Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Text
Imports System.IO

Module API

    Public Sub sendRequestAPI(
            ByVal getUser As String,
            ByVal getPass As String,
            ByVal getStation As String,
            ByVal getIpaddr As String,
            ByVal getReason As String,
            ByVal getBStatus As String,
            ByVal getUrl As String,
            ByVal type As String
        )

        gettyUser = getUser
        getStation = getStationName()
        getIpaddr = getIpAddress()

        If type = LOGIN Then
            loginRequestAPI(getUser, getPass, 1, "", getStation, getIpaddr, getReason, getUrl, 1, 1)
        ElseIf type = PAUSE Then
            breakRequestAPI(getUser, "", getStation, getIpaddr, getReason, getBStatus, getUrl, 1, 1)
        ElseIf type = LOGOUT Then
            logoutRequestAPI(getUser, "", getStation, getIpaddr, getUrl, 1, 1)
        ElseIf type = "Direct" Then
            directLoginRequestAPI(getUser, getPass, 1, "", getStation, getIpaddr, getReason, getUrl, 1, 1)
        End If

    End Sub

    Private Sub loginRequestAPI(
            ByVal user As String,
            ByVal pass As String,
            ByVal reqpass As String,
            ByVal datetime As String,
            ByVal station As String,
            ByVal ipaddress As String,
            ByVal reason As String,
            ByVal url As String,
            ByVal write As String,
            ByVal alert As Integer
        )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user & "&password=" & pass & "&station=" & station & "&ipaddress=" & ipaddress & "&datetime=" & datetime & "&reqpass=" & reqpass
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)
            If json.SelectToken("success") Then
                gettyUser = user
                gettyIP = ipaddress
                gettyStation = station
                gettyProfile = json.SelectToken("profile").ToString
                If alert = 1 Then
                    'MsgBox(json.SelectToken("message"), vbInformation, "System Message")
                    AppForm.Show()
                    LoginApp.Close()
                End If
            Else
                MsgBox(json.SelectToken("message"), vbCritical, "System Message")
                LoginApp.txt_pwd.Clear()
            End If

            reader.Close()
            dataStream.Close()
            response.Close()

        Catch ex As Exception
            'MsgBox("There's an error in your connection, please try again or contact techsupport. " & ex.ToString, vbCritical, "System Message")
            If write = 1 Then
                writeLocalLogs(user, station, ipaddress, reason, 0, LOGIN)
                AppForm.Show()
                LoginApp.Close()
            End If
        End Try
    End Sub

    Private Sub directLoginRequestAPI(
            ByVal user As String,
            ByVal pass As String,
            ByVal reqpass As String,
            ByVal datetime As String,
            ByVal station As String,
            ByVal ipaddress As String,
            ByVal reason As String,
            ByVal url As String,
            ByVal write As String,
            ByVal alert As Integer
        )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user & "&password=" & pass & "&station=" & station & "&ipaddress=" & ipaddress & "&datetime=" & datetime & "&reqpass=" & reqpass
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)
            If json.SelectToken("success") Then
                gettyUser = user
                gettyIP = ipaddress
                gettyStation = station
                gettyProfile = json.SelectToken("profile").ToString
                If alert = 1 Then
                    'MsgBox(json.SelectToken("message"), vbInformation, "System Message")
                    AppForm.Show()
                    LoginApp.Close()
                End If
            Else
                'MsgBox(json.SelectToken("message"), vbCritical, "System Message")
                'LoginApp.txt_pwd.Clear()
            End If

            reader.Close()
            dataStream.Close()
            response.Close()

        Catch ex As Exception
            'MsgBox("There's an error in your connection, please try again or contact techsupport. " & ex.ToString, vbCritical, "System Message")
            If write = 1 Then
                writeLocalLogs(user, station, ipaddress, reason, 0, LOGIN)
                AppForm.Show()
                LoginApp.Close()
            End If
        End Try
    End Sub

    Private Sub logoutRequestAPI(
            ByVal user As String,
            ByVal datetime As String,
            ByVal station As String,
            ByVal ipaddress As String,
            ByVal url As String,
            ByVal write As String,
            ByVal alert As Integer
        )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user & "&station=" & station & "&ipaddress=" & ipaddress & "&datetime=" & datetime
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            'If responseFromServer = "0" Then
            '    MsgBox("Login Failed")
            'Else
            'MsgBox(responseFromServer)
            Dim json As JObject = JObject.Parse(responseFromServer)
            If json.SelectToken("success") Then
                If alert = 1 Then
                    gettyUser = user
                    MsgBox(json.SelectToken("message"), vbInformation, "System Message")
                    cmd_close = False
                    AppForm.Close()
                End If
            Else
                MsgBox(json.SelectToken("message"), vbCritical, "System Message")
            End If
            'End If
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            'MsgBox("There's an error in your connection, please try again or contact techsupport.", vbCritical, "System Message")
            If write = 1 Then
                gettyUser = user
                writeLocalLogs(user, station, ipaddress, NOREASON, 1, LOGOUT)
                cmd_close = False
                AppForm.Close()
            End If
        End Try
    End Sub

    Private Sub breakRequestAPI(
            ByVal user As String,
            ByVal datetime As String,
            ByVal station As String,
            ByVal ipaddress As String,
            ByVal reason As String,
            ByVal bstatus As String,
            ByVal url As String,
            ByVal write As String,
            ByVal alert As Integer
        )

        If write = 1 Then
            bstatus = breakStatus
        End If

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user & "&station=" & station & "&ipaddress=" & ipaddress & "&reason=" & reason & "&status=" & bstatus & "&datetime=" & datetime
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)

            If json.SelectToken("success") Then
                If alert = 1 Then
                    If breakStatus = 0 Then
                        breakReason = reason
                        breakStatus = 1
                        AppForm.TopMost = True
                        AppForm.btnpause.Text = "    Resume"
                        AppForm.blk_pnl.Visible = True
                        AppForm.pb_logout.Enabled = False
                    Else
                        breakReason = ""
                        breakStatus = 0
                        AppForm.TopMost = False
                        AppForm.btnpause.Text = "    Break"
                        AppForm.blk_pnl.Visible = False
                        AppForm.pb_logout.Enabled = True
                    End If

                    MsgBox(json.SelectToken("message"), vbInformation, "System Message")
                    BreakApp.Close()
                End If
            Else
                MsgBox(json.SelectToken("message"), vbCritical, "System Message")
            End If

            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            'MsgBox("There's an error in your connection, please try again or contact techsupport." & ex.ToString, vbCritical, "System Message")
            If write = 1 Then
                writeLocalLogs(user, station, ipaddress, reason, bstatus, PAUSE)
                If breakStatus = 0 Then
                    breakReason = reason
                    breakStatus = 1
                    AppForm.btnpause.Text = "    Resume"
                Else
                    breakReason = ""
                    breakStatus = 0
                    AppForm.btnpause.Text = "    Break"
                End If
                BreakApp.Close()
            End If
        End Try
    End Sub

    Public Sub messageRequestAPI(
            ByVal user As String,
            ByVal url As String,
            ByVal id As String
        )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user & "&id=" & id
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)
            If Integer.Parse(json.SelectToken("count")) >= 1 Then
                Dim scount As Integer = 1
                Dim mcount As Integer = Integer.Parse(json.SelectToken("count").ToString)

                If msgCounter < mcount Then
                    msgCounter = mcount
                    NewMessage.Show()
                End If

                For scount = 0 To mcount - 1
                    'MsgBox(json.SelectToken("list")(scount)("title"), vbInformation, "System Message")
                    If Integer.Parse(json.SelectToken("list")(scount)("read")) = 1 Then
                        With AppForm.lv_msg_inbox.Items.Add(json.SelectToken("list")(scount)("msg_id"))
                            '.Font = New Font(AppForm.lv_msg_inbox.Font, FontStyle.Bold)
                            .SubItems.Add(json.SelectToken("list")(scount)("title")) '.Font = New Font(AppForm.lv_msg_inbox.Font, FontStyle.Bold)
                            .SubItems.Add(json.SelectToken("list")(scount)("datecreated")) '.Font = New Font(AppForm.lv_msg_inbox.Font, FontStyle.Bold)
                        End With
                    Else
                        With AppForm.lv_msg_inbox.Items.Add(json.SelectToken("list")(scount)("msg_id"))
                            .Font = New Font(AppForm.lv_msg_inbox.Font, FontStyle.Bold)
                            .SubItems.Add(json.SelectToken("list")(scount)("title")).Font = New Font(AppForm.lv_msg_inbox.Font, FontStyle.Bold)
                            .SubItems.Add(json.SelectToken("list")(scount)("datecreated")).Font = New Font(AppForm.lv_msg_inbox.Font, FontStyle.Bold)
                        End With
                    End If
                Next
            Else
                'MsgBox(json.SelectToken("message"), vbCritical, "System Message")
            End If

            reader.Close()
            dataStream.Close()
            response.Close()

        Catch ex As Exception
            'MsgBox("There's an error in your connection unable to fetch the data. ", vbCritical, "System Message")
        End Try
    End Sub

    Public Sub getMessageRequestAPI(
            ByVal user As String,
            ByVal url As String,
            ByVal id As String
        )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user & "&id=" & id
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)
            If Integer.Parse(json.SelectToken("count")) >= 1 Then
                Dim scount As Integer = 1
                Dim mcount As Integer = Integer.Parse(json.SelectToken("count").ToString)
                For scount = 0 To mcount - 1
                    'AppForm.lbl_msg_read.Text = WordWrap(json.SelectToken("list")(scount)("content").ToString & Environment.NewLine & Environment.NewLine, 45)
                    AppForm.lbl_msg_read.Text = json.SelectToken("list")(scount)("content").ToString & Environment.NewLine & Environment.NewLine
                    AppForm.lbl_from.Text = json.SelectToken("list")(scount)("author").ToString
                    AppForm.lbl_to.Text = json.SelectToken("list")(scount)("to").ToString
                    AppForm.lbl_title.Text = json.SelectToken("list")(scount)("title").ToString
                    AppForm.lbl_date.Text = json.SelectToken("list")(scount)("datecreated").ToString
                Next
            Else
                'MsgBox(json.SelectToken("message"), vbCritical, "System Message")
            End If

            reader.Close()
            dataStream.Close()
            response.Close()

        Catch ex As Exception
            MsgBox("There's an error in your connection unable to fetch the data. ", vbCritical, "System Message")
        End Try
    End Sub

    Public Sub addLogsRequestAPI(
            ByVal user As String,
            ByVal datetime As String,
            ByVal ipaddress As String,
            ByVal station As String,
            ByVal status As String,
            ByVal reason As String,
            ByVal type As String,
            ByVal alert As Integer
        )

        Dim url As String

        If type = LOGIN Then
            url = API_LOGIN_PATH
        ElseIf type = LOGOUT Then
            url = API_LOGOUT_PATH
        ElseIf type = PAUSE Then
            url = API_PAUSE_PATH
        End If

        If type = LOGIN Then
            loginRequestAPI(user, "", 0, datetime, station, ipaddress, reason, API_LOGIN_PATH, 0, alert)
        ElseIf type = PAUSE Then
            breakRequestAPI(user, datetime, station, ipaddress, status, reason, API_PAUSE_PATH, 0, alert)
        ElseIf type = LOGOUT Then
            logoutRequestAPI(user, datetime, station, ipaddress, API_LOGOUT_PATH, 0, alert)
        End If
    End Sub

    Public Function checkConnectionAPI(
            ByVal user As String,
            ByVal url As String
        )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            reader.Close()
            dataStream.Close()
            response.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub getRequestTimeAPI(
           ByVal url As String
       )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & gettyUser
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)
            AppForm.lbl_time.Text = json.SelectToken("time").ToString
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            'MsgBox("There's an error in your connection unable to fetch the data. ", vbCritical, "System Message")
        End Try
    End Sub

    Public Sub getRequestScheduleAPI(
        ByVal url As String,
        ByVal user As String
    )
        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            'MsgBox(responseFromServer)
            Dim json As JObject = JObject.Parse(responseFromServer)

            If Integer.Parse(json.SelectToken("count")) >= 1 Then
                Dim scount As Integer = 1
                Dim mcount As Integer = Integer.Parse(json.SelectToken("count").ToString)
                For scount = 0 To mcount - 1
                    AppForm.lbl_sched.Text = json.SelectToken("sched")(scount)("sched_st").ToString & " - " & json.SelectToken("sched")(scount)("sched_en").ToString

                    'MsgBox(json.SelectToken("staff")(scount)("break").ToString)
                    If String.IsNullOrEmpty(json.SelectToken("sched")(scount)("pre_st").ToString) = False Then
                        AppForm.lbl_preshift.Text = json.SelectToken("sched")(scount)("pre_st").ToString & " - " & json.SelectToken("sched")(scount)("pre_en").ToString
                    Else
                        AppForm.lbl_preshift.Text = "N/A"
                    End If

                    If String.IsNullOrEmpty(json.SelectToken("sched")(scount)("post_st").ToString) = False Then
                        AppForm.lbl_postshift.Text = json.SelectToken("sched")(scount)("post_st").ToString & " - " & json.SelectToken("sched")(scount)("post_en").ToString
                    Else
                        AppForm.lbl_postshift.Text = "N/A"
                    End If

                    If String.IsNullOrEmpty(json.SelectToken("staff")(scount)("logged").ToString) = False Then
                        AppForm.lbl_logged.Text = json.SelectToken("staff")(scount)("logged").ToString
                    Else
                        AppForm.lbl_logged.Text = "N/A"
                    End If

                    If String.IsNullOrEmpty(json.SelectToken("staff")(scount)("stime").ToString) = False Then
                        AppForm.lbl_stime.Text = json.SelectToken("staff")(scount)("stime").ToString
                    Else
                        AppForm.lbl_stime.Text = "N/A"
                    End If

                    If String.IsNullOrEmpty(json.SelectToken("staff")(scount)("tpause").ToString) = False Then
                        AppForm.lbl_tpause.Text = json.SelectToken("staff")(scount)("tpause").ToString
                    Else
                        AppForm.lbl_tpause.Text = "N/A"
                    End If
                    Dim aryTextFile() As String
                    aryTextFile = json.SelectToken("staff")(scount)("break").ToString.Split("|")
                    AppForm.lbl_break_list.Text = ""
                    For i = 0 To UBound(aryTextFile)
                        AppForm.lbl_break_list.Text &= aryTextFile(i).ToString & Environment.NewLine
                    Next i
                    AppForm.lbl_break_list.Text &= Environment.NewLine
                Next

                'AppForm.pnl_msg.Visible = False
            Else
                'MsgBox(json.SelectToken("message"), vbCritical, "System Message")
            End If

            reader.Close()
            dataStream.Close()
            response.Close()

        Catch ex As Exception
            'MsgBox("There's an error in your connection unable to fetch the data." & ex.ToString, vbCritical, "System Message")
        End Try
    End Sub

    Public Sub resetPasswordRequestAPI(
            ByVal user As String,
            ByVal oldpass As String,
            ByVal newpass As String,
            ByVal confpass As String,
            ByVal url As String
        )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user & "&old_pass=" & oldpass & "&new_pass=" & newpass & "&conf_pass=" & confpass
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)

            If json.SelectToken("success") Then
                Profile.txt_old_pass.Clear()
                Profile.txt_new_pass.Clear()
                Profile.txt_conf_pass.Clear()
                MsgBox(json.SelectToken("message"), vbInformation, "System Message")
            Else
                MsgBox(json.SelectToken("message"), vbCritical, "System Message")
            End If

            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            MsgBox("There's an error in your connection please try again later. ", vbCritical, "System Message")
        End Try
    End Sub

    Public Sub getUserInfoRequestAPI(
            ByVal user As String,
            ByVal url As String
        )

        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        Dim postData As String
        postData = "username=" & user
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length

        Try
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()

            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()

            Dim json As JObject = JObject.Parse(responseFromServer)

            If Integer.Parse(json.SelectToken("count")) >= 1 Then
                Dim scount As Integer = 1
                Dim mcount As Integer = Integer.Parse(json.SelectToken("count").ToString)
                For scount = 0 To mcount - 1
                    Profile.lbl_user.Text = json.SelectToken("profile")(0)("user").ToString
                    Profile.lbl_campaign.Text = json.SelectToken("profile")(0)("camp").ToString
                    Profile.lbl_team.Text = json.SelectToken("profile")(0)("team").ToString
                    Profile.lbl_fullname.Text = json.SelectToken("profile")(0)("fullname").ToString
                    Profile.lbl_position.Text = json.SelectToken("profile")(0)("pos").ToString
                    Profile.lbl_dept.Text = json.SelectToken("profile")(0)("dept").ToString
                    Profile.lbl_gender.Text = json.SelectToken("profile")(0)("gender").ToString
                    Profile.lbl_bday.Text = json.SelectToken("profile")(0)("bday").ToString
                Next
                'MsgBox(json.SelectToken("message"), vbInformation, "System Message")
            Else
                'MsgBox(json.SelectToken("message"), vbCritical, "System Message")
            End If

            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            MsgBox("There's an error in your connection please try again later." & ex.ToString, vbCritical, "System Message")
        End Try
    End Sub

End Module
