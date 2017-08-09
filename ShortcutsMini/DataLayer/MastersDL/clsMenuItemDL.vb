
Imports System.Data.SqlClient
Public Class clsMenuItemDL


    Dim sqlcommand As New SqlCommand

    'To Fetch MenuItems of UserGroup
    Public Function FetchMenuItemsOfUserGroupDataSet(ByVal intUserGroupID As Integer) As DataSet

        FetchMenuItemsOfUserGroupDataSet = New DataSet


        sqlcommand = New SqlCommand("FetchMenuItemsOfUserGroup", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intUserTypeId", intUserGroupID)
        Dim sqlAdapter As SqlDataAdapter
        sqlAdapter = New SqlDataAdapter(sqlcommand)
        sqlAdapter.Fill(FetchMenuItemsOfUserGroupDataSet, "MenuItems")


        Return FetchMenuItemsOfUserGroupDataSet

    End Function


End Class

