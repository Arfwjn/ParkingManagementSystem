Imports System
Imports System.Collections.Generic

Namespace Models
    ''' <summary>
    ''' Entity Model Member menyimpan informasi profil keanggotaan pelanggan parkir berlangganan.
    ''' </summary>
    Public Class Member
        ''' <summary>ID unik data member di database.</summary>
        Public Property Id As Integer

        ''' <summary>Plat nomor utama kendaraan member.</summary>
        Public Property PlateNumber As String

        ''' <summary>Daftar seluruh plat nomor terdaftar milik member (maksimal 3 kendaraan per pemilik).</summary>
        Public Property PlateNumbers As List(Of String)

        ''' <summary>Nama lengkap pemilik akun keanggotaan.</summary>
        Public Property OwnerName As String

        ''' <summary>ID referensi level member pada tabel member_levels.</summary>
        Public Property LevelId As Integer

        ''' <summary>Nama tingkatan keanggotaan (contoh: Bronze, Silver, Gold, Platinum).</summary>
        Public Property MemberLevel As String

        ''' <summary>Persentase diskon tarif parkir khusus member (contoh: 0.10 untuk 10%).</summary>
        Public Property DiscountPercentage As Decimal

        ''' <summary>Tanggal pertama kali member mendaftar.</summary>
        Public Property RegistrationDate As Nullable(Of DateTime)

        ''' <summary>Tanggal batas akhir masa aktif berlangganan member.</summary>
        Public Property SubscriptionExpiresAt As Nullable(Of DateTime)

        ''' <summary>Status status keanggotaan saat ini ('ACTIVE' atau 'EXPIRED').</summary>
        Public Property Status As String

        ''' <summary>
        ''' Constructor default untuk menginisialisasi list plat nomor dan menetapkan status awal ACTIVE.
        ''' </summary>
        Public Sub New()
            PlateNumbers = New List(Of String)()
            Status = "ACTIVE"
        End Sub

        ''' <summary>
        ''' Memeriksa apakah keanggotaan member masih aktif berdasarkan tanggal kadaluarsa dan statusnya.
        ''' </summary>
        Public Function IsSubscriptionActive() As Boolean
            If String.Equals(Status, "EXPIRED", StringComparison.OrdinalIgnoreCase) Then
                Return False
            End If

            If SubscriptionExpiresAt.HasValue Then
                Return SubscriptionExpiresAt.Value >= DateTime.Now
            End If

            Return True
        End Function
    End Class
End Namespace