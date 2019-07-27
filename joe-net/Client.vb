Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel

Public Class Client

    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Public t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)

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


    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'verbindungs aufbau
        Try
            client.Connect(Join.IP, Join.Port) ' hier die ip des servers eintragen. 

            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
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


End Class