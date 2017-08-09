
Imports System.Net.NetworkInformation
Imports System.Net
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class frmIndex
    Dim intUserGroupID As Integer
    Dim objMenuItems As New clsMenuItemsBL
    Dim objUserGroupBL As New clsUserGroupBL
    Dim objStaffBL As New ClsEmployeeSearchBL
    Dim sqlreaderUserGroup As SqlDataReader
    Dim sqlreaderEmployeeDetails As SqlDataReader


    Dim dtableTab As New DataTable("TabTable")
    Dim dtablePanel As New DataTable("PanelTable")
    Dim dtableMenu As New DataTable("TabMenu")

    Dim drowTab As DataRow
    Dim drowPanel As DataRow
    Dim drowMenu As DataRow


    Private Sub toLoadMenu()

        dtableMenu.Columns.Add(New DataColumn("intMenuD"))
        dtableMenu.Columns.Add(New DataColumn("strDisplayName"))
        dtableMenu.Columns.Add(New DataColumn("strFormName"))
        dtableMenu.Columns.Add(New DataColumn("strTabName"))
        dtableMenu.Columns.Add(New DataColumn("strPanelName"))
        dtableMenu.Columns.Add(New DataColumn("strImg"))

        dtableTab.Columns.Add(New DataColumn("intTabID"))
        dtableTab.Columns.Add(New DataColumn("strTabName"))

        dtablePanel.Columns.Add(New DataColumn("intPanelID"))
        dtablePanel.Columns.Add(New DataColumn("strPanelName"))
        dtablePanel.Columns.Add(New DataColumn("strTabName"))

        ' Call toFetchMenuItems(BL.PublicVariables.gintUserGroupID)
        Call toFetchMenuItems(1)

        Dim rtab As RibbonTab
        Dim rpanel As RibbonPanel
        Dim rbutton As RibbonButton
        Dim lintCountButton As Integer = 1

        Dim strTab As String = String.Empty
        Dim strPanel As String = String.Empty
        Dim strMenuItem As String = String.Empty

        rtab = New RibbonTab
        rpanel = New RibbonPanel

        For lintCountButton = 0 To dtableMenu.Rows.Count - 1

            If strTab <> dtableMenu.Rows(lintCountButton).Item(3).ToString Then

                drowTab = dtableTab.NewRow
                drowTab(0) = lintCountButton + 1
                drowTab(1) = dtableMenu.Rows(lintCountButton).Item(3).ToString
                dtableTab.Rows.Add(drowTab)


                strTab = dtableMenu.Rows(lintCountButton).Item(3).ToString

            End If

            If strPanel <> dtableMenu.Rows(lintCountButton).Item(4).ToString Then

                drowPanel = dtablePanel.NewRow
                drowPanel(0) = lintCountButton + 1
                drowPanel(1) = dtableMenu.Rows(lintCountButton).Item(4).ToString
                drowPanel(2) = dtableMenu.Rows(lintCountButton).Item(3).ToString
                dtablePanel.Rows.Add(drowPanel)


                strPanel = dtableMenu.Rows(lintCountButton).Item(4).ToString

            End If



        Next

        'MsgBox("Tab : " & dtableTab.Rows.Count)
        'MsgBox("Panel : " & dtablePanel.Rows.Count)
        'MsgBox("Menu : " & dtableMenu.Rows.Count)

        For lintCountTab = 0 To dtableTab.Rows.Count - 1

            rtab = New RibbonTab
            rtab.Text = dtableTab.Rows(lintCountTab).Item(1).ToString
            Ribbon1.Tabs.Add(rtab)

            For lintCountPanel = 0 To dtablePanel.Rows.Count - 1

                If dtableTab.Rows(lintCountTab).Item(1).ToString = dtablePanel.Rows(lintCountPanel).Item(2).ToString Then


                    rpanel = New RibbonPanel
                    rtab.Panels.Add(rpanel)
                    rpanel.Text = dtablePanel.Rows(lintCountPanel).Item(1).ToString

                    For lintCountButton = 0 To dtableMenu.Rows.Count - 1

                        If dtableMenu.Rows(lintCountButton).Item(4).ToString = dtablePanel.Rows(lintCountPanel).Item(1).ToString Then

                            rbutton = New RibbonButton

                            rpanel.Items.Add(rbutton)

                            rbutton.AltKey = Nothing
                            rbutton.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down
                            rbutton.DropDownArrowSize = New System.Drawing.Size(5, 3)



                            rbutton.Image = ImageList1.Images(dtableMenu.Rows(lintCountButton).Item(5).ToString)
                            rbutton.SmallImage = ImageList1.Images(dtableMenu.Rows(lintCountButton).Item(5).ToString)

                            rbutton.Style = System.Windows.Forms.RibbonButtonStyle.Normal


                            rbutton.Tag = Nothing
                            rbutton.Text = dtableMenu.Rows(lintCountButton).Item(1).ToString
                            rbutton.ToolTip = Nothing
                            rbutton.ToolTipImage = Nothing
                            rbutton.ToolTipTitle = Nothing

                            AddHandler rbutton.Click, AddressOf rbuttonClick

                        End If

                    Next

                End If

            Next

        Next

    End Sub



    Private Sub toFetchMenuItems(ByVal intUserGroupID As Integer)

        Dim dsetMenuItems As New DataSet

        dsetMenuItems = objMenuItems.FetchMenuItemsOfUserGroupDataSet(intUserGroupID)

        If dsetMenuItems.Tables.Count > 0 Then

            Dim arrMenuItems(10) As String
            Dim lintCount As Integer = 1

            For lintCounter As Integer = 0 To dsetMenuItems.Tables(0).Rows.Count - 1

                With dsetMenuItems.Tables(0).Rows(lintCounter)

                    drowMenu = dtableMenu.NewRow
                    drowMenu(0) = lintCount + 1
                    drowMenu(1) = .Item("vaDisplayName")
                    drowMenu(2) = .Item("vaFormName")
                    drowMenu(3) = .Item("vaTabName")
                    drowMenu(4) = .Item("vaPanelName")
                    drowMenu(5) = .Item("vaImagePath")
                    dtableMenu.Rows.Add(drowMenu)

                End With


            Next


        End If



    End Sub
    Private Sub rbuttonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim arrButton(2) As String
        arrButton = sender.ToString.Split(":")
        For lintCountButton = 0 To dtableMenu.Rows.Count - 1

            If dtableMenu.Rows(lintCountButton).Item(1).ToString.Trim = arrButton(1).Trim Then

                For lintCount As Integer = 0 To Application.OpenForms.Count - 1

                    If dtableMenu.Rows(lintCountButton).Item(2).ToString.ToUpper = Application.OpenForms(lintCount).Name.ToString.ToUpper Then

                        Application.OpenForms(lintCount).BringToFront()
                        Exit Sub

                    End If

                Next

                Dim type As Type = type.[GetType]("ShortcutsMini." & dtableMenu.Rows(lintCountButton).Item(2).ToString)

                Dim obj As Object = Activator.CreateInstance(type)
                TryCast(obj, Form).MdiParent = Me
                TryCast(obj, Form).Show()

            End If

        Next

        'If DateValue(BL.PublicVariables.gdtCurrentDate) <> DateValue(Now) Then
        '    BL.ShowMessageBox.toError("Incorrect System Date. Please correct to : " & BL.PublicVariables.gdtCurrentDate)
        '    Exit Sub
        'End If



    End Sub


    Private Sub toChangeSystemDateFormat()


        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\International", True)
        regKey.SetValue("sShortDate", "dd/MM/yyyy")
        regKey.SetValue("sLongDate", "dd/MM/yyyy")
        regKey.Close()

    End Sub

    Private Sub frmIndex_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Try




        'Me.Opacity = 0

        'Call toChangeSystemDateFormat()

        'Call toSetServerDateAsClientDate()

        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl As Control In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = DirectCast(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Color.FromArgb(255, 236, 213)
                ' Catch and ignore the error if casting failed.
            Catch exc As InvalidCastException
            End Try
                Next



        NotifyIcon1.ShowBalloonTip(10, "Welcome", "Welcome To Flex Resorts and Real Estate Company. Login at " & BL.PublicVariables.gdtCurrentDate.ToLongDateString & " " & BL.PublicVariables.gdtCurrentDate.ToLongTimeString, ToolTipIcon.Info)

        BL.PublicVariables.gintUserGroupID = objUserGroupBL.FetchUserGroupBasedOnEmployeeID(BL.PublicVariables.gintEmployeeID)

        intUserGroupID = BL.PublicVariables.gintUserGroupID


        sqlreaderUserGroup = objUserGroupBL.FetchUserGroupBasedOnUserGroupID(intUserGroupID)

        If sqlreaderUserGroup.HasRows = True Then
            BL.PublicVariables.gstrUserGroup = sqlreaderUserGroup!UserGroup
        End If
        lblUserName.Text = toGetEmployeeName(BL.PublicVariables.gintEmployeeID)

        lblDate.Text = Now.Day
        lblDay.Text = WeekdayName(Now.DayOfWeek + 1)
        lblMonthYear.Text = MonthName(Now.Month) & " " & Now.Year

        Call toLoadMenu()

        Me.Opacity = 100

        'Catch ex As Exception

        'End Try
    End Sub
    Private Function toGetEmployeeName(ByVal intEmployeeID As Integer) As String

        Dim sqlReader As SqlDataReader = Nothing

        sqlReader = objStaffBL.fetchUserDetailsBasedOnUserID(intEmployeeID)

        If sqlReader.HasRows = True Then

            While sqlReader.Read

                If (sqlReader!Middlename = "") Then
                    toGetEmployeeName = sqlReader!Firstname + sqlReader!Middlename + sqlReader!Lastname
                Else
                    toGetEmployeeName = sqlReader!Firstname + "" + sqlReader!Middlename + "" + sqlReader!Lastname
                End If


            End While
        End If


        sqlReader.Close()


    End Function
    Private Sub toFetchImageBasedOnLocation()
        If (BL.PublicVariables.gintLocationId = 1) Then

            Me.BackgroundImage = My.Resources.Spa_final_logo

        ElseIf (BL.PublicVariables.gintLocationId = 2) Then
            Me.BackgroundImage = My.Resources.Spa_final_logo


        ElseIf (BL.PublicVariables.gintLocationId = 3) Then
            Me.BackgroundImage = My.Resources.Spa_final_logo


        ElseIf (BL.PublicVariables.gintLocationId = 4) Then
            Me.BackgroundImage = My.Resources.Spa_final_logo


        End If

    End Sub

    Private Sub lblMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMinimize.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub


    Private Sub lblLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogout.Click

        If MsgBox("Are You Sure To Close ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            NotifyIcon1.Dispose()

            End

        End If

    End Sub

    Private Sub frmIndex_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.Width <= 1024 Then
            Me.Width = 1024
        End If
        If Me.Height <= 754 Then
            Me.Height = 754
        End If
    End Sub
End Class