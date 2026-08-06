Imports System
Imports System.Data
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Helpers

Namespace Views
    ''' <summary>
    ''' Form HistoryForm menampilkan riwayat transaksi parkir kendaraan yang telah selesai (Status 'OUT').
    ''' Menyediakan pencarian plat nomor, penyaringan rentang tanggal dan tipe kendaraan, serta menampilkan total akumulasi pendapatan.
    ''' </summary>
    Partial Public Class HistoryForm
        Inherits Form

        Private ReadOnly _historyController As HistoryController
        Private _rawHistoryData As DataTable
        Private _currentPage As Integer = 1
        Private _totalPages As Integer = 1
        Private _totalRows As Integer = 0

        ''' <summary>
        ''' Constructor untuk menginisialisasi Form Riwayat Transaksi.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            _historyController = New HistoryController()
        End Sub

        Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Pengaturan awal rentang tanggal default: 30 hari terakhir hingga hari ini
            dtpStartDate.Value = DateTime.Now.AddDays(-30)
            dtpEndDate.Value = DateTime.Now
            cmbVehicleType.SelectedIndex = 0
            LoadData()
        End Sub

        ''' <summary>
        ''' Memuat data riwayat transaksi parkir berdasarkan parameter filter dan merender total pendapatan ke label UI.
        ''' </summary>
        Private Sub LoadData()
            Dim totalRevenue As Decimal = 0
            Dim totalCount As Integer = 0

            Dim selectedType As String = If(cmbVehicleType.SelectedItem IsNot Nothing, cmbVehicleType.SelectedItem.ToString(), "Semua")

            _rawHistoryData = _historyController.FetchHistory(
                dtpStartDate.Value,
                dtpEndDate.Value,
                selectedType,
                txtSearchPlate.Text,
                totalRevenue,
                totalCount
            )

            _currentPage = 1
            ApplyPagination()

            ' Merender teks ringkasan jumlah unit kendaraan dan total rupiah pendapatan
            lblTotalCount.Text = $"{totalCount} Unit"
            lblTotalRevenue.Text = $"Rp {totalRevenue:N0}"
        End Sub

        ''' <summary>
        ''' Menerapkan paginasi data 20 baris, sembunyikan ID, dan beri penomoran urut 'No'.
        ''' </summary>
        Private Sub ApplyPagination()
            If _rawHistoryData Is Nothing Then Exit Sub

            _totalRows = _rawHistoryData.Rows.Count
            _totalPages = PaginationHelper.GetTotalPages(_totalRows, PaginationHelper.DEFAULT_PAGE_SIZE)

            If _currentPage > _totalPages Then _currentPage = _totalPages
            If _currentPage < 1 Then _currentPage = 1

            Dim pagedTable As DataTable = PaginationHelper.GetPagedTable(_rawHistoryData, _currentPage, PaginationHelper.DEFAULT_PAGE_SIZE)
            dgvHistory.DataSource = pagedTable

            ' Sembunyikan kolom ID dan atur format No
            If dgvHistory.Columns("ID") IsNot Nothing Then dgvHistory.Columns("ID").Visible = False
            If dgvHistory.Columns("Id") IsNot Nothing Then dgvHistory.Columns("Id").Visible = False

            If dgvHistory.Columns("No") IsNot Nothing Then
                dgvHistory.Columns("No").HeaderText = "No"
                dgvHistory.Columns("No").Width = 50
                dgvHistory.Columns("No").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            lblPageInfo.Text = $"HALAMAN {_currentPage} DARI {_totalPages} (TOTAL {_totalRows} DATA)"

            btnPrev.Enabled = (_currentPage > 1)
            btnNext.Enabled = (_currentPage < _totalPages)
        End Sub

        Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
            If _currentPage > 1 Then
                _currentPage -= 1
                ApplyPagination()
            End If
        End Sub

        Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
            If _currentPage < _totalPages Then
                _currentPage += 1
                ApplyPagination()
            End If
        End Sub

        Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
            LoadData()
        End Sub

        Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
            dtpStartDate.Value = DateTime.Now.AddDays(-30)
            dtpEndDate.Value = DateTime.Now
            cmbVehicleType.SelectedIndex = 0
            txtSearchPlate.Clear()
            LoadData()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace