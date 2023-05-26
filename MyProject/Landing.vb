Imports MySql.Data.MySqlClient
Imports System
Imports System.Text
Imports System.Windows.Forms
Imports System.IO


Public Class Landing
    Public Property welcome_string As String

    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        string_welcome.Text = welcome_string
    End Sub

    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        'Show the OpenFileDialog
        Dim open_files As New OpenFileDialog()
        open_files.Filter = "BAT files (*.bat)|*.bat"
        open_files.FilterIndex = 1
        open_files.RestoreDirectory = True
        ' Show dialog file
        If open_files.ShowDialog() = DialogResult.OK Then
            System.Diagnostics.Process.Start(open_files.FileName)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub loadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT * FROM edp_database.registered_users", myconn)
        adapter.Fill(table)
        dataTable.DataSource = table
        dataTable.Columns("BIRTHDAY").DefaultCellStyle.Format = "yyyy-MM-dd"
        Call Disconnect_to_DB()
    End Sub

    Private Sub testButton_Click(sender As Object, e As EventArgs) Handles testButton.Click
        Call Connect_to_DB()
        Try
            myconn.Open()
            MessageBox.Show("Connect Test success")
            myconn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error in your Connection String!")
        Finally
            myconn.Dispose()
        End Try
        Call Disconnect_to_DB()
    End Sub

    Private Sub dataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTable.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dataTable.Rows(e.RowIndex)
            idTextBox.Text = row.Cells("USER_ID").Value.ToString
            fnameTextBox.Text = row.Cells("FIRST_NAME").Value.ToString
            lnameTextBox.Text = row.Cells("LAST_NAME").Value.ToString
            usernameTextBox.Text = row.Cells("USER_NAME").Value.ToString
            emailTextBox.Text = row.Cells("EMAIL").Value.ToString
            passwordTextBox.Text = row.Cells("PASSWORD").Value.ToString
            genderBox.Text = row.Cells("GENDER").Value.ToString
            birthTextBox.Text = row.Cells("BIRTHDAY").Value
            profileBox.Text = dataTable.Rows(e.RowIndex).Cells(8).Value
            bioBox.Text = dataTable.Rows(e.RowIndex).Cells(9).Value
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Try
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            mycmd = New MySqlCommand("INSERT INTO `edp_database`.`registered_users` (`FIRST_NAME`, `LAST_NAME`, `USER_NAME`, `EMAIL`, `PASSWORD`, `GENDER`, `BIRTHDAY`, `PROFILE_PIC`, `BIO`) VALUES (@fname, @lname, @username, @email, @password, @gender, @birthday, @profile, @bio)", myconn)
            mycmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fnameTextBox.Text
            mycmd.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lnameTextBox.Text
            mycmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = usernameTextBox.Text
            mycmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailTextBox.Text
            mycmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordTextBox.Text
            mycmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = genderBox.SelectedItem
            mycmd.Parameters.Add("@birthday", MySqlDbType.Date).Value = birthTextBox.Text
            mycmd.Parameters.Add("@profile", MySqlDbType.VarChar).Value = profileBox.Text
            mycmd.Parameters.Add("@bio", MySqlDbType.VarChar).Value = bioBox.Text
            If mycmd.ExecuteNonQuery() = 1 Then
                MsgBox("Details Inserted!")
            Else
                MsgBox("Details Not Inserted!")
                Call Disconnect_to_DB()
            End If
            Call Disconnect_to_DB()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call Disconnect_to_DB()
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Try
            Call Connect_to_DB()
            Dim mycmd2 As New MySqlCommand
            mycmd2 = New MySqlCommand("UPDATE `edp_database`.`registered_users` SET `FIRST_NAME` = @fname, `LAST_NAME` = @lname, `USER_NAME` = @username, `EMAIL` = @email, `PASSWORD` = @password, `BIRTHDAY` = @birthday, `PROFILE_PIC` = @profile, `BIO` = @bio WHERE (`USER_ID` = @id)", myconn)
            mycmd2.Parameters.Add("@id", MySqlDbType.VarChar).Value = idTextBox.Text
            mycmd2.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fnameTextBox.Text
            mycmd2.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lnameTextBox.Text
            mycmd2.Parameters.Add("@username", MySqlDbType.VarChar).Value = usernameTextBox.Text
            mycmd2.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailTextBox.Text
            mycmd2.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordTextBox.Text
            mycmd2.Parameters.Add("@gender", MySqlDbType.VarChar).Value = genderBox.SelectedItem
            mycmd2.Parameters.Add("@birthday", MySqlDbType.Date).Value = birthTextBox.Text
            mycmd2.Parameters.Add("@profile", MySqlDbType.VarChar).Value = profileBox.Text
            mycmd2.Parameters.Add("@bio", MySqlDbType.VarChar).Value = bioBox.Text
            If mycmd2.ExecuteNonQuery() = 1 Then
                MsgBox("Details Updated!")
            Else
                MsgBox("Details Not Updated!")
                Call Disconnect_to_DB()
            End If
            Call Disconnect_to_DB()
        Catch ex As Exception
            Call Disconnect_to_DB()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub birthTextBox_TextChanged(sender As Object, e As EventArgs) Handles birthTextBox.TextChanged
    End Sub


    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Try
            Call Connect_to_DB()
            Dim mycmd3 As New MySqlCommand
            mycmd3 = New MySqlCommand("DELETE FROM `edp_database`.`registered_users` WHERE (`USER_ID` = @id)", myconn)
            mycmd3.Parameters.Add("@id", MySqlDbType.VarChar).Value = idTextBox.Text
            If mycmd3.ExecuteNonQuery() = 1 Then
                MsgBox("Details Updated!")
            Else
                MsgBox("Details Not Updated!")
                Call Disconnect_to_DB()
            End If
            Call Disconnect_to_DB()
        Catch ex As Exception
            Call Disconnect_to_DB()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub exportButton_Click(sender As Object, e As EventArgs) Handles exportButton.Click
        Dim csvData As New StringBuilder()
        Dim headerRow As String = ""
        For Each Column As DataGridViewColumn In dataTable.Columns
            headerRow += Column.HeaderText + ","
        Next
        headerRow = headerRow.TrimEnd(","c)
        csvData.AppendLine(headerRow)
        For Each row As DataGridViewRow In dataTable.Rows
            Dim rowData As String = ""
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing Then
                    rowData += cell.Value.ToString() + ","
                Else
                    rowData += ","
                End If
            Next
            rowData = rowData.TrimEnd(","c)
            csvData.AppendLine(rowData)
        Next
        Dim savePath As String = "C:\Users\Algilbert\Desktop\EDP-Activity\backup.csv"
        File.WriteAllText(savePath, csvData.ToString)
        MsgBox("Export Success!", MsgBoxStyle.Information, "CSV Export")
    End Sub

    Private Sub csvImport_Click(sender As Object, e As EventArgs) Handles csvImport.Click
        Dim open_files As New OpenFileDialog()
        open_files.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        open_files.FilterIndex = 1
        open_files.RestoreDirectory = True
        If open_files.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                'Create a DataTable to store the data from the CSV file
                Dim dt As New DataTable()
                'Read the contents of the CSV file
                Using sr As New System.IO.StreamReader(open_files.FileName)
                    Dim line As String = sr.ReadLine()
                    Dim headers() As String = line.Split(","c)
                    For Each header As String In headers
                        dt.Columns.Add(header)
                    Next
                    While Not sr.EndOfStream
                        Dim values() As String = sr.ReadLine().Split(","c)
                        If values.Length = dt.Columns.Count Then
                            dt.Rows.Add(values)
                        End If
                    End While
                End Using
                'Datatable through GridView
                dataTable.DataSource = dt
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error!")
            End Try
        End If
    End Sub
End Class