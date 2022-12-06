Imports Objetos
Imports Negocio
Public Class AgregarPaciente
    Private Provincias As New List(Of Objetos.Provincia)
    Private ListaCanton As New List(Of Objetos.Canton)
    Private ListaDistritos As New List(Of Objetos.Distrito)
    Private TemporalPaciente As New Objetos.Paciente()

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

        ' asignación de datos de paciente a paciente en memoria
        TemporalPaciente.Nombre = txtNombrePaciente.Text
        TemporalPaciente.Apellidos = txtApellidosPaciente.Text
        TemporalPaciente.Identificacion = txtIdenPaciente.Text
        TemporalPaciente.TipoIdentificacion = cbTipoIdenPaciente.Text
        TemporalPaciente.Sexo = cbSexoPaciente.Text
        TemporalPaciente.EstadoCivil = cbEstadoCivilPaciente.Text
        TemporalPaciente.Nacionalidad = txtNacionalidadPaciente.Text
        ' la asignación de id distrito se realiza en otro sitio
        TemporalPaciente.NumeroTelefonico = txtTelefonoPaciente.Text
        TemporalPaciente.Correo = txtCorreoPaciente.Text
        If cbSeguro.Text.Equals("No") Then
            TemporalPaciente.EstaActivo = False
        Else
            TemporalPaciente.EstaActivo = True
        End If

        ' envio a negocios e inserción en db





    End Sub

    Private Sub cbDistrito_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbDistrito.SelectedValueChanged
        Dim distrito As String = cbDistrito.Text
        For Each _distrito As Objetos.Distrito In ListaDistritos
            If _distrito.Nombre.Equals(distrito) Then
                TemporalPaciente.IdDistrito = _distrito.IdDistrito
            End If
        Next
    End Sub
End Class