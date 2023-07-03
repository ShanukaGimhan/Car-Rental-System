Imports MySql.Data.MySqlClient
Public Class Admin_mange_user
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table As New DataTable
    Dim result As Boolean
    Dim str As String

    Private Sub Admin_mange_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Open_db() Then

            str = "SELECT `NIC` FROM `admin`"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            ComboBox_nic.DataSource = table
            ComboBox_nic.DisplayMember = "NIC"
            ComboBox_nic.ValueMember = "NIC"
            ComboBox_nic.SelectedIndex = -1
            ComboBox_nic.Text = "Select NIC Number"
        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
        reader.Close()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        If Open_db() Then
                Dim username, status As String
                username = txtuser_name.Text


                str = "SELECT NIC, user_name, status FROM admin WHERE NIC = @NIC"
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = ComboBox_nic.SelectedValue
                command.CommandText = str
                command.Connection = conn

                reader = command.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    txtuser_name.Text = reader.GetString("user_name").ToString
                    status = reader.GetUInt32("status")
                    If status = "1" Then
                        RadioButton_enable.Checked = True
                    ElseIf status = "2" Then
                        RadioButton_disable.Checked = True
                    End If
                    txtuser_name.Enabled = False
                End If
            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If

        reader.Close()
        command.Parameters.Clear()
        Close_db()
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click

        Dim status As String
        Dim msgboxstyle As MsgBoxResult
        Dim msdboxstyle2 As MsgBoxResult
        status = If((RadioButton_enable.Checked = True), 1, 2)

        If ComboBox_nic.SelectedValue = Nothing Then
            MsgBox("Select NIC Number Before Serch.", vbExclamation, "Search Values Empty")

        Else

            If Open_db() Then

                str = "UPDATE `admin` SET `status` = @STATUS WHERE `NIC` = @NIC"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@STATUS", MySqlDbType.VarChar).Value = status
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = ComboBox_nic.SelectedValue


                If RadioButton_disable.Checked = True Then

                    msgboxstyle = MsgBox("Do you want Disable User..?", vbYesNo + vbQuestion, "Confirm User Disable")

                ElseIf RadioButton_enable.Checked = True Then

                    msdboxstyle2 = MsgBox("Do you want Enable User..?", vbYesNo + vbQuestion, "Confirm User Enable")

                End If

                If msgboxstyle = MsgBoxResult.Yes Then
                    result = command.ExecuteNonQuery
                    If result Then
                        MsgBox("User Disable Success..", vbInformation, "Disable Success")
                    End If
                ElseIf msdboxstyle2 = MsgBoxResult.Yes Then
                    result = command.ExecuteNonQuery
                    If result Then
                        MsgBox("User Enable Success..", vbInformation, "Enable Success")
                    End If
                End If

            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        command.Parameters.Clear()
        Close_db()

    End Sub

    Private Sub btnallclear_Click(sender As Object, e As EventArgs) Handles btnallclear.Click
        txtuser_name.Text = ""
        RadioButton_disable.Checked = False
        RadioButton_enable.Checked = False
        ComboBox_nic.SelectedIndex = -1
        ComboBox_nic.Text = "Select NIC Number"
    End Sub
End Class