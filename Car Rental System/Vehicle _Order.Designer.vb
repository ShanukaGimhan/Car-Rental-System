<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehicle_Order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehicle_Order))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmilage = New System.Windows.Forms.TextBox()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.txtkm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Combovehicleregid = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView_status = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_status = New System.Windows.Forms.Button()
        Me.DateTimePicker_rent = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_handover = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView_status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(73, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vehicle Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(72, 224)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Current Milage Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(73, 334)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pickup Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(73, 384)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Handover Date"
        '
        'txtmilage
        '
        Me.txtmilage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmilage.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtmilage.Location = New System.Drawing.Point(355, 218)
        Me.txtmilage.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtmilage.Name = "txtmilage"
        Me.txtmilage.Size = New System.Drawing.Size(456, 31)
        Me.txtmilage.TabIndex = 1
        '
        'btnconfirm
        '
        Me.btnconfirm.BackColor = System.Drawing.Color.DarkCyan
        Me.btnconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnconfirm.ForeColor = System.Drawing.SystemColors.Control
        Me.btnconfirm.Location = New System.Drawing.Point(357, 448)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(213, 67)
        Me.btnconfirm.TabIndex = 13
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = False
        '
        'txtkm
        '
        Me.txtkm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkm.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtkm.Location = New System.Drawing.Point(355, 269)
        Me.txtkm.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtkm.Name = "txtkm"
        Me.txtkm.Size = New System.Drawing.Size(456, 31)
        Me.txtkm.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(73, 277)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Km per day"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Gray
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnclear.Location = New System.Drawing.Point(640, 448)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(160, 65)
        Me.btnclear.TabIndex = 17
        Me.btnclear.Text = "All Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Combovehicleregid
        '
        Me.Combovehicleregid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Combovehicleregid.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Combovehicleregid.FormattingEnabled = True
        Me.Combovehicleregid.Location = New System.Drawing.Point(357, 114)
        Me.Combovehicleregid.Name = "Combovehicleregid"
        Me.Combovehicleregid.Size = New System.Drawing.Size(447, 33)
        Me.Combovehicleregid.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(73, 171)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 25)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Vehicle  Status"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Location = New System.Drawing.Point(-5, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1226, 73)
        Me.Panel3.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(41, 7)
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
        Me.Label14.Location = New System.Drawing.Point(117, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(259, 42)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Vehicle Order"
        '
        'DataGridView_status
        '
        Me.DataGridView_status.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView_status.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView_status.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_status.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_status.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_status.Location = New System.Drawing.Point(36, 25)
        Me.DataGridView_status.Name = "DataGridView_status"
        Me.DataGridView_status.RowHeadersWidth = 51
        Me.DataGridView_status.RowTemplate.Height = 29
        Me.DataGridView_status.Size = New System.Drawing.Size(287, 283)
        Me.DataGridView_status.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.btn_status)
        Me.Panel1.Controls.Add(Me.DataGridView_status)
        Me.Panel1.Location = New System.Drawing.Point(832, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 398)
        Me.Panel1.TabIndex = 34
        '
        'btn_status
        '
        Me.btn_status.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_status.Location = New System.Drawing.Point(79, 331)
        Me.btn_status.Name = "btn_status"
        Me.btn_status.Size = New System.Drawing.Size(202, 41)
        Me.btn_status.TabIndex = 34
        Me.btn_status.Text = "Find Status"
        Me.btn_status.UseVisualStyleBackColor = False
        '
        'DateTimePicker_rent
        '
        Me.DateTimePicker_rent.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_rent.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker_rent.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_rent.Location = New System.Drawing.Point(353, 327)
        Me.DateTimePicker_rent.Name = "DateTimePicker_rent"
        Me.DateTimePicker_rent.Size = New System.Drawing.Size(460, 34)
        Me.DateTimePicker_rent.TabIndex = 35
        '
        'DateTimePicker_handover
        '
        Me.DateTimePicker_handover.CustomFormat = "yyy-MM-dd"
        Me.DateTimePicker_handover.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker_handover.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_handover.Location = New System.Drawing.Point(352, 382)
        Me.DateTimePicker_handover.Name = "DateTimePicker_handover"
        Me.DateTimePicker_handover.Size = New System.Drawing.Size(460, 34)
        Me.DateTimePicker_handover.TabIndex = 35
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.Location = New System.Drawing.Point(357, 164)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(171, 32)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "Pickup Vehicle"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Vehicle_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1219, 576)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DateTimePicker_handover)
        Me.Controls.Add(Me.DateTimePicker_rent)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Combovehicleregid)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtkm)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.txtmilage)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "Vehicle_Order"
        Me.Text = "Vehicle_Order"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmilage As TextBox
    Friend WithEvents btnconfirm As Button
    Friend WithEvents txtkm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents Combovehicleregid As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView_status As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_status As Button
    Friend WithEvents DateTimePicker_rent As DateTimePicker
    Friend WithEvents DateTimePicker_handover As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
End Class
