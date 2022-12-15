Imports Objetos
Imports AccesoDatos

Public Class CitasNegocios
    Private _CitasAccesoDatos As New AccesoDatos.Cita
    ''' <summary>
    ''' Ingresa una nueva cita a la base de datos
    ''' </summary>
    ''' <param name="objCita">Objeto de tipo cita a ingresar</param>
    Public Function AgregarCita(objCita As Citas) As Integer
        Try
            Return _CitasAccesoDatos.InsertarCita(objCita)
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Function

    ''' <summary>
    ''' Borra una cita almancenada en la base de datos
    ''' </summary>
    ''' <param name="objCita">Objeto de tipo cita a borrar</param>
    ''' <returns></returns>
    Public Function BorrarCita(objCita As Citas) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Actualiza una cita existente en la DB
    ''' </summary>
    ''' <param name="objCita"></param>
    ''' <returns></returns>
    Public Function ActualizarCita(objCita As Citas) As Boolean
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
    ''' <param name="idCita"></param>
    ''' <returns></returns>
    Public Function ObtenerCitaPorId(idCita As String) As Citas
        Try
            Throw New NotImplementedException()
            Return New Citas
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New Citas
        End Try
    End Function


    ''' <summary>
    ''' Retorna u
    ''' </summary>
    ''' <returns></returns>
    Public Function ListaCitasPorExpediente(idExpediente As String) As List(Of Citas)
        Try
            Throw New NotImplementedException()
            Return New List(Of Citas)
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New List(Of Citas)
        End Try
    End Function


End Class
