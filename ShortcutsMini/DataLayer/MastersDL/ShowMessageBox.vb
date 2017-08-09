Namespace BL

#Region "About Author and Class Description"
    '*********************************************************************
    'Author         :   Jaison D.Thomas
    'Date           :   Monday, February 2, 2009
    'Description    :   This class create commonly used messageboxes, this 
    'provide the reusablity. Here we custmize messageboxes meet our project standards.
    '*********************************************************************


    'Modified By    :Ashok R 
    'Reason         :Change Function Names For Clarity
    '               :1. Change the name of the function "toSavedSuccesfully" to "toSavedSuccesfully"
    '               :2. Change the name of the function "toMandatoryFieldsCompleted" to
    '                   "toMandatoryFieldsCompleted"
    '               :3. Change the name of the function "showGeneralInformativeMessageBox" to 
    '                       "toGeneralInformation"
    '               :4. Change the name of the function "showErrorMessageBox" to "toError"
    '               :5. Change the name of  function "toUpdateSuccesfully" to "toUpdateSuccesfully"
    '               :5. Change the name of the function "toConfirmDelete" to "toConfirmDelete"
    '               :6. Change the name of the function "isOkOrCancel" to "isOkOrCancel"

#End Region

#Region "MessageBoxes Category Descriptions"

    'Messageboxes Category
    '-----------------------
    'Saved Succesfully MessageBox : This messagebox invoke when user save the the details      'succesfully.
    'Mandatory Informative MessageBox : This messagebox displayed while user forgot any         mandatory field.
    'General Informative MessageBox : This provide some general  valuble information to the     user.
    'Error MessageBox: This box will display when something went wrong.
    'Update MessageBox : This message box displayed while an update operation done.
    'Confirm Delete Action MessageBox : Message box display before a delete operation,      ' this make sure that user really need to delete.
#End Region



#Region "Show Custom MessageBoxes"

    Public Class ShowMessageBox
        Public Shared MESSAGE_TITLE As String
#Region "MessageBox Title and Text"
        'Mention the messagebox Title,and Message text, this allow the programmer to        'create messagebox with a uniform title and text.
        Public Const MESSAGEBOX_TITLE As String = "KOSERP"
        Public Const SUCCESS_MESSAGE As String = "You saved successfully"
        Public Const INFORMATION_MESSAGE As String = "Complete the"
        Public Const UPDATE_MESSAGE As String = "You updated successfully"
        Public Const DELETE_MESSAGE As String = "Are you sure, you want to delete"
        Public Const UNAUTHORIZED_ACTION As String = "You have no permission to perform this action"

#End Region
#Region "New Variables"

        Private Shared ReturnValue As Integer
        Private Shared _prompt = New Form()
#End Region

        'This messagebox invoke when the user saved some details succesfully,
        'this inform the user wheather he saved the details succesfully.
        Public Shared Sub toSavedSuccesfully()
            MessageBox.Show(SUCCESS_MESSAGE, MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Shared Sub toShowUnauthorizedAction()
            MessageBox.Show(UNAUTHORIZED_ACTION, MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Sub
        'This messagebox display if user fail to complete a mandatory fields, this                 'assist the user to complete the mandatory field, and do the job succesfully.
        'parameter  :   The name of mandatory field        
        Public Shared Sub toMandatoryFieldsCompleted(ByVal lstrMandatoryFieldName As String)
            MessageBox.Show(INFORMATION_MESSAGE + " " + lstrMandatoryFieldName, MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Sub
        'Informative messagebox displays , in case user need some information,
        'which assist him to work correctly.. with out much confusions.
        'Parameter  : The information which is to be informed.
        Public Shared Sub toGeneralInformation(ByVal lstrInformation As String)
            MessageBox.Show(lstrInformation, MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        'This messagebox should be displayed, while some thing went wrong,
        'this help the user to identify that.., something really went wrong.
        'Parameter  : The error details.
        Public Shared Sub toError(ByVal lstrErrorInformation As String)
            MessageBox.Show(lstrErrorInformation, MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        'This messagebox displayed while a user finished the upadate operation successfully        ',user immediately get the status.
        Public Shared Sub toUpdateSuccesfully()
            MessageBox.Show(UPDATE_MESSAGE, MESSAGEBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        'This messagebox give a confirmation message before a delete operation, this ask           'the user wheather he want to delete? or not?
        'This fuction returns a TRUE value if the user press the OK button,else it returns 
        'a FALSE value.
        Public Shared Function toConfirmDelete() As Boolean
            'If user press the OK button, he can delete the information, 
            'otherwise, he can cancel the delete operation.
            If (MessageBox.Show(DELETE_MESSAGE, MESSAGEBOX_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.OK) Then
                Return True
            Else
                Return False
            End If
        End Function
        ' Author  : jacob
        'date     :25-2-2009

        ''this messagebox is used to give a confirmation message before a process, this asks user whether he wants to YES or No 
        Public Shared Function isYesOrNo(ByVal lstrInformation As String) As Boolean
            'If user press the YES button, he can do according to the message box information, 
            'otherwise,if No button, he can cancel the  operation.
            If (MessageBox.Show(lstrInformation, MESSAGE_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes) Then
                Return True
            Else
                Return False
            End If
        End Function

        ' Author  : jacob
        'date     :25-5-2009

        ''this messagebox is used to give a confirmation message before a process, this asks user whether he wants to OK or Cancel 
        Public Shared Function isOkOrCancel(ByVal lstrInformation As String) As Boolean
            'If user press the OK button, he can do according to the message box information, 
            'otherwise, he can cancel the  operation.
            If (MessageBox.Show(lstrInformation, MESSAGE_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK) Then
                Return True
            Else
                Return False
            End If
        End Function

        'Author  : Abhith
        'Date     :12-06-2013

        ''this messagebox used to give a confirm choice message, and is customized to have 2 custom button along with a cancel button this asks user whether he wants 1st option or 2nd option or need to Cancel 
        Public Shared Function IsOneOrTwoOrZero(ByVal lstrInformation As String, ByVal lstrMsgButtonOneText As String, ByVal lstrMsgButtonTwoText As String) As Integer
            'receive purchase order
            _prompt = New Form() With { _
             .Left = 25, _
              .Top = 2, _
              .Width = 500, _
              .Height = 130, _
              .StartPosition = FormStartPosition.CenterScreen, .Location = New Point(100, 100), .ControlBox = False}
            Dim lblInformation = New Label() With { _
              .Left = 50, _
              .Top = 20, _
              .Width = 400, _
              .Text = lstrInformation _
            }

            Dim msgButtonOne = New Button() With { _
              .Text = lstrMsgButtonOneText, _
              .Left = 50, _
              .Width = 80, _
              .Top = 50 _
            }
            Dim msgButtonTwo = New Button() With { _
              .Text = lstrMsgButtonTwoText, _
              .Left = 200, _
              .Width = 80, _
              .Top = 50 _
            }
            Dim msgButtonCancel = New Button() With { _
              .Text = "Cancel", _
              .Left = 350, _
              .Width = 80, _
              .Top = 50 _
            }
            AddHandler msgButtonOne.Click, AddressOf Return1
            AddHandler msgButtonTwo.Click, AddressOf Return2
            AddHandler msgButtonCancel.Click, AddressOf Return0

            _prompt.Controls.Add(msgButtonOne)
            _prompt.Controls.Add(msgButtonTwo)
            _prompt.Controls.Add(msgButtonCancel)
            _prompt.Controls.Add(lblInformation)
            _prompt.ShowDialog()
            Return ReturnValue
        End Function
        'part of IsOneOrTwoOrZero : indicating cancel click
        Private Shared Sub Return0()
            ReturnValue = 0
            _prompt.Close()
        End Sub
        'part of IsOneOrTwoOrZero : indicating msgButtonOne click
        Private Shared Sub Return1()
            ReturnValue = 1
            _prompt.Close()
        End Sub
        'part of IsOneOrTwoOrZero : indicating msgButtonTwo click
        Private Shared Sub Return2()
            ReturnValue = 2
            _prompt.Close()
        End Sub

    End Class

#End Region
End Namespace

