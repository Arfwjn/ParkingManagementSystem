Imports System
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Helpers

Namespace Views
    Partial Public Class DashboardForm
        Inherits Form

        Private ReadOnly _parkingController As ParkingController
        Private Const TOTAL_CAPACITY As Integer = 50 ' Kapasitas total slot parkir

        Public Sub New()
            InitializeComponent()
            _parkingController = New ParkingController()
        End Sub

        Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If Not SessionManager.IsLoggedIn() Then
                RedirectToLogin()
                Return
            End If

            Dim user = SessionManager.CurrentUser
            lblWelcome.Text = $"Selamat Datang, {user.Fullname} [{user.Role}]"

            ApplyRolePermissions(user.Role)
            LoadDashboardData()
        End Sub

        Public Sub LoadDashboardData()
            Try
                Dim activeCount As Integer = _parkingController.GetActiveParkingCount()
                Dim todayCount As Integer = _parkingController.GetTodayEntryCount()
                Dim availableSlots As Integer = Math.Max(0, TOTAL_CAPACITY - activeCount)

                lblActiveValue.Text = activeCount.ToString()
                lblTodayValue.Text = todayCount.ToString()
                lblSlotsValue.Text = availableSlots.ToString()
            Catch ex As Exception
                MessageBox.Show("Gagal memuat statistik dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub ApplyRolePermissions(role As String)
            If btnKelolaUser IsNot Nothing Then
                btnKelolaUser.Enabled = role.Equals("Admin", StringComparison.OrdinalIgnoreCase)
            End If
        End Sub

        Private Sub btnKendaraanMasuk_Click(sender As Object, e As EventArgs) Handles btnKendaraanMasuk.Click
            Using entryForm As New EntryForm()
                entryForm.ShowDialog(Me)
            End Using
            LoadDashboardData()
        End Sub

        Private Sub btnKendaraanKeluar_Click(sender As Object, e As EventArgs) Handles btnKendaraanKeluar.Click
            Using exitForm As New ExitForm()
                exitForm.ShowDialog(Me)
            End Using
            LoadDashboardData()
        End Sub

        Private Sub btnDataAktif_Click(sender As Object, e As EventArgs) Handles btnDataAktif.Click
            Using activeForm As New ActiveParkingForm()
                activeForm.ShowDialog(Me)
            End Using
            LoadDashboardData()
        End Sub

        Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
            Using historyForm As New HistoryForm()
                historyForm.ShowDialog(Me)
            End Using
            LoadDashboardData()
        End Sub

        Private Sub btnKelolaUser_Click(sender As Object, e As EventArgs) Handles btnKelolaUser.Click
            Using userForm As New UserManagementForm()
                userForm.ShowDialog(Me)
            End Using
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