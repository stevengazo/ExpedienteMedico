Imports Negocio
Imports Objetos

Public Class VerReceta
    Dim idReceta As Integer
    Dim _receta As New Negocio.Receta
    Dim _RecetaInventario As New Negocio.ReceHasInv
    Dim _receInven As New List(Of Objetos.ReceHasMedi)
    Private Sub VerReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _receInven = _RecetaInventario.ListaRecetasInventario(TEMPORAL.RegistroTemp.idReceta)
        idReceta = TEMPORAL.RegistroTemp.idReceta
        cargarInformacion()
        cargarMedicamento()
    End Sub



    Private Sub cargarInformacion()
        Try
            Dim data = _receta.ObtenerReceta(TEMPORAL.RegistroTemp.idReceta)
            lblFechaRetiro.Text = data.Fecha.ToShortDateString()
            lblFechaVencimiento.Text = data.FechaVencimiento.ToShortDateString()
            txtIndicaciones.Text = data.Indicaciones
            txtIndicaciones.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error interno", "Error")
        End Try
    End Sub

    Private Sub cargarMedicamento()
        Try
            If _receInven.Count() > 0 Then
                'Dim data =
                If _receInven.Count() > 0 Then
                    dgvMedicamentos.Columns.Clear()
                    Dim _tabla As New DataTable
                    _tabla.Columns.Add("Id Inventario")
                    _tabla.Columns.Add("Nombre")
                    _tabla.Columns.Add("Cantidad")
                    For Each obj As Objetos.ReceHasMedi In _receInven
                        _tabla.Rows.Add(obj.idInventaio,
                                         obj.Inventario.Medicamento.Nombre,
                                         obj.Cantidad.ToString())
                    Next

                    dgvMedicamentos.DataSource = _tabla
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar medicamento", "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class