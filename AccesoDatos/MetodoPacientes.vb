Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Permissions
Imports Objetos

Public Class MetodoPacientes

    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)


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
End Class
