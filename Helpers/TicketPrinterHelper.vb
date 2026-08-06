Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports ParkingManagementSystem.Models

Namespace Helpers
    Public Class TicketPrinterHelper
        Private Shared _parkingData As Parking
        Private Shared _isReceipt As Boolean ' False: Karcis Masuk, True: Struk Pembayaran

        ''' <summary>
        ''' Mencetak Karcis Parkir Kendaraan Masuk
        ''' </summary>
        Public Shared Sub PrintEntryTicket(p As Parking)
            _parkingData = p
            _isReceipt = False
            ExecutePrint()
        End Sub

        ''' <summary>
        ''' Mencetak Struk Pembayaran Kendaraan Keluar
        ''' </summary>

        Public Shared Sub PrintExitReceipt(p As Parking)
            _parkingData = p
            _isReceipt = True
            ExecutePrint()
        End Sub

        Private Shared Sub ExecutePrint()
            Try
                Dim pd As New PrintDocument()
                AddHandler pd.PrintPage, AddressOf PrintPageHandler

                ' Menggunakan PrintPreviewDialog agar aman digunakan tanpa fisik printer thermal
                Dim previewDlg As New PrintPreviewDialog With {
                    .Document = pd,
                    .Width = 400,
                    .Height = 600,
                    .StartPosition = FormStartPosition.CenterScreen
                }
                previewDlg.ShowDialog()
            Catch ex As Exception
                MessageBox.Show($"Gagal mencetak dokumen: {ex.Message}", "Printer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Shared Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
            Dim g As Graphics = e.Graphics
            Dim fontTitle As New Font("Courier New", 10, FontStyle.Bold)
            Dim fontBody As New Font("Courier New", 8, FontStyle.Regular)
            Dim fontBodyBold As New Font("Courier New", 8, FontStyle.Bold)
            Dim fontHeader As New Font("Courier New", 12, FontStyle.Bold)

            Dim yPos As Single = 10
            Dim leftMargin As Single = 10
            Dim lineHeight As Single = 15

            ' Header Struk/Karcis
            g.DrawString("==================================", fontTitle, Brushes.Black, leftMargin, yPos)
            yPos += lineHeight
            g.DrawString("        PARKIRMAS        ", fontHeader, Brushes.Black, leftMargin, yPos)
            yPos += lineHeight
            g.DrawString("       SISTEM PARKIR MANDIRI      ", fontBodyBold, Brushes.Black, leftMargin, yPos)
            yPos += lineHeight
            g.DrawString("==================================", fontTitle, Brushes.Black, leftMargin, yPos)
            yPos += lineHeight + 5

            If Not _isReceipt Then
                ' METODE 1: CETAK KARCIS MASUK
                g.DrawString($"ID TIKET : TRX-{_parkingData.Id:D6}", fontBodyBold, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"NO POLISI: {_parkingData.PlateNumber}", fontTitle, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"JENIS    : {_parkingData.VehicleType}", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"MASUK    : {_parkingData.EntryTime:dd/MM/yyyy HH:mm:ss}", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight + 10

                g.DrawString("----------------------------------", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString(" Simpan karcis ini dengan baik.   ", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString(" Denda Rp 20.000 - Rp 50.000 jika ", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString(" karcis hilang.                   ", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
            Else
                ' METODE 2: CETAK STRUK PEMBAYARAN KELUAR
                g.DrawString($"ID STRUK : TRX-{_parkingData.Id:D6}", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"NO POLISI: {_parkingData.PlateNumber}", fontTitle, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"JENIS    : {_parkingData.VehicleType}", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"MASUK    : {_parkingData.EntryTime:dd/MM/yy HH:mm}", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"KELUAR   : {_parkingData.ExitTime:dd/MM/yy HH:mm}", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"DURASI   : {_parkingData.Duration} Jam", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString("----------------------------------", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight

                g.DrawString($"Tarif Dasar : Rp {_parkingData.ParkingFee,10:N0}", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                If _parkingData.OvernightFee > 0 Then
                    g.DrawString($"Menginap    : Rp {_parkingData.OvernightFee,10:N0}", fontBody, Brushes.Black, leftMargin, yPos)
                    yPos += lineHeight
                End If
                If _parkingData.LostTicketFine > 0 Then
                    g.DrawString($"Denda Karcis: Rp {_parkingData.LostTicketFine,10:N0}", fontBody, Brushes.Black, leftMargin, yPos)
                    yPos += lineHeight
                End If
                If _parkingData.Discount > 0 Then
                    g.DrawString($"Diskon      :-Rp {_parkingData.Discount,10:N0}", fontBody, Brushes.Black, leftMargin, yPos)
                    yPos += lineHeight
                End If
                g.DrawString("----------------------------------", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight

                g.DrawString($"TOTAL BAYAR : Rp {_parkingData.TotalPayment,10:N0}", fontTitle, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
                g.DrawString($"METODE         : {_parkingData.PaymentMethod}", fontBodyBold, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight + 10

                g.DrawString("  Terima Kasih Atas Kunjungan Anda  ", fontBody, Brushes.Black, leftMargin, yPos)
                yPos += lineHeight
            End If

            g.DrawString("==================================", fontTitle, Brushes.Black, leftMargin, yPos)
        End Sub
    End Class
End Namespace