<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer_registerform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer_registerform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lable_f1 = New System.Windows.Forms.Label()
        Me.lable_l1 = New System.Windows.Forms.Label()
        Me.lable_nic1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnselect_picture = New System.Windows.Forms.Button()
        Me.btnselect2 = New System.Windows.Forms.Button()
        Me.Picturenic2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btntake_picture = New System.Windows.Forms.Button()
        Me.pictureboxnic = New System.Windows.Forms.PictureBox()
        Me.pictureboxprofile = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtfirst_name = New System.Windows.Forms.TextBox()
        Me.txtlast_name = New System.Windows.Forms.TextBox()
        Me.txtnic = New System.Windows.Forms.TextBox()
        Me.txtcontact01 = New System.Windows.Forms.TextBox()
        Me.txtcontact02 = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtfcity = New System.Windows.Forms.TextBox()
        Me.btnallclear = New System.Windows.Forms.Button()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.txtfstreet = New System.Windows.Forms.TextBox()
        Me.txtfdistrict = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_register_user = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox_nic = New System.Windows.Forms.ComboBox()
        Me.lable_nic2 = New System.Windows.Forms.Label()
        Me.lable_fname = New System.Windows.Forms.Label()
        Me.lablel_last_name = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnupdate2 = New System.Windows.Forms.Button()
        Me.ComboBox_register_user_2 = New System.Windows.Forms.ComboBox()
        Me.txtnic_2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Picturenic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxnic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureboxprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(117, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Register"
        '
        'lable_f1
        '
        Me.lable_f1.AutoSize = True
        Me.lable_f1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable_f1.Location = New System.Drawing.Point(64, 87)
        Me.lable_f1.Name = "lable_f1"
        Me.lable_f1.Size = New System.Drawing.Size(116, 25)
        Me.lable_f1.TabIndex = 1
        Me.lable_f1.Text = "First Name"
        '
        'lable_l1
        '
        Me.lable_l1.AutoSize = True
        Me.lable_l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable_l1.Location = New System.Drawing.Point(60, 135)
        Me.lable_l1.Name = "lable_l1"
        Me.lable_l1.Size = New System.Drawing.Size(115, 25)
        Me.lable_l1.TabIndex = 1
        Me.lable_l1.Text = "Last Name"
        '
        'lable_nic1
        '
        Me.lable_nic1.AutoSize = True
        Me.lable_nic1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable_nic1.Location = New System.Drawing.Point(60, 180)
        Me.lable_nic1.Name = "lable_nic1"
        Me.lable_nic1.Size = New System.Drawing.Size(130, 25)
        Me.lable_nic1.TabIndex = 1
        Me.lable_nic1.Text = "NIC Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(56, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Contact Number 01" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(56, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Contact Number 02"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(56, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(54, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 25)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Address"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnselect_picture)
        Me.Panel1.Controls.Add(Me.btnselect2)
        Me.Panel1.Controls.Add(Me.Picturenic2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btntake_picture)
        Me.Panel1.Controls.Add(Me.pictureboxnic)
        Me.Panel1.Controls.Add(Me.pictureboxprofile)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(258, 640)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(632, 250)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(443, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 40)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Take Picture"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnselect_picture
        '
        Me.btnselect_picture.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnselect_picture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnselect_picture.Location = New System.Drawing.Point(35, 182)
        Me.btnselect_picture.Name = "btnselect_picture"
        Me.btnselect_picture.Size = New System.Drawing.Size(138, 40)
        Me.btnselect_picture.TabIndex = 15
        Me.btnselect_picture.Text = "Select Picture"
        Me.btnselect_picture.UseVisualStyleBackColor = False
        '
        'btnselect2
        '
        Me.btnselect2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnselect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnselect2.Location = New System.Drawing.Point(237, 182)
        Me.btnselect2.Name = "btnselect2"
        Me.btnselect2.Size = New System.Drawing.Size(138, 40)
        Me.btnselect2.TabIndex = 14
        Me.btnselect2.Text = "Select Picture"
        Me.btnselect2.UseVisualStyleBackColor = False
        '
        'Picturenic2
        '
        Me.Picturenic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picturenic2.Location = New System.Drawing.Point(224, 53)
        Me.Picturenic2.Name = "Picturenic2"
        Me.Picturenic2.Size = New System.Drawing.Size(171, 115)
        Me.Picturenic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picturenic2.TabIndex = 13
        Me.Picturenic2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(224, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 25)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "NIC Picture 2"
        '
        'btntake_picture
        '
        Me.btntake_picture.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btntake_picture.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btntake_picture.Location = New System.Drawing.Point(27, 416)
        Me.btntake_picture.Name = "btntake_picture"
        Me.btntake_picture.Size = New System.Drawing.Size(139, 40)
        Me.btntake_picture.TabIndex = 7
        Me.btntake_picture.Text = "Take Picture"
        Me.btntake_picture.UseVisualStyleBackColor = False
        '
        'pictureboxnic
        '
        Me.pictureboxnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxnic.Location = New System.Drawing.Point(23, 53)
        Me.pictureboxnic.Name = "pictureboxnic"
        Me.pictureboxnic.Size = New System.Drawing.Size(171, 115)
        Me.pictureboxnic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxnic.TabIndex = 5
        Me.pictureboxnic.TabStop = False
        '
        'pictureboxprofile
        '
        Me.pictureboxprofile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureboxprofile.Location = New System.Drawing.Point(427, 53)
        Me.pictureboxprofile.Name = "pictureboxprofile"
        Me.pictureboxprofile.Size = New System.Drawing.Size(171, 115)
        Me.pictureboxprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureboxprofile.TabIndex = 6
        Me.pictureboxprofile.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(427, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 25)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Profile Picture"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(30, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 25)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "NIC Picture 1"
        '
        'txtfirst_name
        '
        Me.txtfirst_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfirst_name.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtfirst_name.Location = New System.Drawing.Point(281, 82)
        Me.txtfirst_name.Name = "txtfirst_name"
        Me.txtfirst_name.Size = New System.Drawing.Size(592, 30)
        Me.txtfirst_name.TabIndex = 0
        '
        'txtlast_name
        '
        Me.txtlast_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlast_name.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtlast_name.Location = New System.Drawing.Point(281, 130)
        Me.txtlast_name.Name = "txtlast_name"
        Me.txtlast_name.Size = New System.Drawing.Size(594, 30)
        Me.txtlast_name.TabIndex = 1
        '
        'txtnic
        '
        Me.txtnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnic.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtnic.Location = New System.Drawing.Point(281, 180)
        Me.txtnic.Name = "txtnic"
        Me.txtnic.Size = New System.Drawing.Size(594, 30)
        Me.txtnic.TabIndex = 2
        '
        'txtcontact01
        '
        Me.txtcontact01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontact01.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtcontact01.Location = New System.Drawing.Point(281, 230)
        Me.txtcontact01.Name = "txtcontact01"
        Me.txtcontact01.Size = New System.Drawing.Size(594, 30)
        Me.txtcontact01.TabIndex = 3
        '
        'txtcontact02
        '
        Me.txtcontact02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontact02.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtcontact02.Location = New System.Drawing.Point(281, 280)
        Me.txtcontact02.Name = "txtcontact02"
        Me.txtcontact02.Size = New System.Drawing.Size(594, 30)
        Me.txtcontact02.TabIndex = 4
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtemail.Location = New System.Drawing.Point(281, 330)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(594, 30)
        Me.txtemail.TabIndex = 5
        '
        'txtfcity
        '
        Me.txtfcity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfcity.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtfcity.Location = New System.Drawing.Point(280, 380)
        Me.txtfcity.Multiline = True
        Me.txtfcity.Name = "txtfcity"
        Me.txtfcity.Size = New System.Drawing.Size(593, 27)
        Me.txtfcity.TabIndex = 7
        '
        'btnallclear
        '
        Me.btnallclear.BackColor = System.Drawing.Color.Gray
        Me.btnallclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnallclear.Location = New System.Drawing.Point(200, 913)
        Me.btnallclear.Name = "btnallclear"
        Me.btnallclear.Size = New System.Drawing.Size(149, 49)
        Me.btnallclear.TabIndex = 5
        Me.btnallclear.Text = "All Clear"
        Me.btnallclear.UseVisualStyleBackColor = False
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.DarkCyan
        Me.btnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnregister.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnregister.Location = New System.Drawing.Point(421, 911)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(208, 49)
        Me.btnregister.TabIndex = 5
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'txtfstreet
        '
        Me.txtfstreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfstreet.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtfstreet.Location = New System.Drawing.Point(282, 426)
        Me.txtfstreet.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfstreet.Name = "txtfstreet"
        Me.txtfstreet.Size = New System.Drawing.Size(593, 30)
        Me.txtfstreet.TabIndex = 8
        '
        'txtfdistrict
        '
        Me.txtfdistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfdistrict.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtfdistrict.Location = New System.Drawing.Point(280, 480)
        Me.txtfdistrict.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfdistrict.Name = "txtfdistrict"
        Me.txtfdistrict.Size = New System.Drawing.Size(593, 30)
        Me.txtfdistrict.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(198, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 20)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "City"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(200, 430)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 20)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Street"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(198, 487)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "District"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(930, 64)
        Me.Panel2.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(56, 4)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 56)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnupdate.Location = New System.Drawing.Point(696, 910)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(194, 49)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(56, 535)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Register Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(281, 530)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(594, 30)
        Me.DateTimePicker1.TabIndex = 15
        '
        'ComboBox_register_user
        '
        Me.ComboBox_register_user.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox_register_user.FormattingEnabled = True
        Me.ComboBox_register_user.Location = New System.Drawing.Point(282, 580)
        Me.ComboBox_register_user.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox_register_user.Name = "ComboBox_register_user"
        Me.ComboBox_register_user.Size = New System.Drawing.Size(594, 31)
        Me.ComboBox_register_user.TabIndex = 18
        Me.ComboBox_register_user.Text = "Select User NIC"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(52, 589)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(142, 25)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Register User"
        '
        'ComboBox_nic
        '
        Me.ComboBox_nic.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox_nic.FormattingEnabled = True
        Me.ComboBox_nic.Location = New System.Drawing.Point(279, 82)
        Me.ComboBox_nic.Name = "ComboBox_nic"
        Me.ComboBox_nic.Size = New System.Drawing.Size(420, 31)
        Me.ComboBox_nic.TabIndex = 19
        Me.ComboBox_nic.Visible = False
        '
        'lable_nic2
        '
        Me.lable_nic2.AutoSize = True
        Me.lable_nic2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable_nic2.Location = New System.Drawing.Point(59, 87)
        Me.lable_nic2.Name = "lable_nic2"
        Me.lable_nic2.Size = New System.Drawing.Size(130, 25)
        Me.lable_nic2.TabIndex = 20
        Me.lable_nic2.Text = "NIC Number"
        Me.lable_nic2.Visible = False
        '
        'lable_fname
        '
        Me.lable_fname.AutoSize = True
        Me.lable_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lable_fname.Location = New System.Drawing.Point(59, 135)
        Me.lable_fname.Name = "lable_fname"
        Me.lable_fname.Size = New System.Drawing.Size(116, 25)
        Me.lable_fname.TabIndex = 21
        Me.lable_fname.Text = "First Name"
        '
        'lablel_last_name
        '
        Me.lablel_last_name.AutoSize = True
        Me.lablel_last_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lablel_last_name.Location = New System.Drawing.Point(60, 185)
        Me.lablel_last_name.Name = "lablel_last_name"
        Me.lablel_last_name.Size = New System.Drawing.Size(115, 25)
        Me.lablel_last_name.TabIndex = 22
        Me.lablel_last_name.Text = "Last Name"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsearch.Location = New System.Drawing.Point(721, 82)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(135, 31)
        Me.btnsearch.TabIndex = 49
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnupdate2
        '
        Me.btnupdate2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnupdate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupdate2.ForeColor = System.Drawing.SystemColors.Control
        Me.btnupdate2.Location = New System.Drawing.Point(696, 910)
        Me.btnupdate2.Name = "btnupdate2"
        Me.btnupdate2.Size = New System.Drawing.Size(194, 49)
        Me.btnupdate2.TabIndex = 50
        Me.btnupdate2.Text = "Update"
        Me.btnupdate2.UseVisualStyleBackColor = False
        '
        'ComboBox_register_user_2
        '
        Me.ComboBox_register_user_2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox_register_user_2.FormattingEnabled = True
        Me.ComboBox_register_user_2.Location = New System.Drawing.Point(281, 580)
        Me.ComboBox_register_user_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox_register_user_2.Name = "ComboBox_register_user_2"
        Me.ComboBox_register_user_2.Size = New System.Drawing.Size(594, 31)
        Me.ComboBox_register_user_2.TabIndex = 51
        Me.ComboBox_register_user_2.Text = "Select User NIC"
        '
        'txtnic_2
        '
        Me.txtnic_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnic_2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtnic_2.Location = New System.Drawing.Point(282, 180)
        Me.txtnic_2.Name = "txtnic_2"
        Me.txtnic_2.Size = New System.Drawing.Size(594, 30)
        Me.txtnic_2.TabIndex = 52
        '
        'customer_registerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(928, 989)
        Me.Controls.Add(Me.ComboBox_register_user)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtfdistrict)
        Me.Controls.Add(Me.txtfstreet)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.btnallclear)
        Me.Controls.Add(Me.txtfcity)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtcontact02)
        Me.Controls.Add(Me.txtcontact01)
        Me.Controls.Add(Me.txtnic)
        Me.Controls.Add(Me.txtlast_name)
        Me.Controls.Add(Me.txtfirst_name)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lable_nic1)
        Me.Controls.Add(Me.lable_l1)
        Me.Controls.Add(Me.lable_f1)
        Me.Controls.Add(Me.ComboBox_nic)
        Me.Controls.Add(Me.lable_nic2)
        Me.Controls.Add(Me.lable_fname)
        Me.Controls.Add(Me.lablel_last_name)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnupdate2)
        Me.Controls.Add(Me.ComboBox_register_user_2)
        Me.Controls.Add(Me.txtnic_2)
        Me.MaximizeBox = False
        Me.Name = "customer_registerform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Picturenic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxnic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureboxprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lable_f1 As Label
    Friend WithEvents lable_l1 As Label
    Friend WithEvents lable_nic1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btntake_picture As Button
    Friend WithEvents pictureboxnic As PictureBox
    Friend WithEvents pictureboxprofile As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtfirst_name As TextBox
    Friend WithEvents txtlast_name As TextBox
    Friend WithEvents txtnic As TextBox
    Friend WithEvents txtcontact01 As TextBox
    Friend WithEvents txtcontact02 As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtfcity As TextBox
    Friend WithEvents btnallclear As Button
    Friend WithEvents btnregister As Button
    Friend WithEvents txtfstreet As TextBox
    Friend WithEvents txtfdistrict As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Picturenic2 As PictureBox
    Friend WithEvents btnselect2 As Button
    Friend WithEvents btnselect_picture As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox_register_user As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox_nic As ComboBox
    Friend WithEvents lable_nic2 As Label
    Friend WithEvents lable_fname As Label
    Friend WithEvents lablel_last_name As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnupdate2 As Button
    Friend WithEvents ComboBox_register_user_2 As ComboBox
    Friend WithEvents txtnic_2 As TextBox
End Class
