Imports Objetos
Imports AccesoDatos

Public Class PacienteNegocio


    ''' <summary>
    ''' Ingresa un nuevo paciente en la DB  
    ''' </summary>
    ''' <param name="pacienteTMP">Objeto de tipo paciente a ingresar</param>
    ''' <returns>0 si presenta error, </returns>
    Public Function AgregarPaciente(pacienteTMP As Objetos.Paciente) As Integer
        Try


            Return 1
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
    End Function
End Class
