Class labels


    Dim joueuer As Integer = 0 ' on suppose que le jouer  A qui prend le relais des le debut
    Dim listDesLabels As Collection

    Private Sub I_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I_0.Click
        peutRejouer(I_0, 0)
        Fonctions.jouer(0)
        mettreAjour(joueuer)
    End Sub

    Private Sub I_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I_1.Click
        peutRejouer(I_1, 1)
        Fonctions.jouer(1)
        mettreAjour(joueuer)
    End Sub


    Private Sub I_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I_2.Click
        peutRejouer(I_2, 2)

        Fonctions.jouer(2)
        mettreAjour(joueuer)
    End Sub

    Private Sub I_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I_3.Click
        peutRejouer(I_3, 3)
        Fonctions.jouer(3)
        mettreAjour(joueuer)
    End Sub

    Private Sub I_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I_4.Click
        peutRejouer(I_4, 4)
        Fonctions.jouer(4)
        mettreAjour(joueuer)
    End Sub

    Private Sub I_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I_5.Click
        peutRejouer(I_5, 5)
        Fonctions.jouer(5)
        mettreAjour(joueuer)
    End Sub

    Private Sub J_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J_0.Click
        peutRejouer(J_0, 7)
        Fonctions.jouer(7 + 0)
        mettreAjour(joueuer)
    End Sub

    Private Sub J_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J_1.Click
        peutRejouer(J_1, 8)
        Fonctions.jouer(7 + 1)
        mettreAjour(joueuer)
    End Sub


    Private Sub J_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J_2.Click
        peutRejouer(J_2, 9)
        Fonctions.jouer(7 + 2)
        mettreAjour(joueuer)
    End Sub

    Private Sub J_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J_3.Click
        peutRejouer(J_3, 10)
        Fonctions.jouer(7 + 3)
        mettreAjour(joueuer)
    End Sub

    Private Sub J_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J_4.Click
        peutRejouer(J_4, 11)
        Fonctions.jouer(7 + 4)
        mettreAjour(joueuer)
    End Sub

    Private Sub J_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles J_5.Click
        peutRejouer(J_5, 12)
        Fonctions.jouer(7 + 5)
        mettreAjour(joueuer)
    End Sub


    Private Sub labels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reinitialiser()
    End Sub



    'subs 




    Sub mettreAjour(ByRef y As Integer)

        tour(y)

        For i As Integer = 1 To Fonctions.tableau.Length

            Dim b As Label = listDesLabels.Item(i)

            Dim val As Integer = Fonctions.tableau(i - 1)

            b.Text = Str(val)

        Next

        If Fonctions.jeutermine() Then
            Dim gagnant As String

            If tableau(6) > tableau(13) Then
                gagnant = "le joueur A gangne !"

            ElseIf tableau(6) < tableau(13) Then
                gagnant = "le joueur B gangne !"
            Else

                gagnant = "match nul"


            End If

            MsgBox("Jeu terminé, " + gagnant)

        End If

    End Sub

    Private Sub tour(ByRef i As Integer)
        If Not peutjouer(i) Then ' si un joueuer ne peut  pas jouer, l'adversaire tient le role 
            i = (i + 1) Mod 2 ' pour abréger:  si y=0 then y=1, si y=1 then y=0
        End If
        If i = 0 Then
            activerA()
            desactiverB()

        ElseIf i = 1 Then
            activerB()
            desactiverA()
        End If
        i = (i + 1) Mod 2
    End Sub

    Private Sub Reinitialiser()
        joueuer = 0

        listDesLabels = New Collection ' un ensemble pour acceder aux controles de facçon iterative

        listDesLabels.Add(I_0)
        listDesLabels.Add(I_1)
        listDesLabels.Add(I_2)
        listDesLabels.Add(I_3)
        listDesLabels.Add(I_4)
        listDesLabels.Add(I_5)
        listDesLabels.Add(I_panier)
        '
        listDesLabels.Add(J_0)
        listDesLabels.Add(J_1)
        listDesLabels.Add(J_2)
        listDesLabels.Add(J_3)
        listDesLabels.Add(J_4)
        listDesLabels.Add(J_5)
        listDesLabels.Add(J_panier)

        Fonctions.initialiser()
        mettreAjour(joueuer)

    End Sub


    Private Sub activerA()
        For y As Integer = 0 To 5
            Dim b As Label = listDesLabels.Item(y + 1) ' les controles de A
            If Fonctions.tableau(y) = 0 Then

                b.Enabled = False

                b.BackColor = Color.White
            Else
                b.Enabled = True

                b.BackColor = Color.AliceBlue




            End If
        Next

    End Sub



    Private Sub desactiverA()
        For y As Integer = 0 To 5
            Dim b As Label = listDesLabels.Item(y + 1) ' les controles de A
            b.Enabled = False
            b.BackColor = Color.White
        Next

    End Sub


    Private Sub activerB()
        For y As Integer = 7 To 12
            Dim b As Label = listDesLabels.Item(y + 1) ' les controles de B

            If Fonctions.tableau(y) = 0 Then

                b.Enabled = False
                b.BackColor = Color.White
            Else
                b.Enabled = True
                b.BackColor = Color.AliceBlue
            End If
        Next

    End Sub




    Private Sub desactiverB()

        For y As Integer = 7 To 12
            Dim b As Label = listDesLabels.Item(y + 1) ' les controles de B
            b.Enabled = False
            b.BackColor = Color.White
        Next

    End Sub

    Private Sub peutRejouer(ByRef btn As Label, ByVal position As Integer)
        Dim val As Integer = CInt(btn.Text)

        If position < 6 Then
            If val + position = 6 Mod 14 Then
                joueuer = (joueuer + 1) Mod 2
            End If
        Else
            If val + position = 13 Mod 14 Then
                joueuer = (joueuer + 1) Mod 2
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Reinitialiser()

    End Sub
End Class
