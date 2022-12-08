Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Objetos

Public Class MetodoPacientes

    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

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
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Paciente)
        End Try
    End Function
End Class
