Namespace Models
    ''' <summary>
    ''' Entity Model Tariff menyimpan acuan harga tarif per jam dan tarif menginap per jenis kendaraan.
    ''' </summary>
    Public Class Tariff
        ''' <summary>ID unik data tarif.</summary>
        Public Property Id As Integer
        ''' <summary>Jenis kendaraan (Mobil / Motor).</summary>
        Public Property VehicleType As String
        ''' <summary>Tarif biaya parkir per jam (Rp).</summary>
        Public Property HourlyRate As Decimal
        ''' <summary>Tarif biaya inap per 24 jam (Rp).</summary>
        Public Property OvernightRate As Decimal
        ''' <summary>Waktu data dibuat.</summary>
        Public Property CreatedAt As DateTime
        ''' <summary>Waktu data diperbarui.</summary>
        Public Property UpdatedAt As DateTime

        ''' <summary>Constructor default.</summary>
        Public Sub New()
        End Sub

        ''' <summary>Constructor dengan parameter nilai awal tarif.</summary>
        Public Sub New(id As Integer, vehicleType As String, hourlyRate As Decimal, overnightRate As Decimal)
            Me.Id = id
            Me.VehicleType = vehicleType
            Me.HourlyRate = hourlyRate
            Me.OvernightRate = overnightRate
        End Sub
    End Class
End Namespace