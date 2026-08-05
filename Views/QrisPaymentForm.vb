Imports System
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Namespace Views
    Public Class QrisPaymentForm
        Public Property Amount As Decimal
        Public Property TransactionTitle As String
        Public Property GeneratedReferenceNumber As String

        Private ReadOnly _settingController As PaymentSettingController

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

            ' PERBAIKAN: Kunci PictureBox agar selalu menampilkan seluruh gambar secara utuh (Zoom)
            picQrisCode.SizeMode = PictureBoxSizeMode.Zoom

            ' Muat data QRIS dari basis data
            LoadQrisData()
        End Sub

        Private Sub LoadQrisData()
            Dim qrLoadedFromFile As Boolean = False

            Try
                Dim setting As PaymentSetting = _settingController.LoadPaymentSetting()
                If setting IsNot Nothing Then
                    ' Set Label Nama Merchant jika kontrol tersedia
                    Dim lblMerchantArray = Controls.Find("lblMerchantName", True)
                    If lblMerchantArray.Length > 0 AndAlso TypeOf lblMerchantArray(0) Is Label Then
                        CType(lblMerchantArray(0), Label).Text = setting.QrisMerchantName
                    End If

                    ' Set Label NMID jika kontrol tersedia
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

                    ' Cek dan muat gambar QRIS kustom jika berkas fisik tersedia
                    If Not String.IsNullOrWhiteSpace(setting.QrisImagePath) AndAlso File.Exists(setting.QrisImagePath) Then
                        Using fs As New FileStream(setting.QrisImagePath, FileMode.Open, FileAccess.Read)
                            ' Pastikan mode Zoom aktif sebelum assign gambar
                            picQrisCode.SizeMode = PictureBoxSizeMode.Zoom
                            picQrisCode.Image = Image.FromStream(fs)
                        End Using
                        qrLoadedFromFile = True
                    End If
                End If
            Catch ex As Exception
                ' Fallback jika terjadi kegagalan pembacaan
            End Try

            If Not qrLoadedFromFile Then
                RenderSimulatedQris()
            End If
        End Sub

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