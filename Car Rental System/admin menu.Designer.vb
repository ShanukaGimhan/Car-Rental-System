<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin__menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin__menu))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnlog_out = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnallusers = New System.Windows.Forms.Button()
        Me.btnmanege_user = New System.Windows.Forms.Button()
        Me.btnadd_user = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_manegeaccoun = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnlog_out)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(1, 29)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(853, 93)
        Me.Panel3.TabIndex = 41
        '
        'btnlog_out
        '
        Me.btnlog_out.BackColor = System.Drawing.Color.AliceBlue
        Me.btnlog_out.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnlog_out.Image = CType(resources.GetObject("btnlog_out.Image"), System.Drawing.Image)
        Me.btnlog_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlog_out.Location = New System.Drawing.Point(673, 23)
        Me.btnlog_out.Name = "btnlog_out"
        Me.btnlog_out.Size = New System.Drawing.Size(155, 51)
        Me.btnlog_out.TabIndex = 10
        Me.btnlog_out.Text = "Log Out"
        Me.btnlog_out.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(25, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 73)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(135, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Administrator"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnallusers)
        Me.Panel2.Controls.Add(Me.btnmanege_user)
        Me.Panel2.Controls.Add(Me.btnadd_user)
        Me.Panel2.Location = New System.Drawing.Point(413, 146)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 386)
        Me.Panel2.TabIndex = 42
        '
        'btnallusers
        '
        Me.btnallusers.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnallusers.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnallusers.ForeColor = System.Drawing.SystemColors.Control
        Me.btnallusers.Location = New System.Drawing.Point(27, 272)
        Me.btnallusers.Name = "btnallusers"
        Me.btnallusers.Size = New System.Drawing.Size(359, 68)
        Me.btnallusers.TabIndex = 16
        Me.btnallusers.Text = "All Users"
        Me.btnallusers.UseVisualStyleBackColor = False
        '
        'btnmanege_user
        '
        Me.btnmanege_user.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnmanege_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnmanege_user.ForeColor = System.Drawing.SystemColors.Control
        Me.btnmanege_user.Location = New System.Drawing.Point(27, 160)
        Me.btnmanege_user.Name = "btnmanege_user"
        Me.btnmanege_user.Size = New System.Drawing.Size(359, 69)
        Me.btnmanege_user.TabIndex = 7
        Me.btnmanege_user.Text = "Manege User"
        Me.btnmanege_user.UseVisualStyleBackColor = False
        '
        'btnadd_user
        '
        Me.btnadd_user.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnadd_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnadd_user.ForeColor = System.Drawing.SystemColors.Control
        Me.btnadd_user.Location = New System.Drawing.Point(27, 41)
        Me.btnadd_user.Name = "btnadd_user"
        Me.btnadd_user.Size = New System.Drawing.Size(359, 71)
        Me.btnadd_user.TabIndex = 6
        Me.btnadd_user.Text = "Add New User"
        Me.btnadd_user.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(26, 146)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 387)
        Me.Panel1.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(35, 57)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(246, 283)
        Me.Button2.TabIndex = 32
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_manegeaccoun})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 31)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_manegeaccoun
        '
        Me.menu_manegeaccoun.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.menu_manegeaccoun.ForeColor = System.Drawing.Color.Firebrick
        Me.menu_manegeaccoun.Name = "menu_manegeaccoun"
        Me.menu_manegeaccoun.Size = New System.Drawing.Size(217, 27)
        Me.menu_manegeaccoun.Text = "Manage Admin Account"
        '
        'admin__menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(854, 581)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "admin__menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin__menu"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnallusers As Button
    Friend WithEvents btnmanege_user As Button
    Friend WithEvents btnadd_user As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnlog_out As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menu_manegeaccoun As ToolStripMenuItem
End Class
