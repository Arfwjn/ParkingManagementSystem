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
            Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.dgvHistory = New System.Windows.Forms.DataGridView()
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
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(950, 60)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(20, 18)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(201, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Riwayat Transaksi Parkir"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(903, 12)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(35, 35)
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
            Me.pnlMain.Location = New System.Drawing.Point(0, 60)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
            Me.pnlMain.Size = New System.Drawing.Size(950, 560)
            Me.pnlMain.TabIndex = 1
            '
            'pnlGridCard
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.dgvHistory)
            Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGridCard.Location = New System.Drawing.Point(20, 160)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlGridCard.Size = New System.Drawing.Size(910, 380)
            Me.pnlGridCard.TabIndex = 2
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
            Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            dataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvHistory.DefaultCellStyle = dataGridViewCellStyle2
            Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvHistory.EnableHeadersVisualStyles = False
            Me.dgvHistory.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvHistory.Location = New System.Drawing.Point(10, 10)
            Me.dgvHistory.MultiSelect = False
            Me.dgvHistory.Name = "dgvHistory"
            Me.dgvHistory.ReadOnly = True
            Me.dgvHistory.RowHeadersVisible = False
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvHistory.RowsDefaultCellStyle = dataGridViewCellStyle3
            Me.dgvHistory.RowTemplate.Height = 35
            Me.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvHistory.Size = New System.Drawing.Size(890, 360)
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
            Me.pnlSummaryCard.Location = New System.Drawing.Point(20, 95)
            Me.pnlSummaryCard.Name = "pnlSummaryCard"
            Me.pnlSummaryCard.Size = New System.Drawing.Size(910, 65)
            Me.pnlSummaryCard.TabIndex = 1
            '
            'lblTotalRevenue
            '
            Me.lblTotalRevenue.AutoSize = True
            Me.lblTotalRevenue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
            Me.lblTotalRevenue.Location = New System.Drawing.Point(520, 22)
            Me.lblTotalRevenue.Name = "lblTotalRevenue"
            Me.lblTotalRevenue.Size = New System.Drawing.Size(44, 21)
            Me.lblTotalRevenue.TabIndex = 3
            Me.lblTotalRevenue.Text = "Rp 0"
            '
            'lblTotalRevenueTitle
            '
            Me.lblTotalRevenueTitle.AutoSize = True
            Me.lblTotalRevenueTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblTotalRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalRevenueTitle.Location = New System.Drawing.Point(395, 24)
            Me.lblTotalRevenueTitle.Name = "lblTotalRevenueTitle"
            Me.lblTotalRevenueTitle.Size = New System.Drawing.Size(117, 17)
            Me.lblTotalRevenueTitle.TabIndex = 2
            Me.lblTotalRevenueTitle.Text = "Total Pendapatan:"
            '
            'lblTotalCount
            '
            Me.lblTotalCount.AutoSize = True
            Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.lblTotalCount.Location = New System.Drawing.Point(145, 22)
            Me.lblTotalCount.Name = "lblTotalCount"
            Me.lblTotalCount.Size = New System.Drawing.Size(56, 21)
            Me.lblTotalCount.TabIndex = 1
            Me.lblTotalCount.Text = "0 Unit"
            '
            'lblTotalCountTitle
            '
            Me.lblTotalCountTitle.AutoSize = True
            Me.lblTotalCountTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCountTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalCountTitle.Location = New System.Drawing.Point(20, 24)
            Me.lblTotalCountTitle.Name = "lblTotalCountTitle"
            Me.lblTotalCountTitle.Size = New System.Drawing.Size(111, 17)
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
            Me.pnlFilterCard.Location = New System.Drawing.Point(20, 20)
            Me.pnlFilterCard.Name = "pnlFilterCard"
            Me.pnlFilterCard.Size = New System.Drawing.Size(910, 75)
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
            Me.btnReset.Location = New System.Drawing.Point(825, 24)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(70, 30)
            Me.btnReset.TabIndex = 9
            Me.btnReset.Text = "Reset"
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
            Me.btnFilter.Location = New System.Drawing.Point(745, 24)
            Me.btnFilter.Name = "btnFilter"
            Me.btnFilter.Size = New System.Drawing.Size(75, 30)
            Me.btnFilter.TabIndex = 8
            Me.btnFilter.Text = "Filter"
            Me.btnFilter.UseVisualStyleBackColor = False
            '
            'txtSearchPlate
            '
            Me.txtSearchPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearchPlate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.txtSearchPlate.Location = New System.Drawing.Point(620, 27)
            Me.txtSearchPlate.Name = "txtSearchPlate"
            Me.txtSearchPlate.Size = New System.Drawing.Size(110, 24)
            Me.txtSearchPlate.TabIndex = 7
            '
            'lblSearchPlate
            '
            Me.lblSearchPlate.AutoSize = True
            Me.lblSearchPlate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblSearchPlate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblSearchPlate.Location = New System.Drawing.Point(555, 31)
            Me.lblSearchPlate.Name = "lblSearchPlate"
            Me.lblSearchPlate.Size = New System.Drawing.Size(58, 15)
            Me.lblSearchPlate.TabIndex = 6
            Me.lblSearchPlate.Text = "Plat Polisi:"
            '
            'cmbVehicleType
            '
            Me.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbVehicleType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.cmbVehicleType.FormattingEnabled = True
            Me.cmbVehicleType.Items.AddRange(New Object() {"Semua", "Mobil", "Motor"})
            Me.cmbVehicleType.Location = New System.Drawing.Point(440, 26)
            Me.cmbVehicleType.Name = "cmbVehicleType"
            Me.cmbVehicleType.Size = New System.Drawing.Size(100, 25)
            Me.cmbVehicleType.TabIndex = 5
            '
            'lblVehicleType
            '
            Me.lblVehicleType.AutoSize = True
            Me.lblVehicleType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblVehicleType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblVehicleType.Location = New System.Drawing.Point(395, 31)
            Me.lblVehicleType.Name = "lblVehicleType"
            Me.lblVehicleType.Size = New System.Drawing.Size(36, 15)
            Me.lblVehicleType.TabIndex = 4
            Me.lblVehicleType.Text = "Jenis:"
            '
            'dtpEndDate
            '
            Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpEndDate.Location = New System.Drawing.Point(265, 27)
            Me.dtpEndDate.Name = "dtpEndDate"
            Me.dtpEndDate.Size = New System.Drawing.Size(115, 24)
            Me.dtpEndDate.TabIndex = 3
            '
            'lblEndDate
            '
            Me.lblEndDate.AutoSize = True
            Me.lblEndDate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblEndDate.Location = New System.Drawing.Point(205, 31)
            Me.lblEndDate.Name = "lblEndDate"
            Me.lblEndDate.Size = New System.Drawing.Size(52, 15)
            Me.lblEndDate.TabIndex = 2
            Me.lblEndDate.Text = "Sampai:"
            '
            'dtpStartDate
            '
            Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpStartDate.Location = New System.Drawing.Point(75, 27)
            Me.dtpStartDate.Name = "dtpStartDate"
            Me.dtpStartDate.Size = New System.Drawing.Size(115, 24)
            Me.dtpStartDate.TabIndex = 1
            '
            'lblStartDate
            '
            Me.lblStartDate.AutoSize = True
            Me.lblStartDate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblStartDate.Location = New System.Drawing.Point(15, 31)
            Me.lblStartDate.Name = "lblStartDate"
            Me.lblStartDate.Size = New System.Drawing.Size(52, 15)
            Me.lblStartDate.TabIndex = 0
            Me.lblStartDate.Text = "Dari Tgl:"
            '
            'HistoryForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(950, 620)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "HistoryForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Riwayat Transaksi Parkir"
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
    End Class
End Namespace