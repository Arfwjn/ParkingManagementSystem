Imports System
Imports System.Windows.Forms

Namespace Views
    Public Class DebitPaymentForm
        Public Property Amount As Decimal
        Public Property TransactionTitle As String
        Public Property CardOrReferenceNumber As String

        Private ReadOnly _settingController As PaymentSettingController

        Public Sub New(amount As Decimal, transactionTitle As String)
            InitializeComponent()
            Me.Amount = amount
            Me.TransactionTitle = transactionTitle
            Me.CardOrReferenceNumber = String.Empty

            ' Inisialisasi controller untuk mengambil data rekening bank dari database
            _settingController = New PaymentSettingController()
        End Sub

        Private Sub DebitPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblTransactionTitle.Text = TransactionTitle
            lblAmountValue.Text = $"Rp {Amount:N0}"

            ' Memuat informasi rekening bank penerima dari database
            LoadBankData()

            txtCardOrRefNo.Focus()
        End Sub

        ''' <summary>
        ''' Memuat data bank, nomor rekening, dan nama pemilik dari konfigurasi database
        ''' </summary>
        Private Sub LoadBankData()
            Try
                Dim setting As PaymentSetting = _settingController.LoadPaymentSetting()
                If setting IsNot Nothing Then
                    ' Set Label Nama Bank jika kontrol tersedia di designer
                    SetControlText("lblBankName", setting.BankName)

                    ' Set Label Nomor Rekening jika kontrol tersedia di designer
                    SetControlText("lblAccountNumber", setting.AccountNumber)

                    ' Set Label Nama Pemilik Rekening jika kontrol tersedia di designer
                    SetControlText("lblAccountHolder", $"a.n. {setting.AccountHolder}")
                End If
            Catch ex As Exception
                ' Jika gagal membaca dari DB, form tetap dapat digunakan untuk penginputan nomor kartu/referensi
            End Try
        End Sub

        ''' <summary>
        ''' Helper untuk memperbarui teks label secara aman jika kontrol ditemukan pada designer
        ''' </summary>
        Private Sub SetControlText(controlName As String, textValue As String)
            Dim foundControls = Controls.Find(controlName, True)
            If foundControls.Length > 0 AndAlso TypeOf foundControls(0) Is Label Then
                CType(foundControls(0), Label).Text = textValue
            End If
        End Sub

        Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
            Dim inputRef As String = txtCardOrRefNo.Text.Trim()

            If String.IsNullOrWhiteSpace(inputRef) Then
                MessageBox.Show("Masukkan nomor kartu debit atau nomor referensi transaksi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCardOrRefNo.Focus()
                Return
            End If

            Me.CardOrReferenceNumber = inputRef
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub
    End Class
End Namespace