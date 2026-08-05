Imports MySql.Data.MySqlClient
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Database

Namespace Repositories
    Public Class ParkingRepository
        ''' <summary>
        ''' Memeriksa apakah nomor polisi masih aktif berada di dalam area parkir
        ''' </summary>
        Public Function IsPlateActive(plateNumber As String) As Boolean
            Dim sql As String = "SELECT COUNT(*) FROM parking WHERE plate_number = @plateNumber AND status IN ('IN', 'OVERNIGHT')"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@plateNumber", plateNumber)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menghitung jumlah kendaraan yang sedang aktif parkir berdasarkan jenisnya
        ''' </summary>
        Public Function GetActiveCountByType(vehicleType As String) As Integer
            Dim sql As String = "SELECT COUNT(*) FROM parking WHERE vehicle_type = @vehicleType AND status IN ('IN', 'OVERNIGHT')"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@vehicleType", vehicleType)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menyimpan transaksi kendaraan masuk baru
        ''' </summary>
        Public Function InsertEntry(parking As Parking) As Boolean
            Dim sql As String = "INSERT INTO parking (plate_number, vehicle_type, entry_time, status, payment_status, user_id) " &
                               "VALUES (@plateNumber, @vehicleType, @entryTime, 'IN', 'Belum Dibayar', @userId)"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@plateNumber", parking.PlateNumber)
                    cmd.Parameters.AddWithValue("@vehicleType", parking.VehicleType)
                    cmd.Parameters.AddWithValue("@entryTime", parking.EntryTime)
                    cmd.Parameters.AddWithValue("@userId", If(parking.UserId.HasValue, CObj(parking.UserId.Value), DBNull.Value))

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Mencari transaksi parkir yang sedang aktif berdasarkan nomor polisi
        ''' </summary>
        Public Function GetActiveParkingByPlate(plateNumber As String) As Parking
            Dim sql As String = "SELECT * FROM parking WHERE plate_number = @plateNumber AND status IN ('IN', 'OVERNIGHT') ORDER BY id DESC LIMIT 1"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@plateNumber", plateNumber)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return New Parking With {
                                .Id = Convert.ToInt32(reader("id")),
                                .PlateNumber = reader("plate_number").ToString(),
                                .VehicleType = reader("vehicle_type").ToString(),
                                .EntryTime = Convert.ToDateTime(reader("entry_time")),
                                .Status = reader("status").ToString()
                            }
                        End If
                    End Using
                End Using
            End Using
            Return Nothing
        End Function

        ''' <summary>
        ''' Memperbarui transaksi parkir saat kendaraan keluar (Check-Out & Pembayaran)
        ''' </summary>
        Public Function UpdateExitPayment(p As Parking) As Boolean
            Dim sql As String = "UPDATE parking SET " &
                               "exit_time = @exitTime, " &
                               "duration = @duration, " &
                               "parking_fee = @parkingFee, " &
                               "additional_fee = @additionalFee, " &
                               "overnight_fee = @overnightFee, " &
                               "lost_ticket_fine = @lostTicketFine, " &
                               "discount = @discount, " &
                               "total_payment = @totalPayment, " &
                               "payment_method = @paymentMethod, " &
                               "reference_number = @referenceNumber, " &
                               "payment_status = 'Lunas', " &
                               "status = 'OUT' " &
                               "WHERE id = @id"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@exitTime", p.ExitTime)
                    cmd.Parameters.AddWithValue("@duration", p.Duration)
                    cmd.Parameters.AddWithValue("@parkingFee", p.ParkingFee)
                    cmd.Parameters.AddWithValue("@additionalFee", p.AdditionalFee)
                    cmd.Parameters.AddWithValue("@overnightFee", p.OvernightFee)
                    cmd.Parameters.AddWithValue("@lostTicketFine", p.LostTicketFine)
                    cmd.Parameters.AddWithValue("@discount", p.Discount)
                    cmd.Parameters.AddWithValue("@totalPayment", p.TotalPayment)
                    cmd.Parameters.AddWithValue("@paymentMethod", p.PaymentMethod)
                    cmd.Parameters.AddWithValue("@referenceNumber", If(String.IsNullOrWhiteSpace(p.ReferenceNumber), DBNull.Value, CObj(p.ReferenceNumber)))
                    cmd.Parameters.AddWithValue("@id", p.Id)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Mengambil daftar seluruh plat nomor aktif untuk fitur AutoComplete Suggestion
        ''' </summary>
        Public Function GetActivePlateNumbers() As List(Of String)
            Dim list As New List(Of String)()
            Dim sql As String = "SELECT plate_number FROM parking WHERE status IN ('IN', 'OVERNIGHT') ORDER BY plate_number ASC"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            list.Add(reader("plate_number").ToString())
                        End While
                    End Using
                End Using
            End Using
            Return list
        End Function

        ''' <summary>
        ''' Mengambil data tabular kendaraan yang sedang berada di dalam parkiran
        ''' </summary>
        Public Function GetActiveParkingDataTable() As DataTable
            Dim dt As New DataTable()
            Dim sql As String = "SELECT id AS 'ID', plate_number AS 'Nomor Polisi', vehicle_type AS 'Jenis Kendaraan', " &
                               "entry_time AS 'Waktu Masuk', status AS 'Status' " &
                               "FROM parking WHERE status IN ('IN', 'OVERNIGHT') ORDER BY entry_time DESC"

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
        ''' Mengambil data riwayat transaksi parkir yang sudah selesai (OUT) berdasarkan filter
        ''' </summary>
        Public Function GetParkingHistoryDataTable(startDate As DateTime, endDate As DateTime, vehicleType As String, plateSearch As String) As DataTable
            Dim dt As New DataTable()
            Dim sql As String = "SELECT id AS 'ID', plate_number AS 'Nomor Polisi', vehicle_type AS 'Jenis', " &
                               "entry_time AS 'Waktu Masuk', exit_time AS 'Waktu Keluar', duration AS 'Durasi (Jam)', " &
                               "parking_fee AS 'Tarif Parkir', overnight_fee AS 'Biaya Menginap', lost_ticket_fine AS 'Denda', " &
                               "discount AS 'Diskon', total_payment AS 'Total Bayar', payment_method AS 'Metode', " &
                               "COALESCE(reference_number, '-') AS 'Ref / No. Kartu' " &
                               "FROM parking WHERE status = 'OUT' " &
                               "AND entry_time BETWEEN @startDate AND @endDate "

            If Not String.IsNullOrEmpty(vehicleType) AndAlso Not vehicleType.Equals("Semua", StringComparison.OrdinalIgnoreCase) Then
                sql &= "AND vehicle_type = @vehicleType "
            End If

            If Not String.IsNullOrWhiteSpace(plateSearch) Then
                sql &= "AND plate_number LIKE @plateSearch "
            End If

            sql &= "ORDER BY exit_time DESC"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@startDate", startDate.Date)
                    cmd.Parameters.AddWithValue("@endDate", endDate.Date.AddDays(1).AddTicks(-1))

                    If Not String.IsNullOrEmpty(vehicleType) AndAlso Not vehicleType.Equals("Semua", StringComparison.OrdinalIgnoreCase) Then
                        cmd.Parameters.AddWithValue("@vehicleType", vehicleType)
                    End If

                    If Not String.IsNullOrWhiteSpace(plateSearch) Then
                        cmd.Parameters.AddWithValue("@plateSearch", $"%{plateSearch.Trim()}%")
                    End If

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        End Function

        ''' <summary>
        ''' Menghitung jumlah total kendaraan yang sedang aktif parkir (Status IN / OVERNIGHT)
        ''' </summary>
        Public Function GetActiveParkingCount() As Integer
            Dim sql As String = "SELECT COUNT(*) FROM parking WHERE status IN ('IN', 'OVERNIGHT')"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menghitung jumlah total kendaraan yang masuk pada hari ini
        ''' </summary>
        Public Function GetTodayEntryCount() As Integer
            Dim sql As String = "SELECT COUNT(*) FROM parking WHERE DATE(entry_time) = CURDATE()"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menghitung total pendapatan dari transaksi parkir lunas pada hari ini
        ''' </summary>
        Public Function GetTodayRevenue() As Decimal
            Dim sql As String = "SELECT COALESCE(SUM(total_payment), 0) FROM parking WHERE DATE(exit_time) = CURDATE() AND payment_status = 'Lunas'"
            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Return Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Mengambil 10 transaksi parkir terkini (masuk atau keluar) untuk tabel monitoring dashboard
        ''' </summary>
        Public Function GetRecentTransactionsDataTable() As DataTable
            Dim dt As New DataTable()
            Dim sql As String = "SELECT id AS 'ID', plate_number AS 'Nomor Polisi', vehicle_type AS 'Jenis', " &
                               "entry_time AS 'Waktu Masuk', exit_time AS 'Waktu Keluar', status AS 'Status', " &
                               "total_payment AS 'Total Bayar' " &
                               "FROM parking ORDER BY COALESCE(exit_time, entry_time) DESC LIMIT 10"

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
        ''' Memperbarui data transaksi parkir keluar termasuk metode dan nomor referensi pembayaran
        ''' </summary>
        Public Function ProcessExit(parkingData As Parking) As Boolean
            Dim query As String = "UPDATE parking SET " &
                                  "exit_time = @exitTime, " &
                                  "duration = @duration, " &
                                  "parking_fee = @parkingFee, " &
                                  "additional_fee = @additionalFee, " &
                                  "overnight_fee = @overnightFee, " &
                                  "lost_ticket_fine = @lostTicketFine, " &
                                  "discount = @discount, " &
                                  "total_payment = @totalPayment, " &
                                  "payment_method = @paymentMethod, " &
                                  "reference_number = @referenceNumber, " &
                                  "payment_status = 'Lunas', " &
                                  "status = 'OUT', " &
                                  "user_id = @userId, " &
                                  "updated_at = CURRENT_TIMESTAMP " &
                                  "WHERE id = @id AND status != 'OUT'"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                Try
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@exitTime", parkingData.ExitTime)
                        cmd.Parameters.AddWithValue("@duration", parkingData.Duration)
                        cmd.Parameters.AddWithValue("@parkingFee", parkingData.ParkingFee)
                        cmd.Parameters.AddWithValue("@additionalFee", parkingData.AdditionalFee)
                        cmd.Parameters.AddWithValue("@overnightFee", parkingData.OvernightFee)
                        cmd.Parameters.AddWithValue("@lostTicketFine", parkingData.LostTicketFine)
                        cmd.Parameters.AddWithValue("@discount", parkingData.Discount)
                        cmd.Parameters.AddWithValue("@totalPayment", parkingData.TotalPayment)
                        cmd.Parameters.AddWithValue("@paymentMethod", parkingData.PaymentMethod)
                        cmd.Parameters.AddWithValue("@referenceNumber", If(String.IsNullOrWhiteSpace(parkingData.ReferenceNumber), DBNull.Value, parkingData.ReferenceNumber))
                        cmd.Parameters.AddWithValue("@userId", If(parkingData.UserId.HasValue, parkingData.UserId.Value, DBNull.Value))
                        cmd.Parameters.AddWithValue("@id", parkingData.Id)

                        Return cmd.ExecuteNonQuery() > 0
                    End Using
                Catch ex As Exception
                    Throw New Exception("Gagal menyimpan transaksi keluar: " & ex.Message)
                End Try
            End Using
        End Function

        ''' <summary>
        ''' Mengambil data transaksi parkir keluar berdasarkan tanggal tertentu (Harian)
        ''' </summary>
        Public Function GetDailyReport(selectedDate As DateTime) As List(Of Parking)
            Dim query As String = "SELECT id, plate_number, vehicle_type, entry_time, exit_time, duration, " &
                                  "parking_fee, additional_fee, overnight_fee, lost_ticket_fine, discount, total_payment, " &
                                  "payment_method, reference_number, user_id " &
                                  "FROM parking WHERE DATE(exit_time) = @selectedDate AND status = 'OUT' " &
                                  "ORDER BY exit_time DESC"

            Dim params As New Dictionary(Of String, Object) From {
                {"@selectedDate", selectedDate.ToString("yyyy-MM-dd")}
            }

            Return FetchReportData(query, params)
        End Function

        ''' <summary>
        ''' Mengambil data transaksi parkir keluar berdasarkan rentang tanggal (Mingguan / Custom)
        ''' </summary>
        Public Function GetWeeklyReport(startDate As DateTime, endDate As DateTime) As List(Of Parking)
            Dim query As String = "SELECT id, plate_number, vehicle_type, entry_time, exit_time, duration, " &
                                  "parking_fee, additional_fee, overnight_fee, lost_ticket_fine, discount, total_payment, " &
                                  "payment_method, reference_number, user_id " &
                                  "FROM parking WHERE DATE(exit_time) BETWEEN @startDate AND @endDate AND status = 'OUT' " &
                                  "ORDER BY exit_time DESC"

            Dim params As New Dictionary(Of String, Object) From {
                {"@startDate", startDate.ToString("yyyy-MM-dd")},
                {"@endDate", endDate.ToString("yyyy-MM-dd")}
            }

            Return FetchReportData(query, params)
        End Function

        ''' <summary>
        ''' Mengambil data transaksi parkir keluar berdasarkan Bulan dan Tahun (Bulanan)
        ''' </summary>
        Public Function GetMonthlyReport(month As Integer, year As Integer) As List(Of Parking)
            Dim query As String = "SELECT id, plate_number, vehicle_type, entry_time, exit_time, duration, " &
                                  "parking_fee, additional_fee, overnight_fee, lost_ticket_fine, discount, total_payment, " &
                                  "payment_method, reference_number, user_id " &
                                  "FROM parking WHERE MONTH(exit_time) = @month AND YEAR(exit_time) = @year AND status = 'OUT' " &
                                  "ORDER BY exit_time DESC"

            Dim params As New Dictionary(Of String, Object) From {
                {"@month", month},
                {"@year", year}
            }

            Return FetchReportData(query, params)
        End Function

        ''' <summary>
        ''' Helper private untuk mengeksekusi query laporan dan memetakan hasilnya ke List(Of Parking)
        ''' </summary>
        Private Function FetchReportData(query As String, parameters As Dictionary(Of String, Object)) As List(Of Parking)
            Dim reportList As New List(Of Parking)()

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                Try
                    conn.Open()
                    Using cmd As New MySqlCommand(query, conn)
                        For Each param In parameters
                            cmd.Parameters.AddWithValue(param.Key, param.Value)
                        Next

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                Dim item As New Parking() With {
                                    .Id = Convert.ToInt64(reader("id")),
                                    .PlateNumber = reader("plate_number").ToString(),
                                    .VehicleType = reader("vehicle_type").ToString(),
                                    .EntryTime = Convert.ToDateTime(reader("entry_time")),
                                    .ExitTime = Convert.ToDateTime(reader("exit_time")),
                                    .Duration = Convert.ToInt32(reader("duration")),
                                    .ParkingFee = Convert.ToDecimal(reader("parking_fee")),
                                    .AdditionalFee = Convert.ToDecimal(reader("additional_fee")),
                                    .OvernightFee = Convert.ToDecimal(reader("overnight_fee")),
                                    .LostTicketFine = Convert.ToDecimal(reader("lost_ticket_fine")),
                                    .Discount = Convert.ToDecimal(reader("discount")),
                                    .TotalPayment = Convert.ToDecimal(reader("total_payment")),
                                    .PaymentMethod = If(IsDBNull(reader("payment_method")), "Tunai", reader("payment_method").ToString()),
                                    .ReferenceNumber = If(IsDBNull(reader("reference_number")), "-", reader("reference_number").ToString())
                                }
                                reportList.Add(item)
                            End While
                        End Using
                    End Using
                Catch ex As Exception
                    Throw New Exception("Gagal memuat data laporan parkir: " & ex.Message)
                End Try
            End Using

            Return reportList
        End Function
    End Class
End Namespace