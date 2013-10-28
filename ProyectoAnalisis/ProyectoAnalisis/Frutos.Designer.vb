<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frutos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNombreCultivo = New System.Windows.Forms.TextBox()
        Me.tbValorPorKilo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tfId = New System.Windows.Forms.TextBox()
        Me.listaFrutos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bBorrarEspacios = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bInsertar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgTemp = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.listaFrutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(51, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre del Cultivo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(51, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Valor por Kilo"
        '
        'tbNombreCultivo
        '
        Me.tbNombreCultivo.Location = New System.Drawing.Point(224, 25)
        Me.tbNombreCultivo.Name = "tbNombreCultivo"
        Me.tbNombreCultivo.Size = New System.Drawing.Size(173, 20)
        Me.tbNombreCultivo.TabIndex = 7
        '
        'tbValorPorKilo
        '
        Me.tbValorPorKilo.Location = New System.Drawing.Point(224, 82)
        Me.tbValorPorKilo.Name = "tbValorPorKilo"
        Me.tbValorPorKilo.Size = New System.Drawing.Size(173, 20)
        Me.tbValorPorKilo.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tfId)
        Me.GroupBox1.Controls.Add(Me.tbValorPorKilo)
        Me.GroupBox1.Controls.Add(Me.tbNombreCultivo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(113, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 189)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Fruto "
        '
        'tfId
        '
        Me.tfId.Location = New System.Drawing.Point(224, 118)
        Me.tfId.Name = "tfId"
        Me.tfId.Size = New System.Drawing.Size(100, 20)
        Me.tfId.TabIndex = 9
        Me.tfId.Visible = False
        '
        'listaFrutos
        '
        Me.listaFrutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.listaFrutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaFrutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Nombre, Me.Valor})
        Me.listaFrutos.Location = New System.Drawing.Point(125, 19)
        Me.listaFrutos.Name = "listaFrutos"
        Me.listaFrutos.Size = New System.Drawing.Size(344, 139)
        Me.listaFrutos.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgTemp)
        Me.GroupBox2.Controls.Add(Me.listaFrutos)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(113, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 237)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FRUTOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ProyectoAnalisis.My.Resources.Resources.Submit_02
        Me.PictureBox1.Location = New System.Drawing.Point(-22, -24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 121)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'bBorrarEspacios
        '
        Me.bBorrarEspacios.BackColor = System.Drawing.Color.YellowGreen
        Me.bBorrarEspacios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBorrarEspacios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBorrarEspacios.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBorrarEspacios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bBorrarEspacios.Image = Global.ProyectoAnalisis.My.Resources.Resources.Search_Find
        Me.bBorrarEspacios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBorrarEspacios.Location = New System.Drawing.Point(956, 156)
        Me.bBorrarEspacios.Name = "bBorrarEspacios"
        Me.bBorrarEspacios.Size = New System.Drawing.Size(256, 88)
        Me.bBorrarEspacios.TabIndex = 3
        Me.bBorrarEspacios.Text = "BUSCAR"
        Me.bBorrarEspacios.UseVisualStyleBackColor = False
        '
        'bBorrar
        '
        Me.bBorrar.BackColor = System.Drawing.Color.YellowGreen
        Me.bBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBorrar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bBorrar.Image = Global.ProyectoAnalisis.My.Resources.Resources.Garbage_Closed
        Me.bBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBorrar.Location = New System.Drawing.Point(692, 156)
        Me.bBorrar.Name = "bBorrar"
        Me.bBorrar.Size = New System.Drawing.Size(257, 88)
        Me.bBorrar.TabIndex = 2
        Me.bBorrar.Text = "          BORRAR"
        Me.bBorrar.UseVisualStyleBackColor = False
        '
        'bModificar
        '
        Me.bModificar.BackColor = System.Drawing.Color.YellowGreen
        Me.bModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bModificar.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bModificar.Image = Global.ProyectoAnalisis.My.Resources.Resources.Data_Edit
        Me.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bModificar.Location = New System.Drawing.Point(955, 63)
        Me.bModificar.Name = "bModificar"
        Me.bModificar.Size = New System.Drawing.Size(257, 87)
        Me.bModificar.TabIndex = 1
        Me.bModificar.Text = "MODIFICAR"
        Me.bModificar.UseVisualStyleBackColor = False
        '
        'bInsertar
        '
        Me.bInsertar.BackColor = System.Drawing.Color.YellowGreen
        Me.bInsertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bInsertar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bInsertar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bInsertar.Image = Global.ProyectoAnalisis.My.Resources.Resources.Save
        Me.bInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bInsertar.Location = New System.Drawing.Point(692, 62)
        Me.bInsertar.Name = "bInsertar"
        Me.bInsertar.Size = New System.Drawing.Size(257, 88)
        Me.bInsertar.TabIndex = 0
        Me.bInsertar.Text = "            INSERTAR"
        Me.bInsertar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoAnalisis.My.Resources.Resources.Fruit_Banana_011
        Me.PictureBox2.Location = New System.Drawing.Point(756, 200)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(456, 281)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'dgTemp
        '
        Me.dgTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTemp.Location = New System.Drawing.Point(546, 19)
        Me.dgTemp.Name = "dgTemp"
        Me.dgTemp.Size = New System.Drawing.Size(35, 10)
        Me.dgTemp.TabIndex = 15
        Me.dgTemp.Visible = False
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 41
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre.FillWeight = 200.0!
        Me.Nombre.HeaderText = "Nombre del cultivo"
        Me.Nombre.MinimumWidth = 20
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 82
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor por kilo"
        Me.Valor.Name = "Valor"
        Me.Valor.Width = 71
        '
        'Frutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1285, 636)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bBorrarEspacios)
        Me.Controls.Add(Me.bBorrar)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.bInsertar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Frutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frutos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.listaFrutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bInsertar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bBorrar As System.Windows.Forms.Button
    Friend WithEvents bBorrarEspacios As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNombreCultivo As System.Windows.Forms.TextBox
    Friend WithEvents tbValorPorKilo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents listaFrutos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tfId As System.Windows.Forms.TextBox
    Friend WithEvents dgTemp As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
