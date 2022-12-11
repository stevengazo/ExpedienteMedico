Imports Negocio
Imports Objetos
Public Class VerExpediente
    Private NegociosExpediente As New Objetos.ExpedienteMedico()
    Private ListaSucursales As New List(Of Objetos.Sucursal)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

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
        Dim NegocioComun As New Negocio.Comunes()
        Dim listaSucursales = NegocioComun.ListaSucursales()
        For Each item As Objetos.Sucursal In listaSucursales
            cbSucursal.Items.Add(item.Nombre)
        Next
        PanelAgregarRegistro.Hide()
    End Sub

    Private Sub btnCancelarAgregar_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregar.Click
        PanelAgregarRegistro.Hide()
        btnGenerarRegistro.Enabled = True
    End Sub

    Private Sub btnAgregarRegistro_Click(sender As Object, e As EventArgs) Handles btnAgregarRegistro.Click
        Try
            PanelAgregarRegistro.Hide()
            btnGenerarRegistro.Enabled = True
            Throw New NotImplementedException()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class