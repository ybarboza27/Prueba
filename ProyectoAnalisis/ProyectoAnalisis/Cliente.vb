Public Class Cliente


    Dim dCliente As New DataCliente

    Private Sub Cliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        End


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim volver As New principal

        Me.Hide()

        volver.Show()

    End Sub

    'Ingresar
    Private Sub bInsertar_Click(sender As Object, e As EventArgs) Handles bInsertar.Click
        Dim salida As String
        If tbCedula.Text <> "" And tbCliente.Text <> "" And
            tb1apellido.Text <> "" And tb2apellido.Text <> "" And tbtelefono.Text <> "" Then
            salida = dCliente.ingresarCliente(tbCedula.Text, tbCliente.Text, tb1apellido.Text, tb2apellido.Text, tbtelefono.Text)
            limpiarEspacios()
                'listaClientes.DataSource = dCliente.mostrarClientes.Tables(0).DefaultView
            llenarDataGrid()
            MsgBox(salida)
        Else
            MsgBox("Elija una opción")
        End If
    End Sub


    'Eliminar
    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        Dim salida As String
        Dim response As MsgBoxResult
        If tbCedula.Text <> "" And tbCliente.Text <> "" And
            tb1apellido.Text <> "" And tb2apellido.Text <> "" And tbtelefono.Text <> "" Then
            response = MsgBox("Está segur@ que desea modificar la información de la fruta", MsgBoxStyle.YesNoCancel, "Eliminar")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.

                salida = dCliente.eliminarCliente(tbCedula.Text)

                limpiarEspacios()
                'listaClientes.DataSource = dCliente.mostrarClientes.Tables(0).DefaultView
                llenarDataGrid()
            Else
                MsgBox("La acción ha sido cancelada")
            End If
        Else
            MsgBox("Elija una opción")
        End If
    End Sub


    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'listaClientes.DataSource = dCliente.mostrarClientes.Tables(0).DefaultView
        llenarDataGrid()
    End Sub

    'Modificar
    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim salida As String
        Dim response As MsgBoxResult
        If tbCedula.Text <> "" And tbCliente.Text <> "" And
            tb1apellido.Text <> "" And tb2apellido.Text <> "" And tbtelefono.Text <> "" Then
            response = MsgBox("Está segur@ que desea modificar la información de la fruta", MsgBoxStyle.YesNoCancel, "Eliminar")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.

                salida = dCliente.modificarCliente(CInt(tbIdCliente.Text), tbCedula.Text, tbCliente.Text, tb1apellido.Text, tb2apellido.Text, tbtelefono.Text)
                MsgBox(salida)
                limpiarEspacios()
                llenarDataGrid()
            Else
                MsgBox("La acción ha sido cancelada")
            End If
        Else
            MsgBox("Elija una opción")
        End If

                'listaClientes.DataSource = dCliente.mostrarClientes.Tables(0).DefaultView
    End Sub


    Private Sub empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaClientes.CellContentClick
        Dim fila As Integer
        fila = listaClientes.CurrentRow.Index
        tbCedula.Text = listaClientes.Item(1, fila).Value
        tbCliente.Text = listaClientes.Item(2, fila).Value
        tb1apellido.Text = listaClientes.Item(3, fila).Value
        tb2apellido.Text = listaClientes.Item(4, fila).Value
        tbtelefono.Text = listaClientes.Item(5, fila).Value
        tbporAnio.Text = listaClientes.Item(6, fila).Value
        tbIdCliente.Text = listaClientes.Item(0, fila).Value
    End Sub

    'Limpiar campos
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bLimpiarCampos.Click
        limpiarEspacios()

    End Sub

    Public Sub llenarDataGrid()
        dgTemp.DataSource = dCliente.mostrarClientes.Tables(0).DefaultView
        listaClientes.Rows.Clear()
        Dim i As Int32
        Dim celda As String
        Dim dgc As DataGridViewCell
        For i = 0 To dgTemp.Rows.Count - 2
            dgc = dgTemp.Rows(i).Cells(2)
            celda = dgc.Value
            listaClientes.Rows.Add(dgTemp.Rows(i).Cells(0).Value,
                                 dgTemp.Rows(i).Cells(1).Value, dgTemp.Rows(i).Cells(2).Value,
                                 dgTemp.Rows(i).Cells(3).Value, dgTemp.Rows(i).Cells(4).Value,
                                 dgTemp.Rows(i).Cells(5).Value, dgTemp.Rows(i).Cells(6).Value)
        Next
    End Sub

    Public Sub limpiarEspacios()
        tbCedula.Text = ""
        tbCliente.Text = ""
        tb1apellido.Text = ""
        tb2apellido.Text = ""
        tbtelefono.Text = ""
        tbKilosMomento.Text = ""
        tbporAnio.Text = ""

    End Sub
End Class