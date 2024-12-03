Imports System.Data.SqlClient
Imports CapaEntidades
Imports DAL

Public Class FacturaService
    Private _factura As New FacturarDAL()

    Public Sub CrearFactura(factura As Factura, detalles As List(Of DetallerFactura))
        Try
            _factura.InsertarFactra(factura, detalles)

        Catch ex As SqlException
            Throw New Exception("Ocurrió un error al crear la factura: " & ex.Message)

        Catch ex As Exception
            Throw New Exception("Ocurrió un error inesperado: " & ex.Message)
        End Try

    End Sub

End Class
