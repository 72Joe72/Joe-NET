<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hauptmenue
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Beenden = New System.Windows.Forms.Button()
        Me.Button_Optionen = New System.Windows.Forms.Button()
        Me.Button_Spielen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_NAME = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L_SN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hauptmenü"
        '
        'Button_Beenden
        '
        Me.Button_Beenden.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Beenden.Location = New System.Drawing.Point(71, 233)
        Me.Button_Beenden.Name = "Button_Beenden"
        Me.Button_Beenden.Size = New System.Drawing.Size(148, 46)
        Me.Button_Beenden.TabIndex = 1
        Me.Button_Beenden.Text = "Beenden"
        Me.Button_Beenden.UseVisualStyleBackColor = True
        '
        'Button_Optionen
        '
        Me.Button_Optionen.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Optionen.Location = New System.Drawing.Point(71, 160)
        Me.Button_Optionen.Name = "Button_Optionen"
        Me.Button_Optionen.Size = New System.Drawing.Size(148, 46)
        Me.Button_Optionen.TabIndex = 2
        Me.Button_Optionen.Text = "Optionen"
        Me.Button_Optionen.UseVisualStyleBackColor = True
        '
        'Button_Spielen
        '
        Me.Button_Spielen.Font = New System.Drawing.Font("Arial", 12.25!)
        Me.Button_Spielen.Location = New System.Drawing.Point(71, 90)
        Me.Button_Spielen.Name = "Button_Spielen"
        Me.Button_Spielen.Size = New System.Drawing.Size(148, 46)
        Me.Button_Spielen.TabIndex = 3
        Me.Button_Spielen.Text = "Spielen"
        Me.Button_Spielen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hallo:"
        '
        'L_NAME
        '
        Me.L_NAME.AutoSize = True
        Me.L_NAME.Location = New System.Drawing.Point(68, 323)
        Me.L_NAME.Name = "L_NAME"
        Me.L_NAME.Size = New System.Drawing.Size(10, 13)
        Me.L_NAME.TabIndex = 5
        Me.L_NAME.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Serien-Nr"
        '
        'L_SN
        '
        Me.L_SN.AutoSize = True
        Me.L_SN.Location = New System.Drawing.Point(69, 340)
        Me.L_SN.Name = "L_SN"
        Me.L_SN.Size = New System.Drawing.Size(10, 13)
        Me.L_SN.TabIndex = 5
        Me.L_SN.Text = "-"
        '
        'Hauptmenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 362)
        Me.Controls.Add(Me.L_SN)
        Me.Controls.Add(Me.L_NAME)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Spielen)
        Me.Controls.Add(Me.Button_Optionen)
        Me.Controls.Add(Me.Button_Beenden)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Hauptmenue"
        Me.Text = "Form1"
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
End Class
