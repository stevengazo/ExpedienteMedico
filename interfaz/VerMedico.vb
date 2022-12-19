﻿Public Class VerMedico
    Dim tmpNegocioMedico As New Negocio.MedicoNegocio()
    Dim Medico As New Objetos.Medico()
    Dim Bandera As Boolean = True
    Dim listaProvincias As New List(Of Objetos.Provincia)
    Dim listaCantones As New List(Of Objetos.Canton)
    Dim listaDistritos As New List(Of Objetos.Distrito)
    Private Sub VerMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Medico = TEMPORAL.Medico
        'ActualizarPanelInformacion()
        ActualizarMedico()

        ' cargar provincias 
        Dim tmpComunesNegocios As New Negocio.Comunes()
        listaProvincias = tmpComunesNegocios.ListarProvincias()
        For Each item In listaProvincias
            cbProvincia.Items.Add(item.Nombre)
        Next
        'cargar especialidade
        'txtNombre.Text = TEMPORAL.Medico.Nombre
        'txtApellidos.Text = TEMPORAL.Medico.Apellido
        'txtContrasena.Text = "Información no disponible"
        'txtContrasena.Enabled = False
        'txtUsuario.Text = TEMPORAL.Medico.Usuario
        'txtIdentificacion.Text = TEMPORAL.Medico.Identificacion
        'txtCorreo.Text = TEMPORAL.Medico.Correo
    End Sub


    Private Sub ActualizarMedico()
        txtUsuario.Enabled = False
        txtContrasena.Enabled = False
        txtNombre.Enabled = False
        txtApellidos.Enabled = False
        txtIdentificacion.Enabled = False
        cboTipoIdentificacion.Enabled = False
        cboSexo.Enabled = False
        cboEstadoCivil.Enabled = False
        txtNacionalidad.Enabled = False
        dtNacimiento.Enabled = False
        cbDistrito.Enabled = False

        txtUsuario.Text = Medico.Usuario
        txtContrasena.Text = "Información no disponible"
        txtNombre.Text = Medico.Nombre
        txtApellidos.Text = Medico.Apellido
        txtIdentificacion.Text = Medico.Identificacion
        cboTipoIdentificacion.Text = Medico.TipoIdentificación
        cboSexo.Text = Medico.Sexo
        cboEstadoCivil.Text = Medico.EstadoCivil
        txtNacionalidad.Text = Medico.Nacionalidad
        dtNacimiento.Text = Medico.FechaNacimiento
        cbDistrito.Text = Medico.IdDistrito
        Dim comun As New Negocio.Comunes()
        Dim ubicacioninf = comun.ObtenerDistrito(Medico.IdDistrito)
        cbProvincia.Enabled = False
        cbProvincia.Text = ubicacioninf.Canton.Provincia.Nombre
        cbCanton.Enabled = False
        cbCanton.Text = ubicacioninf.Canton.Canton

    End Sub

    Private Sub HabilitarCampos()
        txtUsuario.Enabled = True
        txtContrasena.Enabled = True
        txtNombre.Enabled = True
        txtApellidos.Enabled = True
        txtIdentificacion.Enabled = True
        cboTipoIdentificacion.Enabled = True
        cboSexo.Enabled = True
        cboEstadoCivil.Enabled = True
        txtNacionalidad.Enabled = True
        dtNacimiento.Enabled = True
        cbDistrito.Enabled = True
        cbCanton.Enabled = True
        cbProvincia.Enabled = True
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


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Bandera Then
            HabilitarCampos()
            Bandera = False
            btnEditar.Text = "Actualizar Información"

        Else

            'Enfe.Nombre = txtNombre.Text
            'Enfe.Descripcion = txtDes.Text
            'Enfe.sintomas = txtSin.Text
            'Dim flag = tmpNegocioEnfermedad.ActualizarEnfermedad(Enfermedad)
            'If flag Then
            '    PanelEditable.SendToBack()
            '    Bandera = True
            '    btnEditar.Text = "Editar información"
            '    ActualizarEnfermedad()
            '    ActualizarPanelInformacion()
            '    PanelInfo.BringToFront()
            '    MessageBox.Show("Enfermedad actualizada correctamente", "Información", MessageBoxButtons.OK)
            'Else
            '    MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK)
            'End If




        End If
    End Sub


End Class