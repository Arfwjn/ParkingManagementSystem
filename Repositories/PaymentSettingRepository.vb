Imports MySql.Data.MySqlClient
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Database

''' <summary>
''' Repository PaymentSettingRepository mengelola pembacaan dan pembaruan pengaturan pembayaran QRIS dan Rekening Debit (Row Single ID = 1).
''' </summary>
Public Class PaymentSettingRepository

    ''' <summary>
    ''' Mengambil data pengaturan pembayaran aktif (QRIS & Rekening Bank) dari baris tunggal (ID = 1).
    ''' </summary>
    Public Function GetSetting() As PaymentSetting
        Dim setting As PaymentSetting = Nothing
        Dim query As String = "SELECT id, qris_merchant_name, qris_nmid, qris_image_path, " &
                              "bank_name, account_number, account_holder " &
                              "FROM payment_settings WHERE id = 1 LIMIT 1"

        Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            setting = New PaymentSetting() With {
                                .Id = Convert.ToInt32(reader("id")),
                                .QrisMerchantName = If(IsDBNull(reader("qris_merchant_name")), "", reader("qris_merchant_name").ToString()),
                                .QrisNmid = If(IsDBNull(reader("qris_nmid")), "", reader("qris_nmid").ToString()),
                                .QrisImagePath = If(IsDBNull(reader("qris_image_path")), "", reader("qris_image_path").ToString()),
                                .BankName = If(IsDBNull(reader("bank_name")), "", reader("bank_name").ToString()),
                                .AccountNumber = If(IsDBNull(reader("account_number")), "", reader("account_number").ToString()),
                                .AccountHolder = If(IsDBNull(reader("account_holder")), "", reader("account_holder").ToString())
                            }
                        End If
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Gagal mengambil data pengaturan pembayaran: " & ex.Message)
            End Try
        End Using

        Return setting
    End Function

    ''' <summary>
    ''' Memperbarui konfigurasi Merchant QRIS dan Rekening Bank pada database (ID = 1).
    ''' </summary>
    Public Function UpdateSetting(setting As PaymentSetting) As Boolean
        Dim query As String = "UPDATE payment_settings SET " &
                              "qris_merchant_name = @qrisMerchant, " &
                              "qris_nmid = @qrisNmid, " &
                              "qris_image_path = @qrisImage, " &
                              "bank_name = @bankName, " &
                              "account_number = @accNumber, " &
                              "account_holder = @accHolder " &
                              "WHERE id = 1"

        Using conn As MySqlConnection = DbConnection.Instance.GetConnection()
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@qrisMerchant", setting.QrisMerchantName)
                    cmd.Parameters.AddWithValue("@qrisNmid", If(String.IsNullOrEmpty(setting.QrisNmid), DBNull.Value, setting.QrisNmid))
                    cmd.Parameters.AddWithValue("@qrisImage", If(String.IsNullOrEmpty(setting.QrisImagePath), DBNull.Value, setting.QrisImagePath))
                    cmd.Parameters.AddWithValue("@bankName", setting.BankName)
                    cmd.Parameters.AddWithValue("@accNumber", setting.AccountNumber)
                    cmd.Parameters.AddWithValue("@accHolder", setting.AccountHolder)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            Catch ex As Exception
                Throw New Exception("Gagal memperbarui pengaturan pembayaran: " & ex.Message)
            End Try
        End Using
    End Function

End Class