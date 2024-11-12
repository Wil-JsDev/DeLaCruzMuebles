Imports CapaEntidades
Imports DAL

Public Class ProveedorService

    Private ReadOnly _dal As New ProveedorCrud

    Public Sub InsertarProveedorService(proveedor As Proveedor)
        If proveedor Is Nothing Then
            Throw New ArgumentNullException("Proveedor no enviado")
        Else
            _dal.InsertarProveedor(proveedor)
        End If
    End Sub

    Public Function ObtenerProveedorService() As List(Of Proveedor)
        Return _dal.ObtenerProveedor()
    End Function

    Public Sub ActualizarProveedorService(proveedor As Proveedor)
        If proveedor Is Nothing Then
            Throw New ArgumentNullException("Proveedor no enviado")
        Else
            _dal.ActualizarProveedor(proveedor)
        End If
    End Sub

    Public Sub EliminarProveedorService(IdProveedor As Integer)
        If IdProveedor <= 0 Then
            Throw New ArgumentNullException("Proveedor no enviado")
        Else
            _dal.EliminarProveedor(IdProveedor)
        End If
    End Sub

End Class
