Imports System
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers

Namespace Views
    Partial Public Class EntryForm
        Inherits Form

        Private ReadOnly _parkingController As ParkingController

        Public Sub New()
            InitializeComponent()
            _parkingController = New ParkingController()
        End Sub

        Private Sub EntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If cmbVehicleType.Items.Count > 0 Then
                cmbVehicleType.SelectedIndex = 0
            End If
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            lblStatusMessage.Text = String.Empty
            Dim errorMessage As String = String.Empty

            Dim selectedType As String = If(cmbVehicleType.SelectedItem IsNot Nothing, cmbVehicleType.SelectedItem.ToString(), "")

            Dim isSuccess As Boolean = _parkingController.RegisterEntry(txtPlateNumber.Text, selectedType, errorMessage)

            If isSuccess Then
                Dim askPrint As DialogResult = MessageBox.Show(
            "Data kendaraan berhasil disimpan!" & vbCrLf & "Apakah Anda ingin mencetak karcis parkir?",
            "Konfirmasi Cetak",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

                If askPrint = DialogResult.Yes Then
                    ' Ambil data transaksi terbaru untuk dicetak
                    Dim activeParking = _parkingController.GetActiveParkingByPlate(txtPlateNumber.Text.Trim().ToUpper())
                    If activeParking IsNot Nothing Then
                        Helpers.TicketPrinterHelper.PrintEntryTicket(activeParking)
                    End If
                End If

                txtPlateNumber.Clear()
                txtPlateNumber.Focus()
            Else
                lblStatusMessage.Text = errorMessage
            End If
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace