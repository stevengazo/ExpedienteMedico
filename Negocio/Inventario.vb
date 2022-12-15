Imports Objetos
Imports Negocio
Public Class Inventario
    Private _InventarioAccesoDatos As New AccesoDatos.Inventario()


    Public Function InsertarInventario(obj As Objetos.InventarioMedico) As Integer
        Try
            Return _InventarioAccesoDatos.AgregarRegistro(obj)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListaInventarioPorSucursal(idSucursal As Integer) As List(Of Objetos.InventarioMedico)
        Try
            Return _InventarioAccesoDatos.ListarRegistros(idSucursal)
        Catch ex As Exception
            Return New List(Of InventarioMedico)
        End Try
    End Function

End Class
