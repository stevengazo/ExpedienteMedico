

Public Class Medico
    Public idMedico As Integer
    Public Usuario As String
    Public Contraseña As String
    Public Nombre As String
    Public Apellido As String
    Public Identificacion As String
    Public TipoIdentificación As String
    Public Sexo As String
    Public EstadoCivil As String
    Public Nacionalidad As String
    Public FechaNacimiento As DateTime
    Public NumeroTelefono As Integer
    Public Correo As String
    Public IdDistrito As Integer
    Public OtrasSenas As String
    Public Especialidades As New List(Of Objetos.MedHasEspe)
End Class
