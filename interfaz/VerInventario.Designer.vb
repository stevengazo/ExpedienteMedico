<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerInventario
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
        Me.PanelGeneral = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.lblSucursalNombre = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cBoxRefrigeracion = New System.Windows.Forms.CheckBox()
        Me.dtpVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbMedicamento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSucursal = New System.Windows.Forms.Button()
        Me.cbBuscarSucursal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelActualizar = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.cbMedicamentoExist = New System.Windows.Forms.ComboBox()
        Me.cbSucursalExist = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numCantidadExit = New System.Windows.Forms.NumericUpDown()
        Me.CheckBoxRefrigeracionExist = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpVencimientoExist = New System.Windows.Forms.DateTimePicker()
        Me.txtLoteExist = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpIngresoExist = New System.Windows.Forms.DateTimePicker()
        Me.PanelGeneral.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelActualizar.SuspendLayout()
        CType(Me.numCantidadExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelGeneral
        '
        Me.PanelGeneral.Controls.Add(Me.GroupBox2)
        Me.PanelGeneral.Controls.Add(Me.GroupBox1)
        Me.PanelGeneral.Location = New System.Drawing.Point(3, 12)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(1113, 426)
        Me.PanelGeneral.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvInventario)
        Me.GroupBox3.Controls.Add(Me.lblSucursalNombre)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(252, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(861, 419)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'dgvInventario
        '
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(6, 37)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.Size = New System.Drawing.Size(849, 376)
        Me.dgvInventario.TabIndex = 2
        '
        'lblSucursalNombre
        '
        Me.lblSucursalNombre.AutoSize = True
        Me.lblSucursalNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursalNombre.Location = New System.Drawing.Point(78, 16)
        Me.lblSucursalNombre.Name = "lblSucursalNombre"
        Me.lblSucursalNombre.Size = New System.Drawing.Size(0, 18)
        Me.lblSucursalNombre.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sucursal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.cbSucursal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cBoxRefrigeracion)
        Me.GroupBox2.Controls.Add(Me.dtpVencimiento)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpIngreso)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtLote)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.numCantidad)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbMedicamento)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 314)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Medicamento"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(84, 221)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(140, 23)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar Medicamento"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(84, 183)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(140, 21)
        Me.cbSucursal.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Sucursal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Refrigeración"
        '
        'cBoxRefrigeracion
        '
        Me.cBoxRefrigeracion.AutoSize = True
        Me.cBoxRefrigeracion.Location = New System.Drawing.Point(84, 160)
        Me.cBoxRefrigeracion.Name = "cBoxRefrigeracion"
        Me.cBoxRefrigeracion.Size = New System.Drawing.Size(58, 17)
        Me.cBoxRefrigeracion.TabIndex = 11
        Me.cBoxRefrigeracion.Text = "Ocupa"
        Me.cBoxRefrigeracion.UseVisualStyleBackColor = True
        '
        'dtpVencimiento
        '
        Me.dtpVencimiento.Location = New System.Drawing.Point(84, 133)
        Me.dtpVencimiento.Name = "dtpVencimiento"
        Me.dtpVencimiento.Size = New System.Drawing.Size(140, 20)
        Me.dtpVencimiento.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Vencimiento"
        '
        'dtpIngreso
        '
        Me.dtpIngreso.Location = New System.Drawing.Point(84, 107)
        Me.dtpIngreso.Name = "dtpIngreso"
        Me.dtpIngreso.Size = New System.Drawing.Size(140, 20)
        Me.dtpIngreso.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha Ingreso"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(84, 78)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(140, 20)
        Me.txtLote.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Lote"
        '
        'numCantidad
        '
        Me.numCantidad.Location = New System.Drawing.Point(84, 52)
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(140, 20)
        Me.numCantidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'cbMedicamento
        '
        Me.cbMedicamento.FormattingEnabled = True
        Me.cbMedicamento.Location = New System.Drawing.Point(84, 25)
        Me.cbMedicamento.Name = "cbMedicamento"
        Me.cbMedicamento.Size = New System.Drawing.Size(140, 21)
        Me.cbMedicamento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Medicamento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSucursal)
        Me.GroupBox1.Controls.Add(Me.cbBuscarSucursal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(10, 65)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(184, 23)
        Me.btnSucursal.TabIndex = 2
        Me.btnSucursal.Text = "Buscar Inventario"
        Me.btnSucursal.UseVisualStyleBackColor = True
        '
        'cbBuscarSucursal
        '
        Me.cbBuscarSucursal.FormattingEnabled = True
        Me.cbBuscarSucursal.Location = New System.Drawing.Point(10, 37)
        Me.cbBuscarSucursal.Name = "cbBuscarSucursal"
        Me.cbBuscarSucursal.Size = New System.Drawing.Size(184, 21)
        Me.cbBuscarSucursal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Sucursal"
        '
        'PanelActualizar
        '
        Me.PanelActualizar.Controls.Add(Me.btnCerrar)
        Me.PanelActualizar.Controls.Add(Me.Label17)
        Me.PanelActualizar.Controls.Add(Me.btnActualizar)
        Me.PanelActualizar.Controls.Add(Me.cbMedicamentoExist)
        Me.PanelActualizar.Controls.Add(Me.cbSucursalExist)
        Me.PanelActualizar.Controls.Add(Me.Label16)
        Me.PanelActualizar.Controls.Add(Me.Label10)
        Me.PanelActualizar.Controls.Add(Me.Label15)
        Me.PanelActualizar.Controls.Add(Me.Label11)
        Me.PanelActualizar.Controls.Add(Me.numCantidadExit)
        Me.PanelActualizar.Controls.Add(Me.CheckBoxRefrigeracionExist)
        Me.PanelActualizar.Controls.Add(Me.Label14)
        Me.PanelActualizar.Controls.Add(Me.dtpVencimientoExist)
        Me.PanelActualizar.Controls.Add(Me.txtLoteExist)
        Me.PanelActualizar.Controls.Add(Me.Label12)
        Me.PanelActualizar.Controls.Add(Me.Label13)
        Me.PanelActualizar.Controls.Add(Me.dtpIngresoExist)
        Me.PanelActualizar.Location = New System.Drawing.Point(3, 12)
        Me.PanelActualizar.Name = "PanelActualizar"
        Me.PanelActualizar.Size = New System.Drawing.Size(271, 426)
        Me.PanelActualizar.TabIndex = 3
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(166, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(92, 23)
        Me.btnCerrar.TabIndex = 16
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(19, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(166, 18)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Actualizar Medicamento"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(96, 264)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(140, 23)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar Médicamento"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'cbMedicamentoExist
        '
        Me.cbMedicamentoExist.FormattingEnabled = True
        Me.cbMedicamentoExist.Location = New System.Drawing.Point(96, 79)
        Me.cbMedicamentoExist.Name = "cbMedicamentoExist"
        Me.cbMedicamentoExist.Size = New System.Drawing.Size(140, 21)
        Me.cbMedicamentoExist.TabIndex = 3
        '
        'cbSucursalExist
        '
        Me.cbSucursalExist.FormattingEnabled = True
        Me.cbSucursalExist.Location = New System.Drawing.Point(96, 237)
        Me.cbSucursalExist.Name = "cbSucursalExist"
        Me.cbSucursalExist.Size = New System.Drawing.Size(140, 21)
        Me.cbSucursalExist.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Medicamento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Sucursal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 215)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Refrigeración"
        '
        'numCantidadExit
        '
        Me.numCantidadExit.Location = New System.Drawing.Point(96, 106)
        Me.numCantidadExit.Name = "numCantidadExit"
        Me.numCantidadExit.Size = New System.Drawing.Size(140, 20)
        Me.numCantidadExit.TabIndex = 5
        '
        'CheckBoxRefrigeracionExist
        '
        Me.CheckBoxRefrigeracionExist.AutoSize = True
        Me.CheckBoxRefrigeracionExist.Location = New System.Drawing.Point(96, 214)
        Me.CheckBoxRefrigeracionExist.Name = "CheckBoxRefrigeracionExist"
        Me.CheckBoxRefrigeracionExist.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxRefrigeracionExist.TabIndex = 11
        Me.CheckBoxRefrigeracionExist.Text = "Ocupa"
        Me.CheckBoxRefrigeracionExist.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Lote"
        '
        'dtpVencimientoExist
        '
        Me.dtpVencimientoExist.Location = New System.Drawing.Point(96, 187)
        Me.dtpVencimientoExist.Name = "dtpVencimientoExist"
        Me.dtpVencimientoExist.Size = New System.Drawing.Size(140, 20)
        Me.dtpVencimientoExist.TabIndex = 9
        '
        'txtLoteExist
        '
        Me.txtLoteExist.Location = New System.Drawing.Point(96, 132)
        Me.txtLoteExist.Name = "txtLoteExist"
        Me.txtLoteExist.Size = New System.Drawing.Size(140, 20)
        Me.txtLoteExist.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Vencimiento"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Fecha Ingreso"
        '
        'dtpIngresoExist
        '
        Me.dtpIngresoExist.Location = New System.Drawing.Point(96, 161)
        Me.dtpIngresoExist.Name = "dtpIngresoExist"
        Me.dtpIngresoExist.Size = New System.Drawing.Size(140, 20)
        Me.dtpIngresoExist.TabIndex = 2
        '
        'VerInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1128, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PanelGeneral)
        Me.Controls.Add(Me.PanelActualizar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerInventario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Inventario"
        Me.PanelGeneral.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelActualizar.ResumeLayout(False)
        Me.PanelActualizar.PerformLayout()
        CType(Me.numCantidadExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelGeneral As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents lblSucursalNombre As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbSucursal As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cBoxRefrigeracion As CheckBox
    Friend WithEvents dtpVencimiento As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpIngreso As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents cbMedicamento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSucursal As Button
    Friend WithEvents cbBuscarSucursal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelActualizar As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents cbMedicamentoExist As ComboBox
    Friend WithEvents cbSucursalExist As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents numCantidadExit As NumericUpDown
    Friend WithEvents CheckBoxRefrigeracionExist As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtpVencimientoExist As DateTimePicker
    Friend WithEvents txtLoteExist As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpIngresoExist As DateTimePicker
End Class
