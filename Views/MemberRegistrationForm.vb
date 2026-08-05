Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Models

Namespace Views
    Public Class MemberRegistrationForm
        Private ReadOnly _controller As MemberController
        Private _selectedMemberId As Integer = 0

        Public Sub New()
            InitializeComponent()
            _controller = New MemberController()
        End Sub

        Private Sub MemberRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadLevelDropdown()
            LoadMemberData()
            ClearForm()
        End Sub

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

        Private Sub LoadMemberData()
            Try
                Dim dt As DataTable = _controller.GetAllMembersDataTable()
                dgvMembers.DataSource = Nothing
                dgvMembers.DataSource = dt

                ' Sembunyikan kolom internal level_id dari tampilan DataGridView
                If dgvMembers.Columns.Contains("level_id") Then
                    dgvMembers.Columns("level_id").Visible = False
                End If

                ' Format Tampilan Tanggal Daftar dan Masa Aktif
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
            ' Sesuaikan status kontrol pembayaran berdasarkan jenis transaksi yang dipilih
            Dim isEditOnly As Boolean = (_selectedMemberId > 0) AndAlso cmbTransactionType.SelectedIndex = 1
            cmbPaymentMethod.Enabled = Not isEditOnly
            UpdateTotalFeeDisplay()
        End Sub

        ''' <summary>
        ''' Kalkulasi total biaya dinamis berdasarkan level dan jenis transaksi
        ''' </summary>
        Private Function CalculateCurrentFee() As Decimal
            ' Jika dalam Mode Edit Profil (Tanpa Pembayaran), biaya = 0
            If _selectedMemberId > 0 AndAlso cmbTransactionType.SelectedIndex = 1 Then
                Return 0D
            End If

            ' Jika Pendaftaran Baru / Perpanjangan Langganan, ambil MonthlyFee dari level
            If cmbLevel IsNot Nothing AndAlso cmbLevel.SelectedItem IsNot Nothing Then
                Dim selectedLevel As MemberLevel = TryCast(cmbLevel.SelectedItem, MemberLevel)
                If selectedLevel IsNot Nothing Then
                    Return selectedLevel.MonthlyFee
                End If
            End If

            Return 50000D ' Default Fallback
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
        ''' Safe Auto-Populate event dari DataGridView ke Form Control
        ''' </summary>
        Private Sub dgvMembers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMembers.CellClick
            If e.RowIndex < 0 Then Return

            Try
                Dim selectedRow As DataGridViewRow = dgvMembers.Rows(e.RowIndex)

                ' 1. Ambil ID Member
                If dgvMembers.Columns.Contains("ID") AndAlso selectedRow.Cells("ID").Value IsNot DBNull.Value Then
                    _selectedMemberId = Convert.ToInt32(selectedRow.Cells("ID").Value)
                Else
                    Return
                End If

                ' 2. Ambil Nama Pemilik
                If dgvMembers.Columns.Contains("Nama Pemilik") AndAlso selectedRow.Cells("Nama Pemilik").Value IsNot DBNull.Value Then
                    txtOwnerName.Text = selectedRow.Cells("Nama Pemilik").Value.ToString()
                End If

                ' 3. Select Level via level_id
                If dgvMembers.Columns.Contains("level_id") AndAlso selectedRow.Cells("level_id").Value IsNot DBNull.Value Then
                    Dim levelId As Integer = Convert.ToInt32(selectedRow.Cells("level_id").Value)
                    cmbLevel.SelectedValue = levelId
                ElseIf dgvMembers.Columns.Contains("Level") AndAlso selectedRow.Cells("Level").Value IsNot DBNull.Value Then
                    Dim levelName As String = selectedRow.Cells("Level").Value.ToString()
                    cmbLevel.SelectedIndex = cmbLevel.FindStringExact(levelName)
                End If

                ' 4. Ambil dan Pemisahan Presisi Plat Nomor Berbasis Koma (",")
                If dgvMembers.Columns.Contains("Plat Nomor") AndAlso selectedRow.Cells("Plat Nomor").Value IsNot DBNull.Value Then
                    Dim fullPlates As String = selectedRow.Cells("Plat Nomor").Value.ToString()
                    Dim plateArray As String() = fullPlates.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)

                    txtPlate1.Text = If(plateArray.Length > 0, plateArray(0).Trim(), String.Empty)
                    txtPlate2.Text = If(plateArray.Length > 1, plateArray(1).Trim(), String.Empty)
                    txtPlate3.Text = If(plateArray.Length > 2, plateArray(2).Trim(), String.Empty)
                End If

                ' Set Form ke Mode Member Terdaftar (Membuka Pilihan Transaksi & Pembayaran)
                SetFormMode(isMemberSelected:=True)

            Catch ex As Exception
                MessageBox.Show("Gagal memuat detail baris yang dipilih: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        ''' <summary>
        ''' Pengaturan mode antarmuka antara Pendaftaran Baru dan Member Terdaftar
        ''' </summary>
        Private Sub SetFormMode(isMemberSelected As Boolean)
            cmbTransactionType.Items.Clear()

            If isMemberSelected Then
                btnSave.Text = "Proses Transaksi Member"
                btnSave.BackColor = System.Drawing.Color.FromArgb(16, 185, 129) ' Warna Hijau

                ' Memberikan Opsi Lengkap untuk Member Terdaftar
                cmbTransactionType.Items.Add("Perpanjangan Langganan Bulanan")
                cmbTransactionType.Items.Add("Perbarui Profil Member (Tanpa Biaya)")
                cmbTransactionType.SelectedIndex = 0 ' Default ke Perpanjangan

                cmbTransactionType.Enabled = True
                cmbPaymentMethod.Enabled = True
            Else
                btnSave.Text = "Daftarkan Member / Bayar"
                btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235) ' Warna Biru

                cmbTransactionType.Items.Add("Pendaftaran Baru (+1 Bulan)")
                cmbTransactionType.SelectedIndex = 0

                cmbTransactionType.Enabled = False
                cmbPaymentMethod.Enabled = True
            End If

            If cmbPaymentMethod.Items.Count > 0 Then cmbPaymentMethod.SelectedIndex = 0
            UpdateTotalFeeDisplay()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim ownerName As String = txtOwnerName.Text
            Dim selectedLevelId As Integer = If(cmbLevel.SelectedValue IsNot Nothing, Convert.ToInt32(cmbLevel.SelectedValue), 0)
            Dim plates As New List(Of String) From {txtPlate1.Text, txtPlate2.Text, txtPlate3.Text}
            Dim errorMsg As String = String.Empty

            ' =========================================================================
            ' SKENARIO 1: MEMBER TERDAFTAR - PERBARUI PROFIL MEMBER (TANPA PEMBAYARAN)
            ' =========================================================================
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

            ' =========================================================================
            ' SKENARIO 2 & 3: PEMBAYARAN (PENDAFTARAN BARU ATAU PERPANJANGAN LANGGANAN)
            ' =========================================================================
            Dim paymentMethod As String = If(cmbPaymentMethod.SelectedItem IsNot Nothing, cmbPaymentMethod.SelectedItem.ToString(), "Tunai")
            Dim totalFee As Decimal = CalculateCurrentFee()
            Dim referenceNumber As String = String.Empty
            Dim transactionNote As String = If(_selectedMemberId > 0, $"Perpanjangan Member - {ownerName}", $"Pendaftaran Member - {ownerName}")

            ' Eksekusi Modal Dialog Pembayaran Non-Tunai
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

            ' Proses Eksekusi Database
            Dim success As Boolean = False
            If _selectedMemberId > 0 Then
                ' Perpanjangan Masa Aktif Member (+1 Bulan)
                success = _controller.RenewSubscriptionWithPayment(_selectedMemberId, paymentMethod, referenceNumber, totalFee, errorMsg)
            Else
                ' Pendaftaran Member Baru
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