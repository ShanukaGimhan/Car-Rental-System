<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehicle_Owner_Payment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_paid_amount = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.Combovehicleid = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker_paid = New System.Windows.Forms.DateTimePicker()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(211, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vehicel Owner Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(32, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vehicle Register Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(32, 221)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Paid Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(32, 293)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Paid Amount"
        '
        'txt_paid_amount
        '
        Me.txt_paid_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_paid_amount.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_paid_amount.Location = New System.Drawing.Point(258, 285)
        Me.txt_paid_amount.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_paid_amount.Name = "txt_paid_amount"
        Me.txt_paid_amount.Size = New System.Drawing.Size(469, 31)
        Me.txt_paid_amount.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(419, 461)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(0, 0)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.Color.DarkCyan
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnconfirm.ForeColor = System.Drawing.SystemColors.Control
        Me.btnconfirm.Location = New System.Drawing.Point(263, 398)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnconfirm.Size = New System.Drawing.Size(203, 56)
        Me.btnconfirm.TabIndex = 12
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnprint.Location = New System.Drawing.Point(539, 398)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(187, 56)
        Me.btnprint.TabIndex = 15
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'Combovehicleid
        '
        Me.Combovehicleid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Combovehicleid.FormattingEnabled = True
        Me.Combovehicleid.Location = New System.Drawing.Point(261, 137)
        Me.Combovehicleid.Name = "Combovehicleid"
        Me.Combovehicleid.Size = New System.Drawing.Size(463, 36)
        Me.Combovehicleid.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 69)
        Me.Panel1.TabIndex = 17
        '
        'DateTimePicker_paid
        '
        Me.DateTimePicker_paid.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_paid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker_paid.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_paid.Location = New System.Drawing.Point(258, 212)
        Me.DateTimePicker_paid.Name = "DateTimePicker_paid"
        Me.DateTimePicker_paid.Size = New System.Drawing.Size(466, 34)
        Me.DateTimePicker_paid.TabIndex = 18
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Gray
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnclear.Location = New System.Drawing.Point(57, 398)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(136, 56)
        Me.btnclear.TabIndex = 19
        Me.btnclear.Text = "All Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Vehicle_Owner_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(797, 504)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.DateTimePicker_paid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Combovehicleid)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_paid_amount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "Vehicle_Owner_Payment"
        Me.Text = "Vehicle_Owner_Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_paid_amount As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnconfirm As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents Combovehicleid As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker_paid As DateTimePicker
    Friend WithEvents btnclear As Button
End Class
