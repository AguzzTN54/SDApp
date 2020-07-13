Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader

    Sub KoneksiDB()
        Try
            '' MS. Jet OleDB ndak support di laptop aing, tinggal ganti hilangin tanda petik di depan di DB yang mau dipake

            'conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=SDApp.accdb")
            conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=../../Resources/database/kelas6.mdb")
            'conn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0; data source=../../Resources/database/kelas6.mdb")

            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Module
