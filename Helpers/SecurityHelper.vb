Imports System.Security.Cryptography
Imports System.Text

Namespace Helpers
    ''' <summary>
    ''' Class SecurityHelper menyediakan fungsi pembantu untuk kebutuhan enkripsi dan keamanan data aplikasi.
    ''' </summary>
    Public Class SecurityHelper
        ''' <summary>
        ''' Mengubah teks kata sandi (plain text) menjadi hash SHA-256 berformat string heksadesimal lowercase.
        ''' </summary>
        Public Shared Function HashSHA256(rawData As String) As String
            Using sha256Hash As SHA256 = SHA256.Create()
                Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData))
                Dim builder As New StringBuilder()
                For i As Integer = 0 To bytes.Length - 1
                    builder.Append(bytes(i).ToString("x2"))
                Next
                Return builder.ToString()
            End Using
        End Function
    End Class
End Namespace