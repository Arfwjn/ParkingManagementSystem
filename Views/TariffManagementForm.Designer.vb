Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class TariffManagementForm
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
            Me.pnlFormCard = New System.Windows.Forms.Panel()
            Me.lblFormTitle = New System.Windows.Forms.Label()
            Me.lblVehicleType = New System.Windows.Forms.Label()
            Me.txtVehicleType = New System.Windows.Forms.TextBox()
            Me.lblHourlyRate = New System.Windows.Forms.Label()
            Me.numHourlyRate = New System.Windows.Forms.NumericUpDown()
            Me.lblOvernightRate = New System.Windows.Forms.Label()
            Me.numOvernightRate = New System.Windows.Forms.NumericUpDown()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.dgvTariffs = New System.Windows.Forms.DataGridView()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlFormCard.SuspendLayout()
            CType(Me.numHourlyRate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numOvernightRate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGridCard.SuspendLayout()
            CType(Me.dgvTariffs, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.lblTitle.Size = New System.Drawing.Size(234, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Manajemen Tarif Parkir"
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
            Me.pnlMain.Controls.Add(Me.pnlFormCard)
            Me.pnlMain.Controls.Add(Me.pnlGridCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 74)
            Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
            Me.pnlMain.Size = New System.Drawing.Size(1267, 566)
            Me.pnlMain.TabIndex = 1
            '
            'pnlFormCard
            '
            Me.pnlFormCard.BackColor = System.Drawing.Color.White
            Me.pnlFormCard.Controls.Add(Me.lblFormTitle)
            Me.pnlFormCard.Controls.Add(Me.lblVehicleType)
            Me.pnlFormCard.Controls.Add(Me.txtVehicleType)
            Me.pnlFormCard.Controls.Add(Me.lblHourlyRate)
            Me.pnlFormCard.Controls.Add(Me.numHourlyRate)
            Me.pnlFormCard.Controls.Add(Me.lblOvernightRate)
            Me.pnlFormCard.Controls.Add(Me.numOvernightRate)
            Me.pnlFormCard.Controls.Add(Me.btnSave)
            Me.pnlFormCard.Controls.Add(Me.btnClear)
            Me.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlFormCard.Location = New System.Drawing.Point(800, 25)
            Me.pnlFormCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlFormCard.Name = "pnlFormCard"
            Me.pnlFormCard.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
            Me.pnlFormCard.Size = New System.Drawing.Size(440, 516)
            Me.pnlFormCard.TabIndex = 1
            '
            'lblFormTitle
            '
            Me.lblFormTitle.AutoSize = True
            Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.lblFormTitle.Location = New System.Drawing.Point(27, 25)
            Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblFormTitle.Name = "lblFormTitle"
            Me.lblFormTitle.Size = New System.Drawing.Size(142, 25)
            Me.lblFormTitle.TabIndex = 0
            Me.lblFormTitle.Text = "Form Edit Tarif"
            '
            'lblVehicleType
            '
            Me.lblVehicleType.AutoSize = True
            Me.lblVehicleType.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblVehicleType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblVehicleType.Location = New System.Drawing.Point(27, 74)
            Me.lblVehicleType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblVehicleType.Name = "lblVehicleType"
            Me.lblVehicleType.Size = New System.Drawing.Size(120, 20)
            Me.lblVehicleType.TabIndex = 1
            Me.lblVehicleType.Text = "Tipe Kendaraan:"
            '
            'txtVehicleType
            '
            Me.txtVehicleType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtVehicleType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.txtVehicleType.Location = New System.Drawing.Point(31, 98)
            Me.txtVehicleType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtVehicleType.Name = "txtVehicleType"
            Me.txtVehicleType.Size = New System.Drawing.Size(378, 29)
            Me.txtVehicleType.TabIndex = 2
            '
            'lblHourlyRate
            '
            Me.lblHourlyRate.AutoSize = True
            Me.lblHourlyRate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblHourlyRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblHourlyRate.Location = New System.Drawing.Point(27, 154)
            Me.lblHourlyRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblHourlyRate.Name = "lblHourlyRate"
            Me.lblHourlyRate.Size = New System.Drawing.Size(132, 20)
            Me.lblHourlyRate.TabIndex = 3
            Me.lblHourlyRate.Text = "Tarif Per Jam (Rp):"
            '
            'numHourlyRate
            '
            Me.numHourlyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numHourlyRate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.numHourlyRate.Increment = New Decimal(New Integer() {500, 0, 0, 0})
            Me.numHourlyRate.Location = New System.Drawing.Point(31, 178)
            Me.numHourlyRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.numHourlyRate.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
            Me.numHourlyRate.Name = "numHourlyRate"
            Me.numHourlyRate.Size = New System.Drawing.Size(379, 29)
            Me.numHourlyRate.TabIndex = 4
            Me.numHourlyRate.ThousandsSeparator = True
            '
            'lblOvernightRate
            '
            Me.lblOvernightRate.AutoSize = True
            Me.lblOvernightRate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblOvernightRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblOvernightRate.Location = New System.Drawing.Point(27, 234)
            Me.lblOvernightRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblOvernightRate.Name = "lblOvernightRate"
            Me.lblOvernightRate.Size = New System.Drawing.Size(149, 20)
            Me.lblOvernightRate.TabIndex = 5
            Me.lblOvernightRate.Text = "Tarif Menginap (Rp):"
            '
            'numOvernightRate
            '
            Me.numOvernightRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numOvernightRate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.numOvernightRate.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.numOvernightRate.Location = New System.Drawing.Point(31, 258)
            Me.numOvernightRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.numOvernightRate.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
            Me.numOvernightRate.Name = "numOvernightRate"
            Me.numOvernightRate.Size = New System.Drawing.Size(379, 29)
            Me.numOvernightRate.TabIndex = 6
            Me.numOvernightRate.ThousandsSeparator = True
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(31, 332)
            Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(180, 43)
            Me.btnSave.TabIndex = 7
            Me.btnSave.Text = "SIMPAN"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClear.FlatAppearance.BorderSize = 0
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.btnClear.Location = New System.Drawing.Point(229, 332)
            Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(180, 43)
            Me.btnClear.TabIndex = 8
            Me.btnClear.Text = "RESET"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            'pnlGridCard
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.dgvTariffs)
            Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlGridCard.Location = New System.Drawing.Point(27, 25)
            Me.pnlGridCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.pnlGridCard.Size = New System.Drawing.Size(747, 516)
            Me.pnlGridCard.TabIndex = 0
            '
            'dgvTariffs
            '
            Me.dgvTariffs.AllowUserToAddRows = False
            Me.dgvTariffs.AllowUserToDeleteRows = False
            Me.dgvTariffs.AllowUserToResizeRows = False
            Me.dgvTariffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvTariffs.BackgroundColor = System.Drawing.Color.White
            Me.dgvTariffs.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvTariffs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvTariffs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvTariffs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvTariffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvTariffs.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvTariffs.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvTariffs.EnableHeadersVisualStyles = False
            Me.dgvTariffs.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvTariffs.Location = New System.Drawing.Point(13, 12)
            Me.dgvTariffs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dgvTariffs.MultiSelect = False
            Me.dgvTariffs.Name = "dgvTariffs"
            Me.dgvTariffs.ReadOnly = True
            Me.dgvTariffs.RowHeadersVisible = False
            Me.dgvTariffs.RowHeadersWidth = 51
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvTariffs.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvTariffs.RowTemplate.Height = 35
            Me.dgvTariffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvTariffs.Size = New System.Drawing.Size(721, 492)
            Me.dgvTariffs.TabIndex = 0
            '
            'TariffManagementForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1267, 640)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "TariffManagementForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Manajemen Tarif Parkir"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlFormCard.ResumeLayout(False)
            Me.pnlFormCard.PerformLayout()
            CType(Me.numHourlyRate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numOvernightRate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlGridCard.ResumeLayout(False)
            CType(Me.dgvTariffs, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
        Friend WithEvents dgvTariffs As System.Windows.Forms.DataGridView
        Friend WithEvents pnlFormCard As System.Windows.Forms.Panel
        Friend WithEvents lblFormTitle As System.Windows.Forms.Label
        Friend WithEvents lblVehicleType As System.Windows.Forms.Label
        Friend WithEvents txtVehicleType As System.Windows.Forms.TextBox
        Friend WithEvents lblHourlyRate As System.Windows.Forms.Label
        Friend WithEvents numHourlyRate As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblOvernightRate As System.Windows.Forms.Label
        Friend WithEvents numOvernightRate As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnClear As System.Windows.Forms.Button
    End Class
End Namespace