Imports System
Imports System.Collections.Generic

Namespace Models
    Public Class Member
        ''' <summary>
        ''' Primary Key ID Member pada database
        ''' </summary>
        Public Property Id As Integer

        ''' <summary>
        ''' Plat nomor utama kendaraan
        ''' </summary>
        Public Property PlateNumber As String

        ''' <summary>
        ''' Koleksi seluruh plat nomor terdaftar milik member (maksimal 3 kendaraan)
        ''' </summary>
        Public Property PlateNumbers As List(Of String)

        ''' <summary>
        ''' Nama lengkap pemilik keanggotaan
        ''' </summary>
        Public Property OwnerName As String

        ''' <summary>
        ''' Foreign Key ID yang merujuk pada tabel member_levels
        ''' </summary>
        Public Property LevelId As Integer

        ''' <summary>
        ''' Nama teks level keanggotaan (misal: Bronze, Silver, Gold, Platinum)
        ''' </summary>
        Public Property MemberLevel As String

        ''' <summary>
        ''' Persentase diskon dinamis yang diambil dari database (misal: 0.10 untuk 10%)
        ''' </summary>
        Public Property DiscountPercentage As Decimal

        ''' <summary>
        ''' Tanggal pertama pendaftaran member
        ''' </summary>
        Public Property RegistrationDate As Nullable(Of DateTime)

        ''' <summary>
        ''' Tanggal jatuh tempo / kedaluwarsa masa aktif keanggotaan
        ''' </summary>
        Public Property SubscriptionExpiresAt As Nullable(Of DateTime)

        ''' <summary>
        ''' Status keanggotaan ('ACTIVE' / 'EXPIRED')
        ''' </summary>
        Public Property Status As String

        ''' <summary>
        ''' Constructor default untuk inisialisasi koleksi list plat nomor
        ''' </summary>
        Public Sub New()
            PlateNumbers = New List(Of String)()
            Status = "ACTIVE"
        End Sub

        ''' <summary>
        ''' Helper method untuk mengecek apakah keanggotaan masih aktif secara real-time
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