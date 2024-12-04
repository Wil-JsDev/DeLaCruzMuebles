Imports System.Data.SqlClient
Imports CapaEntidades

Public Class InventarioDAL
    Private _conexion As New Conexion()

    Public Sub InsertarProductoInventrario(inventario As Inventario)

        Using sqlConnection As SqlConnection = _conexion.ObtenerConexion()
            Dim cmd As New SqlCommand("InsertarProductoEnInventario", sqlConnection)
            sqlConnection.Open()
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdCategoria", inventario.IdCategoria)
            cmd.Parameters.AddWithValue("@Cantidad", inventario.Cantidad)
            cmd.Parameters.AddWithValue("@IdProducto", inventario.IdProducto)
            cmd.ExecuteNonQuery()

            sqlConnection.Close()

        End Using

    End Sub

End Class
