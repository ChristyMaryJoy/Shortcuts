Imports System.Data.SqlClient


Public Class ClsEmployeeSearchBL

    Dim objStaffSearchBL As New ClsEmployeeSearchDL

    'To Fetch UserDetails  based on EmployeeID
    Public Function FetchUserDetailsBasedOnUserID(ByVal intEmployeeId As Integer) As SqlDataReader

        Return objStaffSearchBL.FetchUserDetailsBasedOnUserID(intEmployeeId)

    End Function
End Class
