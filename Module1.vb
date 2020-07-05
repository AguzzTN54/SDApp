Imports MySql.Data.MySqlClient
Module Module1
	Public sql As String
	Public ds As New DataSet
	Public cmd As MySqlCommand
	Public dr As MySqlDataReader
	Public da As MySqlDataAdapter

	Public conn As New MySqlConnection
	Public Sub conndb()
		Try
			conn = New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=db_sekolah;")
			conn.Open()
		Catch ex As Exception
			MsgBox("Gagal", MsgBoxStyle.Information, "Database")
		End Try
	End Sub

End Module
