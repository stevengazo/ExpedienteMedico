Imports System.Diagnostics.Contracts
Imports Negocio
Imports Objetos
Public Class ModoMedicos
    Private Sub Medicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tmpNegocios As New Negocio.PacienteNegocio
            Dim listaPaciente As List(Of Objetos.Paciente)
            listaPaciente = tmpNegocios.ObtenerPacientes()

            If listaPaciente.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id Interno")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Apellidos")
                _tabla.Columns.Add("Identificación")
                _tabla.Columns.Add("TipoIdentificación")
                _tabla.Columns.Add("Sexo")
                _tabla.Columns.Add("FechaNacimiento")
                _tabla.Columns.Add("Número")
                _tabla.Columns.Add("Correo")

                For Each objP As Objetos.Paciente In listaPaciente
                    _tabla.Rows.Add(objP.idPaciente, objP.Nombre, objP.Apellidos, objP.Identificacion, objP.TipoIdentificacion, objP.Sexo, objP.FechaNacimiento, objP.NumeroTelefonico, objP.Correo)
                Next

                dgListaPacientes.Columns.Clear()
                dgListaPacientes.DataSource = _tabla

                Dim buttonExpediente As New DataGridViewButtonColumn
                buttonExpediente.HeaderText = "Expediente"
                buttonExpediente.Text = "Expediente"
                buttonExpediente.Name = "btnExpediente"
                buttonExpediente.UseColumnTextForButtonValue = True
                dgListaPacientes.Columns.Add(buttonExpediente)


                Dim buttonVer As New DataGridViewButtonColumn
                buttonVer.HeaderText = "Ver"
                buttonVer.Text = "Ver Paciente"
                buttonVer.Name = "btnVerPaciente"
                buttonVer.UseColumnTextForButtonValue = True
                dgListaPacientes.Columns.Add(buttonVer)


                Dim buttonBorrar As New DataGridViewButtonColumn
                buttonBorrar.HeaderText = "Borrar"
                buttonBorrar.Text = "Borrar"
                buttonBorrar.Name = "Borrar"
                buttonBorrar.UseColumnTextForButtonValue = True
                dgListaPacientes.Columns.Add(buttonBorrar)

            End If


        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub CargarDatos()
        Try
            Dim negociosPacientes As New Negocio.PacienteNegocio()
            Dim listaPacientes = negociosPacientes.ObtenerPacientes()

            If listaPacientes.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id Interno")
                _tabla.Columns.Add("Identificación")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Apellidos")
                _tabla.Columns.Add("Sexo")
                _tabla.Columns.Add("Número")
                _tabla.Columns.Add("Correo")

                For Each objPaciente As Objetos.Paciente In listaPacientes
                    _tabla.Rows.Add(objPaciente.idPaciente, objPaciente.Identificacion, objPaciente.Nombre, objPaciente.Apellidos, objPaciente.Sexo, objPaciente.NumeroTelefonico, objPaciente.Correo)
                Next

                dgListaPacientes.Columns.Clear()
                dgListaPacientes.DataSource = _tabla

                Dim buttonVer As New DataGridViewButtonColumn
                buttonVer.HeaderText = "Ver"
                buttonVer.Text = "Ver"
                buttonVer.Name = "btnVerDoctor"
                buttonVer.UseColumnTextForButtonValue = True
                dgListaPacientes.Columns.Add(buttonVer)


                Dim buttonBorrar As New DataGridViewButtonColumn
                buttonBorrar.HeaderText = "Borrar"
                buttonBorrar.Text = "Borrar"
                buttonBorrar.Name = "Borrar"
                buttonBorrar.UseColumnTextForButtonValue = True
                dgListaPacientes.Columns.Add(buttonBorrar)

            End If
        Catch ex As Exception
            MessageBox.Show("Error interno:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgListaPacientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListaPacientes.CellContentClick
        Dim id = Integer.Parse(dgListaPacientes.Rows.Item(e.RowIndex).Cells(0).Value)
        Dim tmpNegocios As New Negocio.PacienteNegocio
        Dim Paciente = tmpNegocios.ObtenerPaciente(id)
        Select Case e.ColumnIndex
            ' Ver Expediente
            Case 9
                VerExpediente.ShowDialog()
            ' Ver Paciente
            Case 10
                VerPaciente.Show()
            ' Borrar Paciente
            Case 11
                Dim respuestaBorrar = MessageBox.Show("Deseas Borrar este Paciente " + Paciente.Nombre + " " + Paciente.Apellidos + "de la Base de Datos", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If DialogResult.Yes = respuestaBorrar Then
                    'Intenta Borrarlo
                    MessageBox.Show("Proceso de borrado..", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Else

                End If
        End Select


    End Sub


End Class