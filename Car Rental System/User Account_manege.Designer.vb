<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Account_manege
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Account_manege))
        Me.panelmenu = New System.Windows.Forms.Panel()
        Me.btnallcancel = New System.Windows.Forms.Button()
        Me.btnchange_password = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paneltop = New System.Windows.Forms.Panel()
        Me.panelpassword = New System.Windows.Forms.Panel()
        Me.txtusename = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrepass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcurent_pass = New System.Windows.Forms.TextBox()
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.btncancel_password = New System.Windows.Forms.Button()
        Me.btnupdate_password = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.paneldescription = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.panelmenu.SuspendLayout()
        Me.paneltop.SuspendLayout()
        Me.panelpassword.SuspendLayout()
        Me.paneldescription.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelmenu
        '
        Me.panelmenu.BackColor = System.Drawing.SystemColors.Control
        Me.panelmenu.BackgroundImage = CType(resources.GetObject("panelmenu.BackgroundImage"), System.Drawing.Image)
        Me.panelmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelmenu.Controls.Add(Me.btnallcancel)
        Me.panelmenu.Controls.Add(Me.btnchange_password)
        Me.panelmenu.Location = New System.Drawing.Point(0, 51)
        Me.panelmenu.Name = "panelmenu"
        Me.panelmenu.Size = New System.Drawing.Size(290, 468)
        Me.panelmenu.TabIndex = 0
        '
        'btnallcancel
        '
        Me.btnallcancel.BackColor = System.Drawing.Color.Silver
        Me.btnallcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnallcancel.ForeColor = System.Drawing.Color.Red
        Me.btnallcancel.Location = New System.Drawing.Point(57, 364)
        Me.btnallcancel.Name = "btnallcancel"
        Me.btnallcancel.Size = New System.Drawing.Size(149, 49)
        Me.btnallcancel.TabIndex = 7
        Me.btnallcancel.Text = "Cancel"
        Me.btnallcancel.UseVisualStyleBackColor = False
        '
        'btnchange_password
        '
        Me.btnchange_password.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnchange_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnchange_password.ForeColor = System.Drawing.SystemColors.Control
        Me.btnchange_password.Location = New System.Drawing.Point(12, 204)
        Me.btnchange_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnchange_password.Name = "btnchange_password"
        Me.btnchange_password.Size = New System.Drawing.Size(264, 56)
        Me.btnchange_password.TabIndex = 2
        Me.btnchange_password.Text = "Change Password"
        Me.btnchange_password.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(231, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manege User Account"
        '
        'paneltop
        '
        Me.paneltop.BackColor = System.Drawing.Color.Teal
        Me.paneltop.Controls.Add(Me.Label1)
        Me.paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltop.Location = New System.Drawing.Point(0, 0)
        Me.paneltop.Name = "paneltop"
        Me.paneltop.Size = New System.Drawing.Size(862, 57)
        Me.paneltop.TabIndex = 2
        '
        'panelpassword
        '
        Me.panelpassword.Controls.Add(Me.txtusename)
        Me.panelpassword.Controls.Add(Me.Label3)
        Me.panelpassword.Controls.Add(Me.txtrepass)
        Me.panelpassword.Controls.Add(Me.Label2)
        Me.panelpassword.Controls.Add(Me.txtcurent_pass)
        Me.panelpassword.Controls.Add(Me.txtnewpass)
        Me.panelpassword.Controls.Add(Me.btncancel_password)
        Me.panelpassword.Controls.Add(Me.btnupdate_password)
        Me.panelpassword.Controls.Add(Me.Label4)
        Me.panelpassword.Controls.Add(Me.Label5)
        Me.panelpassword.Location = New System.Drawing.Point(296, 63)
        Me.panelpassword.Name = "panelpassword"
        Me.panelpassword.Size = New System.Drawing.Size(557, 456)
        Me.panelpassword.TabIndex = 16
        '
        'txtusename
        '
        Me.txtusename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusename.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtusename.Location = New System.Drawing.Point(64, 42)
        Me.txtusename.Name = "txtusename"
        Me.txtusename.Size = New System.Drawing.Size(351, 34)
        Me.txtusename.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(37, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "User Name"
        '
        'txtrepass
        '
        Me.txtrepass.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtrepass.Location = New System.Drawing.Point(64, 308)
        Me.txtrepass.Name = "txtrepass"
        Me.txtrepass.Size = New System.Drawing.Size(351, 34)
        Me.txtrepass.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(37, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Retype New Password"
        '
        'txtcurent_pass
        '
        Me.txtcurent_pass.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtcurent_pass.Location = New System.Drawing.Point(64, 123)
        Me.txtcurent_pass.Name = "txtcurent_pass"
        Me.txtcurent_pass.Size = New System.Drawing.Size(351, 34)
        Me.txtcurent_pass.TabIndex = 18
        '
        'txtnewpass
        '
        Me.txtnewpass.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtnewpass.Location = New System.Drawing.Point(64, 217)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.Size = New System.Drawing.Size(351, 34)
        Me.txtnewpass.TabIndex = 19
        '
        'btncancel_password
        '
        Me.btncancel_password.BackColor = System.Drawing.Color.Gray
        Me.btncancel_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btncancel_password.Location = New System.Drawing.Point(336, 372)
        Me.btncancel_password.Name = "btncancel_password"
        Me.btncancel_password.Size = New System.Drawing.Size(136, 53)
        Me.btncancel_password.TabIndex = 17
        Me.btncancel_password.Text = "Clear All"
        Me.btncancel_password.UseVisualStyleBackColor = False
        '
        'btnupdate_password
        '
        Me.btnupdate_password.BackColor = System.Drawing.Color.DarkCyan
        Me.btnupdate_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnupdate_password.ForeColor = System.Drawing.SystemColors.Control
        Me.btnupdate_password.Location = New System.Drawing.Point(81, 372)
        Me.btnupdate_password.Name = "btnupdate_password"
        Me.btnupdate_password.Size = New System.Drawing.Size(183, 53)
        Me.btnupdate_password.TabIndex = 16
        Me.btnupdate_password.Text = "Update"
        Me.btnupdate_password.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Enter New Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(37, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Enter Current Password"
        '
        'paneldescription
        '
        Me.paneldescription.Controls.Add(Me.RichTextBox1)
        Me.paneldescription.Location = New System.Drawing.Point(296, 63)
        Me.paneldescription.Name = "paneldescription"
        Me.paneldescription.Size = New System.Drawing.Size(557, 453)
        Me.paneldescription.TabIndex = 22
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(557, 453)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(10) & "  " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "-Remember Your Password and Username." & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(10) & "  -If you have a problem please cont" &
    "atct Admin" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "-Click the Button to Changes."
        '
        'User_Account_manege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 519)
        Me.Controls.Add(Me.paneldescription)
        Me.Controls.Add(Me.paneltop)
        Me.Controls.Add(Me.panelmenu)
        Me.Controls.Add(Me.panelpassword)
        Me.MaximizeBox = False
        Me.Name = "User_Account_manege"
        Me.Text = "User_Account_manege"
        Me.panelmenu.ResumeLayout(False)
        Me.paneltop.ResumeLayout(False)
        Me.paneltop.PerformLayout()
        Me.panelpassword.ResumeLayout(False)
        Me.panelpassword.PerformLayout()
        Me.paneldescription.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelmenu As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents paneltop As Panel
    Friend WithEvents btnchange_password As Button
    Friend WithEvents panelpassword As Panel
    Friend WithEvents txtcurent_pass As TextBox
    Friend WithEvents txtnewpass As TextBox
    Friend WithEvents btncancel_password As Button
    Friend WithEvents btnupdate_password As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents paneldescription As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtrepass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusename As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnallcancel As Button
End Class
