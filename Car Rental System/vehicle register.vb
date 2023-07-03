Imports MySql.Data.MySqlClient
Imports System.IO

Public Class vehicle_registerform
    Dim command As New MySqlCommand
    Dim table, table2, table3 As New DataTable
    Dim reader As MySqlDataReader
    Dim result As Boolean
    Dim ms As New MemoryStream
    Dim str1 As String
    Private Sub vehicle_registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Open_db() Then
            str1 = "SELECT NIC,owner_id FROM vehicle_owner "
            command.CommandText = str1
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            ComboBox1.DataSource = table
            ComboBox1.DisplayMember = "NIC"
            ComboBox1.ValueMember = "owner_id"
            ComboBox1.SelectedIndex = -1
            ComboBox1.Text = "Select Owner NIC"

        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
        reader.Close()


    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click

        Dim str2, fk_owner_id, vehicle_number, brand, model, color, chassis_number, amount_per_day, delay_charge, agreement_period As String
        Dim agreement_start_date, insured_end, licence_end, emmission_end As Date
        Dim result As Boolean

        fk_owner_id = ComboBox1.SelectedValue
        vehicle_number = txtvehicle_number.Text
        brand = txtbrand.Text
        model = txtmodel.Text
        color = txtcolor.Text
        chassis_number = txtchassis.Text
        amount_per_day = txtamount_per_day.Text
        delay_charge = txtdelay_charge_per_day.Text
        agreement_period = txtagriment_period.Text


        agreement_start_date = DateTimePicker_statr_date.Value.ToShortDateString()
        insured_end = DateTimePickerend_date.Value.ToShortDateString()
        licence_end = DateTimePickerend_revenue.Value.ToShortDateString()
        emmission_end = DateTimePickerend_emission.Value.ToShortDateString()


        If Nullempty(vehicle_number) Or
            Nullempty(fk_owner_id) Or
            Nullempty(vehicle_number) Or
            Nullempty(brand) Or
            Nullempty(model) Or
            Nullempty(color) Or
            Nullempty(chassis_number) Or
            Nullempty(amount_per_day) Or
            Nullempty(delay_charge) Or
            Nullempty(agreement_period) Then
            MsgBox("Enter Data To Required Field..", vbExclamation, "Empty Feild")

        ElseIf PictureBoxvehicle.Image Is Nothing Then
            MsgBox("Vehicle Picture is Empty", vbExclamation, "Picture Empty")


        Else
            PictureBoxvehicle.Image.Save(ms, PictureBoxvehicle.Image.RawFormat)

            If Open_db() Then

                str2 = "INSERT INTO `vehicle_register`( `fk_owner_id`,`vehicle_number`, `vehicle_brand`, `vehicle_model`, `vehicle_color`, `chassis_number`, `agreement_period`, `end_insured`, `end_revenue`, `end_emission`, `amount_perday`, `delay_charge_perday`, `agreement_start_date`,`vehicle_image`) VALUES (@FK_OWNER_ID,@VN,@BN,@ML,@CR,@CN,@AGD,@APD,@DL,@AP,@IN,@LIE,@EE,@VIMAGE)"
                command.CommandText = str2
                command.Connection = conn

                command.Parameters.Add("@FK_OWNER_ID", MySqlDbType.VarChar).Value = fk_owner_id
                command.Parameters.Add("@VN", MySqlDbType.VarChar).Value = vehicle_number
                command.Parameters.Add("@BN", MySqlDbType.VarChar).Value = brand
                command.Parameters.Add("@ML", MySqlDbType.VarChar).Value = model
                command.Parameters.Add("@CR", MySqlDbType.VarChar).Value = color
                command.Parameters.Add("@CN", MySqlDbType.VarChar).Value = chassis_number
                command.Parameters.Add("@AGD", MySqlDbType.VarChar).Value = agreement_period
                command.Parameters.Add("@APD", MySqlDbType.Date).Value = insured_end
                command.Parameters.Add("@DL", MySqlDbType.Date).Value = licence_end
                command.Parameters.Add("@AP", MySqlDbType.Date).Value = emmission_end
                command.Parameters.Add("@IN", MySqlDbType.Int32).Value = amount_per_day
                command.Parameters.Add("@LIE", MySqlDbType.Int32).Value = delay_charge
                command.Parameters.Add("@EE", MySqlDbType.Date).Value = agreement_start_date
                command.Parameters.AddWithValue("@VIMAGE", ms.ToArray)


                result = command.ExecuteNonQuery
                If result Then
                    MsgBox("New vehicle add", vbInformation + vbOKOnly, "Add Vehicle")
                Else
                    MsgBox("Not added", vbExclamation + vbOKOnly, "Error")
                End If
                command.Parameters.Clear()
            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        Close_db()
    End Sub

    Private Sub btnpictureselect_Click(sender As Object, e As EventArgs) Handles btnpictureselect.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        opf.ShowDialog()

        If opf.FileName.Length > 0 Then
            PictureBoxvehicle.Image = Image.FromFile(opf.FileName)

        End If



    End Sub

    Private Sub btnall_clear_Click(sender As Object, e As EventArgs) Handles btnall_clear.Click
        txtvehicle_number.Clear()
        txtbrand.Clear()
        txtmodel.Clear()
        txtcolor.Clear()
        txtchassis.Clear()
        txtamount_per_day.Clear()
        txtdelay_charge_per_day.Clear()
        txtagriment_period.Clear()
        txtvehicle_number.Focus()
        PictureBoxvehicle.Image = Nothing
        btnregister.Enabled = True
        btnupdate_2.Visible = False
        btnupdate.Visible = True
        ComboBox1.Visible = True
        ComboBox1.SelectedIndex = -1
        ComboBox1.Text = "Select Owner NIC"
        ComboBox_nic_2.Visible = False
        txtvehicle_number.Visible = True


    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim b_image As Byte()
        If Open_db() Then

            str1 = "SELECT vehicle_register.vehicle_number,vehicle_owner.owner_id,vehicle_owner.NIC FROM `vehicle_register` INNER JOIN vehicle_owner ON vehicle_register.fk_owner_id=vehicle_owner.owner_id"
            command.CommandText = str1
            command.Connection = conn
            reader = command.ExecuteReader
            table3.Load(reader)

            ComboBox_nic_2.DataSource = table3
            ComboBox_nic_2.DisplayMember = "NIC"
            ComboBox_nic_2.ValueMember = "owner_id"
            ComboBox_nic_2.SelectedIndex = -1
            ComboBox_nic_2.Text = "Select NIC"
        End If
        reader.Close()

        If ComboBox_vehicle_no.SelectedValue = Nothing Then
            MsgBox("Select Vehicle Number before Serch", vbExclamation, "Select Value Is Nothing")
        Else

            If Open_db() Then

                str1 = "SELECT `fk_owner_id`, `vehicle_number`, `vehicle_brand`, `vehicle_model`, `vehicle_color`, `chassis_number`, `agreement_period`, `end_insured`, `end_revenue`, `end_emission`, `amount_perday`, `delay_charge_perday`, `agreement_start_date`, `vehicle_image` FROM `vehicle_register` WHERE vehicle_number = @VE_NUM"
                command.CommandText = str1
                command.Connection = conn
                command.Parameters.Add("@VE_NUM", MySqlDbType.VarChar).Value = ComboBox_vehicle_no.SelectedValue
                reader = command.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    b_image = reader("vehicle_image")
                    Dim ms3 As New MemoryStream(b_image)
                    PictureBoxvehicle.Image = Image.FromStream(ms3)

                    ComboBox_nic_2.SelectedValue = reader.GetString("fk_owner_id").ToString
                    txtbrand.Text = reader.GetString("vehicle_brand").ToString
                    txtmodel.Text = reader.GetString("vehicle_model").ToString
                    txtcolor.Text = reader.GetString("vehicle_color").ToString
                    txtchassis.Text = reader.GetString("chassis_number").ToString
                    txtagriment_period.Text = reader.GetString("agreement_period").ToString
                    txtamount_per_day.Text = reader.GetString("amount_perday").ToString
                    txtdelay_charge_per_day.Text = reader.GetString("delay_charge_perday").ToString
                    DateTimePickerend_date.Value = reader.GetString("end_insured").ToString
                    DateTimePickerend_emission.Value = reader.GetString("end_emission").ToString
                    DateTimePickerend_revenue.Value = reader.GetString("end_revenue").ToString
                    DateTimePicker_statr_date.Value = reader.GetString("agreement_start_date").ToString


                End If
            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If

        command.Parameters.Clear()
        reader.Close()
        Close_db()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        btnregister.Enabled = False
        btnupdate_2.Visible = True
        btnupdate.Visible = False
        ComboBox1.Visible = False
        ComboBox_nic_2.Visible = True
        txtvehicle_number.Visible = False

        If Open_db() Then

            str1 = "SELECT `vehicle_register_id`, vehicle_number FROM vehicle_register"
            command.CommandText = str1
            command.Connection = conn
            reader = command.ExecuteReader
            table2.Load(reader)

            ComboBox_vehicle_no.DataSource = table2
            ComboBox_vehicle_no.DisplayMember = "vehicle_number"
            ComboBox_vehicle_no.ValueMember = "vehicle_number"
            ComboBox_vehicle_no.SelectedIndex = -1
            ComboBox_vehicle_no.Text = "Select Vehicle Number"

        End If
        reader.Close()

        txtvehicle_number.Clear()
        txtbrand.Clear()
        txtmodel.Clear()
        txtcolor.Clear()
        txtchassis.Clear()
        txtamount_per_day.Clear()
        txtdelay_charge_per_day.Clear()
        txtagriment_period.Clear()
        txtvehicle_number.Focus()
        PictureBoxvehicle.Image = Nothing

    End Sub

    Private Sub btnupdate_2_Click(sender As Object, e As EventArgs) Handles btnupdate_2.Click
        Dim fk_owner_id, vehicle_number, brand, model, color, chassis_number, amount_per_day, delay_charge, agreement_period As String
        Dim agreement_start_date, insured_end, licence_end, emmission_end As Date
        Dim ms4 As New MemoryStream

        fk_owner_id = ComboBox_nic_2.SelectedValue
        vehicle_number = ComboBox_vehicle_no.SelectedValue
        brand = txtbrand.Text
        model = txtmodel.Text
        color = txtcolor.Text
        chassis_number = txtchassis.Text
        amount_per_day = txtamount_per_day.Text
        delay_charge = txtdelay_charge_per_day.Text
        agreement_period = txtagriment_period.Text

        agreement_start_date = DateTimePicker_statr_date.Value.ToShortDateString()
        insured_end = DateTimePickerend_date.Value.ToShortDateString()
        licence_end = DateTimePickerend_revenue.Value.ToShortDateString()
        emmission_end = DateTimePickerend_emission.Value.ToShortDateString()

        If Nullempty(brand) Or
            Nullempty(model) Or
            Nullempty(color) Or
            Nullempty(fk_owner_id) Or
            Nullempty(vehicle_number) Or
            Nullempty(chassis_number) Or
            Nullempty(amount_per_day) Or
            Nullempty(delay_charge) Or
            Nullempty(agreement_period) Then
            MsgBox("Enter Data To Required Field..", vbExclamation, "Empty Feild")

        ElseIf PictureBoxvehicle.Image Is Nothing Then
            MsgBox("Vehicle Picture is Empty", vbExclamation, "Picture Empty")

        Else

            PictureBoxvehicle.Image.Save(ms4, PictureBoxvehicle.Image.RawFormat)

            If Open_db() Then



                str1 = "UPDATE `vehicle_register` SET `fk_owner_id`=(@FK_ID),`vehicle_brand`=(@VBRAND),`vehicle_model`=(@VMODEL),`vehicle_color`=(@VCOLOR),`chassis_number`=(@CHASSIS_NO),`agreement_period`=(@AGREE_PERIOD),`end_insured`=(@EINSURED),`end_revenue`=(@EREVENUE),`end_emission`=(@EEMISSION),`amount_perday`=(@AMOUNT_DAY),`delay_charge_perday`=(@DCHARGE),`agreement_start_date`=(@AGREE_STRT),`vehicle_image`=(@IMAGE) WHERE `vehicle_number` = @VNO"
                command.CommandText = str1
                command.Connection = conn

                command.Parameters.Add("@FK_ID", MySqlDbType.VarChar).Value = fk_owner_id
                command.Parameters.Add("@VNO", MySqlDbType.VarChar).Value = vehicle_number
                command.Parameters.Add("@VBRAND", MySqlDbType.VarChar).Value = brand
                command.Parameters.Add("@VMODEL", MySqlDbType.VarChar).Value = model
                command.Parameters.Add("@VCOLOR", MySqlDbType.VarChar).Value = color
                command.Parameters.Add("@CHASSIS_NO", MySqlDbType.VarChar).Value = chassis_number
                command.Parameters.Add("@AGREE_PERIOD", MySqlDbType.VarChar).Value = agreement_period
                command.Parameters.Add("@EINSURED", MySqlDbType.Date).Value = insured_end
                command.Parameters.Add("@EREVENUE", MySqlDbType.Date).Value = licence_end
                command.Parameters.Add("@EEMISSION", MySqlDbType.Date).Value = emmission_end
                command.Parameters.Add("@AMOUNT_DAY", MySqlDbType.Int32).Value = amount_per_day
                command.Parameters.Add("@DCHARGE", MySqlDbType.Int32).Value = delay_charge
                command.Parameters.Add("@AGREE_STRT", MySqlDbType.Date).Value = agreement_start_date
                command.Parameters.AddWithValue("@IMAGE", ms4.ToArray)

                result = command.ExecuteNonQuery
                If result Then
                    MsgBox("Vehicle Details Update Complete", vbInformation, "Update Done")
                Else
                    MsgBox("Update Not Complete. Try Again", vbExclamation, "Update Failed")
                End If

            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If

            command.Parameters.Clear()
        End If
        Close_db()
    End Sub

    Private Sub txtamount_per_day_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtamount_per_day.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtamount_per_day.Clear()
        End If
    End Sub

    Private Sub txtdelay_charge_per_day_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdelay_charge_per_day.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtdelay_charge_per_day.Clear()
        End If
    End Sub
End Class