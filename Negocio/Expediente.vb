Imports Objetos
Imports AccesoDatos
Public Class Expediente
    Dim _expediente As New AccesoDatos.ExpedienteMedico()

    Public Function ObtenerExpediente(id As Integer) As Objetos.ExpedienteMedico
        Try
            If id = 0 Then
                Return New Objetos.ExpedienteMedico
            Else
                Return _expediente.ObtenerExpediente(id)
            End If
        Catch ex As Exception
            Return New Objetos.ExpedienteMedico
        End Try
    End Function


End Class
