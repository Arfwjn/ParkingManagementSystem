Imports System

Namespace Models
    Public Class Parking
        Public Property Id As Integer
        Public Property PlateNumber As String
        Public Property VehicleType As String ' Mobil / Motor
        Public Property EntryTime As DateTime
        Public Property ExitTime As DateTime?
        Public Property Duration As Integer ' Jam (pembulatan ke atas)
        Public Property ParkingFee As Decimal
        Public Property AdditionalFee As Decimal
        Public Property OvernightFee As Decimal
        Public Property LostTicketFine As Decimal
        Public Property Discount As Decimal
        Public Property TotalPayment As Decimal
        Public Property PaymentMethod As String ' Tunai / QRIS / Debit
        Public Property PaymentStatus As String ' Belum Dibayar / Lunas
        Public Property Status As String ' IN / OUT / OVERNIGHT
        Public Property UserId As Integer?

        ''' <summary>
        ''' Menghitung durasi parkir dalam jam dengan pembulatan ke atas
        ''' </summary>
        Public Shared Function CalculateDurationInHours(entry As DateTime, [exit] As DateTime) As Integer
            Dim timeSpan As TimeSpan = [exit] - entry
            If timeSpan.TotalMinutes <= 0 Then Return 1

            ' Durasi kurang dari 1 jam tetap dihitung 1 jam (pembulatan ke atas)
            Return CInt(Math.Ceiling(timeSpan.TotalHours))
        End Function
    End Class
End Namespace