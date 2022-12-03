Public Class VerMedicos
    Private Sub VerMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tmpNegocios As New Negocio.MedicoNegocio
            Dim listaMedicos As List(Of Objetos.Medico)
            listaMedicos = tmpNegocios.ListaMedicos()

            If listaMedicos.Count > 0 Then
                Dim _tabla As New DataTable
                _tabla.Columns.Add("Id")
                _tabla.Columns.Add("Identificación")
                _tabla.Columns.Add("Nombre")
                _tabla.Columns.Add("Apellidos")
                _tabla.Columns.Add("Sexo")
                _tabla.Columns.Add("Número")
                _tabla.Columns.Add("Correo")

                For Each objMedico As Objetos.Medico In listaMedicos
                    _tabla.Rows.Add(objMedico.idMedico, objMedico.Identificacion, objMedico.Nombre, objMedico.Apellido, objMedico.Sexo, objMedico.NumeroTelefono, objMedico.Correo)
                Next

                dgListaMedicos.Columns.Clear()

                dgListaMedicos.DataSource = _tabla
            End If


        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class