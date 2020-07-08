Public Class Masuk

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Daftar.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        PilihKelas.nama.Text = TextBox1.Text
        PilihKelas.Show()
    End Sub

    Private Sub Masuk_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Select Case MessageBox.Show("Berhenti Belajar ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
            Case Windows.Forms.DialogResult.No
                e.Cancel = True
        End Select
    End Sub

End Class