Imports MySql.Data.MySqlClient
Public Class Damege_vehicle_summaryform
    Dim command As New MySqlCommand
    Dim table As New DataTable
    Dim reader As MySqlDataReader
    Dim str As String

    Private Sub Damege_vehicle_summaryform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Open_db() Then
            str = "SELECT vehicle_register.vehicle_number,damage_details.damage_id FROM vehicle_register INNER JOIN damage_details ON damage_details.fk_vehicle_number=vehicle_register.vehicle_register_id"
            command.CommandText = str
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)
            comboselect_vehicle_damege.DataSource = table
            comboselect_vehicle_damege.DisplayMember = "vehicle_number"
            comboselect_vehicle_damege.ValueMember = "damage_id"
            comboselect_vehicle_damege.SelectedIndex = -1
            comboselect_vehicle_damege.Text = "Select Vehicle Number"

        Else
            MsgBox("Connection Error", vbExclamation, "Lost Connection")
        End If
        reader.Close()
    End Sub

    Private Sub btnshow_vehicle_damege_Click(sender As Object, e As EventArgs) Handles btnshow_vehicle_damege.Click

        Dim table2 As New DataTable

        If Nullempty(comboselect_vehicle_damege.SelectedValue) Then
            MsgBox("Select Vehicle Number Before Serch Data", vbExclamation, "Vehicle Number Not Selected")

        Else

            If Open_db() Then
                str = "SELECT vehicle_register.vehicle_number,vehicle_register.vehicle_brand,vehicle_register.vehicle_model,vehicle_register.vehicle_color,damage_details.* FROM 
             vehicle_register INNER JOIN damage_details ON vehicle_register.vehicle_register_id=damage_details.fk_vehicle_number WHERE damage_details.damage_id = @VEHICLE_NUMBER"
                command.CommandText = str
                command.Connection = conn
                command.Parameters.Add("@VEHICLE_NUMBER", MySqlDbType.VarChar).Value = comboselect_vehicle_damege.SelectedValue
                reader = command.ExecuteReader
                table2.Load(reader)
                grid_damege_summary.DataSource = table2
                grid_damege_summary.AllowUserToAddRows = False
                grid_damege_summary.RowHeadersVisible = False

                With grid_damege_summary
                    .CurrentRow.Height = 50
                    .AutoResizeColumns()
                    .Columns(0).DefaultCellStyle.Font = New Font("Calibri”, 12)
                    .Columns(1).DefaultCellStyle.Font = New Font("Calibri”, 12)
                    .Columns(2).DefaultCellStyle.Font = New Font("Calibri”, 12)
                    .Columns(3).DefaultCellStyle.Font = New Font("Calibri”, 12)
                    .Columns(4).DefaultCellStyle.Font = New Font("Calibri”, 12)
                    .Columns(5).DefaultCellStyle.Font = New Font("Calibri”, 12)
                    .Columns(6).DefaultCellStyle.Font = New Font("Calibri”, 12)
                    .Columns(7).DefaultCellStyle.Font = New Font("Calibri”, 12)
                    .ColumnHeadersDefaultCellStyle.Font = New Font("Calibri”, 12, FontStyle.Bold)
                    .Columns(0).HeaderText = "Vehicle Number"
                    .Columns(1).HeaderText = "Vehicle Brand"
                    .Columns(2).HeaderText = "Vehicle Model"
                    .Columns(3).HeaderText = "Vehicle Color"
                    .Columns(4).HeaderText = "Damege ID"
                    .Columns(5).HeaderText = "Order ID"
                    .Columns(6).HeaderText = "Vehicle Register ID"
                    .Columns(7).HeaderText = "Details of Damege Vehicles"

                End With

                command.Parameters.Clear()
            Else
                MsgBox("Connection Error", vbExclamation, "Lost Connection")
            End If
        End If
        reader.Close()
        grid_damege_summary.Refresh()
        Close_db()

    End Sub

    Private Sub btnclear_damege_Click(sender As Object, e As EventArgs) Handles btnclear_damege.Click
        reader.Close()
        grid_damege_summary.DataSource = Nothing
        comboselect_vehicle_damege.SelectedIndex = -1
        comboselect_vehicle_damege.Text = "Select Vehicle Number"
    End Sub
End Class