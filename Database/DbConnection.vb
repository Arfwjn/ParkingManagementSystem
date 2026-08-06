Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Namespace Database
    ''' <summary>
    ''' Class DbConnection bertanggung jawab mengelola koneksi utama ke database MySQL.
    ''' Menggunakan pola Singleton agar konfigurasi connection string hanya dibuat sekali selama aplikasi berjalan.
    ''' </summary>
    Public Class DbConnection
        Private Shared _instance As DbConnection
        Private ReadOnly _connectionString As String

        ''' <summary>
        ''' Constructor privat untuk menginisialisasi kredensial dan parameter koneksi MySQL.
        ''' </summary>
        Private Sub New()
            ' Pengaturan kredensial default untuk MySQL XAMPP
            Dim server As String = "localhost"
            Dim database As String = "parking_db"
            Dim uid As String = "root"
            Dim password As String = ""
            Dim port As String = "3306"

            ' Menggabungkan parameter menjadi MySQL connection string dengan fitur Connection Pooling
            _connectionString = $"Server={server};Port={port};Database={database};Uid={uid};Pwd={password};SslMode=Disabled;Pooling=true;Min Pool Size=5;Max Pool Size=50;"
        End Sub

        ''' <summary>
        ''' Property global untuk mengakses instance tunggal dari DbConnection.
        ''' </summary>
        Public Shared ReadOnly Property Instance As DbConnection
            Get
                If _instance Is Nothing Then
                    _instance = New DbConnection()
                End If
                Return _instance
            End Get
        End Property

        ''' <summary>
        ''' Membuat dan mengembalikan objek MySqlConnection baru siap pakai.
        ''' </summary>
        Public Function GetConnection() As MySqlConnection
            Return New MySqlConnection(_connectionString)
        End Function

        ''' <summary>
        ''' Menguji apakah koneksi ke database MySQL berhasil dilakukan atau terdapat kendala.
        ''' </summary>
        Public Function TestConnection(ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty
            Try
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    Return conn.State = ConnectionState.Open
                End Using
            Catch ex As Exception
                errorMessage = ex.Message
                Return False
            End Try
        End Function
    End Class
End Namespace