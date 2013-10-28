Imports System.Data.SqlClient

Public Class principal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bFruta.Click

        Dim fruta As New Frutos

        Me.Hide()
        fruta.Show()

    End Sub

    Private Sub calendario_Click(sender As Object, e As EventArgs) Handles calendario.Click

        MsgBox("Funka")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        MsgBox("Revise el Calendario")

    End Sub

    Private Sub principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        End


    End Sub

    Private Sub bEmpleado_Click(sender As Object, e As EventArgs) Handles bEmpleado.Click

        Dim empleao As New Empleado

        Me.Hide()
        empleao.Show()

    End Sub

    Private Sub bBolsa_Click(sender As Object, e As EventArgs) Handles bBolsa.Click

        Dim embol As New Embolse

        Me.Hide()
        embol.Show()

    End Sub

    Private Sub bCliente_Click(sender As Object, e As EventArgs) Handles bCliente.Click

        Dim clien As New Cliente

        Me.Hide()
        clien.Show()


    End Sub

    Private Sub bProveedor_Click(sender As Object, e As EventArgs) Handles bProveedor.Click

        Dim provee As New Proovedor

        Me.Hide()

        provee.Show()

    End Sub

    Private Sub bExportar_Click(sender As Object, e As EventArgs) Handles bExportar.Click


        Dim ruta As String
        Dim base As String


        base = "infoAplicada"

        'Abrimos un cuadro de Dialogo 
        Dim path As New SaveFileDialog
        'Ponemos la extension en que se va a almacenar
        path.Filter = "Archivo backup | *.bak"
        If path.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Almacenamos el la Ruta en el TexBox
            ruta = CStr(path.FileName)

            Dim sBackup As String = "BACKUP DATABASE " & base & _
" TO DISK = N'" & ruta & _
"' WITH NOFORMAT, NOINIT, NAME =N'" & base & _
"-Full Database Backup',SKIP, STATS = 10"

            Dim csb As New SqlConnectionStringBuilder
            csb.DataSource = "Data Source=Mau-PC;Initial Catalog=infoAplicada;Integrated Security=True"
            csb.InitialCatalog = base
            csb.IntegratedSecurity = True

            Me.bExportar.Enabled = False
            Me.bExportar.Text = "    Procesando..."
            Me.bExportar.Refresh()

            Using con As New SqlConnection(csb.ConnectionString)
                Try
                    con.Open()
                    Dim cmdBackUp As New SqlCommand(sBackup, con)
                    cmdBackUp.ExecuteNonQuery()
                    MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoria")
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, _
                                   "Error al copiar la base de datos")

                End Try
            End Using
            Me.bExportar.Text = "           Exportar"
            Me.bExportar.Enabled = True
            Me.bExportar.Refresh()

        End If

        

    End Sub

    Private Sub bImportar_Click(sender As Object, e As EventArgs) Handles bImportar.Click

        Dim op As New OpenFileDialog
        op.Filter = "Archivo Backup|*.bak"
        If op.ShowDialog = Windows.Forms.DialogResult.OK Then




        End If

    End Sub

    Private Sub bPulpa_Click(sender As Object, e As EventArgs) Handles bPulpa.Click

        Dim pul As New Pulpa

        Me.Hide()

        pul.Show()


    End Sub

    Private Sub bMantenimiento_Click(sender As Object, e As EventArgs) Handles bMantenimiento.Click

        Dim producto As New Producto

        Me.Hide()

        producto.Show()


    End Sub

    Private Sub bPagar_Click(sender As Object, e As EventArgs) Handles bPagar.Click

        Dim cuenta As New CuentaPagar

        Me.Hide()

        cuenta.Show()


    End Sub

    Private Sub bCobrar_Click(sender As Object, e As EventArgs) Handles bCobrar.Click

        Dim cuenta As New CuentaCobrar

        Me.Hide()

        cuenta.Show()

    End Sub
End Class
