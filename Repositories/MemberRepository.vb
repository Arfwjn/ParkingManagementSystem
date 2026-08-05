Imports System
Imports System.Collections.Generic
Imports System.Data
Imports MySql.Data.MySqlClient
Imports ParkingManagementSystem.Database
Imports ParkingManagementSystem.Models

Namespace Repositories
    Public Class MemberRepository

        ''' <summary>
        ''' Mencari data member aktif berdasarkan plat nomor (mendukung plat utama & multi-plat)
        ''' </summary>
        Public Function GetMemberWithLevelByPlate(plateNumber As String) As Tuple(Of Member, String, Decimal)
            Dim cleanPlate As String = plateNumber.Trim().ToLower()
            Dim query As String = "SELECT DISTINCT m.id, m.owner_name, m.plate_number, m.level_id, " &
                                 "COALESCE(ml.level_name, m.member_level, 'Non-Member') AS level_name, " &
                                 "COALESCE(ml.discount_percentage, 0.00) AS discount_percentage " &
                                 "FROM members m " &
                                 "LEFT JOIN member_levels ml ON m.level_id = ml.id " &
                                 "LEFT JOIN member_plates mp ON m.id = mp.member_id " &
                                 "WHERE (LOWER(m.plate_number) = @plate OR LOWER(mp.plate_number) = @plate) " &
                                 "  AND (m.status IS NULL OR m.status = 'ACTIVE') " &
                                 "  AND (m.subscription_expires_at IS NULL OR m.subscription_expires_at >= NOW()) LIMIT 1"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@plate", cleanPlate)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim memberItem As New Member() With {
                                .Id = Convert.ToInt32(reader("id")),
                                .OwnerName = reader("owner_name").ToString(),
                                .PlateNumber = reader("plate_number").ToString()
                            }
                            Dim levelName As String = reader("level_name").ToString()
                            Dim discount As Decimal = Convert.ToDecimal(reader("discount_percentage"))
                            Return Tuple.Create(memberItem, levelName, discount)
                        End If
                    End Using
                End Using
            End Using

            Return Nothing
        End Function

        ''' <summary>
        ''' Menghitung jumlah plat nomor terdaftar untuk satu nama pemilik
        ''' </summary>
        Public Function GetPlateCountByOwner(ownerName As String, Optional excludeMemberId As Integer = 0) As Integer
            Dim sql As String = "SELECT COUNT(*) FROM members WHERE LOWER(owner_name) = LOWER(@owner_name) AND id <> @excludeId"
            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@owner_name", ownerName.Trim())
                    cmd.Parameters.AddWithValue("@excludeId", excludeMemberId)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Memeriksa apakah plat nomor sudah terdaftar pada sistem (cek tabel members & member_plates)
        ''' </summary>
        Public Function IsPlateRegistered(plateNumber As String, Optional excludeMemberId As Integer = 0) As Boolean
            Dim cleanPlate As String = plateNumber.Trim().ToLower()
            Dim sql As String = "SELECT COUNT(*) FROM (" &
                               "   SELECT m.id FROM members m WHERE LOWER(m.plate_number) = @plate " &
                               "   UNION " &
                               "   SELECT mp.member_id AS id FROM member_plates mp WHERE LOWER(mp.plate_number) = @plate " &
                               ") AS t WHERE t.id <> @excludeId"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@plate", cleanPlate)
                    cmd.Parameters.AddWithValue("@excludeId", excludeMemberId)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menyimpan member baru lengkap dengan masa aktif (+30 hari) dan pendaftaran multi-plat
        ''' </summary>
        Public Function SaveMember(ownerName As String, plateNumber As String, levelId As Integer) As Boolean
            Return SaveMemberWithPlates(ownerName, New List(Of String) From {plateNumber}, levelId)
        End Function

        Public Function SaveMemberWithPlates(ownerName As String, plateNumbers As List(Of String), levelId As Integer) As Boolean
            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()

                Dim levelName As String = "Bronze"
                Dim getLevelSql As String = "SELECT level_name FROM member_levels WHERE id = @level_id"
                Using cmdLvl As New MySqlCommand(getLevelSql, conn)
                    cmdLvl.Parameters.AddWithValue("@level_id", levelId)
                    Dim res = cmdLvl.ExecuteScalar()
                    If res IsNot Nothing AndAlso res IsNot DBNull.Value Then
                        levelName = res.ToString()
                    End If
                End Using

                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim mainPlate As String = If(plateNumbers.Count > 0, plateNumbers(0).Trim().ToUpper(), "")

                        Dim insertSql As String = "INSERT INTO members (plate_number, owner_name, member_level, level_id, registration_date, subscription_expires_at, status) " &
                                                 "VALUES (@plate_number, @owner_name, @member_level, @level_id, NOW(), DATE_ADD(NOW(), INTERVAL 30 DAY), 'ACTIVE')"

                        Dim newMemberId As Integer = 0
                        Using cmd As New MySqlCommand(insertSql, conn, trans)
                            cmd.Parameters.AddWithValue("@plate_number", mainPlate)
                            cmd.Parameters.AddWithValue("@owner_name", ownerName.Trim())
                            cmd.Parameters.AddWithValue("@member_level", levelName)
                            cmd.Parameters.AddWithValue("@level_id", levelId)
                            cmd.ExecuteNonQuery()
                            newMemberId = CInt(cmd.LastInsertedId)
                        End Using

                        ' Simpan ke tabel relasi member_plates
                        Dim insertPlateSql As String = "INSERT INTO member_plates (member_id, plate_number) VALUES (@member_id, @plate_number)"
                        For Each plate In plateNumbers
                            If Not String.IsNullOrWhiteSpace(plate) Then
                                Using cmdPlate As New MySqlCommand(insertPlateSql, conn, trans)
                                    cmdPlate.Parameters.AddWithValue("@member_id", newMemberId)
                                    cmdPlate.Parameters.AddWithValue("@plate_number", plate.Trim().ToUpper())
                                    cmdPlate.ExecuteNonQuery()
                                End Using
                            End If
                        Next

                        trans.Commit()
                        Return True
                    Catch ex As Exception
                        trans.Rollback()
                        Return False
                    End Try
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Mengambil seluruh data member untuk DataGridView UI dengan alias kolom yang presisi
        ''' </summary>
        Public Function GetAllMembersDataTable() As DataTable
            Dim dt As New DataTable()
            Dim sql As String = "SELECT " &
                               "    m.id AS 'ID', " &
                               "    m.owner_name AS 'Nama Pemilik', " &
                               "    m.level_id AS 'level_id', " &
                               "    COALESCE(ml.level_name, m.member_level, 'Non-Level') AS 'Level', " &
                               "    COALESCE(NULLIF(GROUP_CONCAT(mp.plate_number SEPARATOR ', '), ''), m.plate_number) AS 'Plat Nomor', " &
                               "    m.registration_date AS 'Tanggal Daftar', " &
                               "    m.subscription_expires_at AS 'Masa Aktif', " &
                               "    m.status AS 'Status' " &
                               "FROM members m " &
                               "LEFT JOIN member_levels ml ON m.level_id = ml.id " &
                               "LEFT JOIN member_plates mp ON m.id = mp.member_id " &
                               "GROUP BY m.id, m.owner_name, m.level_id, m.member_level, ml.level_name, m.plate_number, m.registration_date, m.subscription_expires_at, m.status " &
                               "ORDER BY m.id DESC"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        End Function

        ''' <summary>
        ''' Memperpanjang masa aktif keanggotaan member selama 1 bulan dari tanggal kedaluwarsa saat ini (atau dari waktu sekarang jika sudah expired)
        ''' </summary>
        Public Function RenewSubscription(memberId As Integer) As Boolean
            Dim sql As String = "UPDATE members " &
                       "SET subscription_expires_at = DATE_ADD(IF(subscription_expires_at > NOW(), subscription_expires_at, NOW()), INTERVAL 1 MONTH), " &
                       "status = 'ACTIVE' " &
                       "WHERE id = @id"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", memberId)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Memperbarui data profil member dan sinkronisasi daftar plat nomor tanpa mengubah log pembayaran
        ''' </summary>
        Public Function UpdateMemberDetails(memberId As Integer, ownerName As String, levelId As Integer, plateNumbers As List(Of String)) As Boolean
            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()

                Dim levelName As String = "Bronze"
                Dim getLevelSql As String = "SELECT level_name FROM member_levels WHERE id = @level_id"
                Using cmdLvl As New MySqlCommand(getLevelSql, conn)
                    cmdLvl.Parameters.AddWithValue("@level_id", levelId)
                    Dim res = cmdLvl.ExecuteScalar()
                    If res IsNot Nothing AndAlso res IsNot DBNull.Value Then
                        levelName = res.ToString()
                    End If
                End Using

                Using trans As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim mainPlate As String = If(plateNumbers.Count > 0, plateNumbers(0).Trim().ToUpper(), "")
                        Dim updateSql As String = "UPDATE members SET owner_name = @owner_name, level_id = @level_id, member_level = @member_level, plate_number = @plate_number WHERE id = @id"

                        Using cmd As New MySqlCommand(updateSql, conn, trans)
                            cmd.Parameters.AddWithValue("@owner_name", ownerName.Trim())
                            cmd.Parameters.AddWithValue("@level_id", levelId)
                            cmd.Parameters.AddWithValue("@member_level", levelName)
                            cmd.Parameters.AddWithValue("@plate_number", mainPlate)
                            cmd.Parameters.AddWithValue("@id", memberId)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Hapus relasi plat lama & ganti dengan yang baru
                        Dim deletePlatesSql As String = "DELETE FROM member_plates WHERE member_id = @member_id"
                        Using cmdDel As New MySqlCommand(deletePlatesSql, conn, trans)
                            cmdDel.Parameters.AddWithValue("@member_id", memberId)
                            cmdDel.ExecuteNonQuery()
                        End Using

                        Dim insertPlateSql As String = "INSERT INTO member_plates (member_id, plate_number) VALUES (@member_id, @plate_number)"
                        For Each plate In plateNumbers
                            If Not String.IsNullOrWhiteSpace(plate) Then
                                Using cmdIns As New MySqlCommand(insertPlateSql, conn, trans)
                                    cmdIns.Parameters.AddWithValue("@member_id", memberId)
                                    cmdIns.Parameters.AddWithValue("@plate_number", plate.Trim().ToUpper())
                                    cmdIns.ExecuteNonQuery()
                                End Using
                            End If
                        Next

                        trans.Commit()
                        Return True
                    Catch ex As Exception
                        trans.Rollback()
                        Return False
                    End Try
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menghapus data member berdasarkan ID
        ''' </summary>
        Public Function DeleteMember(id As Integer) As Boolean
            Dim sql As String = "DELETE FROM members WHERE id = @id"
            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menyimpan log transaksi pembayaran pendaftaran / perpanjangan member
        ''' </summary>
        Public Function InsertMemberPayment(memberId As Integer, paymentType As String, amount As Decimal, paymentMethod As String, referenceNumber As String, userId As Nullable(Of Integer)) As Boolean
            Dim sql As String = "INSERT INTO member_payments (member_id, payment_type, amount, payment_method, reference_number, payment_date, user_id) " &
                               "VALUES (@member_id, @payment_type, @amount, @payment_method, @reference_number, NOW(), @user_id)"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@member_id", memberId)
                    cmd.Parameters.AddWithValue("@payment_type", paymentType)
                    cmd.Parameters.AddWithValue("@amount", amount)
                    cmd.Parameters.AddWithValue("@payment_method", paymentMethod)
                    cmd.Parameters.AddWithValue("@reference_number", If(String.IsNullOrEmpty(referenceNumber), DBNull.Value, referenceNumber))
                    cmd.Parameters.AddWithValue("@user_id", If(userId.HasValue, userId.Value, DBNull.Value))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function
    End Class
End Namespace