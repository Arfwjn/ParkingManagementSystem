Imports System

Namespace Models
    ''' <summary>
    ''' Entity Model Parking menyimpan informasi lengkap satu transaksi parkir kendaraan (masuk hingga keluar).
    ''' </summary>
    Public Class Parking
        ''' <summary>ID unik transaksi parkir.</summary>
        Public Property Id As Integer
        ''' <summary>Plat nomor kendaraan.</summary>
        Public Property PlateNumber As String
        ''' <summary>Jenis kendaraan (Mobil / Motor).</summary>
        Public Property VehicleType As String
        ''' <summary>Waktu kedatangan kendaraan masuk parkir.</summary>
        Public Property EntryTime As DateTime
        ''' <summary>Waktu kendaraan keluar dari area parkir (nullable jika masih parkir).</summary>
        Public Property ExitTime As DateTime?
        ''' <summary>Total durasi parkir dalam satuan jam (dibulatkan ke atas).</summary>
        Public Property Duration As Integer
        ''' <summary>Biaya tarif parkir dasar.</summary>
        Public Property ParkingFee As Decimal
        ''' <summary>Biaya tambahan (jika ada).</summary>
        Public Property AdditionalFee As Decimal
        ''' <summary>Biaya inap jika kendaraan parkir menginap.</summary>
        Public Property OvernightFee As Decimal
        ''' <summary>Denda jika karcis/tiket parkir hilang.</summary>
        Public Property LostTicketFine As Decimal
        ''' <summary>Jumlah nilai potongan diskon yang didapat.</summary>
        Public Property Discount As Decimal
        ''' <summary>Total nilai akhir yang harus dibayarkan.</summary>
        Public Property TotalPayment As Decimal
        ''' <summary>Metode pembayaran yang dipilih (Tunai / QRIS / Debit).</summary>
        Public Property PaymentMethod As String
        ''' <summary>Status pembayaran (Belum Dibayar / Lunas).</summary>
        Public Property PaymentStatus As String
        ''' <summary>Status transaksi kendaraan ('IN', 'OUT', atau 'OVERNIGHT').</summary>
        Public Property Status As String
        ''' <summary>Nomor referensi pembayaran transaksi digital (bila ada).</summary>
        Public Property ReferenceNumber As String
        ''' <summary>ID Petugas yang memproses transaksi.</summary>
        Public Property UserId As Integer?

        ''' <summary>
        ''' Menghitung durasi parkir dalam satuan jam dari selisih waktu masuk dan keluar.
        ''' Menggunakan pembulatan ke atas (ceiling), durasi kurang dari 1 jam tetap dihitung 1 jam.
        ''' </summary>
        Public Shared Function CalculateDurationInHours(entry As DateTime, [exit] As DateTime) As Integer
            Dim timeSpan As TimeSpan = [exit] - entry
            If timeSpan.TotalMinutes <= 0 Then Return 1

            Return CInt(Math.Ceiling(timeSpan.TotalHours))
        End Function
    End Class
End Namespace