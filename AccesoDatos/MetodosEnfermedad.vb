Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Objetos

Public Class MetodosEnfermedad
    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)
    ''' <summary>
    ''' Ingresa una nueva enfermedad en el sistema 
    ''' </summary>
    ''' <param name="nombre">nombre de la enfermedad </param>
    ''' <param name="desc">Descripción de la enfermedad</param>
    ''' <param name="sin">Sintomas de la enfermedad</param>
    ''' <returns>Retorna el id de la enfermedad ingresada</returns>
    Public Function InsertaEnfermedad(nombre As String, desc As String, sin As String) As Integer
        Dim idEnfermedad As Integer = 0
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "EnfermedadAgregar"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conection

            'agregar parametros
            'son parametros de entrada
            command.Parameters.Add("@_Nombre", SqlDbType.VarChar, 50).Value = nombre
            command.Parameters.Add("@_Descripcion ", SqlDbType.VarChar, 1000).Value = desc
            command.Parameters.Add("@_Sintomas ", SqlDbType.VarChar, 100).Value = sin

            'agregar los parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@idEnfermedad", SqlDbType.Int).Direction = ParameterDirection.Output

            'abrir la conexion
            conection.Open()

            'ejecutar
            command.ExecuteNonQuery()

            'cerrar la conexion
            conection.Close()

            If command.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + command.Parameters("@_mensaje_error").Value)
            Else
                idEnfermedad = command.Parameters("@idEnfermedad").Value
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return idEnfermedad
    End Function
End Class
