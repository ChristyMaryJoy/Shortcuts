Imports System.Data.SqlClient
Public Class FrmAddEmployee
    Inherits KOSLibraries.KOSForm

    Implements KOSLibraries.IFormInterface
    Dim objCommonFunction As New BusinessLayer.CommonFunctionBL
    Dim objAddEmpBL As New ClsAddEmployeeBL
    Dim strEmployeeName As String
    Dim ClubMemberShipNo As String
    Dim gender As String
    Dim intEmpID As Integer
    Dim strStatus As String
    Public Shared vaInsertionOrUpdation As String 'This variable is used for select the Insertion/Updation

    Dim sqlreader As SqlDataReader
    '  Form Permission Variables Start Here
    Dim objPermissionsBL As New clsPermissionBL

    Dim strIsFormEnable As String = "No"
    Dim strIsSaveEnable As String = "No"
    Dim strIsUpdateEnable As String = "No"
    Dim strIsPrintEnable As String = "No"
    Dim strIsSearchEnable As String = "No"
    Dim dtableLocation As New DataTable("Locations")
    Private Sub FetchFormPermissionOfAUser(ByVal strFormName As String, ByVal intUserGroupID As Integer)

        Dim sqlReader As SqlClient.SqlDataReader = Nothing

        sqlReader = objPermissionsBL.FetchFormPermissionOfAUser(strFormName, intUserGroupID)

        If sqlReader.HasRows = True Then

            While sqlReader.Read

                strIsFormEnable = sqlReader!vaIsFormEnable
                strIsSaveEnable = sqlReader!vaIsSaveEnable
                strIsUpdateEnable = sqlReader!vaIsUpdateEnable
                strIsPrintEnable = sqlReader!vaIsPrintEnable
                strIsSearchEnable = sqlReader!vaIsSearchEnable

            End While
        End If
        sqlReader.Close()

    End Sub
    Public Sub addToList() Implements KOSLibraries.IFormInterface.addToList

    End Sub

    Public Sub deleteList() Implements KOSLibraries.IFormInterface.deleteList

    End Sub

    Public Sub editList() Implements KOSLibraries.IFormInterface.editList

    End Sub

    Public Function isMandatoryFieldsCompleted() As Boolean Implements KOSLibraries.IFormInterface.isMandatoryFieldsCompleted
        If (TbFirstname.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("First Name")
            TbFirstname.Focus()
            Return False
        End If

        If (TbLastName.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Last Name")
            TbLastName.Focus()
            Return False
        End If

        If (TbmobileNo1.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Mobile Number")
            TbmobileNo1.Focus()
            Return False
        End If

        If TbmobileNo1.Text.Count < 8 Then
            BL.ShowMessageBox.toGeneralInformation("Enter Minimum 8 Digit Phone No")
            Return False
        End If




        If (DtpDOB.Value > BL.PublicVariables.gdtCurrentDate) Then
            BL.ShowMessageBox.toGeneralInformation("Dateof Birth should be less than todays date")
            DtpDOB.Focus()
            Return False
        End If

        If (CmbNationality.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Nationality")
            CmbNationality.Focus()
            Return False
        End If


        If (CmbDesignation.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Designation")
            CmbDesignation.Focus()
            Return False
        End If

        If (CmbUsergroup.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("UserGroup")
            CmbUsergroup.Focus()
            Return False
        End If

        If (TbUsername.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Username")
            TbUsername.Focus()
            Return False
        End If

        If (TbPassword.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Password")
            TbPassword.Focus()
            Return False
        End If

        If (TbConfirmpassword.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Confirm Password")
            TbConfirmpassword.Focus()
            Return False
        End If





    End Function

    Public Sub toCheckComboBoxPropertiesSet() Implements KOSLibraries.IFormInterface.toCheckComboBoxPropertiesSet

    End Sub

    Public Sub toCheckDateTimePickerPropertiesSet() Implements KOSLibraries.IFormInterface.toCheckDateTimePickerPropertiesSet

    End Sub

    Public Sub toCheckFormPropertiesSet() Implements KOSLibraries.IFormInterface.toCheckFormPropertiesSet

    End Sub

    Public Sub toCheckGroupBoxPropertiesSet() Implements KOSLibraries.IFormInterface.toCheckGroupBoxPropertiesSet

    End Sub

    Public Sub toCheckListViewPropertiesSet() Implements KOSLibraries.IFormInterface.toCheckListViewPropertiesSet

    End Sub

    Public Sub toCheckOtherProcessWorkingOnExit() Implements KOSLibraries.IFormInterface.toCheckOtherProcessWorkingOnExit

    End Sub

    Public Sub toCheckTextBoxPropertiesSet() Implements KOSLibraries.IFormInterface.toCheckTextBoxPropertiesSet

    End Sub

    Public Sub toCheckWhetherItemAvailable() Implements KOSLibraries.IFormInterface.toCheckWhetherItemAvailable

    End Sub

    Public Sub toCheckWhetherNumeric(ByVal e As System.Windows.Forms.KeyPressEventArgs) Implements KOSLibraries.IFormInterface.toCheckWhetherNumeric

    End Sub

    Public Sub toClear() Implements KOSLibraries.IFormInterface.toClear
        TbFirstname.Text = ""
        TbMiddleName.Text = ""
        TbLastName.Text = ""
        TbCivilID.Text = ""
        DtpDOB.Value = BL.PublicVariables.gdtCurrentDate
        TbmobileNo1.Text = ""
        TbMobileNo2.Text = ""
        TbAddress.Text = ""
        TbEmailaddress.Text = ""
        TbUsername.Text = ""
        Tbnote.Text = ""

        If (CmbDesignation.SelectedIndex > 0) Then
            CmbDesignation.SelectedIndex = 0
        End If

        If (CmbNationality.SelectedIndex > 0) Then
            CmbNationality.SelectedIndex = 0
        End If
        If (CmbUsergroup.SelectedIndex > 0) Then
            CmbUsergroup.SelectedIndex = 0
        End If



    End Sub

    Public Sub toClearAfterAddToList() Implements KOSLibraries.IFormInterface.toClearAfterAddToList

    End Sub

    Public Sub toClearAfterSave() Implements KOSLibraries.IFormInterface.toClearAfterSave

    End Sub

    Public Sub toExit() Implements KOSLibraries.IFormInterface.toExit

    End Sub

    Public Sub toLoad() Implements KOSLibraries.IFormInterface.toLoad

        Call FetchFormPermissionOfAUser(Me.Name, BL.PublicVariables.gintUserGroupID)

        If strIsFormEnable = "No" Then
            BL.ShowMessageBox.toShowUnauthorizedAction()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If


        If (vaInsertionOrUpdation = "Insertion") Then

            toShowOrHideButtons(True, False, False, False)

        Else
            toShowOrHideButtons(False, True, False, False)

        End If


        DtpDOB.MinDate = BL.PublicVariables.gdtCurrentDate.AddYears(-100)

        If (BL.PublicVariables.gintLocationId = 3) Then
            RdoMale.Checked = True
        Else
            RdoFemale.Checked = True
        End If
        CmbUsergroup.Items.Insert(0, "--SELECT--")
        CmbNationality.Items.Insert(0, "--SELECT--")
        CmbDesignation.Items.Insert(0, "--SELECT--")

        Call FetchCountry()
        Call FetchDesignation()
        Call FetchUserGroup()

    End Sub
    Private Sub FetchDesignation()
        Dim sqlReader As SqlClient.SqlDataReader
        sqlReader = objCommonFunction.CommonFetchBasedOnSingleConditions("[Master.Designation]", "Active", "Yes", "pkDesignationID,Designation")

        If sqlReader.HasRows = True Then
            While sqlReader.Read
                'cmbOccupation.Items.Add(sqlReader("vaOccupationType"))
                'cmbOccupation.DisplayMember = "vaOccupationType"
                'cmbOccupation.ValueMember = "pk_OccupationTypeID"
                CmbDesignation.Items.Add(New ValueAndTextBL(sqlReader!pkDesignationID, sqlReader!Designation))
                CmbDesignation.SelectedIndex = 0
            End While
        End If
    End Sub
    Private Sub FetchUserGroup()
        Dim sqlReader As SqlClient.SqlDataReader
        sqlReader = objCommonFunction.CommonFetchBasedOnSingleConditions("[Master.UserGroup]", "Active", "Yes", "pkUserGroupId,vaUserGroup")


        If sqlReader.HasRows = True Then
            While sqlReader.Read

                CmbUsergroup.Items.Add(New ValueAndTextBL(sqlReader!pkUserGroupId, sqlReader!vaUserGroup))
                CmbUsergroup.SelectedIndex = 0
            End While
        End If
    End Sub
    Private Sub FetchCountry()

        Dim sqlReader As SqlClient.SqlDataReader
        sqlReader = objCommonFunction.CommonFetchBasedOnSingleConditions("[Country]", "Active", "Yes", "pkCountryID,CountryName")
        If sqlReader.HasRows = True Then

            While sqlReader.Read
                CmbNationality.Items.Add(New ValueAndTextBL(sqlReader!pk_CountryID, sqlReader!vaCountryName))

            End While
            CmbNationality.SelectedIndex = 0
        End If
    End Sub
    Public Sub toPrint() Implements KOSLibraries.IFormInterface.toPrint

    End Sub

    Public Sub toRefresh() Implements KOSLibraries.IFormInterface.toRefresh

    End Sub

    Public Sub toSave() Implements KOSLibraries.IFormInterface.toSave


        strEmployeeName = TbFirstname.Text + "" + TbMiddleName.Text + "" + TbLastName.Text
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objAddEmpBL.FetchDuplicateEmployee(CType(CmbUsergroup.SelectedItem, ValueAndTextBL).Value, strEmployeeName)
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The Employee is already added under the same usergroup.Please Check and try with another usergroup")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then


            Else

                If (RdoMale.Checked = True) Then
                    gender = "Male"
                End If
                If (RdoFemale.Checked = True) Then
                    gender = "Female"
                End If

                strStatus = "Yes"

                objAddEmpBL.EmployeeRegistration(TbFirstname.Text, TbMiddleName.Text, TbLastName.Text, DtpDOB.Value, Convert.ToInt32(TbAge.Text), gender, CType(CmbDesignation.SelectedItem, ValueAndTextBL).Value, CType(CmbNationality.SelectedItem, ValueAndTextBL).Value, TbCivilID.Text, TbmobileNo1.Text, TbMobileNo2.Text, TbEmailaddress.Text, TbAddress.Text, Tbnote.Text, strStatus, BL.PublicVariables.gintUserId, CType(CmbUsergroup.SelectedItem, ValueAndTextBL).Value, TbUsername.Text, TbPassword.Text, BL.PublicVariables.gintLocationId)
                MsgBox("Employee Details are Saved Successfully.")

                Call toClear()
            End If
        End If

    End Sub

    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmAddStaff_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtableLocation.Columns.Add(New DataColumn("intLocation"))
    End Sub

    Private Sub FrmAddStaff_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub FrmAddStaff_SaveClick() Handles Me.SaveClick
        Call toSave()
    End Sub
End Class