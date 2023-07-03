Imports MySql.Data.MySqlClient
Imports System.IO
Public Class customer_report
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim result As Boolean
    Dim str As String


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim table As New DataTable()

        Try
            If Open_db() Then

                str = "SELECT * FROM `customer` WHERE `register_date` BETWEEN @d1 AND @d2"

                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value
                reader = command.ExecuteReader
                table.Load(reader)
                DataGridView1.DataSource = table
                DataGridView1.AllowUserToAddRows = False

                With DataGridView1
                    .Columns(1).Visible = False
                    .Columns(4).HeaderText = "NIC Number"
                    .Columns(7).HeaderText = "Email Address"
                    .Columns(3).Width = 250
                    .Columns(6).Width = 250
                    .Columns(11).Visible = False
                    .Columns(12).Visible = False
                    .Columns(13).Visible = False


                End With




                If result Then

                    command.Parameters.Clear()

                    DataGridView1.Refresh()
                End If
                command.Parameters.Clear()
            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If


            reader.Close()
            DataGridView1.Refresh()
            btnsearch.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Close_db()


    End Sub


    Private Sub btnallclear_Click(sender As Object, e As EventArgs) Handles btnallclear.Click

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Dim msgboxresult As MsgBoxResult
        Dim cus_id As Integer


        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            cus_id = row.Cells(0).Value

        Next


        If Open_db() Then

            str = "DELETE FROM `customer` WHERE `customer_id`=@CUSTOMER_ID"
            command.CommandText = str
            command.Connection = conn

            command.Parameters.Add("@CUSTOMER_ID", MySqlDbType.Int32).Value = cus_id

            msgboxresult = MsgBox("Do you want Delete Customer..?", vbYesNo + vbQuestion, "Delete Customer")
            If msgboxresult = MsgBoxResult.Yes Then
                result = command.ExecuteNonQuery()

                MsgBox("Customer Delete Success", vbOKOnly + vbInformation, "Delete Success")

            End If
        End If
        command.Parameters.Clear()

    End Sub

    Private Sub btnsearch1_Click(sender As Object, e As EventArgs) Handles btnsearch1.Click
        Dim table2 As New DataTable
        Dim biteimge1, biteimage2, biteimage3 As Byte()

        If Nullempty(txtid.Text) Then
            MsgBox("Enter Customer NIC Number Before Serch", vbExclamation, "NIC Number Not Selected")

        Else

            If Open_db() Then

                str = "SELECT* FROM `customer` WHERE NIC=@NIC"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = txtid.Text
                reader = command.ExecuteReader


                If reader.HasRows Then
                    reader.Read()

                    biteimge1 = reader("NIC_pic")
                    biteimage2 = reader("NIC_picture_02")
                    biteimage3 = reader("profile_pic")

                    Dim ms1 As New MemoryStream(biteimge1)
                    PictureBox_1.Image = Image.FromStream(ms1)
                    Dim ms2 As New MemoryStream(biteimage2)
                    PictureBox_2.Image = Image.FromStream(ms2)
                    Dim ms3 As New MemoryStream(biteimage3)
                    PictureBox_3.Image = Image.FromStream(ms3)

                    command.Parameters.Clear()
                End If
                Close_db()

                If Open_db() Then


                    str = "SELECT* FROM `customer` WHERE NIC=@NIC2"
                    command.CommandText = str
                    command.Connection = conn
                    command.Parameters.Add("@NIC2", MySqlDbType.VarChar).Value = txtid.Text
                    reader = command.ExecuteReader



                    table2.Load(reader)
                    DataGridView2.DataSource = table2
                    DataGridView2.AllowUserToAddRows = False


                    With DataGridView2
                        .Columns(1).Visible = False
                        .Columns(4).HeaderText = "NIC Number"
                        .Columns(7).HeaderText = "Email Address"
                        .Columns(3).Width = 250
                        .Columns(6).Width = 250
                        .Columns(11).Visible = False
                        .Columns(12).Visible = False
                        .Columns(13).Visible = False


                    End With
                    command.Parameters.Clear()
                End If

            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        reader.Close()
        command.Parameters.Clear()
        btnsearch1.Refresh()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtid.Clear()
        DataGridView2.DataSource = Nothing
        DataGridView2.Rows.Clear()
        PictureBox_1.Image = Nothing
        PictureBox_2.Image = Nothing
        PictureBox_3.Image = Nothing
    End Sub



    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim table3 As New DataTable


        Try
            If Open_db() Then

                str = "SELECT * FROM `customer` WHERE `register_date` BETWEEN @d1 AND @d2"

                command.CommandText = str
                command.Connection = conn

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value
                reader = command.ExecuteReader
                table3.Load(reader)
                DataGridView1.DataSource = table3
                DataGridView1.AllowUserToAddRows = False



                command.Parameters.Clear()
            Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If


            reader.Close()
            DataGridView1.Refresh()
            btnsearch.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Close_db()
    End Sub

    Private Sub customer_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class