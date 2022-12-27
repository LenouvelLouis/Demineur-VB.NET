<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.ButtonFacile = New System.Windows.Forms.Button()
        Me.ButtonMoyen = New System.Windows.Forms.Button()
        Me.ButtonDifficile = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.GrbPersonnaliser = New System.Windows.Forms.GroupBox()
        Me.LabelSecondes = New System.Windows.Forms.Label()
        Me.ValeurSecondes = New System.Windows.Forms.Label()
        Me.HScrollBarSecondes = New System.Windows.Forms.HScrollBar()
        Me.ValeurMinutes = New System.Windows.Forms.Label()
        Me.HScrollBarMinutes = New System.Windows.Forms.HScrollBar()
        Me.ValeurMines = New System.Windows.Forms.Label()
        Me.ValeurTaille = New System.Windows.Forms.Label()
        Me.HScrollBarNbMines = New System.Windows.Forms.HScrollBar()
        Me.HScrollBarNbCase = New System.Windows.Forms.HScrollBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonConfirmer = New System.Windows.Forms.Button()
        Me.ActiverTemps = New System.Windows.Forms.CheckBox()
        Me.LabelMinutes = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelTaille = New System.Windows.Forms.Label()
        Me.BtnDéfaut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelFacile = New System.Windows.Forms.Label()
        Me.LabelMoyen = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GrbPersonnaliser.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonFacile
        '
        Me.ButtonFacile.BackColor = System.Drawing.Color.Green
        Me.ButtonFacile.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFacile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonFacile.Location = New System.Drawing.Point(9, 141)
        Me.ButtonFacile.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonFacile.Name = "ButtonFacile"
        Me.ButtonFacile.Size = New System.Drawing.Size(268, 59)
        Me.ButtonFacile.TabIndex = 0
        Me.ButtonFacile.Text = "Facile"
        Me.ButtonFacile.UseVisualStyleBackColor = False
        '
        'ButtonMoyen
        '
        Me.ButtonMoyen.BackColor = System.Drawing.Color.Orange
        Me.ButtonMoyen.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMoyen.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonMoyen.Location = New System.Drawing.Point(9, 208)
        Me.ButtonMoyen.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonMoyen.Name = "ButtonMoyen"
        Me.ButtonMoyen.Size = New System.Drawing.Size(268, 59)
        Me.ButtonMoyen.TabIndex = 1
        Me.ButtonMoyen.Text = "Moyen"
        Me.ButtonMoyen.UseVisualStyleBackColor = False
        '
        'ButtonDifficile
        '
        Me.ButtonDifficile.BackColor = System.Drawing.Color.Red
        Me.ButtonDifficile.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDifficile.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonDifficile.Location = New System.Drawing.Point(9, 273)
        Me.ButtonDifficile.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonDifficile.Name = "ButtonDifficile"
        Me.ButtonDifficile.Size = New System.Drawing.Size(268, 59)
        Me.ButtonDifficile.TabIndex = 2
        Me.ButtonDifficile.Text = "Difficile"
        Me.ButtonDifficile.UseVisualStyleBackColor = False
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.Color.White
        Me.ButtonRetour.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRetour.Location = New System.Drawing.Point(248, 343)
        Me.ButtonRetour.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(104, 51)
        Me.ButtonRetour.TabIndex = 8
        Me.ButtonRetour.Text = "Menu"
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'GrbPersonnaliser
        '
        Me.GrbPersonnaliser.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GrbPersonnaliser.Controls.Add(Me.LabelSecondes)
        Me.GrbPersonnaliser.Controls.Add(Me.ValeurSecondes)
        Me.GrbPersonnaliser.Controls.Add(Me.HScrollBarSecondes)
        Me.GrbPersonnaliser.Controls.Add(Me.ValeurMinutes)
        Me.GrbPersonnaliser.Controls.Add(Me.HScrollBarMinutes)
        Me.GrbPersonnaliser.Controls.Add(Me.ValeurMines)
        Me.GrbPersonnaliser.Controls.Add(Me.ValeurTaille)
        Me.GrbPersonnaliser.Controls.Add(Me.HScrollBarNbMines)
        Me.GrbPersonnaliser.Controls.Add(Me.HScrollBarNbCase)
        Me.GrbPersonnaliser.Controls.Add(Me.Label3)
        Me.GrbPersonnaliser.Controls.Add(Me.ButtonConfirmer)
        Me.GrbPersonnaliser.Controls.Add(Me.ActiverTemps)
        Me.GrbPersonnaliser.Controls.Add(Me.LabelMinutes)
        Me.GrbPersonnaliser.Controls.Add(Me.Label2)
        Me.GrbPersonnaliser.Controls.Add(Me.LabelTaille)
        Me.GrbPersonnaliser.Location = New System.Drawing.Point(281, 77)
        Me.GrbPersonnaliser.Margin = New System.Windows.Forms.Padding(2)
        Me.GrbPersonnaliser.Name = "GrbPersonnaliser"
        Me.GrbPersonnaliser.Padding = New System.Windows.Forms.Padding(2)
        Me.GrbPersonnaliser.Size = New System.Drawing.Size(310, 255)
        Me.GrbPersonnaliser.TabIndex = 9
        Me.GrbPersonnaliser.TabStop = False
        '
        'LabelSecondes
        '
        Me.LabelSecondes.AutoSize = True
        Me.LabelSecondes.Location = New System.Drawing.Point(4, 196)
        Me.LabelSecondes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelSecondes.Name = "LabelSecondes"
        Me.LabelSecondes.Size = New System.Drawing.Size(55, 13)
        Me.LabelSecondes.TabIndex = 18
        Me.LabelSecondes.Text = "Secondes"
        '
        'ValeurSecondes
        '
        Me.ValeurSecondes.AutoSize = True
        Me.ValeurSecondes.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValeurSecondes.Location = New System.Drawing.Point(262, 194)
        Me.ValeurSecondes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ValeurSecondes.Name = "ValeurSecondes"
        Me.ValeurSecondes.Size = New System.Drawing.Size(32, 17)
        Me.ValeurSecondes.TabIndex = 17
        Me.ValeurSecondes.Text = "sec"
        '
        'HScrollBarSecondes
        '
        Me.HScrollBarSecondes.LargeChange = 1
        Me.HScrollBarSecondes.Location = New System.Drawing.Point(58, 186)
        Me.HScrollBarSecondes.Maximum = 60
        Me.HScrollBarSecondes.Name = "HScrollBarSecondes"
        Me.HScrollBarSecondes.Size = New System.Drawing.Size(192, 31)
        Me.HScrollBarSecondes.TabIndex = 16
        '
        'ValeurMinutes
        '
        Me.ValeurMinutes.AutoSize = True
        Me.ValeurMinutes.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValeurMinutes.Location = New System.Drawing.Point(262, 158)
        Me.ValeurMinutes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ValeurMinutes.Name = "ValeurMinutes"
        Me.ValeurMinutes.Size = New System.Drawing.Size(34, 17)
        Me.ValeurMinutes.TabIndex = 15
        Me.ValeurMinutes.Text = "Min"
        '
        'HScrollBarMinutes
        '
        Me.HScrollBarMinutes.LargeChange = 1
        Me.HScrollBarMinutes.Location = New System.Drawing.Point(58, 150)
        Me.HScrollBarMinutes.Maximum = 59
        Me.HScrollBarMinutes.Name = "HScrollBarMinutes"
        Me.HScrollBarMinutes.Size = New System.Drawing.Size(192, 31)
        Me.HScrollBarMinutes.TabIndex = 14
        '
        'ValeurMines
        '
        Me.ValeurMines.AutoSize = True
        Me.ValeurMines.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValeurMines.Location = New System.Drawing.Point(262, 91)
        Me.ValeurMines.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ValeurMines.Name = "ValeurMines"
        Me.ValeurMines.Size = New System.Drawing.Size(26, 17)
        Me.ValeurMines.TabIndex = 13
        Me.ValeurMines.Text = "nb"
        '
        'ValeurTaille
        '
        Me.ValeurTaille.AutoSize = True
        Me.ValeurTaille.Font = New System.Drawing.Font("Stencil", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValeurTaille.Location = New System.Drawing.Point(262, 48)
        Me.ValeurTaille.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ValeurTaille.Name = "ValeurTaille"
        Me.ValeurTaille.Size = New System.Drawing.Size(16, 17)
        Me.ValeurTaille.TabIndex = 12
        Me.ValeurTaille.Text = "T"
        '
        'HScrollBarNbMines
        '
        Me.HScrollBarNbMines.LargeChange = 1
        Me.HScrollBarNbMines.Location = New System.Drawing.Point(58, 89)
        Me.HScrollBarNbMines.Maximum = 399
        Me.HScrollBarNbMines.Minimum = 1
        Me.HScrollBarNbMines.Name = "HScrollBarNbMines"
        Me.HScrollBarNbMines.Size = New System.Drawing.Size(192, 31)
        Me.HScrollBarNbMines.TabIndex = 10
        Me.HScrollBarNbMines.Value = 1
        '
        'HScrollBarNbCase
        '
        Me.HScrollBarNbCase.LargeChange = 1
        Me.HScrollBarNbCase.Location = New System.Drawing.Point(58, 46)
        Me.HScrollBarNbCase.Maximum = 20
        Me.HScrollBarNbCase.Minimum = 4
        Me.HScrollBarNbCase.Name = "HScrollBarNbCase"
        Me.HScrollBarNbCase.Size = New System.Drawing.Size(192, 31)
        Me.HScrollBarNbCase.TabIndex = 9
        Me.HScrollBarNbCase.Value = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Stencil", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(32, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 35)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Personnaliser"
        '
        'ButtonConfirmer
        '
        Me.ButtonConfirmer.Location = New System.Drawing.Point(114, 219)
        Me.ButtonConfirmer.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonConfirmer.Name = "ButtonConfirmer"
        Me.ButtonConfirmer.Size = New System.Drawing.Size(87, 33)
        Me.ButtonConfirmer.TabIndex = 7
        Me.ButtonConfirmer.Text = "Confirmer"
        Me.ButtonConfirmer.UseVisualStyleBackColor = True
        '
        'ActiverTemps
        '
        Me.ActiverTemps.AutoSize = True
        Me.ActiverTemps.Location = New System.Drawing.Point(7, 124)
        Me.ActiverTemps.Margin = New System.Windows.Forms.Padding(2)
        Me.ActiverTemps.Name = "ActiverTemps"
        Me.ActiverTemps.Size = New System.Drawing.Size(94, 17)
        Me.ActiverTemps.TabIndex = 6
        Me.ActiverTemps.Text = "Activer Temps"
        Me.ActiverTemps.UseVisualStyleBackColor = True
        '
        'LabelMinutes
        '
        Me.LabelMinutes.AutoSize = True
        Me.LabelMinutes.Location = New System.Drawing.Point(4, 158)
        Me.LabelMinutes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMinutes.Name = "LabelMinutes"
        Me.LabelMinutes.Size = New System.Drawing.Size(44, 13)
        Me.LabelMinutes.TabIndex = 2
        Me.LabelMinutes.Text = "Minutes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mines"
        '
        'LabelTaille
        '
        Me.LabelTaille.AutoSize = True
        Me.LabelTaille.Location = New System.Drawing.Point(4, 46)
        Me.LabelTaille.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTaille.Name = "LabelTaille"
        Me.LabelTaille.Size = New System.Drawing.Size(32, 13)
        Me.LabelTaille.TabIndex = 0
        Me.LabelTaille.Text = "Taille"
        '
        'BtnDéfaut
        '
        Me.BtnDéfaut.BackColor = System.Drawing.Color.LightGreen
        Me.BtnDéfaut.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDéfaut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDéfaut.Location = New System.Drawing.Point(8, 77)
        Me.BtnDéfaut.Name = "BtnDéfaut"
        Me.BtnDéfaut.Size = New System.Drawing.Size(268, 59)
        Me.BtnDéfaut.TabIndex = 10
        Me.BtnDéfaut.Text = "Défaut"
        Me.BtnDéfaut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Stencil", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(180, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mode de Jeu"
        '
        'LabelFacile
        '
        Me.LabelFacile.AutoSize = True
        Me.LabelFacile.BackColor = System.Drawing.Color.Green
        Me.LabelFacile.Location = New System.Drawing.Point(34, 178)
        Me.LabelFacile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFacile.Name = "LabelFacile"
        Me.LabelFacile.Size = New System.Drawing.Size(204, 13)
        Me.LabelFacile.TabIndex = 12
        Me.LabelFacile.Text = "Taille Grille = 5. Mines = 5. Temps(s) = 30 "
        '
        'LabelMoyen
        '
        Me.LabelMoyen.AutoSize = True
        Me.LabelMoyen.BackColor = System.Drawing.Color.Orange
        Me.LabelMoyen.Location = New System.Drawing.Point(34, 245)
        Me.LabelMoyen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMoyen.Name = "LabelMoyen"
        Me.LabelMoyen.Size = New System.Drawing.Size(222, 13)
        Me.LabelMoyen.TabIndex = 13
        Me.LabelMoyen.Text = "Taille Grille = 10. Mines = 20. Temps(s) = 180 "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightGreen
        Me.Label5.Location = New System.Drawing.Point(34, 114)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Taille Grille = 8. Mines = 10. Temps(s) = 60 "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(34, 310)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Taille Grille = 15. Mines = 40. Temps(s) = 240 "
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(600, 401)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelMoyen)
        Me.Controls.Add(Me.LabelFacile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDéfaut)
        Me.Controls.Add(Me.GrbPersonnaliser)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ButtonDifficile)
        Me.Controls.Add(Me.ButtonMoyen)
        Me.Controls.Add(Me.ButtonFacile)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Options"
        Me.Text = "Paramètres"
        Me.GrbPersonnaliser.ResumeLayout(False)
        Me.GrbPersonnaliser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonFacile As Button
    Friend WithEvents ButtonMoyen As Button
    Friend WithEvents ButtonDifficile As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents GrbPersonnaliser As GroupBox
    Friend WithEvents ActiverTemps As CheckBox
    Friend WithEvents LabelMinutes As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTaille As Label
    Friend WithEvents ButtonConfirmer As Button
    Friend WithEvents BtnDéfaut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelFacile As Label
    Friend WithEvents LabelMoyen As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HScrollBarNbCase As HScrollBar
    Friend WithEvents ValeurMines As Label
    Friend WithEvents ValeurTaille As Label
    Friend WithEvents ValeurMinutes As Label
    Friend WithEvents HScrollBarMinutes As HScrollBar
    Friend WithEvents HScrollBarNbMines As HScrollBar
    Friend WithEvents LabelSecondes As Label
    Friend WithEvents ValeurSecondes As Label
    Friend WithEvents HScrollBarSecondes As HScrollBar
End Class
