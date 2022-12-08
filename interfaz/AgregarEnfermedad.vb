Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Negocio
Imports Objetos

Public Class AgregarEnfermedad
    Private objEnfermedad As New Objetos.Enfermedad
    Private Sub btnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles btnAgregarEnfermedad.Click
        Try
            'obtener los valores de la UI
            Dim enfe As New Enfermedad()

            objEnfermedad.Nombre = txtNombreEnfermedad.Text
            objEnfermedad.Descripcion = txtDescripcionEnfermedad.Text
            objEnfermedad.sintomas = txtSintomas.Text

            If String.IsNullOrEmpty(objEnfermedad.Nombre) Then
                MessageBox.Show("Debe colocar al menos el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim negocios As New Negocio.EnfermedadNegocio
                'Dim objEnfermedad As New Objetos.Enfermedad

                Dim idEnfermedad = negocios.AgregarEnfermedad(objEnfermedad)

                If idEnfermedad > 0 Then
                    MessageBox.Show("La enfermedad se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("No se pudo agregar la enfermedad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema (Error: " + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class