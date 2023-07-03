<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Payment
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
        Me.txtdelay_charge = New System.Windows.Forms.TextBox()
        Me.txttotal_amount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBox_handover = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_nic = New System.Windows.Forms.ComboBox()
        Me.ComboBox_order = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnallclear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Pickup = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Handover = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtdelay_charge
        '
        Me.txtdelay_charge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdelay_charge.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtdelay_charge.Location = New System.Drawing.Point(264, 157)
        Me.txtdelay_charge.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdelay_charge.Multiline = True
        Me.txtdelay_charge.Name = "txtdelay_charge"
        Me.txtdelay_charge.Size = New System.Drawing.Size(432, 31)
        Me.txtdelay_charge.TabIndex = 4
        '
        'txttotal_amount
        '
        Me.txttotal_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotal_amount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txttotal_amount.Location = New System.Drawing.Point(264, 215)
        Me.txttotal_amount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttotal_amount.Name = "txttotal_amount"
        Me.txttotal_amount.Size = New System.Drawing.Size(432, 31)
        Me.txttotal_amount.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(49, 222)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Total  Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(49, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Delay Charge"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.CausesValidation = False
        Me.Panel3.Controls.Add(Me.CheckBox_handover)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.ComboBox_nic)
        Me.Panel3.Controls.Add(Me.ComboBox_order)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.btnallclear)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.btnconfirm)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.DateTimePicker_Pickup)
        Me.Panel3.Controls.Add(Me.txtdelay_charge)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.DateTimePicker_Handover)
        Me.Panel3.Controls.Add(Me.txttotal_amount)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(0, 75)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(834, 587)
        Me.Panel3.TabIndex = 25
        '
        'CheckBox_handover
        '
        Me.CheckBox_handover.AutoSize = True
        Me.CheckBox_handover.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox_handover.Location = New System.Drawing.Point(264, 406)
        Me.CheckBox_handover.Name = "CheckBox_handover"
        Me.CheckBox_handover.Size = New System.Drawing.Size(200, 32)
        Me.CheckBox_handover.TabIndex = 39
        Me.CheckBox_handover.Text = "Handover Vehicle"
        Me.CheckBox_handover.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(50, 413)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Vehicle  Status"
        '
        'ComboBox_nic
        '
        Me.ComboBox_nic.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox_nic.FormattingEnabled = True
        Me.ComboBox_nic.Location = New System.Drawing.Point(264, 99)
        Me.ComboBox_nic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox_nic.Name = "ComboBox_nic"
        Me.ComboBox_nic.Size = New System.Drawing.Size(431, 33)
        Me.ComboBox_nic.TabIndex = 36
        '
        'ComboBox_order
        '
        Me.ComboBox_order.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox_order.FormattingEnabled = True
        Me.ComboBox_order.Location = New System.Drawing.Point(264, 41)
        Me.ComboBox_order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox_order.Name = "ComboBox_order"
        Me.ComboBox_order.Size = New System.Drawing.Size(431, 33)
        Me.ComboBox_order.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(-37, -139)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 75)
        Me.Panel1.TabIndex = 32
        '
        'btnallclear
        '
        Me.btnallclear.BackColor = System.Drawing.Color.DimGray
        Me.btnallclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnallclear.Location = New System.Drawing.Point(97, 484)
        Me.btnallclear.Name = "btnallclear"
        Me.btnallclear.Size = New System.Drawing.Size(149, 53)
        Me.btnallclear.TabIndex = 30
        Me.btnallclear.Text = "All Clear"
        Me.btnallclear.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(550, 484)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 53)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.Color.DarkCyan
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnconfirm.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnconfirm.Location = New System.Drawing.Point(305, 484)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(187, 53)
        Me.btnconfirm.TabIndex = 32
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(50, 283)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Pickup Date"
        '
        'DateTimePicker_Pickup
        '
        Me.DateTimePicker_Pickup.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_Pickup.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker_Pickup.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Pickup.Location = New System.Drawing.Point(265, 276)
        Me.DateTimePicker_Pickup.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DateTimePicker_Pickup.Name = "DateTimePicker_Pickup"
        Me.DateTimePicker_Pickup.Size = New System.Drawing.Size(431, 31)
        Me.DateTimePicker_Pickup.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(50, 341)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Handover Date"
        '
        'DateTimePicker_Handover
        '
        Me.DateTimePicker_Handover.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_Handover.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker_Handover.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Handover.Location = New System.Drawing.Point(265, 340)
        Me.DateTimePicker_Handover.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DateTimePicker_Handover.Name = "DateTimePicker_Handover"
        Me.DateTimePicker_Handover.Size = New System.Drawing.Size(431, 31)
        Me.DateTimePicker_Handover.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(49, 47)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 24)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Order ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(49, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 24)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Customer NIC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(215, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 42)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Customer Payment"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(834, 75)
        Me.Panel2.TabIndex = 33
        '
        'Customer_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 661)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "Customer_Payment"
        Me.Text = "Customer payment"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker_Handover As DateTimePicker
    Friend WithEvents DateTimePicker_Picup As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnallclear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnconfirm As Button
    Friend WithEvents txtdelay_charge As TextBox
    Friend WithEvents txttotal_amount As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox_nic As ComboBox
    Friend WithEvents ComboBox_order As ComboBox
    Friend WithEvents DateTimePicker_Pickup As DateTimePicker
    Friend WithEvents CheckBox_handover As CheckBox
    Friend WithEvents Label1 As Label
End Class
