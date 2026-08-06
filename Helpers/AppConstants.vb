Namespace Helpers
    ''' <summary>
    ''' Kelas konstanta terpusat AppConstants menyimpan nilai konstanta string dan numerik yang digunakan di seluruh layer aplikasi.
    ''' Membantu mengeliminasi magic strings/numbers serta mencegah kesalahan pengetikan (typo).
    ''' </summary>
    Public Class AppConstants
        ''' <summary>Konstanta jenis kendaraan parkir.</summary>
        Public Class VehicleTypes
            Public Const Car As String = "Mobil"
            Public Const Motorcycle As String = "Motor"
        End Class

        ''' <summary>Konstanta status keberadaan transaksi parkir di lokasi.</summary>
        Public Class ParkingStatus
            Public Const InArea As String = "IN"
            Public Const OutArea As String = "OUT"
        End Class

        ''' <summary>Konstanta status pembayaran transaksi parkir.</summary>
        Public Class PaymentStatus
            Public Const Unpaid As String = "Belum Dibayar"
            Public Const Paid As String = "Lunas"
        End Class

        ''' <summary>Konstanta jenis metode pembayaran yang didukung.</summary>
        Public Class PaymentMethods
            Public Const Cash As String = "Tunai"
            Public Const Qris As String = "QRIS"
            Public Const Debit As String = "Debit"
            Public Const TransferDebit As String = "Transfer / Debit"
        End Class

        ''' <summary>Konstanta peran (role) hak akses pengguna sistem.</summary>
        Public Class UserRoles
            Public Const Admin As String = "Admin"
            Public Const Officer As String = "Petugas"
        End Class

        ''' <summary>Konstanta batas maksimum kapasitas kendaraan di area parkir.</summary>
        Public Class CapacityLimits
            Public Const MaxCarCapacity As Integer = 50
            Public Const MaxMotorcycleCapacity As Integer = 100
        End Class
    End Class
End Namespace
