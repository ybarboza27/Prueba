Public Class Proovedor


    Private Sub Proovedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        End


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim volver As New principal

        Me.Hide()

        volver.Show()

    End Sub

End Class