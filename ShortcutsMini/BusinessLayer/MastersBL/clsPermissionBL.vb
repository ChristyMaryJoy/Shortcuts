
Imports System.Data.SqlClient

Public Class clsPermissionBL

    Dim objPermissionDL As New clsPermissionDL


    Public Function FetchFormPermissionOfAUser(ByVal strFormName As String, ByVal intUserGroupID As Integer) As SqlDataReader

        Return objPermissionDL.FetchFormPermissionOfAUser(strFormName, intUserGroupID)


    End Function



End Class
