Public Class Partie
    Private Dem As Demineur
    Private WithEvents Timer As Timer
    Private coup As Integer = 0


    Private Sub Load_Partie(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer = New Timer
        Timer.Interval = 1000
        Me.Text = "Demineur"
        Dim btn As Button
        NbDrapeau.Text = Dem.nbMines
        LabelPseudo.Text = Accueil.ComboBoxPseudo.Text
        Dim size As Integer = 384 \ Dem.Taille
        Dim larg As Integer = 0
        Dim haut As Integer = 0
        Map.Controls.Clear()
        For i As Integer = 0 To Dem.Taille - 1
            For j As Integer = 0 To Dem.Taille - 1
                btn = New Button
                btn.Size = New Size(size, size)
                AddHandler btn.MouseDown, AddressOf CliqueButton
                btn.Location = New Point(btn.Height * larg, haut)
                btn.Text = " "
                btn.BackColor = Color.DarkGray
                Map.Controls.Add(btn)
                larg += 1
            Next
            haut += size
            larg = 0
        Next
        If Dem.temps = 0 Then
            LabelTemps.Visible = False
            ButtonPause.Visible = False
        Else
            AfficherTemps()
        End If
    End Sub
    Private Sub AfficherTemps()
        LabelTemps.Text = ""
        Dim minutes As Integer = Dem.temps \ 60
        Dim secondes As Integer = Dem.temps Mod 60
        If minutes < 10 Then
            LabelTemps.Text = "0"
        End If
        LabelTemps.Text += minutes & ":"
        If secondes < 10 Then
            LabelTemps.Text += "0"
        End If
        LabelTemps.Text += CStr(secondes)
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim msgArret = MsgBox("Etes-vous sûr ?", vbYesNo + vbDefaultButton2)
        If msgArret = vbYes Then
            Timer.Stop()
            Me.Close()
            Accueil.Show()
        End If
    End Sub
    Public Sub InitMap(taille, mine, temps)
        Dem = Démineur.initialisation(taille, mine, temps)
    End Sub

    Public Sub ActualiserAffichageCases()
        For i As Integer = 0 To Dem.Taille - 1
            For j As Integer = 0 To Dem.Taille - 1
                Select Case Dem.etatCase(i, j)
                    Case StatutCase.DEMASQUE : afficherCaseVide(i, j)
                    Case StatutCase.MINE : afficherCaseMine(i, j)
                    Case StatutCase.DRAPEAU : afficherCaseDrapeau(i, j)
                    Case StatutCase.MASQUE : afficherCaseMasque(i, j)
                End Select
            Next
        Next
    End Sub

    Public Sub afficherCaseMasque(hauteur As Integer, largeur As Integer)
        Dim position As Integer = hauteur * Dem.Taille + largeur
        Map.Controls(position).BackColor = Color.DarkGray
        If Not Map.Controls(position).BackgroundImage Is Nothing Then
            Map.Controls(position).BackgroundImage.Dispose()
            Map.Controls(position).BackgroundImage = Nothing
        End If
    End Sub

    Private Sub CreationPersonne()
        Dim j1 As Pers
        j1.nom = Me.LabelPseudo.Text
        j1.meilleurScore = Démineur.getnbCasesdemasquer(Dem)
        j1.score = Démineur.getnbCasesdemasquer(Dem)
        Console.WriteLine(Démineur.getnbCasesdemasquer(Dem))
        j1.temppsjeux = Démineur.gettempsécou(Dem)
        j1.partiejouer = 1
        If Personnes.ExistePers(j1) = False Then
            Accueil.ComboBoxPseudo.Items.Add(j1.nom)
        End If
        If Démineur.aPerdu(Dem) = True Then
            j1.PartiesPerdues = 1
            j1.PartiesGagnés = 0
        Else
            j1.PartiesPerdues = 0
            j1.PartiesGagnés = 1
        End If
        Personnes.ajoutPers(j1)
    End Sub
    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        LabelTemps.Text = ""
        Dem = Démineur.Temps(Dem)
        AfficherTemps()
        If Dem.temps = 0 Then
            Timer.Stop()
            MsgBox("Le temps est écoulé " & vbCr & Démineur.MsgFin(Dem))
            CreationPersonne()
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Public Sub afficherCaseVide(hauteur As Integer, largeur As Integer)
        Dim position As Integer = hauteur * Dem.Taille + largeur
        Map.Controls(position).BackColor = Color.White
        If Démineur.getNbMineCases(Dem, hauteur, largeur) <> 0 Then
            Select Case Démineur.getNbMineCases(Dem, hauteur, largeur)
                Case 1 : Map.Controls(position).ForeColor = Color.Blue
                Case 2 : Map.Controls(position).ForeColor = Color.Green
                Case Else : Map.Controls(position).ForeColor = Color.Red
            End Select
            Map.Controls(position).Text = Démineur.getNbMineCases(Dem, hauteur, largeur)
        End If
    End Sub

    Public Function RedimImageButton(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(384 / Dem.Taille, 384 / Dem.Taille))
    End Function

    Public Sub afficherCaseMine(hauteur As Integer, largeur As Integer)
        Dim position As Integer = hauteur * Dem.Taille + largeur
        Dim s As Image = Image.FromFile(".\mine.png")
        s = RedimImageButton(s)
        Map.Controls(position).BackgroundImage = s

    End Sub

    Public Sub afficherCaseDrapeau(i As Integer, j As Integer)
        Dim pos As Integer = i * Dem.Taille + j
        Dim flag As Image = Image.FromFile(".\flag.jpg")
        flag = RedimImageButton(flag)
        Map.Controls(pos).BackgroundImage = flag
    End Sub

    Public Sub CliqueButton(sender As Object, e As MouseEventArgs)
        Dim ButtonClique As MouseEventArgs = DirectCast(e, MouseEventArgs)
        If Dem.temps <> 0 Then
            Timer.Start()
        End If
        Dim hauteur As Integer = 0, largeur As Integer = 0
        For Each btn As Button In Map.Controls
            If btn.Location = sender.location Then
                largeur = sender.Location.X \ Map.Controls(0).Height
                hauteur = sender.Location.Y \ Map.Controls(0).Height
            End If
        Next
        If coup = 0 Then
            Dem = Démineur.initmine(Dem, hauteur, largeur)
            Dem = Démineur.placerMine(Dem, hauteur, largeur)
        End If
        coup += 1
        If ButtonClique.Button = MouseButtons.Left Then
            Dem = Démineur.demasquer(Dem, hauteur, largeur)
        ElseIf ButtonClique.Button = MouseButtons.Right Then
            Dem = Démineur.marque(Dem, hauteur, largeur)
            NbDrapeau.Text = Dem.nbMines - Dem.cptDrapeau
        End If
        ActualiserAffichageCases()
        If Démineur.Partifini(Dem) = True Then
            Timer.Stop()
            MsgBox(Démineur.MsgFin(Dem))
            CreationPersonne()
            Me.Close()
        End If
    End Sub

    Private Sub ButtonPause_Click(sender As Object, e As MouseEventArgs) Handles ButtonPause.Click
        Timer.Stop()
    End Sub

    Private Sub ButtonPause_MouseHover(sender As Button, e As EventArgs) Handles ButtonQuitter.MouseHover
        sender.BackColor = Color.Red
    End Sub

    Private Sub ButtonQuitter_MouseLeave(sender As Button, e As EventArgs) Handles ButtonQuitter.MouseLeave
        sender.BackColor = Color.White
    End Sub

    Private Sub Partie_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub
End Class