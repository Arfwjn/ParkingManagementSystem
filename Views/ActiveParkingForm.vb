Imports System
Imports System.Data
Imports System.Windows.Forms
Imports ParkingManagementSystem.Helpers
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
        Private _currentPage As Integer = 1
        Private _totalPages As Integer = 1
        Private _totalRows As Integer = 0

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
            _currentPage = 1
            ApplyPaginationAndFilter()
        End Sub

        ''' <summary>
        ''' Menerapkan penyaringan (filtering), penyembunyian kolom ID, penomoran urut 'No', dan paginasi data.
        ''' </summary>
        Private Sub ApplyPaginationAndFilter()
            If _dtActiveData Is Nothing Then Exit Sub

            Dim filterText As String = txtSearch.Text.Trim().Replace("'", "''")
            Dim dv As DataView = _dtActiveData.DefaultView
            dv.RowFilter = $"[Nomor Polisi] LIKE '%{filterText}%'"

            Dim filteredTable As DataTable = dv.ToTable()
            _totalRows = filteredTable.Rows.Count
            _totalPages = PaginationHelper.GetTotalPages(_totalRows, PaginationHelper.DEFAULT_PAGE_SIZE)

            If _currentPage > _totalPages Then _currentPage = _totalPages
            If _currentPage < 1 Then _currentPage = 1

            Dim pagedTable As DataTable = PaginationHelper.GetPagedTable(filteredTable, _currentPage, PaginationHelper.DEFAULT_PAGE_SIZE)
            dgvActiveParking.DataSource = pagedTable

            ' Sembunyikan kolom ID dan format kolom No
            If dgvActiveParking.Columns("ID") IsNot Nothing Then dgvActiveParking.Columns("ID").Visible = False
            If dgvActiveParking.Columns("Id") IsNot Nothing Then dgvActiveParking.Columns("Id").Visible = False

            If dgvActiveParking.Columns("No") IsNot Nothing Then
                dgvActiveParking.Columns("No").HeaderText = "No"
                dgvActiveParking.Columns("No").Width = 50
                dgvActiveParking.Columns("No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            lblTotalCount.Text = $"Total Kendaraan: {_totalRows} Unit"
            lblPageInfo.Text = $"HALAMAN {_currentPage} DARI {_totalPages} (TOTAL {_totalRows} DATA)"

            btnPrev.Enabled = (_currentPage > 1)
            btnNext.Enabled = (_currentPage < _totalPages)
        End Sub

        Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
            If _currentPage > 1 Then
                _currentPage -= 1
                ApplyPaginationAndFilter()
            End If
        End Sub

        Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
            If _currentPage < _totalPages Then
                _currentPage += 1
                ApplyPaginationAndFilter()
            End If
        End Sub

        ''' <summary>
        ''' Penyaringan (filtering) data secara real-time pada DataGridView berdasarkan input nomor polisi.
        ''' </summary>
        Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
            _currentPage = 1
            ApplyPaginationAndFilter()
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