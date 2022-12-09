Imports Objetos
Imports AccesoDatos
Imports System.Net.Http.Headers

Public Class PacienteNegocio


    ''' <summary>
    ''' Ingresa un nuevo paciente en la DB  
    ''' </summary>
    ''' <param name="pacienteTMP">Objeto de tipo paciente a ingresar</param>
    ''' <returns>0 si presenta error, </returns>
    ''' 
    Public Function ListaPacientes() As List(Of Objetos.Paciente)
        Try
            Dim tmpNegocio As New AccesoDatos.MetodoPacientes
            Return tmpNegocio.ObtenerListaPacientes()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Paciente)
        End Try
    End Function
    Public Function AgregarPaciente(pacienteTMP As Objetos.Paciente) As Integer
        Try
            Dim accesoDatosPaciente As New AccesoDatos.Paciente
            Return accesoDatosPaciente.AgregarPaciente(pacienteTMP)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
    End Function


    Public Function ObtenerPacientes() As List(Of Objetos.Paciente)
        Try
            Dim accesoDatosPaciente As New AccesoDatos.Paciente
            Return accesoDatosPaciente.ListarPacientes()
        Catch ex As Exception
            Return New List(Of Objetos.Paciente)
        End Try
    End Function
End Class
