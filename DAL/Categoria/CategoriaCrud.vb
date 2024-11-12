Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports CapaEntidades


Public Class CategoriaCrud
    Private conexionString As New Conexion()

    Public Function InsertarCategoria(categoria As Categoria) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("CategoriaCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 1)
            cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre)

            conexionSql.Open()
            Dim filasInsertadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()
            Return filasInsertadas > 0


        End Using

    End Function

    Public Function ObtenerCategoria() As List(Of Categoria)
        Dim categoria As New List(Of Categoria)
        Using conexionsql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("CategoriaCRUD", conexionsql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 2)
            conexionsql.Open()
            Dim leer As SqlDataReader = cmd.ExecuteReader

            While leer.Read()
                categoria.Add(New Categoria With {
                             .IdCategoria = Convert.ToInt32(leer("IdCategoria")),
                             .Nombre = leer("Nombre")
                })
            End While

            Return categoria

        End Using

    End Function

    Public Function ActualizarCategoria(categoria As Categoria) As Boolean
        Using conexionsql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("CategoriaCRUD", conexionsql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 3)
            cmd.Parameters.AddWithValue("Nombre", categoria.Nombre)

            conexionsql.Open()
            Dim filasActualizadas As Integer = cmd.ExecuteNonQuery()
            conexionsql.Close()

            Return filasActualizadas > 0

        End Using

    End Function

    Public Function EliminarCategoria(IdCategoria As Integer) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("CategoriaCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 4)
            cmd.Parameters.AddWithValue("IdCategoria", IdCategoria)

            conexionSql.Open()
            Dim filasEliminadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasEliminadas > 0

        End Using
    End Function





End Class
