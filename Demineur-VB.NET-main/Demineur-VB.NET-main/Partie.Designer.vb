<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTemps = New System.Windows.Forms.Label()
        Me.LabelPseudo = New System.Windows.Forms.Label()
        Me.Map = New System.Windows.Forms.Panel()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.NbDrapeau = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.Color.White
        Me.ButtonQuitter.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(432, 72)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(150, 35)
        Me.ButtonQuitter.TabIndex = 3
        Me.ButtonQuitter.Text = "Abandonner"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'LabelTemps
        '
        Me.LabelTemps.AutoSize = True
        Me.LabelTemps.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTemps.ForeColor = System.Drawing.Color.Red
        Me.LabelTemps.Location = New System.Drawing.Point(156, 79)
        Me.LabelTemps.Name = "LabelTemps"
        Me.LabelTemps.Size = New System.Drawing.Size(79, 24)
        Me.LabelTemps.TabIndex = 4
        Me.LabelTemps.Text = "Temps"
        '
        'LabelPseudo
        '
        Me.LabelPseudo.AutoSize = True
        Me.LabelPseudo.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPseudo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelPseudo.Location = New System.Drawing.Point(12, 79)
        Me.LabelPseudo.Name = "LabelPseudo"
        Me.LabelPseudo.Size = New System.Drawing.Size(92, 24)
        Me.LabelPseudo.TabIndex = 6
        Me.LabelPseudo.Text = "Pseudo"
        '
        'Map
        '
        Me.Map.Location = New System.Drawing.Point(38, 120)
        Me.Map.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(512, 473)
        Me.Map.TabIndex = 7
        '
        'ButtonPause
        '
        Me.ButtonPause.BackColor = System.Drawing.Color.White
        Me.ButtonPause.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPause.Location = New System.Drawing.Point(322, 72)
        Me.ButtonPause.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(102, 35)
        Me.ButtonPause.TabIndex = 8
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = False
        '
        'NbDrapeau
        '
        Me.NbDrapeau.AutoSize = True
        Me.NbDrapeau.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NbDrapeau.ForeColor = System.Drawing.Color.Red
        Me.NbDrapeau.Location = New System.Drawing.Point(261, 79)
        Me.NbDrapeau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NbDrapeau.Name = "NbDrapeau"
        Me.NbDrapeau.Size = New System.Drawing.Size(38, 24)
        Me.NbDrapeau.TabIndex = 9
        Me.NbDrapeau.Text = "Nb"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(185, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 47)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Démineur"
        '
        'Partie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(587, 627)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NbDrapeau)
        Me.Controls.Add(Me.Map)
        Me.Controls.Add(Me.LabelPseudo)
        Me.Controls.Add(Me.LabelTemps)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Partie"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTemps As Label
    Friend WithEvents LabelPseudo As Label
    Friend WithEvents Map As Panel
    Friend WithEvents ButtonPause As Button
    Friend WithEvents NbDrapeau As Label
    Friend WithEvents Label1 As Label
End Class
