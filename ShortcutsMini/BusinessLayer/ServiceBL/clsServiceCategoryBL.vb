
Imports System.Data.SqlClient

Public Class clsServiceCategoryBL
    Dim objServiceCategoryBL As New clsServiceCategoryDL

  
    Public Sub InsertServiceCategory(ByVal strServiceCategoryName As String, ByVal strStatus As String)
        objServiceCategoryBL.InsertServiceCategory(strServiceCategoryName, strStatus)
    End Sub
    Public Sub UpdateServiceCategory(ByVal intServiceCategoryId As Integer, ByVal strServiceCategoryName As String, ByVal strStatus As String)
        objServiceCategoryBL.UpdateServiceCategory(intServiceCategoryId, strServiceCategoryName, strStatus)
    End Sub
End Class
