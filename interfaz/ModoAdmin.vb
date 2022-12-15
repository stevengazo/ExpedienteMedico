Public Class ModoAdmin
    Private Sub AgregarMédicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMédicoToolStripMenuItem.Click
        AgregarMedico.Show()
    End Sub

    Private Sub MédicosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MédicosToolStripMenuItem1.Click
        VerMedicos.Show()
    End Sub

    Private Sub MédicosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MédicosToolStripMenuItem2.Click
        VerMedicos.Show()
    End Sub

    Private Sub MédicosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MédicosToolStripMenuItem3.Click
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

    Private Sub InventarioDeMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioDeMedicamentosToolStripMenuItem.Click
        VerMedicamentos.Show()
    End Sub

    Private Sub InventarioDeMedicamentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InventarioDeMedicamentosToolStripMenuItem1.Click
        VerMedicamentos.Show()
    End Sub

    Private Sub InventarioDeMedicamentosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles InventarioDeMedicamentosToolStripMenuItem2.Click
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

    End Sub

    Private Sub AgregarUnaEnfermedadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUnaEnfermedadToolStripMenuItem.Click
        AgregarEnfermedad.Show()

    End Sub

    Private Sub AgregarMedicamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarMedicamentoToolStripMenuItem.Click
        AgregarMedicamento.ShowDialog()

    End Sub

    Private Sub PacientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem1.Click
        ModoMedicos.ShowDialog()

    End Sub

    Private Sub PacientesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem2.Click
        ModoMedicos.ShowDialog()
    End Sub

    Private Sub PacientesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem3.Click
        ModoMedicos.ShowDialog()
    End Sub

    Private Sub ModoAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub InventarioMedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioMedicamentosToolStripMenuItem.Click
        VerInventario.ShowDialog()
    End Sub
End Class