Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
    End Sub

<<<<<<< HEAD
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

=======
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Daftar.Show()
        Me.Close()
>>>>>>> db07646eba4f9f1c3f2f41349fbf7aa621500ca0
    End Sub
End Class
