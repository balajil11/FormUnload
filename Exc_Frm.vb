Imports Test_Project.Module1

Public Class Exc_Frm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        blnUnload = True
        GetUnloadOption("")
    End Sub

    Public Function GetUnloadOption(ByVal arg As String) As Integer
        If (blnUnload = True) Then
            GetUnloadOption = NXOpen.Session.LibraryUnloadOption.Immediately
        End If
    End Function

End Class