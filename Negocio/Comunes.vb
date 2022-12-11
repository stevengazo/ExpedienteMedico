Imports AccesoDatos
Imports Objetos

Public Class Comunes

    Public Function ListaSucursales() As List(Of Objetos.Sucursal)
        Try
            Dim tmpNegocioSucursal As New AccesoDatos.Sucursal
            Return tmpNegocioSucursal.ListarSucursales()
        Catch ex As Exception
            Return New List(Of Objetos.Sucursal)
        End Try
    End Function
    Public Function ObtenerDistrito(id As Integer) As Objetos.Distrito
        Try
            Dim tmpAccesoDatos As New AccesoDatos.Distrito
            Dim distrito As Objetos.Distrito = tmpAccesoDatos.ObtenerDistrito(id)
            Dim tmpcanton As New AccesoDatos.Canton
            Dim canton As Objetos.Canton = tmpcanton.ObtenerCanton(distrito.idCanton)
            Dim tmpProvincia As New AccesoDatos.Provincia
            Dim Provincia As Objetos.Provincia = tmpProvincia.ObtenerProvincia(canton.idProvincia)
            canton.Provincia = Provincia
            distrito.Canton = canton
            Return distrito
        Catch ex As Exception
            Return New Objetos.Distrito()
        End Try
    End Function
    Public Function GenerarExpediente() As Integer
        Try
            Dim tmpComun As New AccesoDatos.ExpedienteMedico
            Return tmpComun.GenerarExpediente()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 0
        End Try
    End Function
    Public Function ListarProvincias() As List(Of Objetos.Provincia)
        Try
            Dim tmpProvincia As New AccesoDatos.Provincia
            Return tmpProvincia.ObtenerProvincias()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Provincia)
        End Try
    End Function

    Public Function ListarCantonesPorProvincia(idProvincia As String) As List(Of Objetos.Canton)
        Try
            Dim tmpComun As New AccesoDatos.Canton
            Return tmpComun.ObtenerCantonesPorProvincia(idProvincia)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Canton)
        End Try
    End Function


    Public Function ListarDistritosPorCanton(idCanton As String) As List(Of Objetos.Distrito)
        Try
            Dim tmpComun As New AccesoDatos.Distrito
            Return tmpComun.ObtenerDistriosPorCanton(idCanton)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Distrito)
        End Try
    End Function
End Class
