<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerPaciente
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
        Me.PanelInformación = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelEditable = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.PanelInformación.SuspendLayout()
        Me.PanelEditable.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelInformación
        '
        Me.PanelInformación.Controls.Add(Me.Label2)
        Me.PanelInformación.Location = New System.Drawing.Point(12, 12)
        Me.PanelInformación.Name = "PanelInformación"
        Me.PanelInformación.Size = New System.Drawing.Size(776, 377)
        Me.PanelInformación.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Paciente"
        '
        'PanelEditable
        '
        Me.PanelEditable.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PanelEditable.Controls.Add(Me.Label1)
        Me.PanelEditable.Location = New System.Drawing.Point(12, 12)
        Me.PanelEditable.Name = "PanelEditable"
        Me.PanelEditable.Size = New System.Drawing.Size(776, 377)
        Me.PanelEditable.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Editar la Información"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(12, 415)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(126, 23)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar Información"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'VerPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.PanelInformación)
        Me.Controls.Add(Me.PanelEditable)
        Me.Name = "VerPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de Paciente"
        Me.PanelInformación.ResumeLayout(False)
        Me.PanelInformación.PerformLayout()
        Me.PanelEditable.ResumeLayout(False)
        Me.PanelEditable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelInformación As Panel
    Friend WithEvents PanelEditable As Panel
    Friend WithEvents btnEditar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
