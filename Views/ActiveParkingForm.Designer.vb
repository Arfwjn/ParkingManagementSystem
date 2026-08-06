Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ActiveParkingForm
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.dgvActiveParking = New System.Windows.Forms.DataGridView()
            Me.pnlPagination = New System.Windows.Forms.Panel()
            Me.btnPrev = New System.Windows.Forms.Button()
            Me.lblPageInfo = New System.Windows.Forms.Label()
            Me.btnNext = New System.Windows.Forms.Button()
            Me.cmsGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.tsmiCheckout = New System.Windows.Forms.ToolStripMenuItem()
            Me.pnlToolbar = New System.Windows.Forms.Panel()
            Me.btnProcessCheckout = New System.Windows.Forms.Button()
            Me.btnRefresh = New System.Windows.Forms.Button()
            Me.txtSearch = New System.Windows.Forms.TextBox()
            Me.lblSearch = New System.Windows.Forms.Label()
            Me.lblTotalCount = New System.Windows.Forms.Label()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlGridCard.SuspendLayout()
            Me.pnlPagination.SuspendLayout()
            CType(Me.dgvActiveParking, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.cmsGrid.SuspendLayout()
            Me.pnlToolbar.SuspendLayout()
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
            Me.pnlHeader.Size = New System.Drawing.Size(1200, 74)
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
            Me.lblTitle.Size = New System.Drawing.Size(358, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "DAFTAR KENDARAAN PARKIR AKTIF"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(1137, 15)
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
            Me.pnlMain.Controls.Add(Me.pnlToolbar)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 74)
            Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
            Me.pnlMain.Size = New System.Drawing.Size(1200, 664)
            Me.pnlMain.TabIndex = 1
            '
            'pnlGridCard
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.dgvActiveParking)
            Me.pnlGridCard.Controls.Add(Me.pnlPagination)
            Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGridCard.Location = New System.Drawing.Point(27, 105)
            Me.pnlGridCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.pnlGridCard.Size = New System.Drawing.Size(1146, 534)
            Me.pnlGridCard.TabIndex = 1
            '
            'pnlPagination
            '
            Me.pnlPagination.Controls.Add(Me.lblPageInfo)
            Me.pnlPagination.Controls.Add(Me.btnNext)
            Me.pnlPagination.Controls.Add(Me.btnPrev)
            Me.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPagination.Location = New System.Drawing.Point(13, 477)
            Me.pnlPagination.Name = "pnlPagination"
            Me.pnlPagination.Size = New System.Drawing.Size(1120, 45)
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
            Me.lblPageInfo.Location = New System.Drawing.Point(360, 7)
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
            Me.btnNext.Location = New System.Drawing.Point(980, 7)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(140, 32)
            Me.btnNext.TabIndex = 2
            Me.btnNext.Text = "SELANJUTNYA ▶"
            Me.btnNext.UseVisualStyleBackColor = False
            '
            'dgvActiveParking
            '
            Me.dgvActiveParking.AllowUserToAddRows = False
            Me.dgvActiveParking.AllowUserToDeleteRows = False
            Me.dgvActiveParking.AllowUserToResizeRows = False
            Me.dgvActiveParking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvActiveParking.BackgroundColor = System.Drawing.Color.White
            Me.dgvActiveParking.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvActiveParking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvActiveParking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActiveParking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvActiveParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvActiveParking.ContextMenuStrip = Me.cmsGrid
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvActiveParking.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvActiveParking.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvActiveParking.EnableHeadersVisualStyles = False
            Me.dgvActiveParking.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvActiveParking.Location = New System.Drawing.Point(13, 12)
            Me.dgvActiveParking.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dgvActiveParking.MultiSelect = False
            Me.dgvActiveParking.Name = "dgvActiveParking"
            Me.dgvActiveParking.ReadOnly = True
            Me.dgvActiveParking.RowHeadersVisible = False
            Me.dgvActiveParking.RowHeadersWidth = 51
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvActiveParking.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvActiveParking.RowTemplate.Height = 35
            Me.dgvActiveParking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActiveParking.Size = New System.Drawing.Size(1120, 510)
            Me.dgvActiveParking.TabIndex = 0
            '
            'cmsGrid
            '
            Me.cmsGrid.ImageScalingSize = New System.Drawing.Size(20, 20)
            Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCheckout})
            Me.cmsGrid.Name = "cmsGrid"
            Me.cmsGrid.Size = New System.Drawing.Size(253, 30)
            '
            'tsmiCheckout
            '
            Me.tsmiCheckout.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.tsmiCheckout.Name = "tsmiCheckout"
            Me.tsmiCheckout.Size = New System.Drawing.Size(252, 26)
            Me.tsmiCheckout.Text = "Proses Keluar (Checkout)"
            '
            'pnlToolbar
            '
            Me.pnlToolbar.BackColor = System.Drawing.Color.White
            Me.pnlToolbar.Controls.Add(Me.btnProcessCheckout)
            Me.pnlToolbar.Controls.Add(Me.btnRefresh)
            Me.pnlToolbar.Controls.Add(Me.txtSearch)
            Me.pnlToolbar.Controls.Add(Me.lblSearch)
            Me.pnlToolbar.Controls.Add(Me.lblTotalCount)
            Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlToolbar.Location = New System.Drawing.Point(27, 25)
            Me.pnlToolbar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlToolbar.Name = "pnlToolbar"
            Me.pnlToolbar.Size = New System.Drawing.Size(1146, 80)
            Me.pnlToolbar.TabIndex = 0
            '
            'btnProcessCheckout
            '
            Me.btnProcessCheckout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnProcessCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnProcessCheckout.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnProcessCheckout.FlatAppearance.BorderSize = 0
            Me.btnProcessCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnProcessCheckout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnProcessCheckout.ForeColor = System.Drawing.Color.White
            Me.btnProcessCheckout.Location = New System.Drawing.Point(939, 18)
            Me.btnProcessCheckout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnProcessCheckout.Name = "btnProcessCheckout"
            Me.btnProcessCheckout.Size = New System.Drawing.Size(187, 43)
            Me.btnProcessCheckout.TabIndex = 4
            Me.btnProcessCheckout.Text = "PROSES KELUAR"
            Me.btnProcessCheckout.UseVisualStyleBackColor = False
            '
            'btnRefresh
            '
            Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRefresh.FlatAppearance.BorderSize = 0
            Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.btnRefresh.Location = New System.Drawing.Point(799, 18)
            Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(127, 43)
            Me.btnRefresh.TabIndex = 3
            Me.btnRefresh.Text = "REFRESH"
            Me.btnRefresh.UseVisualStyleBackColor = False
            '
            'txtSearch
            '
            Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.5!)
            Me.txtSearch.Location = New System.Drawing.Point(153, 23)
            Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(266, 31)
            Me.txtSearch.TabIndex = 1
            '
            'lblSearch
            '
            Me.lblSearch.AutoSize = True
            Me.lblSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblSearch.Location = New System.Drawing.Point(20, 28)
            Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblSearch.Name = "lblSearch"
            Me.lblSearch.Size = New System.Drawing.Size(114, 21)
            Me.lblSearch.TabIndex = 0
            Me.lblSearch.Text = "Cari Plat Polisi:"
            '
            'lblTotalCount
            '
            Me.lblTotalCount.AutoSize = True
            Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalCount.Location = New System.Drawing.Point(453, 27)
            Me.lblTotalCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblTotalCount.Name = "lblTotalCount"
            Me.lblTotalCount.Size = New System.Drawing.Size(188, 23)
            Me.lblTotalCount.TabIndex = 2
            Me.lblTotalCount.Text = "Total Kendaraan: 0 Unit"
            '
            'ActiveParkingForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1200, 738)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "ActiveParkingForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Daftar Kendaraan Parkir Aktif"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlGridCard.ResumeLayout(False)
            CType(Me.dgvActiveParking, System.ComponentModel.ISupportInitialize).EndInit()
            Me.cmsGrid.ResumeLayout(False)
            Me.pnlToolbar.ResumeLayout(False)
            Me.pnlToolbar.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlToolbar As System.Windows.Forms.Panel
        Friend WithEvents lblSearch As System.Windows.Forms.Label
        Friend WithEvents txtSearch As System.Windows.Forms.TextBox
        Friend WithEvents lblTotalCount As System.Windows.Forms.Label
        Friend WithEvents btnRefresh As System.Windows.Forms.Button
        Friend WithEvents btnProcessCheckout As System.Windows.Forms.Button
        Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
        Friend WithEvents dgvActiveParking As System.Windows.Forms.DataGridView
        Friend WithEvents pnlPagination As System.Windows.Forms.Panel
        Friend WithEvents btnPrev As System.Windows.Forms.Button
        Friend WithEvents lblPageInfo As System.Windows.Forms.Label
        Friend WithEvents btnNext As System.Windows.Forms.Button
        Friend WithEvents cmsGrid As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmiCheckout As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace