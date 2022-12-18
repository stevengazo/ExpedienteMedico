Public Class VerMedicamento

    Private Sub VerMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInformacion()
    End Sub

    Private Sub CargarInformacion()
        Try
            Dim medicamento = TEMPORAL.Medicamento

            lblCasaFarmaceutica.Text = medicamento.CasaFarmaceutica
            lblNombre.Text = medicamento.Nombre
            lblDescripcion.Text = medicamento.Descripcion
            lblIdMedicamento.Text = medicamento.idMedicamento
        Catch ex As Exception
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class