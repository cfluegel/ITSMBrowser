Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Dim jsonString As String
    Dim jsonData As Object

    Private Sub WebView21_Click(sender As Object, e As EventArgs) Handles WV1.Click

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        WV1.Location = New Point(0, 0)

        Dim NewHeight As Integer = Me.Size.Height - 39
        Dim NewWidth As Integer = Me.Size.Width - 16

        WV1.Size = New Size(NewWidth, NewHeight)
    End Sub

    Private Sub timRefresh_Tick(sender As Object, e As EventArgs) Handles timRefresh.Tick
        WV1.Reload()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        timRefresh.Stop()
    End Sub

    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        timRefresh.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Try to load the configuration file from different places 
        If My.Computer.FileSystem.FileExists(AppDomain.CurrentDomain.BaseDirectory + "ITSMBrowser.json") Then
            jsonString = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "ITSMBrowser.json")
        ElseIf My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ITSMBrowser.json") Then
            jsonString = File.ReadAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\ITSMBrowser.json")
        End If

        ' Try to convert the file contents to a json object 
        Try
            jsonData = JsonConvert.DeserializeObject(Of Object)(jsonString)
        Catch ex As System.ArgumentNullException
            Console.WriteLine("No JSON Data in file!")
        End Try

        ' Read out the configuration and write it to the objects 
        If jsonData.containsKey("url") Then
            WV1.Source = New Uri(jsonData("url").ToString())
        Else
            Console.WriteLine("URL not present!")
        End If
        If jsonData.containsKey("refreshCounter") Then
            timRefresh.Interval = jsonData("refreshCounter").ToString()
        Else
            Console.WriteLine("refreshCounter not present!")
        End If

    End Sub
End Class
