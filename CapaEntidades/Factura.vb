Public Class Factura

    Public Property IdFactura As Integer

    Public Property Fecha As DateTime = DateTime.UtcNow

    Public Property TipoDePago As String

    Public Property IdCliente As Integer

    Public Property IdEmpleado As Integer

    Public Property Total As Decimal

End Class
