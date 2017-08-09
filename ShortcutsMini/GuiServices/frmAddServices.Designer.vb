<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddServices
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NupDuration = New System.Windows.Forms.NumericUpDown
        Me.LblCategory = New System.Windows.Forms.Label
        Me.TbService = New System.Windows.Forms.TextBox
        Me.LblSeviceDuration = New System.Windows.Forms.Label
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.LblServicename = New System.Windows.Forms.Label
        Me.LblServiceCharge = New System.Windows.Forms.Label
        Me.CmbCategory = New System.Windows.Forms.ComboBox
        Me.TbServiceCharge = New System.Windows.Forms.TextBox
        Me.Grp = New System.Windows.Forms.GroupBox
        Me.LstServices = New System.Windows.Forms.ListView
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToSeriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NupDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Grp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 489)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salon and Spa Services"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NupDuration)
        Me.GroupBox2.Controls.Add(Me.LblCategory)
        Me.GroupBox2.Controls.Add(Me.TbService)
        Me.GroupBox2.Controls.Add(Me.LblSeviceDuration)
        Me.GroupBox2.Controls.Add(Me.ChkActive)
        Me.GroupBox2.Controls.Add(Me.LblServicename)
        Me.GroupBox2.Controls.Add(Me.LblServiceCharge)
        Me.GroupBox2.Controls.Add(Me.CmbCategory)
        Me.GroupBox2.Controls.Add(Me.TbServiceCharge)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 69)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Services"
        '
        'NupDuration
        '
        Me.NupDuration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NupDuration.Location = New System.Drawing.Point(597, 33)
        Me.NupDuration.Name = "NupDuration"
        Me.NupDuration.Size = New System.Drawing.Size(73, 20)
        Me.NupDuration.TabIndex = 18
        Me.NupDuration.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Location = New System.Drawing.Point(6, 20)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(49, 13)
        Me.LblCategory.TabIndex = 13
        Me.LblCategory.Text = "Category"
        '
        'TbService
        '
        Me.TbService.Location = New System.Drawing.Point(228, 34)
        Me.TbService.Name = "TbService"
        Me.TbService.Size = New System.Drawing.Size(244, 20)
        Me.TbService.TabIndex = 8
        '
        'LblSeviceDuration
        '
        Me.LblSeviceDuration.AutoSize = True
        Me.LblSeviceDuration.Location = New System.Drawing.Point(594, 20)
        Me.LblSeviceDuration.Name = "LblSeviceDuration"
        Me.LblSeviceDuration.Size = New System.Drawing.Size(86, 13)
        Me.LblSeviceDuration.TabIndex = 17
        Me.LblSeviceDuration.Text = "Service Duration"
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Location = New System.Drawing.Point(703, 33)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.Size = New System.Drawing.Size(56, 17)
        Me.ChkActive.TabIndex = 9
        Me.ChkActive.Text = "Active"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'LblServicename
        '
        Me.LblServicename.AutoSize = True
        Me.LblServicename.Location = New System.Drawing.Point(225, 20)
        Me.LblServicename.Name = "LblServicename"
        Me.LblServicename.Size = New System.Drawing.Size(79, 13)
        Me.LblServicename.TabIndex = 11
        Me.LblServicename.Text = "Services Name"
        '
        'LblServiceCharge
        '
        Me.LblServiceCharge.AutoSize = True
        Me.LblServiceCharge.Location = New System.Drawing.Point(490, 20)
        Me.LblServiceCharge.Name = "LblServiceCharge"
        Me.LblServiceCharge.Size = New System.Drawing.Size(85, 13)
        Me.LblServiceCharge.TabIndex = 15
        Me.LblServiceCharge.Text = "Services Charge"
        '
        'CmbCategory
        '
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(9, 33)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(193, 21)
        Me.CmbCategory.TabIndex = 12
        '
        'TbServiceCharge
        '
        Me.TbServiceCharge.Location = New System.Drawing.Point(493, 34)
        Me.TbServiceCharge.Name = "TbServiceCharge"
        Me.TbServiceCharge.Size = New System.Drawing.Size(80, 20)
        Me.TbServiceCharge.TabIndex = 14
        Me.TbServiceCharge.Text = "0"
        '
        'Grp
        '
        Me.Grp.Controls.Add(Me.LstServices)
        Me.Grp.Location = New System.Drawing.Point(22, 92)
        Me.Grp.Name = "Grp"
        Me.Grp.Size = New System.Drawing.Size(764, 391)
        Me.Grp.TabIndex = 18
        Me.Grp.TabStop = False
        Me.Grp.Text = "Saved Services"
        '
        'LstServices
        '
        Me.LstServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LstServices.FullRowSelect = True
        Me.LstServices.GridLines = True
        Me.LstServices.Location = New System.Drawing.Point(9, 19)
        Me.LstServices.MultiSelect = False
        Me.LstServices.Name = "LstServices"
        Me.LstServices.Size = New System.Drawing.Size(744, 366)
        Me.LstServices.TabIndex = 0
        Me.LstServices.UseCompatibleStateImageBehavior = False
        Me.LstServices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "SeviceID"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "fkCategoryID"
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Category"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Service"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Duration"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Series"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Active"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.AddToSeriesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(144, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddToSeriesToolStripMenuItem
        '
        Me.AddToSeriesToolStripMenuItem.Name = "AddToSeriesToolStripMenuItem"
        Me.AddToSeriesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AddToSeriesToolStripMenuItem.Text = "Add to Series"
        '
        'frmAddServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(830, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddServices"
        Me.Text = "frmAddServices"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NupDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents CmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents LblServicename As System.Windows.Forms.Label
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents TbService As System.Windows.Forms.TextBox
    Friend WithEvents LblSeviceDuration As System.Windows.Forms.Label
    Friend WithEvents LblServiceCharge As System.Windows.Forms.Label
    Friend WithEvents TbServiceCharge As System.Windows.Forms.TextBox
    Friend WithEvents Grp As System.Windows.Forms.GroupBox
    Friend WithEvents LstServices As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NupDuration As System.Windows.Forms.NumericUpDown
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToSeriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
End Class
