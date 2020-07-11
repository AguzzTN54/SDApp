Public Class Numbers
    Private Function setNumber(ByVal x)
        Dim Number As New NumberItem
        Me.Hide()
        Number.getNumber.Text = x
        Number.Show()
        Return vbNull
    End Function

    Private Sub Numbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mathNumbers() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"}
        Dim buttonIndex As Integer = 0
        Dim noOfButtonPerline As Integer = 5
        Dim y As Integer = 0

        For Each value As String In mathNumbers
            Dim btn As New Button With {.Height = 150, .Width = 150}
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
                .BackgroundImage = System.Drawing.Bitmap.FromFile("../../Resources/Assets/Classes/Kelas1/Numbers/" & value & ".png")
                .BackgroundImageLayout = ImageLayout.Zoom
            End With

            Panel1.Controls.Add(btn)
            btn.Location = New Point(60 * 1 + ((buttonIndex - 1) * btn.Width), y)
            AddHandler btn.Click, AddressOf angka_Click
        Next
    End Sub

    Private Sub angka_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        setNumber(btn.Tag)
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