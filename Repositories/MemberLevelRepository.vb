Imports MySql.Data.MySqlClient
Imports ParkingManagementSystem.Database
Imports ParkingManagementSystem.Models

Namespace Repositories
    ''' <summary>
    ''' Repository MemberLevelRepository menangani operasi basis data (DAL) untuk tabel tingkatan keanggotaan (member_levels).
    ''' </summary>
    Public Class MemberLevelRepository
        ''' <summary>
        ''' Mengambil seluruh daftar tingkatan member dalam bentuk List objek MemberLevel.
        ''' </summary>
        Public Function GetAll() As List(Of MemberLevel)
            Dim list As New List(Of MemberLevel)()
            Dim sql As String = "SELECT id, level_name, discount_percentage, monthly_fee, description FROM member_levels ORDER BY id ASC"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            list.Add(New MemberLevel() With {
                                .Id = Convert.ToInt32(reader("id")),
                                .LevelName = reader("level_name").ToString(),
                                .DiscountPercentage = Convert.ToDecimal(reader("discount_percentage")),
                                .MonthlyFee = Convert.ToDecimal(reader("monthly_fee")),
                                .Description = If(reader("description") IsNot DBNull.Value, reader("description").ToString(), String.Empty)
                            })
                        End While
                    End Using
                End Using
            End Using
            Return list
        End Function

        ''' <summary>
        ''' Menyimpan data level member baru ke database.
        ''' </summary>
        Public Function Save(level As MemberLevel) As Boolean
            Dim sql As String = "INSERT INTO member_levels (level_name, discount_percentage, monthly_fee, description) " &
                               "VALUES (@level_name, @discount_percentage, @monthly_fee, @description)"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@level_name", level.LevelName.Trim())
                    cmd.Parameters.AddWithValue("@discount_percentage", level.DiscountPercentage)
                    cmd.Parameters.AddWithValue("@monthly_fee", level.MonthlyFee)
                    cmd.Parameters.AddWithValue("@description", If(String.IsNullOrWhiteSpace(level.Description), DBNull.Value, level.Description.Trim()))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Memperbarui data level member yang sudah ada berdasarkan ID.
        ''' </summary>
        Public Function Update(level As MemberLevel) As Boolean
            Dim sql As String = "UPDATE member_levels SET level_name = @level_name, discount_percentage = @discount_percentage, " &
                               "monthly_fee = @monthly_fee, description = @description WHERE id = @id"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@level_name", level.LevelName.Trim())
                    cmd.Parameters.AddWithValue("@discount_percentage", level.DiscountPercentage)
                    cmd.Parameters.AddWithValue("@monthly_fee", level.MonthlyFee)
                    cmd.Parameters.AddWithValue("@description", If(String.IsNullOrWhiteSpace(level.Description), DBNull.Value, level.Description.Trim()))
                    cmd.Parameters.AddWithValue("@id", level.Id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menghapus data level member dari database berdasarkan ID.
        ''' </summary>
        Public Function Delete(id As Integer) As Boolean
            Dim sql As String = "DELETE FROM member_levels WHERE id = @id"
            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menyimpan atau memperbarui data level member secara otomatis (UPSERT MySQL).
        ''' Parameter outputs 'isUpdated' akan bernilai True jika data yang ada diperbarui.
        ''' </summary>
        Public Function UpsertMemberLevel(levelName As String, discountPercentage As Decimal, monthlyFee As Decimal, description As String, ByRef isUpdated As Boolean) As Boolean
            Dim checkSql As String = "SELECT COUNT(*) FROM member_levels WHERE LOWER(level_name) = LOWER(@level_name)"
            Dim upsertSql As String = "INSERT INTO member_levels (level_name, discount_percentage, monthly_fee, description) " &
                                     "VALUES (@level_name, @discount_percentage, @monthly_fee, @description) " &
                                     "ON DUPLICATE KEY UPDATE discount_percentage = @discount_percentage, monthly_fee = @monthly_fee, description = @description"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()

                Using checkCmd As New MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@level_name", levelName.Trim())
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    isUpdated = (count > 0)
                End Using

                Using cmd As New MySqlCommand(upsertSql, conn)
                    cmd.Parameters.AddWithValue("@level_name", levelName.Trim())
                    cmd.Parameters.AddWithValue("@discount_percentage", discountPercentage)
                    cmd.Parameters.AddWithValue("@monthly_fee", monthlyFee)
                    cmd.Parameters.AddWithValue("@description", If(String.IsNullOrEmpty(description), DBNull.Value, description.Trim()))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Mengambil seluruh data level member berformat DataTable untuk pengisian komponen UI DataGridView.
        ''' </summary>
        Public Function GetAllMemberLevelsDataTable() As DataTable
            Dim dt As New DataTable()
            Dim sql As String = "SELECT id AS 'ID', level_name AS 'Nama Level', discount_percentage AS 'Diskon (%)', monthly_fee AS 'Iuran Bulanan', description AS 'Deskripsi' FROM member_levels ORDER BY discount_percentage ASC"

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
    End Class
End Namespace