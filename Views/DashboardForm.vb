Imports System
Imports System.Windows.Forms
Imports ParkingManagementSystem.Helpers

Namespace Views
    Partial Public Class DashboardForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If Not SessionManager.IsLoggedIn() Then
                RedirectToLogin()
                Return
            End If

            Dim user = SessionManager.CurrentUser
            lblWelcome.Text = $"Selamat Datang, {user.Fullname} [{user.Role}]"

            ApplyRolePermissions(user.Role)
        End Sub

        Private Sub ApplyRolePermissions(role As String)
            If btnKelolaUser IsNot Nothing Then
                btnKelolaUser.Enabled = role.Equals("Admin", StringComparison.OrdinalIgnoreCase)
            End If
        End Sub

        Private Sub btnKendaraanMasuk_Click(sender As Object, e As EventArgs) Handles btnKendaraanMasuk.Click
            Dim entryForm As New EntryForm()
            entryForm.ShowDialog(Me)
        End Sub

        Private Sub btnKendaraanKeluar_Click(sender As Object, e As EventArgs) Handles btnKendaraanKeluar.Click
            Dim exitForm As New ExitForm()
            exitForm.ShowDialog(Me)
        End Sub

        Private Sub btnDataAktif_Click(sender As Object, e As EventArgs) Handles btnDataAktif.Click
            Dim activeForm As New ActiveParkingForm()
            activeForm.ShowDialog(Me)
        End Sub

        Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
            Dim historyForm As New HistoryForm()
            historyForm.ShowDialog(Me)
        End Sub

        Private Sub btnKelolaUser_Click(sender As Object, e As EventArgs) Handles btnKelolaUser.Click
            Dim userForm As New UserManagementForm()
            userForm.ShowDialog(Me)
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            SessionManager.ClearSession()
            RedirectToLogin()
        End Sub

        Private Sub RedirectToLogin()
            Dim login As New LoginForm()
            login.Show()
            Me.Hide()
        End Sub

        Private Sub DashboardForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            Application.Exit()
        End Sub
    End Class
End Namespace