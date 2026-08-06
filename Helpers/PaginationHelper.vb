Imports System
Imports System.Data

Namespace Helpers
    ''' <summary>
    ''' Helper PaginationHelper mengolah pemotongan data (Pagination) maksimal 20 baris per halaman
    ''' serta menambahkan kolom nomor urut berurutan ("No") secara otomatis di program tanpa mengubah database.
    ''' </summary>
    Public Class PaginationHelper
        Public Const DEFAULT_PAGE_SIZE As Integer = 20

        ''' <summary>
        ''' Memotong DataTable asli sesuai nomor halaman dan ukuran halaman, serta menyisipkan kolom 'No' di urutan paling awal.
        ''' </summary>
        Public Shared Function GetPagedTable(sourceTable As DataTable, currentPage As Integer, Optional pageSize As Integer = DEFAULT_PAGE_SIZE) As DataTable
            If sourceTable Is Nothing Then Return New DataTable()

            Dim pagedTable As DataTable = sourceTable.Clone()

            ' Menyisipkan kolom 'No' di posisi indeks 0 jika belum ada
            If Not pagedTable.Columns.Contains("No") Then
                Dim noCol As New DataColumn("No", GetType(Integer))
                pagedTable.Columns.Add(noCol)
                noCol.SetOrdinal(0)
            End If

            Dim totalRows As Integer = sourceTable.Rows.Count
            If totalRows = 0 Then Return pagedTable

            Dim startIndex As Integer = (currentPage - 1) * pageSize
            If startIndex >= totalRows Then startIndex = 0

            Dim endIndex As Integer = Math.Min(startIndex + pageSize - 1, totalRows - 1)

            For i As Integer = startIndex To endIndex
                Dim sourceRow As DataRow = sourceTable.Rows(i)
                Dim newRow As DataRow = pagedTable.NewRow()

                ' Menyalin seluruh kolom asli
                For Each col As DataColumn In sourceTable.Columns
                    If pagedTable.Columns.Contains(col.ColumnName) Then
                        newRow(col.ColumnName) = sourceRow(col.ColumnName)
                    End If
                Next

                ' Mengisi nomor urut kontinu: 1, 2, 3, dst. (Halaman 2: 21, 22, 23, dst.)
                newRow("No") = i + 1
                pagedTable.Rows.Add(newRow)
            Next

            Return pagedTable
        End Function

        ''' <summary>
        ''' Menghitung total halaman berdasarkan jumlah total baris dan ukuran halaman.
        ''' </summary>
        Public Shared Function GetTotalPages(totalRows As Integer, Optional pageSize As Integer = DEFAULT_PAGE_SIZE) As Integer
            If totalRows <= 0 Then Return 1
            Return CInt(Math.Ceiling(CDbl(totalRows) / CDbl(pageSize)))
        End Function
    End Class
End Namespace
