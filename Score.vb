Public Class Score

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBoxPseudo.Items.Clear()
        ListBoxMeilleurScore.Items.Clear()
        ListBoxTemps.Items.Clear()
        Personnes.tricroissant()
        For i As Integer = 0 To Personnes.getNbPersonne() - 1
            ListBoxPseudo.Items.Add(Personnes.recupJoueur(i).nom)
            ListBoxMeilleurScore.Items.Add(Personnes.recupJoueur(i).meilleurScore)
            ListBoxTemps.Items.Add(Personnes.recupJoueur(i).temppsjeux)
        Next
        Me.Text = "Score"
    End Sub

    Private Sub ListBoxPseudo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPseudo.Click
        ListBoxMeilleurScore.SetSelected(ListBoxPseudo.SelectedIndex, True)
        ListBoxTemps.SetSelected(ListBoxPseudo.SelectedIndex, True)
    End Sub

    Private Sub ListBoxMeilleurScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMeilleurScore.Click
        ListBoxPseudo.SetSelected(ListBoxMeilleurScore.SelectedIndex, True)
        ListBoxTemps.SetSelected(ListBoxMeilleurScore.SelectedIndex, True)
    End Sub

    Private Sub ListBoxTemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTemps.Click
        ListBoxPseudo.SetSelected(ListBoxTemps.SelectedIndex, True)
        ListBoxMeilleurScore.SetSelected(ListBoxTemps.SelectedIndex, True)
    End Sub

    Private Sub ListBoxTemps_SelectedPseudo(sender As Object, e As EventArgs) Handles ListBoxTemps.SelectedIndexChanged
        ComboBoxPseudo.Text = ListBoxPseudo.SelectedItem
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub ButtonTri_Click(sender As Object, e As EventArgs) Handles ButtonTri.Click
        ListBoxPseudo.Items.Clear()
        ListBoxMeilleurScore.Items.Clear()
        ListBoxTemps.Items.Clear()
        Personnes.inversesens()
        For i As Integer = 0 To Personnes.getNbPersonne() - 1
            ListBoxPseudo.Items.Add(Personnes.recupJoueur(i).nom)
            ListBoxMeilleurScore.Items.Add(Personnes.recupJoueur(i).meilleurScore)
            ListBoxTemps.Items.Add(Personnes.recupJoueur(i).temppsjeux)
        Next
    End Sub

    Private Sub ButtonDetails_Click(sender As Object, e As EventArgs) Handles ButtonDetails.Click
        Debug.Assert(Personnes.getNbPersonne > 0)
        Dim details = MsgBox(Personnes.RecapJoueur(ComboBoxPseudo.Text))
    End Sub

    Private Sub Score_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub
End Class