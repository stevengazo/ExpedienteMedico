Imports Objetos
Imports System.Linq
Imports Negocio

Public Class AgregarDiagnostico
    Private _Enfermedades As New Negocio.EnfermedadNegocio()
    Private _Diagnostico As New Negocio.DiagnosticoNegocios()

    Private _listaEnfermedades As New List(Of Objetos.Enfermedad)
    Private Sub AgregarDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _listaEnfermedades = _Enfermedades.ListaEnfermedad()
        For Each enfermedad As Objetos.Enfermedad In _listaEnfermedades
            If enfermedad.idEnfermedad <> 0 And Not String.IsNullOrEmpty(enfermedad.Nombre) Then
                cbEnfermedades.Items.Add(enfermedad.Nombre)
            End If
        Next
    End Sub

    Private Sub btnAgregarDiagnostico_Click(sender As Object, e As EventArgs) Handles btnAgregarDiagnostico.Click
        Dim bandera As Boolean = True
        Dim tmpEnfermedad As New Objetos.Enfermedad
        For Each enfermedad As Objetos.Enfermedad In _listaEnfermedades
            If enfermedad.Nombre.Equals(cbEnfermedades.Text) Then
                tmpEnfermedad = enfermedad
                bandera = True
                Exit For
            Else
                bandera = False
            End If
        Next
        If String.IsNullOrEmpty(txtDescripcion.Text) Then
            MessageBox.Show("Descripción vacia", "Error")
            bandera = False
        End If
        If bandera Then
            Dim diag As New Objetos.Diagnostico()
            diag.Fecha = dtpFechaSintomas.Value
            diag.idEnfermedad = tmpEnfermedad.idEnfermedad
            diag.Descripcion = txtDescripcion.Text
            Dim id = _Diagnostico.AgregarDiagnostico(diag)
            If id <> 0 Then
                TEMPORAL.RegistroTemp.idDiagnostico = id
                MessageBox.Show("Registro Agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        End If
    End Sub
End Class