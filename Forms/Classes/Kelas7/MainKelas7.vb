Public Class MainKelas7
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
                Button2.Visible = True
                Button2.Tag = prevID
            Else
                Button2.Visible = False
            End If

            If nextID Then
                Button1.Visible = True
                Button1.Tag = nextID
            Else
                Button1.Visible = False
            End If

        Else
            MsgBox("Belum Ada materi")
        End If

        Return vbNull
    End Function

    Private Sub MainKelas7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        cmd = New OleDb.OleDbCommand("Select min(id) from data_materi where grade=7 and sub_bab='" & Button3.Tag & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows() Then
            Dim id = dr.GetValue(0)
            ambilMateri(id)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ambilMateri(Button1.Tag)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ambilMateri(Button2.Tag)
    End Sub
End Class