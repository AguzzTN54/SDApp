Public Class Kls3smstr1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim kls3 As New Materikls3smstr1
        kls3.Button1.Tag = "alphabet"
        kls3.Button1.Text = "Alphabet"
        Me.Hide()
        kls3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kls3 As New Materikls3smstr1
        kls3.Button1.Tag = "vegetables"
        kls3.Button1.Text = "Vegetables"
        Me.Hide()
        kls3.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim kls3 As New Materikls3smstr1
        kls3.Button1.Tag = "animals"
        kls3.Button1.Text = "Animals"
        Me.Hide()
        kls3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim kls3 As New Materikls3smstr1
        kls3.Button1.Tag = "things in the house"
        kls3.Button1.Text = "Things in The House"
        Me.Hide()
        kls3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MainKelas3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub

    Private Sub Kls3smstr1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Button2
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
    End Sub
End Class