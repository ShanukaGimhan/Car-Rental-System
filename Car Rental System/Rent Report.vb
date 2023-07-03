Imports MySql.Data.MySqlClient

Public Class Rented_report

    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim result As Boolean
    Dim str As String



    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim table As New DataTable
        Try
            Open_db()


            str = "SELECT vehicle_order.*, vehicle_register.vehicle_number,vehicle_register.vehicle_brand,vehicle_register.vehicle_model FROM `vehicle_order` INNER JOIN vehicle_register ON vehicle_order.fk_vehicle_register_id=vehicle_register.vehicle_register_id WHERE `pick_date` BETWEEN @d1 AND @d2"
            command.CommandText = str
            command.Connection = conn
            command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
            command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value


            reader = command.ExecuteReader
            table.Load(reader)

            DataGridView1.DataSource = table
            DataGridView1.AllowUserToAddRows = False

            With DataGridView1
                .Columns(1).Visible = False
            End With


            command.Parameters.Clear()
            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Dim msgboxresult As MsgBoxResult
        Dim r_id As Integer


        For Each row As DataGridViewRow In DataGridView1.SelectedRows

            r_id = row.Cells(0).Value

        Next

        If Open_db() Then

            str = "DELETE FROM `vehicle_order` WHERE `order_id`=@CUSTOMER_ID"

            command.CommandText = str
            command.Connection = conn
            command.Parameters.Add("@CUSTOMER_ID", MySqlDbType.Int32).Value = r_id

            msgboxresult = MsgBox("Do you want Delete Vehicle Order Details..?", vbYesNo + vbQuestion, "Delete Order")

            Try

                If msgboxresult = MsgBoxResult.Yes Then
                    result = command.ExecuteNonQuery()
                    If result Then
                        MsgBox("Order Details Delete Success", vbOKOnly + vbInformation, "Delete Success")
                    End If
                End If



                command.Parameters.Clear()
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

        If Nullempty(txtid.Text) Then
            MsgBox("Enter Rent ID Before Serch", vbExclamation, "ID Not Selected")
        Else

            If Open_db() Then

                str = "SELECT vehicle_order.*, vehicle_register.vehicle_number,vehicle_register.vehicle_brand,vehicle_register.vehicle_model FROM `vehicle_order` INNER JOIN vehicle_register ON vehicle_order.fk_vehicle_register_id=vehicle_register.vehicle_register_id WHERE order_id=@ORDER_ID"
                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@ORDER_ID", MySqlDbType.Int32).Value = txtid.Text
                reader = command.ExecuteReader
                table2.Load(reader)

                DataGridView2.DataSource = table2
                DataGridView2.AllowUserToAddRows = False

                With DataGridView2
                    .Columns(1).Visible = False
                End With

                command.Parameters.Clear()


            End If
        End If
        reader.Close()
        btnsearch.Refresh()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtid.Clear()
        DataGridView2.DataSource = Nothing
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub Rented_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim table As New DataTable()
        Try
            If Open_db() Then

                'Dim command As New MySqlCommand("SELECT * FROM `vehicle_order` WHERE `pick_date` BETWEEN @d1 AND @d2", conn)

                str = "SELECT vehicle_order.*, vehicle_register.vehicle_number,vehicle_register.vehicle_brand,vehicle_register.vehicle_model FROM `vehicle_order` INNER JOIN vehicle_register ON vehicle_order.fk_vehicle_register_id=vehicle_register.vehicle_register_id WHERE `pick_date` BETWEEN @d1 AND @d2"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value
                Dim adapter As New MySqlDataAdapter(command)

                reader = command.ExecuteReader
                table.Load(reader)

                DataGridView1.DataSource = table
                DataGridView1.AllowUserToAddRows = False

                command.Parameters.Clear()
                reader.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "EROOR")
        End Try
        Close_db()
    End Sub
End Class