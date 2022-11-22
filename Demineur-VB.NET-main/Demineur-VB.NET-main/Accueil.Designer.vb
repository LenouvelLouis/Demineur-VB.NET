<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBoxPseudo = New System.Windows.Forms.ComboBox()
        Me.ButtonPartie = New System.Windows.Forms.Button()
        Me.ButtonScore = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonParamètre = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxPseudo
        '
        Me.ComboBoxPseudo.FormattingEnabled = True
        Me.ComboBoxPseudo.Location = New System.Drawing.Point(166, 225)
        Me.ComboBoxPseudo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxPseudo.Name = "ComboBoxPseudo"
        Me.ComboBoxPseudo.Size = New System.Drawing.Size(181, 21)
        Me.ComboBoxPseudo.TabIndex = 0
        '
        'ButtonPartie
        '
        Me.ButtonPartie.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPartie.Location = New System.Drawing.Point(374, 265)
        Me.ButtonPartie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonPartie.Name = "ButtonPartie"
        Me.ButtonPartie.Size = New System.Drawing.Size(117, 49)
        Me.ButtonPartie.TabIndex = 1
        Me.ButtonPartie.Text = "Nouvelle Partie"
        Me.ButtonPartie.UseVisualStyleBackColor = False
        '
        'ButtonScore
        '
        Me.ButtonScore.BackColor = System.Drawing.Color.Transparent
        Me.ButtonScore.Location = New System.Drawing.Point(130, 265)
        Me.ButtonScore.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonScore.Name = "ButtonScore"
        Me.ButtonScore.Size = New System.Drawing.Size(117, 49)
        Me.ButtonScore.TabIndex = 5
        Me.ButtonScore.Text = "Score"
        Me.ButtonScore.UseVisualStyleBackColor = False
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.Color.Transparent
        Me.ButtonQuitter.Location = New System.Drawing.Point(9, 265)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(117, 49)
        Me.ButtonQuitter.TabIndex = 6
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'ButtonParamètre
        '
        Me.ButtonParamètre.BackColor = System.Drawing.Color.Transparent
        Me.ButtonParamètre.Location = New System.Drawing.Point(252, 265)
        Me.ButtonParamètre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonParamètre.Name = "ButtonParamètre"
        Me.ButtonParamètre.Size = New System.Drawing.Size(117, 49)
        Me.ButtonParamètre.TabIndex = 8
        Me.ButtonParamètre.Text = "Options"
        Me.ButtonParamètre.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 318)
        Me.Controls.Add(Me.ButtonPartie)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonParamètre)
        Me.Controls.Add(Me.ButtonScore)
        Me.Controls.Add(Me.ComboBoxPseudo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Accueil"
        Me.Text = "ic"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBoxPseudo As ComboBox
    Friend WithEvents ButtonPartie As Button
    Friend WithEvents ButtonScore As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ButtonParamètre As Button
End Class
