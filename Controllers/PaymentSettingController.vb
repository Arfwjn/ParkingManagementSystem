''' <summary>
''' Controller PaymentSettingController mengelola validasi dan penyimpanan konfigurasi Merchant QRIS serta Rekening Bank.
''' </summary>
Public Class PaymentSettingController
    Private ReadOnly _repository As PaymentSettingRepository

    ''' <summary>
    ''' Constructor untuk menginisialisasi repository pengaturan pembayaran.
    ''' </summary>
    Sub New()
        _repository = New PaymentSettingRepository()
    End Sub

    ''' <summary>
    ''' Memuat konfigurasi pengaturan pembayaran aktif dari database.
    ''' </summary>
    Public Function LoadPaymentSetting() As PaymentSetting
        Return _repository.GetSetting()
    End Function

    ''' <summary>
    ''' Memvalidasi kelengkapan data Merchant QRIS dan Rekening Bank lalu menyimpannya ke database.
    ''' </summary>
    Public Function SavePaymentSetting(setting As PaymentSetting, ByRef errorMessage As String) As Boolean
        ' Validasi kelengkapan nama Merchant QRIS
        If String.IsNullOrWhiteSpace(setting.QrisMerchantName) Then
            errorMessage = "Nama Merchant QRIS tidak boleh kosong."
            Return False
        End If

        ' Validasi kelengkapan data Bank dan Rekening
        If String.IsNullOrWhiteSpace(setting.BankName) Then
            errorMessage = "Nama Bank tidak boleh kosong."
            Return False
        End If

        If String.IsNullOrWhiteSpace(setting.AccountNumber) Then
            errorMessage = "Nomor Rekening tidak boleh kosong."
            Return False
        End If

        If Not IsNumeric(setting.AccountNumber) Then
            errorMessage = "Nomor Rekening harus berupa angka."
            Return False
        End If

        If String.IsNullOrWhiteSpace(setting.AccountHolder) Then
            errorMessage = "Nama Pemilik Rekening tidak boleh kosong."
            Return False
        End If

        Try
            Dim success As Boolean = _repository.UpdateSetting(setting)
            If Not success Then
                errorMessage = "Gagal memperbarui data di basis data."
            End If
            Return success
        Catch ex As Exception
            errorMessage = ex.Message
            Return False
        End Try
    End Function
End Class