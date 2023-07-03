<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Damege_vehicle_summaryform
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grid_damege_summary = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboselect_vehicle_damege = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnshow_vehicle_damege = New System.Windows.Forms.Button()
        Me.btnclear_damege = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.grid_damege_summary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_damege_summary
        '
        Me.grid_damege_summary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_damege_summary.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_damege_summary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_damege_summary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_damege_summary.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_damege_summary.Location = New System.Drawing.Point(47, 247)
        Me.grid_damege_summary.Name = "grid_damege_summary"
        Me.grid_damege_summary.RowHeadersWidth = 51
        Me.grid_damege_summary.RowTemplate.Height = 29
        Me.grid_damege_summary.Size = New System.Drawing.Size(726, 252)
        Me.grid_damege_summary.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(128, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Damege Vehicle Summary"
        '
        'comboselect_vehicle_damege
        '
        Me.comboselect_vehicle_damege.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.comboselect_vehicle_damege.FormattingEnabled = True
        Me.comboselect_vehicle_damege.Location = New System.Drawing.Point(358, 104)
        Me.comboselect_vehicle_damege.Name = "comboselect_vehicle_damege"
        Me.comboselect_vehicle_damege.Size = New System.Drawing.Size(414, 36)
        Me.comboselect_vehicle_damege.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(47, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Vehicle Number"
        '
        'btnshow_vehicle_damege
        '
        Me.btnshow_vehicle_damege.BackColor = System.Drawing.Color.DarkCyan
        Me.btnshow_vehicle_damege.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnshow_vehicle_damege.ForeColor = System.Drawing.SystemColors.Control
        Me.btnshow_vehicle_damege.Location = New System.Drawing.Point(47, 172)
        Me.btnshow_vehicle_damege.Name = "btnshow_vehicle_damege"
        Me.btnshow_vehicle_damege.Size = New System.Drawing.Size(293, 53)
        Me.btnshow_vehicle_damege.TabIndex = 4
        Me.btnshow_vehicle_damege.Text = "Show Details"
        Me.btnshow_vehicle_damege.UseVisualStyleBackColor = False
        '
        'btnclear_damege
        '
        Me.btnclear_damege.BackColor = System.Drawing.Color.Gray
        Me.btnclear_damege.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnclear_damege.Location = New System.Drawing.Point(637, 172)
        Me.btnclear_damege.Name = "btnclear_damege"
        Me.btnclear_damege.Size = New System.Drawing.Size(136, 53)
        Me.btnclear_damege.TabIndex = 5
        Me.btnclear_damege.Text = "All Clear"
        Me.btnclear_damege.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 64)
        Me.Panel1.TabIndex = 6
        '
        'Damege_vehicle_summaryform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(824, 545)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclear_damege)
        Me.Controls.Add(Me.btnshow_vehicle_damege)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboselect_vehicle_damege)
        Me.Controls.Add(Me.grid_damege_summary)
        Me.MaximizeBox = False
        Me.Name = "Damege_vehicle_summaryform"
        Me.Text = "Damege vehicle summary"
        CType(Me.grid_damege_summary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_damege_summary As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents comboselect_vehicle_damege As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnshow_vehicle_damege As Button
    Friend WithEvents btnclear_damege As Button
    Friend WithEvents Panel1 As Panel
End Class
