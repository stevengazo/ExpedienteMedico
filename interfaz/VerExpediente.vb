Imports System.Deployment.Application
Imports System.Net.Http
Imports System.Xml
Imports Negocio
Imports Objetos
Public Class VerExpediente
    Private _ComunesNegocio As New Negocio.Comunes()
    Private _Expediente As New Objetos.ExpedienteMedico()
    Private ListaSucursales As New List(Of Objetos.Sucursal)
    Private _RegistroNegocios As New Negocio.Registro()
    Private _ListaRegistros As New List(Of Objetos.Registro)
    Private Paciente As New Objetos.Paciente()
    Private _RecetaNegocios As New Negocio.Receta()
    Private _listaMedicos As New List(Of Objetos.Medico)
    Private _doctor As New Objetos.Medico
    Private _negociosMedico As New Negocio.MedicoNegocio()

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        PanelRegistroInfo.SendToBack()
    End Sub

    Private Sub CargarDatosTabla()
        Try
            dgvRegistrosMedicos.Columns.Clear()
            _ListaRegistros = _RegistroNegocios.ListarRegistrosPorExpediente(Paciente.Expediente.idExpediente)
            Dim _tabla As New DataTable
            _tabla.Columns.Add("Id")
            _tabla.Columns.Add("N° Expediente")
            _tabla.Columns.Add("N° Cita")
            _tabla.Columns.Add("N° Diagnostico")
            _tabla.Columns.Add("N° Receta")
            _tabla.Columns.Add("N° Medico")
            _tabla.Columns.Add("N° Sucursal")
            For Each obj As Objetos.Registro In _ListaRegistros
                Dim idRegistro As String
                If obj.idRegistro = 0 Then
                    idRegistro = "No asignado"
                Else
                    idRegistro = obj.idRegistro.ToString()
                End If
                Dim idExpediente As String
                If obj.idRegistro = 0 Then
                    idExpediente = "No asignado"
                Else
                    idExpediente = obj.idExpediente.ToString()
                End If
                Dim idCita As String
                If obj.idCita = 0 Then
                    idCita = "No asignado"
                Else
                    idCita = obj.idCita.ToString()
                End If
                Dim idDiagnostico As String
                If obj.idDiagnostico = 0 Then
                    idDiagnostico = "No Asignado"
                Else
                    idDiagnostico = obj.idDiagnostico.ToString()
                End If
                Dim idReceta As String
                If obj.idReceta = 0 Then
                    idReceta = "No asignado"
                Else
                    idReceta = obj.idReceta.ToString()
                End If
                Dim idMedico As String
                If obj.idMedico = 0 Then
                    idMedico = "No Asignado"
                Else
                    idMedico = obj.idMedico.ToString()
                End If
                Dim _Sucusal As String = ""
                If obj.idSucursal = 0 Then
                    _Sucusal = "No Asignado"
                Else
                    For Each x In ListaSucursales
                        If x.idSucursal = obj.idSucursal Then
                            _Sucusal = x.Nombre
                            Exit For
                        Else
                            _Sucusal = ""
                        End If
                    Next
                End If
                _tabla.Rows.Add(idRegistro, idExpediente, idCita, idDiagnostico, idReceta, idMedico, _Sucusal)
            Next
            dgvRegistrosMedicos.Columns.Clear()
            dgvRegistrosMedicos.DataSource = _tabla
            Dim buttonVer As New DataGridViewButtonColumn
            buttonVer.HeaderText = "Ver"
            buttonVer.Text = "Ver"
            buttonVer.Name = "btnVerRegistro"
            buttonVer.UseColumnTextForButtonValue = True
            dgvRegistrosMedicos.Columns.Add(buttonVer)
        Catch ex As Exception
            MessageBox.Show("Error interno", "Error")
        End Try
    End Sub

    Private Sub btnGenerarRegistro_Click(sender As Object, e As EventArgs) Handles btnGenerarRegistro.Click
        Try
            PanelAgregarRegistro.Show()
            btnGenerarRegistro.Enabled = False
            _listaMedicos = _negociosMedico.ListaMedicos()
            For Each i In _listaMedicos
                cbMedico.Items.Add(i.Nombre + " " + i.Apellido)
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub VerExpediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PanelAgregarRegistro.Hide()
        PanelRegistroInfo.Show()
        Paciente = TEMPORAL.Paciente
        lblApellidos.Text = Paciente.Apellidos
        lblNombre.Text = Paciente.Nombre
        lblDNI.Text = Paciente.Identificacion
        lblFechaNacimiento.Text = Paciente.FechaNacimiento.ToString()
        Dim NegocioComun As New Negocio.Comunes()
        ListaSucursales = NegocioComun.ListaSucursales()
        For Each item As Objetos.Sucursal In ListaSucursales
            cbSucursal.Items.Add(item.Nombre)
        Next
        PanelAgregarRegistro.Hide()
        CargarDatosTabla()
    End Sub


    Private Sub btnCancelarAgregar_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregar.Click
        PanelAgregarRegistro.Hide()
        btnGenerarRegistro.Enabled = True
        CargarDatosTabla()
    End Sub


    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        Try
            Dim doctor = (From i In _listaMedicos Where (i.Nombre + " " + i.Apellido) = cbMedico.SelectedItem Select i).FirstOrDefault()
            PanelAgregarRegistro.Hide()
            btnGenerarRegistro.Enabled = True
            For Each item In ListaSucursales
                If item.Nombre.Equals(cbSucursal.Text) Then
                    Dim NegociosRegistro As New Negocio.Registro()
                    Dim id As Integer = NegociosRegistro.GenerarRegistro(Paciente.Expediente.idExpediente, item.idSucursal, doctor.idMedico)
                    If id = 0 Then
                        MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Registro Agregado. Número: " + id.ToString(), "información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarDatosTabla()
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgvRegistrosMedicos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistrosMedicos.CellContentClick
        Try
            If e.ColumnIndex = 7 Then
                Dim id = dgvRegistrosMedicos.Rows(e.RowIndex).Cells.Item(0).Value.ToString()
                Dim numId = Integer.Parse(id)
                Dim Registro = (From regi
                                    In _ListaRegistros
                                Where regi.idRegistro = numId
                                Select regi).FirstOrDefault()
                Dim tmpDoctor As New Negocio.MedicoNegocio()
                _doctor = tmpDoctor.ObtenerMedico(Registro.idRegistro)
                Dim sucursal = _ComunesNegocio.ObtenerSucursal(Registro.idSucursal)
                TEMPORAL.RegistroTemp = Registro
                TEMPORAL.Sucursal = sucursal
                PanelRegistroInfo.BringToFront()
                ActualizarPanel(Registro, sucursal)
            End If
        Catch ex As Exception
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnDiagnostico_Click(sender As Object, e As EventArgs) Handles btnDiagnostico.Click
        Dim tipo = btnDiagnostico.Text
        Select Case tipo
            Case "Ver"
                VerDiagnostico.ShowDialog()
                btnEliminarDiagnostico.Enabled = True
                ' Abrir Ver Diagnostico
            Case "Agregar"
                ' Abrir Agregar Diagnostico
                Dim tmp1 As New AgregarDiagnostico()
                tmp1.ShowDialog()
                Dim estado = _RegistroNegocios.ActualizarRegistro(TEMPORAL.RegistroTemp)
                If estado Then
                    btnDiagnostico.Text = "Ver"
                    btnDiagnostico.ForeColor = Color.White
                    btnDiagnostico.BackColor = Color.Blue
                    btnEliminarDiagnostico.Enabled = True

                End If
                CargarDatosTabla()
        End Select
    End Sub


    Private Sub btnCita_Click(sender As Object, e As EventArgs) Handles btnCita.Click
        Dim tipo = btnCita.Text
        Select Case tipo
            Case "Ver"
                ' Abrir Ver Diagnostico
                VerCita.ShowDialog()
                CargarDatosTabla()
                btnEliminarCita.Enabled = False
            Case "Agregar"
                ' Abrir Agregar Diagnostico
                Dim tmp As New AgregarCita()
                tmp.ShowDialog()
                ' Setear registro en memoria temporal
                Dim estado = _RegistroNegocios.ActualizarRegistro(TEMPORAL.RegistroTemp)
                If estado Then
                    ' Cambio de Estado Boton
                    btnCita.Text = "Ver"
                    btnCita.ForeColor = Color.White
                    btnCita.BackColor = Color.Blue
                    CargarDatosTabla()
                End If
        End Select
    End Sub

    Private Sub btnReceta_Click(sender As Object, e As EventArgs) Handles btnReceta.Click
        Dim tipo = btnReceta.Text
        Select Case tipo
            Case "Ver"
                ' Setear registro en memoria temporal
                Dim tmp1 As New VerReceta()
                tmp1.ShowDialog()
            Case "Agregar"
                ' Abrir Agregar Receta
                Dim recetaAgregar As New AgregarReceta
                recetaAgregar.ShowDialog()

                Dim estado = _RegistroNegocios.ActualizarRegistro(TEMPORAL.RegistroTemp)
                If estado Then
                    CargarDatosTabla()
                    ' Cambio de Estado 
                    btnReceta.Text = "Ver"
                    btnReceta.ForeColor = Color.White
                    btnReceta.BackColor = Color.Blue
                End If
        End Select
    End Sub


    Private Sub ActualizarPanel(registro As Objetos.Registro, sucursal As Objetos.Sucursal)
        Try
            lblSucursal.Text = sucursal.Nombre
            lblNumeroRegistro.Text = registro.idRegistro
            lblDoctor.Text = _doctor.Nombre + " " + _doctor.Apellido
            ' Citas
            If registro.idCita = 0 Then
                ' Agregar Nuevo Registro
                btnCita.Text = "Agregar"
                btnCita.BackColor = Color.Green
                btnCita.ForeColor = Color.White
                btnEliminarCita.Enabled = False
            Else
                ' Ver Registro
                btnCita.Text = "Ver"
                btnCita.ForeColor = Color.White
                btnCita.BackColor = Color.Blue
                btnEliminarDiagnostico.Enabled = True
            End If
            ' Diagnostico
            If registro.idDiagnostico = 0 Then
                btnDiagnostico.Text = "Agregar"
                btnDiagnostico.ForeColor = Color.White
                btnDiagnostico.BackColor = Color.Green
                btnEliminarDiagnostico.Enabled = False
            Else
                btnDiagnostico.Text = "Ver"
                btnDiagnostico.ForeColor = Color.White
                btnDiagnostico.BackColor = Color.Blue
                btnEliminarDiagnostico.Enabled = True
            End If
            ' Receta 
            If registro.idReceta = 0 Then
                btnReceta.Text = "Agregar"
                btnReceta.ForeColor = Color.White
                btnReceta.BackColor = Color.Green
                btnEliminarReceta.Enabled = False
            Else
                btnReceta.Text = "Ver"
                btnReceta.ForeColor = Color.White
                btnReceta.BackColor = Color.Blue
                btnEliminarReceta.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "errro")
        End Try

    End Sub

    Private Sub btnEliminarCita_Click(sender As Object, e As EventArgs) Handles btnEliminarCita.Click
        Dim result = MessageBox.Show("¿Deseas eliminar la cita asociada a este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            ' Actualizar Registro
            Dim tmpIdCita = TEMPORAL.RegistroTemp.idCita
            TEMPORAL.RegistroTemp.idCita = 0
            Dim Estado = _RegistroNegocios.ActualizarRegistro(TEMPORAL.RegistroTemp)
            ' Borrar Cita en DB
            If Estado Then
                Dim _citaNegocios As New Negocio.CitasNegocios()
                Dim Estado1 = _citaNegocios.BorrarCita(tmpIdCita)
                If Estado1 Then
                    MessageBox.Show("Cita borrada del registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnEliminarCita.Enabled = False
                    btnCita.Text = "Agregar"
                    btnCita.BackColor = Color.Green
                End If
            Else
                MessageBox.Show("Error Interno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnEliminarCita.Enabled = True
            End If
            CargarDatosTabla()
        End If
    End Sub

    Private Sub btnEliminarDiagnostico_Click(sender As Object, e As EventArgs) Handles btnEliminarDiagnostico.Click
        Dim result = MessageBox.Show("¿Deseas eliminar el diagnostico asociado a este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            ' Borrar 
            Dim idDiagnostico = TEMPORAL.RegistroTemp.idDiagnostico
            TEMPORAL.RegistroTemp.idDiagnostico = 0
            Dim Estado = _RegistroNegocios.ActualizarRegistro(TEMPORAL.RegistroTemp)
            ' Borrar Cita en DB
            If Estado Then
                Dim _Diagnosticos As New Negocio.DiagnosticoNegocios()
                Dim Estado1 = _Diagnosticos.BorrarDiagnostico(idDiagnostico)
                If Estado1 Then
                    MessageBox.Show("Diagnostico borrada del registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnEliminarDiagnostico.Enabled = False
                    btnDiagnostico.Text = "Agregar"
                    btnDiagnostico.BackColor = Color.Green
                End If
            Else
                MessageBox.Show("Error Interno", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnEliminarDiagnostico.Enabled = True
            End If
            CargarDatosTabla()
        End If
    End Sub

    Private Sub btnEliminarReceta_Click(sender As Object, e As EventArgs) Handles btnEliminarReceta.Click
        Dim result = MessageBox.Show("¿Deseas eliminar la receta asociada a este registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            ' Borrar 
            Dim idAborrar = TEMPORAL.RegistroTemp.idReceta
            TEMPORAL.RegistroTemp.idReceta = 0
            Dim Estado = _RegistroNegocios.ActualizarRegistro(TEMPORAL.RegistroTemp)
            If Estado Then
                Dim resultado = _RecetaNegocios.BorrarReceta(idAborrar)
                If resultado Then
                    MessageBox.Show("Diagnostico borrada del registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnReceta.ForeColor = Color.White
                    btnEliminarReceta.Enabled = False
                    btnReceta.Text = "Agregar"
                    btnReceta.BackColor = Color.Green
                End If
            End If
        End If
    End Sub

    Private Sub btnEliminarRegistro_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistro.Click
        Dim result = MessageBox.Show("¿Deseas eliminar el registro asociado al expediente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            ' Borrar 
            Dim idRegistro = TEMPORAL.RegistroTemp.idRegistro
            Dim estado = _RegistroNegocios.BorrarRegistro(idRegistro)
            If estado Then
                MessageBox.Show("Registro del Expediente eliminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarDatosTabla()
            End If
        End If
    End Sub
End Class