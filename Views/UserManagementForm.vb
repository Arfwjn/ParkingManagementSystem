Imports System
Imports System.Data
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers

Namespace Views
    ''' <summary>
    ''' Form UserManagementForm mengelola modul CRUD (Tambah, Edit, Hapus) akun pengguna/petugas sistem parkir.
    ''' </summary>
    Partial Public Class UserManagementForm
        Inherits Form

        Private ReadOnly _userController As UserController
        Private _selectedUserId As Integer = 0

        ''' <summary>
        ''' Constructor untuk menginisialisasi Form Kelola User.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            _userController = New UserController()
        End Sub

        Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            cmbRole.SelectedIndex = 0
            LoadUserData()
            ResetForm()
        End Sub

        ''' <summary>
        ''' Memuat seluruh daftar akun pengguna dari database ke DataGridView.
        ''' </summary>
        Private Sub LoadUserData()
            dgvUsers.DataSource = _userController.GetAllUsers()
        End Sub

        ''' <summary>
        ''' Memindahkan data akun dari baris DataGridView yang dipilih ke dalam kontrol form.
        ''' </summary>
        Private Sub dgvUsers_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsers.SelectionChanged
            If dgvUsers.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = dgvUsers.SelectedRows(0)
                _selectedUserId = Convert.ToInt32(row.Cells("ID").Value)
                txtUsername.Text = row.Cells("Username").Value.ToString()
                txtFullname.Text = row.Cells("Nama Lengkap").Value.ToString()
                cmbRole.SelectedItem = row.Cells("Role").Value.ToString()

                txtPassword.Clear()
                lblPasswordNote.Visible = True
                btnSave.Text = "UPDATE"
                btnDelete.Enabled = True
            End If
        End Sub

        ''' <summary>
        ''' Memproses penyimpanan akun pengguna baru atau pembaruan profil/password pengguna lama.
        ''' </summary>
        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim errorMessage As String = String.Empty
            Dim isSuccess As Boolean = False
            Dim selectedRole As String = If(cmbRole.SelectedItem IsNot Nothing, cmbRole.SelectedItem.ToString(), "Petugas")

            If _selectedUserId = 0 Then
                ' Mode Pembuatan User Baru
                isSuccess = _userController.SaveNewUser(txtUsername.Text, txtPassword.Text, txtFullname.Text, selectedRole, errorMessage)
            Else
                ' Mode Pembaruan User Lama
                isSuccess = _userController.UpdateExistingUser(_selectedUserId, txtUsername.Text, txtPassword.Text, txtFullname.Text, selectedRole, errorMessage)
            End If

            If isSuccess Then
                MessageBox.Show("Data petugas berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUserData()
                ResetForm()
            Else
                MessageBox.Show(errorMessage, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        ''' <summary>
        ''' Menghapus akun pengguna dari database dengan konfirmasi keamanan.
        ''' </summary>
        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If _selectedUserId = 0 Then
                MessageBox.Show("Pilih user yang ingin dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show($"Apakah Anda yakin ingin menghapus petugas '{txtUsername.Text}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim errorMessage As String = String.Empty
                If _userController.RemoveUser(_selectedUserId, errorMessage) Then
                    MessageBox.Show("Petugas berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadUserData()
                    ResetForm()
                Else
                    MessageBox.Show(errorMessage, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

        Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
            ResetForm()
        End Sub

        Private Sub ResetForm()
            _selectedUserId = 0
            txtUsername.Clear()
            txtFullname.Clear()
            txtPassword.Clear()
            cmbRole.SelectedIndex = 0
            lblPasswordNote.Visible = False
            btnSave.Text = "SIMPAN"
            btnDelete.Enabled = False
            dgvUsers.ClearSelection()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub
    End Class
End Namespace