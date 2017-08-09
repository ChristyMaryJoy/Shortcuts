Imports System.Data.SqlClient
Namespace BusinessLayer

    Public Class CommonFunctionBL
        Dim objCommonFunction As New DataLayer.clsCommonFunctionDL

        Public Function CommonFetchBasedOnSingleConditions(ByVal lstrTableName As String, ByVal lstrColoumName As String, ByVal lstrConditionValue As String, ByVal lstrReturnedFieldsSeperatedByComa As String) As SqlDataReader
            Try
                Return objCommonFunction.CommonFetchBasedOnSingleConditions(lstrTableName, lstrColoumName, lstrConditionValue, lstrReturnedFieldsSeperatedByComa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
       
        Public Function commonFetchBasesdOnTwoConditions(ByVal lstrTableName As String, ByVal lstrColoumNameOne As String, ByVal lstrConditionValueOne As String, ByVal lstrColoumNameTwo As String, ByVal lstrConditionValueTwo As String, ByVal lstrReturnedFieldsSeperatedByComa As String) As SqlDataReader

            Return objCommonFunction.commonFetchBasesdOnTwoConditions(lstrTableName, lstrColoumNameOne, lstrConditionValueOne, lstrColoumNameTwo, lstrConditionValueTwo, lstrReturnedFieldsSeperatedByComa)

        End Function
        
        ''Public Function FetchCurrentVoucherNumberBasedOnBranchIdAndVoucherName(ByVal intBranchId As Integer, ByVal InterestVoucherName As String) As Integer

        ''    Return objCommonFunction.FetchCurrentVoucherNumberBasedOnBranchIdAndVoucherName(intBranchId, InterestVoucherName)

        ''End Function



        'Public Sub toIncrementVoucherNumberByOneBasedOnVoucherType(ByVal lstrVoucherName As String, ByVal intBranchId As Integer)

        '    objCommonFunction.toIncrementVoucherNumberByOneBasedOnVoucherType(lstrVoucherName, intBranchId)

        'End Sub


        Public Function CommonFetchAllDetails(ByVal lstrTableName As String, ByVal lstrReturnedFieldsSeperatedByComa As String) As SqlDataReader
            Try
                Return objCommonFunction.CommonFetchAllDetails(lstrTableName, lstrReturnedFieldsSeperatedByComa)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace