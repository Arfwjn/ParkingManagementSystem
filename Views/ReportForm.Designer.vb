Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ReportForm
        Inherits System.Windows.Forms.Form

        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.pnlFilterCard = New System.Windows.Forms.Panel()
            Me.lblReportType = New System.Windows.Forms.Label()
            Me.cmbReportType = New System.Windows.Forms.ComboBox()
            Me.lblDateStart = New System.Windows.Forms.Label()
            Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
            Me.lblDateEnd = New System.Windows.Forms.Label()
            Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
            Me.lblMonth = New System.Windows.Forms.Label()
            Me.cmbMonth = New System.Windows.Forms.ComboBox()
            Me.lblYear = New System.Windows.Forms.Label()
            Me.cmbYear = New System.Windows.Forms.ComboBox()
            Me.btnFilter = New System.Windows.Forms.Button()
            Me.pnlSummaryCard = New System.Windows.Forms.Panel()
            Me.lblTotalTrxTitle = New System.Windows.Forms.Label()
            Me.lblTotalTrxVal = New System.Windows.Forms.Label()
            Me.lblTotalRevenueTitle = New System.Windows.Forms.Label()
            Me.lblTotalRevenueVal = New System.Windows.Forms.Label()
            Me.lblMethodBreakdown = New System.Windows.Forms.Label()
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.btnExportCsv = New System.Windows.Forms.Button()
            Me.dgvReport = New System.Windows.Forms.DataGridView()
            Me.pnlPagination = New System.Windows.Forms.Panel()
            Me.btnPrev = New System.Windows.Forms.Button()
            Me.lblPageInfo = New System.Windows.Forms.Label()
            Me.btnNext = New System.Windows.Forms.Button()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlFilterCard.SuspendLayout()
            Me.pnlSummaryCard.SuspendLayout()
            Me.pnlGridCard.SuspendLayout()
            Me.pnlPagination.SuspendLayout()
            CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.btnClose)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(1200, 60)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(20, 18)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(321, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "LAPORAN PENDAPATAN PARKIR"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(1150, 12)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(38, 35)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "X"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.pnlMain.Controls.Add(Me.pnlFilterCard)
            Me.pnlMain.Controls.Add(Me.pnlSummaryCard)
            Me.pnlMain.Controls.Add(Me.pnlGridCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 60)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
            Me.pnlMain.Size = New System.Drawing.Size(1200, 640)
            Me.pnlMain.TabIndex = 1
            '
            'pnlFilterCard
            '
            Me.pnlFilterCard.BackColor = System.Drawing.Color.White
            Me.pnlFilterCard.Controls.Add(Me.lblReportType)
            Me.pnlFilterCard.Controls.Add(Me.cmbReportType)
            Me.pnlFilterCard.Controls.Add(Me.lblDateStart)
            Me.pnlFilterCard.Controls.Add(Me.dtpStartDate)
            Me.pnlFilterCard.Controls.Add(Me.lblDateEnd)
            Me.pnlFilterCard.Controls.Add(Me.dtpEndDate)
            Me.pnlFilterCard.Controls.Add(Me.lblMonth)
            Me.pnlFilterCard.Controls.Add(Me.cmbMonth)
            Me.pnlFilterCard.Controls.Add(Me.lblYear)
            Me.pnlFilterCard.Controls.Add(Me.cmbYear)
            Me.pnlFilterCard.Controls.Add(Me.btnFilter)
            Me.pnlFilterCard.Location = New System.Drawing.Point(20, 20)
            Me.pnlFilterCard.Name = "pnlFilterCard"
            Me.pnlFilterCard.Size = New System.Drawing.Size(1160, 70)
            Me.pnlFilterCard.TabIndex = 0
            '
            'lblReportType
            '
            Me.lblReportType.AutoSize = True
            Me.lblReportType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblReportType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblReportType.Location = New System.Drawing.Point(15, 12)
            Me.lblReportType.Name = "lblReportType"
            Me.lblReportType.Size = New System.Drawing.Size(102, 20)
            Me.lblReportType.TabIndex = 0
            Me.lblReportType.Text = "Tipe Laporan:"
            '
            'cmbReportType
            '
            Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbReportType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.cmbReportType.FormattingEnabled = True
            Me.cmbReportType.Items.AddRange(New Object() {"Harian", "Mingguan", "Bulanan"})
            Me.cmbReportType.Location = New System.Drawing.Point(18, 32)
            Me.cmbReportType.Name = "cmbReportType"
            Me.cmbReportType.Size = New System.Drawing.Size(130, 28)
            Me.cmbReportType.TabIndex = 1
            '
            'lblDateStart
            '
            Me.lblDateStart.AutoSize = True
            Me.lblDateStart.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblDateStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblDateStart.Location = New System.Drawing.Point(165, 12)
            Me.lblDateStart.Name = "lblDateStart"
            Me.lblDateStart.Size = New System.Drawing.Size(67, 20)
            Me.lblDateStart.TabIndex = 2
            Me.lblDateStart.Text = "Tanggal:"
            '
            'dtpStartDate
            '
            Me.dtpStartDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpStartDate.Location = New System.Drawing.Point(168, 32)
            Me.dtpStartDate.Name = "dtpStartDate"
            Me.dtpStartDate.Size = New System.Drawing.Size(130, 27)
            Me.dtpStartDate.TabIndex = 3
            '
            'lblDateEnd
            '
            Me.lblDateEnd.AutoSize = True
            Me.lblDateEnd.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblDateEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblDateEnd.Location = New System.Drawing.Point(315, 12)
            Me.lblDateEnd.Name = "lblDateEnd"
            Me.lblDateEnd.Size = New System.Drawing.Size(92, 20)
            Me.lblDateEnd.TabIndex = 4
            Me.lblDateEnd.Text = "s/d Tanggal:"
            Me.lblDateEnd.Visible = False
            '
            'dtpEndDate
            '
            Me.dtpEndDate.CustomFormat = "dd/MM/yyyy"
            Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpEndDate.Location = New System.Drawing.Point(318, 32)
            Me.dtpEndDate.Name = "dtpEndDate"
            Me.dtpEndDate.Size = New System.Drawing.Size(130, 27)
            Me.dtpEndDate.TabIndex = 5
            Me.dtpEndDate.Visible = False
            '
            'lblMonth
            '
            Me.lblMonth.AutoSize = True
            Me.lblMonth.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblMonth.Location = New System.Drawing.Point(165, 12)
            Me.lblMonth.Name = "lblMonth"
            Me.lblMonth.Size = New System.Drawing.Size(52, 20)
            Me.lblMonth.TabIndex = 6
            Me.lblMonth.Text = "Bulan:"
            Me.lblMonth.Visible = False
            '
            'cmbMonth
            '
            Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbMonth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.cmbMonth.FormattingEnabled = True
            Me.cmbMonth.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
            Me.cmbMonth.Location = New System.Drawing.Point(168, 32)
            Me.cmbMonth.Name = "cmbMonth"
            Me.cmbMonth.Size = New System.Drawing.Size(130, 28)
            Me.cmbMonth.TabIndex = 7
            Me.cmbMonth.Visible = False
            '
            'lblYear
            '
            Me.lblYear.AutoSize = True
            Me.lblYear.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblYear.Location = New System.Drawing.Point(315, 12)
            Me.lblYear.Name = "lblYear"
            Me.lblYear.Size = New System.Drawing.Size(55, 20)
            Me.lblYear.TabIndex = 8
            Me.lblYear.Text = "Tahun:"
            Me.lblYear.Visible = False
            '
            'cmbYear
            '
            Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbYear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.cmbYear.FormattingEnabled = True
            Me.cmbYear.Location = New System.Drawing.Point(318, 32)
            Me.cmbYear.Name = "cmbYear"
            Me.cmbYear.Size = New System.Drawing.Size(100, 28)
            Me.cmbYear.TabIndex = 9
            Me.cmbYear.Visible = False
            '
            'btnFilter
            '
            Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnFilter.FlatAppearance.BorderSize = 0
            Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnFilter.ForeColor = System.Drawing.Color.White
            Me.btnFilter.Location = New System.Drawing.Point(470, 28)
            Me.btnFilter.Name = "btnFilter"
            Me.btnFilter.Size = New System.Drawing.Size(120, 28)
            Me.btnFilter.TabIndex = 10
            Me.btnFilter.Text = "TAMPILKAN"
            Me.btnFilter.UseVisualStyleBackColor = False
            '
            'pnlSummaryCard
            '
            Me.pnlSummaryCard.BackColor = System.Drawing.Color.White
            Me.pnlSummaryCard.Controls.Add(Me.lblTotalTrxTitle)
            Me.pnlSummaryCard.Controls.Add(Me.lblTotalTrxVal)
            Me.pnlSummaryCard.Controls.Add(Me.lblTotalRevenueTitle)
            Me.pnlSummaryCard.Controls.Add(Me.lblTotalRevenueVal)
            Me.pnlSummaryCard.Controls.Add(Me.lblMethodBreakdown)
            Me.pnlSummaryCard.Location = New System.Drawing.Point(20, 100)
            Me.pnlSummaryCard.Name = "pnlSummaryCard"
            Me.pnlSummaryCard.Size = New System.Drawing.Size(1160, 75)
            Me.pnlSummaryCard.TabIndex = 1
            '
            'lblTotalTrxTitle
            '
            Me.lblTotalTrxTitle.AutoSize = True
            Me.lblTotalTrxTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblTotalTrxTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalTrxTitle.Location = New System.Drawing.Point(15, 12)
            Me.lblTotalTrxTitle.Name = "lblTotalTrxTitle"
            Me.lblTotalTrxTitle.Size = New System.Drawing.Size(108, 20)
            Me.lblTotalTrxTitle.TabIndex = 0
            Me.lblTotalTrxTitle.Text = "Total Transaksi"
            '
            'lblTotalTrxVal
            '
            Me.lblTotalTrxVal.AutoSize = True
            Me.lblTotalTrxVal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalTrxVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.lblTotalTrxVal.Location = New System.Drawing.Point(15, 32)
            Me.lblTotalTrxVal.Name = "lblTotalTrxVal"
            Me.lblTotalTrxVal.Size = New System.Drawing.Size(33, 37)
            Me.lblTotalTrxVal.TabIndex = 1
            Me.lblTotalTrxVal.Text = "0"
            '
            'lblTotalRevenueTitle
            '
            Me.lblTotalRevenueTitle.AutoSize = True
            Me.lblTotalRevenueTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblTotalRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalRevenueTitle.Location = New System.Drawing.Point(200, 12)
            Me.lblTotalRevenueTitle.Name = "lblTotalRevenueTitle"
            Me.lblTotalRevenueTitle.Size = New System.Drawing.Size(127, 20)
            Me.lblTotalRevenueTitle.TabIndex = 2
            Me.lblTotalRevenueTitle.Text = "Total Pendapatan"
            '
            'lblTotalRevenueVal
            '
            Me.lblTotalRevenueVal.AutoSize = True
            Me.lblTotalRevenueVal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalRevenueVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.lblTotalRevenueVal.Location = New System.Drawing.Point(200, 32)
            Me.lblTotalRevenueVal.Name = "lblTotalRevenueVal"
            Me.lblTotalRevenueVal.Size = New System.Drawing.Size(75, 37)
            Me.lblTotalRevenueVal.TabIndex = 3
            Me.lblTotalRevenueVal.Text = "Rp 0"
            '
            'lblMethodBreakdown
            '
            Me.lblMethodBreakdown.AutoSize = True
            Me.lblMethodBreakdown.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblMethodBreakdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblMethodBreakdown.Location = New System.Drawing.Point(500, 38)
            Me.lblMethodBreakdown.Name = "lblMethodBreakdown"
            Me.lblMethodBreakdown.Size = New System.Drawing.Size(306, 20)
            Me.lblMethodBreakdown.TabIndex = 4
            Me.lblMethodBreakdown.Text = "Rincian: Cash: Rp 0 | QRIS: Rp 0 | Debit: Rp 0"
            '
            'pnlGridCard
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.btnExportCsv)
            Me.pnlGridCard.Controls.Add(Me.dgvReport)
            Me.pnlGridCard.Controls.Add(Me.pnlPagination)
            Me.pnlGridCard.Location = New System.Drawing.Point(20, 185)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(15)
            Me.pnlGridCard.Size = New System.Drawing.Size(1160, 435)
            Me.pnlGridCard.TabIndex = 2
            '
            'pnlPagination
            '
            Me.pnlPagination.Controls.Add(Me.lblPageInfo)
            Me.pnlPagination.Controls.Add(Me.btnNext)
            Me.pnlPagination.Controls.Add(Me.btnPrev)
            Me.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPagination.Location = New System.Drawing.Point(15, 375)
            Me.pnlPagination.Name = "pnlPagination"
            Me.pnlPagination.Size = New System.Drawing.Size(1130, 45)
            Me.pnlPagination.TabIndex = 2
            '
            'btnPrev
            '
            Me.btnPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrev.FlatAppearance.BorderSize = 0
            Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPrev.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.btnPrev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.btnPrev.Location = New System.Drawing.Point(0, 7)
            Me.btnPrev.Name = "btnPrev"
            Me.btnPrev.Size = New System.Drawing.Size(140, 32)
            Me.btnPrev.TabIndex = 0
            Me.btnPrev.Text = "◀ SEBELUMNYA"
            Me.btnPrev.UseVisualStyleBackColor = False
            '
            'lblPageInfo
            '
            Me.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.lblPageInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPageInfo.Location = New System.Drawing.Point(365, 7)
            Me.lblPageInfo.Name = "lblPageInfo"
            Me.lblPageInfo.Size = New System.Drawing.Size(400, 32)
            Me.lblPageInfo.TabIndex = 1
            Me.lblPageInfo.Text = "HALAMAN 1 DARI 1"
            Me.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnNext
            '
            Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNext.FlatAppearance.BorderSize = 0
            Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNext.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.btnNext.Location = New System.Drawing.Point(990, 7)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(140, 32)
            Me.btnNext.TabIndex = 2
            Me.btnNext.Text = "SELANJUTNYA ▶"
            Me.btnNext.UseVisualStyleBackColor = False
            '
            'btnExportCsv
            '
            Me.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.btnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnExportCsv.FlatAppearance.BorderSize = 0
            Me.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnExportCsv.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.btnExportCsv.ForeColor = System.Drawing.Color.White
            Me.btnExportCsv.Location = New System.Drawing.Point(1015, 12)
            Me.btnExportCsv.Name = "btnExportCsv"
            Me.btnExportCsv.Size = New System.Drawing.Size(130, 28)
            Me.btnExportCsv.TabIndex = 0
            Me.btnExportCsv.Text = "EKSPOR CSV"
            Me.btnExportCsv.UseVisualStyleBackColor = False
            '
            'dgvReport
            '
            Me.dgvReport.AllowUserToAddRows = False
            Me.dgvReport.AllowUserToDeleteRows = False
            Me.dgvReport.AllowUserToResizeRows = False
            Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvReport.BackgroundColor = System.Drawing.Color.White
            Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
            Me.dgvReport.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvReport.ColumnHeadersHeight = 32
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvReport.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvReport.EnableHeadersVisualStyles = False
            Me.dgvReport.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvReport.Location = New System.Drawing.Point(15, 48)
            Me.dgvReport.MultiSelect = False
            Me.dgvReport.Name = "dgvReport"
            Me.dgvReport.ReadOnly = True
            Me.dgvReport.RowHeadersVisible = False
            Me.dgvReport.RowHeadersWidth = 51
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvReport.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvReport.RowTemplate.Height = 30
            Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvReport.Size = New System.Drawing.Size(1130, 372)
            Me.dgvReport.TabIndex = 0
            '
            'ReportForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1200, 700)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "ReportForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Laporan Pendapatan Parkir"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlFilterCard.ResumeLayout(False)
            Me.pnlFilterCard.PerformLayout()
            Me.pnlSummaryCard.ResumeLayout(False)
            Me.pnlSummaryCard.PerformLayout()
            Me.pnlGridCard.ResumeLayout(False)
            CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlFilterCard As System.Windows.Forms.Panel
        Friend WithEvents lblReportType As System.Windows.Forms.Label
        Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
        Friend WithEvents lblDateStart As System.Windows.Forms.Label
        Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblDateEnd As System.Windows.Forms.Label
        Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblMonth As System.Windows.Forms.Label
        Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
        Friend WithEvents lblYear As System.Windows.Forms.Label
        Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
        Friend WithEvents btnFilter As System.Windows.Forms.Button
        Friend WithEvents pnlSummaryCard As System.Windows.Forms.Panel
        Friend WithEvents lblTotalTrxTitle As System.Windows.Forms.Label
        Friend WithEvents lblTotalTrxVal As System.Windows.Forms.Label
        Friend WithEvents lblTotalRevenueTitle As System.Windows.Forms.Label
        Friend WithEvents lblTotalRevenueVal As System.Windows.Forms.Label
        Friend WithEvents lblMethodBreakdown As System.Windows.Forms.Label
        Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
        Friend WithEvents btnExportCsv As System.Windows.Forms.Button
        Friend WithEvents dgvReport As System.Windows.Forms.DataGridView
        Friend WithEvents pnlPagination As System.Windows.Forms.Panel
        Friend WithEvents btnPrev As System.Windows.Forms.Button
        Friend WithEvents lblPageInfo As System.Windows.Forms.Label
        Friend WithEvents btnNext As System.Windows.Forms.Button
    End Class
End Namespace