Imports Objetos
Imports AccesoDatos
Public Class Medicamento
    Private _Medicamento As New AccesoDatos.Medicamento()

    Public Function AgregarMedicamento(medicamento As Objetos.Medicamento) As Integer
        Try
            Return _Medicamento.InsertarRegistro(medicamento)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function ListarMedicamentos() As List(Of Objetos.Medicamento)
        Try
            Return _Medicamento.ListarRegistros()
        Catch ex As Exception
            Return New List(Of Objetos.Medicamento)
        End Try
    End Function

    Public Function ObtenerMedicamento(id As Integer) As Objetos.Medicamento
        Try
            Return _Medicamento.ObtenerRegistro(id)
        Catch ex As Exception
            Return New Objetos.Medicamento
        End Try
    End Function

End Class
