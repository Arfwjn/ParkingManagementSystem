Imports System
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Helpers

Namespace Views
    Partial Public Class DashboardForm
        Inherits Form

        Private ReadOnly _dashboardController As DashboardController
        Private _isLoggingOut As Boolean = False

        Public Sub New()
            InitializeComponent()
            _dashboardController = New DashboardController()
        End Sub

        Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If SessionManager.IsLoggedIn() Then
                lblWelcome.Text = $"Selamat Datang, {SessionManager.CurrentUser.Fullname} [{SessionManager.CurrentUser.Role}]"
            End If

            ' Terapkan Hak Akses Berdasarkan Role Pengguna
            ApplyRolePermissions()

            ' Memuat Data Statistik Dashboard
            LoadDashboardData()
        End Sub

        ''' <summary>
        ''' Mengatur visibilitas menu navigasi berdasarkan peran (Role) pengguna aktif
        ''' </summary>
        Private Sub ApplyRolePermissions()
            If SessionManager.IsLoggedIn() AndAlso SessionManager.CurrentUser IsNot Nothing Then
                Dim userRole As String = SessionManager.CurrentUser.Role

                ' Jika pengguna adalah 'Petugas' (bukan Admin), sembunyikan menu administratif
                If Not userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                    btnKelolaUser.Visible = False
                    btnTariffManagement.Visible = False
                    btnMemberLevelManagement.Visible = False
                    btnPaymentSetting.Visible = False
                    btnLaporan.Visible = False
                Else
                    ' Admin memiliki akses penuh ke seluruh menu
                    btnKelolaUser.Visible = True
                    btnTariffManagement.Visible = True
                    btnMemberLevelManagement.Visible = True
                    btnPaymentSetting.Visible = True
                    btnLaporan.Visible = True
                End If
            End If
        End Sub

        ''' <summary>
        ''' Pengecekan keamanan tambahan sebelum membuka form khusus Admin
        ''' </summary>
        Private Function CheckAdminAccess() As Boolean
            If SessionManager.IsLoggedIn() AndAlso Not SessionManager.CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Akses ditolak. Fitur ini hanya dapat diakses oleh Admin.", "Peringatan Hak Akses", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            Return True
        End Function

        ''' <summary>
        ''' Memuat seluruh statistik KPI, progress kapasitas, dan tabel aktivitas terbaru ke UI
        ''' </summary>
        Public Sub LoadDashboardData()
            Try
                Dim summary As DashboardSummaryData = _dashboardController.GetDashboardSummary()

                ' 1. Bind KPI Cards
                lblActiveValue.Text = summary.ActiveParkingCount.ToString()
                lblTodayValue.Text = summary.TodayEntryCount.ToString()
                lblSlotsValue.Text = summary.AvailableSlots.ToString()
                lblRevenueValue.Text = $"Rp {summary.TodayRevenue:N0}"

                ' 2. Bind Progress Bars Kapasitas Mobil & Motor
                pbCarCapacity.Maximum = DashboardController.MAX_CAR_CAPACITY
                pbCarCapacity.Value = Math.Min(summary.ActiveCarCount, DashboardController.MAX_CAR_CAPACITY)
                Dim carPct As Integer = CInt((summary.ActiveCarCount / CDbl(DashboardController.MAX_CAR_CAPACITY)) * 100)
                lblCarProgressVal.Text = $"{summary.ActiveCarCount} / {DashboardController.MAX_CAR_CAPACITY} ({carPct}%)"

                pbMotorCapacity.Maximum = DashboardController.MAX_MOTORCYCLE_CAPACITY
                pbMotorCapacity.Value = Math.Min(summary.ActiveMotorcycleCount, DashboardController.MAX_MOTORCYCLE_CAPACITY)
                Dim motorPct As Integer = CInt((summary.ActiveMotorcycleCount / CDbl(DashboardController.MAX_MOTORCYCLE_CAPACITY)) * 100)
                lblMotorProgressVal.Text = $"{summary.ActiveMotorcycleCount} / {DashboardController.MAX_MOTORCYCLE_CAPACITY} ({motorPct}%)"

                ' 3. Bind DataGridView Aktivitas Terkini
                dgvRecentActivity.DataSource = Nothing
                dgvRecentActivity.DataSource = summary.RecentActivityData

                ' Formatting Kolom DataGridView
                If dgvRecentActivity.Columns("Total Bayar") IsNot Nothing Then
                    dgvRecentActivity.Columns("Total Bayar").DefaultCellStyle.Format = "N0"
                End If
            Catch ex As Exception
                MessageBox.Show("Gagal memuat data dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ' ==========================================
        ' MENU NAVIGATION EVENT HANDLERS
        ' ==========================================

        Private Sub btnKendaraanMasuk_Click(sender As Object, e As EventArgs) Handles btnKendaraanMasuk.Click
            Dim form As New EntryForm()
            form.ShowDialog(Me)
            LoadDashboardData()
        End Sub

        Private Sub btnKendaraanKeluar_Click(sender As Object, e As EventArgs) Handles btnKendaraanKeluar.Click
            Dim form As New ExitForm()
            form.ShowDialog(Me)
            LoadDashboardData()
        End Sub

        Private Sub btnDataAktif_Click(sender As Object, e As EventArgs) Handles btnDataAktif.Click
            Dim form As New ActiveParkingForm()
            form.ShowDialog(Me)
            LoadDashboardData()
        End Sub

        Private Sub btnRiwayat_Click(sender As Object, e As EventArgs) Handles btnRiwayat.Click
            ' Membuka Form Riwayat Transaksi Umum
            Dim form As New HistoryForm()
            form.ShowDialog(Me)
        End Sub

        Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
            ' Membuka Modul Laporan Pendapatan (Harian, Mingguan, Bulanan & CSV)
            If Not CheckAdminAccess() Then Return
            Dim form As New ReportForm()
            form.ShowDialog(Me)
        End Sub

        Private Sub btnKelolaMember_Click(sender As Object, e As EventArgs) Handles btnKelolaMember.Click
            Dim form As New MemberRegistrationForm()
            form.ShowDialog(Me)
            LoadDashboardData()
        End Sub

        ' Menu Khusus Admin (Dilengkapi Guard CheckAdminAccess)
        Private Sub btnKelolaUser_Click(sender As Object, e As EventArgs) Handles btnKelolaUser.Click
            If Not CheckAdminAccess() Then Return
            Dim form As New UserManagementForm()
            form.ShowDialog(Me)
        End Sub

        Private Sub btnTariffManagement_Click(sender As Object, e As EventArgs) Handles btnTariffManagement.Click
            If Not CheckAdminAccess() Then Return
            Dim form As New TariffManagementForm()
            form.ShowDialog(Me)
            LoadDashboardData()
        End Sub

        Private Sub btnMemberLevelManagement_Click(sender As Object, e As EventArgs) Handles btnMemberLevelManagement.Click
            If Not CheckAdminAccess() Then Return
            Dim form As New MemberLevelManagementForm()
            form.ShowDialog(Me)
            LoadDashboardData()
        End Sub

        Private Sub btnPaymentSetting_Click(sender As Object, e As EventArgs) Handles btnPaymentSetting.Click
            If Not CheckAdminAccess() Then Return
            Dim form As New PaymentSettingForm()
            form.ShowDialog(Me)
            LoadDashboardData()
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            Dim confirm As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari sistem?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                _isLoggingOut = True
                SessionManager.CurrentUser = Nothing

                Dim loginForm As New LoginForm()
                loginForm.Show()
                Me.Close()
            End If
        End Sub

        Private Sub DashboardForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
            If Not _isLoggingOut Then
                Application.Exit()
            End If
        End Sub
    End Class
End Namespace