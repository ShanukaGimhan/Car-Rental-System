Imports MySql.Data.MySqlClient
Public Class Vehicle_Owner_Payment
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim table As New DataTable
    Dim result As Boolean
    Dim str As String

    Private Sub Vehicle_Owner_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Open_db() Then
            str = "SELECT vehicle_number,vehicle_register_id FROM vehicle_register "

            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            Combovehicleid.DataSource = table
            Combovehicleid.DisplayMember = "vehicle_number"
            Combovehicleid.ValueMember = "vehicle_register_id"
            Combovehicleid.SelectedIndex = -1
            Combovehicleid.Text = "Select Vehicle Number"

        Else
            MsgBox("Connection Error", vbExclamation, "Failed Connection")
        End If

        reader.Close()
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        Dim fk_register_id, paid_amount As String
        Dim paid_day As Date

        fk_register_id = Combovehicleid.SelectedValue
        paid_amount = txt_paid_amount.Text
        paid_day = DateTimePicker_paid.Value.ToShortDateString

        If Nullempty(paid_amount) Then
            MsgBox("Enter Paid Amount", vbExclamation, "Empty Feild")
        ElseIf Nullempty(fk_register_id) Then
            MsgBox("Select Vehicle Number", vbExclamation, "Empty Feild")

        Else
            If Open_db() Then

                str = "INSERT INTO `owner_payment`(fk_vehicle_register_id, `paid_date`, `paid_amount`)  VALUES (@FK_REGISTER_ID,@PDATE,@PAMOUNT)"

                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@FK_REGISTER_ID", MySqlDbType.Int32).Value = fk_register_id
                command.Parameters.Add("@PDATE", MySqlDbType.Date).Value = paid_day
                command.Parameters.Add("@PAMOUNT", MySqlDbType.Int32).Value = paid_amount

                result = command.ExecuteNonQuery
                If result Then
                    MsgBox("Payment Done ", vbInformation, "Owner Payment")
                Else
                    MsgBox("Record Add Failed", vbExclamation, "Process Failed")
                End If


            Else
                MsgBox("Connection Error", vbExclamation, "Failed Connection")
            End If
            command.Parameters.Clear()
        End If
        Close_db()
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Vehicle_Owner_Bill.Show()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txt_paid_amount.Text = ""
        Combovehicleid.SelectedValue = False
        Combovehicleid.Text = "Select Vehicle Number"
    End Sub

    Private Sub txt_paid_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_paid_amount.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txt_paid_amount.Clear()
        End If
    End Sub
End Class