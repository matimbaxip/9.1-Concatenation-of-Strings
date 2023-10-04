Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1, text2, text3, text4 As String

        text1 = "VISUAL"
        text2 = "BASIC"
        text3 = "2022"

        text4 = text1 + "" + text2 + "" + text3

        MsgBox(text4)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
