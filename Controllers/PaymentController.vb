Imports System
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    Public Class PaymentController
        Private ReadOnly _parkingRepository As ParkingRepository
        Private ReadOnly _memberRepository As MemberRepository

        Public Sub New()
            _parkingRepository = New ParkingRepository()
            _memberRepository = New MemberRepository()
        End Sub

        ''' <summary>
        ''' Mencari transaksi aktif dan menghitung seluruh rincian tarif parkir
        ''' </summary>
        Public Function CalculateExitDetails(plateNumber As String, isLostTicket As Boolean, ByRef activeMember As Member, ByRef errorMessage As String) As Parking
            errorMessage = String.Empty

            If String.IsNullOrWhiteSpace(plateNumber) Then
                errorMessage = "Nomor Polisi wajib diisi."
                Return Nothing
            End If

            ' 1. Cari transaksi aktif di database
            Dim activeParking As Parking = _parkingRepository.GetActiveParkingByPlate(plateNumber.Trim().ToUpper())
            If activeParking Is Nothing Then
                errorMessage = $"Kendaraan dengan plat '{plateNumber}' tidak ditemukan atau sudah keluar."
                Return Nothing
            End If

            ' 2. Hitung Waktu & Durasi
            Dim exitTime As DateTime = DateTime.Now
            Dim durationHours As Integer = Parking.CalculateDurationInHours(activeParking.EntryTime, exitTime)

            ' 3. Instansiasi Objek Kendaraan (Polymorphism)
            Dim vehicle As Vehicle
            If activeParking.VehicleType.Equals("Mobil", StringComparison.OrdinalIgnoreCase) Then
                vehicle = New Car(activeParking.PlateNumber)
            Else
                vehicle = New Motorcycle(activeParking.PlateNumber)
            End If

            ' 4. Hitung Tarif Dasar Parkir
            Dim baseFee As Decimal = vehicle.CalculateFee(durationHours)

            ' 5. Hitung Biaya Menginap (> 24 Jam)
            Dim overnightFee As Decimal = 0
            If durationHours > 24 Then
                Dim days As Integer = CInt(Math.Floor(durationHours / 24.0))
                overnightFee = vehicle.GetOvernightFee(days)
            End If

            ' 6. Hitung Denda Karcis Hilang
            Dim lostFine As Decimal = If(isLostTicket, vehicle.GetLostTicketFine(), 0D)

            ' 7. Pengecekan Diskon Member
            activeMember = _memberRepository.GetMemberByPlate(activeParking.PlateNumber)
            Dim discountAmount As Decimal = 0
            If activeMember IsNot Nothing Then
                Dim discountPercent As Decimal = activeMember.GetDiscountPercentage()
                discountAmount = (baseFee + overnightFee) * discountPercent
            End If

            ' 8. Hitung Total Akhir: (Tarif + Menginap + Denda) - Diskon
            Dim totalPay As Decimal = (baseFee + overnightFee + lostFine) - discountAmount
            If totalPay < 0 Then totalPay = 0

            ' Populasi objek transaksi
            activeParking.ExitTime = exitTime
            activeParking.Duration = durationHours
            activeParking.ParkingFee = baseFee
            activeParking.OvernightFee = overnightFee
            activeParking.LostTicketFine = lostFine
            activeParking.Discount = discountAmount
            activeParking.TotalPayment = totalPay

            Return activeParking
        End Function

        ''' <summary>
        ''' Menyimpan transaksi pembayaran kendaraan keluar
        ''' </summary>
        Public Function ProcessPayment(parkingData As Parking, paymentMethod As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If parkingData Is Nothing Then
                errorMessage = "Data transaksi tidak valid."
                Return False
            End If

            If String.IsNullOrWhiteSpace(paymentMethod) Then
                errorMessage = "Pilih metode pembayaran (Tunai / QRIS / Debit)."
                Return False
            End If

            parkingData.PaymentMethod = paymentMethod
            Return _parkingRepository.UpdateExitPayment(parkingData)
        End Function
    End Class
End Namespace