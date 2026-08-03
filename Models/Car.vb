Imports System

Namespace Models
    ''' <summary>
    ''' Kelas Mobil turunan dari Vehicle (Inheritance)
    ''' </summary>
    Public Class Car
        Inherits Vehicle

        Public Sub New(plateNumber As String)
            MyBase.New(plateNumber, "Mobil")
        End Sub

        ' Polymorphism: Implementasi perhitungan tarif khusus Mobil
        Public Overrides Function CalculateFee(durationInHours As Integer) As Decimal
            If durationInHours <= 0 Then Return 0

            Dim fee As Decimal = 0

            ' Tarif Mobil: Jam 1 = 5.000, Jam 2 = +3.000, Jam 3 = +3.000, Jam >3 = +2.000/jam
            If durationInHours = 1 Then
                fee = 5000
            ElseIf durationInHours = 2 Then
                fee = 5000 + 3000 ' 8.000
            ElseIf durationInHours = 3 Then
                fee = 5000 + 3000 + 3000 ' 11.000
            Else
                fee = 11000 + ((durationInHours - 3) * 2000)
            End If

            ' Aturan Tarif Maksimum Harian
            Dim maxFee As Decimal = GetMaxDailyFee()
            If fee > maxFee Then
                fee = maxFee
            End If

            Return fee
        End Function

        Public Overrides Function GetLostTicketFine() As Decimal
            Return 50000 ' Denda karcis hilang mobil
        End Function

        Public Overrides Function GetOvernightFee(days As Integer) As Decimal
            Return days * 25000 ' Biaya menginap mobil Rp25.000/hari
        End Function

        Public Overrides Function GetMaxDailyFee() As Decimal
            Return 50000 ' Tarif maksimum harian mobil
        End Function
    End Class
End Namespace