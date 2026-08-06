Imports System
Imports System.Data
Imports ParkingManagementSystem.Helpers
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    ''' <summary>
    ''' Controller UserController mengelola validasi aturan bisnis pembuatan, pengeditan, dan penghapusan akun pengguna/petugas.
    ''' </summary>
    Public Class UserController
        Private ReadOnly _userRepository As UserRepository

        ''' <summary>
        ''' Constructor untuk menginisialisasi repository user.
        ''' </summary>
        Public Sub New()
            _userRepository = New UserRepository()
        End Sub

        ''' <summary>
        ''' Mengambil seluruh data pengguna terdaftar berformat DataTable untuk pengisian komponen DataGridView.
        ''' </summary>
        Public Function GetAllUsers() As DataTable
            Return _userRepository.GetAllUsersDataTable()
        End Function

        ''' <summary>
        ''' Memvalidasi dan menyimpan pembuatan akun pengguna/petugas baru ke database (minimal username 4 karakter, password 6 karakter).
        ''' </summary>
        Public Function SaveNewUser(username As String, password As String, fullname As String, role As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If String.IsNullOrWhiteSpace(username) OrElse username.Length < 4 Then
                errorMessage = "Username minimal harus 4 karakter."
                Return False
            End If

            If String.IsNullOrWhiteSpace(password) OrElse password.Length < 6 Then
                errorMessage = "Password minimal harus 6 karakter."
                Return False
            End If

            If String.IsNullOrWhiteSpace(fullname) Then
                errorMessage = "Nama lengkap wajib diisi."
                Return False
            End If

            ' Memeriksa agar tidak ada username duplikat pada sistem
            If _userRepository.IsUsernameExists(username.Trim(), 0) Then
                errorMessage = $"Username '{username}' sudah digunakan."
                Return False
            End If

            Dim newUser As New User With {
                .username = username.Trim(),
                .password = SecurityHelper.HashSHA256(password),
                .fullname = fullname.Trim(),
                .role = role
            }

            Return _userRepository.AddUser(newUser)
        End Function

        ''' <summary>
        ''' Memvalidasi dan mengeksekusi pembaruan data pengguna (dapat opsional mengganti kata sandi baru atau hanya informasi profil).
        ''' </summary>
        Public Function UpdateExistingUser(userId As Integer, username As String, newPassword As String, fullname As String, role As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If userId <= 0 Then
                errorMessage = "ID User tidak valid."
                Return False
            End If

            If String.IsNullOrWhiteSpace(username) OrElse username.Length < 4 Then
                errorMessage = "Username minimal harus 4 karakter."
                Return False
            End If

            If String.IsNullOrWhiteSpace(fullname) Then
                errorMessage = "Nama lengkap wajib diisi."
                Return False
            End If

            ' Memeriksa agar username baru tidak bentrok dengan akun pengguna lain
            If _userRepository.IsUsernameExists(username.Trim(), userId) Then
                errorMessage = $"Username '{username}' sudah digunakan oleh akun lain."
                Return False
            End If

            Dim isUpdatePassword As Boolean = Not String.IsNullOrWhiteSpace(newPassword)
            Dim hashedPassword As String = String.Empty

            If isUpdatePassword Then
                If newPassword.Length < 6 Then
                    errorMessage = "Password baru minimal harus 6 karakter."
                    Return False
                End If
                hashedPassword = SecurityHelper.HashSHA256(newPassword)
            End If

            Dim targetUser As New User With {
                .Id = userId,
                .username = username.Trim(),
                .Password = hashedPassword,
                .fullname = fullname.Trim(),
                .role = role
            }

            Return _userRepository.UpdateUser(targetUser, isUpdatePassword)
        End Function

        ''' <summary>
        ''' Menghapus akun pengguna dengan proteksi keamanan agar pengguna yang sedang login tidak dapat menghapus akunnya sendiri.
        ''' </summary>
        Public Function RemoveUser(userId As Integer, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            ' Proteksi keamanan: Cegah pengguna menghapus akunnya sendiri yang sedang aktif digunakan
            If SessionManager.CurrentUser IsNot Nothing AndAlso SessionManager.CurrentUser.Id = userId Then
                errorMessage = "Anda tidak dapat menghapus akun Anda sendiri yang sedang digunakan saat ini."
                Return False
            End If

            Return _userRepository.DeleteUser(userId)
        End Function
    End Class
End Namespace