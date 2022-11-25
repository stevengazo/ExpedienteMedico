<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerMedicamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerMedicamentos))
        Me.txtEliminarMedicamento = New System.Windows.Forms.Button()
        Me.txtModificarMedicamento = New System.Windows.Forms.Button()
        Me.dgListaMedicamentos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgListaMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEliminarMedicamento
        '
        Me.txtEliminarMedicamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEliminarMedicamento.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEliminarMedicamento.Location = New System.Drawing.Point(496, 492)
        Me.txtEliminarMedicamento.Name = "txtEliminarMedicamento"
        Me.txtEliminarMedicamento.Size = New System.Drawing.Size(179, 44)
        Me.txtEliminarMedicamento.TabIndex = 9
        Me.txtEliminarMedicamento.Text = "Eliminar"
        Me.txtEliminarMedicamento.UseVisualStyleBackColor = False
        '
        'txtModificarMedicamento
        '
        Me.txtModificarMedicamento.BackColor = System.Drawing.Color.SteelBlue
        Me.txtModificarMedicamento.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificarMedicamento.Location = New System.Drawing.Point(252, 492)
        Me.txtModificarMedicamento.Name = "txtModificarMedicamento"
        Me.txtModificarMedicamento.Size = New System.Drawing.Size(179, 44)
        Me.txtModificarMedicamento.TabIndex = 8
        Me.txtModificarMedicamento.Text = "Modificar"
        Me.txtModificarMedicamento.UseVisualStyleBackColor = False
        '
        'dgListaMedicamentos
        '
        Me.dgListaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListaMedicamentos.Location = New System.Drawing.Point(99, 172)
        Me.dgListaMedicamentos.Margin = New System.Windows.Forms.Padding(8)
        Me.dgListaMedicamentos.Name = "dgListaMedicamentos"
        Me.dgListaMedicamentos.RowHeadersWidth = 51
        Me.dgListaMedicamentos.RowTemplate.Height = 24
        Me.dgListaMedicamentos.Size = New System.Drawing.Size(733, 276)
        Me.dgListaMedicamentos.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Inventario de Medicamentos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.interfaz.My.Resources.Resources.pastilla
        Me.PictureBox1.Location = New System.Drawing.Point(652, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'VerMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(931, 574)
        Me.Controls.Add(Me.txtEliminarMedicamento)
        Me.Controls.Add(Me.txtModificarMedicamento)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgListaMedicamentos)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "VerMedicamentos"
        Me.Text = "Inventario de Medicamentos"
        CType(Me.dgListaMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEliminarMedicamento As Button
    Friend WithEvents txtModificarMedicamento As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgListaMedicamentos As DataGridView
    Friend WithEvents Label1 As Label
End Class
