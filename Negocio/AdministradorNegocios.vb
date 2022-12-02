Imports System.Runtime.InteropServices.WindowsRuntime
Imports Objetos
Imports AccesoDatos
Public Class AdministradorNegocios

    ''' <summary>
    ''' Agregar Nuevo Administrador
    ''' </summary>
    ''' <param name="objAdmin">Objeto de Tipo administrador a agregar a la  DB</param>
    Public Sub AgregarAdministrador(objAdmin As Administrador)
        Try
            Throw New NotImplementedException()
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
    End Sub

    ''' <summary>
    ''' Borra un administrador existente en la DB
    ''' </summary>
    ''' <param name="objAdmin">Administrador a Borrar</param>
    ''' <returns>True si fue borrado, False si no lo borro o presenta error</returns>
    Public Function BorrarAdministrador(objAdmin As Administrador) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Actualiza la información de un administrador existente
    ''' </summary>
    ''' <param name="objAdmin">Administrador a actualizar</param>
    ''' <returns>True si lo actualiza, False si presenta error</returns>
    Public Function ActualizarAdministrador(objAdmin As Administrador) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Busca un administrador en la base de datos y regresa el administrador 
    ''' </summary>
    ''' <param name="idAdminitrador">id del administrador a buscar</param>
    ''' <returns>Objeto de tipo administrador</returns>
    Public Function ObtenerAdministrador(idAdminitrador As Integer) As Administrador
        Try
            Throw New NotImplementedException()
            Return New Administrador()
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New Administrador()
        End Try
    End Function

    ''' <summary>
    ''' Verifica la información proporcionada e intenta ver si el login es valido
    ''' </summary>
    ''' <param name="nombreUsuario">Nombre de Usuario del Administrador</param>
    ''' <param name="contraseña">Contraseña Brindada</param>
    ''' <returns>True si la contraseña es correcta, False si no lo es o presenta error</returns>
    Public Function InicioSesion(nombreUsuario As String, contraseña As String) As Boolean
        Try
            If Not String.IsNullOrEmpty(nombreUsuario) Or Not String.IsNullOrEmpty(contraseña) Then
                Dim administradorDatos As New AdministradorDatos()
                Dim bandera As Boolean = administradorDatos.InicioSesion(nombreUsuario, contraseña)
                If bandera Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function


    ''' <summary>
    ''' Regresa la lista de administradores registrados en la DB
    ''' </summary>
    ''' <returns>Lista de administradores</returns>
    Public Function ListarAdministradores() As List(Of Administrador)
        Try
            Throw New NotImplementedException()
            Return New List(Of Administrador)
        Catch ex As Exception
            Throw New NotImplementedException()
            Return New List(Of Administrador)
        End Try
    End Function


    ''' <summary>
    ''' Comprueba la contraseña brindada y si puede iniciar sesión
    ''' </summary>
    ''' <param name="usuario">usuario que inicia sesión</param>
    ''' <param name="contraseña">Contraseña del usuario</param>
    ''' <returns>true si puede iniciar sesion, false si presenta un error o no puede iniciar sesion</returns>
    Public Function InicioSesionAdministrador(usuario As String, contraseña As String) As Boolean
        Try
            Throw New NotImplementedException()
            Return True
        Catch ex As Exception
            Throw New NotImplementedException()
            Return False
        End Try
    End Function
End Class
