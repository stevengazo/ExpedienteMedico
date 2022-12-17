Imports Objetos
Imports AccesoDatos

Public Class PacienteNegocio
    Dim ConexionAccesoDatos As New AccesoDatos.MetodoPacientes
    Dim tmpNegocio As New AccesoDatos.MetodoPacientes

    Public Function ObtenerPaciente(id As Integer) As Objetos.Paciente
        Try
            If id = 0 Then
                Return New Objetos.Paciente()
            Else
                Return tmpNegocio.ObtenerPacientePorId(id)
            End If

        Catch ex As Exception
            Return New Objetos.Paciente()
        End Try
    End Function


    ''' <summary>
    ''' Ingresa un nuevo paciente en la DB  
    ''' </summary>
    ''' <param name="pacienteTMP">Objeto de tipo paciente a ingresar</param>
    ''' <returns>0 si presenta error, </returns>
    ''' 
    Public Function ListaPacientes() As List(Of Objetos.Paciente)
        Try
            Return tmpNegocio.ObtenerListaPacientes()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Paciente)
        End Try
    End Function
    Public Function AgregarPaciente(pacienteTMP As Objetos.Paciente) As Integer
        Try
            Dim accesoDatosPaciente As New AccesoDatos.MetodoPacientes
            Return accesoDatosPaciente.AgregarPaciente(pacienteTMP)
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
    End Function


    Public Function ObtenerPacientes() As List(Of Objetos.Paciente)
        Try
            Dim accesoDatosPaciente As New AccesoDatos.MetodoPacientes
            Return accesoDatosPaciente.ListarPacientes()
        Catch ex As Exception
            Return New List(Of Objetos.Paciente)
        End Try
    End Function

    Public Function BorrarPaciente(idPaciente As Integer) As Boolean
        Try
            Dim codigo As Integer = ConexionAccesoDatos.BorrarPaciente(idPaciente)
            If codigo = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Console.Write(ex.Message)
            Return False
        End Try
    End Function

    Public Function ActualizarPaciente(paciente As Objetos.Paciente) As Boolean
        Try
            Dim estado = ConexionAccesoDatos.ActualizarPaciente(paciente)
            If estado Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function
End Class
