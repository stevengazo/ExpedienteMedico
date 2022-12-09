Public Class VerMedico

    Private Sub VerMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = TEMPORAL.Medico.Nombre
        txtApellidos.Text = TEMPORAL.Medico.Apellido
        txtContrasena.Text = "Información no disponible"
        txtContrasena.Enabled = False
        txtUsuario.Text = TEMPORAL.Medico.Usuario
        txtIdentificacion.Text = TEMPORAL.Medico.Identificacion
        txtCorreo.Text = TEMPORAL.Medico.Correo
    End Sub
End Class