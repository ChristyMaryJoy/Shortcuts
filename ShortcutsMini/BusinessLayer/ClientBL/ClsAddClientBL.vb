Imports System.Data.SqlClient

Public Class ClsAddClientBL
    Dim objAddClientDL As New ClsAddClientDL

    Public Function FetchDuplicateClient(ByVal strMobileNo As String, ByVal strClientName As String)
        Return objAddClientDL.FetchDuplicateClient(strMobileNo, strClientName)

    End Function
    Public Sub ClientRegistration(ByVal strFirstName As String, ByVal strMiddlename As String, ByVal strLastname As String, ByVal dtDOB As Date, ByVal strgender As String, ByVal intCountry As Integer, ByVal intOccupation As Integer, ByVal intClientType As Integer, ByVal strClubmemberno As String, ByVal strcivilId As String, ByVal strMobileNo1 As String, ByVal strMobileNo2 As String, ByVal strResidence As String, ByVal stremail As String, ByVal strAddress As String, ByVal strClientnote As String, ByVal strStatus As String, ByVal intCreatedUserID As Integer, ByVal intLocationId As Integer)
        objAddClientDL.ClientRegistration(strFirstName, strMiddlename, strLastname, dtDOB, strgender, intCountry, intOccupation, intClientType, strClubmemberno, strcivilId, strMobileNo1, strMobileNo2, strResidence, stremail, strAddress, strClientnote, strStatus, intCreatedUserID, intLocationId)
    End Sub


    Public Sub UpdateClientDetails(ByVal intClientId As Integer, ByVal strFirstName As String, ByVal strMiddlename As String, ByVal strLastname As String, ByVal dtDOP As Date, ByVal strgender As String, ByVal intNationality As Integer, ByVal intClientType As Integer, ByVal strClubmemberno As String, ByVal strcivilId As String, ByVal strMobileNo1 As String, ByVal strMobileNo2 As String, ByVal strMobileNo3 As String, ByVal stremail As String, ByVal strAddress As String, ByVal strClientnote As String, ByVal strStatus As String, ByVal intCreatedUserID As Integer, ByVal intLocationId As Integer)
        objAddClientDL.UpdateClientDetails(intClientId, strFirstName, strMiddlename, strLastname, dtDOP, strgender, intNationality, intClientType, strClubmemberno, strcivilId, strMobileNo1, strMobileNo2, strMobileNo3, stremail, strAddress, strClientnote, strStatus, intCreatedUserID, intLocationId)
    End Sub
    'To View Customer Info baseed on Search Result
    Public Function ViewClientInfo(ByVal intClientID As Integer) As SqlDataReader
        Return objAddClientDL.ViewClientInfo(intClientID)
    End Function

End Class
