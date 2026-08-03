Imports System.Windows.Forms

Namespace Views
    Partial Class ActiveParkingForm
        Inherits Form

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.lblTitle = New Label()
            Me.lblSearch = New Label()
            Me.txtSearch = New TextBox()
            Me.dgvActiveParking = New DataGridView()
            Me.cmsParking = New ContextMenuStrip(Me.components)
            Me.tsmiCheckout = New ToolStripMenuItem()
            Me.lblTotalCount = New Label()
            Me.btnProcessCheckout = New Button()
            Me.btnRefresh = New Button()
            Me.btnClose = New Button()
            CType(Me.dgvActiveParking, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.cmsParking.SuspendLayout()
            Me.SuspendLayout()
            '
            ' lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.Location = New System.Drawing.Point(20, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(262, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "DAFTAR KENDARAAN AKTIF (IN)"
            '
            ' lblSearch
            '
            Me.lblSearch.AutoSize = True
            Me.lblSearch.Location = New System.Drawing.Point(20, 55)
            Me.lblSearch.Name = "lblSearch"
            Me.lblSearch.Size = New System.Drawing.Size(95, 15)
            Me.lblSearch.TabIndex = 1
            Me.lblSearch.Text = "Cari Plat Nomor:"
            '
            ' txtSearch
            '
            Me.txtSearch.CharacterCasing = CharacterCasing.Upper
            Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.txtSearch.Location = New System.Drawing.Point(120, 50)
            Me.txtSearch.Name = "txtSearch"
            Me.txtSearch.Size = New System.Drawing.Size(200, 24)
            Me.txtSearch.TabIndex = 2
            '
            ' dgvActiveParking
            '
            Me.dgvActiveParking.AllowUserToAddRows = False
            Me.dgvActiveParking.AllowUserToDeleteRows = False
            Me.dgvActiveParking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvActiveParking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvActiveParking.ContextMenuStrip = Me.cmsParking
            Me.dgvActiveParking.Location = New System.Drawing.Point(23, 90)
            Me.dgvActiveParking.MultiSelect = False
            Me.dgvActiveParking.Name = "dgvActiveParking"
            Me.dgvActiveParking.ReadOnly = True
            Me.dgvActiveParking.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.dgvActiveParking.Size = New System.Drawing.Size(640, 300)
            Me.dgvActiveParking.TabIndex = 3
            '
            ' cmsParking
            '
            Me.cmsParking.Items.AddRange(New ToolStripItem() {Me.tsmiCheckout})
            Me.cmsParking.Name = "cmsParking"
            Me.cmsParking.Size = New System.Drawing.Size(217, 26)
            '
            ' tsmiCheckout
            '
            Me.tsmiCheckout.Name = "tsmiCheckout"
            Me.tsmiCheckout.Size = New System.Drawing.Size(216, 22)
            Me.tsmiCheckout.Text = "Proses Keluar (Checkout)"
            '
            ' lblTotalCount
            '
            Me.lblTotalCount.AutoSize = True
            Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCount.Location = New System.Drawing.Point(20, 405)
            Me.lblTotalCount.Name = "lblTotalCount"
            Me.lblTotalCount.Size = New System.Drawing.Size(147, 17)
            Me.lblTotalCount.TabIndex = 4
            Me.lblTotalCount.Text = "Total Kendaraan: 0 Unit"
            '
            ' btnProcessCheckout
            '
            Me.btnProcessCheckout.BackColor = System.Drawing.Color.DarkOrange
            Me.btnProcessCheckout.FlatStyle = FlatStyle.Flat
            Me.btnProcessCheckout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnProcessCheckout.ForeColor = System.Drawing.Color.White
            Me.btnProcessCheckout.Location = New System.Drawing.Point(273, 400)
            Me.btnProcessCheckout.Name = "btnProcessCheckout"
            Me.btnProcessCheckout.Size = New System.Drawing.Size(130, 32)
            Me.btnProcessCheckout.TabIndex = 5
            Me.btnProcessCheckout.Text = "PROSES KELUAR"
            Me.btnProcessCheckout.UseVisualStyleBackColor = False
            '
            ' btnRefresh
            '
            Me.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnRefresh.FlatStyle = FlatStyle.Flat
            Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnRefresh.ForeColor = System.Drawing.Color.White
            Me.btnRefresh.Location = New System.Drawing.Point(413, 400)
            Me.btnRefresh.Name = "btnRefresh"
            Me.btnRefresh.Size = New System.Drawing.Size(100, 32)
            Me.btnRefresh.TabIndex = 6
            Me.btnRefresh.Text = "REFRESH"
            Me.btnRefresh.UseVisualStyleBackColor = False
            '
            ' btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Gray
            Me.btnClose.FlatStyle = FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.Location = New System.Drawing.Point(523, 400)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(140, 32)
            Me.btnClose.TabIndex = 7
            Me.btnClose.Text = "TUTUP"
            Me.btnClose.UseVisualStyleBackColor = False
            '
            ' ActiveParkingForm
            '
            Me.ClientSize = New System.Drawing.Size(684, 450)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnRefresh)
            Me.Controls.Add(Me.btnProcessCheckout)
            Me.Controls.Add(Me.lblTotalCount)
            Me.Controls.Add(Me.dgvActiveParking)
            Me.Controls.Add(Me.txtSearch)
            Me.Controls.Add(Me.lblSearch)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "ActiveParkingForm"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Parking App - Kendaraan Aktif"
            CType(Me.dgvActiveParking, System.ComponentModel.ISupportInitialize).EndInit()
            Me.cmsParking.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents lblSearch As Label
        Friend WithEvents txtSearch As TextBox
        Friend WithEvents dgvActiveParking As DataGridView
        Friend WithEvents cmsParking As ContextMenuStrip
        Friend WithEvents tsmiCheckout As ToolStripMenuItem
        Friend WithEvents lblTotalCount As Label
        Friend WithEvents btnProcessCheckout As Button
        Friend WithEvents btnRefresh As Button
        Friend WithEvents btnClose As Button
    End Class
End Namespace