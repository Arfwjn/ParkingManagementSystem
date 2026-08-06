Imports MySql.Data.MySqlClient
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Database

Namespace Repositories
    ''' <summary>
    ''' Repository UserRepository bertanggung jawab atas akses data (Data Access Layer - DAL) untuk tabel pengguna (users).
    ''' </summary>
    Public Class UserRepository
        ''' <summary>
        ''' Memverifikasi kredensial login pengguna berdasarkan username dan kata sandi yang di-hash SHA-256.
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
        ''' Mengambil seluruh data pengguna terdaftar berformat DataTable untuk pengisian komponen DataGridView.
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
        ''' Memeriksa ketersediaan username di database untuk mencegah duplikasi (kecuali ID pengguna yang sedang disunting).
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
        ''' Menyimpan data akun pengguna baru ke dalam database.
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
        ''' Memperbarui informasi akun pengguna (dapat menyertakan perubahan kata sandi baru atau hanya informasi profil).
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
        ''' Menghapus akun pengguna dari database berdasarkan ID pengguna.
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