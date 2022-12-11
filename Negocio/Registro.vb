Imports AccesoDatos
Imports Objetos


''' <summary>
''' Clase para la gestión de la información de Registro
''' </summary>
Public Class Registro
    ''' <summary>
    ''' Conexión estandar a acceso a datos
    ''' </summary>
    Private AccesoDatosRegistro As New AccesoDatos.Registro()
    ''' <summary>
    ''' Lista todos los registros asociados a un expediente
    ''' </summary>
    ''' <param name="id">Expediente a consultar</param>
    ''' <returns>Lista de registros</returns>
    Private Function ListarRegistrosPorExpediente(id As Integer) As List(Of Objetos.Registro)
        Try

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
    Private Function GenerarRegistro(idExpediente As Integer, idSucursal As Integer) As Boolean
        Try
            'Dim Estado = AccesoDatosRegistro
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


End Class
