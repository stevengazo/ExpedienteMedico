Imports Objetos
Imports Negocio
Public Class VerPaciente
    Dim tmpNegocioPaciente As New Negocio.PacienteNegocio()
    Dim Paciente As New Objetos.Paciente()
    Dim Bandera As Boolean = True

    Private Provincias As New List(Of Objetos.Provincia)
    Private ListaCanton As New List(Of Objetos.Canton)
    Private ListaDistritos As New List(Of Objetos.Distrito)

    Private Sub VerPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Paciente = TEMPORAL.Paciente
        ActualizarPanelInformacion()
        ActualizarPaciente()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Bandera Then
            PanelEditable.BringToFront()
            PanelInformacion.SendToBack()
            Bandera = False
            btnEditar.Text = "Actualizar Información"

        Else

            Paciente.Nombre = txtNombrePaciente.Text
            Paciente.Apellidos = txtApellidosPaciente.Text
            Paciente.Identificacion = txtIdenPaciente.Text
            Paciente.TipoIdentificacion = cbTipoIdenPaciente.Text
            Paciente.Sexo = cbSexoPaciente.Text
            Paciente.EstadoCivil = cbEstadoCivilPaciente.Text
            Paciente.Nacionalidad = txtNacionalidadPaciente.Text
            Paciente.NumeroTelefonico = txtTelefonoPaciente.Text
            Paciente.Distrito.Nombre = cbDistrito.Text
            Paciente.Distrito.Canton.Canton = cbCanton.Text
            Paciente.Distrito.Canton.Provincia.Nombre = cbProvincia.Text



            Dim flag = tmpNegocioPaciente.ActualizarPaciente(Paciente)
            If flag Then
                PanelEditable.SendToBack()
                Bandera = True
                btnEditar.Text = "Editar información"
                ActualizarPaciente()
                ActualizarPanelInformacion()
                PanelInformacion.BringToFront()
                MessageBox.Show("Paciente actualizado correctamente", "Información", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub ActualizarPanelInformacion()
        lblNombre.Text = Paciente.Nombre
        lblApellidos.Text = Paciente.Apellidos
        lblEstadoCivil.Text = Paciente.EstadoCivil
        lblIdentificación.Text = Paciente.Identificacion
        lblTipoIdentificación.Text = Paciente.TipoIdentificacion
        lblCorreo.Text = Paciente.Correo
        lblProvincia.Text = Paciente.Distrito.Canton.Provincia.Nombre
        lblCantón.Text = Paciente.Distrito.Canton.Canton
        lblDistrito.Text = Paciente.Distrito.Nombre
        lblFechaNacimiento.Text = Paciente.FechaNacimiento.ToLongDateString()
        lblNacionalidad.Text = Paciente.Nacionalidad
        lblSexo.Text = Paciente.Sexo
        lblContacto.Text = Paciente.NumeroTelefonico
    End Sub
    Private Sub ActualizarPaciente()
        Dim Negocios As New Negocio.Comunes
        Provincias = Negocios.ListarProvincias()
        For Each Provincia As Objetos.Provincia In Provincias
            cbProvincia.Items.Add(Provincia.Nombre)
        Next

        txtApellidosPaciente.Text = Paciente.Apellidos
        txtNombrePaciente.Text = Paciente.Nombre
        txtIdenPaciente.Text = Paciente.Identificacion
        txtTelefonoPaciente.Text = Paciente.NumeroTelefonico
        txtNacionalidadPaciente.Text = Paciente.Nacionalidad
        cbCanton.Text = Paciente.Distrito.Canton.Canton
        cbDistrito.Text = Paciente.Distrito.Nombre
        cbProvincia.Text = Paciente.Distrito.Canton.Provincia.Nombre
        cbEstadoCivilPaciente.Text = Paciente.EstadoCivil
        cbSexoPaciente.Text = Paciente.Sexo
        cbTipoIdenPaciente.Text = Paciente.TipoIdentificacion
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cbProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedValueChanged
        Dim comunes As New Negocio.Comunes
        cbDistrito.Items.Clear()
        Dim provinciaSeleccionada As String = cbProvincia.Text
        For Each provincia In Provincias
            If provincia.Nombre.Equals(provinciaSeleccionada) Then
                cbCanton.SelectedIndex = -1
                cbCanton.Items.Clear()
                If ListaCanton.Count() > 0 Then
                    ListaCanton.Clear()
                End If

                ListaCanton = Comunes.ListarCantonesPorProvincia(provincia.IdProvincia)
                For Each canton In ListaCanton
                    cbCanton.Items.Add(canton.Canton)
                Next
            End If
        Next
    End Sub

    Private Sub cbCanton_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbCanton.SelectedValueChanged
        Dim canton As String = cbCanton.Text
        For Each _canton As Objetos.Canton In ListaCanton
            If _canton.Canton.Equals(canton) Then
                Dim tmpcomun As New Negocio.Comunes
                ListaDistritos.Clear()
                ListaDistritos = tmpcomun.ListarDistritosPorCanton(_canton.IdCanton)
                For Each item In ListaDistritos
                    cbDistrito.Items.Add(item.Nombre)
                Next
            End If
        Next
    End Sub

    Private Sub cbDistrito_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbDistrito.SelectedValueChanged
        Dim distrito As String = cbDistrito.Text
        For Each _distrito As Objetos.Distrito In ListaDistritos
            If _distrito.Nombre.Equals(distrito) Then
                Paciente.IdDistrito = _distrito.IdDistrito
                Dim Negocios As New Negocio.Comunes
                Paciente.Distrito = Negocios.ObtenerDistrito(_distrito.IdDistrito)
            End If
        Next
    End Sub

End Class
