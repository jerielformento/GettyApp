Module ImageControl
    'The function below is extensively commented
    'as it is expected to be a tutorial to itself.
    'Why? I hate to see all those text in between
    'code examples which makes it impossible to
    'copy-paste the stuff and make it work.
    'Thought I would rather care for the sentiments
    'of like minds ;)


    'Name   :   GetImage
    'Input  :   URL, a String variable holding the URL of the image. Type: System.String
    'Output :   An image containing the image located at the URL. Type: System.Drawing.Image
    Function GetImage(ByVal URL As String) As System.Drawing.Image
        'You would require a Request object to send the
        'request to the web server holding this image.
        'Let us call it 'Request', juz for simplicity.
        Dim Request As System.Net.HttpWebRequest
        'And, ofcourse, a Response object to hold the
        'return chunk of data from the web server
        Dim Response As System.Net.HttpWebResponse


        'Now we need to actually ask the web server
        'for the image we want.
        Try
            'Creating the Request object is the first step of 'asking'
            Request = System.Net.WebRequest.Create(URL)
            'Actually this line can be split into two.
            'The first part is Request.GetResponse
            'which actually go about requesting for the
            'resource pointed to by the URL
            'The second step is casting it to the proper
            'type and assigning it to our Response object.
            Response = CType(Request.GetResponse, System.Net.WebResponse)

            If Request.HaveResponse Then 'Did we really get a response?
                If Response.StatusCode = Net.HttpStatusCode.OK Then 'Is the status code 200? (You can check for more)
                    'So we have a response and it is an OK response.
                    'Now we can go about loading it to the output
                    'We know that the response (if OK) would contain
                    'an image. So load it to the function return, by
                    'using the static conversion function FromStream
                    'of the Image class. FromStream creates an Image out
                    'of a stream. Isn't that nice of FromStream? ;)
                    GetImage = System.Drawing.Image.FromStream(Response.GetResponseStream)
                End If
            End If
            'What follows is the bad part... catching exceptions.
            'May his soul rest in peace if code flow comes to this part!
        Catch e As System.Net.WebException
            MsgBox("A web exception has occured [" & URL & "]." & vbCrLf & " System returned: " & e.Message, MsgBoxStyle.Exclamation, "Error!")
            Exit Try
        Catch e As System.Net.ProtocolViolationException
            MsgBox("A protocol violation has occured [" & URL & "]." & vbCrLf & "  System returned: " & e.Message, MsgBoxStyle.Exclamation, "Error!")
            Exit Try
        Catch e As System.Net.Sockets.SocketException
            MsgBox("Socket error [" & URL & "]." & vbCrLf & "  System returned: " & e.Message, MsgBoxStyle.Exclamation, "Error!")
            Exit Try
        Catch e As System.IO.EndOfStreamException
            MsgBox("An IO stream exception has occured. System returned: " & e.Message, MsgBoxStyle.Exclamation, "Error!")
            Exit Try
        Finally
        End Try
    End Function


    'Now am supposed to tell you how to save that stuff, aint I?
    'Thatz easy, coz Image has a Save method on it :)
    '(boy, these ppl have made some things really easy with .Net!)
    Sub Main()
        'Create an Image object to hold the return of GetImage function
        Dim MyImage As System.Drawing.Image

        'We need an image.. letz select the most popular image on planet ;)
        Dim URL As String = API_USER_IMG_PATH & gettyProfile

            'Not really related with getting the image
            'Just stripping out the filename from the URL so that
            'it can be saved with the same name
            Dim FileName As String, URLpieces As String()
            URLpieces = Split(URL, "/")
            FileName = URLpieces.GetValue(UBound(URLpieces))
            'Calling our dear function to return the Image
            MyImage = GetImage(URL)
            'Save the image
            MyImage.Save(FileName)
            MyImage = Nothing
    End Sub
End Module