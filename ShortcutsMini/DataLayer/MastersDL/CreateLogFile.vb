Imports System
Imports System.IO

Module CreateLogFile
    'Mention the error types, this make the user aware about type of error.
    Public Const MESSAGE_ERROR_CRITICAL = "Critical"
    Public Const MESSAGE_ERROR_WARNING = "Warning"
    Public Const MESSAGE_INFORMATION = "Information"
    Public Const MESSAGE_TITLE As String = "BIZ EIZ"

    'This fuction create the log file and write the information regarding the
    'operation.It helps to  handle the exceptions and help to figure out
    'later "what went wrong.."
    'Parameters : Error Message, Error Type,Form name, From where error arised,
    'Error number.
    Public Sub WritetoLogFile(ByVal strErrMessage As String, ByVal strErrType As String, Optional ByVal lstrFormName As String = "", Optional ByVal strCalledin As String = "0", Optional ByVal strErrNumber As String = "0")
        Try
            'MsgBox(strErrMessage)
            Dim streamWriterInfo As StreamWriter
            'In case user fail to mention from where the error erased,its optional.
            ' show the user the following message "Function not specified.
            If Trim(strCalledin) = "" Then
                strCalledin = "Procedure/Function not specified"
            End If
            'In case user fail to mention the error number, 
            'inform him with following message. "Error number not specified.
            If Trim(strErrNumber) = "0" Then
                strErrNumber = "Error number not specified"
            End If
            'When application start check for the "Logfile" ,if in case not created
            'create a new "Logfile" and write the information given by the user
            If Not File.Exists(Application.StartupPath & "\VC_Logfile.txt") = True Then
                streamWriterInfo = New StreamWriter(Application.StartupPath & "\VC_Logfile.txt")
                ProcessLog(strErrMessage & "||" & strErrType & "||" & "||" & lstrFormName & "||" & strCalledin & "||" & strErrNumber, streamWriterInfo)
                streamWriterInfo.Close()
            Else
                'If already a "Logfile" exist then append the text so that new information                 ' can be written in a well format.So that each line can stand apart from 
                'others
                streamWriterInfo = File.AppendText(Application.StartupPath & "\VC_Logfile.txt")
                'Writting the details into logfile, this information can be verified by 
                'user later ,so that he can figure out what went wrong.
                'This include data, month , errortype, from where the error happend.
                ProcessLog(strErrMessage & "||" & strErrType & "||" & "||" & lstrFormName & "||" & strCalledin & "||" & strErrNumber, streamWriterInfo)
                streamWriterInfo.Close()
            End If
            streamWriterInfo.Dispose()
        Catch ex As Exception
            MsgBox("Error happened while writing to log file")
        End Try
    End Sub

    Private Sub ProcessLog(ByVal strLogMessage As String, ByVal twrLogFile As TextWriter)
        Try
            'Writing the details to logfile, this informations can be verifyed by the user             'later,it include, date and time. 
            With twrLogFile
                .Write(ControlChars.CrLf & "Log Entry : ")
                .WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString())
                .WriteLine("  {0}", strLogMessage)
                .WriteLine("-------------------------------")
                .Flush()
            End With
            'If something went while writting to log file ,display the user with a 
            'a messagebox.
        Catch ex As Exception
            MsgBox("Error happened while writing to log file (ProcessLog)")
        End Try
    End Sub
End Module
