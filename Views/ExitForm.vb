Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Views
    Partial Public Class ExitForm
        Inherits Form

        Private ReadOnly _paymentController As PaymentController
        Private ReadOnly _parkingRepository As ParkingRepository
        Private _currentParking As Parking

        ' Constructor Default
        Public Sub New()
            InitializeComponent()
            _paymentController = New PaymentController()
            _parkingRepository = New ParkingRepository()
        End Sub

        ' Constructor dengan parameter plat nomor otomatis
        Public Sub New(plateNumber As String)
            Me.New()
            txtPlateNumber.Text = plateNumber.Trim().ToUpper()
            If Not String.IsNullOrEmpty(txtPlateNumber.Text) Then
                ProcessCalculation()
            End If
        End Sub

        Private Sub ExitForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If cmbPaymentMethod.Items.Count > 0 Then
                cmbPaymentMethod.SelectedIndex = 0
            End If
            LoadAutoCompleteData()
            If String.IsNullOrEmpty(txtPlateNumber.Text) Then
                ResetForm()
            End If
        End Sub

        Private Sub LoadAutoCompleteData()
            Dim activePlates As List(Of String) = _parkingRepository.GetActivePlateNumbers()
            Dim collection As New AutoCompleteStringCollection()
            collection.AddRange(activePlates.ToArray())

            txtPlateNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtPlateNumber.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtPlateNumber.AutoCompleteCustomSource = collection
        End Sub

        Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
            ProcessCalculation()
        End Sub

        Private Sub chkLostTicket_CheckedChanged(sender As Object, e As EventArgs) Handles chkLostTicket.CheckedChanged
            If _currentParking IsNot Nothing Then
                ProcessCalculation()
            End If
        End Sub

        Private Sub ProcessCalculation()
            Dim errorMessage As String = String.Empty
            Dim activeMember As Member = Nothing

            _currentParking = _paymentController.CalculateExitDetails(txtPlateNumber.Text, chkLostTicket.Checked, activeMember, errorMessage)

            If _currentParking IsNot Nothing Then
                lblTypeVal.Text = _currentParking.VehicleType
                lblEntryTimeVal.Text = _currentParking.EntryTime.ToString("dd/MM/yyyy HH:mm")
                lblDurationVal.Text = $"{_currentParking.Duration} Jam"
                lblBaseFeeVal.Text = $"Rp {_currentParking.ParkingFee:N0}"
                lblFineVal.Text = $"Rp {_currentParking.LostTicketFine:N0}"
                lblOvernightVal.Text = $"Rp {_currentParking.OvernightFee:N0}"
                lblDiscountVal.Text = $"Rp {_currentParking.Discount:N0}"
                lblTotalPay.Text = $"Rp {_currentParking.TotalPayment:N0}"

                If activeMember IsNot Nothing Then
                    lblMemberInfo.Text = $"* Terdeteksi Member ({activeMember.OwnerName})"
                    lblMemberInfo.ForeColor = Color.FromArgb(16, 185, 129)
                Else
                    lblMemberInfo.Text = "* Bukan Member"
                    lblMemberInfo.ForeColor = Color.FromArgb(100, 116, 139)
                End If
            Else
                MessageBox.Show(errorMessage, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ResetForm()
            End If
        End Sub

        Private Sub btnProcessPayment_Click(sender As Object, e As EventArgs) Handles btnProcessPayment.Click
            If _currentParking Is Nothing Then
                MessageBox.Show("Silakan cari kendaraan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim errorMessage As String = String.Empty
            Dim selectedMethod As String = If(cmbPaymentMethod.SelectedItem IsNot Nothing, cmbPaymentMethod.SelectedItem.ToString(), "Tunai")
            Dim referenceNumber As String = String.Empty

            ' 1. PEMICU DIALOG PEMBAYARAN NON-TUNAI (QRIS & DEBIT)
            If selectedMethod.Equals("QRIS", StringComparison.OrdinalIgnoreCase) Then
                Using qrisForm As New QrisPaymentForm(_currentParking.TotalPayment, $"Parkir Keluar - {_currentParking.PlateNumber}")
                    Dim result As DialogResult = qrisForm.ShowDialog(Me)
                    If result <> DialogResult.OK Then
                        MessageBox.Show("Pembayaran QRIS dibatalkan. Transaksi parkir keluar dihentikan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                    referenceNumber = qrisForm.GeneratedReferenceNumber
                End Using

            ElseIf selectedMethod.Equals("Transfer / Debit", StringComparison.OrdinalIgnoreCase) OrElse selectedMethod.Equals("Debit", StringComparison.OrdinalIgnoreCase) Then
                Using debitForm As New DebitPaymentForm(_currentParking.TotalPayment, $"Parkir Keluar - {_currentParking.PlateNumber}")
                    Dim result As DialogResult = debitForm.ShowDialog(Me)
                    If result <> DialogResult.OK Then
                        MessageBox.Show("Pembayaran Debit dibatalkan. Transaksi parkir keluar dihentikan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                    referenceNumber = debitForm.CardOrReferenceNumber
                End Using
            End If

            ' PERBAIKAN: Masukkan nomor referensi ke dalam objek _currentParking sebelum diproses oleh controller
            _currentParking.ReferenceNumber = referenceNumber
            _currentParking.PaymentMethod = selectedMethod

            ' 2. EKSEKUSI PENYIMPANAN TRANSAKSI PARKIR KELUAR
            Dim isSuccess As Boolean = _paymentController.ProcessPayment(_currentParking, selectedMethod, errorMessage)

            If isSuccess Then
                Dim askReceipt As DialogResult = MessageBox.Show(
                    $"Pembayaran Berhasil!{vbCrLf}Metode: {selectedMethod}{vbCrLf}Ref/Kartu: {If(String.IsNullOrEmpty(referenceNumber), "-", referenceNumber)}{vbCrLf}Total: Rp {_currentParking.TotalPayment:N0}{vbCrLf}{vbCrLf}Cetak struk bukti pembayaran?",
                    "Sukses",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                )

                If askReceipt = DialogResult.Yes Then
                    Helpers.TicketPrinterHelper.PrintExitReceipt(_currentParking)
                End If

                txtPlateNumber.Clear()
                LoadAutoCompleteData()
                ResetForm()
            Else
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub

        Private Sub ResetForm()
            _currentParking = Nothing
            lblTypeVal.Text = "-"
            lblEntryTimeVal.Text = "-"
            lblDurationVal.Text = "-"
            lblBaseFeeVal.Text = "Rp 0"
            lblFineVal.Text = "Rp 0"
            lblOvernightVal.Text = "Rp 0"
            lblDiscountVal.Text = "Rp 0"
            lblTotalPay.Text = "Rp 0"
            lblMemberInfo.Text = String.Empty
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

    End Class
End Namespace