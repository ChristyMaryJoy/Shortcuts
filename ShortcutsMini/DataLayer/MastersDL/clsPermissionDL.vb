Imports System.Data.SqlClient

Public Class clsPermissionDL
    Dim sqlcommand As New SqlCommand

    'To Fetch UserGroupID Based on EmployeeID

    Public Function FetchFormPermissionOfAUser(ByVal strFormName As String, ByVal intUserGroupID As Integer)

        sqlcommand = New SqlCommand("FetchFormPermissionOfAUser", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@strFormName", strFormName)
        sqlcommand.Parameters.AddWithValue("@intUserGroupID", intUserGroupID)
        Return SqlCommand.ExecuteReader()

    End Function

End Class
