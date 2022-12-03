Imports System.Data.SqlClient
Imports Objetos


Public Class MetodosMedico

    Dim conection As New SqlConnection("Data Source=127.0.0.1;Initial Catalog=Proyecto_Hospital;Persist Security Info=True;User ID=sa;Password=Password123")

    Public Function InsertaMedico(medico As Medico) As Integer
        Dim idMedico As Integer = 0
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "[dbo].[MedicoAgregar]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conection

            'agregar parametros
            'son parametros de entrada
            command.Parameters.Add("@_Usuario", SqlDbType.VarChar, 25).Value = medico.Usuario
            command.Parameters.Add("@_Contraseña", SqlDbType.VarChar, 50).Value = medico.Contraseña
            command.Parameters.Add("@_Nombre", SqlDbType.VarChar, 25).Value = medico.Nombre
            command.Parameters.Add("@_Apellidos", SqlDbType.VarChar, 50).Value = medico.Apellido
            command.Parameters.Add("@_Identificacion", SqlDbType.VarChar, 30).Value = medico.Identificacion
            command.Parameters.Add("@_TipoIdentificacion", SqlDbType.VarChar, 15).Value = medico.TipoIdentificación
            command.Parameters.Add("@_Sexo", SqlDbType.VarChar, 15).Value = medico.Sexo
            command.Parameters.Add("@_EstadoCivil", SqlDbType.VarChar, 15).Value = medico.EstadoCivil
            command.Parameters.Add("@_Nacionalidad", SqlDbType.VarChar, 15).Value = medico.Nacionalidad
            command.Parameters.Add("@_FechaNacimiento", SqlDbType.VarChar, 10).Value = medico.FechaNacimiento.ToString()
            command.Parameters.Add("@_IdDistrito", SqlDbType.Int).Value = medico.IdDistrito
            'agregar los parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@idMedico", SqlDbType.Int).Direction = ParameterDirection.Output

            'abrir la conexion
            conection.Open()

            'ejecutar
            command.ExecuteNonQuery()

            'cerrar la conexion
            conection.Close()

            If command.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + command.Parameters("@_mensaje_error").Value)
            Else
                idMedico = command.Parameters("@idMedico").Value
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return idMedico
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function ObtenerListaMedicos() As List(Of Objetos.Medico)
        Try
            Dim _dataSet As New DataSet()
            Dim listaMedicos As New List(Of Objetos.Medico)
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Medicos"
            comando.CommandType = CommandType.Text
            comando.Connection = conection

            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(_dataSet, "Medicos")
            conection.Close()


            For Each datarow In _dataSet.Tables(0).Rows
                Dim tmp As New Objetos.Medico
                tmp.idMedico = Integer.Parse(datarow(0))
                tmp.Usuario = datarow(1)
                tmp.Nombre = datarow(3)
                tmp.Apellido = datarow(4)
                tmp.Identificacion = datarow(5)
                tmp.TipoIdentificación = datarow(6)
                tmp.Sexo = datarow(7)
                tmp.EstadoCivil = datarow(8)
                tmp.Nacionalidad = datarow(9)
                tmp.FechaNacimiento = datarow(10)
                tmp.NumeroTelefono = Integer.Parse(datarow(11))
                tmp.Correo = datarow(12)
                tmp.OtrasSenas = datarow(13)
                tmp.IdDistrito = Integer.Parse(datarow(14))
                listaMedicos.Add(tmp)
            Next


            Return listaMedicos
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Medico)
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function ObtenerDataSetMedicos() As DataSet
        Dim _dataSet As New DataSet()
        Try
            Dim listaMedicos As New List(Of Objetos.Medico)
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Medicos"
            comando.CommandType = CommandType.Text
            comando.Connection = conection

            conection.Open()
            Dim adapter As New SqlDataAdapter()
            adapter.Fill(_dataSet, "Medicos")
            conection.Close()

            Return _dataSet
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return _dataSet
        End Try
    End Function

End Class
