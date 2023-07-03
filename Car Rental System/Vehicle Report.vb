Imports MySql.Data.MySqlClient

Public Class Vehicle_Report
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim result As Boolean
    Dim str As String



    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        Dim table As New DataTable
        Try
            If Open_db() Then


                str = "SELECT vehicle_register.*,vehicle_owner.first_name,vehicle_owner.NIC FROM `vehicle_register` INNER JOIN vehicle_owner ON vehicle_register.fk_owner_id=vehicle_owner.owner_id WHERE `agreement_start_date` BETWEEN @d1 AND @d2"



                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value

                Dim adapter As New MySqlDataAdapter(command)
                reader = command.ExecuteReader
                table.Load(reader)
                DataGridView1.DataSource = table

                DataGridView1.DataSource = table
                DataGridView1.AllowUserToAddRows = False


                With DataGridView1
                    .Columns(1).Visible = False
                    .Columns(14).Visible = False
                End With



            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        command.Parameters.Clear()
        reader.Close()

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim msgboxresult As MsgBoxResult
        Dim v_reg As Integer


        For Each row As DataGridViewRow In DataGridView1.Rows

            v_reg = row.Cells(0).Value

        Next


        If Open_db() Then

            str = "DELETE FROM `vehicle_register` WHERE `vehicle_register_id`=@VEHICLE_ID"
            command.CommandText = str
            command.Connection = conn
            command.Parameters.Add("@VEHICLE_ID", MySqlDbType.Int32).Value = v_reg

            Try

                msgboxresult = MsgBox("Do you want Delete Vehicle Details..?", vbYesNo + vbQuestion, "Delete Vehicle Details")
                If msgboxresult = MsgBoxResult.Yes Then
                    result = command.ExecuteNonQuery
                    If result Then
                        MsgBox("Data Delete Success", vbOKOnly + vbInformation, "Delete Success")
                    End If
                    command.Parameters.Clear()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try




        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If

    End Sub

    Private Sub btnallclear_Click(sender As Object, e As EventArgs) Handles btnallclear.Click

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub btnsearch1_Click(sender As Object, e As EventArgs) Handles btnsearch1.Click
        Dim table2 As New DataTable

        If Nullempty(txtvehicle_number.Text) Then
            MsgBox("Enter Vehicle Number Before Serch", vbExclamation, "Vehicle Number Not Selected")

        Else

            If Open_db() Then
                str = "SELECT* FROM `vehicle_register` WHERE vehicle_number=@VVN"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@VVN", MySqlDbType.VarChar).Value = txtvehicle_number.Text

                reader = command.ExecuteReader
                table2.Load(reader)
                DataGridView2.DataSource = table2
                DataGridView2.AllowUserToAddRows = False

                With DataGridView2
                    .Columns(1).Visible = False
                    .Columns(14).Visible = False
                End With


            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        command.Parameters.Clear()
        reader.Close()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtvehicle_number.Clear()
        DataGridView2.DataSource = Nothing
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim table3 As New DataTable

        Try
            If Open_db() Then


                str = "SELECT vehicle_register.*,vehicle_owner.first_name,vehicle_owner.NIC FROM `vehicle_register` INNER JOIN vehicle_owner ON vehicle_register.fk_owner_id=vehicle_owner.owner_id WHERE `agreement_start_date` BETWEEN @d1 AND @d2"

                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value

                Dim adapter As New MySqlDataAdapter(command)
                reader = command.ExecuteReader
                table3.Load(reader)
                DataGridView1.DataSource = table3

                DataGridView1.DataSource = table3
                DataGridView1.AllowUserToAddRows = False


            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        command.Parameters.Clear()
        reader.Close()


    End Sub

    Private Sub Vehicle_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class