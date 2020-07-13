Public Class Direction1
    Function ambilMateri(ByVal id)
        Call KoneksiDB()
        cmd = New OleDb.OleDbCommand("select * from data_materi where id=" & id & "", conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows() Then
            Dim materi = dr.GetValue(3)
            Dim nextID = dr.GetValue(4)
            Dim prevID = dr.GetValue(5)

            WebView1.NavigateToString(bacaMateri(materi))

            If prevID Then
                BackBtn.Visible = True
                BackBtn.Tag = prevID
            Else
                BackBtn.Visible = False
            End If

            If nextID Then
                NextBtn.Visible = True
                NextBtn.Tag = nextID
            Else
                NextBtn.Visible = False
            End If

        Else
            MsgBox("Belum Ada materi")
        End If

        Return vbNull
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Direction1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        cmd = New OleDb.OleDbCommand("Select min(id) from data_materi where grade=6 and sub_bab='Direction and Location'", conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows() Then
            Dim id = dr.GetValue(0)
            ambilMateri(id)
        End If

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
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        ambilMateri(NextBtn.Tag)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        ambilMateri(BackBtn.Tag)
    End Sub
End Class