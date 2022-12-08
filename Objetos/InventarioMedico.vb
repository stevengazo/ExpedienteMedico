Public Class InventarioMedico
    Public idInventario As Integer
    Public NumLote As String
    Public FechaIngreso As DateTime
    Public FechaVencimiento As DateTime
    Public Refrigeracion As Boolean
    Public CantidadDisponible As Integer

    ' Asociación con medicamento
    Public Medicamento As Medicamento
    Public IdMedicamento As Integer
End Class
