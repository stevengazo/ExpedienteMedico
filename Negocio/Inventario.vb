Imports Objetos
Imports Negocio
Public Class Inventario
    Private _InventarioAccesoDatos As New AccesoDatos.Inventario()

    Private _Medicos As New Negocio.Medicamento()

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


    Public Function ObtenerInventario(id As Integer) As Objetos.InventarioMedico
        Try
            Dim listaInventario = _InventarioAccesoDatos.ListarRegistros()
            Dim tmpInventario = (From item In listaInventario Where item.idInventario = id Select item).FirstOrDefault()
            Dim medicamento As New Objetos.Medicamento()
            medicamento = _Medicos.ObtenerMedicamento(tmpInventario.IdMedicamento)
            tmpInventario.Medicamento = medicamento
            Return tmpInventario
        Catch ex As Exception
            Return New Objetos.InventarioMedico
        End Try
    End Function

End Class
