Namespace Models
    Public Class MemberLevel
        Public Property Id As Integer
        Public Property LevelName As String
        Public Property DiscountPercentage As Decimal
        Public Property MonthlyFee As Decimal
        Public Property Description As String
        Public Property CreatedAt As DateTime
        Public Property UpdatedAt As DateTime

        Public Sub New()
        End Sub

        Public Sub New(id As Integer, levelName As String, discountPercentage As Decimal, description As String)
            Me.Id = id
            Me.LevelName = levelName
            Me.DiscountPercentage = discountPercentage
            Me.Description = description
        End Sub
    End Class
End Namespace