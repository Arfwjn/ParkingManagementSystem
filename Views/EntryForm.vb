Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Helpers
Imports ParkingManagementSystem.Models

Namespace Views
    Public Class EntryForm
        Private ReadOnly _controller As ParkingController

        Public Sub New()
            InitializeComponent()
            _controller = New ParkingController()
        End Sub

        Private Sub EntryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If cmbVehicleType.Items.Count > 0 Then
                cmbVehicleType.SelectedIndex = 0
            End If
            UpdateTariffDisplay()
        End Sub

        ''' <summary>
        ''' Deteksi otomatis status member saat plat nomor diubah
        ''' </summary>
        Private Sub txtPlateNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPlateNumber.TextChanged
            Dim plate As String = txtPlateNumber.Text.Trim()

            If plate.Length >= 3 Then
                Dim memberStatus = _controller.CheckMemberStatus(plate)
                If memberStatus.Item1 Then
                    ' IsMember = True
                    lblMemberStatus.Text = $"* Member Terdeteksi: {memberStatus.Item2} ({memberStatus.Item3} - Diskon {memberStatus.Item4:N0}%)"
                    lblMemberStatus.ForeColor = Color.FromArgb(16, 185, 129) ' Emerald Green Accent
                Else
                    lblMemberStatus.Text = "* Status: Non-Member / Umum"
                    lblMemberStatus.ForeColor = Color.FromArgb(100, 116, 139) ' Gray Accent
                End If
            Else
                lblMemberStatus.Text = "* Status: Non-Member / Umum"
                lblMemberStatus.ForeColor = Color.FromArgb(100, 116, 139)
            End If
        End Sub

        ''' <summary>
        ''' Memperbarui informasi tarif saat jenis kendaraan dipilih
        ''' </summary>
        Private Sub cmbVehicleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVehicleType.SelectedIndexChanged
            UpdateTariffDisplay()
        End Sub

        Private Sub UpdateTariffDisplay()
            If cmbVehicleType.SelectedItem IsNot Nothing Then
                Dim vehicleType As String = cmbVehicleType.SelectedItem.ToString()
                Dim tariff As Tariff = _controller.GetTariffInfo(vehicleType)

                If tariff IsNot Nothing Then
                    lblTariffInfo.Text = $"* Tarif: Per Jam: Rp {tariff.HourlyRate:N0} | Inap: Rp {tariff.OvernightRate:N0}"
                Else
                    lblTariffInfo.Text = "* Tarif Belum Dikonfigurasi (Menggunakan Default)"
                End If
            End If
        End Sub

        Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
            Dim plateNumber As String = txtPlateNumber.Text
            Dim vehicleType As String = If(cmbVehicleType.SelectedItem IsNot Nothing, cmbVehicleType.SelectedItem.ToString(), "")
            Dim currentUserId As Nullable(Of Integer) = If(SessionManager.CurrentUser IsNot Nothing, SessionManager.CurrentUser.Id, CType(Nothing, Nullable(Of Integer)))

            Dim errorMessage As String = String.Empty
            Dim success As Boolean = _controller.ProcessEntry(plateNumber, vehicleType, currentUserId, errorMessage)

            If success Then
                MessageBox.Show($"Kendaraan '{plateNumber.Trim().ToUpper()}' berhasil masuk area parkir!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Opsi Cetak Struk Tiket Masuk
                Dim printReceipt As DialogResult = MessageBox.Show("Cetak Tiket Masuk Parkir?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If printReceipt = DialogResult.Yes Then
                    Dim parkingObj As New Parking() With {
                        .PlateNumber = plateNumber.Trim().ToUpper(),
                        .VehicleType = vehicleType,
                        .EntryTime = DateTime.Now
                    }
                    TicketPrinterHelper.PrintEntryTicket(parkingObj)
                End If

                txtPlateNumber.Clear()
                txtPlateNumber.Focus()
            Else
                MessageBox.Show(errorMessage, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace