Imports System.Data.SqlClient
Imports CapaEntidades

Public Class FacturarDAL

    Private conexion As New Conexion()

    Public Sub InsertarFactra(factura As Factura, detalles As List(Of DetallerFactura))

        Using sqlConnection As SqlConnection = conexion.ObtenerConexion
            Dim cmd As New SqlCommand("InsertarFactura", sqlConnection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdFactura", factura.IdFactura)
            cmd.Parameters.AddWithValue("@IdCliente", factura.IdCliente)
            cmd.Parameters.AddWithValue("@@Tipo_De_Pago", factura.TipoDePago)
            cmd.Parameters.AddWithValue("@IdEmpleado", factura.IdEmpleado)
            cmd.Parameters.AddWithValue("@Fecha", factura.Fecha)

            ''Dim detalleFactura = cmd.Parameters.AddWithValue("@DetallesFactura",)''

        End Using
    End Sub

    Private Function ConvertToTable(detalles As List(Of DetallerFactura))
        Dim table As New DataTable()
        table.Columns.Add("Id_Producto", GetType(Integer))
        table.Columns.Add("Cantidad", GetType(Integer))
        table.Columns.Add("Precio_Total", GetType(Decimal))
        table.Columns.Add("Descuento", GetType(Decimal))
        table.Columns.Add("Precio", GetType(Decimal))

        For Each detalle In detalles
            table.Rows.Add(detalle.IdProducto, detalle.Cantidad, detalle.PrecioTotal, detalle.Descuento, detalle.Precio)
        Next
        Return table

    End Function

End Class
