Imports System.Windows.Forms

Namespace Views
    Partial Class HistoryForm
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
            Me.lblTitle = New Label()
            Me.grpFilter = New GroupBox()
            Me.btnReset = New Button()
            Me.btnFilter = New Button()
            Me.txtSearchPlate = New TextBox()
            Me.lblSearchPlate = New Label()
            Me.cmbVehicleType = New ComboBox()
            Me.lblVehicleType = New Label()
            Me.dtpEndDate = New DateTimePicker()
            Me.lblEndDate = New Label()
            Me.dtpStartDate = New DateTimePicker()
            Me.lblStartDate = New Label()
            Me.dgvHistory = New DataGridView()
            Me.pnlSummary = New Panel()
            Me.lblTotalRevenue = New Label()
            Me.lblTotalRevenueTitle = New Label()
            Me.lblTotalCount = New Label()
            Me.lblTotalCountTitle = New Label()
            Me.btnClose = New Button()
            Me.grpFilter.SuspendLayout()
            CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSummary.SuspendLayout()
            Me.SuspendLayout()
            '
            ' lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.Location = New System.Drawing.Point(20, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(248, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "RIWAYAT TRANSAKSI PARKIR"
            '
            ' grpFilter
            '
            Me.grpFilter.Controls.Add(Me.btnReset)
            Me.grpFilter.Controls.Add(Me.btnFilter)
            Me.grpFilter.Controls.Add(Me.txtSearchPlate)
            Me.grpFilter.Controls.Add(Me.lblSearchPlate)
            Me.grpFilter.Controls.Add(Me.cmbVehicleType)
            Me.grpFilter.Controls.Add(Me.lblVehicleType)
            Me.grpFilter.Controls.Add(Me.dtpEndDate)
            Me.grpFilter.Controls.Add(Me.lblEndDate)
            Me.grpFilter.Controls.Add(Me.dtpStartDate)
            Me.grpFilter.Controls.Add(Me.lblStartDate)
            Me.grpFilter.Location = New System.Drawing.Point(23, 45)
            Me.grpFilter.Name = "grpFilter"
            Me.grpFilter.Size = New System.Drawing.Size(840, 75)
            Me.grpFilter.TabIndex = 1
            Me.grpFilter.TabStop = False
            Me.grpFilter.Text = "Filter Data"
            '
            ' lblStartDate
            '
            Me.lblStartDate.AutoSize = True
            Me.lblStartDate.Location = New System.Drawing.Point(15, 22)
            Me.lblStartDate.Name = "lblStartDate"
            Me.lblStartDate.Size = New System.Drawing.Size(76, 15)
            Me.lblStartDate.TabIndex = 0
            Me.lblStartDate.Text = "Dari Tanggal:"
            '
            ' dtpStartDate
            '
            Me.dtpStartDate.Format = DateTimePickerFormat.Short
            Me.dtpStartDate.Location = New System.Drawing.Point(18, 40)
            Me.dtpStartDate.Name = "dtpStartDate"
            Me.dtpStartDate.Size = New System.Drawing.Size(120, 23)
            Me.dtpStartDate.TabIndex = 1
            '
            ' lblEndDate
            '
            Me.lblEndDate.AutoSize = True
            Me.lblEndDate.Location = New System.Drawing.Point(150, 22)
            Me.lblEndDate.Name = "lblEndDate"
            Me.lblEndDate.Size = New System.Drawing.Size(91, 15)
            Me.lblEndDate.TabIndex = 2
            Me.lblEndDate.Text = "Sampai Tanggal:"
            '
            ' dtpEndDate
            '
            Me.dtpEndDate.Format = DateTimePickerFormat.Short
            Me.dtpEndDate.Location = New System.Drawing.Point(153, 40)
            Me.dtpEndDate.Name = "dtpEndDate"
            Me.dtpEndDate.Size = New System.Drawing.Size(120, 23)
            Me.dtpEndDate.TabIndex = 3
            '
            ' lblVehicleType
            '
            Me.lblVehicleType.AutoSize = True
            Me.lblVehicleType.Location = New System.Drawing.Point(285, 22)
            Me.lblVehicleType.Name = "lblVehicleType"
            Me.lblVehicleType.Size = New System.Drawing.Size(91, 15)
            Me.lblVehicleType.TabIndex = 4
            Me.lblVehicleType.Text = "Jenis Kendaraan:"
            '
            ' cmbVehicleType
            '
            Me.cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbVehicleType.FormattingEnabled = True
            Me.cmbVehicleType.Items.AddRange(New Object() {"Semua", "Mobil", "Motor"})
            Me.cmbVehicleType.Location = New System.Drawing.Point(288, 40)
            Me.cmbVehicleType.Name = "cmbVehicleType"
            Me.cmbVehicleType.Size = New System.Drawing.Size(110, 23)
            Me.cmbVehicleType.TabIndex = 5
            '
            ' lblSearchPlate
            '
            Me.lblSearchPlate.AutoSize = True
            Me.lblSearchPlate.Location = New System.Drawing.Point(410, 22)
            Me.lblSearchPlate.Name = "lblSearchPlate"
            Me.lblSearchPlate.Size = New System.Drawing.Size(76, 15)
            Me.lblSearchPlate.TabIndex = 6
            Me.lblSearchPlate.Text = "Nomor Polisi:"
            '
            ' txtSearchPlate
            '
            Me.txtSearchPlate.CharacterCasing = CharacterCasing.Upper
            Me.txtSearchPlate.Location = New System.Drawing.Point(413, 40)
            Me.txtSearchPlate.Name = "txtSearchPlate"
            Me.txtSearchPlate.Size = New System.Drawing.Size(130, 23)
            Me.txtSearchPlate.TabIndex = 7
            '
            ' btnFilter
            '
            Me.btnFilter.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnFilter.FlatStyle = FlatStyle.Flat
            Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnFilter.ForeColor = System.Drawing.Color.White
            Me.btnFilter.Location = New System.Drawing.Point(560, 37)
            Me.btnFilter.Name = "btnFilter"
            Me.btnFilter.Size = New System.Drawing.Size(120, 28)
            Me.btnFilter.TabIndex = 8
            Me.btnFilter.Text = "TERAPKAN"
            Me.btnFilter.UseVisualStyleBackColor = False
            '
            ' btnReset
            '
            Me.btnReset.BackColor = System.Drawing.Color.Gray
            Me.btnReset.FlatStyle = FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnReset.ForeColor = System.Drawing.Color.White
            Me.btnReset.Location = New System.Drawing.Point(690, 37)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(100, 28)
            Me.btnReset.TabIndex = 9
            Me.btnReset.Text = "RESET"
            Me.btnReset.UseVisualStyleBackColor = False
            '
            ' dgvHistory
            '
            Me.dgvHistory.AllowUserToAddRows = False
            Me.dgvHistory.AllowUserToDeleteRows = False
            Me.dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvHistory.Location = New System.Drawing.Point(23, 130)
            Me.dgvHistory.MultiSelect = False
            Me.dgvHistory.Name = "dgvHistory"
            Me.dgvHistory.ReadOnly = True
            Me.dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.dgvHistory.Size = New System.Drawing.Size(840, 300)
            Me.dgvHistory.TabIndex = 2
            '
            ' pnlSummary
            '
            Me.pnlSummary.BackColor = System.Drawing.Color.Gainsboro
            Me.pnlSummary.Controls.Add(Me.lblTotalRevenue)
            Me.pnlSummary.Controls.Add(Me.lblTotalRevenueTitle)
            Me.pnlSummary.Controls.Add(Me.lblTotalCount)
            Me.pnlSummary.Controls.Add(Me.lblTotalCountTitle)
            Me.pnlSummary.Location = New System.Drawing.Point(23, 440)
            Me.pnlSummary.Name = "pnlSummary"
            Me.pnlSummary.Size = New System.Drawing.Size(680, 45)
            Me.pnlSummary.TabIndex = 3
            '
            ' lblTotalCountTitle
            '
            Me.lblTotalCountTitle.AutoSize = True
            Me.lblTotalCountTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCountTitle.Location = New System.Drawing.Point(15, 15)
            Me.lblTotalCountTitle.Name = "lblTotalCountTitle"
            Me.lblTotalCountTitle.Size = New System.Drawing.Size(95, 15)
            Me.lblTotalCountTitle.TabIndex = 0
            Me.lblTotalCountTitle.Text = "Total Transaksi:"
            '
            ' lblTotalCount
            '
            Me.lblTotalCount.AutoSize = True
            Me.lblTotalCount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalCount.Location = New System.Drawing.Point(115, 13)
            Me.lblTotalCount.Name = "lblTotalCount"
            Me.lblTotalCount.Size = New System.Drawing.Size(48, 19)
            Me.lblTotalCount.TabIndex = 1
            Me.lblTotalCount.Text = "0 Unit"
            '
            ' lblTotalRevenueTitle
            '
            Me.lblTotalRevenueTitle.AutoSize = True
            Me.lblTotalRevenueTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalRevenueTitle.Location = New System.Drawing.Point(320, 15)
            Me.lblTotalRevenueTitle.Name = "lblTotalRevenueTitle"
            Me.lblTotalRevenueTitle.Size = New System.Drawing.Size(107, 15)
            Me.lblTotalRevenueTitle.TabIndex = 2
            Me.lblTotalRevenueTitle.Text = "Total Pendapatan:"
            '
            ' lblTotalRevenue
            '
            Me.lblTotalRevenue.AutoSize = True
            Me.lblTotalRevenue.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalRevenue.ForeColor = System.Drawing.Color.DarkGreen
            Me.lblTotalRevenue.Location = New System.Drawing.Point(433, 12)
            Me.lblTotalRevenue.Name = "lblTotalRevenue"
            Me.lblTotalRevenue.Size = New System.Drawing.Size(41, 20)
            Me.lblTotalRevenue.TabIndex = 3
            Me.lblTotalRevenue.Text = "Rp 0"
            '
            ' btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Gray
            Me.btnClose.FlatStyle = FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.Location = New System.Drawing.Point(723, 440)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(140, 45)
            Me.btnClose.TabIndex = 4
            Me.btnClose.Text = "TUTUP"
            Me.btnClose.UseVisualStyleBackColor = False
            '
            ' HistoryForm
            '
            Me.ClientSize = New System.Drawing.Size(885, 500)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.pnlSummary)
            Me.Controls.Add(Me.dgvHistory)
            Me.Controls.Add(Me.grpFilter)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "HistoryForm"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Parking App - Riwayat Transaksi"
            Me.grpFilter.ResumeLayout(False)
            Me.grpFilter.PerformLayout()
            CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlSummary.ResumeLayout(False)
            Me.pnlSummary.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents grpFilter As GroupBox
        Friend WithEvents lblStartDate As Label
        Friend WithEvents dtpStartDate As DateTimePicker
        Friend WithEvents lblEndDate As Label
        Friend WithEvents dtpEndDate As DateTimePicker
        Friend WithEvents lblVehicleType As Label
        Friend WithEvents cmbVehicleType As ComboBox
        Friend WithEvents lblSearchPlate As Label
        Friend WithEvents txtSearchPlate As TextBox
        Friend WithEvents btnFilter As Button
        Friend WithEvents btnReset As Button
        Friend WithEvents dgvHistory As DataGridView
        Friend WithEvents pnlSummary As Panel
        Friend WithEvents lblTotalCountTitle As Label
        Friend WithEvents lblTotalCount As Label
        Friend WithEvents lblTotalRevenueTitle As Label
        Friend WithEvents lblTotalRevenue As Label
        Friend WithEvents btnClose As Button
    End Class
End Namespace