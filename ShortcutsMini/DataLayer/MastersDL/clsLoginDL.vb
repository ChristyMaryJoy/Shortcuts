
Imports System.Data.SqlClient
Public Class clsLoginDL
    Dim sqlcommand As SqlCommand

    'To Fetch Login based on Username and Password 
    Public Function FetchLoginBasedOnUserNameandPassword(ByVal strUserName As String, ByVal strPassword As String) As SqlDataReader
        sqlcommand = New SqlCommand("FetchLoginBasedOnUserNameandPassword", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@strUserName", strUserName)
        sqlcommand.Parameters.AddWithValue("@strPassword", strPassword)
        Return sqlcommand.ExecuteReader()

    End Function
End Class
