<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppForm))
        Me.btnpause = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogsChecker = New System.Windows.Forms.Timer(Me.components)
        Me.lv_msg_inbox = New System.Windows.Forms.ListView()
        Me.pnl_msg = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_from = New System.Windows.Forms.Label()
        Me.lbl_to = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_msg_read = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pb_logout = New System.Windows.Forms.PictureBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.InboxChecker = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TimeManager = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pb_user_photo = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_break_list = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_logged = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_stime = New System.Windows.Forms.Label()
        Me.lbl_tpause = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_sched = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_preshift = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_postshift = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SchedChecker = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_ver = New System.Windows.Forms.Label()
        Me.blk_pnl = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pnl_msg_container = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pb_min = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_logout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.pb_user_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.blk_pnl.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnl_msg_container.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.pb_min, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnpause
        '
        Me.btnpause.BackColor = System.Drawing.Color.SteelBlue
        Me.btnpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpause.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpause.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnpause.Image = CType(resources.GetObject("btnpause.Image"), System.Drawing.Image)
        Me.btnpause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpause.Location = New System.Drawing.Point(267, 1)
        Me.btnpause.Name = "btnpause"
        Me.btnpause.Size = New System.Drawing.Size(138, 45)
        Me.btnpause.TabIndex = 3
        Me.btnpause.Text = "    Break"
        Me.btnpause.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnpause)
        Me.Panel1.Location = New System.Drawing.Point(243, 382)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 48)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(137, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "      Payroll"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "     Profile"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 21)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LogsChecker
        '
        Me.LogsChecker.Interval = 15000
        '
        'lv_msg_inbox
        '
        Me.lv_msg_inbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lv_msg_inbox.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_msg_inbox.Location = New System.Drawing.Point(244, 90)
        Me.lv_msg_inbox.Name = "lv_msg_inbox"
        Me.lv_msg_inbox.Size = New System.Drawing.Size(405, 134)
        Me.lv_msg_inbox.TabIndex = 4
        Me.lv_msg_inbox.UseCompatibleStateImageBehavior = False
        '
        'pnl_msg
        '
        Me.pnl_msg.Location = New System.Drawing.Point(247, 237)
        Me.pnl_msg.Name = "pnl_msg"
        Me.pnl_msg.Size = New System.Drawing.Size(399, 145)
        Me.pnl_msg.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(7, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(7, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "To:"
        '
        'lbl_from
        '
        Me.lbl_from.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lbl_from.AutoSize = True
        Me.lbl_from.BackColor = System.Drawing.Color.Transparent
        Me.lbl_from.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_from.ForeColor = System.Drawing.Color.Black
        Me.lbl_from.Location = New System.Drawing.Point(48, 26)
        Me.lbl_from.Name = "lbl_from"
        Me.lbl_from.Size = New System.Drawing.Size(38, 16)
        Me.lbl_from.TabIndex = 17
        Me.lbl_from.Text = "From"
        '
        'lbl_to
        '
        Me.lbl_to.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lbl_to.AutoSize = True
        Me.lbl_to.BackColor = System.Drawing.Color.Transparent
        Me.lbl_to.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_to.ForeColor = System.Drawing.Color.Black
        Me.lbl_to.Location = New System.Drawing.Point(48, 62)
        Me.lbl_to.Name = "lbl_to"
        Me.lbl_to.Size = New System.Drawing.Size(22, 16)
        Me.lbl_to.TabIndex = 16
        Me.lbl_to.Text = "To"
        '
        'lbl_date
        '
        Me.lbl_date.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_date.Location = New System.Drawing.Point(48, 43)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(34, 16)
        Me.lbl_date.TabIndex = 15
        Me.lbl_date.Text = "date"
        '
        'lbl_title
        '
        Me.lbl_title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbl_title.Location = New System.Drawing.Point(7, 4)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(47, 18)
        Me.lbl_title.TabIndex = 14
        Me.lbl_title.Text = "TITLE"
        '
        'lbl_msg_read
        '
        Me.lbl_msg_read.AutoSize = True
        Me.lbl_msg_read.BackColor = System.Drawing.Color.Transparent
        Me.lbl_msg_read.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg_read.Location = New System.Drawing.Point(11, 96)
        Me.lbl_msg_read.Name = "lbl_msg_read"
        Me.lbl_msg_read.Size = New System.Drawing.Size(60, 16)
        Me.lbl_msg_read.TabIndex = 13
        Me.lbl_msg_read.Text = "message"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Sent:"
        '
        'pb_logout
        '
        Me.pb_logout.BackColor = System.Drawing.Color.Transparent
        Me.pb_logout.BackgroundImage = CType(resources.GetObject("pb_logout.BackgroundImage"), System.Drawing.Image)
        Me.pb_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_logout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_logout.Location = New System.Drawing.Point(622, 6)
        Me.pb_logout.Name = "pb_logout"
        Me.pb_logout.Size = New System.Drawing.Size(26, 26)
        Me.pb_logout.TabIndex = 17
        Me.pb_logout.TabStop = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Gold
        Me.lbl_user.Location = New System.Drawing.Point(217, 13)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(0, 14)
        Me.lbl_user.TabIndex = 18
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InboxChecker
        '
        Me.InboxChecker.Interval = 20000
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_time.Location = New System.Drawing.Point(42, 22)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(40, 16)
        Me.lbl_time.TabIndex = 19
        Me.lbl_time.Text = "12:01"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(9, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(168, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "On Break"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(186, 117)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'TimeManager
        '
        Me.TimeManager.Interval = 30000
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Location = New System.Drawing.Point(3, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 392)
        Me.Panel4.TabIndex = 21
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Controls.Add(Me.pb_user_photo)
        Me.Panel6.Location = New System.Drawing.Point(64, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(106, 106)
        Me.Panel6.TabIndex = 20
        '
        'pb_user_photo
        '
        Me.pb_user_photo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pb_user_photo.Location = New System.Drawing.Point(3, 3)
        Me.pb_user_photo.Name = "pb_user_photo"
        Me.pb_user_photo.Size = New System.Drawing.Size(100, 100)
        Me.pb_user_photo.TabIndex = 22
        Me.pb_user_photo.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.lbl_break_list)
        Me.GroupBox3.Location = New System.Drawing.Point(-1, 285)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 106)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'lbl_break_list
        '
        Me.lbl_break_list.AutoSize = True
        Me.lbl_break_list.BackColor = System.Drawing.Color.Transparent
        Me.lbl_break_list.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_break_list.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbl_break_list.Location = New System.Drawing.Point(11, 19)
        Me.lbl_break_list.Name = "lbl_break_list"
        Me.lbl_break_list.Size = New System.Drawing.Size(0, 16)
        Me.lbl_break_list.TabIndex = 40
        Me.lbl_break_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl_logged)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lbl_stime)
        Me.GroupBox2.Controls.Add(Me.lbl_tpause)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(-1, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(21, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Logged:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Staffed Time Report"
        '
        'lbl_logged
        '
        Me.lbl_logged.AutoSize = True
        Me.lbl_logged.BackColor = System.Drawing.Color.Transparent
        Me.lbl_logged.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_logged.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_logged.Location = New System.Drawing.Point(120, 35)
        Me.lbl_logged.Name = "lbl_logged"
        Me.lbl_logged.Size = New System.Drawing.Size(0, 16)
        Me.lbl_logged.TabIndex = 37
        Me.lbl_logged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(21, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 16)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Staffed Time:"
        '
        'lbl_stime
        '
        Me.lbl_stime.AutoSize = True
        Me.lbl_stime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_stime.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_stime.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_stime.Location = New System.Drawing.Point(120, 56)
        Me.lbl_stime.Name = "lbl_stime"
        Me.lbl_stime.Size = New System.Drawing.Size(0, 16)
        Me.lbl_stime.TabIndex = 38
        Me.lbl_stime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_tpause
        '
        Me.lbl_tpause.AutoSize = True
        Me.lbl_tpause.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tpause.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tpause.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_tpause.Location = New System.Drawing.Point(120, 76)
        Me.lbl_tpause.Name = "lbl_tpause"
        Me.lbl_tpause.Size = New System.Drawing.Size(0, 16)
        Me.lbl_tpause.TabIndex = 39
        Me.lbl_tpause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(21, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Total Pause:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_sched)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_preshift)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_postshift)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Current Schedule"
        '
        'lbl_sched
        '
        Me.lbl_sched.AutoSize = True
        Me.lbl_sched.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sched.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sched.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_sched.Location = New System.Drawing.Point(87, 36)
        Me.lbl_sched.Name = "lbl_sched"
        Me.lbl_sched.Size = New System.Drawing.Size(0, 16)
        Me.lbl_sched.TabIndex = 23
        Me.lbl_sched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(22, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Post:"
        '
        'lbl_preshift
        '
        Me.lbl_preshift.AutoSize = True
        Me.lbl_preshift.BackColor = System.Drawing.Color.Transparent
        Me.lbl_preshift.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_preshift.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_preshift.Location = New System.Drawing.Point(87, 56)
        Me.lbl_preshift.Name = "lbl_preshift"
        Me.lbl_preshift.Size = New System.Drawing.Size(0, 16)
        Me.lbl_preshift.TabIndex = 26
        Me.lbl_preshift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(22, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Pre:"
        '
        'lbl_postshift
        '
        Me.lbl_postshift.AutoSize = True
        Me.lbl_postshift.BackColor = System.Drawing.Color.Transparent
        Me.lbl_postshift.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_postshift.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_postshift.Location = New System.Drawing.Point(87, 76)
        Me.lbl_postshift.Name = "lbl_postshift"
        Me.lbl_postshift.Size = New System.Drawing.Size(0, 16)
        Me.lbl_postshift.TabIndex = 29
        Me.lbl_postshift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(22, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Sched:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(125, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 14)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Logged in as:"
        '
        'SchedChecker
        '
        Me.SchedChecker.Interval = 25000
        '
        'lbl_ver
        '
        Me.lbl_ver.AutoSize = True
        Me.lbl_ver.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ver.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ver.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_ver.Location = New System.Drawing.Point(84, 6)
        Me.lbl_ver.Name = "lbl_ver"
        Me.lbl_ver.Size = New System.Drawing.Size(32, 16)
        Me.lbl_ver.TabIndex = 50
        Me.lbl_ver.Text = "v1.0"
        Me.lbl_ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'blk_pnl
        '
        Me.blk_pnl.Controls.Add(Me.Label1)
        Me.blk_pnl.Controls.Add(Me.PictureBox3)
        Me.blk_pnl.Location = New System.Drawing.Point(245, 84)
        Me.blk_pnl.Name = "blk_pnl"
        Me.blk_pnl.Size = New System.Drawing.Size(402, 298)
        Me.blk_pnl.TabIndex = 51
        Me.blk_pnl.TabStop = False
        Me.blk_pnl.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pnl_msg_container)
        Me.GroupBox4.Location = New System.Drawing.Point(244, 224)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(405, 158)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        '
        'pnl_msg_container
        '
        Me.pnl_msg_container.AutoScroll = True
        Me.pnl_msg_container.Controls.Add(Me.Panel5)
        Me.pnl_msg_container.Controls.Add(Me.lbl_title)
        Me.pnl_msg_container.Controls.Add(Me.lbl_to)
        Me.pnl_msg_container.Controls.Add(Me.Label6)
        Me.pnl_msg_container.Controls.Add(Me.lbl_date)
        Me.pnl_msg_container.Controls.Add(Me.Label2)
        Me.pnl_msg_container.Controls.Add(Me.lbl_from)
        Me.pnl_msg_container.Controls.Add(Me.Label3)
        Me.pnl_msg_container.Controls.Add(Me.lbl_msg_read)
        Me.pnl_msg_container.Location = New System.Drawing.Point(2, 10)
        Me.pnl_msg_container.Name = "pnl_msg_container"
        Me.pnl_msg_container.Padding = New System.Windows.Forms.Padding(0, 0, 0, 40)
        Me.pnl_msg_container.Size = New System.Drawing.Size(402, 148)
        Me.pnl_msg_container.TabIndex = 21
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Location = New System.Drawing.Point(39, 87)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(327, 1)
        Me.Panel5.TabIndex = 54
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_time)
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(244, 39)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(405, 52)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(119, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 39)
        Me.Panel2.TabIndex = 53
        '
        'pb_min
        '
        Me.pb_min.BackColor = System.Drawing.Color.Transparent
        Me.pb_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_min.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_min.Location = New System.Drawing.Point(590, 6)
        Me.pb_min.Name = "pb_min"
        Me.pb_min.Size = New System.Drawing.Size(26, 26)
        Me.pb_min.TabIndex = 55
        Me.pb_min.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.ForeColor = System.Drawing.Color.LightGray
        Me.Panel3.Location = New System.Drawing.Point(596, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(14, 2)
        Me.Panel3.TabIndex = 56
        '
        'TrayIcon
        '
        Me.TrayIcon.BalloonTipText = "Click here to maximize the application."
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Getty"
        Me.TrayIcon.Visible = True
        '
        'AppForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(654, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pb_min)
        Me.Controls.Add(Me.blk_pnl)
        Me.Controls.Add(Me.pnl_msg)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lbl_ver)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.pb_logout)
        Me.Controls.Add(Me.lv_msg_inbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AppForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Getty"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_logout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.pb_user_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.blk_pnl.ResumeLayout(False)
        Me.blk_pnl.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.pnl_msg_container.ResumeLayout(False)
        Me.pnl_msg_container.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.pb_min, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnpause As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogsChecker As System.Windows.Forms.Timer
    Friend WithEvents lv_msg_inbox As System.Windows.Forms.ListView
    Friend WithEvents pb_logout As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_from As System.Windows.Forms.Label
    Friend WithEvents lbl_to As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lbl_msg_read As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnl_msg As System.Windows.Forms.Panel
    Friend WithEvents InboxChecker As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TimeManager As System.Windows.Forms.Timer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pb_user_photo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_sched As System.Windows.Forms.Label
    Friend WithEvents lbl_postshift As System.Windows.Forms.Label
    Friend WithEvents lbl_preshift As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbl_tpause As System.Windows.Forms.Label
    Friend WithEvents lbl_stime As System.Windows.Forms.Label
    Friend WithEvents lbl_logged As System.Windows.Forms.Label
    Friend WithEvents lbl_break_list As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SchedChecker As System.Windows.Forms.Timer
    Friend WithEvents lbl_ver As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents blk_pnl As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnl_msg_container As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pb_min As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon

End Class
