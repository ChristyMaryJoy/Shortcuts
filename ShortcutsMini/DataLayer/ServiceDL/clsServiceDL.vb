
Imports System.Data.SqlClient
Public Class clsServiceDL
    Dim sqlcommand As SqlCommand

    'to fetch all services based on category
    Public Function FetchAllServicesBasedOnCategory(ByVal intCategoryId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchAllServiceBasedOnCategory"

        sqlcommand.Parameters.AddWithValue("@intCategoryId", intCategoryId)
        Return sqlcommand.ExecuteReader()
    End Function
    'to Save New Services
    Public Sub InsertService(ByVal intCategoryId As Integer, ByVal strServiceName As String, ByVal strServicePrice As String, ByVal intDuration As Integer, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertService"

        sqlcommand.Parameters.AddWithValue("@intCategoryId", intCategoryId)
        sqlcommand.Parameters.AddWithValue("@vastrServiceName", strServiceName)
        sqlcommand.Parameters.AddWithValue("@vaServicePrice", strServicePrice)
        sqlcommand.Parameters.AddWithValue("@intDuration", intDuration)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@vaCreatedBy", BL.PublicVariables.gintEmployeeID)
       
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

    'to update saved Services
    Public Sub UpdateService(ByVal intServiceId As Integer, ByVal strServiceName As String, ByVal strServicePrice As String, ByVal intDuration As Integer, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateService"

        sqlcommand.Parameters.AddWithValue("@intServiceId", intServiceId)
        sqlcommand.Parameters.AddWithValue("@vastrServiceName", strServiceName)
        sqlcommand.Parameters.AddWithValue("@vaServicePrice", strServicePrice)
        sqlcommand.Parameters.AddWithValue("@intDuration", intDuration)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@vaUpdatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub

End Class
