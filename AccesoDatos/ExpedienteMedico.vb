Imports System.Data.SqlClient

Public Class ExpedienteMedico
    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

    ''' <summary>
    ''' Genera un nuevo expediente médico en la  DB
    ''' </summary>
    ''' <returns>Retorna el id del expediente, si prenta un error, retorna 0</returns>
    Public Function GenerarExpediente() As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[GenerarExpediente]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conection
            ' parametros de salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_idExpediente", SqlDbType.Int).Direction = ParameterDirection.Output
            ' abre la conexión
            conection.Open()
            ' ejecuta 
            comando.ExecuteNonQuery()
            ' cierra la conexion
            conection.Close()
            If comando.Parameters("@_codigo_error").Value <> 0 Then
                Console.WriteLine("Error: " + comando.Parameters("@msj_error").Value)
                Return 0
            Else
                Return comando.Parameters("@_idExpediente").Value
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
    End Function

    Public Function ObtenerExpediente(id As Integer) As Objetos.ExpedienteMedico
        Try
            Dim _dataset As New DataSet()
            Dim Expediente As New Objetos.ExpedienteMedico()
            Dim comando As New SqlCommand()
            comando.CommandText = " select * from ExpedienteMedico WHERE idExpediente =  " + id
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            conection.Open()
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(_dataset, "ExpedienteMedico")
            conection.Close()
            For Each row In _dataset.Tables(0).Rows
                Expediente.idExpediente = Integer.Parse(row(0))
                Expediente.FechaApertura = row(1)
                Expediente.UltimaModificacion = row(2)
            Next
            Return Expediente
        Catch ex As Exception
            Return New Objetos.ExpedienteMedico
        End Try
    End Function

End Class
