Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Namespace Views
    ''' <summary>
    ''' Form QrisPaymentForm menampilkan dialog konfirmasi pembayaran transaksi metode QRIS.
    ''' Memuat berkas gambar QR Code asli dari database atau merender QR Code simulasi dinamis jika berkas fisik tidak ditemukan.
    ''' </summary>
    Public Class QrisPaymentForm
        ''' <summary>Nominal pembayaran transaksi.</summary>
        Public Property Amount As Decimal
        ''' <summary>Judul deskripsi transaksi.</summary>
        Public Property TransactionTitle As String
        ''' <summary>Nomor referensi unik transaksi QRIS yang dihasilkan secara otomatis.</summary>
        Public Property GeneratedReferenceNumber As String

        Private ReadOnly _settingController As PaymentSettingController

        ''' <summary>
        ''' Constructor dengan parameter nominal dan judul transaksi.
        ''' </summary>
        Public Sub New(amount As Decimal, transactionTitle As String)
            InitializeComponent()
            Me.Amount = amount
            Me.TransactionTitle = transactionTitle
            Me.GeneratedReferenceNumber = "QRIS-" & DateTime.Now.ToString("yyyyMMddHHmmss")

            _settingController = New PaymentSettingController()
        End Sub

        Private Sub QrisPaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblTransactionTitle.Text = TransactionTitle
            lblAmountValue.Text = $"Rp {Amount:N0}"

            ' Memastikan mode PictureBox menggunakan Zoom agar gambar QR tidak terpotong
            picQrisCode.SizeMode = PictureBoxSizeMode.Zoom

            ' Memuat data gambar dan Merchant QRIS dari database
            LoadQrisData()
        End Sub

        ''' <summary>
        ''' Memuat berkas gambar QRIS dari database. Jika tidak ada gambar kustom, memanggil fungsi generator simulasi QRIS.
        ''' </summary>
        Private Sub LoadQrisData()
            Dim qrLoadedFromFile As Boolean = False

            Try
                Dim setting As PaymentSetting = _settingController.LoadPaymentSetting()
                If setting IsNot Nothing Then
                    ' Menetapkan label nama Merchant QRIS jika kontrol tersedia
                    Dim lblMerchantArray = Controls.Find("lblMerchantName", True)
                    If lblMerchantArray.Length > 0 AndAlso TypeOf lblMerchantArray(0) Is Label Then
                        CType(lblMerchantArray(0), Label).Text = setting.QrisMerchantName
                    End If

                    ' Menetapkan label NMID jika kontrol tersedia
                    Dim lblNmidArray = Controls.Find("lblNmid", True)
                    If lblNmidArray.Length > 0 AndAlso TypeOf lblNmidArray(0) Is Label Then
                        Dim lblNmidControl As Label = CType(lblNmidArray(0), Label)
                        If Not String.IsNullOrWhiteSpace(setting.QrisNmid) Then
                            lblNmidControl.Text = "NMID: " & setting.QrisNmid
                            lblNmidControl.Visible = True
                        Else
                            lblNmidControl.Visible = False
                        End If
                    End If

                    ' Memeriksa dan memuat berkas gambar QRIS jika ada di direktori fisik
                    If Not String.IsNullOrWhiteSpace(setting.QrisImagePath) AndAlso File.Exists(setting.QrisImagePath) Then
                        Using fs As New FileStream(setting.QrisImagePath, FileMode.Open, FileAccess.Read)
                            picQrisCode.SizeMode = PictureBoxSizeMode.Zoom
                            picQrisCode.Image = Image.FromStream(fs)
                        End Using
                        qrLoadedFromFile = True
                    End If
                End If
            Catch ex As Exception
                ' Fallback jika terjadi kesalahan pembacaan berkas gambar
            End Try

            If Not qrLoadedFromFile Then
                RenderSimulatedQris()
            End If
        End Sub

        ''' <summary>
        ''' Generasi grafis bitmap QR Code simulasi secara prosedural berdasarkan seed nomor referensi transaksi.
        ''' </summary>
        Private Sub RenderSimulatedQris()
            Dim bmp As New Bitmap(200, 200)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
                Dim rnd As New Random(ReferenceNumberSeed(GeneratedReferenceNumber))

                Dim cellSize As Integer = 8
                For row As Integer = 0 To 24
                    For col As Integer = 0 To 24
                        Dim isFinder As Boolean = (row < 7 AndAlso col < 7) OrElse (row < 7 AndAlso col > 17) OrElse (row > 17 AndAlso col < 7)
                        If isFinder Then
                            If (row = 0 OrElse row = 6 OrElse col = 0 OrElse col = 6 OrElse (row >= 2 AndAlso row <= 4 AndAlso col >= 2 AndAlso col <= 4)) AndAlso
                               (row < 7 AndAlso col < 7) Then
                                g.FillRectangle(Brushes.Black, col * cellSize, row * cellSize, cellSize, cellSize)
                            ElseIf (row = 0 OrElse row = 6 OrElse col = 18 OrElse col = 24 OrElse (row >= 2 AndAlso row <= 4 AndAlso col >= 20 AndAlso col <= 22)) AndAlso
                                   (row < 7 AndAlso col > 17) Then
                                g.FillRectangle(Brushes.Black, col * cellSize, row * cellSize, cellSize, cellSize)
                            ElseIf (row = 18 OrElse row = 24 OrElse col = 0 OrElse col = 6 OrElse (row >= 20 AndAlso row <= 22 AndAlso col >= 2 AndAlso col <= 4)) AndAlso
                                   (row > 17 AndAlso col < 7) Then
                                g.FillRectangle(Brushes.Black, col * cellSize, row * cellSize, cellSize, cellSize)
                            End If
                        Else
                            If rnd.Next(0, 2) = 1 Then
                                g.FillRectangle(Brushes.Black, col * cellSize, row * cellSize, cellSize, cellSize)
                            End If
                        End If
                    Next
                Next
            End Using
            picQrisCode.SizeMode = PictureBoxSizeMode.Zoom
            picQrisCode.Image = bmp
        End Sub

        ''' <summary>
        ''' Mengkalkulasi nilai hash integer dari string nomor referensi untuk seed acak generator simulasi QR Code.
        ''' </summary>
        Private Function ReferenceNumberSeed(refNo As String) As Integer
            Dim hash As Integer = 0
            For Each c As Char In refNo
                hash += AscW(c)
            Next
            Return hash
        End Function

        Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Sub
    End Class
End Namespace