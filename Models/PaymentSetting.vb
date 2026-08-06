''' <summary>
''' Entity Model PaymentSetting menyimpan konfigurasi pembayaran non-tunai (Merchant QRIS dan Rekening Bank Transfer/Debit).
''' </summary>
Public Class PaymentSetting
    ''' <summary>ID unik pengaturan pembayaran.</summary>
    Public Property Id As Integer

    ''' <summary>Nama Merchant QRIS yang muncul pada struk/layanan.</summary>
    Public Property QrisMerchantName As String
    ''' <summary>National Merchant ID (NMID) QRIS resmi.</summary>
    Public Property QrisNmid As String
    ''' <summary>Path lokasi penyimpanan file gambar barcode QRIS.</summary>
    Public Property QrisImagePath As String

    ''' <summary>Nama Bank penerima (misal: BCA, Mandiri, BNI).</summary>
    Public Property BankName As String
    ''' <summary>Nomor rekening bank tujuan transfer.</summary>
    Public Property AccountNumber As String
    ''' <summary>Nama pemilik / pemegang rekening bank.</summary>
    Public Property AccountHolder As String

    ''' <summary>Waktu dibuatnya data pengaturan.</summary>
    Public Property CreatedAt As DateTime
    ''' <summary>Waktu pembaruan data pengaturan.</summary>
    Public Property UpdatedAt As DateTime

    ''' <summary>Constructor default.</summary>
    Sub New()
    End Sub

    ''' <summary>Constructor dengan parameter lengkap untuk inisialisasi data pengaturan pembayaran.</summary>
    Sub New(id As Integer, qrisMerchantName As String, qrisNmid As String, qrisImagePath As String,
            bankName As String, accountNumber As String, accountHolder As String)
        Me.Id = id
        Me.QrisMerchantName = qrisMerchantName
        Me.QrisNmid = qrisNmid
        Me.QrisImagePath = qrisImagePath
        Me.BankName = bankName
        Me.AccountNumber = accountNumber
        Me.AccountHolder = accountHolder
    End Sub
End Class