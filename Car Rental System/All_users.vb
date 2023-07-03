Imports MySql.Data.MySqlClient
Public Class All_users_form
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim str As String
    Dim result As Boolean

    Private Sub btnadduser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        Me.Hide()
        user_register.Show()
    End Sub

    Private Sub btnAll_user_show_Click(sender As Object, e As EventArgs) Handles btnAll_user_show.Click
        Dim table As New DataTable
        If Open_db() Then

            str = "SELECT `user_id`, `first_name`, `last_name`, `NIC`, `user_name`, `contact_number`, `email`, `register_date` FROM `admin` WHERE `user_role` = 2"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)


            grid_all_user.DataSource = table
            grid_all_user.AllowUserToAddRows = False

            With grid_all_user
                .Columns(0).HeaderText = "User ID"
                .Columns(1).HeaderText = "First Name"
                .Columns(2).HeaderText = "Last Name"
                .Columns(4).HeaderText = "User Name"
                .Columns(5).HeaderText = "Contact Number"
                .Columns(7).HeaderText = "Register Date"
                .Columns(5).Width = 150
                .Columns(7).Width = 150

            End With

        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If

        reader.Close()
        Close_db()
    End Sub

    Private Sub btnallclear_Click(sender As Object, e As EventArgs) Handles btnallclear.Click
        ' table.Clear()
        grid_all_user.DataSource = Nothing
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Dim msgboxresult As MsgBoxResult
        Dim u_id As Integer
        Try

            For Each row As DataGridViewRow In grid_all_user.SelectedRows
                u_id = row.Cells(0).Value
            Next

            If Open_db() Then

                str = "DELETE FROM `admin` WHERE `user_id`=@ID"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@ID", MySqlDbType.Int32).Value = u_id

                msgboxresult = MsgBox("Do you want Delete User..?", vbYesNo + vbQuestion, "Delete User")
                If msgboxresult = MsgBoxResult.Yes Then

                    result = command.ExecuteNonQuery
                    If result Then
                        MsgBox("User Delete Success", vbOKOnly + vbInformation, "Delete Success")
                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        command.Parameters.Clear()
        Close_db()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim table2 As New DataTable

        If Open_db() Then

            str = "SELECT `user_id`, `first_name`, `last_name`, `NIC`, `user_name`, `contact_number`, `email`, `register_date` FROM `admin` WHERE `user_role` = 2"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table2.Load(reader)


            grid_all_user.DataSource = table2
            grid_all_user.AllowUserToAddRows = False

            With grid_all_user
                .Columns(1).HeaderText = "First Name"
                .Columns(2).HeaderText = "Last Name"
                .Columns(4).HeaderText = "User Name"
                .Columns(5).HeaderText = "Contact Number"
                .Columns(7).HeaderText = "Register Date"
                .Columns(5).Width = 150
                .Columns(7).Width = 150

            End With

        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If

        reader.Close()
        Close_db()
    End Sub

    Private Sub All_users_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class