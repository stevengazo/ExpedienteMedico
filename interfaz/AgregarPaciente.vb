Imports Objetos
Imports Negocio
Public Class AgregarPaciente
    Private Provincias As New List(Of Objetos.Provincia)
    Private ListaCanton As New List(Of Objetos.Canton)
    Private ListaDistritos As New List(Of Objetos.Distrito)
    Private TemporalPaciente As New Objetos.Paciente()
    Private temporalExpediente As New Objetos.ExpedienteMedico()

    ' Conexion con comunes
    Dim comunes As New Negocio.Comunes()

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cbSexoPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSexoPaciente.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub AgregarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProvincias()
    End Sub

    Private Sub cargarProvincias()
        Provincias = Comunes.ListarProvincias()
        For Each provincia As Objetos.Provincia In Provincias
            cbProvincia.Items.Add(provincia.Nombre)
        Next
    End Sub

    Private Sub cbProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedValueChanged
        cbDistrito.Items.Clear()
        Dim provinciaSeleccionada As String = cbProvincia.Text
        For Each provincia In Provincias
            If provincia.Nombre.Equals(provinciaSeleccionada) Then
                cbCanton.SelectedIndex = -1
                cbCanton.Items.Clear()
                If ListaCanton.Count() > 0 Then
                    ListaCanton.Clear()
                End If
                ListaCanton = comunes.ListarCantonesPorProvincia(provincia.IdProvincia)
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
                listaDistritos.Clear()
                listaDistritos = tmpcomun.ListarDistritosPorCanton(_canton.IdCanton)
                For Each item In listaDistritos
                    cbDistrito.Items.Add(item.Nombre)
                Next
            End If
        Next
    End Sub

    Private Sub btnAgregarPaciente_Click(sender As Object, e As EventArgs) Handles btnAgregarPaciente.Click
        Dim banderaExpediente = GenerarExpediente()
        If banderaExpediente Then
            ' asignación de datos de paciente a paciente en memoria
            TemporalPaciente.Nombre = txtNombrePaciente.Text
            TemporalPaciente.Apellidos = txtApellidosPaciente.Text
            TemporalPaciente.Identificacion = txtIdenPaciente.Text
            TemporalPaciente.TipoIdentificacion = cbTipoIdenPaciente.Text
            TemporalPaciente.Sexo = cbSexoPaciente.Text
            TemporalPaciente.EstadoCivil = cbEstadoCivilPaciente.Text
            TemporalPaciente.FechaNacimiento = datePaciente.Value
            TemporalPaciente.Nacionalidad = txtNacionalidadPaciente.Text
            ' la asignación de id distrito se realiza en otro sitio
            TemporalPaciente.NumeroTelefonico = Integer.Parse(txtTelefonoPaciente.Text)
            TemporalPaciente.Correo = txtCorreoPaciente.Text
            If cbSeguro.Text.Equals("No") Then
                TemporalPaciente.EstaActivo = False
            Else
                TemporalPaciente.EstaActivo = True
            End If
            ' envio a negocios e inserción en db
            Dim negocios As New Negocio.PacienteNegocio()
            Dim idPaciente = negocios.AgregarPaciente(TemporalPaciente)
            TemporalPaciente = New Objetos.Paciente()
            If idPaciente <> 0 Then
                MessageBox.Show("Usuario Agregado. Id interno: " + idPaciente.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function GenerarExpediente() As Boolean
        Try
            Dim negocio As New Negocio.Comunes
            temporalExpediente.idExpediente = negocio.GenerarExpediente()
            If temporalExpediente.idExpediente <> 0 Then
                TemporalPaciente.Expediente = temporalExpediente
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error generando expediente. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub cbDistrito_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbDistrito.SelectedValueChanged
        Dim distrito As String = cbDistrito.Text
        For Each _distrito As Objetos.Distrito In ListaDistritos
            If _distrito.Nombre.Equals(distrito) Then
                TemporalPaciente.IdDistrito = _distrito.IdDistrito
            End If
        Next
    End Sub


End Class