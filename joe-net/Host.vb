Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel

Public Class Host

    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Public t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)
    Public IP As String
    Public Port As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False

        'server start button
        'server starten
        Try
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp & "\Server_P8888Hidden.exe", My.Resources.Server_P8888Hidden, False)
            Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\Server_P8888Hidden.exe")
        Catch ex As Exception
            MsgBox("Es Läuft Bereits Eine Anwendung mit Port 8888")
        End Try

        'verbindungs variablen
        IP = "127.0.0.1"
        Port = 8888

        'verbindungs aufbau
        Try
            client.Connect(IP, Port) ' hier die ip des servers eintragen. 

            If client.Connected Then
                Stream = client.GetStream
                streamw = New StreamWriter(Stream)
                streamr = New StreamReader(Stream)
                'streamw.WriteLine(nick) ' das ist optional.
                streamw.Flush()
                t.Start()

            End If
        Catch ex As Exception
            MsgBox("Verbindung zu Server Unterbrochenb")
            Try
                t.Interrupt()
                t.Abort()
            Catch exx As Exception
                MsgBox("KURWA")
            End Try
            Close()

        End Try
    End Sub

    'netstream reader
    Private Sub AddItem(ByVal s As String)
        'Dim Empfangen() As String = s.Split("0")

        'Connect
        Try
            MsgBox(s)

            Dim Connect() As String = s.Split(":")

            If Connect(0) = "CON" Then
                'msg

            End If
        Catch ex As Exception
        End Try
        'Weiter....
        'RichTextBox1.Text = RichTextBox1.Text + s + vbCrLf
    End Sub


    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch ex As Exception
                MsgBox("Fail")
                t.Interrupt()
                t.Abort()
                Close()
            End Try
        End While
    End Sub
End Class