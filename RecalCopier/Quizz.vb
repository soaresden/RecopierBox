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
        ButtonValidFilters.Hide()
        Label10.Hide()
        TxtTotalEntrees.Hide()
        ButtonPlay.Hide()

    End Sub
    Private Sub ButtonValidConsole_Click(sender As Object, e As EventArgs) Handles ButtonValidConsole.Click
        'Afficher le groupParametres
        GroupParametres.Show()

        'Afficher les Totaux
        Label10.Show()
        TxtTotalEntrees.Show()

        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If ConsoleList.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner une/des Consoles")
            Exit Sub
        End If

        'Showing stuff
        TempGrid.Show()

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
        TempGrid.Show()
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
    Private Sub txtnbmanches_TextChanged(sender As Object, e As EventArgs) Handles txtnbmanches.TextChanged
        If txtnbmanches.Text Is Nothing Then
            Exit Sub
        Else
            ButtonValidFilters.Show()
        End If

    End Sub

    'Ensemble Got Focus et Leave Focus pour les listboxes
    Private Sub txtgenre_GotFocus(sender As Object, e As EventArgs) Handles txtgenre.GotFocus
        listhelpingboxDev.Show()
        listhelpingboxGenre.Show()
        listhelpingboxNote.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPubl.Show()
        listhelpingboxGenre.BringToFront()
        listhelpingboxGenre.Location = New Point(6, 16)
        listhelpingboxGenre.Size = New Point(136, 199)
    End Sub
    Private Sub txtdev_GotFocus(sender As Object, e As EventArgs) Handles txtdev.GotFocus
        listhelpingboxDev.Show()
        listhelpingboxGenre.Show()
        listhelpingboxNote.Show()
        listhelpingboxPlayers.Show()
        listhelpingboxPubl.Show()
        listhelpingboxDev.BringToFront()
        listhelpingboxDev.Location = New Point(6, 16)
        listhelpingboxDev.Size = New Point(136, 199)
    End Sub
    Private Sub txtpub_GotFocus(sender As Object, e As EventArgs) Handles txtpub.GotFocus
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
    Private Sub txtgenre_LostFocus(sender As Object, e As EventArgs) Handles txtgenre.LostFocus
        listhelpingboxGenre.Location = New Point(6, 16)
        listhelpingboxGenre.Size = New Point(136, 30)
    End Sub
    Private Sub listhelpingboxDev_LostFocus(sender As Object, e As EventArgs) Handles listhelpingboxDev.LostFocus
        listhelpingboxDev.Location = New Point(6, 58)
        listhelpingboxDev.Size = New Point(136, 30)
    End Sub
    Private Sub listhelpingboxPubl_LostFocus(sender As Object, e As EventArgs) Handles listhelpingboxPubl.LostFocus
        listhelpingboxPubl.Location = New Point(6, 94)
        listhelpingboxPubl.Size = New Point(136, 30)
    End Sub
    Private Sub listhelpingboxPlayers_LostFocus(sender As Object, e As EventArgs) Handles listhelpingboxPlayers.LostFocus
        listhelpingboxPlayers.Location = New Point(6, 130)
        listhelpingboxPlayers.Size = New Point(136, 30)
    End Sub
    Private Sub listhelpingboxNote_Leave(sender As Object, e As EventArgs) Handles listhelpingboxNote.Leave
        listhelpingboxNote.Location = New Point(6, 166)
        listhelpingboxNote.Size = New Point(136, 30)
    End Sub





    Private Sub TitreOnly_CheckedChanged(sender As Object, e As EventArgs) Handles TitreOnly.CheckedChanged
        If TitreOnly.Checked = True Then ConsoleTitre.Checked = False
    End Sub

    Private Sub ConsoleTitre_CheckedChanged(sender As Object, e As EventArgs) Handles ConsoleTitre.CheckedChanged
        If TitreOnly.Checked = False Then ConsoleTitre.Checked = True
    End Sub




End Class