Imports Negocio
Public Class VerMedicamentos
    Dim NegocioMedi As New Negocio.MedicamentoNegocios
    Private Sub VerMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim tmpNegocios As New Negocio.MedicamentoNegocios
            Dim listaMedi As List(Of Objetos.Medicamento)
            listaMedi = tmpNegocios.ListaMedicamento()

            If listaMedi.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("CasaFarmaceutica")
                _tabla.Columns.Add("Descripcion")

                For Each objM As Objetos.Medicamento In listaMedi
                    _tabla.Rows.Add(objM.idMedicamento, objM.Nombre, objM.CasaFarmaceutica, objM.Descripcion)
                Next

                dgListaMedicamentos.Columns.Clear()
                dgListaMedicamentos.DataSource = _tabla

                Dim buttonVer As New DataGridViewButtonColumn
                buttonVer.HeaderText = "Actualizar"
                buttonVer.Text = "Actualizar"
                buttonVer.Name = "btnActualizar"
                buttonVer.UseColumnTextForButtonValue = True
                dgListaMedicamentos.Columns.Add(buttonVer)


                Dim buttonBorrar As New DataGridViewButtonColumn
                buttonBorrar.HeaderText = "Borrar"
                buttonBorrar.Text = "Borrar"
                buttonBorrar.Name = "Borrar"
                buttonBorrar.UseColumnTextForButtonValue = True
                dgListaMedicamentos.Columns.Add(buttonBorrar)


            End If


        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub dgListaMedicamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaMedicamentos.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim row = dgListaMedicamentos.Rows(e.RowIndex)
            Dim cells = row.Cells

            Dim id = Integer.Parse(cells.Item(0).Value)
            Dim bandera = NegocioMedi.BorrarMedicamento(id)
            If bandera Then
                Dim tmpNegocios As New Negocio.MedicamentoNegocios
                Dim listamedi As List(Of Objetos.Medicamento)
                listamedi = tmpNegocios.ListaMedicamento()

                If listamedi.Count > 0 Then
                    Dim _tabla As New DataTable
                    _tabla.Columns.Add("Id")
                    _tabla.Columns.Add("Nombre")
                    _tabla.Columns.Add("CasaFarmaceutica")
                    _tabla.Columns.Add("Despcripcion")

                    For Each objM As Objetos.Medicamento In listamedi
                        _tabla.Rows.Add(objM.idMedicamento, objM.Nombre, objM.CasaFarmaceutica, objM.Descripcion)
                    Next

                    dgListaMedicamentos.Columns.Clear()
                    dgListaMedicamentos.DataSource = _tabla

                    Dim buttonVer As New DataGridViewButtonColumn
                    buttonVer.HeaderText = "Actualizar"
                    buttonVer.Text = "Actualizar"
                    buttonVer.Name = "btnActualizar"
                    buttonVer.UseColumnTextForButtonValue = True
                    dgListaMedicamentos.Columns.Add(buttonVer)


                    Dim buttonBorrar As New DataGridViewButtonColumn
                    buttonBorrar.HeaderText = "Borrar"
                    buttonBorrar.Text = "Borrar"
                    buttonBorrar.Name = "Borrar"
                    buttonBorrar.UseColumnTextForButtonValue = True
                    dgListaMedicamentos.Columns.Add(buttonBorrar)

                End If
            Else
                MessageBox.Show("Error al borrar auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub
End Class