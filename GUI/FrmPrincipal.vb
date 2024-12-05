Imports BLL
Imports CapaEntidades

Public Class frmPrincipal

    Private _bll As New ClienteService()
    Private _bllProducto As New ProductoService()
    Private _bllCiudad As New CiudadService()
    Private _bllCategoria As New CategoriaServices()
    Private _bllProveedor As New ProveedorService()
    Private _bllEmpleado As New EmpleadoService()
    Private _detallesList As New List(Of DetallerFactura)
    Private _facturaBll As New FacturaService()
    Private _inventarioService As New InventarioService()


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

#Region "Mostrar Panel Registro"
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

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        MostrarPanel(pnl2, pnlEmpleados)
    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        MostrarPanel(pnl2, pnlProveedor)
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        MostrarPanel(pnl2, pnlArticulos)
    End Sub

#End Region

#Region "Mostrar Panel Mantenimiento"

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btn5.Click
        MostrarPanel(pnl6, pnlFacturacion)
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

#End Region


    Private Sub MostrarPanel(panel1 As Panel, panel2 As Panel)
        Dim paneles As Panel() = {Pnl1, pnl2, pnl6, pnlInicio, pnlClientes, pnlArticulos, pnlFacturacion, pnlCiudad, pnlProveedor, pnlCategoria, pnlInventario, pnlEmpleados}

        For Each pnl In paneles
            pnl.Visible = False
        Next

        panel1.Visible = True
        panel2.Visible = True

        Me.Refresh()
    End Sub



#Region "Eventos de TextBox"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(900, 600)

        ' Configurar los TextBox de Clientes
        ConfigureTextBox(txtCodigo, "ID Cliente")
        ConfigureTextBox(txtNombre, "Nombre Cliente")
        ConfigureTextBox(txtTelefono, "Telefono Cliente")
        ConfigureTextBox(txtDireccion, "Direccion Cliente")
        ConfigureTextBox(txtCedula, "Cedula Cliente")

        ' Configurar los TextBox de articulos o productos
        ConfigureTextBox(TxtIdCodigoArticulo, "ID Articulo")
        ConfigureTextBox(TxtNombreArticulo, "Nombre Articulo")
        ConfigureTextBox(TxtProveedorArticulo, "ID Proveedor Articulo")
        ConfigureTextBox(TxtPrecioArticulos, "Precio Artículos")
        ConfigureTextBox(txtCantidadArticulo, "Cantidad Artículo")
        ConfigureTextBox(TxtCategoriaArticulos, "ID Categoría Artículos")



        ' Configurar los TextBox de facturacion
        ConfigureTextBox(TxtIdFacturacion, "ID Facturacion")
        ConfigureTextBox(TtxIdClienteFacturacion, "ID Cliente")
        ConfigureTextBox(TxtTipoDePagoFacturacion, "Tipo de Pago Facturacion")
        ConfigureTextBox(TxtIdEmpleadoFacturacion, "ID Empleado Facturacion")
        ConfigureTextBox(TxtIdArticulo, "ID Articulo")
        ConfigureTextBox(TxtCantidad, "Cantidad")
        ConfigureTextBox(TxtPrecioUnitarioFacturacion, "Precio Unitario Facturación")
        ConfigureTextBox(TxtDescuentoFacturacion, "Descuento Facturación")
        ConfigureTextBox(TxtNumeroFactura, "Numero de Factura")

        ' Configurar los TextBox de categoria
        ConfigureTextBox(txtIdCategoria, "ID Categoria")
        ConfigureTextBox(txtNombreCategoria, "Nombre Categoria")

        ' Configurar los TextBox de Inventario
        ConfigureTextBox(txtIdInventario, "ID Inventario")
        ConfigureTextBox(txtIdCategoriaInventario, "ID Categoria Inventario")
        ConfigureTextBox(txtCantidadInventario, "ID Cantidad Inventario")
        ConfigureTextBox(txtIdProductoInventario, "ID Producto Inventario")

        ' Configurar los TextBox de Ciudad
        ConfigureTextBox(txtIdCiudad, "ID Ciudad")
        ConfigureTextBox(txtNombreCiudad, "Nombre Ciudad")

        ' Configurar los TextBox de Proveedor
        ConfigureTextBox(txtIdProveedor, "ID Proveedor")
        ConfigureTextBox(txtNombreProveedor, "Nombre Proveedor")
        ConfigureTextBox(txtDireccionProveedor, "Proveedor Direccion")
        ConfigureTextBox(txtRnc, "RNC")
        ConfigureTextBox(txtTelefonoProveedor, "Telefono Proveedor")
        ConfigureTextBox(txtIdCiudadProveedor, "ID Ciudad Proveedor")

        ' Configurar los TextBox de Empleados
        ConfigureTextBox(txtIdEmpleados, "ID Empleado")
        ConfigureTextBox(txtNombreEmpleado, "Nombre Empleado")
        ConfigureTextBox(txtTelefonoEmpleado, "Telefono Empleado")
        ConfigureTextBox(txtDireccionEmpleado, "Direccion Empleado")
        ConfigureTextBox(txtCedulaEmpleado, "Cedula Empleado")

    End Sub

    Private Sub TextBox_Enter(sender As Object, e As EventArgs)
        Dim txtBox As TextBox = DirectCast(sender, TextBox)
        If txtBox.Text = CStr(txtBox.Tag) Then
            txtBox.Text = ""
            txtBox.ForeColor = ColorTranslator.FromHtml("#603F26")
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs)
        Dim txtBox As TextBox = DirectCast(sender, TextBox)
        If String.IsNullOrWhiteSpace(txtBox.Text) Then
            txtBox.Text = CStr(txtBox.Tag)
            txtBox.ForeColor = ColorTranslator.FromHtml("#603F26")
        End If
    End Sub

    Private Sub ConfigureTextBox(txtBox As TextBox, placeholder As String)
        ' Configura el TextBox con el marcador de posición y asigna los eventos
        txtBox.Tag = placeholder
        txtBox.Text = placeholder
        txtBox.ForeColor = ColorTranslator.FromHtml("#603F26")
        AddHandler txtBox.Enter, AddressOf TextBox_Enter
        AddHandler txtBox.Leave, AddressOf TextBox_Leave
    End Sub

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
            txt.Text = CStr(txt.Tag)
            txt.ForeColor = ColorTranslator.FromHtml("#603F26")
        Next
    End Sub


    Dim MantenimientoMenu As Boolean = False
    Dim RegistroMenu As Boolean = False

    Private Sub MantenimientoTimer_Tick(sender As Object, e As EventArgs) Handles MantenimientoTimer.Tick
        If Not MantenimientoMenu Then
            FlowLayoutContenedor.Height += 10
            If FlowLayoutContenedor.Height >= 210 Then
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
            LimpiarTextos(txtIdCiudad, txtNombreCiudad)

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
            LimpiarTextos(txtIdCategoria, txtNombreCategoria)
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
        LimpiarTextos(txtIdProveedor, txtNombreProveedor, txtDireccionProveedor, txtRnc, txtTelefono, txtIdCiudadProveedor)

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
        LimpiarTextos(txtIdProveedor, txtNombreProveedor, txtDireccionProveedor, txtRnc, txtTelefono, txtIdCiudadProveedor)
    End Sub


#End Region

#Region "Empleados"
    Private Sub btnAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        Try
            Dim empleado As New Empleados With {
            .Nombre = txtNombreEmpleado.Text,
            .Telefono = txtTelefonoEmpleado.Text,
            .Direccion = txtDireccionEmpleado.Text,
            .Cedula = txtCedulaEmpleado.Text
            }
            _bllEmpleado.InsertarEmpleadoService(empleado)

            dtEmpleado.DataSource = _bllEmpleado.ObtenerEmpleadoService()
            LimpiarTextos(txtIdEmpleados, txtNombreEmpleado, txtDireccionEmpleado, txtTelefonoEmpleado, txtCedulaEmpleado)
        Catch ex As Exception
            MessageBox.Show("Los campos no pueden estar vacios")
        End Try

    End Sub


    Private Sub btnObtenerEmpleado_Click(sender As Object, e As EventArgs) Handles btnObtenerEmpleado.Click
        _bllEmpleado.ObtenerEmpleadoService()
        dtEmpleado.DataSource = _bllEmpleado.ObtenerEmpleadoService()

    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        Try

            Dim id As Integer = CInt(txtIdEmpleados.Text)
            _bllEmpleado.EliminarEmpleadoService(id)
            dtEmpleado.DataSource = _bllEmpleado.ObtenerEmpleadoService()
            LimpiarTextos(txtIdEmpleados)

        Catch Ex As Exception
            MessageBox.Show("Debe de llenar el campo Id")
        End Try
    End Sub

    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        Try
            Dim empleado As New Empleados With {
        .IdEmpleado = txtIdEmpleados.Text,
        .Nombre = txtNombreEmpleado.Text,
        .Telefono = txtTelefonoEmpleado.Text,
        .Direccion = txtDireccionEmpleado.Text,
        .Cedula = txtCedulaEmpleado.Text
        }

            _bllEmpleado.ActualizarEmpleadoService(empleado)
            dtEmpleado.DataSource = _bllEmpleado.ObtenerEmpleadoService()
            LimpiarTextos(txtIdEmpleados, txtNombreEmpleado, txtDireccionEmpleado, txtTelefonoEmpleado, txtCedulaEmpleado)

        Catch ex As Exception
            MessageBox.Show("Los campos no pueden estar vacios")
        End Try

    End Sub

#End Region

#Region "Facturacion"
    Private Sub BtnFacturar_Click(sender As Object, e As EventArgs) Handles BtnFacturar.Click

        Dim id As Integer = Convert.ToInt32(TxtIdArticulo.Text)
        Dim cantidad As Integer = Convert.ToInt32(TxtCantidad.Text)
        Dim precio As Decimal = Convert.ToDecimal(TxtPrecioUnitarioFacturacion.Text)
        Dim descuento As Decimal = Convert.ToDecimal(TxtDescuentoFacturacion.Text)

        Dim detalle As New DetallerFactura() With
        {
            .IdProducto = id,
            .Cantidad = cantidad,
            .Precio = precio,
            .PrecioTotal = cantidad * precio,
            .Descuento = descuento
        }

        _detallesList.Add(detalle)
        dtFacturacion.DataSource = Nothing
        dtFacturacion.DataSource = _detallesList

        Dim fact As New Factura() With {
            .IdFactura = Integer.Parse(TxtIdFacturacion.Text),
            .IdCliente = Integer.Parse(TtxIdClienteFacturacion.Text),
            .TipoDePago = TxtTipoDePagoFacturacion.Text,
            .Fecha = DateTime.Now,
            .IdEmpleado = Integer.Parse(TxtIdEmpleadoFacturacion.Text),
            .Total = _detallesList.Sum(Function(d) d.PrecioTotal)
        }

        _facturaBll.CrearFactura(fact, _detallesList)
        LimpiarTextos(TxtIdFacturacion, TtxIdClienteFacturacion, TxtTipoDePagoFacturacion, TxtIdEmpleadoFacturacion)


    End Sub
#End Region

    Private Sub btnAgregarInventario_Click(sender As Object, e As EventArgs) Handles btnAgregarInventario.Click

        Dim producto As New Inventario With {
            .IdInventario = txtIdInventario.Text,
            .Cantidad = txtCantidadInventario.Text,
            .IdCategoria = txtIdCategoriaInventario.Text,
            .IdProducto = txtIdProductoInventario.Text
        }

        _inventarioService.InsertarProductoInventario(producto)
        DtInventario.DataSource = _inventarioService.ObtenerProducto()

    End Sub

    Private Sub btnObtenerInventario_Click(sender As Object, e As EventArgs) Handles btnObtenerInventario.Click

    End Sub
End Class
