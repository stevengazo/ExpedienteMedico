Imports System.Data.SqlClient
Imports Objetos
Public Class InvHasSucur
    Private _conexion As New SqlConnection(DATOSGENERALES.StringConnection)
    Public Function agregarRegistro(obj As Objetos.InvHasSucur) As Boolean
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[InvHasSucurAgregar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = _conexion

            ' parametros entrada 
            comando.Parameters.Add("@_idInventario", SqlDbType.Int).Value = obj.idInventario
            comando.Parameters.Add("@_idSucursal", SqlDbType.Int).Value = obj.idSucursal
            ' parametros de salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_Agregado", SqlDbType.Bit).Direction = ParameterDirection.Output
            _conexion.Open()
            comando.ExecuteNonQuery()
            _conexion.Close()

            If comando.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + comando.Parameters("@msj_error").Value)
            Else
                Return comando.Parameters("@_Agregado").Value
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            Return False
        End Try
    End Function

End Class
