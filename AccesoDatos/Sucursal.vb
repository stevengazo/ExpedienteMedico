Imports Objetos
Imports System.Collections.ObjectModel
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Sucursal
    Private conexion As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function ListarSucursales() As List(Of Objetos.Sucursal)
        Try
            Dim data As New DataSet()
            Dim listaSucursales As New List(Of Objetos.Sucursal)
            Dim comando As New SqlCommand()
            comando.CommandText = "select * from Sucursal"
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            conexion.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Especialidad")
            conexion.Close()
            For Each mydatarow In data.Tables(0).Rows
                Dim tmp As New Objetos.Sucursal
                tmp.idSucursal = Integer.Parse(mydatarow(0))
                tmp.Nombre = mydatarow(1)
                listaSucursales.Add(tmp)
            Next
            Return listaSucursales
        Catch ex As Exception
            Return New List(Of Objetos.Sucursal)
        End Try
    End Function


    Public Function ObtenerRegistro(id As Integer) As Objetos.Sucursal
        Try
            Dim data As New DataSet()
            Dim Sucursal As New Objetos.Sucursal
            Dim comando As New SqlCommand()
            comando.CommandText = "select * from Sucursal where idSucursal= " + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            conexion.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Sucursal")
            conexion.Close()
            For Each mydatarow In data.Tables(0).Rows
                Sucursal.idSucursal = Integer.Parse(mydatarow(0))
                Sucursal.Nombre = mydatarow(1)
            Next
            Return Sucursal
        Catch ex As Exception
            Return New Objetos.Sucursal()
        End Try
    End Function
End Class
