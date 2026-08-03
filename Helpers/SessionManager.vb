Imports ParkingManagementSystem.Models

Namespace Helpers
    Public Class SessionManager
        ' Shared Property menyimpan instance User yang sedang aktif
        Public Shared Property CurrentUser As User

        Public Shared Sub ClearSession()
            CurrentUser = Nothing
        End Sub

        Public Shared Function IsLoggedIn() As Boolean
            Return CurrentUser IsNot Nothing
        End Function
    End Class
End Namespace