Imports System.Text.RegularExpressions
Imports System.Collections

Namespace BL

    Public Class ValidateContol

        Public Shared MESSAGE_ERROR_CRITICAL As String
        'Author     :   Ashok R
        'Date       :   March 16,2009
        'About      :   Using this class user can Validate the Entering Character in a text box is number or 
        '               string 

        'AUTHOR     :   JAISON D.THOMAS
        'DATE       :   MARCH 18,2008
        'REASON     :   COMMENT ADDED TO GET CLARITY.

        'In some situations the user only allowed to entre some digits 
        'inside the controls, no text is allowed inside the control.
        'This function allow the user to entre only numerical datas.

        'Returns    : Returns true if the digit is entred otherwise return false
        'parameter  : The key press event

        Public Shared Sub isNumeric(ByVal e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = "." Then Exit Sub

            If (e.KeyChar >= "!" And e.KeyChar <= "/") Or (e.KeyChar >= ":" And e.KeyChar <= "~") Then
                e.Handled = True
            End If

        End Sub

        Public Shared Sub NoComma(ByVal e As System.Windows.Forms.KeyPressEventArgs)

            If (e.KeyChar = ",") Then
                e.Handled = True
            End If

        End Sub

        Public Shared Sub isNumbersOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)

            If Char.IsNumber(e.KeyChar) = False Then
                If Asc(e.KeyChar) = 8 Then
                    Exit Sub
                End If

                e.Handled = True
            End If

        End Sub

        Public Shared Sub isInteger(ByVal e As System.Windows.Forms.KeyPressEventArgs)

            If (e.KeyChar >= "!" And e.KeyChar <= "/") Or (e.KeyChar >= ":" And e.KeyChar <= "~") Then
                e.Handled = True
            End If

        End Sub
        'In some situation the user only allowed to entre string data inside
        'the controls, no digit values allowed , this function restrict 
        'user to entre the digit values.

        'Returns    : returns true if the string is entred
        'Parameter  :   the keypress event.
        Public Shared Sub isString(ByVal e As System.Windows.Forms.KeyPressEventArgs)

            If (e.KeyChar <= "!" And e.KeyChar >= "/") Or (e.KeyChar <= ":" And e.KeyChar >= "~") Then
                e.Handled = True
            End If

        End Sub
        'Author     :   Ashok R
        'Date       :   March 19,2009
        'About      :   Common Usable Function
        '               Using this class user can Validate an allready entered datagrid items with New entry .
        '               using this function User can evaluate ***TWO*** fields in data grid.
        '           :   Function returns boolean value
        '
        'Parameters 
        '   lstrNewEnteredItemOne >> Holds The first string value which we want to add data grid
        '   lstrNewEnteredItemTwo >> Holds The second string value which we want to add data grid

        '   lintItemColumnIndexOne >> Holds The Column index of the data grid which we want to add first string
        '   lintItemColumnIndexTwo >> Holds The Column index of the data grid which we want to add second string

        '   dataGridId >> Holds The datagridviewid(Name) 
        '   nextFocousedControlId >> Holds The Id(Name) of the control when the focus goes to


        Public Shared Function isGridItemsRepeated(ByVal lstrNewEnteredItemOne As String, ByVal lstrNewEnteredItemTwo As String, ByVal lintItemColumnIndexOne As Integer, ByVal lintItemColumnIndexTwo As Integer, ByVal lintItemQuantityIndex As Integer, ByVal QuantityTextBoxId As Windows.Forms.TextBox, ByVal dataGridId As Windows.Forms.DataGridView) As Boolean
            'Public Shared Function isGridItemsRepeated(ByVal lstrNewEnteredItemOne As String, ByVal lstrNewEnteredItemTwo As String, ByVal lintItemColumnIndexOne As Integer, ByVal lintItemColumnIndexTwo As Integer, ByVal dataGridId As Windows.Forms.DataGridView, ByVal nextFocousedControlId As Windows.Forms.Control) As Boolean

            Dim Rowcount As Integer
            Dim lstrFirstItem As String
            Dim lstrSecondItem As String

            If dataGridId.Rows.Count > 0 Then

                'we must check from the first row to last row for find out the new item is already exist 
                'or not in any row of data grid
                For Rowcount = 0 To dataGridId.Rows.Count - 2
                    'take the items from the grid 
                    lstrFirstItem = Trim(dataGridId.Item(lintItemColumnIndexOne, Rowcount).Value)
                    lstrSecondItem = Val(dataGridId.Item(lintItemColumnIndexTwo, Rowcount).Value)
                    'Comparing grid item with new entered items
                    'if both conditions are satisfied,that means thitr is already a row of entry with 
                    'the same item which is currently entered
                    If lstrFirstItem = Trim(lstrNewEnteredItemOne) And lstrSecondItem = Val(lstrNewEnteredItemTwo) Then
                        QuantityTextBoxId.Text = QuantityTextBoxId.Text + Val(dataGridId.Item(lintItemQuantityIndex, Rowcount).Value)
                        ''Removes the row that already entered 
                        dataGridId.Rows.Remove(dataGridId.Rows(Rowcount))
                        Return True
                        Exit Function
                    End If
                Next
            End If
        End Function
        'Author     :   Ashok R
        'Date       :   March 19,2009
        'About      :   Common Usable Function
        '               Using this class user can Validate an allready entered datagrid items with New entry .
        '               using this function User can evaluate ***THREE*** fields in data grid.
        '           :   Function returns boolean value
        '
        'Parameters 
        '   lstrNewEnteredItemOne >> Holds The first string value which we want to add data grid
        '   lstrNewEnteredItemTwo >> Holds The second string value which we want to add data grid
        '   lstrNewEnteredItemThree >> Holds The Third string value which we want to add data grid

        '   lintItemColumnIndexOne >> Holds The Column index of the data grid which we want to add first string
        '   lintItemColumnIndexTwo >> Holds The Column index of the data grid which we want to add second string
        '   lintItemColumnIndexThree >> Holds The Column index of the data grid which we want to add third string

        '   dataGridId >> Holds The datagridviewid(Name) 
        '   nextFocousedControlId >> Holds The Id(Name) of the control when the focus goes to


        Public Shared Function isGridItemsRepeated(ByVal lstrNewEnteredItemOne As String, ByVal lstrNewEnteredItemTwo As String, ByVal lstrNewEnteredItemThree As String, ByVal lintItemColumnIndexOne As Integer, ByVal lintItemColumnIndexTwo As Integer, ByVal lintItemColumnIndeThree As Integer, ByVal lintItemQuantityIndex As Integer, ByVal QuantityTextBoxId As Windows.Forms.TextBox, ByVal dataGridId As Windows.Forms.DataGridView) As Boolean

            Dim Rowcount As Integer
            Dim lstrFirstItem As String
            Dim lstrSecondItem As String
            Dim lstrThirdItem As String

            If dataGridId.Rows.Count > 0 Then

                'we must check from the first row to last row for find out the new item is already exist 
                'or not in any row of data grid
                For Rowcount = 0 To dataGridId.Rows.Count - 2
                    'take the items from the grid 
                    lstrFirstItem = Trim(dataGridId.Item(lintItemColumnIndexOne, Rowcount).Value)
                    lstrSecondItem = Val(dataGridId.Item(lintItemColumnIndexTwo, Rowcount).Value)
                    lstrThirdItem = dataGridId.Item(lintItemColumnIndeThree, Rowcount).Value
                    'Comparing grid item with new entered items
                    'if both conditions are satisfied,that means thitr is already a row of entry with 
                    'the same item which is currently entered
                    If lstrFirstItem = Trim(lstrNewEnteredItemOne) And lstrSecondItem = Val(lstrNewEnteredItemTwo) And lstrThirdItem = Trim(lstrNewEnteredItemThree) Then

                        QuantityTextBoxId.Text = QuantityTextBoxId.Text + Val(dataGridId.Item(lintItemQuantityIndex, Rowcount).Value)
                        'ShowMessageBox.toGeneralInformation("Item Already Exist")
                        'Removes the row that already entered 
                        dataGridId.Rows.Remove(dataGridId.Rows(Rowcount))
                        'nextFocousedControlId.Focus()
                        Return True
                        Exit Function
                    End If
                Next
            End If
        End Function
        'Author     :   Ashok R
        'Date       :   March 19,2009
        'About      :   Common Usable Function
        '               Using this class user can Validate an allready entered datagrid items with New entry .
        '               using this function User can evaluate ***THREE*** fields in data grid.
        '           :   Function returns boolean value
        '
        'Parameters 
        '   lstrNewEnteredItemOne >> Holds The first string value which we want to add data grid
        '   lstrNewEnteredItemTwo >> Holds The second string value which we want to add data grid
        '   lstrNewEnteredItemThree >> Holds The Third string value which we want to add data grid

        '   lintItemColumnIndexOne >> Holds The Column index of the data grid which we want to add first string
        '   lintItemColumnIndexTwo >> Holds The Column index of the data grid which we want to add second string
        '   lintItemColumnIndexThree >> Holds The Column index of the data grid which we want to add third string

        '   dataGridId >> Holds The datagridviewid(Name) 
        '   nextFocousedControlId >> Holds The Id(Name) of the control when the focus goes to


        Public Shared Function isGridItemsRepeated(ByVal lstrNewEnteredItemOne As String, ByVal lstrNewEnteredItemTwo As String, ByVal lstrNewEnteredItemThree As String, ByVal lintItemColumnIndexOne As Integer, ByVal lintItemColumnIndexTwo As Integer, ByVal lintItemColumnIndeThree As Integer, ByVal lintAmountIndex As Integer, ByVal dataGridId As Windows.Forms.DataGridView, ByVal AmountTextBoxId As Windows.Forms.TextBox) As Boolean
            Dim Rowcount As Integer
            Dim lstrFirstItem As String
            Dim lstrSecondItem As String
            Dim lstrThirdItem As String
            '
            If dataGridId.Rows.Count > 0 Then
                'we must check from the first row to last row for find out the new item is already exist 
                'or not in any row of data grid
                For Rowcount = 0 To dataGridId.Rows.Count - 2
                    'take the items from the grid 
                    lstrFirstItem = Trim(dataGridId.Item(lintItemColumnIndexOne, Rowcount).Value)
                    lstrSecondItem = Trim(dataGridId.Item(lintItemColumnIndexTwo, Rowcount).Value)
                    lstrThirdItem = Trim(dataGridId.Item(lintItemColumnIndeThree, Rowcount).Value)
                    'Comparing grid item with new entered items
                    'if both conditions are satisfied,that means thitr is already a row of entry with 
                    'the same item which is currently entered
                    If lstrFirstItem = Trim(lstrNewEnteredItemOne) And lstrSecondItem = Trim(lstrNewEnteredItemTwo) And lstrThirdItem = Trim(lstrNewEnteredItemThree) Then

                        AmountTextBoxId.Text = AmountTextBoxId.Text + Val(dataGridId.Item(lintAmountIndex, Rowcount).Value)
                        'ShowMessageBox.toGeneralInformation("Item Already Exist")
                        'Removes the row that already entered 
                        dataGridId.Rows.Remove(dataGridId.Rows(Rowcount))
                        'nextFocousedControlId.Focus()
                        Return True
                        Exit Function
                    End If
                Next
            End If
        End Function
        'Author     :   Ashok R
        'Date       :   March 19,2009
        'About      :   Common Usable Function
        '               Using this class user can Validate an allready entered datagrid items with New entry .
        '               using this function User can evaluate ***TWO*** fields in data grid.
        '           :   Function returns boolean value
        '
        'Parameters 
        '   lstrNewEnteredItemOne >> Holds The first string value which we want to add data grid
        '   lstrNewEnteredItemTwo >> Holds The second string value which we want to add data grid

        '   lintItemColumnIndexOne >> Holds The Column index of the data grid which we want to add first string
        '   lintItemColumnIndexTwo >> Holds The Column index of the data grid which we want to add second string

        '   dataGridId >> Holds The datagridviewid(Name) 
        '   nextFocousedControlId >> Holds The Id(Name) of the control when the focus goes to


        Public Shared Function isGridItemsRepeated(ByVal lstrNewEnteredItemOne As String, ByVal lstrNewEnteredItemTwo As String, ByVal lintItemColumnIndexOne As Integer, ByVal lintItemColumnIndexTwo As Integer, ByVal dataGridId As Windows.Forms.DataGridView, ByVal NextFocusedControl As Windows.Forms.Control) As Boolean
            'Public Shared Function isGridItemsRepeated(ByVal lstrNewEnteredItemOne As String, ByVal lstrNewEnteredItemTwo As String, ByVal lintItemColumnIndexOne As Integer, ByVal lintItemColumnIndexTwo As Integer, ByVal dataGridId As Windows.Forms.DataGridView, ByVal nextFocousedControlId As Windows.Forms.Control) As Boolean

            Dim Rowcount As Integer
            Dim lstrFirstItem As String
            Dim lstrSecondItem As String

            If dataGridId.Rows.Count > 0 Then

                'we must check from the first row to last row for find out the new item is already exist 
                'or not in any row of data grid
                For Rowcount = 0 To dataGridId.Rows.Count - 2
                    'take the items from the grid 
                    lstrFirstItem = Trim(dataGridId.Item(lintItemColumnIndexOne, Rowcount).Value)
                    lstrSecondItem = Trim(dataGridId.Item(lintItemColumnIndexTwo, Rowcount).Value)
                    'Comparing grid item with new entered items
                    'if both conditions are satisfied,that means thitr is already a row of entry with 
                    'the same item which is currently entered
                    If lstrFirstItem.ToUpper = Trim(lstrNewEnteredItemOne).ToUpper And lstrSecondItem.ToUpper = (lstrNewEnteredItemTwo).ToUpper Then
                        ShowMessageBox.toGeneralInformation("Item Already Exist")
                        ''Removes the row that already entered 
                        'dataGridId.Rows.Remove(dataGridId.Rows(Rowcount))
                        NextFocusedControl.Focus()
                        Return True
                        Exit Function
                    End If
                Next
            End If
        End Function
        'Check if an item is repeated in the grid
        Public Shared Function isGridItemsRepeated(ByVal ItemTextBox As Windows.Forms.TextBox, ByVal dataGridId As Windows.Forms.DataGridView, ByVal GridColumnNo As Integer) As Boolean
            Dim rowcount As Integer
            Dim lstrGridValue As String

            If dataGridId.Rows.Count > 1 Then
                For rowcount = 0 To dataGridId.Rows.Count - 2
                    lstrGridValue = dataGridId.Item(GridColumnNo, rowcount).Value
                    If Trim(ItemTextBox.Text).ToUpper = lstrGridValue.ToUpper Then
                        ShowMessageBox.toGeneralInformation("Item Already Exist In The List")
                        ItemTextBox.Focus()
                        Return False
                    End If
                Next
                Return True
            Else
                Return True
            End If

        End Function


        'This function validate a web address .
        'Return true if the address is valid,otherwise
        'return false.
        'parameter : Web address.

        Public Shared Function isWebAddressValid(ByVal webAddress As String) As Boolean
            'Author     :   Jackson Thomas
            'Date       :   June 13,2009

            Try

                Dim lstrStart As String
                Dim lstrExtension() As String = {".com", ".edu", ".info", ".gov", ".int", ".mil", ".net", ".org", ".biz", ".name", ".museum", ".coop", ".aero", ".pro", ".tv"}


                lstrStart = "www."
                For extensionCount = 0 To lstrExtension.Count - 1

                    If webAddress.StartsWith(lstrStart) And webAddress.EndsWith(lstrExtension(extensionCount)) Then

                        Return True
                    End If
                Next

                ShowMessageBox.toGeneralInformation("Enter A Valid Web Address")
                Return False

            Catch exception As Exception
                WritetoLogFile(exception.Message, MESSAGE_ERROR_CRITICAL, "frmExistingCompany", "isWebAddressValid")
            End Try
        End Function

        'This function validate wheather user entred the email
        'address with valid format
        'Returns true if the address is valid,else returns false.
        'parmeter : email address.
        Public Shared Function isEmailValid(ByVal emailAddress As String) As Boolean

            'Author     :   Jackson Thomas
            'Date       :   June 13,2009

            Try

                Dim pattern As String = "^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.""(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$"
                Dim expression As New Regex(pattern)
                If expression.IsMatch(emailAddress) Then
                    Return True
                Else
                    ShowMessageBox.toGeneralInformation("Enter A Valid Email Address")
                    Return False

                End If

            Catch exception As Exception
                WritetoLogFile(exception.Message, MESSAGE_ERROR_CRITICAL, "frmExistingCompany", "isEmailValid")
            End Try
        End Function


        'Check if an item is repeated in the grid with combobox
        Public Shared Function isGridItemsRepeated(ByVal ComboBox As Windows.Forms.ComboBox, ByVal dataGridId As Windows.Forms.DataGridView, ByVal GridColumnNo As Integer) As Boolean
            Dim rowcount As Integer
            Dim lstrGridValue As String

            If dataGridId.Rows.Count > 1 Then
                For rowcount = 0 To dataGridId.Rows.Count - 2
                    lstrGridValue = dataGridId.Item(GridColumnNo, rowcount).Value
                    If Trim(ComboBox.Text).ToUpper = lstrGridValue.ToUpper Then
                        ShowMessageBox.toGeneralInformation("Item Already Exist In The List")
                        ComboBox.Focus()
                        Return False
                    End If
                Next
                Return True
            Else
                Return True
            End If

        End Function

        Public Sub toValidateTextBoxesInsideGroupBox(ByVal grpGroupBox As GroupBox)

            For Each ctl As Control In grpGroupBox.Controls

                If TypeOf ctl Is TextBox Then

                    If ctl.Text = Nothing Then
                        MsgBox("Please enter " & ctl.Name.Replace("txt", ""), MsgBoxStyle.Information)
                        ctl.Focus()
                        Exit Sub
                    End If

                End If

            Next

        End Sub

        Public Sub toClearAllTextBoxesInsideGroupBox(ByVal grpGroupBox As GroupBox)

            For Each ctl As Control In grpGroupBox.Controls

                If TypeOf ctl Is TextBox Then

                    ctl.Text = Nothing

                End If

            Next

        End Sub

        Public Shared Function toValidateSelectedValueIsInComboBox(ByVal dropDropdownlist As ComboBox, ByVal strSelectedText As String) As String

            Dim strEqual As String = "No"

            For lintCount As Integer = 0 To dropDropdownlist.Items.Count - 1

                If strSelectedText.ToUpper = dropDropdownlist.Items(lintCount).ToString.ToUpper Then

                    strEqual = "Yes"

                End If

            Next

            Return strEqual

        End Function

        Public Shared Sub toAvoidTypingSpaceInDropDownList(ByVal e As System.Windows.Forms.KeyPressEventArgs)

            If (e.KeyChar = " ") Then
                e.Handled = True
            End If


        End Sub


        '    Public Shared Function toCheckIfThumbReaderConnected() As Boolean

        '        toCheckIfThumbReaderConnected = False

        '        Dim strDeviceName As String
        '        Dim strQuotes As String
        '        Dim arrDeviceNames As Array
        '        Dim USBDevice As System.Management.ManagementObject
        '        Dim objReturnCollection As System.Management.ManagementObjectCollection

        '        'Dim ObjScope As New System.Management.ManagementScope("\\FullNameOfYourComputer\root\cimv2")    'This is optional. Can be used for remote connections.

        '        Dim SearcherUSBDevicesCollection As New System.Management.ManagementObjectSearcher("Select * from Win32_USBControllerDevice")
        '        Dim ReturnUSBDevicesCollection As System.Management.ManagementObjectCollection
        '        ReturnUSBDevicesCollection = SearcherUSBDevicesCollection.Get

        '        'Or
        '        'Dim USBDevicesClass As New System.Management.ManagementClass("Win32_USBControllerDevice")
        '        'Dim ReturnUSBDevicesCollection As System.Management.ManagementObjectCollection = USBDevicesClass.GetInstances()


        '        For Each USBDevice In ReturnUSBDevicesCollection
        '            strDeviceName = USBDevice.Properties("Dependent").Value.ToString()
        '            strQuotes = Chr(34)
        '            strDeviceName = Replace(strDeviceName, strQuotes, "")
        '            arrDeviceNames = Split(strDeviceName, "=")
        '            strDeviceName = arrDeviceNames(1)

        '            Dim objSearcher As New System.Management.ManagementObjectSearcher("Select * From Win32_PnPEntity Where DeviceID = '" & strDeviceName & "'")
        '            objReturnCollection = objSearcher.Get()

        '            Dim objReturn As System.Management.ManagementObject

        '            For Each objReturn In objReturnCollection


        '                If objReturn("Name").ToString().Contains("Futronic") Then

        '                    toCheckIfThumbReaderConnected = True
        '                End If

        '            Next
        '        Next

        '        Return toCheckIfThumbReaderConnected

        '    End Function

    End Class
End Namespace
