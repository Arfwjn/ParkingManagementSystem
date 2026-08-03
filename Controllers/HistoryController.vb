Imports System
Imports System.Data
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    Public Class HistoryController
        Private ReadOnly _parkingRepository As ParkingRepository

        Public Sub New()
            _parkingRepository = New ParkingRepository()
        End Sub

        ''' <summary>
        ''' Memuat data riwayat transaksi berdasarkan filter yang ditentukan
        ''' </summary>
        Public Function FetchHistory(startDate As DateTime, endDate As DateTime, vehicleType As String, plateSearch As String, ByRef totalRevenue As Decimal, ByRef totalRecords As Integer) As DataTable
            Dim dt As DataTable = _parkingRepository.GetParkingHistoryDataTable(startDate, endDate, vehicleType, plateSearch)

            totalRecords = dt.Rows.Count
            totalRevenue = 0

            For Each row As DataRow In dt.Rows
                If Not IsDBNull(row("Total Bayar")) Then
                    totalRevenue += Convert.ToDecimal(row("Total Bayar"))
                End If
            Next

            Return dt
        End Function
    End Class
End Namespace