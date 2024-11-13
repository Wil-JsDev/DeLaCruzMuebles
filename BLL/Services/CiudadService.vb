Imports CapaEntidades
Imports DAL

Public Class CiudadService

    Private ReadOnly _dal As New CiudadCrud

    Public Sub InsertarCiudadService(ciudad As Ciudad)
        If ciudad Is Nothing Then
            Throw New ArgumentNullException("La ciudad no puede ser nula")
        Else
            _dal.InsertCiudad(ciudad)
        End If
    End Sub

    Public Function ObtenerCiudadService() As List(Of Ciudad)
        Return _dal.ObtenerCiudad()
    End Function

    Public Sub ActualizarCiudadService(ciudad As Ciudad)
        If ciudad Is Nothing Then
            Throw New ArgumentNullException("La ciudad no puede ser nula")
        Else
            _dal.ActualizarCiudad(ciudad)
        End If
    End Sub

    Public Sub EliminarCiudadService(IdCiudad As Integer)
        If IdCiudad <= 0 Then
            Throw New ArgumentNullException("La ciudad no puede ser nula")
        Else
            _dal.EliminarCiudad(IdCiudad)
        End If

    End Sub
End Class
