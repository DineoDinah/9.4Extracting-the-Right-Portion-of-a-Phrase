Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
		Dim MyText As String
		MyText = "Visual Basic"
		MsgBox(Microsoft.VisualBasic.Right(MyText, 8))

	End Sub
End Class
