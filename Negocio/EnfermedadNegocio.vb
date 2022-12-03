Imports Objetos
Imports AccesoDatos
Imports System.Security.Cryptography

Public Class EnfermedadNegocio
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objEnfermedad"></param>
    Public Function AgregarEnfermedad(nombre As String, desc As String, sin As String)
        Try
            Dim obtieneDatos As New AccesoDatos.MetodosEnfermedad

            Return obtieneDatos.InsertaEnfermedad(nombre, desc, sin)
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
    ''' <returns></returns>
    Public Function ListaEnfermedades() As List(Of Enfermedad)
        Try
            Throw New NotImplementedException()
            Return New List(Of Enfermedad)
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New List(Of Enfermedad)
        End Try
    End Function

End Class
