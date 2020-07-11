Public Class Admin
    Sub TampilkanData()
        Call KoneksiDB()
        da = New OleDb.OleDbDataAdapter("select * from data_siswa", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True

    End Sub

    Sub Kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Call TampilkanData()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Call KoneksiDB()
        cmd = New OleDb.OleDbCommand("update data_siswa set nama_siswa='" & TextBox2.Text & "' where id='" & TextBox1.Text & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("Update data siswa berhasil")
        Call TampilkanData()
        Call Kosong()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Tidak ada data yang akan dihapus")
            Exit Sub
        Else
            Dim id As String = TextBox1.Text
            Call KoneksiDB()
            cmd = New OleDb.OleDbCommand("delete from data_siswa where id='" & id & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data siswa berhasil dihapus")
            Call TampilkanData()
            Call Kosong()
        End If


    End Sub
End Class