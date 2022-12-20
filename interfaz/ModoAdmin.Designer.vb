<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModoAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModoAdmin))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MédicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerInformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarMédicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnfermedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListaDeEnfermedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUnaEnfermedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerListaDeMedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarMedicamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioMedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSucursales = New System.Windows.Forms.Label()
        Me.dgvSucursales = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMedicos = New System.Windows.Forms.Label()
        Me.dgvMedicos = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPacientes = New System.Windows.Forms.Label()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MédicosToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.EnfermedadesToolStripMenuItem, Me.MedicamentosToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(781, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MédicosToolStripMenuItem
        '
        Me.MédicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerInformaciónToolStripMenuItem, Me.AgregarMédicoToolStripMenuItem})
        Me.MédicosToolStripMenuItem.Name = "MédicosToolStripMenuItem"
        Me.MédicosToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.MédicosToolStripMenuItem.Text = "Médicos"
        '
        'VerInformaciónToolStripMenuItem
        '
        Me.VerInformaciónToolStripMenuItem.Name = "VerInformaciónToolStripMenuItem"
        Me.VerInformaciónToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.VerInformaciónToolStripMenuItem.Text = "Ver lista de médicos"
        '
        'AgregarMédicoToolStripMenuItem
        '
        Me.AgregarMédicoToolStripMenuItem.Name = "AgregarMédicoToolStripMenuItem"
        Me.AgregarMédicoToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.AgregarMédicoToolStripMenuItem.Text = "Agregar Médico"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPacientesToolStripMenuItem, Me.AgregarPacienteToolStripMenuItem})
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'VerPacientesToolStripMenuItem
        '
        Me.VerPacientesToolStripMenuItem.Name = "VerPacientesToolStripMenuItem"
        Me.VerPacientesToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.VerPacientesToolStripMenuItem.Text = "Ver lista de pacientes"
        '
        'AgregarPacienteToolStripMenuItem
        '
        Me.AgregarPacienteToolStripMenuItem.Name = "AgregarPacienteToolStripMenuItem"
        Me.AgregarPacienteToolStripMenuItem.Size = New System.Drawing.Size(238, 24)
        Me.AgregarPacienteToolStripMenuItem.Text = "Agregar Paciente "
        '
        'EnfermedadesToolStripMenuItem
        '
        Me.EnfermedadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerListaDeEnfermedadesToolStripMenuItem, Me.AgregarUnaEnfermedadToolStripMenuItem})
        Me.EnfermedadesToolStripMenuItem.Name = "EnfermedadesToolStripMenuItem"
        Me.EnfermedadesToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.EnfermedadesToolStripMenuItem.Text = "Enfermedades"
        '
        'VerListaDeEnfermedadesToolStripMenuItem
        '
        Me.VerListaDeEnfermedadesToolStripMenuItem.Name = "VerListaDeEnfermedadesToolStripMenuItem"
        Me.VerListaDeEnfermedadesToolStripMenuItem.Size = New System.Drawing.Size(273, 24)
        Me.VerListaDeEnfermedadesToolStripMenuItem.Text = "Ver lista de enfermedades"
        '
        'AgregarUnaEnfermedadToolStripMenuItem
        '
        Me.AgregarUnaEnfermedadToolStripMenuItem.Name = "AgregarUnaEnfermedadToolStripMenuItem"
        Me.AgregarUnaEnfermedadToolStripMenuItem.Size = New System.Drawing.Size(273, 24)
        Me.AgregarUnaEnfermedadToolStripMenuItem.Text = "Agregar una enfermedad"
        '
        'MedicamentosToolStripMenuItem
        '
        Me.MedicamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerListaDeMedicamentosToolStripMenuItem, Me.AgregarMedicamentoToolStripMenuItem, Me.InventarioMedicamentosToolStripMenuItem})
        Me.MedicamentosToolStripMenuItem.Name = "MedicamentosToolStripMenuItem"
        Me.MedicamentosToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.MedicamentosToolStripMenuItem.Text = "Medicamentos"
        '
        'VerListaDeMedicamentosToolStripMenuItem
        '
        Me.VerListaDeMedicamentosToolStripMenuItem.Name = "VerListaDeMedicamentosToolStripMenuItem"
        Me.VerListaDeMedicamentosToolStripMenuItem.Size = New System.Drawing.Size(278, 24)
        Me.VerListaDeMedicamentosToolStripMenuItem.Text = "Ver lista de medicamentos"
        '
        'AgregarMedicamentoToolStripMenuItem
        '
        Me.AgregarMedicamentoToolStripMenuItem.Name = "AgregarMedicamentoToolStripMenuItem"
        Me.AgregarMedicamentoToolStripMenuItem.Size = New System.Drawing.Size(278, 24)
        Me.AgregarMedicamentoToolStripMenuItem.Text = "Agregar medicamento"
        '
        'InventarioMedicamentosToolStripMenuItem
        '
        Me.InventarioMedicamentosToolStripMenuItem.Name = "InventarioMedicamentosToolStripMenuItem"
        Me.InventarioMedicamentosToolStripMenuItem.Size = New System.Drawing.Size(278, 24)
        Me.InventarioMedicamentosToolStripMenuItem.Text = "Inventario Medicamentos"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSucursales)
        Me.GroupBox1.Controls.Add(Me.dgvSucursales)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 150)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sucursales"
        '
        'lblSucursales
        '
        Me.lblSucursales.AutoSize = True
        Me.lblSucursales.Location = New System.Drawing.Point(6, 36)
        Me.lblSucursales.Name = "lblSucursales"
        Me.lblSucursales.Size = New System.Drawing.Size(39, 13)
        Me.lblSucursales.TabIndex = 3
        Me.lblSucursales.Text = "Label3"
        '
        'dgvSucursales
        '
        Me.dgvSucursales.AllowUserToAddRows = False
        Me.dgvSucursales.AllowUserToDeleteRows = False
        Me.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursales.Location = New System.Drawing.Point(6, 52)
        Me.dgvSucursales.Name = "dgvSucursales"
        Me.dgvSucursales.ReadOnly = True
        Me.dgvSucursales.Size = New System.Drawing.Size(325, 92)
        Me.dgvSucursales.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMedicos)
        Me.GroupBox2.Controls.Add(Me.dgvMedicos)
        Me.GroupBox2.Location = New System.Drawing.Point(166, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 156)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Médicos Existentes"
        '
        'lblMedicos
        '
        Me.lblMedicos.AutoSize = True
        Me.lblMedicos.Location = New System.Drawing.Point(8, 24)
        Me.lblMedicos.Name = "lblMedicos"
        Me.lblMedicos.Size = New System.Drawing.Size(39, 13)
        Me.lblMedicos.TabIndex = 5
        Me.lblMedicos.Text = "Label5"
        '
        'dgvMedicos
        '
        Me.dgvMedicos.AllowUserToAddRows = False
        Me.dgvMedicos.AllowUserToDeleteRows = False
        Me.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicos.Location = New System.Drawing.Point(8, 40)
        Me.dgvMedicos.Name = "dgvMedicos"
        Me.dgvMedicos.ReadOnly = True
        Me.dgvMedicos.Size = New System.Drawing.Size(361, 110)
        Me.dgvMedicos.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblPacientes)
        Me.GroupBox4.Controls.Add(Me.dgvPacientes)
        Me.GroupBox4.Location = New System.Drawing.Point(351, 77)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(377, 156)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pacientes"
        '
        'lblPacientes
        '
        Me.lblPacientes.AutoSize = True
        Me.lblPacientes.Location = New System.Drawing.Point(6, 36)
        Me.lblPacientes.Name = "lblPacientes"
        Me.lblPacientes.Size = New System.Drawing.Size(39, 13)
        Me.lblPacientes.TabIndex = 2
        Me.lblPacientes.Text = "Label2"
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AllowUserToAddRows = False
        Me.dgvPacientes.AllowUserToDeleteRows = False
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(6, 52)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.Size = New System.Drawing.Size(365, 98)
        Me.dgvPacientes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Este sistema permite el registro de pacientes  y algunos aspectos básicos relacio" &
    "nados con ellos "
        '
        'ModoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(781, 438)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ModoAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modo Administrador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MédicosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerInformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarMédicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnfermedadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListaDeEnfermedadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUnaEnfermedadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerListaDeMedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarMedicamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioMedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSucursales As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvMedicos As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSucursales As Label
    Friend WithEvents lblMedicos As Label
    Friend WithEvents lblPacientes As Label
End Class
