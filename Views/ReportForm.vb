Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Models

Namespace Views
    ''' <summary>
    ''' Form ReportForm mengelola tampilan laporan rekapitulasi transaksi parkir secara harian, mingguan/kustom, dan bulanan.
    ''' Menyediakan agregasi statistik (pendapatan per metode bayar, jumlah unit) serta fitur ekspor berkas CSV (Excel).
    ''' </summary>
    Public Class ReportForm
        Private ReadOnly _reportController As ReportController
        Private _currentReportList As List(Of Parking)

        ''' <summary>
        ''' Constructor untuk menginisialisasi Form Laporan Parkir.
        ''' </summary>
        Sub New()
            InitializeComponent()
            _reportController = New ReportController()
        End Sub

        Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Inisialisasi pilihan rentang 5 tahun terakhir pada ComboBox Tahun
            cmbYear.Items.Clear()
            Dim currentYear As Integer = DateTime.Now.Year
            For y As Integer = currentYear To currentYear - 4 Step -1
                cmbYear.Items.Add(y)
            Next
            cmbYear.SelectedIndex = 0
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1

            ' Menetapkan pilihan default tipe filter laporan ke "Harian"
            cmbReportType.SelectedIndex = 0

            ' Memuat data laporan harian pertama kali saat form dibuka
            LoadReportData()
        End Sub

        ''' <summary>
        ''' Event handler perubahan pilihan jenis filter laporan (Harian / Mingguan / Bulanan) untuk menyembunyikan/menampilkan kontrol tanggal.
        ''' </summary>
        Private Sub cmbReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReportType.SelectedIndexChanged
            Dim selectedType As String = cmbReportType.SelectedItem.ToString()

            If selectedType = "Harian" Then
                lblDateStart.Text = "Tanggal:"
                lblDateStart.Visible = True
                dtpStartDate.Visible = True

                lblDateEnd.Visible = False
                dtpEndDate.Visible = False
                lblMonth.Visible = False
                cmbMonth.Visible = False
                lblYear.Visible = False
                cmbYear.Visible = False

            ElseIf selectedType = "Mingguan" Then
                lblDateStart.Text = "Dari Tanggal:"
                lblDateStart.Visible = True
                dtpStartDate.Visible = True

                lblDateEnd.Visible = True
                dtpEndDate.Visible = True
                lblMonth.Visible = False
                cmbMonth.Visible = False
                lblYear.Visible = False
                cmbYear.Visible = False

            ElseIf selectedType = "Bulanan" Then
                lblDateStart.Visible = False
                dtpStartDate.Visible = False
                lblDateEnd.Visible = False
                dtpEndDate.Visible = False

                lblMonth.Visible = True
                cmbMonth.Visible = True
                lblYear.Visible = True
                cmbYear.Visible = True
            End If
        End Sub

        Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
            LoadReportData()
        End Sub

        ''' <summary>
        ''' Memuat data laporan parkir dari database sesuai parameter filter harian/mingguan/bulanan yang sedang dipilih.
        ''' </summary>
        Private Sub LoadReportData()
            Try
                Dim selectedType As String = cmbReportType.SelectedItem.ToString()
                Dim summary As New ParkingReportSummary()

                If selectedType = "Harian" Then
                    _currentReportList = _reportController.GetDailyReportData(dtpStartDate.Value, summary)

                ElseIf selectedType = "Mingguan" Then
                    _currentReportList = _reportController.GetWeeklyReportData(dtpStartDate.Value, dtpEndDate.Value, summary)

                ElseIf selectedType = "Bulanan" Then
                    Dim selectedMonth As Integer = cmbMonth.SelectedIndex + 1
                    Dim selectedYear As Integer = Convert.ToInt32(cmbYear.SelectedItem)
                    _currentReportList = _reportController.GetMonthlyReportData(selectedMonth, selectedYear, summary)
                End If

                ' Merender ringkasan total transaksi dan breakdown pendapatan ke UI
                lblTotalTrxVal.Text = summary.TotalTransactions.ToString("N0")
                lblTotalRevenueVal.Text = $"Rp {summary.TotalRevenue:N0}"
                lblMethodBreakdown.Text = $"Rincian: Cash: Rp {summary.TotalCashRevenue:N0} | QRIS: Rp {summary.TotalQrisRevenue:N0} | Debit/Transfer: Rp {summary.TotalDebitRevenue:N0}"

                ' Mengisi data transaksi ke DataGridView
                DisplayDataToGrid(_currentReportList)

            Catch ex As Exception
                MessageBox.Show("Gagal memuat laporan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Memformat dan merender daftar transaksi parkir ke tabel DataGridView.
        ''' </summary>
        Private Sub DisplayDataToGrid(data As List(Of Parking))
            dgvReport.Columns.Clear()

            If data Is Nothing OrElse data.Count = 0 Then
                dgvReport.DataSource = Nothing
                Return
            End If

            ' Mengatur struktur kolom tabel
            dgvReport.AutoGenerateColumns = False

            dgvReport.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colPlate", .HeaderText = "Plat Nomor", .DataPropertyName = "PlateNumber"})
            dgvReport.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colType", .HeaderText = "Jenis", .DataPropertyName = "VehicleType"})
            dgvReport.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colEntry", .HeaderText = "Waktu Masuk", .DataPropertyName = "EntryTime"})
            dgvReport.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colExit", .HeaderText = "Waktu Keluar", .DataPropertyName = "ExitTime"})
            dgvReport.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colDuration", .HeaderText = "Durasi (Jam)", .DataPropertyName = "Duration"})
            dgvReport.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colFee", .HeaderText = "Total Bayar", .DataPropertyName = "TotalPayment"})
            dgvReport.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colMethod", .HeaderText = "Metode", .DataPropertyName = "PaymentMethod"})
            dgvReport.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colRef", .HeaderText = "Ref Transaksi / Kartu", .DataPropertyName = "ReferenceNumber"})

            ' Format tampilan tanggal dan format uang rupiah
            dgvReport.Columns("colEntry").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            dgvReport.Columns("colExit").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            dgvReport.Columns("colFee").DefaultCellStyle.Format = "Rp #,##0"

            dgvReport.DataSource = data
        End Sub

        ''' <summary>
        ''' Mengekspor seluruh baris data laporan parkir yang sedang ditampilkan ke dalam berkas CSV (Comma Separated Values) untuk Microsoft Excel.
        ''' </summary>
        Private Sub btnExportCsv_Click(sender As Object, e As EventArgs) Handles btnExportCsv.Click
            If _currentReportList Is Nothing OrElse _currentReportList.Count = 0 Then
                MessageBox.Show("Tidak ada data laporan untuk diekspor.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using sfd As New SaveFileDialog()
                sfd.Filter = "CSV File (*.csv)|*.csv"
                sfd.FileName = $"Laporan_Parkir_{DateTime.Now:yyyyMMdd_HHmmss}.csv"

                If sfd.ShowDialog() = DialogResult.OK Then
                    Try
                        Dim sb As New StringBuilder()
                        ' Menulis baris header kolom CSV
                        sb.AppendLine("Plat Nomor,Jenis Kendaraan,Waktu Masuk,Waktu Keluar,Durasi (Jam),Total Bayar,Metode Pembayaran,Ref Transaksi / Kartu")

                        For Each item In _currentReportList
                            ' Menggunakan double quote escape ("") untuk data teks CSV
                            sb.AppendLine($"""{item.PlateNumber}"",""{item.VehicleType}"",""{item.EntryTime:yyyy-MM-dd HH:mm:ss}"",""{item.ExitTime:yyyy-MM-dd HH:mm:ss}"",{item.Duration},{item.TotalPayment},""{item.PaymentMethod}"",""{item.ReferenceNumber}""")
                        Next

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8)
                        MessageBox.Show("Laporan berhasil diekspor ke berkas CSV.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Gagal mengekspor laporan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace