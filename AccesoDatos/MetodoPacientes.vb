Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Permissions
Imports System.Runtime.Remoting.Messaging
Imports Objetos.Paciente

Public Class MetodoPacientes

    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function AgregarPaciente(paciente As Objetos.Paciente) As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[PacientesAgregar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conection
            ' Parametros de Entrada
            comando.Parameters.Add("@_Nombre", SqlDbType.VarChar, 25).Value = paciente.Nombre
            comando.Parameters.Add("@_Apellidos", SqlDbType.VarChar, 50).Value = paciente.Apellidos
            comando.Parameters.Add("@_Identificacion", SqlDbType.VarChar, 30).Value = paciente.Identificacion
            comando.Parameters.Add("@_TipoIdentificacion", SqlDbType.VarChar, 15).Value = paciente.TipoIdentificacion
            comando.Parameters.Add("@_Sexo", SqlDbType.VarChar, 15).Value = paciente.Sexo
            comando.Parameters.Add("@_EstadoCivil", SqlDbType.VarChar, 15).Value = paciente.EstadoCivil
            comando.Parameters.Add("@_Nacionalidad", SqlDbType.VarChar, 15).Value = paciente.Nacionalidad
            comando.Parameters.Add("@_FechaNacimiento", SqlDbType.DateTime).Value = paciente.FechaNacimiento
            comando.Parameters.Add("@_NumeroTelefonico", SqlDbType.Int).Value = paciente.NumeroTelefonico
            comando.Parameters.Add("@_Correo", SqlDbType.VarChar, 40).Value = paciente.Correo
            comando.Parameters.Add("@_EstaActivo", SqlDbType.Bit).Value = paciente.EstaActivo
            comando.Parameters.Add("@_idExpediente", SqlDbType.Int).Value = paciente.Expediente.idExpediente
            comando.Parameters.Add("@_idDistrito", SqlDbType.Int).Value = paciente.IdDistrito
            ' Parametros de Salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idPaciente", SqlDbType.Int).Direction = ParameterDirection.Output
            ' Abre la conexión
            conection.Open()
            comando.ExecuteNonQuery()
            conection.Close()

            If comando.Parameters("@idPaciente").Value <> 0 Then
                Return comando.Parameters("@idPaciente").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 0
        End Try
    End Function

    Public Function ListarPacientes() As List(Of Objetos.Paciente)
        Try
            Dim _DataSet As New DataSet()
            Dim listaPacientes As New List(Of Objetos.Paciente)
            Dim comando As New SqlCommand()
            comando.CommandText = "select * from Pacientes where idPaciente > 0 "
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            ' Ejecutar el comando en la  DB
            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(_DataSet, "Pacientes")
            conection.Close()
            ' creación de lista de objetos
            For Each row In _DataSet.Tables(0).Rows
                Dim tmpObject As New Objetos.Paciente
                tmpObject.idPaciente = Integer.Parse(row(0))
                tmpObject.Nombre = row(1)
                tmpObject.Apellidos = row(2)
                tmpObject.Identificacion = row(3)
                tmpObject.TipoIdentificacion = row(4)
                tmpObject.Sexo = row(5)
                tmpObject.EstadoCivil = row(6)
                tmpObject.Nacionalidad = row(7)
                tmpObject.FechaNacimiento = DateTime.Parse(row(8))
                tmpObject.NumeroTelefonico = Integer.Parse(row(9))
                tmpObject.Correo = row(10)
                tmpObject.EstaActivo = Boolean.Parse(row(11))
                Dim expediente As New Objetos.ExpedienteMedico()
                expediente.idExpediente = Integer.Parse(row(12))
                tmpObject.Expediente = expediente
                tmpObject.IdDistrito = Integer.Parse(row(13))
                listaPacientes.Add(tmpObject)
            Next
            Return listaPacientes
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Paciente)
        End Try
    End Function

    Public Function ObtenerPacientePorId(id As Integer) As Objetos.Paciente
        Try
            Dim _dataset As New DataSet()
            Dim Paciente As New Objetos.Paciente()
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM PACIENTES WHERE idPaciente = " + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            ' Open the connection with sql server
            conection.Open()
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(_dataset, "Pacientes")
            conection.Close()

            For Each row In _dataset.Tables(0).Rows
                Paciente.idPaciente = Integer.Parse(row(0))
                Paciente.Nombre = row(1)
                Paciente.Apellidos = row(2)
                Paciente.Identificacion = row(3)
                Paciente.TipoIdentificacion = row(4)
                Paciente.Sexo = row(5)
                Paciente.EstadoCivil = row(6)
                Paciente.Nacionalidad = row(7)
                Paciente.FechaNacimiento = row(8)
                Paciente.NumeroTelefonico = Integer.Parse(row(9))
                Paciente.Correo = row(10)
                Paciente.EstaActivo = Boolean.Parse(row(11))
                Dim expediente As New Objetos.ExpedienteMedico
                expediente.idExpediente = Integer.Parse(row(12))
                Paciente.Expediente = expediente
                Paciente.IdDistrito = Integer.Parse(row(13))
            Next
            Return Paciente
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ObtenerListaPacientes() As List(Of Objetos.Paciente)
        Try
            Dim _dataSet As New DataSet()
            Dim listaPacientes As New List(Of Objetos.Paciente)
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Pacientes"
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(_dataSet, "Pacientes")
            conection.Close()
            For Each datarow In _dataSet.Tables(0).Rows
                Dim tmp As New Objetos.Paciente
                tmp.idPaciente = Integer.Parse(datarow(0))
                tmp.Nombre = datarow(1)
                tmp.Apellidos = datarow(2)
                tmp.Identificacion = datarow(3)
                tmp.TipoIdentificacion = datarow(4)
                tmp.Sexo = datarow(5)
                tmp.EstadoCivil = datarow(6)
                tmp.Nacionalidad = datarow(7)
                tmp.FechaNacimiento = datarow(8)
                tmp.NumeroTelefonico = Integer.Parse(datarow(9))
                tmp.Correo = datarow(10)
                tmp.EstaActivo = datarow(11)
                tmp.IdDistrito = Integer.Parse(datarow(12))
                listaPacientes.Add(tmp)
            Next
            Return listaPacientes
        Catch ex As Exception
            Return New List(Of Objetos.Paciente)
        End Try
    End Function

    Public Function BorrarPaciente(idPaciente As Integer) As Integer
        Try
            Dim _comando As New SqlCommand()
            _comando.CommandText = "[dbo].[EliminarPaciente]"
            _comando.CommandType = CommandType.StoredProcedure
            _comando.Connection = conection
            'son parametros de entrada (envia el id al procedimiento)
            _comando.Parameters.Add("@idPaciente", SqlDbType.Int).Value = idPaciente
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

    Public Function ActualizarPaciente(paciente As Objetos.Paciente) As Boolean
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[PacientesActualizar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conection
            'Parametros Entrada
            comando.Parameters.Add("@idPaciente", SqlDbType.Int).Value = paciente.idPaciente
            comando.Parameters.Add("@_Nombre", SqlDbType.VarChar, 25).Value = paciente.Nombre
            comando.Parameters.Add("@_Apellidos", SqlDbType.VarChar, 50).Value = paciente.Apellidos
            comando.Parameters.Add("@_Identificacion", SqlDbType.VarChar, 30).Value = paciente.Identificacion
            comando.Parameters.Add("@_TipoIdentificacion", SqlDbType.VarChar, 15).Value = paciente.TipoIdentificacion
            comando.Parameters.Add("@_Sexo", SqlDbType.VarChar, 15).Value = paciente.Sexo
            comando.Parameters.Add("@_EstadoCivil", SqlDbType.VarChar, 15).Value = paciente.EstadoCivil
            comando.Parameters.Add("@_Nacionalidad", SqlDbType.VarChar, 15).Value = paciente.Nacionalidad
            comando.Parameters.Add("@_FechaNacimiento", SqlDbType.Date).Value = paciente.FechaNacimiento
            comando.Parameters.Add("@_NumeroTelefonico", SqlDbType.Int).Value = paciente.NumeroTelefonico
            comando.Parameters.Add("@_Correo", SqlDbType.VarChar, 40).Value = paciente.Correo
            comando.Parameters.Add("@_EstaActivo", SqlDbType.Bit).Value = paciente.EstaActivo
            comando.Parameters.Add("@_IdDistrito", SqlDbType.Int).Value = paciente.IdDistrito
            ' Parametros salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@Editado", SqlDbType.Bit).Direction = ParameterDirection.Output
            ' Conexion
            conection.Open()
            comando.ExecuteNonQuery()
            conection.Close()
            '
            If comando.Parameters("@Editado").Value Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
