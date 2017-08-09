<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSupplier
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
        Me.LblSupplier = New System.Windows.Forms.Label
        Me.TbSupplier = New System.Windows.Forms.TextBox
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LstwSupplier = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(822, 496)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblSupplier)
        Me.GroupBox3.Controls.Add(Me.TbSupplier)
        Me.GroupBox3.Controls.Add(Me.ChkActive)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(772, 68)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'LblSupplier
        '
        Me.LblSupplier.AutoSize = True
        Me.LblSupplier.Location = New System.Drawing.Point(6, 16)
        Me.LblSupplier.Name = "LblSupplier"
        Me.LblSupplier.Size = New System.Drawing.Size(76, 13)
        Me.LblSupplier.TabIndex = 4
        Me.LblSupplier.Text = "Supplier Name"
        '
        'TbSupplier
        '
        Me.TbSupplier.Location = New System.Drawing.Point(9, 32)
        Me.TbSupplier.Name = "TbSupplier"
        Me.TbSupplier.Size = New System.Drawing.Size(321, 20)
        Me.TbSupplier.TabIndex = 0
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Location = New System.Drawing.Point(354, 32)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.Size = New System.Drawing.Size(56, 17)
        Me.ChkActive.TabIndex = 2
        Me.ChkActive.Text = "Active"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LstwSupplier)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(772, 377)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saved Suppliers"
        '
        'LstwSupplier
        '
        Me.LstwSupplier.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LstwSupplier.FullRowSelect = True
        Me.LstwSupplier.GridLines = True
        Me.LstwSupplier.Location = New System.Drawing.Point(12, 19)
        Me.LstwSupplier.Name = "LstwSupplier"
        Me.LstwSupplier.Size = New System.Drawing.Size(748, 352)
        Me.LstwSupplier.TabIndex = 3
        Me.LstwSupplier.UseCompatibleStateImageBehavior = False
        Me.LstwSupplier.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Supplier Name"
        Me.ColumnHeader2.Width = 202
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
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'frmAddSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(830, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddSupplier"
        Me.Text = "frmAddSupplier"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LstwSupplier As System.Windows.Forms.ListView
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents TbSupplier As System.Windows.Forms.TextBox
    Friend WithEvents LblSupplier As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
