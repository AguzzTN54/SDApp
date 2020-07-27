Public Class NumberItem
    Private Sub NumberItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            .Text = getNumber.Text
        End With

        With Button4
            .Parent = PictureBox1
            .FlatStyle = Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackColor = Color.Transparent
        End With

        Dim Alpha As String
        Alpha = getNumber.Text

        With showAbjad
            '.BackgroundImage = Image.FromFile("../../Resources/Assets/Classes/Kelas1/Numbers/" & Alpha & ".png")
            .BackgroundImage = My.Resources.ResourceManager.GetObject("_" & Alpha)
        End With

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Numbers.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Alpha As String
        Alpha = getNumber.Text
        'My.Computer.Audio.Play("../../Resources/Assets/Classes/Kelas1/Speechs/" & Alpha & ".wav")
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject("_" & Alpha & "1"), AudioPlayMode.Background)
    End Sub
End Class