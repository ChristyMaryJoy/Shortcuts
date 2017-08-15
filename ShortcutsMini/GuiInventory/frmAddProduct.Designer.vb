<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProduct
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TbBuyPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TbSellPrice = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TbRequired = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TbOnOrder = New System.Windows.Forms.TextBox
        Me.NupWarning = New System.Windows.Forms.NumericUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TbOnStock = New System.Windows.Forms.TextBox
        Me.NupReorder = New System.Windows.Forms.NumericUpDown
        Me.Label28 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSupplier = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbCompany = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLine = New System.Windows.Forms.ComboBox
        Me.TbBarcode = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TbProductcode = New System.Windows.Forms.TextBox
        Me.ChckActive = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TbProductName = New System.Windows.Forms.TextBox
        Me.ChckRetail = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NupWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NupReorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.ChckActive)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TbProductName)
        Me.GroupBox2.Controls.Add(Me.ChckRetail)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(798, 447)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Product"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TbBuyPrice)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TbSellPrice)
        Me.GroupBox4.Location = New System.Drawing.Point(319, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 125)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Price"
        '
        'TbBuyPrice
        '
        Me.TbBuyPrice.Location = New System.Drawing.Point(21, 38)
        Me.TbBuyPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TbBuyPrice.Name = "TbBuyPrice"
        Me.TbBuyPrice.Size = New System.Drawing.Size(123, 20)
        Me.TbBuyPrice.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Buy Price"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 72)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Sell Price"
        '
        'TbSellPrice
        '
        Me.TbSellPrice.Location = New System.Drawing.Point(21, 85)
        Me.TbSellPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.TbSellPrice.Name = "TbSellPrice"
        Me.TbSellPrice.Size = New System.Drawing.Size(123, 20)
        Me.TbSellPrice.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TbRequired)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TbOnOrder)
        Me.GroupBox3.Controls.Add(Me.NupWarning)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TbOnStock)
        Me.GroupBox3.Controls.Add(Me.NupReorder)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Location = New System.Drawing.Point(568, 80)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 275)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Re-order Level"
        '
        'TbRequired
        '
        Me.TbRequired.AutoSize = True
        Me.TbRequired.Location = New System.Drawing.Point(13, 119)
        Me.TbRequired.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TbRequired.Name = "TbRequired"
        Me.TbRequired.Size = New System.Drawing.Size(50, 13)
        Me.TbRequired.TabIndex = 40
        Me.TbRequired.Text = "Required"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(16, 131)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(157, 20)
        Me.TextBox7.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "On Order"
        '
        'TbOnOrder
        '
        Me.TbOnOrder.Location = New System.Drawing.Point(18, 87)
        Me.TbOnOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.TbOnOrder.Name = "TbOnOrder"
        Me.TbOnOrder.Size = New System.Drawing.Size(157, 20)
        Me.TbOnOrder.TabIndex = 37
        '
        'NupWarning
        '
        Me.NupWarning.Location = New System.Drawing.Point(18, 232)
        Me.NupWarning.Margin = New System.Windows.Forms.Padding(2)
        Me.NupWarning.Name = "NupWarning"
        Me.NupWarning.Size = New System.Drawing.Size(154, 20)
        Me.NupWarning.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 218)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Warning"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "On Stock"
        '
        'TbOnStock
        '
        Me.TbOnStock.Location = New System.Drawing.Point(18, 38)
        Me.TbOnStock.Margin = New System.Windows.Forms.Padding(2)
        Me.TbOnStock.Name = "TbOnStock"
        Me.TbOnStock.Size = New System.Drawing.Size(157, 20)
        Me.TbOnStock.TabIndex = 19
        '
        'NupReorder
        '
        Me.NupReorder.Location = New System.Drawing.Point(19, 178)
        Me.NupReorder.Margin = New System.Windows.Forms.Padding(2)
        Me.NupReorder.Name = "NupReorder"
        Me.NupReorder.Size = New System.Drawing.Size(154, 20)
        Me.NupReorder.TabIndex = 33
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(15, 165)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 13)
        Me.Label28.TabIndex = 32
        Me.Label28.Text = "Reorder Level"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCompany)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbLine)
        Me.GroupBox1.Controls.Add(Me.TbBarcode)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TbProductcode)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 275)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Properties"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Supplier"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(10, 40)
        Me.cmbSupplier.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(236, 21)
        Me.cmbSupplier.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Company"
        '
        'cmbCompany
        '
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(11, 92)
        Me.cmbCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(238, 21)
        Me.cmbCompany.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Line"
        '
        'cmbLine
        '
        Me.cmbLine.FormattingEnabled = True
        Me.cmbLine.Location = New System.Drawing.Point(11, 138)
        Me.cmbLine.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbLine.Name = "cmbLine"
        Me.cmbLine.Size = New System.Drawing.Size(238, 21)
        Me.cmbLine.TabIndex = 7
        '
        'TbBarcode
        '
        Me.TbBarcode.AutoSize = True
        Me.TbBarcode.Location = New System.Drawing.Point(9, 231)
        Me.TbBarcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TbBarcode.Name = "TbBarcode"
        Me.TbBarcode.Size = New System.Drawing.Size(51, 13)
        Me.TbBarcode.TabIndex = 25
        Me.TbBarcode.Text = "Bar Code"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 173)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Product Code"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(12, 243)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(234, 20)
        Me.TextBox6.TabIndex = 24
        '
        'TbProductcode
        '
        Me.TbProductcode.Location = New System.Drawing.Point(12, 186)
        Me.TbProductcode.Margin = New System.Windows.Forms.Padding(2)
        Me.TbProductcode.Name = "TbProductcode"
        Me.TbProductcode.Size = New System.Drawing.Size(234, 20)
        Me.TbProductcode.TabIndex = 22
        '
        'ChckActive
        '
        Me.ChckActive.AutoSize = True
        Me.ChckActive.Location = New System.Drawing.Point(324, 37)
        Me.ChckActive.Margin = New System.Windows.Forms.Padding(2)
        Me.ChckActive.Name = "ChckActive"
        Me.ChckActive.Size = New System.Drawing.Size(67, 17)
        Me.ChckActive.TabIndex = 30
        Me.ChckActive.Text = "Is Active"
        Me.ChckActive.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 13
        '
        'TbProductName
        '
        Me.TbProductName.Location = New System.Drawing.Point(21, 37)
        Me.TbProductName.Margin = New System.Windows.Forms.Padding(2)
        Me.TbProductName.Name = "TbProductName"
        Me.TbProductName.Size = New System.Drawing.Size(275, 20)
        Me.TbProductName.TabIndex = 12
        '
        'ChckRetail
        '
        Me.ChckRetail.AutoSize = True
        Me.ChckRetail.Location = New System.Drawing.Point(417, 37)
        Me.ChckRetail.Margin = New System.Windows.Forms.Padding(2)
        Me.ChckRetail.Name = "ChckRetail"
        Me.ChckRetail.Size = New System.Drawing.Size(53, 17)
        Me.ChckRetail.TabIndex = 0
        Me.ChckRetail.Text = "Retail"
        Me.ChckRetail.UseVisualStyleBackColor = True
        '
        'frmAddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(814, 522)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmAddProduct"
        Me.Text = "frmProduct"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NupWarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NupReorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NupReorder As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents ChckActive As System.Windows.Forms.CheckBox
    Friend WithEvents TbBarcode As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TbProductcode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TbOnStock As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TbSellPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbBuyPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLine As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents ChckRetail As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NupWarning As System.Windows.Forms.NumericUpDown
    Friend WithEvents TbRequired As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbOnOrder As System.Windows.Forms.TextBox
End Class
