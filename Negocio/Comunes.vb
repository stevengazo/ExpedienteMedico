Imports AccesoDatos
Imports Objetos

Public Class Comunes

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

End Class
