Imports System.Data.SqlClient

Public Class clsSupplierDL
    Dim sqlcommand As SqlCommand



    Public Sub InsertSupplier(ByVal strSupplierName As String, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "InsertSupplier"

        sqlcommand.Parameters.AddWithValue("@vaSupplierName", strSupplierName)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intCreatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub

    Public Sub UpdateSupplier(ByVal intSupplierId As Integer, ByVal strSupplierName As String, ByVal strStatus As String)

        sqlcommand = New SqlCommand

        sqlcommand.Connection = ServerConnection()
        sqlcommand.CommandType = CommandType.StoredProcedure

        sqlcommand.CommandText = "UpdateSupplier"
        sqlcommand.Parameters.AddWithValue("@intSupplierId", intSupplierId)
        sqlcommand.Parameters.AddWithValue("@vaSupplierName", strSupplierName)
        sqlcommand.Parameters.AddWithValue("@vaStatus", strStatus)
        sqlcommand.Parameters.AddWithValue("@intUpdatedBy", BL.PublicVariables.gintEmployeeID)

        sqlcommand.ExecuteNonQuery()
    End Sub
End Class
