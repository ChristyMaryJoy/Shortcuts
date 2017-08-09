
Imports System.Data.SqlClient
Public Class clsSeriesServiceDL
    Dim sqlcommand As SqlCommand


    'to Save New Services
    Public Sub InsertSeriesService(ByVal intServiceId As Integer, ByVal strSeriesServiceName As String, ByVal strSeriesPrice As String, ByVal intSession As Integer, ByVal intDuration As Integer, ByVal intTotalPrice As Integer, ByVal intExpiryMonth As Integer, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertSeriesService"

        sqlcommand.Parameters.AddWithValue("@intServiceId", intServiceId)
        sqlcommand.Parameters.AddWithValue("@vaSeriesServiceName", strSeriesServiceName)
        sqlcommand.Parameters.AddWithValue("@strSeriesPrice", strSeriesPrice)
        sqlcommand.Parameters.AddWithValue("@intSession", intSession)
        sqlcommand.Parameters.AddWithValue("@intDuration", intDuration)
        sqlcommand.Parameters.AddWithValue("@intTotalPrice", intTotalPrice)
        sqlcommand.Parameters.AddWithValue("@intExpiryMonth", intExpiryMonth)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@vaCreatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub
    'to update saved Services
    Public Sub UpdateSeriesService(ByVal intSeriesId As Integer, ByVal strSeriesServiceName As String, ByVal intSeriesPrice As String, ByVal intSession As Integer, ByVal intDuration As Integer, ByVal intTotalPrice As Integer, ByVal intExpiryMonth As Integer, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateSeriesService"

        sqlcommand.Parameters.AddWithValue("@intSeriesId", intSeriesId)
        sqlcommand.Parameters.AddWithValue("@vaSeriesServiceName", strSeriesServiceName)
        sqlcommand.Parameters.AddWithValue("@intSeriesPrice", intSeriesPrice)
        sqlcommand.Parameters.AddWithValue("@intSession", intSession)
        sqlcommand.Parameters.AddWithValue("@intDuration", intDuration)
        sqlcommand.Parameters.AddWithValue("@intTotalPrice", intTotalPrice)
        sqlcommand.Parameters.AddWithValue("@intExpiryMonth", intExpiryMonth)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@vaLastUpdatedBy", BL.PublicVariables.gintEmployeeID)
        sqlcommand.ExecuteNonQuery()
    End Sub
    'to fetch active category
    Public Function FetchActiveCategory() As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchActiveCategory"

        Return sqlcommand.ExecuteReader()

    End Function


    'to fetch all active services based on category
    Public Function FetchServiceBasedOnCategoryandSeries(ByVal intCategoryId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchServiceBasedOnCategoryandSeries"


        sqlcommand.Parameters.AddWithValue("@intCategoryId", intCategoryId)
        Return sqlcommand.ExecuteReader()

    End Function

    'to fetch all series services based on category
    Public Function FetchAllSeriesServicesBasedOnCategory(ByVal intCategoryId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchAllSeriesServicesBasedOnCategory"

        sqlcommand.Parameters.AddWithValue("@intCategoryId", intCategoryId)
        Return sqlcommand.ExecuteReader()

    End Function
    'to fetch all Series based on Services
    Public Function FetchAllSeriesServicesBasedOnService(ByVal intServiceId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchAllSeriesServiceBasedOnService"

        sqlcommand.Parameters.AddWithValue("@intServiceId", intServiceId)
        Return sqlcommand.ExecuteReader()

    End Function

End Class
