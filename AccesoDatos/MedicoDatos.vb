Imports System.Data.SqlClient
Imports System.Security.Permissions
Imports Objetos
Public Class MedicoDatos
    Dim conexion As New SqlConnection("Data Source=127.0.0.1;Initial Catalog=Proyecto_Hospital;Persist Security Info=True;User ID=sa;Password=Password123")

    ''' <summary>
    ''' envia la información a la DB para ver si el medico puede iniciar sesión
    ''' </summary>
    ''' <param name="usuario">nombre de usuario del medico</param>
    ''' <param name="contraseña">contraseña del médico</param>
    ''' <returns>true si es valido, false si presenta error</returns>
    Public Function InicioSesion(usuario As String, contraseña As String) As Boolean
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[MedicoComprobarSesion]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion

            ' parametros entrada 
            comando.Parameters.Add("@_usuario", SqlDbType.VarChar, 25).Value = usuario
            comando.Parameters.Add("@_contrasena", SqlDbType.VarChar, 50).Value = contraseña
            ' parametros de salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idMedico", SqlDbType.Int).Direction = ParameterDirection.Output

            ' abre la conexión
            conexion.Open()
            ' ejecuta 
            comando.ExecuteNonQuery()
            ' cierra la conexion
            conexion.Close()

            If comando.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + comando.Parameters("@msj_error").Value)
            Else
                If comando.Parameters("@idMedico").Value = 0 Then
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
