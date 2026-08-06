Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Models

Namespace Views
    ''' <summary>
    ''' Form TariffManagementForm menyediakan antarmuka untuk mengubah dan mengatur tarif parkir per jam serta tarif menginap per jenis kendaraan (Mobil dan Motor).
    ''' </summary>
    Public Class TariffManagementForm
        Private ReadOnly _tariffController As TariffController

        ''' <summary>
        ''' Constructor untuk menginisialisasi Form Kelola Tarif.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            _tariffController = New TariffController()
        End Sub

        Private Sub TariffManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadTariffData()
            ClearForm()
        End Sub

        ''' <summary>
        ''' Memuat seluruh data konfigurasi tarif kendaraan dari database dan merender ke DataGridView.
        ''' </summary>
        Private Sub LoadTariffData()
            Try
                Dim list As List(Of Tariff) = _tariffController.GetAllTariffs()
                dgvTariffs.Columns.Clear()
                dgvTariffs.AutoGenerateColumns = False

                dgvTariffs.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colNo", .HeaderText = "No"})
                dgvTariffs.Columns("colNo").Width = 50
                dgvTariffs.Columns("colNo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgvTariffs.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Id", .HeaderText = "Id", .DataPropertyName = "Id", .Visible = False})
                dgvTariffs.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "VehicleType", .HeaderText = "Tipe Kendaraan", .DataPropertyName = "VehicleType"})
                dgvTariffs.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "HourlyRate", .HeaderText = "Tarif / Jam (Rp)", .DataPropertyName = "HourlyRate"})
                dgvTariffs.Columns("HourlyRate").DefaultCellStyle.Format = "N0"
                dgvTariffs.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "OvernightRate", .HeaderText = "Tarif / Malam (Rp)", .DataPropertyName = "OvernightRate"})
                dgvTariffs.Columns("OvernightRate").DefaultCellStyle.Format = "N0"

                dgvTariffs.DataSource = list

                For i As Integer = 0 To dgvTariffs.Rows.Count - 1
                    dgvTariffs.Rows(i).Cells("colNo").Value = i + 1
                Next
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat memuat data tarif: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Memindahkan data tarif dari baris DataGridView yang diklik ke kontrol input form.
        ''' </summary>
        Private Sub dgvTariffs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTariffs.CellClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = dgvTariffs.Rows(e.RowIndex)
                txtVehicleType.Text = row.Cells("VehicleType").Value.ToString()
                numHourlyRate.Value = Convert.ToDecimal(row.Cells("HourlyRate").Value)
                numOvernightRate.Value = Convert.ToDecimal(row.Cells("OvernightRate").Value)
                btnSave.Text = "PERBARUI"
            End If
        End Sub

        ''' <summary>
        ''' Memvalidasi dan menyimpan pembaruan nilai tarif parkir ke database.
        ''' </summary>
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
            btnSave.Text = "SIMPAN"
        End Sub
    End Class
End Namespace