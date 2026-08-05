Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class LoginForm
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
            Me.pnlSidebar = New System.Windows.Forms.Panel()
            Me.lblBrandSubtitle = New System.Windows.Forms.Label()
            Me.lblBrandTitle = New System.Windows.Forms.Label()
            Me.pnlMain = New System.Windows.Forms.Panel()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.pnlCard = New System.Windows.Forms.Panel()
            Me.lblError = New System.Windows.Forms.Label()
            Me.btnLogin = New System.Windows.Forms.Button()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.lblUsername = New System.Windows.Forms.Label()
            Me.lblLoginSubHeader = New System.Windows.Forms.Label()
            Me.lblLoginHeader = New System.Windows.Forms.Label()
            Me.pnlSidebar.SuspendLayout()
            Me.pnlMain.SuspendLayout()
            Me.pnlCard.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlSidebar
            '
            Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.pnlSidebar.Controls.Add(Me.lblBrandSubtitle)
            Me.pnlSidebar.Controls.Add(Me.lblBrandTitle)
            Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
            Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlSidebar.Name = "pnlSidebar"
            Me.pnlSidebar.Size = New System.Drawing.Size(427, 615)
            Me.pnlSidebar.TabIndex = 0
            '
            'lblBrandSubtitle
            '
            Me.lblBrandSubtitle.AutoSize = True
            Me.lblBrandSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.lblBrandSubtitle.Location = New System.Drawing.Point(89, 309)
            Me.lblBrandSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblBrandSubtitle.Name = "lblBrandSubtitle"
            Me.lblBrandSubtitle.Size = New System.Drawing.Size(232, 23)
            Me.lblBrandSubtitle.TabIndex = 1
            Me.lblBrandSubtitle.Text = "Parking Management System"
            '
            'lblBrandTitle
            '
            Me.lblBrandTitle.AutoSize = True
            Me.lblBrandTitle.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBrandTitle.ForeColor = System.Drawing.Color.White
            Me.lblBrandTitle.Location = New System.Drawing.Point(56, 249)
            Me.lblBrandTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblBrandTitle.Name = "lblBrandTitle"
            Me.lblBrandTitle.Size = New System.Drawing.Size(298, 62)
            Me.lblBrandTitle.TabIndex = 0
            Me.lblBrandTitle.Text = "PARKIRMAS"
            '
            'pnlMain
            '
            Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.pnlMain.Controls.Add(Me.btnClose)
            Me.pnlMain.Controls.Add(Me.pnlCard)
            Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMain.Location = New System.Drawing.Point(427, 0)
            Me.pnlMain.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlMain.Name = "pnlMain"
            Me.pnlMain.Size = New System.Drawing.Size(640, 615)
            Me.pnlMain.TabIndex = 1
            '
            'btnClose
            '
            Me.btnClose.FlatAppearance.BorderSize = 0
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(587, 12)
            Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(40, 37)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "X"
            Me.btnClose.UseVisualStyleBackColor = True
            '
            'pnlCard
            '
            Me.pnlCard.BackColor = System.Drawing.Color.White
            Me.pnlCard.Controls.Add(Me.lblError)
            Me.pnlCard.Controls.Add(Me.btnLogin)
            Me.pnlCard.Controls.Add(Me.txtPassword)
            Me.pnlCard.Controls.Add(Me.lblPassword)
            Me.pnlCard.Controls.Add(Me.txtUsername)
            Me.pnlCard.Controls.Add(Me.lblUsername)
            Me.pnlCard.Controls.Add(Me.lblLoginSubHeader)
            Me.pnlCard.Controls.Add(Me.lblLoginHeader)
            Me.pnlCard.Location = New System.Drawing.Point(67, 80)
            Me.pnlCard.Margin = New System.Windows.Forms.Padding(4)
            Me.pnlCard.Name = "pnlCard"
            Me.pnlCard.Size = New System.Drawing.Size(507, 468)
            Me.pnlCard.TabIndex = 0
            '
            'lblError
            '
            Me.lblError.AutoSize = True
            Me.lblError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblError.Location = New System.Drawing.Point(43, 123)
            Me.lblError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblError.Name = "lblError"
            Me.lblError.Size = New System.Drawing.Size(0, 20)
            Me.lblError.TabIndex = 7
            '
            'btnLogin
            '
            Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
            Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLogin.FlatAppearance.BorderSize = 0
            Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnLogin.ForeColor = System.Drawing.Color.White
            Me.btnLogin.Location = New System.Drawing.Point(47, 369)
            Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
            Me.btnLogin.Name = "btnLogin"
            Me.btnLogin.Size = New System.Drawing.Size(413, 52)
            Me.btnLogin.TabIndex = 6
            Me.btnLogin.Text = "Login"
            Me.btnLogin.UseVisualStyleBackColor = False
            '
            'txtPassword
            '
            Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPassword.Location = New System.Drawing.Point(47, 289)
            Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(413, 32)
            Me.txtPassword.TabIndex = 5
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblPassword.Location = New System.Drawing.Point(43, 265)
            Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(73, 20)
            Me.lblPassword.TabIndex = 4
            Me.lblPassword.Text = "Password"
            '
            'txtUsername
            '
            Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUsername.Location = New System.Drawing.Point(47, 197)
            Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(413, 32)
            Me.txtUsername.TabIndex = 3
            '
            'lblUsername
            '
            Me.lblUsername.AutoSize = True
            Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblUsername.Location = New System.Drawing.Point(43, 172)
            Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblUsername.Name = "lblUsername"
            Me.lblUsername.Size = New System.Drawing.Size(78, 20)
            Me.lblUsername.TabIndex = 2
            Me.lblUsername.Text = "Username"
            '
            'lblLoginSubHeader
            '
            Me.lblLoginSubHeader.AutoSize = True
            Me.lblLoginSubHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLoginSubHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblLoginSubHeader.Location = New System.Drawing.Point(43, 92)
            Me.lblLoginSubHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblLoginSubHeader.Name = "lblLoginSubHeader"
            Me.lblLoginSubHeader.Size = New System.Drawing.Size(270, 20)
            Me.lblLoginSubHeader.TabIndex = 1
            Me.lblLoginSubHeader.Text = "Masukkan kredensial Anda untuk masuk"
            '
            'lblLoginHeader
            '
            Me.lblLoginHeader.AutoSize = True
            Me.lblLoginHeader.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblLoginHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.lblLoginHeader.Location = New System.Drawing.Point(40, 43)
            Me.lblLoginHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.lblLoginHeader.Name = "lblLoginHeader"
            Me.lblLoginHeader.Size = New System.Drawing.Size(97, 41)
            Me.lblLoginHeader.TabIndex = 0
            Me.lblLoginHeader.Text = "Login"
            '
            'LoginForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1067, 615)
            Me.Controls.Add(Me.pnlMain)
            Me.Controls.Add(Me.pnlSidebar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "LoginForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Login"
            Me.pnlSidebar.ResumeLayout(False)
            Me.pnlSidebar.PerformLayout()
            Me.pnlMain.ResumeLayout(False)
            Me.pnlCard.ResumeLayout(False)
            Me.pnlCard.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
        Friend WithEvents lblBrandTitle As System.Windows.Forms.Label
        Friend WithEvents lblBrandSubtitle As System.Windows.Forms.Label
        Friend WithEvents pnlMain As System.Windows.Forms.Panel
        Friend WithEvents pnlCard As System.Windows.Forms.Panel
        Friend WithEvents lblLoginHeader As System.Windows.Forms.Label
        Friend WithEvents lblLoginSubHeader As System.Windows.Forms.Label
        Friend WithEvents lblError As System.Windows.Forms.Label
        Friend WithEvents lblUsername As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents btnLogin As System.Windows.Forms.Button
        Friend WithEvents btnClose As System.Windows.Forms.Button
    End Class
End Namespace