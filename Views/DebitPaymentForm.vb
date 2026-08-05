Imports System
Imports System.Windows.Forms

Namespace Views
    Public Class DebitPaymentForm
        Public Property Amount As Decimal
        Public Property TransactionTitle As String
        Public Property CardOrReferenceNumber As String

        Public Sub New(amount As Decimal, transactionTitle As String)
            InitializeComponent()
            Me.Amount = amount
            Me.TransactionTitle = transactionTitle
            Me.CardOrReferenceNumber = String.Empty
        End Sub

        Private Sub DebitPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblTransactionTitle.Text = TransactionTitle
            lblAmountValue.Text = $"Rp {Amount:N0}"
            txtCardOrRefNo.Focus()
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