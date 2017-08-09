Imports System.Data.SqlClient
Public Class clsLoginBL

    Dim objLoginDL As New clsLoginDL

    'To Fetch Login based on Username and Password 
    Public Function FetchLoginBasedOnUserNameandPassword(ByVal strUserName As String, ByVal strPassword As String) As SqlDataReader
        Return objLoginDL.FetchLoginBasedOnUserNameandPassword(strUserName, strPassword)
    End Function


End Class
