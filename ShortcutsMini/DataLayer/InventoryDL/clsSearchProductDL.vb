

Imports System.Data.SqlClient
Public Class clsSearchProductDL
    Dim sqlcommand As SqlCommand
    'to fetch all companies based on supplier
    Public Function FetchActiveCompaniesBasedonSupplier(ByVal intSupplierId As Integer) As SqlDataReader

        SqlCommand = New SqlCommand

        SqlCommand.Connection = ServerConnection()
        SqlCommand.CommandType = CommandType.StoredProcedure

        SqlCommand.CommandText = "FetchActiveCompaniesBasedonSupplier"

        SqlCommand.Parameters.AddWithValue("@intSupplierId", intSupplierId)
        Return SqlCommand.ExecuteReader()
    End Function

    'to fetch active Suppliers
    Public Function FetchActiveSupplier() As SqlDataReader

        SqlCommand = New SqlCommand

        SqlCommand.Connection = ServerConnection()
        SqlCommand.CommandType = CommandType.StoredProcedure

        SqlCommand.CommandText = "FetchActiveSupplier"

        Return SqlCommand.ExecuteReader()

    End Function

    'to fetch active Lines based on Companies
    Public Function FetchActiveLinesBasedonCompanies(ByVal intCompanyId As Integer) As SqlDataReader

        SqlCommand = New SqlCommand

        SqlCommand.Connection = ServerConnection()
        SqlCommand.CommandType = CommandType.StoredProcedure

        SqlCommand.CommandText = "FetchActiveLinesBasedonCompanies"

        SqlCommand.Parameters.AddWithValue("@intCompanyId", intCompanyId)
        Return SqlCommand.ExecuteReader()
    End Function
    'To View Product Info based on Search Result
    Public Function ViewProductDetailsBasedonStatus(ByVal intProductId As Integer, ByVal strStatus As String) As SqlDataReader
        sqlcommand = New SqlCommand("FetchProductDetailsBasedonStatus", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intProductId", intProductId)
        sqlcommand.Parameters.AddWithValue("@strStatus", strStatus)

        Return sqlcommand.ExecuteReader()
    End Function
End Class
