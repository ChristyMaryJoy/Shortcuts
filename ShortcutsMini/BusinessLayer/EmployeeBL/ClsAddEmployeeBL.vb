
Imports System.Data.SqlClient

Public Class ClsAddEmployeeBL
    Dim objAddEmployeeDL As New ClsAddEmployeeDL

    Public Function FetchDuplicateEmployee(ByVal strMobileNo As String, ByVal strEmployeeName As String)
        Return objAddEmployeeDL.FetchDuplicateEmployee(strMobileNo, strEmployeeName)

    End Function
    Public Sub EmployeeRegistration(ByVal strFirstName As String, ByVal strMiddlename As String, ByVal strLastname As String, ByVal dtDOB As Date, ByVal intAge As Integer, ByVal strgender As String, ByVal intDesignation As Integer, ByVal intNationality As Integer, ByVal strcivilId As String, ByVal strMobileNo1 As String, ByVal strMobileNo2 As String, ByVal stremail As String, ByVal strAddress As String, ByVal strEmployeenote As String, ByVal strStatus As String, ByVal intCreatedUserID As Integer, ByVal intUsergroupId As Integer, ByVal strUserName As String, ByVal strPassword As String, ByVal intLocationId As Integer)
        'objAddEmployeeDL.EmployeeRegistration(strFirstName, strMiddlename, strLastname, dtDOB, intAge, strgender, intDesignation, intNationality, strcivilId, strMobileNo1, strMobileNo2, stremail, strAddress, strEmployeenote, strStatus, intCreatedUserID, intUsergroupId, strUserName, strPassword, intLocationId)
    End Sub


    Public Sub UpdateEmployeeDetails(ByVal intEmployeeId As Integer, ByVal strFirstName As String, ByVal strMiddlename As String, ByVal strLastname As String, ByVal dtDOP As Date, ByVal strgender As String, ByVal intNationality As Integer, ByVal intEmployeeType As Integer, ByVal strClubmemberno As String, ByVal strcivilId As String, ByVal strMobileNo1 As String, ByVal strMobileNo2 As String, ByVal strMobileNo3 As String, ByVal stremail As String, ByVal strAddress As String, ByVal strEmployeenote As String, ByVal strStatus As String, ByVal intCreatedUserID As Integer, ByVal intLocationId As Integer)

        objAddEmployeeDL.UpdateEmployeeDetails(intEmployeeId, strFirstName, strMiddlename, strLastname, dtDOP, strgender, intNationality, intEmployeeType, strClubmemberno, strcivilId, strMobileNo1, strMobileNo2, strMobileNo3, stremail, strAddress, strEmployeenote, strStatus, intCreatedUserID, intLocationId)
    End Sub
    'To View Customer Info baseed on Search Result
    Public Function ViewEmployeeInfo(ByVal intEmployeeID As Integer) As SqlDataReader
        Return objAddEmployeeDL.ViewEmployeeInfo(intEmployeeID)
    End Function

End Class

