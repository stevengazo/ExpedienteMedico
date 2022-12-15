Imports Negocio
Imports Objetos
Public Class AgregarCita
    Private _CitaNegocios As New Negocio.CitasNegocios()
    Private Sub AgregarCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreSucursal.Text = TEMPORAL.Sucursal.Nombre
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarCita_Click(sender As Object, e As EventArgs) Handles btnAgregarCita.Click
        Dim fecha = dtpFecha.Value
        Dim ObjetoCita = New Objetos.Citas()
        ObjetoCita.Fecha = fecha
        ObjetoCita.idCita = 0
        ObjetoCita.idCita = _CitaNegocios.AgregarCita(ObjetoCita)
        If ObjetoCita.idCita <> 0 Then
            TEMPORAL.RegistroTemp.idCita = ObjetoCita.idCita
            MessageBox.Show("Cita Agendada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class