Public Class AlphaItem
    Private Sub formabjad_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

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
            .Text = getAlpha.Text
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
        Alpha = getAlpha.Text

        With showAbjad
            .BackgroundImage = My.Resources.ResourceManager.GetObject(Alpha)
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Alphabets.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Alpha As String
        Alpha = getAlpha.Text
        'My.Computer.Audio.Play("../../Resources/Assets/Classes/Kelas1/Speechs/" & Alpha & ".wav")
        My.Computer.Audio.Play(My.Resources.ResourceManager.GetObject(Alpha & "1"), AudioPlayMode.Background)
    End Sub

End Class