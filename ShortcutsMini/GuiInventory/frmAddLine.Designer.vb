<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddLine
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
        Me.cmbSupplier = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblCompany = New System.Windows.Forms.Label
        Me.TbLine = New System.Windows.Forms.TextBox
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.CmbCompany = New System.Windows.Forms.ComboBox
        Me.LblLine = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LstwLine = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 485)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Line"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbSupplier)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LblCompany)
        Me.GroupBox3.Controls.Add(Me.TbLine)
        Me.GroupBox3.Controls.Add(Me.ChkActive)
        Me.GroupBox3.Controls.Add(Me.CmbCompany)
        Me.GroupBox3.Controls.Add(Me.LblLine)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(759, 110)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add New Line"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(29, 30)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(321, 21)
        Me.cmbSupplier.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Supplier"
        '
        'LblCompany
        '
        Me.LblCompany.AutoSize = True
        Me.LblCompany.Location = New System.Drawing.Point(406, 17)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.Size = New System.Drawing.Size(51, 13)
        Me.LblCompany.TabIndex = 7
        Me.LblCompany.Text = "Company"
        '
        'TbLine
        '
        Me.TbLine.Location = New System.Drawing.Point(29, 72)
        Me.TbLine.Name = "TbLine"
        Me.TbLine.Size = New System.Drawing.Size(321, 20)
        Me.TbLine.TabIndex = 0
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Location = New System.Drawing.Point(682, 72)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.Size = New System.Drawing.Size(56, 17)
        Me.ChkActive.TabIndex = 2
        Me.ChkActive.Text = "Active"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'CmbCompany
        '
        Me.CmbCompany.FormattingEnabled = True
        Me.CmbCompany.Location = New System.Drawing.Point(408, 30)
        Me.CmbCompany.Name = "CmbCompany"
        Me.CmbCompany.Size = New System.Drawing.Size(321, 21)
        Me.CmbCompany.TabIndex = 5
        '
        'LblLine
        '
        Me.LblLine.AutoSize = True
        Me.LblLine.Location = New System.Drawing.Point(25, 60)
        Me.LblLine.Name = "LblLine"
        Me.LblLine.Size = New System.Drawing.Size(58, 13)
        Me.LblLine.TabIndex = 4
        Me.LblLine.Text = "Line Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LstwLine)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(759, 344)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Line"
        '
        'LstwLine
        '
        Me.LstwLine.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader7, Me.ColumnHeader6, Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LstwLine.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LstwLine.FullRowSelect = True
        Me.LstwLine.GridLines = True
        Me.LstwLine.Location = New System.Drawing.Point(6, 19)
        Me.LstwLine.Name = "LstwLine"
        Me.LstwLine.Size = New System.Drawing.Size(747, 319)
        Me.LstwLine.TabIndex = 3
        Me.LstwLine.UseCompatibleStateImageBehavior = False
        Me.LstwLine.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "intCompanyId"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "intLineId"
        Me.ColumnHeader6.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No."
        Me.ColumnHeader1.Width = 51
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Supplier"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Company"
        Me.ColumnHeader4.Width = 209
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Line Name"
        Me.ColumnHeader2.Width = 184
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
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "intSupplierId"
        Me.ColumnHeader8.Width = 0
        '
        'frmAddLine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(830, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddLine"
        Me.Text = "frmAddLine"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCompany As System.Windows.Forms.Label
    Friend WithEvents CmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents LblLine As System.Windows.Forms.Label
    Friend WithEvents LstwLine As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents TbLine As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
End Class
