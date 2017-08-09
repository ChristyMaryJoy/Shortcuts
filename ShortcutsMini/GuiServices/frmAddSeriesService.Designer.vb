<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSeriesService
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NupSession = New System.Windows.Forms.NumericUpDown
        Me.LblCategory = New System.Windows.Forms.Label
        Me.CmbCategory = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbServices = New System.Windows.Forms.ComboBox
        Me.LblService = New System.Windows.Forms.Label
        Me.NupDuration = New System.Windows.Forms.NumericUpDown
        Me.TbSeriesName = New System.Windows.Forms.TextBox
        Me.LblSeviceDuration = New System.Windows.Forms.Label
        Me.LblPackage = New System.Windows.Forms.Label
        Me.NupExpiry = New System.Windows.Forms.NumericUpDown
        Me.LblUnitprice = New System.Windows.Forms.Label
        Me.LblExpiry = New System.Windows.Forms.Label
        Me.TbUnitPrice = New System.Windows.Forms.TextBox
        Me.LblToatlPrice = New System.Windows.Forms.Label
        Me.TbTotalPrice = New System.Windows.Forms.TextBox
        Me.ChkActive = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LstwSeries = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NupSession, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupExpiry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(829, 426)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NupSession)
        Me.GroupBox2.Controls.Add(Me.LblCategory)
        Me.GroupBox2.Controls.Add(Me.CmbCategory)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbServices)
        Me.GroupBox2.Controls.Add(Me.LblService)
        Me.GroupBox2.Controls.Add(Me.NupDuration)
        Me.GroupBox2.Controls.Add(Me.TbSeriesName)
        Me.GroupBox2.Controls.Add(Me.LblSeviceDuration)
        Me.GroupBox2.Controls.Add(Me.LblPackage)
        Me.GroupBox2.Controls.Add(Me.NupExpiry)
        Me.GroupBox2.Controls.Add(Me.LblUnitprice)
        Me.GroupBox2.Controls.Add(Me.LblExpiry)
        Me.GroupBox2.Controls.Add(Me.TbUnitPrice)
        Me.GroupBox2.Controls.Add(Me.LblToatlPrice)
        Me.GroupBox2.Controls.Add(Me.TbTotalPrice)
        Me.GroupBox2.Controls.Add(Me.ChkActive)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(807, 110)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Series Services"
        '
        'NupSession
        '
        Me.NupSession.Location = New System.Drawing.Point(150, 77)
        Me.NupSession.Name = "NupSession"
        Me.NupSession.Size = New System.Drawing.Size(73, 20)
        Me.NupSession.TabIndex = 35
        Me.NupSession.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Location = New System.Drawing.Point(17, 19)
        Me.LblCategory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(49, 13)
        Me.LblCategory.TabIndex = 17
        Me.LblCategory.Text = "Category"
        '
        'CmbCategory
        '
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(20, 32)
        Me.CmbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(245, 21)
        Me.CmbCategory.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "xSession"
        '
        'CmbServices
        '
        Me.CmbServices.FormattingEnabled = True
        Me.CmbServices.Location = New System.Drawing.Point(296, 33)
        Me.CmbServices.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbServices.Name = "CmbServices"
        Me.CmbServices.Size = New System.Drawing.Size(214, 21)
        Me.CmbServices.TabIndex = 16
        '
        'LblService
        '
        Me.LblService.AutoSize = True
        Me.LblService.Location = New System.Drawing.Point(293, 20)
        Me.LblService.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblService.Name = "LblService"
        Me.LblService.Size = New System.Drawing.Size(48, 13)
        Me.LblService.TabIndex = 18
        Me.LblService.Text = "Services"
        '
        'NupDuration
        '
        Me.NupDuration.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NupDuration.Location = New System.Drawing.Point(305, 78)
        Me.NupDuration.Name = "NupDuration"
        Me.NupDuration.Size = New System.Drawing.Size(73, 20)
        Me.NupDuration.TabIndex = 32
        Me.NupDuration.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'TbSeriesName
        '
        Me.TbSeriesName.Location = New System.Drawing.Point(537, 34)
        Me.TbSeriesName.Margin = New System.Windows.Forms.Padding(2)
        Me.TbSeriesName.Name = "TbSeriesName"
        Me.TbSeriesName.Size = New System.Drawing.Size(259, 20)
        Me.TbSeriesName.TabIndex = 20
        '
        'LblSeviceDuration
        '
        Me.LblSeviceDuration.AutoSize = True
        Me.LblSeviceDuration.Location = New System.Drawing.Point(302, 65)
        Me.LblSeviceDuration.Name = "LblSeviceDuration"
        Me.LblSeviceDuration.Size = New System.Drawing.Size(86, 13)
        Me.LblSeviceDuration.TabIndex = 31
        Me.LblSeviceDuration.Text = "Service Duration"
        '
        'LblPackage
        '
        Me.LblPackage.AutoSize = True
        Me.LblPackage.Location = New System.Drawing.Point(536, 22)
        Me.LblPackage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPackage.Name = "LblPackage"
        Me.LblPackage.Size = New System.Drawing.Size(67, 13)
        Me.LblPackage.TabIndex = 19
        Me.LblPackage.Text = "Series Name"
        '
        'NupExpiry
        '
        Me.NupExpiry.Location = New System.Drawing.Point(554, 77)
        Me.NupExpiry.Margin = New System.Windows.Forms.Padding(2)
        Me.NupExpiry.Name = "NupExpiry"
        Me.NupExpiry.Size = New System.Drawing.Size(72, 20)
        Me.NupExpiry.TabIndex = 29
        '
        'LblUnitprice
        '
        Me.LblUnitprice.AutoSize = True
        Me.LblUnitprice.Location = New System.Drawing.Point(23, 64)
        Me.LblUnitprice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUnitprice.Name = "LblUnitprice"
        Me.LblUnitprice.Size = New System.Drawing.Size(53, 13)
        Me.LblUnitprice.TabIndex = 17
        Me.LblUnitprice.Text = "Unit Price"
        '
        'LblExpiry
        '
        Me.LblExpiry.AutoSize = True
        Me.LblExpiry.Location = New System.Drawing.Point(551, 65)
        Me.LblExpiry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblExpiry.Name = "LblExpiry"
        Me.LblExpiry.Size = New System.Drawing.Size(84, 13)
        Me.LblExpiry.TabIndex = 30
        Me.LblExpiry.Text = "Expiry in Months"
        '
        'TbUnitPrice
        '
        Me.TbUnitPrice.Location = New System.Drawing.Point(24, 77)
        Me.TbUnitPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TbUnitPrice.Name = "TbUnitPrice"
        Me.TbUnitPrice.Size = New System.Drawing.Size(88, 20)
        Me.TbUnitPrice.TabIndex = 15
        Me.TbUnitPrice.Text = "0"
        '
        'LblToatlPrice
        '
        Me.LblToatlPrice.AutoSize = True
        Me.LblToatlPrice.Location = New System.Drawing.Point(414, 65)
        Me.LblToatlPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblToatlPrice.Name = "LblToatlPrice"
        Me.LblToatlPrice.Size = New System.Drawing.Size(75, 13)
        Me.LblToatlPrice.TabIndex = 28
        Me.LblToatlPrice.Text = "Total SellPrice"
        '
        'TbTotalPrice
        '
        Me.TbTotalPrice.Location = New System.Drawing.Point(417, 78)
        Me.TbTotalPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TbTotalPrice.Name = "TbTotalPrice"
        Me.TbTotalPrice.ReadOnly = True
        Me.TbTotalPrice.Size = New System.Drawing.Size(92, 20)
        Me.TbTotalPrice.TabIndex = 27
        '
        'ChkActive
        '
        Me.ChkActive.AutoSize = True
        Me.ChkActive.Location = New System.Drawing.Point(656, 79)
        Me.ChkActive.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkActive.Name = "ChkActive"
        Me.ChkActive.Size = New System.Drawing.Size(67, 17)
        Me.ChkActive.TabIndex = 22
        Me.ChkActive.Text = "Is Active"
        Me.ChkActive.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LstwSeries)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 281)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Saved Series Services"
        '
        'LstwSeries
        '
        Me.LstwSeries.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.LstwSeries.FullRowSelect = True
        Me.LstwSeries.GridLines = True
        Me.LstwSeries.Location = New System.Drawing.Point(7, 18)
        Me.LstwSeries.Margin = New System.Windows.Forms.Padding(2)
        Me.LstwSeries.Name = "LstwSeries"
        Me.LstwSeries.Size = New System.Drawing.Size(797, 256)
        Me.LstwSeries.TabIndex = 21
        Me.LstwSeries.UseCompatibleStateImageBehavior = False
        Me.LstwSeries.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "intCategoryId"
        Me.ColumnHeader11.Width = 0
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "intServiceID"
        Me.ColumnHeader12.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Category"
        Me.ColumnHeader2.Width = 88
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Service"
        Me.ColumnHeader3.Width = 102
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Series Name"
        Me.ColumnHeader4.Width = 141
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "UnitPrice"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "xSession"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Total price"
        Me.ColumnHeader7.Width = 81
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Duration"
        Me.ColumnHeader8.Width = 89
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Expiry"
        Me.ColumnHeader9.Width = 75
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Active"
        Me.ColumnHeader10.Width = 85
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
        'frmAddSeriesService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(844, 497)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmAddSeriesService"
        Me.Text = "frmAddNonSeriesPackage"
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NupSession, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupExpiry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents NupExpiry As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblExpiry As System.Windows.Forms.Label
    Friend WithEvents LblToatlPrice As System.Windows.Forms.Label
    Friend WithEvents ChkActive As System.Windows.Forms.CheckBox
    Friend WithEvents TbTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents LstwSeries As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LblPackage As System.Windows.Forms.Label
    Friend WithEvents LblUnitprice As System.Windows.Forms.Label
    Friend WithEvents TbSeriesName As System.Windows.Forms.TextBox
    Friend WithEvents TbUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblService As System.Windows.Forms.Label
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents CmbServices As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents NupDuration As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblSeviceDuration As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents NupSession As System.Windows.Forms.NumericUpDown
End Class
