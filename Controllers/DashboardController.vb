Imports System
Imports System.Data
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    Public Class DashboardSummaryData
        Public Property ActiveParkingCount As Integer
        Public Property TodayEntryCount As Integer
        Public Property ActiveCarCount As Integer
        Public Property ActiveMotorcycleCount As Integer
        Public Property TodayRevenue As Decimal
        Public Property AvailableSlots As Integer
        Public Property RecentActivityData As DataTable
    End Class

    Public Class DashboardController
        Private ReadOnly _parkingRepository As ParkingRepository

        Public Const MAX_CAR_CAPACITY As Integer = 50
        Public Const MAX_MOTORCYCLE_CAPACITY As Integer = 100

        Public Sub New()
            _parkingRepository = New ParkingRepository()
        End Sub

        Public Function GetDashboardSummary() As DashboardSummaryData
            Dim summary As New DashboardSummaryData()

            summary.ActiveParkingCount = _parkingRepository.GetActiveParkingCount()
            summary.TodayEntryCount = _parkingRepository.GetTodayEntryCount()
            summary.ActiveCarCount = _parkingRepository.GetActiveCountByType("Mobil")
            summary.ActiveMotorcycleCount = _parkingRepository.GetActiveCountByType("Motor")
            summary.TodayRevenue = _parkingRepository.GetTodayRevenue()

            Dim totalCapacity As Integer = MAX_CAR_CAPACITY + MAX_MOTORCYCLE_CAPACITY
            summary.AvailableSlots = Math.Max(0, totalCapacity - summary.ActiveParkingCount)
            summary.RecentActivityData = _parkingRepository.GetRecentTransactionsDataTable()

            Return summary
        End Function
    End Class
End Namespace