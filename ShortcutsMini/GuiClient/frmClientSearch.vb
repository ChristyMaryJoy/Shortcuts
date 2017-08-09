
Imports System.Data.SqlClient
Public Class frmClientSearch

    Inherits KOSLibraries.KOSForm
    Implements KOSLibraries.IFormInterface

    Dim sqlreader As SqlDataReader
    Dim dtTab As New DataTable
    Dim objClientInfoBL As New ClsAddEmployeeDL
    Dim objClientSearchBL As New ClsClientSearchBL
    Dim intClientID As Integer
    Public Shared vaInsertionOrUpdation As String 'This variable is used for select the Insertion/Updation


    '  Form Permission Variables Start Here
    Dim objPermissionsBL As New clsPermissionBL

    Dim strIsFormEnable As String = "No"
    Dim strIsSaveEnable As String = "No"
    Dim strIsUpdateEnable As String = "No"
    Dim strIsPrintEnable As String = "No"
    Dim strIsSearchEnable As String = "No"

    Dim strDescription As String

    Public Sub addToList() Implements KOSLibraries.IFormInterface.addToList
        If (sqlreader.HasRows = True) Then
            Dim SLNo As Integer = 1
            Dim arraylist(15) As String
            While (sqlreader.Read)
                arraylist(0) = sqlreader!pkClientID
                arraylist(1) = SLNo
                arraylist(2) = sqlreader!FirstName + " " + sqlreader!Middlename + " " + sqlreader!LastName
                arraylist(3) = sqlreader!MobileNo1
                arraylist(4) = sqlreader!MobileNo2
                arraylist(5) = sqlreader!ClientType
                arraylist(6) = sqlreader!LocationName
                arraylist(7) = sqlreader!fkLocationId
                arraylist(8) = sqlreader!CreatedDate
                'arraylist(9) = sqlreader!dtLastVisit

                Dim objList As New ListViewItem(arraylist)
                LstwClientDetails.Items.Add(objList)
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

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click


        LstwClientDetails.Items.Clear()
        If (ChkbName.Checked = True) Then
            If (TbSearch.Text = "") Then
                BL.ShowMessageBox.toMandatoryFieldsCompleted("Client Name")
                TbSearch.Focus()
                Exit Sub
            Else
                LstwClientDetails.Items.Clear()
                sqlreader = objClientSearchBL.FetchClientDetailsBasedonCriteria("ClientName", 0, TbSearch.Text)
                Call addToList()
            End If
        ElseIf (ChkbMobNo.Checked = True) Then
            If (TbSearch.Text = "") Then
                BL.ShowMessageBox.toMandatoryFieldsCompleted("Mobile Number")
                TbSearch.Focus()
                Exit Sub
            Else
                LstwClientDetails.Items.Clear()
                sqlreader = objClientSearchBL.FetchClientDetailsBasedonCriteria("ContactNo", Convert.ToInt64(TbSearch.Text), "")
                Call addToList()
            End If

        Else
            LstwClientDetails.Items.Clear()
            sqlreader = objClientSearchBL.FetchClientDetailsBasedonCriteria("All", 0, "")
            Call addToList()


        End If


    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click


        If (LstwClientDetails.SelectedItems.Count > 0) Then


            BL.PublicVariables.gintClientId = Convert.ToInt32(LstwClientDetails.SelectedItems(0).SubItems(0).Text)

            frmAddClient.MdiParent = Me.MdiParent
            frmAddClient.Show()
            frmAddClient.vaInsertionOrUpdation = "Updation"


            frmAddClient.toLoad()

           

            frmAddClient.TextBoxBind(LstwClientDetails.SelectedItems(0).SubItems(0).Text)

            Me.Close()
        End If


    End Sub


    Private Sub TbSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BtnSearch_Click(sender, e)
        End If
    End Sub


    Private Sub ViewHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHistoryToolStripMenuItem.Click

    End Sub

    Private Sub BookAnAppoinmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookAnAppoinmentToolStripMenuItem.Click

    End Sub

    Private Sub POSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POSToolStripMenuItem.Click

    End Sub
End Class