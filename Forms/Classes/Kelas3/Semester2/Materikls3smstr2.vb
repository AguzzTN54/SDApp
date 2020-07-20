Public Class Materikls3smstr2
    Function ambilMateri(ByVal id)
        Call KoneksiDB()
        cmd = New OleDb.OleDbCommand("select * from data_materi where id=" & id & "", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        Button1.Visible = True
        Button4.Visible = True
        Button5.Visible = True

        If dr.HasRows() Then
            Dim materi = dr.GetValue(3)
            Dim lanjut = dr.GetValue(4)
            Dim prev = dr.GetValue(5)

            If prev Then
                Button2.Visible = True
                Button2.Tag = prev
            Else
                Button2.Visible = False
            End If

            If lanjut Then
                Button3.Visible = True
                Button3.Tag = lanjut
            Else
                Button3.Visible = False
            End If

            WebView1.NavigateToString(bacaMateri(materi))

        Else
            MsgBox("Belum Ada materi")
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ambilMateri(Button2.Tag)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ambilMateri(Button3.Tag)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Kls3smstr2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        PilihKelas.Show()
    End Sub

    Private Sub Materikls3smstr2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KoneksiDB()
        cmd = New OleDb.OleDbCommand("Select min(id) from data_materi where grade=3 and sub_bab='" & Button1.Tag & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows() Then
            Dim id = dr.GetValue(0)
            ambilMateri(id)
        End If
    End Sub
End Class