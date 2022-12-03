Imports System.Data.SqlClient
Imports Objetos

Public Class Canton
    Dim conection As New SqlConnection("Data Source=127.0.0.1;Initial Catalog=Proyecto_Hospital;Persist Security Info=True;User ID=sa;Password=Password123")


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
End Class
