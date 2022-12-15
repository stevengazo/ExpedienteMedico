Imports System.Globalization
Imports AccesoDatos
Imports Objetos
Public Class DiagnosticoNegocios
    Private _Diagnosticos As New AccesoDatos.Diagnostico()
    ''' <summary>
    ''' Agrega un nuevo registro en la db
    ''' </summary>
    ''' <param name="objDiagnostico"></param>
    Public Function AgregarDiagnostico(objDiagnostico As Objetos.Diagnostico) As Integer
        Try
            Return _Diagnosticos.AgregarRegistro(objDiagnostico)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Borrar Registro de la DB
    ''' </summary>
    ''' <param name="objDiagnostico"></param>
    ''' <returns></returns>
    Public Function BorrarDiagnostico(id As Integer) As Boolean
        Try
            Return _Diagnosticos.BorrarRegistro(id)
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objDiagnostico"></param>
    ''' <returns></returns>
    Public Function ActualizarDiagnostico(objDiagnostico As Objetos.Diagnostico) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Busca un regitro en la DB
    ''' </summary>
    ''' <param name="idDiagnostico"></param>
    ''' <returns></returns>
    Public Function ObtenerDiagnosticoPorId(idDiagnostico As Integer) As Objetos.Diagnostico
        Try
            Return _Diagnosticos.ObtenerRegistro(idDiagnostico)
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New Objetos.Diagnostico
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idExpediente"></param>
    ''' <returns></returns>
    Public Function ListaDiagnosticosPorExpediente(idExpediente As String) As List(Of Objetos.Diagnostico)
        Try
            Throw New NotImplementedException()
            Return New List(Of Objetos.Diagnostico)
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New List(Of Objetos.Diagnostico)
        End Try
    End Function
End Class
