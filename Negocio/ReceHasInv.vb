
Imports Objetos
Imports AccesoDatos

Public Class ReceHasInv
    Private _Negocios As New AccesoDatos.ReceHasInve

    Private _NegociosMedicamento As New AccesoDatos.Medicamento
    Private _NegocioInventario As New AccesoDatos.Inventario()
    Public Function IngresarRecetaInventario(obj As Objetos.ReceHasMedi) As Boolean
        Try
            Return _Negocios.InsertarRegistro(obj)

        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function ListaRecetasInventario(idReceta As Integer) As List(Of Objetos.ReceHasMedi)
        Try

            If idReceta <> 0 Then
                Dim data = _Negocios.ObtenerLista(idReceta)
                For Each i In data
                    i.Inventario = _NegocioInventario.ObtenerRegistro(i.idInventaio)
                    i.Inventario.Medicamento = _NegociosMedicamento.ObtenerRegistro(i.Inventario.IdMedicamento)
                Next
                Return data
            Else
                Return New List(Of ReceHasMedi)
            End If

        Catch ex As Exception
            Return New List(Of ReceHasMedi)
        End Try
    End Function


    Public Function IngresarRecetaInventario(lista As List(Of Objetos.ReceHasMedi)) As Boolean
        Try
            For Each item In lista
                _Negocios.InsertarRegistro(item)
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
