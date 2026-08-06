Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class HistoryForm
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
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.dgvHistory = New System.Windows.Forms.DataGridView()
            Me.pnlPagination = New System.Windows.Forms.Panel()
            Me.btnPrev = New System.Windows.Forms.Button()
            Me.lblPageInfo = New System.Windows.Forms.Label()
            Me.btnNext = New System.Windows.Forms.Button()
            Me.pnlSummaryCard = New System.Windows.Forms.Panel()
            Me.lblTotalRevenue = New System.Windows.Forms.Label()
            Me.lblTotalRevenueTitle = New System.Windows.Forms.Label()
            Me.lblTotalCount = New System.Windows.Forms.Label()
            Me.lblTotalCountTitle = New System.Windows.Forms.Label()
            Me.pnlFilterCard = New System.Windows.Forms.Panel()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnFilter = New System.Windows.Forms.Button()
            Me.txtSearchPlate = New System.Windows.Forms.TextBox()
            Me.lblSearchPlate = New System.Windows.Forms.Label()
            Me.cmbVehicleType = New System.Windows.Forms.ComboBox()
            Me.lblVehicleType = New System.Windows.Forms.Label()
            Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
            Me.lblEndDate = New System.Windows.Forms.Label()
            Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
            Me.lblStartDate = New System.Windows.Forms.Label()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlGridCard.SuspendLayout()
            Me.pnlPagination.SuspendLayout()
            CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSummaryCard.SuspendLayout()
            Me.pnlFilterCard.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.btnClose)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(1267, 74)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(27, 22)
            Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(421, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "RIWAYAT TRANSAKSI PARKIR KENDARAAN"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(1204, 15)
            Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(47, 43)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "X"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.pnlMain.Controls.Add(Me.pnlGridCard)
            Me.pnlMain.Controls.Add(Me.pnlSummaryCard)
            Me.pnlMain.Controls.Add(Me.pnlFilterCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 74)
            Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
            Me.pnlMain.Size = New System.Drawing.Size(1267, 689)
            Me.pnlMain.TabIndex = 1
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.dgvHistory)
            Me.pnlGridCard.Controls.Add(Me.pnlPagination)
            Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGridCard.Location = New System.Drawing.Point(27, 197)
            Me.pnlGridCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.pnlGridCard.Size = New System.Drawing.Size(1213, 467)
            Me.pnlGridCard.TabIndex = 2
            '
            'pnlPagination
            '
            Me.pnlPagination.Controls.Add(Me.lblPageInfo)
            Me.pnlPagination.Controls.Add(Me.btnNext)
            Me.pnlPagination.Controls.Add(Me.btnPrev)
            Me.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPagination.Location = New System.Drawing.Point(13, 410)
            Me.pnlPagination.Name = "pnlPagination"
            Me.pnlPagination.Size = New System.Drawing.Size(1187, 45)
            Me.pnlPagination.TabIndex = 1
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
            Me.lblPageInfo.Location = New System.Drawing.Point(393, 7)
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
            Me.btnNext.Location = New System.Drawing.Point(1047, 7)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(140, 32)
            Me.btnNext.TabIndex = 2
            Me.btnNext.Text = "SELANJUTNYA ▶"
            Me.btnNext.UseVisualStyleBackColor = False
            '
            'dgvHistory
            '
            Me.dgvHistory.AllowUserToAddRows = False
            Me.dgvHistory.AllowUserToDeleteRows = False
            Me.dgvHistory.AllowUserToResizeRows = False
            Me.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvHistory.BackgroundColor = System.Drawing.Color.White
            Me.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvHistory.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvHistory.EnableHeadersVisualStyles = False
            Me.dgvHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvHistory.Location = New System.Drawing.Point(13, 12)
            Me.dgvHistory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dgvHistory.MultiSelect = False
            Me.dgvHistory.Name = "dgvHistory"
            Me.dgvHistory.ReadOnly = True
            Me.dgvHistory.RowHeadersVisible = False
            Me.dgvHistory.RowHeadersWidth = 51
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvHistory.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvHistory.RowTemplate.Height = 35
            Me.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvHistory.Size = New System.Drawing.Size(1187, 443)
            Me.dgvHistory.TabIndex = 0
            '
            'pnlSummaryCard
            '
            Me.pnlSummaryCard.BackColor = System.Drawing.Color.White
            Me.pnlSummaryCard.Controls.Add(Me.lblTotalRevenue)
            Me.pnlSummaryCard.Controls.Add(Me.lblTotalRevenueTitle)
            Me.pnlSummaryCard.Controls.Add(Me.lblTotalCount)
            Me.pnlSummaryCard.Controls.Add(Me.lblTotalCountTitle)
            Me.pnlSummaryCard.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSummaryCard.Location = New System.Drawing.Point(27, 117)
            Me.pnlSummaryCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlSummaryCard.Name = "pnlSummaryCard"
            Me.pnlSummaryCard.Size = New System.Drawing.Size(1213, 80)
            Me.pnlSummaryCard.TabIndex = 1
            '
            'lblTotalRevenue
            '
            Me.lblTotalRevenue.AutoSize = True
            Me.lblTotalRevenue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.lblTotalRevenue.Location = New System.Drawing.Point(693, 27)
            Me.lblTotalRevenue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTotalRevenue.Name = "lblTotalRevenue"
            Me.lblTotalRevenue.Size = New System.Drawing.Size(55, 28)
            Me.lblTotalRevenue.TabIndex = 3
            Me.lblTotalRevenue.Text = "Rp 0"
            '
            'lblTotalRevenueTitle
            '
            Me.lblTotalRevenueTitle.AutoSize = True
            Me.lblTotalRevenueTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblTotalRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalRevenueTitle.Location = New System.Drawing.Point(527, 30)
            Me.lblTotalRevenueTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTotalRevenueTitle.Name = "lblTotalRevenueTitle"
            Me.lblTotalRevenueTitle.Size = New System.Drawing.Size(138, 21)
            Me.lblTotalRevenueTitle.TabIndex = 2
            Me.lblTotalRevenueTitle.Text = "Total Pendapatan:"
            '
            'lblTotalCount
            '
            Me.lblTotalCount.AutoSize = True
            Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.lblTotalCount.Location = New System.Drawing.Point(193, 27)
            Me.lblTotalCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTotalCount.Name = "lblTotalCount"
            Me.lblTotalCount.Size = New System.Drawing.Size(70, 28)
            Me.lblTotalCount.TabIndex = 1
            Me.lblTotalCount.Text = "0 Unit"
            '
            'lblTotalCountTitle
            '
            Me.lblTotalCountTitle.AutoSize = True
            Me.lblTotalCountTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCountTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalCountTitle.Location = New System.Drawing.Point(27, 30)
            Me.lblTotalCountTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTotalCountTitle.Name = "lblTotalCountTitle"
            Me.lblTotalCountTitle.Size = New System.Drawing.Size(130, 21)
            Me.lblTotalCountTitle.TabIndex = 0
            Me.lblTotalCountTitle.Text = "Total Kendaraan:"
            '
            'pnlFilterCard
            '
            Me.pnlFilterCard.BackColor = System.Drawing.Color.White
            Me.pnlFilterCard.Controls.Add(Me.btnReset)
            Me.pnlFilterCard.Controls.Add(Me.btnFilter)
            Me.pnlFilterCard.Controls.Add(Me.txtSearchPlate)
            Me.pnlFilterCard.Controls.Add(Me.lblSearchPlate)
            Me.pnlFilterCard.Controls.Add(Me.cmbVehicleType)
            Me.pnlFilterCard.Controls.Add(Me.lblVehicleType)
            Me.pnlFilterCard.Controls.Add(Me.dtpEndDate)
            Me.pnlFilterCard.Controls.Add(Me.lblEndDate)
            Me.pnlFilterCard.Controls.Add(Me.dtpStartDate)
            Me.pnlFilterCard.Controls.Add(Me.lblStartDate)
            Me.pnlFilterCard.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlFilterCard.Location = New System.Drawing.Point(27, 25)
            Me.pnlFilterCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlFilterCard.Name = "pnlFilterCard"
            Me.pnlFilterCard.Size = New System.Drawing.Size(1213, 92)
            Me.pnlFilterCard.TabIndex = 0
            '
            'btnReset
            '
            Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.FlatAppearance.BorderSize = 0
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.btnReset.Location = New System.Drawing.Point(1100, 30)
            Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(93, 37)
            Me.btnReset.TabIndex = 9
            Me.btnReset.Text = "RESET"
            Me.btnReset.UseVisualStyleBackColor = False
            '
            'btnFilter
            '
            Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnFilter.FlatAppearance.BorderSize = 0
            Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnFilter.ForeColor = System.Drawing.Color.White
            Me.btnFilter.Location = New System.Drawing.Point(993, 30)
            Me.btnFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnFilter.Name = "btnFilter"
            Me.btnFilter.Size = New System.Drawing.Size(100, 37)
            Me.btnFilter.TabIndex = 8
            Me.btnFilter.Text = "FILTER"
            Me.btnFilter.UseVisualStyleBackColor = False
            '
            'txtSearchPlate
            '
            Me.txtSearchPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearchPlate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.txtSearchPlate.Location = New System.Drawing.Point(827, 33)
            Me.txtSearchPlate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtSearchPlate.Name = "txtSearchPlate"
            Me.txtSearchPlate.Size = New System.Drawing.Size(146, 29)
            Me.txtSearchPlate.TabIndex = 7
            '
            'lblSearchPlate
            '
            Me.lblSearchPlate.AutoSize = True
            Me.lblSearchPlate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblSearchPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblSearchPlate.Location = New System.Drawing.Point(740, 38)
            Me.lblSearchPlate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblSearchPlate.Name = "lblSearchPlate"
            Me.lblSearchPlate.Size = New System.Drawing.Size(78, 20)
            Me.lblSearchPlate.TabIndex = 6
            Me.lblSearchPlate.Text = "Plat Polisi:"
            '
            'cmbVehicleType
            '
            Me.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbVehicleType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.cmbVehicleType.FormattingEnabled = True
            Me.cmbVehicleType.Items.AddRange(New Object() {"Semua", "Mobil", "Motor"})
            Me.cmbVehicleType.Location = New System.Drawing.Point(587, 32)
            Me.cmbVehicleType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.cmbVehicleType.Name = "cmbVehicleType"
            Me.cmbVehicleType.Size = New System.Drawing.Size(132, 29)
            Me.cmbVehicleType.TabIndex = 5
            '
            'lblVehicleType
            '
            Me.lblVehicleType.AutoSize = True
            Me.lblVehicleType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblVehicleType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblVehicleType.Location = New System.Drawing.Point(527, 38)
            Me.lblVehicleType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblVehicleType.Name = "lblVehicleType"
            Me.lblVehicleType.Size = New System.Drawing.Size(46, 20)
            Me.lblVehicleType.TabIndex = 4
            Me.lblVehicleType.Text = "Jenis:"
            '
            'dtpEndDate
            '
            Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpEndDate.Location = New System.Drawing.Point(353, 33)
            Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dtpEndDate.Name = "dtpEndDate"
            Me.dtpEndDate.Size = New System.Drawing.Size(152, 29)
            Me.dtpEndDate.TabIndex = 3
            '
            'lblEndDate
            '
            Me.lblEndDate.AutoSize = True
            Me.lblEndDate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblEndDate.Location = New System.Drawing.Point(273, 38)
            Me.lblEndDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblEndDate.Name = "lblEndDate"
            Me.lblEndDate.Size = New System.Drawing.Size(63, 20)
            Me.lblEndDate.TabIndex = 2
            Me.lblEndDate.Text = "Sampai:"
            '
            'dtpStartDate
            '
            Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpStartDate.Location = New System.Drawing.Point(100, 33)
            Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dtpStartDate.Name = "dtpStartDate"
            Me.dtpStartDate.Size = New System.Drawing.Size(152, 29)
            Me.dtpStartDate.TabIndex = 1
            '
            'lblStartDate
            '
            Me.lblStartDate.AutoSize = True
            Me.lblStartDate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblStartDate.Location = New System.Drawing.Point(20, 38)
            Me.lblStartDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblStartDate.Name = "lblStartDate"
            Me.lblStartDate.Size = New System.Drawing.Size(66, 20)
            Me.lblStartDate.TabIndex = 0
            Me.lblStartDate.Text = "Dari Tgl:"
            '
            'HistoryForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1267, 763)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "HistoryForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "RIWAYAT TRANSAKSI PARKIR KENDARAAN"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlGridCard.ResumeLayout(False)
            CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlSummaryCard.ResumeLayout(False)
            Me.pnlSummaryCard.PerformLayout()
            Me.pnlFilterCard.ResumeLayout(False)
            Me.pnlFilterCard.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlFilterCard As System.Windows.Forms.Panel
        Friend WithEvents lblStartDate As System.Windows.Forms.Label
        Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblEndDate As System.Windows.Forms.Label
        Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblVehicleType As System.Windows.Forms.Label
        Friend WithEvents cmbVehicleType As System.Windows.Forms.ComboBox
        Friend WithEvents lblSearchPlate As System.Windows.Forms.Label
        Friend WithEvents txtSearchPlate As System.Windows.Forms.TextBox
        Friend WithEvents btnFilter As System.Windows.Forms.Button
        Friend WithEvents btnReset As System.Windows.Forms.Button
        Friend WithEvents pnlSummaryCard As System.Windows.Forms.Panel
        Friend WithEvents lblTotalCountTitle As System.Windows.Forms.Label
        Friend WithEvents lblTotalCount As System.Windows.Forms.Label
        Friend WithEvents lblTotalRevenueTitle As System.Windows.Forms.Label
        Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
        Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
        Friend WithEvents dgvHistory As System.Windows.Forms.DataGridView
        Friend WithEvents pnlPagination As System.Windows.Forms.Panel
        Friend WithEvents btnPrev As System.Windows.Forms.Button
        Friend WithEvents lblPageInfo As System.Windows.Forms.Label
        Friend WithEvents btnNext As System.Windows.Forms.Button
    End Class
End Namespace