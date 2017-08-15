Imports System.Data.SqlClient

Public Class frmSearchProduct

    Inherits KOSLibraries.KOSForm

    Implements KOSLibraries.IFormInterface

    Dim sqlreader As SqlDataReader

    Dim objSearchProductBL As New clsSearchProductBL
    Dim objCommonBL As New BusinessLayer.CommonFunctionBL
    Dim intProductId As Integer

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
                arraylist(0) = sqlreader!pkSupplierID
                arraylist(1) = sqlreader!pkCompanyID
                arraylist(2) = sqlreader!fkLine
                arraylist(3) = sqlreader!pkProductID
                arraylist(4) = SLNo
                arraylist(5) = sqlreader!ProductName
                arraylist(6) = sqlreader!BuyPrice
                arraylist(7) = sqlreader!SellPrice
                arraylist(8) = sqlreader!Barcode
                If (sqlreader!Retail = 1) Then
                    arraylist(8) = "Yes"
                Else
                    arraylist(8) = "No"
                End If

                arraylist(10) = sqlreader!Active

                Dim objList As New ListViewItem(arraylist)
                LstvProducts.Items.Add(objList)
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
        Call toSetFormName("Search Product")

        Call FetchFormPermissionOfAUser(Me.Name, BL.PublicVariables.gintUserGroupID)

        If strIsFormEnable = "No" Then
            BL.ShowMessageBox.toShowUnauthorizedAction()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If

        ChkActive.Checked = True

        Call FetchActiveSupplier()
    End Sub

    Public Sub toPrint() Implements KOSLibraries.IFormInterface.toPrint

    End Sub

    Public Sub toRefresh() Implements KOSLibraries.IFormInterface.toRefresh

    End Sub

    Public Sub toSave() Implements KOSLibraries.IFormInterface.toSave

    End Sub

    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate

    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        If (LstvProducts.SelectedItems.Count > 0) Then


            BL.PublicVariables.gintClientId = Convert.ToInt32(LstvProducts.SelectedItems(0).SubItems(0).Text)

            frmAddProduct.MdiParent = Me.MdiParent
            frmAddProduct.Show()
            frmAddProduct.vaInsertionOrUpdation = "Updation"


            frmAddProduct.toLoad()

            frmAddProduct.TextBoxBind(Convert.ToInt32(LstvProducts.SelectedItems(0).SubItems(3).Text))

            Me.Close()
        End If
    End Sub

    Private Sub frmSearchProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call toLoad()
    End Sub

   
    Private Sub cmbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSupplier.SelectedIndexChanged
        Call FetchActiveCompaniesBasedonSupplier()

    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompany.SelectedIndexChanged
        Call FetchActiveLinesBasedonCompany()
    End Sub

    'To load combobox with active suppliers 

    Public Sub FetchActiveSupplier()

        sqlreader = objSearchProductBL.FetchActiveSupplier
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                CmbSupplier.Items.Add(New ValueAndTextBL(sqlreader!pkSupplierID, sqlreader!SupplierName.ToString.ToUpper))

            End While
            CmbSupplier.SelectedIndex = 0
        End If
        sqlreader.Close()
    End Sub
    'To load combobox with active companies based on selecting supplier

    Public Sub FetchActiveCompaniesBasedonSupplier()

        sqlreader = objSearchProductBL.FetchActiveCompaniesBasedonSupplier(CType(cmbSupplier.SelectedItem, ValueAndTextBL).Value)
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                cmbCompany.Items.Add(New ValueAndTextBL(sqlreader!pkCompanyID, sqlreader!Companyname.ToString.ToUpper))

            End While
            CmbSupplier.SelectedIndex = 0
        End If
        sqlreader.Close()
    End Sub
    'To load combobox with active lines based on selecting companies
    Public Sub FetchActiveLinesBasedonCompany()

        sqlreader = objSearchProductBL.FetchActiveLinesBasedonCompanies(CType(cmbCompany.SelectedItem, ValueAndTextBL).Value)
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                cmbLine.Items.Add(New ValueAndTextBL(sqlreader!pkLineID, sqlreader!LineName.ToString.ToUpper))

            End While
            CmbSupplier.SelectedIndex = 0
        End If
        sqlreader.Close()
    End Sub

    
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        If ChkActive.Checked = True Then
            sqlreader = objSearchProductBL.ViewProductDetailsBasedonStatus(intProductId, "Yes")
            
        Else
            sqlreader = objSearchProductBL.ViewProductDetailsBasedonStatus(intProductId, "No")
            
        End If
        Call addToList()
    End Sub
End Class