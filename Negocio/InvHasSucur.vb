Imports AccesoDatos
Imports Objetos
Public Class InvHasSucur
    Private _InvHasSucursal As New AccesoDatos.InvHasSucur()
    Public Function Agregar(obj As Objetos.InvHasSucur) As Boolean
        Try
            Return _InvHasSucursal.agregarRegistro(obj)
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
