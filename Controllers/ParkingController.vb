Imports System
Imports ParkingManagementSystem.Helpers
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    Public Class ParkingController
        Private ReadOnly _parkingRepository As ParkingRepository
        Private ReadOnly _memberRepository As MemberRepository
        Private ReadOnly _tariffRepository As TariffRepository

        ' Konfigurasi Batas Kapasitas Parkir (Business Rules 5.9)
        Public Const MAX_CAR_CAPACITY As Integer = 50
        Public Const MAX_MOTORCYCLE_CAPACITY As Integer = 100

        Public Sub New()
            _parkingRepository = New ParkingRepository()
            _memberRepository = New MemberRepository()
            _tariffRepository = New TariffRepository()
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
                .PlateNumber = cleanPlate,
                .VehicleType = vehicleType,
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

        ''' <summary>
        ''' Memeriksa apakah plat nomor terdaftar sebagai member dan mengembalikan data info member
        ''' </summary>
        Public Function CheckMemberStatus(plateNumber As String) As Tuple(Of Boolean, String, String, Decimal)
            ' Returns: Tuple(IsMember, OwnerName, LevelName, DiscountPercentage)
            If String.IsNullOrWhiteSpace(plateNumber) Then
                Return Tuple.Create(False, "", "Non-Member", 0D)
            End If

            Dim memberData = _memberRepository.GetMemberWithLevelByPlate(plateNumber.Trim())
            If memberData IsNot Nothing Then
                Return Tuple.Create(True, memberData.Item1.OwnerName, memberData.Item2, memberData.Item3)
            End If

            Return Tuple.Create(False, "", "Non-Member", 0D)
        End Function

        ''' <summary>
        ''' Mengambil estimasi tarif per jam dari database berdasarkan tipe kendaraan
        ''' </summary>
        Public Function GetTariffInfo(vehicleType As String) As Tariff
            Return _tariffRepository.GetByVehicleType(vehicleType)
        End Function

        ''' <summary>
        ''' Memproses transaksi kendaraan masuk baru
        ''' </summary>
        Public Function ProcessEntry(plateNumber As String, vehicleType As String, userId As Nullable(Of Integer), ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If String.IsNullOrWhiteSpace(plateNumber) Then
                errorMessage = "Plat nomor kendaraan wajib diisi."
                Return False
            End If

            If String.IsNullOrWhiteSpace(vehicleType) Then
                errorMessage = "Pilih jenis kendaraan terlebih dahulu."
                Return False
            End If

            ' Cek apakah kendaraan masih berada di dalam area parkir
            If _parkingRepository.IsPlateActive(plateNumber.Trim()) Then
                errorMessage = $"Kendaraan dengan plat nomor '{plateNumber.Trim().ToUpper()}' saat ini masih terdaftar aktif berada di dalam area parkir."
                Return False
            End If

            Dim parking As New Parking() With {
                .PlateNumber = plateNumber.Trim().ToUpper(),
                .VehicleType = vehicleType,
                .EntryTime = DateTime.Now,
                .UserId = userId
            }

            If Not _parkingRepository.InsertEntry(parking) Then
                errorMessage = "Gagal menyimpan transaksi parkir masuk ke database."
                Return False
            End If

            Return True
        End Function
    End Class
End Namespace