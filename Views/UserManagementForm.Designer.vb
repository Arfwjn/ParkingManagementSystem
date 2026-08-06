Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UserManagementForm
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
            Me.pnlGridCard = New System.Windows.Forms.Panel()
            Me.dgvUsers = New System.Windows.Forms.DataGridView()
            Me.pnlPagination = New System.Windows.Forms.Panel()
            Me.btnPrev = New System.Windows.Forms.Button()
            Me.lblPageInfo = New System.Windows.Forms.Label()
            Me.btnNext = New System.Windows.Forms.Button()
            Me.pnlInputCard = New System.Windows.Forms.Panel()
            Me.lblPasswordNote = New System.Windows.Forms.Label()
            Me.btnClear = New System.Windows.Forms.Button()
            Me.btnDelete = New System.Windows.Forms.Button()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.cmbRole = New System.Windows.Forms.ComboBox()
            Me.lblRole = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtFullname = New System.Windows.Forms.TextBox()
            Me.lblFullname = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.lblUsername = New System.Windows.Forms.Label()
            Me.pnlHeader.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlGridCard.SuspendLayout()
            Me.pnlPagination.SuspendLayout()
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlInputCard.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Controls.Add(Me.btnClose)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
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
            Me.lblTitle.Size = New System.Drawing.Size(328, 28)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "MANAJEMEN PENGGUNA (USER)"
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
            Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
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
            Me.pnlMain.Controls.Add(Me.pnlInputCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(0, 74)
            Me.pnlMain.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Padding = New System.Windows.Forms.Padding(27, 25, 27, 25)
            Me.pnlMain.Size = New System.Drawing.Size(1267, 640)
            Me.pnlMain.TabIndex = 1
            '
            'pnlGridCard
            '
            Me.pnlGridCard.BackColor = System.Drawing.Color.White
            Me.pnlGridCard.Controls.Add(Me.dgvUsers)
            Me.pnlGridCard.Controls.Add(Me.pnlPagination)
            Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGridCard.Location = New System.Drawing.Point(480, 25)
            Me.pnlGridCard.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlGridCard.Name = "pnlGridCard"
            Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
            Me.pnlGridCard.Size = New System.Drawing.Size(760, 590)
            Me.pnlGridCard.TabIndex = 1
            '
            'pnlPagination
            '
            Me.pnlPagination.Controls.Add(Me.lblPageInfo)
            Me.pnlPagination.Controls.Add(Me.btnNext)
            Me.pnlPagination.Controls.Add(Me.btnPrev)
            Me.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlPagination.Location = New System.Drawing.Point(13, 533)
            Me.pnlPagination.Name = "pnlPagination"
            Me.pnlPagination.Size = New System.Drawing.Size(734, 45)
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
            Me.btnPrev.Size = New System.Drawing.Size(130, 32)
            Me.btnPrev.TabIndex = 0
            Me.btnPrev.Text = "◀ SEBELUMNYA"
            Me.btnPrev.UseVisualStyleBackColor = False
            '
            'lblPageInfo
            '
            Me.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.lblPageInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPageInfo.Location = New System.Drawing.Point(167, 7)
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
            Me.btnNext.Location = New System.Drawing.Point(604, 7)
            Me.btnNext.Name = "btnNext"
            Me.btnNext.Size = New System.Drawing.Size(130, 32)
            Me.btnNext.TabIndex = 2
            Me.btnNext.Text = "SELANJUTNYA ▶"
            Me.btnNext.UseVisualStyleBackColor = False
            '
            'dgvUsers
            '
            Me.dgvUsers.AllowUserToAddRows = False
            Me.dgvUsers.AllowUserToDeleteRows = False
            Me.dgvUsers.AllowUserToResizeRows = False
            Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
            Me.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvUsers.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dgvUsers.EnableHeadersVisualStyles = False
            Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
            Me.dgvUsers.Location = New System.Drawing.Point(13, 12)
            Me.dgvUsers.Margin = New System.Windows.Forms.Padding(4)
            Me.dgvUsers.MultiSelect = False
            Me.dgvUsers.Name = "dgvUsers"
            Me.dgvUsers.ReadOnly = True
            Me.dgvUsers.RowHeadersVisible = False
            Me.dgvUsers.RowHeadersWidth = 51
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.dgvUsers.RowsDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvUsers.RowTemplate.Height = 35
            Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvUsers.Size = New System.Drawing.Size(734, 566)
            Me.dgvUsers.TabIndex = 0
            '
            'pnlInputCard
            '
            Me.pnlInputCard.BackColor = System.Drawing.Color.White
            Me.pnlInputCard.Controls.Add(Me.lblPasswordNote)
            Me.pnlInputCard.Controls.Add(Me.btnClear)
            Me.pnlInputCard.Controls.Add(Me.btnDelete)
            Me.pnlInputCard.Controls.Add(Me.btnSave)
            Me.pnlInputCard.Controls.Add(Me.cmbRole)
            Me.pnlInputCard.Controls.Add(Me.lblRole)
            Me.pnlInputCard.Controls.Add(Me.txtPassword)
            Me.pnlInputCard.Controls.Add(Me.lblPassword)
            Me.pnlInputCard.Controls.Add(Me.txtFullname)
            Me.pnlInputCard.Controls.Add(Me.lblFullname)
            Me.pnlInputCard.Controls.Add(Me.txtUsername)
            Me.pnlInputCard.Controls.Add(Me.lblUsername)
            Me.pnlInputCard.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlInputCard.Location = New System.Drawing.Point(27, 25)
            Me.pnlInputCard.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlInputCard.Name = "pnlInputCard"
            Me.pnlInputCard.Size = New System.Drawing.Size(453, 590)
            Me.pnlInputCard.TabIndex = 0
            '
            'lblPasswordNote
            '
            Me.lblPasswordNote.AutoSize = True
            Me.lblPasswordNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.lblPasswordNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblPasswordNote.Location = New System.Drawing.Point(27, 318)
            Me.lblPasswordNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPasswordNote.Name = "lblPasswordNote"
            Me.lblPasswordNote.Size = New System.Drawing.Size(312, 17)
            Me.lblPasswordNote.TabIndex = 11
            Me.lblPasswordNote.Text = "*Kosongkan jika tidak ingin mengubah password"
            Me.lblPasswordNote.Visible = False
            '
            'btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClear.FlatAppearance.BorderSize = 0
            Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.btnClear.Location = New System.Drawing.Point(27, 511)
            Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(193, 47)
            Me.btnClear.TabIndex = 10
            Me.btnClear.Text = "RESET"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            'btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnDelete.Enabled = False
            Me.btnDelete.FlatAppearance.BorderSize = 0
            Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnDelete.ForeColor = System.Drawing.Color.White
            Me.btnDelete.Location = New System.Drawing.Point(228, 511)
            Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(193, 49)
            Me.btnDelete.TabIndex = 9
            Me.btnDelete.Text = "HAPUS"
            Me.btnDelete.UseVisualStyleBackColor = False
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatAppearance.BorderSize = 0
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(27, 449)
            Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(394, 49)
            Me.btnSave.TabIndex = 8
            Me.btnSave.Text = "SIMPAN"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'cmbRole
            '
            Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbRole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cmbRole.FormattingEnabled = True
            Me.cmbRole.Items.AddRange(New Object() {"Petugas", "Admin"})
            Me.cmbRole.Location = New System.Drawing.Point(27, 369)
            Me.cmbRole.Margin = New System.Windows.Forms.Padding(4)
            Me.cmbRole.Name = "cmbRole"
            Me.cmbRole.Size = New System.Drawing.Size(399, 31)
            Me.cmbRole.TabIndex = 7
            '
            'lblRole
            '
            Me.lblRole.AutoSize = True
            Me.lblRole.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblRole.Location = New System.Drawing.Point(23, 345)
            Me.lblRole.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblRole.Name = "lblRole"
            Me.lblRole.Size = New System.Drawing.Size(122, 20)
            Me.lblRole.TabIndex = 6
            Me.lblRole.Text = "Role / Hak Akses"
            '
            'txtPassword
            '
            Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtPassword.Location = New System.Drawing.Point(27, 283)
            Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(399, 30)
            Me.txtPassword.TabIndex = 5
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPassword.Location = New System.Drawing.Point(23, 258)
            Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(73, 20)
            Me.lblPassword.TabIndex = 4
            Me.lblPassword.Text = "Password"
            '
            'txtFullname
            '
            Me.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFullname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtFullname.Location = New System.Drawing.Point(27, 197)
            Me.txtFullname.Margin = New System.Windows.Forms.Padding(4)
            Me.txtFullname.Name = "txtFullname"
            Me.txtFullname.Size = New System.Drawing.Size(399, 30)
            Me.txtFullname.TabIndex = 3
            '
            'lblFullname
            '
            Me.lblFullname.AutoSize = True
            Me.lblFullname.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblFullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblFullname.Location = New System.Drawing.Point(23, 172)
            Me.lblFullname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblFullname.Name = "lblFullname"
            Me.lblFullname.Size = New System.Drawing.Size(112, 20)
            Me.lblFullname.TabIndex = 2
            Me.lblFullname.Text = "Nama Lengkap"
            '
            'txtUsername
            '
            Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtUsername.Location = New System.Drawing.Point(27, 111)
            Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(399, 30)
            Me.txtUsername.TabIndex = 1
            '
            'lblUsername
            '
            Me.lblUsername.AutoSize = True
            Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblUsername.Location = New System.Drawing.Point(23, 86)
            Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblUsername.Name = "lblUsername"
            Me.lblUsername.Size = New System.Drawing.Size(78, 20)
            Me.lblUsername.TabIndex = 0
            Me.lblUsername.Text = "Username"
            '
            'UserManagementForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1267, 714)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlHeader)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "UserManagementForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Manajemen Pengguna / Petugas"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlGridCard.ResumeLayout(False)
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlInputCard.ResumeLayout(False)
            Me.pnlInputCard.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlInputCard As System.Windows.Forms.Panel
        Friend WithEvents lblUsername As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblFullname As System.Windows.Forms.Label
        Friend WithEvents txtFullname As System.Windows.Forms.TextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents lblPasswordNote As System.Windows.Forms.Label
        Friend WithEvents lblRole As System.Windows.Forms.Label
        Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnDelete As System.Windows.Forms.Button
        Friend WithEvents btnClear As System.Windows.Forms.Button
        Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
        Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
        Friend WithEvents pnlPagination As System.Windows.Forms.Panel
        Friend WithEvents btnPrev As System.Windows.Forms.Button
        Friend WithEvents lblPageInfo As System.Windows.Forms.Label
        Friend WithEvents btnNext As System.Windows.Forms.Button
    End Class
End Namespace