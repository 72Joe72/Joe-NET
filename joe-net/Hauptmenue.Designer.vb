<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptmenue
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Beenden = New System.Windows.Forms.Button()
        Me.Button_Optionen = New System.Windows.Forms.Button()
        Me.Button_Spielen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_NAME = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L_SN = New System.Windows.Forms.Label()
        Me.HMenue_Panel = New System.Windows.Forms.Panel()
        Me.Spiel_Panel = New System.Windows.Forms.Panel()
        Me.Button_Host = New System.Windows.Forms.Button()
        Me.Join_Button = New System.Windows.Forms.Button()
        Me.B_Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Optionen_Panel = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Profil_Button = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Profil_Panel = New System.Windows.Forms.Panel()
        Me.Profiel_Info_Button = New System.Windows.Forms.Button()
        Me.Neues_Profiel_Button = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HMenue_Panel.SuspendLayout()
        Me.Spiel_Panel.SuspendLayout()
        Me.Optionen_Panel.SuspendLayout()
        Me.Profil_Panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hauptmenü"
        '
        'Button_Beenden
        '
        Me.Button_Beenden.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Beenden.Location = New System.Drawing.Point(64, 255)
        Me.Button_Beenden.Name = "Button_Beenden"
        Me.Button_Beenden.Size = New System.Drawing.Size(148, 46)
        Me.Button_Beenden.TabIndex = 1
        Me.Button_Beenden.Text = "Beenden"
        Me.Button_Beenden.UseVisualStyleBackColor = True
        '
        'Button_Optionen
        '
        Me.Button_Optionen.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Optionen.Location = New System.Drawing.Point(64, 182)
        Me.Button_Optionen.Name = "Button_Optionen"
        Me.Button_Optionen.Size = New System.Drawing.Size(148, 46)
        Me.Button_Optionen.TabIndex = 2
        Me.Button_Optionen.Text = "Optionen"
        Me.Button_Optionen.UseVisualStyleBackColor = True
        '
        'Button_Spielen
        '
        Me.Button_Spielen.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Spielen.Location = New System.Drawing.Point(64, 112)
        Me.Button_Spielen.Name = "Button_Spielen"
        Me.Button_Spielen.Size = New System.Drawing.Size(148, 46)
        Me.Button_Spielen.TabIndex = 3
        Me.Button_Spielen.Text = "Spielen"
        Me.Button_Spielen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hallo:"
        '
        'L_NAME
        '
        Me.L_NAME.AutoSize = True
        Me.L_NAME.Location = New System.Drawing.Point(69, 390)
        Me.L_NAME.Name = "L_NAME"
        Me.L_NAME.Size = New System.Drawing.Size(10, 13)
        Me.L_NAME.TabIndex = 5
        Me.L_NAME.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Serien-Nr"
        '
        'L_SN
        '
        Me.L_SN.AutoSize = True
        Me.L_SN.Location = New System.Drawing.Point(69, 407)
        Me.L_SN.Name = "L_SN"
        Me.L_SN.Size = New System.Drawing.Size(10, 13)
        Me.L_SN.TabIndex = 5
        Me.L_SN.Text = "-"
        '
        'HMenue_Panel
        '
        Me.HMenue_Panel.BackColor = System.Drawing.SystemColors.Control
        Me.HMenue_Panel.Controls.Add(Me.Label1)
        Me.HMenue_Panel.Controls.Add(Me.Button_Beenden)
        Me.HMenue_Panel.Controls.Add(Me.Button_Optionen)
        Me.HMenue_Panel.Controls.Add(Me.Button_Spielen)
        Me.HMenue_Panel.Location = New System.Drawing.Point(57, 3)
        Me.HMenue_Panel.Name = "HMenue_Panel"
        Me.HMenue_Panel.Size = New System.Drawing.Size(159, 76)
        Me.HMenue_Panel.TabIndex = 6
        '
        'Spiel_Panel
        '
        Me.Spiel_Panel.Controls.Add(Me.Button_Host)
        Me.Spiel_Panel.Controls.Add(Me.Join_Button)
        Me.Spiel_Panel.Controls.Add(Me.B_Button1)
        Me.Spiel_Panel.Controls.Add(Me.Label4)
        Me.Spiel_Panel.Location = New System.Drawing.Point(35, 172)
        Me.Spiel_Panel.Name = "Spiel_Panel"
        Me.Spiel_Panel.Size = New System.Drawing.Size(179, 84)
        Me.Spiel_Panel.TabIndex = 7
        '
        'Button_Host
        '
        Me.Button_Host.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Host.Location = New System.Drawing.Point(64, 113)
        Me.Button_Host.Name = "Button_Host"
        Me.Button_Host.Size = New System.Drawing.Size(148, 46)
        Me.Button_Host.TabIndex = 15
        Me.Button_Host.Text = "Erstellen"
        Me.Button_Host.UseVisualStyleBackColor = True
        '
        'Join_Button
        '
        Me.Join_Button.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Join_Button.Location = New System.Drawing.Point(64, 183)
        Me.Join_Button.Name = "Join_Button"
        Me.Join_Button.Size = New System.Drawing.Size(148, 46)
        Me.Join_Button.TabIndex = 14
        Me.Join_Button.Text = "Beitreten"
        Me.Join_Button.UseVisualStyleBackColor = True
        '
        'B_Button1
        '
        Me.B_Button1.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.B_Button1.Location = New System.Drawing.Point(64, 256)
        Me.B_Button1.Name = "B_Button1"
        Me.B_Button1.Size = New System.Drawing.Size(148, 46)
        Me.B_Button1.TabIndex = 13
        Me.B_Button1.Text = "Zurück"
        Me.B_Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Spielen"
        '
        'Optionen_Panel
        '
        Me.Optionen_Panel.Controls.Add(Me.Button3)
        Me.Optionen_Panel.Controls.Add(Me.Profil_Button)
        Me.Optionen_Panel.Controls.Add(Me.Button5)
        Me.Optionen_Panel.Controls.Add(Me.Label5)
        Me.Optionen_Panel.Location = New System.Drawing.Point(13, 75)
        Me.Optionen_Panel.Name = "Optionen_Panel"
        Me.Optionen_Panel.Size = New System.Drawing.Size(201, 91)
        Me.Optionen_Panel.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button3.Location = New System.Drawing.Point(64, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 46)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Profil_Button
        '
        Me.Profil_Button.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Profil_Button.Location = New System.Drawing.Point(64, 183)
        Me.Profil_Button.Name = "Profil_Button"
        Me.Profil_Button.Size = New System.Drawing.Size(148, 46)
        Me.Profil_Button.TabIndex = 10
        Me.Profil_Button.Text = "Profil"
        Me.Profil_Button.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button5.Location = New System.Drawing.Point(64, 256)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(148, 46)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Zurück"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(76, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Optionen"
        '
        'Profil_Panel
        '
        Me.Profil_Panel.Controls.Add(Me.Profiel_Info_Button)
        Me.Profil_Panel.Controls.Add(Me.Neues_Profiel_Button)
        Me.Profil_Panel.Controls.Add(Me.Button4)
        Me.Profil_Panel.Controls.Add(Me.Label6)
        Me.Profil_Panel.Location = New System.Drawing.Point(57, 258)
        Me.Profil_Panel.Name = "Profil_Panel"
        Me.Profil_Panel.Size = New System.Drawing.Size(167, 83)
        Me.Profil_Panel.TabIndex = 17
        '
        'Profiel_Info_Button
        '
        Me.Profiel_Info_Button.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Profiel_Info_Button.Location = New System.Drawing.Point(64, 112)
        Me.Profiel_Info_Button.Name = "Profiel_Info_Button"
        Me.Profiel_Info_Button.Size = New System.Drawing.Size(148, 46)
        Me.Profiel_Info_Button.TabIndex = 15
        Me.Profiel_Info_Button.Text = "Profiel Info"
        Me.Profiel_Info_Button.UseVisualStyleBackColor = True
        '
        'Neues_Profiel_Button
        '
        Me.Neues_Profiel_Button.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Neues_Profiel_Button.Location = New System.Drawing.Point(64, 182)
        Me.Neues_Profiel_Button.Name = "Neues_Profiel_Button"
        Me.Neues_Profiel_Button.Size = New System.Drawing.Size(148, 46)
        Me.Neues_Profiel_Button.TabIndex = 14
        Me.Neues_Profiel_Button.Text = "Neues Profiel"
        Me.Neues_Profiel_Button.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button4.Location = New System.Drawing.Point(64, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 46)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Zurück"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(95, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 32)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Profil"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(88, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 32)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Joe-NET"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.HMenue_Panel)
        Me.Panel1.Controls.Add(Me.Spiel_Panel)
        Me.Panel1.Controls.Add(Me.Optionen_Panel)
        Me.Panel1.Controls.Add(Me.Profil_Panel)
        Me.Panel1.Location = New System.Drawing.Point(15, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 342)
        Me.Panel1.TabIndex = 18
        '
        'Hauptmenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 427)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.L_SN)
        Me.Controls.Add(Me.L_NAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "Hauptmenue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.HMenue_Panel.ResumeLayout(False)
        Me.HMenue_Panel.PerformLayout()
        Me.Spiel_Panel.ResumeLayout(False)
        Me.Spiel_Panel.PerformLayout()
        Me.Optionen_Panel.ResumeLayout(False)
        Me.Optionen_Panel.PerformLayout()
        Me.Profil_Panel.ResumeLayout(False)
        Me.Profil_Panel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Beenden As Button
    Friend WithEvents Button_Optionen As Button
    Friend WithEvents Button_Spielen As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents L_NAME As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents L_SN As Label
    Friend WithEvents HMenue_Panel As Panel
    Friend WithEvents Spiel_Panel As Panel
    Friend WithEvents Button_Host As Button
    Friend WithEvents Join_Button As Button
    Friend WithEvents B_Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Optionen_Panel As Panel
    Friend WithEvents Profil_Panel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Profil_Button As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Profiel_Info_Button As Button
    Friend WithEvents Neues_Profiel_Button As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
End Class
