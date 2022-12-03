﻿Imports Objetos
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

    Public Function ListaMedicos() As List(Of Objetos.Medico)
        Try
            Dim tmpNegocio As New AccesoDatos.MetodosMedico
            Return tmpNegocio.ObtenerListaMedicos()
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Medico)
        End Try
    End Function
End Class
