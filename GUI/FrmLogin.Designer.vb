<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.PContenedor = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BInicioSesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.imgEye = New System.Windows.Forms.PictureBox()
        Me.imgHidden = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PUser = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PContenedor.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PContenedor
        '
        Me.PContenedor.Controls.Add(Me.PictureBox5)
        Me.PContenedor.Controls.Add(Me.imgEye)
        Me.PContenedor.Controls.Add(Me.imgHidden)
        Me.PContenedor.Controls.Add(Me.PictureBox4)
        Me.PContenedor.Controls.Add(Me.Panel2)
        Me.PContenedor.Controls.Add(Me.BInicioSesion)
        Me.PContenedor.Controls.Add(Me.Panel1)
        Me.PContenedor.Controls.Add(Me.PictureBox3)
        Me.PContenedor.Controls.Add(Me.PUser)
        Me.PContenedor.Controls.Add(Me.Label1)
        Me.PContenedor.Controls.Add(Me.txtUserName)
        Me.PContenedor.Controls.Add(Me.PictureBox1)
        Me.PContenedor.Controls.Add(Me.txtPassword)
        resources.ApplyResources(Me.PContenedor, "PContenedor")
        Me.PContenedor.Name = "PContenedor"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'BInicioSesion
        '
        Me.BInicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.BInicioSesion, "BInicioSesion")
        Me.BInicioSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.BInicioSesion.Name = "BInicioSesion"
        Me.BInicioSesion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtUserName, "txtUserName")
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtUserName.Name = "txtUserName"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtPassword.Name = "txtPassword"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.GUI.My.Resources.Resources.receptionist_45
        resources.ApplyResources(Me.PictureBox5, "PictureBox5")
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.TabStop = False
        '
        'imgEye
        '
        Me.imgEye.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.imgEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgEye.Image = Global.GUI.My.Resources.Resources.eye
        resources.ApplyResources(Me.imgEye, "imgEye")
        Me.imgEye.Name = "imgEye"
        Me.imgEye.TabStop = False
        '
        'imgHidden
        '
        Me.imgHidden.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.imgHidden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgHidden.Image = Global.GUI.My.Resources.Resources.hidden
        resources.ApplyResources(Me.imgHidden, "imgHidden")
        Me.imgHidden.Name = "imgHidden"
        Me.imgHidden.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.GUI.My.Resources.Resources.new_moon
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GUI.My.Resources.Resources.lock
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PUser
        '
        Me.PUser.Image = Global.GUI.My.Resources.Resources.profile_user
        resources.ApplyResources(Me.PUser, "PUser")
        Me.PUser.Name = "PUser"
        Me.PUser.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GUI.My.Resources.Resources.wave__3___1__removebg1
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Controls.Add(Me.PContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.PContenedor.ResumeLayout(False)
        Me.PContenedor.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PContenedor As Panel
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BInicioSesion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PUser As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents imgEye As PictureBox
    Friend WithEvents imgHidden As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
