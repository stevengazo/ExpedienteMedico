Public Class ReceHasMedi
    Public idReceta As Integer
    Public Cantidad As Integer
    Public idInventaio As Integer
    Public Inventario As Objetos.InventarioMedico
    Public Receta As Objetos.Receta()

    Public Sub New()
        idReceta = 0
        Cantidad = 0
        idInventaio = 0

    End Sub
    Public Sub New(_idReceta As Integer, _cantidad As Integer, _idInventario As Integer)
        idReceta = _idReceta
        Cantidad = _cantidad
        idInventaio = _idInventario
    End Sub


End Class
