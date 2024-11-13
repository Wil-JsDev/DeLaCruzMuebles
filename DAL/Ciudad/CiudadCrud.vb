Imports System.Data.SqlClient
Imports CapaEntidades


Public Class CiudadCrud
    Private conexionString As New Conexion()

    Public Function InsertCiudad(ciudad As Ciudad) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion()
            Dim cmd As New SqlCommand("CiudadCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 1)
            cmd.Parameters.AddWithValue("@Nombre", ciudad.Nombre)

            conexionSql.Open()
            Dim filasInsertadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasInsertadas > 0

        End Using

    End Function

    Public Function ObtenerCiudad() As List(Of Ciudad)
        Dim Ciudad As New List(Of Ciudad)
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion()
            Dim cmd As New SqlCommand("CiudadCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 2)

            Dim leer As SqlDataReader = cmd.ExecuteReader()

            conexionSql.Open()
            While leer.Read()
                Ciudad.Add(New Ciudad With {
                           .IdCiudad = Convert.ToInt32(leer("IdCiudad")),
                           .Nombre = leer("Nombre")
                })

            End While
            Return Ciudad
        End Using
    End Function


    Public Function ActualizarCiudad(ciudad As Ciudad) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion()
            Dim cmd As New SqlCommand("CiudadCrud", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 3)
            cmd.Parameters.AddWithValue("@Nombre", ciudad.Nombre)

            conexionSql.Open()
            Dim filasActualizadas As Integer = cmd.ExecuteNonQuery()
            Return filasActualizadas > 0
        End Using

    End Function

    Public Function EliminarCiudad(IdCiudad As Integer) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("CiudadCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 4)
            cmd.Parameters.AddWithValue("@IdCiudad", IdCiudad)

            conexionSql.Open()
            Dim filasEliminadas As Integer = cmd.ExecuteNonQuery()

            Return filasEliminadas > 0

        End Using

    End Function

End Class
