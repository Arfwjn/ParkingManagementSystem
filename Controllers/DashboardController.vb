Imports System
Imports System.Data
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    ''' <summary>
    ''' DTO (Data Transfer Object) DashboardSummaryData menampung seluruh ringkasan metrik statistik untuk tampilan Dashboard utama.
    ''' </summary>
    Public Class DashboardSummaryData
        ''' <summary>Total kendaraan yang sedang parkir saat ini.</summary>
        Public Property ActiveParkingCount As Integer
        ''' <summary>Total kendaraan yang masuk pada hari ini.</summary>
        Public Property TodayEntryCount As Integer
        ''' <summary>Jumlah mobil yang sedang parkir aktif.</summary>
        Public Property ActiveCarCount As Integer
        ''' <summary>Jumlah motor yang sedang parkir aktif.</summary>
        Public Property ActiveMotorcycleCount As Integer
        ''' <summary>Total pendapatan parkir lunas pada hari ini.</summary>
        Public Property TodayRevenue As Decimal
        ''' <summary>Sisa kuota slot area parkir yang masih tersedia.</summary>
        Public Property AvailableSlots As Integer
        ''' <summary>DataTable aktivitas 10 transaksi parkir terbaru.</summary>
        Public Property RecentActivityData As DataTable
    End Class

    ''' <summary>
    ''' Controller DashboardController mengolah logika agregasi data ringkasan statistik dan ketersediaan kapasitas area parkir.
    ''' </summary>
    Public Class DashboardController
        Private ReadOnly _parkingRepository As ParkingRepository

        ''' <summary>Kapasitas maksimum untuk area parkir mobil.</summary>
        Public Const MAX_CAR_CAPACITY As Integer = 50
        ''' <summary>Kapasitas maksimum untuk area parkir sepeda motor.</summary>
        Public Const MAX_MOTORCYCLE_CAPACITY As Integer = 100

        ''' <summary>
        ''' Inisialisasi controller dan instansiasi repository parkir.
        ''' </summary>
        Public Sub New()
            _parkingRepository = New ParkingRepository()
        End Sub

        ''' <summary>
        ''' Mengambil seluruh data statistik ringkasan dashboard secara real-time dari database.
        ''' </summary>
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