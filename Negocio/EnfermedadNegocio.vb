Imports Objetos
Imports AccesoDatos
Imports System.Security.Cryptography

Public Class EnfermedadNegocio
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objEnfermedad"></param>
    Public Function AgregarEnfermedad(enfermedad As Objetos.Enfermedad) As Integer
        Try
            Dim obtieneDatos As New AccesoDatos.MetodosEnfermedad

            Return obtieneDatos.InsertaEnfermedad(enfermedad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objEnfermedad"></param>
    ''' <returns></returns>
    Public Function BorrarEnfermedad(objEnfermedad As Enfermedad) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objEnfermedad"></param>
    ''' <returns></returns>
    Public Function ActualizarEnfermedad(objEnfermedad As Enfermedad) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idEnfermedad"></param>
    ''' <returns></returns>
    Public Function ObtenerEnfermedadPorId(idEnfermedad As String) As Enfermedad
        Try
            Throw New NotImplementedException()
            Return New Enfermedad
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New Enfermedad
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns

    Public Function ListaEnfermedad() As List(Of Objetos.Enfermedad)
        Try
            Dim tmpNegocio As New AccesoDatos.MetodosEnfermedad
            Return tmpNegocio.ObtenerListaEnfermedades()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Enfermedad)
        End Try
    End Function

End Class
