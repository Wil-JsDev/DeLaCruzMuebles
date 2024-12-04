Imports CapaEntidades
Imports DAL

Public Class InventarioService

    Private _dalInventario As New InventarioDAL()
    Private _dalProducto As New ProductoCrud()

    Public Sub InsertarProductoInventario(inventario As Inventario)
        _dalInventario.InsertarProductoInventrario(inventario)
    End Sub

    Public Function ObtenerProducto() As List(Of Producto)
        Return _dalProducto.ObtenerProductos()
    End Function

End Class
