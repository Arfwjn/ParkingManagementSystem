Imports System

Namespace Models
    ''' <summary>
    ''' Abstract Class sebagai Induk dari semua tipe kendaraan (Abstraction & Inheritance)
    ''' </summary>
    Public MustInherit Class Vehicle
        ' Encapsulation: Properties
        Public Property PlateNumber As String
        Public Property VehicleType As String

        Protected Sub New(plateNumber As String, vehicleType As String)
            Me.PlateNumber = plateNumber
            Me.VehicleType = vehicleType
        End Sub

        ' Polymorphism: Abstract Methods yang wajib di-override oleh class turunan
        Public MustOverride Function CalculateFee(durationInHours As Integer) As Decimal
        Public MustOverride Function GetLostTicketFine() As Decimal
        Public MustOverride Function GetOvernightFee(days As Integer) As Decimal
        Public MustOverride Function GetMaxDailyFee() As Decimal
    End Class
End Namespace