

Imports System.Data.SqlClient
Public Class ClsAddEmployeeDL
    Dim sqlcommand As SqlCommand

    'to find duplicate Employees
    Public Function FetchDuplicateEmployee(ByVal intUserGroupId As Integer, ByVal strEmployeeName As String) As SqlDataReader
        sqlcommand = New SqlCommand("FetchDuplicateEmployee", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intUserGroupId", intUserGroupId)
        sqlcommand.Parameters.AddWithValue("@vaEmployeeName", strEmployeeName)
        Return sqlcommand.ExecuteReader()
    End Function


    Public Sub EmployeeRegistration(ByVal strFirstName As String, ByVal strMiddlename As String, ByVal strLastname As String, ByVal dtDOB As Date, ByVal intAge As Integer, ByVal strgender As String, ByVal intDesignation As Integer, ByVal intNationality As Integer, ByVal strcivilId As String, ByVal strMobileNo1 As String, ByVal strMobileNo2 As String, ByVal stremail As String, ByVal strAddress As String, ByVal strEmployeenote As String, ByVal strStatus As String, ByVal intCreatedUserID As Integer, ByVal intUsergroupId As Integer, ByVal strUserName As String, ByVal strPassword As String, ByVal intLocationId As Integer)
        ServerConnection()

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertEmployeeDetails"

        'sqlcommand.Parameters.AddWithValue("@vaFirstName", strFirstName)
        'sqlcommand.Parameters.AddWithValue("@vaMiddlename", strMiddlename)
        'sqlcommand.Parameters.AddWithValue("@vaLastname", strLastname)
        'sqlcommand.Parameters.AddWithValue("@dtDOB", dtDOB)
        'sqlcommand.Parameters.AddWithValue("@vagender", strgender)
        'sqlcommand.Parameters.AddWithValue("@intCountry", intCountry)
        'sqlcommand.Parameters.AddWithValue("@intOccupation", intOccupation)
        'sqlcommand.Parameters.AddWithValue("@intEmployeeType", intEmployeeType)
        'sqlcommand.Parameters.AddWithValue("@vaClubmemberno", strClubmemberno)
        'sqlcommand.Parameters.AddWithValue("@vaCivilId", strcivilId)
        'sqlcommand.Parameters.AddWithValue("@vaMobileNo1", strMobileNo1)
        'sqlcommand.Parameters.AddWithValue("@vaMobileNo2", strMobileNo2)
        'sqlcommand.Parameters.AddWithValue("@vastrResidence", strResidence)
        'sqlcommand.Parameters.AddWithValue("@vaemail", stremail)
        'sqlcommand.Parameters.AddWithValue("@vaAddress", strAddress)
        'sqlcommand.Parameters.AddWithValue("@vaEmployeenote", strEmployeenote)
        'sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        'sqlcommand.Parameters.AddWithValue("@intCreatedUserID", intCreatedUserID)
        'sqlcommand.Parameters.AddWithValue("@LocationId", intLocationId)

        sqlcommand.ExecuteNonQuery()
    End Sub


    Public Sub UpdateEmployeeDetails(ByVal intEmployeeId As Integer, ByVal strFirstName As String, ByVal strMiddlename As String, ByVal strLastname As String, ByVal dtDOP As Date, ByVal strgender As String, ByVal intNationality As Integer, ByVal intEmployeeType As Integer, ByVal strClubmemberno As String, ByVal strcivilId As String, ByVal strMobileNo1 As String, ByVal strMobileNo2 As String, ByVal strMobileNo3 As String, ByVal stremail As String, ByVal strAddress As String, ByVal strEmployeenote As String, ByVal strStatus As String, ByVal intUpdatedUserID As Integer, ByVal intLocationId As Integer)
        ServerConnection()

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateEmployeeDetails"

        sqlcommand.Parameters.AddWithValue("@intEmployeeId", intEmployeeId)
        sqlcommand.Parameters.AddWithValue("@vaFirstName", strFirstName)
        sqlcommand.Parameters.AddWithValue("@vaMiddlename", strMiddlename)

        sqlcommand.Parameters.AddWithValue("@intNationality", intNationality)
        sqlcommand.Parameters.AddWithValue("@vaClubmemberno", strClubmemberno)
        sqlcommand.Parameters.AddWithValue("@vacivilId", strcivilId)
        sqlcommand.Parameters.AddWithValue("@vaMobileNo1", strMobileNo1)
        sqlcommand.Parameters.AddWithValue("@vaMobileNo2", strMobileNo2)
        sqlcommand.Parameters.AddWithValue("@vaMobileNo2", strMobileNo2)
        sqlcommand.Parameters.AddWithValue("@vaemail", stremail)
        sqlcommand.Parameters.AddWithValue("@vaAddress", strAddress)
        sqlcommand.Parameters.AddWithValue("@vaEmployeenote", strEmployeenote)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intUpdatedUserID ", intUpdatedUserID)
        sqlcommand.Parameters.AddWithValue("@LocationId", intLocationId)

        sqlcommand.ExecuteNonQuery()
    End Sub

    'To View Employee Info based on Search Result
    Public Function ViewEmployeeInfo(ByVal intEmployeeID As Integer) As SqlDataReader
        sqlcommand = New SqlCommand("FetchEmployeeDetails", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intEmployeeId", intEmployeeID)

        Return sqlcommand.ExecuteReader()
    End Function

End Class


