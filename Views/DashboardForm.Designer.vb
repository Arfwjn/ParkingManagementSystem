Imports System.Windows.Forms

Namespace Views
    Partial Class DashboardForm

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
            Me.panelHeader = New Panel()
            Me.lblWelcome = New Label()
            Me.btnLogout = New Button()
            Me.pnlMenu = New Panel()
            Me.btnKendaraanMasuk = New Button()
            Me.btnKendaraanKeluar = New Button()
            Me.btnDataAktif = New Button()
            Me.btnRiwayat = New Button()
            Me.btnKelolaUser = New Button()
            Me.panelHeader.SuspendLayout()
            Me.pnlMenu.SuspendLayout()
            Me.SuspendLayout()
            '
            ' panelHeader
            '
            Me.panelHeader.BackColor = System.Drawing.Color.SteelBlue
            Me.panelHeader.Controls.Add(Me.btnLogout)
            Me.panelHeader.Controls.Add(Me.lblWelcome)
            Me.panelHeader.Dock = DockStyle.Top
            Me.panelHeader.Location = New System.Drawing.Point(0, 0)
            Me.panelHeader.Name = "panelHeader"
            Me.panelHeader.Size = New System.Drawing.Size(800, 60)
            Me.panelHeader.TabIndex = 0
            '
            ' lblWelcome
            '
            Me.lblWelcome.AutoSize = True
            Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblWelcome.ForeColor = System.Drawing.Color.White
            Me.lblWelcome.Location = New System.Drawing.Point(20, 18)
            Me.lblWelcome.Name = "lblWelcome"
            Me.lblWelcome.Size = New System.Drawing.Size(180, 21)
            Me.lblWelcome.TabIndex = 0
            Me.lblWelcome.Text = "Selamat Datang, User"
            '
            ' btnLogout
            '
            Me.btnLogout.BackColor = System.Drawing.Color.Crimson
            Me.btnLogout.FlatStyle = FlatStyle.Flat
            Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogout.ForeColor = System.Drawing.Color.White
            Me.btnLogout.Location = New System.Drawing.Point(670, 12)
            Me.btnLogout.Name = "btnLogout"
            Me.btnLogout.Size = New System.Drawing.Size(110, 35)
            Me.btnLogout.TabIndex = 1
            Me.btnLogout.Text = "LOGOUT"
            Me.btnLogout.UseVisualStyleBackColor = False
            '
            ' pnlMenu
            '
            Me.pnlMenu.Controls.Add(Me.btnKelolaUser)
            Me.pnlMenu.Controls.Add(Me.btnRiwayat)
            Me.pnlMenu.Controls.Add(Me.btnDataAktif)
            Me.pnlMenu.Controls.Add(Me.btnKendaraanKeluar)
            Me.pnlMenu.Controls.Add(Me.btnKendaraanMasuk)
            Me.pnlMenu.Dock = DockStyle.Fill
            Me.pnlMenu.Location = New System.Drawing.Point(0, 60)
            Me.pnlMenu.Name = "pnlMenu"
            Me.pnlMenu.Size = New System.Drawing.Size(800, 390)
            Me.pnlMenu.TabIndex = 1
            '
            ' btnKendaraanMasuk
            '
            Me.btnKendaraanMasuk.BackColor = System.Drawing.Color.DodgerBlue
            Me.btnKendaraanMasuk.FlatStyle = FlatStyle.Flat
            Me.btnKendaraanMasuk.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnKendaraanMasuk.ForeColor = System.Drawing.Color.White
            Me.btnKendaraanMasuk.Location = New System.Drawing.Point(50, 40)
            Me.btnKendaraanMasuk.Name = "btnKendaraanMasuk"
            Me.btnKendaraanMasuk.Size = New System.Drawing.Size(200, 80)
            Me.btnKendaraanMasuk.TabIndex = 0
            Me.btnKendaraanMasuk.Text = "KENDARAAN MASUK"
            Me.btnKendaraanMasuk.UseVisualStyleBackColor = False
            '
            ' btnKendaraanKeluar
            '
            Me.btnKendaraanKeluar.BackColor = System.Drawing.Color.DarkOrange
            Me.btnKendaraanKeluar.FlatStyle = FlatStyle.Flat
            Me.btnKendaraanKeluar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnKendaraanKeluar.ForeColor = System.Drawing.Color.White
            Me.btnKendaraanKeluar.Location = New System.Drawing.Point(300, 40)
            Me.btnKendaraanKeluar.Name = "btnKendaraanKeluar"
            Me.btnKendaraanKeluar.Size = New System.Drawing.Size(200, 80)
            Me.btnKendaraanKeluar.TabIndex = 1
            Me.btnKendaraanKeluar.Text = "KENDARAAN KELUAR"
            Me.btnKendaraanKeluar.UseVisualStyleBackColor = False
            '
            ' btnDataAktif
            '
            Me.btnDataAktif.BackColor = System.Drawing.Color.MediumSeaGreen
            Me.btnDataAktif.FlatStyle = FlatStyle.Flat
            Me.btnDataAktif.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnDataAktif.ForeColor = System.Drawing.Color.White
            Me.btnDataAktif.Location = New System.Drawing.Point(550, 40)
            Me.btnDataAktif.Name = "btnDataAktif"
            Me.btnDataAktif.Size = New System.Drawing.Size(200, 80)
            Me.btnDataAktif.TabIndex = 2
            Me.btnDataAktif.Text = "KENDARAAN AKTIF"
            Me.btnDataAktif.UseVisualStyleBackColor = False
            '
            ' btnRiwayat
            '
            Me.btnRiwayat.BackColor = System.Drawing.Color.SlateGray
            Me.btnRiwayat.FlatStyle = FlatStyle.Flat
            Me.btnRiwayat.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnRiwayat.ForeColor = System.Drawing.Color.White
            Me.btnRiwayat.Location = New System.Drawing.Point(50, 160)
            Me.btnRiwayat.Name = "btnRiwayat"
            Me.btnRiwayat.Size = New System.Drawing.Size(200, 80)
            Me.btnRiwayat.TabIndex = 3
            Me.btnRiwayat.Text = "RIWAYAT TRANSAKSI"
            Me.btnRiwayat.UseVisualStyleBackColor = False
            '
            ' btnKelolaUser
            '
            Me.btnKelolaUser.BackColor = System.Drawing.Color.DarkSlateBlue
            Me.btnKelolaUser.FlatStyle = FlatStyle.Flat
            Me.btnKelolaUser.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnKelolaUser.ForeColor = System.Drawing.Color.White
            Me.btnKelolaUser.Location = New System.Drawing.Point(300, 160)
            Me.btnKelolaUser.Name = "btnKelolaUser"
            Me.btnKelolaUser.Size = New System.Drawing.Size(200, 80)
            Me.btnKelolaUser.TabIndex = 4
            Me.btnKelolaUser.Text = "KELOLA PETUGAS"
            Me.btnKelolaUser.UseVisualStyleBackColor = False
            '
            ' DashboardForm
            '
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.pnlMenu)
            Me.Controls.Add(Me.panelHeader)
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.Name = "DashboardForm"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Parking App - Dashboard System"
            Me.panelHeader.ResumeLayout(False)
            Me.panelHeader.PerformLayout()
            Me.pnlMenu.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

        Friend WithEvents panelHeader As Panel
        Friend WithEvents lblWelcome As Label
        Friend WithEvents btnLogout As Button
        Friend WithEvents pnlMenu As Panel
        Friend WithEvents btnKendaraanMasuk As Button
        Friend WithEvents btnKendaraanKeluar As Button
        Friend WithEvents btnDataAktif As Button
        Friend WithEvents btnRiwayat As Button
        Friend WithEvents btnKelolaUser As Button
    End Class
End Namespace