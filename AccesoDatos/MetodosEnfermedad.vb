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
            comando.CommandText = "Select * from Enfermedades"
            comando.CommandType = CommandType.Text
            comando.Connection = conection

            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(_dataSet, "Enfermedades")
            conection.Close()


            For Each datarow In _dataSet.Tables(0).Rows
                Dim tmp As New Objetos.Enfermedad
                tmp.id = Integer.Parse(datarow(0))
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

End Class
