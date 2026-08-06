Imports System

Namespace Models
    ''' <summary>
    ''' Abstract Class Vehicle merupakan kelas induk (base class) untuk semua tipe kendaraan parkir.
    ''' Menerapkan prinsip OOP Abstraction, Encapsulation, dan Polymorphism.
    ''' </summary>
    Public MustInherit Class Vehicle
        ''' <summary>Plat nomor polisi kendaraan.</summary>
        Public Property PlateNumber As String
        ''' <summary>Jenis kendaraan (misal: Mobil / Motor).</summary>
        Public Property VehicleType As String

        ''' <summary>
        ''' Inisialisasi properti dasar kendaraan.
        ''' </summary>
        Protected Sub New(plateNumber As String, vehicleType As String)
            Me.PlateNumber = plateNumber
            Me.VehicleType = vehicleType
        End Sub

        ''' <summary>Menghitung total tarif parkir berdasarkan durasi jam.</summary>
        Public MustOverride Function CalculateFee(durationInHours As Integer) As Decimal
        ''' <summary>Mendapatkan nilai denda tiket hilang untuk jenis kendaraan ini.</summary>
        Public MustOverride Function GetLostTicketFine() As Decimal
        ''' <summary>Menghitung tarif menginap per hari untuk jenis kendaraan ini.</summary>
        Public MustOverride Function GetOvernightFee(days As Integer) As Decimal
        ''' <summary>Mendapatkan batas maksimum tarif harian untuk jenis kendaraan ini.</summary>
        Public MustOverride Function GetMaxDailyFee() As Decimal
    End Class
End Namespace