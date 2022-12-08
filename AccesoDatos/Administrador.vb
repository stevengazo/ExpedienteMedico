Imports System.Data.SqlClient

Public Class Administrador
    Dim conexion As New SqlConnection(DATOSGENERALES.StringConnection)


    ''' <summary>
    ''' Comprueba que el usuario prueda iniciar sesión
    ''' </summary>
    ''' <param name="usuario">usuario a comprobar</param>
    ''' <param name="contraseña">contraseña</param>
    ''' <returns>true si la contraseña es correcta, false si presenta error o es incorrecta</returns>
    Public Function InicioSesion(usuario As String, contraseña As String) As Boolean
        Try
            Dim command As New SqlCommand()
            command.CommandText = "[dbo].[AdministradorComprobarSesion]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conexion

            ' parametros de entrada
            command.Parameters.Add("@_usuario", SqlDbType.VarChar, 25).Value = usuario
            command.Parameters.Add("@_contrasena", SqlDbType.VarChar, 50).Value = contraseña

            ' parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@idAdministrador", SqlDbType.Int).Direction = ParameterDirection.Output

            ' abre la conexión
            conexion.Open()
            ' ejecuta 
            command.ExecuteNonQuery()
            ' cierra la conexion
            conexion.Close()

            If command.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + command.Parameters("@msj_error").Value)
            Else
                If command.Parameters("@idAdministrador").Value = 0 Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            Return False
        End Try
    End Function


End Class
