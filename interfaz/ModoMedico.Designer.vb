<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModoMedico
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeEnfermedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEnfermedadesRegistradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerMedicamentosDisponiblesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitasRegistradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.ListaDeEnfermedadesToolStripMenuItem, Me.MedicamentosToolStripMenuItem, Me.CitasRegistradasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarPacienteToolStripMenuItem})
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'BuscarPacienteToolStripMenuItem
        '
        Me.BuscarPacienteToolStripMenuItem.Name = "BuscarPacienteToolStripMenuItem"
        Me.BuscarPacienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BuscarPacienteToolStripMenuItem.Text = "Buscar Paciente"
        '
        'ListaDeEnfermedadesToolStripMenuItem
        '
        Me.ListaDeEnfermedadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerEnfermedadesRegistradasToolStripMenuItem})
        Me.ListaDeEnfermedadesToolStripMenuItem.Name = "ListaDeEnfermedadesToolStripMenuItem"
        Me.ListaDeEnfermedadesToolStripMenuItem.Size = New System.Drawing.Size(137, 20)
        Me.ListaDeEnfermedadesToolStripMenuItem.Text = "Lista de Enfermedades"
        '
        'VerEnfermedadesRegistradasToolStripMenuItem
        '
        Me.VerEnfermedadesRegistradasToolStripMenuItem.Name = "VerEnfermedadesRegistradasToolStripMenuItem"
        Me.VerEnfermedadesRegistradasToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.VerEnfermedadesRegistradasToolStripMenuItem.Text = "Ver Enfermedades Registradas"
        '
        'MedicamentosToolStripMenuItem
        '
        Me.MedicamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerMedicamentosDisponiblesToolStripMenuItem})
        Me.MedicamentosToolStripMenuItem.Name = "MedicamentosToolStripMenuItem"
        Me.MedicamentosToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.MedicamentosToolStripMenuItem.Text = "Medicamentos"
        '
        'VerMedicamentosDisponiblesToolStripMenuItem
        '
        Me.VerMedicamentosDisponiblesToolStripMenuItem.Name = "VerMedicamentosDisponiblesToolStripMenuItem"
        Me.VerMedicamentosDisponiblesToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.VerMedicamentosDisponiblesToolStripMenuItem.Text = "Ver Medicamentos Disponibles"
        '
        'CitasRegistradasToolStripMenuItem
        '
        Me.CitasRegistradasToolStripMenuItem.Name = "CitasRegistradasToolStripMenuItem"
        Me.CitasRegistradasToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.CitasRegistradasToolStripMenuItem.Text = "Citas Registradas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 411)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Medico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Medico"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Medico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Medico"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(109, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Medico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Medico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Medico"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Medico"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(9, 209)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(208, 97)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Especialidades Registradas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ModoMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ModoMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModoMedico"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeEnfermedadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerEnfermedadesRegistradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerMedicamentosDisponiblesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CitasRegistradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
End Class
