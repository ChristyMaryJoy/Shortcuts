
Imports System.Data.SqlClient
Public Class frmAddProduct
    Inherits KOSLibraries.KOSForm

    Implements KOSLibraries.IFormInterface


    Dim objProductBL As New clsProductBL
    Dim objCommonBL As New BusinessLayer.CommonFunctionBL
    Dim intProductId As Integer
    Dim status As String
    Dim Retail As Integer
    Public Shared vaInsertionOrUpdation As String 'This variable is used for select the Insertion/Updation

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
        Call toSetFormName("Add Product")

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

        Call FetchActiveSupplier()
       
        
    End Sub
    'To load combobox with active suppliers 

    Public Sub FetchActiveSupplier()

        sqlreader = objProductBL.FetchActiveSupplier
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

        sqlreader = objProductBL.FetchActiveCompaniesBasedonSupplier(CType(cmbSupplier.SelectedItem, ValueAndTextBL).Value)
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

        sqlreader = objProductBL.FetchActiveLinesBasedonCompanies(CType(cmbCompany.SelectedItem, ValueAndTextBL).Value)
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read)

                cmbLine.Items.Add(New ValueAndTextBL(sqlreader!pkLineID, sqlreader!LineName.ToString.ToUpper))

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
        Dim sqlreaderDuplication As SqlClient.SqlDataReader = objCommonBL.commonFetchBasesdOnTwoConditions("[dbo].[Product]", "Barcode", TbBarcode.Text, "Active", "Yes", "pkProductID,ProductName")
        If (sqlreaderDuplication.HasRows) Then
            BL.ShowMessageBox.toGeneralInformation("This Barcode " & TbBarcode.Text & "already exists.Please Check")
            Exit Sub
        Else

            If (isMandatoryFieldsCompleted() = False) Then

            Else
                objProductBL.InsertProduct(CType(cmbCompany.SelectedItem, ValueAndTextBL).Value, TbProductName.Text, TbProductcode.Text, TbBarcode.Text, Convert.ToInt32(TbBuyPrice.Text), Convert.ToInt32(TbSellPrice.Text), Retail, status)
                MsgBox("Product" & TbProductName.Text & " are Saved Successfully.")
                Call toClear()

            End If
        End If
    End Sub

    Public Sub toSearch() Implements KOSLibraries.IFormInterface.toSearch

    End Sub

    Public Sub toUpdate() Implements KOSLibraries.IFormInterface.toUpdate

    End Sub

    Private Sub frmAddProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        vaInsertionOrUpdation = "Insertion"
        Call toLoad()
    End Sub

    Private Sub frmAddProduct_SaveClick() Handles Me.SaveClick
        Call toSave()
    End Sub

    Private Sub frmAddProduct_UpdateClick() Handles Me.UpdateClick
        Call toUpdate()
    End Sub

    'Bind Details to Text Box in Updation Time
    Public Sub TextBoxBind(ByVal intProductId As Integer)

        cmbCompany.Enabled = False
        cmbLine.Enabled = False
        cmbSupplier.Enabled = False

        sqlreader = objProductBL.ViewProductInfo(intProductId)
        Call toClear()
        If (sqlreader.HasRows = True) Then
            While (sqlreader.Read())
              
                TbProductName.Text = sqlreader!ProductName
                TbProductcode.Text = sqlreader!ProductCode
                TbBarcode.Text = sqlreader!Barcode
                If (sqlreader!Retail = 1) Then
                    ChckRetail.Checked = True
                Else
                    ChckRetail.Checked = True = False
                End If
                If (sqlreader!Active = "Yes") Then
                    ChckActive.Checked = True
                Else

                    ChckActive.Checked = False
                End If

                cmbSupplier.SelectedValue = sqlreader!fkNationalityId
                cmbCompany.SelectedValue = sqlreader!fkNationalityId
                TbBuyPrice.Text = sqlreader!BuyPrice
                TbSellPrice.Text = sqlreader!SellPrice
                TbOnStock.Text = sqlreader!Stock
                TbOnOrder.Text = sqlreader!OnOrder
                TbRequired.Text = sqlreader!Required
                NupReorder.Value = sqlreader!Reorder
                NupWarning.Value = sqlreader!Warning
                
            End While
        End If
    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSupplier.SelectedIndexChanged
        Call FetchActiveCompaniesBasedonSupplier()

    End Sub

    Private Sub cmbCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompany.SelectedIndexChanged
        Call FetchActiveLinesBasedonCompany()
    End Sub

   

End Class