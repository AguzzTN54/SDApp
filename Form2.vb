Imports MySql.Data.MySqlClient
Public Class Form2
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		showusers()
	End Sub

	Sub showusers()
		conndb()
		cmd = New MySqlCommand("select * from daftar_murid", conn)
		da = New MySqlDataAdapter(cmd)
		ds = New DataSet
		da.Fill(ds, "data")
		DataGridView1.DataSource = ds
		DataGridView1.DataMember = "daftar_murid"
		cmd.Dispose()
		da.Dispose()
		conn.Close()
	End Sub

	Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
		TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
		TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Try
			sql = "update data_murid set nama_siswa='" & TextBox2.Text & "' where id='" & TextBox1.Text & "'"
			conndb()
			cmd = New MySqlCommand(sql, conn)
			dr = cmd.ExecuteReader()
			MsgBox("Data Berhasil diupdate")
		Catch ex As Exception
			MsgBox(ex.Message)
		Finally
			cmd.Dispose()
			conn.Close()
		End Try
		Me.Controls.Clear()
		InitializeComponent()
		Form2_Load(e, e)
		showusers()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Dim result As Integer = MessageBox.Show("Apakah kamu yakin untuk menghapus data ini?", "caption", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			Try
				sql = "delete from data_murid where id='" & TextBox1.Text & "'"
				conndb()
				cmd = New MySqlCommand(sql, conn)
				dr = cmd.ExecuteReader()
				MsgBox("Data berhasil di hapus")
			Catch ex As Exception
				MsgBox(ex.Message)
			Finally
				cmd.Dispose()
				conn.Close()
			End Try
			Me.Controls.Clear()
			InitializeComponent()
			Form2_Load(e, e)
			showusers()
		Else
		End If

	End Sub
End Class