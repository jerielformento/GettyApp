Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class BreakApp

    Private Sub BreakApp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        displayPauses()
    End Sub

    Public Sub displayPauses()
        Dim user As String = ""
        Dim request As WebRequest = WebRequest.Create("http://172.16.0.76:8081/api/app/pauses_list.php")
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
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            'If responseFromServer = "0" Then
            '    MsgBox("Login Failed")
            'Else
            'MsgBox(responseFromServer)
            Dim str As String
            Dim strArr() As String
            Dim count As Integer
            str = responseFromServer
            strArr = str.Split(",")
            cb_pauses.Items.Clear()

            For count = 0 To strArr.Length - 1
                cb_pauses.Items.Add(strArr(count))
            Next
            reader.Close()
            dataStream.Close()
            response.Close()
        Catch ex As Exception
            'MsgBox("There's an error in your connection, please try again or contact techsupport. " & ex.ToString, vbCritical, "System Message")
        End Try
    End Sub

    Private Sub btn_break_Click(sender As System.Object, e As System.EventArgs) Handles btn_break.Click
        takingBreak()
    End Sub

    Public Sub takingBreak()
        Dim user As String
        Dim url As String = API_PAUSE_PATH
        Dim station As String
        Dim ipaddress As String
        Dim reason As String
        Dim bstatus As Integer
        user = gettyUser
        station = getStationName()
        ipaddress = getIpAddress()
        reason = cb_pauses.Text
        breakReason = reason

        bstatus = breakStatus
        If reason = "" Then
            MsgBox("Please select your reason to take a break.", vbExclamation, "System Message")
        Else
            sendRequestAPI(user, "", station, ipaddress, reason, bstatus, url, PAUSE)
            AppForm.BringToFront()
        End If
    End Sub
End Class