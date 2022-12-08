Imports System.Globalization
Imports Objetos
Public Class DiagnosticoNegocios
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objDiagnostico"></param>
    Public Sub AgregarDiagnostico(objDiagnostico As Diagnostico)
        Try
            Throw New NotImplementedException()
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objDiagnostico"></param>
    ''' <returns></returns>
    Public Function BorrarDiagnostico(objDiagnostico As Diagnostico) As Boolean
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
    ''' <param name="objDiagnostico"></param>
    ''' <returns></returns>
    Public Function ActualizarDiagnostico(objDiagnostico As Diagnostico) As Boolean
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
    ''' <param name="idDiagnostico"></param>
    ''' <returns></returns>
    Public Function ObtenerDiagnosticoPorId(idDiagnostico As String) As Diagnostico
        Try
            Throw New NotImplementedException()
            Return New Diagnostico
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New Diagnostico
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idExpediente"></param>
    ''' <returns></returns>
    Public Function ListaDiagnosticosPorExpediente(idExpediente As String) As List(Of Diagnostico)
        Try
            Throw New NotImplementedException()
            Return New List(Of Diagnostico)
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New List(Of Diagnostico)
        End Try
    End Function
End Class
