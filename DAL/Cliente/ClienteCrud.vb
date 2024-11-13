Imports CapaEntidades
Imports System.Data.SqlClient

Public Class ClienteCrud
    Private conexionString As New Conexion()

    Public Function InsertarCliente(cliente As Cliente) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion()
            Dim cmd As New SqlCommand("ClienteCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@opcion", 1)
            cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente)
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre)
            cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula)
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion)
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)

            conexionSql.Open()
            Dim filasInsertadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasInsertadas > 0
        End Using
    End Function



    Public Function ObtenerCliente() As List(Of Cliente)
        Dim cliente As New List(Of Cliente)

        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("LeerClientes", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            ''cmd.Parameters.AddWithValue("@LeerClientes")''
            conexionSql.Open()

            Dim leer As SqlDataReader = cmd.ExecuteReader()

            While leer.Read()
                cliente.Add(New Cliente With {
                         .IdCliente = Convert.ToInt32(leer("Id_Cliente")),
                         .Nombre = leer("Nombre"),
                         .Cedula = leer("Cedula"),
                         .Direccion = leer("Direccion"),
                         .Telefono = leer("Telefono")
            })
            End While
            Return cliente
        End Using
    End Function

    Public Function ActualizarCliente(cliente As Cliente) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("ClienteCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 3)
            cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente)
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre)
            cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula)
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion)
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono)

            conexionSql.Open()
            Dim filasActualizadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasActualizadas > 0

        End Using
    End Function

    Public Function EliminarCliente(IdCliente As Integer) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("EliminarCliente", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            ''cmd.Parameters.AddWithValue("@opcion", 4)''
            cmd.Parameters.AddWithValue("@IdCliente", IdCliente)

            conexionSql.Open()

            Dim filasEliminadas As Integer = cmd.ExecuteNonQuery()

            conexionSql.Close()

            Return filasEliminadas > 0
        End Using
    End Function
End Class
