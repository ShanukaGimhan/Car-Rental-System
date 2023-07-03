<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class All_users_form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grid_all_user = New System.Windows.Forms.DataGridView()
        Me.btnAll_user_show = New System.Windows.Forms.Button()
        Me.btnadduser = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnallclear = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        CType(Me.grid_all_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(277, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "All Users Details"
        '
        'grid_all_user
        '
        Me.grid_all_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_all_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grid_all_user.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_all_user.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_all_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_all_user.DefaultCellStyle = DataGridViewCellStyle2
        Me.grid_all_user.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grid_all_user.Location = New System.Drawing.Point(46, 181)
        Me.grid_all_user.Name = "grid_all_user"
        Me.grid_all_user.RowHeadersWidth = 51
        Me.grid_all_user.RowTemplate.Height = 29
        Me.grid_all_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_all_user.Size = New System.Drawing.Size(768, 349)
        Me.grid_all_user.TabIndex = 2
        '
        'btnAll_user_show
        '
        Me.btnAll_user_show.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAll_user_show.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAll_user_show.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAll_user_show.Location = New System.Drawing.Point(46, 101)
        Me.btnAll_user_show.Name = "btnAll_user_show"
        Me.btnAll_user_show.Size = New System.Drawing.Size(291, 53)
        Me.btnAll_user_show.TabIndex = 5
        Me.btnAll_user_show.Text = "Show All Users"
        Me.btnAll_user_show.UseVisualStyleBackColor = False
        '
        'btnadduser
        '
        Me.btnadduser.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnadduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnadduser.Location = New System.Drawing.Point(547, 101)
        Me.btnadduser.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.Size = New System.Drawing.Size(264, 53)
        Me.btnadduser.TabIndex = 14
        Me.btnadduser.Text = "Add New User"
        Me.btnadduser.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(878, 73)
        Me.Panel1.TabIndex = 15
        '
        'btnallclear
        '
        Me.btnallclear.BackColor = System.Drawing.Color.DimGray
        Me.btnallclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnallclear.Location = New System.Drawing.Point(648, 577)
        Me.btnallclear.Name = "btnallclear"
        Me.btnallclear.Size = New System.Drawing.Size(149, 53)
        Me.btnallclear.TabIndex = 31
        Me.btnallclear.Text = "All Clear"
        Me.btnallclear.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_refresh.Location = New System.Drawing.Point(262, 577)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(149, 53)
        Me.btn_refresh.TabIndex = 37
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Firebrick
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btndelete.Location = New System.Drawing.Point(459, 577)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(149, 53)
        Me.btndelete.TabIndex = 36
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'All_users_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(877, 663)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnallclear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnadduser)
        Me.Controls.Add(Me.btnAll_user_show)
        Me.Controls.Add(Me.grid_all_user)
        Me.MaximizeBox = False
        Me.Name = "All_users_form"
        Me.Text = "All Users"
        CType(Me.grid_all_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grid_all_user As DataGridView
    Friend WithEvents btnAll_user_show As Button
    Friend WithEvents btnadduser As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnallclear As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btndelete As Button
End Class
