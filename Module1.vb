Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader

    Sub KoneksiDB()
        Try
            conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Resources/database/SDApp.mdb")

            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Module
