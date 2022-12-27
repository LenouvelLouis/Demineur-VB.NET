Public Class Accueil

    Public Function RedimImageButton(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(500, 289))
    End Function
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Accueil"
        ComboBoxPseudo.Text = ""
        Dim accueil As Image = System.Drawing.Bitmap.FromFile(".\unknown.png")
        accueil = RedimImageButton(accueil)
        Me.BackgroundImage = accueil
        ButtonParamètre.Font = New System.Drawing.Font("stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ButtonPartie.Font = New System.Drawing.Font("stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ButtonQuitter.Font = New System.Drawing.Font("stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ButtonScore.Font = New System.Drawing.Font("stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub ComboBoxPseudo_keypress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxPseudo.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonPartie_Click(sender As Object, e As EventArgs) Handles ButtonPartie.Click
        If ComboBoxPseudo.Text.Length < 3 Then
            MsgBox("Veuillez saisir un pseudo d'au moins 3 caractères")
        ElseIf ComboBoxPseudo.Text.Length > 10 Then
            MsgBox("Veuillez saisir un pseudo d'au maximum 10 caractères")
        Else
            ComboBoxPseudo.Text = StrConv(ComboBoxPseudo.Text, vbProperCase)
            Partie.LabelPseudo.Text = ComboBoxPseudo.Text
            Me.Hide()
            Options.EnvoiOptions()
            Partie.Show()
        End If

    End Sub
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim msgArret = MsgBox("Etes-vous sûr ?", vbYesNo + vbDefaultButton2)
        If msgArret = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub ButtonScore_Click(sender As Object, e As EventArgs) Handles ButtonScore.Click
        Me.Hide()
        Score.Show()
    End Sub
    Private Sub ButtonParamètre_Click(sender As Object, e As EventArgs) Handles ButtonParamètre.Click
        Me.Hide()
        Options.Show()
    End Sub
End Class
