<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerDiagnostico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSintomasEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEnfermedadNombre = New System.Windows.Forms.Label()
        Me.lblFechaSintomas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcionDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcionEnfermedad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSintomasEnfermedad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblEnfermedadNombre)
        Me.GroupBox1.Controls.Add(Me.lblFechaSintomas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDescripcionDiagnostico)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 363)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtDescripcionEnfermedad
        '
        Me.txtDescripcionEnfermedad.Location = New System.Drawing.Point(13, 286)
        Me.txtDescripcionEnfermedad.Multiline = True
        Me.txtDescripcionEnfermedad.Name = "txtDescripcionEnfermedad"
        Me.txtDescripcionEnfermedad.Size = New System.Drawing.Size(293, 61)
        Me.txtDescripcionEnfermedad.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Descripcion"
        '
        'txtSintomasEnfermedad
        '
        Me.txtSintomasEnfermedad.Location = New System.Drawing.Point(12, 204)
        Me.txtSintomasEnfermedad.Multiline = True
        Me.txtSintomasEnfermedad.Name = "txtSintomasEnfermedad"
        Me.txtSintomasEnfermedad.Size = New System.Drawing.Size(293, 61)
        Me.txtSintomasEnfermedad.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Sintomas"
        '
        'lblEnfermedadNombre
        '
        Me.lblEnfermedadNombre.AutoSize = True
        Me.lblEnfermedadNombre.Location = New System.Drawing.Point(9, 163)
        Me.lblEnfermedadNombre.Name = "lblEnfermedadNombre"
        Me.lblEnfermedadNombre.Size = New System.Drawing.Size(39, 13)
        Me.lblEnfermedadNombre.TabIndex = 10
        Me.lblEnfermedadNombre.Text = "Label1"
        '
        'lblFechaSintomas
        '
        Me.lblFechaSintomas.AutoSize = True
        Me.lblFechaSintomas.Location = New System.Drawing.Point(6, 39)
        Me.lblFechaSintomas.Name = "lblFechaSintomas"
        Me.lblFechaSintomas.Size = New System.Drawing.Size(39, 13)
        Me.lblFechaSintomas.TabIndex = 9
        Me.lblFechaSintomas.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enfermedad"
        '
        'txtDescripcionDiagnostico
        '
        Me.txtDescripcionDiagnostico.Location = New System.Drawing.Point(9, 82)
        Me.txtDescripcionDiagnostico.Multiline = True
        Me.txtDescripcionDiagnostico.Name = "txtDescripcionDiagnostico"
        Me.txtDescripcionDiagnostico.Size = New System.Drawing.Size(296, 61)
        Me.txtDescripcionDiagnostico.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Descripción "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de Inicio de Sintomas"
        '
        'VerDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 387)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerDiagnostico"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Diagnostico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents Label4 As Label
    Friend WithEvents txtDescripcionDiagnostico As TextBox
    Public WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEnfermedadNombre As Label
    Friend WithEvents lblFechaSintomas As Label
    Friend WithEvents txtDescripcionEnfermedad As TextBox
    Public WithEvents Label5 As Label
    Friend WithEvents txtSintomasEnfermedad As TextBox
    Public WithEvents Label1 As Label
End Class
