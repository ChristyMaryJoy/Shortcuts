<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientSearch
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
        Me.LstwClientDetails = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ChkbSearchAll = New System.Windows.Forms.CheckBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.TbSearch = New System.Windows.Forms.TextBox
        Me.ChkbMobNo = New System.Windows.Forms.CheckBox
        Me.ChkbName = New System.Windows.Forms.CheckBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BookAnAppoinmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.POSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(818, 455)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Client"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LstwClientDetails)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(783, 315)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Details"
        '
        'LstwClientDetails
        '
        Me.LstwClientDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader6})
        Me.LstwClientDetails.FullRowSelect = True
        Me.LstwClientDetails.GridLines = True
        Me.LstwClientDetails.Location = New System.Drawing.Point(17, 36)
        Me.LstwClientDetails.Name = "LstwClientDetails"
        Me.LstwClientDetails.Size = New System.Drawing.Size(760, 290)
        Me.LstwClientDetails.TabIndex = 1
        Me.LstwClientDetails.UseCompatibleStateImageBehavior = False
        Me.LstwClientDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Client Name"
        Me.ColumnHeader2.Width = 135
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Mobile Number1"
        Me.ColumnHeader3.Width = 116
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 4
        Me.ColumnHeader4.Text = "Client Type"
        Me.ColumnHeader4.Width = 109
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 3
        Me.ColumnHeader5.Text = "Mobile Number2"
        Me.ColumnHeader5.Width = 103
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 6
        Me.ColumnHeader6.Text = "Last Visit"
        Me.ColumnHeader6.Width = 152
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkbSearchAll)
        Me.GroupBox2.Controls.Add(Me.BtnSearch)
        Me.GroupBox2.Controls.Add(Me.TbSearch)
        Me.GroupBox2.Controls.Add(Me.ChkbMobNo)
        Me.GroupBox2.Controls.Add(Me.ChkbName)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(783, 93)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search by Name or mobile Number"
        '
        'ChkbSearchAll
        '
        Me.ChkbSearchAll.AutoSize = True
        Me.ChkbSearchAll.Location = New System.Drawing.Point(252, 34)
        Me.ChkbSearchAll.Name = "ChkbSearchAll"
        Me.ChkbSearchAll.Size = New System.Drawing.Size(74, 17)
        Me.ChkbSearchAll.TabIndex = 5
        Me.ChkbSearchAll.Text = "Search All"
        Me.ChkbSearchAll.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(647, 28)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 51)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TbSearch
        '
        Me.TbSearch.Location = New System.Drawing.Point(27, 60)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(325, 20)
        Me.TbSearch.TabIndex = 2
        '
        'ChkbMobNo
        '
        Me.ChkbMobNo.AutoSize = True
        Me.ChkbMobNo.Location = New System.Drawing.Point(129, 35)
        Me.ChkbMobNo.Name = "ChkbMobNo"
        Me.ChkbMobNo.Size = New System.Drawing.Size(95, 17)
        Me.ChkbMobNo.TabIndex = 1
        Me.ChkbMobNo.Text = "Mobile number"
        Me.ChkbMobNo.UseVisualStyleBackColor = True
        '
        'ChkbName
        '
        Me.ChkbName.AutoSize = True
        Me.ChkbName.Location = New System.Drawing.Point(27, 34)
        Me.ChkbName.Name = "ChkbName"
        Me.ChkbName.Size = New System.Drawing.Size(54, 17)
        Me.ChkbName.TabIndex = 0
        Me.ChkbName.Text = "Name"
        Me.ChkbName.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewHistoryToolStripMenuItem, Me.BookAnAppoinmentToolStripMenuItem, Me.POSToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(186, 114)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewHistoryToolStripMenuItem
        '
        Me.ViewHistoryToolStripMenuItem.Name = "ViewHistoryToolStripMenuItem"
        Me.ViewHistoryToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.ViewHistoryToolStripMenuItem.Text = "View History"
        '
        'BookAnAppoinmentToolStripMenuItem
        '
        Me.BookAnAppoinmentToolStripMenuItem.Name = "BookAnAppoinmentToolStripMenuItem"
        Me.BookAnAppoinmentToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.BookAnAppoinmentToolStripMenuItem.Text = "Book an appoinment"
        '
        'POSToolStripMenuItem
        '
        Me.POSToolStripMenuItem.Name = "POSToolStripMenuItem"
        Me.POSToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.POSToolStripMenuItem.Text = "POS"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 5
        Me.ColumnHeader7.Text = "Location"
        '
        'frmClientSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(830, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmClientSearch"
        Me.Text = "frmClientSearch"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LstwClientDetails As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TbSearch As System.Windows.Forms.TextBox
    Friend WithEvents ChkbMobNo As System.Windows.Forms.CheckBox
    Friend WithEvents ChkbName As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkbSearchAll As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookAnAppoinmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
End Class
