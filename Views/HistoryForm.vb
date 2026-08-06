Imports System
Imports System.Data
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers

Namespace Views
    ''' <summary>
    ''' Form HistoryForm menampilkan riwayat transaksi parkir kendaraan yang telah selesai (Status 'OUT').
    ''' Menyediakan pencarian plat nomor, penyaringan rentang tanggal dan tipe kendaraan, serta menampilkan total akumulasi pendapatan.
    ''' </summary>
    Partial Public Class HistoryForm
        Inherits Form

        Private ReadOnly _historyController As HistoryController

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

            Dim dt As DataTable = _historyController.FetchHistory(
                dtpStartDate.Value,
                dtpEndDate.Value,
                selectedType,
                txtSearchPlate.Text,
                totalRevenue,
                totalCount
            )

            dgvHistory.DataSource = dt

            ' Merender teks ringkasan jumlah unit kendaraan dan total rupiah pendapatan
            lblTotalCount.Text = $"{totalCount} Unit"
            lblTotalRevenue.Text = $"Rp {totalRevenue:N0}"
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
End NamespaceEnd Sub

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