Imports System.Deployment.Application
Imports Negocio
Imports Objetos
Public Class VerExpediente
    Private NegociosExpediente As New Objetos.ExpedienteMedico()
    Private Expediente As New Objetos.ExpedienteMedico()
    Private ListaSucursales As New List(Of Objetos.Sucursal)
    Private _RegistroNegocios As New Negocio.Registro()
    Private Paciente As New Objetos.Paciente()

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
            Dim listaRegistros As New List(Of Objetos.Registro)
            listaRegistros = _RegistroNegocios.ListarRegistrosPorExpediente(Paciente.Expediente.idExpediente)

            Dim _tabla As New DataTable
            _tabla.Columns.Add("Id")
            _tabla.Columns.Add("N° Expediente")
            _tabla.Columns.Add("N° Cita")
            _tabla.Columns.Add("N° Diagnostico")
            _tabla.Columns.Add("N° Receta")
            _tabla.Columns.Add("N° Medico")
            _tabla.Columns.Add("N° Sucursal")


            For Each obj As Objetos.Registro In listaRegistros
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

            'Dim buttonEliminar As New DataGridViewButtonColumn
            'buttonVer.HeaderText = "Eliminar"
            'buttonVer.Text = "Eliminar"
            'buttonVer.Name = "btnEliminarRegistro"
            'buttonVer.UseColumnTextForButtonValue = True
            'dgvRegistrosMedicos.Columns.Add(buttonEliminar)


        Catch ex As Exception
            MessageBox.Show("Error interno", "Error")
        End Try
    End Sub

    Private Sub btnGenerarRegistro_Click(sender As Object, e As EventArgs) Handles btnGenerarRegistro.Click
        Try
            PanelAgregarRegistro.Show()
            btnGenerarRegistro.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub VerExpediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelAgregarRegistro.Hide()
        PanelRegistroInfo.Show()
        Paciente = TEMPORAL.Paciente
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
    End Sub

    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        Try

            PanelAgregarRegistro.Hide()
            btnGenerarRegistro.Enabled = True
            For Each item In ListaSucursales
                If item.Nombre.Equals(cbSucursal.Text) Then
                    Dim NegociosRegistro As New Negocio.Registro()
                    Dim id As Integer = NegociosRegistro.GenerarRegistro(Paciente.Expediente.idExpediente, item.idSucursal)
                    If id = 0 Then
                        MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Registro Agregado. Número: " + id, "información", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                PanelRegistroInfo.BringToFront()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class