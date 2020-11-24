﻿Imports System.IO
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
        txtRules.Hide()

    End Sub
    Private Sub ButtonValidConsole_Click(sender As Object, e As EventArgs) Handles ButtonValidConsole.Click
        'On stop par securité
        PlayerStop.PerformClick()

        'Afficher le groupParametres
        GroupParametres.Show()

        'On va hider le bouton des console + jeu si un seul systeme est selectionné

        If ConsoleList.SelectedItems.Count = 1 Then
            ConsoleTitre.Hide()
            ListConsoleDesJeux.Hide()
            TitreOnly.Checked = True
        Else
            ConsoleTitre.Show()
            ListConsoleDesJeux.Show()
        End If

        'Afficher les Totaux
        Label10.Show()
        TxtTotalEntrees.Show()

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
        TempGrid.Columns("Titre").Width = 230

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
    Private Sub TxtSynopsis_LostFocus(sender As Object, e As EventArgs) Handles TxtSynopsis.LostFocus
        listhelpingboxGenre.Show()
        listhelpingboxDev.Show()
        listhelpingboxPubl.Show()
        listhelpingboxAnnee.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPlayCount.Show()
        listhelpingboxNote.Show()
    End Sub


    Private Sub TitreOnly_CheckedChanged(sender As Object, e As EventArgs) Handles TitreOnly.CheckedChanged
        If TitreOnly.Checked = True Then ConsoleTitre.Checked = False
    End Sub

    Private Sub ConsoleTitre_CheckedChanged(sender As Object, e As EventArgs) Handles ConsoleTitre.CheckedChanged
        If TitreOnly.Checked = False Then ConsoleTitre.Checked = True
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
    Private Sub ComboRating_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call Entreesurfiltres()
        End If
    End Sub

    Private Sub ButtonValidFilters_Click(sender As Object, e As EventArgs) Handles ButtonDoRandom.Click

        If txtnbmanches.Text <= 0 Then
            MsgBox("Impossible de Générer des Manches")
            Exit Sub
        End If

        If Val(txtnbmanches.Text) > Val(TxtTotalEntrees.Text) Then
            MsgBox("Trop de Manches > Nb Roms")
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
        'On refresh les reponses par securité
        ListTitreDesJeux.Items.Clear()
        ListConsoleDesJeux.Items.Clear()

        'On va generer un chiffre et tester
        Dim rnd As New Random
        Dim x As Integer

        Do Until RandomList.Items.Count = nbdemanches - 1
recalculrando:
            x = rnd.Next(0, nbroms + 1) 'generer un chiffre entre 0 et le nb de roms
            'test de la presence du vrai jeu ou d'un doublon 
            Dim xremade As Integer = x
            If RandomList.Items.Contains(xremade) Then GoTo recalculrando
            RandomList.Items.Add(xremade)
        Loop

        'on controle que tout est bien OK
        If TitreOnly.Checked = False And ConsoleTitre.Checked = False Then
            MsgBox("Merci de Selectionner un Type de Partie")
            Exit Sub
        End If

        If ModeEasy.Checked = False And ModeHardcore.Checked = False Then
            MsgBox("Merci de choisir la Difficulté")
            Exit Sub
        End If

        If RandomList.Items.Count = 0 Then
            MsgBox("Merci de Générer un Random")
            Exit Sub
        End If

        'On va maintenant Charger toute l'interface de jeu
        QuizzBox.Show()
        txtRules.Show()

        If ConsoleTitre.Checked = True Then ListConsoleDesJeux.Show() Else ListConsoleDesJeux.Hide()

        'On Parametre le tout
        PlayerAudio.uiMode = "invisible"
        PlayerAudio.settings.setMode("loop", False)
        PlayerAudio.settings.mute = False
        RandomList.SelectedIndex = 0

        'Et enfin on cheeck si c'est Titre+Console pour Ajouter les console de base
        If ConsoleTitre.Checked = True Then

            For Each j In ConsoleList.SelectedItems
                ListConsoleDesJeux.Items.Add(j)
            Next
        End If

        MsgBox("Veuiller Appuyer sur le Bouton pour Commencer")
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
        PlayerStop.PerformClick()
    End Sub


    Private Sub PlayerNext_Click(sender As Object, e As EventArgs) Handles PlayerNext.Click
        Dim selectionactuelle = RandomList.SelectedIndex
        If selectionactuelle >= txtpositionend.Text - 1 Then Exit Sub
        PlayerAudio.Ctlcontrols.stop()
        RandomList.SelectedIndex = selectionactuelle + 1
        ListTitreDesJeux.Items.Clear()
        ListConsoleDesJeux.Items.Clear()
        'On va hider le bouton video si jamais c'etait fini sur la precedente
        ButtonShowVid.Hide()
    End Sub

    Private Sub PlayerPrev_Click(sender As Object, e As EventArgs) Handles PlayerPrev.Click
        Dim selectionactuelle = RandomList.SelectedIndex
        If selectionactuelle <= 0 Then Exit Sub
        PlayerAudio.Ctlcontrols.stop()
        RandomList.SelectedIndex = selectionactuelle - 1
        ListTitreDesJeux.Items.Clear()
        ListConsoleDesJeux.Items.Clear()
        'On va hider le bouton video si jamais c'etait fini sur la precedente
        ButtonShowVid.Hide()
        TimeBox.Text = ""
    End Sub

    Private Sub PlayerPlay_Click(sender As Object, e As EventArgs) Handles PlayerPlay.Click
        'test pour voir si c'est à l'arret ou en play
        If (PlayerAudio.playState = WMPLib.WMPPlayState.wmppsPlaying) Then 'Si c'est play on fait Pause
            Exit Sub
        ElseIf PlayerAudio.playState = WMPLib.WMPPlayState.wmppsStopped Or PlayerAudio.playState = WMPLib.WMPPlayState.wmppsStopped = 0 Then 'Si c'est stoppé on load la video
            Dim lavraieligne As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString)

            PlayerAudio.URL = TempGrid.Rows(lavraieligne).Cells(TempGrid.Columns("CheminVideo").Index).Value

            PlayerAudio.Ctlcontrols.play()
            If ModeEasy.Checked = True Then PlayerAudio.uiMode = "full"
            If ModeHardcore.Checked = True Then PlayerAudio.uiMode = "invisible"

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = PlayerAudio.currentMedia.duration

            ListTitreDesJeux.Items.Clear()
            ButtonShowVid.Hide()
            Timer1.Start()
            TimeBox.Text = ""

            'On remplit la randobox e toutes les possibilités
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
        PlayerAudio.Ctlcontrols.stop()
        ButtonShowVid.Hide()
        TimeBox.Text = ""
        TimeBox.BackColor = Color.FromArgb(72, 61, 139)
    End Sub

    Private Sub HiddenButton_Click(sender As Object, e As EventArgs) Handles HiddenButton.Click
        ' Si le quizz est pas fait encore, on affiche juste
        If QuizzBox.Visible = False Then
            If TempGrid.Visible = True Then
                TempGrid.Visible = False
            Else
                TempGrid.Visible = True
                TempGrid.Size = New Point(369, 404)
            End If

        Else ' sinon on affiche et on va selectionner
            If TempGrid.Visible = False Then
                TempGrid.Visible = True
                TempGrid.Size = New Point(369, 404)
                Dim lavraieligne As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString)
                Dim nomdujeu As String = TempGrid.Rows(lavraieligne).Cells(TempGrid.Columns("Titre").Index).Value
                'on faire le focus sur la ligne
                TempGrid.ClearSelection()
                TempGrid.Rows(lavraieligne).Selected = True
                TempGrid.CurrentCell = TempGrid.Rows(lavraieligne).Cells(1)
            Else
                TempGrid.Visible = False
                TempGrid.Size = New Point(369, 30)
            End If
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = PlayerAudio.currentMedia.duration
        ProgressBar1.Value = PlayerAudio.Ctlcontrols.currentPosition
        ProgressBar1.Increment(1)
        Dim tpsrestant As Double = PlayerAudio.currentMedia.duration - PlayerAudio.Ctlcontrols.currentPosition
        TimeBox.Text = tpsrestant.ToString("00.0")



        'On check le temps des propositions
        Dim tempsprop As String = txttempsaffichprop.Text

        'On envoie la couleur
        If ProgressBar1.Value <= tempsprop Then 'Si c'est avant les propositions c'est VERT
            SendMessage(ProgressBar1.Handle, 1040, 1, 0)
            TimeBox.BackColor = Color.FromArgb(6, 176, 37)
        ElseIf ProgressBar1.Value >= tempsprop And ProgressBar1.Value < (0.8 * ProgressBar1.Maximum) Then 'Si c'est avant les propositions c'est ORANGE
            SendMessage(ProgressBar1.Handle, 1040, 3, 0)
            TimeBox.BackColor = Color.FromArgb(218, 203, 38)
        Else 'Sinon c'est rouge
            SendMessage(ProgressBar1.Handle, 1040, 2, 0)
            TimeBox.BackColor = Color.FromArgb(218, 38, 38)
        End If

        Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString)
        Dim titreencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Titre").Index).Value
        Dim consoleencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Console").Index).Value

        '############SI C'EST QUIZZ TITRE + CONSOLE #################
        If ConsoleTitre.Checked = True Then ' Titre Et Consoles
            'On va d'abord faire un melange des consoles selectionnées

            If ListConsoleDesJeux.SelectedItem = Nothing Then Exit Sub
            If ListConsoleDesJeux.SelectedItem.ToString = consoleencours Then ' Si c'est la bonne console on va afficher les propositions apres les secaussi

                Dim rndo As New Random
                Dim y As Integer
                Dim titlegeno As String

                'Si la liste est prete on sort 
                If ListTitreDesJeux.Items.Count > 11 Then Exit Sub
                'on va faire une liste de chiffre en list box
                'on va prendre un chiffre au pif
                'et si ca marche pas on va l'enlever de cette liste
                'et on reboucle sur celle ci pour ne pas refaire le meme chiffre

                'on commence par remplir la randobox de tous les chiffres possible
                listrandobox.Items.Clear()
                Dim rando As Integer
                For rando = 0 To TxtTotalEntrees.Text
                    listrandobox.Items.Add(rando)
                Next


                Do Until ListTitreDesJeux.Items.Count > 11
                    Application.DoEvents()
                    y = rndo.Next(0, listrandobox.Items.Count) 'generer un chiffre entre 0 et le nb de roms
                    titlegeno = TempGrid.Rows(y).Cells(TempGrid.Columns("Titre").Index).Value
                    'test de la presence d'un doublon 
                    If y = RandomList.SelectedItem Then
                        GoTo looping1
                    End If
                    If Not ListTitreDesJeux.Items.Contains(titlegeno) Then ListTitreDesJeux.Items.Add(titlegeno) 'si le titre est deja present, on l'enleve
looping1:
                    listrandobox.Items.Remove(y)
                Loop

                'on ajoute le titre en cours et on range
                ListTitreDesJeux.Items.Add(titreencours)
                ListTitreDesJeux.Sorted = True
                Exit Sub
            End If

        End If

        '########### CHECK DU TEMPS POUR LES TITRES ONLY ###############
        If PlayerAudio.Ctlcontrols.currentPosition < tempsprop Then Exit Sub

        '############SI C'EST QUIZZ TITRE#################        If TitreOnly.Checked = True Then 'Titre uniquement
        If TitreOnly.Checked = True Then ' Titre Et Consoles
            Dim rnda As New Random
            Dim x As Integer
            Dim titlegen As String

            'Si la liste est prete on sort 
            If ListTitreDesJeux.Items.Count > 11 Then Exit Sub

            'on va faire une liste de chiffre en list box
            'on va prendre un chiffre au pif
            'et si ca marche pas on va l'enlever de cette liste
            'et on reboucle sur celle ci pour ne pas refaire le meme chiffre


            Do Until ListTitreDesJeux.Items.Count > 11
                Application.DoEvents()
                x = rnda.Next(0, listrandobox.Items.Count) 'generer un chiffre entre 0 et le nb de roms
                titlegen = TempGrid.Rows(x).Cells(TempGrid.Columns("Titre").Index).Value
                'test de la presence d'un doublon 
                If x = RandomList.SelectedItem Then
                    GoTo looping2
                End If
                If Not ListTitreDesJeux.Items.Contains(titlegen) Then ListTitreDesJeux.Items.Add(titlegen) 'si le titre est deja present, on l'enleve
looping2:
                listrandobox.Items.Remove(x)
            Loop

            'on ajoute le titre en cours et on range
            ListTitreDesJeux.Items.Add(titreencours)
            ListTitreDesJeux.Sorted = True
            Exit Sub
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
        Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString)
        Dim titreencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Titre").Index).Value
        'on verifie si la selection est bien celle ci
        If IsNothing(ListTitreDesJeux.SelectedItem.ToString) Then Exit Sub
        If ListTitreDesJeux.SelectedItem.ToString = titreencours Then
            PlayerAudio.uiMode = "full"
            'On configure vite le bouton showvideo
            Dim imgvideo As New Bitmap(My.Resources.OKvideo)
            Dim imgvideo2 As New Bitmap(imgvideo, ButtonShowVid.Width, ButtonShowVid.Height)
            ButtonShowVid.Image = imgvideo2
            ButtonShowVid.Show()

            MsgBox("Bien Joué !")
        Else
            MsgBox("Nope !")
        End If
    End Sub
    Private Sub ButtonShowVid_Click(sender As Object, e As EventArgs) Handles ButtonShowVid.Click
        Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString)
        Dim videoencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("CheminVideo").Index).Value
        System.Diagnostics.Process.Start(videoencours)
    End Sub

    Private Sub ModeEasy_CheckedChanged(sender As Object, e As EventArgs) Handles ModeEasy.CheckedChanged
        If ModeEasy.Checked = True Then ModeHardcore.Checked = False
    End Sub

    Private Sub ModeHardcore_CheckedChanged(sender As Object, e As EventArgs) Handles ModeHardcore.CheckedChanged
        If ModeHardcore.Checked = True Then ModeEasy.Checked = False
    End Sub

    Private Sub ListConsoleDesJeux_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListConsoleDesJeux.SelectedIndexChanged
        Dim lignefakeremade As Integer = Convert.ToInt32(RandomList.SelectedItem.ToString)
        Dim consoleencours As String = TempGrid.Rows(lignefakeremade).Cells(TempGrid.Columns("Console").Index).Value

        If ListConsoleDesJeux.SelectedItem.ToString = consoleencours Then
            MsgBox("Bravo pour la Console !")
        Else
            MsgBox("Mauvaise Console !")
        End If
    End Sub

    Private Sub Buttongetback_Click(sender As Object, e As EventArgs) Handles Buttongetback.Click
        Me.Close()
        Form1.Show()
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

    Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" _
(ByVal hWnd As IntPtr, ByVal wCmd As Integer,
ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
End Class