Public Class Alphabets
    Private Function setAlpha(ByVal x)
        Dim Alpha As New AlphaItem
        Me.Hide()
        Alpha.getAlpha.Text = x
        Alpha.Show()
        Return vbNull
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        setAlpha("a")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        setAlpha("b")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        setAlpha("c")
    End Sub

End Class