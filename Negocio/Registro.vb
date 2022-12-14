Imports AccesoDatos
Imports Objetos


''' <summary>
''' Clase para la gestión de la información de Registro
''' </summary>
Public Class Registro
    ''' <summary>
    ''' Conexión estandar a acceso a datos
    ''' </summary>
    Private _AccesoDatosRegistro As New AccesoDatos.Registro()
    ''' <summary>
    ''' Lista todos los registros asociados a un expediente
    ''' </summary>
    ''' <param name="id">Expediente a consultar</param>
    ''' <returns>Lista de registros</returns>
    Public Function ListarRegistrosPorExpediente(id As Integer) As List(Of Objetos.Registro)
        Try
            Return _AccesoDatosRegistro.ListarRegistrosPorExpediente(id)
        Catch ex As Exception
            Return New List(Of Objetos.Registro)
        End Try
    End Function
    ''' <summary>
    ''' Generar un nuevo registro en la DB para la inserción de citas, diagnosticos y recetas
    ''' </summary>
    ''' <param name="idExpediente"> Expediente al cual se agrega</param>
    ''' <param name="idSucursal">Sucursal en las cual será atendido (general de uso general para cita,receta y diagnostico)</param>
    ''' <returns>True si agrega el registro, false si no lo logra o presenta error</returns>
    Public Function GenerarRegistro(idExpediente As Integer, idSucursal As Integer) As Integer
        Try
            Return _AccesoDatosRegistro.AñadirRegistro(idExpediente, idSucursal)
        Catch ex As Exception
            Return 0
        End Try
    End Function


End Class
