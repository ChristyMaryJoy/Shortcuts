Imports System.Data.SqlClient
Public Class clsUserGroupBL


    Dim objUserGroupBL As New clsUserGroupDL
    'To Fetch Usergroup based on Employee
    Public Function FetchUserGroupBasedOnEmployeeID(ByVal intEmployeeId As Integer) As Integer

        Return objUserGroupBL.FetchUserGroupBasedOnEmployeeID(intEmployeeId)

    End Function


    'To Fetch Usergroup based on Employee
    Public Function FetchUserGroupBasedOnUserGroupID(ByVal intUserGroupId As String) As SqlDataReader

        Return objUserGroupBL.FetchUserGroupBasedOnUserGroupID(intUserGroupId)

    End Function


End Class
