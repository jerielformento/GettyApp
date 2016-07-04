Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.IO
Imports System.Text

Public Class LoginApp

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim attempt As Integer = 0

    Private Sub LoginApp_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        If UnloadMode = CloseReason.UserClosing Then
            Cancel = cmd_close
        End If
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub LoginApp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub LoginApp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub LoginApp_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW
            Return cParam
        End Get
    End Property

    Private Sub btn_login_Click(sender As System.Object, e As System.EventArgs) Handles btn_login.Click
        userLogin()
    End Sub

    Private Sub LoginApp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmd_close = True
        hasLogs(LOCAL_LOG_PATH)
        userDirectLogin()
        txt_station.Text = Environment.MachineName
        lbl_version.TextAlign = ContentAlignment.MiddleLeft
        lbl_version.Text = versionChecker()
        lbl_site.Text = SITENAME
    End Sub

    Private Sub txt_pwd_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_pwd.KeyUp
        If e.KeyCode = Keys.Enter Then
            If attempt <> 1 Then
                attempt = 1
                userLogin()
            Else
                attempt = 0
            End If
        End If
    End Sub

    Public Sub userLogin()
        Dim user As String
        Dim pass As String
        Dim station As String
        Dim ipaddress As String
        Dim url As String = API_LOGIN_PATH
        user = txt_user.Text
        pass = txt_pwd.Text
        station = getStationName()
        ipaddress = getIpAddress()

        sendRequestAPI(user, pass, station, ipaddress, LOGIN, "", url, LOGIN)
    End Sub

    Public Sub userDirectLogin()
        Dim user As String
        Dim pass As String
        Dim station As String
        Dim ipaddress As String
        Dim url As String = API_DIRECT_LOGIN_PATH
        user = Environment.UserName
        pass = ""
        station = getStationName()
        ipaddress = getIpAddress()

        sendRequestAPI(user, pass, station, ipaddress, LOGIN, "", url, "Direct")
    End Sub
End Class