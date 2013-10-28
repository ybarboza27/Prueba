Public Class Insumo

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim volver As New Producto

        Me.Hide()

        volver.Show()

    End Sub

    Private Sub Insumo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        End


    End Sub

End Class