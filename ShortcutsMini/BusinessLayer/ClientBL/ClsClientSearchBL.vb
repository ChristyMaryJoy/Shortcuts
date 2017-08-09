
Imports System.Data.SqlClient
Public Class ClsClientSearchBL
    Dim objClientSearchDL As New ClsClientSearchDL

    Public Function FetchClientDetailsBasedonCriteria(ByVal intCriteria As String, ByVal intClientMobNo As Integer, ByVal strClientName As String) As SqlDataReader

        Return objClientSearchDL.FetchClientDetailsBasedonCriteria(intCriteria, intClientMobNo, strClientName)

    End Function
End Class
