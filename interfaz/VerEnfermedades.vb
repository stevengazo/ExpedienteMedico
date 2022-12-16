Imports Negocio
Imports Objetos
Imports System.Net.Security
Imports System.Linq
Imports System.IO
Imports System.Threading

Public Class VerEnfermedades
    Dim NegocioEnfe As New Negocio.EnfermedadNegocio
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
                    If objE.idEnfermedad > 0 Then
                        _tabla.Rows.Add(objE.idEnfermedad, objE.Nombre, objE.Descripcion, objE.sintomas)
                    End If

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

    Private Sub dgListaEnfermedades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaEnfermedades.CellContentClick
        Dim id = Integer.Parse(dgListaEnfermedades.Rows.Item(e.RowIndex).Cells(0).Value)
        Dim NegociosEnfe As New Negocio.EnfermedadNegocio
        'Dim Enfermedad = NegociosEnfe.ObtenerEnfermedad(id)
        TEMPORAL.Enfermedad = Enfermedad
        Select Case e.ColumnIndex
            ' Ver Enfermedad
            Case 4
                VerEnfermedad.Show()
            ' borrar
            Case 5
                Dim row = dgListaEnfermedades.Rows(e.RowIndex)
                Dim cells = row.Cells

                    'Dim Id = Integer.Parse(cells.Item(0).Value)
                    Dim bandera = NegocioEnfe.BorrarEnfermedad(id)
                    If bandera Then
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
                                _tabla.Rows.Add(objE.idEnfermedad, objE.Nombre, objE.Descripcion, objE.sintomas)
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
                    Else
                        MessageBox.Show("Error al borrar la enfermedad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

        End Select



        'If e.ColumnIndex = 5 Then
        '    Dim row = dgListaEnfermedades.Rows(e.RowIndex)
        '    Dim cells = row.Cells

        '    Dim id = Integer.Parse(cells.Item(0).Value)
        '    Dim bandera = NegocioEnfe.BorrarEnfermedad(id)
        '    If bandera Then
        '        Dim tmpNegocios As New Negocio.EnfermedadNegocio
        '        Dim listaEnfe As List(Of Objetos.Enfermedad)
        '        listaEnfe = tmpNegocios.ListaEnfermedad()

        '        If listaEnfe.Count > 0 Then
        '            Dim _tabla As New DataTable
        '            _tabla.Columns.Add("Id")
        '            _tabla.Columns.Add("Nombre")
        '            _tabla.Columns.Add("Descrición")
        '            _tabla.Columns.Add("Sintomas")

        '            For Each objE As Objetos.Enfermedad In listaEnfe
        '                _tabla.Rows.Add(objE.idEnfermedad, objE.Nombre, objE.Descripcion, objE.sintomas)
        '            Next

        '            dgListaEnfermedades.Columns.Clear()
        '            dgListaEnfermedades.DataSource = _tabla

        '            Dim buttonVer As New DataGridViewButtonColumn
        '            buttonVer.HeaderText = "Ver"
        '            buttonVer.Text = "Ver"
        '            buttonVer.Name = "btnVerPaciente"
        '            buttonVer.UseColumnTextForButtonValue = True
        '            dgListaEnfermedades.Columns.Add(buttonVer)


        '            Dim buttonBorrar As New DataGridViewButtonColumn
        '            buttonBorrar.HeaderText = "Borrar"
        '            buttonBorrar.Text = "Borrar"
        '            buttonBorrar.Name = "Borrar"
        '            buttonBorrar.UseColumnTextForButtonValue = True
        '            dgListaEnfermedades.Columns.Add(buttonBorrar)

        '        End If
        '    Else
        '        MessageBox.Show("Error al borrar la enfermedad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'End If
        'If e.ColumnIndex = 4 Then
        '    VerEnfermedad.Show()
        'End If

    End Sub
End Class