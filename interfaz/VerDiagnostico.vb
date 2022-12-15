Imports Objetos
Imports Negocio

Public Class VerDiagnostico
    Private _Diagnostico As New Negocio.DiagnosticoNegocios()
    Private _Enfermedades As New Negocio.EnfermedadNegocio()

    Private Sub VerDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim diagnostico = _Diagnostico.ObtenerDiagnosticoPorId(TEMPORAL.RegistroTemp.idDiagnostico)
        Dim enfermedad = _Enfermedades.ObtenerEnfermedadPorId(diagnostico.idEnfermedad)

        lblFechaSintomas.Text = diagnostico.Fecha.ToLongDateString()
        lblEnfermedadNombre.Text = enfermedad.Nombre
        txtDescripcionDiagnostico.Text = diagnostico.Descripcion
        txtDescripcionDiagnostico.Enabled = False
        txtDescripcionEnfermedad.Text = enfermedad.Descripcion
        txtDescripcionEnfermedad.Enabled = False
        txtSintomasEnfermedad.Text = enfermedad.sintomas
        txtSintomasEnfermedad.Enabled = False

    End Sub
End Class