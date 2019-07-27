Imports System
Imports System.IO
Imports System.Text
Imports System.Environment



Public Class Hauptmenue
    'Variabeln ...
    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Public YourPath As String = appData + "\Joe-Apps\Profil"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Create Path
        If (Not System.IO.Directory.Exists(YourPath)) Then
            System.IO.Directory.CreateDirectory(YourPath)
        End If
        'Check Porfiel data

        If (Not System.IO.File.Exists(YourPath + "\pro.joe")) Then
            fmsg_Pro.Show()
        Else
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(YourPath + "\pro.joe")
            Dim pro() As String = fileReader.Split(";")
            L_NAME.Text = pro(1)
            L_SN.Text = pro(0)

        End If







    End Sub

    Private Sub Button_Beenden_Click(sender As Object, e As EventArgs) Handles Button_Beenden.Click
        Me.Close()
    End Sub

    Private Sub Button_Optionen_Click(sender As Object, e As EventArgs) Handles Button_Optionen.Click
        optionen.Show()

    End Sub

    Private Sub Button_Spielen_Click(sender As Object, e As EventArgs) Handles Button_Spielen.Click
        Host_Client.Show()

    End Sub
End Class
