Public Class VerMedico
    Dim tmpNegocioMedico As New Negocio.MedicoNegocio()
    Dim Medico As New Objetos.Medico()
    Dim Bandera As Boolean = True
    Private Sub VerMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Medico = TEMPORAL.Medico
        'ActualizarPanelInformacion()
        ActualizarMedico()

        'txtNombre.Text = TEMPORAL.Medico.Nombre
        'txtApellidos.Text = TEMPORAL.Medico.Apellido
        'txtContrasena.Text = "Información no disponible"
        'txtContrasena.Enabled = False
        'txtUsuario.Text = TEMPORAL.Medico.Usuario
        'txtIdentificacion.Text = TEMPORAL.Medico.Identificacion
        'txtCorreo.Text = TEMPORAL.Medico.Correo
    End Sub

    Private Sub ActualizarMedico()
        txtUsuario.Enabled = False
        txtContrasena.Enabled = False
        txtNombre.Enabled = False
        txtApellidos.Enabled = False
        txtIdentificacion.Enabled = False
        cboTipoIdentificacion.Enabled = False
        cboSexo.Enabled = False
        cboEstadoCivil.Enabled = False
        txtNacionalidad.Enabled = False
        dtNacimiento.Enabled = False
        cbDistrito.Enabled = False

        txtUsuario.Text = Medico.Usuario
        txtContrasena.Text = "Información no disponible"
        txtNombre.Text = Medico.Nombre
        txtApellidos.Text = Medico.Apellido
        txtIdentificacion.Text = Medico.Identificacion
        cboTipoIdentificacion.Text = Medico.TipoIdentificación
        cboSexo.Text = Medico.Sexo
        cboEstadoCivil.Text = Medico.EstadoCivil
        txtNacionalidad.Text = Medico.Nacionalidad
        dtNacimiento.Text = Medico.FechaNacimiento
        cbDistrito.Text = Medico.IdDistrito

    End Sub

    Private Sub HabilitarCampos()
        txtUsuario.Enabled = True
        txtContrasena.Enabled = True
        txtNombre.Enabled = True
        txtApellidos.Enabled = True
        txtIdentificacion.Enabled = True
        cboTipoIdentificacion.Enabled = True
        cboSexo.Enabled = True
        cboEstadoCivil.Enabled = True
        txtNacionalidad.Enabled = True
        dtNacimiento.Enabled = True
        cbDistrito.Enabled = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Bandera Then
            HabilitarCampos()
            Bandera = False
            btnEditar.Text = "Actualizar Información"

        Else

            'Enfe.Nombre = txtNombre.Text
            'Enfe.Descripcion = txtDes.Text
            'Enfe.sintomas = txtSin.Text
            'Dim flag = tmpNegocioEnfermedad.ActualizarEnfermedad(Enfermedad)
            'If flag Then
            '    PanelEditable.SendToBack()
            '    Bandera = True
            '    btnEditar.Text = "Editar información"
            '    ActualizarEnfermedad()
            '    ActualizarPanelInformacion()
            '    PanelInfo.BringToFront()
            '    MessageBox.Show("Enfermedad actualizada correctamente", "Información", MessageBoxButtons.OK)
            'Else
            '    MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK)
            'End If




        End If
    End Sub
End Class