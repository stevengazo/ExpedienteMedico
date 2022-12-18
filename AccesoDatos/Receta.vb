Imports Objetos
Imports System.Data.SqlClient
Public Class Receta
    Private _conection As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function InsertarRegistro(obj As Objetos.Receta) As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[AgregarReceta]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = _conection
            ' Parametros de Entrada
            comando.Parameters.Add("@_Fecha", SqlDbType.Date).Value = obj.Fecha
            comando.Parameters.Add("@_fechaVencimiento", SqlDbType.Date).Value = obj.FechaVencimiento
            comando.Parameters.Add("@_Indicaciones", SqlDbType.VarChar, 100).Value = obj.Indicaciones

            ' Parametros de Salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idReceta", SqlDbType.Int).Direction = ParameterDirection.Output
            ' Abre la conexión
            _conection.Open()
            comando.ExecuteNonQuery()
            _conection.Close()

            If comando.Parameters("@idReceta").Value <> 0 Then
                Return comando.Parameters("@idReceta").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 0
        End Try
    End Function

End Class
