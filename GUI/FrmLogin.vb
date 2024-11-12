Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub AbrirFrm(ByVal frmHijo As Form)
        If Me.PContenedor.Controls.Count > 0 Then
            Me.PContenedor.Controls.RemoveAt(0)
        End If
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        txtUserName.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub LExit_Click(sender As Object, e As EventArgs) Handles LExit.Click
        Application.Exit()
    End Sub

    Private Sub BInicioSesion_Click_1(sender As Object, e As EventArgs) Handles BInicioSesion.Click
        Dim userName As String = "Admin"
        Dim password As String = "Muebles"


        If txtUserName.Text = userName AndAlso txtPassword.Text = password Then
            Dim frm As New frmPrincipal
            Me.Hide()
            frm.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Nombre de usuario o contraseña inválidos.")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
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

End Class