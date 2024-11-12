Imports CapaEntidades
Imports DAL

Public Class CategoriaServices

    Private ReadOnly _dal As New CategoriaCrud()

    Public Function ObtenerCategoriaService() As List(Of Categoria)

        Return _dal.ObtenerCategoria()
    End Function

    Public Sub InsertarCategoriaService(categoria As Categoria)
        If categoria Is Nothing Then
            Throw New ArgumentNullException("La categoría no puede ser nula")

        Else
            _dal.InsertarCategoria(categoria)
        End If

    End Sub

    Public Sub ActualizarCategoriaService(categoria As Categoria)
        If categoria Is Nothing Then
            Throw New ArgumentNullException("La categoría no puede ser nula")
        Else
            _dal.ActualizarCategoria(categoria)
        End If
    End Sub

    Public Sub EliminarCategoriaService(Id As Integer)
        If Id <= 0 Then
            Throw New ArgumentNullException("La categoría no puede ser nula")
        Else
            _dal.EliminarCategoria(Id)
        End If
    End Sub

End Class
