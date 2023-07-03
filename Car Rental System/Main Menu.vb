Public Class Main_Menu

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnlog_out_Click(sender As Object, e As EventArgs) Handles btnlog_out.Click

        If admin__menu.Visible = True Or
                Admin_mange_user.Visible = True Or
                All_users_form.Visible = True Or
                Calculate_From.Visible = True Or
                Customer_Bill.Visible = True Or
                Customer_Payment.Visible = True Or
                customer_registerform.Visible = True Or
                customer_report.Visible = True Or
                Customer.Visible = True Or
                Damege_vehicle_summaryform.Visible = True Or
                demage_vehicle_commentform.Visible = True Or
                Rented_report.Visible = True Or
                New_report.Visible = True Or
                User_Account_manege.Visible = True Or
                user_register.Visible = True Or
                Vehicle_Order.Visible = True Or
                Vehicle_Owner_Payment.Visible = True Or
                Vehicle_Owner_Bill.Visible = True Or
                Vehicle_Owner_Registration.Visible = True Or
                Vehicle_owner_report.Visible = True Or
                vehicle_registerform.Visible = True Or
                Vehicle_Report.Visible = True Or
                Vehicle.Visible = True Or
                Vehicle_Owner.Visible = True Then

            MsgBox("Make Sure All the Forms are Closed", vbExclamation, "close Form Alerts")

        Else
            Me.Hide()
            loginform.Show()
        End If
    End Sub

    Private Sub menucustomer_Click(sender As Object, e As EventArgs) Handles menucustomer.Click
        Customer.Show()
    End Sub

    Private Sub menuvehicle_Click(sender As Object, e As EventArgs) Handles menuvehicle.Click
        Vehicle.Show()
    End Sub

    Private Sub menuowner_Click(sender As Object, e As EventArgs) Handles menuowner.Click
        Vehicle_Owner.Show()
    End Sub

    Private Sub menureport_Click(sender As Object, e As EventArgs) Handles menureport.Click
        New_report.Show()
    End Sub

    Private Sub userreg_Click(sender As Object, e As EventArgs) Handles userreg.Click
        user_register.Show()
    End Sub

    Private Sub customerreg_Click(sender As Object, e As EventArgs) Handles customerreg.Click
        customer_registerform.Show()
    End Sub

    Private Sub ownerreg_Click(sender As Object, e As EventArgs) Handles ownerreg.Click
        Vehicle_Owner_Registration.Show()
    End Sub

    Private Sub vehiclereg_Click(sender As Object, e As EventArgs) Handles vehiclereg.Click
        vehicle_registerform.Show()
    End Sub

    Private Sub customersum_Click(sender As Object, e As EventArgs) Handles customersum.Click
        customer_report.Show()
    End Sub

    Private Sub rentsum_Click(sender As Object, e As EventArgs) Handles rentsum.Click
        Rented_report.Show()
    End Sub

    Private Sub vehiclesum_Click(sender As Object, e As EventArgs) Handles vehiclesum.Click
        Vehicle_Report.Show()
    End Sub

    Private Sub ownerpay_Click(sender As Object, e As EventArgs) Handles ownerpay.Click
        Vehicle_Owner_Payment.Show()
    End Sub

    Private Sub customerpay_Click(sender As Object, e As EventArgs) Handles customerpay.Click
        Customer_Payment.Show()
    End Sub

    Private Sub customerbill_Click(sender As Object, e As EventArgs) Handles customerbill.Click
        Customer_Bill.Show()
    End Sub

    Private Sub Ownerbill_Click(sender As Object, e As EventArgs) Handles Ownerbill.Click
        Vehicle_Owner_Bill.Show()
    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Calculate_From.Show()
    End Sub

    Private Sub vehicleorder_Click(sender As Object, e As EventArgs) Handles vehicleorder.Click
        Vehicle_Order.Show()
    End Sub

    Private Sub damagevehicle_Click(sender As Object, e As EventArgs)
        demage_vehicle_commentform.Show()
    End Sub

    Private Sub damegesum_Click(sender As Object, e As EventArgs) Handles damegesum.Click
        Damege_vehicle_summaryform.Show()
    End Sub


    Private Sub menucustomerupdate_Click(sender As Object, e As EventArgs)
        ' Customer_register_update.Show()
    End Sub

    Private Sub menuvehicleownerupdate_Click(sender As Object, e As EventArgs)
        ' Vehicle_owner_register_update.Show()
    End Sub

    Private Sub menuvehicleupdate_Click(sender As Object, e As EventArgs)
        '  Vehicle_register_update.Show()
    End Sub

    Private Sub btncustomer_MouseHover(sender As Object, e As EventArgs) Handles btncustomer.MouseHover
        btncustomer.BackColor = Color.DarkCyan
    End Sub

    Private Sub btncustomer_MouseLeave(sender As Object, e As EventArgs) Handles btncustomer.MouseLeave
        btncustomer.BackColor = Color.White
    End Sub

    Private Sub btnreport_MouseHover(sender As Object, e As EventArgs) Handles btnreport.MouseHover
        btnreport.BackColor = Color.DarkCyan
    End Sub

    Private Sub btnreport_MouseLeave(sender As Object, e As EventArgs) Handles btnreport.MouseLeave
        btnreport.BackColor = Color.White
    End Sub

    Private Sub btnvehicle_MouseHover(sender As Object, e As EventArgs) Handles btnvehicle.MouseHover
        btnvehicle.BackColor = Color.DarkCyan
    End Sub

    Private Sub btnvehicle_MouseLeave(sender As Object, e As EventArgs) Handles btnvehicle.MouseLeave
        btnvehicle.BackColor = Color.White
    End Sub

    Private Sub btnvehicle_owner_MouseHover(sender As Object, e As EventArgs) Handles btnvehicle_owner.MouseHover
        btnvehicle_owner.BackColor = Color.DarkCyan
    End Sub

    Private Sub btnvehicle_owner_MouseLeave(sender As Object, e As EventArgs) Handles btnvehicle_owner.MouseLeave
        btnvehicle_owner.BackColor = Color.White
    End Sub

    Private Sub btncustomer_Click(sender As Object, e As EventArgs) Handles btncustomer.Click
        Customer.Show()
    End Sub

    Private Sub btnvehicle_Click(sender As Object, e As EventArgs) Handles btnvehicle.Click
        Vehicle.Show()
    End Sub

    Private Sub btnvehicle_owner_Click(sender As Object, e As EventArgs) Handles btnvehicle_owner.Click
        Vehicle_Owner.Show()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        New_report.Show()
    End Sub

    Private Sub btnlog_out_MouseHover(sender As Object, e As EventArgs) Handles btnlog_out.MouseHover
        btnlog_out.BackColor = Color.Red
    End Sub

    Private Sub btnlog_out_MouseLeave(sender As Object, e As EventArgs) Handles btnlog_out.MouseLeave
        btnlog_out.BackColor = Color.White
    End Sub

    Private Sub btnfinance_Click(sender As Object, e As EventArgs) Handles btnfinance.Click
        Calculate_From.Show()
    End Sub

    Private Sub btnfinance_MouseHover(sender As Object, e As EventArgs) Handles btnfinance.MouseHover
        btnfinance.BackColor = Color.DarkCyan
    End Sub

    Private Sub btnfinance_MouseLeave(sender As Object, e As EventArgs) Handles btnfinance.MouseLeave
        btnfinance.BackColor = Color.White
    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ownersum_Click(sender As Object, e As EventArgs) Handles ownersum.Click
        Vehicle_owner_report.Show()
    End Sub

    Private Sub useraccount_Click(sender As Object, e As EventArgs) Handles useraccount.Click
        User_Account_manege.Show()
    End Sub
End Class