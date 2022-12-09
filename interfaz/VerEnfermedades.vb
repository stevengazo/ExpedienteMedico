Public Class VerEnfermedades
    Private Sub VerEnfermedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim tmpNegocios As New Negocio.EnfermedadNegocio
            Dim listaEnfe As List(Of Objetos.Enfermedad)
            listaEnfe = tmpNegocios.ListaEnfermedad()

            If listaEnfe.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Descrición")
                _tabla.Columns.Add("Sintomas")

                For Each objE As Objetos.Enfermedad In listaEnfe
                    _tabla.Rows.Add(objE.id, objE.Nombre, objE.Descripcion, objE.sintomas)
                Next

                dgListaEnfermedades.Columns.Clear()
                dgListaEnfermedades.DataSource = _tabla

                Dim buttonVer As New DataGridViewButtonColumn
                buttonVer.HeaderText = "Ver"
                buttonVer.Text = "Ver"
                buttonVer.Name = "btnVerPaciente"
                buttonVer.UseColumnTextForButtonValue = True
                dgListaEnfermedades.Columns.Add(buttonVer)


                Dim buttonBorrar As New DataGridViewButtonColumn
                buttonBorrar.HeaderText = "Borrar"
                buttonBorrar.Text = "Borrar"
                buttonBorrar.Name = "Borrar"
                buttonBorrar.UseColumnTextForButtonValue = True
                dgListaEnfermedades.Columns.Add(buttonBorrar)

            End If


        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class