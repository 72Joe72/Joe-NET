Public Class Host_Client
    Private Sub Host_Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Beenden_Click(sender As Object, e As EventArgs) Handles Button_Beenden.Click
        Me.Close()

    End Sub

    Private Sub Button_Host_Click(sender As Object, e As EventArgs) Handles Button_Host.Click
        Host.Show()

    End Sub

    Private Sub Button_Optionen_Click(sender As Object, e As EventArgs) Handles Button_Optionen.Click
        Join.Show()

    End Sub
End Class