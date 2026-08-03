Imports System.Windows.Forms

Namespace Views
    Partial Class UserManagementForm
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
            Me.dgvUsers = New DataGridView()
            Me.grpForm = New GroupBox()
            Me.lblPasswordNote = New Label()
            Me.txtPassword = New TextBox()
            Me.lblPassword = New Label()
            Me.cmbRole = New ComboBox()
            Me.lblRole = New Label()
            Me.txtFullname = New TextBox()
            Me.lblFullname = New Label()
            Me.txtUsername = New TextBox()
            Me.lblUsername = New Label()
            Me.btnSave = New Button()
            Me.btnDelete = New Button()
            Me.btnClear = New Button()
            Me.btnClose = New Button()
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpForm.SuspendLayout()
            Me.SuspendLayout()
            '
            ' lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.Location = New System.Drawing.Point(20, 15)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(202, 21)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "KELOLA DATA PETUGAS"
            '
            ' dgvUsers
            '
            Me.dgvUsers.AllowUserToAddRows = False
            Me.dgvUsers.AllowUserToDeleteRows = False
            Me.dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.dgvUsers.Location = New System.Drawing.Point(23, 50)
            Me.dgvUsers.MultiSelect = False
            Me.dgvUsers.Name = "dgvUsers"
            Me.dgvUsers.ReadOnly = True
            Me.dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.dgvUsers.Size = New System.Drawing.Size(420, 370)
            Me.dgvUsers.TabIndex = 1
            '
            ' grpForm
            '
            Me.grpForm.Controls.Add(Me.lblPasswordNote)
            Me.grpForm.Controls.Add(Me.txtPassword)
            Me.grpForm.Controls.Add(Me.lblPassword)
            Me.grpForm.Controls.Add(Me.cmbRole)
            Me.grpForm.Controls.Add(Me.lblRole)
            Me.grpForm.Controls.Add(Me.txtFullname)
            Me.grpForm.Controls.Add(Me.lblFullname)
            Me.grpForm.Controls.Add(Me.txtUsername)
            Me.grpForm.Controls.Add(Me.lblUsername)
            Me.grpForm.Location = New System.Drawing.Point(460, 45)
            Me.grpForm.Name = "grpForm"
            Me.grpForm.Size = New System.Drawing.Size(300, 280)
            Me.grpForm.TabIndex = 2
            Me.grpForm.TabStop = False
            Me.grpForm.Text = "Form Petugas"
            '
            ' lblUsername
            '
            Me.lblUsername.AutoSize = True
            Me.lblUsername.Location = New System.Drawing.Point(15, 25)
            Me.lblUsername.Name = "lblUsername"
            Me.lblUsername.Size = New System.Drawing.Size(63, 15)
            Me.lblUsername.TabIndex = 0
            Me.lblUsername.Text = "Username:"
            '
            ' txtUsername
            '
            Me.txtUsername.Location = New System.Drawing.Point(18, 43)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(260, 23)
            Me.txtUsername.TabIndex = 1
            '
            ' lblFullname
            '
            Me.lblFullname.AutoSize = True
            Me.lblFullname.Location = New System.Drawing.Point(15, 75)
            Me.lblFullname.Name = "lblFullname"
            Me.lblFullname.Size = New System.Drawing.Size(90, 15)
            Me.lblFullname.TabIndex = 2
            Me.lblFullname.Text = "Nama Lengkap:"
            '
            ' txtFullname
            '
            Me.txtFullname.Location = New System.Drawing.Point(18, 93)
            Me.txtFullname.Name = "txtFullname"
            Me.txtFullname.Size = New System.Drawing.Size(260, 23)
            Me.txtFullname.TabIndex = 3
            '
            ' lblRole
            '
            Me.lblRole.AutoSize = True
            Me.lblRole.Location = New System.Drawing.Point(15, 125)
            Me.lblRole.Name = "lblRole"
            Me.lblRole.Size = New System.Drawing.Size(33, 15)
            Me.lblRole.TabIndex = 4
            Me.lblRole.Text = "Role:"
            '
            ' cmbRole
            '
            Me.cmbRole.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbRole.FormattingEnabled = True
            Me.cmbRole.Items.AddRange(New Object() {"Petugas", "Admin"})
            Me.cmbRole.Location = New System.Drawing.Point(18, 143)
            Me.cmbRole.Name = "cmbRole"
            Me.cmbRole.Size = New System.Drawing.Size(260, 23)
            Me.cmbRole.TabIndex = 5
            '
            ' lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Location = New System.Drawing.Point(15, 178)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(60, 15)
            Me.lblPassword.TabIndex = 6
            Me.lblPassword.Text = "Password:"
            '
            ' txtPassword
            '
            Me.txtPassword.Location = New System.Drawing.Point(18, 196)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(260, 23)
            Me.txtPassword.TabIndex = 7
            Me.txtPassword.UseSystemPasswordChar = True
            '
            ' lblPasswordNote
            '
            Me.lblPasswordNote.AutoSize = True
            Me.lblPasswordNote.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
            Me.lblPasswordNote.ForeColor = System.Drawing.Color.Gray
            Me.lblPasswordNote.Location = New System.Drawing.Point(18, 225)
            Me.lblPasswordNote.Name = "lblPasswordNote"
            Me.lblPasswordNote.Size = New System.Drawing.Size(223, 13)
            Me.lblPasswordNote.TabIndex = 8
            Me.lblPasswordNote.Text = "* Kosongkan password jika tidak ingin diubah"
            '
            ' btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.SeaGreen
            Me.btnSave.FlatStyle = FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(460, 335)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(140, 35)
            Me.btnSave.TabIndex = 3
            Me.btnSave.Text = "SIMPAN"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            ' btnClear
            '
            Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnClear.FlatStyle = FlatStyle.Flat
            Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClear.ForeColor = System.Drawing.Color.White
            Me.btnClear.Location = New System.Drawing.Point(610, 335)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New System.Drawing.Size(150, 35)
            Me.btnClear.TabIndex = 4
            Me.btnClear.Text = "RESET FORM"
            Me.btnClear.UseVisualStyleBackColor = False
            '
            ' btnDelete
            '
            Me.btnDelete.BackColor = System.Drawing.Color.Crimson
            Me.btnDelete.FlatStyle = FlatStyle.Flat
            Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnDelete.ForeColor = System.Drawing.Color.White
            Me.btnDelete.Location = New System.Drawing.Point(460, 380)
            Me.btnDelete.Name = "btnDelete"
            Me.btnDelete.Size = New System.Drawing.Size(140, 35)
            Me.btnDelete.TabIndex = 5
            Me.btnDelete.Text = "HAPUS"
            Me.btnDelete.UseVisualStyleBackColor = False
            '
            ' btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.Gray
            Me.btnClose.FlatStyle = FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.White
            Me.btnClose.Location = New System.Drawing.Point(610, 380)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(150, 35)
            Me.btnClose.TabIndex = 6
            Me.btnClose.Text = "TUTUP"
            Me.btnClose.UseVisualStyleBackColor = False
            '
            ' UserManagementForm
            '
            Me.ClientSize = New System.Drawing.Size(780, 440)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.grpForm)
            Me.Controls.Add(Me.dgvUsers)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "UserManagementForm"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Parking App - Kelola Petugas"
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpForm.ResumeLayout(False)
            Me.grpForm.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents dgvUsers As DataGridView
        Friend WithEvents grpForm As GroupBox
        Friend WithEvents lblUsername As Label
        Friend WithEvents txtUsername As TextBox
        Friend WithEvents lblFullname As Label
        Friend WithEvents txtFullname As TextBox
        Friend WithEvents lblRole As Label
        Friend WithEvents cmbRole As ComboBox
        Friend WithEvents lblPassword As Label
        Friend WithEvents txtPassword As TextBox
        Friend WithEvents lblPasswordNote As Label
        Friend WithEvents btnSave As Button
        Friend WithEvents btnClear As Button
        Friend WithEvents btnDelete As Button
        Friend WithEvents btnClose As Button
    End Class
End Namespace