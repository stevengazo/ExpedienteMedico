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
            Dim lista = _Medicamento.ListarRegistros()
            Dim listaOrdenada = (From medi In lista
                                 Order By medi.Nombre
                                 Select medi).ToList()
            Return listaOrdenada
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

    Public Function BorrarMedicamento(idMedicamento As Integer) As Boolean
        Try
            Dim codigo As Integer = _Medicamento.BorrarMedicamento(idMedicamento)
            If codigo = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Console.Write(ex.Message)
            Return False
        End Try
    End Function
End Class
