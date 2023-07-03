<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class demage_vehicle_commentform
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.btnrecord = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboorderid = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.combovehicle_id = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(114, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Damege Vehicle Detailes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(36, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vehicle Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(38, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "comment"
        '
        'txtcomment
        '
        Me.txtcomment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomment.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtcomment.Location = New System.Drawing.Point(249, 242)
        Me.txtcomment.Multiline = True
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.Size = New System.Drawing.Size(416, 109)
        Me.txtcomment.TabIndex = 2
        '
        'btnrecord
        '
        Me.btnrecord.BackColor = System.Drawing.Color.DarkCyan
        Me.btnrecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnrecord.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnrecord.Location = New System.Drawing.Point(266, 404)
        Me.btnrecord.Name = "btnrecord"
        Me.btnrecord.Size = New System.Drawing.Size(169, 52)
        Me.btnrecord.TabIndex = 3
        Me.btnrecord.Text = "Record"
        Me.btnrecord.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Gray
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnclear.Location = New System.Drawing.Point(529, 404)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(136, 52)
        Me.btnclear.TabIndex = 4
        Me.btnclear.Text = "All Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(37, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Order Id"
        '
        'comboorderid
        '
        Me.comboorderid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboorderid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboorderid.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.comboorderid.FormattingEnabled = True
        Me.comboorderid.Location = New System.Drawing.Point(249, 172)
        Me.comboorderid.Name = "comboorderid"
        Me.comboorderid.Size = New System.Drawing.Size(416, 39)
        Me.comboorderid.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 56)
        Me.Panel1.TabIndex = 7
        '
        'combovehicle_id
        '
        Me.combovehicle_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.combovehicle_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combovehicle_id.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.combovehicle_id.FormattingEnabled = True
        Me.combovehicle_id.Location = New System.Drawing.Point(249, 93)
        Me.combovehicle_id.Name = "combovehicle_id"
        Me.combovehicle_id.Size = New System.Drawing.Size(416, 39)
        Me.combovehicle_id.TabIndex = 8
        '
        'demage_vehicle_commentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 495)
        Me.Controls.Add(Me.combovehicle_id)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.comboorderid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnrecord)
        Me.Controls.Add(Me.txtcomment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.Name = "demage_vehicle_commentform"
        Me.Text = "Demage Vehicle Comment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcomment As TextBox
    Friend WithEvents btnrecord As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents comboorderid As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents combovehicle_id As ComboBox
End Class
