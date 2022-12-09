Imports Negocio
Imports Objetos
Public Class Medicos
    Private Sub Medicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim tmpNegocios As New Negocio.PacienteNegocio
            Dim listaPaciente As List(Of Objetos.Paciente)
            listaPaciente = tmpNegocios.ListaPacientes()

            If listaPaciente.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id Interno")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Apellidos")
                _tabla.Columns.Add("Identificación")
                _tabla.Columns.Add("TipoIdentificación")
                _tabla.Columns.Add("Sexo")
                _tabla.Columns.Add("EstadoCivil")
                _tabla.Columns.Add("Nacionalidad")
                _tabla.Columns.Add("FechaNacimiento")
                _tabla.Columns.Add("Número")
                _tabla.Columns.Add("Correo")
                _tabla.Columns.Add("EstaActivo")
                _tabla.Columns.Add("IdDistrito")

                For Each objP As Objetos.Paciente In listaPaciente
                    _tabla.Rows.Add(objP.idPaciente, objP.Nombre, objP.Apellidos, objP.Identificacion, objP.TipoIdentificacion, objP.Sexo, objP.EstadoCivil, objP.Nacionalidad, objP.FechaNacimiento, objP.NumeroTelefonico, objP.Correo, objP.EstaActivo, objP.IdDistrito)
                Next

                DataGridView1.Columns.Clear()
                DataGridView1.DataSource = _tabla

        Dim buttonVer As New DataGridViewButtonColumn
        buttonVer.HeaderText = "Ver"
        buttonVer.Text = "Ver"
        buttonVer.Name = "btnVerPaciente"
        buttonVer.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(buttonVer)


        Dim buttonBorrar As New DataGridViewButtonColumn
        buttonBorrar.HeaderText = "Borrar"
        buttonBorrar.Text = "Borrar"
        buttonBorrar.Name = "Borrar"
        buttonBorrar.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(buttonBorrar)

        End If


        Catch ex As Exception
        MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub



    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnExpediente.Click
        ExpedientePaciente.Show()
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
End Class