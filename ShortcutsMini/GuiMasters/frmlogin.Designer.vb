<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
    Inherits KOSLibraries.KOSForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmblocation = New System.Windows.Forms.ComboBox
        Me.TbUserName = New System.Windows.Forms.TextBox
        Me.BtnLogin = New System.Windows.Forms.Button
        Me.PicbLogin = New System.Windows.Forms.PictureBox
        Me.TbPassword = New System.Windows.Forms.TextBox
        Me.LblLocation = New System.Windows.Forms.Label
        Me.LblPassword = New System.Windows.Forms.Label
        Me.LblUsername = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicbLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = Nothing
        Me.GroupBox2.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackgroundImage = Nothing
        Me.GroupBox2.Controls.Add(Me.Cmblocation)
        Me.GroupBox2.Controls.Add(Me.TbUserName)
        Me.GroupBox2.Controls.Add(Me.BtnLogin)
        Me.GroupBox2.Controls.Add(Me.PicbLogin)
        Me.GroupBox2.Controls.Add(Me.TbPassword)
        Me.GroupBox2.Controls.Add(Me.LblLocation)
        Me.GroupBox2.Controls.Add(Me.LblPassword)
        Me.GroupBox2.Controls.Add(Me.LblUsername)
        Me.GroupBox2.Font = Nothing
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Cmblocation
        '
        Me.Cmblocation.AccessibleDescription = Nothing
        Me.Cmblocation.AccessibleName = Nothing
        resources.ApplyResources(Me.Cmblocation, "Cmblocation")
        Me.Cmblocation.BackgroundImage = Nothing
        Me.Cmblocation.Font = Nothing
        Me.Cmblocation.FormattingEnabled = True
        Me.Cmblocation.Name = "Cmblocation"
        '
        'TbUserName
        '
        Me.TbUserName.AccessibleDescription = Nothing
        Me.TbUserName.AccessibleName = Nothing
        resources.ApplyResources(Me.TbUserName, "TbUserName")
        Me.TbUserName.BackgroundImage = Nothing
        Me.TbUserName.Font = Nothing
        Me.TbUserName.Name = "TbUserName"
        '
        'BtnLogin
        '
        Me.BtnLogin.AccessibleDescription = Nothing
        Me.BtnLogin.AccessibleName = Nothing
        resources.ApplyResources(Me.BtnLogin, "BtnLogin")
        Me.BtnLogin.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnLogin.BackgroundImage = Nothing
        Me.BtnLogin.Font = Nothing
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'PicbLogin
        '
        Me.PicbLogin.AccessibleDescription = Nothing
        Me.PicbLogin.AccessibleName = Nothing
        resources.ApplyResources(Me.PicbLogin, "PicbLogin")
        Me.PicbLogin.BackgroundImage = Nothing
        Me.PicbLogin.Font = Nothing
        Me.PicbLogin.ImageLocation = Nothing
        Me.PicbLogin.InitialImage = Nothing
        Me.PicbLogin.Name = "PicbLogin"
        Me.PicbLogin.TabStop = False
        '
        'TbPassword
        '
        Me.TbPassword.AccessibleDescription = Nothing
        Me.TbPassword.AccessibleName = Nothing
        resources.ApplyResources(Me.TbPassword, "TbPassword")
        Me.TbPassword.BackgroundImage = Nothing
        Me.TbPassword.Font = Nothing
        Me.TbPassword.Name = "TbPassword"
        '
        'LblLocation
        '
        Me.LblLocation.AccessibleDescription = Nothing
        Me.LblLocation.AccessibleName = Nothing
        resources.ApplyResources(Me.LblLocation, "LblLocation")
        Me.LblLocation.Font = Nothing
        Me.LblLocation.Name = "LblLocation"
        '
        'LblPassword
        '
        Me.LblPassword.AccessibleDescription = Nothing
        Me.LblPassword.AccessibleName = Nothing
        resources.ApplyResources(Me.LblPassword, "LblPassword")
        Me.LblPassword.Font = Nothing
        Me.LblPassword.Name = "LblPassword"
        '
        'LblUsername
        '
        Me.LblUsername.AccessibleDescription = Nothing
        Me.LblUsername.AccessibleName = Nothing
        resources.ApplyResources(Me.LblUsername, "LblUsername")
        Me.LblUsername.Font = Nothing
        Me.LblUsername.Name = "LblUsername"
        '
        'frmlogin
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "frmlogin"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicbLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents PicbLogin As System.Windows.Forms.PictureBox
    Friend WithEvents TbPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblLocation As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents LblUsername As System.Windows.Forms.Label
    Friend WithEvents TbUserName As System.Windows.Forms.TextBox
    Friend WithEvents Cmblocation As System.Windows.Forms.ComboBox
End Class
