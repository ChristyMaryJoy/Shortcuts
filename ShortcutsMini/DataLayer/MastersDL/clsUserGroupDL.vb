
Imports System.Data.SqlClient

Public Class clsUserGroupDL

    Dim sqlcommand As New SqlCommand

    'To Fetch UserGroupID Based on EmployeeID
    Public Function FetchUserGroupBasedOnEmployeeID(ByVal intEmployeeId As Integer) As Integer

        sqlcommand = New SqlCommand("FetchUserGroupBasedOnEmployeeID", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intEmployeeId", intEmployeeId)
        Return sqlcommand.ExecuteScalar()
       
    End Function
    'To 
    'Fetch UserGroupName based on UserGroupId
    Public Function FetchUserGroupBasedOnUserGroupID(ByVal intUserGroupId As Integer) As SqlDataReader
        sqlcommand = New SqlCommand("FetchUserGroupBasedOnUserGroupID", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intUserGroupId", intUserGroupId)
        Return sqlcommand.ExecuteReader()
    End Function


End Class
