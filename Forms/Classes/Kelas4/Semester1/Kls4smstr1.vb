Public Class Kls4smstr1


    Private Sub Semester1Kelas4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kls4 As New Materikls4smstr1
        kls4.Button5.Tag = "calender"
        kls4.Button5.Text = "Calender"
        Me.Hide()
        kls4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kls4 As New Materikls4smstr1
        kls4.Button5.Tag = "greeting"
        kls4.Button5.Text = "Greeting"
        Me.Hide()
        kls4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim kls4 As New Materikls4smstr1
        kls4.Button5.Tag = "introducing"
        kls4.Button5.Text = "Introducing Oneself"
        Me.Hide()
        kls4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim kls4 As New Materikls4smstr1
        kls4.Button5.Tag = "food"
        kls4.Button5.Text = "Foood and Drink"
        Me.Hide()
        kls4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim kls4 As New Materikls4smstr1
        kls4.Button5.Tag = "things"
        kls4.Button5.Text = "Things in The House"
        Me.Hide()
        kls4.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        MainKelas4.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub
End Class