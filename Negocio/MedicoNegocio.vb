Imports Objetos
Imports AccesoDatos

Public Class MedicoNegocio
    Public Function AgregarMedico(usuario As String, contrasena As String, nom As String, ape As String, ide As String, Tide As String, sexo As String, Ecivil As String, nac As String, Fnac As String, tel As String, correo As String,
                                  espe As String, Aexp As String, prov As String, can As String, dis As String, otras As String)
        Try
            Dim obtieneDatos As New AccesoDatos.MetodosMedico

            Return obtieneDatos.InsertaMedico(usuario, contrasena, nom, ape, ide, Tide, sexo, Ecivil, nac, Fnac, tel, correo,
                                  espe, Aexp, prov, can, dis, otras)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
