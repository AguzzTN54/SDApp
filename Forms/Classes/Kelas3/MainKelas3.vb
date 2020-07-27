Public Class MainKelas3
    Private Sub MainKelas3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Button1
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With
        With Button2
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Kls3smstr1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Kls3smstr2.Show()
    End Sub

End Class