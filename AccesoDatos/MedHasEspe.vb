Imports System.Data.SqlClient
Imports Objetos

Public Class MedHasEspe
    Dim conection As New SqlConnection("Data Source=127.0.0.1;Initial Catalog=Proyecto_Hospital;Persist Security Info=True;User ID=sa;Password=Password123")

    Public Function AgregarEspecialidad(registro As Objetos.MedHasEspe) As Boolean
        Try
            Dim comando As New SqlCommand
            comando.CommandText = "[dbo].[MediHasEspeAgregar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conection
            '  Parametros de entrada
            comando.Parameters.Add("@_idMedico", SqlDbType.Int).Value = registro.IdMedico
            comando.Parameters.Add("@_años", SqlDbType.Int).Value = registro.años
            comando.Parameters.Add("@_idEspecialidad", SqlDbType.Int).Value = registro.IdEspecialidad
            ' Parametros de salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idAdmin", SqlDbType.Binary, 1).Direction = ParameterDirection.Output

            conection.Open()
            comando.ExecuteNonQuery()
            conection.Close()
            If comando.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + comando.Parameters("@_mensaje_error").Value)
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class




