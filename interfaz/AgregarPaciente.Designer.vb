<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarPaciente))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCorreoPaciente = New System.Windows.Forms.TextBox()
        Me.txtTelefonoPaciente = New System.Windows.Forms.TextBox()
        Me.cbTipoCorreoPaciente = New System.Windows.Forms.ComboBox()
        Me.cbTipoTelefonoPaciente = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbDistrito = New System.Windows.Forms.ComboBox()
        Me.cbCanton = New System.Windows.Forms.ComboBox()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.datePaciente = New System.Windows.Forms.DateTimePicker()
        Me.cbEstadoCivilPaciente = New System.Windows.Forms.ComboBox()
        Me.cbSexoPaciente = New System.Windows.Forms.ComboBox()
        Me.cbTipoIdenPaciente = New System.Windows.Forms.ComboBox()
        Me.txtNacionalidadPaciente = New System.Windows.Forms.TextBox()
        Me.txtApellidosPaciente = New System.Windows.Forms.TextBox()
        Me.txtIdenPaciente = New System.Windows.Forms.TextBox()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarPaciente = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbSeguro = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCorreoPaciente)
        Me.GroupBox3.Controls.Add(Me.txtTelefonoPaciente)
        Me.GroupBox3.Controls.Add(Me.cbTipoCorreoPaciente)
        Me.GroupBox3.Controls.Add(Me.cbTipoTelefonoPaciente)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(8, 302)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(836, 128)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contactos"
        '
        'txtCorreoPaciente
        '
        Me.txtCorreoPaciente.Location = New System.Drawing.Point(147, 80)
        Me.txtCorreoPaciente.Name = "txtCorreoPaciente"
        Me.txtCorreoPaciente.Size = New System.Drawing.Size(165, 26)
        Me.txtCorreoPaciente.TabIndex = 6
        '
        'txtTelefonoPaciente
        '
        Me.txtTelefonoPaciente.Location = New System.Drawing.Point(147, 37)
        Me.txtTelefonoPaciente.Name = "txtTelefonoPaciente"
        Me.txtTelefonoPaciente.Size = New System.Drawing.Size(165, 26)
        Me.txtTelefonoPaciente.TabIndex = 5
        '
        'cbTipoCorreoPaciente
        '
        Me.cbTipoCorreoPaciente.FormattingEnabled = True
        Me.cbTipoCorreoPaciente.Items.AddRange(New Object() {"", "casa", "trabajo", "personal"})
        Me.cbTipoCorreoPaciente.Location = New System.Drawing.Point(366, 80)
        Me.cbTipoCorreoPaciente.Name = "cbTipoCorreoPaciente"
        Me.cbTipoCorreoPaciente.Size = New System.Drawing.Size(142, 24)
        Me.cbTipoCorreoPaciente.TabIndex = 4
        '
        'cbTipoTelefonoPaciente
        '
        Me.cbTipoTelefonoPaciente.FormattingEnabled = True
        Me.cbTipoTelefonoPaciente.Items.AddRange(New Object() {"", "celular", "casa", "trabajo"})
        Me.cbTipoTelefonoPaciente.Location = New System.Drawing.Point(366, 40)
        Me.cbTipoTelefonoPaciente.Name = "cbTipoTelefonoPaciente"
        Me.cbTipoTelefonoPaciente.Size = New System.Drawing.Size(142, 24)
        Me.cbTipoTelefonoPaciente.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Correo electronico"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Número de teléfono"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbDistrito)
        Me.GroupBox2.Controls.Add(Me.cbCanton)
        Me.GroupBox2.Controls.Add(Me.cbProvincia)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(8, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(836, 111)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lugar de Residencia"
        '
        'cbDistrito
        '
        Me.cbDistrito.FormattingEnabled = True
        Me.cbDistrito.Location = New System.Drawing.Point(529, 24)
        Me.cbDistrito.Name = "cbDistrito"
        Me.cbDistrito.Size = New System.Drawing.Size(290, 24)
        Me.cbDistrito.TabIndex = 20
        '
        'cbCanton
        '
        Me.cbCanton.FormattingEnabled = True
        Me.cbCanton.Location = New System.Drawing.Point(136, 64)
        Me.cbCanton.Name = "cbCanton"
        Me.cbCanton.Size = New System.Drawing.Size(209, 24)
        Me.cbCanton.TabIndex = 19
        '
        'cbProvincia
        '
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(136, 24)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(209, 24)
        Me.cbProvincia.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Cantón"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(363, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Distrito"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Provincia"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.datePaciente)
        Me.GroupBox1.Controls.Add(Me.cbEstadoCivilPaciente)
        Me.GroupBox1.Controls.Add(Me.cbSexoPaciente)
        Me.GroupBox1.Controls.Add(Me.cbTipoIdenPaciente)
        Me.GroupBox1.Controls.Add(Me.txtNacionalidadPaciente)
        Me.GroupBox1.Controls.Add(Me.txtApellidosPaciente)
        Me.GroupBox1.Controls.Add(Me.txtIdenPaciente)
        Me.GroupBox1.Controls.Add(Me.txtNombrePaciente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(836, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Personal"
        '
        'datePaciente
        '
        Me.datePaciente.Location = New System.Drawing.Point(529, 129)
        Me.datePaciente.Name = "datePaciente"
        Me.datePaciente.Size = New System.Drawing.Size(290, 26)
        Me.datePaciente.TabIndex = 16
        '
        'cbEstadoCivilPaciente
        '
        Me.cbEstadoCivilPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbEstadoCivilPaciente.FormattingEnabled = True
        Me.cbEstadoCivilPaciente.Items.AddRange(New Object() {"Soltero", "Casado", "Viudo", "Divorciado", "Unión Libre"})
        Me.cbEstadoCivilPaciente.Location = New System.Drawing.Point(531, 96)
        Me.cbEstadoCivilPaciente.Name = "cbEstadoCivilPaciente"
        Me.cbEstadoCivilPaciente.Size = New System.Drawing.Size(288, 24)
        Me.cbEstadoCivilPaciente.TabIndex = 15
        '
        'cbSexoPaciente
        '
        Me.cbSexoPaciente.FormattingEnabled = True
        Me.cbSexoPaciente.Items.AddRange(New Object() {"Otro", "Masculino", "Femenino"})
        Me.cbSexoPaciente.Location = New System.Drawing.Point(136, 96)
        Me.cbSexoPaciente.Name = "cbSexoPaciente"
        Me.cbSexoPaciente.Size = New System.Drawing.Size(209, 24)
        Me.cbSexoPaciente.TabIndex = 14
        '
        'cbTipoIdenPaciente
        '
        Me.cbTipoIdenPaciente.FormattingEnabled = True
        Me.cbTipoIdenPaciente.Items.AddRange(New Object() {"Nacional ", "DIMEX", "Pasaporte"})
        Me.cbTipoIdenPaciente.Location = New System.Drawing.Point(531, 65)
        Me.cbTipoIdenPaciente.Name = "cbTipoIdenPaciente"
        Me.cbTipoIdenPaciente.Size = New System.Drawing.Size(288, 24)
        Me.cbTipoIdenPaciente.TabIndex = 13
        '
        'txtNacionalidadPaciente
        '
        Me.txtNacionalidadPaciente.Location = New System.Drawing.Point(136, 129)
        Me.txtNacionalidadPaciente.Name = "txtNacionalidadPaciente"
        Me.txtNacionalidadPaciente.Size = New System.Drawing.Size(209, 26)
        Me.txtNacionalidadPaciente.TabIndex = 12
        '
        'txtApellidosPaciente
        '
        Me.txtApellidosPaciente.Location = New System.Drawing.Point(531, 24)
        Me.txtApellidosPaciente.Name = "txtApellidosPaciente"
        Me.txtApellidosPaciente.Size = New System.Drawing.Size(288, 26)
        Me.txtApellidosPaciente.TabIndex = 11
        '
        'txtIdenPaciente
        '
        Me.txtIdenPaciente.Location = New System.Drawing.Point(138, 62)
        Me.txtIdenPaciente.Name = "txtIdenPaciente"
        Me.txtIdenPaciente.Size = New System.Drawing.Size(209, 26)
        Me.txtIdenPaciente.TabIndex = 10
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(138, 24)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(209, 26)
        Me.txtNombrePaciente.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(363, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha de nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nacionalidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado Civil"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de identificación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Identificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(363, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'btnAgregarPaciente
        '
        Me.btnAgregarPaciente.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarPaciente.Location = New System.Drawing.Point(134, 521)
        Me.btnAgregarPaciente.Name = "btnAgregarPaciente"
        Me.btnAgregarPaciente.Size = New System.Drawing.Size(247, 39)
        Me.btnAgregarPaciente.TabIndex = 3
        Me.btnAgregarPaciente.Text = "Agregar Nuevo Paciente"
        Me.btnAgregarPaciente.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(425, 521)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(133, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(240, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "¿Posee algún tipo de seguro médico?"
        '
        'cbSeguro
        '
        Me.cbSeguro.FormattingEnabled = True
        Me.cbSeguro.Items.AddRange(New Object() {"Sí", "No"})
        Me.cbSeguro.Location = New System.Drawing.Point(408, 25)
        Me.cbSeguro.Name = "cbSeguro"
        Me.cbSeguro.Size = New System.Drawing.Size(149, 24)
        Me.cbSeguro.TabIndex = 5
        Me.cbSeguro.Text = "No"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbSeguro)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 436)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(836, 68)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        '
        'AgregarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(862, 568)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAgregarPaciente)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AgregarPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AgregarPaciente"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCorreoPaciente As TextBox
    Friend WithEvents txtTelefonoPaciente As TextBox
    Friend WithEvents cbTipoCorreoPaciente As ComboBox
    Friend WithEvents cbTipoTelefonoPaciente As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents datePaciente As DateTimePicker
    Friend WithEvents cbEstadoCivilPaciente As ComboBox
    Friend WithEvents cbSexoPaciente As ComboBox
    Friend WithEvents cbTipoIdenPaciente As ComboBox
    Friend WithEvents txtNacionalidadPaciente As TextBox
    Friend WithEvents txtApellidosPaciente As TextBox
    Friend WithEvents txtIdenPaciente As TextBox
    Friend WithEvents txtNombrePaciente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarPaciente As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbDistrito As ComboBox
    Friend WithEvents cbCanton As ComboBox
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbSeguro As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
