Imports System.Data.SqlClient
Imports Objetos
Public Class Distrito
    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

    ''' <summary>
    ''' Obtiene una lista de distritos según un cantón especifico
    ''' </summary>
    ''' <param name="idCanton">id Del cantona a buscar</param>
    ''' <returns>lista de tipo distritos</returns>
    Public Function ObtenerDistriosPorCanton(idCanton As String) As List(Of Objetos.Distrito)
        Try
            Dim data As New DataSet()
            Dim listaCantones As New List(Of Objetos.Distrito)
            ''
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Distrito where IdCanton = " + idCanton
            comando.CommandType = CommandType.Text
            comando.Connection = conection


            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Distrito")
            conection.Close()

            For Each mydatarow In data.Tables(0).Rows
                Dim tmpObject As New Objetos.Distrito
                tmpObject.IdDistrito = mydatarow(0)
                tmpObject.Nombre = mydatarow(1)
                listaCantones.Add(tmpObject)
            Next
            Return listaCantones

        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Distrito)
        End Try
    End Function


    Public Function ObtenerDistrito(idDistrito As Integer) As Objetos.Distrito
        Try
            Dim data As New DataSet()
            Dim distrito As New Objetos.Distrito()
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM Distrito WHERE Distrito.IdDistrito = " + idDistrito.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Distrito")
            conection.Close()
            For Each mydatarow In data.Tables(0).Rows
                distrito.IdDistrito = Integer.Parse(mydatarow(0))
                distrito.Nombre = mydatarow(1)
                distrito.idCanton = Integer.Parse(mydatarow(2))
            Next
            Return distrito
        Catch ex As Exception
            Return New Objetos.Distrito
        End Try
    End Function

End Class
