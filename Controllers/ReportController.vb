Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    Public Class ReportController
        Private ReadOnly _parkingRepository As ParkingRepository

        Sub New()
            _parkingRepository = New ParkingRepository()
        End Sub

        Public Function GetDailyReportData(selectedDate As DateTime, ByRef summary As ParkingReportSummary) As List(Of Parking)
            Dim list As List(Of Parking) = _parkingRepository.GetDailyReport(selectedDate)
            summary = CalculateSummary(list)
            Return list
        End Function

        Public Function GetWeeklyReportData(startDate As DateTime, endDate As DateTime, ByRef summary As ParkingReportSummary) As List(Of Parking)
            Dim list As List(Of Parking) = _parkingRepository.GetWeeklyReport(startDate, endDate)
            summary = CalculateSummary(list)
            Return list
        End Function

        Public Function GetMonthlyReportData(month As Integer, year As Integer, ByRef summary As ParkingReportSummary) As List(Of Parking)
            Dim list As List(Of Parking) = _parkingRepository.GetMonthlyReport(month, year)
            summary = CalculateSummary(list)
            Return list
        End Function

        ''' <summary>
        ''' Mengkalkulasi akumulasi ringkasan statistik laporan (Perbaikan LINQ Count)
        ''' </summary>
        Private Function CalculateSummary(transactions As List(Of Parking)) As ParkingReportSummary
            Dim summary As New ParkingReportSummary()

            If transactions Is Nothing OrElse transactions.Count = 0 Then
                Return summary
            End If

            summary.TotalTransactions = transactions.Count
            summary.TotalRevenue = transactions.Sum(Function(x) x.TotalPayment)

            ' PERBAIKAN: Gunakan .Where(...).Count agar tidak bentrok dengan properti List.Count
            summary.TotalCar = transactions.Where(Function(x) x.VehicleType.Equals("Mobil", StringComparison.OrdinalIgnoreCase)).Count()
            summary.TotalMotorcycle = transactions.Where(Function(x) x.VehicleType.Equals("Motor", StringComparison.OrdinalIgnoreCase)).Count()

            ' Agregasi Pendapatan Berdasarkan Metode Pembayaran
            summary.TotalCashRevenue = transactions.
                Where(Function(x) x.PaymentMethod.Equals("Tunai", StringComparison.OrdinalIgnoreCase)).
                Sum(Function(x) x.TotalPayment)

            summary.TotalQrisRevenue = transactions.
                Where(Function(x) x.PaymentMethod.Equals("QRIS", StringComparison.OrdinalIgnoreCase)).
                Sum(Function(x) x.TotalPayment)

            summary.TotalDebitRevenue = transactions.
                Where(Function(x) x.PaymentMethod.StartsWith("Debit", StringComparison.OrdinalIgnoreCase) OrElse
                                  x.PaymentMethod.StartsWith("Transfer", StringComparison.OrdinalIgnoreCase)).
                Sum(Function(x) x.TotalPayment)

            Return summary
        End Function
    End Class
End Namespace