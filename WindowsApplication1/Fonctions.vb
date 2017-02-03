Module Fonctions
    ' le jeu consiste en un tableau de 14 case contenant les cases du joueur A et celles du 
    ' joueur B, plus leurs panier 
    ' les cases de A vont de l'indice 0 jusqu'à 5, le 6 est pour son panier 
    ' celles de B vont de 7 à 12 , 13 étant son panier
    ' pour que le tableau respecte la règle du jeu, les indices sont calculés de façon modulaire : modulo 14 

    Public tableau(13) As Integer

    'cette fonction sert à déterminer si le joueuer passé en paramètres a la possibilité de jouer ou non,
    ' un joueuer peut jouer s'il a au moins une case non vide(i.e non égale à 0)

    Public Function peutjouer(ByVal i As Integer) As Boolean

        Dim idx As Integer
        Dim possibilite As Boolean = False


        If i = 0 Then
            idx = 0 'pour le premier joueur
        Else
            idx = 7 'pour le 2ème joueur

        End If

        For y As Integer = idx To idx + 5

            If tableau(y) <> 0 Then

                possibilite = True
            End If

        Next

        peutjouer = possibilite

    End Function

    'cette fonction répartit les jetons dans ledit tableau,
    'en testant au préalable la possibilité de jouer.
    ' le paramètre i étant le numéro du joueur 0 pour A, 1 pour B 

    Public Sub jouer(ByVal i As Integer)

        Dim possibilite As Boolean


        If i <= 5 Then

            possibilite = peutjouer(0)

        Else
            possibilite = peutjouer(1)


        End If

        Dim idx As Integer = i + 1

        If possibilite = True Then


            'cette boucle répartit les jetons dans le tableau dans les 
            'cases qui suivent de manière circulaire

            While tableau(i) > 0
                tableau(idx Mod 14) += 1
                tableau(i Mod 14) -= 1
                idx += 1
            End While

        End If
    End Sub

    'cette méthode remet le tableau  à son état initial
    Public Sub initialiser()

        For i As Integer = 0 To tableau.Length - 1
            If i <> 6 And i <> 13 Then

                tableau(i) = 3

            Else
                tableau(i) = 0
            End If
        Next

    End Sub

    'le jeu est terminé quand toutes les cases sont vides 
    Public Function jeutermine() As Boolean

        jeutermine = peutjouer(0) = False And peutjouer(1) = False

    End Function



     
End Module
