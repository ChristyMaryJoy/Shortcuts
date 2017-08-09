
Imports System.Data.SqlClient

Public Class clsSupplierBL
    Dim objAddSupplierDL As New clsSupplierDL


    Public Sub InsertSupplier(ByVal strServiceCategoryName As String, ByVal strStatus As String)
        objAddSupplierDL.InsertSupplier(strServiceCategoryName, strStatus)
    End Sub
    Public Sub UpdateSupplier(ByVal intServiceCategoryId As Integer, ByVal strServiceCategoryName As String, ByVal strStatus As String)
        objAddSupplierDL.UpdateSupplier(intServiceCategoryId, strServiceCategoryName, strStatus)
    End Sub
End Class
