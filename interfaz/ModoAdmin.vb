Public Class ModoAdmin
    Private Sub AgregarMédicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMédicoToolStripMenuItem.Click
        AgregarMedico.Show()
    End Sub

    Private Sub MédicosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        VerMedicos.Show()
    End Sub

    Private Sub MédicosToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        VerMedicos.Show()
    End Sub

    Private Sub MédicosToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        VerMedicos.Show()
    End Sub

    Private Sub VerInformaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerInformaciónToolStripMenuItem.Click
        VerMedicos.Show()
    End Sub

    Private Sub VerPacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPacientesToolStripMenuItem.Click
        ModoMedicos.ShowDialog()
    End Sub

    Private Sub VerListaDeMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListaDeMedicamentosToolStripMenuItem.Click
        VerMedicamentos.Show()

    End Sub

    Private Sub InventarioDeMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        VerMedicamentos.Show()
    End Sub

    Private Sub InventarioDeMedicamentosToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        VerMedicamentos.Show()
    End Sub

    Private Sub InventarioDeMedicamentosToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        VerMedicamentos.Show()
    End Sub

    Private Sub AgregarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPacienteToolStripMenuItem.Click
        Dim agregarPacienteForm As New AgregarPaciente()
        agregarPacienteForm.ShowDialog()
    End Sub

    Private Sub VerListaDeEnfermedadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerListaDeEnfermedadesToolStripMenuItem.Click
        VerEnfermedades.Show()

    End Sub

    Private Sub ModoAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTablas()
    End Sub

    Private Sub AgregarUnaEnfermedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUnaEnfermedadToolStripMenuItem.Click
        AgregarEnfermedad.Show()

    End Sub

    Private Sub AgregarMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMedicamentoToolStripMenuItem.Click
        AgregarMedicamento.ShowDialog()

    End Sub

    Private Sub PacientesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ModoMedicos.ShowDialog()

    End Sub

    Private Sub PacientesToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        ModoMedicos.ShowDialog()
    End Sub

    Private Sub PacientesToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        ModoMedicos.ShowDialog()
    End Sub

    Private Sub ModoAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub InventarioMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioMedicamentosToolStripMenuItem.Click
        VerInventario.ShowDialog()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub CargarTablas()
        Try
            Dim _NegoMedicos As New Negocio.MedicoNegocio
            Dim _NegoComun As New Negocio.Comunes
            Dim _NegoPacientes As New Negocio.PacienteNegocio


            Dim listaMedicos = _NegoMedicos.ListaMedicos()
            If listaMedicos.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Apellidos")
                For Each objE As Objetos.Medico In listaMedicos
                    If objE.idMedico > 0 Then
                        _tabla.Rows.Add(objE.idMedico, objE.Nombre, objE.Apellido)
                    End If
                Next
                dgvMedicos.Columns.Clear()
                dgvMedicos.DataSource = _tabla

            End If
            lblMedicos.Text = "En el sistema existen " + listaMedicos.Count.ToString() + " medicos"

            Dim listaSucursal = _NegoComun.ListaSucursales()
            If listaSucursal.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id")
                _tabla.Columns.Add("Nombre")
                For Each objE As Objetos.Sucursal In listaSucursal
                    If objE.idSucursal > 0 Then
                        _tabla.Rows.Add(objE.idSucursal, objE.Nombre)
                    End If
                Next
                dgvSucursales.Columns.Clear()
                dgvSucursales.DataSource = _tabla
            End If
            lblSucursales.Text = "En el sistema existen " + listaSucursal.Count.ToString() + "Sucursales"

            Dim listaPacients = _NegoPacientes.ListaPacientes()
            If listaPacients.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Apellidos")
                For Each objE As Objetos.Paciente In listaPacients
                    If objE.idPaciente > 0 Then
                        _tabla.Rows.Add(objE.Identificacion, objE.Nombre, objE.Apellidos)
                    End If
                Next
                dgvPacientes.Columns.Clear()
                dgvPacientes.DataSource = _tabla
            End If
            lblPacientes.Text = "La cantidad de pacientes existentes es de " + listaPacients.Count.ToString() + " personas"


        Catch ex As Exception
            MessageBox.Show("Error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class