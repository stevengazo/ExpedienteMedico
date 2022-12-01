Public Class Paciente
    Public idPaciente As Integer
    Public Nombre As String
    Public Apellidos As String
    Public Identificacion As String
    Public TipoIdentificacion As String
    Public Sexo As String
    Public EstadoCivil As String
    Public Nacionalidad As String
    Public FechaNacimiento As DateTime
    Public NumeroTelefonico As Integer
    Public Correo As Integer
    Public Provincia As String
    Public Canton As String
    Public EstaActivo As Boolean
    ' Dependencia de expediente

    Public Expediente As ExpedienteMedico


End Class
