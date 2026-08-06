Imports System.IO

''' <summary>
''' Form PaymentSettingForm mengelola pengaturan antarmuka pembayaran non-tunai, seperti nama Merchant QRIS, NMID, berkas gambar QR Code, nama bank, nomor rekening, dan nama pemilik rekening.
''' </summary>
Public Class PaymentSettingForm
    Private ReadOnly _controller As PaymentSettingController

    ''' <summary>
    ''' Constructor untuk menginisialisasi Form Pengaturan Pembayaran.
    ''' </summary>
    Sub New()
        InitializeComponent()
        _controller = New PaymentSettingController()
    End Sub

    Private Sub PaymentSettingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    ''' <summary>
    ''' Memuat konfigurasi pengaturan pembayaran aktif dari database dan memuat preview gambar QRIS jika tersedia.
    ''' </summary>
    Private Sub LoadData()
        Try
            Dim setting As PaymentSetting = _controller.LoadPaymentSetting()
            If setting IsNot Nothing Then
                txtQrisMerchant.Text = setting.QrisMerchantName
                txtQrisNmid.Text = setting.QrisNmid
                txtQrisImagePath.Text = setting.QrisImagePath

                txtBankName.Text = setting.BankName
                txtAccountNumber.Text = setting.AccountNumber
                txtAccountHolder.Text = setting.AccountHolder

                LoadQrisPreviewImage(setting.QrisImagePath)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat pengaturan pembayaran: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Menampilkan file dialog untuk memilih berkas gambar QR Code QRIS dari penyimpan lokal.
    ''' </summary>
    Private Sub btnBrowseQris_Click(sender As Object, e As EventArgs) Handles btnBrowseQris.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
            ofd.Title = "Pilih Gambar QRIS"

            If ofd.ShowDialog() = DialogResult.OK Then
                txtQrisImagePath.Text = ofd.FileName
                LoadQrisPreviewImage(ofd.FileName)
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Memuat gambar berkas QRIS ke komponen PictureBox preview secara aman dengan FileStream.
    ''' </summary>
    Private Sub LoadQrisPreviewImage(path As String)
        If Not String.IsNullOrEmpty(path) AndAlso File.Exists(path) Then
            Try
                Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
                    picQrisPreview.Image = Image.FromStream(fs)
                End Using
            Catch ex As Exception
                picQrisPreview.Image = Nothing
            End Try
        Else
            picQrisPreview.Image = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Memvalidasi dan menyimpan pembaruan konfigurasi pengaturan pembayaran ke database.
    ''' </summary>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim setting As New PaymentSetting() With {
                .Id = 1,
                .QrisMerchantName = txtQrisMerchant.Text.Trim(),
                .QrisNmid = txtQrisNmid.Text.Trim(),
                .QrisImagePath = txtQrisImagePath.Text.Trim(),
                .BankName = txtBankName.Text.Trim(),
                .AccountNumber = txtAccountNumber.Text.Trim(),
                .AccountHolder = txtAccountHolder.Text.Trim()
            }

        Dim errorMsg As String = ""
        Dim success As Boolean = _controller.SavePaymentSetting(setting, errorMsg)

        If success Then
            MessageBox.Show("Pengaturan metode pembayaran berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show(errorMsg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class