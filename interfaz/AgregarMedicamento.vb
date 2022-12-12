Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Negocio
Imports Objetos
Public Class AgregarMedicamento
    Private Sub AgregarMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private objMedicamento As New Objetos.Medicamento
    Private Sub btnAgregarMedicamento_Click(sender As Object, e As EventArgs) Handles btnAgregarMedicamento.Click

        Try
            'obtener los valores de la UI
            Dim medi As New Medicamento()

            objMedicamento.Nombre = txtNombreMedicamento.Text
            objMedicamento.CasaFarmaceutica = txtCasaFarmaceutica.Text
            objMedicamento.Descripcion = txtDescripcionMedicina.Text

            If String.IsNullOrEmpty(objMedicamento.Nombre) Then
                MessageBox.Show("Debe colocar al menos el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim negocios As New Negocio.MedicamentoNegocios
                'Dim objMedicamento As New Objetos.Medicamento

                Dim idMedicamento = negocios.AgregarMedicamento(objMedicamento)

                If idMedicamento > 0 Then
                    MessageBox.Show("El medicamento se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("No se pudo agregar el medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema (Error: " + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




End Class