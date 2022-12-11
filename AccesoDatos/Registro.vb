Imports System.Data.SqlClient
Imports Objetos
Imports AccesoDatos

Public Class Registro
    ''' <summary>
    ''' Clase de conexión a la DB
    ''' </summary>
    Private conexion As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function AñadirRegistro(idExpediente As Integer, idSucursal As Integer) As Boolean
        Throw New NotImplementedException()
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = ""
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
            'Parametros Entrada
            'comando.Parameters.Add("@_usuario", SqlDbType.VarChar, 25).Value = usuari
            'comando.Parameters.Add("@_contrasena", SqlDbType.VarChar, 50).Value = contraseña
            ' Parametros salida
            'comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            'comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            'comando.Parameters.Add("@idAdministrador", SqlDbType.Int).Direction = ParameterDirection.Output

            Return True
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function



End Class
