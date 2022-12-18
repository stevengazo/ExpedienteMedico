Imports Negocio
Imports Objetos
Public Class VerInventario
    Private _Medicamentos As New Negocio.Medicamento()
    Private _Inventario As New Negocio.Inventario()
    Private _Comun As New Negocio.Comunes()
    Private _InventarioItem As New Objetos.InventarioMedico()
    Private _InvHasSucur As New Negocio.InvHasSucur()

    Private _sucursal As New Objetos.Sucursal
    Private _listaInventario As New List(Of Objetos.InventarioMedico)


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        PanelActualizar.SendToBack()
    End Sub

    Private Sub VerInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarElementos()
    End Sub
    Private Sub CargarElementos()
        Dim ListaMedicamentos = _Medicamentos.ListarMedicamentos()
        cbMedicamento.Items.Clear()
        For Each item As Objetos.Medicamento In ListaMedicamentos
            If item.idMedicamento <> 0 And Not String.IsNullOrEmpty(item.Nombre) Then
                cbMedicamento.Items.Add(item.Nombre)
            End If
        Next
        Dim sucursales = _Comun.ListaSucursales()
        cbBuscarSucursal.Items.Clear()
        cbSucursal.Items.Clear()
        For Each item As Objetos.Sucursal In sucursales
            If item.idSucursal <> 0 Then
                cbSucursal.Items.Add(item.Nombre)
                cbBuscarSucursal.Items.Add(item.Nombre)
            End If
        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim listaMed = _Medicamentos.ListarMedicamentos()
            For Each medi In listaMed
                If medi.Nombre.Equals(cbMedicamento.Text) Then
                    _InventarioItem.IdMedicamento = medi.idMedicamento
                End If
            Next
            _InventarioItem.CantidadDisponible = numCantidad.Value
            _InventarioItem.NumLote = txtLote.Text
            _InventarioItem.FechaIngreso = dtpIngreso.Value
            _InventarioItem.FechaVencimiento = dtpVencimiento.Value
            _InventarioItem.Refrigeracion = cBoxRefrigeracion.Checked
            Dim listaSucur = _Comun.ListaSucursales().Where(Function(x) x.Nombre.Equals(cbSucursal.Text)).FirstOrDefault()
            Dim id = _Inventario.InsertarInventario(_InventarioItem)
            If id <> 0 Then
                Dim tmpObj As New Objetos.InvHasSucur()
                tmpObj.idSucursal = listaSucur.idSucursal
                tmpObj.idInventario = id
                Dim stado = _InvHasSucur.Agregar(tmpObj)
                If stado Then
                    MessageBox.Show("Inventario agregad", "Información", MessageBoxButtons.OK)
                    _listaInventario = _Inventario.ListaInventarioPorSucursal(tmpObj.idSucursal)
                    CargarTabla()
                    cbSucursal.SelectedText = ""
                End If
            End If





        Catch ex As Exception
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        Dim sucursal = _Comun.ListaSucursales().Where(Function(s) s.Nombre.Equals(cbBuscarSucursal.Text)).FirstOrDefault()
        _listaInventario = _Inventario.ListaInventarioPorSucursal(sucursal.idSucursal)
        CargarTabla()


    End Sub


    Private Sub CargarTabla()
        Try
            If _listaInventario.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Medicamento")
                _tabla.Columns.Add("Ingreso")
                _tabla.Columns.Add("Vencimiento")
                _tabla.Columns.Add("Refrigeracion")
                _tabla.Columns.Add("Cantidad")
                _tabla.Columns.Add("Id Medicamento")
                _tabla.Columns.Add("Id Id Inventrio")
                _tabla.Columns.Add("N° lote")


                For Each obj As Objetos.InventarioMedico In _listaInventario
                    obj.Medicamento = _Medicamentos.ObtenerMedicamento(obj.IdMedicamento)
                    _tabla.Rows.Add(
                        obj.Medicamento.Nombre,
                        obj.FechaIngreso.ToString(),
                        obj.FechaVencimiento.ToString(),
                        obj.Refrigeracion.ToString(),
                        obj.CantidadDisponible.ToString(),
                        obj.Medicamento.idMedicamento,
                        obj.idInventario,
                        obj.NumLote)
                Next

                dgvInventario.Columns.Clear()
                dgvInventario.DataSource = _tabla

                Dim buttonVer As New DataGridViewButtonColumn
                buttonVer.HeaderText = "Ver"
                buttonVer.Text = "Ver"
                buttonVer.Name = "btnVerMedicamento"
                buttonVer.UseColumnTextForButtonValue = True
                dgvInventario.Columns.Add(buttonVer)

                Dim buttonVerInvent As New DataGridViewButtonColumn
                buttonVerInvent.HeaderText = "Medicamento"
                buttonVerInvent.Text = "Medicamento"
                buttonVerInvent.Name = "btnVerMedicamento"
                buttonVerInvent.UseColumnTextForButtonValue = True
                dgvInventario.Columns.Add(buttonVerInvent)

                Dim buttonBOrrar As New DataGridViewButtonColumn
                buttonBOrrar.HeaderText = "Borrar"
                buttonBOrrar.Text = "Borrar"
                buttonBOrrar.Name = "btnBorrar"
                buttonBOrrar.UseColumnTextForButtonValue = True
                dgvInventario.Columns.Add(buttonBOrrar)


            End If
        Catch ex As Exception
            MessageBox.Show("Error cargando tabla", "Error")
        End Try
    End Sub

    Private Sub dgvInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventario.CellContentClick
        Dim idRegistro = Integer.Parse(dgvInventario.Rows(e.RowIndex).Cells.Item(6).Value)
        Dim registroInventario = (From reg As Objetos.InventarioMedico
                                  In _listaInventario
                                  Where reg.idInventario = idRegistro
                                  Select reg).FirstOrDefault()
        Select Case e.ColumnIndex
            ' ver inventario

            Case 8
                TEMPORAL.InventarioMedicamento = registroInventario
                TEMPORAL.Sucursal = New Objetos.Sucursal()
                VerInventarioMedicamento.ShowDialog()
            ' ver medicamento
            Case 9
                TEMPORAL.Medicamento = registroInventario.Medicamento
                VerMedicamento.ShowDialog()
            ' Borrar
            Case 10
                Dim resultado = MessageBox.Show("Deseas borrar este registro de inventario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If resultado Then
                    Dim estadoborrado = False ' llama a funcion
                End If
        End Select
    End Sub




End Class