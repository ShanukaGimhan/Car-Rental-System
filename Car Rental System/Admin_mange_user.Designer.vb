<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_mange_user
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtuser_name = New System.Windows.Forms.TextBox()
        Me.RadioButton_enable = New System.Windows.Forms.RadioButton()
        Me.RadioButton_disable = New System.Windows.Forms.RadioButton()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox_nic = New System.Windows.Forms.ComboBox()
        Me.btnallclear = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(42, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIC Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(42, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(42, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'txtuser_name
        '
        Me.txtuser_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtuser_name.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtuser_name.Location = New System.Drawing.Point(242, 207)
        Me.txtuser_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuser_name.Name = "txtuser_name"
        Me.txtuser_name.Size = New System.Drawing.Size(320, 34)
        Me.txtuser_name.TabIndex = 1
        '
        'RadioButton_enable
        '
        Me.RadioButton_enable.AutoSize = True
        Me.RadioButton_enable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton_enable.Location = New System.Drawing.Point(242, 285)
        Me.RadioButton_enable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton_enable.Name = "RadioButton_enable"
        Me.RadioButton_enable.Size = New System.Drawing.Size(116, 33)
        Me.RadioButton_enable.TabIndex = 2
        Me.RadioButton_enable.TabStop = True
        Me.RadioButton_enable.Text = "Enable"
        Me.RadioButton_enable.UseVisualStyleBackColor = True
        '
        'RadioButton_disable
        '
        Me.RadioButton_disable.AutoSize = True
        Me.RadioButton_disable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton_disable.Location = New System.Drawing.Point(442, 285)
        Me.RadioButton_disable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButton_disable.Name = "RadioButton_disable"
        Me.RadioButton_disable.Size = New System.Drawing.Size(123, 33)
        Me.RadioButton_disable.TabIndex = 2
        Me.RadioButton_disable.TabStop = True
        Me.RadioButton_disable.Text = "Disable"
        Me.RadioButton_disable.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnsearch.Location = New System.Drawing.Point(625, 117)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(110, 43)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.Color.DarkCyan
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnconfirm.ForeColor = System.Drawing.SystemColors.Control
        Me.btnconfirm.Location = New System.Drawing.Point(280, 371)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(229, 53)
        Me.btnconfirm.TabIndex = 3
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(791, 73)
        Me.Panel3.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(264, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(254, 42)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Manage User"
        '
        'ComboBox_nic
        '
        Me.ComboBox_nic.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox_nic.FormattingEnabled = True
        Me.ComboBox_nic.Location = New System.Drawing.Point(242, 120)
        Me.ComboBox_nic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox_nic.Name = "ComboBox_nic"
        Me.ComboBox_nic.Size = New System.Drawing.Size(320, 36)
        Me.ComboBox_nic.TabIndex = 37
        '
        'btnallclear
        '
        Me.btnallclear.BackColor = System.Drawing.Color.Gray
        Me.btnallclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnallclear.Location = New System.Drawing.Point(580, 373)
        Me.btnallclear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnallclear.Name = "btnallclear"
        Me.btnallclear.Size = New System.Drawing.Size(155, 53)
        Me.btnallclear.TabIndex = 38
        Me.btnallclear.Text = "Clear"
        Me.btnallclear.UseVisualStyleBackColor = False
        '
        'Admin_mange_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(791, 477)
        Me.Controls.Add(Me.btnallclear)
        Me.Controls.Add(Me.ComboBox_nic)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.RadioButton_disable)
        Me.Controls.Add(Me.RadioButton_enable)
        Me.Controls.Add(Me.txtuser_name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Admin_mange_user"
        Me.Text = "Admin_mange_user"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtuser_name As TextBox
    Friend WithEvents RadioButton_enable As RadioButton
    Friend WithEvents RadioButton_disable As RadioButton
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnconfirm As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox_nic As ComboBox
    Friend WithEvents btnallclear As Button
End Class
