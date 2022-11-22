
Imports System.IO
Module Personnes
    Public Structure Pers 'Structure personne
        Public nom As String
        Public meilleurScore As Integer
        Public partiejouer As Integer
        Public temppsjeux As Integer
        Public score As Integer
        Public tempsCumulé As Integer
        Public PartiesGagnés As Integer
        Public PartiesPerdues As Integer
    End Structure

    Private num As Integer = FreeFile()
    Private nbPersonne As Integer = 0
    Private tab(nbPersonne) As Pers 'tableau de personne

    Function ExistePers(p As Pers) As Boolean
        For Each joueur As Pers In tab 'Nous vérifions si la personne existe
            If joueur.nom = p.nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function getNbPersonne() As Integer
        Return nbPersonne
    End Function

    Public Function getindexPers(joueur As Pers) As Integer

        For i As Integer = 0 To getNbPersonne() 'Nous récupérons l'index de la personne cherché
            If tab(i).nom = joueur.nom Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Sub ajoutPers(joueur As Pers)
        If nbPersonne > UBound(tab) Then 'on vérifie que l'on dépasse pas la capacité du tableau
            ReDim Preserve tab(nbPersonne)
        End If
        If ExistePers(joueur) = False Then 'on vérifie que la personne n'est pas déjà dans le tableau
            tab(nbPersonne) = joueur
            nbPersonne += 1

        Else 'Sinon nous la cherchons et nous mettons à jour ses statistiques
            Console.WriteLine("la")
            Dim index As Integer = getindexPers(joueur)
            If joueur.score > tab(index).meilleurScore Then
                tab(index).temppsjeux = joueur.temppsjeux
                tab(index).meilleurScore = joueur.score
            End If
            tab(index).score += joueur.score
            tab(index).tempsCumulé += joueur.temppsjeux
            tab(index).partiejouer += joueur.partiejouer
            tab(index).PartiesGagnés += joueur.PartiesGagnés
            tab(index).PartiesPerdues += joueur.PartiesPerdues
        End If
    End Sub

    Public Sub LireFichier()
        FileOpen(num, ".\score.txt", OpenMode.Input)
        Dim nbPers As Integer = 0
        Do Until EOF(num)
            nbPers = LineInput(num)
            For i As Integer = 0 To nbPers - 1 'Pour toutes les personnes du fichier nous récupérons ses statistiques
                Dim joueur As New Pers
                joueur.nom = LineInput(num)
                joueur.meilleurScore = LineInput(num)
                joueur.score = LineInput(num)
                joueur.partiejouer = LineInput(num)
                joueur.temppsjeux = LineInput(num)
                joueur.tempsCumulé = LineInput(num)
                joueur.PartiesGagnés = LineInput(num)
                joueur.PartiesPerdues = LineInput(num)
                ajoutPers(joueur)
                Accueil.ComboBoxPseudo.Items.Add(joueur.nom)
            Next
        Loop
        FileClose(num)
    End Sub

    Public Sub EcritureFichier()
        FileOpen(num, "./score.txt", OpenMode.Output)
        WriteLine(num, getNbPersonne())
        For i As Integer = 0 To getNbPersonne() - 1 'Pour chaque personne nous écrivons ses statistiques
            PrintLine(num, recupJoueur(i).nom)
            WriteLine(num, recupJoueur(i).meilleurScore)
            WriteLine(num, recupJoueur(i).score)
            WriteLine(num, recupJoueur(i).partiejouer)
            WriteLine(num, recupJoueur(i).temppsjeux)
            WriteLine(num, recupJoueur(i).tempsCumulé)
            WriteLine(num, recupJoueur(i).PartiesGagnés)
            WriteLine(num, recupJoueur(i).PartiesPerdues)
        Next
        FileClose(num)
    End Sub

    Function RecapJoueur(Pseudo As String) As String
        If Pseudo = "" Then 'si aucun joueur n'est choisi nous donnons les statistiques du 1er
            Pseudo = tab(0).nom
        End If
        For Each p1 As Pers In tab
            If p1.nom = Pseudo Then
                Return "Détails" & vbCr & "Pseudo : " & p1.nom & vbCr & "Nombre de case révélées : " & p1.score & vbCr & "Temps(s) de jeux cumulé : " & p1.tempsCumulé & vbCr & "Nombre de parties jouées : " & p1.partiejouer & vbCr & "dont gagnées : " & p1.PartiesGagnés & vbCr & "dont perdues : " & p1.PartiesPerdues
            End If
        Next
        Return ""
    End Function

    Public Function recupJoueur(i As Integer) As Pers
        Return tab(i)
    End Function

    Public Sub tricroissant()
        Debug.Assert(getNbPersonne() > 0)
        Dim perstmp As Pers
        For i As Integer = 0 To getNbPersonne() - 1
            For j As Integer = i To getNbPersonne() - 1
                If tab(i).meilleurScore > tab(j).meilleurScore Then 'nous vérifions si le score de j1 est inférieur à j2
                    perstmp = tab(j) 'Si c'est le cas nous échangeons les places
                    tab(j) = tab(i)
                    tab(i) = perstmp
                ElseIf tab(i).meilleurScore = tab(j).meilleurScore Then 'Sile score est identique nous regardons les temps
                    If tab(i).temppsjeux > tab(j).temppsjeux Then
                        perstmp = tab(j)
                        tab(j) = tab(i)
                        tab(i) = perstmp
                    End If
                End If
            Next

        Next
    End Sub

    Public Sub inversesens()
        Debug.Assert(getNbPersonne() > 0)
        Dim perstmp As Pers
        Dim point As Integer
        Dim nbpers As Integer = getNbPersonne() - 1
        If getNbPersonne() - 1 Mod 2 Then 'Nous récupérons le milieu du tableau
            point = nbpers \ 2
        Else
            point = (nbpers + 1) \ 2
        End If
        For i As Integer = 0 To point 'Et nous inversons l'ordre du tableau
            perstmp = tab(i)
            tab(i) = tab(nbpers - i)
            tab(nbpers - i) = perstmp
        Next

    End Sub

End Module
