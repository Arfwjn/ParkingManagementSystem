Imports System.Collections.Generic
Imports System.Data
Imports ParkingManagementSystem.Helpers
Imports ParkingManagementSystem.Models
Imports ParkingManagementSystem.Repositories

Namespace Controllers
    ''' <summary>
    ''' Controller MemberController mengelola aturan bisnis pendaftaran member, validasi multi-plat nomor (maksimal 3 kendaraan),
    ''' pengeditan profil, perpanjangan masa aktif keanggotaan, dan transaksi pembayaran berlangganan.
    ''' </summary>
    Public Class MemberController
        Private ReadOnly _memberRepository As MemberRepository
        Private ReadOnly _memberLevelRepository As MemberLevelRepository

        ''' <summary>
        ''' Inisialisasi controller member dan instansiasi repository member & level.
        ''' </summary>
        Public Sub New()
            _memberRepository = New MemberRepository()
            _memberLevelRepository = New MemberLevelRepository()
        End Sub

        ''' <summary>
        ''' Mengambil daftar seluruh pilihan level keanggotaan yang tersedia.
        ''' </summary>
        Public Function GetMemberLevels() As List(Of MemberLevel)
            Return _memberLevelRepository.GetAll()
        End Function

        ''' <summary>
        ''' Mengambil data seluruh member terintegrasi berformat DataTable untuk tampilan DataGridView.
        ''' </summary>
        Public Function GetAllMembersDataTable() As DataTable
            Return _memberRepository.GetAllMembersDataTable()
        End Function

        ''' <summary>
        ''' Mendaftarkan member baru dengan 1 hingga 3 plat nomor kendaraan sekaligus beserta validasi duplikasi.
        ''' </summary>
        Public Function RegisterMember(ownerName As String, plateNumbers As List(Of String), levelId As Integer, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If String.IsNullOrWhiteSpace(ownerName) Then
                errorMessage = "Nama pemilik wajib diisi."
                Return False
            End If

            If levelId <= 0 Then
                errorMessage = "Pilih level member yang valid."
                Return False
            End If

            ' Menyaring daftar plat nomor kendaraan agar tidak ada string kosong atau duplikat pada input
            Dim validPlates As New List(Of String)()
            For Each plate In plateNumbers
                If Not String.IsNullOrWhiteSpace(plate) Then
                    Dim cleanPlate As String = plate.Trim().ToUpper()
                    If Not validPlates.Contains(cleanPlate) Then
                        validPlates.Add(cleanPlate)
                    End If
                End If
            Next

            If validPlates.Count = 0 Then
                errorMessage = "Minimal 1 plat nomor kendaraan harus diisi."
                Return False
            End If

            ' Memeriksa batas aturan bisnis maksimal 3 kendaraan terdaftar per pemilik
            Dim existingCount As Integer = _memberRepository.GetPlateCountByOwner(ownerName)
            If (existingCount + validPlates.Count) > 3 Then
                errorMessage = $"Pemilik '{ownerName}' sudah memiliki {existingCount} plat terdaftar. Maksimal plat nomor per individu adalah 3 unit."
                Return False
            End If

            ' Memeriksa ketersediaan plat nomor agar tidak bentrok dengan member lain
            For Each plate In validPlates
                If _memberRepository.IsPlateRegistered(plate) Then
                    errorMessage = $"Plat nomor '{plate}' sudah terdaftar pada member lain."
                    Return False
                End If
            Next

            ' Menyimpan data member baru ke database
            If Not _memberRepository.SaveMemberWithPlates(ownerName, validPlates, levelId) Then
                errorMessage = "Gagal mendaftarkan data member ke database."
                Return False
            End If

            Return True
        End Function

        ''' <summary>
        ''' Menghapus data member dari database berdasarkan ID member.
        ''' </summary>
        Public Function DeleteMember(id As Integer, ByRef errorMessage As String) As Boolean
            If id <= 0 Then
                errorMessage = "Pilih data member yang ingin dihapus."
                Return False
            End If

            If Not _memberRepository.DeleteMember(id) Then
                errorMessage = "Gagal menghapus data member dari database."
                Return False
            End If

            Return True
        End Function

        ''' <summary>
        ''' Mendaftarkan member baru lengkap beserta konfirmasi penerimaan transaksi pembayaran awal.
        ''' </summary>
        Public Function RegisterMemberWithPayment(ownerName As String, plateNumbers As List(Of String), levelId As Integer, paymentMethod As String, referenceNumber As String, totalAmount As Decimal, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            ' Validasi input dasar
            If String.IsNullOrWhiteSpace(ownerName) Then
                errorMessage = "Nama pemilik wajib diisi."
                Return False
            End If

            If levelId <= 0 Then
                errorMessage = "Pilih level member yang valid."
                Return False
            End If

            Dim validPlates As New List(Of String)()
            For Each plate In plateNumbers
                If Not String.IsNullOrWhiteSpace(plate) Then
                    Dim cleanPlate As String = plate.Trim().ToUpper()
                    If Not validPlates.Contains(cleanPlate) Then validPlates.Add(cleanPlate)
                End If
            Next

            If validPlates.Count = 0 Then
                errorMessage = "Minimal 1 plat nomor kendaraan harus diisi."
                Return False
            End If

            ' Validasi batasan 3 plat nomor per pemilik
            Dim existingCount As Integer = _memberRepository.GetPlateCountByOwner(ownerName)
            If (existingCount + validPlates.Count) > 3 Then
                errorMessage = $"Pemilik '{ownerName}' sudah memiliki {existingCount} plat terdaftar. Maksimal 3 kendaraan per individu."
                Return False
            End If

            ' Validasi duplikasi plat pada sistem
            For Each plate In validPlates
                If _memberRepository.IsPlateRegistered(plate) Then
                    errorMessage = $"Plat nomor '{plate}' sudah terdaftar pada member lain."
                    Return False
                End If
            Next

            ' Menyimpan data member dan multi-plat
            If Not _memberRepository.SaveMemberWithPlates(ownerName, validPlates, levelId) Then
                errorMessage = "Gagal menyimpan data member ke database."
                Return False
            End If

            Return True
        End Function

        ''' <summary>
        ''' Memvalidasi dan mengeksekusi pembaruan profil data member beserta daftar plat nomornya.
        ''' </summary>
        Public Function UpdateMemberProfile(memberId As Integer, ownerName As String, levelId As Integer, plateNumbers As List(Of String), ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If memberId <= 0 Then
                errorMessage = "ID Member tidak valid."
                Return False
            End If

            If String.IsNullOrWhiteSpace(ownerName) Then
                errorMessage = "Nama pemilik wajib diisi."
                Return False
            End If

            Dim validPlates As New List(Of String)()
            For Each plate In plateNumbers
                If Not String.IsNullOrWhiteSpace(plate) Then
                    Dim cleanPlate As String = plate.Trim().ToUpper()
                    If Not validPlates.Contains(cleanPlate) Then validPlates.Add(cleanPlate)
                End If
            Next

            If validPlates.Count = 0 Then
                errorMessage = "Minimal 1 plat nomor kendaraan harus diisi."
                Return False
            End If

            If validPlates.Count > 3 Then
                errorMessage = "Maksimal 3 plat nomor kendaraan per member."
                Return False
            End If

            Return _memberRepository.UpdateMemberDetails(memberId, ownerName, levelId, validPlates)
        End Function

        ''' <summary>
        ''' Memproses perpanjangan masa aktif berlangganan member (+1 bulan) serta menyimpan log pembayarannya.
        ''' </summary>
        Public Function RenewSubscriptionWithPayment(memberId As Integer, paymentMethod As String, referenceNumber As String, totalAmount As Decimal, ByRef errorMessage As String) As Boolean
            errorMessage = String.Empty

            If memberId <= 0 Then
                errorMessage = "ID Member tidak valid."
                Return False
            End If

            ' Memperbarui tanggal kedaluwarsa (+1 bulan) dan mengaktifkan kembali status member
            If Not _memberRepository.RenewSubscription(memberId) Then
                errorMessage = "Gagal memperpanjang masa aktif member di database."
                Return False
            End If

            Return True
        End Function
    End Class
End Namespace