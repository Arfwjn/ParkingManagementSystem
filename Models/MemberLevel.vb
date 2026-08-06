Namespace Models
    ''' <summary>
    ''' Entity Model MemberLevel menyimpan konfigurasi tingkatan member, persentase diskon parkir, dan biaya iuran bulanan.
    ''' </summary>
    Public Class MemberLevel
        ''' <summary>ID unik tingkatan member.</summary>
        Public Property Id As Integer
        ''' <summary>Nama tingkatan member (contoh: Silver, Gold, VIP).</summary>
        Public Property LevelName As String
        ''' <summary>Persentase diskon potongan harga parkir (0-100%).</summary>
        Public Property DiscountPercentage As Decimal
        ''' <summary>Biaya berlangganan per bulan.</summary>
        Public Property MonthlyFee As Decimal
        ''' <summary>Keterangan deskripsi tambahan tingkatan member.</summary>
        Public Property Description As String
        ''' <summary>Waktu dibuatnya data tingkatan member.</summary>
        Public Property CreatedAt As DateTime
        ''' <summary>Waktu terakhir perubahan data.</summary>
        Public Property UpdatedAt As DateTime

        ''' <summary>Constructor default.</summary>
        Public Sub New()
        End Sub

        ''' <summary>Constructor dengan parameter inisialisasi awal.</summary>
        Public Sub New(id As Integer, levelName As String, discountPercentage As Decimal, description As String)
            Me.Id = id
            Me.LevelName = levelName
            Me.DiscountPercentage = discountPercentage
            Me.Description = description
        End Sub
    End Class
End Namespace