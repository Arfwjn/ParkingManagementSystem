Public Class PaymentSetting
    Public Property Id As Integer

    ' Atribut QRIS
    Public Property QrisMerchantName As String
    Public Property QrisNmid As String
    Public Property QrisImagePath As String

    ' Atribut Debit / Bank
    Public Property BankName As String
    Public Property AccountNumber As String
    Public Property AccountHolder As String

    Public Property CreatedAt As DateTime
    Public Property UpdatedAt As DateTime

    Sub New()
        ' Default constructor
    End Sub

    Sub New(id As Integer, qrisMerchantName As String, qrisNmid As String, qrisImagePath As String,
            bankName As String, accountNumber As String, accountHolder As String)
        Me.Id = id
        Me.QrisMerchantName = qrisMerchantName
        Me.QrisNmid = qrisNmid
        Me.QrisImagePath = qrisImagePath
        Me.BankName = bankName
        Me.AccountNumber = accountNumber
        Me.AccountHolder = accountHolder
    End Sub
End Class