Imports MySql.Data.MySqlClient
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Database

Namespace Repositories
    Public Class UserRepository
        ''' <summary>
        ''' Memverifikasi kredensial pengguna berdasarkan username dan password hash
        ''' </summary>
        Public Function GetUserByCredentials(username As String, passwordHash As String) As User
            Dim sql As String = "SELECT id, username, fullname, role FROM users WHERE username = @username AND password = @password LIMIT 1"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", passwordHash)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return New User With {
                                .Id = Convert.ToInt32(reader("id")),
                                .username = reader("username").ToString(),
                                .Fullname = reader("fullname").ToString(),
                                .Role = reader("role").ToString()
                            }
                        End If
                    End Using
                End Using
            End Using
            Return Nothing
        End Function

        ''' <summary>
        ''' Mengambil seluruh data user untuk ditampilkan pada tabel DataGridView
        ''' </summary>
        Public Function GetAllUsersDataTable() As DataTable
            Dim dt As New DataTable()
            Dim sql As String = "SELECT id AS 'ID', username AS 'Username', fullname AS 'Nama Lengkap', " &
                               "role AS 'Role', created_at AS 'Tanggal Dibuat' FROM users ORDER BY id ASC"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
            Return dt
        End Function

        ''' <summary>
        ''' Memeriksa apakah username sudah digunakan oleh user lain
        ''' </summary>
        Public Function IsUsernameExists(username As String, excludeId As Integer) As Boolean
            Dim sql As String = "SELECT COUNT(*) FROM users WHERE username = @username AND id <> @excludeId"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@excludeId", excludeId)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menambahkan user baru
        ''' </summary>
        Public Function AddUser(u As User) As Boolean
            Dim sql As String = "INSERT INTO users (username, password, fullname, role) VALUES (@username, @password, @fullname, @role)"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@username", u.Username)
                    cmd.Parameters.AddWithValue("@password", u.Password)
                    cmd.Parameters.AddWithValue("@fullname", u.Fullname)
                    cmd.Parameters.AddWithValue("@role", u.Role)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Mengubah data user (dengan atau tanpa memperbarui password)
        ''' </summary>
        Public Function UpdateUser(u As User, isUpdatePassword As Boolean) As Boolean
            Dim sql As String
            If isUpdatePassword Then
                sql = "UPDATE users SET username = @username, password = @password, fullname = @fullname, role = @role WHERE id = @id"
            Else
                sql = "UPDATE users SET username = @username, fullname = @fullname, role = @role WHERE id = @id"
            End If

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@username", u.Username)
                    If isUpdatePassword Then
                        cmd.Parameters.AddWithValue("@password", u.Password)
                    End If
                    cmd.Parameters.AddWithValue("@fullname", u.Fullname)
                    cmd.Parameters.AddWithValue("@role", u.Role)
                    cmd.Parameters.AddWithValue("@id", u.Id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Menghapus user berdasarkan ID
        ''' </summary>
        Public Function DeleteUser(userId As Integer) As Boolean
            Dim sql As String = "DELETE FROM users WHERE id = @id"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        End Function
    End Class
End Namespace