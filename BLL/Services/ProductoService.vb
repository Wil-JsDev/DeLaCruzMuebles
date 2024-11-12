Imports CapaEntidades
Imports DAL

Public Class ProductoService

    Private ReadOnly _dal As New ProductoCrud

    Public Sub InsertarProductoService(producto As Producto)
        If producto Is Nothing Then
            Throw New ArgumentNullException("Producto no enviado")
        Else
            _dal.InsertarProducto(producto)
        End If
    End Sub

    Public Function ObtenerProductoService() As List(Of Producto)
        Return _dal.ObtenerProductos()
    End Function

    Public Sub ActualizarProductoService(producto As Producto)
        If producto Is Nothing Then
            Throw New ArgumentNullException("Producto no enviado")
        Else
            _dal.ActualizarProducto(producto)
        End If
    End Sub

    Public Sub EliminarProductoService(IdProducto As Integer)
        If IdProducto <= 0 Then
            Throw New ArgumentNullException("Producto no enviado")
        Else
            _dal.EliminarProducto(IdProducto)
        End If
    End Sub

End Class
