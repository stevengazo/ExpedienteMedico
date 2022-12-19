Imports System.Data.SqlClient
Imports Objetos
Imports AccesoDatos

Public Class Registro
    ''' <summary>
    ''' Clase de conexión a la DB
    ''' </summary>
    Private conexion As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function AñadirRegistro(idExpediente As Integer, idSucursal As Integer) As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[GenerarRegistroEnExpediente]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
            'Parametros Entrada
            comando.Parameters.Add("@_idExpediente", SqlDbType.Int).Value = idExpediente
            comando.Parameters.Add("@_idSucursal", SqlDbType.Int).Value = idSucursal
            ' Parametros salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idRegistro", SqlDbType.Int).Direction = ParameterDirection.Output
            ' Conexion
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            '
            If comando.Parameters("@_codigo_error").Value = 0 Then
                Return comando.Parameters("@idRegistro").Value
            Else
                Throw New Exception("Error")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return 0
        End Try
    End Function


    Public Function ListarRegistrosPorExpediente(id As Integer) As List(Of Objetos.Registro)
        Try
            Dim _dataSet As New DataSet()
            Dim listaRegistros As New List(Of Objetos.Registro)
            Dim comando As New SqlCommand()
            comando.CommandText = "SELECT * FROM Registro WHERE Registro.Expediente_id =" + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            conexion.Open()
            Dim adaptador As New SqlDataAdapter(comando)
            adaptador.Fill(_dataSet, "Registro")
            conexion.Close()

            For Each row In _dataSet.Tables(0).Rows
                Dim tmp As New Objetos.Registro
                tmp.idRegistro = Integer.Parse(row(0))
                tmp.idMedico = Integer.Parse(row(1))
                tmp.idDiagnostico = Integer.Parse(row(2))
                tmp.idReceta = Integer.Parse(row(3))
                tmp.idCita = Integer.Parse(row(4))
                tmp.idSucursal = Integer.Parse(row(5))
                tmp.idExpediente = Integer.Parse(row(6))
                listaRegistros.Add(tmp)
            Next
            Return listaRegistros
        Catch ex As Exception
            Return New List(Of Objetos.Registro)
        End Try
    End Function


    Public Function ActualizarRegistro(Registro As Objetos.Registro) As Boolean
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[RegistroActualizar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
            'Parametros Entrada
            comando.Parameters.Add("@_idRegistro", SqlDbType.Int).Value = Registro.idRegistro
            comando.Parameters.Add("@_idMedico", SqlDbType.Int).Value = Registro.idMedico
            comando.Parameters.Add("@_idDiagnostico", SqlDbType.Int).Value = Registro.idDiagnostico
            comando.Parameters.Add("@_idReceta", SqlDbType.Int).Value = Registro.idReceta
            comando.Parameters.Add("@_idCita", SqlDbType.Int).Value = Registro.idCita
            ' Parametros salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@Editado", SqlDbType.Bit).Direction = ParameterDirection.Output
            ' Conexion
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            '
            If comando.Parameters("@Editado").Value Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function BorrarRegistro(id As Integer) As Boolean
        Try
            Dim _dataSet As New DataSet()
            Dim listaRegistros As New List(Of Objetos.Registro)
            Dim comando As New SqlCommand()
            comando.CommandText = "delete from Registro where idRegistro = " + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            conexion.Open()
            comando.ExecuteNonQuery()
            conexion.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
