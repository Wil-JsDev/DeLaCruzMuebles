Imports System.Data.SqlClient
Imports CapaEntidades

Public Class UsuarioCrud
    Private conexionString As New Conexion()
    Public Function login(usuario As String, contrasena As String) As Usuarios
        Dim usua As Usuarios = Nothing
        Using conex As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("UsuariosCRUD", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Opcion", 5)
            cmd.Parameters.AddWithValue("@Nombre", usuario)
            cmd.Parameters.AddWithValue("@contrasena", contrasena)

            conex.Open()
            Using leer As SqlDataReader = cmd.ExecuteReader()
                If leer.Read() Then
                    usua = New Usuarios() With {
                    .UsuarioId = Convert.ToInt32(leer("UsuarioId")),
                    .NombreUsuario = leer("NombreUsuario").ToString(),
                    .Contrasena = leer("Password").ToString()
                    }
                End If
            End Using
        End Using
        Return usua
    End Function
End Class
