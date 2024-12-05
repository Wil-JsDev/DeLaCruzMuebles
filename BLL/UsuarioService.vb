Imports CapaEntidades
Imports DAL

Public Class UsuarioService
    Dim usuariodal As New UsuarioCrud
    Public Function login(ByVal user As String, ByVal contra As String) As Usuarios
        Return usuariodal.login(user, contra)
    End Function
End Class
