Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Objetos
Public Class Medicamento
    Private _conection As New SqlConnection(DATOSGENERALES.StringConnection)

    Public Function InsertarRegistro(obj As Objetos.Medicamento) As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[MedicamentoAgregar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = _conection
            ' Parametros de Entrada
            comando.Parameters.Add("@_Nombre", SqlDbType.VarChar, 40).Value = obj.Nombre
            comando.Parameters.Add("@_Casa_Farmaceutica", SqlDbType.VarChar, 60).Value = obj.CasaFarmaceutica
            comando.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 60).Value = obj.Descripcion

            ' Parametros de Salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idMedicamento", SqlDbType.Int).Direction = ParameterDirection.Output
            ' Abre la conexión
            _conection.Open()
            comando.ExecuteNonQuery()
            _conection.Close()

            If comando.Parameters("@idMedicamento").Value <> 0 Then
                Return comando.Parameters("@idMedicamento").Value
            Else
                Return 0
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return 0
        End Try
    End Function


    Public Function ActualizarRegistro(obj As Objetos.Medicamento) As Boolean
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[MedicamentoAgregar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = _conection
            ' Parametros de Entrada
            comando.Parameters.Add("@_idMedicamento", SqlDbType.Int).Value = obj.idMedicamento
            comando.Parameters.Add("@_Nombre", SqlDbType.VarChar, 40).Value = obj.Nombre
            comando.Parameters.Add("@_Casa_Farmaceutica", SqlDbType.VarChar, 60).Value = obj.CasaFarmaceutica
            comando.Parameters.Add("@_Descripcion", SqlDbType.VarChar, 60).Value = obj.Descripcion
            ' Parametros de Salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@Editado", SqlDbType.Bit).Direction = ParameterDirection.Output
            ' Abre la conexión
            _conection.Open()
            comando.ExecuteNonQuery()
            _conection.Close()
            If comando.Parameters("@Editado").Value Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function


    Public Function ObtenerRegistro(id As Integer) As Objetos.Medicamento
        Try
            Dim data As New DataSet()
            Dim Medicamento As New Objetos.Medicamento()
            Dim comando As New SqlCommand()
            comando.CommandText = "select * from Medicamento where Medicamento.idMedicamento = " + id.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = _conection
            _conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Medicamento")
            _conection.Close()
            For Each row In data.Tables(0).Rows
                Medicamento.idMedicamento = Integer.Parse(row(0))
                Medicamento.Nombre = row(1)
                Medicamento.CasaFarmaceutica = row(2)
                Medicamento.Descripcion = row(3)
            Next
            Return Medicamento
        Catch ex As Exception
            Return New Objetos.Medicamento()
        End Try
    End Function


    Public Function ListarRegistros() As List(Of Objetos.Medicamento)
        Try
            Dim data As New DataSet()
            Dim listaMedicamentos As New List(Of Objetos.Medicamento)
            Dim comando As New SqlCommand()
            comando.CommandText = "select * from Medicamento"
            comando.CommandType = CommandType.Text
            comando.Connection = _conection
            _conection.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "Medicamento")
            _conection.Close()
            For Each row In data.Tables(0).Rows
                Dim tmp As New Objetos.Medicamento()
                tmp.idMedicamento = Integer.Parse(row(0))
                tmp.Nombre = row(1)
                tmp.CasaFarmaceutica = row(2)
                tmp.Descripcion = row(3)
                listaMedicamentos.Add(tmp)
            Next
            Return listaMedicamentos
        Catch ex As Exception
            Return New List(Of Objetos.Medicamento)
        End Try
    End Function
End Class
