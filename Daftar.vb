Public Class Daftar

	Private Sub Daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Call KoneksiDB()
		cmd = New OleDb.OleDbCommand("select * from data_siswa where nama_siswa= '" & TextBox1.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		If Not dr.HasRows Then
			Call KoneksiDB()
			Dim simpan As String
			simpan = "insert into data_siswa (nama_siswa)values('" & TextBox1.Text & "')"
			cmd = New OleDb.OleDbCommand(simpan, conn)
			cmd.ExecuteNonQuery()
			MsgBox("Input data siswa berhasil")
		Else
			MsgBox("Siswa tersebut sudah ada")
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Form2.Show()
		Me.Hide()
	End Sub
End Class