Public Class VerPaciente
    Dim Bandera As Boolean = False

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If Bandera Then
            PanelEditable.Show()
            PanelInformación.Hide()
            Bandera = False
            btnEditar.Text = "Editar Información"
        Else
            PanelEditable.Hide()
            PanelInformación.Show()
            Bandera = True
            btnEditar.Text = "Ver Información"
        End If
    End Sub
End Class