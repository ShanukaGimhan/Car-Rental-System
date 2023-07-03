Public Class Customer
    Private Sub btncustomer_register_Click(sender As Object, e As EventArgs) Handles btncustomer_register.Click
        customer_registerform.Show()
    End Sub

    Private Sub btcustomer_payment_Click(sender As Object, e As EventArgs) Handles btcustomer_payment.Click
        Customer_Payment.Show()
    End Sub
End Class