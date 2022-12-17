﻿Imports Objetos
Imports AccesoDatos
Imports System.Security.Cryptography

Public Class EnfermedadNegocio
    Dim ConexionAccesoDatos As New AccesoDatos.MetodosEnfermedad
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objEnfermedad"></param>
    Public Function AgregarEnfermedad(enfermedad As Objetos.Enfermedad) As Integer
        Try
            Dim obtieneDatos As New AccesoDatos.MetodosEnfermedad

            Return obtieneDatos.InsertaEnfermedad(enfermedad)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objEnfermedad"></param>
    ''' <returns></returns>
    Public Function BorrarEnfermedad(idEnfermedad As Integer) As Boolean
        Try
            Dim codigo As Integer = ConexionAccesoDatos.BorrarEnfermedad(idEnfermedad)
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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objEnfermedad"></param>
    ''' <returns></returns>
    Public Function ActualizarEnfermedad(Enfermedad As Objetos.Enfermedad) As Boolean
        Try
            Dim estado = ConexionAccesoDatos.ActualizarEnfermedad(Enfermedad)
            If estado Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception

        End Try
    End Function
    ''' <summary>
    ''' Obtiene una enfermedad de la base de datos
    ''' </summary>
    ''' <param name="idEnfermedad"></param>
    ''' <returns></returns>
    Public Function ObtenerEnfermedadPorId(idEnfermedad As Integer) As Enfermedad
        Try
            Return ConexionAccesoDatos.ObtenerEnfermedad(idEnfermedad)
            Return New Enfermedad
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New Enfermedad
        End Try
    End Function
    ''' <summary>
    ''' Lista las enfermedades registradas
    ''' </summary>
    ''' <returns>Lista de tipo enfermedad</returns

    Public Function ListaEnfermedad() As List(Of Objetos.Enfermedad)
        Try
            Dim tmpNegocio As New AccesoDatos.MetodosEnfermedad
            Return tmpNegocio.ObtenerListaEnfermedades()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Enfermedad)
        End Try
    End Function

    Public Function ObtenerEnfermedad(id As Integer) As Objetos.Enfermedad
        Try
            If id = 0 Then
                Return New Objetos.Enfermedad()
            Else
                Return ConexionAccesoDatos.ObtenerEnfermedadPorId(id)
            End If

        Catch ex As Exception
            Return New Objetos.Enfermedad()
        End Try
    End Function
End Class
