Imports Objetos
Imports AccesoDatos

Public Class MedicoNegocio
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
                Return bandera
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
            Return False
        End Try
    End Function
End Class
