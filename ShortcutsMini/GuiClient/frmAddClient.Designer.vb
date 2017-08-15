<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddClient
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LblClientType = New System.Windows.Forms.Label
        Me.CmbClientType = New System.Windows.Forms.ComboBox
        Me.TbClubMembeshipNo = New System.Windows.Forms.TextBox
        Me.LblNote = New System.Windows.Forms.Label
        Me.TbNote = New System.Windows.Forms.TextBox
        Me.lblClubmembershipNo = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Txtage = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CmbOccupation = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblFirstname = New System.Windows.Forms.Label
        Me.LblMiddleName = New System.Windows.Forms.Label
        Me.RbFemale = New System.Windows.Forms.RadioButton
        Me.RbMale = New System.Windows.Forms.RadioButton
        Me.LblLastname = New System.Windows.Forms.Label
        Me.TbLastname = New System.Windows.Forms.TextBox
        Me.TbFirstname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TbMiddleName = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TbResidenceNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblCivilID = New System.Windows.Forms.Label
        Me.TbCivilID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Lblemail = New System.Windows.Forms.Label
        Me.Tbemail = New System.Windows.Forms.TextBox
        Me.LblMobNo2 = New System.Windows.Forms.Label
        Me.LblAddress = New System.Windows.Forms.Label
        Me.TbAddress = New System.Windows.Forms.TextBox
        Me.LblMob1 = New System.Windows.Forms.Label
        Me.TbMobileNo1 = New System.Windows.Forms.TextBox
        Me.TbMobileNo2 = New System.Windows.Forms.TextBox
        Me.CmbCountry = New System.Windows.Forms.ComboBox
        Me.LblNationality = New System.Windows.Forms.Label
        Me.RibbonComboBox1 = New System.Windows.Forms.RibbonComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 487)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "loading "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblClientType)
        Me.GroupBox4.Controls.Add(Me.CmbClientType)
        Me.GroupBox4.Controls.Add(Me.TbClubMembeshipNo)
        Me.GroupBox4.Controls.Add(Me.LblNote)
        Me.GroupBox4.Controls.Add(Me.TbNote)
        Me.GroupBox4.Controls.Add(Me.lblClubmembershipNo)
        Me.GroupBox4.Location = New System.Drawing.Point(556, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 421)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'LblClientType
        '
        Me.LblClientType.AutoSize = True
        Me.LblClientType.Location = New System.Drawing.Point(6, 27)
        Me.LblClientType.Name = "LblClientType"
        Me.LblClientType.Size = New System.Drawing.Size(60, 13)
        Me.LblClientType.TabIndex = 17
        Me.LblClientType.Text = "Client Type"
        '
        'CmbClientType
        '
        Me.CmbClientType.FormattingEnabled = True
        Me.CmbClientType.Location = New System.Drawing.Point(6, 41)
        Me.CmbClientType.Name = "CmbClientType"
        Me.CmbClientType.Size = New System.Drawing.Size(232, 21)
        Me.CmbClientType.TabIndex = 16
        '
        'TbClubMembeshipNo
        '
        Me.TbClubMembeshipNo.Location = New System.Drawing.Point(6, 89)
        Me.TbClubMembeshipNo.Name = "TbClubMembeshipNo"
        Me.TbClubMembeshipNo.Size = New System.Drawing.Size(232, 20)
        Me.TbClubMembeshipNo.TabIndex = 20
        '
        'LblNote
        '
        Me.LblNote.AutoSize = True
        Me.LblNote.Location = New System.Drawing.Point(6, 134)
        Me.LblNote.Name = "LblNote"
        Me.LblNote.Size = New System.Drawing.Size(62, 13)
        Me.LblNote.TabIndex = 23
        Me.LblNote.Text = "Note If any;"
        '
        'TbNote
        '
        Me.TbNote.Location = New System.Drawing.Point(6, 148)
        Me.TbNote.Multiline = True
        Me.TbNote.Name = "TbNote"
        Me.TbNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbNote.Size = New System.Drawing.Size(232, 169)
        Me.TbNote.TabIndex = 22
        '
        'lblClubmembershipNo
        '
        Me.lblClubmembershipNo.AutoSize = True
        Me.lblClubmembershipNo.Location = New System.Drawing.Point(6, 74)
        Me.lblClubmembershipNo.Name = "lblClubmembershipNo"
        Me.lblClubmembershipNo.Size = New System.Drawing.Size(105, 13)
        Me.lblClubmembershipNo.TabIndex = 20
        Me.lblClubmembershipNo.Text = "Club Membership No"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Txtage)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.CmbOccupation)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DtpDOB)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblFirstname)
        Me.GroupBox3.Controls.Add(Me.LblMiddleName)
        Me.GroupBox3.Controls.Add(Me.RbFemale)
        Me.GroupBox3.Controls.Add(Me.RbMale)
        Me.GroupBox3.Controls.Add(Me.LblLastname)
        Me.GroupBox3.Controls.Add(Me.TbLastname)
        Me.GroupBox3.Controls.Add(Me.TbFirstname)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TbMiddleName)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 424)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'Txtage
        '
        Me.Txtage.Location = New System.Drawing.Point(19, 241)
        Me.Txtage.Name = "Txtage"
        Me.Txtage.Size = New System.Drawing.Size(58, 20)
        Me.Txtage.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Age"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(58, 502)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 18)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "*"
        '
        'CmbOccupation
        '
        Me.CmbOccupation.FormattingEnabled = True
        Me.CmbOccupation.Location = New System.Drawing.Point(18, 333)
        Me.CmbOccupation.Name = "CmbOccupation"
        Me.CmbOccupation.Size = New System.Drawing.Size(245, 21)
        Me.CmbOccupation.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 317)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Occupation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(62, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 18)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(81, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 18)
        Me.Label4.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(72, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 18)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(69, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Date Of Birth"
        '
        'DtpDOB
        '
        Me.DtpDOB.Location = New System.Drawing.Point(19, 183)
        Me.DtpDOB.Name = "DtpDOB"
        Me.DtpDOB.Size = New System.Drawing.Size(244, 20)
        Me.DtpDOB.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Gender"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(17, 27)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(54, 13)
        Me.lblFirstname.TabIndex = 3
        Me.lblFirstname.Text = "FirstName"
        '
        'LblMiddleName
        '
        Me.LblMiddleName.AutoSize = True
        Me.LblMiddleName.Location = New System.Drawing.Point(16, 70)
        Me.LblMiddleName.Name = "LblMiddleName"
        Me.LblMiddleName.Size = New System.Drawing.Size(66, 13)
        Me.LblMiddleName.TabIndex = 0
        Me.LblMiddleName.Text = "MiddleName"
        '
        'RbFemale
        '
        Me.RbFemale.AutoSize = True
        Me.RbFemale.Location = New System.Drawing.Point(165, 273)
        Me.RbFemale.Name = "RbFemale"
        Me.RbFemale.Size = New System.Drawing.Size(59, 17)
        Me.RbFemale.TabIndex = 8
        Me.RbFemale.TabStop = True
        Me.RbFemale.Text = "Female"
        Me.RbFemale.UseVisualStyleBackColor = True
        '
        'RbMale
        '
        Me.RbMale.AutoSize = True
        Me.RbMale.Location = New System.Drawing.Point(92, 273)
        Me.RbMale.Name = "RbMale"
        Me.RbMale.Size = New System.Drawing.Size(48, 17)
        Me.RbMale.TabIndex = 9
        Me.RbMale.TabStop = True
        Me.RbMale.Text = "Male"
        Me.RbMale.UseVisualStyleBackColor = True
        '
        'LblLastname
        '
        Me.LblLastname.AutoSize = True
        Me.LblLastname.Location = New System.Drawing.Point(17, 119)
        Me.LblLastname.Name = "LblLastname"
        Me.LblLastname.Size = New System.Drawing.Size(55, 13)
        Me.LblLastname.TabIndex = 4
        Me.LblLastname.Text = "LastName"
        '
        'TbLastname
        '
        Me.TbLastname.Location = New System.Drawing.Point(18, 132)
        Me.TbLastname.Name = "TbLastname"
        Me.TbLastname.Size = New System.Drawing.Size(245, 20)
        Me.TbLastname.TabIndex = 2
        '
        'TbFirstname
        '
        Me.TbFirstname.Location = New System.Drawing.Point(18, 41)
        Me.TbFirstname.Name = "TbFirstname"
        Me.TbFirstname.Size = New System.Drawing.Size(245, 20)
        Me.TbFirstname.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-65, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Label2"
        '
        'TbMiddleName
        '
        Me.TbMiddleName.Location = New System.Drawing.Point(18, 83)
        Me.TbMiddleName.Name = "TbMiddleName"
        Me.TbMiddleName.Size = New System.Drawing.Size(245, 20)
        Me.TbMiddleName.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TbResidenceNo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LblCivilID)
        Me.GroupBox2.Controls.Add(Me.TbCivilID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Lblemail)
        Me.GroupBox2.Controls.Add(Me.Tbemail)
        Me.GroupBox2.Controls.Add(Me.LblMobNo2)
        Me.GroupBox2.Controls.Add(Me.LblAddress)
        Me.GroupBox2.Controls.Add(Me.TbAddress)
        Me.GroupBox2.Controls.Add(Me.LblMob1)
        Me.GroupBox2.Controls.Add(Me.TbMobileNo1)
        Me.GroupBox2.Controls.Add(Me.TbMobileNo2)
        Me.GroupBox2.Controls.Add(Me.CmbCountry)
        Me.GroupBox2.Controls.Add(Me.LblNationality)
        Me.GroupBox2.Location = New System.Drawing.Point(295, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 424)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Mobile No 2:"
        '
        'TbResidenceNo
        '
        Me.TbResidenceNo.Location = New System.Drawing.Point(8, 184)
        Me.TbResidenceNo.Name = "TbResidenceNo"
        Me.TbResidenceNo.Size = New System.Drawing.Size(237, 20)
        Me.TbResidenceNo.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(74, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "*"
        '
        'LblCivilID
        '
        Me.LblCivilID.AutoSize = True
        Me.LblCivilID.Location = New System.Drawing.Point(5, 71)
        Me.LblCivilID.Name = "LblCivilID"
        Me.LblCivilID.Size = New System.Drawing.Size(37, 13)
        Me.LblCivilID.TabIndex = 20
        Me.LblCivilID.Text = "CivilID"
        '
        'TbCivilID
        '
        Me.TbCivilID.Location = New System.Drawing.Point(10, 283)
        Me.TbCivilID.Name = "TbCivilID"
        Me.TbCivilID.Size = New System.Drawing.Size(237, 20)
        Me.TbCivilID.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(42, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 18)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "*"
        '
        'Lblemail
        '
        Me.Lblemail.AutoSize = True
        Me.Lblemail.Location = New System.Drawing.Point(6, 268)
        Me.Lblemail.Name = "Lblemail"
        Me.Lblemail.Size = New System.Drawing.Size(72, 13)
        Me.Lblemail.TabIndex = 19
        Me.Lblemail.Text = "Email address"
        '
        'Tbemail
        '
        Me.Tbemail.Location = New System.Drawing.Point(10, 241)
        Me.Tbemail.Name = "Tbemail"
        Me.Tbemail.Size = New System.Drawing.Size(233, 20)
        Me.Tbemail.TabIndex = 18
        '
        'LblMobNo2
        '
        Me.LblMobNo2.AutoSize = True
        Me.LblMobNo2.Location = New System.Drawing.Point(8, 226)
        Me.LblMobNo2.Name = "LblMobNo2"
        Me.LblMobNo2.Size = New System.Drawing.Size(58, 13)
        Me.LblMobNo2.TabIndex = 17
        Me.LblMobNo2.Text = "Residence"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(11, 317)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(45, 13)
        Me.LblAddress.TabIndex = 16
        Me.LblAddress.Text = "Address"
        '
        'TbAddress
        '
        Me.TbAddress.Location = New System.Drawing.Point(11, 333)
        Me.TbAddress.Multiline = True
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbAddress.Size = New System.Drawing.Size(236, 77)
        Me.TbAddress.TabIndex = 15
        '
        'LblMob1
        '
        Me.LblMob1.AutoSize = True
        Me.LblMob1.Location = New System.Drawing.Point(11, 114)
        Me.LblMob1.Name = "LblMob1"
        Me.LblMob1.Size = New System.Drawing.Size(64, 13)
        Me.LblMob1.TabIndex = 2
        Me.LblMob1.Text = "Mobile No1:"
        '
        'TbMobileNo1
        '
        Me.TbMobileNo1.Location = New System.Drawing.Point(6, 84)
        Me.TbMobileNo1.Name = "TbMobileNo1"
        Me.TbMobileNo1.Size = New System.Drawing.Size(237, 20)
        Me.TbMobileNo1.TabIndex = 14
        '
        'TbMobileNo2
        '
        Me.TbMobileNo2.Location = New System.Drawing.Point(7, 131)
        Me.TbMobileNo2.Name = "TbMobileNo2"
        Me.TbMobileNo2.Size = New System.Drawing.Size(237, 20)
        Me.TbMobileNo2.TabIndex = 7
        '
        'CmbCountry
        '
        Me.CmbCountry.FormattingEnabled = True
        Me.CmbCountry.Location = New System.Drawing.Point(5, 40)
        Me.CmbCountry.Name = "CmbCountry"
        Me.CmbCountry.Size = New System.Drawing.Size(245, 21)
        Me.CmbCountry.TabIndex = 10
        '
        'LblNationality
        '
        Me.LblNationality.AutoSize = True
        Me.LblNationality.Location = New System.Drawing.Point(3, 24)
        Me.LblNationality.Name = "LblNationality"
        Me.LblNationality.Size = New System.Drawing.Size(43, 13)
        Me.LblNationality.TabIndex = 1
        Me.LblNationality.Text = "Country"
        '
        'RibbonComboBox1
        '
        Me.RibbonComboBox1.AltKey = Nothing
        Me.RibbonComboBox1.Image = Nothing
        Me.RibbonComboBox1.Tag = Nothing
        Me.RibbonComboBox1.Text = Nothing
        Me.RibbonComboBox1.TextBoxText = Nothing
        Me.RibbonComboBox1.ToolTip = Nothing
        Me.RibbonComboBox1.ToolTipImage = Nothing
        Me.RibbonComboBox1.ToolTipTitle = Nothing
        '
        'frmAddClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(830, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddClient"
        Me.Text = "frmAddClient"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TbMobileNo1 As System.Windows.Forms.TextBox
    Friend WithEvents TbLastname As System.Windows.Forms.TextBox
    Friend WithEvents TbMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents TbFirstname As System.Windows.Forms.TextBox
    Friend WithEvents CmbCountry As System.Windows.Forms.ComboBox
    Friend WithEvents RbMale As System.Windows.Forms.RadioButton
    Friend WithEvents RbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents TbMobileNo2 As System.Windows.Forms.TextBox
    Friend WithEvents LblLastname As System.Windows.Forms.Label
    Friend WithEvents lblFirstname As System.Windows.Forms.Label
    Friend WithEvents LblMob1 As System.Windows.Forms.Label
    Friend WithEvents LblNationality As System.Windows.Forms.Label
    Friend WithEvents LblMiddleName As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents TbAddress As System.Windows.Forms.TextBox
    Friend WithEvents Lblemail As System.Windows.Forms.Label
    Friend WithEvents Tbemail As System.Windows.Forms.TextBox
    Friend WithEvents LblMobNo2 As System.Windows.Forms.Label
    Friend WithEvents LblAddress As System.Windows.Forms.Label
    Friend WithEvents lblClubmembershipNo As System.Windows.Forms.Label
    Friend WithEvents TbClubMembeshipNo As System.Windows.Forms.TextBox
    Friend WithEvents LblClientType As System.Windows.Forms.Label
    Friend WithEvents CmbClientType As System.Windows.Forms.ComboBox
    Friend WithEvents LblCivilID As System.Windows.Forms.Label
    Friend WithEvents TbCivilID As System.Windows.Forms.TextBox
    Friend WithEvents LblNote As System.Windows.Forms.Label
    Friend WithEvents TbNote As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TbResidenceNo As System.Windows.Forms.TextBox
    Friend WithEvents RibbonComboBox1 As System.Windows.Forms.RibbonComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbOccupation As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
