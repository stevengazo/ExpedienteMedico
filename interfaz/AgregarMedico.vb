Imports Objetos
Imports System.Linq
Public Class AgregarMedico
    Private listaProvincias As New List(Of Objetos.Provincia)
    Private listaCantones As New List(Of Objetos.Canton)
    Private listaDistritos As New List(Of Objetos.Distrito)
    Private listaEspecialidades As New List(Of Objetos.Especialidad)
    Private tmpMedico As New Objetos.Medico
    Private tmpMediHasEspe As New List(Of Objetos.MedHasEspe)


    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
    End Sub

    Private Sub btnAgregarMedico_Click(sender As Object, e As EventArgs) Handles btnAgregarMedico.Click
        Try
            'obtener los valores de la UI

            Dim medico As New Medico()

            tmpMedico.Usuario = txtUsuario.Text
            tmpMedico.Contraseña = txtContrasena.Text
            tmpMedico.Nombre = txtNombre.Text
            tmpMedico.Apellido = txtApellidos.Text
            tmpMedico.Identificacion = txtIdentificacion.Text
            tmpMedico.TipoIdentificación = cboTipoIdentificacion.Text
            tmpMedico.Sexo = cboSexo.Text
            tmpMedico.EstadoCivil = cboEstadoCivil.Text
            tmpMedico.Nacionalidad = txtNacionalidad.Text
            tmpMedico.FechaNacimiento = dtNacimiento.Value
            tmpMedico.NumeroTelefono = Integer.Parse(txtTelefono.Text)
            tmpMedico.Correo = txtCorreo.Text
            tmpMedico.OtrasSenas = txtOtros.Text

            If String.IsNullOrEmpty(tmpMedico.Nombre) Then
                MessageBox.Show("Debe colocar al menos el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim negocios As New Negocio.MedicoNegocio
                Dim objMedico As New Objetos.Medico

                Dim idMedico = negocios.AgregarMedico(tmpMedico)

                If idMedico > 0 Then
                    MessageBox.Show("El médico se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' añade las especialidades del doctor
                    If tmpMediHasEspe.Count > 0 Then
                        Dim NegoMediHasEspec As New Negocio.MediHasEspe()
                        For Each registro In tmpMediHasEspe
                            registro.IdMedico = idMedico
                            Dim bandera = NegoMediHasEspec.InsertarRegistro(registro)
                            If (bandera) Then
                                MessageBox.Show("Especialidad agregada", "Información", MessageBoxButtons.OK)
                            End If
                        Next
                    Else
                        MessageBox.Show("No hay especialidades para agregar...", "Información", MessageBoxButtons.OK)
                    End If
                    MessageBox.Show("El médico se agregó correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("No se pudo agregar el médico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un problema (Error: " + ex.Message + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AgregarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' cargar provincias 
        Dim tmpComunesNegocios As New Negocio.Comunes()
        listaProvincias = tmpComunesNegocios.ListarProvincias()
        For Each item In listaProvincias
            cbProvincia.Items.Add(item.Nombre)
        Next
        'cargar especialidades
        Dim tmpNegoEspe As New Negocio.Especialidad
        listaEspecialidades = tmpNegoEspe.ListarEspecialidades()
        For Each item In listaEspecialidades
            cbEspecialidad.Items.Add(item.Nombre)
        Next
    End Sub

    Private Sub btnAgregarEspecialidad_Click(sender As Object, e As EventArgs) Handles btnAgregarEspecialidad.Click
        For Each especialidad In listaEspecialidades
            If especialidad.Nombre.Equals(cbEspecialidad.Text) Then
                Dim registro As New Objetos.MedHasEspe
                registro.años = Integer.Parse(txtAñosExperiencia.Value)
                registro.IdEspecialidad = especialidad.idEspecialidad
                tmpMediHasEspe.Add(registro)
                MessageBox.Show("Especialidad " + especialidad.Nombre + " Agregada", "información", MessageBoxButtons.OK)
                txtAñosExperiencia.Value = 0
                cbEspecialidad.SelectedIndex = -1
            End If
        Next
    End Sub

    Private Sub cbProvincia_TextUpdate(sender As Object, e As EventArgs) Handles cbProvincia.TextUpdate

    End Sub

    Private Sub cbProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProvincia.SelectedIndexChanged
        cbDistrito.Items.Clear()
        Dim ProvinciaNombre As String = cbProvincia.Text
        For Each provincia In listaProvincias

            If provincia.Nombre.Equals(ProvinciaNombre) Then
                cbCanton.Items.Clear()
                Dim tmpcomun As New Negocio.Comunes
                listaCantones.Clear()
                listaCantones = tmpcomun.ListarCantonesPorProvincia(provincia.IdProvincia)
                For Each canton In listaCantones
                    cbCanton.Items.Add(canton.Canton)
                Next
            End If
        Next
    End Sub

    Private Sub cbCanton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCanton.SelectedIndexChanged
        Dim canton As String = cbCanton.Text
        For Each _canton As Objetos.Canton In listaCantones
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

    Private Sub cbDistrito_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbDistrito.SelectedValueChanged
        Dim distrito As String = cbDistrito.Text
        For Each _distrito As Objetos.Distrito In listaDistritos
            If _distrito.Nombre.Equals(distrito) Then
                tmpMedico.IdDistrito = _distrito.IdDistrito
            End If
        Next
    End Sub
End Class