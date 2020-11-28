Imports System.IO

Public Class CopyRoms
    Private sec As Integer = 0
    Private Sub CopyRoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hiding buttons and datagrids
        txt_txtsearch.Hide()
        FinalGrid.Hide()
        ButtonShowGames.Hide()
        GroupBox1.Hide()
        grp_RomInfos.Hide()
        vid_romvid.uiMode = "none"
        listboxMaSelection.Hide()
        buttonRAZ.Hide()
        GroupFiltresAvances.Hide()
        minipic1.Hide()
        minipic2.Hide()
        minipic3.Hide()
        minipic4.Hide()
        minipic5.Hide()
        ButtonTuto.Hide()
        'Et tout le Block Tuto
        TutoHideGameList.Hide()
        TutoHideFinalGrid.Hide()
        TutoHideRomInfo.Hide()
        TutoHideFiltres.Hide()
        TutoHideOutilsP1.Hide()
        TutoHideOutilsP2.Hide()
        TutoHideOutilsP3.Hide()
        TutoHideOutilsP4.Hide()
        TutoHideOutilsP5.Hide()
        TutoHideOutilsP6.Hide()

    End Sub
    Private Sub ButtonImportXML_click(sender As Object, e As EventArgs) Handles ButtonImportXML.Click
        If CheckBoxARRM.Checked = True Then
            For Each foundDirectory In Directory.GetDirectories(My.Settings.RecalboxFolder & "\roms", ".", SearchOption.TopDirectoryOnly)

                If File.Exists(foundDirectory & "\gamelist_ARRM.xml") Then
                    ListGameLists.Items.Add(foundDirectory & "\gamelist_ARRM.xml")
                Else
                    ListGameLists.Items.Add(foundDirectory & "\gamelist.xml")
                End If
            Next
        Else
            For Each foundDirectory In Directory.GetDirectories(My.Settings.RecalboxFolder & "\roms", ".", SearchOption.TopDirectoryOnly)
                If File.Exists(foundDirectory & "\gamelist.xml") Then
                    ListGameLists.Items.Add(foundDirectory & "\gamelist.xml")
                End If
            Next
        End If

        'showing gridview2
        ButtonImportXML.Hide()
        FinalGrid.Show()
        ButtonShowGames.Show()
        ButtonImportXML.Hide()
        CheckBoxARRM.Hide()
    End Sub

    Public Shared Function GetFilesRecursive(ByVal initial As String) As List(Of String)
        ' This list stores the results.
        Dim result As New List(Of String)

        ' This stack stores the directories to process.
        Dim stack As New Stack(Of String)

        ' Add the initial directory
        stack.Push(initial)

        ' Continue processing for each stacked directory
        Do While (stack.Count > 0)
            ' Get top directory string
            Dim dir As String = stack.Pop
            Try
                ' Add all immediate file paths
                result.AddRange(Directory.GetFiles(dir, "*gamelist.xml*"))

                ' Loop through all subdirectories and add them to the stack.
                Dim directoryName As String
                For Each directoryName In Directory.GetDirectories(dir)
                    stack.Push(directoryName)
                Next

            Catch ex As Exception
            End Try
        Loop

        ' Return the list
        Return result
    End Function

    Private Sub ShowGames_Click(sender As Object, e As EventArgs) Handles ButtonShowGames.Click

        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If ListGameLists.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner des Gamelists")
            Exit Sub
        End If

        'Showing stuff
        FinalGrid.Show()

        If ListGameLists.Items.Count = 0 Then Exit Sub



        Dim gamelist As String = ListGameLists.Items(0)
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
            .ColumnName = "GameId"
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
            .ColumnName = "CheminManuel"
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
            .ColumnName = "Adulte"
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

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Region"
        End With
        table.Columns.Add(column)

        'Loop for every gamelists
        For Each i In ListGameLists.SelectedItems

            'generating the console name
            'Dim console As String = i
            'Dim chercheroms As String = InStr(console, "roms\",)
            'Dim finphrase As String = console.Substring((chercheroms + 4))
            'Dim detectedeuz As String = InStr(finphrase, "\gamelist.xml")
            'Dim findugame As String = finphrase.Substring(0, detectedeuz - 1)
            Dim dettectarm As String = InStr(i, "ARRM")
            Dim nomduxml As String
            If dettectarm > 1 Then nomduxml = "\gamelist_ARRM.xml" Else nomduxml = "\gamelist.xml"
            Dim nomconsole As String = i.Substring((InStr(i, "roms\",) + 4)).Substring(0, InStr(i.Substring((InStr(i, "roms\",) + 4)), nomduxml) - 1)

            gamelist = i

            'On ajoute ensuite les consoles dans la listebox des console
            Dim consolederom As String = i
            consolederom = consolederom.Substring(InStr(consolederom, "\roms\") + 5).Substring(0, InStr(consolederom.Substring(InStr(consolederom, "\roms\") + 5), "\") - 1)

            listconsoleselected.Items.Add(consolederom)

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
                Dim romanual As String
                Dim romadult As String
                Dim romnote As String
                Dim romdev As String
                Dim rompubl As String
                Dim romnbplayers As String
                Dim romdate As String
                Dim romCompteur As String
                Dim romRegion As String
                Dim romhidden As String = xEle.Element("hidden")

                'Conditionnelles sur tous les champs
                If romhidden = "true" Then GoTo romsuivante 'si la rom est hidden, on l'affiche pas (Roms multicd)


                If xEle.Element("desc") Is Nothing Then
                    romdesc = Nothing
                Else
                    romdesc = xEle.Element("desc")
                End If

                Dim ExistGameId As Boolean = xEle.Attributes("id").Any

                If ExistGameId = True Then
                    romId = xEle.Attribute("id").Value
                Else
                    romId = Nothing
                End If

                If xEle.Element("image") Is Nothing Then
                    romimage = Nothing
                Else
                    romimage = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & Replace(Replace(Replace(xEle.Element("image"), "/", "\"), "./", ""), ".\", "")
                End If

                If xEle.Element("video") Is Nothing Then
                    romvideo = Nothing
                Else
                    romvideo = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & Replace(Replace(Replace(xEle.Element("video"), "/", "\"), "./", ""), ".\", "")
                End If

                If xEle.Element("manual") Is Nothing Then
                    romanual = Nothing
                Else
                    romanual = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & Replace(Replace(Replace(xEle.Element("manual"), "/", "\"), "./", ""), ".\", "")
                End If

                If xEle.Element("genre") Is Nothing Then
                    romgenre = Nothing
                Else
                    romgenre = xEle.Element("genre")
                End If

                If xEle.Element("adult") Is Nothing Then
                    romadult = Nothing
                Else
                    romadult = xEle.Element("adult")
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

                If xEle.Element("region") Is Nothing Then
                    romRegion = Nothing
                Else
                    romRegion = xEle.Element("region")
                End If

                'on ajoute le tout dans une table
                table.Rows.Add(romconsole, romname, romId, rompath, romdesc, romimage, romvideo, romanual, romgenre, romadult, romnote, romdev, rompubl, romnbplayers, romdate, romCompteur, romRegion)
romsuivante:
            Next
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        FinalGrid.DataSource = table

        'Width for columns
        FinalGrid.Columns("Console").Width = 50
        FinalGrid.Columns("Titre").Width = 260
        'Hiding les colonnes
        FinalGrid.Columns("GameId").Visible = False
        FinalGrid.Columns("CheminRom").Visible = False
        FinalGrid.Columns("Synopsis").Visible = False
        FinalGrid.Columns("CheminImage").Visible = False
        FinalGrid.Columns("CheminVideo").Visible = False
        FinalGrid.Columns("CheminManuel").Visible = False
        'Width for columns
        FinalGrid.Columns("Genre").Visible = False
        FinalGrid.Columns("Adulte").Visible = False
        FinalGrid.Columns("Note").Visible = False
        FinalGrid.Columns("Developer").Visible = False
        FinalGrid.Columns("Publisher").Visible = False
        FinalGrid.Columns("NbPlayers").Visible = False
        FinalGrid.Columns("DateSortie").Visible = False
        FinalGrid.Columns("NbLancé").Visible = False
        FinalGrid.Columns("Region").Visible = False

        'add checkable columns at the end
        Dim colromimage As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromimage)
        colromimage.HeaderText = "CocheImage"
        colromimage.Name = "CocheImage"
        colromimage.Width = 25

        Dim colromvideo As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromvideo)
        colromvideo.HeaderText = "CocheVideo"
        colromvideo.Name = "CocheVideo"
        colromvideo.Width = 25

        Dim colromanual As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromanual)
        colromanual.HeaderText = "CocheManuel"
        colromanual.Name = "CocheManuel"
        colromanual.Width = 25

        Dim colromoverlay As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromoverlay)
        colromoverlay.HeaderText = "CocheOverlay"
        colromoverlay.Name = "CocheOverlay"
        colromoverlay.Width = 25

        Dim colromsaves As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromsaves)
        colromsaves.HeaderText = "CocheSave"
        colromsaves.Name = "CocheSave"
        colromsaves.Width = 25

        'Ajout de la taille de la rom 
        Dim colromSize As New DataGridViewTextBoxColumn()
        FinalGrid.Columns.Add(colromSize)
        colromSize.HeaderText = "Mo"
        colromSize.Name = "Mo"
        colromSize.Width = 60

        Dim colromselection As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromselection)
        colromselection.HeaderText = "Selection"
        colromselection.Name = "Selection"
        colromselection.Width = 30

        'Reajusting Interface and Showing Final Interface
        ButtonImportXML.Hide()
        ListGameLists.Hide()
        FinalGrid.Location = New Point(8, 28)
        FinalGrid.Size = New Size(600, 365)
        grp_RomInfos.Show()
        GroupBox1.Show()
        ButtonShowGames.Hide()
        txt_txtsearch.Show()
        buttonRAZ.Show()
        GroupFiltresAvances.Show()
        dv.Sort = "Console asc, Titre asc"


        'On va alimenter les filtres de la combobox 
        ComboFiltreColonnes.Items.Add("Console")
        ComboFiltreColonnes.Items.Add("Titre")
        ComboFiltreColonnes.Text = "Titre"
        ComboFiltreColonnes.Items.Add("GameId")
        ComboFiltreColonnes.Items.Add("CheminRom")
        ComboFiltreColonnes.Items.Add("Synopsis")
        ComboFiltreColonnes.Items.Add("CheminImage")
        ComboFiltreColonnes.Items.Add("CheminVideo")
        ComboFiltreColonnes.Items.Add("CheminManuel")
        ComboFiltreColonnes.Items.Add("Genre")
        ComboFiltreColonnes.Items.Add("Adulte")
        ComboFiltreColonnes.Items.Add("Note")
        ComboFiltreColonnes.Items.Add("Developer")
        ComboFiltreColonnes.Items.Add("Publisher")
        ComboFiltreColonnes.Items.Add("NbPlayers")
        ComboFiltreColonnes.Items.Add("DateSortie")
        ComboFiltreColonnes.Items.Add("Nblancé")
        ComboFiltreColonnes.Items.Add("Region")

        'On compte le nombre total d'entrées
        txt_nbrom.Text = FinalGrid.Rows.Count - 1

        'On affiche les petites icones 
        minipic1.Show()
        minipic2.Show()
        minipic3.Show()
        minipic4.Show()
        minipic5.Show()


        'on va calculer la taille des roms
        Call Calcultaillerom()
        'On lance la completion des checkbox
        Call Completiondescheckbox()
        'On appelle le stockage size
        txt_USBGo.Text = My.Settings.StockageSize

        'On affiche le bouton Tuto !
        ButtonTuto.Show()
    End Sub

    Sub Calcultaillerom()
        On Error Resume Next
        Dim valeursize As String

        Dim comptage As Integer = FinalGrid.Rows.Count - 1
        If comptage = 0 Then Exit Sub

        For oRow = 0 To FinalGrid.Rows.Count - 2
            valeursize = FinalGrid.Rows(oRow).Cells(FinalGrid.Columns("Mo").Index).Value
            Dim valeurrom As String = FinalGrid.Rows(oRow).Cells(FinalGrid.Columns("Titre").Index).Value
            Dim chemindelarom = FinalGrid.Rows(oRow).Cells(FinalGrid.Columns("CheminRom").Index).Value
            If valeursize Is Nothing Then ' si la cellule valeur size est vide on la calcule, sinon rien

                Dim sizefichier As Double
                Dim attr As FileAttributes = File.GetAttributes(chemindelarom)

                If ((attr And FileAttribute.Directory) = FileAttribute.Directory) Then
                    'si c'est un repertoire (daphne, dos ...etc) 

                    Dim folder As New IO.DirectoryInfo(chemindelarom & "\")
                    For Each file As IO.FileInfo In folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
                        sizefichier += file.Length
                    Next file
                    GoTo labelapresfolder
                Else
                    'si c'est un fichier...
                    Dim extensionrom As String = Path.GetExtension(chemindelarom)

                    'si c'est un m3u, il faut lire le fichier pour recuperer la vraie taille des cd's dedans
                    If extensionrom = ".m3u" Then
                        File.ReadAllLines(chemindelarom)

                        ' Open the m3u file to read from.
                        Dim readText() As String = File.ReadAllLines(chemindelarom)
                        Dim s As String
                        sizefichier = 0
                        For Each s In readText
                            chemindelarom = My.Settings.RecalboxFolder & "\roms\" & FinalGrid.Rows(oRow).Cells(FinalGrid.Columns("Console").Index).Value & "\" & Replace(s, "/", "\")
                            Dim info As New FileInfo(chemindelarom)
                            sizefichier += info.Length
                        Next
                    ElseIf extensionrom = ".cue" Then 'si c'est un cue, il faut lire le fichier pour recuperer la vraie taille des cd's dedans
                        File.ReadAllLines(chemindelarom)

                        ' Open the cue file to read from.
                        Dim readText() As String = File.ReadAllLines(chemindelarom)
                        Dim s As String
                        sizefichier = 0
                        For Each s In readText
                            Dim detectfile = InStr(s, Chr(34))
                            If detectfile >= 1 Then
                                'Dim isolerome As String = s.Substring(detectfile)
                                'Dim isolebinary As String = InStr(isolerome, Chr(34))
                                'Dim isolerom As String = isolerome.Substring(0, isolebinary - 1)

                                Dim iso As String = s.Substring(detectfile).Substring(0, InStr(s.Substring(detectfile), Chr(34)) - 1)

                                chemindelarom = My.Settings.RecalboxFolder & "\roms\" & FinalGrid.Rows(oRow).Cells(0).Value & "\" & Replace(iso, "/", "\")

                                Dim info As New FileInfo(chemindelarom)
                                sizefichier += info.Length
                            End If
                        Next

                    Else

                        'sinon c'est un fichier normal 
                        Dim info As New FileInfo(chemindelarom)
                        sizefichier = info.Length
                    End If
                End If
labelapresfolder:
                'Conversion en Mo
                Dim tailleenmo As Double = sizefichier / 1048576
                FinalGrid.Rows(oRow).Cells(FinalGrid.Columns("Mo").Index).Value = Math.Round(tailleenmo, 2)
                sizefichier = 0
            End If
        Next
        On Error GoTo 0
    End Sub
    Sub Completiondescheckbox()

        For orow = 0 To FinalGrid.RowCount - 2
            If orow = 0 And FinalGrid.RowCount - 1 = orow Then
                MsgBox("Pas de Resultats")
                buttonRAZ.PerformClick()
                Exit Sub
            End If

            Dim cheminrom As String = FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CheminRom").Index).Value

            'test sur le chemin des screens, si la cellule est complétée alors on coche
            If IsDBNull(FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CheminImage").Index).Value) Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheImage").Index).Value = False
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheImage").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheImage").Index).Value = True
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheImage").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            End If
            'test sur le chemin des videos
            If IsDBNull(FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CheminVideo").Index).Value) Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheVideo").Index).Value = False
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheVideo").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheVideo").Index).Value = True
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheVideo").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            End If
            'test sur le chemin des manuels
            If IsDBNull(FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CheminManuel").Index).Value) Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheManuel").Index).Value = False
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheManuel").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheManuel").Index).Value = True
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheManuel").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            End If

            'test sur le chemin des overlays

            Dim FileInfo As New FileInfo(cheminrom)
            Dim nomdelarom As String = FileInfo.Name
            Dim nomducfg As String = nomdelarom & ".cfg"

            Dim cheminoverlay As String = Replace(cheminrom, "\roms\", "\overlays\")
            Dim testcheminoverlay As String = Replace(cheminoverlay, nomdelarom, nomducfg)

            If System.IO.File.Exists(testcheminoverlay) Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheOverlay").Index).Value = True
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheOverlay").Index).Value = False
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If

            'test sur le chemin des saves
            Dim cheminsaves As String = Replace(cheminrom, "\roms\", "\saves\")
            Dim romsansextension = FileNameWithoutExtension(nomdelarom)

            'test consoles qui n'ont pas de saves
            Dim consolesanssaves(34)
            consolesanssaves(0) = "3do"
            consolesanssaves(1) = "64dd"
            consolesanssaves(2) = "amigacd32"
            consolesanssaves(3) = "amigacdtv"
            consolesanssaves(4) = "apple2gs"
            consolesanssaves(5) = "atari5200"
            consolesanssaves(6) = "atarist"
            consolesanssaves(7) = "channelf"
            consolesanssaves(8) = "dos"
            consolesanssaves(9) = "easyrpg"
            consolesanssaves(10) = "fds"
            consolesanssaves(11) = "intellivision"
            consolesanssaves(12) = "moonlight"
            consolesanssaves(13) = "msx"
            consolesanssaves(14) = "msxturbor"
            consolesanssaves(15) = "multivision"
            consolesanssaves(16) = "neogeocd"
            consolesanssaves(17) = "o2em"
            consolesanssaves(18) = "oricatmos"
            consolesanssaves(19) = "palm"
            consolesanssaves(20) = "pc88"
            consolesanssaves(21) = "pc98"
            consolesanssaves(22) = "pcengine"
            consolesanssaves(23) = "pcfx"
            consolesanssaves(24) = "phillipscdi"
            consolesanssaves(25) = "ports"
            consolesanssaves(26) = "ps2"
            consolesanssaves(27) = "samcoupe"
            consolesanssaves(28) = "saturn"
            consolesanssaves(29) = "spectravideo"
            consolesanssaves(30) = "sufami"
            consolesanssaves(31) = "thomson"
            consolesanssaves(32) = "tic80"
            consolesanssaves(33) = "x1"
            consolesanssaves(34) = "x68000"

            'On test les saves, si c'est pas une console avec un dossier save, on passe au jeu suivant en mettant son fond en gris
            If consolesanssaves.Contains(FinalGrid.Rows(orow).Cells(FinalGrid.Columns("Console").Index).Value) Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheSave").Index).Value = False
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheSave").Index).Style.BackColor = Color.FromArgb(50, 50, 50)
                GoTo consolesanssaves
            End If

            'on verifie si il y'a des sauvegardes avec le nom du jeu en racine
            Dim savesCount As Integer = IO.Directory.GetFiles(Replace(cheminsaves, nomdelarom, ""), romsansextension & ".*").Length

            If savesCount >= 1 Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheSave").Index).Value = True
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheSave").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheSave").Index).Value = False
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheSave").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If
consolesanssaves:
        Next

        'On met en ReadOnly les cases coches
        FinalGrid.Columns("CocheImage").ReadOnly = True
        FinalGrid.Columns("CocheVideo").ReadOnly = True
        FinalGrid.Columns("CocheManuel").ReadOnly = True
        FinalGrid.Columns("CocheOverlay").ReadOnly = True
        FinalGrid.Columns("CocheSave").ReadOnly = True

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttongetback.Click
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub FinalGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FinalGrid.CellMouseClick
        Dim totalline As Integer = FinalGrid.RowCount - 1

        If e.RowIndex = totalline Or e.RowIndex < 0 Then Exit Sub

        'Chargement des informations dans Rom Informations
        Dim row As DataGridViewRow = FinalGrid.Rows(e.RowIndex)

        Dim celluleromname As String = row.Cells(FinalGrid.Columns("Titre").Index).Value
        Dim cellulerompath As String = row.Cells(FinalGrid.Columns("CheminRom").Index).Value
        Dim celluledesc As String
        Dim celluleimage As String
        Dim cellulevideo As String

        If IsDBNull(row.Cells(FinalGrid.Columns("Synopsis").Index).Value) Then
            celluledesc = Nothing
        Else
            celluledesc = row.Cells(FinalGrid.Columns("Synopsis").Index).Value
        End If

        If IsDBNull(row.Cells(FinalGrid.Columns("CheminImage").Index).Value) Then
            celluleimage = Nothing
        Else
            celluleimage = row.Cells(FinalGrid.Columns("CheminImage").Index).Value
        End If

        If IsDBNull(row.Cells(FinalGrid.Columns("CheminVideo").Index).Value) Then
            cellulevideo = Nothing
        Else
            cellulevideo = row.Cells(FinalGrid.Columns("CocheVideo").Index).Value
        End If


        'Defilement du Titre du Jeu
        txt_romname.Text = celluleromname
        Timer1.Start()
        sec = 0


        'On met le RomPath
        txt_rompath.Text = cellulerompath

        'SYNOPSIS
        If celluledesc = Nothing Then
            txt_romdesc.Text = ""
        Else
            txt_romdesc.Text = row.Cells(FinalGrid.Columns("Synopsis").Index).Value
        End If

        'IMAGE
        Dim console As String = row.Cells(FinalGrid.Columns("Console").Index).Value

        If celluleimage = Nothing Then
            RomImage.Hide()
        Else
            RomImage.Show()
            RomImage.Image = Image.FromFile(row.Cells(FinalGrid.Columns("CheminImage").Index).Value)
        End If

        'VIDEO
        If cellulevideo = Nothing Then
            vid_romvid.Hide()
        Else
            vid_romvid.Show()
            vid_romvid.URL = row.Cells(FinalGrid.Columns("CheminVideo").Index).Value
            vid_romvid.settings.setMode("loop", True)
            vid_romvid.settings.mute = True
            vid_romvid.Ctlcontrols.play()
        End If

        'Conditionnelle sur les Boutons
        On Error Resume Next
        Dim checkboximg As String = row.Cells(FinalGrid.Columns("CocheImage").Index).Value
        Dim checkboxvideo As String = row.Cells(FinalGrid.Columns("CocheVideo").Index).Value
        Dim checkboxmanual As String = row.Cells(FinalGrid.Columns("CocheManuel").Index).Value
        Dim checkboxoverlay As String = row.Cells(FinalGrid.Columns("CocheOverlay").Index).Value
        Dim checkboxsave As String = row.Cells(FinalGrid.Columns("CocheSave").Index).Value

        Dim imgscreen As New Bitmap(My.Resources.Okscreen)
        Dim imgscreenno As New Bitmap(My.Resources.noscreen)
        Dim imgscreen2 As New Bitmap(imgscreen, romscreeno.Width, romscreeno.Height)
        Dim imgscreen2no As New Bitmap(imgscreenno, romscreeno.Width, romscreeno.Height)

        Dim imgvideo As New Bitmap(My.Resources.OKvideo)
        Dim imgvideono As New Bitmap(My.Resources.novideo)
        Dim imgvideo2 As New Bitmap(imgvideo, romvideoo.Width, romvideoo.Height)
        Dim imgvideo2no As New Bitmap(imgvideono, romvideoo.Width, romvideoo.Height)

        Dim imgmanual As New Bitmap(My.Resources.OKmanual)
        Dim imgmanualno As New Bitmap(My.Resources.nomanual)
        Dim imgmanual2 As New Bitmap(imgmanual, romvideoo.Width, romvideoo.Height)
        Dim imgmanual2no As New Bitmap(imgmanualno, romvideoo.Width, romvideoo.Height)

        Dim imgoverlay As New Bitmap(My.Resources.OKoverlay)
        Dim imgoverlayno As New Bitmap(My.Resources.nooverlay)
        Dim imgoverlay2 As New Bitmap(imgoverlay, romoverlayo.Width, romoverlayo.Height)
        Dim imgoverlay2no As New Bitmap(imgoverlayno, romoverlayo.Width, romoverlayo.Height)

        Dim imgsaves As New Bitmap(My.Resources.OKMem)
        Dim imgsavesno As New Bitmap(My.Resources.nomem)
        Dim imgsaves2 As New Bitmap(imgsaves, romsaveo.Width, romsaveo.Height)
        Dim imgsaves2no As New Bitmap(imgsavesno, romsaveo.Width, romsaveo.Height)

        If checkboximg = False Or Nothing Then
            romscreeno.Image = imgscreen2no
        Else
            romscreeno.Image = imgscreen2
        End If

        If checkboxvideo = False Or Nothing Then
            romvideoo.Image = imgvideo2no
        Else
            romvideoo.Image = imgvideo2
        End If

        If checkboxmanual = False Or Nothing Then
            rommanualo.Image = imgmanual2no
        Else
            rommanualo.Image = imgmanual2
        End If

        If checkboxoverlay = False Or Nothing Then
            romoverlayo.Image = imgoverlay2no
        Else
            romoverlayo.Image = imgoverlay2
        End If

        If checkboxsave = False Or Nothing Then
            romsaveo.Image = imgsaves2no
        Else
            romsaveo.Image = imgsaves2
        End If
        On Error GoTo 0
    End Sub
    Public Function FileNameWithoutExtension(ByVal FullPath _
        As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function
    'Ends Edit Mode So CellValueChanged Event Can Fire
    Private Sub EndEditMode(sender As System.Object,
                            e As EventArgs) _
                Handles FinalGrid.CurrentCellDirtyStateChanged
        'if current cell of grid is dirty, commits edit
        If FinalGrid.IsCurrentCellDirty Then
            FinalGrid.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    'Executes when Cell Value on a DataGridView changes
    Private Sub DataGridCellValueChanged(sender As DataGridView,
                                         e As DataGridViewCellEventArgs) Handles FinalGrid.CellValueChanged
        'check that row isn't -1, i.e. creating datagrid header
        If e.RowIndex = -1 Then Exit Sub

        'On recherche le numero de la colonne des Selections
        If e.ColumnIndex = FinalGrid.Columns("Selection").Index Then

            'Si on est ici c'est qu'on vient de cocher la case Selection

            Dim columnindex As Integer = FinalGrid.CurrentCell.ColumnIndex
            Dim rowIndex As Integer = FinalGrid.CurrentCell.RowIndex
            Dim pathrom As String = FinalGrid.Rows(rowIndex).Cells(FinalGrid.Columns("CheminRom").Index).Value

            'Verification de l'etat de la coche
            'si la Case dans selection est cochée, alors on ajoute dans la listebox ma selection
            If FinalGrid.Rows(rowIndex).Cells(FinalGrid.Columns("Selection").Index).Value = True Then
                listboxMaSelection.Items.Add(pathrom)

                Dim a As String = pathrom
                'et on la selectionne dans la listbox pour l'avoir en bleue
                If listboxMaSelection.Visible = False Then 'on reboucle pour ne laisser l'element selectionné que le dernier.

                    listboxMaSelection.Show() 'si la listbox est invisible on l'affiche 
                    Call Selectiondudernier(a)
                    listboxMaSelection.Hide() 'et On la rehide
                Else
                    Call Selectiondudernier(a)
                End If

            Else 'ca veut dire que on va retirer un element là
                listboxMaSelection.Items.Remove(pathrom)
            End If
            'On va checker les doublons quand meme
            Supdoublon(listboxMaSelection)
            'On lance une update
            Call UpdatelesChiffreRoms()
        End If
    End Sub
    Sub Selectiondudernier(RomPath As String)
        For ligne = 0 To listboxMaSelection.Items.Count - 1
            If listboxMaSelection.Items(ligne).ToString = RomPath Then
                listboxMaSelection.SetSelected(ligne, True)
            Else
                listboxMaSelection.SetSelected(ligne, False)
            End If
        Next
    End Sub
    Sub UpdatelesChiffreRoms()
        'On test d'abord si y'en a des roms dans la selection !
        If listboxMaSelection.Items.Count = 0 Then Exit Sub

        'On calcule la taille des roms cochées
        Dim sizecumulrom As Decimal

        For a = 0 To listboxMaSelection.Items.Count - 1 'Toutes les lignes
            Dim romacchercher As String = listboxMaSelection.Items(a)
            For j = 0 To FinalGrid.RowCount - 1
                If FinalGrid.Rows(j).Cells(FinalGrid.Columns("CheminRom").Index).Value = romacchercher Then
                    sizecumulrom += Math.Round(FinalGrid.Rows(j).Cells(FinalGrid.Columns("Mo").Index).Value, 2)
                End If
            Next
            txt_GoAPrevoir.Text = sizecumulrom
        Next

        'On va Update les nombres de visibles et le nombre de roms selectionnées
        txtShownRoms.Text = FinalGrid.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1
        'on refresh l'indicateurs de selectionné
        Dim valeurnbselect As Integer = listboxMaSelection.Items.Count
        txt_NbRomSelected.Text = valeurnbselect
    End Sub
    Private Sub ButtonParcourirRecalCopy_Click(sender As Object, e As EventArgs) Handles ButtonParcourirRecalCopy.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txt_CopyFolder.Text = FolderBrowserDialog1.SelectedPath
            'On va remplacer la valeur par defaut "RecalboxFolder" et on la sauvegarde pour les prochaines fois
            My.Settings.CopyFolder = txt_CopyFolder.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub GroupBox1_VisibleChanged(sender As Object, e As EventArgs) Handles GroupBox1.VisibleChanged
        txt_CopyFolder.Text = My.Settings.CopyFolder
    End Sub

    Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopy.Click
        'verif du chemin
        If txt_CopyFolder.Text = Nothing Then
            MsgBox("Pas de Repertoire de Copie Défini" & Chr(13) & "ABANDON")
            Exit Sub
        End If

        'verif de la liste a copier
        If listboxMaSelection.Items.Count = 0 Then
            MsgBox("Pas de Roms à Copier" & Chr(13) & "ABANDON")
            Exit Sub
        End If

        'verif de l'espace disque
        If txt_GoAPrevoir.Text < 0 Then
            MsgBox("Trop d'espace est necessaire à la Copie" & Chr(13) & "ABANDON")
            Exit Sub
        End If

        'Verification que le chemin est vide
        Dim folder As New IO.DirectoryInfo(txt_CopyFolder.Text & "\")
        Dim sizedudossier = Nothing
        For Each file As IO.FileInfo In folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
            sizedudossier += file.Length
        Next file

        If sizedudossier >= 0 Then
            If MsgBox("Le Chemin de Copie : " & Chr(13) & txt_CopyFolder.Text & Chr(13) & "n'est pas vide" & Chr(13) & Chr(13) & "L'Assistant va creer un dossier : " & Chr(13) & txt_CopyFolder.Text & "\recalbox" & Chr(13) & "Continuer ?", vbYesNo) = vbNo Then Exit Sub
        End If

        'msgbox pour un recap de la selection et des options
        listboxMaSelection.Show()
        Dim temptxt1 As String
        Dim temptxt2 As String
        Dim temptxt3 As String
        Dim temptxt4 As String
        Dim temptxt5 As String
        Dim temptxt6 As String

        If checkbios.Checked = True Then
            temptxt1 = "Les Bios seront Copiées"
        Else
            temptxt1 = ""
        End If


        If checkimgs.Checked = True Then
            temptxt2 = "Les Images seront Copiées"
        Else
            temptxt2 = ""
        End If

        If checkvideos.Checked = True Then
            temptxt3 = "Les Vidéos seront Copiées"
        Else
            temptxt3 = ""

        End If

        If checkmanuals.Checked = True Then
            temptxt4 = "Les Manuels seront Copiés"
        Else
            temptxt4 = ""
        End If

        If checkoverlays.Checked = True Then
            temptxt5 = "Les Overlays seront Copiés"
        Else
            temptxt5 = ""
        End If

        If checksaves.Checked = True Then
            temptxt6 = "Les Saves seront copiées"
        Else
            temptxt6 = ""
        End If

        Dim optionsbox As String = temptxt1 & Chr(13) & temptxt2 & Chr(13) & temptxt3 & Chr(13) & temptxt4 & Chr(13) & temptxt5 & Chr(13) & temptxt6

        'Reposition listboxmaselection
        listboxMaSelection.Location = New Point(-2, 43)
        listboxMaSelection.Size = New Size(396, 433)

        If MsgBox("Vérifiez Votre Liste de Roms Ci Dessus" & Chr(13) & optionsbox & Chr(13) & Chr(13) & "Chemin de Copie :  " & Chr(13) & txt_CopyFolder.Text & "\recalbox", vbYesNo) = vbNo Then
            listboxMaSelection.Hide()
            Exit Sub
        End If

        'On défiltre par securité
        buttonRAZ.PerformClick()

        'On va boucler sur toutes les roms de la liste. 
        'COPIE DES ROMS
        Dim newrecalbox As String = My.Settings.CopyFolder & "\recalbox"
        Directory.CreateDirectory(newrecalbox)

        For i = 0 To listboxMaSelection.Items.Count - 1
            Dim pathjeu As String = listboxMaSelection.Items(i)
            Dim replacejeu As String = Replace(pathjeu, My.Settings.RecalboxFolder, newrecalbox)
            Dim repertoirefinal As String = Path.GetDirectoryName(replacejeu)
            Dim legamelist As String = Path.GetDirectoryName(pathjeu) & "\gamelist.xml"
            Dim lenouvogamelist As String = Path.GetDirectoryName(replacejeu) & "\gamelist.xml"
            Dim extensionrom As String = Path.GetExtension(pathjeu)

            'Dim consola As String = InStr(pathjeu, "\roms\")
            'Dim consoleu As String = pathjeu.Substring(consola + 5)
            'Dim prochainslash As String = InStr(consoleu, "\")
            'Dim consoledelarom As String = consoleu.Substring(0, prochainslash - 1)
            Dim consolederom As String = pathjeu.Substring(InStr(pathjeu, "\roms\") + 5).Substring(0, InStr(pathjeu.Substring(InStr(pathjeu, "\roms\") + 5), "\") - 1)

            'On check d'abord si c'est un m3u ou un cue pour recupérer les vrais jeux et le fichier
            'si c'est un m3u, il faut lire le fichier pour recuperer la vraie taille des cd's dedans
            If extensionrom = ".m3u" Then
                File.ReadAllLines(pathjeu)

                ' Open the m3u file to read from.
                Dim readText() As String = File.ReadAllLines(pathjeu)
                Dim s As String

                For Each s In readText
                    Dim pathducd As String = My.Settings.RecalboxFolder & "\roms\" & consolederom & "\" & Replace(s, "/", "\")
                    Dim replaceducd As String = Replace(pathducd, My.Settings.RecalboxFolder, newrecalbox)
                    'On check si ca existe, au cas ou on le cree
                    If (Not System.IO.Directory.Exists(Path.GetDirectoryName(replaceducd))) Then
                        System.IO.Directory.CreateDirectory(Path.GetDirectoryName(replaceducd))
                    End If
                    'et on copie LES CDS
                    System.IO.File.Copy(pathducd, replaceducd, True)

                Next
            ElseIf extensionrom = ".cue" Then 'si c'est un cue, il faut lire le fichier pour recuperer la vraie taille des cd's dedans
                File.ReadAllLines(pathjeu)

                ' Open the cue file to read from.
                Dim readText() As String = File.ReadAllLines(pathjeu)
                Dim g As String

                For Each g In readText
                    Dim detectfile = InStr(g, Chr(34))
                    If detectfile >= 1 Then
                        'Dim isolerome As String = s.Substring(detectfile)
                        'Dim isolebinary As String = InStr(isolerome, Chr(34))
                        'Dim isolerom As String = isolerome.Substring(0, isolebinary - 1)

                        Dim iso As String = g.Substring(detectfile).Substring(0, InStr(g.Substring(detectfile), Chr(34)) - 1)
                        Dim pathdeliso As String = My.Settings.RecalboxFolder & "\roms\" & consolederom & "\" & Replace(iso, "/", "\")
                        Dim pathisofinal As String = Replace(pathdeliso, My.Settings.RecalboxFolder, newrecalbox)
                        'On check si ca existe, au cas ou on le cree
                        If (Not System.IO.Directory.Exists(Path.GetDirectoryName(pathdeliso))) Then
                            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(pathdeliso))
                        End If
                        'et on copie LES CDS
                        System.IO.File.Copy(pathdeliso, pathisofinal, True)
                    End If
                Next
            End If

            'On retourne a la copie de la rom pure (pas les fichiers induits des CUE et bin)
            'On check si ca existe, au cas ou on le cree
            If (Not System.IO.Directory.Exists(repertoirefinal)) Then
                System.IO.Directory.CreateDirectory(repertoirefinal)
            End If

            'et on copie LES ROMS
            System.IO.File.Copy(pathjeu, replacejeu, True)

            'on fait un test sur les patchs SBI pour Playstation
            If consolederom = "psx" Then
                'on va chercher le fichier sbi avec le nom de la rom
                For Each foundFile As String In My.Computer.FileSystem.GetFiles(
Path.GetDirectoryName(pathjeu),
Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, FileNameWithoutExtension(pathjeu) & ".sbi")

                    Dim nomdusbi = foundFile
                    Dim cheminfinalsave = Replace(foundFile, My.Settings.RecalboxFolder, newrecalbox)
                    'et on copie LES saves
                    System.IO.File.Copy(foundFile, cheminfinalsave, True)
                Next

            End If

            'GAMELIST:
            'Tentative ecriture gamelist
            'on va d'abord tester pour voir si y'a deja un gamelist 

            If System.IO.File.Exists(lenouvogamelist) Then
                For xmline = 0 To FinalGrid.RowCount - 1

                    Dim jeuencours As String = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminRom").Index).Value
                    If jeuencours = pathjeu Then ' on cherche la ligne du jeu' si il existe on va UPDATE le gamelist

                        Dim doctoupdate As New Xml.XmlDocument()
                        doctoupdate.Load(lenouvogamelist)

                        'on recupere toutes les valeurs
                        Dim xmlname As String
                        Dim xmlpath As String = Replace(Replace(pathjeu, My.Settings.RecalboxFolder & "\roms\" & consolederom & "\", ""), "\", "/")
                        Dim xmlromId As String
                        Dim xmldesc As String
                        Dim xmlrating As String
                        Dim xmldeveloper As String
                        Dim xmlpublisher As String
                        Dim xmlgenre As String
                        Dim xmladult As String
                        Dim xmlplayers As String
                        Dim xmlreleasedate As String
                        Dim xmlimage As String
                        Dim xmlvideo As String
                        Dim xmlmanual As String
                        Dim xmlregion As String
                        Dim xmlplaycount As String

                        'test dugameid 
                        Dim game As Xml.XmlElement = doctoupdate.CreateElement("game")

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("GameId").Index).Value) Then
                            xmlromId = Nothing
                        Else
                            xmlromId = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("GameId").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Titre").Index).Value) Then
                            xmlname = Nothing
                        Else
                            xmlname = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Titre").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Synopsis").Index).Value) Then
                            xmldesc = Nothing
                        Else
                            xmldesc = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Synopsis").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Note").Index).Value) Then
                            xmlrating = Nothing
                        Else
                            xmlrating = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Note").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Developer").Index).Value) Then
                            xmldeveloper = Nothing
                        Else
                            xmldeveloper = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Developer").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Publisher").Index).Value) Then
                            xmlpublisher = Nothing
                        Else
                            xmlpublisher = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Publisher").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Genre").Index).Value) Then
                            xmlgenre = Nothing
                        Else
                            xmlgenre = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Genre").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Adulte").Index).Value) Then
                            xmladult = Nothing
                        Else
                            xmladult = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Adulte").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("NbPlayers").Index).Value) Then
                            xmlplayers = Nothing
                        Else
                            xmlplayers = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("NbPlayers").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("DateSortie").Index).Value) Then
                            xmlreleasedate = Nothing
                        Else
                            xmlreleasedate = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("DateSortie").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminImage").Index).Value) Then
                            xmlimage = Nothing
                        Else
                            xmlimage = Replace(Replace(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminImage").Index).Value, My.Settings.RecalboxFolder & "\roms\" & consolederom & "\", ""), "\", "/")
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminVideo").Index).Value) Then
                            xmlvideo = Nothing
                        Else
                            xmlvideo = Replace(Replace(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminVideo").Index).Value, My.Settings.RecalboxFolder & "\roms\" & consolederom & "\", ""), "\", "/")
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Nblancé").Index).Value) Then
                            xmlplaycount = Nothing
                        Else
                            xmlplaycount = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Nblancé").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminManuel").Index).Value) Then
                            xmlmanual = Nothing
                        Else
                            xmlmanual = Replace(Replace(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminManuel").Index).Value, My.Settings.RecalboxFolder & "\roms\" & consolederom & "\", ""), "\", "/")
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Region").Index).Value) Then
                            xmlregion = Nothing
                        Else
                            xmlregion = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Region").Index).Value
                        End If

                        'On va prendre chaque node et assigner aux valeur du dessus
                        Dim nameEl As Xml.XmlElement = doctoupdate.CreateElement("name")
                        nameEl.InnerText = xmlname
                        game.AppendChild(nameEl)
                        If xmlromId <> Nothing Then game.SetAttribute("id", xmlromId)
                        doctoupdate.DocumentElement.AppendChild(game)



                            Dim pathEl As Xml.XmlElement = doctoupdate.CreateElement("path")
                            pathEl.InnerText = xmlpath
                            game.AppendChild(pathEl)
                            doctoupdate.DocumentElement.AppendChild(game)

                            If xmldesc <> Nothing Then
                                Dim descEl As Xml.XmlElement = doctoupdate.CreateElement("desc")
                                descEl.InnerText = xmldesc
                                game.AppendChild(descEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlrating <> Nothing Then
                                Dim rateEl As Xml.XmlElement = doctoupdate.CreateElement("rating")
                                rateEl.InnerText = xmlrating
                                game.AppendChild(rateEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmldeveloper <> Nothing Then
                                Dim devEl As Xml.XmlElement = doctoupdate.CreateElement("developer")
                                devEl.InnerText = xmldeveloper
                                game.AppendChild(devEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlpublisher <> Nothing Then
                                Dim publEl As Xml.XmlElement = doctoupdate.CreateElement("publisher")
                                publEl.InnerText = xmlpublisher
                                game.AppendChild(publEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlgenre <> Nothing Then
                                Dim genrEl As Xml.XmlElement = doctoupdate.CreateElement("genre")
                                genrEl.InnerText = xmlgenre
                                game.AppendChild(genrEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmladult <> Nothing Or xmladult = "true" Then
                                Dim adultEl As Xml.XmlElement = doctoupdate.CreateElement("adult")
                                adultEl.InnerText = xmladult
                                game.AppendChild(adultEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlplayers <> Nothing Then
                                Dim playEl As Xml.XmlElement = doctoupdate.CreateElement("players")
                                playEl.InnerText = xmlplayers
                                game.AppendChild(playEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlreleasedate <> Nothing Then
                                Dim dateEl As Xml.XmlElement = doctoupdate.CreateElement("releasedate")
                                dateEl.InnerText = xmlreleasedate
                                game.AppendChild(dateEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlimage <> Nothing Then
                                Dim imageEl As Xml.XmlElement = doctoupdate.CreateElement("image")
                                imageEl.InnerText = xmlimage
                                game.AppendChild(imageEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlvideo <> Nothing Then
                                Dim videoEl As Xml.XmlElement = doctoupdate.CreateElement("video")
                                videoEl.InnerText = xmlvideo
                                game.AppendChild(videoEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlplaycount <> Nothing Then
                                Dim pcountEl As Xml.XmlElement = doctoupdate.CreateElement("playcount")
                                pcountEl.InnerText = xmlplaycount
                                game.AppendChild(pcountEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlmanual <> Nothing Then
                                Dim manualEl As Xml.XmlElement = doctoupdate.CreateElement("manual")
                                manualEl.InnerText = xmlmanual
                                game.AppendChild(manualEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If

                            If xmlregion <> Nothing Then
                                Dim regEl As Xml.XmlElement = doctoupdate.CreateElement("region")
                                regEl.InnerText = xmlregion
                                game.AppendChild(regEl)
                                doctoupdate.DocumentElement.AppendChild(game)
                            End If
                            doctoupdate.Save(lenouvogamelist)
                        End If
                Next
            Else
                'si le gamelist n'existe pas, on va devoir le creer
                Dim xmlDoc As New Xml.XmlDocument
                Dim fooElement As Xml.XmlElement = xmlDoc.CreateElement("gameList")

                For xmline = 0 To FinalGrid.RowCount - 1

                    Dim jeuencours As String = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminRom").Index).Value
                    If jeuencours = pathjeu Then ' on cherche la ligne du jeu
                        'on doit obtenir tout les nodes qu'on a sur le jeu 
                        xmlDoc.AppendChild(fooElement)
                        Dim xmlname As String
                        Dim xmlpath As String = Replace(Replace(pathjeu, My.Settings.RecalboxFolder & "\roms\" & consolederom & "\", ""), "\", "/")
                        Dim xmldesc As String
                        Dim xmlromId As Integer
                        Dim xmlrating As String
                        Dim xmldeveloper As String
                        Dim xmlpublisher As String
                        Dim xmlgenre As String
                        Dim xmladult As String
                        Dim xmlplayers As String
                        Dim xmlreleasedate As String
                        Dim xmlimage As String
                        Dim xmlvideo As String
                        Dim xmlmanual As String
                        Dim xmlregion As String
                        Dim xmlplaycount As String

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Titre").Index).Value) Then
                            xmlname = Nothing
                        Else
                            xmlname = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Titre").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("GameId").Index).Value) Then
                            xmlromId = Nothing
                        Else
                            xmlromId = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("GameId").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Synopsis").Index).Value) Then
                            xmldesc = Nothing
                        Else
                            xmldesc = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Synopsis").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Note").Index).Value) Then
                            xmlrating = Nothing
                        Else
                            xmlrating = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Note").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Developer").Index).Value) Then
                            xmldeveloper = Nothing
                        Else
                            xmldeveloper = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Developer").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Publisher").Index).Value) Then
                            xmlpublisher = Nothing
                        Else
                            xmlpublisher = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Publisher").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Genre").Index).Value) Then
                            xmlgenre = Nothing
                        Else
                            xmlgenre = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Genre").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Adulte").Index).Value) Then
                            xmladult = Nothing
                        Else
                            xmladult = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Adulte").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("NbPlayers").Index).Value) Then
                            xmlplayers = Nothing
                        Else
                            xmlplayers = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("NbPlayers").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("DateSortie").Index).Value) Then
                            xmlreleasedate = Nothing
                        Else
                            xmlreleasedate = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("DateSortie").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminImage").Index).Value) Then
                            xmlimage = Nothing
                        Else
                            xmlimage = Replace(Replace(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminImage").Index).Value, My.Settings.RecalboxFolder & "\roms\" & consolederom & "\", ""), "\", "/")
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminVideo").Index).Value) Then
                            xmlvideo = Nothing
                        Else
                            xmlvideo = Replace(Replace(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminVideo").Index).Value, My.Settings.RecalboxFolder & "\roms\" & consolederom & "\", ""), "\", "/")
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Nblancé").Index).Value) Then
                            xmlplaycount = Nothing
                        Else
                            xmlplaycount = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Nblancé").Index).Value
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminManuel").Index).Value) Then
                            xmlmanual = Nothing
                        Else
                            xmlmanual = Replace(Replace(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("CheminManuel").Index).Value, My.Settings.RecalboxFolder & "\roms\" & consolederom & "\", ""), "\", "/")
                        End If

                        If IsDBNull(FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Region").Index).Value) Then
                            xmlregion = Nothing
                        Else
                            xmlregion = FinalGrid.Rows(xmline).Cells(FinalGrid.Columns("Region").Index).Value
                        End If

                        Dim wwriter As New Xml.XmlTextWriter(Path.GetDirectoryName(replacejeu) & "\gamelist.xml", System.Text.Encoding.UTF8)
                        wwriter.WriteStartDocument(True)
                        wwriter.Formatting = Xml.Formatting.Indented
                        wwriter.Indentation = 2
                        wwriter.WriteStartElement("gameList")

                        CreateNode(xmlname _
                                     , xmlpath _
                                     , xmldesc _
                                     , xmlrating _
                                     , xmldeveloper _
                                     , xmlpublisher _
                                     , xmlgenre _
                                     , xmladult _
                                     , xmlplayers _
                                     , xmlreleasedate _
                                     , xmlimage _
                                     , xmlvideo _
                                     , xmlmanual _
                                     , xmlregion _
                                     , xmlplaycount _
                                     , wwriter, xmlromId)

                        wwriter.WriteEndElement()
                        wwriter.WriteEndDocument()
                        wwriter.Close()

                    End If
                Next
            End If

            'a optimiser pour ecrire le gamelist en temps réel ...
            'en attendant on copie le gamelist
            'System.IO.File.Copy(legamelist, lenouvogamelist, True)


            'on check si la copie des image a été activée
            If checkimgs.Checked = True Then

                For a = 0 To FinalGrid.RowCount - 1 'Auquel cas on va boucler sur toute les lignes jusqu'a trouver la rom
                    Dim jeuencours As String = FinalGrid.Rows(a).Cells(FinalGrid.Columns("CheminRom").Index).Value
                    If jeuencours = pathjeu Then ' on cherche la ligne du jeu

                        Dim estcequeimage As String
                        estcequeimage = FinalGrid.Rows(a).Cells(FinalGrid.Columns("CocheOverlay").Index).Value
                        If estcequeimage = True Then 'on verifie si le jeu a une image

                            Dim console As String = FinalGrid.Rows(a).Cells(FinalGrid.Columns("Console").Index).Value
                            Dim cheminimage As String = FinalGrid.Rows(a).Cells(FinalGrid.Columns("CheminImage").Index).Value
                            Dim nouvocheminimage As String = Replace(cheminimage, My.Settings.RecalboxFolder, newrecalbox)
                            'On check si ca existe, au cas ou on le cree
                            If (Not System.IO.Directory.Exists(Path.GetDirectoryName(nouvocheminimage))) Then
                                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(nouvocheminimage))
                            End If
                            'et on copie LES images
                            System.IO.File.Copy(cheminimage, nouvocheminimage, True)
                            Exit For
                        End If
                    End If
                Next
            End If

            'on check si les videos
            If checkvideos.Checked = True Then

                For b = 0 To FinalGrid.RowCount - 1 'Toutes les lignes

                    Dim jeuencours As String = FinalGrid.Rows(b).Cells(FinalGrid.Columns("CheminRom").Index).Value
                    If jeuencours = pathjeu Then ' colonne des path

                        Dim estcequevideo As String
                        estcequevideo = FinalGrid.Rows(b).Cells(FinalGrid.Columns("CocheVideo").Index).Value
                        If estcequevideo = True Then 'on verifie si le jeu a une video

                            Dim console As String = FinalGrid.Rows(b).Cells(FinalGrid.Columns("Console").Index).Value
                            Dim cheminvideo As String = FinalGrid.Rows(b).Cells(FinalGrid.Columns("CheminVideo").Index).Value
                            Dim nouvocheminvideo As String = Replace(cheminvideo, My.Settings.RecalboxFolder, newrecalbox)
                            'On check si ca existe, au cas ou on le cree
                            If (Not System.IO.Directory.Exists(Path.GetDirectoryName(nouvocheminvideo))) Then
                                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(nouvocheminvideo))
                            End If

                            'et on copie LES videos
                            System.IO.File.Copy(cheminvideo, nouvocheminvideo, True)
                            Exit For
                        End If
                    End If
                Next
            End If

            'on check si les manuels
            If checkmanuals.Checked = True Then

                For c = 0 To FinalGrid.RowCount - 1 'Toutes les lignes


                    Dim jeuencours As String = FinalGrid.Rows(c).Cells(FinalGrid.Columns("CheminRom").Index).Value
                    If jeuencours = pathjeu Then ' colonne des path

                        Dim estcequemanuel As String
                        estcequemanuel = FinalGrid.Rows(c).Cells(FinalGrid.Columns("CocheManuel").Index).Value
                        If estcequemanuel = True Then 'on verifie si le jeu a un manuel

                            Dim console As String = FinalGrid.Rows(c).Cells(FinalGrid.Columns("Console").Index).Value
                            Dim cheminmanuel As String = FinalGrid.Rows(c).Cells(FinalGrid.Columns("CheminManuel").Index).Value
                            Dim nouvocheminmanuel As String = Replace(cheminmanuel, My.Settings.RecalboxFolder, newrecalbox)
                            'On check si ca existe, au cas ou on le cree
                            If (Not System.IO.Directory.Exists(Path.GetDirectoryName(nouvocheminmanuel))) Then
                                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(nouvocheminmanuel))
                            End If

                            'et on copie LES images
                            System.IO.File.Copy(cheminmanuel, nouvocheminmanuel, True)
                            Exit For
                        End If
                    End If
                Next
            End If

            'on check si les overlays
            If checkoverlays.Checked = True Then

                For d = 0 To FinalGrid.RowCount - 1 'Toutes les lignes

                    'check sur le jeu 

                    Dim jeuencours As String = FinalGrid.Rows(d).Cells(FinalGrid.Columns("CheminRom").Index).Value
                    If jeuencours = pathjeu Then ' colonne des path
                        Dim estcequeoverlay As String
                        estcequeoverlay = FinalGrid.Rows(d).Cells(FinalGrid.Columns("CocheOverlay").Index).Value ' on check si le jeu a un overlay sinon on zappe le traitement
                        If estcequeoverlay = True Then 'on verifie si le jeu a un overlay

                            Dim cheminpropreoverlay2 As String
                            Dim console As String = FinalGrid.Rows(d).Cells(FinalGrid.Columns("Console").Index).Value
                            Dim cheminoverlaycfg1 As String = Replace(FinalGrid.Rows(d).Cells(2).Value, "\roms\", "\overlays\") & ".cfg"

                            Dim justefichier2 As String
                            Dim cheminpng3 As String


                            cheminpropreoverlay2 = 0
                            justefichier2 = 0
                            cheminpng3 = 0

                            'on va lire le cfg pour trouver le cfg overlay
                            File.ReadAllLines(cheminoverlaycfg1)

                            Dim readText() As String = File.ReadAllLines(cheminoverlaycfg1)
                            Dim s As String

                            For Each s In readText
                                Dim detectinputoverlay As String = InStr(s, "/overlays/")
                                If detectinputoverlay > 0 Then
                                    'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                                    'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                                    'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)
                                    Dim chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                                    cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\overlays\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                                    justefichier2 = FileNameWithoutExtension(cheminpropreoverlay2) & ".cfg"
                                    Exit For
                                End If
                            Next

                            'on lit le deuxieme fichier overlay cfg pour trouver le png
                            File.ReadAllLines(cheminpropreoverlay2)

                            Dim readText2() As String = File.ReadAllLines(cheminpropreoverlay2)
                            Dim t As String

                            For Each t In readText2
                                Dim detectoverlayzero As String = InStr(t, "overlay0_overlay")
                                If detectoverlayzero > 0 Then
                                    'Dim chemindupng = t.Substring(detectoverlayzero + 19)
                                    ' Dim detectpng = InStr(chemindupng, "png")
                                    ' Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 2)
                                    Dim cheminpng = t.Substring(InStr(t, "overlay0_overlay") + 19).Substring(0, InStr(t.Substring(InStr(t, "overlay0_overlay") + 19), "png") + 2)
                                    cheminpng3 = Replace(cheminpropreoverlay2, justefichier2, cheminpng)
                                    Exit For
                                End If
                            Next

                            Dim nouvochemin1 As String = Replace(cheminoverlaycfg1, My.Settings.RecalboxFolder, newrecalbox)
                            Dim nouvochemin2 As String = Replace(cheminpropreoverlay2, My.Settings.RecalboxFolder, newrecalbox)
                            Dim nouvochemin3 As String = Replace(cheminpng3, My.Settings.RecalboxFolder, newrecalbox)

                            'On check si ca existe, au cas ou on le cree
                            If (Not System.IO.Directory.Exists(Path.GetDirectoryName(nouvochemin2))) Then
                                System.IO.Directory.CreateDirectory(Path.GetDirectoryName(nouvochemin2))
                            End If

                            'et on copie LES 3 fichiers Overlays
                            System.IO.File.Copy(cheminoverlaycfg1, nouvochemin1, True)
                            System.IO.File.Copy(cheminpropreoverlay2, nouvochemin2, True)
                            System.IO.File.Copy(cheminpng3, nouvochemin3, True)
                            Exit For
                        End If
                    End If
                Next
            End If


            'on check si les saves
            If checksaves.Checked = True Then
                For e1 = 0 To FinalGrid.RowCount - 1 'Toutes les lignes

                    Dim jeuencours As String = FinalGrid.Rows(e1).Cells(FinalGrid.Columns("CheminRom").Index).Value
                    If jeuencours = pathjeu Then ' colonne des path

                        Dim estcequesaves As String
                        estcequesaves = FinalGrid.Rows(e1).Cells(FinalGrid.Columns("CocheSave").Index).Value ' on check si le jeu a un overlay sinon on zappe le traitement
                        If estcequesaves = True Then 'on verifie si le jeu a des saves

                            Dim console As String = FinalGrid.Rows(e1).Cells(FinalGrid.Columns("Console").Index).Value
                            Dim tempsaves As String = FinalGrid.Rows(e1).Cells(FinalGrid.Columns("CheminRom").Index).Value
                            Dim savesdir As String = Path.GetDirectoryName(Replace(tempsaves, "\roms\", "\saves\"))
                            'on va creer un tableau temporaire pour stocker tous les fichiers avec la racine du jeu (sstates et saves du coup)
                            Dim tableauresultats(100)
                            Dim compteur As Integer = 0
                            'on va boucler pour les stocker
                            For Each foundFile As String In My.Computer.FileSystem.GetFiles(
savesdir,
Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, FileNameWithoutExtension(jeuencours) & ".*")

                                tableauresultats(compteur) = foundFile
                                compteur += 1
                            Next

                            'on va les retravailler pour avoir le chemin complet
                            Dim cheminfinalsave As String
                            cheminfinalsave = 0
                            For lignetab = 0 To compteur - 1
                                cheminfinalsave = Replace(tableauresultats(lignetab), My.Settings.RecalboxFolder, newrecalbox)

                                'On check si ca existe, au cas ou on le cree
                                If (Not System.IO.Directory.Exists(Path.GetDirectoryName(cheminfinalsave))) Then
                                    System.IO.Directory.CreateDirectory(Path.GetDirectoryName(cheminfinalsave))
                                End If
                                'et on copie LES saves
                                System.IO.File.Copy(tableauresultats(lignetab), cheminfinalsave, True)
                            Next
                        End If
                    End If
                Next
            End If
        Next

        'Demande les Overlay systemes ?
        If checkoverlays.Checked = True Then
            If MsgBox("Vous avez coché la copie d'Overlays, Que souhaitez vous Copier ?" & Chr(13) & "Oui = Tous les Systemes" & Chr(13) & "Annuler = Uniquement les Consoles de la vue Actuelle" & Chr(13) & "Non = Aucune, Mauvaise saisie :) !", vbYesNoCancel) = vbYes Then
                On Error Resume Next
                For overlaysys = 0 To ListGameLists.Items.Count - 1
                    Dim fulladresse As String = Path.GetDirectoryName(ListGameLists.Items(overlaysys))
                    Dim overlayadresse As String = Replace(fulladresse, "\roms\", "\overlays\")
                    Dim parentName As String = IO.Path.GetFileName(overlayadresse)

                    Dim fichier1cfg As String = overlayadresse & "\" & parentName & ".cfg"
                    Dim fichier2overlaycfg As String
                    Dim fichier3png As String

                    Dim cheminpropreoverlay2 As String
                    Dim justefichier2 As String

                    fichier3png = 0
                    justefichier2 = 0
                    fichier2overlaycfg = 0
                    cheminpropreoverlay2 = 0

                    'on va lire le cfg pour trouver le cfg overlay
                    File.ReadAllLines(fichier1cfg)

                    Dim readText() As String = File.ReadAllLines(fichier1cfg)
                    Dim s As String

                    For Each s In readText
                        Dim detectinputoverlay As String = InStr(s, "/overlays/")
                        If detectinputoverlay > 0 Then
                            'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                            'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                            'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)
                            Dim chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                            cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\overlays\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                            justefichier2 = FileNameWithoutExtension(cheminpropreoverlay2) & ".cfg"
                            Exit For
                        End If
                    Next

                    'on lit le deuxieme fichier overlay cfg pour trouver le png
                    File.ReadAllLines(cheminpropreoverlay2)

                    Dim readText2() As String = File.ReadAllLines(cheminpropreoverlay2)
                    Dim t As String

                    For Each t In readText2
                        Dim detectoverlayzero As String = InStr(t, "overlay0_overlay")
                        If detectoverlayzero > 0 Then
                            Dim chemindupng = t.Substring(detectoverlayzero + 18)
                            Dim detectpng = InStr(chemindupng, "png")
                            Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 2)
                            Dim cheminpng = t.Substring(InStr(t, "overlay0_overlay") + 18).Substring(0, InStr(t.Substring(InStr(t, "overlay0_overlay") + 18), "png") + 2)
                            fichier3png = Replace(cheminpropreoverlay2, justefichier2, cheminpng)
                            Exit For
                        End If
                    Next

                    Dim nouvochemin1 As String = Replace(fichier1cfg, My.Settings.RecalboxFolder, newrecalbox)
                    Dim nouvochemin2 As String = Replace(cheminpropreoverlay2, My.Settings.RecalboxFolder, newrecalbox)
                    Dim nouvochemin3 As String = Replace(fichier3png, My.Settings.RecalboxFolder, newrecalbox)

                    'On check si ca existe, au cas ou on le cree
                    If (Not System.IO.Directory.Exists(Path.GetDirectoryName(nouvochemin2))) Then
                        System.IO.Directory.CreateDirectory(Path.GetDirectoryName(nouvochemin2))
                    End If

                    'et on copie LES 3 fichiers Overlays
                    System.IO.File.Copy(fichier1cfg, nouvochemin1, True)
                    System.IO.File.Copy(cheminpropreoverlay2, nouvochemin2, True)
                    System.IO.File.Copy(fichier3png, nouvochemin3, True)
                Next
                On Error GoTo 0

            ElseIf vbCancel Then

                For ligne = 0 To listconsoleselected.Items.Count - 1
                    Dim consolename As String = listconsoleselected.Items(ligne)
                    Dim fulladresse As String = My.Settings.RecalboxFolder & "\roms\" & consolename
                    Dim overlayadresse As String = Replace(fulladresse, "\roms\", "\overlays\")
                    Dim parentName As String = IO.Path.GetFileName(overlayadresse)

                    Dim fichier1cfg As String = overlayadresse & "\" & parentName & ".cfg"
                    Dim fichier2overlaycfg As String
                    Dim fichier3png As String

                    Dim cheminpropreoverlay2 As String
                    Dim justefichier2 As String

                    fichier3png = 0
                    justefichier2 = 0
                    fichier2overlaycfg = 0
                    cheminpropreoverlay2 = 0

                    'on va lire le cfg pour trouver le cfg overlay
                    File.ReadAllLines(fichier1cfg)

                    Dim readText() As String = File.ReadAllLines(fichier1cfg)
                    Dim s As String

                    For Each s In readText
                        Dim detectinputoverlay As String = InStr(s, "/overlays/")
                        If detectinputoverlay > 0 Then
                            'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                            'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                            'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)
                            Dim chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                            cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\overlays\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                            justefichier2 = FileNameWithoutExtension(cheminpropreoverlay2) & ".cfg"
                            Exit For
                        End If
                    Next

                    'on lit le deuxieme fichier overlay cfg pour trouver le png
                    File.ReadAllLines(cheminpropreoverlay2)

                    Dim readText2() As String = File.ReadAllLines(cheminpropreoverlay2)
                    Dim t As String

                    For Each t In readText2
                        Dim detectoverlayzero As String = InStr(t, "overlay0_overlay")
                        If detectoverlayzero > 0 Then
                            Dim chemindupng = t.Substring(detectoverlayzero + 18)
                            Dim detectpng = InStr(chemindupng, "png")
                            Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 2)
                            Dim cheminpng = t.Substring(InStr(t, "overlay0_overlay") + 18).Substring(0, InStr(t.Substring(InStr(t, "overlay0_overlay") + 18), "png") + 2)
                            fichier3png = Replace(cheminpropreoverlay2, justefichier2, cheminpng)
                            Exit For
                        End If
                    Next

                    Dim nouvochemin1 As String = Replace(fichier1cfg, My.Settings.RecalboxFolder, newrecalbox)
                    Dim nouvochemin2 As String = Replace(cheminpropreoverlay2, My.Settings.RecalboxFolder, newrecalbox)
                    Dim nouvochemin3 As String = Replace(fichier3png, My.Settings.RecalboxFolder, newrecalbox)

                    'On check si ca existe, au cas ou on le cree
                    If (Not System.IO.Directory.Exists(Path.GetDirectoryName(nouvochemin2))) Then
                        System.IO.Directory.CreateDirectory(Path.GetDirectoryName(nouvochemin2))
                    End If

                    'et on copie LES 3 fichiers Overlays
                    System.IO.File.Copy(fichier1cfg, nouvochemin1, True)
                    System.IO.File.Copy(cheminpropreoverlay2, nouvochemin2, True)
                    System.IO.File.Copy(fichier3png, nouvochemin3, True)
                    On Error GoTo 0

                Next

            End If
        End If

        'on check si les BIOS a la fin 
        If checkbios.Checked = True Then
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(My.Settings.RecalboxFolder & "\Bios", newrecalbox & "\Bios", True)
        End If

        'calcul taille total du dossier
        Dim sizefichier As Long
        Dim foldero As New IO.DirectoryInfo(My.Settings.CopyFolder)
        For Each file As IO.FileInfo In foldero.GetFiles("*.*", IO.SearchOption.AllDirectories)
            sizefichier += file.Length
        Next file

        Dim calcultailletotal As Decimal = Math.Round(sizefichier / 1048576, 2)

        MsgBox("Copie Terminée !" & Chr(13) & "Taille Totale : " & calcultailletotal & " Mo" & Chr(13) & "Veuillez Deplacer le dossier 'recalbox' sur votre media")
        Process.Start("explorer", My.Settings.CopyFolder)
    End Sub
    Private Sub CreateNode(ByVal xmlname As String _
        , ByVal xmlpath As String _
        , ByVal xmldesc As String _
                           , ByVal xmlrating As String _
                           , ByVal xmldeveloper As String _
                           , ByVal xmlpublisher As String _
                           , ByVal xmlgenre As String _
                           , ByVal xmladult As String _
                           , ByVal xmlplayers As String _
                           , ByVal xmlreleasedate As String _
                           , ByVal xmlimage As String _
                           , ByVal xmlvideo As String _
                           , ByVal xmlmanual As String _
                           , ByVal xmlregion As String _
                           , ByVal xmlplaycount As String _
                           , ByVal writer As Xml.XmlTextWriter, gameid As Integer)

        If gameid = Nothing Then
            writer.WriteStartElement("game")
        Else
            writer.WriteStartElement("game")
            writer.WriteAttributeString("id", gameid)
        End If

        writer.WriteStartElement("name")
        writer.WriteString(xmlname)
        writer.WriteEndElement()

        writer.WriteStartElement("path")
        writer.WriteString(xmlpath)
        writer.WriteEndElement()

        If xmldesc <> Nothing Then
            writer.WriteStartElement("desc")
            writer.WriteString(xmldesc)
            writer.WriteEndElement()
        End If

        If xmlrating <> Nothing Then
            writer.WriteStartElement("rating")
            writer.WriteString(xmlrating)
            writer.WriteEndElement()
        End If

        If xmldeveloper <> Nothing Then
            writer.WriteStartElement("developer")
            writer.WriteString(xmldeveloper)
            writer.WriteEndElement()
        End If

        If xmlpublisher <> Nothing Then
            writer.WriteStartElement("publisher")
            writer.WriteString(xmlpublisher)
            writer.WriteEndElement()
        End If

        If xmlgenre <> Nothing Then
            writer.WriteStartElement("genre")
            writer.WriteString(xmlgenre)
            writer.WriteEndElement()
        End If

        If xmladult <> Nothing Or xmladult = "true" Then
            writer.WriteStartElement("adult")
            writer.WriteString(xmladult)
            writer.WriteEndElement()
        End If

        If xmlplayers <> Nothing Then
            writer.WriteStartElement("players")
            writer.WriteString(xmlplayers)
            writer.WriteEndElement()
        End If

        If xmlreleasedate <> Nothing Then
            writer.WriteStartElement("releasedate")
            writer.WriteString(xmlreleasedate)
            writer.WriteEndElement()
        End If

        If xmlimage <> Nothing Then
            writer.WriteStartElement("image")
            writer.WriteString(xmlimage)
            writer.WriteEndElement()
        End If

        If xmlvideo <> Nothing Then
            writer.WriteStartElement("video")
            writer.WriteString(xmlvideo)
            writer.WriteEndElement()
        End If

        If xmlmanual <> Nothing Then
            writer.WriteStartElement("manual")
            writer.WriteString(xmlmanual)
            writer.WriteEndElement()
        End If

        If xmlregion <> Nothing Then
            writer.WriteStartElement("region")
            writer.WriteString(xmlregion)
            writer.WriteEndElement()
        End If

        If xmlplaycount <> Nothing Then
            writer.WriteStartElement("playcount")
            writer.WriteString(xmlplaycount)
            writer.WriteEndElement()
        End If

        writer.WriteEndElement()
    End Sub
    Private Sub Buttonaffichermaselection_Click(sender As Object, e As EventArgs) Handles buttonaffichermaselection.Click
        'On affiche la Listbox a la bonne place ou on là referme
        If listboxMaSelection.Visible = True Then
            listboxMaSelection.Hide()
        Else
            listboxMaSelection.Location = New Point(-2, 43)
            listboxMaSelection.Size = New Size(396, 433)
            listboxMaSelection.Show()
        End If

        ' 'Verification de la listebox en coherence avec FinalGrid
        For j = 0 To listboxMaSelection.Items.Count - 1 'toutes les lignes de la listbox

            Dim romselected As String = listboxMaSelection.Items(j)
            For a = 0 To FinalGrid.RowCount - 1 'Toutes les lignes du grid
                If FinalGrid.Rows(a).Cells(FinalGrid.Columns("CheminRom").Index).Value = romselected Then ' colonne des path
                    Dim valeurselection As String = FinalGrid.Rows(a).Cells(FinalGrid.Columns("Selection").Index).Value

                    If valeurselection = False Then 'Ici on est sur la bonne ligne du Final Grid, on verifie si c'est pas coché et on replique si besoin
                        FinalGrid.Rows(a).Cells(FinalGrid.Columns("Selection").Index).Value = False
                        GoTo prochainj 'on saute au prochain jeu
                    ElseIf valeurselection = FinalGrid.Rows(a).Cells(FinalGrid.Columns("Selection").Index).Value Then
                        GoTo prochainj
                    End If
                End If
            Next
prochainj:
        Next

        'Check des Doublons
        Supdoublon(listboxMaSelection)

        'On lance un calcul par securité
        Call UpdatelesChiffreRoms()

    End Sub
    Function Supdoublon(ByVal listboxName As ListBox)
        listboxName.Sorted = True
        listboxName.Refresh()
        Dim index As Integer
        Dim itemcount As Integer = listboxName.Items.Count

        If itemcount > 1 Then
            Dim lastitem As String = listboxName.Items(itemcount - 1)

            For index = itemcount - 2 To 0 Step -1
                If listboxName.Items(index) = lastitem Then
                    listboxName.Items.RemoveAt(index)
                Else
                    lastitem = listboxName.Items(index)
                End If
            Next
        End If
    End Function
    Private Sub ListboxMaSelection_DoubleClick(sender As Object, e As EventArgs) Handles listboxMaSelection.DoubleClick
        'on enleve de la liste et on met a jour la checkbox dans la selection
        Dim pathrom As String = listboxMaSelection.Items(listboxMaSelection.SelectedIndex)

        For a = 0 To FinalGrid.RowCount - 1 'Toutes les lignes
            If FinalGrid.Rows(a).Cells(FinalGrid.Columns("CheminRom").Index).Value = pathrom Then ' colonne des path
                listboxMaSelection.Items.Remove(pathrom)
                FinalGrid.Rows(a).Cells(FinalGrid.Columns("Selection").Index).Value = False
                Exit Sub
            End If
        Next
        'Check des Doublons
        Supdoublon(listboxMaSelection)
    End Sub

    Private Sub Txt_txtsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_txtsearch.KeyDown
        If txt_txtsearch.Text = "forcingreset" Then Call ToucheEntree()
        If e.KeyCode = Keys.Enter Then Call ToucheEntree()
    End Sub

    Sub ToucheEntree()
        If txt_txtsearch.Text = "forcingreset" Then txt_txtsearch.Text = Nothing

        'Si pas de colonne selectionnée alors on fait rien
        If ComboFiltreColonnes.Text = Nothing Then Exit Sub

        'On teste si la colonne est affichee ou non
        Dim colonneselected As String = ComboFiltreColonnes.Text
        Dim etat As String
        If FinalGrid.Columns(colonneselected).Visible = False Then
            etat = "cachee"
            FinalGrid.Columns(colonneselected).Visible = True
        Else
            etat = "visible"
        End If

        'On parametre la recherche
        Dim commanderecherche As String = ComboFiltreColonnes.Text & " Like '%{0}%'"

        'Si c'etait caché, on la remet en caché
        If etat = "cachee" Then FinalGrid.Columns(colonneselected).Visible = False

        'commande pour filtrer
        TryCast(FinalGrid.DataSource, DataTable).DefaultView.RowFilter = String.Format(commanderecherche, txt_txtsearch.Text)

        'on relance le calcul des checkbox et de la taille des checkbox
        Call Completiondescheckbox()
        Call Calcultaillerom()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rowindex As Integer = FinalGrid.CurrentCell.RowIndex
        Dim columnindex As Integer = FinalGrid.Columns("Titre").Index

        Dim titre As String = FinalGrid.Rows(rowindex).Cells(columnindex).Value.ToString()
        Dim nbcartexte As Integer = titre.Length
        If nbcartexte = Nothing Then Exit Sub

        If sec <= nbcartexte Then

            txt_romname.Text = titre.Substring(0, sec)
            sec += 1
        Else
            txt_romname.Text = titre
        End If
    End Sub
    Private Sub ButtonRAZ_Click(sender As Object, e As EventArgs) Handles buttonRAZ.Click
        txt_txtsearch.Text = "forcingreset"
    End Sub
    Private Sub Romscreeno_Click(sender As Object, e As EventArgs) Handles romscreeno.Click
        'si y'a rien de loadé
        If txt_romname.Text = Nothing Then Exit Sub

        'Si pas d'image sur le jeu en cours
        If IsDBNull(FinalGrid.SelectedCells(FinalGrid.Columns("CheminImage").Index)) Then
        Else
            System.Diagnostics.Process.Start(FinalGrid.SelectedCells(FinalGrid.Columns("CheminImage").Index).Value.ToString)
        End If
    End Sub
    Private Sub Romvideoo_Click(sender As Object, e As EventArgs) Handles romvideoo.Click
        'si y'a rien de loadé
        If txt_romname.Text = Nothing Then Exit Sub

        'Si pas d'image sur le jeu en cours
        If IsDBNull(FinalGrid.SelectedCells(FinalGrid.Columns("CheminVideo").Index)) Then
        Else
            System.Diagnostics.Process.Start(FinalGrid.SelectedCells(FinalGrid.Columns("CheminVideo").Index).Value.ToString)
        End If
    End Sub
    Private Sub Rommanualo_Click(sender As Object, e As EventArgs) Handles rommanualo.Click
        'si y'a rien de loadé
        If txt_romname.Text = Nothing Then Exit Sub

        'Si pas d'image sur le jeu en cours
        If FinalGrid.SelectedCells(FinalGrid.Columns("CocheManuel").Index).Value = False Then
        Else
            System.Diagnostics.Process.Start(FinalGrid.SelectedCells(FinalGrid.Columns("CheminManuel").Index).Value.ToString)
        End If
    End Sub
    Private Sub Romoverlayo_Click(sender As Object, e As EventArgs) Handles romoverlayo.Click
        'si y'a rien de loadé
        If txt_romname.Text = Nothing Then Exit Sub

        'Si pas d'image sur le jeu en cours
        If FinalGrid.SelectedCells(FinalGrid.Columns("CocheOverlay").Index).Value = False Then
        Else
            Dim cheminrom As String = FinalGrid.SelectedCells(FinalGrid.Columns("CheminRom").Index).Value.ToString
            Dim FileInfo As New FileInfo(cheminrom)
            Dim nomdelarom As String = FileInfo.Name
            Dim nomducfg As String = nomdelarom & ".cfg"

            Dim cheminoverlay As String = Replace(cheminrom, "\roms\", "\overlays\")
            Dim testcheminoverlay As String = Replace(cheminoverlay, nomdelarom, nomducfg)

            Process.Start("explorer", Path.GetDirectoryName(testcheminoverlay).ToString)
        End If
    End Sub
    Private Sub Romsaveo_Click(sender As Object, e As EventArgs) Handles romsaveo.Click
        'si y'a rien de loadé
        If txt_romname.Text = Nothing Then Exit Sub

        'Si pas d'image sur le jeu en cours
        If FinalGrid.SelectedCells(FinalGrid.Columns("CocheSave").Index).Value = False Then
        Else
            Dim chemin As String = txt_rompath.Text.ToString
            Dim cheminsave As String = Path.GetDirectoryName(Replace(chemin, "\roms\", "\saves\"))
            Process.Start("explorer", cheminsave)
        End If
    End Sub
    Private Sub RomImage_Click(sender As Object, e As EventArgs) Handles RomImage.DoubleClick
        System.Diagnostics.Process.Start(FinalGrid.SelectedCells(FinalGrid.Columns("CheminImage").Index).Value.ToString)
    End Sub
    Private Sub Txt_CopyFolder_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CopyFolder.KeyDown
        'Ajout d'un \ de securite si besoin
        If e.KeyCode = Keys.Enter Then
            If txt_CopyFolder.Text.Substring(Len(txt_CopyFolder.Text) - 1, 1) <> "\" Then
                txt_CopyFolder.Text = txt_CopyFolder.Text + "\"
            End If
        End If
    End Sub

    Private Sub CocherTout_CheckedChanged(sender As Object, e As EventArgs) Handles CocherTout.CheckedChanged
        For i = 0 To FinalGrid.Rows.Count - 2
            If FinalGrid.Rows(i).Visible = True Then
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("Selection").Index).Value = True
            End If
        Next
        CocherTout.Checked = True
    End Sub

    Private Sub DécocherTout_CheckedChanged(sender As Object, e As EventArgs) Handles DecocherTout.CheckedChanged
        For i = 0 To FinalGrid.Rows.Count - 2
            If FinalGrid.Rows(i).Visible = True Then
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("Selection").Index).Value = False
            End If
        Next
        DecocherTout.Checked = False
    End Sub

    Private Sub ButtonShowColonne_Click(sender As Object, e As EventArgs) Handles ButtonShowColonne.Click
        If ComboFiltreColonnes.Text Is Nothing Then Exit Sub
        If ComboFiltreColonnes.Text = "Console" Or ComboFiltreColonnes.Text = "Titre" Then Exit Sub
        FinalGrid.Columns(ComboFiltreColonnes.Text).Visible = True
    End Sub

    Private Sub ButtonHideColonne_Click(sender As Object, e As EventArgs) Handles ButtonHideColonne.Click
        If ComboFiltreColonnes.Text Is Nothing Then Exit Sub
        If ComboFiltreColonnes.Text = "Console" Or ComboFiltreColonnes.Text = "Titre" Then Exit Sub
        FinalGrid.Columns(ComboFiltreColonnes.Text).Visible = False
    End Sub

    Private Sub Txt_romdesc_TextChanged(sender As Object, e As EventArgs) Handles txt_romdesc.TextChanged
        'En travail, mettre en gras !
        If ComboFiltreColonnes.Text = "Synopsis" And txt_txtsearch.Text IsNot Nothing Then
        End If
    End Sub

    Private Sub Txt_txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txt_txtsearch.TextChanged
        If txt_txtsearch.Text = "forcingreset" Then Call ToucheEntree()
    End Sub

    Private Sub FinalGrid_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles FinalGrid.RowEnter
        Call UpdatelesChiffreRoms()
    End Sub

    Private Sub Txt_GoAPrevoir_TextChanged(sender As Object, e As EventArgs) Handles txt_GoAPrevoir.TextChanged
        Dim calcul As Decimal = (Val(txt_USBGo.Text) * 1024) - Val(txt_GoAPrevoir.Text)

        If calcul >= 1024 Then 'Si c'est au dessus de 1024 Mo, ca va 
            txt_morestant.BackColor = Color.FromArgb(185, 209, 234)
            txt_morestant.ForeColor = Color.FromArgb(0, 0, 0)
            txt_morestant.Text = (Val(txt_USBGo.Text) * 1024) - Val(txt_GoAPrevoir.Text)
        ElseIf calcul > 0 And calcul < 1000 Then 'Si c'est au [0;1024] attention
            txt_morestant.BackColor = Color.FromArgb(255, 204, 153)
            txt_morestant.ForeColor = Color.FromArgb(0, 0, 0)
            txt_morestant.Text = (Val(txt_USBGo.Text) * 1024) - Val(txt_GoAPrevoir.Text)
        Else ' Dire que c'est plein quand il reste moins de 1024 Mo ! (Securité)
            txt_morestant.BackColor = Color.FromArgb(255, 0, 0)
            txt_morestant.ForeColor = Color.FromArgb(255, 255, 255)
            txt_morestant.Text = "USB PLEIN"
        End If
    End Sub
    Private Sub Txt_USBGo_TextChanged(sender As Object, e As EventArgs) Handles txt_USBGo.TextChanged
        txt_morestant.Text = (Val(txt_USBGo.Text) * 1024) - Val(txt_GoAPrevoir.Text)
    End Sub

    Private Sub Txt_USBGo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_USBGo.KeyDown
        If e.KeyCode = Keys.Enter Then
            'On va remplacer la valeur par defaut du Stockage et on la sauvegarde pour les prochaines fois
            My.Settings.StockageSize = txt_USBGo.Text
            My.Settings.Save()
        End If
    End Sub
    Private Sub Txt_txtsearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_txtsearch.MouseClick
        'Si la colonne c'est le filtre des Dates, afficher le popup
        If ComboFiltreColonnes.Text = "DateSortie" Then
            MsgBox("Vous allez filtrer sur une date" & Chr(13) & "Le Format des dates est 'AAAAMMJJ'" & Chr(13) & Chr(13) & "Je vous recommande de toujours saisir une année")
        End If
    End Sub

    Private Sub FinalGrid_MouseHover(sender As Object, e As EventArgs) Handles FinalGrid.MouseHover
        For Each dgvr As DataGridViewRow In FinalGrid.Rows
            If dgvr.Cells("CocheImage").Value = True Then
                dgvr.Cells("CocheImage").ToolTipText = "Image OK pour cette Rom"
            Else
                dgvr.Cells("CocheImage").ToolTipText = "Pas d'Image pour cette Rom"
            End If

            If dgvr.Cells("CocheVideo").Value = True Then
                dgvr.Cells("CocheVideo").ToolTipText = "Video OK pour cette Rom"
            Else
                dgvr.Cells("CocheVideo").ToolTipText = "Pas de Video pour cette Rom"
            End If

            If dgvr.Cells("CocheManuel").Value = True Then
                dgvr.Cells("CocheManuel").ToolTipText = "Manuel OK pour cette Rom"
            Else
                dgvr.Cells("CocheManuel").ToolTipText = "Pas de Manuel pour cette Rom"
            End If

            If dgvr.Cells("CocheOverlay").Value = True Then
                dgvr.Cells("CocheOverlay").ToolTipText = "Overlay OK pour cette Rom"
            Else
                dgvr.Cells("CocheOverlay").ToolTipText = "Pas d'Overlay pour cette Rom"
            End If

            If dgvr.Cells("CocheSave").Value = True Then
                dgvr.Cells("CocheSave").ToolTipText = "Saves OK pour cette Rom"
            Else
                dgvr.Cells("CocheSave").ToolTipText = "Pas de Saves pour cette Rom"
            End If
        Next
    End Sub

    Private Sub ButtonTuto_Click(sender As Object, e As EventArgs) Handles ButtonTuto.Click
        'Deroulement du Tuto
        'Replace les overlay des tutos
        TutoHideGameList.Size = New Point(213, 365)
        TutoHideGameList.Location = New Point(8, 28)

        TutoHideFinalGrid.Size = New Point(391, 364)
        TutoHideFinalGrid.Location = New Point(217, 28)

        TutoHideRomInfo.Size = New Point(395, 475)
        TutoHideRomInfo.Location = New Point(612, 28)

        TutoHideFiltres.Size = New Point(624, 105)
        TutoHideFiltres.Location = New Point(8, 398)

        TutoHideOutilsP1.Size = New Point(129, 90)
        TutoHideOutilsP1.Location = New Point(8, 509)

        TutoHideOutilsP2.Size = New Point(194, 91)
        TutoHideOutilsP2.Location = New Point(129, 509)

        TutoHideOutilsP3.Size = New Point(203, 91)
        TutoHideOutilsP3.Location = New Point(323, 509)

        TutoHideOutilsP4.Size = New Point(179, 91)
        TutoHideOutilsP4.Location = New Point(525, 509)

        TutoHideOutilsP5.Size = New Point(223, 91)
        TutoHideOutilsP5.Location = New Point(707, 509)

        TutoHideOutilsP6.Size = New Point(77, 91)
        TutoHideOutilsP6.Location = New Point(930, 509)

        'On reaffiche tout
        TutoHideGameList.Show()
        TutoHideFinalGrid.Show()
        TutoHideRomInfo.Show()
        TutoHideFiltres.Show()
        TutoHideOutilsP1.Show()
        TutoHideOutilsP2.Show()
        TutoHideOutilsP3.Show()
        TutoHideOutilsP4.Show()
        TutoHideOutilsP5.Show()
        TutoHideOutilsP6.Show()

        MsgBox("Bienvenue dans ce Petit Tuto pour Apprendre à Utiliser RecopierBox")

        TutoHideGameList.Hide()
        ListGameLists.Show()
        MsgBox("Ci-Contre, vos Gamelists" & Chr(13) & "Vous avez selectionné à la Souris ou en laissant enfoncé le clic" & Chr(13) & "Ou avec CTRL Enfoncé + Clic" & Chr(13) & "les systèmes qui vous interesse")

        ListGameLists.Hide()
        TutoHideFinalGrid.Hide()
        MsgBox("Une fois les Gamelists chargés, retrouvez l'intégralité de vos roms dans ce tableau")
        MsgBox("Chaque ligne du tableau représente une Rom" & Chr(13) & "Les coches à sa droite representent les métadonnées")
        MsgBox("Si la cellule est Verte : Info présente dans le Gamelist" & Chr(13) & "Si la cellule est Rouge : Info non présente" & Chr(13) & "Si la cellule est Noire : Non applicable à cette Console")
        MsgBox("La dernière colonne est la SEULE colonne qui vous interesse" & Chr(13) & Chr(13) & "Elle permet de selectionner la Rom pour Copie")

        TutoHideRomInfo.Hide()
        MsgBox("Lors d'un clic sur une Rom du tableau précédent" & Chr(13) & "Les informations ici sont affichées")
        MsgBox("Remarquez les 5 boutons ci dessous" & Chr(13) & Chr(13) & "Qui vous permettront d'ouvrir chacun des médias représentés en coche dans le tableau")

        TutoHideFiltres.Hide()
        MsgBox("Lire votre bibliothèque c'est bien" & Chr(13) & "Pouvoir réaliser votre selection, c'est mieux !" & Chr(13) & Chr(13) & "Ces filtres permettent de filtrer la vue de votre tableau grâce aux colonnes et à votre saisie")
        MsgBox("N'oubliez pas de Selectionner les Roms que vous souhaitez copier !")

        TutoHideOutilsP3.Hide()
        MsgBox("Après Selection, surveillez les indicateurs qui vous permettent d'avoir un oeil sur l'espace necessaire à la copie")

        TutoHideOutilsP4.Hide()
        MsgBox("Pendant ou à la fin de vos choix: " & Chr(13) & "Vous pouvez afficher cette selection à tout moment grâce à ce bouton")

        TutoHideOutilsP1.Hide()
        MsgBox("N'oubliez pas de Saisir ici l'espace de stockage de votre média cible pour la réalisation de votre collection")

        TutoHideOutilsP2.Hide()
        MsgBox("Selectionner les elements que vous souhaitez retrouver dans votre copie personnalisée")

        TutoHideOutilsP5.Hide()
        MsgBox("Definissez ici votre repertoire de Sortie")
        MsgBox("Je vous conseille de mettre ici un repertoire vide 'REMADE'" & Chr(13) & "de préference sur le support de stockage contenant" & Chr(13) & "les médias pour optimiser le temps de copie")

        TutoHideOutilsP6.Hide()
        MsgBox("Quand votre selection est complète, et que votre copie finale est parametrée" & "C'est ici qu'on lance le tout !")

        MsgBox("En esperant que ces popups vous aient été utile")
        MsgBox("Bonne Construction =)" & Chr(13) & Chr(13) & Chr(13) & "Soaresden")

        'Et tout le Block Tuto
        TutoHideGameList.Hide()
        TutoHideFinalGrid.Hide()
        TutoHideRomInfo.Hide()
        TutoHideFiltres.Hide()
        TutoHideOutilsP1.Hide()
        TutoHideOutilsP2.Hide()
        TutoHideOutilsP3.Hide()
        TutoHideOutilsP4.Hide()
        TutoHideOutilsP5.Hide()
        TutoHideOutilsP6.Hide()

    End Sub
End Class
