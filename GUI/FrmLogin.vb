Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Public Sub AbrirFrm(ByVal frmHijo As Form)
        If Me.PContenedor.Controls.Count > 0 Then
            Me.PContenedor.Controls.RemoveAt(0)
        End If
    End Sub


    Private Sub BInicioSesion_Click(sender As Object, e As EventArgs)

        Dim userName As String = "Admin"
        Dim password As String = "Papo"

        If txtUserName.Text = "Admin" And txtPassword.Text = "Papo" Then
            Me.Hide()
            Dim frm As New frmPrincipal
            frm.ShowDialog(Me)
        Else
            MessageBox.Show("Nombre de usuario o contraseña inválidos.")
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

        If txtUserName.Text = "Admin" And txtPassword.Text = "Muebles" Then
            Me.Hide()
            Dim frm As New frmPrincipal
            frm.ShowDialog(Me)
        Else
            MessageBox.Show("Nombre de usuario o contraseña inválidos.")
        End If
    End Sub
End Class