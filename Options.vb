Public Class Options

    Private mine As Integer = 10
    Private nbcase As Integer = 8
    Private durée As Integer = 60


    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelMinutes.Visible = False
        ValeurMinutes.Visible = False
        HScrollBarMinutes.Visible = False
        HScrollBarSecondes.Visible = False
        LabelSecondes.Visible = False
        ValeurSecondes.Visible = False
        ValeurTaille.Text = HScrollBarNbCase.Minimum
        ValeurMines.Text = HScrollBarNbMines.Minimum
        ValeurMinutes.Text = HScrollBarMinutes.Minimum
        ValeurSecondes.Text = HScrollBarSecondes.Minimum
        HScrollBarNbMines.Maximum = HScrollBarNbCase.Value * HScrollBarNbCase.Value - 1
    End Sub
    Public Sub ModifOptions(nbcases, nbmine, temps)
        nbcase = nbcases
        mine = nbmine
        durée = temps
    End Sub

    Public Sub EnvoiOptions()
        Partie.InitMap(nbcase, mine, durée)
    End Sub
    Public Sub ButtonFacile_Click(sender As Object, e As EventArgs) Handles ButtonFacile.Click
        ModifOptions(5, 5, 30)
    End Sub
    Private Sub ButtonMoyen_Click(sender As Object, e As EventArgs) Handles ButtonMoyen.Click
        ModifOptions(10, 20, 180)
    End Sub

    Private Sub ButtonDifficile_Click(sender As Object, e As EventArgs) Handles ButtonDifficile.Click
        ModifOptions(15, 40, 240)
    End Sub

    Private Sub BtnDéfaut_Click(sender As Object, e As EventArgs) Handles BtnDéfaut.Click
        ModifOptions(8, 10, 60)
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub ActiverTemps_CheckedChanged(sender As Object, e As EventArgs) Handles ActiverTemps.CheckedChanged
        If ActiverTemps.Checked Then
            LabelMinutes.Visible = True
            ValeurMinutes.Visible = True
            HScrollBarMinutes.Visible = True
            HScrollBarSecondes.Visible = True
            LabelSecondes.Visible = True
            ValeurSecondes.Visible = True
        Else
            LabelMinutes.Visible = False
            ValeurMinutes.Visible = False
            HScrollBarMinutes.Visible = False
            HScrollBarSecondes.Visible = False
            LabelSecondes.Visible = False
            ValeurSecondes.Visible = False
        End If
    End Sub

    Private Sub ButtonConfirmer_Click(sender As Object, e As EventArgs) Handles ButtonConfirmer.Click
        Dim temps As Integer = ValeurMinutes.Text * 60 + ValeurSecondes.Text
        If ActiverTemps.Checked And temps < 10 Then
            MsgBox("Lorsque le temps est activé, le temps minimum est de 10 secondes. ")
        Else
            If ActiverTemps.Checked = False Then
                temps = 0
            End If
            ModifOptions(ValeurTaille.Text, ValeurMines.Text, temps)
        End If

    End Sub

    Private Sub TextBoxGrille_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub



    Private Sub HScrollBarNbCase_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarNbCase.Scroll
        ValeurTaille.Text = HScrollBarNbCase.Value
        HScrollBarNbMines.Maximum = ValeurTaille.Text * ValeurTaille.Text - 1
    End Sub

    Private Sub HScrollBarNbMines_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarNbMines.Scroll
        ValeurMines.Text = HScrollBarNbMines.Value
    End Sub

    Private Sub HScrollBarMinutes_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarMinutes.Scroll
        ValeurMinutes.Text = HScrollBarMinutes.Value
    End Sub

    Private Sub HScrollBarSecondes_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBarSecondes.Scroll
        ValeurSecondes.Text = HScrollBarSecondes.Value
    End Sub

    Private Sub Options_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub
End Class