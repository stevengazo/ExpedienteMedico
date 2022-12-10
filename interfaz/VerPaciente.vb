Public Class VerPaciente
    Dim Bandera As Boolean = False

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Bandera Then
            PanelEditable.Show()
            PanelInformación.Hide()
            Bandera = False
            btnEditar.Text = "Ver Información"
        Else
            PanelEditable.Hide()
            PanelInformación.Show()
            Bandera = True
            btnEditar.Text = "Editar información"
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class