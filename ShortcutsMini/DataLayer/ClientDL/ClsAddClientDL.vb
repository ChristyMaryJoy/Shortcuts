Imports System.Data.SqlClient

Public Class ClsAddClientDL

    Dim sqlcommand As SqlCommand

    'to find duplicate Clients
    Public Function FetchDuplicateClient(ByVal strMobileNo As String, ByVal strClientName As String) As SqlDataReader
        sqlcommand = New SqlCommand("FetchDuplicateClient", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@vaMobileNo", strMobileNo)
        sqlcommand.Parameters.AddWithValue("@vaClientName", strClientName)
        Return sqlcommand.ExecuteReader()
    End Function


    Public Sub ClientRegistration(ByVal strFirstName As String, ByVal strMiddlename As String, ByVal strLastname As String, ByVal dtDOB As Date, ByVal strgender As String, ByVal intCountry As Integer, ByVal intOccupation As Integer, ByVal intClientType As Integer, ByVal strClubmemberno As String, ByVal strcivilId As String, ByVal strMobileNo1 As String, ByVal strMobileNo2 As String, ByVal strResidence As String, ByVal stremail As String, ByVal strAddress As String, ByVal strClientnote As String, ByVal strStatus As String, ByVal intCreatedUserID As Integer, ByVal intLocationId As Integer)
        ServerConnection()

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertClientDetails"

        sqlcommand.Parameters.AddWithValue("@vaFirstName", strFirstName)
        sqlcommand.Parameters.AddWithValue("@vaMiddlename", strMiddlename)
        sqlcommand.Parameters.AddWithValue("@vaLastname", strLastname)
        sqlcommand.Parameters.AddWithValue("@dtDOB", dtDOB)
        sqlcommand.Parameters.AddWithValue("@vagender", strgender)
        sqlcommand.Parameters.AddWithValue("@intCountry", intCountry)
        sqlcommand.Parameters.AddWithValue("@intOccupation", intOccupation)
        sqlcommand.Parameters.AddWithValue("@intClientType", intClientType)
        sqlcommand.Parameters.AddWithValue("@vaClubmemberno", strClubmemberno)
        sqlcommand.Parameters.AddWithValue("@vaCivilId", strcivilId)
        sqlcommand.Parameters.AddWithValue("@vaMobileNo1", strMobileNo1)
        sqlcommand.Parameters.AddWithValue("@vaMobileNo2", strMobileNo2)
        sqlcommand.Parameters.AddWithValue("@vastrResidence", strResidence)
        sqlcommand.Parameters.AddWithValue("@vaemail", stremail)
        sqlcommand.Parameters.AddWithValue("@vaAddress", strAddress)
        sqlcommand.Parameters.AddWithValue("@vaClientnote", strClientnote)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intCreatedUserID", intCreatedUserID)
        sqlcommand.Parameters.AddWithValue("@LocationId", intLocationId)

        sqlcommand.ExecuteNonQuery()
    End Sub


    Public Sub UpdateClientDetails(ByVal intClientId As Integer, ByVal strFirstName As String, ByVal strMiddlename As String, ByVal strLastname As String, ByVal dtDOP As Date, ByVal strgender As String, ByVal intNationality As Integer, ByVal intClientType As Integer, ByVal strClubmemberno As String, ByVal strcivilId As String, ByVal strMobileNo1 As String, ByVal strMobileNo2 As String, ByVal strMobileNo3 As String, ByVal stremail As String, ByVal strAddress As String, ByVal strClientnote As String, ByVal strStatus As String, ByVal intUpdatedUserID As Integer, ByVal intLocationId As Integer)
        ServerConnection()

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateClientDetails"

        sqlcommand.Parameters.AddWithValue("@intClientId", intClientId)
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
        sqlcommand.Parameters.AddWithValue("@vaClientnote", strClientnote)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intUpdatedUserID ", intUpdatedUserID)
        sqlcommand.Parameters.AddWithValue("@LocationId", intLocationId)

        sqlcommand.ExecuteNonQuery()
    End Sub

    'To View Client Info based on Search Result
    Public Function ViewClientInfo(ByVal intClientID As Integer) As SqlDataReader
        sqlcommand = New SqlCommand("FetchClientDetails", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intClientId", intClientID)

        Return sqlcommand.ExecuteReader()
    End Function

End Class
