<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddEmployee
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CmbLocation = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TbUsername = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TbPassword = New System.Windows.Forms.TextBox
        Me.TbConfirmpassword = New System.Windows.Forms.TextBox
        Me.LblUserType = New System.Windows.Forms.Label
        Me.CmbUsergroup = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TbAge = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbNationality = New System.Windows.Forms.ComboBox
        Me.LblDesignation = New System.Windows.Forms.Label
        Me.LblCivilID = New System.Windows.Forms.Label
        Me.TbCivilID = New System.Windows.Forms.TextBox
        Me.lblDOB = New System.Windows.Forms.Label
        Me.DtpDOB = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblFirstName = New System.Windows.Forms.Label
        Me.LblMiddleName = New System.Windows.Forms.Label
        Me.RdoFemale = New System.Windows.Forms.RadioButton
        Me.RdoMale = New System.Windows.Forms.RadioButton
        Me.CmbDesignation = New System.Windows.Forms.ComboBox
        Me.LblLstName = New System.Windows.Forms.Label
        Me.TbLastName = New System.Windows.Forms.TextBox
        Me.TbFirstname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TbMiddleName = New System.Windows.Forms.TextBox
        Me.LblNationality = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Lblnote = New System.Windows.Forms.Label
        Me.Tbnote = New System.Windows.Forms.TextBox
        Me.LblEmail = New System.Windows.Forms.Label
        Me.TbEmailaddress = New System.Windows.Forms.TextBox
        Me.LblMobileno2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TbAddress = New System.Windows.Forms.TextBox
        Me.lblMobileno = New System.Windows.Forms.Label
        Me.TbmobileNo1 = New System.Windows.Forms.TextBox
        Me.TbMobileNo2 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(806, 486)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Staff"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CmbLocation)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Location = New System.Drawing.Point(542, 248)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(258, 192)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "es"
        '
        'CmbLocation
        '
        Me.CmbLocation.FormattingEnabled = True
        Me.CmbLocation.Location = New System.Drawing.Point(9, 48)
        Me.CmbLocation.Name = "CmbLocation"
        Me.CmbLocation.Size = New System.Drawing.Size(240, 21)
        Me.CmbLocation.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Location Allocated"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TbUsername)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TbPassword)
        Me.GroupBox4.Controls.Add(Me.TbConfirmpassword)
        Me.GroupBox4.Controls.Add(Me.LblUserType)
        Me.GroupBox4.Controls.Add(Me.CmbUsergroup)
        Me.GroupBox4.Location = New System.Drawing.Point(541, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(259, 219)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "User Credentials"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(59, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 18)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(96, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 18)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(54, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 18)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(59, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 18)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "UserName"
        '
        'TbUsername
        '
        Me.TbUsername.Location = New System.Drawing.Point(10, 86)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(240, 20)
        Me.TbUsername.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Password"
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(9, 131)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(240, 20)
        Me.TbPassword.TabIndex = 24
        '
        'TbConfirmpassword
        '
        Me.TbConfirmpassword.Location = New System.Drawing.Point(10, 180)
        Me.TbConfirmpassword.Name = "TbConfirmpassword"
        Me.TbConfirmpassword.Size = New System.Drawing.Size(240, 20)
        Me.TbConfirmpassword.TabIndex = 23
        '
        'LblUserType
        '
        Me.LblUserType.AutoSize = True
        Me.LblUserType.Location = New System.Drawing.Point(6, 27)
        Me.LblUserType.Name = "LblUserType"
        Me.LblUserType.Size = New System.Drawing.Size(58, 13)
        Me.LblUserType.TabIndex = 17
        Me.LblUserType.Text = "UserGroup"
        '
        'CmbUsergroup
        '
        Me.CmbUsergroup.FormattingEnabled = True
        Me.CmbUsergroup.Location = New System.Drawing.Point(8, 41)
        Me.CmbUsergroup.Name = "CmbUsergroup"
        Me.CmbUsergroup.Size = New System.Drawing.Size(240, 21)
        Me.CmbUsergroup.TabIndex = 16
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TbAge)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.CmbNationality)
        Me.GroupBox3.Controls.Add(Me.LblDesignation)
        Me.GroupBox3.Controls.Add(Me.LblCivilID)
        Me.GroupBox3.Controls.Add(Me.TbCivilID)
        Me.GroupBox3.Controls.Add(Me.lblDOB)
        Me.GroupBox3.Controls.Add(Me.DtpDOB)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.LblFirstName)
        Me.GroupBox3.Controls.Add(Me.LblMiddleName)
        Me.GroupBox3.Controls.Add(Me.RdoFemale)
        Me.GroupBox3.Controls.Add(Me.RdoMale)
        Me.GroupBox3.Controls.Add(Me.CmbDesignation)
        Me.GroupBox3.Controls.Add(Me.LblLstName)
        Me.GroupBox3.Controls.Add(Me.TbLastName)
        Me.GroupBox3.Controls.Add(Me.TbFirstname)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TbMiddleName)
        Me.GroupBox3.Controls.Add(Me.LblNationality)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 451)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(70, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 18)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(62, 323)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 18)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(63, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 18)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(62, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 18)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(79, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 18)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "*"
        '
        'TbAge
        '
        Me.TbAge.Location = New System.Drawing.Point(18, 219)
        Me.TbAge.Name = "TbAge"
        Me.TbAge.Size = New System.Drawing.Size(58, 20)
        Me.TbAge.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(52, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 18)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "*"
        '
        'CmbNationality
        '
        Me.CmbNationality.FormattingEnabled = True
        Me.CmbNationality.Location = New System.Drawing.Point(13, 342)
        Me.CmbNationality.Name = "CmbNationality"
        Me.CmbNationality.Size = New System.Drawing.Size(222, 21)
        Me.CmbNationality.TabIndex = 21
        '
        'LblDesignation
        '
        Me.LblDesignation.AutoSize = True
        Me.LblDesignation.Location = New System.Drawing.Point(10, 277)
        Me.LblDesignation.Name = "LblDesignation"
        Me.LblDesignation.Size = New System.Drawing.Size(63, 13)
        Me.LblDesignation.TabIndex = 20
        Me.LblDesignation.Text = "Designation"
        '
        'LblCivilID
        '
        Me.LblCivilID.AutoSize = True
        Me.LblCivilID.Location = New System.Drawing.Point(12, 371)
        Me.LblCivilID.Name = "LblCivilID"
        Me.LblCivilID.Size = New System.Drawing.Size(37, 13)
        Me.LblCivilID.TabIndex = 20
        Me.LblCivilID.Text = "CivilID"
        '
        'TbCivilID
        '
        Me.TbCivilID.Location = New System.Drawing.Point(13, 385)
        Me.TbCivilID.Name = "TbCivilID"
        Me.TbCivilID.Size = New System.Drawing.Size(222, 20)
        Me.TbCivilID.TabIndex = 21
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(16, 161)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(68, 13)
        Me.lblDOB.TabIndex = 15
        Me.lblDOB.Text = "Date Of Birth"
        '
        'DtpDOB
        '
        Me.DtpDOB.Location = New System.Drawing.Point(17, 176)
        Me.DtpDOB.Name = "DtpDOB"
        Me.DtpDOB.Size = New System.Drawing.Size(230, 20)
        Me.DtpDOB.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Gender"
        '
        'LblFirstName
        '
        Me.LblFirstName.AutoSize = True
        Me.LblFirstName.Location = New System.Drawing.Point(13, 27)
        Me.LblFirstName.Name = "LblFirstName"
        Me.LblFirstName.Size = New System.Drawing.Size(54, 13)
        Me.LblFirstName.TabIndex = 3
        Me.LblFirstName.Text = "FirstName"
        '
        'LblMiddleName
        '
        Me.LblMiddleName.AutoSize = True
        Me.LblMiddleName.Location = New System.Drawing.Point(13, 70)
        Me.LblMiddleName.Name = "LblMiddleName"
        Me.LblMiddleName.Size = New System.Drawing.Size(66, 13)
        Me.LblMiddleName.TabIndex = 0
        Me.LblMiddleName.Text = "MiddleName"
        '
        'RdoFemale
        '
        Me.RdoFemale.AutoSize = True
        Me.RdoFemale.Location = New System.Drawing.Point(159, 249)
        Me.RdoFemale.Name = "RdoFemale"
        Me.RdoFemale.Size = New System.Drawing.Size(59, 17)
        Me.RdoFemale.TabIndex = 8
        Me.RdoFemale.TabStop = True
        Me.RdoFemale.Text = "Female"
        Me.RdoFemale.UseVisualStyleBackColor = True
        '
        'RdoMale
        '
        Me.RdoMale.AutoSize = True
        Me.RdoMale.Location = New System.Drawing.Point(83, 248)
        Me.RdoMale.Name = "RdoMale"
        Me.RdoMale.Size = New System.Drawing.Size(48, 17)
        Me.RdoMale.TabIndex = 9
        Me.RdoMale.TabStop = True
        Me.RdoMale.Text = "Male"
        Me.RdoMale.UseVisualStyleBackColor = True
        '
        'CmbDesignation
        '
        Me.CmbDesignation.FormattingEnabled = True
        Me.CmbDesignation.Location = New System.Drawing.Point(13, 292)
        Me.CmbDesignation.Name = "CmbDesignation"
        Me.CmbDesignation.Size = New System.Drawing.Size(222, 21)
        Me.CmbDesignation.TabIndex = 10
        '
        'LblLstName
        '
        Me.LblLstName.AutoSize = True
        Me.LblLstName.Location = New System.Drawing.Point(14, 116)
        Me.LblLstName.Name = "LblLstName"
        Me.LblLstName.Size = New System.Drawing.Size(55, 13)
        Me.LblLstName.TabIndex = 4
        Me.LblLstName.Text = "LastName"
        '
        'TbLastName
        '
        Me.TbLastName.Location = New System.Drawing.Point(16, 130)
        Me.TbLastName.Name = "TbLastName"
        Me.TbLastName.Size = New System.Drawing.Size(231, 20)
        Me.TbLastName.TabIndex = 13
        '
        'TbFirstname
        '
        Me.TbFirstname.Location = New System.Drawing.Point(16, 41)
        Me.TbFirstname.Name = "TbFirstname"
        Me.TbFirstname.Size = New System.Drawing.Size(231, 20)
        Me.TbFirstname.TabIndex = 11
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
        Me.TbMiddleName.Location = New System.Drawing.Point(15, 84)
        Me.TbMiddleName.Name = "TbMiddleName"
        Me.TbMiddleName.Size = New System.Drawing.Size(231, 20)
        Me.TbMiddleName.TabIndex = 12
        '
        'LblNationality
        '
        Me.LblNationality.AutoSize = True
        Me.LblNationality.Location = New System.Drawing.Point(10, 327)
        Me.LblNationality.Name = "LblNationality"
        Me.LblNationality.Size = New System.Drawing.Size(56, 13)
        Me.LblNationality.TabIndex = 1
        Me.LblNationality.Text = "Nationality"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Lblnote)
        Me.GroupBox2.Controls.Add(Me.Tbnote)
        Me.GroupBox2.Controls.Add(Me.LblEmail)
        Me.GroupBox2.Controls.Add(Me.TbEmailaddress)
        Me.GroupBox2.Controls.Add(Me.LblMobileno2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TbAddress)
        Me.GroupBox2.Controls.Add(Me.lblMobileno)
        Me.GroupBox2.Controls.Add(Me.TbmobileNo1)
        Me.GroupBox2.Controls.Add(Me.TbMobileNo2)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 451)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(71, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 18)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "*"
        '
        'Lblnote
        '
        Me.Lblnote.AutoSize = True
        Me.Lblnote.Location = New System.Drawing.Point(9, 275)
        Me.Lblnote.Name = "Lblnote"
        Me.Lblnote.Size = New System.Drawing.Size(62, 13)
        Me.Lblnote.TabIndex = 23
        Me.Lblnote.Text = "Note If any;"
        '
        'Tbnote
        '
        Me.Tbnote.Location = New System.Drawing.Point(10, 291)
        Me.Tbnote.Multiline = True
        Me.Tbnote.Name = "Tbnote"
        Me.Tbnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tbnote.Size = New System.Drawing.Size(243, 93)
        Me.Tbnote.TabIndex = 22
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(12, 116)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(72, 13)
        Me.LblEmail.TabIndex = 19
        Me.LblEmail.Text = "Email address"
        '
        'TbEmailaddress
        '
        Me.TbEmailaddress.Location = New System.Drawing.Point(12, 131)
        Me.TbEmailaddress.Name = "TbEmailaddress"
        Me.TbEmailaddress.Size = New System.Drawing.Size(245, 20)
        Me.TbEmailaddress.TabIndex = 18
        '
        'LblMobileno2
        '
        Me.LblMobileno2.AutoSize = True
        Me.LblMobileno2.Location = New System.Drawing.Point(12, 70)
        Me.LblMobileno2.Name = "LblMobileno2"
        Me.LblMobileno2.Size = New System.Drawing.Size(64, 13)
        Me.LblMobileno2.TabIndex = 17
        Me.LblMobileno2.Text = "Mobile No2:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Address"
        '
        'TbAddress
        '
        Me.TbAddress.Location = New System.Drawing.Point(10, 176)
        Me.TbAddress.Multiline = True
        Me.TbAddress.Name = "TbAddress"
        Me.TbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TbAddress.Size = New System.Drawing.Size(245, 72)
        Me.TbAddress.TabIndex = 15
        '
        'lblMobileno
        '
        Me.lblMobileno.AutoSize = True
        Me.lblMobileno.Location = New System.Drawing.Point(12, 27)
        Me.lblMobileno.Name = "lblMobileno"
        Me.lblMobileno.Size = New System.Drawing.Size(64, 13)
        Me.lblMobileno.TabIndex = 2
        Me.lblMobileno.Text = "Mobile No1:"
        '
        'TbmobileNo1
        '
        Me.TbmobileNo1.Location = New System.Drawing.Point(13, 40)
        Me.TbmobileNo1.Name = "TbmobileNo1"
        Me.TbmobileNo1.Size = New System.Drawing.Size(244, 20)
        Me.TbmobileNo1.TabIndex = 14
        '
        'TbMobileNo2
        '
        Me.TbMobileNo2.Location = New System.Drawing.Point(12, 83)
        Me.TbMobileNo2.Name = "TbMobileNo2"
        Me.TbMobileNo2.Size = New System.Drawing.Size(242, 20)
        Me.TbMobileNo2.TabIndex = 7
        '
        'FrmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 560)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAddEmployee"
        Me.Text = "FrmAddStaff"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblDesignation As System.Windows.Forms.Label
    Friend WithEvents LblUserType As System.Windows.Forms.Label
    Friend WithEvents CmbUsergroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents DtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblFirstName As System.Windows.Forms.Label
    Friend WithEvents LblMiddleName As System.Windows.Forms.Label
    Friend WithEvents RdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents CmbDesignation As System.Windows.Forms.ComboBox
    Friend WithEvents LblLstName As System.Windows.Forms.Label
    Friend WithEvents TbLastName As System.Windows.Forms.TextBox
    Friend WithEvents TbFirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents LblNationality As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lblnote As System.Windows.Forms.Label
    Friend WithEvents Tbnote As System.Windows.Forms.TextBox
    Friend WithEvents LblCivilID As System.Windows.Forms.Label
    Friend WithEvents TbCivilID As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TbEmailaddress As System.Windows.Forms.TextBox
    Friend WithEvents LblMobileno2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TbAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblMobileno As System.Windows.Forms.Label
    Friend WithEvents TbmobileNo1 As System.Windows.Forms.TextBox
    Friend WithEvents TbMobileNo2 As System.Windows.Forms.TextBox
    Friend WithEvents CmbNationality As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TbPassword As System.Windows.Forms.TextBox
    Friend WithEvents TbConfirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbAge As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
End Class
