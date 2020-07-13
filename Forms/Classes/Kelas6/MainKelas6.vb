Public Class MainKelas6
    Private Sub MainKelas6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kelas6 As New MateriKelas6
        kelas6.Button5.Tag = "direction"
        kelas6.Button5.Text = "Direction and Location"
        Me.Hide()
        kelas6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kelas6 As New MateriKelas6
        kelas6.Button5.Tag = "describing"
        kelas6.Button5.Text = "Describing People and Object"
        Me.Hide()
        kelas6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kelas6 As New MateriKelas6
        kelas6.Button5.Tag = "ownership"
        kelas6.Button5.Text = "Ownership"
        Me.Hide()
        kelas6.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim kelas6 As New MateriKelas6
        kelas6.Button5.Tag = "holiday"
        kelas6.Button5.Text = "Holiday"
        Me.Hide()
        kelas6.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim kelas6 As New MateriKelas6
        kelas6.Button5.Tag = "folktales"
        kelas6.Button5.Text = "Folktales"
        Me.Hide()
        kelas6.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim kelas6 As New MateriKelas6
        kelas6.Button5.Tag = "government"
        kelas6.Button5.Text = "Government"
        Me.Hide()
        kelas6.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub
End Class