
Imports System.Data.SqlClient
Public Class frmAddServiceCategory

    Inherits KOSLibraries.KOSForm

    Implements KOSLibraries.IFormInterface
    Dim objAddServiceCategoryBL As New clsServiceCategoryBL
    Dim objCommonBL As New BusinessLayer.CommonFunctionBL
    Dim intCategoryId As Integer
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
                arraylist(0) = sqlreader!pkServiceCategoryID
                arraylist(1) = SLNo
                arraylist(2) = sqlreader!CategoryName
                arraylist(3) = sqlreader!Active
                

                Dim objList As New ListViewItem(arraylist)
                LstwCategory.Items.Add(objList)
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
        If (TbCategory.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Category Name")
            TbCategory.Focus()
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
        TbCategory.Text = ""
        ChkActive.Checked = True
    End Sub

    Public Sub toClearAfterAddToList() Implements KOSLibraries.IFormInterface.toClearAfterAddToList

    End Sub

    Public Sub toClearAfterSave() Implements KOSLibraries.IFormInterface.toClearAfterSave

    End Sub

    Public Sub toExit() Implements KOSLibraries.IFormInterface.toExit

    End Sub

    Public Sub toLoad() Implements KOSLibraries.IFormInterface.toLoad
        Call toSetFormName("Add Service Category")

        Call FetchFormPermissionOfAUser(Me.Name, BL.PublicVariables.gintUserGroupID)

        If strIsFormEnable = "No" Then
            BL.ShowMessageBox.toShowUnauthorizedAction()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If

        toShowOrHideButtons(True, False, False, False)
        LstwCategory.Items.Clear()
        sqlreader = objCommonBL.CommonFetchAllDetails("dbo.ServiceCategory", "pkServiceCategoryID,CategoryName,Active")
        Call addToList()


    End Sub

    Public Sub toPrint() Implements KOSLibraries.IFormInterface.toPrint

    End Sub

    Public Sub toRefresh() Implements KOSLibraries.IFormInterface.toRefresh

    End Sub

    Public Sub toSave() Implements KOSLibraries.IFormInterface.toSave

        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.CommonFetchBasedOnSingleConditions("dbo.ServiceCategory", "CategoryName", TbCategory.Text, "pkServiceCategoryID,CategoryName,Active")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The Category is already added.Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then


            Else
                objAddServiceCategoryBL.InsertServiceCategory(TbCategory.Text, "Yes")
                MsgBox("Category for Service are Saved Successfully.")

                Call toClear()
            End If
        End If

    End Sub

    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate

        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.CommonFetchBasedOnSingleConditions("dbo.ServiceCategory", "CategoryName", TbCategory.Text, "pkServiceCategoryID,CategoryName,Active")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The Category is already added.Please Check")
            Exit Sub
        Else


            If (isMandatoryFieldsCompleted() = False) Then


            Else

                If (ChkActive.Checked = True) Then
                    status = "Yes"
                Else
                    status = "No"
                End If
                objAddServiceCategoryBL.UpdateServiceCategory(intCategoryId, TbCategory.Text, status)
                MsgBox("Category are updated Successfully.")

                Call toClear()
            End If
        End If

    End Sub

    Private Sub frmAddServiceCategory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call toLoad()

    End Sub

    Private Sub frmAddServiceCategory_SaveClick() Handles Me.SaveClick
        Call toSave()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If (LstwCategory.SelectedItems.Count > 0) Then

            intCategoryId = LstwCategory.SelectedItems(0).SubItems(0).Text
            TbCategory.Text = LstwCategory.SelectedItems(0).SubItems(2).Text
            If (LstwCategory.SelectedItems(0).SubItems(3).Text = "Yes") Then
                ChkActive.Checked = True
            Else
                ChkActive.Checked = False

            End If


            Me.Close()
        End If
    End Sub
End Class