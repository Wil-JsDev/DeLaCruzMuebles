Imports CapaEntidades
Imports DAL

Public Class ClienteService

    Private ReadOnly _dal As New ClienteCrud

    Public Sub InsertarClienteService(cliente As Cliente)
        If cliente Is Nothing Then
            Throw New ArgumentNullException("cliente no enviado")
        Else
            _dal.InsertarCliente(cliente)
        End If
    End Sub

    Public Function ObtenerClientesService() As List(Of Cliente)
        Return _dal.ObtenerCliente()
    End Function

    Public Sub ActualizarClienteService(cliente As Cliente)
        If cliente Is Nothing Then
            Throw New ArgumentNullException("cliente no enviado")
        Else
            _dal.ActualizarCliente(cliente)
        End If
    End Sub

    Public Sub EliminarClienteService(IdCliente As Integer)
        If IdCliente <= 0 Then
            Throw New ArgumentNullException("cliente no enviado")
        Else
            _dal.EliminarCliente(IdCliente)
        End If
    End Sub
End Class
