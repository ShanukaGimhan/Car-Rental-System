<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class user_register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_register))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfirst_name = New System.Windows.Forms.TextBox()
        Me.txtlast_name = New System.Windows.Forms.TextBox()
        Me.txtnic = New System.Windows.Forms.TextBox()
        Me.txtuser_name = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.radioadmin = New System.Windows.Forms.RadioButton()
        Me.radiouser = New System.Windows.Forms.RadioButton()
        Me.btnaclear_user_reg = New System.Windows.Forms.Button()
        Me.btnadduser_user_reg = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radiodisable = New System.Windows.Forms.RadioButton()
        Me.radioenable = New System.Windows.Forms.RadioButton()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(66, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(66, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(66, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NIC Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(66, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "User Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(67, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(69, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "User Role"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(66, 412)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Contact Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(66, 468)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Email"
        '
        'txtfirst_name
        '
        Me.txtfirst_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfirst_name.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtfirst_name.Location = New System.Drawing.Point(252, 80)
        Me.txtfirst_name.Name = "txtfirst_name"
        Me.txtfirst_name.Size = New System.Drawing.Size(392, 34)
        Me.txtfirst_name.TabIndex = 0
        '
        'txtlast_name
        '
        Me.txtlast_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlast_name.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtlast_name.Location = New System.Drawing.Point(252, 137)
        Me.txtlast_name.Name = "txtlast_name"
        Me.txtlast_name.Size = New System.Drawing.Size(392, 34)
        Me.txtlast_name.TabIndex = 1
        '
        'txtnic
        '
        Me.txtnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnic.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtnic.Location = New System.Drawing.Point(252, 193)
        Me.txtnic.Name = "txtnic"
        Me.txtnic.Size = New System.Drawing.Size(392, 34)
        Me.txtnic.TabIndex = 2
        '
        'txtuser_name
        '
        Me.txtuser_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuser_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuser_name.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtuser_name.Location = New System.Drawing.Point(252, 247)
        Me.txtuser_name.Name = "txtuser_name"
        Me.txtuser_name.Size = New System.Drawing.Size(392, 34)
        Me.txtuser_name.TabIndex = 3
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtpassword.Location = New System.Drawing.Point(252, 302)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(392, 34)
        Me.txtpassword.TabIndex = 4
        '
        'txtcontact
        '
        Me.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcontact.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtcontact.Location = New System.Drawing.Point(252, 408)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(392, 34)
        Me.txtcontact.TabIndex = 6
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtemail.Location = New System.Drawing.Point(252, 464)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(392, 34)
        Me.txtemail.TabIndex = 7
        '
        'radioadmin
        '
        Me.radioadmin.AutoSize = True
        Me.radioadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioadmin.Location = New System.Drawing.Point(270, 364)
        Me.radioadmin.Name = "radioadmin"
        Me.radioadmin.Size = New System.Drawing.Size(94, 29)
        Me.radioadmin.TabIndex = 5
        Me.radioadmin.TabStop = True
        Me.radioadmin.Text = "Admin"
        Me.radioadmin.UseVisualStyleBackColor = True
        '
        'radiouser
        '
        Me.radiouser.AutoSize = True
        Me.radiouser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radiouser.Location = New System.Drawing.Point(463, 364)
        Me.radiouser.Name = "radiouser"
        Me.radiouser.Size = New System.Drawing.Size(78, 29)
        Me.radiouser.TabIndex = 5
        Me.radiouser.TabStop = True
        Me.radiouser.Text = "User"
        Me.radiouser.UseVisualStyleBackColor = True
        '
        'btnaclear_user_reg
        '
        Me.btnaclear_user_reg.BackColor = System.Drawing.Color.Gray
        Me.btnaclear_user_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnaclear_user_reg.Location = New System.Drawing.Point(241, 598)
        Me.btnaclear_user_reg.Name = "btnaclear_user_reg"
        Me.btnaclear_user_reg.Size = New System.Drawing.Size(153, 50)
        Me.btnaclear_user_reg.TabIndex = 5
        Me.btnaclear_user_reg.Text = "All Clear"
        Me.btnaclear_user_reg.UseVisualStyleBackColor = False
        '
        'btnadduser_user_reg
        '
        Me.btnadduser_user_reg.BackColor = System.Drawing.Color.DarkCyan
        Me.btnadduser_user_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnadduser_user_reg.ForeColor = System.Drawing.SystemColors.Control
        Me.btnadduser_user_reg.Location = New System.Drawing.Point(437, 598)
        Me.btnadduser_user_reg.Name = "btnadduser_user_reg"
        Me.btnadduser_user_reg.Size = New System.Drawing.Size(192, 50)
        Me.btnadduser_user_reg.TabIndex = 5
        Me.btnadduser_user_reg.Text = "Add User"
        Me.btnadduser_user_reg.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(69, 527)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 24)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Status"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(715, 54)
        Me.Panel3.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(36, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(102, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(259, 42)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "User Register"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radiodisable)
        Me.Panel1.Controls.Add(Me.radioenable)
        Me.Panel1.Location = New System.Drawing.Point(264, 516)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 49)
        Me.Panel1.TabIndex = 32
        '
        'radiodisable
        '
        Me.radiodisable.AutoSize = True
        Me.radiodisable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radiodisable.Location = New System.Drawing.Point(202, 5)
        Me.radiodisable.Name = "radiodisable"
        Me.radiodisable.Size = New System.Drawing.Size(100, 28)
        Me.radiodisable.TabIndex = 9
        Me.radiodisable.TabStop = True
        Me.radiodisable.Text = "Disable"
        Me.radiodisable.UseVisualStyleBackColor = True
        '
        'radioenable
        '
        Me.radioenable.AutoSize = True
        Me.radioenable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioenable.Location = New System.Drawing.Point(10, 5)
        Me.radioenable.Name = "radioenable"
        Me.radioenable.Size = New System.Drawing.Size(97, 28)
        Me.radioenable.TabIndex = 10
        Me.radioenable.TabStop = True
        Me.radioenable.Text = "Enable"
        Me.radioenable.UseVisualStyleBackColor = True
        '
        'user_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(712, 678)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnadduser_user_reg)
        Me.Controls.Add(Me.btnaclear_user_reg)
        Me.Controls.Add(Me.radiouser)
        Me.Controls.Add(Me.radioadmin)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtuser_name)
        Me.Controls.Add(Me.txtnic)
        Me.Controls.Add(Me.txtlast_name)
        Me.Controls.Add(Me.txtfirst_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.Name = "user_register"
        Me.Text = "User Register"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtfirst_name As TextBox
    Friend WithEvents txtlast_name As TextBox
    Friend WithEvents txtnic As TextBox
    Friend WithEvents txtuser_name As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents radioadmin As RadioButton
    Friend WithEvents radiouser As RadioButton
    Friend WithEvents btnaclear_user_reg As Button
    Friend WithEvents btnadduser_user_reg As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents radiodisable As RadioButton
    Friend WithEvents radioenable As RadioButton
End Class
