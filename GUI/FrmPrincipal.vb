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
        pnlInicio.Visible = True
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

    Private Sub btn2salir_Click(sender As Object, e As EventArgs)

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


    Private Sub txtCodigo_Enter(sender As Object, e As EventArgs)
        ClearPlaceholder(txtCodigo, "Codigo")
    End Sub

    Private Sub txtNombre_Enter(sender As Object, e As EventArgs)
        ClearPlaceholder(txtNombre, "Nombre")
    End Sub

    Private Sub txtSexo_Enter(sender As Object, e As EventArgs)
        ClearPlaceholder(txtSexo, "Sexo")
    End Sub

    Private Sub txtTelefono_Enter(sender As Object, e As EventArgs)
        ClearPlaceholder(txtTelefono, "Telefono")
    End Sub

    Private Sub txtDireccion_Enter(sender As Object, e As EventArgs)
        ClearPlaceholder(txtDireccion, "Direccion")
    End Sub

    Private Sub txtCedula_Enter(sender As Object, e As EventArgs)
        ClearPlaceholder(txtCedula, "Cedula")
    End Sub

    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs)
        SetPlaceholderOnLeave(txtCodigo, "Codigo")
    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs)
        SetPlaceholderOnLeave(txtNombre, "Nombre")
    End Sub

    Private Sub txtSexo_Leave(sender As Object, e As EventArgs)
        SetPlaceholderOnLeave(txtSexo, "Sexo")
    End Sub

    Private Sub txtTelefono_Leave(sender As Object, e As EventArgs)
        SetPlaceholderOnLeave(txtTelefono, "Telefono")
    End Sub

    Private Sub txtDireccion_Leave(sender As Object, e As EventArgs)
        SetPlaceholderOnLeave(txtDireccion, "Direccion")
    End Sub

    Private Sub txtCedula_Leave(sender As Object, e As EventArgs)
        SetPlaceholderOnLeave(txtCedula, "Cedula")
    End Sub

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

End Class
