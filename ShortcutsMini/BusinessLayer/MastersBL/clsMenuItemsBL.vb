Imports System.Data.SqlClient


Public Class clsMenuItemsBL


    Dim objMenuItemsDL As New clsMenuItemDL


    'To Fetch MenuItems of UserGroup
    Public Function FetchMenuItemsOfUserGroupDataSet(ByVal intUserGroupID As Integer) As DataSet
        Return objMenuItemsDL.FetchMenuItemsOfUserGroupDataSet(intUserGroupID)
    End Function



End Class
