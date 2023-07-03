Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt
Imports System.Net.Mail
Public Class User_Account_manege
    Dim command As New MySqlCommand
    Dim table As New DataTable
    Dim str As String
    Dim result As Boolean

    Private Sub btnchange_password_Click(sender As Object, e As EventArgs) Handles btnchange_password.Click
        panelpassword.Visible = True
        paneldescription.Visible = False
    End Sub

    Private Sub btnupdate_password_Click(sender As Object, e As EventArgs) Handles btnupdate_password.Click
        Dim reader As MySqlDataReader
        Dim result2 As Boolean
        Dim password, new_password, repasword, db_hash, username, db_mail As String

        username = txtusename.Text
        password = txtcurent_pass.Text
        new_password = txtnewpass.Text
        repasword = txtrepass.Text



        If Nullempty(username) Or
                Nullempty(password) Or
                Nullempty(new_password) Or
                Nullempty(repasword) Then
            MsgBox("ALL Feilds are Required.", vbExclamation, "Empty Feild")

        ElseIf Not Check_str(new_password, repasword) Then
            MsgBox("New Password and Re Type Password not Match", vbExclamation, " Error Password Match")

        ElseIf Min_len(new_password, 5) Then
            MsgBox("New Password at least 5 Characters Required.", vbExclamation, "Password Lenght not Enough")
            txtnewpass.Text = ""
            txtrepass.Text = ""
            txtnewpass.Focus()


        Else
            new_password = BCrypt.Net.BCrypt.HashPassword(new_password)
            If Open_db() Then

                str = "SELECT `user_name`, `password`,email FROM `admin` WHERE `user_name` = @USER"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@USER", MySqlDbType.VarChar).Value = username
                reader = command.ExecuteReader
                command.Parameters.Clear()

                If reader.HasRows = True Then

                    reader.Read()
                    db_hash = reader("password").ToString
                    'db_mail = reader("email").ToString
                    db_mail = reader("email").ToString
                    result = BCrypt.Net.BCrypt.Verify(password, db_hash)
                    reader.Close()

                    If result Then

                        str = "UPDATE `admin` SET `password`=(@NEWPASS) WHERE `user_name`=(@USER1) LIMIT 1"
                        command.CommandText = str
                        command.Connection = conn
                        command.Parameters.Add("@USER1", MySqlDbType.VarChar).Value = username
                        command.Parameters.Add("@NEWPASS", MySqlDbType.VarChar).Value = new_password
                        result2 = command.ExecuteNonQuery

                        If result2 Then



                            Dim smtp_server As New SmtpClient
                            Dim mail As New MailMessage
                            smtp_server.UseDefaultCredentials = False
                            smtp_server.Credentials = New Net.NetworkCredential("carenting222@gmail.com", "project222")
                            smtp_server.Port = 587
                            smtp_server.EnableSsl = True
                            smtp_server.Host = "smtp.gmail.com"
                            mail = New MailMessage()
                            mail.From = New MailAddress("carenting222@gmail.com")
                            mail.To.Add(db_mail)
                            mail.Subject = "Change Password In Car Rental System"
                            mail.Body = txtnewpass.Text
                            smtp_server.Send(mail)
                            ' reader.Close()

                            MsgBox("Password Change Complete.. New Password Send Your Email..", vbInformation, "Change Done")
                        Else
                            MsgBox("Password Change Failed", vbExclamation, "Change Failed")
                        End If
                        command.Parameters.Clear()

                        ' reader.Close()
                    Else
                        MsgBox("Incorrect Current Password or Username ", vbExclamation, "Invalid Password")

                    End If
                    reader.Close()
                ElseIf reader.HasRows = False Then
                    MsgBox("Incorrect Current Password or Username ", vbExclamation, "Invalid Password")
                End If

                reader.Close()
            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If

        End If
        Close_db()

    End Sub

    Private Sub btncancel_password_Click_1(sender As Object, e As EventArgs) Handles btncancel_password.Click
        txtusename.Text = ""
        txtrepass.Text = ""
        txtcurent_pass.Text = ""
        txtnewpass.Text = ""
        txtusename.Focus()
    End Sub

    Private Sub btnallcancel_Click_1(sender As Object, e As EventArgs) Handles btnallcancel.Click

        Me.Hide()
        Main_Menu.Show()


    End Sub

    Private Sub User_Account_manege_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class