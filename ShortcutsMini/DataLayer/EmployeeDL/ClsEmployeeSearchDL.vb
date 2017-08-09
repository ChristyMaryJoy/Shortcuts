
Imports System.Data.SqlClient

Public Class ClsEmployeeSearchDL

    Dim sqlcommand As New SqlCommand

    'To Fetch details of UserLogin based on EmployeeId 
    Public Function FetchUserDetailsBasedOnUserID(ByVal intEmployeeId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand("FetchUserDetailsBasedOnUserID", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intEmployeeId", intEmployeeId)

        Return sqlcommand.ExecuteReader()

    End Function


End Class
