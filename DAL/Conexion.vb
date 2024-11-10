Imports System.Data.SqlClient

Public Class Conexion

    Private connectionString As String = "Data Source=DESKTOP-RCAMOUQ\SQLEXPRESS;Initial Catalog=DECORACIONES_AMBAR;Integrated Security=True;Trust Server Certificate=True"

    Public Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class
