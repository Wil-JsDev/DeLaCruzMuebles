Imports CapaEntidades
Imports System.Data.SqlClient

Public Class ProveedorCrud
    Private conexionString As New Conexion()

    Public Function InsertarProveedor(proveedor As Proveedor) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion()
            Dim cmd As New SqlCommand("ProveedorCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@opcion", 1)
            cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor)
            cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre)
            cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion)
            cmd.Parameters.AddWithValue("@Rnc", proveedor.Rnc)
            cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
            cmd.Parameters.AddWithValue("@IdCiudad", proveedor.IdCiudad)



            conexionSql.Open()
            Dim filasInsertadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasInsertadas > 0
        End Using
    End Function



    Public Function ObtenerProveedor() As List(Of Proveedor)
        Dim proveedor As New List(Of Proveedor)

        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("LeerProveedor", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            ''cmd.Parameters.AddWithValue("@opcion", 2)''
            conexionSql.Open()

            Dim leer As SqlDataReader = cmd.ExecuteReader()

            While leer.Read()
                proveedor.Add(New Proveedor With {
                             .IdProveedor = Convert.ToInt32(leer("Id_Proveedor")),
                             .Nombre = leer("Nombre"),
                             .Direccion = leer("Direccion"),
                             .Rnc = Convert.ToInt32(leer("Rnc")),
                             .Telefono = leer("Telefono"),
                             .IdCiudad = Convert.ToInt32(leer("Id_Ciudad"))
                })
            End While
            Return proveedor
        End Using
    End Function

    Public Function ActualizarProveedor(proveedor As Proveedor) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("ProveedorCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 3)
            cmd.Parameters.AddWithValue("@IdProveedor", proveedor.IdProveedor)
            cmd.Parameters.AddWithValue("@Nombre", proveedor.Nombre)
            cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion)
            cmd.Parameters.AddWithValue("@Rnc", proveedor.Rnc)
            cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
            cmd.Parameters.AddWithValue("@IdCiudad", proveedor.IdCiudad)

            conexionSql.Open()
            Dim filasActualizadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasActualizadas > 0

        End Using
    End Function

    Public Function EliminarProveedor(IdProveedor As Integer) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("ProductosCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 4)
            cmd.Parameters.AddWithValue("@IdProveedor", IdProveedor)

            conexionSql.Open()

            Dim filasEliminadas As Integer = cmd.ExecuteNonQuery()

            conexionSql.Close()

            Return filasEliminadas > 0
        End Using
    End Function
End Class
