Imports Negocio
Imports Objetos
Public Class VerInventarioMedicamento
    Private _InventarioMedicamentoNegocio As New Negocio.Inventario
    Private _InventarioMedicamento As New Objetos.InventarioMedico


    Private Sub VerInventarioMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInformación()
    End Sub

    Private Sub CargarInformación()
        Try

            Dim InventarioItem = TEMPORAL.InventarioMedicamento

            lblCantidad.Text = InventarioItem.CantidadDisponible
            lblFechaIngreso.Text = InventarioItem.FechaIngreso.ToShortDateString()
            lblFechaVencimiento.Text = InventarioItem.FechaVencimiento.ToShortDateString()
            lblIdInventario.Text = InventarioItem.idInventario.ToString()
            lblNombreSucursal.Text = TEMPORAL.Sucursal.Nombre.ToString()
            lblNumeroLote.Text = InventarioItem.NumLote.ToString()

        Catch ex As Exception
            MessageBox.Show("Error interno", "Error")
        End Try
    End Sub
End Class