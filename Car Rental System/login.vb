Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt
Public Class loginform

    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim result As Boolean

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click


        Dim username, password, qst, hash_db, role, status As String
        username = txtusername.Text
        password = txtpass.Text

        If Nullempty(username) Or
                Nullempty(password) Then
            MsgBox("Both Feilds are Required.", vbExclamation, "Empty Feild")
        Else

            Try
                If Open_db() Then

                    qst = "SELECT  `user_name`, `password`,`user_role`,`status` FROM `admin` WHERE `user_name` = @USER LIMIT 1"
                    command.CommandText = qst
                    command.Connection = conn
                    command.Parameters.Add("@USER", MySqlDbType.VarChar).Value = username
                    'command.Parameters.Add("@PASS", MySqlDbType.VarChar).Value = password
                    reader = command.ExecuteReader

                    If reader.HasRows() = True Then
                        reader.Read()
                        role = reader("user_role").ToString
                        status = reader("status").ToString
                        hash_db = reader("password").ToString
                        result = BCrypt.Net.BCrypt.Verify(password, hash_db)
                        If result Then
                            If status = "1" Then
                                If role = "1" Then
                                    Me.Hide()
                                    admin__menu.Show()
                                ElseIf role = "2" Then
                                    Me.Hide()
                                    Main_Menu.Show()
                                End If
                            ElseIf status = "2" Then
                                MsgBox("User Disable", vbExclamation, "User Blocked")
                            End If
                        Else
                            MsgBox("invalid login. Try Again", vbExclamation, "Login Failed")
                        End If
                    ElseIf reader.HasRows() = False Then
                        MsgBox("invalid login. Try Again", vbExclamation, "Login Failed")

                    End If
                Else
                    MsgBox("Connection Error", vbExclamation, "Lost Connection")
                End If
                reader.Close()
                command.Parameters.Clear()
                txtpass.Text = ""
                txtusername.Text = ""
                txtpass.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Close_db()
    End Sub

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpass.UseSystemPasswordChar = True
    End Sub

    Private Sub checkshowpass_CheckedChanged(sender As Object, e As EventArgs) Handles checkshowpass.CheckedChanged
        If checkshowpass.CheckState = CheckState.Checked Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnlogin_MouseHover(sender As Object, e As EventArgs) Handles btnlogin.MouseHover
        btnlogin.BackColor = Color.Cyan
        btnlogin.ForeColor = (Color.Black)
    End Sub

    Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnlogin.MouseLeave
        btnlogin.BackColor = Color.DarkCyan
        btnlogin.ForeColor = Color.WhiteSmoke
    End Sub
End Class