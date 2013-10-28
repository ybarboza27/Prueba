<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.calendario = New System.Windows.Forms.PictureBox()
        Me.bImportar = New System.Windows.Forms.Button()
        Me.bCobrar = New System.Windows.Forms.Button()
        Me.bPagar = New System.Windows.Forms.Button()
        Me.bPulpa = New System.Windows.Forms.Button()
        Me.bExportar = New System.Windows.Forms.Button()
        Me.bPlanilla = New System.Windows.Forms.Button()
        Me.bProveedor = New System.Windows.Forms.Button()
        Me.bCliente = New System.Windows.Forms.Button()
        Me.bBolsa = New System.Windows.Forms.Button()
        Me.bMantenimiento = New System.Windows.Forms.Button()
        Me.bEmpleado = New System.Windows.Forms.Button()
        Me.bFruta = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.ProyectoAnalisis.My.Resources.Resources.Message_Information
        Me.PictureBox1.Location = New System.Drawing.Point(990, 310)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 201)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'calendario
        '
        Me.calendario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calendario.Image = Global.ProyectoAnalisis.My.Resources.Resources.Calendar_Date_04
        Me.calendario.Location = New System.Drawing.Point(990, 22)
        Me.calendario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.calendario.Name = "calendario"
        Me.calendario.Size = New System.Drawing.Size(206, 204)
        Me.calendario.TabIndex = 12
        Me.calendario.TabStop = False
        '
        'bImportar
        '
        Me.bImportar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bImportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bImportar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bImportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bImportar.Image = Global.ProyectoAnalisis.My.Resources.Resources.Data_Import
        Me.bImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bImportar.Location = New System.Drawing.Point(632, 431)
        Me.bImportar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bImportar.Name = "bImportar"
        Me.bImportar.Size = New System.Drawing.Size(286, 111)
        Me.bImportar.TabIndex = 11
        Me.bImportar.Text = "      IMPORTAR"
        Me.bImportar.UseVisualStyleBackColor = False
        '
        'bCobrar
        '
        Me.bCobrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bCobrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCobrar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCobrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bCobrar.Image = Global.ProyectoAnalisis.My.Resources.Resources.Payments
        Me.bCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCobrar.Location = New System.Drawing.Point(632, 310)
        Me.bCobrar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bCobrar.Name = "bCobrar"
        Me.bCobrar.Size = New System.Drawing.Size(285, 111)
        Me.bCobrar.TabIndex = 10
        Me.bCobrar.Text = "                               CUENTAS POR COBRAR"
        Me.bCobrar.UseVisualStyleBackColor = False
        '
        'bPagar
        '
        Me.bPagar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bPagar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPagar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bPagar.Image = Global.ProyectoAnalisis.My.Resources.Resources.Payment_01
        Me.bPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPagar.Location = New System.Drawing.Point(631, 189)
        Me.bPagar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bPagar.Name = "bPagar"
        Me.bPagar.Size = New System.Drawing.Size(287, 113)
        Me.bPagar.TabIndex = 9
        Me.bPagar.Text = "                           CUENTAS POR PAGAR"
        Me.bPagar.UseVisualStyleBackColor = False
        '
        'bPulpa
        '
        Me.bPulpa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bPulpa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPulpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPulpa.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPulpa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bPulpa.Image = Global.ProyectoAnalisis.My.Resources.Resources.Inventory_
        Me.bPulpa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPulpa.Location = New System.Drawing.Point(631, 67)
        Me.bPulpa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bPulpa.Name = "bPulpa"
        Me.bPulpa.Size = New System.Drawing.Size(287, 113)
        Me.bPulpa.TabIndex = 8
        Me.bPulpa.Text = "                           Inventario de Pulpa"
        Me.bPulpa.UseVisualStyleBackColor = False
        '
        'bExportar
        '
        Me.bExportar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExportar.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bExportar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bExportar.Image = Global.ProyectoAnalisis.My.Resources.Resources.Export
        Me.bExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bExportar.Location = New System.Drawing.Point(338, 431)
        Me.bExportar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(286, 111)
        Me.bExportar.TabIndex = 7
        Me.bExportar.Text = "            EXPORTAR"
        Me.bExportar.UseVisualStyleBackColor = False
        '
        'bPlanilla
        '
        Me.bPlanilla.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bPlanilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bPlanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPlanilla.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPlanilla.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bPlanilla.Image = Global.ProyectoAnalisis.My.Resources.Resources.Table
        Me.bPlanilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bPlanilla.Location = New System.Drawing.Point(338, 310)
        Me.bPlanilla.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bPlanilla.Name = "bPlanilla"
        Me.bPlanilla.Size = New System.Drawing.Size(285, 113)
        Me.bPlanilla.TabIndex = 6
        Me.bPlanilla.Text = "         PLANILLA"
        Me.bPlanilla.UseVisualStyleBackColor = False
        '
        'bProveedor
        '
        Me.bProveedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bProveedor.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bProveedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bProveedor.Image = Global.ProyectoAnalisis.My.Resources.Resources.Customer
        Me.bProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bProveedor.Location = New System.Drawing.Point(336, 189)
        Me.bProveedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bProveedor.Name = "bProveedor"
        Me.bProveedor.Size = New System.Drawing.Size(288, 113)
        Me.bProveedor.TabIndex = 5
        Me.bProveedor.Text = "                    PROVEEDORES"
        Me.bProveedor.UseVisualStyleBackColor = False
        '
        'bCliente
        '
        Me.bCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCliente.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bCliente.Image = Global.ProyectoAnalisis.My.Resources.Resources.suppler
        Me.bCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bCliente.Location = New System.Drawing.Point(336, 67)
        Me.bCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bCliente.Name = "bCliente"
        Me.bCliente.Size = New System.Drawing.Size(288, 113)
        Me.bCliente.TabIndex = 4
        Me.bCliente.Text = "           CLIENTES"
        Me.bCliente.UseVisualStyleBackColor = False
        '
        'bBolsa
        '
        Me.bBolsa.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bBolsa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bBolsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBolsa.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBolsa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bBolsa.Image = Global.ProyectoAnalisis.My.Resources.Resources.Tree
        Me.bBolsa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bBolsa.Location = New System.Drawing.Point(41, 431)
        Me.bBolsa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bBolsa.Name = "bBolsa"
        Me.bBolsa.Size = New System.Drawing.Size(288, 113)
        Me.bBolsa.TabIndex = 3
        Me.bBolsa.Text = "                              FRUTA EMBOLSADA"
        Me.bBolsa.UseVisualStyleBackColor = False
        '
        'bMantenimiento
        '
        Me.bMantenimiento.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bMantenimiento.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMantenimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bMantenimiento.Image = Global.ProyectoAnalisis.My.Resources.Resources.Radiation_Warning
        Me.bMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bMantenimiento.Location = New System.Drawing.Point(40, 310)
        Me.bMantenimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bMantenimiento.Name = "bMantenimiento"
        Me.bMantenimiento.Size = New System.Drawing.Size(289, 113)
        Me.bMantenimiento.TabIndex = 2
        Me.bMantenimiento.Text = "                            MANTENIMIENTO"
        Me.bMantenimiento.UseVisualStyleBackColor = False
        '
        'bEmpleado
        '
        Me.bEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bEmpleado.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bEmpleado.Image = Global.ProyectoAnalisis.My.Resources.Resources.Men_Work
        Me.bEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bEmpleado.Location = New System.Drawing.Point(38, 189)
        Me.bEmpleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bEmpleado.Name = "bEmpleado"
        Me.bEmpleado.Size = New System.Drawing.Size(290, 113)
        Me.bEmpleado.TabIndex = 1
        Me.bEmpleado.Text = "                            COLABORADORES"
        Me.bEmpleado.UseVisualStyleBackColor = False
        '
        'bFruta
        '
        Me.bFruta.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bFruta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bFruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bFruta.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bFruta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bFruta.Image = Global.ProyectoAnalisis.My.Resources.Resources.Fruit_Banana_01
        Me.bFruta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bFruta.Location = New System.Drawing.Point(38, 67)
        Me.bFruta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bFruta.Name = "bFruta"
        Me.bFruta.Size = New System.Drawing.Size(290, 113)
        Me.bFruta.TabIndex = 0
        Me.bFruta.Text = "        FRUTOS"
        Me.bFruta.UseVisualStyleBackColor = False
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1256, 636)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.calendario)
        Me.Controls.Add(Me.bImportar)
        Me.Controls.Add(Me.bCobrar)
        Me.Controls.Add(Me.bPagar)
        Me.Controls.Add(Me.bPulpa)
        Me.Controls.Add(Me.bExportar)
        Me.Controls.Add(Me.bPlanilla)
        Me.Controls.Add(Me.bProveedor)
        Me.Controls.Add(Me.bCliente)
        Me.Controls.Add(Me.bBolsa)
        Me.Controls.Add(Me.bMantenimiento)
        Me.Controls.Add(Me.bEmpleado)
        Me.Controls.Add(Me.bFruta)
        Me.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRUTOS RyC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bFruta As System.Windows.Forms.Button
    Friend WithEvents bEmpleado As System.Windows.Forms.Button
    Friend WithEvents bMantenimiento As System.Windows.Forms.Button
    Friend WithEvents bBolsa As System.Windows.Forms.Button
    Friend WithEvents bCliente As System.Windows.Forms.Button
    Friend WithEvents bProveedor As System.Windows.Forms.Button
    Friend WithEvents bPlanilla As System.Windows.Forms.Button
    Friend WithEvents bExportar As System.Windows.Forms.Button
    Friend WithEvents bPulpa As System.Windows.Forms.Button
    Friend WithEvents bPagar As System.Windows.Forms.Button
    Friend WithEvents bCobrar As System.Windows.Forms.Button
    Friend WithEvents bImportar As System.Windows.Forms.Button
    Friend WithEvents calendario As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
