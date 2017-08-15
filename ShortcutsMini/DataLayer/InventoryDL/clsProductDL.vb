
Imports System.Data.SqlClient
Public Class clsProductDL
    Dim sqlcommand As SqlCommand

    Public Sub InsertProduct(ByVal intLineId As Integer, ByVal strProductName As String, ByVal strProductCode As String, ByVal strBarcode As String, ByVal intBuyPrice As Integer, ByVal intSellPrice As Integer, ByVal intRetail As Integer, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertProduct"

        sqlcommand.Parameters.AddWithValue("@intLineId", intLineId)
        sqlcommand.Parameters.AddWithValue("@vaProductName", strProductName)
        sqlcommand.Parameters.AddWithValue("@vaProductCode", strProductCode)
        sqlcommand.Parameters.AddWithValue("@vaBarcode", strBarcode)
        sqlcommand.Parameters.AddWithValue("@intBuyPrice", intBuyPrice)
        sqlcommand.Parameters.AddWithValue("@intSellPrice", intSellPrice)
        sqlcommand.Parameters.AddWithValue("@intRetail", intRetail)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intCreatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub

    Public Sub UpdateProduct(ByVal intProductId As Integer, ByVal strProductName As String, ByVal strProductCode As String, ByVal strBarcode As String, ByVal intBuyPrice As Integer, ByVal intSellPrice As Integer, ByVal intRetail As Integer, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateProduct"
        sqlcommand.Parameters.AddWithValue("@intProductId", intProductId)
        sqlcommand.Parameters.AddWithValue("@vaProductName", strProductName)
        sqlcommand.Parameters.AddWithValue("@vaProductCode", strProductCode)
        sqlcommand.Parameters.AddWithValue("@vaBarcode", strBarcode)
        sqlcommand.Parameters.AddWithValue("@intBuyPrice", intBuyPrice)
        sqlcommand.Parameters.AddWithValue("@intSellPrice", intSellPrice)
        sqlcommand.Parameters.AddWithValue("@intRetail", intRetail)
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

    'to fetch active Lines based on Companies
    Public Function FetchActiveLinesBasedonCompanies(ByVal intCompanyId As Integer) As SqlDataReader

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "FetchActiveLinesBasedonCompanies"

        sqlcommand.Parameters.AddWithValue("@intCompanyId", intCompanyId)
        Return sqlcommand.ExecuteReader()
    End Function
    'To View Product Info based on Search Result
    Public Function ViewProductInfo(ByVal intProductId As Integer) As SqlDataReader
        sqlcommand = New SqlCommand("FetchProductInfo", ServerConnection)
        sqlcommand.CommandType = CommandType.StoredProcedure
        sqlcommand.Parameters.AddWithValue("@intProductId", intProductId)

        Return sqlcommand.ExecuteReader()
    End Function
    

End Class
