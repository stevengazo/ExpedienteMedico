Imports Negocio
Imports Objetos

Public Class Autenticacion
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If String.IsNullOrEmpty(txtNombreUsuario.Text) Or String.IsNullOrEmpty(txtContraseña.Text) Then
            MessageBox.Show("Verifica los campos", "Advertencia", MessageBoxButtons.OK)
        Else
            Dim tipo As String = cboRoles.Text
            If String.IsNullOrEmpty(tipo) Then
                MessageBox.Show("Selecciona un tipo de Usuario", "Advertencia", MessageBoxButtons.OK)
            ElseIf tipo.Equals("Administrador") Then
                Dim negocioAdmin As AdministradorNegocios = New AdministradorNegocios()
                Dim aceptado = negocioAdmin.InicioSesion(txtNombreUsuario.Text, txtContraseña.Text)
                If aceptado Then
                    Dim MedForm As ModoAdmin = New ModoAdmin()
                    Me.Hide()
                    'Me.Dispose()
                    MedForm.ShowDialog()
                    Me.Show()
                    'Me.Close()
                    clean()
                Else
                    MessageBox.Show("Incorrecto", "Información", MessageBoxButtons.OK)
                    clean()
                End If
            ElseIf tipo.Equals("Médico") Then
                Dim negocioMedi As New Negocio.MedicoNegocio()
                Dim aceptado = negocioMedi.InicioSesion(txtNombreUsuario.Text, txtContraseña.Text)
                If aceptado Then
                    Dim mediForm As New Medicos()
                    Me.Hide()
                    mediForm.Show()
                    clean()
                Else
                    MessageBox.Show("Incorrecto", "Información", MessageBoxButtons.OK)
                    clean()
                End If
            End If
        End If
    End Sub
    Private Sub clean()
        txtContraseña.Text = String.Empty
        txtNombreUsuario.Text = String.Empty
        cboRoles.SelectedIndex = -1
    End Sub


End Class