Public Class MainKelas2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim materiTime As New MateriKelas2
        materiTime.Button3.Tag = "times"
        materiTime.Button3.Text = "TIMES"
        Me.Hide()
        materiTime.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim materiFoods As New MateriKelas2
        materiFoods.Button3.Tag = "foods"
        materiFoods.Button3.Text = "FOODS & DRINKS"
        Me.Hide()
        materiFoods.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim materiHobby As New MateriKelas2
        materiHobby.Button3.Tag = "hobby"
        materiHobby.Button3.Text = "HOBBY"
        Me.Hide()
        materiHobby.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub
End Class