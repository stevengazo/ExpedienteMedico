Imports System.Data.SqlClient
Imports Objetos


Public Class MetodosMedico

    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

    ''' <summary>
    ''' Ingresa un nuevo médico en la base de datos
    ''' </summary>
    ''' <param name="medico">Objeto de tipo médico a ingresar</param>
    ''' <returns>0 si presenta un error, si no el ID del médico</returns>
    Public Function InsertaMedico(medico As Objetos.Medico) As Integer
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
            command.Parameters.Add("@_NumeroTelefonico", SqlDbType.Int).Value = medico.NumeroTelefono
            command.Parameters.Add("@_correo", SqlDbType.VarChar, 40).Value = medico.Correo
            command.Parameters.Add("@_OtrasSenas", SqlDbType.VarChar, 100).Value = medico.OtrasSenas
            command.Parameters.Add("@_IdDistrito", SqlDbType.Int).Value = medico.IdDistrito.ToString()
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


    ''' <summary>
    ''' envia la información a la DB para ver si el medico puede iniciar sesión
    ''' </summary>
    ''' <param name="usuario">nombre de usuario del medico</param>
    ''' <param name="contraseña">contraseña del médico</param>
    ''' <returns>true si es valido, false si presenta error</returns>
    Public Function InicioSesion(usuario As String, contraseña As String) As Boolean
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[MedicoComprobarSesion]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conection

            ' parametros entrada 
            comando.Parameters.Add("@_usuario", SqlDbType.VarChar, 25).Value = usuario
            comando.Parameters.Add("@_contrasena", SqlDbType.VarChar, 50).Value = contraseña
            ' parametros de salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idMedico", SqlDbType.Int).Direction = ParameterDirection.Output

            ' abre la conexión
            conection.Open()
            ' ejecuta 
            comando.ExecuteNonQuery()
            ' cierra la conexion
            conection.Close()

            If comando.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + comando.Parameters("@msj_error").Value)
            Else
                If comando.Parameters("@idMedico").Value = 0 Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Consulta un id a la base de datos y retorna un médico
    ''' </summary>
    ''' <param name="id">id del Médico</param>
    ''' <returns>Objeto de tipo médico</returns>
    Public Function ObtenerMedico(id As Integer) As Objetos.Medico
        Try
            Dim _dataSet As New DataSet()
            Dim Medico As New Objetos.Medico()
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM MEDICOS WHERE idMedico= " + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            conection.Open()
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(_dataSet, "Medicos")
            conection.Close()
            For Each row In _dataSet.Tables(0).Rows
                Medico.idMedico = Integer.Parse(row(0))
                Medico.Usuario = row(1)
                Medico.Contraseña = "" 'row()
                Medico.Nombre = row(3)
                Medico.Apellido = row(4)
                Medico.Identificacion = row(5)
                Medico.TipoIdentificación = row(6)
                Medico.Sexo = row(7)
                Medico.EstadoCivil = row(8)
                Medico.Nacionalidad = row(9)
                Medico.FechaNacimiento = row(10)
                Medico.NumeroTelefono = Integer.Parse(row(11))
                Medico.Correo = row(12)
                Medico.OtrasSenas = row(13)
                Medico.IdDistrito = row(14)
            Next
            Return Medico
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            Return New Objetos.Medico()
        End Try
    End Function

    Public Function BorrarMedico(idMedico As Integer) As Integer
        Try
            Dim _comando As New SqlCommand()
            _comando.CommandText = "[dbo].[EliminarMedico]"
            _comando.CommandType = CommandType.StoredProcedure
            _comando.Connection = conection
            'son parametros de entrada (envia el id al procedimiento)
            _comando.Parameters.Add("@idMedico", SqlDbType.Int).Value = idMedico
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

End Class
