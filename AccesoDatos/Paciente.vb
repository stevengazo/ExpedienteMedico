Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports Objetos.Paciente

Public Class Paciente
    Dim conexion As New SqlConnection(DATOSGENERALES.StringConnection)

    ''' <summary>
    ''' Agrega un nuevo paciente a la DB
    ''' </summary>
    ''' <param name="paciente">Objeto de tipo paciente</param>
    ''' <returns>0 si presenta error</returns>
    Public Function AgregarPaciente(paciente As Objetos.Paciente) As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[PacientesAgregar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
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
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()

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

    ''' <summary>
    ''' Lista los pacientes existentes
    ''' </summary>
    ''' <returns>retorna una lista de tipo objeto Paciente</returns>
    Public Function ListarPacientes() As List(Of Objetos.Paciente)
        Try
            Dim _DataSet As New DataSet()
            Dim listaPacientes As New List(Of Objetos.Paciente)
            Dim comando As New SqlCommand()
            comando.CommandText = " Select * from Pacientes "
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            ' Ejecutar el comando en la  DB
            conexion.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(_DataSet, "Pacientes")
            conexion.Close()
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

End Class
