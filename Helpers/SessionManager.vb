Imports ParkingManagementSystem.Models

Namespace Helpers
    ''' <summary>
    ''' Class SessionManager menyimpan state dan data pengguna (User) yang sedang berhasil melakukan login ke sistem.
    ''' </summary>
    Public Class SessionManager
        ''' <summary>
        ''' Menyimpan informasi data objek User yang sedang aktif menggunakan aplikasi.
        ''' </summary>
        Public Shared Property CurrentUser As User

        ''' <summary>
        ''' Membersihkan sesi login pengguna saat melakukan logout.
        ''' </summary>
        Public Shared Sub ClearSession()
            CurrentUser = Nothing
        End Sub

        ''' <summary>
        ''' Memeriksa apakah saat ini ada pengguna yang terautentikasi / terdeteksi login.
        ''' </summary>
        Public Shared Function IsLoggedIn() As Boolean
            Return CurrentUser IsNot Nothing
        End Function
    End Class
End Namespace