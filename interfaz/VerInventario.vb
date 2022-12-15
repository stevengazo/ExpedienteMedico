Imports Negocio
Imports Objetos
Public Class VerInventario
    Private _Medicamentos As New Negocio.Medicamento()
    Private _Inventario As New Negocio.Inventario()
    Private _Comun As New Negocio.Comunes()
    Private _InventarioItem As New Objetos.InventarioMedico()
    Private _InvHasSucur As New Negocio.InvHasSucur()


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
                End If
            End If





        Catch ex As Exception
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSucursal_Click(sender As Object, e As EventArgs) Handles btnSucursal.Click
        Dim sucursal = _Comun.ListaSucursales().Where(Function(s) s.Nombre.Equals(cbBuscarSucursal.Text)).FirstOrDefault()
        Dim listaInventario = _Inventario.ListaInventarioPorSucursal(sucursal.idSucursal)


        If listaInventario.Count > 0 Then
            Dim _tabla As New DataTable
            _tabla.Columns.Add("Id Interno")
            _tabla.Columns.Add("N° lote")
            _tabla.Columns.Add("Ingreso")
            _tabla.Columns.Add("Vencimiento")
            _tabla.Columns.Add("Refrigeracion")
            _tabla.Columns.Add("Cantidad")
            _tabla.Columns.Add("Medicamento")

            For Each obj As Objetos.InventarioMedico In listaInventario
                obj.Medicamento = _Medicamentos.ObtenerMedicamento(obj.IdMedicamento)
                _tabla.Rows.Add(obj.idInventario.ToString(), obj.NumLote, obj.FechaIngreso.ToShortDateString(), obj.FechaVencimiento.ToShortDateString(), obj.Refrigeracion.ToString(), obj.CantidadDisponible.ToString(), obj.Medicamento.Nombre)
            Next

            dgvInventario.Columns.Clear()
            dgvInventario.DataSource = _tabla

            Dim buttonVer As New DataGridViewButtonColumn
            buttonVer.HeaderText = "Ver"
            buttonVer.Text = "Ver"
            buttonVer.Name = "btnVerDoctor"
            buttonVer.UseColumnTextForButtonValue = True
            dgvInventario.Columns.Add(buttonVer)
        End If
    End Sub
End Class