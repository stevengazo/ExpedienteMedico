Imports System.Data.SqlClient
Imports Objetos

Public Class Inventario
    Dim _conexion As New SqlConnection(DATOSGENERALES.StringConnection)


    Public Function ListarInventarioPorSucursal(idSucursal As Integer) As List(Of Objetos.InventarioMedico)
        Try
            Dim data As New DataSet()
            Dim listaInventario As New List(Of Objetos.InventarioMedico)
            Dim comando As New SqlCommand()
            comando.CommandText = "
                DECLARE @_idSucursal int = " & idSucursal & "
                SELECT IM.*, m.Nombre  
                FROM INVENTARIOMEDICO AS IM
                INNER JOIN 
	                (SELECT idInventario  FROM InvHasSucur WHERE InvHasSucur.idSucursal = @_idSucursal) AS TMP
	                ON IM.idInventario = TMP.idInventario
                inner join 
	                Medicamento as M	
	                on im.Medicamento_id = m.idMedicamento
                where IM.CantDisponible>0
                "
            comando.CommandType = CommandType.Text
            comando.Connection = _conexion
            _conexion.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "InventarioMedico")
            _conexion.Close()
            For Each row In data.Tables(0).Rows
                Dim tmp As New Objetos.InventarioMedico()
                tmp.idInventario = row(0)
                tmp.NumLote = row(1)
                tmp.FechaIngreso = Date.Parse(row(2))
                tmp.FechaVencimiento = Date.Parse(row(3))
                tmp.Refrigeracion = Boolean.Parse(row(4))
                tmp.CantidadDisponible = Integer.Parse(row(5))
                tmp.IdMedicamento = Integer.Parse(row(6))
                Dim tmpMediAccess As New AccesoDatos.Medicamento
                tmp.Medicamento = tmpMediAccess.ObtenerRegistro(tmp.IdMedicamento)
                listaInventario.Add(tmp)
            Next
            Return listaInventario
        Catch ex As Exception
            Return New List(Of Objetos.InventarioMedico)
        End Try
    End Function

    Public Function AgregarRegistro(obj As Objetos.InventarioMedico) As Integer
        Try
            Dim comando As New SqlCommand()
            comando.CommandText = "[dbo].[InventarioAgregar]"
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = _conexion
            ' parametros entrada 
            comando.Parameters.Add("@_NumLote", SqlDbType.VarChar, 30).Value = obj.NumLote
            comando.Parameters.Add("@_FechaIngreso", SqlDbType.Date).Value = obj.FechaIngreso
            comando.Parameters.Add("@_FechaVencimiento", SqlDbType.Date).Value = obj.FechaVencimiento
            comando.Parameters.Add("@_Refrigeracion", SqlDbType.Bit).Value = obj.Refrigeracion
            comando.Parameters.Add("@_Cantidad", SqlDbType.Int).Value = obj.CantidadDisponible
            comando.Parameters.Add("@_idMedicamento", SqlDbType.Int).Value = obj.IdMedicamento
            ' parametros de salida
            comando.Parameters.Add("@_codigo_error", SqlDbType.Int).Direction = ParameterDirection.Output
            comando.Parameters.Add("@_mensaje_error", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output
            comando.Parameters.Add("@idInventario", SqlDbType.Int).Direction = ParameterDirection.Output
            ' abre la conexión
            _conexion.Open()
            comando.ExecuteNonQuery()
            _conexion.Close()
            If comando.Parameters("@_codigo_error").Value <> 0 Then
                Throw New Exception("Error: " + comando.Parameters("@msj_error").Value)
            Else
                If comando.Parameters("@idInventario").Value = 0 Then
                    Return 0
                Else
                    Return comando.Parameters("@idInventario").Value
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            Return 0
        End Try
    End Function


    Public Function ObtenerRegistro(inventario As Integer) As Objetos.InventarioMedico
        Try
            Dim data As New DataSet()
            Dim listaInventario As New List(Of Objetos.InventarioMedico)
            Dim comando As New SqlCommand()
            comando.CommandText = "select * from InventarioMedico where idInventario =" + inventario.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = _conexion
            _conexion.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "InventarioMedico")
            _conexion.Close()
            Dim tmp As New Objetos.InventarioMedico
            For Each row In data.Tables(0).Rows
                tmp.idInventario = row(0)
                tmp.NumLote = row(1)
                tmp.FechaIngreso = Date.Parse(row(2))
                tmp.FechaVencimiento = Date.Parse(row(3))
                tmp.Refrigeracion = Boolean.Parse(row(4))
                tmp.CantidadDisponible = Integer.Parse(row(5))
                tmp.IdMedicamento = Integer.Parse(row(6))
            Next
            Return tmp
        Catch ex As Exception
            Return New Objetos.InventarioMedico
        End Try
    End Function

    Public Function ListarRegistros(idSucursal) As List(Of Objetos.InventarioMedico)
        Try
            Dim data As New DataSet()
            Dim listaInventario As New List(Of Objetos.InventarioMedico)
            Dim comando As New SqlCommand()
            comando.CommandText = "select IM.* from InventarioMedico as IM inner join InvHasSucur as IHS on IHS.idInventario = IM.idInventario where IHS.idSucursal = " + idSucursal.ToString()
            comando.CommandType = CommandType.Text
            comando.Connection = _conexion
            _conexion.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "InventarioMedico")
            _conexion.Close()
            For Each row In data.Tables(0).Rows
                Dim tmp As New Objetos.InventarioMedico()
                tmp.idInventario = row(0)
                tmp.NumLote = row(1)
                tmp.FechaIngreso = Date.Parse(row(2))
                tmp.FechaVencimiento = Date.Parse(row(3))
                tmp.Refrigeracion = Boolean.Parse(row(4))
                tmp.CantidadDisponible = Integer.Parse(row(5))
                tmp.IdMedicamento = Integer.Parse(row(6))
                listaInventario.Add(tmp)
            Next
            Return listaInventario
        Catch ex As Exception
            Return New List(Of InventarioMedico)
        End Try
    End Function

    Public Function ListarRegistros() As List(Of Objetos.InventarioMedico)
        Try
            Dim data As New DataSet()
            Dim listaInventario As New List(Of Objetos.InventarioMedico)
            Dim comando As New SqlCommand()
            comando.CommandText = "select IM.* from InventarioMedico as IM  "
            comando.CommandType = CommandType.Text
            comando.Connection = _conexion
            _conexion.Open()
            Dim adapter As New SqlDataAdapter(comando)
            adapter.Fill(data, "InventarioMedico")
            _conexion.Close()
            For Each row In data.Tables(0).Rows
                Dim tmp As New Objetos.InventarioMedico()
                tmp.idInventario = row(0)
                tmp.NumLote = row(1)
                tmp.FechaIngreso = Date.Parse(row(2))
                tmp.FechaVencimiento = Date.Parse(row(3))
                tmp.Refrigeracion = Boolean.Parse(row(4))
                tmp.CantidadDisponible = Integer.Parse(row(5))
                tmp.IdMedicamento = Integer.Parse(row(6))
                listaInventario.Add(tmp)
            Next
            Return listaInventario
        Catch ex As Exception
            Return New List(Of InventarioMedico)
        End Try
    End Function
End Class
