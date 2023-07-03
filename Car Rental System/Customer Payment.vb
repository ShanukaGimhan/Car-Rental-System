Imports MySql.Data.MySqlClient
Public Class Customer_Payment
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table1 As New DataTable
    Dim table2 As New DataTable
    Dim status, str As String
    Dim result As Boolean

    Private Sub Customer_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str1, str2 As String
        If Open_db() Then
            str1 = "SELECT `order_id` FROM `vehicle_order`"
            command.CommandText = str1
            command.Connection = conn
            reader = command.ExecuteReader
            table1.Load(reader)
            ComboBox_order.DataSource = table1
            ComboBox_order.DisplayMember = "order_id"
            ComboBox_order.ValueMember = "order_id"
            ComboBox_order.SelectedIndex = -1
            ComboBox_order.Text = "Select Order ID"

        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
        If Open_db() Then

            str2 = "SELECT NIC,customer_id FROM customer "
            command.CommandText = str2
            command.Connection = conn
            reader = command.ExecuteReader
            table2.Load(reader)
            ComboBox_nic.DataSource = table2
            ComboBox_nic.DisplayMember = "NIC"
            ComboBox_nic.ValueMember = "customer_id"
            ComboBox_nic.SelectedIndex = -1
            ComboBox_nic.Text = "Select Customer NIC"

        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
        reader.Close()
        Close_db()
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click

        Dim str, fk_order_id, fk_customer_id, Delay_charge, Total_amount As String
        Dim Pickup_date, Handover_date As Date
        Dim result As Boolean

        fk_order_id = ComboBox_order.SelectedValue
        fk_customer_id = ComboBox_nic.SelectedValue
        Delay_charge = txtdelay_charge.Text
        Total_amount = txttotal_amount.Text

        Pickup_date = DateTimePicker_Pickup.Value.ToShortDateString()
        Handover_date = DateTimePicker_Handover.Value.ToShortDateString()

        If Nullempty(fk_customer_id) Or
                Nullempty(fk_customer_id) Or
                Nullempty(Total_amount) Then
            MsgBox("Enter Data To Required Fields.. ", vbExclamation, "Empty Feild")
        ElseIf CheckBox_handover.Checked = False Then
            MsgBox("Mark Vehicle Status", vbExclamation, "Status Not Mark")

        Else

            If Open_db() Then

                str = "INSERT INTO `customer_payment`( `fk_order_id`,`fk_customer_id`,`delay_charge`, `total_amount`, `handover_date`, `pick_date`) VALUES (@FK_ORDER_ID,@FK_CUSTOMER_ID,@DELAY,@TOTAL,@PICKUP_DATE,@HANDOVER_DATE)"

                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@FK_ORDER_ID", MySqlDbType.VarChar).Value = fk_order_id
                command.Parameters.Add("@FK_CUSTOMER_ID", MySqlDbType.VarChar).Value = fk_customer_id
                command.Parameters.Add("@DELAY", MySqlDbType.VarChar).Value = Delay_charge
                command.Parameters.Add("@TOTAL", MySqlDbType.VarChar).Value = Total_amount
                command.Parameters.Add("@PICKUP_DATE", MySqlDbType.Date).Value = Pickup_date
                command.Parameters.Add("@HANDOVER_DATE", MySqlDbType.Date).Value = Handover_date
                result = command.ExecuteNonQuery()

                If result Then
                    MsgBox("Payment Done", vbInformation, "Confirm Payment")
                Else
                    MsgBox("Details not Record.", vbExclamation, "Error")
                End If
            End If
            If Open_db() Then
                str = "UPDATE `vehicle_order` SET `vehicle_status`=(@STATUS) WHERE `order_id` = @ID"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@STATUS", MySqlDbType.VarChar).Value = status
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ComboBox_order.SelectedValue
                command.ExecuteNonQuery()
            End If

            command.Parameters.Clear()
            Close_db()
        End If
    End Sub

    Private Sub btnallclear_Click(sender As Object, e As EventArgs) Handles btnallclear.Click
        txtdelay_charge.Clear()
        txttotal_amount.Clear()
        CheckBox_handover.Checked = False
        ComboBox_nic.SelectedValue = False
        ComboBox_order.SelectedValue = False
        ComboBox_nic.Text = "Select Customer NIC"
        ComboBox_order.Text = "Select Order ID"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Customer_Bill.Show()
    End Sub

    Private Sub CheckBox_handover_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_handover.CheckedChanged
        status = "AVAILABLE"
    End Sub



    Private Sub txtdelay_charge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdelay_charge.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtdelay_charge.Clear()
            txtdelay_charge.Clear()
        End If
    End Sub

    Private Sub txttotal_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotal_amount.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtdelay_charge.Clear()
            txttotal_amount.Clear()
        End If
    End Sub
End Class