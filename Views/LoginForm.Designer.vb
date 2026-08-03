Imports System.Windows.Forms

Namespace Views
    Partial Class LoginForm

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
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.lblUsername = New System.Windows.Forms.Label()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.btnLogin = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.lblError = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.Location = New System.Drawing.Point(68, 20)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(255, 32)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "PARKING APP LOGIN"
            '
            'lblUsername
            '
            Me.lblUsername.AutoSize = True
            Me.lblUsername.Location = New System.Drawing.Point(40, 70)
            Me.lblUsername.Name = "lblUsername"
            Me.lblUsername.Size = New System.Drawing.Size(73, 16)
            Me.lblUsername.TabIndex = 1
            Me.lblUsername.Text = "Username:"
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Location = New System.Drawing.Point(40, 130)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(70, 16)
            Me.lblPassword.TabIndex = 3
            Me.lblPassword.Text = "Password:"
            '
            'txtUsername
            '
            Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtUsername.Location = New System.Drawing.Point(43, 90)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(300, 30)
            Me.txtUsername.TabIndex = 2
            '
            'txtPassword
            '
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtPassword.Location = New System.Drawing.Point(43, 150)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtPassword.Size = New System.Drawing.Size(300, 30)
            Me.txtPassword.TabIndex = 4
            Me.txtPassword.UseSystemPasswordChar = True
            '
            'btnLogin
            '
            Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnLogin.ForeColor = System.Drawing.Color.White
            Me.btnLogin.Location = New System.Drawing.Point(43, 215)
            Me.btnLogin.Name = "btnLogin"
            Me.btnLogin.Size = New System.Drawing.Size(140, 35)
            Me.btnLogin.TabIndex = 6
            Me.btnLogin.Text = "Login"
            Me.btnLogin.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.Gray
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnCancel.ForeColor = System.Drawing.Color.White
            Me.btnCancel.Location = New System.Drawing.Point(203, 215)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(140, 35)
            Me.btnCancel.TabIndex = 7
            Me.btnCancel.Text = "Batal"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'lblError
            '
            Me.lblError.AutoSize = True
            Me.lblError.ForeColor = System.Drawing.Color.Red
            Me.lblError.Location = New System.Drawing.Point(40, 185)
            Me.lblError.Name = "lblError"
            Me.lblError.Size = New System.Drawing.Size(0, 16)
            Me.lblError.TabIndex = 5
            '
            'LoginForm
            '
            Me.ClientSize = New System.Drawing.Size(390, 280)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnLogin)
            Me.Controls.Add(Me.lblError)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.lblPassword)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.lblUsername)
            Me.Controls.Add(Me.lblTitle)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "LoginForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Parking App - Login System"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblTitle As Label
        Friend WithEvents lblUsername As Label
        Friend WithEvents txtUsername As TextBox
        Friend WithEvents lblPassword As Label
        Friend WithEvents txtPassword As TextBox
        Friend WithEvents lblError As Label
        Friend WithEvents btnLogin As Button
        Friend WithEvents btnCancel As Button
    End Class
End Namespace