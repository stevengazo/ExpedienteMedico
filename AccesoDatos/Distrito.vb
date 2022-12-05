Imports System.Data.SqlClient
Imports Objetos
Public Class Distrito
    Dim conection As New SqlConnection("Data Source=127.0.0.1;Initial Catalog=Proyecto_Hospital;Persist Security Info=True;User ID=sa;Password=Password123")

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

End Class
