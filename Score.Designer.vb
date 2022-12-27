<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
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
        Me.ComboBoxPseudo = New System.Windows.Forms.ComboBox()
        Me.ListBoxPseudo = New System.Windows.Forms.ListBox()
        Me.ListBoxMeilleurScore = New System.Windows.Forms.ListBox()
        Me.ListBoxTemps = New System.Windows.Forms.ListBox()
        Me.ButtonTri = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonDetails = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxPseudo
        '
        Me.ComboBoxPseudo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ComboBoxPseudo.FormattingEnabled = True
        Me.ComboBoxPseudo.Location = New System.Drawing.Point(237, 261)
        Me.ComboBoxPseudo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxPseudo.Name = "ComboBoxPseudo"
        Me.ComboBoxPseudo.Size = New System.Drawing.Size(201, 24)
        Me.ComboBoxPseudo.TabIndex = 0
        '
        'ListBoxPseudo
        '
        Me.ListBoxPseudo.BackColor = System.Drawing.Color.RoyalBlue
        Me.ListBoxPseudo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListBoxPseudo.FormattingEnabled = True
        Me.ListBoxPseudo.ItemHeight = 16
        Me.ListBoxPseudo.Location = New System.Drawing.Point(31, 110)
        Me.ListBoxPseudo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxPseudo.Name = "ListBoxPseudo"
        Me.ListBoxPseudo.Size = New System.Drawing.Size(159, 116)
        Me.ListBoxPseudo.TabIndex = 1
        '
        'ListBoxMeilleurScore
        '
        Me.ListBoxMeilleurScore.BackColor = System.Drawing.Color.RoyalBlue
        Me.ListBoxMeilleurScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListBoxMeilleurScore.FormattingEnabled = True
        Me.ListBoxMeilleurScore.ItemHeight = 16
        Me.ListBoxMeilleurScore.Location = New System.Drawing.Point(257, 110)
        Me.ListBoxMeilleurScore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxMeilleurScore.Name = "ListBoxMeilleurScore"
        Me.ListBoxMeilleurScore.Size = New System.Drawing.Size(159, 116)
        Me.ListBoxMeilleurScore.TabIndex = 2
        '
        'ListBoxTemps
        '
        Me.ListBoxTemps.BackColor = System.Drawing.Color.RoyalBlue
        Me.ListBoxTemps.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ListBoxTemps.FormattingEnabled = True
        Me.ListBoxTemps.ItemHeight = 16
        Me.ListBoxTemps.Location = New System.Drawing.Point(496, 110)
        Me.ListBoxTemps.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxTemps.Name = "ListBoxTemps"
        Me.ListBoxTemps.Size = New System.Drawing.Size(159, 116)
        Me.ListBoxTemps.TabIndex = 3
        '
        'ButtonTri
        '
        Me.ButtonTri.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonTri.Font = New System.Drawing.Font("Stencil", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTri.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonTri.Location = New System.Drawing.Point(496, 261)
        Me.ButtonTri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonTri.Name = "ButtonTri"
        Me.ButtonTri.Size = New System.Drawing.Size(149, 60)
        Me.ButtonTri.TabIndex = 4
        Me.ButtonTri.Text = "↓↑"
        Me.ButtonTri.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(77, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pseudo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(276, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Meilleur score"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(492, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Temps (secondes)"
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonQuitter.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonQuitter.Location = New System.Drawing.Point(31, 261)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(149, 60)
        Me.ButtonQuitter.TabIndex = 9
        Me.ButtonQuitter.Text = "MENU"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'ButtonDetails
        '
        Me.ButtonDetails.BackColor = System.Drawing.Color.RoyalBlue
        Me.ButtonDetails.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonDetails.Location = New System.Drawing.Point(267, 308)
        Me.ButtonDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonDetails.Name = "ButtonDetails"
        Me.ButtonDetails.Size = New System.Drawing.Size(149, 39)
        Me.ButtonDetails.TabIndex = 10
        Me.ButtonDetails.Text = "Détails"
        Me.ButtonDetails.UseVisualStyleBackColor = False
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Stencil", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelTitre.Location = New System.Drawing.Point(255, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(158, 51)
        Me.LabelTitre.TabIndex = 11
        Me.LabelTitre.Text = "Score"
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(697, 361)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonDetails)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonTri)
        Me.Controls.Add(Me.ListBoxTemps)
        Me.Controls.Add(Me.ListBoxMeilleurScore)
        Me.Controls.Add(Me.ListBoxPseudo)
        Me.Controls.Add(Me.ComboBoxPseudo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Score"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxPseudo As ComboBox
    Friend WithEvents ListBoxPseudo As ListBox
    Friend WithEvents ListBoxMeilleurScore As ListBox
    Friend WithEvents ListBoxTemps As ListBox
    Friend WithEvents ButtonTri As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ButtonDetails As Button
    Friend WithEvents LabelTitre As Label
End Class
