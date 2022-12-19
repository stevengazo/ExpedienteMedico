Imports Objetos
Imports System.Data.SqlClient
Public Class ReceHasInve
    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

    ''' <summary>
    ''' Ingresa un nuevo médico en la base de datos
    ''' </summary>
    ''' <param name="medico">Objeto de tipo médico a ingresar</param>
    ''' <returns>0 si presenta un error, si no el ID del médico</returns>
    Public Function InsertarRegistro(obj As Objetos.ReceHasMedi) As Integer
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "[dbo].[ReceHasInvenAgregar]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conection
            'agregar parametros
            'son parametros de entrada
            command.Parameters.Add("@_idInventario", SqlDbType.Int).Value = obj.idInventaio
            command.Parameters.Add("@_cantidad", SqlDbType.Int).Value = obj.Cantidad
            command.Parameters.Add("@_idReceta ", SqlDbType.Int).Value = obj.idReceta
            'agregar los parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@_Estado", SqlDbType.Bit).Direction = ParameterDirection.Output
            'abrir la conexion
            conection.Open()

            'ejecutar
            command.ExecuteNonQuery()

            'cerrar la conexion
            conection.Close()

            If command.Parameters("@_Estado").Value Then
                Return True
            Else
                Throw New Exception(command.Parameters("@_mensaje_error").Value)
                Return False
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function ObtenerLista(idReceta As Integer) As List(Of Objetos.ReceHasMedi)
        Try
            Dim _dataSet As New DataSet()
            Dim listaDatos As New List(Of Objetos.ReceHasMedi)
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM ReceHasMedi WHERE ReceHasMedi.idReceta = " + idReceta.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(_dataSet, "ReceHasMedi")
            conection.Close()
            For Each datarow In _dataSet.Tables(0).Rows
                Dim tmp As New Objetos.ReceHasMedi()
                tmp.idInventaio = Integer.Parse(datarow(0))
                tmp.Cantidad = Integer.Parse(datarow(1))
                tmp.idReceta = Integer.Parse(datarow(2))
                listaDatos.Add(tmp)
            Next
            Return listaDatos
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function



End Class
