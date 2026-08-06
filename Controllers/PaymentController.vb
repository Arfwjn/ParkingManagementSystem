Imports System
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    ''' <summary>
    ''' Controller PaymentController mengolah kalkulasi rincian biaya keluar parkir (durasi, tarif per jam, tarif inap, denda hilang tiket, diskon member)
    ''' serta menyimpan status transaksi pembayaran lunas ke database.
    ''' </summary>
    Public Class PaymentController
        Private ReadOnly _tariffRepository As TariffRepository
        Private ReadOnly _memberRepository As MemberRepository
        Private ReadOnly _parkingRepository As ParkingRepository

        ''' <summary>
        ''' Constructor untuk menginisialisasi repository tarif, member, dan parkir.
        ''' </summary>
        Public Sub New()
            _tariffRepository = New TariffRepository()
            _memberRepository = New MemberRepository()
            _parkingRepository = New ParkingRepository()
        End Sub

        ''' <summary>
        ''' Menghitung rincian biaya parkir secara presisi berdasarkan waktu masuk, durasi jam (pembulatan ke atas), tarif inap, denda karcis, serta diskon level member.
        ''' </summary>
        Public Function CalculateExitDetails(plateNumber As String, isTicketLost As Boolean, ByRef activeMember As Member, ByRef errorMessage As String) As Parking
            errorMessage = String.Empty
            activeMember = Nothing

            If String.IsNullOrWhiteSpace(plateNumber) Then
                errorMessage = "Plat nomor kendaraan tidak boleh kosong."
                Return Nothing
            End If

            ' Ambil data transaksi parkir aktif berdasarkan nomor polisi
            Dim parking As Parking = _parkingRepository.GetActiveParkingByPlate(plateNumber.Trim())
            If parking Is Nothing Then
                errorMessage = "Kendaraan dengan plat nomor tersebut tidak ditemukan pada daftar parkir aktif."
                Return Nothing
            End If

            Dim exitTime As DateTime = DateTime.Now
            parking.ExitTime = exitTime

            ' Menghitung durasi parkir dalam satuan jam (minimum 1 jam, pembulatan ke atas)
            Dim totalMinutes As Double = (exitTime - parking.EntryTime).TotalMinutes
            Dim totalHours As Integer = CInt(Math.Ceiling(totalMinutes / 60.0))
            If totalHours < 1 Then totalHours = 1
            parking.Duration = totalHours

            ' Mengambil acuan tarif dinamis dari database berdasarkan tipe kendaraan
            Dim tariff As Tariff = _tariffRepository.GetByVehicleType(parking.VehicleType)
            Dim hourlyRate As Decimal = If(tariff IsNot Nothing, tariff.HourlyRate, 3000D)
            Dim overnightRate As Decimal = If(tariff IsNot Nothing, tariff.OvernightRate, 25000D)

            ' Menghitung rincian biaya parkir per jam dan biaya inap per 24 jam
            Dim overnightDays As Integer = totalHours \ 24
            Dim remainingHours As Integer = totalHours Mod 24

            parking.OvernightFee = overnightDays * overnightRate
            parking.ParkingFee = remainingHours * hourlyRate

            ' Menambahkan denda tiket hilang (jika dicentang/terjadi)
            parking.LostTicketFine = If(isTicketLost, 25000D, 0D)

            ' Kalkulasi total kotor sebelum dikurangi diskon
            Dim grossTotal As Decimal = parking.ParkingFee + parking.OvernightFee + parking.LostTicketFine

            ' Memeriksa status keanggotaan member dan persentase potongan diskon
            Dim memberTuple = _memberRepository.GetMemberWithLevelByPlate(plateNumber)
            If memberTuple IsNot Nothing Then
                activeMember = memberTuple.Item1
                Dim discountPercentage As Decimal = memberTuple.Item3
                parking.Discount = grossTotal * (discountPercentage / 100D)
            Else
                parking.Discount = 0D
            End If

            ' Total bayar bersih akhir setelah diskon
            parking.TotalPayment = Math.Max(0D, grossTotal - parking.Discount)
            Return parking
        End Function

        ''' <summary>
        ''' Memproses dan menyimpan transaksi pembayaran parkir kendaraan keluar (Check-Out) ke database.
        ''' </summary>
        Public Function ProcessPayment(parking As Parking, paymentMethod As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            ' Validasi input data parkir dan metode pembayaran
            If parking Is Nothing Then
                errorMessage = "Data parkir tidak valid."
                Return False
            End If

            If String.IsNullOrWhiteSpace(paymentMethod) Then
                errorMessage = "Metode pembayaran wajib dipilih."
                Return False
            End If

            ' Menetapkan metode pembayaran, status transaksi keluar ('OUT'), dan waktu keluar
            parking.PaymentMethod = paymentMethod
            parking.Status = "OUT"

            If Not parking.ExitTime.HasValue Then
                parking.ExitTime = DateTime.Now
            End If

            ' Menyimpan perubahan status dan rincian transaksi ke database
            Try
                Dim success As Boolean = _parkingRepository.UpdateExitPayment(parking)
                If Not success Then
                    errorMessage = "Gagal memperbarui transaksi pembayaran di database."
                    Return False
                End If

                Return True
            Catch ex As Exception
                errorMessage = "Terjadi kesalahan database: " & ex.Message
                Return False
            End Try
        End Function
    End Class
End Namespace