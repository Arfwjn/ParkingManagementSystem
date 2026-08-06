Imports ParkingManagementSystem.Helpers
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    ''' <summary>
    ''' Controller LoginController mengelola proses autentikasi masuk (login) pengguna ke aplikasi.
    ''' </summary>
    Public Class LoginController
        Private ReadOnly _userRepository As UserRepository

        ''' <summary>
        ''' Inisialisasi controller login dan repository user.
        ''' </summary>
        Public Sub New()
            _userRepository = New UserRepository()
        End Sub

        ''' <summary>
        ''' Memvalidasi input username/password, melakukan verifikasi enkripsi kata sandi, dan menyimpan objek User pada SessionManager jika berhasil.
        ''' </summary>
        Public Function Login(username As String, password As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            ' Validasi kelengkapan input username dan password
            If String.IsNullOrWhiteSpace(username) Then
                errorMessage = "Username tidak boleh kosong."
                Return False
            End If

            If String.IsNullOrWhiteSpace(password) Then
                errorMessage = "Password tidak boleh kosong."
                Return False
            End If

            ' Mengubah password plain text menjadi hash SHA-256
            Dim hashedPassword As String = SecurityHelper.HashSHA256(password)

            ' Verifikasi kredensial ke database
            Dim user As User = _userRepository.GetUserByCredentials(username, hashedPassword)

            If user IsNot Nothing Then
                ' Menyimpan data pengguna ke sesi aktif aplikasi
                SessionManager.CurrentUser = user
                Return True
            Else
                errorMessage = "Username atau password salah!"
                Return False
            End If
        End Function
    End Class
End Namespace