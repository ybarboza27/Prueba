Public Class Frutos

    Dim dFrutas As New DataFrutas
    Private Sub Frutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'listaFrutos.DataSource = dFrutas.mostrarFrutas.Tables(0).DefaultView
        llenarDataGrid()
    End Sub

    Private Sub Frutos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
        If tbNombreCultivo.Text <> "" And tbValorPorKilo.Text <> "" Then
            salida = dFrutas.ingresarFruta(tbNombreCultivo.Text, tbValorPorKilo.Text)
            MsgBox(salida)
            tbNombreCultivo.Text = ""
            tbValorPorKilo.Text = ""
            'listaFrutos.DataSource = dFrutas.mostrarFrutas.Tables(0).DefaultView
            llenarDataGrid()
        Else
            MsgBox("Ingrese los datos correspondientes")
        End If

    End Sub

    'Borrar
    Private Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        Dim salida As String
        Dim response As MsgBoxResult
        If tbNombreCultivo.Text <> "" And tbValorPorKilo.Text <> "" Then
            response = MsgBox("Está segur@ que desea eliminar esta fruta", MsgBoxStyle.YesNoCancel, "Eliminar")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.
                salida = dFrutas.eliminarFruta(tfId.Text)
                MsgBox(salida)
                'listaFrutos.DataSource = dFrutas.mostrarFrutas.Tables(0).DefaultView
                llenarDataGrid()

            Else
                MsgBox("La acción ha sido cancelada")
            End If


            tbNombreCultivo.Text = ""
            tbValorPorKilo.Text = ""
        Else
            MsgBox("Elija una opción")
        End If

    End Sub

    Private Sub empleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaFrutos.CellContentClick
        Dim fila As Integer
        fila = listaFrutos.CurrentRow.Index
        tbNombreCultivo.Text = listaFrutos.Item(1, fila).Value
        tbValorPorKilo.Text = listaFrutos.Item(2, fila).Value
        tfId.Text = listaFrutos.Item(0, fila).Value
    End Sub

    'Modificar
    Private Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim salida As String
        Dim response As MsgBoxResult
        If tbNombreCultivo.Text <> "" And tbValorPorKilo.Text <> "" Then
            response = MsgBox("Está segur@ que desea modificar la información de la fruta", MsgBoxStyle.YesNoCancel, "Eliminar")
            If response = MsgBoxResult.Yes Then   ' User chose Yes.
                salida = dFrutas.modificarFruta(tfId.Text, tbNombreCultivo.Text, tbValorPorKilo.Text)
                MsgBox(salida)
                dgTemp.DataSource = dFrutas.mostrarFrutas.Tables(0).DefaultView
                llenarDataGrid()

            Else
                MsgBox("La acción ha sido cancelada")
            End If

            tbNombreCultivo.Text = ""
            tbValorPorKilo.Text = ""
        Else
            MsgBox("Elija una opción")
        End If

    End Sub

    Private Sub bBorrarEspacios_Click(sender As Object, e As EventArgs) Handles bBorrarEspacios.Click
        tbNombreCultivo.Text = ""
        tbValorPorKilo.Text = ""
    End Sub

    Public Sub llenarDataGrid()
        dgTemp.DataSource = dFrutas.mostrarFrutas.Tables(0).DefaultView
        listaFrutos.Rows.Clear()
        Dim i As Int32
        Dim celda As String
        Dim dgc As DataGridViewCell
        For i = 0 To dgTemp.Rows.Count - 2
            dgc = dgTemp.Rows(i).Cells(2)
            celda = dgc.Value
            listaFrutos.Rows.Add(dgTemp.Rows(i).Cells(0).Value,
                                 dgTemp.Rows(i).Cells(1).Value, dgTemp.Rows(i).Cells(2).Value)
        Next
    End Sub
    
End Class