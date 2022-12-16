Imports Negocio
Imports Objetos
Public Class VerEnfermedad
    Dim tmpNegocioEnfermedad As New Negocio.EnfermedadNegocio()
    Dim Enfe As New Objetos.Enfermedad()
    Dim Bandera As Boolean = True
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub VerEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enfe = TEMPORAL.Enfermedad
        'ActualizarPanelInformacion()
        ActualizarEnfermedad()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Bandera Then
            PanelEditable.Show()
            PanelInfo.Hide()
            Bandera = False
            btnEditar.Text = "Actualizar Información"
        Else
            PanelEditable.Hide()
            Bandera = True
            btnEditar.Text = "Editar información"
            ActualizarEnfermedad()
            'ActualizarPanelInformacion()
            PanelInfo.Show()
        End If
    End Sub

    'Private Sub ActualizarPanelInformacion()
    '    lblNombre.Text = Enfe.Nombre
    '    lblDes.Text = Enfermedad.Descripcion
    '    lblSin.Text = Enfermedad.sintomas
    'End Sub

    Private Sub ActualizarEnfermedad()

        txtNombre.Text = Enfe.Nombre
        txtDes.Text = Enfe.Descripcion
        txtSin.Text = Enfe.sintomas
    End Sub
End Class