Imports AccesoDatos
Imports Objetos



Public Class Receta
    Private _Comunes As New Negocio.Comunes
    Private _Inventario As New Negocio.Inventario
    Private _accesodatosReceta As New AccesoDatos.Receta

    Public Function AgregarReceta(obj As Objetos.Receta) As Integer
        Try
            Return _accesodatosReceta.InsertarRegistro(obj)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ObtenerReceta(id As Integer) As Objetos.Receta
        Try
            Return _accesodatosReceta.ObtenerRegistro(id)
        Catch ex As Exception
            Return New Objetos.Receta
        End Try
    End Function

    Public Function BorrarReceta(id As Integer) As Boolean
        Try
            Return _accesodatosReceta.BorrarRegistro(id)
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
