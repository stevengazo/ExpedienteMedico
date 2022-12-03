Imports System.Data.SqlClient
Imports Objetos


Public Class MetodosMedico

    Dim conection As New SqlConnection("Data Source=LAPTOP-B2U83SJU\SQLEXPRESS;Initial Catalog=Proyecto_Hospital;Integrated Security=True")

    Public Function InsertaMedico(usuario As String, contrasena As String, nom As String, ape As String, ide As String, Tide As String, sexo As String, Ecivil As String, nac As String, Fnac As String, tel As String, correo As String,
                                  espe As String, Aexp As String, prov As String, can As String, dis As String, otras As String) As Integer
        Dim idMedico As Integer = 0
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "[dbo].[MedicoAgregar]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conection

            'agregar parametros
            'son parametros de entrada
            command.Parameters.Add("@_Usuario", SqlDbType.VarChar, 25).Value = usuario
            command.Parameters.Add("@_Contraseña", SqlDbType.VarChar, 50).Value = contrasena
            command.Parameters.Add("@_Nombre", SqlDbType.VarChar, 25).Value = nom
            command.Parameters.Add("@_Apellidos", SqlDbType.VarChar, 50).Value = ape
            command.Parameters.Add("@_Identificacion", SqlDbType.VarChar, 30).Value = ide
            command.Parameters.Add("@_TipoIdentificacion", SqlDbType.VarChar, 15).Value = Tide
            command.Parameters.Add("@_Sexo", SqlDbType.VarChar, 15).Value = sexo
            command.Parameters.Add("@_EstadoCivil", SqlDbType.VarChar, 15).Value = Ecivil
            command.Parameters.Add("@_Nacionalidad", SqlDbType.VarChar, 15).Value = nac
            command.Parameters.Add("@_FechaNacimiento", SqlDbType.VarChar, 10).Value = Fnac
            command.Parameters.Add("@_NumeroTelefonico", SqlDbType.Int).Value = tel
            command.Parameters.Add("@_correo", SqlDbType.VarChar, 40).Value = correo
            command.Parameters.Add("@_IdEspecialidad", SqlDbType.VarChar, 100).Value = espe
            command.Parameters.Add("@_AniosExp", SqlDbType.VarChar, 100).Value = Aexp
            command.Parameters.Add("@_Provincia", SqlDbType.VarChar, 15).Value = prov
            command.Parameters.Add("@_Canton", SqlDbType.VarChar, 20).Value = can
            command.Parameters.Add("@_Distrito", SqlDbType.VarChar, 30).Value = dis
            command.Parameters.Add("@_OtrasSenas", SqlDbType.VarChar, 100).Value = otras

            'agregar los parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@idMedico", SqlDbType.Int).Direction = ParameterDirection.Output

            'abrir la conexion
            conection.Open()

            'ejecutar
            command.ExecuteNonQuery()

            'cerrar la conexion
            conection.Close()

            If command.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + command.Parameters("@_mensaje_error").Value)
            Else
                idMedico = command.Parameters("@idMedico").Value
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return idMedico
    End Function

End Class
