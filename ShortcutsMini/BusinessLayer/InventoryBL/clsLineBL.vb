Imports System.Data.SqlClient
Public Class clsLineBL

   
    Dim objLineDL As New clsLineDL

    'to insert new Line
    Public Sub InsertLine(ByVal intCompanyId As Integer, ByVal strLineName As String, ByVal strStatus As String)

        objLineDL.InsertLine(intCompanyId, strLineName, strStatus)
    End Sub
    'to update line
    Public Sub UpdateLine(ByVal intLineId As Integer, ByVal strLineName As String, ByVal strStatus As String)
        objLineDL.UpdateLine(intLineId, strLineName, strStatus)
    End Sub
    'to fetch active suppliers
    Public Function FetchActiveSupplier() As SqlDataReader
        Return objLineDL.FetchActiveSupplier

    End Function
    'to fetch all active companies based on supplier
    Public Function FetchActiveCompaniesBasedonSupplier(ByVal intSupplierId As Integer) As SqlDataReader
        Return objLineDL.FetchActiveCompaniesBasedonSupplier(intSupplierId)

    End Function
    'to fetch all Lines  based on company
    Public Function FetchAllLinesBasedonCompanies(ByVal intCompanyId As Integer) As SqlDataReader
        Return objLineDL.FetchAllLinesBasedonCompanies(intCompanyId)

    End Function
    'to fetch all Lines  based on supplier
    Public Function FetchAllLinesBasedonSuppliers(ByVal intSuppliersId As Integer) As SqlDataReader
        Return objLineDL.FetchAllLinesBasedonSuppliers(intSuppliersId)

    End Function
End Class
