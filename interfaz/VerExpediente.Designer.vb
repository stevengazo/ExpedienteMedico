<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerExpediente
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosMedicos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGenerarRegistro = New System.Windows.Forms.Button()
        Me.PanelGeneral = New System.Windows.Forms.Panel()
        Me.PanelAgregarRegistro = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbMedico = New System.Windows.Forms.ComboBox()
        Me.btnCancelarAgregar = New System.Windows.Forms.Button()
        Me.btnAgregarRegistro = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelRegistroInfo = New System.Windows.Forms.Panel()
        Me.btnEliminarRegistro = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarReceta = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnReceta = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarDiagnostico = New System.Windows.Forms.Button()
        Me.btnDiagnostico = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarCita = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCita = New System.Windows.Forms.Button()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNumeroRegistro = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRegistrosMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.PanelGeneral.SuspendLayout()
        Me.PanelAgregarRegistro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelRegistroInfo.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvRegistrosMedicos)
        Me.GroupBox2.Location = New System.Drawing.Point(290, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(939, 384)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro Médico"
        '
        'dgvRegistrosMedicos
        '
        Me.dgvRegistrosMedicos.AllowUserToAddRows = False
        Me.dgvRegistrosMedicos.AllowUserToDeleteRows = False
        Me.dgvRegistrosMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosMedicos.Location = New System.Drawing.Point(6, 19)
        Me.dgvRegistrosMedicos.Name = "dgvRegistrosMedicos"
        Me.dgvRegistrosMedicos.ReadOnly = True
        Me.dgvRegistrosMedicos.Size = New System.Drawing.Size(927, 359)
        Me.dgvRegistrosMedicos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGenerarRegistro)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 52)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        'btnGenerarRegistro
        '
        Me.btnGenerarRegistro.Location = New System.Drawing.Point(9, 19)
        Me.btnGenerarRegistro.Name = "btnGenerarRegistro"
        Me.btnGenerarRegistro.Size = New System.Drawing.Size(244, 23)
        Me.btnGenerarRegistro.TabIndex = 0
        Me.btnGenerarRegistro.Text = "Generar Registro en el expediente"
        Me.btnGenerarRegistro.UseVisualStyleBackColor = True
        '
        'PanelGeneral
        '
        Me.PanelGeneral.Controls.Add(Me.PanelAgregarRegistro)
        Me.PanelGeneral.Controls.Add(Me.GroupBox1)
        Me.PanelGeneral.Controls.Add(Me.GroupBox2)
        Me.PanelGeneral.Controls.Add(Me.GroupBox3)
        Me.PanelGeneral.Location = New System.Drawing.Point(1, 12)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(1232, 415)
        Me.PanelGeneral.TabIndex = 4
        '
        'PanelAgregarRegistro
        '
        Me.PanelAgregarRegistro.Controls.Add(Me.Label6)
        Me.PanelAgregarRegistro.Controls.Add(Me.cbMedico)
        Me.PanelAgregarRegistro.Controls.Add(Me.btnCancelarAgregar)
        Me.PanelAgregarRegistro.Controls.Add(Me.btnAgregarRegistro)
        Me.PanelAgregarRegistro.Controls.Add(Me.Label11)
        Me.PanelAgregarRegistro.Controls.Add(Me.cbSucursal)
        Me.PanelAgregarRegistro.Location = New System.Drawing.Point(19, 226)
        Me.PanelAgregarRegistro.Name = "PanelAgregarRegistro"
        Me.PanelAgregarRegistro.Size = New System.Drawing.Size(265, 128)
        Me.PanelAgregarRegistro.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Doctor"
        '
        'cbMedico
        '
        Me.cbMedico.FormattingEnabled = True
        Me.cbMedico.Location = New System.Drawing.Point(113, 40)
        Me.cbMedico.Name = "cbMedico"
        Me.cbMedico.Size = New System.Drawing.Size(140, 21)
        Me.cbMedico.TabIndex = 11
        '
        'btnCancelarAgregar
        '
        Me.btnCancelarAgregar.Location = New System.Drawing.Point(136, 67)
        Me.btnCancelarAgregar.Name = "btnCancelarAgregar"
        Me.btnCancelarAgregar.Size = New System.Drawing.Size(111, 23)
        Me.btnCancelarAgregar.TabIndex = 10
        Me.btnCancelarAgregar.Text = "Cancelar"
        Me.btnCancelarAgregar.UseVisualStyleBackColor = True
        '
        'btnAgregarRegistro
        '
        Me.btnAgregarRegistro.Location = New System.Drawing.Point(3, 67)
        Me.btnAgregarRegistro.Name = "btnAgregarRegistro"
        Me.btnAgregarRegistro.Size = New System.Drawing.Size(111, 23)
        Me.btnAgregarRegistro.TabIndex = 9
        Me.btnAgregarRegistro.Text = "Agregar Registro"
        Me.btnAgregarRegistro.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Sucursal"
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(113, 13)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(140, 21)
        Me.cbSucursal.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.lblApellidos)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblDNI)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paciente"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(127, 101)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(93, 13)
        Me.lblFechaNacimiento.TabIndex = 11
        Me.lblFechaNacimiento.Text = "Fecha Nacimiento"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Location = New System.Drawing.Point(127, 75)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(93, 13)
        Me.lblApellidos.TabIndex = 10
        Me.lblApellidos.Text = "Fecha Nacimiento"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(127, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(93, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Fecha Nacimiento"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(127, 23)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(93, 13)
        Me.lblDNI.TabIndex = 8
        Me.lblDNI.Text = "Fecha Nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identificación"
        '
        'PanelRegistroInfo
        '
        Me.PanelRegistroInfo.Controls.Add(Me.btnEliminarRegistro)
        Me.PanelRegistroInfo.Controls.Add(Me.btnCerrar)
        Me.PanelRegistroInfo.Controls.Add(Me.GroupBox4)
        Me.PanelRegistroInfo.Location = New System.Drawing.Point(826, 1)
        Me.PanelRegistroInfo.Name = "PanelRegistroInfo"
        Me.PanelRegistroInfo.Size = New System.Drawing.Size(407, 426)
        Me.PanelRegistroInfo.TabIndex = 5
        '
        'btnEliminarRegistro
        '
        Me.btnEliminarRegistro.ForeColor = System.Drawing.Color.Red
        Me.btnEliminarRegistro.Location = New System.Drawing.Point(296, 10)
        Me.btnEliminarRegistro.Name = "btnEliminarRegistro"
        Me.btnEliminarRegistro.Size = New System.Drawing.Size(103, 23)
        Me.btnEliminarRegistro.TabIndex = 3
        Me.btnEliminarRegistro.Text = "EliminarRegistro"
        Me.btnEliminarRegistro.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(12, 10)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.lblSucursal)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.lblNumeroRegistro)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(396, 365)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnEliminarReceta)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.btnReceta)
        Me.GroupBox8.Location = New System.Drawing.Point(17, 189)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(373, 49)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        '
        'btnEliminarReceta
        '
        Me.btnEliminarReceta.Location = New System.Drawing.Point(254, 13)
        Me.btnEliminarReceta.Name = "btnEliminarReceta"
        Me.btnEliminarReceta.Size = New System.Drawing.Size(106, 23)
        Me.btnEliminarReceta.TabIndex = 14
        Me.btnEliminarReceta.Text = "Eliminar"
        Me.btnEliminarReceta.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Receta"
        '
        'btnReceta
        '
        Me.btnReceta.Location = New System.Drawing.Point(123, 13)
        Me.btnReceta.Name = "btnReceta"
        Me.btnReceta.Size = New System.Drawing.Size(110, 23)
        Me.btnReceta.TabIndex = 8
        Me.btnReceta.Text = "Agregar Receta"
        Me.btnReceta.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnEliminarDiagnostico)
        Me.GroupBox7.Controls.Add(Me.btnDiagnostico)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Location = New System.Drawing.Point(17, 134)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(373, 49)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        '
        'btnEliminarDiagnostico
        '
        Me.btnEliminarDiagnostico.Location = New System.Drawing.Point(254, 16)
        Me.btnEliminarDiagnostico.Name = "btnEliminarDiagnostico"
        Me.btnEliminarDiagnostico.Size = New System.Drawing.Size(106, 23)
        Me.btnEliminarDiagnostico.TabIndex = 13
        Me.btnEliminarDiagnostico.Text = "Eliminar"
        Me.btnEliminarDiagnostico.UseVisualStyleBackColor = True
        '
        'btnDiagnostico
        '
        Me.btnDiagnostico.Location = New System.Drawing.Point(123, 16)
        Me.btnDiagnostico.Name = "btnDiagnostico"
        Me.btnDiagnostico.Size = New System.Drawing.Size(110, 23)
        Me.btnDiagnostico.TabIndex = 6
        Me.btnDiagnostico.Text = "Agregar Diagnostico"
        Me.btnDiagnostico.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Diagnostico"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnEliminarCita)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.btnCita)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 85)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(373, 49)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        '
        'btnEliminarCita
        '
        Me.btnEliminarCita.Location = New System.Drawing.Point(254, 17)
        Me.btnEliminarCita.Name = "btnEliminarCita"
        Me.btnEliminarCita.Size = New System.Drawing.Size(106, 23)
        Me.btnEliminarCita.TabIndex = 12
        Me.btnEliminarCita.Text = "Eliminar"
        Me.btnEliminarCita.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(0, 55)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(373, 49)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cita"
        '
        'btnCita
        '
        Me.btnCita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCita.Location = New System.Drawing.Point(123, 17)
        Me.btnCita.Name = "btnCita"
        Me.btnCita.Size = New System.Drawing.Size(110, 23)
        Me.btnCita.TabIndex = 4
        Me.btnCita.Text = "Agregar Cita"
        Me.btnCita.UseVisualStyleBackColor = True
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSucursal.Location = New System.Drawing.Point(268, 54)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(109, 16)
        Me.lblSucursal.TabIndex = 3
        Me.lblSucursal.Text = "Sucursal Elegida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Sucursal Elegida"
        '
        'lblNumeroRegistro
        '
        Me.lblNumeroRegistro.AutoSize = True
        Me.lblNumeroRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroRegistro.Location = New System.Drawing.Point(232, 23)
        Me.lblNumeroRegistro.Name = "lblNumeroRegistro"
        Me.lblNumeroRegistro.Size = New System.Drawing.Size(151, 20)
        Me.lblNumeroRegistro.TabIndex = 1
        Me.lblNumeroRegistro.Text = "Número de Registro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Número de Registro"
        '
        'VerExpediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 433)
        Me.Controls.Add(Me.PanelGeneral)
        Me.Controls.Add(Me.PanelRegistroInfo)
        Me.Name = "VerExpediente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Expediente"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvRegistrosMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.PanelGeneral.ResumeLayout(False)
        Me.PanelAgregarRegistro.ResumeLayout(False)
        Me.PanelAgregarRegistro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelRegistroInfo.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvRegistrosMedicos As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnGenerarRegistro As Button
    Friend WithEvents PanelGeneral As Panel
    Friend WithEvents PanelRegistroInfo As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnReceta As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDiagnostico As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCita As Button
    Friend WithEvents lblSucursal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNumeroRegistro As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelAgregarRegistro As Panel
    Friend WithEvents btnAgregarRegistro As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cbSucursal As ComboBox
    Friend WithEvents btnCancelarAgregar As Button
    Friend WithEvents btnEliminarRegistro As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btnEliminarReceta As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnEliminarDiagnostico As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnEliminarCita As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbMedico As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
