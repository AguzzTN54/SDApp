Public Class Kls3smstr2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kls3 As New Materikls3smstr2
        kls3.Button1.Tag = "our body"
        kls3.Button1.Text = "Our Body"
        Me.Hide()
        kls3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kls3 As New Materikls3smstr2
        kls3.Button1.Tag = "clothes"
        kls3.Button1.Text = "Clothes"
        Me.Hide()
        kls3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kls3 As New Materikls3smstr2
        kls3.Button1.Tag = "thing in the park"
        kls3.Button1.Text = "Thing in The Park"
        Me.Hide()
        kls3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        MainKelas3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub
End Class