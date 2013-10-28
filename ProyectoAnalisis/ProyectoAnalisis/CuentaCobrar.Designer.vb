<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CuentaCobrar
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.cbCultivo = New System.Windows.Forms.ComboBox()
        Me.FrutaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RycFrutasDataSet1 = New ProyectoAnalisis.rycFrutasDataSet1()
        Me.mtbKilosPendientes = New System.Windows.Forms.MaskedTextBox()
        Me.mtbMonto = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbAbonoK = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbNombreCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RycFrutasDataSet = New ProyectoAnalisis.rycFrutasDataSet()
        Me.tbAbono = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbIdCuenta = New System.Windows.Forms.TextBox()
        Me.tbIdFruto = New System.Windows.Forms.TextBox()
        Me.tbIdCliente = New System.Windows.Forms.TextBox()
        Me.dgCuentaCobrar = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbClienteCuenta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bLimpiarCampos = New System.Windows.Forms.Button()
        Me.bBorrar = New System.Windows.Forms.Button()
        Me.bModificar = New System.Windows.Forms.Button()
        Me.bInsertar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ClientesTableAdapter = New ProyectoAnalisis.rycFrutasDataSetTableAdapters.clientesTableAdapter()
        Me.FrutaTableAdapter = New ProyectoAnalisis.rycFrutasDataSet1TableAdapters.frutaTableAdapter()
        Me.dgTemp = New System.Windows.Forms.DataGridView()
        Me.IdCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KilosPendientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cultivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.FrutaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RycFrutasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RycFrutasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuentaCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(10, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "NOMBRE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(212, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "FECHA DE ENTREGA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(10, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "MONTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(214, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "KILOS PENDIENTES"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(214, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 23)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "CULTIVO"
        '
        'dpFechaEntrega
        '
        Me.dpFechaEntrega.Location = New System.Drawing.Point(364, 168)
        Me.dpFechaEntrega.Name = "dpFechaEntrega"
        Me.dpFechaEntrega.Size = New System.Drawing.Size(200, 20)
        Me.dpFechaEntrega.TabIndex = 27
        '
        'cbCultivo
        '
        Me.cbCultivo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FrutaBindingSource, "id", True))
        Me.cbCultivo.DataSource = Me.FrutaBindingSource
        Me.cbCultivo.DisplayMember = "nombreFruto"
        Me.cbCultivo.FormattingEnabled = True
        Me.cbCultivo.Location = New System.Drawing.Point(364, 36)
        Me.cbCultivo.Name = "cbCultivo"
        Me.cbCultivo.Size = New System.Drawing.Size(121, 21)
        Me.cbCultivo.TabIndex = 28
        Me.cbCultivo.ValueMember = "id"
        '
        'FrutaBindingSource
        '
        Me.FrutaBindingSource.DataMember = "fruta"
        Me.FrutaBindingSource.DataSource = Me.RycFrutasDataSet1
        '
        'RycFrutasDataSet1
        '
        Me.RycFrutasDataSet1.DataSetName = "rycFrutasDataSet1"
        Me.RycFrutasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mtbKilosPendientes
        '
        Me.mtbKilosPendientes.Location = New System.Drawing.Point(364, 88)
        Me.mtbKilosPendientes.Mask = "###################"
        Me.mtbKilosPendientes.Name = "mtbKilosPendientes"
        Me.mtbKilosPendientes.Size = New System.Drawing.Size(121, 20)
        Me.mtbKilosPendientes.TabIndex = 29
        '
        'mtbMonto
        '
        Me.mtbMonto.Location = New System.Drawing.Point(108, 88)
        Me.mtbMonto.Mask = "################"
        Me.mtbMonto.Name = "mtbMonto"
        Me.mtbMonto.Size = New System.Drawing.Size(100, 20)
        Me.mtbMonto.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbAbonoK)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbNombreCliente)
        Me.GroupBox1.Controls.Add(Me.tbAbono)
        Me.GroupBox1.Controls.Add(Me.mtbMonto)
        Me.GroupBox1.Controls.Add(Me.mtbKilosPendientes)
        Me.GroupBox1.Controls.Add(Me.cbCultivo)
        Me.GroupBox1.Controls.Add(Me.dpFechaEntrega)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(98, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 191)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUENTA"
        '
        'tbAbonoK
        '
        Me.tbAbonoK.Location = New System.Drawing.Point(364, 142)
        Me.tbAbonoK.Name = "tbAbonoK"
        Me.tbAbonoK.Size = New System.Drawing.Size(100, 20)
        Me.tbAbonoK.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(214, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 23)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "ABONO K"
        '
        'cbNombreCliente
        '
        Me.cbNombreCliente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "id", True))
        Me.cbNombreCliente.DataSource = Me.ClientesBindingSource
        Me.cbNombreCliente.DisplayMember = "nombre"
        Me.cbNombreCliente.FormattingEnabled = True
        Me.cbNombreCliente.Location = New System.Drawing.Point(108, 34)
        Me.cbNombreCliente.Name = "cbNombreCliente"
        Me.cbNombreCliente.Size = New System.Drawing.Size(100, 21)
        Me.cbNombreCliente.TabIndex = 32
        Me.cbNombreCliente.ValueMember = "id"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.RycFrutasDataSet
        '
        'RycFrutasDataSet
        '
        Me.RycFrutasDataSet.DataSetName = "rycFrutasDataSet"
        Me.RycFrutasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbAbono
        '
        Me.tbAbono.Location = New System.Drawing.Point(108, 140)
        Me.tbAbono.Mask = "##############"
        Me.tbAbono.Name = "tbAbono"
        Me.tbAbono.Size = New System.Drawing.Size(100, 20)
        Me.tbAbono.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(10, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "ABONO"
        '
        'tbIdCuenta
        '
        Me.tbIdCuenta.Location = New System.Drawing.Point(479, 247)
        Me.tbIdCuenta.Name = "tbIdCuenta"
        Me.tbIdCuenta.Size = New System.Drawing.Size(11, 20)
        Me.tbIdCuenta.TabIndex = 35
        Me.tbIdCuenta.Visible = False
        '
        'tbIdFruto
        '
        Me.tbIdFruto.Location = New System.Drawing.Point(462, 247)
        Me.tbIdFruto.Name = "tbIdFruto"
        Me.tbIdFruto.Size = New System.Drawing.Size(11, 20)
        Me.tbIdFruto.TabIndex = 34
        Me.tbIdFruto.Visible = False
        '
        'tbIdCliente
        '
        Me.tbIdCliente.Location = New System.Drawing.Point(445, 247)
        Me.tbIdCliente.Name = "tbIdCliente"
        Me.tbIdCliente.Size = New System.Drawing.Size(11, 20)
        Me.tbIdCliente.TabIndex = 33
        Me.tbIdCliente.Visible = False
        '
        'dgCuentaCobrar
        '
        Me.dgCuentaCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCuentaCobrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCuenta, Me.IdCliente, Me.Nombre, Me.FechaEntrega, Me.Monto, Me.KilosPendientes, Me.idFruto, Me.Cultivo})
        Me.dgCuentaCobrar.Location = New System.Drawing.Point(42, 90)
        Me.dgCuentaCobrar.Name = "dgCuentaCobrar"
        Me.dgCuentaCobrar.Size = New System.Drawing.Size(639, 150)
        Me.dgCuentaCobrar.TabIndex = 34
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbClienteCuenta)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.dgCuentaCobrar)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(98, 292)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(708, 277)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CUENTAS"
        '
        'cbClienteCuenta
        '
        Me.cbClienteCuenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ClientesBindingSource, "id", True))
        Me.cbClienteCuenta.DataSource = Me.ClientesBindingSource
        Me.cbClienteCuenta.DisplayMember = "nombre"
        Me.cbClienteCuenta.FormattingEnabled = True
        Me.cbClienteCuenta.Location = New System.Drawing.Point(112, 36)
        Me.cbClienteCuenta.Name = "cbClienteCuenta"
        Me.cbClienteCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cbClienteCuenta.TabIndex = 36
        Me.cbClienteCuenta.ValueMember = "id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 23)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "CLIENTE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ProyectoAnalisis.My.Resources.Resources.Submit_02
        Me.PictureBox1.Location = New System.Drawing.Point(-22, -24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 121)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'bLimpiarCampos
        '
        Me.bLimpiarCampos.BackColor = System.Drawing.Color.YellowGreen
        Me.bLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLimpiarCampos.Font = New System.Drawing.Font("Impact", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLimpiarCampos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bLimpiarCampos.Image = Global.ProyectoAnalisis.My.Resources.Resources.Search_Find
        Me.bLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLimpiarCampos.Location = New System.Drawing.Point(956, 156)
        Me.bLimpiarCampos.Name = "bLimpiarCampos"
        Me.bLimpiarCampos.Size = New System.Drawing.Size(256, 88)
        Me.bLimpiarCampos.TabIndex = 18
        Me.bLimpiarCampos.Text = "LIMPIAR CAMPOS"
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
        Me.bBorrar.TabIndex = 17
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
        Me.bModificar.TabIndex = 16
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
        Me.bInsertar.TabIndex = 15
        Me.bInsertar.Text = "            INSERTAR"
        Me.bInsertar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoAnalisis.My.Resources.Resources.Payments1
        Me.PictureBox2.Location = New System.Drawing.Point(795, 223)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(456, 325)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'FrutaTableAdapter
        '
        Me.FrutaTableAdapter.ClearBeforeFill = True
        '
        'dgTemp
        '
        Me.dgTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTemp.Location = New System.Drawing.Point(496, 247)
        Me.dgTemp.Name = "dgTemp"
        Me.dgTemp.Size = New System.Drawing.Size(15, 18)
        Me.dgTemp.TabIndex = 37
        Me.dgTemp.Visible = False
        '
        'IdCuenta
        '
        Me.IdCuenta.HeaderText = "IdCuenta"
        Me.IdCuenta.Name = "IdCuenta"
        Me.IdCuenta.Visible = False
        '
        'IdCliente
        '
        Me.IdCliente.HeaderText = "IdCliente"
        Me.IdCliente.Name = "IdCliente"
        Me.IdCliente.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'FechaEntrega
        '
        Me.FechaEntrega.HeaderText = "Fecha de Entrega"
        Me.FechaEntrega.Name = "FechaEntrega"
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        '
        'KilosPendientes
        '
        Me.KilosPendientes.HeaderText = "Kilos Pendientes"
        Me.KilosPendientes.Name = "KilosPendientes"
        '
        'idFruto
        '
        Me.idFruto.HeaderText = "IdFruto"
        Me.idFruto.Name = "idFruto"
        Me.idFruto.Visible = False
        '
        'Cultivo
        '
        Me.Cultivo.HeaderText = "Cultivo"
        Me.Cultivo.Name = "Cultivo"
        '
        'CuentaCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1285, 636)
        Me.Controls.Add(Me.dgTemp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tbIdCuenta)
        Me.Controls.Add(Me.bLimpiarCampos)
        Me.Controls.Add(Me.bBorrar)
        Me.Controls.Add(Me.tbIdFruto)
        Me.Controls.Add(Me.bModificar)
        Me.Controls.Add(Me.tbIdCliente)
        Me.Controls.Add(Me.bInsertar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "CuentaCobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas Por Cobrar"
        CType(Me.FrutaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RycFrutasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RycFrutasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuentaCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bLimpiarCampos As System.Windows.Forms.Button
    Friend WithEvents bBorrar As System.Windows.Forms.Button
    Friend WithEvents bModificar As System.Windows.Forms.Button
    Friend WithEvents bInsertar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dpFechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCultivo As System.Windows.Forms.ComboBox
    Friend WithEvents mtbKilosPendientes As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbMonto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgCuentaCobrar As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbNombreCliente As System.Windows.Forms.ComboBox
    Friend WithEvents cbClienteCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RycFrutasDataSet As ProyectoAnalisis.rycFrutasDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ProyectoAnalisis.rycFrutasDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents RycFrutasDataSet1 As ProyectoAnalisis.rycFrutasDataSet1
    Friend WithEvents FrutaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FrutaTableAdapter As ProyectoAnalisis.rycFrutasDataSet1TableAdapters.frutaTableAdapter
    Friend WithEvents tbIdCliente As System.Windows.Forms.TextBox
    Friend WithEvents tbIdFruto As System.Windows.Forms.TextBox
    Friend WithEvents tbIdCuenta As System.Windows.Forms.TextBox
    Friend WithEvents tbAbonoK As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbAbono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgTemp As System.Windows.Forms.DataGridView
    Friend WithEvents IdCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEntrega As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KilosPendientes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idFruto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cultivo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
