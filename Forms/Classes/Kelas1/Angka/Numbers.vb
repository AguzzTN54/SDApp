Public Class Numbers
    Private Function setNumber(ByVal x)
        Dim Number As New NumberItem
        Me.Hide()
        Number.getNumber.Text = x
        Number.Show()
        Return vbNull
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        setNumber("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.DocumentText = "<h1>Hallo Coeq</h1>"
    End Sub
End Class