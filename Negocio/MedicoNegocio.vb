Imports Objetos
Imports AccesoDatos

Public Class MedicoNegocio
    Public Function AgregarMedico(medico As Medico) As Integer
        Try
            Dim obtieneDatos As New AccesoDatos.MetodosMedico
            Dim id = obtieneDatos.InsertaMedico(medico)
            Return id
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
    End Function
End Class
