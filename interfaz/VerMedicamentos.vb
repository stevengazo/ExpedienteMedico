Imports Negocio
Imports Objetos

Public Class VerMedicamentos
    Private _MedicamentosNegocios As New Negocio.Medicamento
    Private _listaMedicamentos As New List(Of Objetos.Medicamento)
    Private _MedicamentoSeleccionado As New Objetos.Medicamento

    Private Sub CargarTabla()
        Try
            _listaMedicamentos = _MedicamentosNegocios.ListarMedicamentos()

            If _listaMedicamentos.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id Interno")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Casa Farmaceutica")

                For Each objMedico As Objetos.Medicamento In _listaMedicamentos
                    _tabla.Rows.Add(objMedico.idMedicamento, objMedico.Nombre, objMedico.CasaFarmaceutica)
                Next

                dgListaMedicamentos.Columns.Clear()
                dgListaMedicamentos.DataSource = _tabla

                Dim buttonVer As New DataGridViewButtonColumn
                buttonVer.HeaderText = "Ver"
                buttonVer.Text = "Ver"
                buttonVer.Name = "btnVerDoctor"
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
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub VerMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTabla()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub dgListaMedicamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaMedicamentos.CellContentClick
        Try
            Dim idRegistro = Integer.Parse(dgListaMedicamentos.Rows(e.RowIndex).Cells.Item(0).Value)
            Dim medicamento = (From item In _listaMedicamentos
                               Where item.idMedicamento = idRegistro
                               Select item).FirstOrDefault()

            Select Case e.ColumnIndex

                Case 3
                    TEMPORAL.Medicamento = medicamento
                    VerMedicamento.ShowDialog()
                Case 4
                    Dim resultado = MessageBox.Show("¿Desea eliminar este registro?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If resultado Then
                        ' borrar 
                        Dim resultad1 = _MedicamentosNegocios.BorrarMedicamento(medicamento.idMedicamento)
                        If resultad1 Then
                            MessageBox.Show("Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarTabla()
                        Else
                            MessageBox.Show("Error interno, no es posible borrar el medicamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class