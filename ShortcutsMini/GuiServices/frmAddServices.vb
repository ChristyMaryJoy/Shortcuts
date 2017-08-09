
Imports System.Data.SqlClient

Public Class frmAddServices

    Inherits KOSLibraries.KOSForm

    Implements KOSLibraries.IFormInterface

    Dim objAddServiceBL As New clsServiceBL
    Dim objCommonBL As New BusinessLayer.CommonFunctionBL
    Dim intServiceId As Integer
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
                arraylist(0) = sqlreader!pkServiceID
                arraylist(1) = sqlreader!fkServiceCategoryId
                arraylist(2) = SLNo
                arraylist(3) = sqlreader!CategoryName
                arraylist(4) = sqlreader!ServiceName
                arraylist(5) = sqlreader!Servicecharge
                arraylist(6) = sqlreader!ServiceDuration
                arraylist(7) = sqlreader!Series
                arraylist(8) = sqlreader!Active


                Dim objList As New ListViewItem(arraylist)
                LstServices.Items.Add(objList)
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
        If (CmbCategory.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Category")
            CmbCategory.Focus()
            Return False
        End If
        If (TbService.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Service Name")
            TbService.Focus()
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
        CmbCategory.Items.Insert(0, "--SELECT--")
        TbService.Text = ""
        ChkActive.Checked = True
    End Sub

    Public Sub toClearAfterAddToList() Implements KOSLibraries.IFormInterface.toClearAfterAddToList

    End Sub

    Public Sub toClearAfterSave() Implements KOSLibraries.IFormInterface.toClearAfterSave

    End Sub

    Public Sub toExit() Implements KOSLibraries.IFormInterface.toExit

    End Sub

    Public Sub toLoad() Implements KOSLibraries.IFormInterface.toLoad
        Call toSetFormName("Add Services")

        Call FetchFormPermissionOfAUser(Me.Name, BL.PublicVariables.gintUserGroupID)

        If strIsFormEnable = "No" Then
            BL.ShowMessageBox.toShowUnauthorizedAction()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If

        toShowOrHideButtons(True, False, False, False)
        Call toFetchCategory()
        CmbCategory.Items.Insert(0, "--SELECT--")
        If (CmbCategory.Items.Count > 0) Then
            CmbCategory.SelectedIndex = 0
        End If

    End Sub

    Public Sub toPrint() Implements KOSLibraries.IFormInterface.toPrint

    End Sub

    Public Sub toRefresh() Implements KOSLibraries.IFormInterface.toRefresh

    End Sub
    'To Fetch All Categories
    Public Sub toFetchCategory()
        sqlreader = objAddServiceBL.FetchActiveCategory
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                CmbCategory.Items.Add(New ValueAndTextBL(sqlreader!pkServiceCategoryID, sqlreader!CategoryName.ToString.ToUpper))

            End While
            CmbCategory.SelectedIndex = 0
        End If
        sqlreader.Close()
    End Sub
    Public Sub toSave() Implements KOSLibraries.IFormInterface.toSave
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.commonFetchBasesdOnTwoConditions("[dbo].[Service]", "fkServiceCategoryId", CmbCategory.SelectedValue, "ServiceName", TbService.Text, "pkServiceID,fkServiceCategoryId,ServiceName")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The service is already added under this category .Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then


            Else
                objAddServiceBL.InsertService(CType(CmbCategory.SelectedValue.SelectedItem, ValueAndTextBL).Value, TbService.Text, Convert.ToInt32(TbServiceCharge.Text), (NupDuration.Value), "Yes")
                MsgBox("Service are Saved Successfully.")
                Call toClear()

            End If
        End If
    End Sub

    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.commonFetchBasesdOnTwoConditions("[dbo].[Service]", "fkServiceCategoryId", CmbCategory.SelectedValue, "ServiceName", TbService.Text, "pkServiceID,fkServiceCategoryId,ServiceName")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The service is already added under this category .Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then


            Else
                objAddServiceBL.UpdateService(intServiceId, TbService.Text, Convert.ToInt32(TbServiceCharge.Text), (NupDuration.Value), "Yes")
                MsgBox("Service are updated Successfully.")
                Call toClear()

            End If
        End If
    End Sub


    Private Sub AddToSeriesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToSeriesToolStripMenuItem.Click
        If ((LstServices.SelectedItems(0).SubItems(8).Text) = "Yes") Then

            frmAddSeriesService.MdiParent = Me.MdiParent
            frmAddSeriesService.Show()
            frmAddSeriesService.toLoad()
            frmAddSeriesService.ComboBoxBind(Convert.ToInt32(LstServices.SelectedItems(0).SubItems(0).Text), Convert.ToInt32(LstServices.SelectedItems(0).SubItems(1).Text))
        Else
           
            If (MsgBox("Do you want to create series for this inactive service " & (LstServices.SelectedItems(0).SubItems(4).Text) & "?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then

            Else

                frmAddSeriesService.MdiParent = Me.MdiParent
                frmAddSeriesService.Show()
                frmAddSeriesService.toLoad()
                frmAddSeriesService.ComboBoxBind(Convert.ToInt32(LstServices.SelectedItems(0).SubItems(0).Text), Convert.ToInt32(LstServices.SelectedItems(0).SubItems(1).Text))
            End If
        End If
        

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

        If (LstServices.SelectedItems.Count > 0) Then

            intServiceId = LstServices.SelectedItems(0).SubItems(0).Text
            CmbCategory.SelectedValue = LstServices.SelectedItems(0).SubItems(1).Text
            TbService.Text = LstServices.SelectedItems(0).SubItems(4).Text
            TbServiceCharge.Text = LstServices.SelectedItems(0).SubItems(5).Text
            NupDuration.Value = Convert.ToInt32(LstServices.SelectedItems(0).SubItems(6).Text)
            If (LstServices.SelectedItems(0).SubItems(8).Text = "Yes") Then
                ChkActive.Checked = True
            Else
                ChkActive.Checked = False

            End If

            toShowOrHideButtons(False, True, False, False)
        End If

    End Sub

    Private Sub CmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCategory.SelectedIndexChanged

        Call FetchAllServices()

    End Sub

    Public Sub FetchAllServices()

        sqlreader = objAddServiceBL.FetchAllServicesBasedOnCategory(CmbCategory.SelectedValue)
        Call addToList()

    End Sub

    Private Sub frmAddServices_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call toLoad()
    End Sub
     
    Private Sub frmAddServices_SaveClick() Handles Me.SaveClick
        toShowOrHideButtons(True, False, False, False)
        Call toSave()
    End Sub
End Class