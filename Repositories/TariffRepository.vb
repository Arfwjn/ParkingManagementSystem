Imports MySql.Data.MySqlClient
Imports ParkingManagementSystem.Database
Imports ParkingManagementSystem.Models

Namespace Repositories
    ''' <summary>
    ''' Repository TariffRepository menangani akses data (DAL) untuk tabel pengaturan tarif parkir kendaraan (tariffs).
    ''' </summary>
    Public Class TariffRepository
        ''' <summary>
        ''' Mengambil seluruh daftar tarif parkir dalam bentuk List objek Tariff.
        ''' </summary>
        Public Function GetAll() As List(Of Tariff)
            Dim list As New List(Of Tariff)()
            Dim query As String = "SELECT id, vehicle_type, hourly_rate, overnight_rate, created_at, updated_at FROM tariffs ORDER BY vehicle_type ASC"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim item As New Tariff() With {
                                .Id = Convert.ToInt32(reader("id")),
                                .VehicleType = reader("vehicle_type").ToString(),
                                .HourlyRate = Convert.ToDecimal(reader("hourly_rate")),
                                .OvernightRate = Convert.ToDecimal(reader("overnight_rate")),
                                .CreatedAt = Convert.ToDateTime(reader("created_at")),
                                .UpdatedAt = Convert.ToDateTime(reader("updated_at"))
                            }
                            list.Add(item)
                        End While
                    End Using
                End Using
            End Using

            Return list
        End Function

        ''' <summary>
        ''' Mengambil data tarif spesifik berdasarkan tipe kendaraan (contoh: 'Mobil' atau 'Motor').
        ''' </summary>
        Public Function GetByVehicleType(vehicleType As String) As Tariff
            Dim tariff As Tariff = Nothing
            Dim query As String = "SELECT id, vehicle_type, hourly_rate, overnight_rate, created_at, updated_at FROM tariffs WHERE vehicle_type = @vehicle_type LIMIT 1"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@vehicle_type", vehicleType)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            tariff = New Tariff() With {
                                .Id = Convert.ToInt32(reader("id")),
                                .VehicleType = reader("vehicle_type").ToString(),
                                .HourlyRate = Convert.ToDecimal(reader("hourly_rate")),
                                .OvernightRate = Convert.ToDecimal(reader("overnight_rate")),
                                .CreatedAt = Convert.ToDateTime(reader("created_at")),
                                .UpdatedAt = Convert.ToDateTime(reader("updated_at"))
                            }
                        End If
                    End Using
                End Using
            End Using

            Return tariff
        End Function

        ''' <summary>
        ''' Menyimpan atau memperbarui data tarif berdasarkan objek Tariff (ON DUPLICATE KEY UPDATE).
        ''' </summary>
        Public Function SaveOrUpdate(tariff As Tariff) As Boolean
            Dim query As String = "INSERT INTO tariffs (vehicle_type, hourly_rate, overnight_rate) " &
                                 "VALUES (@vehicle_type, @hourly_rate, @overnight_rate) " &
                                 "ON DUPLICATE KEY UPDATE " &
                                 "hourly_rate = VALUES(hourly_rate), " &
                                 "overnight_rate = VALUES(overnight_rate)"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@vehicle_type", tariff.VehicleType)
                    cmd.Parameters.AddWithValue("@hourly_rate", tariff.HourlyRate)
                    cmd.Parameters.AddWithValue("@overnight_rate", tariff.OvernightRate)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menyimpan tarif baru atau memperbarui otomatis (UPSERT) jika jenis kendaraan sudah ada di database.
        ''' Parameter output 'isUpdated' menandakan apakah data diperbarui atau baru dibuat.
        ''' </summary>
        Public Function UpsertTariff(vehicleType As String, hourlyRate As Decimal, overnightRate As Decimal, ByRef isUpdated As Boolean) As Boolean
            Dim checkSql As String = "SELECT COUNT(*) FROM tariffs WHERE LOWER(vehicle_type) = LOWER(@vehicle_type)"

            Dim upsertSql As String = "INSERT INTO tariffs (vehicle_type, hourly_rate, overnight_rate) " &
                                     "VALUES (@vehicle_type, @hourly_rate, @overnight_rate) " &
                                     "ON DUPLICATE KEY UPDATE hourly_rate = @hourly_rate, overnight_rate = @overnight_rate"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()

                Using checkCmd As New MySqlCommand(checkSql, conn)
                    checkCmd.Parameters.AddWithValue("@vehicle_type", vehicleType.Trim())
                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    isUpdated = (count > 0)
                End Using

                Using cmd As New MySqlCommand(upsertSql, conn)
                    cmd.Parameters.AddWithValue("@vehicle_type", vehicleType.Trim())
                    cmd.Parameters.AddWithValue("@hourly_rate", hourlyRate)
                    cmd.Parameters.AddWithValue("@overnight_rate", overnightRate)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Mengambil seluruh data tarif parkir berformat DataTable untuk pengisian komponen DataGridView.
        ''' </summary>
        Public Function GetAllTariffsDataTable() As DataTable
            Dim dt As New DataTable()
            Dim sql As String = "SELECT id AS 'ID', vehicle_type AS 'Jenis Kendaraan', hourly_rate AS 'Tarif Per Jam', overnight_rate AS 'Tarif Menginap' FROM tariffs ORDER BY id ASC"

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