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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAgregarPaciente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.txtDistritoPaciente = New System.Windows.Forms.TextBox()
        Me.txtIdenPaciente = New System.Windows.Forms.TextBox()
        Me.txtApellidosPaciente = New System.Windows.Forms.TextBox()
        Me.txtNacionalidadPaciente = New System.Windows.Forms.TextBox()
        Me.txtProvinciaPaciente = New System.Windows.Forms.TextBox()
        Me.txtCantonPaciente = New System.Windows.Forms.TextBox()
        Me.cbTipoIdenPaciente = New System.Windows.Forms.ComboBox()
        Me.cbSexoPaciente = New System.Windows.Forms.ComboBox()
        Me.cbEstadoCivilPaciente = New System.Windows.Forms.ComboBox()
        Me.datePaciente = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbTipoTelefonoPaciente = New System.Windows.Forms.ComboBox()
        Me.cbTipoCorreoPaciente = New System.Windows.Forms.ComboBox()
        Me.txtTelefonoPaciente = New System.Windows.Forms.TextBox()
        Me.txtCorreoPaciente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 687)
        Me.Panel1.TabIndex = 0
        '
        'btnAgregarPaciente
        '
        Me.btnAgregarPaciente.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarPaciente.Location = New System.Drawing.Point(619, 718)
        Me.btnAgregarPaciente.Name = "btnAgregarPaciente"
        Me.btnAgregarPaciente.Size = New System.Drawing.Size(247, 39)
        Me.btnAgregarPaciente.TabIndex = 3
        Me.btnAgregarPaciente.Text = "Agregar Nuevo Paciente"
        Me.btnAgregarPaciente.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
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
        Me.GroupBox1.Location = New System.Drawing.Point(20, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(903, 245)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Personal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtProvinciaPaciente)
        Me.GroupBox2.Controls.Add(Me.txtCantonPaciente)
        Me.GroupBox2.Controls.Add(Me.txtDistritoPaciente)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(20, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(903, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lugar de Residencia"
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
        Me.GroupBox3.Location = New System.Drawing.Point(20, 486)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(903, 174)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contactos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Identificación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de identificación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sexo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado Civil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nacionalidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha de nacimiento"
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(136, 31)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(209, 31)
        Me.txtNombrePaciente.TabIndex = 8
        '
        'txtDistritoPaciente
        '
        Me.txtDistritoPaciente.Location = New System.Drawing.Point(557, 34)
        Me.txtDistritoPaciente.Name = "txtDistritoPaciente"
        Me.txtDistritoPaciente.Size = New System.Drawing.Size(209, 31)
        Me.txtDistritoPaciente.TabIndex = 9
        '
        'txtIdenPaciente
        '
        Me.txtIdenPaciente.Location = New System.Drawing.Point(136, 79)
        Me.txtIdenPaciente.Name = "txtIdenPaciente"
        Me.txtIdenPaciente.Size = New System.Drawing.Size(209, 31)
        Me.txtIdenPaciente.TabIndex = 10
        '
        'txtApellidosPaciente
        '
        Me.txtApellidosPaciente.Location = New System.Drawing.Point(557, 30)
        Me.txtApellidosPaciente.Name = "txtApellidosPaciente"
        Me.txtApellidosPaciente.Size = New System.Drawing.Size(194, 31)
        Me.txtApellidosPaciente.TabIndex = 11
        '
        'txtNacionalidadPaciente
        '
        Me.txtNacionalidadPaciente.Location = New System.Drawing.Point(136, 171)
        Me.txtNacionalidadPaciente.Name = "txtNacionalidadPaciente"
        Me.txtNacionalidadPaciente.Size = New System.Drawing.Size(209, 31)
        Me.txtNacionalidadPaciente.TabIndex = 12
        '
        'txtProvinciaPaciente
        '
        Me.txtProvinciaPaciente.Location = New System.Drawing.Point(136, 41)
        Me.txtProvinciaPaciente.Name = "txtProvinciaPaciente"
        Me.txtProvinciaPaciente.Size = New System.Drawing.Size(209, 31)
        Me.txtProvinciaPaciente.TabIndex = 13
        '
        'txtCantonPaciente
        '
        Me.txtCantonPaciente.Location = New System.Drawing.Point(136, 94)
        Me.txtCantonPaciente.Name = "txtCantonPaciente"
        Me.txtCantonPaciente.Size = New System.Drawing.Size(209, 31)
        Me.txtCantonPaciente.TabIndex = 14
        '
        'cbTipoIdenPaciente
        '
        Me.cbTipoIdenPaciente.FormattingEnabled = True
        Me.cbTipoIdenPaciente.Items.AddRange(New Object() {"", "Nacional ", "DIMEX", "Pasaporte"})
        Me.cbTipoIdenPaciente.Location = New System.Drawing.Point(557, 79)
        Me.cbTipoIdenPaciente.Name = "cbTipoIdenPaciente"
        Me.cbTipoIdenPaciente.Size = New System.Drawing.Size(194, 29)
        Me.cbTipoIdenPaciente.TabIndex = 13
        '
        'cbSexoPaciente
        '
        Me.cbSexoPaciente.FormattingEnabled = True
        Me.cbSexoPaciente.Items.AddRange(New Object() {"", "Masculino", "Femenino", "Otro"})
        Me.cbSexoPaciente.Location = New System.Drawing.Point(136, 122)
        Me.cbSexoPaciente.Name = "cbSexoPaciente"
        Me.cbSexoPaciente.Size = New System.Drawing.Size(209, 29)
        Me.cbSexoPaciente.TabIndex = 14
        '
        'cbEstadoCivilPaciente
        '
        Me.cbEstadoCivilPaciente.FormattingEnabled = True
        Me.cbEstadoCivilPaciente.Items.AddRange(New Object() {"", "Soltero", "Casado", "Viudo", "Divorciado", "Unión Libre"})
        Me.cbEstadoCivilPaciente.Location = New System.Drawing.Point(557, 117)
        Me.cbEstadoCivilPaciente.Name = "cbEstadoCivilPaciente"
        Me.cbEstadoCivilPaciente.Size = New System.Drawing.Size(194, 29)
        Me.cbEstadoCivilPaciente.TabIndex = 15
        '
        'datePaciente
        '
        Me.datePaciente.Location = New System.Drawing.Point(557, 174)
        Me.datePaciente.Name = "datePaciente"
        Me.datePaciente.Size = New System.Drawing.Size(290, 31)
        Me.datePaciente.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Provincia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(443, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 21)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Distrito"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 21)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Cantón"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 21)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Número de teléfono"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 105)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(162, 21)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Correo electronico"
        '
        'cbTipoTelefonoPaciente
        '
        Me.cbTipoTelefonoPaciente.FormattingEnabled = True
        Me.cbTipoTelefonoPaciente.Items.AddRange(New Object() {"", "celular", "casa", "trabajo"})
        Me.cbTipoTelefonoPaciente.Location = New System.Drawing.Point(447, 42)
        Me.cbTipoTelefonoPaciente.Name = "cbTipoTelefonoPaciente"
        Me.cbTipoTelefonoPaciente.Size = New System.Drawing.Size(80, 29)
        Me.cbTipoTelefonoPaciente.TabIndex = 3
        '
        'cbTipoCorreoPaciente
        '
        Me.cbTipoCorreoPaciente.FormattingEnabled = True
        Me.cbTipoCorreoPaciente.Items.AddRange(New Object() {"", "casa", "trabajo", "personal"})
        Me.cbTipoCorreoPaciente.Location = New System.Drawing.Point(447, 97)
        Me.cbTipoCorreoPaciente.Name = "cbTipoCorreoPaciente"
        Me.cbTipoCorreoPaciente.Size = New System.Drawing.Size(80, 29)
        Me.cbTipoCorreoPaciente.TabIndex = 4
        '
        'txtTelefonoPaciente
        '
        Me.txtTelefonoPaciente.Location = New System.Drawing.Point(245, 40)
        Me.txtTelefonoPaciente.Name = "txtTelefonoPaciente"
        Me.txtTelefonoPaciente.Size = New System.Drawing.Size(165, 31)
        Me.txtTelefonoPaciente.TabIndex = 5
        '
        'txtCorreoPaciente
        '
        Me.txtCorreoPaciente.Location = New System.Drawing.Point(245, 97)
        Me.txtCorreoPaciente.Name = "txtCorreoPaciente"
        Me.txtCorreoPaciente.Size = New System.Drawing.Size(165, 31)
        Me.txtCorreoPaciente.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(62, 727)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(310, 21)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "¿Posee algún tipo de seguro médico?"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "Sí", "No"})
        Me.ComboBox1.Location = New System.Drawing.Point(389, 724)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 29)
        Me.ComboBox1.TabIndex = 5
        '
        'AgregarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(965, 769)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnAgregarPaciente)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AgregarPaciente"
        Me.Text = "AgregarPaciente"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents txtProvinciaPaciente As TextBox
    Friend WithEvents txtCantonPaciente As TextBox
    Friend WithEvents txtDistritoPaciente As TextBox
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
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
