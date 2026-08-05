Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MemberLevelManagementForm
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
            Me.lblLevelName = New System.Windows.Forms.Label()
            Me.txtLevelName = New System.Windows.Forms.TextBox()
            Me.lblDiscount = New System.Windows.Forms.Label()
            Me.numDiscount = New System.Windows.Forms.NumericUpDown()
            Me.lblMonthlyFee = New System.Windows.Forms.Label()
            Me.numMonthlyFee = New System.Windows.Forms.NumericUpDown()
            Me.lblDescription = New System.Windows.Forms.Label()
            Me.txtDescription = New System.Windows.Forms.TextBox()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.dgvLevels = New System.Windows.Forms.DataGridView()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlFormCard.SuspendLayout()
            CType(Me.numDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numMonthlyFee, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGridCard.SuspendLayout()
            CType(Me.dgvLevels, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.lblTitle.Size = New System.Drawing.Size(263, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Manajemen Level Member"
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
            Me.pnlMain.Size = New System.Drawing.Size(1267, 591)
            Me.pnlMain.TabIndex = 1
            '
            'pnlFormCard
            '
            Me.pnlFormCard.BackColor = System.Drawing.Color.White
            Me.pnlFormCard.Controls.Add(Me.lblFormTitle)
            Me.pnlFormCard.Controls.Add(Me.lblLevelName)
            Me.pnlFormCard.Controls.Add(Me.txtLevelName)
            Me.pnlFormCard.Controls.Add(Me.lblDiscount)
            Me.pnlFormCard.Controls.Add(Me.numDiscount)
            Me.pnlFormCard.Controls.Add(Me.lblMonthlyFee)
            Me.pnlFormCard.Controls.Add(Me.numMonthlyFee)
            Me.pnlFormCard.Controls.Add(Me.lblDescription)
            Me.pnlFormCard.Controls.Add(Me.txtDescription)
            Me.pnlFormCard.Controls.Add(Me.btnSave)
            Me.pnlFormCard.Controls.Add(Me.btnDelete)
            Me.pnlFormCard.Controls.Add(Me.btnClear)
            Me.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlFormCard.Location = New System.Drawing.Point(800, 25)
            Me.pnlFormCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlFormCard.Name = "pnlFormCard"
            Me.pnlFormCard.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
            Me.pnlFormCard.Size = New System.Drawing.Size(440, 541)
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
            Me.lblFormTitle.Size = New System.Drawing.Size(148, 25)
            Me.lblFormTitle.TabIndex = 0
            Me.lblFormTitle.Text = "Form Edit Level"
            '
            'lblLevelName
            '
            Me.lblLevelName.AutoSize = True
            Me.lblLevelName.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblLevelName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblLevelName.Location = New System.Drawing.Point(27, 65)
            Me.lblLevelName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblLevelName.Name = "lblLevelName"
            Me.lblLevelName.Size = New System.Drawing.Size(93, 20)
            Me.lblLevelName.TabIndex = 1
            Me.lblLevelName.Text = "Nama Level:"
            '
            'txtLevelName
            '
            Me.txtLevelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtLevelName.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.txtLevelName.Location = New System.Drawing.Point(31, 88)
            Me.txtLevelName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtLevelName.Name = "txtLevelName"
            Me.txtLevelName.Size = New System.Drawing.Size(378, 29)
            Me.txtLevelName.TabIndex = 2
            '
            'lblDiscount
            '
            Me.lblDiscount.AutoSize = True
            Me.lblDiscount.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblDiscount.Location = New System.Drawing.Point(27, 128)
            Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblDiscount.Name = "lblDiscount"
            Me.lblDiscount.Size = New System.Drawing.Size(132, 20)
            Me.lblDiscount.TabIndex = 3
            Me.lblDiscount.Text = "Diskon Parkir (%):"
            '
            'numDiscount
            '
            Me.numDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numDiscount.DecimalPlaces = 2
            Me.numDiscount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.numDiscount.Location = New System.Drawing.Point(31, 151)
            Me.numDiscount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.numDiscount.Name = "numDiscount"
            Me.numDiscount.Size = New System.Drawing.Size(379, 29)
            Me.numDiscount.TabIndex = 4
            '
            'lblMonthlyFee
            '
            Me.lblMonthlyFee.AutoSize = True
            Me.lblMonthlyFee.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblMonthlyFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblMonthlyFee.Location = New System.Drawing.Point(27, 191)
            Me.lblMonthlyFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblMonthlyFee.Name = "lblMonthlyFee"
            Me.lblMonthlyFee.Size = New System.Drawing.Size(130, 20)
            Me.lblMonthlyFee.TabIndex = 5
            Me.lblMonthlyFee.Text = "Biaya Bulanan (Rp):"
            '
            'numMonthlyFee
            '
            Me.numMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numMonthlyFee.DecimalPlaces = 2
            Me.numMonthlyFee.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.numMonthlyFee.Location = New System.Drawing.Point(31, 214)
            Me.numMonthlyFee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.numMonthlyFee.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
            Me.numMonthlyFee.Name = "numMonthlyFee"
            Me.numMonthlyFee.Size = New System.Drawing.Size(379, 29)
            Me.numMonthlyFee.TabIndex = 6
            Me.numMonthlyFee.ThousandsSeparator = True
            '
            'lblDescription
            '
            Me.lblDescription.AutoSize = True
            Me.lblDescription.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblDescription.Location = New System.Drawing.Point(27, 254)
            Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(92, 20)
            Me.lblDescription.TabIndex = 7
            Me.lblDescription.Text = "Keterangan:"
            '
            'txtDescription
            '
            Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.txtDescription.Location = New System.Drawing.Point(31, 277)
            Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.txtDescription.Multiline = True
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.Size = New System.Drawing.Size(378, 80)
            Me.txtDescription.TabIndex = 8
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(31, 372)
            Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(379, 43)
            Me.btnSave.TabIndex = 9
            Me.btnSave.Text = "SIMPAN"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(72, Byte), Integer))
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.FlatAppearance.BorderSize = 0
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnDelete.ForeColor = System.Drawing.Color.White
            Me.btnDelete.Location = New System.Drawing.Point(31, 428)
            Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(180, 43)
            Me.btnDelete.TabIndex = 10
            Me.btnDelete.Text = "HAPUS"
            Me.btnDelete.UseVisualStyleBackColor = False
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClear.FlatAppearance.BorderSize = 0
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.btnClear.Location = New System.Drawing.Point(229, 428)
            Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(180, 43)
            Me.btnClear.TabIndex = 11
            Me.btnClear.Text = "BATAL"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            'pnlGridCard
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.dgvLevels)
            Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlGridCard.Location = New System.Drawing.Point(27, 25)
            Me.pnlGridCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.pnlGridCard.Size = New System.Drawing.Size(747, 541)
            Me.pnlGridCard.TabIndex = 0
            '
            'dgvLevels
            '
            Me.dgvLevels.AllowUserToAddRows = False
            Me.dgvLevels.AllowUserToDeleteRows = False
            Me.dgvLevels.AllowUserToResizeRows = False
            Me.dgvLevels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvLevels.BackgroundColor = System.Drawing.Color.White
            Me.dgvLevels.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvLevels.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvLevels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvLevels.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
            Me.dgvLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvLevels.DefaultCellStyle = DataGridViewCellStyle5
            Me.dgvLevels.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvLevels.EnableHeadersVisualStyles = False
            Me.dgvLevels.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvLevels.Location = New System.Drawing.Point(13, 12)
            Me.dgvLevels.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.dgvLevels.MultiSelect = False
            Me.dgvLevels.Name = "dgvLevels"
            Me.dgvLevels.ReadOnly = True
            Me.dgvLevels.RowHeadersVisible = False
            Me.dgvLevels.RowHeadersWidth = 51
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvLevels.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.dgvLevels.RowTemplate.Height = 35
            Me.dgvLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvLevels.Size = New System.Drawing.Size(721, 517)
            Me.dgvLevels.TabIndex = 0
            '
            'MemberLevelManagementForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1267, 665)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "MemberLevelManagementForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Manajemen Level Member"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlFormCard.ResumeLayout(False)
            Me.pnlFormCard.PerformLayout()
            CType(Me.numDiscount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numMonthlyFee, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlGridCard.ResumeLayout(False)
            CType(Me.dgvLevels, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
        Friend WithEvents dgvLevels As System.Windows.Forms.DataGridView
        Friend WithEvents pnlFormCard As System.Windows.Forms.Panel
        Friend WithEvents lblFormTitle As System.Windows.Forms.Label
        Friend WithEvents lblLevelName As System.Windows.Forms.Label
        Friend WithEvents txtLevelName As System.Windows.Forms.TextBox
        Friend WithEvents lblDiscount As System.Windows.Forms.Label
        Friend WithEvents numDiscount As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblMonthlyFee As System.Windows.Forms.Label
        Friend WithEvents numMonthlyFee As System.Windows.Forms.NumericUpDown
        Friend WithEvents lblDescription As System.Windows.Forms.Label
        Friend WithEvents txtDescription As System.Windows.Forms.TextBox
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnDelete As System.Windows.Forms.Button
        Friend WithEvents btnClear As System.Windows.Forms.Button
    End Class
End Namespace