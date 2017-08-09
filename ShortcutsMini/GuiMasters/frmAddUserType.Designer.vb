<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUserType
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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblUserType = New System.Windows.Forms.Label
        Me.LstwUserType = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ChkUserType = New System.Windows.Forms.CheckBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TbUserType = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblUserType)
        Me.GroupBox1.Controls.Add(Me.LstwUserType)
        Me.GroupBox1.Controls.Add(Me.ChkUserType)
        Me.GroupBox1.Controls.Add(Me.BtnAdd)
        Me.GroupBox1.Controls.Add(Me.TbUserType)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 396)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UserGroup"
        '
        'LblUserType
        '
        Me.LblUserType.AutoSize = True
        Me.LblUserType.Location = New System.Drawing.Point(20, 36)
        Me.LblUserType.Name = "LblUserType"
        Me.LblUserType.Size = New System.Drawing.Size(61, 13)
        Me.LblUserType.TabIndex = 4
        Me.LblUserType.Text = "User Group"
        '
        'LstwUserType
        '
        Me.LstwUserType.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LstwUserType.FullRowSelect = True
        Me.LstwUserType.GridLines = True
        Me.LstwUserType.Location = New System.Drawing.Point(17, 124)
        Me.LstwUserType.Name = "LstwUserType"
        Me.LstwUserType.Size = New System.Drawing.Size(347, 251)
        Me.LstwUserType.TabIndex = 3
        Me.LstwUserType.UseCompatibleStateImageBehavior = False
        Me.LstwUserType.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Group"
        Me.ColumnHeader2.Width = 202
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 125
        '
        'ChkUserType
        '
        Me.ChkUserType.AutoSize = True
        Me.ChkUserType.Location = New System.Drawing.Point(23, 85)
        Me.ChkUserType.Name = "ChkUserType"
        Me.ChkUserType.Size = New System.Drawing.Size(56, 17)
        Me.ChkUserType.TabIndex = 2
        Me.ChkUserType.Text = "Active"
        Me.ChkUserType.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(289, 85)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 33)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TbUserType
        '
        Me.TbUserType.Location = New System.Drawing.Point(23, 50)
        Me.TbUserType.Name = "TbUserType"
        Me.TbUserType.Size = New System.Drawing.Size(341, 20)
        Me.TbUserType.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'frmAddUserType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddUserType"
        Me.Text = "frmAddUserType"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblUserType As System.Windows.Forms.Label
    Friend WithEvents LstwUserType As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkUserType As System.Windows.Forms.CheckBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TbUserType As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
