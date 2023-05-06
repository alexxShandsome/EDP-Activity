Imports MySql.Data.MySqlClient

Public Class Form_Login
    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from registered_users where USER_NAME = '" _
                & .UsernameTextBox.Text & "' and PASSWORD = '" _
                & .PasswordTextBox.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                MsgBox("Hello " & .UsernameTextBox.Text)
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click

    End Sub
End Class
