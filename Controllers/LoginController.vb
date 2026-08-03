Imports ParkingManagementSystem.Helpers
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    Public Class LoginController
        Private ReadOnly _userRepository As UserRepository

        Public Sub New()
            _userRepository = New UserRepository()
        End Sub

        ''' <summary>
        ''' Memvalidasi input form dan melakukan autentikasi login
        ''' </summary>
        Public Function Login(username As String, password As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            ' 1. Validasi bisnis input
            If String.IsNullOrWhiteSpace(username) Then
                errorMessage = "Username tidak boleh kosong."
                Return False
            End If

            If String.IsNullOrWhiteSpace(password) Then
                errorMessage = "Password tidak boleh kosong."
                Return False
            End If

            ' 2. Enkripsi password input
            Dim hashedPassword As String = SecurityHelper.HashSHA256(password)

            ' 3. Eksekusi pengecekan ke database
            Dim user As User = _userRepository.GetUserByCredentials(username, hashedPassword)

            If user IsNot Nothing Then
                ' Simpan sesi pengguna
                SessionManager.CurrentUser = user
                Return True
            Else
                errorMessage = "Username atau password salah!"
                Return False
            End If
        End Function
    End Class
End Namespace