Imports MySql.Data.MySqlClient
Public Class Customer_Bill
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table As New DataTable
    Dim str As String

    Private Sub Customer_Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Open_db() Then

            str = "SELECT customer.NIC,customer_payment.customer_payment_id FROM `customer_payment` INNER JOIN customer ON customer.customer_id=customer_payment.fk_customer_id"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            ComboBox_nic.DataSource = table
            ComboBox_nic.DisplayMember = "NIC"
            ComboBox_nic.ValueMember = "NIC"
            ComboBox_nic.SelectedIndex = -1
            ComboBox_nic.Text = "Select NIC"


        End If
        reader.Close()
        Close_db()
    End Sub


    Private Sub ComboBox_nic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_nic.SelectedIndexChanged
        If Open_db() Then

            str = "SELECT customer.first_name,customer.NIC,customer_payment.delay_charge,customer_payment.total_amount,customer_payment.handover_date,customer_payment.pick_date FROM `customer_payment` INNER JOIN customer ON customer.customer_id=customer_payment.fk_customer_id WHERE NIC = @NIC "
            command.CommandText = str
            command.Connection = conn
            command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = ComboBox_nic.SelectedValue
            reader = command.ExecuteReader

            If reader.HasRows Then
                reader.Read()

                txtdelay_charge.Text = reader("delay_charge").ToString
                txtbill.Text = reader.GetString("total_amount").ToString
                txtname.Text = reader.GetString("first_name").ToString
                DateTimePicker_hanover.Value = reader.GetString("handover_date").ToString
                DateTimePicker_pick.Value = reader.GetString("pick_date").ToString

            End If
        Else
            MsgBox("Data Empty", vbExclamation, "Data Empty")
        End If
        command.Parameters.Clear()
        reader.Close()
        Close_db()
    End Sub
End Class