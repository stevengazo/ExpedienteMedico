<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerEnfermedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerEnfermedades))
        Me.txtEliminarMedico = New System.Windows.Forms.Button()
        Me.txtModificarMedico = New System.Windows.Forms.Button()
        Me.dgListaMedicos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgListaMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEliminarMedico
        '
        Me.txtEliminarMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEliminarMedico.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEliminarMedico.Location = New System.Drawing.Point(519, 490)
        Me.txtEliminarMedico.Name = "txtEliminarMedico"
        Me.txtEliminarMedico.Size = New System.Drawing.Size(179, 44)
        Me.txtEliminarMedico.TabIndex = 9
        Me.txtEliminarMedico.Text = "Eliminar"
        Me.txtEliminarMedico.UseVisualStyleBackColor = False
        '
        'txtModificarMedico
        '
        Me.txtModificarMedico.BackColor = System.Drawing.Color.SteelBlue
        Me.txtModificarMedico.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModificarMedico.Location = New System.Drawing.Point(275, 490)
        Me.txtModificarMedico.Name = "txtModificarMedico"
        Me.txtModificarMedico.Size = New System.Drawing.Size(179, 44)
        Me.txtModificarMedico.TabIndex = 8
        Me.txtModificarMedico.Text = "Modificar"
        Me.txtModificarMedico.UseVisualStyleBackColor = False
        '
        'dgListaMedicos
        '
        Me.dgListaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListaMedicos.Location = New System.Drawing.Point(122, 170)
        Me.dgListaMedicos.Margin = New System.Windows.Forms.Padding(8)
        Me.dgListaMedicos.Name = "dgListaMedicos"
        Me.dgListaMedicos.RowHeadersWidth = 51
        Me.dgListaMedicos.RowTemplate.Height = 24
        Me.dgListaMedicos.Size = New System.Drawing.Size(733, 276)
        Me.dgListaMedicos.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(228, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Lista de Enfermedades"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.interfaz.My.Resources.Resources.enfe
        Me.PictureBox1.Location = New System.Drawing.Point(656, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'VerEnfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(976, 570)
        Me.Controls.Add(Me.txtEliminarMedico)
        Me.Controls.Add(Me.txtModificarMedico)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgListaMedicos)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VerEnfermedades"
        Me.Text = "Enfermedades"
        CType(Me.dgListaMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEliminarMedico As Button
    Friend WithEvents txtModificarMedico As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgListaMedicos As DataGridView
    Friend WithEvents Label1 As Label
End Class
