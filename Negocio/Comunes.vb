Imports AccesoDatos
Imports Objetos

Public Class Comunes


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
