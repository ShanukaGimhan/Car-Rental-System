Public Class Vehicle

    Private Sub btnvehicle_register_Click_1(sender As Object, e As EventArgs) Handles btnvehicle_register.Click
        vehicle_registerform.Show()

    End Sub

    Private Sub btnvehicle_order_Click(sender As Object, e As EventArgs) Handles btnvehicle_order.Click
        Vehicle_Order.Show()
    End Sub

    Private Sub btndamage_details_Click(sender As Object, e As EventArgs) Handles btndamage_details.Click
        demage_vehicle_commentform.Show()

    End Sub
End Class