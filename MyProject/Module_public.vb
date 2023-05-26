Imports MySql.Data.MySqlClient
Module Module_public
    Public myconn As New MySqlConnection
    Public myConnectionString As String
    Public strSQL As String

    Public Sub Connect_to_DB()
        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=1234;" _
                    & "database=edp_database"
        Try
            myconn.ConnectionString = myConnectionString
            myconn.Open()
        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox(ex.Message)
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try
    End Sub
    Public Sub Disconnect_to_DB()
        myconn.Close()
        myconn.Dispose()
    End Sub
End Module
