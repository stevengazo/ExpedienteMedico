﻿Imports Objetos
Imports AccesoDatos

Public Class MedicoNegocio
    Public Function AgregarMedico(medico As Objetos.Medico) As Integer
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
            Return New List(Of Objetos.Medico)
        End Try
    End Function

    ''' <summary>
    ''' Valida la información e intenta iniciar sesión
    ''' </summary>
    ''' <param name="usuario">usuario a verificar</param>
    ''' <param name="contraseña">contraseña</param>
    ''' <returns></returns>
    Public Function InicioSesion(usuario As String, contraseña As String) As Boolean
        Try
            If Not String.IsNullOrEmpty(usuario) And Not String.IsNullOrEmpty(contraseña) Then
                Dim mediNego As New MedicoNegocio()
                Dim bandera As Boolean = mediNego.InicioSesion(usuario, contraseña)
                If bandera Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function


    Public Function ObtenerMedicoPorId(id As Integer) As Objetos.Medico
        Try
            If id <> 0 Then
                Dim mediAcceso As New AccesoDatos.MetodosMedico()
                Return mediAcceso.ObtenerMedico(id)
            Else
                Return New Objetos.Medico()
            End If
        Catch ex As Exception
            Return New Objetos.Medico()
        End Try

    End Function
End Class
