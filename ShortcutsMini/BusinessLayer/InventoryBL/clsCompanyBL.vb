Imports System.Data.SqlClient
Public Class clsCompanyBL
    Dim objAddCompanyDL As New clsCompanyDL


    Public Sub InsertCompany(ByVal intSupplierId As Integer, ByVal strCompanyName As String, ByVal strStatus As String)
        objAddCompanyDL.InsertCompany(intSupplierId, strCompanyName, strStatus)
    End Sub
    Public Sub UpdateCompany(ByVal intCompanyId As Integer, ByVal strCompanyName As String, ByVal strStatus As String)
        objAddCompanyDL.UpdateCompany(intCompanyId, strCompanyName, strStatus)
    End Sub

    Public Function FetchActiveSupplier() As SqlDataReader
        Return objAddCompanyDL.FetchActiveSupplier

    End Function
    Public Function FetchAllCompaniesBasedonSupplier(ByVal intSupplierId As Integer) As SqlDataReader
        Return objAddCompanyDL.FetchAllCompaniesBasedonSupplier(intSupplierId)
    End Function
End Class
