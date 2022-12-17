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
    Public Function InsertaEnfermedad(enfermedad As Objetos.Enfermedad) As Integer
        Dim idEnfermedad As Integer = 0
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "EnfermedadAgregar"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conection

            'agregar parametros
            'son parametros de entrada
            command.Parameters.Add("@_Nombre", SqlDbType.VarChar, 50).Value = enfermedad.Nombre
            command.Parameters.Add("@_Descripcion ", SqlDbType.VarChar, 1000).Value = enfermedad.Descripcion
            command.Parameters.Add("@_Sintomas ", SqlDbType.VarChar, 100).Value = enfermedad.sintomas

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


    Public Function ObtenerListaEnfermedades() As List(Of Objetos.Enfermedad)
        Try
            Dim _dataSet As New DataSet()
            Dim listaEnfe As New List(Of Objetos.Enfermedad)
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Enfermedades where idEnfermedad > 0"
            comando.CommandType = CommandType.Text
            comando.Connection = conection

            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(_dataSet, "Enfermedades")
            conection.Close()


            For Each datarow In _dataSet.Tables(0).Rows
                Dim tmp As New Objetos.Enfermedad
                tmp.idEnfermedad = Integer.Parse(datarow(0))
                tmp.Nombre = datarow(1)
                tmp.Descripcion = datarow(2)
                tmp.sintomas = datarow(3)
                listaEnfe.Add(tmp)
            Next
            Return listaEnfe
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Enfermedad)
        End Try
    End Function

    Public Function BorrarEnfermedad(idEnfermedad As Integer) As Integer
        Try
            Dim _comando As New SqlCommand()
            _comando.CommandText = "[dbo].[EliminarEnfermedad]"
            _comando.CommandType = CommandType.StoredProcedure
            _comando.Connection = conection
            'son parametros de entrada (envia el id al procedimiento)
            _comando.Parameters.Add("@idEnfermedad", SqlDbType.Int).Value = idEnfermedad
            'agregar los parametros de salida
            _comando.Parameters.Add("@ErrorMessage", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            _comando.Parameters.Add("@ErrorCode", SqlDbType.Int).Direction = ParameterDirection.Output

            conection.Open()
            _comando.ExecuteNonQuery()
            conection.Close()
            If _comando.Parameters("@ErrorCode").Value = 0 Then
                Return 0
            Else
                Return _comando.Parameters("@ErrorCode").Value
            End If
        Catch ex As Exception
            Return 1
        End Try
    End Function

    Public Function ObtenerEnfermedad(id As Integer) As Objetos.Enfermedad
        Try
            Dim data As New DataSet()
            Dim enfermedad As New Objetos.Enfermedad()
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM Enfermedades WHERE idEnfermedad = " + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Enfermedades")
            conection.Close()
            For Each row In data.Tables(0).Rows
                enfermedad.idEnfermedad = row(0)
                enfermedad.Nombre = row(1)
                enfermedad.Descripcion = row(2)
                enfermedad.sintomas = row(3)
            Next
            Return enfermedad
        Catch ex As Exception
            Return New Objetos.Enfermedad
        End Try
    End Function

    Public Function ObtenerEnfermedadPorId(id As Integer) As Objetos.Enfermedad
        Try
            Dim _dataset As New DataSet()
            Dim Enfermedad As New Objetos.Enfermedad()
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM ENFERMEDADES WHERE idEnfermedad = " + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            ' Open the connection with sql server
            conection.Open()
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(_dataset, "Enfermedades")
            conection.Close()

            For Each row In _dataset.Tables(0).Rows
                Enfermedad.idEnfermedad = Integer.Parse(row(0))
                Enfermedad.Nombre = row(1)
                Enfermedad.Descripcion = row(2)
                Enfermedad.sintomas = row(3)
            Next
            Return Enfermedad
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
