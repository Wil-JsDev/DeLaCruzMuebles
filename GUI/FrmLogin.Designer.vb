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
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LExit = New System.Windows.Forms.Label()
        Me.Limpiar = New System.Windows.Forms.Label()
        Me.BInicioSesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PUser = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PContenedor.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PContenedor
        '
        Me.PContenedor.Controls.Add(Me.txtPassword)
        Me.PContenedor.Controls.Add(Me.txtUserName)
        Me.PContenedor.Controls.Add(Me.Panel2)
        Me.PContenedor.Controls.Add(Me.LExit)
        Me.PContenedor.Controls.Add(Me.Limpiar)
        Me.PContenedor.Controls.Add(Me.BInicioSesion)
        Me.PContenedor.Controls.Add(Me.Panel1)
        Me.PContenedor.Controls.Add(Me.PictureBox3)
        Me.PContenedor.Controls.Add(Me.PUser)
        Me.PContenedor.Controls.Add(Me.PictureBox1)
        Me.PContenedor.Controls.Add(Me.PictureBox4)
        Me.PContenedor.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.PContenedor, "PContenedor")
        Me.PContenedor.Name = "PContenedor"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtPassword.Name = "txtPassword"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtUserName, "txtUserName")
        Me.txtUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.txtUserName.Name = "txtUserName"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'LExit
        '
        resources.ApplyResources(Me.LExit, "LExit")
        Me.LExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.LExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.LExit.Name = "LExit"
        '
        'Limpiar
        '
        resources.ApplyResources(Me.Limpiar, "Limpiar")
        Me.Limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Limpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Limpiar.Name = "Limpiar"
        '
        'BInicioSesion
        '
        Me.BInicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
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
        'PictureBox3
        '
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PUser
        '
        resources.ApplyResources(Me.PUser, "PUser")
        Me.PUser.Name = "PUser"
        Me.PUser.TabStop = False
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GUI.My.Resources.Resources.usuario__1_
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label1.Name = "Label1"
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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PContenedor As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LExit As Label
    Friend WithEvents Limpiar As Label
    Friend WithEvents BInicioSesion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PUser As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
End Class
