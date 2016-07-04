<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_campaign = New System.Windows.Forms.Label()
        Me.lbl_team = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pb_user_img = New System.Windows.Forms.PictureBox()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.txt_old_pass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_new_pass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_conf_pass = New System.Windows.Forms.TextBox()
        Me.btn_reset_pass = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.lbl_dept = New System.Windows.Forms.Label()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.lbl_bday = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel6.SuspendLayout()
        CType(Me.pb_user_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_user.Location = New System.Drawing.Point(221, 14)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(0, 16)
        Me.lbl_user.TabIndex = 33
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_campaign
        '
        Me.lbl_campaign.AutoSize = True
        Me.lbl_campaign.BackColor = System.Drawing.Color.Transparent
        Me.lbl_campaign.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_campaign.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_campaign.Location = New System.Drawing.Point(221, 34)
        Me.lbl_campaign.Name = "lbl_campaign"
        Me.lbl_campaign.Size = New System.Drawing.Size(0, 16)
        Me.lbl_campaign.TabIndex = 34
        Me.lbl_campaign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_team
        '
        Me.lbl_team.AutoSize = True
        Me.lbl_team.BackColor = System.Drawing.Color.Transparent
        Me.lbl_team.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_team.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_team.Location = New System.Drawing.Point(221, 54)
        Me.lbl_team.Name = "lbl_team"
        Me.lbl_team.Size = New System.Drawing.Size(0, 16)
        Me.lbl_team.TabIndex = 35
        Me.lbl_team.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(131, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "User:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(131, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Campaign:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(131, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Team:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(131, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Full Name:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Controls.Add(Me.pb_user_img)
        Me.Panel6.Location = New System.Drawing.Point(12, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(106, 106)
        Me.Panel6.TabIndex = 40
        '
        'pb_user_img
        '
        Me.pb_user_img.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pb_user_img.Location = New System.Drawing.Point(3, 3)
        Me.pb_user_img.Name = "pb_user_img"
        Me.pb_user_img.Size = New System.Drawing.Size(100, 100)
        Me.pb_user_img.TabIndex = 22
        Me.pb_user_img.TabStop = False
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fullname.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fullname.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_fullname.Location = New System.Drawing.Point(221, 75)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(0, 16)
        Me.lbl_fullname.TabIndex = 42
        Me.lbl_fullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_old_pass
        '
        Me.txt_old_pass.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_old_pass.ForeColor = System.Drawing.Color.DimGray
        Me.txt_old_pass.Location = New System.Drawing.Point(143, 21)
        Me.txt_old_pass.MaxLength = 30
        Me.txt_old_pass.Name = "txt_old_pass"
        Me.txt_old_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_old_pass.Size = New System.Drawing.Size(237, 25)
        Me.txt_old_pass.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(16, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Old Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(16, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "New Password:"
        '
        'txt_new_pass
        '
        Me.txt_new_pass.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_pass.ForeColor = System.Drawing.Color.DimGray
        Me.txt_new_pass.Location = New System.Drawing.Point(143, 52)
        Me.txt_new_pass.MaxLength = 30
        Me.txt_new_pass.Name = "txt_new_pass"
        Me.txt_new_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_new_pass.Size = New System.Drawing.Size(237, 25)
        Me.txt_new_pass.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(16, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 16)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Confirm New Pass:"
        '
        'txt_conf_pass
        '
        Me.txt_conf_pass.Font = New System.Drawing.Font("Bookman Old Style", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conf_pass.ForeColor = System.Drawing.Color.DimGray
        Me.txt_conf_pass.Location = New System.Drawing.Point(143, 83)
        Me.txt_conf_pass.MaxLength = 30
        Me.txt_conf_pass.Name = "txt_conf_pass"
        Me.txt_conf_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_conf_pass.Size = New System.Drawing.Size(237, 25)
        Me.txt_conf_pass.TabIndex = 48
        '
        'btn_reset_pass
        '
        Me.btn_reset_pass.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_reset_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reset_pass.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset_pass.ForeColor = System.Drawing.Color.AliceBlue
        Me.btn_reset_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reset_pass.Location = New System.Drawing.Point(236, 116)
        Me.btn_reset_pass.Name = "btn_reset_pass"
        Me.btn_reset_pass.Size = New System.Drawing.Size(144, 32)
        Me.btn_reset_pass.TabIndex = 50
        Me.btn_reset_pass.Text = "Reset Password"
        Me.btn_reset_pass.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(131, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Position:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(131, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(131, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Gender:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(131, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 16)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Birthdate:"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.BackColor = System.Drawing.Color.Transparent
        Me.lbl_position.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_position.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_position.Location = New System.Drawing.Point(221, 95)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(0, 16)
        Me.lbl_position.TabIndex = 55
        Me.lbl_position.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dept
        '
        Me.lbl_dept.AutoSize = True
        Me.lbl_dept.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dept.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dept.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_dept.Location = New System.Drawing.Point(221, 116)
        Me.lbl_dept.Name = "lbl_dept"
        Me.lbl_dept.Size = New System.Drawing.Size(0, 16)
        Me.lbl_dept.TabIndex = 56
        Me.lbl_dept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_gender.Location = New System.Drawing.Point(221, 137)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(0, 16)
        Me.lbl_gender.TabIndex = 57
        Me.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_bday
        '
        Me.lbl_bday.AutoSize = True
        Me.lbl_bday.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bday.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bday.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_bday.Location = New System.Drawing.Point(221, 156)
        Me.lbl_bday.Name = "lbl_bday"
        Me.lbl_bday.Size = New System.Drawing.Size(0, 16)
        Me.lbl_bday.TabIndex = 58
        Me.lbl_bday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_old_pass)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_new_pass)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_conf_pass)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btn_reset_pass)
        Me.GroupBox1.Location = New System.Drawing.Point(-4, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 162)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 337)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_bday)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.lbl_dept)
        Me.Controls.Add(Me.lbl_position)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_fullname)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.lbl_campaign)
        Me.Controls.Add(Me.lbl_team)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(401, 365)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(401, 365)
        Me.Name = "Profile"
        Me.Text = "Profile"
        Me.Panel6.ResumeLayout(False)
        CType(Me.pb_user_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents lbl_campaign As System.Windows.Forms.Label
    Friend WithEvents lbl_team As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pb_user_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_fullname As System.Windows.Forms.Label
    Friend WithEvents txt_old_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_new_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_conf_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_reset_pass As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_position As System.Windows.Forms.Label
    Friend WithEvents lbl_dept As System.Windows.Forms.Label
    Friend WithEvents lbl_gender As System.Windows.Forms.Label
    Friend WithEvents lbl_bday As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
