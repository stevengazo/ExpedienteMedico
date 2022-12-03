Public Class AgregarMedico
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombreEspecialidad.Clear()

    End Sub

    Private Sub btnAgregarMedico_Click(sender As Object, e As EventArgs) Handles btnAgregarMedico.Click
        Try
            'obtener los valores de la UI
            Dim usuario = txtUsuario.Text
            Dim contraseña = txtContrasena.Text
            Dim nombre = txtNombre.Text
            Dim apellidos = txtApellidos.Text
            Dim identificacion = txtIdentificacion.Text
            Dim tipoidentificacion = cboTipoIdentificacion.Text
            Dim sexo = cboSexo.Text
            Dim estadocivil = cboEstadoCivil.Text
            Dim nacionalidad = txtNacionalidad.Text
            Dim fechanacimiento = txtFechaN.Text
            Dim telefono = txtTelefono.Text
            Dim correo = txtCorreo.Text
            Dim especialidad = txtNombreEspecialidad.Text
            Dim aniosExp = txtAñosExperiencia.Text
            Dim provincia = cboProvincia.Text
            Dim canton = txtCanton.Text
            Dim distrito = txtDistrito.Text
            Dim otras = txtOtros.Text

            If String.IsNullOrEmpty(nombre) Then
                MessageBox.Show("Debe colocar al menos el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim negocios As New Negocio.MedicoNegocio
                Dim objMedico As New Objetos.Medico

                Dim idMedico = negocios.AgregarMedico(usuario, contraseña, nombre, apellidos, identificacion, tipoidentificacion,
                                                      sexo, estadocivil, nacionalidad, fechanacimiento, telefono, correo, especialidad,
                                                        aniosExp, provincia, canton, distrito, otras)

                If idMedico > 0 Then
                    MessageBox.Show("El médico se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("No se pudo agregar el médico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema (Error: " + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class