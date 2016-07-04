Imports System.Net

Module Helper

    ' User info
    Public gettyIP As String
    Public gettyUser As String
    Public gettyStation As String
    Public gettyProfile As String
    Public breakReason As String = ""
    Public breakStatus As Integer = 0

    Public cmd_close As Boolean
    Public msgCounter As Integer = 0

    ' Log type
    Public LOGIN As String = "Login"
    Public LOGOUT As String = "Logout"
    Public PAUSE As String = "Break"
    Public NOREASON As String = "None"

    ' site location
    Public SITENAME As String = "Quezon"

    ' local path
    Public LOCAL_LOG_PATH As String = "C:\CollectiveSolution\Getty\logs.txt"
    Public LOCAL_USER_IMG_PATH As String = "C:\CollectiveSolution\Getty\"
    ' FILE url path
    Public API_USER_IMG_PATH As Object = "http://172.16.0.76:8082/images/profiles/"
    Public API_CHECK_URL_PATH As String = "http://172.16.0.76:8082/api/app/check_url.php"
    ' API url path
    Public API_DIRECT_LOGIN_PATH As String = "http://172.16.0.76:8081/api/app/directlogin.php"
    Public API_LOGIN_PATH As String = "http://172.16.0.76:8081/api/app/login.php"
    Public API_LOGOUT_PATH As String = "http://172.16.0.76:8081/api/app/logout.php"
    Public API_PAUSE_PATH As String = "http://172.16.0.76:8081/api/app/break.php"
    Public API_MSG_PATH As String = "http://172.16.0.76:8081/api/app/messages_list.php"
    Public API_TZ_PATH As String = "http://172.16.0.76:8081/api/app/get_server_time.php"
    Public API_SCHED_PATH As String = "http://172.16.0.76:8081/api/app/get_user_schedules.php"
    Public API_RESPASS_PATH As String = "http://172.16.0.76:8081/api/app/reset_password.php"
    Public API_USER_INFO_PATH As String = "http://172.16.0.76:8081/api/app/get_user_information.php"

    Public Sub techSupportCritical(Optional ByVal msg As String = "")
        If msg = "" Then
            msg = "Cannot connect to server, please try again or contact techsupport."
        End If
        MsgBox(msg, MsgBoxStyle.OkOnly, "System Message")
    End Sub

    Public Function getIpAddress() As String
        'Dim ipAddress As IPAddress
        'Dim ipHostInfo As IPHostEntry = Dns.Resolve(Dns.GetHostName())
        'ipAddress = ipHostInfo.AddressList(0)
        'gettyIP = ipAddress.ToString
        'Return gettyIP
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        gettyIP = strIPAddress
        Return gettyIP
    End Function

    Public Function getStationName() As String
        Return Environment.MachineName
    End Function

    Function WordWrap(ByVal Text As String, Optional ByVal MaxLineLen As Integer = 70)
        Dim i As Integer
        For i = 1 To Len(Text) / MaxLineLen
            Text = Mid(Text, 1, MaxLineLen * i - 1) & Replace(Text, " ", vbCrLf, MaxLineLen * i, 1, vbTextCompare)
        Next i
        WordWrap = Text
    End Function

End Module
