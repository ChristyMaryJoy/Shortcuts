Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq

Module connection



    'Public strConnection As String = "server=HP-PC; database=ShortcutMini;uid=sa;pwd=123;Pooling=True;Min Pool Size=5;Max Pool Size=5000;Connect Timeout=60;"
    Public strConnection As String = "server=.;database=ShortcutsMini;uid=test;pwd=test@123;Pooling=True;Min Pool Size=5;Max Pool Size=5000;Connect Timeout=60;Trusted_Connection=Yes;"

    Dim sqlConnection As New SqlConnection(strConnection)


    Public Function ServerConnection() As SqlConnection

        Try

            If sqlConnection.State = ConnectionState.Open Then
                sqlConnection.Close()
            End If

            sqlConnection.Open()

            Return sqlConnection

        Catch ex As Exception
            Throw ex
        End Try

    End Function



End Module



