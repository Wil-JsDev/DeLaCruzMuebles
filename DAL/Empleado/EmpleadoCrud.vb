Imports CapaEntidades
Imports System.Data.SqlClient

Public Class EmpleadoCrud

    Private conexionString As New Conexion()

    Public Function InsertarEmpleado(empleados As Empleados) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion()
            Dim cmd As New SqlCommand("EmpleadoCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@opcion", 1)
            cmd.Parameters.AddWithValue("@Nombre", empleados.Nombre)
            cmd.Parameters.AddWithValue("@Telefono", empleados.Telefono)
            cmd.Parameters.AddWithValue("@Direccion", empleados.Direccion)
            cmd.Parameters.AddWithValue("@Cedula", empleados.Cedula)


            conexionSql.Open()
            Dim filasInsertadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasInsertadas > 0
        End Using
    End Function



    Public Function ObtenerEmpleados() As List(Of Empleados)
        Dim empleados As New List(Of Empleados)

        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("ProductosCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 2)
            conexionSql.Open()

            Dim leer As SqlDataReader = cmd.ExecuteReader()

            While leer.Read()
                empleados.Add(New Empleados With {
                             .IdEmpleado = Convert.ToInt32(leer("IdEmpleado")),
                             .Nombre = leer("NombreProducto"),
                             .Telefono = leer("Telefono"),
                             .Direccion = leer("Direccion"),
                             .Cedula = Convert.ToInt32(leer("IdEmpleado"))
                })
            End While
            Return empleados
        End Using
    End Function

    Public Function ActualizarEmpleados(empleado As Empleados) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("ProductosCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 3)
            cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre)
            cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono)
            cmd.Parameters.AddWithValue("@Direccion", empleado.Direccion)
            cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula)


            conexionSql.Open()
            Dim filasActualizadas As Integer = cmd.ExecuteNonQuery()
            conexionSql.Close()

            Return filasActualizadas > 0

        End Using
    End Function

    Public Function EliminarProducto(IdEmpleado As Integer) As Boolean
        Using conexionSql As SqlConnection = conexionString.ObtenerConexion
            Dim cmd As New SqlCommand("EmpleadoCRUD", conexionSql)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@opcion", 4)
            cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado)

            conexionSql.Open()

            Dim filasEliminadas As Integer = cmd.ExecuteNonQuery()

            conexionSql.Close()

            Return filasEliminadas > 0
        End Using
    End Function
End Class
