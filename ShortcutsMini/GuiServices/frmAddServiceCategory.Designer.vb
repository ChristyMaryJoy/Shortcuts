<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddServiceCategory
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
        Me.LblCompany = New System.Windows.Forms.Label
        Me.LstwCategory = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.TbCategory = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblCompany)
        Me.GroupBox1.Controls.Add(Me.LstwCategory)
        Me.GroupBox1.Controls.Add(Me.ChkActive)
        Me.GroupBox1.Controls.Add(Me.TbCategory)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(382, 421)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Service Category"
        '
        'LblCompany
        '
        Me.LblCompany.AutoSize = True
        Me.LblCompany.Location = New System.Drawing.Point(20, 36)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.Size = New System.Drawing.Size(80, 13)
        Me.LblCompany.TabIndex = 4
        Me.LblCompany.Text = "Category Name"
        '
        'LstwCategory
        '
        Me.LstwCategory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LstwCategory.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LstwCategory.FullRowSelect = True
        Me.LstwCategory.GridLines = True
        Me.LstwCategory.Location = New System.Drawing.Point(17, 124)
        Me.LstwCategory.Name = "LstwCategory"
        Me.LstwCategory.Size = New System.Drawing.Size(347, 291)
        Me.LstwCategory.TabIndex = 3
        Me.LstwCategory.UseCompatibleStateImageBehavior = False
        Me.LstwCategory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CategoryId"
        Me.ColumnHeader4.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Category Name"
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
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(95, 26)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Location = New System.Drawing.Point(23, 85)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.Size = New System.Drawing.Size(56, 17)
        Me.ChkActive.TabIndex = 2
        Me.ChkActive.Text = "Active"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'TbCategory
        '
        Me.TbCategory.Location = New System.Drawing.Point(23, 50)
        Me.TbCategory.Name = "TbCategory"
        Me.TbCategory.Size = New System.Drawing.Size(321, 20)
        Me.TbCategory.TabIndex = 0
        '
        'frmAddServiceCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(502, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddServiceCategory"
        Me.Text = "frmAddServiceCategory"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCompany As System.Windows.Forms.Label
    Friend WithEvents LstwCategory As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents TbCategory As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
