Public Class PilihKelas
    Private Sub PilihKelas_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

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

        With Button3
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With

        With Button4
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With

        With Button5
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With

        With Button6
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With

        With Button7
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With

        With Button8
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With

        With nama
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MainKelas1.nama.Text = nama.Text
        Me.Hide()
        MainKelas1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainKelas2.nama.Text = nama.Text
        Me.Hide()
        MainKelas2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        MainKelas4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        MainKelas5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MainKelas3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Kelas5Semester1.Show()
    End Sub
End Class