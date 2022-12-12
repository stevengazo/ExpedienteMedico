Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Objetos

Public Class MetodosMedicamento
    Dim conection As New SqlConnection(DATOSGENERALES.StringConnection)
    ''' <summary>
    ''' Ingresa un nuevo medicamento en el sistema 
    ''' </summary>
    ''' <param name="nombre">Nombre del medicamento </param>
    ''' <param name="casafarm">Casa farmaceutica del medicamento</param>
    ''' <param name="descrip">Descripcion del medicamento</param>
    ''' <returns>Retorna el id del medicamento ingresado</returns>
    Public Function InsertaMedicamento(medicamento As Objetos.Medicamento) As Integer
        Dim idMedicamento As Integer = 0
        Try
            'instanciar el comando
            Dim command As New SqlCommand
            command.CommandText = "MedicamentoAgregar"
            command.CommandType = CommandType.StoredProcedure
            command.Connection = conection

            'agregar parametros
            'son parametros de entrada
            command.Parameters.Add("@_Nombre", SqlDbType.VarChar, 50).Value = medicamento.Nombre
            command.Parameters.Add("@_Casa_Farmaceutica ", SqlDbType.VarChar, 1000).Value = medicamento.CasaFarmaceutica
            command.Parameters.Add("@_Descripcion ", SqlDbType.VarChar, 1000).Value = medicamento.Descripcion

            'agregar los parametros de salida
            command.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            command.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            command.Parameters.Add("@idMedicamento", SqlDbType.Int).Direction = ParameterDirection.Output

            'abrir la conexion
            conection.Open()

            'ejecutar
            command.ExecuteNonQuery()

            'cerrar la conexion
            conection.Close()

            If command.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + command.Parameters("@_mensaje_error").Value)
            Else
                idMedicamento = command.Parameters("@idMedicamento").Value
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return idMedicamento
    End Function

    Public Function ObtenerListaMedicamento() As List(Of Objetos.Medicamento)
        Try
            Dim _dataSet As New DataSet()
            Dim listaMedi As New List(Of Objetos.Medicamento)
            Dim comando As New SqlCommand()
            comando.CommandText = "Select * from Medicamento"
            comando.CommandType = CommandType.Text
            comando.Connection = conection

            conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(_dataSet, "Medicamentos")
            conection.Close()


            For Each datarow In _dataSet.Tables(0).Rows
                Dim tmp As New Objetos.Medicamento
                tmp.idMedicamento = Integer.Parse(datarow(0))
                tmp.Nombre = datarow(1)
                tmp.CasaFarmaceutica = datarow(2)
                tmp.Descripcion = datarow(3)
                listaMedi.Add(tmp)
            Next
            Return listaMedi
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return New List(Of Objetos.Medicamento)
        End Try
    End Function
    Public Function BorrarMedicamento(idMedicamento As Integer) As Integer
        Try
            Dim _comando As New SqlCommand()
            _comando.CommandText = "[dbo].[EliminarMedicamento]"
            _comando.CommandType = CommandType.StoredProcedure
            _comando.Connection = conection
            'son parametros de entrada (envia el id al procedimiento)
            _comando.Parameters.Add("@idMedicamento", SqlDbType.Int).Value = idMedicamento
            'agregar los parametros de salida
            _comando.Parameters.Add("@ErrorMessage", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            _comando.Parameters.Add("@ErrorCode", SqlDbType.Int).Direction = ParameterDirection.Output

            conection.Open()
            _comando.ExecuteNonQuery()
            conection.Close()
            If _comando.Parameters("@ErrorCode").Value = 0 Then
                Return 0
            Else
                Return _comando.Parameters("@ErrorCode").Value
            End If
        Catch ex As Exception
            Return 1
        End Try
    End Function

End Class
