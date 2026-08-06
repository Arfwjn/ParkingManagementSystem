Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    ''' <summary>
    ''' Controller TariffController mengelola validasi bisnis dan pembaruan pengaturan tarif per jam dan tarif menginap kendaraan.
    ''' </summary>
    Public Class TariffController
        Private ReadOnly _tariffRepository As TariffRepository

        ''' <summary>
        ''' Constructor untuk menginisialisasi repository tarif.
        ''' </summary>
        Public Sub New()
            _tariffRepository = New TariffRepository()
        End Sub

        ''' <summary>
        ''' Mengambil seluruh daftar pengaturan tarif kendaraan.
        ''' </summary>
        Public Function GetAllTariffs() As List(Of Tariff)
            Return _tariffRepository.GetAll()
        End Function

        ''' <summary>
        ''' Memvalidasi dan memperbarui tarif per jam serta tarif menginap untuk jenis kendaraan tertentu.
        ''' </summary>
        Public Function UpdateTariff(vehicleType As String, hourlyRate As Decimal, overnightRate As Decimal, ByRef errorMessage As String) As Boolean
            ' Validasi tipe kendaraan dan batasan angka non-negatif
            If String.IsNullOrWhiteSpace(vehicleType) Then
                errorMessage = "Tipe kendaraan wajib diisi."
                Return False
            End If

            If hourlyRate < 0 OrElse overnightRate < 0 Then
                errorMessage = "Harga tarif tidak boleh bernilai negatif."
                Return False
            End If

            Dim item As New Tariff() With {
                .VehicleType = vehicleType.Trim(),
                .HourlyRate = hourlyRate,
                .OvernightRate = overnightRate
            }

            ' Menyimpan atau memperbarui data tarif di database
            Dim success As Boolean = _tariffRepository.SaveOrUpdate(item)
            If Not success Then
                errorMessage = "Gagal memperbarui data tarif di database."
                Return False
            End If

            Return True
        End Function
    End Class
End Namespace