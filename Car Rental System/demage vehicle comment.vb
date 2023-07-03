Imports MySql.Data.MySqlClient
Public Class demage_vehicle_commentform
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table As New DataTable
    Dim result As Boolean
    Private Sub demage_vehicle_commentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qst1, qst2 As String
        Dim table2 As New DataTable

        If Open_db() Then
            qst1 = "SELECT order_id FROM vehicle_order"
            command.CommandText = qst1
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)

            comboorderid.DataSource = table
            comboorderid.DisplayMember = "order_id"
            comboorderid.ValueMember = "order_id"
            comboorderid.SelectedIndex = -1
            comboorderid.Text = "Select Order ID"
        Else
            MsgBox("Connection Error", vbExclamation, "Failed Connection")
        End If
        reader.Close()
        If Open_db() Then
            qst2 = "SELECT `vehicle_register_id`,`vehicle_number`  FROM `vehicle_register`"
            command.CommandText = qst2
            command.Connection = conn
            reader = command.ExecuteReader
            table2.Load(reader)

            combovehicle_id.DataSource = table2
            combovehicle_id.DisplayMember = "vehicle_number"
            combovehicle_id.ValueMember = "vehicle_register_id"
            combovehicle_id.SelectedIndex = -1
            combovehicle_id.Text = "Select Vehicle Number"
        Else
            MsgBox("Connection Error", vbExclamation, "Failed Connection")
        End If
        reader.Close()

    End Sub

    Private Sub btnrecord_Click(sender As Object, e As EventArgs) Handles btnrecord.Click
        Dim qst3, comment, vehicle_number, order_id As String

        comment = txtcomment.Text
        vehicle_number = combovehicle_id.SelectedValue
        order_id = comboorderid.SelectedValue

        If Nullempty(comment) Then
            MsgBox("Enter Comment", vbExclamation, "Empty Feild")
        ElseIf Nullempty(vehicle_number) Or
           Nullempty(order_id) Then
            MsgBox("Data Not Selected", vbExclamation, "Empty Feild")

        Else
            Try
                If Open_db() Then

                    qst3 = "INSERT INTO `damage_details`(`fk_order_id`, `fk_vehicle_number`, `comment`) VALUES (@OID,@VNUMBER,@COMMENT)"
                    command.CommandText = qst3
                    command.Connection = conn
                    command.Parameters.Add("@OID", MySqlDbType.VarChar).Value = order_id
                    command.Parameters.Add("@VNUMBER", MySqlDbType.VarChar).Value = vehicle_number
                    command.Parameters.Add("@COMMENT", MySqlDbType.VarChar).Value = comment

                    result = command.ExecuteNonQuery
                    If result Then
                        MsgBox("New Record Add", vbInformation, "Succsess")
                    Else
                        MsgBox("Record Add Failed", vbExclamation, "Error")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Connection Error", vbExclamation, "Failed Connection")
            End Try
            command.Parameters.Clear()
        End If
        Close_db()
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtcomment.Text = ""
        combovehicle_id.SelectedIndex = -1
        combovehicle_id.Text = "Select Vehicle Number"
        comboorderid.SelectedIndex = -1
        comboorderid.Text = "Select Order ID"
    End Sub

End Class