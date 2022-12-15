<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarDiagnostico
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaSintomas = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEnfermedades = New System.Windows.Forms.ComboBox()
        Me.btnAgregarDiagnostico = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnAgregarDiagnostico)
        Me.GroupBox1.Controls.Add(Me.cbEnfermedades)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSintomas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese el diagnostico de la persona y la enfermedad que posee. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Puede ingresar " &
    "solamente una enfermedad al diagnostico"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de Inicio de Sintomas"
        '
        'dtpFechaSintomas
        '
        Me.dtpFechaSintomas.Location = New System.Drawing.Point(9, 70)
        Me.dtpFechaSintomas.Name = "dtpFechaSintomas"
        Me.dtpFechaSintomas.Size = New System.Drawing.Size(309, 20)
        Me.dtpFechaSintomas.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción "
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(9, 109)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(309, 61)
        Me.txtDescripcion.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enfermedad"
        '
        'cbEnfermedades
        '
        Me.cbEnfermedades.FormattingEnabled = True
        Me.cbEnfermedades.Location = New System.Drawing.Point(9, 190)
        Me.cbEnfermedades.Name = "cbEnfermedades"
        Me.cbEnfermedades.Size = New System.Drawing.Size(309, 21)
        Me.cbEnfermedades.TabIndex = 6
        '
        'btnAgregarDiagnostico
        '
        Me.btnAgregarDiagnostico.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAgregarDiagnostico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarDiagnostico.Location = New System.Drawing.Point(22, 229)
        Me.btnAgregarDiagnostico.Name = "btnAgregarDiagnostico"
        Me.btnAgregarDiagnostico.Size = New System.Drawing.Size(118, 23)
        Me.btnAgregarDiagnostico.TabIndex = 7
        Me.btnAgregarDiagnostico.Text = "Agregar"
        Me.btnAgregarDiagnostico.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DarkRed
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.Location = New System.Drawing.Point(170, 229)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(118, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'AgregarDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 301)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarDiagnostico"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Diagnostico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAgregarDiagnostico As Button
    Friend WithEvents cbEnfermedades As ComboBox
    Public WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As TextBox
    Public WithEvents Label3 As Label
    Friend WithEvents dtpFechaSintomas As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
