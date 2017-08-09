Imports System.Data.SqlClient
Public Class ClsClientSearchDL
    Dim sqlcommand As New SqlCommand


    Public Function FetchClientDetailsBasedonCriteria(ByVal intCriteria As String, ByVal intClientMobNo As Integer, ByVal strClientName As String) As SqlDataReader
        sqlcommand = New SqlCommand("FetchClientDetailsBasedonCriteria", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@vaCriteria", intCriteria)
        sqlcommand.Parameters.AddWithValue("@intMobileNo", intClientMobNo)
        sqlcommand.Parameters.AddWithValue("@vaClientname", strClientName)
        Return sqlcommand.ExecuteReader()

    End Function
End Class
