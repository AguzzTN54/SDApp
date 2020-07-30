Public Class Colors
    Private Function setColor(ByVal x)
        Dim Color As New ColorItem
        Me.Hide()
        Color.getColor.Text = x
        Color.Show()
        Return vbNull
    End Function

    Private Sub Colors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colors() As String = {"black", "blue", "brown", "green", "red", "white", "orange", "yellow", "purple"}
        Dim buttonIndex As Integer = 0
        Dim noOfButtonPerline As Integer = 5
        Dim y As Integer = 0

        For Each value As String In colors
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
                '.FlatAppearance.MouseDownBackColor = Color.Transparent
                '.FlatAppearance.MouseOverBackColor = Color.Transparent
                .FlatAppearance.BorderSize = 2
                .FlatAppearance.BorderColor = Color.DeepPink
                .BackColor = Color.FromName(value)
                .Tag = value
                .BackgroundImageLayout = ImageLayout.Zoom
            End With

            Panel1.Controls.Add(btn)
            btn.Location = New Point(60 * 1 + ((buttonIndex - 1) * btn.Width), y)
            AddHandler btn.Click, AddressOf warna_Click
        Next
    End Sub

    Private Sub warna_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        setColor(btn.Tag)
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