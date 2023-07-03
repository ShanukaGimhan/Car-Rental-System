Public Class admin__menu
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) 

    End Sub

    Private Sub menuhome_Click(sender As Object, e As EventArgs) 
        Main_Menu.Show()
    End Sub

    Private Sub btnadd_user_Click(sender As Object, e As EventArgs)
        All_users_form.Show()
    End Sub

    Private Sub btnmanege_user_Click(sender As Object, e As EventArgs)
        Admin_mange_user.Show()
    End Sub

    Private Sub btnallusers_Click(sender As Object, e As EventArgs)
        All_users_form.Show()
    End Sub

    Private Sub btnadd_user_Click_1(sender As Object, e As EventArgs) Handles btnadd_user.Click
        user_register.Show()
    End Sub

    Private Sub btnmanege_user_Click_1(sender As Object, e As EventArgs) Handles btnmanege_user.Click
        Admin_mange_user.Show()
    End Sub

    Private Sub btnallusers_Click_1(sender As Object, e As EventArgs) Handles btnallusers.Click
        All_users_form.Show()
    End Sub

    Private Sub btnlog_out_MouseHover(sender As Object, e As EventArgs) Handles btnlog_out.MouseHover
        btnlog_out.BackColor = Color.Red
    End Sub

    Private Sub btnlog_out_MouseLeave(sender As Object, e As EventArgs) Handles btnlog_out.MouseLeave
        btnlog_out.BackColor = Color.White
    End Sub

    Private Sub btnlog_out_Click(sender As Object, e As EventArgs) Handles btnlog_out.Click
        If user_register.Visible = True Or
                Admin_mange_user.Visible = True Or
                All_users_form.Visible = True Then
            MsgBox("Make Sure All the Forms are Closed", vbExclamation, "close Form Alerts")
        Else
            Me.Hide()
            loginform.Show()
        End If
    End Sub

    Private Sub menu_manegeaccoun_Click(sender As Object, e As EventArgs) Handles menu_manegeaccoun.Click

        User_Account_manege.btnallcancel.Visible = False
        User_Account_manege.Show()

    End Sub

    Private Sub admin__menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class