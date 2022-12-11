Imports System.Data.SqlClient
Imports Objetos

Public Class Provincia
    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

    ''' <summary>
    ''' Obtiene una lista de provincias de la DB
    ''' </summary>
    ''' <returns>Lista de objetos de tipo provincia</returns>
    Public Function ObtenerProvincias() As List(Of Objetos.Provincia)
        Try
            Dim data As New DataSet()
            Dim listaProvincias As New List(Of Objetos.Provincia)
            ''
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Provincia"
            comando.CommandType = CommandType.Text
            comando.Connection = conection


            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Provincia")
            conection.Close()

            For Each mydatarow In data.Tables(0).Rows
                Dim tmpObject As New Objetos.Provincia
                tmpObject.IdProvincia = mydatarow(0)
                tmpObject.Nombre = mydatarow(1)
                listaProvincias.Add(tmpObject)
            Next
            Return listaProvincias
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Provincia)
        End Try
    End Function

    ''' <summary>
    ''' Busca una provincia en la base de datos con un id
    ''' </summary>
    ''' <param name="idProvincia">Id de la provincia</param>
    ''' <returns></returns>
    Public Function ObtenerProvincia(idProvincia As Integer) As Objetos.Provincia
        Try

            Dim data As New DataSet()
            Dim Provincia As New Objetos.Provincia
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM Provincia WHERE Provincia.IdProvincia = " + idProvincia.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Provincia")
            conection.Close()
            For Each row In data.Tables(0).Rows
                Provincia.IdProvincia = Integer.Parse(row(0))
                Provincia.Nombre = row(1)
            Next
            Return Provincia
        Catch ex As Exception
            Return New Objetos.Provincia
        End Try
    End Function
End Class
