Public Class Embolse

    Dim dFrutaEmbolsada As New DataFrutaEmbolsada

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Dim volver As New principal

        Me.Hide()

        volver.Show()

    End Sub

    Private Sub Embolse_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        End


    End Sub

    'Insertar
    Private Sub bInsertar_Click(sender As Object, e As EventArgs) Handles bInsertar.Click
        Dim salida As String
        If tbNumeroFruta.Text <> "" Then
            salida = dFrutaEmbolsada.ingresarInfoFrutaEmbolsada(dpFechaEmbolse.Text, dpFechaProduccion.Text, CInt(tbNumeroFruta.Text))
            MsgBox(salida)
            tbNumeroFruta.Text = ""
            'dgListaFrutaEmbolsada.DataSource = dFrutaEmbolsada.mostrarInfoFrutaEmbolsadaTodas.Tables(0).DefaultView
            llenarDataGrid()
        Else
            MsgBox("Ingrese los datos correspondientes")
        End If

    End Sub

    Private Sub Embolse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' dgListaFrutaEmbolsada.DataSource = dFrutaEmbolsada.mostrarInfoFrutaEmbolsadaTodas.Tables(0).DefaultView
        llenarDataGrid()

    End Sub

    'Borrar
    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        Dim salida As String
        Dim response As MsgBoxResult
        If tbNumeroFruta.Text <> "" Then
            response = MsgBox("Está segur@ que desea modificar la información", MsgBoxStyle.YesNoCancel, "Eliminar")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.
                salida = dFrutaEmbolsada.eliminarInfoFrutaEmbolsada(CInt(tfIdFrutaEmbolsada.Text))
                MsgBox(salida)
                llenarDataGrid()
            Else
                MsgBox("La acción ha sido cancelada")
            End If
            tbNumeroFruta.Text = ""
            'dgListaFrutaEmbolsada.DataSource = dFrutaEmbolsada.mostrarInfoFrutaEmbolsadaTodas.Tables(0).DefaultView
        Else
            MsgBox("Elija una opción")
        End If

    End Sub

    Private Sub empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaFrutaEmbolsada.CellContentClick
        Dim fila As Integer
        fila = dgListaFrutaEmbolsada.CurrentRow.Index

        dpFechaEmbolse.Text = dgListaFrutaEmbolsada.Item(1, fila).Value
        dpFechaProduccion.Text = dgListaFrutaEmbolsada.Item(2, fila).Value
        tbNumeroFruta.Text = dgListaFrutaEmbolsada.Item(3, fila).Value
        tfIdFrutaEmbolsada.Text = dgListaFrutaEmbolsada.Item(0, fila).Value
    End Sub

    'Modificar
    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim salida As String
        Dim response As MsgBoxResult
        If tbNumeroFruta.Text <> "" Then
            response = MsgBox("Está segur@ que desea modificar la información", MsgBoxStyle.YesNoCancel, "Eliminar")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.
                salida = dFrutaEmbolsada.modificarInfoFrutaEmbolsada(CInt(tfIdFrutaEmbolsada.Text), dpFechaEmbolse.Text, dpFechaProduccion.Text, CInt(tbNumeroFruta.Text))
                MsgBox(salida)
                'dgListaFrutaEmbolsada.DataSource = dFrutaEmbolsada.mostrarInfoFrutaEmbolsadaTodas.Tables(0).DefaultView
                llenarDataGrid()

            Else
                MsgBox("La acción ha sido cancelada")
            End If

            tbNumeroFruta.Text = ""
        Else
            MsgBox("Elija una opción")
        End If

    End Sub

    'Limpiar espacios
    Private Sub bBorrarEspacios_Click(sender As Object, e As EventArgs) Handles bBorrarEspacios.Click
        tbNumeroFruta.Text = ""
        tfIdFrutaEmbolsada.Text = ""
    End Sub

    Public Sub llenarDataGrid()
        dgTemp.DataSource = dFrutaEmbolsada.mostrarInfoFrutaEmbolsadaTodas.Tables(0).DefaultView
        dgListaFrutaEmbolsada.Rows.Clear()
        Dim i As Int32
        Dim celda As String
        Dim dgc As DataGridViewCell
        For i = 0 To dgTemp.Rows.Count - 2
            dgc = dgTemp.Rows(i).Cells(2)
            celda = dgc.Value
            dgListaFrutaEmbolsada.Rows.Add(dgTemp.Rows(i).Cells(0).Value,
                                 dgTemp.Rows(i).Cells(1).Value.ToString, dgTemp.Rows(i).Cells(2).Value,
                                 dgTemp.Rows(i).Cells(3).Value)
        Next
    End Sub
End Class