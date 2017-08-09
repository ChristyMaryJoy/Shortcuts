
Imports System.Data.SqlClient
Public Class frmAddSeriesService
    Inherits KOSLibraries.KOSForm

    Implements KOSLibraries.IFormInterface

    Dim objAddSeriesServiceBL As New clsSeriesServiceBL
    Dim objCommonBL As New BusinessLayer.CommonFunctionBL
    Dim sqlreader As SqlDataReader
    Dim intServiceID As Integer
    Dim intCategoryId As Integer
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
    Private Sub frmAddPackageService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call toLoad()

    End Sub

    Public Sub addToList() Implements KOSLibraries.IFormInterface.addToList
        If (sqlreader.HasRows = True) Then
            Dim SLNo As Integer = 1
            Dim arraylist(15) As String
            While (sqlreader.Read)
                arraylist(0) = sqlreader!fkServiceCategoryId
                arraylist(1) = sqlreader!pkServiceID
                arraylist(2) = SLNo
                arraylist(3) = sqlreader!CategoryName
                arraylist(4) = sqlreader!ServiceName
                arraylist(5) = sqlreader!SeriesName
                arraylist(6) = sqlreader!SeriesUnitPrice
                arraylist(7) = sqlreader!Session
                arraylist(8) = sqlreader!TotalPrice
                arraylist(9) = sqlreader!Duration
                arraylist(10) = sqlreader!ExpiryinMonths
                arraylist(11) = sqlreader!Active


                Dim objList As New ListViewItem(arraylist)
                LstwSeries.Items.Add(objList)
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
        If (CmbServices.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Services")
            CmbCategory.Focus()
            Return False
        End If
        If (TbSeriesName.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("ServiceSeries Name")
            TbSeriesName.Focus()
            Return False
        End If
 
        If (TbUnitPrice.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("UnitPrice")
            TbSeriesName.Focus()
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
        Call toSetFormName("Series Services")

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

    Public Sub toSave() Implements KOSLibraries.IFormInterface.toSave
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.commonFetchBasesdOnTwoConditions("[dbo].[SeriesService]", "fkServiceId", CmbServices.SelectedValue, "SeriesName", TbSeriesName.Text, "pkSeriesID,fkServiceId,SeriesName")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The service is already added under this category .Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then

            Else
                objAddSeriesServiceBL.InsertSeriesService(CType(CmbServices.SelectedItem, ValueAndTextBL).Value, TbSeriesName.Text, Convert.ToInt32(TbUnitPrice.Text), NupSession.Value, NupDuration.Value, Convert.ToInt32(TbTotalPrice.Text), NupDuration.Value, "Yes")
                MsgBox("Series for Service" & CType(CmbServices.SelectedItem, ValueAndTextBL).Value & " are Saved Successfully.")
                Call toClear()

            End If
        End If
    End Sub



    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.commonFetchBasesdOnTwoConditions("[dbo].[SeriesService]", "fkServiceId", CmbServices.SelectedValue, "SeriesName", TbSeriesName.Text, "pkSeriesID,fkServiceId,SeriesName")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("The series" & TbSeriesName.Text & " is already available under this " & CmbServices.SelectedText & "Service.Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then

            Else
                objAddSeriesServiceBL.InsertSeriesService(CType(CmbServices.SelectedItem, ValueAndTextBL).Value, TbSeriesName.Text, Convert.ToInt32(TbUnitPrice.Text), NupSession.Value, NupDuration.Value, Convert.ToInt32(TbTotalPrice.Text), NupDuration.Value, "Yes")
                MsgBox("Series for Service" & CType(CmbServices.SelectedItem, ValueAndTextBL).Value & " are Saved Successfully.")
                Call toClear()

            End If
        End If
        toShowOrHideButtons(True, False, False, False)
    End Sub
    'Bind Details to ComboBox when loading from Service form
    Public Sub ComboBoxBind(ByVal intCategoryId As Integer, ByVal intServiceID As Integer)

        CmbCategory.SelectedValue = intCategoryId
        CmbServices.SelectedValue = intServiceID
        CmbCategory.Enabled = False
        CmbServices.Enabled = False


    End Sub
    'To Fetch All Categories
    Public Sub toFetchCategory()
        sqlreader = objAddSeriesServiceBL.FetchActiveCategory
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                CmbCategory.Items.Add(New ValueAndTextBL(sqlreader!pkServiceCategoryID, sqlreader!CategoryName.ToString.ToUpper))

            End While
            CmbCategory.SelectedIndex = 0
        End If
        sqlreader.Close()
    End Sub

    Private Sub CmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCategory.SelectedIndexChanged

        Call FetchAllServiceswithSeriesOnly()
        Call FetchAllSeriesServicesBasedOnCategory()
        Call addToList()

    End Sub
    'To Fetch All Services BasedOn Categories
    Public Sub FetchAllServiceswithSeriesOnly()
        sqlreader = objAddSeriesServiceBL.FetchServiceBasedOnCategoryandSeries(CmbCategory.SelectedValue)
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                CmbServices.Items.Add(New ValueAndTextBL(sqlreader!pkServiceID, sqlreader!ServiceName.ToString.ToUpper))

            End While
            CmbServices.SelectedIndex = 0
        End If
        sqlreader.Close()
    End Sub
    'To Fetch All Series Services Based On Categories
    Public Sub FetchAllSeriesServicesBasedOnCategory()
        sqlreader = objAddSeriesServiceBL.FetchAllSeriesServicesBasedOnCategory(CmbCategory.SelectedValue)

    End Sub

    Private Sub CmbServices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbServices.SelectedIndexChanged

        Call FetchAllSeriesServicesBaedonServices()
        Call addToList()
        TbSeriesName.Text = "" & CmbServices.SelectedText & "Series"

    End Sub

    Public Sub FetchAllSeriesServicesBaedonServices()
        sqlreader = objAddSeriesServiceBL.FetchAllSeriesServicesBasedOnCategory(CmbServices.SelectedValue)

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If (LstwSeries.SelectedItems.Count > 0) Then

            intServiceID = LstwSeries.SelectedItems(0).SubItems(1).Text
            CmbCategory.SelectedValue = Convert.ToInt32(LstwSeries.SelectedItems(0).SubItems(0).Text)
            CmbServices.SelectedValue = Convert.ToInt32(LstwSeries.SelectedItems(0).SubItems(1).Text)
            TbSeriesName.Text = LstwSeries.SelectedItems(0).SubItems(5).Text
            TbUnitPrice.Text = LstwSeries.SelectedItems(0).SubItems(6).Text
            NupSession.Value = Convert.ToInt32(LstwSeries.SelectedItems(0).SubItems(7).Text)
            TbTotalPrice.Text = Convert.ToInt32(LstwSeries.SelectedItems(0).SubItems(8).Text)
            NupDuration.Value = Convert.ToInt32(LstwSeries.SelectedItems(0).SubItems(9).Text)
            NupExpiry.Value = Convert.ToInt32(LstwSeries.SelectedItems(0).SubItems(10).Text)
           
            If (LstwSeries.SelectedItems(0).SubItems(11).Text = "Yes") Then
                ChkActive.Checked = True
            Else
                ChkActive.Checked = False

            End If

            toShowOrHideButtons(False, True, False, False)
        End If
    End Sub

    Private Sub TbUnitPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbUnitPrice.TextChanged
       
        Call toCalculateTotalAmount()

    End Sub


    Public Sub toCalculateTotalAmount()
        Dim intunitprice As Integer
        Dim inttotalprice As Integer
        Dim intsession As Integer

        inttotalprice = intunitprice * intsession

        TbTotalPrice.Text = inttotalprice.ToString
    End Sub

    Private Sub NupSession_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NupSession.ValueChanged
        Call toCalculateTotalAmount()

    End Sub

    Private Sub frmAddSeriesService_SaveClick() Handles Me.SaveClick
        toShowOrHideButtons(True, False, False, False)
        Call toSave()

    End Sub


    Private Sub frmAddSeriesService_UpdateClick() Handles Me.UpdateClick

        toShowOrHideButtons(True, True, False, False)
        Call toUpdate()

    End Sub
End Class