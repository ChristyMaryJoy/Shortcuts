Imports System.Data.SqlClient


Public Class clsServiceCategoryDL

    Dim sqlcommand As SqlCommand

 

    Public Sub InsertServiceCategory(ByVal strServiceCategoryName As String, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertServiceCategory"

        sqlcommand.Parameters.AddWithValue("@vaServiceCategoryName", strServiceCategoryName)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intCreatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub

    Public Sub UpdateServiceCategory(ByVal intServiceCategoryId As Integer, ByVal strServiceCategoryName As String, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateServiceCategory"
        sqlcommand.Parameters.AddWithValue("@intServiceCategoryId", intServiceCategoryId)
        sqlcommand.Parameters.AddWithValue("@vaServiceCategoryName", strServiceCategoryName)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intUpdatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub
End Class
