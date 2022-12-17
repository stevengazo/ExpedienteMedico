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
        ActualizarPanelInformacion()
        ActualizarEnfermedad()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Bandera Then
            PanelEditable.BringToFront()
            PanelInfo.SendToBack()
            Bandera = False
            btnEditar.Text = "Actualizar Información"

        Else

            Enfe.Nombre = txtNombre.Text
            Enfe.Descripcion = txtDes.Text
            Enfe.sintomas = txtSin.Text
            Dim flag = tmpNegocioEnfermedad.ActualizarEnfermedad(Enfermedad)
            If flag Then
                PanelEditable.SendToBack()
                Bandera = True
                btnEditar.Text = "Editar información"
                ActualizarEnfermedad()
                ActualizarPanelInformacion()
                PanelInfo.BringToFront()
                MessageBox.Show("Enfermedad actualizada correctamente", "Información", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK)
            End If




        End If
    End Sub

    Private Sub ActualizarPanelInformacion()
        lblNombre.Text = Enfe.Nombre
        lblDes.Text = Enfermedad.Descripcion
        lblSin.Text = Enfermedad.sintomas
    End Sub

    Private Sub ActualizarEnfermedad()

        txtNombre.Text = Enfe.Nombre
        txtDes.Text = Enfe.Descripcion
        txtSin.Text = Enfe.sintomas
    End Sub
End Class