Imports Objetos
Imports Negocio
Public Class VerCita
    Private _CitasNegocios As New Negocio.CitasNegocios()
    Private Sub VerCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cita = _CitasNegocios.ObtenerCitaPorId(TEMPORAL.RegistroTemp.idCita)
        lblSucursal.Text = TEMPORAL.Sucursal.Nombre
        lblFecha.Text = Cita.Fecha.ToLongDateString()
    End Sub
End Class