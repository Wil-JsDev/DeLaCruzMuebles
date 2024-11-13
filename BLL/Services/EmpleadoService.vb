Imports CapaEntidades
Imports DAL

Public Class EmpleadoService

    Private ReadOnly _dal As New EmpleadoCrud

    Public Sub InsertarEmpleadoService(empleado As Empleados)
        If empleado Is Nothing Then
            Throw New ArgumentNullException("empleado no enviado")
        Else
            _dal.InsertarEmpleado(empleado)
        End If
    End Sub

    Public Function ObtenerEmpleadoService() As List(Of Empleados)
        Return _dal.ObtenerEmpleados()
    End Function


    Public Sub ActualizarEmpleadoService(empleado As Empleados)
        If empleado Is Nothing Then
            Throw New ArgumentNullException("empleado no enviado")
        Else
            _dal.ActualizarEmpleados(empleado)
        End If
    End Sub

    Public Sub EliminarEmpleadoService(IdEmpleado As Integer)
        If IdEmpleado <= 0 Then
            Throw New ArgumentNullException("empleado no enviado")
        Else
            _dal.EliminarProducto(IdEmpleado)
        End If
    End Sub

End Class
