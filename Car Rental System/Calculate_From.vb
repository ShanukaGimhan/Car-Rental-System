Imports MySql.Data.MySqlClient
Public Class Calculate_From
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim str As String

    Private Sub btninsert1_Click(sender As Object, e As EventArgs) Handles btninsert1.Click
        Try

            If Open_db() Then
                str = "SELECT SUM(total_amount) FROM customer_payment  WHERE `pick_date` BETWEEN @D1 AND @D2"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@D1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@D2", MySqlDbType.Date).Value = DateTimePicker2.Value

                txtcustomer_payment.Text = command.ExecuteScalar().ToString()
            End If
            command.Parameters.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        End Try


    End Sub

    Private Sub btninsert2_Click(sender As Object, e As EventArgs) Handles btninsert2.Click

        Try
            If Open_db() Then
                DateTimePicker1.Checked = True
                DateTimePicker2.Checked = True

                str = "SELECT SUM(paid_amount) FROM owner_payment  WHERE `paid_date` BETWEEN @OD1 AND @OD2"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@OD1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@OD2", MySqlDbType.Date).Value = DateTimePicker2.Value
                txtowner_payment.Text = command.ExecuteScalar().ToString()


            End If
            command.Parameters.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        End Try


    End Sub

    Private Sub btngenerate_profit_Click(sender As Object, e As EventArgs) Handles btngenerate_profit.Click

        If Nullempty(txtcustomer_payment.Text) Or
                    Nullempty(txtowner_payment.Text) Then
            MsgBox("Serch Value Before Generate Profit Or Loss", vbExclamation, "Value Not Selected")
            'Else
        End If

        If IsNumeric(txtcustomer_payment.Text) And IsNumeric(txtowner_payment.Text) Then

            Dim num1 As Double
            Dim num2 As Double
            Dim num3 As Double

            num1 = Convert.ToDouble(txtcustomer_payment.Text)
            num2 = Convert.ToDouble(txtowner_payment.Text)
            num3 = num1 - num2
            txttotal.Text = CStr(num3)

            If num1 < num2 Then
                txttotal.ForeColor = Color.Red
            Else
                txttotal.ForeColor = Color.Black

            End If
        End If

        btngenerate_profit.Refresh()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txtcustomer_payment.Text = ""
        txtowner_payment.Text = ""
        txttotal.Text = ""
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
        Main_Menu.Show()
    End Sub

    Private Sub txtcustomer_payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcustomer_payment.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtcustomer_payment.Clear()
        End If
    End Sub

    Private Sub txtowner_payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtowner_payment.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txtowner_payment.Clear()
        End If
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotal.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.KeyChar = ""
            MsgBox("Only Numbers Are Allow", vbExclamation, "Enter Numeric Values")
            txttotal.Clear()
        End If
    End Sub

    Private Sub Calculate_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class