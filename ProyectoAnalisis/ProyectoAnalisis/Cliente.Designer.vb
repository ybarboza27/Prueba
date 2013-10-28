<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCedula = New System.Windows.Forms.MaskedTextBox()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.tb1apellido = New System.Windows.Forms.TextBox()
        Me.tb2apellido = New System.Windows.Forms.TextBox()
        Me.tbtelefono = New System.Windows.Forms.TextBox()
        Me.tbporAnio = New System.Windows.Forms.TextBox()
        Me.tbKilosMomento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbIdCliente = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bLimpiarCampos = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bInsertar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.listaClientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgTemp = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ced = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unoApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dosApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estimacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kMomento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(37, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "CÉDULA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(37, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(37, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "PRIMER APELLIDO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(37, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "SEGUNDO APELLIDO"
        '
        'tbCedula
        '
        Me.tbCedula.Location = New System.Drawing.Point(192, 35)
        Me.tbCedula.Name = "tbCedula"
        Me.tbCedula.Size = New System.Drawing.Size(100, 20)
        Me.tbCedula.TabIndex = 22
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(192, 68)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.Size = New System.Drawing.Size(100, 20)
        Me.tbCliente.TabIndex = 23
        '
        'tb1apellido
        '
        Me.tb1apellido.Location = New System.Drawing.Point(192, 104)
        Me.tb1apellido.Name = "tb1apellido"
        Me.tb1apellido.Size = New System.Drawing.Size(100, 20)
        Me.tb1apellido.TabIndex = 24
        '
        'tb2apellido
        '
        Me.tb2apellido.Location = New System.Drawing.Point(192, 138)
        Me.tb2apellido.Name = "tb2apellido"
        Me.tb2apellido.Size = New System.Drawing.Size(100, 20)
        Me.tb2apellido.TabIndex = 25
        '
        'tbtelefono
        '
        Me.tbtelefono.Location = New System.Drawing.Point(452, 31)
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.Size = New System.Drawing.Size(100, 20)
        Me.tbtelefono.TabIndex = 26
        '
        'tbporAnio
        '
        Me.tbporAnio.Location = New System.Drawing.Point(452, 63)
        Me.tbporAnio.Name = "tbporAnio"
        Me.tbporAnio.Size = New System.Drawing.Size(100, 20)
        Me.tbporAnio.TabIndex = 27
        '
        'tbKilosMomento
        '
        Me.tbKilosMomento.Location = New System.Drawing.Point(452, 101)
        Me.tbKilosMomento.Name = "tbKilosMomento"
        Me.tbKilosMomento.Size = New System.Drawing.Size(100, 20)
        Me.tbKilosMomento.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(309, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "TELÉFONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(309, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 23)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Kg. POR AÑO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(312, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 23)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Kg. DE MOMENTO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbKilosMomento)
        Me.GroupBox1.Controls.Add(Me.tbporAnio)
        Me.GroupBox1.Controls.Add(Me.tbtelefono)
        Me.GroupBox1.Controls.Add(Me.tb2apellido)
        Me.GroupBox1.Controls.Add(Me.tb1apellido)
        Me.GroupBox1.Controls.Add(Me.tbCliente)
        Me.GroupBox1.Controls.Add(Me.tbCedula)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(100, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 188)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLIENTES"
        '
        'tbIdCliente
        '
        Me.tbIdCliente.Location = New System.Drawing.Point(710, 250)
        Me.tbIdCliente.Name = "tbIdCliente"
        Me.tbIdCliente.Size = New System.Drawing.Size(10, 20)
        Me.tbIdCliente.TabIndex = 32
        Me.tbIdCliente.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ProyectoAnalisis.My.Resources.Resources.Submit_02
        Me.PictureBox1.Location = New System.Drawing.Point(-22, -24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 121)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'bLimpiarCampos
        '
        Me.bLimpiarCampos.BackColor = System.Drawing.Color.YellowGreen
        Me.bLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiarCampos.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiarCampos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bLimpiarCampos.Image = Global.ProyectoAnalisis.My.Resources.Resources.Search_Find
        Me.bLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiarCampos.Location = New System.Drawing.Point(956, 156)
        Me.bLimpiarCampos.Name = "bLimpiarCampos"
        Me.bLimpiarCampos.Size = New System.Drawing.Size(256, 88)
        Me.bLimpiarCampos.TabIndex = 8
        Me.bLimpiarCampos.Text = "BUSCAR"
        Me.bLimpiarCampos.UseVisualStyleBackColor = False
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
        Me.bBorrar.TabIndex = 7
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
        Me.bModificar.TabIndex = 6
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
        Me.bInsertar.TabIndex = 5
        Me.bInsertar.Text = "            INSERTAR"
        Me.bInsertar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoAnalisis.My.Resources.Resources.Customer1
        Me.PictureBox2.Location = New System.Drawing.Point(851, 160)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(456, 323)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'listaClientes
        '
        Me.listaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.ced, Me.nombre, Me.unoApellido, Me.dosApellido, Me.tel, Me.estimacion, Me.kMomento})
        Me.listaClientes.Location = New System.Drawing.Point(14, 17)
        Me.listaClientes.Name = "listaClientes"
        Me.listaClientes.Size = New System.Drawing.Size(743, 150)
        Me.listaClientes.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listaClientes)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(100, 273)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(777, 210)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CLIENTES"
        '
        'dgTemp
        '
        Me.dgTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTemp.Location = New System.Drawing.Point(681, 250)
        Me.dgTemp.Name = "dgTemp"
        Me.dgTemp.Size = New System.Drawing.Size(23, 10)
        Me.dgTemp.TabIndex = 36
        Me.dgTemp.Visible = False
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        '
        'ced
        '
        Me.ced.HeaderText = "Cédula"
        Me.ced.Name = "ced"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'unoApellido
        '
        Me.unoApellido.HeaderText = "Primer Apellido"
        Me.unoApellido.Name = "unoApellido"
        '
        'dosApellido
        '
        Me.dosApellido.HeaderText = "Segundo Apellido"
        Me.dosApellido.Name = "dosApellido"
        '
        'tel
        '
        Me.tel.HeaderText = "Teléfono"
        Me.tel.Name = "tel"
        '
        'estimacion
        '
        Me.estimacion.HeaderText = "Kg. por año"
        Me.estimacion.Name = "estimacion"
        '
        'kMomento
        '
        Me.kMomento.HeaderText = "Kg. de momento"
        Me.kMomento.Name = "kMomento"
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1285, 636)
        Me.Controls.Add(Me.tbIdCliente)
        Me.Controls.Add(Me.dgTemp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bLimpiarCampos)
        Me.Controls.Add(Me.bBorrar)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.bInsertar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bLimpiarCampos As System.Windows.Forms.Button
    Friend WithEvents bBorrar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bInsertar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tbCliente As System.Windows.Forms.TextBox
    Friend WithEvents tb1apellido As System.Windows.Forms.TextBox
    Friend WithEvents tb2apellido As System.Windows.Forms.TextBox
    Friend WithEvents tbtelefono As System.Windows.Forms.TextBox
    Friend WithEvents tbporAnio As System.Windows.Forms.TextBox
    Friend WithEvents tbKilosMomento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents listaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents dgTemp As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ced As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unoApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dosApellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estimacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kMomento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
