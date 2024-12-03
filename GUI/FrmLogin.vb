Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BLL
Imports CapaEntidades

Public Class FrmLogin
    Dim usuariobll As New UsuarioService()

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub AbrirFrm(ByVal frmHijo As Form)
        If Me.PContenedor.Controls.Count > 0 Then
            Me.PContenedor.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub BInicioSesion_Click_1(sender As Object, e As EventArgs) Handles BInicioSesion.Click
        ' Validar que los campos no estén vacíos
        Dim nombreusuario As String = txtUserName.Text
        Dim contrase As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(nombreusuario) Or String.IsNullOrWhiteSpace(contrase) Then
            MessageBox.Show("Por favor ingrese nombre de usuario y contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Intentar hacer login con el servicio de autenticación
            Dim usuario As Usuarios = usuariobll.login(nombreusuario, contrase)

            If usuario IsNot Nothing Then
                ' Guardar al usuario en la sesión
                SesionUsuario.UsuarioActual = usuario

                Me.Hide()
                Dim frm As New frmPrincipal()
                frm.ShowDialog()

                Me.Close()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

            MessageBox.Show("Ocurrió un error al intentar iniciar sesión: " & ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BInicioSesion_Click_1(sender, e) ' Llama al evento del botón cuando presionas Enter
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        ' Bloquea la tecla de espacio
        If e.KeyChar = ChrW(32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress
        ' Bloquea la tecla de espacio
        If e.KeyChar = ChrW(32) Then
            e.Handled = True
        End If

        ' Bloquear números 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub imgEye_Click(sender As Object, e As EventArgs) Handles imgEye.Click
        txtPassword.PasswordChar = Chr(0) ' Quita la máscara de la contraseña
        imgEye.Visible = False ' Oculta el "ojo abierto"
        imgHidden.Visible = True
    End Sub


    Private Sub imgHidden_Click_1(sender As Object, e As EventArgs) Handles imgHidden.Click
        txtPassword.PasswordChar = "*"c ' Aplica la máscara de la contraseña
        imgHidden.Visible = False ' Oculta el "ojo cerrado"
        imgEye.Visible = True
    End Sub
End Class