
Imports System.Data.SqlClient
Public Class clsCompanyDL

    Dim sqlcommand As SqlCommand



    Public Sub InsertCompany(ByVal intSupplierId As Integer, ByVal strCompanyName As String, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertCompany"

        sqlcommand.Parameters.AddWithValue("@intSupplierId", intSupplierId)
        sqlcommand.Parameters.AddWithValue("@vastrCompanyName", strCompanyName)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intCreatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub

    Public Sub UpdateCompany(ByVal intCompanyId As Integer, ByVal strCompanyName As String, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateCompany"
        sqlcommand.Parameters.AddWithValue("@intCompanyId", intCompanyId)
        sqlcommand.Parameters.AddWithValue("@vaCompanyName", strCompanyName)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intUpdatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub

    'to fetch all companies based on supplier
    Public Function FetchAllCompaniesBasedonSupplier(ByVal intSupplierId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchAllCompaniesBasedonSupplier"

        sqlcommand.Parameters.AddWithValue("@intSupplierId", intSupplierId)
        Return sqlcommand.ExecuteReader()
    End Function

    'to fetch active Suppliers
    Public Function FetchActiveSupplier() As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchActiveSupplier"

        Return sqlcommand.ExecuteReader()

    End Function
End Class
