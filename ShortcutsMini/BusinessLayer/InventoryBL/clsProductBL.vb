Imports System.Data.SqlClient
Public Class clsProductBL

    Dim objProductDL As New clsProductDL

    'to insert new Line
    Public Sub InsertProduct(ByVal intLineId As Integer, ByVal strProductName As String, ByVal strProductCode As String, ByVal strBarcode As String, ByVal intBuyPrice As Integer, ByVal intSellPrice As Integer, ByVal intRetail As Integer, ByVal strStatus As String)

        objProductDL.InsertProduct(intLineId, strProductName, strProductCode, strBarcode, intBuyPrice, intSellPrice, intRetail, strStatus)
    End Sub
    'to update line
    Public Sub UpdateProduct(ByVal intProductId As Integer, ByVal strProductName As String, ByVal strProductCode As String, ByVal strBarcode As String, ByVal intBuyPrice As Integer, ByVal intSellPrice As Integer, ByVal intRetail As Integer, ByVal strStatus As String)
        objProductDL.UpdateProduct(intProductId, strProductName, strProductCode, strBarcode, intBuyPrice, intSellPrice, intRetail, strStatus)
    End Sub
    'to fetch active suppliers
    Public Function FetchActiveSupplier() As SqlDataReader
        Return objProductDL.FetchActiveSupplier

    End Function
    'to fetch all active companies based on supplier
    Public Function FetchActiveCompaniesBasedonSupplier(ByVal intSupplierId As Integer) As SqlDataReader
        Return objProductDL.FetchActiveCompaniesBasedonSupplier(intSupplierId)

    End Function
    'to fetch all Lines  based on company
    Public Function FetchActiveLinesBasedonCompanies(ByVal intCompanyId As Integer) As SqlDataReader
        Return objProductDL.FetchActiveLinesBasedonCompanies(intCompanyId)

    End Function

    'To View product Info based on Search Result
    Public Function ViewProductInfo(ByVal intProductId As Integer) As SqlDataReader
        Return objProductDL.ViewProductInfo(intProductId)
    End Function
End Class
