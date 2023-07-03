Imports MySql.Data.MySqlClient
Public Class Vehicle_Order
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table As New DataTable
    Dim result As Boolean
    Dim str,pick As String

    Private Sub Vehicle_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Open_db() Then
            str = "SELECT `vehicle_register_id`,`vehicle_number` FROM `vehicle_register`"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            Combovehicleregid.DataSource = table
            Combovehicleregid.DisplayMember = "vehicle_number"
            Combovehicleregid.ValueMember = "vehicle_register_id"
            Combovehicleregid.SelectedIndex = -1
            Combovehicleregid.Text = "Select Vehicle Number"

            reader.Close()
        End If

    End Sub

    Private Sub btn_status_Click(sender As Object, e As EventArgs) Handles btn_status.Click
        Dim table As New DataTable
        If Open_db() Then
            str = "SELECT vehicle_register.vehicle_number, vehicle_order.vehicle_status FROM `vehicle_order` INNER JOIN vehicle_register ON vehicle_register.vehicle_register_id=vehicle_order.fk_vehicle_register_id"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            DataGridView_status.DataSource = table
            DataGridView_status.AllowUserToAddRows = False
            DataGridView_status.RowHeadersVisible = False

            With DataGridView_status
                .ColumnHeadersDefaultCellStyle.Font = New Font("Calibri”, 12, FontStyle.Bold)
                .Columns(0).HeaderText = "Vehicle Number"
                .Columns(1).HeaderText = "Vehicle Status"
                .Columns(0).Width = 150
                .Columns(1).Width = 130

            End With

            reader.Close()
            btn_status.Refresh()

        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
        DataGridView_status.Refresh()

    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click

        Dim milage_rate, km_per_day As String
        Dim rent_date, hanover_date As Date

        milage_rate = txtmilage.Text
        km_per_day = txtkm.Text
        rent_date = DateTimePicker_rent.Value.ToShortDateString
        hanover_date = DateTimePicker_handover.Value.ToShortDateString

        If Nullempty(milage_rate) Or
                Nullempty(Combovehicleregid.SelectedValue) Or
                    Nullempty(km_per_day) Then
            MsgBox("Enter All Requred Details", vbExclamation, "Empty Fields")
        ElseIf CheckBox1.Checked = False Then
            MsgBox("Need Vehicle Status", vbExclamation, "Empty Field")


        Else
            If Open_db() Then

                str = "INSERT INTO `vehicle_order`(`fk_vehicle_register_id`, `vehicle_status`, `milage_rate`, `kilometer`, `pick_date`, `handover_date`)
                        VALUES (@VID,@STATUS,@MILAGE,@KM,@PICKDATE,@HANDO_DATE)"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@VID", MySqlDbType.VarChar).Value = Combovehicleregid.SelectedValue
                command.Parameters.Add("@STATUS", MySqlDbType.VarChar).Value = pick
                command.Parameters.Add("@MILAGE", MySqlDbType.VarChar).Value = milage_rate
                command.Parameters.Add("@KM", MySqlDbType.VarChar).Value = km_per_day
                command.Parameters.Add("@PICKDATE", MySqlDbType.Date).Value = rent_date
                command.Parameters.Add("@HANDO_DATE", MySqlDbType.Date).Value = hanover_date
                result = command.ExecuteNonQuery
                If result Then
                    MsgBox("Order Record Done", vbInformation, "Record Success")
                Else
                    MsgBox("Order Record Failed", vbExclamation, "Record Failed")
                End If

            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        command.Parameters.Clear()
        Close_db()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtkm.Text = ""
        txtmilage.Text = ""
        CheckBox1.Checked = False
        Combovehicleregid.SelectedValue = False
        Combovehicleregid.Text = "Select Vehicle Number"
        DataGridView_status.DataSource = Nothing
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        pick = "NOT AVAILABLE"
    End Sub

    Private Sub txtkm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkm.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtkm.Clear()
        End If
    End Sub

    Private Sub txtmilage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmilage.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtmilage.Clear()
        End If
    End Sub
End Class