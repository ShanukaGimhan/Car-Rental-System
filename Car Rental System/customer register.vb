Imports MySql.Data.MySqlClient
Imports System.IO

Public Class customer_registerform

    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table As New DataTable
    Dim table2 As New DataTable
    Dim ms As New MemoryStream
    Dim ms2 As New MemoryStream
    Dim ms3 As New MemoryStream
    Dim result As Boolean
    Dim str1 As String


    Private Sub customer_registerform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Open_db() Then

            str1 = "SELECT NIC,user_id FROM `admin`"
            command.CommandText = str1
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)

            ComboBox_register_user.DataSource = table
            ComboBox_register_user.DisplayMember = "NIC"
            ComboBox_register_user.ValueMember = "user_id"
            ComboBox_register_user.SelectedIndex = -1
            ComboBox_register_user.Text = "Select User NIC"
        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")

        End If
        Close_db()

    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click

        Dim str2, fk_user_id, First_name, Last_name, Nic, Contact_01, Contact_02, Email, Address_street, Address_city, Address_district As String
        Dim Register_date As Date


        fk_user_id = ComboBox_register_user.SelectedValue
        First_name = txtfirst_name.Text
        Last_name = txtlast_name.Text
        Nic = txtnic.Text
        Contact_01 = txtcontact01.Text
        Contact_02 = txtcontact02.Text
        Email = txtemail.Text
        Address_street = txtfstreet.Text
        Address_city = txtfcity.Text
        Address_district = txtfdistrict.Text
        Register_date = DateTimePicker1.Value.ToShortDateString()


        If Nullempty(First_name) Or
                Nullempty(Last_name) Or
                Nullempty(Nic) Or
                Nullempty(Contact_01) Or
                Nullempty(Address_street) Or
                Nullempty(Address_city) Or
                Nullempty(Address_district) Or
                Nullempty(fk_user_id) Then

            MsgBox("Enter Data To Required Field.. you can Ignore Contact number 2 and Email if there no Data", vbExclamation, "Empty Feild")

        ElseIf Min_len(Contact_01, 10) Or Contact_01.Length > 10 Or
                Min_len(Contact_02, 10) Or Contact_02.Length > 10 Then
            MsgBox("Check Again Contact Number", vbExclamation, "Contact Number Incorrect")

        ElseIf Email_check(txtemail.Text) Then
            txtemail.Text = ""
            txtemail.Focus()



        ElseIf pictureboxnic.Image Is Nothing Then
            MsgBox("NIC Picture 01 is Empty", vbExclamation, "Picture Empty")
        ElseIf Picturenic2.Image Is Nothing Then
            MsgBox("NIC Picture 02 is Empty", vbExclamation, "Picture Empty")
        ElseIf pictureboxprofile.Image Is Nothing Then
            MsgBox("Profile Picture is Empty", vbExclamation, "Picture Empty")

        Else

            pictureboxnic.Image.Save(ms, pictureboxnic.Image.RawFormat)
            Picturenic2.Image.Save(ms2, Picturenic2.Image.RawFormat)
            pictureboxprofile.Image.Save(ms3, pictureboxprofile.Image.RawFormat)

            If Open_db() Then


                str2 = "INSERT INTO `customer` (`fk_user_id`,`first_name`, `last_name`,`nic`,`contact_01`,`contact_02`,`email`,`address_street`,`address_city`,`address_district`,`register_date`,`NIC_pic`,NIC_picture_02, `profile_pic` ) VALUES 
                (@FK_USER_ID,@FNAME,@LNAME,@NIC,@CONTACT_1,@CONTACT_2,@EMAIL,@ASTREET,@ACITY,@ADISTRICT,@DATE,@NIC_PIC,@NIC_PIC2,@PROFILE)"

                command.CommandText = str2
                command.Connection = conn

                command.Parameters.Add("@FK_USER_ID", MySqlDbType.VarChar).Value = fk_user_id
                command.Parameters.Add("@FNAME", MySqlDbType.VarChar).Value = First_name
                command.Parameters.Add("@LNAME", MySqlDbType.VarChar).Value = Last_name
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = Nic
                command.Parameters.Add("@CONTACT_1", MySqlDbType.VarChar).Value = Contact_01
                command.Parameters.Add("@CONTACT_2", MySqlDbType.VarChar).Value = Contact_02
                command.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = Email
                command.Parameters.Add("@ASTREET", MySqlDbType.VarChar).Value = Address_street
                command.Parameters.Add("@ACITY", MySqlDbType.VarChar).Value = Address_city
                command.Parameters.Add("@ADISTRICT", MySqlDbType.VarChar).Value = Address_district
                command.Parameters.Add("@DATE", MySqlDbType.Date).Value = Register_date

                command.Parameters.AddWithValue("@NIC_PIC", ms.ToArray)
                command.Parameters.AddWithValue("@NIC_PIC2", ms2.ToArray)
                command.Parameters.AddWithValue("@PROFILE", ms3.ToArray)

                result = command.ExecuteNonQuery

                If result Then
                    MsgBox("Customer Register Done", vbInformation + vbOKOnly, "Register Complete")
                Else
                    MsgBox("Customer Register Failed", vbExclamation + vbOKOnly, "Register Not Complete")
                End If
            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        command.Parameters.Clear()
        Close_db()

    End Sub

    Private Sub btnselect_picture_Click(sender As Object, e As EventArgs) Handles btnselect_picture.Click

        Dim openfile1 As New OpenFileDialog
        openfile1.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        openfile1.ShowDialog()
        If openfile1.FileName.Length > 0 Then
            pictureboxnic.Image = Image.FromFile(openfile1.FileName)
        End If



    End Sub

    Private Sub btnselect2_Click(sender As Object, e As EventArgs) Handles btnselect2.Click
        Dim openfile2 As New OpenFileDialog

        openfile2.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        openfile2.ShowDialog()
        If openfile2.FileName.Length > 0 Then
            Picturenic2.Image = Image.FromFile(openfile2.FileName)

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openfile3 As New OpenFileDialog

        openfile3.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        openfile3.ShowDialog()
        If openfile3.FileName.Length > 0 Then
            pictureboxprofile.Image = Image.FromFile(openfile3.FileName)
        End If


    End Sub

    Private Sub btnallclear_Click(sender As Object, e As EventArgs) Handles btnallclear.Click
        txtfirst_name.Clear()
        txtlast_name.Clear()
        txtnic.Clear()
        txtcontact01.Clear()
        txtcontact02.Clear()
        txtemail.Clear()
        txtfstreet.Clear()
        txtfcity.Clear()
        txtfdistrict.Clear()
        txtfirst_name.Focus()
        pictureboxnic.Image = Nothing
        Picturenic2.Image = Nothing
        pictureboxprofile.Image = Nothing
        btnregister.Enabled = True
        btnupdate2.Visible = False
        btnupdate.Visible = True
        txtfirst_name.Visible = True
        ComboBox_nic.Visible = False
        lablel_last_name.Visible = False
        lable_fname.Visible = False
        lable_nic2.Visible = False
        lable_l1.Visible = True
        lable_f1.Visible = True
        lable_nic1.Visible = True
        ComboBox_register_user.Visible = True
        ComboBox_register_user_2.Visible = False
        txtnic.Visible = True
        txtnic_2.Visible = False
        ComboBox_register_user.SelectedIndex = -1
        ComboBox_register_user.Text = "Select User NIC"

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        btnregister.Enabled = False
        txtfirst_name.Visible = False
        ComboBox_nic.Visible = True
        lablel_last_name.Visible = True
        lable_fname.Visible = True
        lable_nic2.Visible = True
        lable_l1.Visible = False
        'lable_nic2.Visible = True
        lable_f1.Visible = False
        lable_nic1.Visible = False
        btnupdate.Visible = False
        btnupdate2.Visible = True
        ComboBox_register_user.Visible = False
        ComboBox_register_user_2.Visible = True
        txtnic.Visible = False
        txtnic_2.Visible = True

        If Open_db() Then
            str1 = "SELECT `NIC` FROM `customer`"
            command.CommandText = str1
            command.Connection = conn
            reader = command.ExecuteReader
            table2.Load(reader)
            ComboBox_nic.DataSource = table2
            ComboBox_nic.DisplayMember = "NIC"
            ComboBox_nic.ValueMember = "NIC"
            ComboBox_nic.SelectedIndex = -1
            ComboBox_nic.Text = "Select Customer NIC"


        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
        reader.Close()


        txtfirst_name.Clear()
        txtlast_name.Clear()
        txtnic.Clear()
        txtcontact01.Clear()
        txtcontact02.Clear()
        txtemail.Clear()
        txtfstreet.Clear()
        txtfcity.Clear()
        txtfdistrict.Clear()
        txtfirst_name.Focus()
        pictureboxnic.Image = Nothing
        Picturenic2.Image = Nothing
        pictureboxprofile.Image = Nothing

    End Sub


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim table3 As New DataTable
        If Open_db() Then
            str1 = "SELECT admin.user_id,admin.NIC,customer.fk_user_id FROM `admin` INNER JOIN customer ON admin.user_id=customer.fk_user_id"
            command.CommandText = str1
            command.Connection = conn
            reader = command.ExecuteReader
            table3.Load(reader)
            ComboBox_register_user_2.DataSource = table3
            ComboBox_register_user_2.DisplayMember = "NIC"
            ComboBox_register_user_2.ValueMember = "fk_user_id"
            ComboBox_register_user_2.Enabled = False
            ComboBox_register_user_2.SelectedIndex = -1


        End If

        reader.Close()


        Dim byte_img, byte_img1, byte_img2 As Byte()

        If ComboBox_nic.SelectedValue = Nothing Then
            MsgBox("Select NIC Number before Serch", vbExclamation, "Select Value Is Nothing")


        Else

            If Open_db() Then

                str1 = "SELECT `fk_user_id`, `first_name`, `last_name`, `NIC`, `contact_01`, `contact_02`, `email`, `address_street`, `address_city`, `address_district`, `NIC_pic`, `NIC_picture_02`, `profile_pic`, `register_date` FROM `customer` WHERE `NIC`=@NIC"
                command.CommandText = str1
                command.Connection = conn
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = ComboBox_nic.SelectedValue
                reader = command.ExecuteReader

                If reader.HasRows() Then
                    reader.Read()

                    byte_img = reader("NIC_pic")
                    byte_img1 = reader("NIC_picture_02")
                    byte_img2 = reader("profile_pic")

                    Dim ms4 As New MemoryStream(byte_img)
                    pictureboxnic.Image = Image.FromStream(ms4)
                    Dim ms5 As New MemoryStream(byte_img1)
                    Picturenic2.Image = Image.FromStream(ms5)
                    Dim ms6 As New MemoryStream(byte_img2)
                    pictureboxprofile.Image = Image.FromStream(ms6)



                    txtlast_name.Text = reader.GetString("first_name").ToString
                    txtnic_2.Text = reader.GetString("last_name").ToString
                    txtcontact01.Text = reader.GetString("contact_01").ToString
                    txtcontact02.Text = reader.GetString("contact_02").ToString
                    txtemail.Text = reader.GetString("email").ToString
                    txtfstreet.Text = reader.GetString("address_street").ToString
                    txtfcity.Text = reader.GetString("address_city").ToString
                    txtfdistrict.Text = reader.GetString("address_district").ToString
                    DateTimePicker1.Value = reader.GetString("register_date").ToString
                    ComboBox_register_user_2.SelectedValue = reader.GetString("fk_user_id").ToString

                End If

            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        command.Parameters.Clear()
        reader.Close()
        Close_db()
    End Sub

    Private Sub btnupdate2_Click(sender As Object, e As EventArgs) Handles btnupdate2.Click



        Dim fk_user_id, First_name, Last_name, Nic, Contact_01, Contact_02, Email, Address_street, Address_city, Address_district As String
        Dim Register_date As Date
        Dim ms7, ms8, ms9 As New MemoryStream

        fk_user_id = ComboBox_register_user.SelectedValue
        First_name = txtlast_name.Text
        Last_name = txtnic_2.Text
        Nic = ComboBox_nic.SelectedValue
        Contact_01 = txtcontact01.Text
        Contact_02 = txtcontact02.Text
        Email = txtemail.Text
        Address_street = txtfstreet.Text
        Address_city = txtfcity.Text
        Address_district = txtfdistrict.Text
        Register_date = DateTimePicker1.Value.ToShortDateString


        If Nullempty(First_name) Or
                Nullempty(Last_name) Or
                Nullempty(Nic) Or
                Nullempty(Contact_01) Or
                Nullempty(Address_street) Or
                Nullempty(Address_city) Or
                Nullempty(Address_district) Or
                Nullempty(fk_user_id) Or
                Nullempty(Nic) Then
            MsgBox("Enter Data To Required Field.. you can Ignore Contact number 2 and Email if there no Data", vbExclamation, "Empty Feild")

        ElseIf Email_check(txtemail.Text) Then
            txtemail.Text = ""
            txtemail.Focus()

        ElseIf pictureboxnic.Image Is Nothing Then
            MsgBox("NIC Picture 01 is Empty", vbExclamation, "Picture Empty")
        ElseIf Picturenic2.Image Is Nothing Then
            MsgBox("NIC Picture 02 is Empty", vbExclamation, "Picture Empty")
        ElseIf pictureboxprofile.Image Is Nothing Then
            MsgBox("Profile Picture is Empty", vbExclamation, "Picture Empty")

        Else

            pictureboxnic.Image.Save(ms7, pictureboxnic.Image.RawFormat)
            Picturenic2.Image.Save(ms8, Picturenic2.Image.RawFormat)
            pictureboxprofile.Image.Save(ms9, pictureboxprofile.Image.RawFormat)


            If Open_db() Then

                str1 = "UPDATE `customer` Set `fk_user_id`=(@FKUID),`first_name`=(@FNAME),`last_name`=(@LNAME),`NIC`=(@NIC),`contact_01`=(@CON1),
                `contact_02`=(@CON2),`email`=(@EMAIL),`address_street`=(@STREET),`address_city`=(@CITY),
                `address_district`=(@DISTRICT),`NIC_pic`=(@NICPIC_1), `NIC_picture_02`=(@NICPIC_2),`profile_pic`=(@PROFILEPIC),`register_date`=(@DATE) WHERE `NIC` = @NIC"

                command.CommandText = str1
                command.Connection = conn
                command.Parameters.Add("@FKUID", MySqlDbType.VarChar).Value = fk_user_id
                command.Parameters.Add("@FNAME", MySqlDbType.VarChar).Value = First_name
                command.Parameters.Add("@LNAME", MySqlDbType.VarChar).Value = Last_name
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = Nic
                command.Parameters.Add("@CON1", MySqlDbType.VarChar).Value = Contact_01
                command.Parameters.Add("@CON2", MySqlDbType.VarChar).Value = Contact_02
                command.Parameters.Add("@EMAIL", MySqlDbType.VarChar).Value = Email
                command.Parameters.Add("@STREET", MySqlDbType.VarChar).Value = Address_street
                command.Parameters.Add("@CITY", MySqlDbType.VarChar).Value = Address_city
                command.Parameters.Add("@DISTRICT", MySqlDbType.VarChar).Value = Address_district
                command.Parameters.Add("@DATE", MySqlDbType.Date).Value = Register_date

                command.Parameters.AddWithValue("@NICPIC_1", ms7.ToArray)
                command.Parameters.AddWithValue("@NICPIC_2", ms8.ToArray)
                command.Parameters.AddWithValue("@PROFILEPIC", ms9.ToArray)

                result = command.ExecuteNonQuery
                If result Then
                    MsgBox("Customer Updata Complete", vbInformation, "Update Done")
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

    Private Sub txtcontact01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact01.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtcontact01.Clear()
        End If
    End Sub

    Private Sub txtcontact02_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact02.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtcontact02.Clear()
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

    Private Sub txtfdistrict_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfdistrict.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox(" Only Letters Are Allow", vbExclamation, "Enter Letters only")
            txtfdistrict.Text = ""
        End If
    End Sub

    Private Sub txtnic_2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnic_2.KeyPress

        If Not Char.IsLetter(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox(" Only Letters Are Allow", vbExclamation, "Enter Letters only")
            txtnic_2.Text = ""
        End If

    End Sub

    Private Sub txtnic_Leave(sender As Object, e As EventArgs) Handles txtnic.Leave

        If Not NIC_check(txtnic.Text) = True Then
            MsgBox("NIC is Not in a Correct Format", vbExclamation, "Invalid NIC Number")
            txtnic.Text = ""
            txtnic.Focus()

        ElseIf NIC_lenght(txtnic.Text) Then
            MsgBox("NIC is Not in a Correct Format", vbExclamation, "Invalid NIC Number")
            txtnic.Text = ""
            txtnic.Focus()

        Else
            MsgBox("Make Sure If NIC Number In 10 Character After 'v' Numbers Are Not Allow", vbInformation, "Confirm NIC Number Format")
        End If

    End Sub
End Class