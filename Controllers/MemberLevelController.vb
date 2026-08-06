Imports System.Collections.Generic
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    ''' <summary>
    ''' Controller MemberLevelController menangani validasi bisnis dan operasi kelola tingkatan member (persentase diskon & iuran bulanan).
    ''' </summary>
    Public Class MemberLevelController
        Private ReadOnly _repository As MemberLevelRepository

        ''' <summary>
        ''' Constructor untuk menginisialisasi repository level member.
        ''' </summary>
        Public Sub New()
            _repository = New MemberLevelRepository()
        End Sub

        ''' <summary>
        ''' Mengambil seluruh tingkatan member dari database.
        ''' </summary>
        Public Function GetAllLevels() As List(Of MemberLevel)
            Return _repository.GetAll()
        End Function

        ''' <summary>
        ''' Menyimpan level member baru atau memperbarui data level member yang sudah ada dengan validasi rentang diskon dan biaya.
        ''' </summary>
        Public Function SaveLevel(id As Integer, levelName As String, discountPercentage As Decimal, monthlyFee As Decimal, description As String, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            ' Validasi nama level
            If String.IsNullOrWhiteSpace(levelName) Then
                errorMessage = "Nama level member wajib diisi."
                Return False
            End If

            ' Validasi persentase diskon (harus antara 0% - 100%)
            If discountPercentage < 0 OrElse discountPercentage > 100 Then
                errorMessage = "Persentase diskon harus bernilai antara 0% hingga 100%."
                Return False
            End If

            ' Validasi biaya langganan bulanan
            If monthlyFee < 0 Then
                errorMessage = "Biaya bulanan tidak boleh bernilai negatif."
                Return False
            End If

            ' Inisialisasi entitas objek MemberLevel
            Dim levelObj As New MemberLevel() With {
                .Id = id,
                .LevelName = levelName.Trim(),
                .DiscountPercentage = discountPercentage,
                .MonthlyFee = monthlyFee,
                .Description = If(description IsNot Nothing, description.Trim(), String.Empty)
            }

            ' Eksekusi pembaruan data jika ID > 0, atau pembuatan data baru jika ID = 0
            If id > 0 Then
                If Not _repository.Update(levelObj) Then
                    errorMessage = "Gagal memperbarui data level member di database."
                    Return False
                End If
            Else
                If Not _repository.Save(levelObj) Then
                    errorMessage = "Gagal menyimpan level member baru ke database."
                    Return False
                End If
            End If

            Return True
        End Function

        ''' <summary>
        ''' Menghapus data level member dari database berdasarkan ID level.
        ''' </summary>
        Public Function DeleteLevel(id As Integer, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If id <= 0 Then
                errorMessage = "Pilih level member yang valid untuk dihapus."
                Return False
            End If

            If Not _repository.Delete(id) Then
                errorMessage = "Gagal menghapus level member. Pastikan level tidak sedang digunakan oleh member aktif."
                Return False
            End If

            Return True
        End Function
    End Class
End Namespace