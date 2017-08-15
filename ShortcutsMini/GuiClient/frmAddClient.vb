Imports System.Data.SqlClient


Public Class frmAddClient
    Inherits KOSLibraries.KOSForm
    Implements KOSLibraries.IFormInterface


    Dim objCommonFunction As New BusinessLayer.CommonFunctionBL
    Dim objAddClientBL As New ClsAddClientBL
    Dim strClientName As String
    Dim ClubMemberShipNo As String
    Dim gender As String
    Dim intClientID As Integer
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

        If (TbLastname.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Last Name")
            TbLastname.Focus()
            Return False
        End If

        If (TbMobileNo1.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Mobile Number")
            TbMobileNo1.Focus()
            Return False
        End If

        If TbMobileNo1.Text.Count < 8 Then
            BL.ShowMessageBox.toGeneralInformation("Enter Minimum 8 Digit Phone No")
            Return False
        End If

        If (CmbCountry.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Nationality")
            CmbCountry.Focus()
            Return False
        End If

        If (CmbClientType.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Client Type")
            CmbCountry.Focus()
            Return False
        End If

        If (CmbClientType.SelectedText = "ClubMember" And TbClubMembeshipNo.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("ClubMembershipno")
            CmbCountry.Focus()
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
        TbLastname.Text = ""
        TbCivilID.Text = ""
        DtpDOB.Value = BL.PublicVariables.gdtCurrentDate
        TbMobileNo1.Text = ""
        TbMobileNo2.Text = ""
        TbAddress.Text = ""
        Tbemail.Text = ""
        TbClubMembeshipNo.Text = ""
        TbNote.Text = ""
        If (CmbClientType.SelectedIndex > 0) Then
            CmbClientType.SelectedIndex = 0
        End If

        If (CmbCountry.SelectedIndex > 0) Then
            CmbCountry.SelectedIndex = 0
        End If
        If (CmbClientType.SelectedIndex > 0) Then
            CmbClientType.SelectedIndex = 0
        End If


        TbClubMembeshipNo.Enabled = False

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
            RbMale.Checked = True
        Else
            RbFemale.Checked = True
        End If
        CmbCountry.Items.Insert(0, "--SELECT--")
        CmbClientType.Items.Insert(0, "--SELECT--")
        CmbOccupation.Items.Insert(0, "--SELECT--")
        
        Call FetchCountry()
        Call FetchOccupationType()
        Call FetchClientType()


    End Sub
    Private Sub FetchCountry()

        Dim sqlReader As SqlClient.SqlDataReader
        sqlReader = objCommonFunction.CommonFetchBasedOnSingleConditions("[Country]", "Active", "Yes", "pkCountryID,CountryName")
        If sqlReader.HasRows = True Then

            While sqlReader.Read
                CmbCountry.Items.Add(New ValueAndTextBL(sqlReader!pk_CountryID, sqlReader!vaCountryName))

            End While
            cmbCountry.SelectedIndex = 0
        End If
    End Sub
    Public Sub toPrint() Implements KOSLibraries.IFormInterface.toPrint

    End Sub

    Public Sub toRefresh() Implements KOSLibraries.IFormInterface.toRefresh

    End Sub

    Public Sub toSave() Implements KOSLibraries.IFormInterface.toSave

        Dim strClientName As String
        Dim ClubMemberShipNo As String

        strClientName = TbFirstname.Text + "" + TbMiddleName.Text + "" + TbLastname.Text
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objAddClientBL.FetchDuplicateClient(TbMobileNo1.Text, strClientName)
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The Client Information is already added.Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then


            Else

                If (RbMale.Checked = True) Then
                    gender = "Male"
                End If
                If (RbFemale.Checked = True) Then
                    gender = "Female"
                End If
                If CmbClientType.SelectedText = "ClubMember" Then
                    TbClubMembeshipNo.Enabled = True
                    ClubMemberShipNo = TbClubMembeshipNo.Text
                Else
                    TbClubMembeshipNo.Enabled = False
                    ClubMemberShipNo = ""
                End If
                strStatus = "Yes"

                objAddClientBL.ClientRegistration(TbFirstname.Text, TbMiddleName.Text, TbLastname.Text, DtpDOB.Value, gender, CType(CmbCountry.SelectedItem, ValueAndTextBL).Value, CType(CmbOccupation.SelectedItem, ValueAndTextBL).Value, CType(CmbClientType.SelectedItem, ValueAndTextBL).Value, ClubMemberShipNo, TbCivilID.Text, TbMobileNo1.Text, TbMobileNo2.Text, TbResidenceNo.Text, Tbemail.Text, TbAddress.Text, TbNote.Text, strStatus, BL.PublicVariables.gintUserId, BL.PublicVariables.gintLocationId)
                MsgBox("Client Details are Saved Successfully.")

                Call toClear()
            End If
        End If

    End Sub
    'To Fetch All Countries
    'Public Sub toFetchAllCountries()
    '    sqlreader = objCommonFunction.CommonFetchWithNoConditionBL
    '    If (sqlreader.HasRows = True) Then
    '        While (sqlreader.Read)

    '            CmbNationality.Items.Add(New ValueAndTextBL(sqlreader!intCountryID, sqlreader!vaCountryName.ToString.ToUpper))

    '        End While
    '        CmbCountry.SelectedIndex = 0
    '    End If
    '    sqlreader.Close()
    'End Sub

    Private Sub FetchOccupationType()
        Dim sqlReader As SqlClient.SqlDataReader
        sqlReader = objCommonFunction.CommonFetchBasedOnSingleConditions("[Master.OccupationType]", "Active", "Yes", "pkOccupationTypeID,OccupationType")

        If sqlReader.HasRows = True Then
            While sqlReader.Read
                'cmbOccupation.Items.Add(sqlReader("vaOccupationType"))
                'cmbOccupation.DisplayMember = "vaOccupationType"
                'cmbOccupation.ValueMember = "pk_OccupationTypeID"
                CmbOccupation.Items.Add(New ValueAndTextBL(sqlReader!pkOccupationTypeID, sqlReader!OccupationType))
                cmbOccupation.SelectedIndex = 0
            End While
        End If
    End Sub
    Private Sub FetchClientType()
        Dim sqlReader As SqlClient.SqlDataReader
        sqlReader = objCommonFunction.CommonFetchBasedOnSingleConditions("[[ClientType]", "Active", "Yes", "pkClientTypeID,ClientType")


        If sqlReader.HasRows = True Then
            While sqlReader.Read

                CmbClientType.Items.Add(New ValueAndTextBL(sqlReader!pkClientTypeID, sqlReader!ClientType))
                CmbClientType.SelectedIndex = 0
            End While
        End If
    End Sub


    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate
        If (isMandatoryFieldsCompleted() = False) Then

        Else


            If (RbMale.Checked = True) Then
                gender = "Male"
            End If
            If (RbFemale.Checked = True) Then
                gender = "Female"
            End If

            If CmbClientType.SelectedText = "ClubMember" Then
                TbClubMembeshipNo.Enabled = True
                ClubMemberShipNo = TbClubMembeshipNo.Text
            Else
                TbClubMembeshipNo.Enabled = False
                ClubMemberShipNo = ""
            End If

            objAddClientBL.UpdateClientDetails(BL.PublicVariables.gintClientId, TbFirstname.Text, TbMiddleName.Text, TbLastname.Text, DtpDOB.Value, gender, CmbCountry.SelectedValue, CmbClientType.SelectedValue, ClubMemberShipNo, TbCivilID.Text, TbMobileNo1.Text, TbMobileNo2.Text, TbResidenceNo.Text, Tbemail.Text, TbAddress.Text, TbNote.Text, strStatus, BL.PublicVariables.gintUserId, BL.PublicVariables.gintLocationId)
            MsgBox("Client Details are updated Successfully.")

            Call toClear()
        End If


    End Sub

    Private Sub TbFirstname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbFirstname.KeyPress
        BL.ValidateContol.isString(e)
    End Sub

    Private Sub TbMiddleName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbMiddleName.KeyPress
        BL.ValidateContol.isString(e)
    End Sub

    Private Sub TbLastname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbLastname.KeyPress
        BL.ValidateContol.isString(e)
    End Sub

    Private Sub TbCivilID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbCivilID.KeyPress
        BL.ValidateContol.isNumbersOnly(e)
    End Sub

    Private Sub TbMobNo1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbMobileNo1.KeyPress
        BL.ValidateContol.isNumbersOnly(e)
    End Sub

    Private Sub TbMobNo2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbMobileNo2.KeyPress
        BL.ValidateContol.isNumbersOnly(e)
    End Sub

    Private Sub Tbemail_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tbemail.KeyPress
        BL.ValidateContol.isEmailValid(Tbemail.Text)
    End Sub

    Private Sub CmbCountry_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCountry.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back Or Asc(e.KeyChar) = Keys.Space Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub CmbClientType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbClientType.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back Or Asc(e.KeyChar) = Keys.Space Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmAddClient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        vaInsertionOrUpdation = "Insertion"
        Call toLoad()
    End Sub


    Private Sub frmAddClient_SaveClick() Handles Me.SaveClick
        Call toSave()
    End Sub

    Private Sub frmAddClient_UpdateClick() Handles Me.UpdateClick
        Call toUpdate()
    End Sub
    'Bind Details to Text Box in Updation Time
    Public Sub TextBoxBind(ByVal intClientId As Integer)



        sqlreader = objAddClientBL.ViewClientInfo(intClientId)
        Call toClear()
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read())

                TbFirstname.Text = sqlreader!FirstName
                TbMiddleName.Text = sqlreader!Middlename
                TbLastname.Text = sqlreader!LastName
                If (sqlreader!Gender = "Male") Then
                    RbMale.Checked = True

                    RbFemale.Enabled = False
                End If
                If (sqlreader!Gender = "Female") Then
                    RbFemale.Checked = True

                    RbMale.Enabled = False
                End If

                CmbCountry.SelectedValue = sqlreader!fkNationalityId
                CmbClientType.SelectedValue = sqlreader!fkNationalityId
                If (sqlreader!ClubMembership <> "") Then
                    TbClubMembeshipNo.Text = sqlreader!ClubMembership
                Else

                    TbClubMembeshipNo.Text = ""
                End If

                TbCivilID.Text = sqlreader!CivilId
                TbMobileNo1.Text = sqlreader!MobileNo1
                TbMobileNo2.Text = sqlreader!Residence
                TbResidenceNo.Text = sqlreader!Office
                Tbemail.Text = sqlreader!email
                TbAddress.Text = sqlreader!Address
                TbNote.Text = sqlreader!ClientNote
                DtpDOB.Value = sqlreader!DOB
                CmbCountry.SelectedIndex = -1

            End While
        End If
    End Sub


  
    
End Class