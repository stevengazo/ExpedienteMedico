Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Objetos

Public Class Cita
    Private _conexion As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function InsertarCita(tmp As Objetos.Citas) As Integer
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "[dbo].[CitaAgregar]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = _conexion
            'son parametros de entrada
            command.Parameters.Add("@_Fecha", SqlDbType.Date).Value = tmp.Fecha.ToString()
            'agregar los parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@idCita", SqlDbType.Int).Direction = ParameterDirection.Output
            'abrir la conexion
            _conexion.Open()
            'ejecutar
            command.ExecuteNonQuery()
            'cerrar la conexion
            _conexion.Close()
            If command.Parameters("@_codigo_error").Value = 0 Then
                Return command.Parameters("@idCita").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function ObtenerRegistro(id As Integer) As Objetos.Citas
        Try
            Dim _dataset As New DataSet()
            Dim Cita As New Objetos.Citas()
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM CITAS WHERE Citas.idCita = " + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = _conexion
            ' Open the connection with sql server
            _conexion.Open()
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(_dataset, "Citas")
            _conexion.Close()

            For Each row In _dataset.Tables(0).Rows
                Cita.idCita = Integer.Parse(row(0))
                Cita.Fecha = Date.Parse(row(1))
            Next
            Return Cita
        Catch ex As Exception
            Return New Objetos.Citas
        End Try
    End Function

    Public Function BorrarCita(id As Integer) As Integer
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "[dbo].[CitaBorrar]"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = _conexion
            'son parametros de entrada
            command.Parameters.Add("@_idCita", SqlDbType.Int).Value = id
            'agregar los parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@Borrado", SqlDbType.Bit).Direction = ParameterDirection.Output
            'abrir la conexion
            _conexion.Open()
            'ejecutar
            command.ExecuteNonQuery()
            'cerrar la conexion
            _conexion.Close()
            Return command.Parameters("@Borrado").Value
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class
