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

    Public Function ObtenerRegistro(idReceta) As Objetos.Receta
        Try
            Dim data As New DataSet()
            Dim receta As New Objetos.Receta
            Dim comando As New SqlCommand()
            comando.CommandText = "select * from Receta where idReceta = " + idReceta.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = _conection
            _conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Receta")
            _conection.Close()
            For Each i In data.Tables(0).Rows
                receta.idReceta = Integer.Parse(i(0))
                receta.Fecha = Date.Parse(i(1))
                receta.Indicaciones = i(2)
                receta.FechaVencimiento = Date.Parse(i(3))
            Next
            Return receta
        Catch ex As Exception
            Return New Objetos.Receta
        End Try
    End Function

    Public Function BorrarRegistro(id As Integer) As Boolean
        Try
            Dim data As New DataSet()
            Dim receta As New Objetos.Receta
            Dim comando As New SqlCommand()
            comando.CommandText = "

                    DECLARE @_idBorrar int= " & id & "
                    DELETE FROM ReceHasMedi
                    WHERE ReceHasMedi.idReceta = @_idBorrar 
                    DELETE FROM Receta 
                    WHERE Receta.idReceta = @_idBorrar
                    "
            comando.CommandType = CommandType.Text
            comando.Connection = _conection
            _conection.Open()
            comando.ExecuteNonQuery()
            _conection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
