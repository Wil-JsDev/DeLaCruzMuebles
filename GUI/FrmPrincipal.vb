Public Class frmPrincipal
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub fechaHora_Tick(sender As Object, e As EventArgs) Handles fechaHora.Tick
        lblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        lblFecha.Text = DateTime.Now.ToString("ddd MMM yyy")
    End Sub



    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Pnl1.Visible = True
        pnl2.Visible = False
        pnl3.Visible = False
        pnl4.Visible = False
        pnl5.Visible = False
        pnlInicio.Visible = False
        pnlRegistro.Visible = False
        pnlVentas.Visible = False
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Pnl1.Visible = False
        pnl2.Visible = True
        pnl3.Visible = False
        pnl4.Visible = False
        pnl5.Visible = False
        pnlInicio.Visible = False
        pnlRegistro.Visible = True
        pnlVentas.Visible = False
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Pnl1.Visible = False
        pnl2.Visible = False
        pnl3.Visible = True
        pnl4.Visible = False
        pnl5.Visible = False
        pnlInicio.Visible = False
        pnlRegistro.Visible = False
        pnlVentas.Visible = True

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Pnl1.Visible = False
        pnl2.Visible = False
        pnl3.Visible = False
        pnl4.Visible = True
        pnl5.Visible = False
        pnlInicio.Visible = False
        pnlRegistro.Visible = False
        pnlVentas.Visible = False
        pnlArticulos.Visible = True
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Pnl1.Visible = False
        pnl2.Visible = False
        pnl3.Visible = False
        pnl4.Visible = False
        pnl5.Visible = True
        pnlInicio.Visible = False
        pnlRegistro.Visible = False
        pnlVentas.Visible = False
        pnlArticulos.Visible = False
        pnlFacturacion.Visible = True
    End Sub

    Private Sub btn2salir_Click(sender As Object, e As EventArgs) Handles btn2salir.Click

    End Sub



#Region "label Eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPlaceholder(txtCodigo, "Codigo")
        SetPlaceholder(txtNombre, "Nombre")
        SetPlaceholder(txtSexo, "Sexo")
        SetPlaceholder(txtTelefono, "Telefono")
        SetPlaceholder(txtDireccion, "Direccion")
        SetPlaceholder(txtCedula, "Cedula")
    End Sub


    Private Sub txtCodigo_Enter(sender As Object, e As EventArgs) Handles txtCodigo.Enter
        ClearPlaceholder(txtCodigo, "Codigo")
    End Sub

    Private Sub txtNombre_Enter(sender As Object, e As EventArgs) Handles txtNombre.Enter
        ClearPlaceholder(txtNombre, "Nombre")
    End Sub

    Private Sub txtSexo_Enter(sender As Object, e As EventArgs) Handles txtSexo.Enter
        ClearPlaceholder(txtSexo, "Sexo")
    End Sub

    Private Sub txtTelefono_Enter(sender As Object, e As EventArgs) Handles txtTelefono.Enter
        ClearPlaceholder(txtTelefono, "Telefono")
    End Sub

    Private Sub txtDireccion_Enter(sender As Object, e As EventArgs) Handles txtDireccion.Enter
        ClearPlaceholder(txtDireccion, "Direccion")
    End Sub

    Private Sub txtCedula_Enter(sender As Object, e As EventArgs) Handles txtCedula.Enter
        ClearPlaceholder(txtCedula, "Cedula")
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        SetPlaceholderOnLeave(txtCodigo, "Codigo")
    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        SetPlaceholderOnLeave(txtNombre, "Nombre")
    End Sub

    Private Sub txtSexo_Leave(sender As Object, e As EventArgs) Handles txtSexo.Leave
        SetPlaceholderOnLeave(txtSexo, "Sexo")
    End Sub

    Private Sub txtTelefono_Leave(sender As Object, e As EventArgs) Handles txtTelefono.Leave
        SetPlaceholderOnLeave(txtTelefono, "Telefono")
    End Sub

    Private Sub txtDireccion_Leave(sender As Object, e As EventArgs) Handles txtDireccion.Leave
        SetPlaceholderOnLeave(txtDireccion, "Direccion")
    End Sub

    Private Sub txtCedula_Leave(sender As Object, e As EventArgs) Handles txtCedula.Leave
        SetPlaceholderOnLeave(txtCedula, "Cedula")
    End Sub

#Region "Panel Ventas"
    Private Sub Form1_Load2(sender As Object, e As EventArgs) Handles MyBase.Load

        SetPlaceholderOnLeave(txtDireccion, "Direccion")
        SetPlaceholderOnLeave(txtCedula, "Cedula")
        SetPlaceholderOnLeave(txtCodigo, "Codigo")
        SetPlaceholderOnLeave(txtIdVentas, "Id Ventas")
        SetPlaceholderOnLeave(TxtNombreVentas, "Nombre Ventas")
        SetPlaceholderOnLeave(TxtFechaVentas, "Fecha Ventas")
        SetPlaceholderOnLeave(txtNumeroReciboVentas, "Número Recibo Ventas")
        SetPlaceholderOnLeave(TxtTipoDePagoVentas, "Tipo de Pago Ventas")
        SetPlaceholderOnLeave(TxtIdEmpleado, "ID Empleado")
        SetPlaceholderOnLeave(txtPrecioPorPago, "Precio por Pago")
        SetPlaceholderOnLeave(TxtTotal, "Total")
    End Sub


    Private Sub txtIdVentas_Enter(sender As Object, e As EventArgs) Handles txtIdVentas.Enter
        ClearPlaceholder(txtIdVentas, "Id Ventas")
    End Sub

    Private Sub txtIdVentas_Leave(sender As Object, e As EventArgs) Handles txtIdVentas.Leave
        SetPlaceholderOnLeave(txtIdVentas, "Id Ventas")
    End Sub

    Private Sub TxtNombreVentas_Enter(sender As Object, e As EventArgs) Handles TxtNombreVentas.Enter
        ClearPlaceholder(TxtNombreVentas, "Nombre Ventas")
    End Sub

    Private Sub TxtNombreVentas_Leave(sender As Object, e As EventArgs) Handles TxtNombreVentas.Leave
        SetPlaceholderOnLeave(TxtNombreVentas, "Nombre Ventas")
    End Sub
    Private Sub TxtFechaVentas_Enter(sender As Object, e As EventArgs) Handles TxtFechaVentas.Enter
        ClearPlaceholder(TxtFechaVentas, "Fecha Ventas")
    End Sub

    Private Sub TxtFechaVentas_Leave(sender As Object, e As EventArgs) Handles TxtFechaVentas.Leave
        SetPlaceholderOnLeave(TxtFechaVentas, "Fecha Ventas")
    End Sub

    Private Sub txtNumeroReciboVentas_Enter(sender As Object, e As EventArgs) Handles txtNumeroReciboVentas.Enter
        ClearPlaceholder(txtNumeroReciboVentas, "Número Recibo Ventas")
    End Sub

    Private Sub txtNumeroReciboVentas_Leave(sender As Object, e As EventArgs) Handles txtNumeroReciboVentas.Leave
        SetPlaceholderOnLeave(txtNumeroReciboVentas, "Número Recibo Ventas")
    End Sub

    Private Sub TxtTipoDePagoVentas_Enter(sender As Object, e As EventArgs) Handles TxtTipoDePagoVentas.Enter
        ClearPlaceholder(TxtTipoDePagoVentas, "Tipo de Pago Ventas")
    End Sub

    Private Sub TxtTipoDePagoVentas_Leave(sender As Object, e As EventArgs) Handles TxtTipoDePagoVentas.Leave
        SetPlaceholderOnLeave(TxtTipoDePagoVentas, "Tipo de Pago Ventas")
    End Sub

    Private Sub TxtIdEmpleado_Enter(sender As Object, e As EventArgs) Handles TxtIdEmpleado.Enter
        ClearPlaceholder(TxtIdEmpleado, "ID Empleado")
    End Sub

    Private Sub TxtIdEmpleado_Leave(sender As Object, e As EventArgs) Handles TxtIdEmpleado.Leave
        SetPlaceholderOnLeave(TxtIdEmpleado, "ID Empleado")
    End Sub

    Private Sub txtPrecioPorPago_Enter(sender As Object, e As EventArgs) Handles txtPrecioPorPago.Enter
        ClearPlaceholder(txtPrecioPorPago, "Precio por Pago")
    End Sub

    Private Sub txtPrecioPorPago_Leave(sender As Object, e As EventArgs) Handles txtPrecioPorPago.Leave
        SetPlaceholderOnLeave(txtPrecioPorPago, "Precio por Pago")
    End Sub

    Private Sub TxtTotal_Enter(sender As Object, e As EventArgs) Handles TxtTotal.Enter
        ClearPlaceholder(TxtTotal, "Total")
    End Sub

    Private Sub TxtTotal_Leave(sender As Object, e As EventArgs) Handles TxtTotal.Leave
        SetPlaceholderOnLeave(TxtTotal, "Total")
    End Sub

#End Region

#Region "Articulo"

    Private Sub Form1_Load_Articulo(sender As Object, e As EventArgs) Handles MyBase.Load

        SetPlaceholderOnLeave(TxtIdCodigoArticulo, "ID Código Artículo")
        SetPlaceholderOnLeave(TxtNombreArticulo, "Nombre Artículo")
        SetPlaceholderOnLeave(TxtProveedorArticulo, "Proveedor Artículo")
        SetPlaceholderOnLeave(TxtCategoriaArticulos, "Categoría Artículos")
        SetPlaceholderOnLeave(TxtPrecioArticulos, "Precio Artículos")
        SetPlaceholderOnLeave(txtEstadosArticulo, "Estados Artículo")
    End Sub

    Private Sub TxtIdCodigoArticulo_Enter(sender As Object, e As EventArgs) Handles TxtIdCodigoArticulo.Enter
        ClearPlaceholder(TxtIdCodigoArticulo, "ID Código Artículo")
    End Sub

    Private Sub TxtIdCodigoArticulo_Leave(sender As Object, e As EventArgs) Handles TxtIdCodigoArticulo.Leave
        SetPlaceholderOnLeave(TxtIdCodigoArticulo, "ID Código Artículo")
    End Sub

    Private Sub TxtNombreArticulo_Enter(sender As Object, e As EventArgs) Handles TxtNombreArticulo.Enter
        ClearPlaceholder(TxtNombreArticulo, "Nombre Artículo")
    End Sub

    Private Sub TxtNombreArticulo_Leave(sender As Object, e As EventArgs) Handles TxtNombreArticulo.Leave
        SetPlaceholderOnLeave(TxtNombreArticulo, "Nombre Artículo")
    End Sub

    Private Sub TxtProveedorArticulo_Enter(sender As Object, e As EventArgs) Handles TxtProveedorArticulo.Enter
        ClearPlaceholder(TxtProveedorArticulo, "Proveedor Artículo")
    End Sub

    Private Sub TxtProveedorArticulo_Leave(sender As Object, e As EventArgs) Handles TxtProveedorArticulo.Leave
        SetPlaceholderOnLeave(TxtProveedorArticulo, "Proveedor Artículo")
    End Sub

    Private Sub TxtCategoriaArticulos_Enter(sender As Object, e As EventArgs) Handles TxtCategoriaArticulos.Enter
        ClearPlaceholder(TxtCategoriaArticulos, "Categoría Artículos")
    End Sub

    Private Sub TxtCategoriaArticulos_Leave(sender As Object, e As EventArgs) Handles TxtCategoriaArticulos.Leave
        SetPlaceholderOnLeave(TxtCategoriaArticulos, "Categoría Artículos")
    End Sub

    Private Sub TxtPrecioArticulos_Enter(sender As Object, e As EventArgs) Handles TxtPrecioArticulos.Enter
        ClearPlaceholder(TxtPrecioArticulos, "Precio Artículos")
    End Sub

    Private Sub TxtPrecioArticulos_Leave(sender As Object, e As EventArgs) Handles TxtPrecioArticulos.Leave
        SetPlaceholderOnLeave(TxtPrecioArticulos, "Precio Artículos")
    End Sub

    Private Sub txtEstadosArticulo_Enter(sender As Object, e As EventArgs) Handles txtEstadosArticulo.Enter
        ClearPlaceholder(txtEstadosArticulo, "Estados Artículo")
    End Sub

    Private Sub txtEstadosArticulo_Leave(sender As Object, e As EventArgs) Handles txtEstadosArticulo.Leave
        SetPlaceholderOnLeave(txtEstadosArticulo, "Estados Artículo")
    End Sub

#End Region

#Region "Facturacion"

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetPlaceholder(TxtIdFacturacion, "ID Facturación")
        SetPlaceholder(TtxNombreFacturacion, "Nombre Facturación")
        SetPlaceholder(TxtFechaFacturacion, "Fecha Facturación")
        SetPlaceholder(TxtTipoDePagoFacturacion, "Tipo de Pago Facturación")
        SetPlaceholder(TxtIdEmpleadoFacturacion, "ID Empleado Facturación")
        SetPlaceholder(TxtIdArticulo, "ID Artículo")
        SetPlaceholder(TxtNombreArticuloFacturacion, "Nombre Artículo Facturación")
        SetPlaceholder(TxtCantidad, "Cantidad")
        SetPlaceholder(TxtPrecioUnitarioFacturacion, "Precio Unitario Facturación")
        SetPlaceholder(TxtDescuentoFacturacion, "Descuento Facturación")
        SetPlaceholder(TxtNumeroFactura, "Número de Factura")


    End Sub

    Private Sub TxtIdFacturacion_Enter(sender As Object, e As EventArgs) Handles TxtIdFacturacion.Enter
        ClearPlaceholder(TxtIdFacturacion, "ID Facturación")
    End Sub

    Private Sub TxtIdFacturacion_Leave(sender As Object, e As EventArgs) Handles TxtIdFacturacion.Leave
        SetPlaceholderOnLeave(TxtIdFacturacion, "ID Facturación")
    End Sub

    Private Sub TtxNombreFacturacion_Enter(sender As Object, e As EventArgs) Handles TtxNombreFacturacion.Enter
        ClearPlaceholder(TtxNombreFacturacion, "Nombre Facturación")
    End Sub

    Private Sub TtxNombreFacturacion_Leave(sender As Object, e As EventArgs) Handles TtxNombreFacturacion.Leave
        SetPlaceholderOnLeave(TtxNombreFacturacion, "Nombre Facturación")
    End Sub

    Private Sub TxtFechaFacturacion_Enter(sender As Object, e As EventArgs) Handles TxtFechaFacturacion.Enter
        ClearPlaceholder(TxtFechaFacturacion, "Fecha Facturación")
    End Sub

    Private Sub TxtFechaFacturacion_Leave(sender As Object, e As EventArgs) Handles TxtFechaFacturacion.Leave
        SetPlaceholderOnLeave(TxtFechaFacturacion, "Fecha Facturación")
    End Sub

    Private Sub TxtTipoDePagoFacturacion_Enter(sender As Object, e As EventArgs) Handles TxtTipoDePagoFacturacion.Enter
        ClearPlaceholder(TxtTipoDePagoFacturacion, "Tipo de Pago Facturación")
    End Sub

    Private Sub TxtTipoDePagoFacturacion_Leave(sender As Object, e As EventArgs) Handles TxtTipoDePagoFacturacion.Leave
        SetPlaceholderOnLeave(TxtTipoDePagoFacturacion, "Tipo de Pago Facturación")
    End Sub

    Private Sub TxtIdEmpleadoFacturacion_Enter(sender As Object, e As EventArgs) Handles TxtIdEmpleadoFacturacion.Enter
        ClearPlaceholder(TxtIdEmpleadoFacturacion, "ID Empleado Facturación")
    End Sub

    Private Sub TxtIdEmpleadoFacturacion_Leave(sender As Object, e As EventArgs) Handles TxtIdEmpleadoFacturacion.Leave
        SetPlaceholderOnLeave(TxtIdEmpleadoFacturacion, "ID Empleado Facturación")
    End Sub

    Private Sub TxtIdArticulo_Enter(sender As Object, e As EventArgs) Handles TxtIdArticulo.Enter
        ClearPlaceholder(TxtIdArticulo, "ID Artículo")
    End Sub

    Private Sub TxtIdArticulo_Leave(sender As Object, e As EventArgs) Handles TxtIdArticulo.Leave
        SetPlaceholderOnLeave(TxtIdArticulo, "ID Artículo")
    End Sub

    Private Sub TxtNombreArticuloFacturacion_Enter(sender As Object, e As EventArgs) Handles TxtNombreArticuloFacturacion.Enter
        ClearPlaceholder(TxtNombreArticuloFacturacion, "Nombre Artículo Facturación")
    End Sub

    Private Sub TxtNombreArticuloFacturacion_Leave(sender As Object, e As EventArgs) Handles TxtNombreArticuloFacturacion.Leave
        SetPlaceholderOnLeave(TxtNombreArticuloFacturacion, "Nombre Artículo Facturación")
    End Sub

    Private Sub TxtCantidad_Enter(sender As Object, e As EventArgs) Handles TxtCantidad.Enter
        ClearPlaceholder(TxtCantidad, "Cantidad")
    End Sub

    Private Sub TxtCantidad_Leave(sender As Object, e As EventArgs) Handles TxtCantidad.Leave
        SetPlaceholderOnLeave(TxtCantidad, "Cantidad")
    End Sub

    Private Sub TxtPrecioUnitarioFacturacion_Enter(sender As Object, e As EventArgs) Handles TxtPrecioUnitarioFacturacion.Enter
        ClearPlaceholder(TxtPrecioUnitarioFacturacion, "Precio Unitario Facturación")
    End Sub

    Private Sub TxtPrecioUnitarioFacturacion_Leave(sender As Object, e As EventArgs) Handles TxtPrecioUnitarioFacturacion.Leave
        SetPlaceholderOnLeave(TxtPrecioUnitarioFacturacion, "Precio Unitario Facturación")
    End Sub

    Private Sub TxtDescuentoFacturacion_Enter(sender As Object, e As EventArgs) Handles TxtDescuentoFacturacion.Enter
        ClearPlaceholder(TxtDescuentoFacturacion, "Descuento Facturación")
    End Sub

    Private Sub TxtDescuentoFacturacion_Leave(sender As Object, e As EventArgs) Handles TxtDescuentoFacturacion.Leave
        SetPlaceholderOnLeave(TxtDescuentoFacturacion, "Descuento Facturación")
    End Sub

    Private Sub TxtNumeroFactura_Enter(sender As Object, e As EventArgs) Handles TxtNumeroFactura.Enter
        ClearPlaceholder(TxtNumeroFactura, "Número de Factura")
    End Sub

    Private Sub TxtNumeroFactura_Leave(sender As Object, e As EventArgs) Handles TxtNumeroFactura.Leave
        SetPlaceholderOnLeave(TxtNumeroFactura, "Número de Factura")
    End Sub


#End Region

#Region "Private Methods"
    Private Sub SetPlaceholder(txtBox As TextBox, placeholder As String)
        txtBox.Text = placeholder
        txtBox.ForeColor = ColorTranslator.FromHtml("#603F26")
    End Sub

    Private Sub ClearPlaceholder(txtBox As TextBox, placeholder As String)
        If txtBox.Text = placeholder Then
            txtBox.Text = ""
            txtBox.ForeColor = ColorTranslator.FromHtml("#603F26")
        End If
    End Sub

    Private Sub SetPlaceholderOnLeave(txtBox As TextBox, placeholder As String)
        If txtBox.Text = "" Then
            txtBox.Text = placeholder
            txtBox.ForeColor = ColorTranslator.FromHtml("#603F26")
        End If
    End Sub

#End Region

#End Region

End Class
