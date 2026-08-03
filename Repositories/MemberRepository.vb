Imports MySql.Data.MySqlClient
Imports ParkingManagementSystem.Database
Imports ParkingManagementSystem.Models

Namespace Repositories
    Public Class MemberRepository
        ''' <summary>
        ''' Memeriksa apakah plat nomor terdaftar sebagai member
        ''' </summary>
        Public Function GetMemberByPlate(plateNumber As String) As Member
            Dim sql As String = "SELECT id, plate_number, owner_name, member_level FROM members WHERE plate_number = @plateNumber LIMIT 1"

            Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@plateNumber", plateNumber)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return New Member With {
                                .Id = Convert.ToInt32(reader("id")),
                                .plateNumber = reader("plate_number").ToString(),
                                .OwnerName = reader("owner_name").ToString(),
                                .MemberLevel = reader("member_level").ToString()
                            }
                        End If
                    End Using
                End Using
            End Using
            Return Nothing
        End Function
    End Class
End Namespace