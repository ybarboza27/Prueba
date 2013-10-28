Public Class Producto

    Private Sub Producto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        End


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim volver As New principal

        Me.Hide()

        volver.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim insumo As New Insumo

        Me.Hide()

        insumo.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim apli As New Aplicacion

        Me.Hide()
        apli.Show()


    End Sub
End Class