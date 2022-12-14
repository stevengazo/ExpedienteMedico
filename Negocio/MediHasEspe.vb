Imports Objetos
Imports AccesoDatos

Public Class MediHasEspe
    Public Function InsertarRegistro(MediHasEspecialidad As Objetos.MedHasEspe) As Boolean
        Try
            Dim tmpAccesoMediHasEspecialidad As New AccesoDatos.MedHasEspe()
            Return tmpAccesoMediHasEspecialidad.AgregarEspecialidad(MediHasEspecialidad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function

End Class
