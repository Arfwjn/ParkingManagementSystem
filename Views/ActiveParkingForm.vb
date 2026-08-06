Imports System
Imports System.Data
Imports System.Windows.Forms
Imports ParkingManagementSystem.Repositories

Namespace Views
    ''' <summary>
    ''' Form ActiveParkingForm menampilkan daftar seluruh kendaraan yang saat ini sedang aktif parkir di dalam area parkir.
    ''' Menyediakan pencarian cepat nomor polisi dan akses langsung ke proses kendaraan keluar (Check-Out).
    ''' </summary>
    Partial Public Class ActiveParkingForm
        Inherits Form

        Private ReadOnly _parkingRepository As ParkingRepository
        Private _dtActiveData As DataTable

        ''' <summary>
        ''' Constructor untuk menginisialisasi komponen UI Form Parkir Aktif.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            _parkingRepository = New ParkingRepository()
        End Sub

        ''' <summary>
        ''' Handler event saat Form dimuat pertama kali.
        ''' </summary>
        Private Sub ActiveParkingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        ''' <summary>
        ''' Memuat data kendaraan aktif dari database dan memperbarui label total unit kendaraan.
        ''' </summary>
        Private Sub LoadData()
            _dtActiveData = _parkingRepository.GetActiveParkingDataTable()
            dgvActiveParking.DataSource = _dtActiveData
            lblTotalCount.Text = $"Total Kendaraan: {_dtActiveData.Rows.Count} Unit"
        End Sub

        ''' <summary>
        ''' Penyaringan (filtering) data secara real-time pada DataGridView berdasarkan input nomor polisi.
        ''' </summary>
        Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
            If _dtActiveData IsNot Nothing Then
                Dim filterText As String = txtSearch.Text.Trim().Replace("'", "''")
                Dim dv As DataView = _dtActiveData.DefaultView
                dv.RowFilter = $"[Nomor Polisi] LIKE '%{filterText}%'"
                lblTotalCount.Text = $"Total Kendaraan: {dv.Count} Unit"
            End If
        End Sub

        ''' <summary>
        ''' Membuka dialog ExitForm untuk memproses transaksi keluar kendaraan yang barisnya sedang dipilih.
        ''' </summary>
        Private Sub OpenExitFormForSelectedRow()
            If dgvActiveParking.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvActiveParking.SelectedRows(0)
                Dim plateNumber As String = selectedRow.Cells("Nomor Polisi").Value.ToString()

                Dim exitForm As New ExitForm(plateNumber)
                exitForm.ShowDialog(Me)

                ' Memperbarui ulang daftar kendaraan aktif setelah proses keluar selesai
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