<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medicos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExpediente = New System.Windows.Forms.Button()
        Me.btnAgregarPaciente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEliminarPaciente = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(2, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 430)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(19, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Información de pacientes registrados"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(900, 376)
        Me.DataGridView1.TabIndex = 0
        '
        'btnExpediente
        '
        Me.btnExpediente.BackColor = System.Drawing.Color.SteelBlue
        Me.btnExpediente.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpediente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExpediente.Location = New System.Drawing.Point(68, 527)
        Me.btnExpediente.Name = "btnExpediente"
        Me.btnExpediente.Size = New System.Drawing.Size(173, 48)
        Me.btnExpediente.TabIndex = 1
        Me.btnExpediente.Text = "Abrir expediente"
        Me.btnExpediente.UseVisualStyleBackColor = False
        '
        'btnAgregarPaciente
        '
        Me.btnAgregarPaciente.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarPaciente.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPaciente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarPaciente.Location = New System.Drawing.Point(385, 527)
        Me.btnAgregarPaciente.Name = "btnAgregarPaciente"
        Me.btnAgregarPaciente.Size = New System.Drawing.Size(187, 48)
        Me.btnAgregarPaciente.TabIndex = 2
        Me.btnAgregarPaciente.Text = "Agregar nuevo paciente"
        Me.btnAgregarPaciente.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(422, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Módulo de Médicos"
        '
        'btnEliminarPaciente
        '
        Me.btnEliminarPaciente.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEliminarPaciente.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPaciente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarPaciente.Location = New System.Drawing.Point(678, 527)
        Me.btnEliminarPaciente.Name = "btnEliminarPaciente"
        Me.btnEliminarPaciente.Size = New System.Drawing.Size(160, 48)
        Me.btnEliminarPaciente.TabIndex = 4
        Me.btnEliminarPaciente.Text = "Eliminar paciente"
        Me.btnEliminarPaciente.UseVisualStyleBackColor = False
        '
        'Medicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(921, 609)
        Me.Controls.Add(Me.btnEliminarPaciente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarPaciente)
        Me.Controls.Add(Me.btnExpediente)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Medicos"
        Me.Text = "Módulo Médicos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExpediente As Button
    Friend WithEvents btnAgregarPaciente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEliminarPaciente As Button
End Class
