Imports System.Data.SqlClient
Imports CapaEntidades

Public Class ProductoCrud
    Private conexionString As New Conexion()

    Public Function InsertarProducto(producto As Producto) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion()
            Dim cmd As New SqlCommand("ProductosCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@opcion", 1)
            cmd.Parameters.AddWithValue("@Nombre_Producto", producto.NombreProducto)
            cmd.Parameters.AddWithValue("@Precio", producto.Precio)
            cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad)
            cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria)
            cmd.Parameters.AddWithValue("@IdProveedor", producto.IdProveedor)

            conexionSql.Open()
            Dim filasInsertadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasInsertadas > 0
        End Using
    End Function



    Public Function ObtenerProductos() As List(Of Producto)
        Dim producto As New List(Of Producto)

        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("ProductosCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 2)
            conexionSql.Open()

            Dim leer As SqlDataReader = cmd.ExecuteReader()

            While leer.Read()
                producto.Add(New Producto With {
                             .IdProducto = Convert.ToInt32(leer("IdProducto")),
                             .NombreProducto = leer("NombreProducto"),
                             .Precio = Convert.ToDecimal(leer("Precio")),
                             .Cantidad = Convert.ToInt32(leer("Cantidad")),
                             .IdCategoria = Convert.ToInt32(leer("IdCategoria")),
                             .IdProveedor = Convert.ToInt32(leer("IdProducto"))
                })
            End While
            Return producto
        End Using
    End Function

    Public Function ActualizarProducto(producto As Producto) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("ProductosCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 3)
            cmd.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto)
            cmd.Parameters.AddWithValue("@Precio", producto.Precio)
            cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad)
            cmd.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria)
            cmd.Parameters.AddWithValue("@IdProveedor", producto.IdProveedor)

            conexionSql.Open()
            Dim filasActualizadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasActualizadas > 0

        End Using
    End Function

    Public Function EliminarProducto(producto As Producto) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("ProductosCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 4)
            cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto)

            conexionSql.Open()

            Dim filasEliminadas As Integer = cmd.ExecuteNonQuery()

            conexionSql.Close()

            Return filasEliminadas > 0
        End Using
    End Function
End Class
