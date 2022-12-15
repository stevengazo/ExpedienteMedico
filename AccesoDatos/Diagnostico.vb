Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Objetos
Public Class Diagnostico
    Private _conection As New SqlConnection(DATOSGENERALES.StringConnection)
    ''' <summary>
    ''' Agrega un nuevo elemento en la base de datos
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <returns>Id del registro</returns>
    Function AgregarRegistro(obj As Objetos.Diagnostico) As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[DiagnosticoAgregar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = _conection

            ' parametros entrada 
            comando.Parameters.Add("@_Fecha", SqlDbType.Date).Value = obj.Fecha
            comando.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 1000).Value = obj.Descripcion
            comando.Parameters.Add("@_idEnfermedad", SqlDbType.Int).Value = obj.idEnfermedad
            ' parametros de salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idDiagnostico", SqlDbType.Int).Direction = ParameterDirection.Output
            ' abre la conexión
            _conection.Open()
            comando.ExecuteNonQuery()
            _conection.Close()

            If comando.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + comando.Parameters("@msj_error").Value)
            Else
                If comando.Parameters("@idDiagnostico").Value <> 0 Then
                    Return comando.Parameters("@idDiagnostico").Value
                Else
                    Return 0
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            Return 0
        End Try
    End Function


    Public Function ObtenerRegistro(id As Integer) As Objetos.Diagnostico
        Try
            Dim data As New DataSet()
            Dim Diagnostico As New Objetos.Diagnostico()
            Dim comando As New SqlCommand()
            comando.CommandText = "select * from Diagnostico where idDiagnostico =" + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = _conection
            _conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Diagnostico")
            _conection.Close()
            For Each mydatarow In data.Tables(0).Rows
                Diagnostico.idDiagnostico = Integer.Parse(mydatarow(0))
                Diagnostico.Fecha = Date.Parse(mydatarow(1))
                Diagnostico.Descripcion = mydatarow(2)
                Diagnostico.idEnfermedad = Integer.Parse(mydatarow(3))
            Next
            Return Diagnostico
        Catch ex As Exception
            Return New Objetos.Diagnostico
        End Try
    End Function


    ''' <summary>
    ''' Borra un registro
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function BorrarRegistro(id As Integer) As Boolean
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[DiagnosticoEliminar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = _conection

            ' parametros entrada 
            comando.Parameters.Add("@idDiagnostico", SqlDbType.Int).Value = id
            ' parametros de salida
            comando.Parameters.Add("@ErrorCode", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@ErrorMessage", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@borrado", SqlDbType.Bit).Direction = ParameterDirection.Output
            ' abre la conexión
            _conection.Open()
            comando.ExecuteNonQuery()
            _conection.Close()

            If comando.Parameters("@borrado").Value Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function




End Class
