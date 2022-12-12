Imports System.Data.SqlClient
Imports Objetos

Public Class Canton
    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

    ''' <summary>
    ''' Generar una lista de cantones por una provincia en especifico
    ''' </summary>
    ''' <param name="idProvincia">Id de la provincia a buscar</param>
    ''' <returns>Retorna una lista de tipo Canton</returns>
    Public Function ObtenerCantonesPorProvincia(idProvincia As String) As List(Of Objetos.Canton)
        Try
            Dim data As New DataSet()
            Dim listaCantones As New List(Of Objetos.Canton)
            ''
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Canton where IdProvincia = " + idProvincia
            comando.CommandType = CommandType.Text
            comando.Connection = conection


            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Canton")
            conection.Close()

            For Each mydatarow In data.Tables(0).Rows
                Dim tmpObject As New Objetos.Canton
                tmpObject.IdCanton = mydatarow(0)
                tmpObject.Canton = mydatarow(1)
                listaCantones.Add(tmpObject)
            Next
            Return listaCantones
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Canton)
        End Try
    End Function


    Public Function ObtenerCanton(idCanton As Integer) As Objetos.Canton
        Try

            Dim data As New DataSet()
            Dim canton As New Objetos.Canton()
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM Canton WHERE Canton.IdCanton =" + idCanton.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conection
            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Canton")
            conection.Close()
            For Each mydatarow In data.Tables(0).Rows
                canton.IdCanton = Integer.Parse(mydatarow(0))
                canton.Canton = mydatarow(1)
                canton.idProvincia = Integer.Parse(mydatarow(2))
            Next
            Return canton
        Catch ex As Exception
            Return New Objetos.Canton
        End Try
    End Function
End Class
