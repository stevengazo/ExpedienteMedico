<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarMedicamento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreMedicamento = New System.Windows.Forms.TextBox()
        Me.txtCasaFarmaceutica = New System.Windows.Forms.TextBox()
        Me.txtDescripcionMedicina = New System.Windows.Forms.TextBox()
        Me.btnAgregarMedicamento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(162, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar nuevo medicamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Casa Farmacéutica:"
        '
        'txtNombreMedicamento
        '
        Me.txtNombreMedicamento.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreMedicamento.Location = New System.Drawing.Point(324, 128)
        Me.txtNombreMedicamento.Name = "txtNombreMedicamento"
        Me.txtNombreMedicamento.Size = New System.Drawing.Size(420, 28)
        Me.txtNombreMedicamento.TabIndex = 9
        '
        'txtCasaFarmaceutica
        '
        Me.txtCasaFarmaceutica.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCasaFarmaceutica.Location = New System.Drawing.Point(324, 171)
        Me.txtCasaFarmaceutica.Name = "txtCasaFarmaceutica"
        Me.txtCasaFarmaceutica.Size = New System.Drawing.Size(420, 28)
        Me.txtCasaFarmaceutica.TabIndex = 10
        '
        'txtDescripcionMedicina
        '
        Me.txtDescripcionMedicina.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionMedicina.Location = New System.Drawing.Point(324, 218)
        Me.txtDescripcionMedicina.Name = "txtDescripcionMedicina"
        Me.txtDescripcionMedicina.Size = New System.Drawing.Size(420, 28)
        Me.txtDescripcionMedicina.TabIndex = 11
        '
        'btnAgregarMedicamento
        '
        Me.btnAgregarMedicamento.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarMedicamento.Location = New System.Drawing.Point(300, 286)
        Me.btnAgregarMedicamento.Name = "btnAgregarMedicamento"
        Me.btnAgregarMedicamento.Size = New System.Drawing.Size(204, 50)
        Me.btnAgregarMedicamento.TabIndex = 12
        Me.btnAgregarMedicamento.Text = "Agregar"
        Me.btnAgregarMedicamento.UseVisualStyleBackColor = False
        '
        'AgregarMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(795, 360)
        Me.Controls.Add(Me.btnAgregarMedicamento)
        Me.Controls.Add(Me.txtDescripcionMedicina)
        Me.Controls.Add(Me.txtCasaFarmaceutica)
        Me.Controls.Add(Me.txtNombreMedicamento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "AgregarMedicamento"
        Me.Text = "Agregar Medicamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreMedicamento As TextBox
    Friend WithEvents txtCasaFarmaceutica As TextBox
    Friend WithEvents txtDescripcionMedicina As TextBox
    Friend WithEvents btnAgregarMedicamento As Button
End Class
