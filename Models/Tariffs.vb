Namespace Models
    Public Class Tariff
        Public Property Id As Integer
        Public Property VehicleType As String
        Public Property HourlyRate As Decimal
        Public Property OvernightRate As Decimal
        Public Property CreatedAt As DateTime
        Public Property UpdatedAt As DateTime

        Public Sub New()
        End Sub

        Public Sub New(id As Integer, vehicleType As String, hourlyRate As Decimal, overnightRate As Decimal)
            Me.Id = id
            Me.VehicleType = vehicleType
            Me.HourlyRate = hourlyRate
            Me.OvernightRate = overnightRate
        End Sub
    End Class
End Namespace