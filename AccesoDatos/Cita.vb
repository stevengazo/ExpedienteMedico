Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Objetos

Public Class Cita
    Private _conexion As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function InsertarCita(tmp As Objetos.Citas) As Integer
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "[dbo].[CitaAgregar]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = _conexion
            'son parametros de entrada
            command.Parameters.Add("@_Fecha", SqlDbType.Date).Value = tmp.Fecha.ToString()
            'agregar los parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@idCita", SqlDbType.Int).Direction = ParameterDirection.Output
            'abrir la conexion
            _conexion.Open()
            'ejecutar
            command.ExecuteNonQuery()
            'cerrar la conexion
            _conexion.Close()
            If command.Parameters("@_codigo_error").Value = 0 Then
                Return command.Parameters("@idCita").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
