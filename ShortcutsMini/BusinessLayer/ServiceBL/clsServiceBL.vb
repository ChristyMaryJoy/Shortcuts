Imports System.Data.SqlClient

Public Class clsServiceBL
    Dim objServiceDL As New clsServiceDL

    Public Function FetchAllServicesBasedOnCategory(ByVal intServiceCategory As Integer) As SqlDataReader
        Return objServiceDL.FetchAllServicesBasedOnCategory(intServiceCategory)

    End Function
    Public Sub InsertService(ByVal intCategoryId As Integer, ByVal strServiceName As String, ByVal strServicePrice As String, ByVal intDuration As Integer, ByVal strStatus As String)
        objServiceDL.InsertService(intCategoryId, strServiceName, strServicePrice, intDuration, strStatus)
    End Sub
    Public Function FetchActiveCategory() As SqlDataReader
        Return objServiceDL.FetchActiveCategory()

    End Function
    Public Sub UpdateService(ByVal intServiceId As Integer, ByVal strServiceName As String, ByVal strServicePrice As String, ByVal intDuration As Integer, ByVal strStatus As String)
        objServiceDL.UpdateService(intServiceId, strServiceName, strServicePrice, intDuration, strStatus)
    End Sub
    
End Class
