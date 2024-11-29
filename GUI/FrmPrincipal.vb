Imports BLL
Imports CapaEntidades

Public Class frmPrincipal
    Private _bll As New ClienteService()
    Private _bllProducto As New ProductoService()
    Private _bllCiudad As New CiudadService()
    Private _bllCategoria As New CategoriaServices()
    Private _bllProveedor As New ProveedorService()


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
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
        MostrarPanel(Pnl1, pnlInicio)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        MostrarPanel(pnl6, pnlVentas)
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        MostrarPanel(pnl2, pnlArticulos)
    End Sub

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btn5.Click
        MostrarPanel(pnl6, pnlFacturacion)
    End Sub
    Private Sub btnRegistros_Click(sender As Object, e As EventArgs) Handles btnRegistros.Click
        RegistroTimer.Start()
        MostrarPanel(pnl2, pnlInicio)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        MostrarPanel(pnl2, pnlClientes)
    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        MostrarPanel(pnl2, pnlCiudad)

    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        MostrarPanel(pnl2, pnlProveedor)
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        MostrarPanel(pnl6, pnlCategoria)
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        MostrarPanel(pnl6, pnlInventario)
    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
        MantenimientoTimer.Start()
        MostrarPanel(pnl6, pnlInicio)
    End Sub

    Private Sub MostrarPanel(panel1 As Panel, panel2 As Panel)
        Dim paneles As Panel() = {Pnl1, pnl2, pnl6, pnlInicio, pnlClientes, pnlVentas, pnlArticulos, pnlFacturacion, pnlCiudad, pnlProveedor, pnlCategoria, pnlInventario}

        For Each pnl In paneles
            pnl.Visible = False
        Next

        panel1.Visible = True
        panel2.Visible = True

        Me.Refresh()
    End Sub



#Region "label Eventos"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetPlaceholder(txtCodigo, "Codigo")
        SetPlaceholder(txtNombre, "Nombre")
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

    Private Sub txtSexo_Enter(sender As Object, e As EventArgs)
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

    Private Sub txtSexo_Leave(sender As Object, e As EventArgs)
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
        SetPlaceholderOnLeave(txtCantidadArticulo, "Cantidad Artículo")
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

    Private Sub txtEstadosArticulo_Enter(sender As Object, e As EventArgs) Handles txtCantidadArticulo.Enter
        ClearPlaceholder(txtCantidadArticulo, "Cantidad Artículo")
    End Sub

    Private Sub txtEstadosArticulo_Leave(sender As Object, e As EventArgs) Handles txtCantidadArticulo.Leave
        SetPlaceholderOnLeave(txtCantidadArticulo, "Cantidad Artículo")
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

#Region "btn Registro"
    Private Sub BtnGuardarR_Click(sender As Object, e As EventArgs) Handles BtnGuardarR.Click

        Try
            Dim cliente As New Cliente With {
       .IdCliente = txtCodigo.Text,
       .Nombre = txtNombre.Text,
       .Telefono = txtTelefono.Text,
       .Direccion = txtDireccion.Text,
       .Cedula = txtCedula.Text
       }
            _bll.InsertarClienteService(cliente)
            dgvRegistro.DataSource = _bll.ObtenerClientesService()

            LimpiarTextos(txtCodigo, txtNombre, txtTelefono, txtDireccion, txtCedula)
        Catch ex As Exception
            MessageBox.Show("Los campos no se pueden quedar vacios")
        End Try


    End Sub



    Private Sub BtnGuardarRegistro_Click(sender As Object, e As EventArgs) Handles BtnModificarRegistro.Click 'Actualizar'

        Try
            Dim cliente As New Cliente With {
        .IdCliente = txtCodigo.Text,
        .Nombre = txtNombre.Text,
        .Telefono = txtTelefono.Text,
        .Direccion = txtDireccion.Text,
        .Cedula = txtCedula.Text
        }
            _bll.ActualizarClienteService(cliente)
            dgvRegistro.DataSource = _bll.ObtenerClientesService()
            LimpiarTextos(txtCodigo, txtNombre, txtTelefono, txtDireccion, txtCedula)

        Catch ex As Exception
            MessageBox.Show("Los campos no pueden estar vacios")
        End Try
    End Sub

    Private Sub BtnEliminarRegistro_Click(sender As Object, e As EventArgs) Handles BtnEliminarRegistro.Click
        Try
            Dim id As Integer = CInt(txtCodigo.Text)
            _bll.EliminarClienteService(id)
            dgvRegistro.DataSource = _bll.ObtenerClientesService()
        Catch Ex As Exception
            MessageBox.Show("El campo Id es obligatorio")
        End Try
    End Sub

    Private Sub pnlRegistro_Paint(sender As Object, e As PaintEventArgs) Handles pnlClientes.Paint

    End Sub

    Private Sub BtnNuevoRegistro_Click(sender As Object, e As EventArgs) Handles BtnObtenerRegistro.Click
        _bll.ObtenerClientesService()
        dgvRegistro.DataSource = _bll.ObtenerClientesService()
    End Sub

    ''Private Sub pnlRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ''dgvRegistro.DataSource = _bll.ObtenerClientesService()''
    ''End Sub''
#End Region

#Region "Articulos"
    Private Sub BtnGuardarArticulos_Click(sender As Object, e As EventArgs) Handles BtnGuardarArticulos.Click
        Try
            Dim producto As New Producto With {
        .IdProducto = TxtIdCodigoArticulo.Text,
        .NombreProducto = TxtNombreArticulo.Text,
        .IdProveedor = TxtProveedorArticulo.Text,
        .IdCategoria = TxtCategoriaArticulos.Text,
        .Precio = TxtPrecioArticulos.Text,
        .Cantidad = txtCantidadArticulo.Text
        }
            _bllProducto.InsertarProductoService(producto)
            dgvArticulos.DataSource = _bllProducto.ObtenerProductoService()
            LimpiarTextos(TxtIdCodigoArticulo, TxtNombreArticulo, TxtProveedorArticulo, TxtCategoriaArticulos, TxtPrecioArticulos, txtCantidadArticulo)
        Catch ex As Exception
            MessageBox.Show("Los campos no pueden estar vacios")
        End Try
    End Sub

    Private Sub BtnModificarArticulo_Click(sender As Object, e As EventArgs) Handles BtnModificarArticulo.Click
        Try
            Dim producto As New Producto With {
        .IdProducto = TxtIdCodigoArticulo.Text,
        .NombreProducto = TxtNombreArticulo.Text,
        .IdProveedor = TxtProveedorArticulo.Text,
        .IdCategoria = TxtCategoriaArticulos.Text,
        .Precio = TxtPrecioArticulos.Text,
        .Cantidad = txtCantidadArticulo.Text
        }

            _bllProducto.ActualizarProductoService(producto)
            dgvArticulos.DataSource = _bllProducto.ObtenerProductoService()
            LimpiarTextos(TxtIdCodigoArticulo, TxtNombreArticulo, TxtProveedorArticulo, TxtCategoriaArticulos, TxtPrecioArticulos, txtCantidadArticulo)
        Catch ex As Exception
            MessageBox.Show("Los campos no pueden estar vacios")
        End Try
    End Sub

    Private Sub BtnEliminarArticulo_Click(sender As Object, e As EventArgs) Handles BtnEliminarArticulo.Click
        Try
            Dim id As Integer = CInt(TxtIdCodigoArticulo.Text)
            _bllProducto.EliminarProductoService(id)
            dgvArticulos.DataSource = _bllProducto.ObtenerProductoService()
            LimpiarTextos(TxtIdCodigoArticulo, TxtNombreArticulo, TxtProveedorArticulo, TxtCategoriaArticulos, TxtPrecioArticulos, txtCantidadArticulo)
        Catch Ex As Exception
            MessageBox.Show("Debe de llenar el campo Id")
        End Try
    End Sub

    Private Sub BtnObtenerArticulos_Click(sender As Object, e As EventArgs) Handles BtnObtenerArticulos.Click
        _bllProducto.ObtenerProductoService()
        dgvArticulos.DataSource = _bllProducto.ObtenerProductoService()
    End Sub

#End Region

#Region "Private Method"

    Private Sub LimpiarTextos(ParamArray textBoxes() As TextBox)
        For Each txt In textBoxes
            txt.Text = ""
        Next
    End Sub

    Dim MantenimientoMenu As Boolean = False
    Dim RegistroMenu As Boolean = False

    Private Sub MantenimientoTimer_Tick(sender As Object, e As EventArgs) Handles MantenimientoTimer.Tick
        If Not MantenimientoMenu Then
            FlowLayoutContenedor.Height += 10
            If FlowLayoutContenedor.Height >= 262 Then
                MantenimientoTimer.Stop()
                MantenimientoMenu = True
            End If
        Else
            FlowLayoutContenedor.Height -= 10
            If FlowLayoutContenedor.Height <= 56 Then
                MantenimientoTimer.Stop()
                MantenimientoMenu = False
            End If
        End If

        FlowLayoutContenedor2.Top = FlowLayoutContenedor.Bottom + 10
    End Sub

    Private Sub RegistroTimer_Tick(sender As Object, e As EventArgs) Handles RegistroTimer.Tick
        If Not RegistroMenu Then
            FlowLayoutContenedor2.Height += 10
            If FlowLayoutContenedor2.Height >= 318 Then
                RegistroTimer.Stop()
                RegistroMenu = True
            End If
        Else
            FlowLayoutContenedor2.Height -= 10
            If FlowLayoutContenedor2.Height <= 56 Then
                RegistroTimer.Stop()
                RegistroMenu = False
            End If
        End If
    End Sub



#End Region

#Region "Ciudad"
    Private Sub btnAgregarCiudad_Click(sender As Object, e As EventArgs) Handles btnAgregarCiudad.Click

        Try
            Dim ciudad As New Ciudad With {
            .IdCiudad = txtIdCiudad.Text,
            .Nombre = txtNombreCiudad.Text
            }
            _bllCiudad.InsertarCiudadService(ciudad)
            dtCiudad.DataSource = _bllCiudad.ObtenerCiudadService()

        Catch Ex As Exception
            MessageBox.Show("Debe de llenar el campo Id")
        End Try
    End Sub

    Private Sub btnObtenerCiudad_Click(sender As Object, e As EventArgs) Handles btnObtenerCiudad.Click
        _bllCiudad.ObtenerCiudadService()
        dtCiudad.DataSource = _bllCiudad.ObtenerCiudadService()
    End Sub
#End Region

#Region "Categoria"
    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        Try
            Dim categoria As New Categoria With {
                .IdCategoria = txtIdCategoria.Text,
                .Nombre = txtNombreCategoria.Text
                }
            _bllCategoria.InsertarCategoriaService(categoria)
            dtCategoria.DataSource = _bllCategoria.ObtenerCategoriaService()
        Catch ex As Exception
            MessageBox.Show("No pueden estar vacios los campos")
        End Try


    End Sub

    Private Sub btnObtenerCategoria_Click(sender As Object, e As EventArgs) Handles btnObtenerCategoria.Click
        _bllCategoria.ObtenerCategoriaService()
        dtCategoria.DataSource = _bllCategoria.ObtenerCategoriaService()
    End Sub

#End Region

#Region "Proveedor"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFacturarProveedor.Click 'Facturar Proveedor'
        Dim proveedor As New Proveedor With {
                .IdProveedor = txtIdProveedor.Text,
                .Nombre = txtNombreProveedor.Text,
                .Direccion = txtDireccionProveedor.Text,
                .Rnc = txtRnc.Text,
                .Telefono = txtTelefonoProveedor.Text,
                .IdCiudad = txtIdCiudadProveedor.Text
                }
        _bllProveedor.InsertarProveedorService(proveedor)
        dtProveedor.DataSource = _bllProveedor.ObtenerProveedorService()

    End Sub

    Private Sub btnModificarProveedor_Click(sender As Object, e As EventArgs) Handles btnModificarProveedor.Click
        Dim proveedor As New Proveedor With {
                .IdProveedor = txtIdProveedor.Text,
                .Nombre = txtNombreProveedor.Text,
                .Direccion = txtDireccionProveedor.Text,
                .Rnc = txtRnc.Text,
                .Telefono = txtTelefonoProveedor.Text,
                .IdCiudad = txtIdCiudadProveedor.Text
                }
        _bllProveedor.ActualizarProveedorService(proveedor)
        dtProveedor.DataSource = _bllProveedor.ObtenerProveedorService()
    End Sub
#End Region
End Class
