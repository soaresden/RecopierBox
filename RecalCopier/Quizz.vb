Imports System.IO
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
        GroupParametres.Hide()
        ButtonDoRandom.Hide()
        Label10.Hide()
        TxtTotalEntrees.Hide()
        QuizzBox.Hide()
        TempGrid.Hide()

    End Sub
    Private Sub ButtonValidConsole_Click(sender As Object, e As EventArgs) Handles ButtonValidConsole.Click
        'Afficher le groupParametres
        GroupParametres.Show()

        'On va hider le bouton des console + jeu si un seul systeme est selectionné

        If ConsoleList.SelectedItems.Count = 1 Then
            ConsoleTitre.Hide()
            ListConsoleDesJeux.Hide()
            TitreOnly.Checked = True
        End If

        'Afficher les Totaux
        Label10.Show()
        TxtTotalEntrees.Show()

        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If ConsoleList.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner une/des Consoles")
            Exit Sub
        End If

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
        TempGrid.Columns("Titre").Width = 50

        TempGrid.Columns("CheminRom").Visible = False
        TempGrid.Columns("CheminRom").Width = 50

        TempGrid.Columns("Synopsis").Visible = False
        TempGrid.Columns("Synopsis").Width = 50

        TempGrid.Columns("CheminImage").Visible = False
        TempGrid.Columns("CheminImage").Width = 50

        TempGrid.Columns("CheminVideo").Visible = False
        TempGrid.Columns("CheminVideo").Width = 50

        TempGrid.Columns("Genre").Visible = True
        TempGrid.Columns("Genre").Width = 50

        TempGrid.Columns("Note").Visible = True
        TempGrid.Columns("Note").Width = 50

        TempGrid.Columns("Developer").Visible = True
        TempGrid.Columns("Developer").Width = 50

        TempGrid.Columns("Publisher").Visible = True
        TempGrid.Columns("Publisher").Width = 50

        TempGrid.Columns("NbPlayers").Visible = True
        TempGrid.Columns("NbPlayers").Width = 50

        TempGrid.Columns("DateSortie").Visible = False
        TempGrid.Columns("DateSortie").Width = 50

        TempGrid.Columns("NbLancé").Visible = False
        TempGrid.Columns("NbLancé").Width = 50

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, Titre asc"

        'On compte le nombre total d'entrées
        TxtTotalEntrees.Text = TempGrid.Rows.Count - 1

        'On va alimenter les filtres de la combobox 
        PeuplerCombobox()

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

        Next

    End Sub
    'Ensemble Got Focus et Leave Focus pour les listboxes
    Private Sub Txtgenre_GotFocus(sender As Object, e As EventArgs) Handles txtgenre.GotFocus
        listhelpingboxDev.Show()
        listhelpingboxGenre.Show()
        listhelpingboxNote.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPubl.Show()
        listhelpingboxGenre.BringToFront()
        listhelpingboxGenre.Location = New Point(6, 16)
        listhelpingboxGenre.Size = New Point(136, 199)
    End Sub
    Private Sub Txtdev_GotFocus(sender As Object, e As EventArgs) Handles txtdev.GotFocus
        listhelpingboxDev.Show()
        listhelpingboxGenre.Show()
        listhelpingboxNote.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPubl.Show()
        listhelpingboxDev.BringToFront()
        listhelpingboxDev.Location = New Point(6, 16)
        listhelpingboxDev.Size = New Point(136, 199)
    End Sub
    Private Sub Txtpub_GotFocus(sender As Object, e As EventArgs) Handles txtpub.GotFocus
        listhelpingboxDev.Show()
        listhelpingboxGenre.Show()
        listhelpingboxNote.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPubl.Show()
        listhelpingboxPubl.BringToFront()
        listhelpingboxPubl.Location = New Point(6, 16)
        listhelpingboxPubl.Size = New Point(136, 199)
    End Sub
    Private Sub ComboRating_GotFocus(sender As Object, e As EventArgs) Handles ComboRating.GotFocus
        listhelpingboxDev.Show()
        listhelpingboxGenre.Show()
        listhelpingboxNote.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPubl.Show()
        listhelpingboxNote.BringToFront()
        listhelpingboxNote.Location = New Point(6, 16)
        listhelpingboxNote.Size = New Point(136, 199)
    End Sub
    Private Sub TxtAnnee_GotFocus(sender As Object, e As EventArgs) Handles TxtAnnee.GotFocus
        listhelpingboxDev.Hide()
        listhelpingboxGenre.Hide()
        listhelpingboxNote.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPubl.Hide()
    End Sub
    Private Sub TxtPlayCount_GotFocus(sender As Object, e As EventArgs) Handles TxtPlayCount.GotFocus
        listhelpingboxDev.Hide()
        listhelpingboxGenre.Hide()
        listhelpingboxNote.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPubl.Hide()
    End Sub
    Private Sub TxtSynopsis_GotFocus(sender As Object, e As EventArgs) Handles TxtSynopsis.GotFocus
        listhelpingboxDev.Hide()
        listhelpingboxGenre.Hide()
        listhelpingboxNote.Hide()
        listhelpingboxPlayers.Hide()
        listhelpingboxPubl.Hide()
    End Sub
    Private Sub Txtgenre_LostFocus(sender As Object, e As EventArgs) Handles txtgenre.LostFocus
        listhelpingboxGenre.Location = New Point(6, 16)
        listhelpingboxGenre.Size = New Point(136, 30)
    End Sub
    Private Sub ListhelpingboxDev_LostFocus(sender As Object, e As EventArgs) Handles listhelpingboxDev.LostFocus
        listhelpingboxDev.Location = New Point(6, 58)
        listhelpingboxDev.Size = New Point(136, 30)
    End Sub
    Private Sub ListhelpingboxPubl_LostFocus(sender As Object, e As EventArgs) Handles listhelpingboxPubl.LostFocus
        listhelpingboxPubl.Location = New Point(6, 94)
        listhelpingboxPubl.Size = New Point(136, 30)
    End Sub
    Private Sub ListhelpingboxPlayers_LostFocus(sender As Object, e As EventArgs) Handles listhelpingboxPlayers.LostFocus
        listhelpingboxPlayers.Location = New Point(6, 130)
        listhelpingboxPlayers.Size = New Point(136, 30)
    End Sub
    Private Sub LsthelpingboxNote_Leave(sender As Object, e As EventArgs) Handles listhelpingboxNote.Leave
        listhelpingboxNote.Location = New Point(6, 166)
        listhelpingboxNote.Size = New Point(136, 30)
    End Sub


    Private Sub TitreOnly_CheckedChanged(sender As Object, e As EventArgs) Handles TitreOnly.CheckedChanged
        If TitreOnly.Checked = True Then ConsoleTitre.Checked = False
    End Sub

    Private Sub ConsoleTitre_CheckedChanged(sender As Object, e As EventArgs) Handles ConsoleTitre.CheckedChanged
        If TitreOnly.Checked = False Then ConsoleTitre.Checked = True
    End Sub

    Sub Entreesurfiltres()
        'commande pour filtrer
        TryCast(TempGrid.DataSource, DataTable).DefaultView.RowFilter = String.Format("[Genre] like '%{0}%' AND [Developer] like '%{1}%' AND [Publisher] like '%{2}%' AND [DateSortie] like '%{3}%' AND [NbPlayers] like '%{4}%' AND [NbLancé] like '%{5}%' AND [Synopsis] like '%{6}%' AND [Note] like '%{7}%'", txtgenre.Text, txtdev.Text, txtpub.Text, TxtAnnee.Text, txtplayers.Text, TxtPlayCount.Text, TxtSynopsis.Text, ComboRating.Text)
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
    Private Sub ComboRating_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboRating.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub

    Private Sub ButtonValidFilters_Click(sender As Object, e As EventArgs) Handles ButtonDoRandom.Click
        If txtnbmanches.Text < 0 Then
            MsgBox("Impossible de Générer des Manches")
            Exit Sub
        End If

        If Val(txtnbmanches.Text) > Val(TxtTotalEntrees.Text) Then
            MsgBox("Trop de Manches > Nb Roms")
            Exit Sub
        End If
        Dim nbdemanches As Integer = Val(txtnbmanches.Text)    ' how many numbers do you want?
        Dim nbroms As Integer = TxtTotalEntrees.Text

        'On Clear par securité
        RandomList.Items.Clear()

        'On va generer un chiffre et tester
        Dim random As New Random()
        For i = 0 To nbdemanches - 1
            Dim chiffregenere As Integer

            'On va generer le chiffre jusqu'a ce qu'il ne soit pas dans la liste
            Do
                chiffregenere = Convert.ToString(random.Next(0, nbroms))
            Loop Until RandomList.Items.Contains(chiffregenere) = False

            RandomList.Items.Add(chiffregenere * 35) ' on met le numero de la row dans la listbox random et on multiplie par 35 pour perdre le User
        Next

        MsgBox("Pret à Demarrer le Quizz ?!")

        'on controle que tout est bien OK
        If TitreOnly.Checked = False And ConsoleTitre.Checked = False Then
            MsgBox("Merci de Selectionner un Type de Partie")
            Exit Sub
        End If

        If RandomList.Items.Count = 0 Then
            MsgBox("Merci de Déclencher un Random")
            Exit Sub
        End If

        'On va maintenant Charger toute l'interface de jeu
        QuizzBox.Show()
        If ConsoleTitre.Checked = True Then ListConsoleDesJeux.Show() Else ListConsoleDesJeux.Hide()

        'On Parametre le tout
        PlayerAudio.uiMode = "invisible"
        PlayerAudio.settings.setMode("loop", False)
        PlayerAudio.settings.mute = False
        RandomList.SelectedIndex = 0

        'Et enfin on cheeck si c'est Titre+Console pour Ajouter les console de base
        If ConsoleTitre.Checked = True Then

            For Each j In ConsoleList.SelectedItems
                ListConsoleDesJeux.Items.Add(ConsoleList.SelectedItems(j).ToString)
            Next
        End If

        MsgBox("Veuiller Appuyer sur le Bouton Start pour Commencer")
    End Sub
    Private Sub Txtnbmanches_TextChanged(sender As Object, e As EventArgs) Handles txtnbmanches.TextChanged
        If txtnbmanches.Text Is Nothing Then
            Exit Sub
        Else
            ButtonDoRandom.Show()
            txtpositionend.Text = txtnbmanches.Text
        End If
    End Sub
    Private Sub Txtnbmanches_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnbmanches.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonDoRandom.PerformClick()
        End If
    End Sub

    Private Sub RandomList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RandomList.SelectedIndexChanged
        txtpositionrandom.Text = RandomList.SelectedIndex + 1
    End Sub


    Private Sub PlayerNext_Click(sender As Object, e As EventArgs) Handles PlayerNext.Click
        Dim selectionactuelle = RandomList.SelectedIndex
        If selectionactuelle >= txtpositionend.Text - 1 Then Exit Sub
        PlayerAudio.Ctlcontrols.stop()
        RandomList.SelectedIndex = selectionactuelle + 1
        ListTitreDesJeux.Items.Clear()
    End Sub

    Private Sub PlayerPrev_Click(sender As Object, e As EventArgs) Handles PlayerPrev.Click
        Dim selectionactuelle = RandomList.SelectedIndex
        If selectionactuelle <= 0 Then Exit Sub
        PlayerAudio.Ctlcontrols.stop()
        RandomList.SelectedIndex = selectionactuelle - 1
        ListTitreDesJeux.Items.Clear()
    End Sub

    Private Sub PlayerPlay_Click(sender As Object, e As EventArgs) Handles PlayerPlay.Click
        'test pour voir si c'est à l'arret ou en play
        If (PlayerAudio.playState = WMPLib.WMPPlayState.wmppsPlaying) Then 'Si c'est play on fait Pause
            PlayerAudio.Ctlcontrols.pause()
            Timer1.Stop()
            Exit Sub
        ElseIf PlayerAudio.playState = WMPLib.WMPPlayState.wmppsPaused Then 'Si c'est pause on fait play
            PlayerAudio.Ctlcontrols.play()
            Timer1.Stop()
        ElseIf PlayerAudio.playState = WMPLib.WMPPlayState.wmppsStopped Or PlayerAudio.playState = WMPLib.WMPPlayState.wmppsStopped = 0 Then 'Si c'est stoppé on load la video
            Dim lavraieligne As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString)
            PlayerAudio.URL = TempGrid.Rows(lavraieligne / 35).Cells(TempGrid.Columns("CheminVideo").Index).Value

            PlayerAudio.Ctlcontrols.play()
            PlayerAudio.uiMode = "invisible"

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = PlayerAudio.currentMedia.duration

            ListTitreDesJeux.Items.Clear()

            Timer1.Start()
        End If
    End Sub

    Private Sub PlayerStop_Click(sender As Object, e As EventArgs) Handles PlayerStop.Click
        PlayerAudio.Ctlcontrols.stop()
    End Sub

    Private Sub HiddenButton_Click(sender As Object, e As EventArgs) Handles HiddenButton.Click
        If TempGrid.Visible = False Then
            TempGrid.Visible = True
            TempGrid.Size = New Point(369, 404)
        Else
            TempGrid.Visible = False
            TempGrid.Size = New Point(369, 30)
            TempGrid.Rows(RandomList.SelectedItem.ToString / 35).Selected = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = PlayerAudio.currentMedia.duration
        ProgressBar1.Value = PlayerAudio.Ctlcontrols.currentPosition
        ProgressBar1.Increment(1)

        'On check la moitié du temps
        Dim moitiedutemps As String = PlayerAudio.currentMedia.duration / 2

        'On va ajouter des valeurs au pif en listbox a partir de la moitié du temps
        If PlayerAudio.Ctlcontrols.currentPosition > moitiedutemps Then

            'on compte la liste pour voir si on doit generer ou non
            If ListTitreDesJeux.Items.Count > 11 Then Exit Sub
            'on recupere le vrai jeu actuel
            Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString) / 35
            Dim titreencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Titre").Index).Value
            Dim random As New Random
            'on check le type de jeu
            Dim TitreGen As String




            If TitreOnly.Checked = True Then 'Titre uniquement

                'On va generer un titre de jeu jusqu'a ce qu'il ne soit pas dans la liste
                Do
again:
                    TitreGen = TempGrid.Rows(Convert.ToString(random.Next(0, TempGrid.Rows.Count - 1))).Cells(TempGrid.Columns("Titre").Index).Value
                    If ListTitreDesJeux.Items.Contains(TitreGen) = True Then GoTo again

                    ListTitreDesJeux.Items.Add(TitreGen)
                Loop Until ListTitreDesJeux.Items.Count > 11

                ListTitreDesJeux.Items.Add(titreencours)
                ListTitreDesJeux.Sorted = True







            ElseIf ConsoleTitre.Checked = True Then ' Titre Et Consoles
                'On va d'abord faire un melange des consoles selectionnées
                Dim consoleencours As String = TempGrid.Rows(Convert.ToInt32(RandomList.SelectedItem.ToString) / 35).Cells(TempGrid.Columns("Titre").Index).Value

                If ListConsoleDesJeux.SelectedItem.ToString = consoleencours Then ' Si c'est la bonne console on va afficher les propositions apres 15 sec aussi
                    Do
again2:
                        TitreGen = TempGrid.Rows(Convert.ToString(random.Next(0, TempGrid.Rows.Count - 1))).Cells(TempGrid.Columns("Titre").Index).Value
                        If ListTitreDesJeux.Items.Contains(TitreGen) = True Then GoTo again2

                        ListTitreDesJeux.Items.Add(TitreGen)
                    Loop Until ListTitreDesJeux.Items.Count > 11

                    ListTitreDesJeux.Items.Add(titreencours)
                    ListTitreDesJeux.Sorted = True
                Else
                    Exit Sub
                End If
            End If
        End If
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
        Dim titreencours As String = TempGrid.Rows(Convert.ToInt32(RandomList.SelectedItem.ToString) / 35).Cells(TempGrid.Columns("Titre").Index).Value
        'on verifie si la selection est bien celle ci
        If ListTitreDesJeux.SelectedItem.ToString = titreencours Then
            PlayerAudio.uiMode = "none"
            MsgBox("Bien vu !")
        Else
            MsgBox("Et Non !")
        End If
    End Sub
End Class