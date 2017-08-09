<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPackageService
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.NumExpiry = New System.Windows.Forms.NumericUpDown
        Me.LblExpiry = New System.Windows.Forms.Label
        Me.LblToatlPrice = New System.Windows.Forms.Label
        Me.ChckActive = New System.Windows.Forms.CheckBox
        Me.TbTotalPrice = New System.Windows.Forms.TextBox
        Me.LstwPackageDetails = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.BtnAddPackage = New System.Windows.Forms.Button
        Me.LblDuration = New System.Windows.Forms.Label
        Me.LblPackage = New System.Windows.Forms.Label
        Me.LblUnitprice = New System.Windows.Forms.Label
        Me.TbDuration = New System.Windows.Forms.TextBox
        Me.TbPackageName = New System.Windows.Forms.TextBox
        Me.TbUnitPrice = New System.Windows.Forms.TextBox
        Me.LblService = New System.Windows.Forms.Label
        Me.LblCategory = New System.Windows.Forms.Label
        Me.CmbServices = New System.Windows.Forms.ComboBox
        Me.CmbCategory = New System.Windows.Forms.ComboBox
        Me.GroupBox4.SuspendLayout()
        CType(Me.NumExpiry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.NumExpiry)
        Me.GroupBox4.Controls.Add(Me.LblExpiry)
        Me.GroupBox4.Controls.Add(Me.LblToatlPrice)
        Me.GroupBox4.Controls.Add(Me.ChckActive)
        Me.GroupBox4.Controls.Add(Me.TbTotalPrice)
        Me.GroupBox4.Controls.Add(Me.LstwPackageDetails)
        Me.GroupBox4.Controls.Add(Me.BtnAddPackage)
        Me.GroupBox4.Controls.Add(Me.LblDuration)
        Me.GroupBox4.Controls.Add(Me.LblPackage)
        Me.GroupBox4.Controls.Add(Me.LblUnitprice)
        Me.GroupBox4.Controls.Add(Me.TbDuration)
        Me.GroupBox4.Controls.Add(Me.TbPackageName)
        Me.GroupBox4.Controls.Add(Me.TbUnitPrice)
        Me.GroupBox4.Controls.Add(Me.LblService)
        Me.GroupBox4.Controls.Add(Me.LblCategory)
        Me.GroupBox4.Controls.Add(Me.CmbServices)
        Me.GroupBox4.Controls.Add(Me.CmbCategory)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(814, 470)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Package Services"
        '
        'NumExpiry
        '
        Me.NumExpiry.Location = New System.Drawing.Point(13, 344)
        Me.NumExpiry.Margin = New System.Windows.Forms.Padding(2)
        Me.NumExpiry.Name = "NumExpiry"
        Me.NumExpiry.Size = New System.Drawing.Size(72, 20)
        Me.NumExpiry.TabIndex = 29
        '
        'LblExpiry
        '
        Me.LblExpiry.AutoSize = True
        Me.LblExpiry.Location = New System.Drawing.Point(9, 329)
        Me.LblExpiry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblExpiry.Name = "LblExpiry"
        Me.LblExpiry.Size = New System.Drawing.Size(84, 13)
        Me.LblExpiry.TabIndex = 30
        Me.LblExpiry.Text = "Expiry in Months"
        '
        'LblToatlPrice
        '
        Me.LblToatlPrice.AutoSize = True
        Me.LblToatlPrice.Location = New System.Drawing.Point(214, 298)
        Me.LblToatlPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblToatlPrice.Name = "LblToatlPrice"
        Me.LblToatlPrice.Size = New System.Drawing.Size(75, 13)
        Me.LblToatlPrice.TabIndex = 28
        Me.LblToatlPrice.Text = "Total SellPrice"
        '
        'ChckActive
        '
        Me.ChckActive.AutoSize = True
        Me.ChckActive.Location = New System.Drawing.Point(212, 345)
        Me.ChckActive.Margin = New System.Windows.Forms.Padding(2)
        Me.ChckActive.Name = "ChckActive"
        Me.ChckActive.Size = New System.Drawing.Size(67, 17)
        Me.ChckActive.TabIndex = 22
        Me.ChckActive.Text = "Is Active"
        Me.ChckActive.UseVisualStyleBackColor = True
        '
        'TbTotalPrice
        '
        Me.TbTotalPrice.Location = New System.Drawing.Point(217, 311)
        Me.TbTotalPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TbTotalPrice.Name = "TbTotalPrice"
        Me.TbTotalPrice.Size = New System.Drawing.Size(92, 20)
        Me.TbTotalPrice.TabIndex = 27
        '
        'LstwPackageDetails
        '
        Me.LstwPackageDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LstwPackageDetails.FullRowSelect = True
        Me.LstwPackageDetails.GridLines = True
        Me.LstwPackageDetails.Location = New System.Drawing.Point(11, 162)
        Me.LstwPackageDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.LstwPackageDetails.Name = "LstwPackageDetails"
        Me.LstwPackageDetails.Size = New System.Drawing.Size(450, 132)
        Me.LstwPackageDetails.TabIndex = 21
        Me.LstwPackageDetails.UseCompatibleStateImageBehavior = False
        Me.LstwPackageDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Service Name"
        Me.ColumnHeader2.Width = 141
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Unit Price"
        Me.ColumnHeader3.Width = 126
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Duration"
        Me.ColumnHeader4.Width = 107
        '
        'BtnAddPackage
        '
        Me.BtnAddPackage.Location = New System.Drawing.Point(13, 128)
        Me.BtnAddPackage.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAddPackage.Name = "BtnAddPackage"
        Me.BtnAddPackage.Size = New System.Drawing.Size(72, 28)
        Me.BtnAddPackage.TabIndex = 3
        Me.BtnAddPackage.Text = "ADD"
        Me.BtnAddPackage.UseVisualStyleBackColor = True
        '
        'LblDuration
        '
        Me.LblDuration.AutoSize = True
        Me.LblDuration.Location = New System.Drawing.Point(232, 91)
        Me.LblDuration.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDuration.Name = "LblDuration"
        Me.LblDuration.Size = New System.Drawing.Size(47, 13)
        Me.LblDuration.TabIndex = 18
        Me.LblDuration.Text = "Duration"
        '
        'LblPackage
        '
        Me.LblPackage.AutoSize = True
        Me.LblPackage.Location = New System.Drawing.Point(10, 19)
        Me.LblPackage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPackage.Name = "LblPackage"
        Me.LblPackage.Size = New System.Drawing.Size(81, 13)
        Me.LblPackage.TabIndex = 19
        Me.LblPackage.Text = "Package Name"
        '
        'LblUnitprice
        '
        Me.LblUnitprice.AutoSize = True
        Me.LblUnitprice.Location = New System.Drawing.Point(10, 93)
        Me.LblUnitprice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUnitprice.Name = "LblUnitprice"
        Me.LblUnitprice.Size = New System.Drawing.Size(53, 13)
        Me.LblUnitprice.TabIndex = 17
        Me.LblUnitprice.Text = "Unit Price"
        '
        'TbDuration
        '
        Me.TbDuration.Location = New System.Drawing.Point(235, 104)
        Me.TbDuration.Margin = New System.Windows.Forms.Padding(2)
        Me.TbDuration.Name = "TbDuration"
        Me.TbDuration.Size = New System.Drawing.Size(164, 20)
        Me.TbDuration.TabIndex = 16
        '
        'TbPackageName
        '
        Me.TbPackageName.Location = New System.Drawing.Point(11, 32)
        Me.TbPackageName.Margin = New System.Windows.Forms.Padding(2)
        Me.TbPackageName.Name = "TbPackageName"
        Me.TbPackageName.Size = New System.Drawing.Size(387, 20)
        Me.TbPackageName.TabIndex = 20
        '
        'TbUnitPrice
        '
        Me.TbUnitPrice.Location = New System.Drawing.Point(11, 106)
        Me.TbUnitPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TbUnitPrice.Name = "TbUnitPrice"
        Me.TbUnitPrice.Size = New System.Drawing.Size(164, 20)
        Me.TbUnitPrice.TabIndex = 15
        '
        'LblService
        '
        Me.LblService.AutoSize = True
        Me.LblService.Location = New System.Drawing.Point(232, 53)
        Me.LblService.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblService.Name = "LblService"
        Me.LblService.Size = New System.Drawing.Size(48, 13)
        Me.LblService.TabIndex = 18
        Me.LblService.Text = "Services"
        '
        'LblCategory
        '
        Me.LblCategory.AutoSize = True
        Me.LblCategory.Location = New System.Drawing.Point(9, 54)
        Me.LblCategory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(49, 13)
        Me.LblCategory.TabIndex = 17
        Me.LblCategory.Text = "Category"
        '
        'CmbServices
        '
        Me.CmbServices.FormattingEnabled = True
        Me.CmbServices.Location = New System.Drawing.Point(235, 67)
        Me.CmbServices.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbServices.Name = "CmbServices"
        Me.CmbServices.Size = New System.Drawing.Size(164, 21)
        Me.CmbServices.TabIndex = 16
        '
        'CmbCategory
        '
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(12, 67)
        Me.CmbCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(166, 21)
        Me.CmbCategory.TabIndex = 15
        '
        'frmAddPackageService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 492)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "frmAddPackageService"
        Me.Text = "frmAddPackageServices"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NumExpiry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents NumExpiry As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblExpiry As System.Windows.Forms.Label
    Friend WithEvents LblToatlPrice As System.Windows.Forms.Label
    Friend WithEvents ChckActive As System.Windows.Forms.CheckBox
    Friend WithEvents TbTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents LstwPackageDetails As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnAddPackage As System.Windows.Forms.Button
    Friend WithEvents LblDuration As System.Windows.Forms.Label
    Friend WithEvents LblPackage As System.Windows.Forms.Label
    Friend WithEvents LblUnitprice As System.Windows.Forms.Label
    Friend WithEvents TbDuration As System.Windows.Forms.TextBox
    Friend WithEvents TbPackageName As System.Windows.Forms.TextBox
    Friend WithEvents TbUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents LblService As System.Windows.Forms.Label
    Friend WithEvents LblCategory As System.Windows.Forms.Label
    Friend WithEvents CmbServices As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCategory As System.Windows.Forms.ComboBox
End Class
