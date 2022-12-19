Imports Negocio
Imports Objetos

Public Class AgregarReceta
    Private _NegoInventario As New Negocio.Inventario
    Private _Inventario As New List(Of Objetos.InventarioMedico)
    Private _InventarioSeleccionados As New List(Of Objetos.InventarioMedico)
    Private _NegoReceta As New Negocio.Receta
    Private _NegoRecetaInventario As New Negocio.ReceHasInv

    Private Sub AgregarReceta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaDatos()
    End Sub

    Private Sub CargaDatos()
        cbMedicamentos.Items.Clear()
        _Inventario = _NegoInventario.ListaInventarioPorSucursal(TEMPORAL.Sucursal.idSucursal)
        cbMedicamentos.Items.Clear()
        If _Inventario.Count Then
            For Each itm In _Inventario
                cbMedicamentos.Items.Add(itm.Medicamento.Nombre)
            Next
        End If
    End Sub

    Private Sub cbMedicamentos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbMedicamentos.SelectedValueChanged
        cbCantidad.Items.Clear()
        cbCantidad.SelectedText = String.Empty
        cbCantidad.SelectedIndex = -1
        Dim item = cbMedicamentos.Text
        Dim regi = (From medi In _Inventario
                    Where medi.Medicamento.Nombre = item
                    Select medi).FirstOrDefault()
        For index = 1 To regi.CantidadDisponible
            cbCantidad.Items.Add(index)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not String.IsNullOrEmpty(txtIndicaciones.Text) Then
            If _InventarioSeleccionados.Count <= 0 Then
                MessageBox.Show("No hay medicamentos agregados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' genero una receta y recivo el id
                Dim receta As New Objetos.Receta
                receta.Fecha = DateTime.Now
                receta.FechaVencimiento = dtpFechaVencimiento.Value
                receta.Indicaciones = txtIndicaciones.Text
                receta.idReceta = _NegoReceta.AgregarReceta(receta)
                ' vincula los medicamentos en inventario seleccionados
                If receta.idReceta > 0 Then
                    TEMPORAL.RegistroTemp.idReceta = receta.idReceta
                    For Each i In _InventarioSeleccionados
                        Dim receinve As New Objetos.ReceHasMedi(receta.idReceta, i.CantidadDisponible, i.idInventario)
                        _NegoRecetaInventario.IngresarRecetaInventario(receinve)

                    Next
                    MessageBox.Show("Elementos Agregados", "Error")
                    Me.Close()

                Else
                    MessageBox.Show("Error interno", "Error")
                End If
            End If
        Else
            MessageBox.Show("Indicaciones vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAgregarMedicamento_Click(sender As Object, e As EventArgs) Handles btnAgregarMedicamento.Click
        Try
            If Not cbMedicamentos.Text = Nothing And Not cbCantidad.Text = Nothing Then
                Dim nombreMedicamento = cbMedicamentos.Text
                Dim cantidad = Integer.Parse(cbCantidad.Text)
                For Each item In _Inventario
                    If item.Medicamento.Nombre.Equals(nombreMedicamento) Then
                        Dim existe = (From i In _InventarioSeleccionados Where i.IdMedicamento = item.idInventario Select i).Count()
                        If existe > 0 Then
                            MessageBox.Show("Elemento ya agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            item.CantidadDisponible = cantidad
                            _InventarioSeleccionados.Add(item)
                            cargarMedicamento()
                        End If
                    End If
                Next
            Else
                MessageBox.Show("Medicamento no seleccionado", "Error")
            End If
        Catch ex As Exception
            MessageBox.Show("Error interno", "Error")
        End Try
    End Sub

    Private Sub AgregarReceta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TEMPORAL.InventarioMedicamento = New InventarioMedico()

    End Sub


    Private Sub cargarMedicamento()
        Try
            If _InventarioSeleccionados.Count > 0 Then
                dgvMedicamentos.Columns.Clear()
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id Inventario")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Cantidad")
                For Each obj As Objetos.InventarioMedico In _InventarioSeleccionados
                    _tabla.Rows.Add(obj.idInventario, obj.Medicamento.Nombre, obj.CantidadDisponible.ToString())
                Next
                dgvMedicamentos.DataSource = _tabla
                Dim buttonVer As New DataGridViewButtonColumn
                buttonVer.HeaderText = "Eliminar"
                buttonVer.Text = "Eliminar"
                buttonVer.Name = "btnEliminar"
                buttonVer.UseColumnTextForButtonValue = True
                dgvMedicamentos.Columns.Add(buttonVer)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar medicamento", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub dgvMedicamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicamentos.CellContentClick
        Try
            Select Case e.ColumnIndex
                Case 3
                    Dim id = Integer.Parse(dgvMedicamentos.Rows(e.RowIndex).Cells.Item(0).Value)
                    Dim itemp = (From item In _InventarioSeleccionados Where item.idInventario = id Select item).FirstOrDefault()
                    _InventarioSeleccionados.Remove(itemp)
                    cargarMedicamento()
            End Select
        Catch ex As Exception
            MessageBox.Show("Error interno", "Error")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class