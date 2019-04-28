Imports NXOpen
Imports Test_Project.Module1
Imports Test_Project


Public Class UI_Input

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        blnUnload = True
        GetUnloadOption("")
    End Sub

    Public Function GetUnloadOption(ByVal arg As String) As Integer
        If (blnUnload = True) Then
            GetUnloadOption = NXOpen.Session.LibraryUnloadOption.Immediately
        End If
    End Function

    Private Sub Ok_btn_Click(sender As Object, e As EventArgs) Handles Ok_btn.Click
        Dim execution As Exc_Frm = New Exc_Frm()
        execution.Show()
    End Sub
End Class