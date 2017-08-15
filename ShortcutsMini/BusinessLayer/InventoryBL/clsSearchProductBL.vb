
Imports System.Data.SqlClient
Public Class clsSearchProductBL

    Dim objSearchProductDL As New clsSearchProductDL
    'to fetch active suppliers
    Public Function FetchActiveSupplier() As SqlDataReader
        Return objSearchProductDL.FetchActiveSupplier

    End Function
    'to fetch all active companies based on supplier
    Public Function FetchActiveCompaniesBasedonSupplier(ByVal intSupplierId As Integer) As SqlDataReader
        Return objSearchProductDL.FetchActiveCompaniesBasedonSupplier(intSupplierId)

    End Function
    'to fetch all Lines  based on company
    Public Function FetchActiveLinesBasedonCompanies(ByVal intCompanyId As Integer) As SqlDataReader
        Return objSearchProductDL.FetchActiveLinesBasedonCompanies(intCompanyId)

    End Function

    'To View product Info based on Search Result
    Public Function ViewProductDetailsBasedonStatus(ByVal intProductId As Integer, ByVal strStatus As String) As SqlDataReader
        Return objSearchProductDL.ViewProductDetailsBasedonStatus(intProductId, strStatus)
    End Function
End Class
