Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Models

Namespace Views
    Public Class TariffManagementForm
        Private ReadOnly _tariffController As TariffController

        Public Sub New()
            InitializeComponent()
            _tariffController = New TariffController()
        End Sub

        Private Sub TariffManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadTariffData()
            ClearForm()
        End Sub

        Private Sub LoadTariffData()
            Try
                Dim list As List(Of Tariff) = _tariffController.GetAllTariffs()
                dgvTariffs.DataSource = Nothing
                dgvTariffs.DataSource = list

                If dgvTariffs.Columns("Id") IsNot Nothing Then dgvTariffs.Columns("Id").Visible = False
                If dgvTariffs.Columns("VehicleType") IsNot Nothing Then dgvTariffs.Columns("VehicleType").HeaderText = "Tipe Kendaraan"
                If dgvTariffs.Columns("HourlyRate") IsNot Nothing Then
                    dgvTariffs.Columns("HourlyRate").HeaderText = "Tarif / Jam (Rp)"
                    dgvTariffs.Columns("HourlyRate").DefaultCellStyle.Format = "N0"
                End If
                If dgvTariffs.Columns("OvernightRate") IsNot Nothing Then
                    dgvTariffs.Columns("OvernightRate").HeaderText = "Tarif / Malam (Rp)"
                    dgvTariffs.Columns("OvernightRate").DefaultCellStyle.Format = "N0"
                End If
                If dgvTariffs.Columns("CreatedAt") IsNot Nothing Then dgvTariffs.Columns("CreatedAt").Visible = False
                If dgvTariffs.Columns("UpdatedAt") IsNot Nothing Then dgvTariffs.Columns("UpdatedAt").Visible = False
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat memuat data tarif: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub dgvTariffs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTariffs.CellClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvTariffs.Rows(e.RowIndex)
                txtVehicleType.Text = row.Cells("VehicleType").Value.ToString()
                numHourlyRate.Value = Convert.ToDecimal(row.Cells("HourlyRate").Value)
                numOvernightRate.Value = Convert.ToDecimal(row.Cells("OvernightRate").Value)
            End If
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim errorMsg As String = String.Empty
            Dim success As Boolean = _tariffController.UpdateTariff(txtVehicleType.Text, numHourlyRate.Value, numOvernightRate.Value, errorMsg)

            If success Then
                MessageBox.Show("Tarif berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadTariffData()
                ClearForm()
            Else
                MessageBox.Show(errorMsg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
            ClearForm()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub ClearForm()
            txtVehicleType.Clear()
            numHourlyRate.Value = 0
            numOvernightRate.Value = 0
        End Sub
    End Class
End Namespace