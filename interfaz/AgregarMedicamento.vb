Imports Objetos
Imports Negocio
Public Class AgregarMedicamento
    Private _Medicamento As New Negocio.Medicamento()
    Private Sub btnAgregarMedicamento_Click(sender As Object, e As EventArgs) Handles btnAgregarMedicamento.Click
        Try
            Dim medicamento As New Objetos.Medicamento()
            medicamento.Nombre = txtNombreMedicamento.Text
            medicamento.CasaFarmaceutica = txtCasaFarmaceutica.Text
            medicamento.Descripcion = txtDescripcionMedicina.Text
            Dim id = _Medicamento.AgregarMedicamento(medicamento)
            If id <> 0 Then
                MessageBox.Show("Medicamento Agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNombreMedicamento.Text = String.Empty
                txtCasaFarmaceutica.Text = String.Empty
                txtDescripcionMedicina.Text = String.Empty
                Me.Close()
            Else
                MessageBox.Show("Error interno", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error")
        End Try
    End Sub

End Class