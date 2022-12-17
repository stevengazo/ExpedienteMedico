<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerEnfermedad
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
        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.lblSin = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelEditable = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSin = New System.Windows.Forms.TextBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PanelInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelEditable.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelInfo
        '
        Me.PanelInfo.BackColor = System.Drawing.SystemColors.Control
        Me.PanelInfo.Controls.Add(Me.GroupBox1)
        Me.PanelInfo.Controls.Add(Me.Label1)
        Me.PanelInfo.Location = New System.Drawing.Point(13, 13)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New System.Drawing.Size(775, 318)
        Me.PanelInfo.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDes)
        Me.GroupBox1.Controls.Add(Me.lblSin)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 222)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'lblDes
        '
        Me.lblDes.AutoSize = True
        Me.lblDes.Location = New System.Drawing.Point(120, 101)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(104, 18)
        Me.lblDes.TabIndex = 5
        Me.lblDes.Text = "____________"
        '
        'lblSin
        '
        Me.lblSin.AutoSize = True
        Me.lblSin.Location = New System.Drawing.Point(120, 157)
        Me.lblSin.Name = "lblSin"
        Me.lblSin.Size = New System.Drawing.Size(104, 18)
        Me.lblSin.TabIndex = 4
        Me.lblSin.Text = "____________"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(120, 46)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(104, 18)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "____________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descripción: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Síntomas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enfermedad"
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(24, 360)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(199, 39)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar información"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(238, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PanelEditable
        '
        Me.PanelEditable.BackColor = System.Drawing.SystemColors.Control
        Me.PanelEditable.Controls.Add(Me.GroupBox2)
        Me.PanelEditable.Controls.Add(Me.Label11)
        Me.PanelEditable.Location = New System.Drawing.Point(12, 13)
        Me.PanelEditable.Name = "PanelEditable"
        Me.PanelEditable.Size = New System.Drawing.Size(772, 315)
        Me.PanelEditable.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSin)
        Me.GroupBox2.Controls.Add(Me.txtDes)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 222)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información"
        '
        'txtSin
        '
        Me.txtSin.Location = New System.Drawing.Point(135, 151)
        Me.txtSin.Name = "txtSin"
        Me.txtSin.Size = New System.Drawing.Size(560, 24)
        Me.txtSin.TabIndex = 5
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(135, 95)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(560, 24)
        Me.txtDes.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(135, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(560, 24)
        Me.txtNombre.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Descripción: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 18)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Síntomas:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nombre: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 29)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Medicamento"
        '
        'VerEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 409)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.PanelInfo)
        Me.Controls.Add(Me.PanelEditable)
        Me.Name = "VerEnfermedad"
        Me.Text = "VerEnfermedad"
        Me.PanelInfo.ResumeLayout(False)
        Me.PanelInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelEditable.ResumeLayout(False)
        Me.PanelEditable.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelInfo As Panel
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDes As Label
    Friend WithEvents lblSin As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents PanelEditable As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSin As TextBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
