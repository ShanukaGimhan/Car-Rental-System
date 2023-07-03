<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehicle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehicle))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btndamage_details = New System.Windows.Forms.Button()
        Me.btnvehicle_order = New System.Windows.Forms.Button()
        Me.btnvehicle_register = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(-3, -3)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(848, 91)
        Me.Panel3.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(18, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(145, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Vehicle "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btndamage_details)
        Me.Panel2.Controls.Add(Me.btnvehicle_order)
        Me.Panel2.Controls.Add(Me.btnvehicle_register)
        Me.Panel2.Location = New System.Drawing.Point(403, 128)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(416, 386)
        Me.Panel2.TabIndex = 41
        '
        'btndamage_details
        '
        Me.btndamage_details.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btndamage_details.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btndamage_details.ForeColor = System.Drawing.SystemColors.Control
        Me.btndamage_details.Location = New System.Drawing.Point(27, 263)
        Me.btndamage_details.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btndamage_details.Name = "btndamage_details"
        Me.btndamage_details.Size = New System.Drawing.Size(359, 76)
        Me.btndamage_details.TabIndex = 5
        Me.btndamage_details.Text = "Damege Vehicle"
        Me.btndamage_details.UseVisualStyleBackColor = False
        '
        'btnvehicle_order
        '
        Me.btnvehicle_order.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnvehicle_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnvehicle_order.ForeColor = System.Drawing.SystemColors.Control
        Me.btnvehicle_order.Location = New System.Drawing.Point(27, 157)
        Me.btnvehicle_order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnvehicle_order.Name = "btnvehicle_order"
        Me.btnvehicle_order.Size = New System.Drawing.Size(359, 76)
        Me.btnvehicle_order.TabIndex = 3
        Me.btnvehicle_order.Text = "Vehicle Order"
        Me.btnvehicle_order.UseVisualStyleBackColor = False
        '
        'btnvehicle_register
        '
        Me.btnvehicle_register.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnvehicle_register.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnvehicle_register.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnvehicle_register.Location = New System.Drawing.Point(27, 44)
        Me.btnvehicle_register.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnvehicle_register.Name = "btnvehicle_register"
        Me.btnvehicle_register.Size = New System.Drawing.Size(359, 76)
        Me.btnvehicle_register.TabIndex = 2
        Me.btnvehicle_register.Text = " Vehicle Register"
        Me.btnvehicle_register.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(31, 128)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 387)
        Me.Panel1.TabIndex = 42
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
        'Vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(845, 559)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Vehicle"
        Me.Text = "Vehicle"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btndamage_details As Button
    Friend WithEvents btnvehicle_order As Button
    Friend WithEvents btnvehicle_register As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
