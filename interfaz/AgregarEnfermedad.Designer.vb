<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEnfermedad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarEnfermedad))
        Me.txtDescripcionEnfermedad = New System.Windows.Forms.TextBox()
        Me.txtNombreEnfermedad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarEnfermedad = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.txtSintomas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDescripcionEnfermedad
        '
        Me.txtDescripcionEnfermedad.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionEnfermedad.Location = New System.Drawing.Point(211, 168)
        Me.txtDescripcionEnfermedad.Name = "txtDescripcionEnfermedad"
        Me.txtDescripcionEnfermedad.Size = New System.Drawing.Size(420, 28)
        Me.txtDescripcionEnfermedad.TabIndex = 15
        '
        'txtNombreEnfermedad
        '
        Me.txtNombreEnfermedad.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEnfermedad.Location = New System.Drawing.Point(211, 126)
        Me.txtNombreEnfermedad.Name = "txtNombreEnfermedad"
        Me.txtNombreEnfermedad.Size = New System.Drawing.Size(420, 28)
        Me.txtNombreEnfermedad.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(52, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(52, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(143, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Agregar nueva enfermedad"
        '
        'btnAgregarEnfermedad
        '
        Me.btnAgregarEnfermedad.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarEnfermedad.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEnfermedad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarEnfermedad.Location = New System.Drawing.Point(264, 282)
        Me.btnAgregarEnfermedad.Name = "btnAgregarEnfermedad"
        Me.btnAgregarEnfermedad.Size = New System.Drawing.Size(204, 50)
        Me.btnAgregarEnfermedad.TabIndex = 16
        Me.btnAgregarEnfermedad.Text = "Agregar"
        Me.btnAgregarEnfermedad.UseVisualStyleBackColor = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=LAPTOP-B2U83SJU\SQLEXPRESS;Initial Catalog=Proyecto_Hospital;Integrat" &
    "ed Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'txtSintomas
        '
        Me.txtSintomas.Font = New System.Drawing.Font("Mongolian Baiti", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSintomas.Location = New System.Drawing.Point(211, 212)
        Me.txtSintomas.Name = "txtSintomas"
        Me.txtSintomas.Size = New System.Drawing.Size(420, 28)
        Me.txtSintomas.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(52, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Síntomas:"
        '
        'AgregarEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(718, 374)
        Me.Controls.Add(Me.txtSintomas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregarEnfermedad)
        Me.Controls.Add(Me.txtDescripcionEnfermedad)
        Me.Controls.Add(Me.txtNombreEnfermedad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarEnfermedad"
        Me.Text = "Agregar Enfermedad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescripcionEnfermedad As TextBox
    Friend WithEvents txtNombreEnfermedad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarEnfermedad As Button
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents txtSintomas As TextBox
    Friend WithEvents Label3 As Label
End Class
