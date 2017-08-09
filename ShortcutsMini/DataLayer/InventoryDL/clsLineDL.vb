
Imports System.Data.SqlClient
Public Class clsLineDL
    Dim sqlcommand As SqlCommand

    Public Sub InsertLine(ByVal intCompanyId As Integer, ByVal strLineName As String, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertLine"

        sqlcommand.Parameters.AddWithValue("@intCompanyId", intCompanyId)
        sqlcommand.Parameters.AddWithValue("@vaLineName", strLineName)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intCreatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub

    Public Sub UpdateLine(ByVal intLineId As Integer, ByVal strLineName As String, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateLine"
        sqlcommand.Parameters.AddWithValue("@intLineId", intLineId)
        sqlcommand.Parameters.AddWithValue("@vaLineName", strLineName)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intUpdatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub

    'to fetch all companies based on supplier
    Public Function FetchActiveCompaniesBasedonSupplier(ByVal intSupplierId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchActiveCompaniesBasedonSupplier"

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

    'to fetch all Lines based on Companies
    Public Function FetchAllLinesBasedonCompanies(ByVal intCompanyId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchAllLinesBasedonCompanies"

        sqlcommand.Parameters.AddWithValue("@intCompanyId", intCompanyId)
        Return sqlcommand.ExecuteReader()
    End Function

    'to fetch all Lines based on Suppliers
    Public Function FetchAllLinesBasedonSuppliers(ByVal intSupplierId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchAllLinesBasedonSuppliers"

        sqlcommand.Parameters.AddWithValue("@intSupplierId", intSupplierId)
        Return sqlcommand.ExecuteReader()
    End Function

End Class
