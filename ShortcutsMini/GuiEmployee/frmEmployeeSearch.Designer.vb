<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeeSearch
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LstwStaffDetails = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ChkSearchAll = New System.Windows.Forms.CheckBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.TbSearch = New System.Windows.Forms.TextBox
        Me.ChkMobileNumber = New System.Windows.Forms.CheckBox
        Me.Chkname = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 460)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Staff"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LstwStaffDetails)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 149)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(747, 260)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Details"
        '
        'LstwStaffDetails
        '
        Me.LstwStaffDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader5})
        Me.LstwStaffDetails.FullRowSelect = True
        Me.LstwStaffDetails.GridLines = True
        Me.LstwStaffDetails.Location = New System.Drawing.Point(14, 19)
        Me.LstwStaffDetails.Name = "LstwStaffDetails"
        Me.LstwStaffDetails.Size = New System.Drawing.Size(720, 227)
        Me.LstwStaffDetails.TabIndex = 1
        Me.LstwStaffDetails.UseCompatibleStateImageBehavior = False
        Me.LstwStaffDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Sl.No."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Staff Name"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 4
        Me.ColumnHeader3.Text = "Mobile Number1"
        Me.ColumnHeader3.Width = 123
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Designation"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 7
        Me.ColumnHeader6.Text = "Active"
        Me.ColumnHeader6.Width = 77
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 2
        Me.ColumnHeader7.Text = "Gender"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DateOfJoining"
        Me.ColumnHeader8.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 5
        Me.ColumnHeader5.Text = "Location"
        Me.ColumnHeader5.Width = 91
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkSearchAll)
        Me.GroupBox2.Controls.Add(Me.BtnSearch)
        Me.GroupBox2.Controls.Add(Me.TbSearch)
        Me.GroupBox2.Controls.Add(Me.ChkMobileNumber)
        Me.GroupBox2.Controls.Add(Me.Chkname)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 93)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search by Name or mobile Number"
        '
        'ChkSearchAll
        '
        Me.ChkSearchAll.AutoSize = True
        Me.ChkSearchAll.Location = New System.Drawing.Point(252, 28)
        Me.ChkSearchAll.Name = "ChkSearchAll"
        Me.ChkSearchAll.Size = New System.Drawing.Size(74, 17)
        Me.ChkSearchAll.TabIndex = 5
        Me.ChkSearchAll.Text = "Search All"
        Me.ChkSearchAll.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(661, 28)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 35)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TbSearch
        '
        Me.TbSearch.Location = New System.Drawing.Point(27, 58)
        Me.TbSearch.Name = "TbSearch"
        Me.TbSearch.Size = New System.Drawing.Size(325, 20)
        Me.TbSearch.TabIndex = 2
        '
        'ChkMobileNumber
        '
        Me.ChkMobileNumber.AutoSize = True
        Me.ChkMobileNumber.Location = New System.Drawing.Point(129, 28)
        Me.ChkMobileNumber.Name = "ChkMobileNumber"
        Me.ChkMobileNumber.Size = New System.Drawing.Size(95, 17)
        Me.ChkMobileNumber.TabIndex = 1
        Me.ChkMobileNumber.Text = "Mobile number"
        Me.ChkMobileNumber.UseVisualStyleBackColor = True
        '
        'Chkname
        '
        Me.Chkname.AutoSize = True
        Me.Chkname.Location = New System.Drawing.Point(27, 28)
        Me.Chkname.Name = "Chkname"
        Me.Chkname.Size = New System.Drawing.Size(54, 17)
        Me.Chkname.TabIndex = 0
        Me.Chkname.Text = "Name"
        Me.Chkname.UseVisualStyleBackColor = True
        '
        'frmEmployeeSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 522)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEmployeeSearch"
        Me.Text = "frmStaffSearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LstwStaffDetails As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkSearchAll As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TbSearch As System.Windows.Forms.TextBox
    Friend WithEvents ChkMobileNumber As System.Windows.Forms.CheckBox
    Friend WithEvents Chkname As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
End Class
