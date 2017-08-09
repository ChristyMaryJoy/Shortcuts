
Imports System.Data.SqlClient
Namespace DataLayer
    Public Class clsCommonFunctionDL


        Dim sqlcommand As SqlCommand
        Public Function CommonFetchBasedOnSingleConditions(ByVal lstrTableName As String, ByVal lstrColoumName As String, ByVal lstrConditionValue As String, ByVal lstrReturnedFieldsSeperatedByComa As String) As SqlDataReader
            sqlcommand = New SqlCommand("CommonFetchBasedOnSingleConditions", ServerConnection)
            sqlcommand.CommandType = CommandType.StoredProcedure
            sqlcommand.Parameters.AddWithValue("@lstrTableName", lstrTableName)
            sqlcommand.Parameters.AddWithValue("@strPassword", lstrColoumName)
            sqlcommand.Parameters.AddWithValue("@strPassword", lstrConditionValue)
            sqlcommand.Parameters.AddWithValue("@strPassword", lstrReturnedFieldsSeperatedByComa)

            Return sqlcommand.ExecuteReader()
        End Function
        Public Function commonFetchBasesdOnTwoConditions(ByVal lstrTableName As String, ByVal lstrColoumNameOne As String, ByVal lstrConditionValueOne As String, ByVal lstrColoumNameTwo As String, ByVal lstrConditionValueTwo As String, ByVal lstrReturnedFieldsSeperatedByComa As String) As SqlDataReader
            sqlcommand = New SqlCommand("CommonFetchBasesdOnTwoConditions", ServerConnection)
            sqlcommand.CommandType = CommandType.StoredProcedure
            sqlcommand.Parameters.AddWithValue("@lstrTableName", lstrTableName)
            sqlcommand.Parameters.AddWithValue("@lstrColoumNameOne", lstrColoumNameOne)
            sqlcommand.Parameters.AddWithValue("@lstrConditionValueOne", lstrConditionValueOne)
            sqlcommand.Parameters.AddWithValue("@lstrColoumNameTwo", lstrColoumNameTwo)
            sqlcommand.Parameters.AddWithValue("@lstrColoumNameOne", lstrConditionValueTwo)
            sqlcommand.Parameters.AddWithValue("@lstrColoumNameOne", lstrReturnedFieldsSeperatedByComa)
            Return sqlcommand.ExecuteReader()
        End Function

        Public Function CommonFetchAllDetails(ByVal lstrTableName As String, ByVal lstrReturnedFieldsSeperatedByComa As String) As SqlDataReader
            sqlcommand = New SqlCommand("CommonFetchAllDetails", ServerConnection)
            sqlcommand.CommandType = CommandType.StoredProcedure
            sqlcommand.Parameters.AddWithValue("@lstrTableName", lstrTableName)
            sqlcommand.Parameters.AddWithValue("@lstrReturnedFieldsSeperatedByComa", lstrReturnedFieldsSeperatedByComa)
            Return sqlcommand.ExecuteReader()
        End Function
    End Class
End Namespace

