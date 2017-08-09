Imports System.Data.SqlClient


Public Class frmlogin
    Inherits KOSLibraries.KOSForm
    Implements KOSLibraries.IFormInterface
    Dim sqlreaderLogin As SqlDataReader
    Dim sqlreaderLoginlocation As SqlDataReader
    Dim ObjLoginBL As New clsLoginBL
    Dim objCommonFunction As New BusinessLayer.CommonFunctionBL

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click

        If (isMandatoryFieldsCompleted() = False) Then


        Else
            sqlreaderLogin = ObjLoginBL.FetchLoginBasedOnUserNameandPassword(TbUserName.Text, TbPassword.Text)


            If sqlreaderLogin.HasRows = True Then


                BL.PublicVariables.gintEmployeeID = sqlreaderLogin!fkEmpID

                sqlreaderLoginlocation = objCommonFunction.commonFetchBasesdOnTwoConditions("Employee.Location", "fkEmpId", BL.PublicVariables.gintEmployeeID, "fkLocationId", CType(Cmblocation.SelectedItem, ValueAndTextBL).Value, "fkLocationId")

                If sqlreaderLoginlocation.HasRows = True Then

                    BL.PublicVariables.gintLocationId = sqlreaderLogin!fkLocationId
                    frmIndex.Show()
                Else
                    BL.ShowMessageBox.toGeneralInformation("Login Failed.Select your Allocated Location")
                    Exit Sub
                End If
                sqlreaderLoginlocation.Close()

            Else
                BL.ShowMessageBox.toGeneralInformation("Login Failed.Invalid Username and Password")
                Exit Sub
            End If

            sqlreaderLogin.Close()
        End If



    End Sub

    Public Sub addToList() Implements KOSLibraries.IFormInterface.addToList

    End Sub

    Public Sub deleteList() Implements KOSLibraries.IFormInterface.deleteList

    End Sub

    Public Sub editList() Implements KOSLibraries.IFormInterface.editList

    End Sub

    Public Function isMandatoryFieldsCompleted() As Boolean Implements KOSLibraries.IFormInterface.isMandatoryFieldsCompleted
        If (TbUserName.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("UserName")
            TbUserName.Focus()
            Return False
        End If

        If (TbPassword.Text = "") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Password")
            TbPassword.Focus()
            Return False
        End If

        If (Cmblocation.Text = "--SELECT--") Then
            BL.ShowMessageBox.toMandatoryFieldsCompleted("Nationality")
            Cmblocation.Focus()
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

        toShowOrHideButtons(False, False, False, False)



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

    Private Sub frmlogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call toLoad()
    End Sub
End Class