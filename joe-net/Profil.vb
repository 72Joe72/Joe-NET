Public Class Profil
    Private Sub Button_Spielen_Click(sender As Object, e As EventArgs) Handles Button_Spielen.Click
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(Hauptmenue.YourPath + "\pro.joe")
        Dim pro() As String = fileReader.Split(";")
        MsgBox("Seriennummer: " + pro(0) + vbCrLf + "Name: " + pro(1))
    End Sub

    Private Sub Button_Optionen_Click(sender As Object, e As EventArgs) Handles Button_Optionen.Click
        Select Case MessageBox.Show("Wenn du ein neues Profiel erstellst wird das alte ersetzt" + vbCrLf + "willst du dennoch ein neues Profil erstellen", "Neues Profil", MessageBoxButtons.YesNo)
            Case Windows.Forms.DialogResult.Yes
                My.Computer.FileSystem.DeleteFile(Hauptmenue.YourPath + "\pro.joe")
                fmsg_Pro.Show()

            Case Windows.Forms.DialogResult.No
                'Code für Nein
        End Select
    End Sub

    Private Sub Button_Beenden_Click(sender As Object, e As EventArgs) Handles Button_Beenden.Click
        Me.Close()
    End Sub
End Class