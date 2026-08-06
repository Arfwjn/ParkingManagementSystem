Imports System
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers

Namespace Views
    ''' <summary>
    ''' Form LoginForm menampilkan antarmuka utama pendaftaran masuk (login) pengguna ke dalam sistem parkir.
    ''' </summary>
    Partial Public Class LoginForm
        Inherits Form

        Private ReadOnly _loginController As LoginController

        ''' <summary>
        ''' Constructor untuk menginisialisasi Form Login dan controller login.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            _loginController = New LoginController()
        End Sub

        Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
            lblError.Text = String.Empty
            Dim errorMessage As String = String.Empty

            ' Mengirim kredensial username dan password ke controller login
            Dim isSuccess As Boolean = _loginController.Login(txtUsername.Text.Trim(), txtPassword.Text, errorMessage)

            If isSuccess Then
                Dim dashboard As New DashboardForm()
                dashboard.Show()
                Me.Hide()
            Else
                lblError.Text = errorMessage
            End If
        End Sub

        Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs)
            Application.Exit()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Application.Exit()
        End Sub
    End Class
End Namespace