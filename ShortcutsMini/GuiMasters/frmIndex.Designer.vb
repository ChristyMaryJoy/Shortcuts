<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndex
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Ribbon1 = New System.Windows.Forms.Ribbon
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblLogout = New System.Windows.Forms.Label
        Me.lblMinimize = New System.Windows.Forms.Label
        Me.lblMonthYear = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblDay = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblUserName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lbllocation = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 447)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = Nothing
        '
        '
        '
        Me.Ribbon1.QuickAcessToolbar.AltKey = Nothing
        Me.Ribbon1.QuickAcessToolbar.Image = Nothing
        Me.Ribbon1.QuickAcessToolbar.Tag = Nothing
        Me.Ribbon1.QuickAcessToolbar.Text = Nothing
        Me.Ribbon1.QuickAcessToolbar.ToolTip = Nothing
        Me.Ribbon1.QuickAcessToolbar.ToolTipImage = Nothing
        Me.Ribbon1.QuickAcessToolbar.ToolTipTitle = Nothing
        Me.Ribbon1.Size = New System.Drawing.Size(814, 138)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.TabSpacing = 6
        Me.Ribbon1.Text = "Ribbon1"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblLogout)
        Me.Panel1.Controls.Add(Me.lblMinimize)
        Me.Panel1.Controls.Add(Me.lblMonthYear)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblDay)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 373)
        Me.Panel1.TabIndex = 2
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Location = New System.Drawing.Point(64, 295)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(40, 13)
        Me.lblLogout.TabIndex = 8
        Me.lblLogout.Text = "Logout"
        '
        'lblMinimize
        '
        Me.lblMinimize.AutoSize = True
        Me.lblMinimize.Location = New System.Drawing.Point(64, 267)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(47, 13)
        Me.lblMinimize.TabIndex = 7
        Me.lblMinimize.Text = "Minimize"
        '
        'lblMonthYear
        '
        Me.lblMonthYear.AutoSize = True
        Me.lblMonthYear.Location = New System.Drawing.Point(64, 211)
        Me.lblMonthYear.Name = "lblMonthYear"
        Me.lblMonthYear.Size = New System.Drawing.Size(39, 13)
        Me.lblMonthYear.TabIndex = 5
        Me.lblMonthYear.Text = "Label2"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 119)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(133, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(64, 185)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Label3"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(64, 157)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(39, 13)
        Me.lblDay.TabIndex = 4
        Me.lblDay.Text = "Label3"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblUserName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Lbllocation)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(159, 481)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(655, 30)
        Me.Panel2.TabIndex = 3
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(161, 9)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(39, 13)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Logged in as :"
        '
        'Lbllocation
        '
        Me.Lbllocation.AutoSize = True
        Me.Lbllocation.Location = New System.Drawing.Point(482, 9)
        Me.Lbllocation.Name = "Lbllocation"
        Me.Lbllocation.Size = New System.Drawing.Size(39, 13)
        Me.Lbllocation.TabIndex = 2
        Me.Lbllocation.Text = "Label3"
        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 511)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Ribbon1)
        Me.IsMdiContainer = True
        Me.Name = "frmIndex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIndex"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lbllocation As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblMonthYear As System.Windows.Forms.Label
    Friend WithEvents lblLogout As System.Windows.Forms.Label
    Friend WithEvents lblMinimize As System.Windows.Forms.Label
    Friend WithEvents Ribbon1 As System.Windows.Forms.Ribbon
End Class
