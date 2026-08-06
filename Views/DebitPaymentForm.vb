Imports System
Imports System.Windows.Forms

Namespace Views
    ''' <summary>
    ''' Form DebitPaymentForm menampilkan dialog konfirmasi pembayaran non-tunai metode Kartu Debit / Transfer Bank.
    ''' Memuat informasi rekening tujuan dari database dan menerima penginputan nomor kartu/referensi transaksi.
    ''' </summary>
    Public Class DebitPaymentForm
        ''' <summary>Jumlah nominal yang harus dibayarkan.</summary>
        Public Property Amount As Decimal
        ''' <summary>Judul deskripsi transaksi (misal: "Pembayaran Parkir Keluar").</summary>
        Public Property TransactionTitle As String
        ''' <summary>Nomor kartu debit atau nomor referensi transaksi yang dimasukkan oleh pengguna.</summary>
        Public Property CardOrReferenceNumber As String

        Private ReadOnly _settingController As PaymentSettingController

        ''' <summary>
        ''' Constructor dengan parameter nominal dan judul transaksi.
        ''' </summary>
        Public Sub New(amount As Decimal, transactionTitle As String)
            InitializeComponent()
            Me.Amount = amount
            Me.TransactionTitle = transactionTitle
            Me.CardOrReferenceNumber = String.Empty

            _settingController = New PaymentSettingController()
        End Sub

        Private Sub DebitPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblTransactionTitle.Text = TransactionTitle
            lblAmountValue.Text = $"Rp {Amount:N0}"

            ' Memuat informasi rekening bank penerima dari basis data
            LoadBankData()

            txtCardOrRefNo.Focus()
        End Sub

        ''' <summary>
        ''' Memuat nama bank, nomor rekening, dan nama pemegang rekening dari pengaturan database.
        ''' </summary>
        Private Sub LoadBankData()
            Try
                Dim setting As PaymentSetting = _settingController.LoadPaymentSetting()
                If setting IsNot Nothing Then
                    SetControlText("lblBankName", setting.BankName)
                    SetControlText("lblAccountNumber", setting.AccountNumber)
                    SetControlText("lblAccountHolder", $"a.n. {setting.AccountHolder}")
                End If
            Catch ex As Exception
                ' Jika gagal membaca dari database, form tetap dapat digunakan untuk penginputan nomor kartu/referensi
            End Try
        End Sub

        ''' <summary>
        ''' Helper privat untuk memperbarui teks label secara aman jika kontrol ditemukan di UI designer.
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