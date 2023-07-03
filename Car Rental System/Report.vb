Imports MySql.Data.MySqlClient
Public Class New_report
    Dim command As New MySqlCommand
    Dim result As Boolean
    Dim str As String

    Private Sub btnreg_customer_Click(sender As Object, e As EventArgs) Handles btnreg_customer.Click
        If Open_db() Then
            str = "SELECT COUNT(`customer_id`) FROM `customer`"
            command.CommandText = str
            command.Connection = conn

            lblcustomer.Text = command.ExecuteScalar().ToString

        Else
            MsgBox("Connection Error", vbExclamation, "Failed Connection")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Open_db() Then

            str = "SELECT COUNT(`owner_id`) FROM `vehicle_owner`"
            command.CommandText = str
            command.Connection = conn

            lblowner.Text = command.ExecuteScalar().ToString

        Else
            MsgBox("Connection Error", vbExclamation, "Failed Connection")
        End If
    End Sub

    Private Sub btnvehicle_Click(sender As Object, e As EventArgs) Handles btnvehicle.Click
        If Open_db() Then

            str = "SELECT COUNT(`vehicle_register_id`) FROM `vehicle_register`"

            command.CommandText = str
            command.Connection = conn

            lblvehicle.Text = command.ExecuteScalar().ToString

        Else
            MsgBox("Connection Error", vbExclamation, "Failed Connection")
        End If
    End Sub

    Private Sub btnrented_Click(sender As Object, e As EventArgs) Handles btnrented.Click
        If Open_db() Then
            str = "SELECT COUNT(`order_id`) FROM `vehicle_order`"

            command.CommandText = str
            command.Connection = conn

            lblrented.Text = command.ExecuteScalar().ToString

        Else
            MsgBox("Connection Error", vbExclamation, "Failed Connection")
        End If
    End Sub

    Private Sub btncustomer_report_Click(sender As Object, e As EventArgs) Handles btncustomer_report.Click
        customer_report.Show()
    End Sub

    Private Sub btnowner_report_Click(sender As Object, e As EventArgs) Handles btnowner_report.Click
        Vehicle_owner_report.Show()
    End Sub

    Private Sub btnvehicle_report_Click(sender As Object, e As EventArgs) Handles btnvehicle_report.Click
        Vehicle_Report.Show()
    End Sub

    Private Sub btnrent_report_Click(sender As Object, e As EventArgs) Handles btnrent_report.Click
        Rented_report.Show()
    End Sub

    Private Sub New_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_damagev_details_Click(sender As Object, e As EventArgs) Handles btn_damagev_details.Click
        Damege_vehicle_summaryform.Show()
    End Sub
End Class