<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCompany
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LstwCompany = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbSupplier = New System.Windows.Forms.ComboBox
        Me.LblCompany = New System.Windows.Forms.Label
        Me.TbCompany = New System.Windows.Forms.TextBox
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 473)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Company"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LstwCompany)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 101)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(774, 350)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Company Lists"
        '
        'LstwCompany
        '
        Me.LstwCompany.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LstwCompany.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LstwCompany.FullRowSelect = True
        Me.LstwCompany.GridLines = True
        Me.LstwCompany.Location = New System.Drawing.Point(21, 19)
        Me.LstwCompany.Name = "LstwCompany"
        Me.LstwCompany.Size = New System.Drawing.Size(734, 315)
        Me.LstwCompany.TabIndex = 3
        Me.LstwCompany.UseCompatibleStateImageBehavior = False
        Me.LstwCompany.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "intCompanyId"
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No."
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Supplier"
        Me.ColumnHeader4.Width = 156
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Company Name"
        Me.ColumnHeader2.Width = 258
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 125
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbSupplier)
        Me.GroupBox2.Controls.Add(Me.LblCompany)
        Me.GroupBox2.Controls.Add(Me.TbCompany)
        Me.GroupBox2.Controls.Add(Me.ChkActive)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(774, 76)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Company"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Supplier"
        '
        'CmbSupplier
        '
        Me.CmbSupplier.FormattingEnabled = True
        Me.CmbSupplier.Location = New System.Drawing.Point(30, 41)
        Me.CmbSupplier.Name = "CmbSupplier"
        Me.CmbSupplier.Size = New System.Drawing.Size(249, 21)
        Me.CmbSupplier.TabIndex = 5
        '
        'LblCompany
        '
        Me.LblCompany.AutoSize = True
        Me.LblCompany.Location = New System.Drawing.Point(328, 29)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.Size = New System.Drawing.Size(82, 13)
        Me.LblCompany.TabIndex = 4
        Me.LblCompany.Text = "Company Name"
        '
        'TbCompany
        '
        Me.TbCompany.Location = New System.Drawing.Point(331, 43)
        Me.TbCompany.Name = "TbCompany"
        Me.TbCompany.Size = New System.Drawing.Size(321, 20)
        Me.TbCompany.TabIndex = 0
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Location = New System.Drawing.Point(699, 45)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.Size = New System.Drawing.Size(56, 17)
        Me.ChkActive.TabIndex = 2
        Me.ChkActive.Text = "Active"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "intSupplierId"
        Me.ColumnHeader6.Width = 0
        '
        'frmAddCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(830, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddCompany"
        Me.Text = "frmAddCompany"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCompany As System.Windows.Forms.Label
    Friend WithEvents LstwCompany As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents TbCompany As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
