<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Embolse
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
        Me.bBorrarEspacios = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bInsertar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNumeroFruta = New System.Windows.Forms.MaskedTextBox()
        Me.dpFechaEmbolse = New System.Windows.Forms.DateTimePicker()
        Me.dpFechaProduccion = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tfIdFrutaEmbolsada = New System.Windows.Forms.TextBox()
        Me.dgListaFrutaEmbolsada = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgTemp = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEmbolse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaProduccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgListaFrutaEmbolsada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.bBorrarEspacios.TabIndex = 4
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
        Me.bBorrar.TabIndex = 3
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
        Me.bModificar.TabIndex = 2
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
        Me.bInsertar.TabIndex = 1
        Me.bInsertar.Text = "            INSERTAR"
        Me.bInsertar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoAnalisis.My.Resources.Resources.Tree1
        Me.PictureBox2.Location = New System.Drawing.Point(756, 182)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(456, 323)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ProyectoAnalisis.My.Resources.Resources.Submit_02
        Me.PictureBox1.Location = New System.Drawing.Point(-22, -24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 121)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(29, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Numero de Fruta Embolsada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(29, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Fecha de Embolse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(29, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fecha de Producción"
        '
        'tbNumeroFruta
        '
        Me.tbNumeroFruta.Location = New System.Drawing.Point(275, 27)
        Me.tbNumeroFruta.Name = "tbNumeroFruta"
        Me.tbNumeroFruta.Size = New System.Drawing.Size(100, 20)
        Me.tbNumeroFruta.TabIndex = 20
        '
        'dpFechaEmbolse
        '
        Me.dpFechaEmbolse.Location = New System.Drawing.Point(275, 85)
        Me.dpFechaEmbolse.Name = "dpFechaEmbolse"
        Me.dpFechaEmbolse.Size = New System.Drawing.Size(216, 20)
        Me.dpFechaEmbolse.TabIndex = 21
        '
        'dpFechaProduccion
        '
        Me.dpFechaProduccion.Location = New System.Drawing.Point(275, 131)
        Me.dpFechaProduccion.Name = "dpFechaProduccion"
        Me.dpFechaProduccion.Size = New System.Drawing.Size(215, 20)
        Me.dpFechaProduccion.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dpFechaProduccion)
        Me.GroupBox1.Controls.Add(Me.dpFechaEmbolse)
        Me.GroupBox1.Controls.Add(Me.tbNumeroFruta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(144, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 188)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fruta Embolsada"
        '
        'tfIdFrutaEmbolsada
        '
        Me.tfIdFrutaEmbolsada.Location = New System.Drawing.Point(756, 250)
        Me.tfIdFrutaEmbolsada.Name = "tfIdFrutaEmbolsada"
        Me.tfIdFrutaEmbolsada.Size = New System.Drawing.Size(100, 20)
        Me.tfIdFrutaEmbolsada.TabIndex = 23
        Me.tfIdFrutaEmbolsada.Visible = False
        '
        'dgListaFrutaEmbolsada
        '
        Me.dgListaFrutaEmbolsada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListaFrutaEmbolsada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.fechaEmbolse, Me.fechaProduccion, Me.Cantidad})
        Me.dgListaFrutaEmbolsada.Location = New System.Drawing.Point(89, 60)
        Me.dgListaFrutaEmbolsada.Name = "dgListaFrutaEmbolsada"
        Me.dgListaFrutaEmbolsada.Size = New System.Drawing.Size(342, 112)
        Me.dgListaFrutaEmbolsada.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgListaFrutaEmbolsada)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(144, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 192)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Frutas"
        '
        'dgTemp
        '
        Me.dgTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTemp.Location = New System.Drawing.Point(756, 276)
        Me.dgTemp.Name = "dgTemp"
        Me.dgTemp.Size = New System.Drawing.Size(32, 19)
        Me.dgTemp.TabIndex = 26
        Me.dgTemp.Visible = False
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.Visible = False
        '
        'fechaEmbolse
        '
        Me.fechaEmbolse.HeaderText = "Fecha de embolse"
        Me.fechaEmbolse.Name = "fechaEmbolse"
        '
        'fechaProduccion
        '
        Me.fechaProduccion.HeaderText = "Fecha de Producción"
        Me.fechaProduccion.Name = "fechaProduccion"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Embolse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1285, 636)
        Me.Controls.Add(Me.dgTemp)
        Me.Controls.Add(Me.tfIdFrutaEmbolsada)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bBorrarEspacios)
        Me.Controls.Add(Me.bBorrar)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.bInsertar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Embolse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Embolse"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgListaFrutaEmbolsada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bInsertar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bBorrar As System.Windows.Forms.Button
    Friend WithEvents bBorrarEspacios As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbNumeroFruta As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dpFechaEmbolse As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpFechaProduccion As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgListaFrutaEmbolsada As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tfIdFrutaEmbolsada As System.Windows.Forms.TextBox
    Friend WithEvents dgTemp As System.Windows.Forms.DataGridView
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaEmbolse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaProduccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
