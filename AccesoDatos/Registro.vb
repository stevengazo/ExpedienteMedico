Imports System.Data.SqlClient
Imports Objetos
Imports AccesoDatos

Public Class Registro
    ''' <summary>
    ''' Clase de conexión a la DB
    ''' </summary>
    Private conexion As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function AñadirRegistro(idExpediente As Integer, idSucursal As Integer) As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[GenerarRegistroEnExpediente]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
            'Parametros Entrada
            comando.Parameters.Add("@_idExpediente", SqlDbType.Int).Value = idExpediente
            comando.Parameters.Add("@_idSucursal", SqlDbType.Int).Value = idSucursal
            ' Parametros salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idRegistro", SqlDbType.Int).Direction = ParameterDirection.Output
            ' Conexion
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            '
            If comando.Parameters("@_codigo_error").Value = 0 Then
                Return comando.Parameters("@idRegistro").Value
            Else
                Throw New Exception("Error")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
    End Function



End Class
