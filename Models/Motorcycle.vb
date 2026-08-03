Imports System

Namespace Models
    ''' <summary>
    ''' Kelas Motor turunan dari Vehicle (Inheritance)
    ''' </summary>
    Public Class Motorcycle
        Inherits Vehicle

        Public Sub New(plateNumber As String)
            MyBase.New(plateNumber, "Motor")
        End Sub

        ' Polymorphism: Implementasi perhitungan tarif khusus Motor
        Public Overrides Function CalculateFee(durationInHours As Integer) As Decimal
            If durationInHours <= 0 Then Return 0

            Dim fee As Decimal = 0

            ' Tarif Motor: Jam 1 = 3.000, Jam 2 = +2.000, Jam 3 = +2.000, Jam >3 = +1.000/jam
            If durationInHours = 1 Then
                fee = 3000
            ElseIf durationInHours = 2 Then
                fee = 3000 + 2000 ' 5.000
            ElseIf durationInHours = 3 Then
                fee = 3000 + 2000 + 2000 ' 7.000
            Else
                fee = 7000 + ((durationInHours - 3) * 1000)
            End If

            ' Aturan Tarif Maksimum Harian
            Dim maxFee As Decimal = GetMaxDailyFee()
            If fee > maxFee Then
                fee = maxFee
            End If

            Return fee
        End Function

        Public Overrides Function GetLostTicketFine() As Decimal
            Return 25000 ' Denda karcis hilang motor
        End Function

        Public Overrides Function GetOvernightFee(days As Integer) As Decimal
            Return days * 15000 ' Biaya menginap motor Rp15.000/hari
        End Function

        Public Overrides Function GetMaxDailyFee() As Decimal
            Return 25000 ' Tarif maksimum harian motor
        End Function
    End Class
End Namespace