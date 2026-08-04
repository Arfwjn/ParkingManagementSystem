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
            Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.dgvActiveParking = New System.Windows.Forms.DataGridView()
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
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(900, 60)
            Me.pnlHeader.TabIndex = 0
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.White
            Me.lblTitle.Location = New System.Drawing.Point(20, 18)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(243, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Daftar Kendaraan Parkir Aktif"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(853, 12)
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
            Me.pnlMain.Controls.Add(Me.pnlToolbar)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 60)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
            Me.pnlMain.Size = New System.Drawing.Size(900, 540)
            Me.pnlMain.TabIndex = 1
            '
            'pnlGridCard
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.dgvActiveParking)
            Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGridCard.Location = New System.Drawing.Point(20, 85)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(10)
            Me.pnlGridCard.Size = New System.Drawing.Size(860, 435)
            Me.pnlGridCard.TabIndex = 1
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
            dataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvActiveParking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
            Me.dgvActiveParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvActiveParking.ContextMenuStrip = Me.cmsGrid
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White
            dataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            dataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvActiveParking.DefaultCellStyle = dataGridViewCellStyle2
            Me.dgvActiveParking.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvActiveParking.EnableHeadersVisualStyles = False
            Me.dgvActiveParking.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvActiveParking.Location = New System.Drawing.Point(10, 10)
            Me.dgvActiveParking.MultiSelect = False
            Me.dgvActiveParking.Name = "dgvActiveParking"
            Me.dgvActiveParking.ReadOnly = True
            Me.dgvActiveParking.RowHeadersVisible = False
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvActiveParking.RowsDefaultCellStyle = dataGridViewCellStyle3
            Me.dgvActiveParking.RowTemplate.Height = 35
            Me.dgvActiveParking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvActiveParking.Size = New System.Drawing.Size(840, 415)
            Me.dgvActiveParking.TabIndex = 0
            '
            'cmsGrid
            '
            Me.cmsGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCheckout})
            Me.cmsGrid.Name = "cmsGrid"
            Me.cmsGrid.Size = New System.Drawing.Size(201, 26)
            '
            'tsmiCheckout
            '
            Me.tsmiCheckout.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.tsmiCheckout.Name = "tsmiCheckout"
            Me.tsmiCheckout.Size = New System.Drawing.Size(200, 22)
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
            Me.pnlToolbar.Location = New System.Drawing.Point(20, 20)
            Me.pnlToolbar.Name = "pnlToolbar"
            Me.pnlToolbar.Size = New System.Drawing.Size(860, 65)
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
            Me.btnProcessCheckout.Location = New System.Drawing.Point(705, 15)
            Me.btnProcessCheckout.Name = "btnProcessCheckout"
            Me.btnProcessCheckout.Size = New System.Drawing.Size(140, 35)
            Me.btnProcessCheckout.TabIndex = 4
            Me.btnProcessCheckout.Text = "Proses Keluar"
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
            Me.btnRefresh.Location = New System.Drawing.Point(600, 15)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(95, 35)
            Me.btnRefresh.TabIndex = 3
            Me.btnRefresh.Text = "Refresh"
            Me.btnRefresh.UseVisualStyleBackColor = False
            '
            'txtSearch
            '
            Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.5!)
            Me.txtSearch.Location = New System.Drawing.Point(115, 19)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(200, 26)
            Me.txtSearch.TabIndex = 1
            '
            'lblSearch
            '
            Me.lblSearch.AutoSize = True
            Me.lblSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblSearch.Location = New System.Drawing.Point(15, 23)
            Me.lblSearch.Name = "lblSearch"
            Me.lblSearch.Size = New System.Drawing.Size(94, 17)
            Me.lblSearch.TabIndex = 0
            Me.lblSearch.Text = "Cari Plat Polisi:"
            '
            'lblTotalCount
            '
            Me.lblTotalCount.AutoSize = True
            Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalCount.Location = New System.Drawing.Point(340, 22)
            Me.lblTotalCount.Name = "lblTotalCount"
            Me.lblTotalCount.Size = New System.Drawing.Size(155, 19)
            Me.lblTotalCount.TabIndex = 2
            Me.lblTotalCount.Text = "Total Kendaraan: 0 Unit"
            '
            'ActiveParkingForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(900, 600)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
        Friend WithEvents cmsGrid As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents tsmiCheckout As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace