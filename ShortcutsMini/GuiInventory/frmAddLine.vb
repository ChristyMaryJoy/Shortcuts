Imports System.Data.SqlClient


Public Class frmAddLine
    Inherits KOSLibraries.KOSForm
    Implements KOSLibraries.IFormInterface

    Dim objLineBL As New clsLineBL
    Dim objCommonBL As New BusinessLayer.CommonFunctionBL
    Dim intLineId As Integer
    Dim status As Integer
    Dim sqlreader As SqlDataReader
#Region "Form Permission Variables"
    '  Form Permission Variables Start Here
    Dim objPermissionsBL As New clsPermissionBL
    Dim strIsFormEnable As String = "No"
    Dim strIsSaveEnable As String = "No"
    Dim strIsUpdateEnable As String = "No"
    Dim strIsPrintEnable As String = "No"
    Dim strIsSearchEnable As String = "No"
    '  Form Permission Variables  Ends here
#End Region
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
        If (sqlreader.HasRows = True) Then
            Dim SLNo As Integer = 1
            Dim arraylist(15) As String
            While (sqlreader.Read)

                arraylist(0) = sqlreader!fkCompanyId
                arraylist(1) = sqlreader!pkLineID
                arraylist(2) = SLNo
                arraylist(3) = sqlreader!SupplierName
                arraylist(4) = sqlreader!Companyname
                arraylist(5) = sqlreader!LineName
                arraylist(6) = sqlreader!Active

                Dim objList As New ListViewItem(arraylist)
                LstwLine.Items.Add(objList)
                SLNo += 1
            End While
        Else
            BL.ShowMessageBox.toGeneralInformation("Details Not Found")
        End If
        sqlreader.Close()
    End Sub

    Public Sub deleteList() Implements KOSLibraries.IFormInterface.deleteList

    End Sub

    Public Sub editList() Implements KOSLibraries.IFormInterface.editList

    End Sub

    Public Function isMandatoryFieldsCompleted() As Boolean Implements KOSLibraries.IFormInterface.isMandatoryFieldsCompleted
        If (cmbSupplier.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Supplier")
            cmbSupplier.Focus()
            Return False
        End If
        If (CmbCompany.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Company")
            CmbCompany.Focus()
            Return False
        End If
        If (TbLine.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Line")
            TbLine.Focus()
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

    End Sub

    Public Sub toClearAfterAddToList() Implements KOSLibraries.IFormInterface.toClearAfterAddToList

    End Sub

    Public Sub toClearAfterSave() Implements KOSLibraries.IFormInterface.toClearAfterSave

    End Sub

    Public Sub toExit() Implements KOSLibraries.IFormInterface.toExit

    End Sub

    Public Sub toLoad() Implements KOSLibraries.IFormInterface.toLoad
        Call toSetFormName("Add Line")

        Call FetchFormPermissionOfAUser(Me.Name, BL.PublicVariables.gintUserGroupID)

        If strIsFormEnable = "No" Then
            BL.ShowMessageBox.toShowUnauthorizedAction()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If

        toShowOrHideButtons(True, False, False, False)
        Call FetchActiveSuppliers()
        cmbSupplier.Items.Insert(0, "--SELECT--")
        CmbCompany.Items.Insert(0, "--SELECT--")
        If (cmbSupplier.Items.Count > 0) Then
            cmbSupplier.SelectedIndex = 0
        End If

        If (CmbCompany.Items.Count > 0) Then
            cmbSupplier.SelectedIndex = 0
        End If
    End Sub
    'To Fetch All Suppliers
    Public Sub FetchActiveSuppliers()

        sqlreader = objLineBL.FetchActiveSupplier
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                CmbSupplier.Items.Add(New ValueAndTextBL(sqlreader!pkSupplierID, sqlreader!SupplierName.ToString.ToUpper))

            End While
            CmbSupplier.SelectedIndex = 0
        End If
        sqlreader.Close()
    End Sub
    Public Sub toPrint() Implements KOSLibraries.IFormInterface.toPrint

    End Sub

    Public Sub toRefresh() Implements KOSLibraries.IFormInterface.toRefresh

    End Sub

    Public Sub toSave() Implements KOSLibraries.IFormInterface.toSave
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.commonFetchBasesdOnTwoConditions("[dbo].[Line]", "fkCompanyId", (CType(CmbCompany.SelectedItem, ValueAndTextBL).Value), "LineName", TbLine.Text, "pkLineID,fkCompanyId,LineName")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The Line is already added under this Company.Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then

            Else
                objLineBL.InsertLine(CType(CmbCompany.SelectedItem, ValueAndTextBL).Value, TbLine.Text, "Yes")
                MsgBox("Line for" & CType(CmbCompany.SelectedItem, ValueAndTextBL).Value & " are Saved Successfully.")
                Call toClear()

            End If
        End If
    End Sub

    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.commonFetchBasesdOnTwoConditions("[dbo].[Line]", "fkCompanyId", (CType(CmbCompany.SelectedItem, ValueAndTextBL).Value), "LineName", TbLine.Text, "pkLineID,fkCompanyId,LineName")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The Line is already added under this Company.Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then

            Else
                objLineBL.UpdateLine(CType(CmbCompany.SelectedItem, ValueAndTextBL).Value, TbLine.Text, "Yes")
                MsgBox("Line for" & CType(CmbCompany.SelectedItem, ValueAndTextBL).Value & " are updated Successfully.")
                Call toClear()


            End If
        End If
        toShowOrHideButtons(True, False, False, False)
    End Sub


    Private Sub cmbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSupplier.SelectedIndexChanged
        Call FetchAllCompanies()
        Call FetchAllLinesBasedonSupplier()

    End Sub
    'To Fetch All Lines Based On Suppliers
    Public Sub FetchAllLinesBasedonSupplier()
        sqlreader = objLineBL.FetchAllLinesBasedonSuppliers(CType(cmbSupplier.SelectedValue.SelectedItem, ValueAndTextBL).Value)
        addToList()
    End Sub
    Public Sub FetchAllCompanies()

        sqlreader = objLineBL.FetchActiveCompaniesBasedonSupplier(CType(cmbSupplier.SelectedValue.SelectedItem, ValueAndTextBL).Value)
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                CmbCompany.Items.Add(New ValueAndTextBL(sqlreader!pkCompanyID, sqlreader!Companyname.ToString.ToUpper))

            End While
            CmbCompany.SelectedIndex = 0
        End If
        sqlreader.Close()

    End Sub

    Private Sub CmbCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCompany.SelectedIndexChanged
        FetchAllLinesBasedonCompanies()
    End Sub
    Public Sub FetchAllLinesBasedonCompanies()

        sqlreader = objLineBL.FetchAllLinesBasedonCompanies(CType(CmbCompany.SelectedValue.SelectedItem, ValueAndTextBL).Value)
        Call addToList()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If (LstwLine.SelectedItems.Count > 0) Then

            intLineId = LstwLine.SelectedItems(0).SubItems(1).Text
            cmbSupplier.SelectedValue = Convert.ToInt32(LstwLine.SelectedItems(0).SubItems(0).Text)
            CmbCompany.SelectedValue = Convert.ToInt32(LstwLine.SelectedItems(0).SubItems(1).Text)
            TbLine.Text = LstwLine.SelectedItems(0).SubItems(5).Text
            

            If (LstwLine.SelectedItems(0).SubItems(11).Text = "Yes") Then
                ChkActive.Checked = True
            Else
                ChkActive.Checked = False

            End If

            toShowOrHideButtons(False, True, False, False)
        End If
    End Sub

    Private Sub frmAddLine_ExitClick() Handles Me.ExitClick

    End Sub

    
    Private Sub frmAddLine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call toLoad()
    End Sub

    Private Sub frmAddLine_SaveClick() Handles Me.SaveClick
        Call toSave()
    End Sub

    Private Sub frmAddLine_UpdateClick() Handles Me.UpdateClick
        Call toUpdate()
    End Sub
End Class