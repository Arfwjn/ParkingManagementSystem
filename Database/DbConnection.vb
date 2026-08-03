Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Namespace Database
    Public Class DbConnection
        Private Shared _instance As DbConnection
        Private ReadOnly _connectionString As String

        Private Sub New()
            ' Parameter konfigurasi database MySQL (XAMPP / phpMyAdmin)
            Dim server As String = "localhost"
            Dim database As String = "parking_db"
            Dim uid As String = "root"
            Dim password As String = "" ' Sesuaikan jika MySQL XAMPP Anda menggunakan password
            Dim port As String = "3306"

            ' PERBAIKAN: SslMode diubah dari 'None' menjadi 'Disabled'
            _connectionString = $"Server={server};Port={port};Database={database};Uid={uid};Pwd={password};SslMode=Disabled;Pooling=true;Min Pool Size=5;Max Pool Size=50;"
        End Sub

        Public Shared ReadOnly Property Instance As DbConnection
            Get
                If _instance Is Nothing Then
                    _instance = New DbConnection()
                End If
                Return _instance
            End Get
        End Property

        Public Function GetConnection() As MySqlConnection
            Return New MySqlConnection(_connectionString)
        End Function

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