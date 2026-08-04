Imports System
Imports ParkingManagementSystem.Helpers
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    Public Class ParkingController
        Private ReadOnly _parkingRepository As ParkingRepository

        ' Konfigurasi Batas Kapasitas Parkir (Business Rules 5.9)
        Public Const MAX_CAR_CAPACITY As Integer = 50
        Public Const MAX_MOTORCYCLE_CAPACITY As Integer = 100

        Public Sub New()
            _parkingRepository = New ParkingRepository()
        End Sub

        ''' <summary>
        ''' Memproses registrasi kendaraan masuk dengan validasi kapasitas dan duplikasi
        ''' </summary>
        Public Function RegisterEntry(plateNumber As String, vehicleType As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            ' 1. Validasi Input Dasar
            If String.IsNullOrWhiteSpace(plateNumber) Then
                errorMessage = "Nomor Polisi wajib diisi."
                Return False
            End If

            If String.IsNullOrWhiteSpace(vehicleType) OrElse (vehicleType <> "Mobil" AndAlso vehicleType <> "Motor") Then
                errorMessage = "Pilih jenis kendaraan yang valid (Mobil / Motor)."
                Return False
            End If

            Dim cleanPlate As String = plateNumber.Trim().ToUpper()

            ' 2. Validasi Nomor Polisi Duplikat (Business Rules 5.10)
            If _parkingRepository.IsPlateActive(cleanPlate) Then
                errorMessage = $"Kendaraan dengan nomor polisi '{cleanPlate}' sudah berada di area parkir."
                Return False
            End If

            ' 3. Validasi Kapasitas Parkir (Business Rules 5.9)
            Dim activeCount As Integer = _parkingRepository.GetActiveCountByType(vehicleType)
            Dim maxCapacity As Integer = If(vehicleType = "Mobil", MAX_CAR_CAPACITY, MAX_MOTORCYCLE_CAPACITY)

            If activeCount >= maxCapacity Then
                errorMessage = "Parkiran penuh." & vbCrLf & "Silakan menunggu hingga tersedia slot parkir."
                Return False
            End If

            ' 4. Eksekusi Simpan Data
            Dim currentUserId As Integer? = If(SessionManager.IsLoggedIn(), SessionManager.CurrentUser.Id, CType(Nothing, Integer?))

            Dim newEntry As New Parking With {
                .plateNumber = cleanPlate,
                .vehicleType = vehicleType,
                .EntryTime = DateTime.Now,
                .Status = "IN",
                .PaymentStatus = "Belum Dibayar",
                .UserId = currentUserId
            }

            Return _parkingRepository.InsertEntry(newEntry)
        End Function

        ''' <summary>
        ''' Mengambil data transaksi parkir aktif berdasarkan nomor polisi (Digunakan untuk cetak karcis)
        ''' </summary>
        Public Function GetActiveParkingByPlate(plateNumber As String) As Parking
            If String.IsNullOrWhiteSpace(plateNumber) Then
                Return Nothing
            End If

            Return _parkingRepository.GetActiveParkingByPlate(plateNumber.Trim().ToUpper())
        End Function

        Public Function GetActiveParkingCount() As Integer
            Return _parkingRepository.GetActiveParkingCount()
        End Function

        Public Function GetTodayEntryCount() As Integer
            Return _parkingRepository.GetTodayEntryCount()
        End Function
    End Class
End Namespace