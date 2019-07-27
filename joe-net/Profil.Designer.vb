<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profil
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_Spielen = New System.Windows.Forms.Button()
        Me.Button_Optionen = New System.Windows.Forms.Button()
        Me.Button_Beenden = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Spielen
        '
        Me.Button_Spielen.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Spielen.Location = New System.Drawing.Point(68, 123)
        Me.Button_Spielen.Name = "Button_Spielen"
        Me.Button_Spielen.Size = New System.Drawing.Size(148, 46)
        Me.Button_Spielen.TabIndex = 11
        Me.Button_Spielen.Text = "Profiel Info"
        Me.Button_Spielen.UseVisualStyleBackColor = True
        '
        'Button_Optionen
        '
        Me.Button_Optionen.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Optionen.Location = New System.Drawing.Point(68, 193)
        Me.Button_Optionen.Name = "Button_Optionen"
        Me.Button_Optionen.Size = New System.Drawing.Size(148, 46)
        Me.Button_Optionen.TabIndex = 10
        Me.Button_Optionen.Text = "Neues Profiel"
        Me.Button_Optionen.UseVisualStyleBackColor = True
        '
        'Button_Beenden
        '
        Me.Button_Beenden.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Beenden.Location = New System.Drawing.Point(68, 266)
        Me.Button_Beenden.Name = "Button_Beenden"
        Me.Button_Beenden.Size = New System.Drawing.Size(148, 46)
        Me.Button_Beenden.TabIndex = 9
        Me.Button_Beenden.Text = "Zurück"
        Me.Button_Beenden.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 32)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Profiel"
        '
        'Profil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 362)
        Me.Controls.Add(Me.Button_Spielen)
        Me.Controls.Add(Me.Button_Optionen)
        Me.Controls.Add(Me.Button_Beenden)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Profil"
        Me.Text = "Profil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Spielen As Button
    Friend WithEvents Button_Optionen As Button
    Friend WithEvents Button_Beenden As Button
    Friend WithEvents Label1 As Label
End Class
