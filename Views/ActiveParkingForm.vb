Imports System
Imports System.Data
Imports System.Windows.Forms
Imports ParkingManagementSystem.Repositories

Namespace Views
    Partial Public Class ActiveParkingForm
        Inherits Form

        Private ReadOnly _parkingRepository As ParkingRepository
        Private _dtActiveData As DataTable

        Public Sub New()
            InitializeComponent()
            _parkingRepository = New ParkingRepository()
        End Sub

        Private Sub ActiveParkingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        Private Sub LoadData()
            _dtActiveData = _parkingRepository.GetActiveParkingDataTable()
            dgvActiveParking.DataSource = _dtActiveData
            lblTotalCount.Text = $"Total Kendaraan: {_dtActiveData.Rows.Count} Unit"
        End Sub

        Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
            If _dtActiveData IsNot Nothing Then
                Dim filterText As String = txtSearch.Text.Trim().Replace("'", "''")
                Dim dv As DataView = _dtActiveData.DefaultView
                dv.RowFilter = $"[Nomor Polisi] LIKE '%{filterText}%'"
                lblTotalCount.Text = $"Total Kendaraan: {dv.Count} Unit"
            End If
        End Sub

        ''' <summary>
        ''' Membuka ExitForm dengan membawa plat nomor baris yang sedang dipilih
        ''' </summary>
        Private Sub OpenExitFormForSelectedRow()
            If dgvActiveParking.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvActiveParking.SelectedRows(0)
                Dim plateNumber As String = selectedRow.Cells("Nomor Polisi").Value.ToString()

                Dim exitForm As New ExitForm(plateNumber)
                exitForm.ShowDialog(Me)

                ' Refresh data setelah proses keluar selesai
                LoadData()
            Else
                MessageBox.Show("Silakan pilih salah satu baris kendaraan terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub btnProcessCheckout_Click(sender As Object, e As EventArgs) Handles btnProcessCheckout.Click
            OpenExitFormForSelectedRow()
        End Sub

        Private Sub tsmiCheckout_Click(sender As Object, e As EventArgs) Handles tsmiCheckout.Click
            OpenExitFormForSelectedRow()
        End Sub

        Private Sub dgvActiveParking_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActiveParking.CellDoubleClick
            If e.RowIndex >= 0 Then
                OpenExitFormForSelectedRow()
            End If
        End Sub

        Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
            txtSearch.Clear()
            LoadData()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace