Imports AccesoDatos
Imports Objetos
Public Class Especialidad



    Public Function ListarEspecialidades() As List(Of Objetos.Especialidad)
        Try
            Dim tmpAccesoEspecialidad As New AccesoDatos.Especialidades
            Return tmpAccesoEspecialidad.ListarEspecialidades
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Especialidad)
        End Try
    End Function
End Class
