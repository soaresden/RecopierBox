Imports System.IO
Imports System.Threading
Imports System.Linq
Imports System.Drawing.Imaging

Public Class Quizz

    Private Sub Quizz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On alimente le gamelist
        For Each foundDirectory In Directory.GetDirectories(My.Settings.RecalboxFolder & "\roms", ".", SearchOption.TopDirectoryOnly)
            If File.Exists(foundDirectory & "\gamelist.xml") Then
                Dim nomconsole = foundDirectory.Substring((InStr(foundDirectory, "roms\",) + 4))
                ConsoleList.Items.Add(nomconsole)
            End If
        Next
        'On hide le groupe parametres
        'Afficher le groupParametres

        GroupFiltres.Hide()
        GroupConfigPartie.Hide()
        ButtonDoRandom1.Hide()
        GroupConfigPartie.Hide()
        Label10.Hide()
        TxtTotalEntrees.Hide()
        Label20.Hide()
        ButtonInfo.Hide()

        TabControl1.Hide()
        TitleBox.Hide()
        GroupDifficulty.Hide()
    End Sub
    Private Sub ButtonGetBack1_Click(sender As Object, e As EventArgs) Handles ButtonGetBack1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ButtonValidConsole1_Click(sender As Object, e As EventArgs) Handles ButtonValidConsole1.Click
        'On stop par securité
        PlayerStop.PerformClick()

        'Afficher le groupParametres
        GroupConfigPartie.Show()

        'On va hider le bouton des console + jeu si un seul systeme est selectionné
        If ConsoleList.SelectedItems.Count = 1 Then
            ConsoleTitre.Hide()
            ListConsoleDesJeux.Hide()
            PasTitreNiConsole.Show()
        Else
            ConsoleTitre.Show()
            ListConsoleDesJeux.Show()
            PasTitreNiConsole.Show()
        End If

        'On met le tooltip
        ToolTipNbJeux.SetToolTip(TxtTotalEntrees, "Ce nombre représente le nombre de jeux total filtré. Plus vous avez un grand chiffre, Meilleur sera l'aléatoire")

        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If ConsoleList.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner une/des Consoles")
            Exit Sub
        End If

        'On affiche les listboxhelpers
        listhelpingboxGenre.Show()
        listhelpingboxDev.Show()
        listhelpingboxPubl.Show()
        listhelpingboxAnnee.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPlayCount.Show()
        listhelpingboxNote.Show()
        'Showing stuff


        If ConsoleList.Items.Count = 0 Then Exit Sub

        Dim gamelist As String = ConsoleList.Items(0)
        Dim table As New DataTable()
        Dim dv As DataView

        Dim column As DataColumn

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Console"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Titre"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminRom"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Synopsis"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminImage"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminVideo"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Genre"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Note"
        End With
        table.Columns.Add(column)


        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Developer"
        End With
        table.Columns.Add(column)


        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Publisher"
        End With
        table.Columns.Add(column)


        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "NbPlayers"
        End With
        table.Columns.Add(column)


        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "DateSortie"
        End With
        table.Columns.Add(column)


        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "NbLancé"
        End With
        table.Columns.Add(column)

        'Loop for every gamelists
        For Each i In ConsoleList.SelectedItems

            'generating the console name
            Dim nomconsole As String = i
            Dim consolederom As String = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\gamelist.xml"
            gamelist = consolederom

            Dim gamelistXml As XElement = XElement.Load(gamelist)

            'getting the list for the xml with nodes
            Dim query2 = From st In gamelistXml.Descendants("game") Select st

            For Each xEle As XElement In query2
                Dim romconsole As String = nomconsole
                Dim romname As String = xEle.Element("name")
                Dim romId As String
                Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
                Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & temprom
                Dim romgenre As String
                Dim romdesc As String
                Dim romimage As String
                Dim romvideo As String
                Dim romnote As String
                Dim romdev As String
                Dim rompubl As String
                Dim romnbplayers As String
                Dim romdate As String
                Dim romCompteur As String
                Dim romhidden As String = xEle.Element("hidden")

                'Conditionnelles sur tous les champs
                If romhidden = "true" Then GoTo romsuivante 'si la rom est hidden, on l'affiche pas (Roms multicd)

                If xEle.Element("video") Is Nothing Then
                    GoTo romsuivante
                Else
                    romvideo = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & Replace(Replace(Replace(xEle.Element("video"), "/", "\"), "./", ""), ".\", "")
                End If

                Dim ExistGameId As Boolean = xEle.Attributes("id").Any

                If ExistGameId = True Then
                    romId = xEle.Attribute("id").Value
                Else
                    romId = Nothing
                End If

                If xEle.Element("desc") Is Nothing Then
                    romdesc = Nothing
                Else
                    romdesc = xEle.Element("desc")
                End If

                If xEle.Element("image") Is Nothing Then
                    romimage = Nothing
                Else
                    romimage = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & Replace(Replace(Replace(xEle.Element("image"), "/", "\"), "./", ""), ".\", "")
                End If

                If xEle.Element("genre") Is Nothing Then
                    romgenre = Nothing
                Else
                    romgenre = xEle.Element("genre")
                End If

                If xEle.Element("rating") Is Nothing Then
                    romnote = Nothing
                Else
                    romnote = xEle.Element("rating")
                End If

                If xEle.Element("rating") Is Nothing Then
                    romnote = Nothing
                Else
                    romnote = xEle.Element("rating")
                End If

                If xEle.Element("developer") Is Nothing Then
                    romdev = Nothing
                Else
                    romdev = xEle.Element("developer")
                End If

                If xEle.Element("publisher") Is Nothing Then
                    rompubl = Nothing
                Else
                    rompubl = xEle.Element("publisher")
                End If

                If xEle.Element("players") Is Nothing Then
                    romnbplayers = Nothing
                Else
                    romnbplayers = xEle.Element("players")
                End If

                If xEle.Element("releasedate") Is Nothing Then
                    romdate = Nothing
                Else
                    romdate = xEle.Element("releasedate")
                End If

                If xEle.Element("playcount") Is Nothing Then
                    romCompteur = Nothing
                Else
                    romCompteur = xEle.Element("playcount")
                End If

                'on ajoute le tout dans une table
                table.Rows.Add(romconsole, romname, rompath, romdesc, romimage, romvideo, romgenre, romnote, romdev, rompubl, romnbplayers, romdate, romCompteur)
romsuivante:
            Next
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        TempGrid.DataSource = table

        'Width for columns
        TempGrid.Columns("Console").Width = 50
        TempGrid.Columns("Titre").Width = 190

        TempGrid.Columns("CheminRom").Visible = False
        TempGrid.Columns("CheminRom").Width = 50

        TempGrid.Columns("Synopsis").Visible = False
        TempGrid.Columns("Synopsis").Width = 50

        TempGrid.Columns("CheminImage").Visible = False
        TempGrid.Columns("CheminImage").Width = 50

        TempGrid.Columns("CheminVideo").Visible = False
        TempGrid.Columns("CheminVideo").Width = 50

        TempGrid.Columns("Genre").Visible = False
        TempGrid.Columns("Genre").Width = 50

        TempGrid.Columns("Note").Visible = False
        TempGrid.Columns("Note").Width = 50

        TempGrid.Columns("Developer").Visible = False
        TempGrid.Columns("Developer").Width = 50

        TempGrid.Columns("Publisher").Visible = False
        TempGrid.Columns("Publisher").Width = 50

        TempGrid.Columns("NbPlayers").Visible = False
        TempGrid.Columns("NbPlayers").Width = 50

        TempGrid.Columns("DateSortie").Visible = True
        TempGrid.Columns("DateSortie").Width = 50

        TempGrid.Columns("NbLancé").Visible = False
        TempGrid.Columns("NbLancé").Width = 50

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, Titre asc"

        'On compte le nombre total d'entrées
        TxtTotalEntrees.Text = TempGrid.Rows.Count - 1

        'On va alimenter les filtres de la combobox 
        PeuplerCombobox()

        'On affiche pas la partie des options pour forcer la saisie
        Label17.Hide()
        Label11.Hide()
        txtnbmanches.Hide()
        Label16.Hide()
        txttempsaffichprop.Hide()
        'Focus sur le nombre de parties
        txtnbmanches.Focus()
    End Sub
    Sub PeuplerCombobox()
        Dim valeur As String
        For ligne = 0 To TempGrid.RowCount - 1

            If IsDBNull(TempGrid.Rows(ligne).Cells(TempGrid.Columns("Genre").Index).Value) = True Or IsNothing(TempGrid.Rows(ligne).Cells(TempGrid.Columns("Genre").Index).Value) = True Then
                GoTo suite1
            Else
                valeur = TempGrid.Rows(ligne).Cells(TempGrid.Columns("Genre").Index).Value ' on check si la valeur est déja presente ou non
                If listhelpingboxGenre.Items.Contains(valeur) Then
                    listhelpingboxGenre.Items.Remove(valeur)
                Else
                    listhelpingboxGenre.Items.Add(valeur) ' si non on l'ajoute
                End If
suite1:
            End If

            If IsDBNull(TempGrid.Rows(ligne).Cells(TempGrid.Columns("Developer").Index).Value) = True Or IsNothing(TempGrid.Rows(ligne).Cells(TempGrid.Columns("Developer").Index).Value) = True Then
                GoTo suite2
            Else
                valeur = TempGrid.Rows(ligne).Cells(TempGrid.Columns("Developer").Index).Value ' on check si la valeur est déja presente ou non
                If listhelpingboxDev.Items.Contains(valeur) Then
                    listhelpingboxDev.Items.Remove(valeur)
                Else
                    listhelpingboxDev.Items.Add(valeur) ' si non on l'ajoute
                End If
suite2:
            End If

            If IsDBNull(TempGrid.Rows(ligne).Cells(TempGrid.Columns("Publisher").Index).Value) = True Or IsNothing(TempGrid.Rows(ligne).Cells(TempGrid.Columns("Publisher").Index).Value) = True Then
                GoTo suite3
            Else
                valeur = TempGrid.Rows(ligne).Cells(TempGrid.Columns("Publisher").Index).Value ' on check si la valeur est déja presente ou non
                If listhelpingboxPubl.Items.Contains(valeur) Then
                    listhelpingboxPubl.Items.Remove(valeur)
                Else
                    listhelpingboxPubl.Items.Add(valeur) ' si non on l'ajoute
                End If
suite3:
            End If

            If IsDBNull(TempGrid.Rows(ligne).Cells(TempGrid.Columns("NbPlayers").Index).Value) = True Or IsNothing(TempGrid.Rows(ligne).Cells(TempGrid.Columns("NbPlayers").Index).Value) = True Then
                GoTo suite4
            Else
                valeur = TempGrid.Rows(ligne).Cells(TempGrid.Columns("NbPlayers").Index).Value ' on check si la valeur est déja presente ou non
                If listhelpingboxPlayers.Items.Contains(valeur) Then
                    listhelpingboxPlayers.Items.Remove(valeur)
                Else
                    listhelpingboxPlayers.Items.Add(valeur) ' si non on l'ajoute
                End If
suite4:
            End If

            If IsDBNull(TempGrid.Rows(ligne).Cells(TempGrid.Columns("Note").Index).Value) = True Or IsNothing(TempGrid.Rows(ligne).Cells(TempGrid.Columns("Note").Index).Value) = True Then
                GoTo suite5
            Else
                valeur = TempGrid.Rows(ligne).Cells(TempGrid.Columns("Note").Index).Value ' on check si la valeur est déja presente ou non
                If listhelpingboxNote.Items.Contains(valeur) Then
                    listhelpingboxNote.Items.Remove(valeur)
                Else
                    listhelpingboxNote.Items.Add(valeur) ' si non on l'ajoute

                End If
suite5:
            End If


            If IsDBNull(TempGrid.Rows(ligne).Cells(TempGrid.Columns("DateSortie").Index).Value) = True Or IsNothing(TempGrid.Rows(ligne).Cells(TempGrid.Columns("DateSortie").Index).Value) = True Then
                GoTo suite6
            Else
                valeur = TempGrid.Rows(ligne).Cells(TempGrid.Columns("DateSortie").Index).Value ' on check si la valeur est déja presente ou non
                If valeur = Nothing Then GoTo suite6
                Dim annee As String = valeur.Substring(0, 4)
                If listhelpingboxAnnee.Items.Contains(annee) Then
                    listhelpingboxAnnee.Items.Remove(annee)
                Else
                    listhelpingboxAnnee.Items.Add(annee) ' si non on l'ajoute

                End If
suite6:
            End If


        Next
    End Sub

    'Ensemble Got Focus et Leave Focus pour les listboxes
    Private Sub Txtgenre_GotFocus(sender As Object, e As EventArgs) Handles txtgenre.GotFocus
        'On hide tout
        listhelpingboxGenre.Hide()
        listhelpingboxDev.Hide()
        listhelpingboxPubl.Hide()
        listhelpingboxAnnee.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPlayCount.Hide()
        listhelpingboxNote.Hide()
        'Sauf
        listhelpingboxGenre.Show()
        'On met la bonne en haut
        listhelpingboxGenre.BringToFront()
        'On resize la bonne
        listhelpingboxGenre.Location = New Point(2, 15)
        listhelpingboxGenre.Size = New Point(145, 300)
    End Sub
    Private Sub Txtdev_GotFocus(sender As Object, e As EventArgs) Handles txtdev.GotFocus
        'On hide tout
        listhelpingboxGenre.Hide()
        listhelpingboxDev.Hide()
        listhelpingboxPubl.Hide()
        listhelpingboxAnnee.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPlayCount.Hide()
        listhelpingboxNote.Hide()
        'Sauf
        listhelpingboxDev.Show()
        'On met la bonne en haut
        listhelpingboxDev.BringToFront()
        'On resize la bonne
        listhelpingboxDev.Location = New Point(2, 15)
        listhelpingboxDev.Size = New Point(145, 300)
    End Sub
    Private Sub Txtpub_GotFocus(sender As Object, e As EventArgs) Handles txtpub.GotFocus
        'On hide tout
        listhelpingboxGenre.Hide()
        listhelpingboxDev.Hide()
        listhelpingboxPubl.Hide()
        listhelpingboxAnnee.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPlayCount.Hide()
        listhelpingboxNote.Hide()
        'Sauf
        listhelpingboxPubl.Show()
        'On met la bonne en haut
        listhelpingboxPubl.BringToFront()
        'On resize la bonne
        listhelpingboxPubl.Location = New Point(2, 15)
        listhelpingboxPubl.Size = New Point(145, 300)
    End Sub
    Private Sub TxtAnnee_GotFocus(sender As Object, e As EventArgs) Handles TxtAnnee.GotFocus
        'On hide tout
        listhelpingboxGenre.Hide()
        listhelpingboxDev.Hide()
        listhelpingboxPubl.Hide()
        listhelpingboxAnnee.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPlayCount.Hide()
        listhelpingboxNote.Hide()
        'Sauf
        listhelpingboxAnnee.Show()
        'On met la bonne en haut
        listhelpingboxAnnee.BringToFront()
        'On resize la bonne
        listhelpingboxAnnee.Location = New Point(2, 15)
        listhelpingboxAnnee.Size = New Point(145, 300)
    End Sub
    Private Sub Txtplayers_GotFocus(sender As Object, e As EventArgs) Handles txtplayers.GotFocus
        'On hide tout
        listhelpingboxGenre.Hide()
        listhelpingboxDev.Hide()
        listhelpingboxPubl.Hide()
        listhelpingboxAnnee.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPlayCount.Hide()
        listhelpingboxNote.Hide()
        'Sauf
        listhelpingboxPlayers.Show()
        'On met la bonne en haut
        listhelpingboxPlayers.BringToFront()
        'On resize la bonne
        listhelpingboxPlayers.Location = New Point(2, 15)
        listhelpingboxPlayers.Size = New Point(145, 300)
    End Sub
    Private Sub TxtPlayCount_GotFocus(sender As Object, e As EventArgs) Handles TxtPlayCount.GotFocus
        'On hide tout
        listhelpingboxGenre.Hide()
        listhelpingboxDev.Hide()
        listhelpingboxPubl.Hide()
        listhelpingboxAnnee.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPlayCount.Hide()
        listhelpingboxNote.Hide()
        'Sauf
        listhelpingboxPlayCount.Show()
        'On met la bonne en haut
        listhelpingboxPlayCount.BringToFront()
        'On resize la bonne
        listhelpingboxPlayCount.Location = New Point(2, 15)
        listhelpingboxPlayCount.Size = New Point(145, 300)
    End Sub
    Private Sub TxtSynopsis_GotFocus(sender As Object, e As EventArgs) Handles TxtSynopsis.GotFocus
        'On hide tout
        listhelpingboxGenre.Hide()
        listhelpingboxDev.Hide()
        listhelpingboxPubl.Hide()
        listhelpingboxAnnee.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPlayCount.Hide()
        listhelpingboxNote.Hide()
    End Sub
    Private Sub TxtRating_GotFocus(sender As Object, e As EventArgs) Handles TxtRating.GotFocus
        'On hide tout
        listhelpingboxGenre.Hide()
        listhelpingboxDev.Hide()
        listhelpingboxPubl.Hide()
        listhelpingboxAnnee.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPlayCount.Hide()
        listhelpingboxNote.Hide()
        'Sauf
        listhelpingboxNote.Show()
        'On met la bonne en haut
        listhelpingboxNote.BringToFront()
        'On resize la bonne
        listhelpingboxNote.Location = New Point(2, 15)
        listhelpingboxNote.Size = New Point(145, 300)
    End Sub
    Private Sub TxtSynopsis_LostFocus(sender As Object, e As EventArgs) Handles TxtSynopsis.GotFocus
        listhelpingboxGenre.Show()
        listhelpingboxDev.Show()
        listhelpingboxPubl.Show()
        listhelpingboxAnnee.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPlayCount.Show()
        listhelpingboxNote.Show()
    End Sub
    Sub Entreesurfiltres()
        'commande pour filtrer
        TryCast(TempGrid.DataSource, DataTable).DefaultView.RowFilter = String.Format("[Genre] Like '%{0}%' AND [Developer] like '%{1}%' AND [Publisher] like '%{2}%' AND [DateSortie] like '%{3}%' AND [NbPlayers] like '%{4}%' AND [NbLancé] like '%{5}%' AND [Synopsis] like '%{6}%' AND [Note] like '%{7}%'", txtgenre.Text, txtdev.Text, txtpub.Text, TxtAnnee.Text, txtplayers.Text, TxtPlayCount.Text, TxtSynopsis.Text, TxtRating.Text)
        'Recalcul des resultats
        TxtTotalEntrees.Text = TempGrid.RowCount - 1
    End Sub
    Private Sub Txtgenre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtgenre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub
    Private Sub Txtdev_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdev.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub
    Private Sub Txtpub_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpub.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub
    Private Sub TxtAnnee_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAnnee.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub
    Private Sub Txtplayers_KeyDown(sender As Object, e As KeyEventArgs) Handles txtplayers.KeyDown
        If e.KeyCode = Keys.Enter Then
        End If
    End Sub
    Private Sub TxtPlayCount_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPlayCount.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub
    Private Sub TxtSynopsis_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSynopsis.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub
    Private Sub ComboRating_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRating.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub
    Private Sub ButtonDoRandom1_Click(sender As Object, e As EventArgs) Handles ButtonDoRandom1.Click
        If txtnbmanches.Text <= 0 Then
            MsgBox("Impossible de Générer des Manches")
            txtnbmanches.Focus()
            Exit Sub
        End If

        If Val(txtnbmanches.Text) > Val(TxtTotalEntrees.Text) Then
            MsgBox("Trop de Manches > Nb Roms dans le(s) Gamelist(s)")
            Exit Sub
        End If

        If TxtTotalEntrees.Text < 12 Then
            MsgBox("Votre Total Roms doit etre Superieur à 12")
            Exit Sub
        End If

        Dim nbdemanches As Integer = Val(txtnbmanches.Text)
        Dim nbroms As Integer = TxtTotalEntrees.Text

        'On Clear par securité
        RandomList.Items.Clear()
        'On enleves toutes les listbox de reponses par securité
        ListTitreDesJeux.Items.Clear()
        ListConsoleDesJeux.Items.Clear()

        'On remplit la randobox de toutes les possibilités
        listrandobox.Items.Clear()
        Dim rando As Integer
        For rando = 0 To TxtTotalEntrees.Text - 1
            listrandobox.Items.Add(rando)
        Next

        'On va generer un chiffre et tester
        Dim rnd As New Random
        Dim x As Integer

        'On clear par securité
        RandomList.Items.Clear()
        Historique.Items.Clear()

        Do Until RandomList.Items.Count = nbdemanches
recalculrando:
            x = listrandobox.Items(rnd.Next(0, listrandobox.Items.Count - 1)) 'generer un chiffre entre 0 et le nb de roms
            Dim xremade As Integer = (x + 5) * 37

            If Not RandomList.Items.Contains(xremade) Then
                RandomList.Items.Add(xremade) 'si le titre n'est pas present, on l'ajoute dans la liste des titres

                'on va creer le log historique
                Dim nomdujeu = TempGrid.Rows(x).Cells(TempGrid.Columns("Console").Index).Value & " (" & TempGrid.Rows(x).Cells(TempGrid.Columns("DateSortie").Index).Value.ToString.Substring(0, 4) & ") - " & TempGrid.Rows(x).Cells(TempGrid.Columns("Titre").Index).Value
                Historique.Items.Add(nomdujeu) ' on ajoute a la liste
            End If
            listrandobox.Items.Remove(x)
        Loop

        'On Remet la temp listbox en vide
        listrandobox.Items.Clear()

        'On va maintenant Charger les options du jeu
        GroupDifficulty.Show()
    End Sub
    Sub afficherlesoptions()
        txtnbmanches.Show()
        txtnbmanches.Focus()
        Label16.Show()
        Label17.Show()
        Label11.Show()
        txttempsaffichprop.Show()
    End Sub
    Private Sub TitreOnly_CheckedChanged(sender As Object, e As EventArgs) Handles TitreOnly.CheckedChanged
        Call afficherlesoptions()
        Call PlayerStop.PerformClick()
    End Sub
    Private Sub ConsoleTitre_CheckedChanged(sender As Object, e As EventArgs) Handles ConsoleTitre.CheckedChanged
        Call afficherlesoptions()
        Call PlayerStop.PerformClick()
    End Sub
    Private Sub PasTitreNiConsole_CheckedChanged(sender As Object, e As EventArgs) Handles PasTitreNiConsole.CheckedChanged
        Call afficherlesoptions()
        Call PlayerStop.PerformClick()
    End Sub
    Private Sub Txtnbmanches_TextChanged(sender As Object, e As EventArgs) Handles txtnbmanches.TextChanged
        If txtnbmanches.Text Is Nothing Or txtnbmanches.Text = "" Then
            Label20.Hide()
            ButtonInfo.Hide()
            Label10.Hide()
            TxtTotalEntrees.Hide()
            ButtonDoRandom1.Hide()
            Exit Sub
        Else
            If TitreOnly.Checked = False And ConsoleTitre.Checked = False And PasTitreNiConsole.Checked = False Then
                Label20.Hide()
                ButtonInfo.Hide()
                Label10.Hide()
                TxtTotalEntrees.Hide()
                ButtonDoRandom1.Hide()
                Exit Sub
            End If

            'On a tout, on peut afficher
            Label20.Show()
            ButtonInfo.Show()
            Label10.Show()
            TxtTotalEntrees.Show()

            ButtonDoRandom1.Show()
            txtpositionend.Text = txtnbmanches.Text
        End If
    End Sub
    Private Sub Txtnbmanches_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnbmanches.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonDoRandom1.PerformClick()
        End If
    End Sub

    Private Sub RandomList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RandomList.SelectedIndexChanged
        txtpositionrandom.Text = RandomList.SelectedIndex + 1
        Historique.SelectedIndex = RandomList.SelectedIndex 'on change aussi celui qui est selectionné dans l'historique
        PlayerStop.PerformClick()

        'calcul du vrai chiffre 
        Dim chiffreactuel = RandomList.SelectedItem
        If chiffreactuel = Nothing Then Exit Sub
        Dim vraichiffre As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString) / 37 - 5

        TempGrid.ClearSelection()
        TempGrid.CurrentCell = TempGrid.Item("Titre", CInt(vraichiffre))

        If TabControl1.SelectedTab Is TabPage2 Then
            TabControl1.SelectedTab = TabPage2
        Else
            TabControl1.SelectedTab = TabPage1
        End If
    End Sub


    Private Sub PlayerNext_Click(sender As Object, e As EventArgs) Handles PlayerNext.Click
        Dim selectionactuelle = RandomList.SelectedIndex
        If selectionactuelle >= txtpositionend.Text - 1 Then Exit Sub
        PlayerVideo.Ctlcontrols.stop()
        RandomList.SelectedIndex = selectionactuelle + 1
        ListTitreDesJeux.Items.Clear()
        'On securise en mettant le player en hide
        PlayerVideo.uiMode = "none"
    End Sub

    Private Sub PlayerPrev_Click(sender As Object, e As EventArgs) Handles PlayerPrev.Click
        Dim selectionactuelle = RandomList.SelectedIndex
        If selectionactuelle <= 0 Then Exit Sub
        PlayerVideo.Ctlcontrols.stop()
        RandomList.SelectedIndex = selectionactuelle - 1
        ListTitreDesJeux.Items.Clear()
        'On securise en mettant le player en hide
        PlayerVideo.uiMode = "none"
    End Sub

    Private Sub PlayerPlay_Click(sender As Object, e As EventArgs) Handles PlayerPlay.Click
        'test pour voir si c'est à l'arret ou en play
        If (PlayerVideo.playState = WMPLib.WMPPlayState.wmppsPlaying) Then 'Si c'est play 
            Exit Sub
        ElseIf PlayerVideo.playState = WMPLib.WMPPlayState.wmppsStopped Or PlayerVideo.playState = WMPLib.WMPPlayState.wmppsStopped = 0 Then 'Si c'est stoppé on load la video
            Dim lavraieligne As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString) / 37 - 5
            PlayerVideo.URL = TempGrid.Rows(lavraieligne).Cells(TempGrid.Columns("CheminVideo").Index).Value
            'En fonction des choix ci dessus
            If VidNormal.Checked = True Then
                PlayerVideo.uiMode = "none"
            End If
            If VidSans.Checked = True Then
                PlayerVideo.uiMode = "invisible"
            End If
            If VidPixel.Checked = True Then
                PlayerVideo.uiMode = "none"
            End If

            If SonAvec.Checked = True Then
                PlayerVideo.settings.mute = False
            End If
            If SonSans.Checked = True Then
                PlayerVideo.settings.mute = True
            End If

            If PlayerOnce.Checked = True Then
                PlayerVideo.settings.setMode("loop", False)
            End If
            If PlayerRepeat.Checked = True Then
                PlayerVideo.settings.setMode("loop", True)
            End If

            PlayerVideo.Ctlcontrols.play()
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = PlayerVideo.currentMedia.duration

            Timer1.Start()
            TimeBox.Text = ""

            'On enleve la liste des jeux par securite
            ListTitreDesJeux.Items.Clear()

            'On remplit la randobox de toutes les possibilités
            listrandobox.Items.Clear()
            Dim rando As Integer
            For rando = 0 To TxtTotalEntrees.Text - 1
                listrandobox.Items.Add(rando)
            Next

            'et on enleve le bon chiffre
            listrandobox.Items.Remove(lavraieligne)
        End If
    End Sub
    Private Sub PlayerStop_Click(sender As Object, e As EventArgs) Handles PlayerStop.Click
        PlayerVideo.Ctlcontrols.stop()
        Timer1.Stop()
        TimeBox.Text = ""
        TimeBox.BackColor = Color.FromArgb(72, 61, 139)

        'Remettre les champs en modifiable
        txtnbmanches.ReadOnly = False
        txtnbmanches.BackColor = Color.FromArgb(0, 102, 204)

        txttempsaffichprop.ReadOnly = False
        txttempsaffichprop.BackColor = Color.FromArgb(0, 102, 204)

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = PlayerVideo.currentMedia.duration
        ProgressBar1.Value = PlayerVideo.Ctlcontrols.currentPosition
        ProgressBar1.Increment(1)
        Dim tpsrestant As Double
        tpsrestant = PlayerVideo.currentMedia.duration - PlayerVideo.Ctlcontrols.currentPosition
        TimeBox.Text = tpsrestant.ToString("00.0")

        'On va bloquer les nb manches et le temps
        If PlayerVideo.playState.wmppsPlaying = True Then
            txtnbmanches.ReadOnly = True
            txtnbmanches.BackColor = Color.FromArgb(172, 172, 172)

            txttempsaffichprop.ReadOnly = True
            txttempsaffichprop.BackColor = Color.FromArgb(172, 172, 172)
        End If

        'On check le temps des propositions
        Dim tempsprop As String = txttempsaffichprop.Text

        'si le mode pas de proposition, on fait juste la couleur donc on arrete
        If PasTitreNiConsole.Checked = True Then Exit Sub

        'On envoie la couleur
        If ProgressBar1.Value <= tempsprop Then 'Si c'est avant les propositions c'est VERT
            SendMessage(ProgressBar1.Handle, 1040, 1, 0)
            TimeBox.BackColor = Color.FromArgb(6, 176, 37)

            'si c'est en mode pixel on va pixelliser à mesure
            If VidPixel.Checked = True Then

            End If

        ElseIf ProgressBar1.Value >= tempsprop And ProgressBar1.Value < (0.8 * ProgressBar1.Maximum) Then 'Si c'est avant les propositions c'est ORANGE
            SendMessage(ProgressBar1.Handle, 1040, 3, 0)
            TimeBox.BackColor = Color.FromArgb(218, 203, 38)
        Else 'Sinon c'est rouge
            SendMessage(ProgressBar1.Handle, 1040, 2, 0)
            TimeBox.BackColor = Color.FromArgb(218, 38, 38)
        End If

        Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString) / 37 - 5
        Dim titreencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Titre").Index).Value
        Dim consoleencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Console").Index).Value

        '############SI C'EST QUIZZ TITRE + CONSOLE #################
        If ConsoleTitre.Checked = True Then ' Titre Et Consoles
            RandomizerPropositions(titreencours, consoleencours)
        End If
        '########### CHECK DU TEMPS POUR LES TITRES ONLY ###############
        If PlayerVideo.Ctlcontrols.currentPosition < tempsprop Then Exit Sub
        '############SI C'EST QUIZZ TITRE#################
        If TitreOnly.Checked = True Then ' Titre Et Consoles
            RandomizerPropositions(titreencours, consoleencours)
        End If
    End Sub
    Sub RandomizerPropositions(titreencours As String, consoleencours As String)
        Dim rnd As New Random
        Dim x As Integer
        Dim titlegen As String

        If ConsoleTitre.Checked = True Then
            If ListConsoleDesJeux.SelectedItem = Nothing Then Exit Sub 'Si on a rien selectionné, on quitte
            'Check Pour les consoles+titres
            If ListConsoleDesJeux.SelectedItem.ToString <> consoleencours Then 'si on selectionne une mauvaise console, on quitte
                Exit Sub
            End If
        End If

        'Si la liste à déja 12 propositions, on sort 
        If ListTitreDesJeux.Items.Count >= 12 Then Exit Sub

        'Pour le rando, on va parcourir tous les numeros de la randobox, et vérifier si le titre est déja dedans ou non
        Do Until ListTitreDesJeux.Items.Count > 11
            Dim nblistex As Integer = listrandobox.Items.Count
            If nblistex = 0 Then GoTo finboucle
            x = listrandobox.Items(rnd.Next(0, nblistex)) 'generer un chiffre entre 0 et le nb de roms dans la liste random
            titlegen = TempGrid.Rows(x).Cells(TempGrid.Columns("Titre").Index).Value

            'test de la presence d'un doublon 
            If x = RandomList.SelectedItem Or titlegen = titreencours Then
                GoTo looping
            End If
            If Not ListTitreDesJeux.Items.Contains(titlegen) Then ListTitreDesJeux.Items.Add(titlegen) 'si le titre n'est pas present, on l'ajoute dans la liste des titres
looping:
            listrandobox.Items.Remove(x) 'on enleve ensuite le x
        Loop
        'on ajoute le titre en cours et on range
finboucle:
        ListTitreDesJeux.Items.Add(titreencours)
        ListTitreDesJeux.Sorted = True
    End Sub
    Private Shared Sub SortIntegerListBox(ByVal listBox As ListBox)
        Dim TempList As New List(Of Integer)
        For Each LI In listBox.Items
            TempList.Add(Integer.Parse(LI.ToString()))
        Next
        TempList.Sort()
        listBox.DataSource = TempList
    End Sub
    Private Sub ListTitreDesJeux_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTitreDesJeux.SelectedIndexChanged
        'on prend le titre en cours
        Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString) / 37 - 5
        Dim titreencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Titre").Index).Value
        'on verifie si la selection est bien celle ci
        If IsNothing(ListTitreDesJeux.SelectedItem.ToString) Then Exit Sub
        If ListTitreDesJeux.SelectedItem.ToString = titreencours Then
            PlayerVideo.uiMode = "full"
            MsgBox("BIEN JOUE !")
        Else
            MsgBox("NOPE !")
        End If
    End Sub
    Private Sub ButtonShowVid_Click(sender As Object, e As EventArgs)
        Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString) / 37 - 5
        Dim videoencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("CheminVideo").Index).Value
        System.Diagnostics.Process.Start(videoencours)
    End Sub
    Private Sub VidNormal_CheckedChanged(sender As Object, e As EventArgs) Handles VidNormal.CheckedChanged
        If VidNormal.Checked = True Then
            VidSans.Checked = Not VidNormal.Checked
            VidPixel.Checked = Not VidNormal.Checked
        End If
    End Sub
    Private Sub VidSans_CheckedChanged(sender As Object, e As EventArgs) Handles VidSans.CheckedChanged
        If VidSans.Checked = True Then
            VidNormal.Checked = Not VidSans.Checked
            VidPixel.Checked = Not VidSans.Checked
        End If
    End Sub
    Private Sub VidPixel_CheckedChanged(sender As Object, e As EventArgs) Handles VidPixel.CheckedChanged
        If VidPixel.Checked = True Then
            MsgBox("Marche pas pour l'instant ^^ !")
                VidNormal.Checked = Not VidPixel.Checked
            VidSans.Checked = Not VidPixel.Checked
        End If
    End Sub
    Private Sub SonAvec_CheckedChanged(sender As Object, e As EventArgs) Handles SonAvec.CheckedChanged
        SonSans.Checked = Not SonAvec.Checked
    End Sub
    Private Sub SonSans_CheckedChanged(sender As Object, e As EventArgs) Handles SonSans.CheckedChanged
        SonAvec.Checked = Not SonSans.Checked
    End Sub
    Private Sub PlayerOnce_CheckedChanged(sender As Object, e As EventArgs) Handles PlayerOnce.CheckedChanged
        PlayerRepeat.Checked = Not PlayerOnce.Checked
    End Sub
    Private Sub PlayerRepeat_CheckedChanged(sender As Object, e As EventArgs) Handles PlayerRepeat.CheckedChanged
        PlayerOnce.Checked = Not PlayerRepeat.Checked
    End Sub
    Private Sub ListConsoleDesJeux_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListConsoleDesJeux.SelectedIndexChanged
        Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString) / 37 - 5
        Dim consoleencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Console").Index).Value
        If ListConsoleDesJeux.SelectedItem.ToString = consoleencours Then
            MsgBox("BRAVO POUR LA CONSOLE !")
        Else
            MsgBox("MAUVAISE CONSOLE !")
        End If
    End Sub
    Private Sub RandomList_DrawItem(sender As Object, e As DrawItemEventArgs) Handles RandomList.DrawItem
        Dim isItemSelected As Boolean = ((e.State And DrawItemState.Selected) = DrawItemState.Selected)
        Dim itemIndex As Integer = e.Index

        If itemIndex >= 0 AndAlso itemIndex < RandomList.Items.Count Then
            Dim g As Graphics = e.Graphics
            Dim backgroundColorBrush As SolidBrush = New SolidBrush(If((isItemSelected), Color.Red, Color.FromArgb(105, 105, 105)))
            g.FillRectangle(backgroundColorBrush, e.Bounds)
            Dim itemText As String = RandomList.Items(itemIndex).ToString()
            Dim itemTextColorBrush As SolidBrush = If((isItemSelected), New SolidBrush(Color.FromArgb(255, 255, 255)), New SolidBrush(Color.FromArgb(255, 255, 255)))
            g.DrawString(itemText, e.Font, itemTextColorBrush, RandomList.GetItemRectangle(itemIndex).Location)
            backgroundColorBrush.Dispose()
            itemTextColorBrush.Dispose()
        End If
        e.DrawFocusRectangle()
    End Sub
    Private Sub Txtnbmanches_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnbmanches.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" _
(ByVal hWnd As IntPtr, ByVal wCmd As Integer,
ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click
        If GroupFiltres.Visible = True Then
            GroupFiltres.Hide()
        Else
            GroupFiltres.Show()
        End If
    End Sub
    Private Sub ValidQuizz_Click(sender As Object, e As EventArgs) Handles ValidQuizz.Click
        If VidNormal.Checked = False And VidPixel.Checked = False And VidSans.Checked = False Then
            MsgBox("Selectionner un Mode Video")
            TitleBox.Hide()
            TabControl1.Hide()
            Exit Sub
        End If

        TitleBox.Show()
        TabControl1.Show()

        'si le mode pas de propositions

        If ConsoleTitre.Checked = True Then
            ListConsoleDesJeux.Show()
            ListTitreDesJeux.Show()
        ElseIf TitreOnly.Checked = True Then
            ListConsoleDesJeux.Hide()
            ListTitreDesJeux.Show()
        ElseIf PasTitreNiConsole.Checked = True Then
            ListConsoleDesJeux.Hide()
            ListTitreDesJeux.Hide()
        End If

        'On Parametre le tout
        RandomList.SelectedIndex = 0

        'Et enfin on cheeck si c'est Titre+Console pour Ajouter les console a la listbox
        If ConsoleTitre.Checked = True Then
            For Each j In ConsoleList.SelectedItems
                ListConsoleDesJeux.Items.Add(j)
            Next
        End If
    End Sub
    Private Sub ExportTxt_Click(sender As Object, e As EventArgs) Handles ExportTxt.Click
        Dim sb As New System.Text.StringBuilder()
        For Each o As Object In Historique.Items
            sb.AppendLine(o)
        Next
        Dim generefichier As String = My.Computer.FileSystem.SpecialDirectories.Desktop & "\" & "QuizzHistorique du " & Format(Now, "dd-MM-yy a HH-mm-ss") & ".txt"
        System.IO.File.WriteAllText(generefichier, sb.ToString())
        Process.Start(generefichier)
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If SonSans.Checked = True Then
            TrackBar1.Hide()
            Exit Sub
        End If
        TrackBar1.Show()
        PlayerVideo.settings.volume = TrackBar1.Value
    End Sub

    Private Sub RemoveQuizz_Click(sender As Object, e As EventArgs) Handles RemoveQuizz.Click
        Dim selectedrow = TempGrid.CurrentCell.RowIndex
        Dim consoledujeu = TempGrid.Rows(selectedrow).Cells(TempGrid.Columns("Console").Index).Value
        Dim anneedujeu = TempGrid.Rows(selectedrow).Cells(TempGrid.Columns("DateSortie").Index).Value.ToString.Substring(0, 4)
        Dim nomdujeu = TempGrid.Rows(selectedrow).Cells(TempGrid.Columns("Titre").Index).Value
        Dim genereformat = consoledujeu & " (" & anneedujeu & ") - " & nomdujeu

        'on cherche si le tempgrid seleectionné est dans l'historique
        If Historique.Items.Contains(genereformat) Then
            'On cherche donc a quelle ligne il est
            For i = 0 To TempGrid.Rows.Count - 1
                Dim nomdujeutemp = TempGrid.Rows(i).Cells(TempGrid.Columns("Titre").Index).Value

                'une fois qu'on le sait, on va aller faire le fakecalcul pour le retirer de la liste du haut
                If nomdujeutemp = nomdujeu Then
                    Dim vraix As Integer = i
                    Dim fauxx = (i + 5) * 37

                    'on enleve maintenant
                    RandomList.Items.Remove(fauxx)
                    Historique.Items.Remove(genereformat)
                    txtpositionend.Text = Historique.Items.Count
                    If RandomList.Items.Count > 0 Then RandomList.SelectedIndex = 0
                    Exit Sub
                End If
            Next

        Else
            'il est pas dedans du coup
            MsgBox("Impossible ! " & Chr(13) & Chr(13) & nomdujeu & " n'est pas dans la liste du Quizz")
        End If
    End Sub

    Private Sub AddQuizz_Click(sender As Object, e As EventArgs) Handles AddQuizz.Click
        Dim selectedrow = TempGrid.CurrentCell.RowIndex
        Dim consoledujeu = TempGrid.Rows(selectedrow).Cells(TempGrid.Columns("Console").Index).Value
        Dim anneedujeu = TempGrid.Rows(selectedrow).Cells(TempGrid.Columns("DateSortie").Index).Value.ToString.Substring(0, 4)
        Dim nomdujeu = TempGrid.Rows(selectedrow).Cells(TempGrid.Columns("Titre").Index).Value
        Dim genereformat = consoledujeu & " (" & anneedujeu & ") - " & nomdujeu

        'on cherche si le tempgrid selectionné est dans l'historique
        If Historique.Items.Contains(genereformat) Then
            MsgBox(nomdujeu & " est déja dans le Quizz !")
            Exit Sub
        Else
            'On ajoute à la liste a la fin
            RandomList.Items.Add((selectedrow + 5) * 37)
            Historique.Items.Add(genereformat)
            txtpositionend.Text = Historique.Items.Count
            If RandomList.Items.Count > 0 Then RandomList.SelectedIndex = 0
        End If
    End Sub
    Private Sub ImportQuizz_Click(sender As Object, e As EventArgs) Handles ImportQuizz.Click
        If MsgBox("Vous allez supprimer le Quizz actuel, Continuer ?", vbYesNo) = vbNo Then
            Me.Close()
            Form1.Show()
            Exit Sub
        End If

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        Dim importing = 1
        If result = Windows.Forms.DialogResult.OK Then
            Dim adresse As String = OpenFileDialog1.FileName
            If Path.GetExtension(adresse) <> ".txt" Then
                MsgBox("Ce n'est pas un .txt")
            End If

            'On clear les listbox
            RandomList.Items.Clear()
            Historique.Items.Clear()
            ConsoleList.ClearSelected()

            Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(adresse)
            Dim line As String
            Dim nblignes = 0
            Do
                line = reader.ReadLine
                If line = Nothing Then GoTo Findufichier
                nblignes = nblignes + 1

                Dim detectparenthese = InStr(line, "(")
                Dim detectetiret = InStr(line, "-")

                If detectetiret = 0 Or detectparenthese = 0 Then
                    MsgBox("Txt Incomplet")
                    Exit Sub
                End If

                Dim consolass = line.Substring(0, detectparenthese - 2)
                'on la selectionne dans la consolelist
                ConsoleList.SelectedItem = consolass

                Dim annee = line.Substring(detectparenthese, 4)
                Dim titre = line.Substring(detectetiret + 1)

                'On ajoute à la liste a la fin
                Historique.Items.Add(line)
                txtpositionend.Text = Historique.Items.Count
                If RandomList.Items.Count > 0 Then RandomList.SelectedIndex = 0

            Loop Until line Is Nothing
Findufichier:
            reader.Close()

            'on ouvre maintenant les fichiers donc c'est le performclick
            'On stop par securité
            PlayerStop.PerformClick()

            'Afficher le groupParametres
            GroupConfigPartie.Show()

            'On va hider le bouton des console + jeu si un seul systeme est selectionné
            If ConsoleList.SelectedItems.Count = 1 Then
                ConsoleTitre.Hide()
                ListConsoleDesJeux.Hide()
                PasTitreNiConsole.Show()
            Else
                ConsoleTitre.Show()
                ListConsoleDesJeux.Show()
                PasTitreNiConsole.Show()
            End If

            'On met le tooltip
            ToolTipNbJeux.SetToolTip(TxtTotalEntrees, "Ce nombre représente le nombre de jeux total filtré. Plus vous avez un grand chiffre, Meilleur sera l'aléatoire")

            'On affiche les listboxhelpers
            listhelpingboxGenre.Show()
            listhelpingboxDev.Show()
            listhelpingboxPubl.Show()
            listhelpingboxAnnee.Show()
            listhelpingboxPlayers.Show()
            listhelpingboxPlayCount.Show()
            listhelpingboxNote.Show()
            'Showing stuff

            Dim gamelist As String = ConsoleList.Items(0)
            Dim table As New DataTable()
            Dim dv As DataView

            Dim column As DataColumn

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "Console"
            End With
            table.Columns.Add(column)

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "Titre"
            End With
            table.Columns.Add(column)

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "CheminRom"
            End With
            table.Columns.Add(column)

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "Synopsis"
            End With
            table.Columns.Add(column)

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "CheminImage"
            End With
            table.Columns.Add(column)

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "CheminVideo"
            End With
            table.Columns.Add(column)

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "Genre"
            End With
            table.Columns.Add(column)

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "Note"
            End With
            table.Columns.Add(column)


            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "Developer"
            End With
            table.Columns.Add(column)


            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "Publisher"
            End With
            table.Columns.Add(column)


            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "NbPlayers"
            End With
            table.Columns.Add(column)

            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "DateSortie"
            End With
            table.Columns.Add(column)


            column = New DataColumn()
            With column
                .DataType = Type.GetType("System.String")
                .ColumnName = "NbLancé"
            End With
            table.Columns.Add(column)

            'Loop for every gamelists
            For Each i In ConsoleList.SelectedItems

                'generating the console name
                Dim nomconsole As String = i
                Dim consolederom As String = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\gamelist.xml"
                gamelist = consolederom

                Dim gamelistXml As XElement = XElement.Load(gamelist)

                'getting the list for the xml with nodes
                Dim query2 = From st In gamelistXml.Descendants("game") Select st

                For Each xEle As XElement In query2
                    Dim romconsole As String = nomconsole
                    Dim romname As String = xEle.Element("name")
                    Dim romId As String
                    Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
                    Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & temprom
                    Dim romgenre As String
                    Dim romdesc As String
                    Dim romimage As String
                    Dim romvideo As String
                    Dim romnote As String
                    Dim romdev As String
                    Dim rompubl As String
                    Dim romnbplayers As String
                    Dim romdate As String
                    Dim romCompteur As String
                    Dim romhidden As String = xEle.Element("hidden")

                    'Conditionnelles sur tous les champs
                    If romhidden = "true" Then GoTo romsuivante 'si la rom est hidden, on l'affiche pas (Roms multicd)

                    If xEle.Element("video") Is Nothing Then
                        GoTo romsuivante
                    Else
                        romvideo = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & Replace(Replace(Replace(xEle.Element("video"), "/", "\"), "./", ""), ".\", "")
                    End If

                    Dim ExistGameId As Boolean = xEle.Attributes("id").Any

                    If ExistGameId = True Then
                        romId = xEle.Attribute("id").Value
                    Else
                        romId = Nothing
                    End If

                    If xEle.Element("desc") Is Nothing Then
                        romdesc = Nothing
                    Else
                        romdesc = xEle.Element("desc")
                    End If

                    If xEle.Element("image") Is Nothing Then
                        romimage = Nothing
                    Else
                        romimage = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & Replace(Replace(Replace(xEle.Element("image"), "/", "\"), "./", ""), ".\", "")
                    End If

                    If xEle.Element("genre") Is Nothing Then
                        romgenre = Nothing
                    Else
                        romgenre = xEle.Element("genre")
                    End If

                    If xEle.Element("rating") Is Nothing Then
                        romnote = Nothing
                    Else
                        romnote = xEle.Element("rating")
                    End If

                    If xEle.Element("rating") Is Nothing Then
                        romnote = Nothing
                    Else
                        romnote = xEle.Element("rating")
                    End If

                    If xEle.Element("developer") Is Nothing Then
                        romdev = Nothing
                    Else
                        romdev = xEle.Element("developer")
                    End If

                    If xEle.Element("publisher") Is Nothing Then
                        rompubl = Nothing
                    Else
                        rompubl = xEle.Element("publisher")
                    End If

                    If xEle.Element("players") Is Nothing Then
                        romnbplayers = Nothing
                    Else
                        romnbplayers = xEle.Element("players")
                    End If

                    If xEle.Element("releasedate") Is Nothing Then
                        romdate = Nothing
                    Else
                        romdate = xEle.Element("releasedate")
                    End If

                    If xEle.Element("playcount") Is Nothing Then
                        romCompteur = Nothing
                    Else
                        romCompteur = xEle.Element("playcount")
                    End If

                    'on ajoute le tout dans une table
                    table.Rows.Add(romconsole, romname, rompath, romdesc, romimage, romvideo, romgenre, romnote, romdev, rompubl, romnbplayers, romdate, romCompteur)
romsuivante:
                Next
            Next

            'Sorting A-Z the console
            dv = table.DefaultView
            TempGrid.DataSource = table

            'Width for columns
            TempGrid.Columns("Console").Width = 50
            TempGrid.Columns("Titre").Width = 190

            TempGrid.Columns("CheminRom").Visible = False
            TempGrid.Columns("CheminRom").Width = 50

            TempGrid.Columns("Synopsis").Visible = False
            TempGrid.Columns("Synopsis").Width = 50

            TempGrid.Columns("CheminImage").Visible = False
            TempGrid.Columns("CheminImage").Width = 50

            TempGrid.Columns("CheminVideo").Visible = False
            TempGrid.Columns("CheminVideo").Width = 50

            TempGrid.Columns("Genre").Visible = False
            TempGrid.Columns("Genre").Width = 50

            TempGrid.Columns("Note").Visible = False
            TempGrid.Columns("Note").Width = 50

            TempGrid.Columns("Developer").Visible = False
            TempGrid.Columns("Developer").Width = 50

            TempGrid.Columns("Publisher").Visible = False
            TempGrid.Columns("Publisher").Width = 50

            TempGrid.Columns("NbPlayers").Visible = False
            TempGrid.Columns("NbPlayers").Width = 50

            TempGrid.Columns("DateSortie").Visible = True
            TempGrid.Columns("DateSortie").Width = 50

            TempGrid.Columns("NbLancé").Visible = False
            TempGrid.Columns("NbLancé").Width = 50

            'Reajusting Interface and Showing Final Interface
            dv.Sort = "Console asc, Titre asc"

            'On compte le nombre total d'entrées
            TxtTotalEntrees.Text = TempGrid.Rows.Count - 1

            'On va alimenter les filtres de la combobox 
            PeuplerCombobox()

            'On affiche pas la partie des options pour forcer la saisie
            Label17.Hide()
            Label11.Hide()
            txtnbmanches.Hide()
            Label16.Hide()
            txttempsaffichprop.Hide()
            'Focus sur le nombre de parties
            txtnbmanches.Focus()

            TitreOnly.Checked = True
            txtnbmanches.Text = nblignes

            'on recherche les entrees et on remet tout
            If txtnbmanches.Text <= 0 Then
                MsgBox("Impossible de Générer des Manches")
                txtnbmanches.Focus()
                Exit Sub
            End If

            If Val(txtnbmanches.Text) > Val(TxtTotalEntrees.Text) Then
                MsgBox("Trop de Manches > Nb Roms dans le(s) Gamelist(s)")
                Exit Sub
            End If

            If TxtTotalEntrees.Text < 12 Then
                MsgBox("Votre Total Roms doit etre Superieur à 12")
                Exit Sub
            End If

            Dim nbdemanches As Integer = Val(txtnbmanches.Text)
            Dim nbroms As Integer = TxtTotalEntrees.Text

            'On Clear par securité
            RandomList.Items.Clear()
            'On enleves toutes les listbox de reponses par securité
            ListTitreDesJeux.Items.Clear()
            ListConsoleDesJeux.Items.Clear()

            'On va maintenant Charger les options du jeu
            GroupDifficulty.Show()

            'on va devoir chercher chaque entrees
            For p = 0 To Historique.Items.Count - 1
                Dim lignoss = Historique.Items(p)
                Dim tiret = InStr(lignoss, "-")
                Dim titre = lignoss.Substring(tiret + 1)

                Dim nouvox As Integer
                'on cherche dans le grid
                For gridoline = 0 To TempGrid.Rows.Count - 1
                    Dim nomdujeu = TempGrid.Rows(gridoline).Cells(TempGrid.Columns("Titre").Index).Value

                    If titre = nomdujeu Then
                        nouvox = gridoline
                        Exit For
                    End If
                Next

                RandomList.Items.Add((nouvox + 5) * 37)
                txtpositionend.Text = Historique.Items.Count
                If RandomList.Items.Count > 0 Then RandomList.SelectedIndex = 0
            Next
        End If
        ValidQuizz.PerformClick()
        MsgBox("Import Terminé")
    End Sub
    Private Sub ImportDouble_Click(sender As Object, e As EventArgs) Handles ImportDouble.Click
        TabControl1.Show()
        TabControl1.SelectedTab = TabPage2
        ImportQuizz.PerformClick()
    End Sub
    Private Sub Historique_DrawItem(sender As Object, e As DrawItemEventArgs) Handles Historique.DrawItem
        Dim mybrush As New System.Drawing.SolidBrush(Color.FromArgb(0, 177, 89))
        mybrush.Color = Color.FromArgb(255, 0, 0)

        e.DrawBackground()
            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                e.Graphics.FillRectangle(mybrush, e.Bounds)
            End If
            Using b As New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(Historique.GetItemText(Historique.Items(e.Index)), e.Font, b, e.Bounds)
            End Using
        e.DrawFocusRectangle()
    End Sub
End Class