Imports System
Imports ParkingManagementSystem.Helpers
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    ''' <summary>
    ''' Controller ParkingController menangani aturan bisnis registrasi kendaraan masuk, pemeriksaan kapasitas area parkir,
    ''' pencegahan duplikasi kendaraan aktif, dan pencarian status keanggotaan member.
    ''' </summary>
    Public Class ParkingController
        Private ReadOnly _parkingRepository As ParkingRepository
        Private ReadOnly _memberRepository As MemberRepository
        Private ReadOnly _tariffRepository As TariffRepository

        ''' <summary>Kapasitas maksimum area parkir mobil (Business Rules 5.9).</summary>
        Public Const MAX_CAR_CAPACITY As Integer = 50
        ''' <summary>Kapasitas maksimum area parkir sepeda motor (Business Rules 5.9).</summary>
        Public Const MAX_MOTORCYCLE_CAPACITY As Integer = 100

        ''' <summary>
        ''' Constructor untuk menginisialisasi repository parkir, member, dan tarif.
        ''' </summary>
        Public Sub New()
            _parkingRepository = New ParkingRepository()
            _memberRepository = New MemberRepository()
            _tariffRepository = New TariffRepository()
        End Sub

        ''' <summary>
        ''' Memproses pendaftaran kendaraan masuk dengan validasi format plat, duplikasi aktif, dan ketersediaan slot parkir.
        ''' </summary>
        Public Function RegisterEntry(plateNumber As String, vehicleType As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            ' Validasi input dasar
            If String.IsNullOrWhiteSpace(plateNumber) Then
                errorMessage = "Nomor Polisi wajib diisi."
                Return False
            End If

            If String.IsNullOrWhiteSpace(vehicleType) OrElse (vehicleType <> "Mobil" AndAlso vehicleType <> "Motor") Then
                errorMessage = "Pilih jenis kendaraan yang valid (Mobil / Motor)."
                Return False
            End If

            Dim cleanPlate As String = plateNumber.Trim().ToUpper()

            ' Memeriksa agar kendaraan dengan plat nomor yang sama tidak masuk dua kali (Duplikasi Active Vehicle)
            If _parkingRepository.IsPlateActive(cleanPlate) Then
                errorMessage = $"Kendaraan dengan nomor polisi '{cleanPlate}' sudah berada di area parkir."
                Return False
            End If

            ' Memeriksa batas kapasitas maksimum area parkir
            Dim activeCount As Integer = _parkingRepository.GetActiveCountByType(vehicleType)
            Dim maxCapacity As Integer = If(vehicleType = "Mobil", MAX_CAR_CAPACITY, MAX_MOTORCYCLE_CAPACITY)

            If activeCount >= maxCapacity Then
                errorMessage = "Parkiran penuh." & vbCrLf & "Silakan menunggu hingga tersedia slot parkir."
                Return False
            End If

            ' Mengambil ID petugas pengguna yang sedang login
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
        ''' Mengambil data transaksi parkir aktif berdasarkan nomor polisi (Digunakan untuk keperluan cetak karcis masuk).
        ''' </summary>
        Public Function GetActiveParkingByPlate(plateNumber As String) As Parking
            If String.IsNullOrWhiteSpace(plateNumber) Then
                Return Nothing
            End If

            Return _parkingRepository.GetActiveParkingByPlate(plateNumber.Trim().ToUpper())
        End Function

        ''' <summary>
        ''' Mengambil jumlah total kendaraan yang sedang aktif parkir saat ini.
        ''' </summary>
        Public Function GetActiveParkingCount() As Integer
            Return _parkingRepository.GetActiveParkingCount()
        End Function

        ''' <summary>
        ''' Mengambil jumlah akumulasi kendaraan yang masuk pada hari ini.
        ''' </summary>
        Public Function GetTodayEntryCount() As Integer
            Return _parkingRepository.GetTodayEntryCount()
        End Function

        ''' <summary>
        ''' Memeriksa apakah suatu nomor polisi terdaftar sebagai member aktif dan mengembalikan data profil beserta diskonnya.
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
        ''' Mengambil informasi acuan tarif parkir dari database berdasarkan tipe kendaraan.
        ''' </summary>
        Public Function GetTariffInfo(vehicleType As String) As Tariff
            Return _tariffRepository.GetByVehicleType(vehicleType)
        End Function

        ''' <summary>
        ''' Memproses transaksi pendaftaran kendaraan masuk baru dengan menyertakan ID petugas.
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

            ' Memeriksa apakah kendaraan sudah berada di dalam lokasi parkir
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