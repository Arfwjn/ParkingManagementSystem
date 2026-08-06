Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports ParkingManagementSystem.Controllers
Imports ParkingManagementSystem.Models

Namespace Views
    ''' <summary>
    ''' Form MemberLevelManagementForm menyediakan antarmuka manajemen CRUD untuk mengelola data level keanggotaan member (Bronze, Silver, Gold, Platinum),
    ''' persentase diskon potongan parkir, dan iuran langganan bulanan.
    ''' </summary>
    Public Class MemberLevelManagementForm
        Private ReadOnly _controller As MemberLevelController
        Private _selectedLevelId As Integer = 0

        ''' <summary>
        ''' Constructor untuk menginisialisasi komponen Form Kelola Level Member.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            _controller = New MemberLevelController()
        End Sub

        Private Sub MemberLevelManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadLevelData()
            ClearForm()
        End Sub

        ''' <summary>
        ''' Memuat daftar seluruh level member dari database ke DataGridView dan mengatur format kolom.
        ''' </summary>
        Private Sub LoadLevelData()
            Try
                Dim list As List(Of MemberLevel) = _controller.GetAllLevels()
                dgvLevels.Columns.Clear()
                dgvLevels.AutoGenerateColumns = False

                dgvLevels.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "colNo", .HeaderText = "No"})
                dgvLevels.Columns("colNo").Width = 50
                dgvLevels.Columns("colNo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgvLevels.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Id", .HeaderText = "Id", .DataPropertyName = "Id", .Visible = False})
                dgvLevels.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "LevelName", .HeaderText = "Nama Level", .DataPropertyName = "LevelName"})
                dgvLevels.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "DiscountPercentage", .HeaderText = "Diskon (%)", .DataPropertyName = "DiscountPercentage"})
                dgvLevels.Columns("DiscountPercentage").DefaultCellStyle.Format = "N2"
                dgvLevels.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "MonthlyFee", .HeaderText = "Biaya Bulanan", .DataPropertyName = "MonthlyFee"})
                dgvLevels.Columns("MonthlyFee").DefaultCellStyle.Format = "Rp #,##0"
                dgvLevels.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Description", .HeaderText = "Keterangan", .DataPropertyName = "Description"})

                dgvLevels.DataSource = list

                For i As Integer = 0 To dgvLevels.Rows.Count - 1
                    dgvLevels.Rows(i).Cells("colNo").Value = i + 1
                Next
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat memuat data level member: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub dgvLevels_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLevels.CellClick
            If e.RowIndex >= 0 Then
                Try
                    Dim row As DataGridViewRow = dgvLevels.Rows(e.RowIndex)

                    If row.Cells("Id").Value IsNot DBNull.Value Then
                        _selectedLevelId = Convert.ToInt32(row.Cells("Id").Value)
                    End If

                    txtLevelName.Text = If(row.Cells("LevelName").Value IsNot DBNull.Value, row.Cells("LevelName").Value.ToString(), String.Empty)

                    If dgvLevels.Columns("DiscountPercentage") IsNot Nothing AndAlso row.Cells("DiscountPercentage").Value IsNot DBNull.Value Then
                        numDiscount.Value = Convert.ToDecimal(row.Cells("DiscountPercentage").Value)
                    End If

                    If dgvLevels.Columns("MonthlyFee") IsNot Nothing AndAlso row.Cells("MonthlyFee").Value IsNot DBNull.Value Then
                        numMonthlyFee.Value = Convert.ToDecimal(row.Cells("MonthlyFee").Value)
                    End If

                    txtDescription.Text = If(row.Cells("Description").Value IsNot DBNull.Value, row.Cells("Description").Value.ToString(), String.Empty)
                    btnSave.Text = "PERBARUI"

                Catch ex As Exception
                    MessageBox.Show("Gagal mengambil data baris: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim errorMsg As String = String.Empty
            Dim success As Boolean = _controller.SaveLevel(_selectedLevelId, txtLevelName.Text, numDiscount.Value, numMonthlyFee.Value, txtDescription.Text, errorMsg)

            If success Then
                MessageBox.Show("Data level member berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadLevelData()
                ClearForm()
            Else
                MessageBox.Show(errorMsg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            If _selectedLevelId = 0 Then
                MessageBox.Show("Pilih level member yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus level member ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim errorMsg As String = String.Empty
                Dim success As Boolean = _controller.DeleteLevel(_selectedLevelId, errorMsg)

                If success Then
                    MessageBox.Show("Level member berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadLevelData()
                    ClearForm()
                Else
                    MessageBox.Show(errorMsg, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
            _selectedLevelId = 0
            txtLevelName.Clear()
            numDiscount.Value = 0
            If numMonthlyFee IsNot Nothing Then numMonthlyFee.Value = 0
            txtDescription.Clear()
            btnSave.Text = "SIMPAN"
        End Sub
    End Class
End Namespace