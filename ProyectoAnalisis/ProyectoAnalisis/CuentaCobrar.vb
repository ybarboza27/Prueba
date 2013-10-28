Public Class CuentaCobrar

    Dim dCuentasPorCobrar As New DataCuentasPorCobrar
    Dim dCliente As New DataCliente
    Private Sub CuentaPagar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim volver As New principal
        Me.Hide()
        volver.Show()
    End Sub

    'Insertar
    Private Sub bInsertar_Click(sender As Object, e As EventArgs) Handles bInsertar.Click
        Dim salida As String
        Dim montoActual As Integer
        Dim kilosActuales As Integer
        If mtbMonto.Text <> "" And mtbKilosPendientes.Text <> "" And tbAbono.Text <> "" And tbAbonoK.Text <> "" Then
            montoActual = CInt(mtbMonto.Text) - CInt(tbAbono.Text)
            kilosActuales = CInt(mtbKilosPendientes.Text) - CInt(tbAbonoK.Text)

            If montoActual < 0 Or kilosActuales < 0 Then
                MsgBox("El abono ha excedido")
            Else

                salida = dCuentasPorCobrar.ingresarCuentaPorCobrar(cbNombreCliente.SelectedValue,
                                                              dpFechaEntrega.Text, montoActual, kilosActuales, cbCultivo.SelectedValue)
                MsgBox(salida)
                MsgBox(cbNombreCliente.SelectedValue)
                mtbMonto.Text = ""
                mtbKilosPendientes.Text = ""
                tbAbono.Text = "0"
                tbAbonoK.Text = "0"
                'dgCuentaCobrar.DataSource = dCuentasPorCobrar.mostrarCuentasPorCobrarClienteTodas(cbNombreCliente.SelectedValue).Tables(0).DefaultView
                llenarDataGrid()
            End If

        Else
            MsgBox("Ingrese los datos correspondientes")
            tbAbono.Text = "0"
            tbAbonoK.Text = "0"
        End If
    End Sub

    'Borrar
    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        Dim salida As String
        Dim response As MsgBoxResult
        If mtbMonto.Text <> "" And mtbKilosPendientes.Text <> "" And tbAbono.Text <> "" And tbAbonoK.Text <> "" Then
            response = MsgBox("Está segur@ que desea eliminar la cuenta por cobrar", MsgBoxStyle.YesNoCancel, "Eliminar")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.

                salida = dCuentasPorCobrar.eliminarCuentaPorCobrar(CInt(cbNombreCliente.SelectedValue), dpFechaEntrega.Text, cbCultivo.SelectedValue)
                MsgBox(salida)
                mtbMonto.Text = ""
                mtbKilosPendientes.Text = ""
                tbAbono.Text = ""
                tbAbono.Text = "0"
                tbAbonoK.Text = "0"
                'dgCuentaCobrar.DataSource = dCuentasPorCobrar.mostrarCuentasPorCobrarClienteTodas(cbNombreCliente.SelectedValue).Tables(0).DefaultView
                llenarDataGrid()
            Else
                MsgBox("La acción ha sido cancelada")
                tbAbono.Text = "0"
                tbAbonoK.Text = "0"
            End If
        Else
            MsgBox("Elija la opción correspondiente")
            tbAbono.Text = "0"
            tbAbonoK.Text = "0"
        End If

    End Sub

    Private Sub empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCuentaCobrar.CellContentClick
        Dim fila As Integer
        fila = dgCuentaCobrar.CurrentRow.Index
        cbNombreCliente.Text = dgCuentaCobrar.Item(2, fila).Value
        dpFechaEntrega.Text = dgCuentaCobrar.Item(3, fila).Value
        mtbMonto.Text = dgCuentaCobrar.Item(4, fila).Value
        mtbKilosPendientes.Text = dgCuentaCobrar.Item(5, fila).Value
        cbCultivo.Text = dgCuentaCobrar.Item(7, fila).Value
        tbIdFruto.Text = dgCuentaCobrar.Item(6, fila).Value 'ID FRUTO
        tbIdCliente.Text = dgCuentaCobrar.Item(1, fila).Value
        tbIdCuenta.Text = dgCuentaCobrar.Item(0, fila).Value
    End Sub

    'Modificar
    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim salida As String
        Dim response As MsgBoxResult
        Dim montoActual As Integer
        Dim kilosActuales As Integer
        If mtbMonto.Text <> "" And mtbKilosPendientes.Text <> "" And tbAbono.Text <> "" And tbAbonoK.Text <> "" Then

            montoActual = CInt(mtbMonto.Text) - CInt(tbAbono.Text)
            kilosActuales = CInt(mtbKilosPendientes.Text) - CInt(tbAbonoK.Text)

            If montoActual < 0 Or kilosActuales < 0 Then
                MsgBox("El abono ha excedido")
            Else
                response = MsgBox("Está segur@ que desea modificar la información de la cuenta por cobrar", MsgBoxStyle.YesNoCancel, "Eliminar")
                If response = MsgBoxResult.Yes Then   ' User chose Yes.
                    salida = dCuentasPorCobrar.modificarCuentaPorCobrar(CInt(cbNombreCliente.SelectedValue), dpFechaEntrega.Text, montoActual, kilosActuales, CInt(tbIdFruto.Text), CInt(tbIdCuenta.Text))
                    MsgBox(salida)
                    'listaFrutos.DataSource = dFrutas.mostrarFrutas.Tables(0).DefaultView
                    llenarDataGrid()
                    mtbMonto.Text = ""
                    mtbKilosPendientes.Text = ""
                    tbAbono.Text = ""
                    tbAbonoK.Text = ""
                    tbAbono.Text = "0"
                    tbAbonoK.Text = "0"
                Else
                    MsgBox("La acción ha sido cancelada")
                    tbAbono.Text = "0"
                    tbAbonoK.Text = "0"
                End If
            End If


        Else
            MsgBox("Elija la opción correspondiente")
            tbAbono.Text = "0"
            tbAbonoK.Text = "0"
        End If




    End Sub

    Private Sub CuentaCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RycFrutasDataSet1.fruta' Puede moverla o quitarla según sea necesario.
        Me.FrutaTableAdapter.Fill(Me.RycFrutasDataSet1.fruta)
        'TODO: esta línea de código carga datos en la tabla 'RycFrutasDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.RycFrutasDataSet.clientes)

        'dgCuentaCobrar.DataSource = dCuentasPorCobrar.mostrarCuentasPorCobrarClienteTodas(cbNombreCliente.SelectedValue).Tables(0).DefaultView
        llenarDataGrid()
        tbAbono.Text = "0"
        tbAbonoK.Text = "0"
        recargarComboBox()

    End Sub

    Private Sub recargarComboBox()
        cbNombreCliente.DataSource = dCliente.infoCliente
        cbNombreCliente.DisplayMember = "nombre"
        ' esto es lo que mostrara el combo
        cbNombreCliente.ValueMember = "id"
        ' esto es lo que devolvera el combo al hacer el "ComboBox1.SelectedValue.ToString" para obtener el valor seleccionado

    End Sub

    



    Private Sub bLimpiarCampos_Click(sender As Object, e As EventArgs) Handles bLimpiarCampos.Click
        mtbMonto.Text = ""
        mtbKilosPendientes.Text = ""
        tbAbono.Text = ""
        tbAbonoK.Text = ""
    End Sub

    Public Sub llenarDataGrid()
        dgTemp.DataSource = dCuentasPorCobrar.mostrarCuentasPorCobrarClienteTodas(cbClienteCuenta.SelectedValue).Tables(0).DefaultView

        dgCuentaCobrar.Rows.Clear()
        Dim i As Int32
        Dim celda As String
        Dim dgc As DataGridViewCell
        For i = 0 To dgTemp.Rows.Count - 2
            dgc = dgTemp.Rows(i).Cells(2)
            celda = dgc.Value
            dgCuentaCobrar.Rows.Add(dgTemp.Rows(i).Cells(0).Value,
                                 dgTemp.Rows(i).Cells(1).Value, dgTemp.Rows(i).Cells(2).Value,
                                 dgTemp.Rows(i).Cells(3).Value, dgTemp.Rows(i).Cells(4).Value,
                                 dgTemp.Rows(i).Cells(5).Value, dgTemp.Rows(i).Cells(6).Value,
                                 dgTemp.Rows(i).Cells(7).Value)
        Next
    End Sub

    Private Sub cbClienteCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClienteCuenta.SelectedIndexChanged

        llenarDataGrid()

    End Sub
End Class