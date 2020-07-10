Public Class Masuk

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Daftar.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call KoneksiDB()
        cmd = New OleDb.OleDbCommand("select * from data_siswa where nama_siswa= '" & TextBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Me.Hide()
            PilihKelas.nama.Text = TextBox1.Text
            PilihKelas.Show()
        Else
            MsgBox("Namamu Belum ada, Silahkan Daftar Terlebih dahulu")
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Masuk_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case MessageBox.Show("Berhenti Belajar ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
            Case Windows.Forms.DialogResult.No
                e.Cancel = True
        End Select
    End Sub

    Private Sub Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class