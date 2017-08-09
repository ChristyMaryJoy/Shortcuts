Imports System.Data.SqlClient
Public Class frmAddCompany
    Inherits KOSLibraries.KOSForm
    Implements KOSLibraries.IFormInterface

    Dim objCompanyBL As New clsCompanyBL
    Dim objCommonBL As New BusinessLayer.CommonFunctionBL
    Dim intCompanyId As Integer
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
                arraylist(0) = sqlreader!fkSupplierID
                arraylist(1) = sqlreader!pkCompanyID
                arraylist(2) = SLNo
                arraylist(3) = sqlreader!SupplierName
                arraylist(3) = sqlreader!Companyname
                arraylist(3) = sqlreader!Companyname
                arraylist(4) = sqlreader!Active

                Dim objList As New ListViewItem(arraylist)
                LstwCompany.Items.Add(objList)
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
        If (TbCompany.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Company Name")
            Return False
        End If
        Return True
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
        TbCompany.Text = ""
        ChkActive.Checked = True
    End Sub

    Public Sub toClearAfterAddToList() Implements KOSLibraries.IFormInterface.toClearAfterAddToList

    End Sub

    Public Sub toClearAfterSave() Implements KOSLibraries.IFormInterface.toClearAfterSave

    End Sub

    Public Sub toExit() Implements KOSLibraries.IFormInterface.toExit

    End Sub

    Public Sub toLoad() Implements KOSLibraries.IFormInterface.toLoad
        Call toSetFormName("Add Company")

        Call FetchFormPermissionOfAUser(Me.Name, BL.PublicVariables.gintUserGroupID)

        If strIsFormEnable = "No" Then
            BL.ShowMessageBox.toShowUnauthorizedAction()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If

        toShowOrHideButtons(True, False, False, False)
        Call FetchActiveSuppliers()
        CmbSupplier.Items.Insert(0, "--SELECT--")
        If (CmbSupplier.Items.Count > 0) Then
            CmbSupplier.SelectedIndex = 0
        End If

    End Sub
    'To Fetch All Suppliers
    Public Sub FetchActiveSuppliers()

        sqlreader = objCompanyBL.FetchActiveSupplier
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
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.commonFetchBasesdOnTwoConditions("[dbo].[Service]", "fkSupplierID", CmbSupplier.SelectedValue, "Companyname", TbCompany.Text, "pkCompanyID,fkSupplierID,Companyname")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("Company" & TbCompany.Text & " is already added.Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then


            Else
                objCompanyBL.InsertCompany(CType(CmbSupplier.SelectedValue.SelectedItem, ValueAndTextBL).Value, TbCompany.Text, "Yes")
                MsgBox("Company Details are saved successfully.")

                Call toClear()
            End If
        End If
    End Sub

    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate
        If (LstwCompany.SelectedItems.Count > 0) Then

            intCompanyId = LstwCompany.SelectedItems(0).SubItems(0).Text
            CmbSupplier.SelectedValue = LstwCompany.SelectedItems(0).SubItems(1).Text
            TbCompany.Text = LstwCompany.SelectedItems(0).SubItems(4).Text
            If (LstwCompany.SelectedItems(0).SubItems(5).Text = "Yes") Then
                ChkActive.Checked = True
            Else
                ChkActive.Checked = False

            End If


            Me.Close()
        End If
    End Sub

    Private Sub frmAddCompany_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call toLoad()
    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSupplier.SelectedIndexChanged
        Call FetchAllCompanies()
    End Sub

    Public Sub FetchAllCompanies()

        sqlreader = objCompanyBL.FetchAllCompaniesBasedonSupplier(CType(CmbSupplier.SelectedValue.SelectedItem, ValueAndTextBL).Value)
        Call addToList()

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If (LstwCompany.SelectedItems.Count > 0) Then

            intCompanyId = LstwCompany.SelectedItems(0).SubItems(0).Text
            CmbSupplier.SelectedText = LstwCompany.SelectedItems(0).SubItems(2).Text
            TbCompany.Text = LstwCompany.SelectedItems(0).SubItems(3).Text
            
            If (LstwCompany.SelectedItems(0).SubItems(4).Text = "Yes") Then
                ChkActive.Checked = True
            Else
                ChkActive.Checked = False

            End If

            toShowOrHideButtons(False, True, False, False)
        End If
    End Sub
End Class