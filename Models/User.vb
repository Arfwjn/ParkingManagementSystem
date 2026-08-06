Namespace Models
    ''' <summary>
    ''' Entity Model User merepresentasikan data akun pengguna/petugas yang mengakses sistem parkir.
    ''' </summary>
    Public Class User
        ''' <summary>ID unik pengguna di database.</summary>
        Public Property Id As Integer
        ''' <summary>Nama akun (username) untuk autentikasi login.</summary>
        Public Property Username As String
        ''' <summary>Kata sandi yang telah terenkripsi SHA-256.</summary>
        Public Property Password As String
        ''' <summary>Nama lengkap pengguna.</summary>
        Public Property Fullname As String
        ''' <summary>Hak akses pengguna (Admin / Petugas).</summary>
        Public Property Role As String
    End Class
End Namespace