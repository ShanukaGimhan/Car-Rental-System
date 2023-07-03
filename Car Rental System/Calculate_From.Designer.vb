<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculate_From
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculate_From))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcustomer_payment = New System.Windows.Forms.TextBox()
        Me.txtowner_payment = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btngenerate_profit = New System.Windows.Forms.Button()
        Me.btninsert1 = New System.Windows.Forms.Button()
        Me.btninsert2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(54, 255)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer  Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(54, 334)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Owner  Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(54, 416)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total  Profit"
        '
        'txtcustomer_payment
        '
        Me.txtcustomer_payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustomer_payment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtcustomer_payment.Location = New System.Drawing.Point(293, 246)
        Me.txtcustomer_payment.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtcustomer_payment.Name = "txtcustomer_payment"
        Me.txtcustomer_payment.Size = New System.Drawing.Size(384, 34)
        Me.txtcustomer_payment.TabIndex = 0
        Me.txtcustomer_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtowner_payment
        '
        Me.txtowner_payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtowner_payment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtowner_payment.Location = New System.Drawing.Point(293, 325)
        Me.txtowner_payment.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtowner_payment.Name = "txtowner_payment"
        Me.txtowner_payment.Size = New System.Drawing.Size(384, 34)
        Me.txtowner_payment.TabIndex = 1
        Me.txtowner_payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotal
        '
        Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txttotal.Location = New System.Drawing.Point(293, 407)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(384, 34)
        Me.txttotal.TabIndex = 2
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnexit.Location = New System.Drawing.Point(131, 494)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(139, 55)
        Me.btnexit.TabIndex = 6
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btngenerate_profit
        '
        Me.btngenerate_profit.BackColor = System.Drawing.Color.DarkCyan
        Me.btngenerate_profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btngenerate_profit.ForeColor = System.Drawing.SystemColors.Control
        Me.btngenerate_profit.Location = New System.Drawing.Point(341, 494)
        Me.btngenerate_profit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btngenerate_profit.Name = "btngenerate_profit"
        Me.btngenerate_profit.Size = New System.Drawing.Size(219, 55)
        Me.btngenerate_profit.TabIndex = 7
        Me.btngenerate_profit.Text = "Generate Profit"
        Me.btngenerate_profit.UseVisualStyleBackColor = False
        '
        'btninsert1
        '
        Me.btninsert1.BackColor = System.Drawing.Color.Turquoise
        Me.btninsert1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btninsert1.Location = New System.Drawing.Point(714, 248)
        Me.btninsert1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btninsert1.Name = "btninsert1"
        Me.btninsert1.Size = New System.Drawing.Size(136, 38)
        Me.btninsert1.TabIndex = 14
        Me.btninsert1.Text = "Insert"
        Me.btninsert1.UseVisualStyleBackColor = False
        '
        'btninsert2
        '
        Me.btninsert2.BackColor = System.Drawing.Color.Turquoise
        Me.btninsert2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btninsert2.Location = New System.Drawing.Point(714, 329)
        Me.btninsert2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btninsert2.Name = "btninsert2"
        Me.btninsert2.Size = New System.Drawing.Size(136, 39)
        Me.btninsert2.TabIndex = 15
        Me.btninsert2.Text = "Insert"
        Me.btninsert2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(894, 85)
        Me.Panel3.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(47, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 56)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(120, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(214, 42)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Calculation"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 69)
        Me.Panel1.TabIndex = 36
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(482, 19)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(294, 32)
        Me.DateTimePicker2.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(426, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 28)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "To"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 19)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(290, 32)
        Me.DateTimePicker1.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(5, 19)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 25)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "From"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_clear.Location = New System.Drawing.Point(650, 494)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(139, 55)
        Me.btn_clear.TabIndex = 37
        Me.btn_clear.Text = "Clear All"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'Calculate_From
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(893, 595)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btninsert2)
        Me.Controls.Add(Me.btninsert1)
        Me.Controls.Add(Me.btngenerate_profit)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtowner_payment)
        Me.Controls.Add(Me.txtcustomer_payment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "Calculate_From"
        Me.Text = " Calculate"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcustomer_payment As TextBox
    Friend WithEvents txtowner_payment As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btnexit As Button
    Friend WithEvents btngenerate_profit As Button
    Friend WithEvents btninsert1 As Button
    Friend WithEvents btninsert2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_clear As Button
End Class
