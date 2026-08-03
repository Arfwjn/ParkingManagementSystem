Namespace Models
    Public Class Member
        Public Property Id As Integer
        Public Property PlateNumber As String
        Public Property OwnerName As String
        Public Property MemberLevel As String ' Silver / Gold / Platinum

        ''' <summary>
        ''' Menghitung persentase diskon berdasarkan level member
        ''' </summary>
        Public Function GetDiscountPercentage() As Decimal
            Select Case MemberLevel?.ToUpper()
                Case "SILVER"
                    Return 0.1D ' 10%
                Case "GOLD"
                    Return 0.2D ' 20%
                Case "PLATINUM"
                    Return 0.3D ' 30%
                Case Else
                    Return 0D
            End Select
        End Function
    End Class
End Namespace