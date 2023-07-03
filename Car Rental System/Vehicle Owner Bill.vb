Imports MySql.Data.MySqlClient
Public Class Vehicle_Owner_Bill
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table As New DataTable
    Dim str As String
    Private Sub Vehicle_Owner_Bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Open_db() Then

            str = "SELECT vehicle_register.vehicle_number,owner_payment.owner_payment_id FROM `owner_payment` INNER JOIN vehicle_register ON vehicle_register.vehicle_register_id=owner_payment.fk_vehicle_register_id"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            ComboBox_vehicle_num.DataSource = table
            ComboBox_vehicle_num.DisplayMember = "vehicle_number"
            ComboBox_vehicle_num.ValueMember = "vehicle_number"
            ComboBox_vehicle_num.SelectedIndex = -1
            ComboBox_vehicle_num.Text = "Select Vehicle Number"


        End If
        reader.Close()

    End Sub

    Private Sub ComboBox_vehicle_num_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_vehicle_num.SelectedIndexChanged

        If Open_db() Then

            str = "SELECT vehicle_register.vehicle_number,vehicle_register.vehicle_model,vehicle_register.vehicle_brand,owner_payment.paid_date,owner_payment.paid_amount FROM `owner_payment` INNER JOIN vehicle_register ON vehicle_register.vehicle_register_id=owner_payment.fk_vehicle_register_id WHERE vehicle_number = @VNUM"
            command.CommandText = str
            command.Connection = conn
            command.Parameters.Add("@VNUM", MySqlDbType.VarChar).Value = ComboBox_vehicle_num.SelectedValue
            reader = command.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                txtbill.Text = reader.GetString("paid_amount").ToString
                txtmodel.Text = reader.GetString("vehicle_model").ToString
                DateTimePicker1.Value = reader.GetString("paid_date").ToString
                txt_brand.Text = reader.GetString("vehicle_brand").ToString

            End If

        End If
        command.Parameters.Clear()
        reader.Close()

        Close_db()
    End Sub


End Class