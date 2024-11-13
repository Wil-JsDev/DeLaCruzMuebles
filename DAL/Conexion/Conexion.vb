Imports System.Data.SqlClient

Public Class Conexion
    'Data Source=.;InitialCatalog=DECORACIONES_AMBAR;IntegratedSecurity=True;TrustServerCertificate=True'
    '"Data Source=NombreDelServidor;Initial Catalog=NombreDeLaBaseDeDatos;User ID=Usuario;Password=Contraseña;"
    '
    Private connectionString As String = "Data Source=DESKTOP-ULT646C\SQLEXPRESS;Initial Catalog=DECORACIONES_AMBAR;Integrated Security=True;TrustServerCertificate=True; "

    Public Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class

