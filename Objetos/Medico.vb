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


    'Public Sub New()
    '    idMedico = 0
    '    Usuario = String.Empty
    '    Contraseña = String.Empty
    '    Nombre = String.Empty
    '    Apellido = String.Empty
    '    Identificacion = String.Empty
    '    TipoIdentificación = String.Empty
    '    Sexo = String.Empty
    '    EstadoCivil = String.Empty
    '    Nacionalidad = String.Empty
    '    FechaNacimiento = DateTime.Now
    '    NumeroTelefono = 0
    '    Correo = String.Empty
    '    IdDistrito = 0
    '    OtrasSenas = String.Empty

    'End Sub
End Class
