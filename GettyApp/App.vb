Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class AppForm

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public userName As String
    Public compName As String

    Private Sub LoginApp_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        If UnloadMode = CloseReason.UserClosing Then
            Cancel = cmd_close
        End If
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub AppForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub AppForm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub AppForm_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub AppForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'readUserLogs("\\s1-smb.csi.lan\LogInLogOutLogs\Login\Logs\" & Environment.UserName & ".log")
        Main()
        lbl_ver.AutoSize = False
        lbl_ver.TextAlign = ContentAlignment.MiddleLeft
        lbl_ver.Text = versionChecker()
        pb_user_photo.Image = Image.FromFile(LOCAL_USER_IMG_PATH & gettyProfile)
        getRequestTimeAPI(API_TZ_PATH)
        getRequestScheduleAPI(API_SCHED_PATH, gettyUser)
        TimeManager.Start()
        lbl_user.Text = gettyUser
        displayMessages()
        cmd_close = False
        LoginApp.Close()
        cmd_close = True
        LogsChecker.Start()
        InboxChecker.Start()
        SchedChecker.Start()
        pnl_msg.Visible = True
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW
            Return cParam
        End Get
    End Property

    Sub readUserLogs(ByVal textFile As String)

        Dim loginTime As String
        Dim loginDate As String

        'Dim fileReader As System.IO.StreamReader
        'fileReader =
        'My.Computer.FileSystem.OpenTextFileReader(file)
        'Dim stringReader As String
        'stringReader = fileReader.ReadLine()
        'MsgBox("The first line of the file is " & stringReader)
        Dim FILE_NAME As String = textFile

        'Dim TextLine As String

        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim lines() As String = System.IO.File.ReadAllLines(FILE_NAME)
            Dim splitStr = lines(lines.Length - 1).Split(",")
            'TextBox1.Text = lines(lines.Length - 1)
            userName = splitStr(2)
            compName = splitStr(1)
            loginDate = splitStr(3)
            loginTime = splitStr(4)
            loginTime = loginTime.Split(".")(0)
            loginDate = loginDate.Split(" ")(1)
            loginDate = loginDate.Split("/")(2) & "-" & loginDate.Split("/")(0) & "-" & loginDate.Split("/")(1)

            MsgBox(userName & "','" & loginDate & " " & loginTime & "',1,'" & getIpAddress())
            'Dim rs As Boolean = execNonQuery("INSERT INTO tbl_test (username,datetime,log_type,ip_addr) VALUES('" & userName & "','" & loginDate & " " & loginTime & "',1,'" & getIpAddress() & "')")
            'For Each fern As String In splitStr
            '    MsgBox(fern)
            'Next
        Else
            MsgBox("File Doesn't Exist", vbExclamation, "System Message")
        End If

        'If System.IO.File.Exists(FILE_NAME) = True Then
        '    Dim objReader As New System.IO.StreamReader(FILE_NAME)
        '    Do While objReader.Peek() <> -1
        '        TextLine = TextLine & objReader.ReadLine() & vbNewLine
        '    Loop
        '    Textbox1.Text = TextLine
        'Else
        '    MessageBox.Show("File Does Not Exist")
        'End If
    End Sub

    Private Sub btnpause_Click(sender As System.Object, e As System.EventArgs) Handles btnpause.Click
        Dim pauseText As String = btnpause.Text.Replace(" ", "")

        If pauseText = "Break" Then
            BreakApp.StartPosition = FormStartPosition.CenterParent
            BreakApp.ShowDialog(Me)
        ElseIf pauseText = "Resume" Then
            If MsgBox("Do you want to end your break ?", vbQuestion + vbYesNo, "System Message") = vbYes Then
                BreakApp.takingBreak()
            End If
        End If
    End Sub

    Public Sub logViewer(ByVal user As String)
        'getFieldRow("SELECT campaign_id,team_id FROM tbl_agents WHERE agent='" & agent & "' AND this_site='" & conn_location & "' AND archived='0' ORDER BY 1 DESC LIMIT 1")
        'getFieldRow("SELECT * FROM tbl_users WHERE user_username='" & user & "'", "computer")
    End Sub

    Public Sub displayMessages()
        lv_msg_inbox.FullRowSelect = True
        lv_msg_inbox.View = View.Details
        lv_msg_inbox.Items.Clear()
        lv_msg_inbox.Columns.Clear()
        lv_msg_inbox.Columns.Add("ID", 60, HorizontalAlignment.Left)
        lv_msg_inbox.Columns.Add("Subject", 140, HorizontalAlignment.Left)
        lv_msg_inbox.Columns.Add("Received", 200, HorizontalAlignment.Left)
        messageRequestAPI(gettyUser, API_MSG_PATH, 0)
        For Each lvi As ListViewItem In lv_msg_inbox.Items
            lvi.UseItemStyleForSubItems = False
        Next
        lv_msg_inbox.View = View.Details
    End Sub

    Private Sub LogsChecker_Tick(sender As System.Object, e As System.EventArgs) Handles LogsChecker.Tick
        hasLogs(LOCAL_LOG_PATH)
    End Sub

    Private Sub pb_logout_Click(sender As System.Object, e As System.EventArgs) Handles pb_logout.Click
        If MsgBox("Do you want to exit Getty ?", vbQuestion + vbYesNo, "System Message") = vbYes Then
            Dim user As String
            Dim station As String
            Dim ipaddress As String
            user = gettyUser
            station = getStationName()
            ipaddress = getIpAddress()

            sendRequestAPI(user, "", station, ipaddress, "", "", API_LOGOUT_PATH, LOGOUT)
        End If
    End Sub

    Private Sub lv_msg_inbox_Click(sender As Object, e As System.EventArgs) Handles lv_msg_inbox.Click
        If Me.lv_msg_inbox.SelectedIndices.Count > 0 Then
            Dim Pos As Integer = Me.lv_msg_inbox.SelectedIndices(0)
            Me.lv_msg_inbox.Items.Item(Me.lv_msg_inbox.SelectedIndices(0)).Font = New System.Drawing.Font("Bookman Old Style", 8)
            Me.lv_msg_inbox.Items.Item(Me.lv_msg_inbox.SelectedIndices(0)).SubItems(1).Font = New System.Drawing.Font("Bookman Old Style", 8)
            Me.lv_msg_inbox.Items.Item(Me.lv_msg_inbox.SelectedIndices(0)).SubItems(2).Font = New System.Drawing.Font("Bookman Old Style", 8)
        End If

        Dim id As Integer = lv_msg_inbox.Items(lv_msg_inbox.SelectedIndices(0)).Text()
        'MsgBox(id)
        getMessageRequestAPI(gettyUser, API_MSG_PATH, id)
        pnl_msg.Visible = False
    End Sub

    Private Sub InboxChecker_Tick(sender As System.Object, e As System.EventArgs) Handles InboxChecker.Tick
        displayMessages()
    End Sub

    Private Sub TimeManager_Tick(sender As System.Object, e As System.EventArgs) Handles TimeManager.Tick
        getRequestTimeAPI(API_TZ_PATH)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Profile.StartPosition = FormStartPosition.CenterParent
        Profile.ShowDialog(Me)
    End Sub

    Private Sub SchedChecker_Tick(sender As System.Object, e As System.EventArgs) Handles SchedChecker.Tick
        getRequestScheduleAPI(API_SCHED_PATH, gettyUser)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Coming soon ..", vbInformation, "System Message")
    End Sub

    Private Sub pb_min_Click(sender As System.Object, e As System.EventArgs) Handles pb_min.Click
        TrayIcon.ShowBalloonTip(1)
        Me.Hide()
    End Sub

    Private Sub TrayIcon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrayIcon.Click
        Me.Show()
    End Sub
End Class
