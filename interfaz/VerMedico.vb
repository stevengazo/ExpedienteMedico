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
        txtUsuario.Text = Medico.Usuario
        txtContrasena.Text = Medico.Contraseña
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
End Class