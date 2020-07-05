Imports MySql.Data.MySqlClient
Public Class Daftar

	Private Sub Daftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Try
			sql = "insert into daftar_murid(nama_siswa)values('" & TextBox1.Text & "')"
			conndb()
			cmd = New MySqlCommand(sql, conn)
			dr = cmd.ExecuteReader()
			MsgBox("Data Berhasil diinput")
		Catch ex As Exception
			MsgBox(ex.Message)
		Finally
			cmd.Dispose()
			conn.Close()
		End Try
		Me.Controls.Clear()
		InitializeComponent()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Form2.Show()
		Me.Close()
	End Sub
End Class