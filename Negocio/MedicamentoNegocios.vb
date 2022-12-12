Imports Objetos
Imports AccesoDatos
Imports System.Security.Cryptography

Public Class MedicamentoNegocios
    Dim ConexionAccesoDatos As New AccesoDatos.MetodosMedicamento
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objMedicamento"></param>
    Public Function AgregarMedicamento(medicamento As Objetos.Medicamento) As Integer
        Try
            Dim obtieneDatos As New AccesoDatos.MetodosMedicamento

            Return obtieneDatos.InsertaMedicamento(medicamento)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objMedicamento"></param>
    ''' <returns></returns>
    Public Function BorrarMedicamento(objMedicamento As Medicamento) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objMedicamento"></param>
    ''' <returns></returns>
    Public Function ActualizarMedicamento(objMedicamento As Medicamento) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idMedicamento"></param>
    ''' <returns></returns>
    Public Function ObtenerMedicamentoPorId(idMedicamento As String) As Medicamento
        Try
            Throw New NotImplementedException()
            Return New Medicamento
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New Medicamento
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function ListaMedicamento() As List(Of Objetos.Medicamento)
        Try
            Dim tmpNegocio As New AccesoDatos.MetodosMedicamento
            Return tmpNegocio.ObtenerListaMedicamento()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Medicamento)
        End Try
    End Function

    Public Function BorrarMedicamento(idMedicamento As Integer) As Boolean
        Try
            Dim codigo As Integer = ConexionAccesoDatos.BorrarMedicamento(idMedicamento)
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
End Class
