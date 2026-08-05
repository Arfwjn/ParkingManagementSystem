Imports System
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    Public Class PaymentController
        Private ReadOnly _tariffRepository As TariffRepository
        Private ReadOnly _memberRepository As MemberRepository
        Private ReadOnly _parkingRepository As ParkingRepository

        Public Sub New()
            _tariffRepository = New TariffRepository()
            _memberRepository = New MemberRepository()
            _parkingRepository = New ParkingRepository()
        End Sub

        ''' <summary>
        ''' Menghitung rincian biaya parkir keluar secara dinamis berdasarkan tarif database dan diskon level member.
        ''' </summary>
        Public Function CalculateExitDetails(plateNumber As String, isTicketLost As Boolean, ByRef activeMember As Member, ByRef errorMessage As String) As Parking
            errorMessage = String.Empty
            activeMember = Nothing

            If String.IsNullOrWhiteSpace(plateNumber) Then
                errorMessage = "Plat nomor kendaraan tidak boleh kosong."
                Return Nothing
            End If

            ' 1. Ambil data transaksi parkir aktif menggunakan GetActiveParkingByPlate
            Dim parking As Parking = _parkingRepository.GetActiveParkingByPlate(plateNumber.Trim())
            If parking Is Nothing Then
                errorMessage = "Kendaraan dengan plat nomor tersebut tidak ditemukan pada daftar parkir aktif."
                Return Nothing
            End If

            Dim exitTime As DateTime = DateTime.Now
            parking.ExitTime = exitTime

            ' 2. Hitung Durasi Parkir (Minimum 1 jam, pembulatan ke atas)
            Dim totalMinutes As Double = (exitTime - parking.EntryTime).TotalMinutes
            Dim totalHours As Integer = CInt(Math.Ceiling(totalMinutes / 60.0))
            If totalHours < 1 Then totalHours = 1
            parking.Duration = totalHours

            ' 3. Ambil tarif dinamis dari database berdasarkan tipe kendaraan
            Dim tariff As Tariff = _tariffRepository.GetByVehicleType(parking.VehicleType)
            Dim hourlyRate As Decimal = If(tariff IsNot Nothing, tariff.HourlyRate, 3000D)
            Dim overnightRate As Decimal = If(tariff IsNot Nothing, tariff.OvernightRate, 25000D)

            ' 4. Hitung rincian biaya dasar & menginap
            Dim overnightDays As Integer = totalHours \ 24
            Dim remainingHours As Integer = totalHours Mod 24

            parking.OvernightFee = overnightDays * overnightRate
            parking.ParkingFee = remainingHours * hourlyRate

            ' 5. Denda tiket hilang (jika ada)
            parking.LostTicketFine = If(isTicketLost, 25000D, 0D)

            ' Total sebelum diskon
            Dim grossTotal As Decimal = parking.ParkingFee + parking.OvernightFee + parking.LostTicketFine

            ' 6. Cek Keanggotaan Member & Level Diskon
            Dim memberTuple = _memberRepository.GetMemberWithLevelByPlate(plateNumber)
            If memberTuple IsNot Nothing Then
                activeMember = memberTuple.Item1
                Dim discountPercentage As Decimal = memberTuple.Item3
                parking.Discount = grossTotal * (discountPercentage / 100D)
            Else
                parking.Discount = 0D
            End If

            ' 7. Total Bayar Akhir setelah diskon
            parking.TotalPayment = Math.Max(0D, grossTotal - parking.Discount)
            Return parking
        End Function

        ''' <summary>
        ''' Memproses transaksi pembayaran parkir keluar dan memperbarui status transaksi di database.
        ''' </summary>
        Public Function ProcessPayment(parking As Parking, paymentMethod As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If parking Is Nothing Then
                errorMessage = "Data parkir tidak valid."
                Return False
            End If

            If String.IsNullOrWhiteSpace(paymentMethod) Then
                errorMessage = "Metode pembayaran wajib dipilih."
                Return False
            End If

            parking.PaymentMethod = paymentMethod
            parking.Status = "Completed"

            Dim success As Boolean = _parkingRepository.UpdateExitPayment(parking)
            If Not success Then
                errorMessage = "Gagal memperbarui transaksi pembayaran di database."
                Return False
            End If

            Return True
        End Function
    End Class
End Namespace