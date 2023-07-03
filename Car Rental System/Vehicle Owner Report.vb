Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Vehicle_owner_report
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim result As Boolean
    Dim str As String


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        Dim table As New DataTable
        Try
            If Open_db() Then

                Dim command As New MySqlCommand("SELECT * FROM `vehicle_owner` WHERE `register_date` BETWEEN @d1 AND @d2", conn)

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value


                reader = command.ExecuteReader
                table.Load(reader)
                DataGridView1.DataSource = table
                DataGridView1.AllowUserToAddRows = False

                With DataGridView1
                    .Columns(1).Visible = False
                    .Columns(9).HeaderText = "Email Address"
                    .Columns(4).HeaderText = "NIC Number"
                    .Columns(10).Visible = False
                    .Columns(11).Visible = False
                    .Columns(12).Visible = False
                End With



            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        command.Parameters.Clear()
        reader.Close()


    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Dim msgboxresult As MsgBoxResult
        Dim v_id As Integer


        For Each row As DataGridViewRow In DataGridView1.SelectedRows

            v_id = row.Cells(0).Value

        Next


        If Open_db() Then

            str = "DELETE FROM `vehicle_owner` WHERE `owner_id`=@OWNER_ID"
            command.CommandText = str
            command.Connection = conn
            command.Parameters.Add("@OWNER_ID", MySqlDbType.Int32).Value = v_id


            Try
                msgboxresult = MsgBox("Do you want Delete Vehicle Owner Details..?", vbYesNo + vbQuestion, "Delete Vehicle Owner")
                If msgboxresult = MsgBoxResult.Yes Then
                    result = command.ExecuteNonQuery()
                    If result Then
                        MsgBox("Vehicle Owner Details Delete Success", vbOKOnly + vbInformation, "Delete Success")
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            command.Parameters.Clear()

        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
    End Sub

    Private Sub btnallclear_Click(sender As Object, e As EventArgs) Handles btnallclear.Click

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub btnsearch1_Click(sender As Object, e As EventArgs) Handles btnsearch1.Click
        Dim table2 As New DataTable
        Dim biteimge1, biteimage2, biteimage3 As Byte()

        If Nullempty(txtid.Text) Then
            MsgBox("Enter Vehicle Owner NIC Number Before Serch", vbExclamation, "NIC Number Not Selected")

        Else
            If Open_db() Then
                str = "SELECT* FROM `vehicle_owner` WHERE NIC=@NIC"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@NIC", MySqlDbType.VarChar).Value = txtid.Text
                reader = command.ExecuteReader

                If reader.HasRows Then
                    reader.Read()

                    biteimge1 = reader("NIC_picture")
                    biteimage2 = reader("NIC_picture_02")
                    biteimage3 = reader("profile_picture")

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
                    str = "SELECT* FROM `vehicle_owner` WHERE NIC=@NIC2"
                    command.CommandText = str
                    command.Connection = conn
                    command.Parameters.Add("@NIC2", MySqlDbType.VarChar).Value = txtid.Text
                    reader = command.ExecuteReader
                    table2.Load(reader)
                    DataGridView2.DataSource = table2
                    DataGridView2.AllowUserToAddRows = False


                    ' command.Parameters.Clear()
                    With DataGridView2
                        .Columns(1).Visible = False
                        .Columns(9).HeaderText = "Email Address"
                        .Columns(4).HeaderText = "NIC Number"
                        .Columns(10).Visible = False
                        .Columns(11).Visible = False
                        .Columns(12).Visible = False
                    End With



                End If
                command.Parameters.Clear()
            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        reader.Close()
        command.Parameters.Clear()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtid.Clear()
        PictureBox_1.Image = Nothing
        PictureBox_2.Image = Nothing
        PictureBox_3.Image = Nothing
        DataGridView2.DataSource = Nothing
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        Dim table3 As New DataTable

        Try
            If Open_db() Then

                Dim command As New MySqlCommand("SELECT * FROM `vehicle_owner` WHERE `register_date` BETWEEN @d1 AND @d2", conn)

                command.Parameters.Add("@d1", MySqlDbType.Date).Value = DateTimePicker1.Value
                command.Parameters.Add("@d2", MySqlDbType.Date).Value = DateTimePicker2.Value

                Dim adapter As New MySqlDataAdapter(command)
                reader = command.ExecuteReader
                table3.Load(reader)
                DataGridView1.DataSource = table3
                DataGridView1.AllowUserToAddRows = False

            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        command.Parameters.Clear()
        reader.Close()

    End Sub

    Private Sub Vehicle_owner_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class