<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vehicle_registerform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vehicle_registerform))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lable4 = New System.Windows.Forms.Label()
        Me.lable5 = New System.Windows.Forms.Label()
        Me.lable6 = New System.Windows.Forms.Label()
        Me.lable8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePickerend_emission = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerend_revenue = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerend_date = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtagriment_period = New System.Windows.Forms.TextBox()
        Me.txtdelay_charge_per_day = New System.Windows.Forms.TextBox()
        Me.txtamount_per_day = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lable = New System.Windows.Forms.Label()
        Me.txtvehicle_number = New System.Windows.Forms.TextBox()
        Me.txtmodel = New System.Windows.Forms.TextBox()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.txtchassis = New System.Windows.Forms.TextBox()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.btnall_clear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBoxvehicle = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnpictureselect = New System.Windows.Forms.Button()
        Me.txtbrand = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_statr_date = New System.Windows.Forms.DateTimePicker()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.ComboBox_vehicle_no = New System.Windows.Forms.ComboBox()
        Me.btnupdate_2 = New System.Windows.Forms.Button()
        Me.ComboBox_nic_2 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxvehicle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vehicle Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Owner NIC"
        '
        'lable4
        '
        Me.lable4.AutoSize = True
        Me.lable4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable4.Location = New System.Drawing.Point(37, 239)
        Me.lable4.Name = "lable4"
        Me.lable4.Size = New System.Drawing.Size(147, 25)
        Me.lable4.TabIndex = 1
        Me.lable4.Text = "Vehicle Brand"
        '
        'lable5
        '
        Me.lable5.AutoSize = True
        Me.lable5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable5.Location = New System.Drawing.Point(37, 299)
        Me.lable5.Name = "lable5"
        Me.lable5.Size = New System.Drawing.Size(149, 25)
        Me.lable5.TabIndex = 1
        Me.lable5.Text = "Vehicle Model"
        '
        'lable6
        '
        Me.lable6.AutoSize = True
        Me.lable6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable6.Location = New System.Drawing.Point(37, 364)
        Me.lable6.Name = "lable6"
        Me.lable6.Size = New System.Drawing.Size(142, 25)
        Me.lable6.TabIndex = 1
        Me.lable6.Text = "Vehicle Color"
        '
        'lable8
        '
        Me.lable8.AutoSize = True
        Me.lable8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable8.Location = New System.Drawing.Point(37, 427)
        Me.lable8.Name = "lable8"
        Me.lable8.Size = New System.Drawing.Size(171, 25)
        Me.lable8.TabIndex = 1
        Me.lable8.Text = "Chassis Number"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePickerend_emission)
        Me.Panel1.Controls.Add(Me.DateTimePickerend_revenue)
        Me.Panel1.Controls.Add(Me.DateTimePickerend_date)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtagriment_period)
        Me.Panel1.Controls.Add(Me.txtdelay_charge_per_day)
        Me.Panel1.Controls.Add(Me.txtamount_per_day)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lable)
        Me.Panel1.Location = New System.Drawing.Point(702, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 391)
        Me.Panel1.TabIndex = 2
        '
        'DateTimePickerend_emission
        '
        Me.DateTimePickerend_emission.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerend_emission.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerend_emission.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerend_emission.Location = New System.Drawing.Point(376, 337)
        Me.DateTimePickerend_emission.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerend_emission.Name = "DateTimePickerend_emission"
        Me.DateTimePickerend_emission.Size = New System.Drawing.Size(255, 30)
        Me.DateTimePickerend_emission.TabIndex = 22
        '
        'DateTimePickerend_revenue
        '
        Me.DateTimePickerend_revenue.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerend_revenue.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerend_revenue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerend_revenue.Location = New System.Drawing.Point(16, 337)
        Me.DateTimePickerend_revenue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerend_revenue.Name = "DateTimePickerend_revenue"
        Me.DateTimePickerend_revenue.Size = New System.Drawing.Size(255, 30)
        Me.DateTimePickerend_revenue.TabIndex = 21
        '
        'DateTimePickerend_date
        '
        Me.DateTimePickerend_date.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerend_date.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerend_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerend_date.Location = New System.Drawing.Point(377, 209)
        Me.DateTimePickerend_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePickerend_date.Name = "DateTimePickerend_date"
        Me.DateTimePickerend_date.Size = New System.Drawing.Size(255, 30)
        Me.DateTimePickerend_date.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(376, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(227, 25)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Delay Charge Per Day"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(15, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(169, 25)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Amount Per Day"
        '
        'txtagriment_period
        '
        Me.txtagriment_period.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtagriment_period.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtagriment_period.Location = New System.Drawing.Point(15, 208)
        Me.txtagriment_period.Name = "txtagriment_period"
        Me.txtagriment_period.Size = New System.Drawing.Size(256, 31)
        Me.txtagriment_period.TabIndex = 9
        '
        'txtdelay_charge_per_day
        '
        Me.txtdelay_charge_per_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdelay_charge_per_day.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtdelay_charge_per_day.Location = New System.Drawing.Point(376, 75)
        Me.txtdelay_charge_per_day.Name = "txtdelay_charge_per_day"
        Me.txtdelay_charge_per_day.Size = New System.Drawing.Size(256, 31)
        Me.txtdelay_charge_per_day.TabIndex = 8
        '
        'txtamount_per_day
        '
        Me.txtamount_per_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtamount_per_day.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtamount_per_day.Location = New System.Drawing.Point(15, 72)
        Me.txtamount_per_day.Name = "txtamount_per_day"
        Me.txtamount_per_day.Size = New System.Drawing.Size(256, 31)
        Me.txtamount_per_day.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(376, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(287, 25)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "End Date of Emission Report"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(15, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(297, 25)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "End Date of Revenue Licence"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(376, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(203, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "End Date of Insured"
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable.Location = New System.Drawing.Point(15, 139)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(185, 25)
        Me.lable.TabIndex = 7
        Me.lable.Text = "Agreement Period"
        '
        'txtvehicle_number
        '
        Me.txtvehicle_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvehicle_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvehicle_number.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtvehicle_number.Location = New System.Drawing.Point(267, 110)
        Me.txtvehicle_number.Name = "txtvehicle_number"
        Me.txtvehicle_number.Size = New System.Drawing.Size(404, 30)
        Me.txtvehicle_number.TabIndex = 0
        '
        'txtmodel
        '
        Me.txtmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmodel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtmodel.Location = New System.Drawing.Point(267, 296)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.Size = New System.Drawing.Size(404, 30)
        Me.txtmodel.TabIndex = 3
        '
        'txtcolor
        '
        Me.txtcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcolor.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtcolor.Location = New System.Drawing.Point(267, 360)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(404, 30)
        Me.txtcolor.TabIndex = 4
        '
        'txtchassis
        '
        Me.txtchassis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtchassis.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtchassis.Location = New System.Drawing.Point(267, 424)
        Me.txtchassis.Name = "txtchassis"
        Me.txtchassis.Size = New System.Drawing.Size(404, 30)
        Me.txtchassis.TabIndex = 5
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.DarkCyan
        Me.btnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnregister.ForeColor = System.Drawing.SystemColors.Control
        Me.btnregister.Location = New System.Drawing.Point(456, 732)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(207, 56)
        Me.btnregister.TabIndex = 14
        Me.btnregister.Text = "Register "
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'btnall_clear
        '
        Me.btnall_clear.BackColor = System.Drawing.Color.Gray
        Me.btnall_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnall_clear.Location = New System.Drawing.Point(1080, 732)
        Me.btnall_clear.Name = "btnall_clear"
        Me.btnall_clear.Size = New System.Drawing.Size(183, 56)
        Me.btnall_clear.TabIndex = 4
        Me.btnall_clear.Text = "All Clear"
        Me.btnall_clear.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 499)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(220, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Agreement Start Date"
        '
        'PictureBoxvehicle
        '
        Me.PictureBoxvehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxvehicle.Location = New System.Drawing.Point(266, 550)
        Me.PictureBoxvehicle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxvehicle.Name = "PictureBoxvehicle"
        Me.PictureBoxvehicle.Size = New System.Drawing.Size(228, 105)
        Me.PictureBoxvehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxvehicle.TabIndex = 6
        Me.PictureBoxvehicle.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(37, 560)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Vehicle Image"
        '
        'btnpictureselect
        '
        Me.btnpictureselect.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnpictureselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnpictureselect.Location = New System.Drawing.Point(309, 668)
        Me.btnpictureselect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnpictureselect.Name = "btnpictureselect"
        Me.btnpictureselect.Size = New System.Drawing.Size(128, 37)
        Me.btnpictureselect.TabIndex = 13
        Me.btnpictureselect.Text = "Select"
        Me.btnpictureselect.UseVisualStyleBackColor = False
        '
        'txtbrand
        '
        Me.txtbrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbrand.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtbrand.Location = New System.Drawing.Point(267, 238)
        Me.txtbrand.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(404, 30)
        Me.txtbrand.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(-1, -1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1412, 67)
        Me.Panel3.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(48, 11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 44)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(152, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(306, 42)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Vehicle Register"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnupdate.Location = New System.Drawing.Point(786, 730)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(200, 56)
        Me.btnupdate.TabIndex = 17
        Me.btnupdate.Text = "Update "
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(267, 170)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(404, 31)
        Me.ComboBox1.TabIndex = 18
        '
        'DateTimePicker_statr_date
        '
        Me.DateTimePicker_statr_date.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_statr_date.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker_statr_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_statr_date.Location = New System.Drawing.Point(267, 497)
        Me.DateTimePicker_statr_date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker_statr_date.Name = "DateTimePicker_statr_date"
        Me.DateTimePicker_statr_date.Size = New System.Drawing.Size(403, 30)
        Me.DateTimePicker_statr_date.TabIndex = 19
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsearch.Location = New System.Drawing.Point(559, 109)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(104, 31)
        Me.btnsearch.TabIndex = 50
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'ComboBox_vehicle_no
        '
        Me.ComboBox_vehicle_no.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox_vehicle_no.FormattingEnabled = True
        Me.ComboBox_vehicle_no.Location = New System.Drawing.Point(267, 110)
        Me.ComboBox_vehicle_no.Name = "ComboBox_vehicle_no"
        Me.ComboBox_vehicle_no.Size = New System.Drawing.Size(269, 31)
        Me.ComboBox_vehicle_no.TabIndex = 51
        '
        'btnupdate_2
        '
        Me.btnupdate_2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnupdate_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupdate_2.ForeColor = System.Drawing.SystemColors.Control
        Me.btnupdate_2.Location = New System.Drawing.Point(786, 730)
        Me.btnupdate_2.Name = "btnupdate_2"
        Me.btnupdate_2.Size = New System.Drawing.Size(200, 56)
        Me.btnupdate_2.TabIndex = 52
        Me.btnupdate_2.Text = "Update"
        Me.btnupdate_2.UseVisualStyleBackColor = False
        '
        'ComboBox_nic_2
        '
        Me.ComboBox_nic_2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox_nic_2.FormattingEnabled = True
        Me.ComboBox_nic_2.Location = New System.Drawing.Point(267, 170)
        Me.ComboBox_nic_2.Name = "ComboBox_nic_2"
        Me.ComboBox_nic_2.Size = New System.Drawing.Size(404, 31)
        Me.ComboBox_nic_2.TabIndex = 53
        '
        'vehicle_registerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1412, 803)
        Me.Controls.Add(Me.txtvehicle_number)
        Me.Controls.Add(Me.ComboBox_vehicle_no)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.DateTimePicker_statr_date)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtbrand)
        Me.Controls.Add(Me.btnpictureselect)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBoxvehicle)
        Me.Controls.Add(Me.btnall_clear)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.txtchassis)
        Me.Controls.Add(Me.txtmodel)
        Me.Controls.Add(Me.txtcolor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lable6)
        Me.Controls.Add(Me.lable5)
        Me.Controls.Add(Me.lable4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lable8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox_nic_2)
        Me.Controls.Add(Me.btnupdate_2)
        Me.MaximizeBox = False
        Me.Name = "vehicle_registerform"
        Me.Text = "vehicle_register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxvehicle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lable4 As Label
    Friend WithEvents lable5 As Label
    Friend WithEvents lable6 As Label
    Friend WithEvents lable8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtagriment_period As TextBox
    Friend WithEvents txtdelay_charge_per_day As TextBox
    Friend WithEvents txtamount_per_day As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lable As Label
    Friend WithEvents txtvehicle_number As TextBox
    Friend WithEvents txtmodel As TextBox
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents txtchassis As TextBox
    Friend WithEvents btnregister As Button
    Friend WithEvents btnall_clear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBoxvehicle As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnpictureselect As Button
    Friend WithEvents txtbrand As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePickerend_emission As DateTimePicker
    Friend WithEvents DateTimePickerend_revenue As DateTimePicker
    Friend WithEvents DateTimePickerend_date As DateTimePicker
    Friend WithEvents DateTimePicker_statr_date As DateTimePicker
    Friend WithEvents btnsearch As Button
    Friend WithEvents ComboBox_vehicle_no As ComboBox
    Friend WithEvents btnupdate_2 As Button
    Friend WithEvents ComboBox_nic_2 As ComboBox
End Class
