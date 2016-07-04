Imports System.IO

Module LocalHandler

    Private LOCAL_LOGS_PATH As String = "C:\CollectiveSolution\Getty\logs.txt"
    Private VERSION_LOG As String = "C:\CollectiveSolution\Getty\vupdate.txt"

    Public Function versionChecker() As String
        Dim vRead As String
        If System.IO.File.Exists(VERSION_LOG) = True Then
            Dim lines() As String = System.IO.File.ReadAllLines(VERSION_LOG)
            Dim readLine = lines(lines.Length - 1)
            vRead = readLine
        Else
            MessageBox.Show("File Does Not Exist")
        End If

        Return vRead
    End Function

    Public Sub writeLocalLogs(
            ByVal user As String,
            ByVal station As String,
            ByVal ipaddress As String,
            ByVal reason As String,
            ByVal bstatus As String,
            ByVal type As String
        )

        Dim file As String = LOCAL_LOGS_PATH
        Dim Writer As New System.IO.StreamWriter(file, True)
        Writer.WriteLine(user & "," & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "," & Environment.MachineName & "," & reason & "," & bstatus & "," & type & "," & ipaddress)
        Writer.Close()
    End Sub

    Public Sub extractLogs()
        Dim getall As String = ""
        Dim filename As String = LOCAL_LOGS_PATH
        Dim Reader As New System.IO.StreamReader(filename, True)
        Dim count_explode As Integer = 1
        Dim user As String
        Dim datetime As String
        Dim pcname As String
        Dim status As String
        Dim reason As String
        Dim type As String
        Dim ipaddress As String

        Dim conn As Boolean = checkConnectionAPI(Environment.UserName, API_LOGIN_PATH)

        If conn = True Then
            Dim lineCount = File.ReadAllLines(filename).Length
            Dim line_counter As Integer = 1
            Do While Reader.Peek() <> -1
                Dim words = Reader.ReadLine()
                Dim boom = words.Split(New Char() {","c})
                If words <> "" Then
                    For Each boo In boom
                        getall += "" & boo & ","
                    Next
                End If

                Dim splitStr = getall.Remove(getall.Length - 1).Split(",")
                user = splitStr(0)
                datetime = splitStr(1)
                pcname = splitStr(2)
                status = splitStr(3)
                reason = splitStr(4)
                type = splitStr(5)
                ipaddress = getIpAddress()

                ' send information to API and insert into the database
                addLogsRequestAPI(user, datetime, ipaddress, pcname, status, reason, type, 0)

                getall = ""
                count_explode = 1
                line_counter = line_counter + 1
            Loop
            Reader.Close()
            System.IO.File.WriteAllText(LOCAL_LOG_PATH, "")
        End If
    End Sub

    Public Sub hasLogs(ByVal path As String)
        If File.ReadAllText(path).Length = 0 Then
        Else
            extractLogs()
        End If
    End Sub

    Public Sub deleteLogs(ByVal line As Integer)
        Dim lines As List(Of String) = System.IO.File.ReadAllLines(LOCAL_LOGS_PATH).ToList
        lines.RemoveAt(line - 1) ' index starts at 0 
        System.IO.File.WriteAllLines(LOCAL_LOGS_PATH, lines)
    End Sub
End Module
