Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Models

Namespace Views
    ''' <summary>
    ''' Form MemberRegistrationForm mengelola alur pendaftaran member baru (dengan 1 hingga 3 plat nomor), perpanjangan masa aktif bulanan,
    ''' pengeditan profil pelanggan, serta pemrosesan transaksi pembayaran langganan.
    ''' </summary>
    Public Class MemberRegistrationForm
        Private ReadOnly _controller As MemberController
        Private _selectedMemberId As Integer = 0

        ''' <summary>
        ''' Constructor untuk menginisialisasi komponen Form Registrasi Member.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            _controller = New MemberController()
        End Sub

        Private Sub MemberRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadLevelDropdown()
            LoadMemberData()
            ClearForm()
        End Sub

        ''' <summary>
        ''' Memuat daftar tingkatan member (Bronze, Silver, Gold, Platinum) dari database ke ComboBox pilihan.
        ''' </summary>
        Private Sub LoadLevelDropdown()
            Try
                Dim levels As List(Of MemberLevel) = _controller.GetMemberLevels()
                cmbLevel.DataSource = levels
                cmbLevel.DisplayMember = "LevelName"
                cmbLevel.ValueMember = "Id"
            Catch ex As Exception
                MessageBox.Show("Gagal memuat level member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Memuat seluruh data member terdaftar ke DataGridView dan mengatur format tampilan tanggal.
        ''' </summary>
        Private Sub LoadMemberData()
            Try
                Dim dt As DataTable = _controller.GetAllMembersDataTable()
                dgvMembers.DataSource = Nothing
                dgvMembers.DataSource = dt

                ' Sembunyikan kolom internal level_id dari tampilan DataGridView
                If dgvMembers.Columns.Contains("level_id") Then
                    dgvMembers.Columns("level_id").Visible = False
                End If

                ' Format tampilan tanggal pendaftaran dan tanggal kadaluarsa
                If dgvMembers.Columns.Contains("Tanggal Daftar") Then
                    dgvMembers.Columns("Tanggal Daftar").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                End If

                If dgvMembers.Columns.Contains("Masa Aktif") Then
                    dgvMembers.Columns("Masa Aktif").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
                End If

            Catch ex As Exception
                MessageBox.Show("Gagal memuat daftar member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub cmbLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLevel.SelectedIndexChanged
            UpdateTotalFeeDisplay()
        End Sub

        Private Sub cmbTransactionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTransactionType.SelectedIndexChanged
            ApplyControlStates()
            UpdateTotalFeeDisplay()
        End Sub

        ''' <summary>
        ''' Mengatur status aktif/tidaknya kontrol input UI berdasarkan mode transaksi (Pendaftaran Baru, Perpanjangan, atau Edit Profil).
        ''' </summary>
        Private Sub ApplyControlStates()
            If _selectedMemberId > 0 Then
                ' Mode Member Terdaftar Diseleksi
                If cmbTransactionType.SelectedIndex = 0 Then
                    ' Perpanjangan Langganan Bulanan: Kunci profil, buka pilihan pembayaran
                    txtOwnerName.Enabled = False
                    cmbLevel.Enabled = False
                    txtPlate1.Enabled = False
                    txtPlate2.Enabled = False
                    txtPlate3.Enabled = False

                    cmbTransactionType.Enabled = True
                    cmbPaymentMethod.Enabled = True

                    btnSave.Text = "Proses Transaksi Member"
                    btnSave.BackColor = Color.FromArgb(16, 185, 129)

                ElseIf cmbTransactionType.SelectedIndex = 1 Then
                    ' Perbarui Profil Member: Buka form profil, kunci pembayaran
                    txtOwnerName.Enabled = True
                    cmbLevel.Enabled = True
                    txtPlate1.Enabled = True
                    txtPlate2.Enabled = True
                    txtPlate3.Enabled = True

                    cmbTransactionType.Enabled = True
                    cmbPaymentMethod.Enabled = False

                    btnSave.Text = "Perbarui"
                    btnSave.BackColor = Color.FromArgb(245, 158, 11)
                End If
            Else
                ' Mode Pendaftaran Member Baru
                txtOwnerName.Enabled = True
                cmbLevel.Enabled = True
                txtPlate1.Enabled = True
                txtPlate2.Enabled = True
                txtPlate3.Enabled = True

                cmbTransactionType.Enabled = False
                cmbPaymentMethod.Enabled = True

                btnSave.Text = "Daftarkan Member / Bayar"
                btnSave.BackColor = Color.FromArgb(37, 99, 235)
            End If
        End Sub

        ''' <summary>
        ''' Menghitung total biaya iuran langganan bulanan berdasarkan level member yang dipilih.
        ''' </summary>
        Private Function CalculateCurrentFee() As Decimal
            ' Jika Mode Edit Profil (Tanpa Biaya), total biaya = 0
            If _selectedMemberId > 0 AndAlso cmbTransactionType.SelectedIndex = 1 Then
                Return 0D
            End If

            ' Jika Pendaftaran Baru / Perpanjangan Langganan, ambil iuran MonthlyFee dari level
            If cmbLevel IsNot Nothing AndAlso cmbLevel.SelectedItem IsNot Nothing Then
                Dim selectedLevel As MemberLevel = TryCast(cmbLevel.SelectedItem, MemberLevel)
                If selectedLevel IsNot Nothing Then
                    Return selectedLevel.MonthlyFee
                End If
            End If

            Return 50000D
        End Function

        Private Sub UpdateTotalFeeDisplay()
            Dim fee As Decimal = CalculateCurrentFee()
            If _selectedMemberId > 0 AndAlso cmbTransactionType.SelectedIndex = 1 Then
                lblTotalFeeValue.Text = "Rp 0 (Edit Profil)"
            Else
                lblTotalFeeValue.Text = $"Rp {fee:N0}"
            End If
        End Sub

        ''' <summary>
        ''' Memindahkan data member dari baris DataGridView yang diklik ke kontrol input form (termasuk pemisahan multi-plat nomor).
        ''' </summary>
        Private Sub dgvMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellClick
            If e.RowIndex < 0 Then Return

            Try
                Dim selectedRow As DataGridViewRow = dgvMembers.Rows(e.RowIndex)

                ' Mengambil ID Member
                If dgvMembers.Columns.Contains("ID") AndAlso selectedRow.Cells("ID").Value IsNot DBNull.Value Then
                    _selectedMemberId = Convert.ToInt32(selectedRow.Cells("ID").Value)
                Else
                    Return
                End If

                ' Mengambil Nama Pemilik
                If dgvMembers.Columns.Contains("Nama Pemilik") AndAlso selectedRow.Cells("Nama Pemilik").Value IsNot DBNull.Value Then
                    txtOwnerName.Text = selectedRow.Cells("Nama Pemilik").Value.ToString()
                End If

                ' Mengambil Level Member via level_id
                If dgvMembers.Columns.Contains("level_id") AndAlso selectedRow.Cells("level_id").Value IsNot DBNull.Value Then
                    Dim levelId As Integer = Convert.ToInt32(selectedRow.Cells("level_id").Value)
                    cmbLevel.SelectedValue = levelId
                ElseIf dgvMembers.Columns.Contains("Level") AndAlso selectedRow.Cells("Level").Value IsNot DBNull.Value Then
                    Dim levelName As String = selectedRow.Cells("Level").Value.ToString()
                    cmbLevel.SelectedIndex = cmbLevel.FindStringExact(levelName)
                End If

                ' Memisahkan daftar multi-plat nomor yang dipisahkan oleh karakter koma (",")
                If dgvMembers.Columns.Contains("Plat Nomor") AndAlso selectedRow.Cells("Plat Nomor").Value IsNot DBNull.Value Then
                    Dim fullPlates As String = selectedRow.Cells("Plat Nomor").Value.ToString()
                    Dim plateArray As String() = fullPlates.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)

                    txtPlate1.Text = If(plateArray.Length > 0, plateArray(0).Trim(), String.Empty)
                    txtPlate2.Text = If(plateArray.Length > 1, plateArray(1).Trim(), String.Empty)
                    txtPlate3.Text = If(plateArray.Length > 2, plateArray(2).Trim(), String.Empty)
                End If

                SetFormMode(isMemberSelected:=True)

            Catch ex As Exception
                MessageBox.Show("Gagal memuat detail baris yang dipilih: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Mengatur mode pilihan transaksi pada ComboBox (Pendaftaran Baru vs Perpanjangan / Edit Profil).
        ''' </summary>
        Private Sub SetFormMode(isMemberSelected As Boolean)
            cmbTransactionType.Items.Clear()

            If isMemberSelected Then
                cmbTransactionType.Items.Add("Perpanjangan Langganan Bulanan")
                cmbTransactionType.Items.Add("Perbarui Profil Member (Tanpa Biaya)")
                cmbTransactionType.SelectedIndex = 0
            Else
                cmbTransactionType.Items.Add("Pendaftaran Baru (+1 Bulan)")
                cmbTransactionType.SelectedIndex = 0
            End If

            If cmbPaymentMethod.Items.Count > 0 Then cmbPaymentMethod.SelectedIndex = 0

            ApplyControlStates()
            UpdateTotalFeeDisplay()
        End Sub

        ''' <summary>
        ''' Memproses eksekusi pendaftaran member baru, perpanjangan langganan, atau pembaruan profil beserta dialog pembayaran non-tunai.
        ''' </summary>
        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim ownerName As String = txtOwnerName.Text
            Dim selectedLevelId As Integer = If(cmbLevel.SelectedValue IsNot Nothing, Convert.ToInt32(cmbLevel.SelectedValue), 0)
            Dim plates As New List(Of String) From {txtPlate1.Text, txtPlate2.Text, txtPlate3.Text}
            Dim errorMsg As String = String.Empty

            ' Penanganan Mode Edit Profil Member (Tanpa Pembayaran)
            If _selectedMemberId > 0 AndAlso cmbTransactionType.SelectedIndex = 1 Then
                Dim isUpdated As Boolean = _controller.UpdateMemberProfile(_selectedMemberId, ownerName, selectedLevelId, plates, errorMsg)
                If isUpdated Then
                    MessageBox.Show($"Profil member '{ownerName}' berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadMemberData()
                    ClearForm()
                Else
                    MessageBox.Show(errorMsg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                Return
            End If

            ' Penanganan Pembayaran Pendaftaran Baru / Perpanjangan Langganan
            Dim paymentMethod As String = If(cmbPaymentMethod.SelectedItem IsNot Nothing, cmbPaymentMethod.SelectedItem.ToString(), "Tunai")
            Dim totalFee As Decimal = CalculateCurrentFee()
            Dim referenceNumber As String = String.Empty
            Dim transactionNote As String = If(_selectedMemberId > 0, $"Perpanjangan Member - {ownerName}", $"Pendaftaran Member - {ownerName}")

            ' Pemicu dialog modal pembayaran non-tunai (QRIS & Kartu Debit)
            If paymentMethod.Equals("QRIS", StringComparison.OrdinalIgnoreCase) Then
                Using qrisForm As New QrisPaymentForm(totalFee, transactionNote)
                    If qrisForm.ShowDialog(Me) <> DialogResult.OK Then
                        MessageBox.Show("Pembayaran QRIS dibatalkan. Transaksi belum diproses.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                    referenceNumber = qrisForm.GeneratedReferenceNumber
                End Using
            ElseIf paymentMethod.Equals("Debit", StringComparison.OrdinalIgnoreCase) Then
                Using debitForm As New DebitPaymentForm(totalFee, transactionNote)
                    If debitForm.ShowDialog(Me) <> DialogResult.OK Then
                        MessageBox.Show("Pembayaran Debit dibatalkan. Transaksi belum diproses.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                    referenceNumber = debitForm.CardOrReferenceNumber
                End Using
            End If

            ' Eksekusi simpan ke database
            Dim success As Boolean = False
            If _selectedMemberId > 0 Then
                success = _controller.RenewSubscriptionWithPayment(_selectedMemberId, paymentMethod, referenceNumber, totalFee, errorMsg)
            Else
                success = _controller.RegisterMemberWithPayment(ownerName, plates, selectedLevelId, paymentMethod, referenceNumber, totalFee, errorMsg)
            End If

            If success Then
                Dim successMsg As String = If(_selectedMemberId > 0,
                    $"Pembayaran {paymentMethod} Sukses! Langganan member '{ownerName}' berhasil diperpanjang +1 Bulan.",
                    $"Pembayaran {paymentMethod} Sukses! Member baru '{ownerName}' berhasil didaftarkan.")

                MessageBox.Show(successMsg, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadMemberData()
                ClearForm()
            Else
                MessageBox.Show(errorMsg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If _selectedMemberId = 0 Then
                MessageBox.Show("Pilih data member dari tabel yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim ask As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data member ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ask = DialogResult.Yes Then
                Dim errorMsg As String = String.Empty
                If _controller.DeleteMember(_selectedMemberId, errorMsg) Then
                    MessageBox.Show("Data member berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadMemberData()
                    ClearForm()
                Else
                    MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End Sub

        Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
            ClearForm()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Me.Close()
        End Sub

        Private Sub ClearForm()
            _selectedMemberId = 0
            txtOwnerName.Clear()
            txtPlate1.Clear()
            txtPlate2.Clear()
            txtPlate3.Clear()
            If cmbLevel.Items.Count > 0 Then cmbLevel.SelectedIndex = 0
            SetFormMode(isMemberSelected:=False)
        End Sub
    End Class
End Namespace