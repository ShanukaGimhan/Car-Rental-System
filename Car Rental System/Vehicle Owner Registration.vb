Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Vehicle_Owner_Registration
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table As New DataTable
    Dim result As Boolean
    Dim str As String
    Private Sub Vehicle_Owner_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Open_db() Then

            str = "SELECT `user_id`, `NIC` FROM `admin`"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            Comboruser.DataSource = table
            Comboruser.DisplayMember = "NIC"
            Comboruser.ValueMember = "user_id"
            Comboruser.SelectedIndex = -1
            Comboruser.Text = "Select User NIC"
        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
        reader.Close()
    End Sub

    Private Sub btnselect_picture_Click(sender As Object, e As EventArgs) Handles btnselect_picture.Click
        Dim dialogbox As New OpenFileDialog
        dialogbox.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG"
        dialogbox.ShowDialog()
        If dialogbox.FileName.Length > 0 Then
            picturenic1.Image = Image.FromFile(dialogbox.FileName)
        End If

    End Sub

    Private Sub btnselect2_Click(sender As Object, e As EventArgs) Handles btnselect2.Click
        Dim dialogbox2 As New OpenFileDialog
        dialogbox2.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG"
        dialogbox2.ShowDialog()
        If dialogbox2.FileName.Length > 0 Then
            Picturenic2.Image = Image.FromFile(dialogbox2.FileName)
        End If

    End Sub

    Private Sub btntake_picture_Click(sender As Object, e As EventArgs) Handles btntake_picture.Click
        Dim dialogbox3 As New OpenFileDialog
        dialogbox3.Filter = "Image Files(*.JPG;*.PNG)|*.JPG;*.PNG"
        dialogbox3.ShowDialog()
        If dialogbox3.FileName.Length > 0 Then
            pictureprofile.Image = Image.FromFile(dialogbox3.FileName)
        End If

    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim ms1, ms2, ms3 As New MemoryStream
        Dim fk_user_id, frist_name, last_name, nic, contact_number, email, address_city, address_street, address_distric As String
        Dim register_date As Date


        fk_user_id = Comboruser.SelectedValue
        frist_name = txtfirst_name.Text
        last_name = txtlast_name.Text
        nic = txtnic.Text
        contact_number = txtcontact.Text
        email = txtemail.Text
        address_city = txtaddress.Text
        address_street = txtstreet.Text
        address_distric = txtdistrict.Text
        register_date = register_date_owner.Value.ToShortDateString

        If Nullempty(fk_user_id) Or
                Nullempty(frist_name) Or
                Nullempty(last_name) Or
                Nullempty(nic) Or
                Nullempty(contact_number) Or
                Nullempty(address_city) Or
                Nullempty(address_street) Or
                Nullempty(address_distric) Then
            MsgBox("Enter Data To Required Field.. you can Ignore Email if there no Data", vbExclamation, "Empty Feild")

        ElseIf Min_len(contact_number, 10) Or contact_number.Length > 10 Then
            MsgBox("Check Again Contact Number", vbExclamation, "Contact Number Incorrect")

        ElseIf Email_check(txtemail.Text) Then
            txtemail.Text = ""
            txtemail.Focus()


        ElseIf picturenic1.Image Is Nothing Then
            MsgBox("NIC Picture 01 is Empty", vbExclamation, "Picture Empty")
        ElseIf Picturenic2.Image Is Nothing Then
            MsgBox("NIC Picture 02 is Empty", vbExclamation, "Picture Empty")
        ElseIf pictureprofile.Image Is Nothing Then
            MsgBox("Profile Picture is Empty", vbExclamation, "Picture Empty")

        Else

            picturenic1.Image.Save(ms1, picturenic1.Image.RawFormat)
            Picturenic2.Image.Save(ms2, Picturenic2.Image.RawFormat)
            pictureprofile.Image.Save(ms3, pictureprofile.Image.RawFormat)


            If Open_db() Then

                str = "INSERT INTO `vehicle_owner`(`fk_user_id`, `first_name`, `last_name`, `NIC`, `contact_number`, `address_street`, `address_city`, `address_distric`, `email`, `NIC_picture`, `NIC_picture_02`, `profile_picture`, `register_date`)
                             VALUES (@U_ID,@FNAME,@LNAME,@NIC,@CONTACT,@STREET,@CITY,@DISTRIC,@MAIL,@NIC_PIC1,@NIC_PIC2,@PROFILE,@DATE)"
                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@U_ID", MySqlDbType.Int32).Value = fk_user_id
                command.Parameters.Add("@FNAME", MySqlDbType.VarChar).Value = frist_name
                command.Parameters.Add("@LNAME", MySqlDbType.VarChar).Value = last_name
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = nic
                command.Parameters.Add("@CONTACT", MySqlDbType.Int32).Value = contact_number
                command.Parameters.Add("@MAIL", MySqlDbType.VarChar).Value = email
                command.Parameters.Add("@CITY", MySqlDbType.VarChar).Value = address_city
                command.Parameters.Add("@STREET", MySqlDbType.VarChar).Value = address_street
                command.Parameters.Add("@DISTRIC", MySqlDbType.VarChar).Value = address_distric
                command.Parameters.Add("@DATE", MySqlDbType.Date).Value = register_date
                command.Parameters.AddWithValue("@NIC_PIC1", ms1.ToArray)
                command.Parameters.AddWithValue("@NIC_PIC2", ms2.ToArray)
                command.Parameters.AddWithValue("@PROFILE", ms3.ToArray)

                result = command.ExecuteNonQuery
                If result Then
                    MsgBox("New Owner Registered", vbInformation, "Owner Add")
                Else
                    MsgBox("Owner Register Failed", vbExclamation, "Register Failed")
                End If

                command.Parameters.Clear()

            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        Close_db()
    End Sub

    Private Sub btnallclear_Click(sender As Object, e As EventArgs) Handles btnallclear.Click
        txtfirst_name.Text = ""
        txtlast_name.Text = ""
        txtnic.Text = ""
        txtcontact.Text = ""
        txtemail.Text = ""
        txtaddress.Text = ""
        txtstreet.Text = ""
        txtdistrict.Text = ""
        picturenic1.Image = Nothing
        Picturenic2.Image = Nothing
        pictureprofile.Image = Nothing
        btnregister.Enabled = True
        txtfirst_name.Visible = True
        lbl_fname_1.Visible = True
        lbl_lname_1.Visible = True
        lblnic_1.Visible = True
        Comboruser.Visible = True
        btnupdate_2.Visible = False
        btnupdate.Visible = True
        Comboruser.Text = "Select User NIC"
        txtnic.Visible = True
        txtnic_2.Visible = False

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim table3 As New DataTable

        btnregister.Enabled = False
        txtfirst_name.Visible = False
        lbl_fname_1.Visible = False
        lbl_lname_1.Visible = False
        lblnic_1.Visible = False
        Comboruser.Visible = False
        btnupdate.Visible = False
        btnupdate_2.Visible = True
        txtnic.Visible = False
        txtnic_2.Visible = True

        If Open_db() Then

            str = "SELECT `NIC`FROM `vehicle_owner`"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table3.Load(reader)
            ComboBox_nic.DataSource = table3
            ComboBox_nic.DisplayMember = "NIC"
            ComboBox_nic.ValueMember = "NIC"
            ComboBox_nic.SelectedIndex = -1
            ComboBox_nic.Text = "Select Owner NIC"

        End If
        reader.Close()

        txtfirst_name.Text = ""
        txtlast_name.Text = ""
        txtnic.Text = ""
        txtcontact.Text = ""
        txtemail.Text = ""
        txtaddress.Text = ""
        txtstreet.Text = ""
        txtdistrict.Text = ""
        picturenic1.Image = Nothing
        Picturenic2.Image = Nothing
        pictureprofile.Image = Nothing

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        Dim table4 As New DataTable
        Dim b_image1, b_image2, b_image3 As Byte()
        If Open_db() Then

            str = "SELECT admin.user_id,admin.NIC,vehicle_owner.fk_user_id FROM `vehicle_owner` INNER JOIN admin ON vehicle_owner.fk_user_id=admin.user_id"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table4.Load(reader)
            ComboBox_user_2.DataSource = table4
            ComboBox_user_2.DisplayMember = "NIC"
            ComboBox_user_2.ValueMember = "fk_user_id"
            ComboBox_user_2.Enabled = False


        End If

        reader.Close()

        If ComboBox_nic.SelectedValue = Nothing Then
            MsgBox("Select NIC Number before Serch", vbExclamation, "Select Value Is Nothing")

        Else
            If Open_db() Then

                str = "SELECT `fk_user_id`, `first_name`, `last_name`, `contact_number`, `address_street`, `address_city`, `address_distric`, `email`, `NIC_picture`, `NIC_picture_02`, `profile_picture`, `register_date` FROM `vehicle_owner` WHERE `NIC` = @NIC"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = ComboBox_nic.SelectedValue
                reader = command.ExecuteReader
                If reader.HasRows = True Then
                    reader.Read()
                    b_image1 = reader("NIC_picture")
                    b_image2 = reader("NIC_picture_02")
                    b_image3 = reader("profile_picture")

                    Dim ms4 As New MemoryStream(b_image1)
                    picturenic1.Image = Image.FromStream(ms4)
                    Dim ms5 As New MemoryStream(b_image2)
                    Picturenic2.Image = Image.FromStream(ms5)
                    Dim ms6 As New MemoryStream(b_image3)
                    pictureprofile.Image = Image.FromStream(ms6)

                    ComboBox_user_2.SelectedValue = reader.GetString("fk_user_id").ToString
                    txtlast_name.Text = reader.GetString("first_name").ToString
                    txtnic_2.Text = reader.GetString("last_name").ToString
                    txtcontact.Text = reader.GetString("contact_number").ToString
                    txtstreet.Text = reader.GetString("address_street").ToString
                    txtaddress.Text = reader.GetString("address_city").ToString
                    txtdistrict.Text = reader.GetString("address_distric").ToString
                    txtemail.Text = reader.GetString("email").ToString
                    register_date_owner.Value = reader.GetString("register_date").ToString

                ElseIf reader.HasRows = False Then
                    MsgBox("Some Feilds Are Empty.. Register Owner Again", vbExclamation, "Error Load Data")
                End If
                reader.Close()
                command.Parameters.Clear()

            End If
        End If
        Close_db()
    End Sub

    Private Sub btnupdate_2_Click(sender As Object, e As EventArgs) Handles btnupdate_2.Click

        Dim register_date As Date
        Dim fk_user_id, frist_name, last_name, nic, contact_number, email, address_city, address_street, address_distric As String
        Dim ms7, ms8, ms9 As New MemoryStream


        fk_user_id = ComboBox_user_2.SelectedValue
        frist_name = txtlast_name.Text
        last_name = txtnic_2.Text
        nic = ComboBox_nic.SelectedValue
        contact_number = txtcontact.Text
        email = txtemail.Text
        address_street = txtdistrict.Text
        address_city = txtaddress.Text
        address_distric = txtdistrict.Text
        register_date = register_date_owner.Value.ToShortDateString


        If Nullempty(fk_user_id) Or
                Nullempty(frist_name) Or
                Nullempty(last_name) Or
                Nullempty(nic) Or
                Nullempty(contact_number) Or
                Nullempty(email) Or
                Nullempty(address_street) Or
                Nullempty(address_city) Or
                Nullempty(address_distric) Then
            MsgBox("Enter Data To Required Field.. you can Ignore Email if there no Data", vbExclamation, "Empty Feild")

        ElseIf Email_check(txtemail.Text) Then
            txtemail.Text = ""
            txtemail.Focus()

        ElseIf picturenic1.Image Is Nothing Then
            MsgBox("NIC Picture 01 is Empty", vbExclamation, "Picture Empty")
        ElseIf Picturenic2.Image Is Nothing Then
            MsgBox("NIC Picture 02 is Empty", vbExclamation, "Picture Empty")
        ElseIf pictureprofile.Image Is Nothing Then
            MsgBox("Profile Picture is Empty", vbExclamation, "Picture Empty")

        Else

            picturenic1.Image.Save(ms7, picturenic1.Image.RawFormat)
            Picturenic2.Image.Save(ms8, Picturenic2.Image.RawFormat)
            pictureprofile.Image.Save(ms9, pictureprofile.Image.RawFormat)


            If Open_db() Then

                str = "UPDATE `vehicle_owner` SET `fk_user_id`=(@FKU),`first_name`=(@FNAME),`last_name`=(@LNAME),`NIC`=(@NIC),`contact_number`=(@CONTACT),
                 `address_street`=(@STREET),`address_city`=(@CITY),`address_distric`=(@DISTRIC),`email`=(@MAIL),`NIC_picture`=(@NIC1),`NIC_picture_02`=(@NIC2),
                   `profile_picture`=(@PROFILE),`register_date`=(@DATE) WHERE `NIC`=(@NIC)"
                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@FKU", MySqlDbType.VarChar).Value = fk_user_id
                command.Parameters.Add("@FNAME", MySqlDbType.VarChar).Value = frist_name
                command.Parameters.Add("@LNAME", MySqlDbType.VarChar).Value = last_name
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = nic
                command.Parameters.Add("@CONTACT", MySqlDbType.VarChar).Value = contact_number
                command.Parameters.Add("@STREET", MySqlDbType.VarChar).Value = address_street
                command.Parameters.Add("@CITY", MySqlDbType.VarChar).Value = address_city
                command.Parameters.Add("@DISTRIC", MySqlDbType.VarChar).Value = address_distric
                command.Parameters.Add("@MAIL", MySqlDbType.VarChar).Value = email
                command.Parameters.Add("@DATE", MySqlDbType.Date).Value = register_date

                command.Parameters.AddWithValue("@NIC1", ms7.ToArray)
                command.Parameters.AddWithValue("@NIC2", ms8.ToArray)
                command.Parameters.AddWithValue("@PROFILE", ms9.ToArray)

                result = command.ExecuteNonQuery

                If result Then
                    MsgBox("Vehicle Owner Updata Complete", vbInformation, "Update Done")
                Else
                    MsgBox("Update Not Complete. Try Again", vbExclamation, "Update Failed")
                End If


            End If
            command.Parameters.Clear()
        End If
        Close_db()
    End Sub

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtcontact.Clear()
        End If
    End Sub

    Private Sub txtfirst_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfirst_name.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox(" Only Letters Are Allow", vbExclamation, "Enter Letters only")
            txtfirst_name.Text = ""
        End If
    End Sub

    Private Sub txtlast_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlast_name.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox(" Only Letters Are Allow", vbExclamation, "Enter Letters only")
            txtlast_name.Text = ""
        End If
    End Sub

    Private Sub txtdistrict_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdistrict.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox(" Only Letters Are Allow", vbExclamation, "Enter Letters only")
            txtdistrict.Text = ""
        End If
    End Sub

    Private Sub txtnic_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnic_2.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox(" Only Letters Are Allow", vbExclamation, "Enter Letters only")
        End If
    End Sub

    Private Sub txtnic_Leave(sender As Object, e As EventArgs) Handles txtnic.Leave

        If Not NIC_check(txtnic.Text) = True Then
            MsgBox("NIC is Not in a Correct Format", vbExclamation, "Invalid NIC Number")
            txtnic.Text = ""
            txtnic.Focus()

        ElseIf NIC_lenght(txtnic.Text) = True Then
            MsgBox("NIC is Not in a Correct Format", vbExclamation, "Invalid NIC Number")
            txtnic.Text = ""
            txtnic.Focus()

        Else
            MsgBox("Make Sure If NIC Number In 10 Character After 'v' Numbers Are Not Allow", vbInformation, "Confirm NIC Number Format")
        End If

    End Sub
End Class