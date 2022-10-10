<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpedientePaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpedientePaciente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.btnModificarInfoPaciente = New System.Windows.Forms.Button()
        Me.btnModificarEnfermedades = New System.Windows.Forms.Button()
        Me.btnAgregarEnfermedad = New System.Windows.Forms.Button()
        Me.btnAgregarMedico = New System.Windows.Forms.Button()
        Me.btnAgregarMedicamento = New System.Windows.Forms.Button()
        Me.btnModificarMedicamentos = New System.Windows.Forms.Button()
        Me.btnEditarCitas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(33, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1004, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Personal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(33, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1004, 172)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enfermedades"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView5)
        Me.GroupBox3.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(33, 347)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1004, 164)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del médico que lo atendió"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView4)
        Me.GroupBox4.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(33, 517)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1004, 178)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Medicamentos recetados"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView3)
        Me.GroupBox5.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(33, 701)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1004, 164)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Citas médicas agendadas "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(955, 107)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(21, 33)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(955, 115)
        Me.DataGridView2.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(25, 35)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(955, 109)
        Me.DataGridView3.TabIndex = 1
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(25, 42)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(955, 115)
        Me.DataGridView4.TabIndex = 2
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(25, 21)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(955, 115)
        Me.DataGridView5.TabIndex = 3
        '
        'btnModificarInfoPaciente
        '
        Me.btnModificarInfoPaciente.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModificarInfoPaciente.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarInfoPaciente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarInfoPaciente.Location = New System.Drawing.Point(1075, 69)
        Me.btnModificarInfoPaciente.Name = "btnModificarInfoPaciente"
        Me.btnModificarInfoPaciente.Size = New System.Drawing.Size(145, 47)
        Me.btnModificarInfoPaciente.TabIndex = 5
        Me.btnModificarInfoPaciente.Text = "Editar Información"
        Me.btnModificarInfoPaciente.UseVisualStyleBackColor = False
        '
        'btnModificarEnfermedades
        '
        Me.btnModificarEnfermedades.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModificarEnfermedades.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarEnfermedades.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarEnfermedades.Location = New System.Drawing.Point(1075, 213)
        Me.btnModificarEnfermedades.Name = "btnModificarEnfermedades"
        Me.btnModificarEnfermedades.Size = New System.Drawing.Size(145, 50)
        Me.btnModificarEnfermedades.TabIndex = 6
        Me.btnModificarEnfermedades.Text = "Editar Enfermedades"
        Me.btnModificarEnfermedades.UseVisualStyleBackColor = False
        '
        'btnAgregarEnfermedad
        '
        Me.btnAgregarEnfermedad.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarEnfermedad.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEnfermedad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarEnfermedad.Location = New System.Drawing.Point(1075, 269)
        Me.btnAgregarEnfermedad.Name = "btnAgregarEnfermedad"
        Me.btnAgregarEnfermedad.Size = New System.Drawing.Size(145, 48)
        Me.btnAgregarEnfermedad.TabIndex = 7
        Me.btnAgregarEnfermedad.Text = "Agregar Enfermedades"
        Me.btnAgregarEnfermedad.UseVisualStyleBackColor = False
        '
        'btnAgregarMedico
        '
        Me.btnAgregarMedico.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarMedico.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMedico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarMedico.Location = New System.Drawing.Point(1075, 403)
        Me.btnAgregarMedico.Name = "btnAgregarMedico"
        Me.btnAgregarMedico.Size = New System.Drawing.Size(145, 51)
        Me.btnAgregarMedico.TabIndex = 8
        Me.btnAgregarMedico.Text = "Agregar médico"
        Me.btnAgregarMedico.UseVisualStyleBackColor = False
        '
        'btnAgregarMedicamento
        '
        Me.btnAgregarMedicamento.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarMedicamento.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMedicamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarMedicamento.Location = New System.Drawing.Point(1075, 619)
        Me.btnAgregarMedicamento.Name = "btnAgregarMedicamento"
        Me.btnAgregarMedicamento.Size = New System.Drawing.Size(145, 44)
        Me.btnAgregarMedicamento.TabIndex = 9
        Me.btnAgregarMedicamento.Text = "Agregar Medicamentos"
        Me.btnAgregarMedicamento.UseVisualStyleBackColor = False
        '
        'btnModificarMedicamentos
        '
        Me.btnModificarMedicamentos.BackColor = System.Drawing.Color.SteelBlue
        Me.btnModificarMedicamentos.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarMedicamentos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarMedicamentos.Location = New System.Drawing.Point(1075, 559)
        Me.btnModificarMedicamentos.Name = "btnModificarMedicamentos"
        Me.btnModificarMedicamentos.Size = New System.Drawing.Size(145, 44)
        Me.btnModificarMedicamentos.TabIndex = 10
        Me.btnModificarMedicamentos.Text = "Editar Medicamentos"
        Me.btnModificarMedicamentos.UseVisualStyleBackColor = False
        '
        'btnEditarCitas
        '
        Me.btnEditarCitas.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditarCitas.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarCitas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditarCitas.Location = New System.Drawing.Point(1075, 765)
        Me.btnEditarCitas.Name = "btnEditarCitas"
        Me.btnEditarCitas.Size = New System.Drawing.Size(145, 46)
        Me.btnEditarCitas.TabIndex = 11
        Me.btnEditarCitas.Text = "Agregar Citas"
        Me.btnEditarCitas.UseVisualStyleBackColor = False
        '
        'ExpedientePaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1251, 877)
        Me.Controls.Add(Me.btnEditarCitas)
        Me.Controls.Add(Me.btnModificarMedicamentos)
        Me.Controls.Add(Me.btnAgregarMedicamento)
        Me.Controls.Add(Me.btnAgregarMedico)
        Me.Controls.Add(Me.btnAgregarEnfermedad)
        Me.Controls.Add(Me.btnModificarEnfermedades)
        Me.Controls.Add(Me.btnModificarInfoPaciente)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExpedientePaciente"
        Me.Text = "Expediente Médico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnModificarInfoPaciente As Button
    Friend WithEvents btnModificarEnfermedades As Button
    Friend WithEvents btnAgregarEnfermedad As Button
    Friend WithEvents btnAgregarMedico As Button
    Friend WithEvents btnAgregarMedicamento As Button
    Friend WithEvents btnModificarMedicamentos As Button
    Friend WithEvents btnEditarCitas As Button
End Class
