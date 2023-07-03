Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt
Public Class user_register
    Dim command As New MySqlCommand
    Dim result As Boolean

    Private Sub btnadduser_user_reg_Click(sender As Object, e As EventArgs) Handles btnadduser_user_reg.Click

        Dim qst, f_name, l_name, nic, username, password, user_role, contact_number, email, status As String

        f_name = txtfirst_name.Text
        l_name = txtlast_name.Text
        nic = txtnic.Text
        username = txtuser_name.Text
        password = txtpassword.Text
        user_role = If((radioadmin.Checked = True), 1, 2)
        contact_number = txtcontact.Text
        email = txtemail.Text
        status = If((radioenable.Checked = True), 1, 2)

        If Nullempty(f_name) Or
                Nullempty(l_name) Or
                Nullempty(nic) Or
                Nullempty(user_role) Or
                Nullempty(contact_number) Or
                Nullempty(email) Or
                Nullempty(status) Or
                Nullempty(password) Or
                Nullempty(username) Then
            MsgBox("ALL Feilds are Required.", vbExclamation, "Empty Feild")

        ElseIf Min_len(username, 4) Then
            MsgBox("User Name at least 4 Characters Required.", vbExclamation, "User Name Lenght not Enough")

        ElseIf Min_len(password, 5) Then
            MsgBox("Password at least 5 Characters Required.", vbExclamation, "Password Lenght not Enough")

        ElseIf Min_len(contact_number, 10) Or contact_number.Length > 10 Then
            MsgBox("Check Again Contact Number", vbExclamation, "Contact Number Incorrect")
            txtcontact.Text = ""
            txtcontact.Focus()

        ElseIf Email_check(txtemail.Text) Then
            txtemail.Text = ""
            txtemail.Focus()

        Else
            password = BCrypt.Net.BCrypt.HashPassword(password)
            username = txtuser_name.Text.ToUpper
            Try

                If Open_db() Then

                    If User_mail(txtemail.Text) Then
                        txtemail.Text = ""
                        txtemail.Focus()

                    ElseIf Username_check(txtuser_name.Text) Then
                        txtuser_name.Text = ""
                        txtuser_name.Focus()

                    ElseIf User_NIC(txtnic.Text) Then
                        txtnic.Text = ""
                        txtnic.Focus()

                    Else

                        qst = "INSERT INTO `admin`(`first_name`, `last_name`, `NIC`, `user_name`, `password`, `user_role`, `contact_number`, `email`, `status`) VALUES 
                               (@FNAME,@LNAME,@NIC,@UNAME,@PASS,@ROLE,@CONTACT,@MAIL,@STATUS)"
                        command.CommandText = qst
                        command.Connection = conn
                        command.Parameters.Add("@FNAME", MySqlDbType.VarChar).Value = f_name
                        command.Parameters.Add("@LNAME", MySqlDbType.VarChar).Value = l_name
                        command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = nic
                        command.Parameters.Add("@UNAME", MySqlDbType.VarChar).Value = username
                        command.Parameters.Add("@PASS", MySqlDbType.VarChar).Value = password
                        command.Parameters.Add("@ROLE", MySqlDbType.VarChar).Value = user_role
                        command.Parameters.Add("@CONTACT", MySqlDbType.VarChar).Value = contact_number
                        command.Parameters.Add("@MAIL", MySqlDbType.VarChar).Value = email
                        command.Parameters.Add("@STATUS", MySqlDbType.VarChar).Value = status

                        result = command.ExecuteNonQuery

                        If result Then
                            MsgBox("New User Registered", vbInformation, "User Add")
                        Else
                            MsgBox("User Register Failed", vbExclamation, "Register Failed")

                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation, "System Error")

            End Try

        End If
        command.Parameters.Clear()
    End Sub

    Private Sub btnaclear_user_reg_Click(sender As Object, e As EventArgs) Handles btnaclear_user_reg.Click
        txtfirst_name.Text = ""
        txtlast_name.Text = ""
        txtnic.Text = ""
        txtuser_name.Text = ""
        txtpassword.Text = ""
        txtcontact.Text = ""
        txtemail.Text = ""
        radioadmin.Checked = False
        radiouser.Checked = False
        radioenable.Checked = False
        radiodisable.Checked = False
        txtfirst_name.Focus()

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

    Private Sub user_register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class