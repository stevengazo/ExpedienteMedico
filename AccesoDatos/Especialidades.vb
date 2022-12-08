﻿Imports System.Data.SqlClient
Imports Objetos

Public Class Especialidades
    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)

    ''' <summary>
    ''' Lista las especialidades medicas almacenadas en la DB
    ''' </summary>
    ''' <returns>lista de objetos de tipo especialidad</returns>
    Public Function ListarEspecialidades() As List(Of Objetos.Especialidad)
        Try
            Dim data As New DataSet()
            Dim listaProvincias As New List(Of Objetos.Especialidad)
            ''
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Especialidad"
            comando.CommandType = CommandType.Text
            comando.Connection = conection


            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Especialidad")
            conection.Close()

            For Each mydatarow In data.Tables(0).Rows
                Dim tmpObject As New Objetos.Especialidad
                tmpObject.idEspecialidad = mydatarow(0)
                tmpObject.Nombre = mydatarow(1)
                listaProvincias.Add(tmpObject)
            Next
            Return listaProvincias
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Especialidad)
        End Try
    End Function
End Class




