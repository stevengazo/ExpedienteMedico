<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarMedico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.cboTipoIdentificacion = New System.Windows.Forms.ComboBox()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.dateFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCanton = New System.Windows.Forms.TextBox()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.txtOtros = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtNombreEspecialidad = New System.Windows.Forms.TextBox()
        Me.txtAñosExperiencia = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregarEspecialidad = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregarMedico = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtAñosExperiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(515, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar nuevo médico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(25, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(25, 393)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha nacimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(25, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nacionalidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(25, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado civíl:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(25, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sexo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(25, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Identificación:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(25, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tipo identificación:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(25, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Apellidos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dateFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.txtNacionalidad)
        Me.GroupBox1.Controls.Add(Me.cboEstadoCivil)
        Me.GroupBox1.Controls.Add(Me.cboSexo)
        Me.GroupBox1.Controls.Add(Me.cboTipoIdentificacion)
        Me.GroupBox1.Controls.Add(Me.txtIdentificacion)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 464)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información personal"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(245, 53)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(312, 27)
        Me.txtNombre.TabIndex = 9
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(245, 90)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(312, 27)
        Me.txtApellidos.TabIndex = 10
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(245, 190)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(312, 27)
        Me.txtIdentificacion.TabIndex = 11
        '
        'cboTipoIdentificacion
        '
        Me.cboTipoIdentificacion.FormattingEnabled = True
        Me.cboTipoIdentificacion.Items.AddRange(New Object() {"", "Nacional", "Pasaporte", "DIMEX"})
        Me.cboTipoIdentificacion.Location = New System.Drawing.Point(245, 139)
        Me.cboTipoIdentificacion.Name = "cboTipoIdentificacion"
        Me.cboTipoIdentificacion.Size = New System.Drawing.Size(312, 26)
        Me.cboTipoIdentificacion.TabIndex = 12
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"", "Femenino", "Masculino", "Otro"})
        Me.cboSexo.Location = New System.Drawing.Point(245, 239)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(312, 26)
        Me.cboSexo.TabIndex = 13
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"", "Soltero", "Casado", "Divorciado", "Viudo"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(245, 288)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(312, 26)
        Me.cboEstadoCivil.TabIndex = 14
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New System.Drawing.Point(245, 335)
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(312, 27)
        Me.txtNacionalidad.TabIndex = 15
        '
        'dateFechaNacimiento
        '
        Me.dateFechaNacimiento.Location = New System.Drawing.Point(245, 387)
        Me.dateFechaNacimiento.Name = "dateFechaNacimiento"
        Me.dateFechaNacimiento.Size = New System.Drawing.Size(312, 27)
        Me.dateFechaNacimiento.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOtros)
        Me.GroupBox2.Controls.Add(Me.cboProvincia)
        Me.GroupBox2.Controls.Add(Me.txtDistrito)
        Me.GroupBox2.Controls.Add(Me.txtCanton)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(718, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(601, 165)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lugar de residencia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Provincia:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 21)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Otros:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 21)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Distrito:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 21)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Cantón:"
        '
        'txtCanton
        '
        Me.txtCanton.Location = New System.Drawing.Point(244, 53)
        Me.txtCanton.Name = "txtCanton"
        Me.txtCanton.Size = New System.Drawing.Size(312, 27)
        Me.txtCanton.TabIndex = 10
        '
        'txtDistrito
        '
        Me.txtDistrito.Location = New System.Drawing.Point(244, 90)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(312, 27)
        Me.txtDistrito.TabIndex = 11
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Items.AddRange(New Object() {"", "Alajuela", "San José", "Heredia", "Cartago", "Puntarenas", "Guanacaste", "Limón"})
        Me.cboProvincia.Location = New System.Drawing.Point(244, 18)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(312, 26)
        Me.cboProvincia.TabIndex = 13
        '
        'txtOtros
        '
        Me.txtOtros.Location = New System.Drawing.Point(244, 123)
        Me.txtOtros.Name = "txtOtros"
        Me.txtOtros.Size = New System.Drawing.Size(312, 27)
        Me.txtOtros.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.btnAgregarEspecialidad)
        Me.GroupBox3.Controls.Add(Me.txtAñosExperiencia)
        Me.GroupBox3.Controls.Add(Me.txtNombreEspecialidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(718, 275)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(601, 129)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Especialidad médica"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCorreo)
        Me.GroupBox4.Controls.Add(Me.txtTelefono)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(718, 431)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(601, 123)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Información de contacto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(19, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 21)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Nombre:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(19, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(201, 21)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Años de experiencia:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(19, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 21)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Teléfono:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(19, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(187, 21)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "Correo electrónico:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(213, 34)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(312, 27)
        Me.txtTelefono.TabIndex = 17
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(213, 73)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(312, 27)
        Me.txtCorreo.TabIndex = 21
        '
        'txtNombreEspecialidad
        '
        Me.txtNombreEspecialidad.Location = New System.Drawing.Point(226, 36)
        Me.txtNombreEspecialidad.Name = "txtNombreEspecialidad"
        Me.txtNombreEspecialidad.Size = New System.Drawing.Size(185, 27)
        Me.txtNombreEspecialidad.TabIndex = 22
        '
        'txtAñosExperiencia
        '
        Me.txtAñosExperiencia.Location = New System.Drawing.Point(226, 78)
        Me.txtAñosExperiencia.Name = "txtAñosExperiencia"
        Me.txtAñosExperiencia.Size = New System.Drawing.Size(185, 27)
        Me.txtAñosExperiencia.TabIndex = 23
        '
        'btnAgregarEspecialidad
        '
        Me.btnAgregarEspecialidad.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarEspecialidad.Location = New System.Drawing.Point(448, 27)
        Me.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad"
        Me.btnAgregarEspecialidad.Size = New System.Drawing.Size(127, 36)
        Me.btnAgregarEspecialidad.TabIndex = 24
        Me.btnAgregarEspecialidad.Text = "Agregar"
        Me.btnAgregarEspecialidad.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLimpiar.Location = New System.Drawing.Point(448, 69)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(127, 36)
        Me.btnLimpiar.TabIndex = 25
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnAgregarMedico
        '
        Me.btnAgregarMedico.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarMedico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarMedico.Location = New System.Drawing.Point(556, 580)
        Me.btnAgregarMedico.Name = "btnAgregarMedico"
        Me.btnAgregarMedico.Size = New System.Drawing.Size(228, 62)
        Me.btnAgregarMedico.TabIndex = 26
        Me.btnAgregarMedico.Text = "Agregar"
        Me.btnAgregarMedico.UseVisualStyleBackColor = False
        '
        'AgregarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1383, 666)
        Me.Controls.Add(Me.btnAgregarMedico)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "AgregarMedico"
        Me.Text = "Agregar Médico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtAñosExperiencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dateFechaNacimiento As DateTimePicker
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents cboEstadoCivil As ComboBox
    Friend WithEvents cboSexo As ComboBox
    Friend WithEvents cboTipoIdentificacion As ComboBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtOtros As TextBox
    Friend WithEvents cboProvincia As ComboBox
    Friend WithEvents txtDistrito As TextBox
    Friend WithEvents txtCanton As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregarEspecialidad As Button
    Friend WithEvents txtAñosExperiencia As NumericUpDown
    Friend WithEvents txtNombreEspecialidad As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnAgregarMedico As Button
End Class
