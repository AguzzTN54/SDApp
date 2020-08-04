Public Class Daftar

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Call KoneksiDB()
		cmd = New OleDb.OleDbCommand("select * from data_siswa where nama_siswa= '" & TextBox1.Text & "'", conn)
		dr = cmd.ExecuteReader
		dr.Read()
		If Not dr.HasRows Then
			Call KoneksiDB()
			cmd = New OleDb.OleDbCommand("select * from data_siswa order by id", conn)
			dr = cmd.ExecuteReader
			dr.Read()

			Call KoneksiDB()
			Dim simpan As String
			simpan = "insert into data_siswa (nama_siswa) values('" & TextBox1.Text & "')"
			cmd = New OleDb.OleDbCommand(simpan, conn)
			cmd.ExecuteNonQuery()
			MsgBox("Kamu Sudah Bisa Mulai Belajar Sekarang")
			TextBox1.Text = ""
		Else
			MsgBox("Namamu Sudah ada, Kamu Bisa lanjut Belajar")
			TextBox1.Text = ""
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin.Show()
		Me.Hide()
	End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Masuk.Show()
    End Sub

	Private Sub Daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class