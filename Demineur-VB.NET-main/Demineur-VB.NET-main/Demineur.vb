Module Démineur
    Structure Demineur
        Public nbMines As Integer
        Public Taille As Integer
        Public posMines(,) As Boolean
        Public temps As Integer
        Public etatCase(,) As StatutCase
        Public cptDrapeau As Integer
        Public perdu As Boolean
        Public tabnbmines(,) As Integer
        Public nbCasesDemasques As Integer
        Public tempsEcouler As Integer
    End Structure

    Enum StatutCase
        MASQUE
        DEMASQUE
        DRAPEAU
        MINE
    End Enum


    Private Vides() As Integer
    Private taille As Integer = 1
    Private pasExt As Integer = 2
    Private nbItems As Integer = 1
    Public Sub Main()
        Personnes.LireFichier()
        Application.Run(Accueil)
        Personnes.EcritureFichier()
    End Sub
    Public Function initialisation(nbcase As Integer, Mines As Integer, temps As Integer) As Demineur
        Dim dem As New Demineur
        dem.nbCasesDemasques = 0
        dem.tempsEcouler = 0
        dem.cptDrapeau = 0
        dem.perdu = True
        dem.temps = temps
        dem.Taille = nbcase
        dem.nbMines = Mines
        ReDim dem.etatCase(dem.Taille, dem.Taille)
        ReDim dem.posMines(dem.Taille, dem.Taille)
        ReDim dem.tabnbmines(dem.Taille, dem.Taille)
        For i As Integer = 0 To dem.Taille - 1
            For j As Integer = 0 To dem.Taille - 1
                dem.etatCase(i, j) = StatutCase.MASQUE
            Next
        Next
        Return dem
    End Function

    Private Sub initVides()
        nbItems = 1
        taille = 1
        pasExt = 2
        Erase Vides
        ReDim Vides(taille)
    End Sub

    Public Function initmine(Dem As Demineur, x As Integer, y As Integer) As Demineur
        Debug.Assert(x >= 0 And x < Dem.Taille And y >= 0 And y < Dem.Taille)
        Dim i As Integer, hauteur As Integer, largeur As Integer
        While i < Dem.nbMines 'on ajoute le nombre de mine demandé
            If (largeur > Dem.Taille - 1) Then 'si nous avons dépassons la largeur deu tableau alors nous passons à la ligne suivante et nous revenons au premier élément
                hauteur += 1
                largeur = 0
            End If
            If x <> hauteur Or y <> largeur Then
                Dem.posMines(hauteur, largeur) = True 'on ajoute une mine
                i += 1
            End If
            largeur += 1
        End While
        Return Dem
    End Function

    Public Sub compter(dem As Demineur, hauteur As Integer, largeur As Integer)
        Debug.Assert(hauteur >= 0 And hauteur < dem.Taille And largeur >= 0 And largeur < dem.Taille)
        For x As Integer = hauteur - 1 To hauteur + 1
            For y As Integer = largeur - 1 To largeur + 1
                If (x <> hauteur Or y <> largeur) And x >= 0 And x < dem.Taille And y >= 0 And y < dem.Taille Then
                    dem.tabnbmines(x, y) += 1
                End If
            Next
        Next
    End Sub

    Public Function placerMine(Dem As Demineur, casex As Integer, casey As Integer) As Demineur
        Debug.Assert(casex >= 0 And casex < Dem.Taille And casey >= 0 And casey < Dem.Taille)
        Dim r As New Random(), i As Integer, largeur As Integer, hauteur As Integer, position As Integer
        Dim x, y As Integer
        While i < Dem.nbMines 'on mélange toutes les mines dans le conteneur
            If (largeur > Dem.Taille - 1) Then
                hauteur += 1
                largeur = 0
            End If
            position = r.Next(0, (Dem.Taille * Dem.Taille)) 'on cherche une nouvelle position
            x = position \ Dem.Taille 'nous récupérons les coodonnées
            y = position Mod Dem.Taille 'nous récupérons les coodonnées
            If (x <> casex Or y <> casey) And (hauteur <> casex Or largeur <> casey) Then 'on mélange toutes les mines dans le conteneur et qu'elle ne se trouve pas sur le bouton préssé
                If Dem.posMines(x, y) = True Then
                    Dem.posMines(hauteur, largeur) = True

                Else
                    Dem.posMines(x, y) = True
                    Dem.posMines(hauteur, largeur) = False 'et l'ancienne case devient de type vide pour éviter les doublons
                End If
            End If
            largeur += 1
            i += 1
        End While
        'Pour chaque case nous calculons le nombre de mines voisines
        For a As Integer = 0 To Dem.Taille - 1
            For b As Integer = 0 To Dem.Taille - 1
                If Dem.posMines(a, b) Then
                    compter(Dem, a, b)
                End If
            Next
        Next
        Return Dem
    End Function

    Public Function Temps(dem As Demineur) As Demineur
        dem.temps -= 1
        dem.tempsEcouler += 1
        Return dem
    End Function

    Public Function gettempsécou(dem As Demineur) As Integer
        Return dem.tempsEcouler
    End Function


    Public Function getNbMineCases(dem As Demineur, hauteur As Integer, largeur As Integer) As Integer
        Debug.Assert(hauteur >= 0 And hauteur < dem.Taille And largeur >= 0 And largeur < dem.Taille)
        Return dem.tabnbmines(hauteur, largeur)
    End Function

    Public Function chercher(position As Integer) As Boolean
        For n1 As Integer = 0 To nbItems 'Nous vérifions que la position ne soit pas déjà dans le tableau de case vide
            If position.Equals(Vides(n1)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub AjoutVides(dem As Demineur, hauteur As Integer, largeur As Integer)
        Debug.Assert(hauteur >= 0 And hauteur < dem.Taille And largeur >= 0 And largeur < dem.Taille)
        Dim position As Integer = hauteur * dem.Taille + largeur
        If chercher(position) = False Then
            If taille <= nbItems Then 'Si nous dépassons la capacité du tableau nous augmentons sa taille
                ReDim Preserve Vides(taille + pasExt)
                taille += pasExt
                Vides(taille - 1) = -1
                Vides(taille) = -1
            End If 'Sinon nous ajoutons la position au tableau
            Vides(nbItems) = position
            nbItems += 1
        End If
    End Sub

    Public Sub caseVide(dem As Demineur, hauteur As Integer, largeur As Integer)
        Debug.Assert(hauteur >= 0 And hauteur < dem.Taille And largeur >= 0 And largeur < dem.Taille)
        initVides() 'on initialise le tableau
        Dim index As Integer = 0, x As Integer, y As Integer
        Vides(index) = hauteur * dem.Taille + largeur 'on implémente un premier élément qui est la case vide que l'on a démasqué
        While index < nbItems 'on vérifie pour chaque case vide du tableau
            x = Vides(index) \ dem.Taille
            y = Vides(index) Mod dem.Taille
            For a As Integer = x - 1 To x + 1
                For b As Integer = y - 1 To y + 1 'on parcourt toutes les cases autour d'elle y compris elle même
                    If (a >= 0 And a <= dem.Taille - 1 And b >= 0 And b <= dem.Taille - 1) Then
                        If (getNbMineCases(dem, a, b) = 0 And dem.posMines(a, b) = False And dem.etatCase(a, b) = StatutCase.MASQUE) Then 'on vérifie si les coordonnées sont valide et si la case est bien une case vide sans chiffre
                            AjoutVides(dem, a, b) 'alors on ajoute les coordonnées trouvées dans notre tableau de case

                        End If
                    End If
                Next
            Next
            index += 1 'on passe à l'élément suivant
        End While
    End Sub

    Public Function vider(dem As Demineur, hauteur As Integer, largeur As Integer) As Demineur
        Debug.Assert(hauteur >= 0 And hauteur < dem.Taille And largeur >= 0 And largeur < dem.Taille)
        Dim position As Integer
        For i As Integer = 0 To UBound(Vides) - 1 'on parcourt toutes les cases du tableau 
            position = Vides(i)
            If (position >= 0) Then
                Dim x As Integer = position \ dem.Taille
                Dim y As Integer = position Mod dem.Taille
                For a As Integer = x - 1 To x + 1
                    For b As Integer = y - 1 To y + 1 'on parcourt toutes les cases autour de l'élément du tableau y compris elle même
                        If (a >= 0 And a <= dem.Taille - 1 And b >= 0 And b <= dem.Taille - 1) AndAlso dem.posMines(a, b) = False Then 'on vérifie si les coordonnées sont valide et si la case est bien une case vide
                            dem.etatCase(a, b) = StatutCase.DEMASQUE 'on démasque la case
                        End If
                    Next
                Next
            End If
        Next

        Return dem
    End Function

    Public Function demasquerCaseVide(dem As Demineur, hauteur As Integer, largeur As Integer) As Demineur
        If dem.etatCase(hauteur, largeur) = StatutCase.MASQUE Then 'On vérfie que la case est bien masquée
            If getNbMineCases(dem, hauteur, largeur) = 0 Then 'Si elle est vide sans chiffre nous vidons les cases vides autour
                caseVide(dem, hauteur, largeur)
                dem = vider(dem, hauteur, largeur)
            Else 'Sinon nous ne démasquons qu'elle
                dem.etatCase(hauteur, largeur) = StatutCase.DEMASQUE
            End If
        End If
        Return dem
    End Function

    Public Function demasquerMinePerdu(dem As Demineur) As Demineur
        For i As Integer = 0 To dem.Taille - 1
            For j As Integer = 0 To dem.Taille - 1 'Nous cherchons toutes les mines pour les démasqués
                If dem.posMines(i, j) Then
                    dem.etatCase(i, j) = StatutCase.MINE
                End If
            Next
        Next
        Return dem
    End Function

    Public Function demasquer(dem As Demineur, hauteur As Integer, largeur As Integer) As Demineur
        Debug.Assert(hauteur >= 0 And hauteur < dem.Taille And largeur >= 0 And largeur < dem.Taille)
        Select Case dem.posMines(hauteur, largeur) 'Nous vérifions l'état de la case démasquée
            Case True 'Si la case démasquée est une mine alors c'est perdu
                dem.perdu = False
                dem.etatCase(hauteur, largeur) = StatutCase.MINE
                dem = demasquerMinePerdu(dem)
            Case False 'Sinon nous la démasquons
                dem = demasquerCaseVide(dem, hauteur, largeur)
        End Select
        Return dem
    End Function

    Public Function getnbCasesdemasquer(dem As Demineur) As Integer
        dem.nbCasesDemasques = nbCasesdemasquer(dem)
        Return dem.nbCasesDemasques
    End Function

    Public Function casedemasquer(dem As Demineur) As Boolean
        Return getnbCasesdemasquer(dem) = (dem.Taille * dem.Taille) - dem.nbMines
    End Function

    Public Function nbCasesdemasquer(dem As Demineur) As Integer
        dem.nbCasesDemasques = 0
        For i As Integer = 0 To dem.Taille - 1
            For j As Integer = 0 To dem.Taille - 1 'Récupère toutes les cases démasquées
                If dem.etatCase(i, j) = StatutCase.DEMASQUE Then
                    dem.nbCasesDemasques += 1
                End If
            Next
        Next
        Return dem.nbCasesDemasques
    End Function

    Public Function marque(dem As Demineur, hauteur As Integer, largeur As Integer) As Demineur
        Debug.Assert(hauteur >= 0 And hauteur < dem.Taille And largeur >= 0 And largeur < dem.Taille)
        If dem.etatCase(hauteur, largeur) <> StatutCase.DEMASQUE Then
            If dem.etatCase(hauteur, largeur) = StatutCase.DRAPEAU Then 'Si elle est marquée alors elle redevient masquée
                dem.etatCase(hauteur, largeur) = StatutCase.MASQUE
                dem.cptDrapeau -= 1
            ElseIf dem.etatCase(hauteur, largeur) = StatutCase.MASQUE Then 'Sinon elle devient marquée
                If dem.cptDrapeau < dem.nbMines Then
                    dem.etatCase(hauteur, largeur) = StatutCase.DRAPEAU
                    dem.cptDrapeau += 1
                End If
            End If
        End If
        Return dem
    End Function

    Public Function aPerdu(dem As Demineur) As Boolean
        If dem.perdu = False Then
            Return True
        End If
        Return False
    End Function
    Public Function aGagner(dem As Demineur) As Boolean
        dem.nbCasesDemasques = nbCasesdemasquer(dem)
        If casedemasquer(dem) = True And dem.perdu <> False Then 'Nous vérifions si toutes les cases vides son bien démasquées et si nous n'avons pas fait d'erreur
            Return True
        End If
        Return False
    End Function

    Public Function Partifini(dem As Demineur) As Boolean 'Vérification de l'état de la partie
        If aPerdu(dem) = True Then
            Return True
        ElseIf aGagner(dem) = True Then
            Return True
        End If
        Return False
    End Function

    Public Function MsgFin(dem As Demineur) As String
        dem.nbCasesDemasques = nbCasesdemasquer(dem)
        Dim s As String = ""
        If aGagner(dem) = True Then
            s += "Vous avez remporté la partie!" + vbCr
        Else
            s += "Vous avez perdu la partie! " + vbCr

        End If
        s += "Lors de cette partie, vous avez révéler " & getnbCasesdemasquer(dem) & " cases"
        If dem.tempsEcouler <> 0 Then
            s += " en " & dem.tempsEcouler & " secondes."
        Else
            s += "."
        End If
        Return s
    End Function
End Module
