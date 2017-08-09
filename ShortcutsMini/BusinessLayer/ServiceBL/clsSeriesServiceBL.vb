Imports System.Data.SqlClient
Public Class clsSeriesServiceBL
    Dim objSeriesServiceDL As New clsSeriesServiceDL

    'to insert new services
    Public Sub InsertSeriesService(ByVal intServiceId As Integer, ByVal strSeriesServiceName As String, ByVal intSeriesPrice As Integer, ByVal intSession As Integer, ByVal intDuration As Integer, ByVal intTotalPrice As Integer, ByVal intExpiryMonth As Integer, ByVal strStatus As String)
        objSeriesServiceDL.InsertSeriesService(intServiceId, strSeriesServiceName, intSeriesPrice, intSession, intDuration, intTotalPrice, intExpiryMonth, strStatus)
    End Sub
    'to update services
    Public Sub UpdateSeriesService(ByVal intSeriesId As Integer, ByVal strSeriesServiceName As String, ByVal intSeriesPrice As Integer, ByVal intSession As Integer, ByVal intDuration As Integer, ByVal intTotalPrice As Integer, ByVal intExpiryMonth As Integer, ByVal strStatus As String)
        objSeriesServiceDL.UpdateSeriesService(intSeriesId, strSeriesServiceName, intSeriesPrice, intSession, intDuration, intTotalPrice, intExpiryMonth, strStatus)
    End Sub
    'to fetch active category
    Public Function FetchActiveCategory() As SqlDataReader
        Return objSeriesServiceDL.FetchActiveCategory()

    End Function
    'to fetch all active services based on category
    Public Function FetchServiceBasedOnCategoryandSeries(ByVal intCategoryId As Integer) As SqlDataReader
        Return objSeriesServiceDL.FetchServiceBasedOnCategoryandSeries(intCategoryId)

    End Function
    'to fetch all series services based on category
    Public Function FetchAllSeriesServicesBasedOnCategory(ByVal intCategoryId As Integer) As SqlDataReader
        Return objSeriesServiceDL.FetchAllSeriesServicesBasedOnCategory(intCategoryId)

    End Function
    'to fetch all series services based on services
    Public Function FetchAllSeriesServicesBasedOnService(ByVal intServiceId As Integer) As SqlDataReader
        Return objSeriesServiceDL.FetchAllSeriesServicesBasedOnService(intServiceId)

    End Function


End Class
