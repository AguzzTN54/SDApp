Public Class Alphabets
    Private Function setAlpha(ByVal x)
        Dim Alpha As New AlphaItem
        Me.Hide()
        Alpha.getAlpha.Text = x
        Alpha.Show()
        Return vbNull
    End Function

    Private Sub Alphabets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Alpha() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "u", "x", "y", "z"}
        Dim buttonIndex As Integer = 0
        Dim noOfButtonPerline As Integer = 7
        Dim y As Integer = 0

        For Each value As String In Alpha
            Dim btn As New Button With {.Height = 80, .Width = 100}
            If buttonIndex = noOfButtonPerline Then
                buttonIndex = 1
                y += btn.Height
            Else
                buttonIndex += 1
            End If
            With btn
                .FlatStyle = Windows.Forms.FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .FlatAppearance.MouseDownBackColor = Color.Transparent
                .FlatAppearance.MouseOverBackColor = Color.Transparent
                .FlatAppearance.BorderSize = 2
                .FlatAppearance.BorderColor = Color.DeepPink
                .BackColor = Color.White
                .Tag = value
                '.BackgroundImage = System.Drawing.Bitmap.FromFile("../../Resources/Assets/Classes/Kelas1/Alphabets/" & value & ".png")
                .BackgroundImage = My.Resources.ResourceManager.GetObject(value)
                .BackgroundImageLayout = ImageLayout.Zoom

            End With

            Panel1.Controls.Add(btn)
            btn.Location = New Point(60 * 1 + ((buttonIndex - 1) * btn.Width), y)
            AddHandler btn.Click, AddressOf abjad_Click
        Next
    End Sub

    Private Sub abjad_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        setAlpha(btn.Tag)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        MainKelas1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub
End Class