Imports System.ComponentModel
Imports System.IO
Imports System.Xml

Public Class CopyRoms
    Private Sub CopyRoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hiding buttons and datagrids
        txt_txtsearch.Hide()
        FinalGrid.Hide()
        ButtonGenererList.Hide()
        GroupBox1.Hide()
        grp_RomInfos.Hide()
        vid_romvid.uiMode = "none"
        listboxMaSelection.Hide()
        ButtonRazClickk.Hide()
        GroupFiltresAvances.Hide()
        GroupBoxSelectionRoms.Hide()
        ButtonTuto1.Hide()
        GroupCollections.Hide()
        GroupCollectEditor.Hide()
        CellEnGrand.Hide()

        'si c'est batocera, on affiche le bouton collection
        If InStr(My.Settings.DossierOverlay, "overlay") = 0 Then
            ButtonCollection.Show()
            ButtonCollection.Location = New Point(93, 417)
            LabelCollection.Show()
            LabelCollection.Location = New Point(90, 470)
        Else
            LabelCollection.Hide()
            ButtonCollection.Hide()
        End If

        'test sur la valeur modesimple
        If My.Settings.SimpleMode = "simple" Or My.Settings.SimpleMode = Nothing Then
            ChkSimple.Checked = True
        Else
            ChkAvance.Checked = True
        End If

        'coute que coute on hide de toute facon 
        GroupFiltresAvances.Hide()

        'On liste les dossiers
        For Each foundDirectory In Directory.GetDirectories(My.Settings.RecalboxFolder & "\roms", ".", SearchOption.TopDirectoryOnly)
            Dim dossierconsole As String = System.IO.Path.GetFileName(foundDirectory)
            ListGameLists.Items.Add(dossierconsole)
        Next

        'showing gridview2
        ButtonGenererList.Show()
        CheckBoxARRM.Hide()

        'Et tout le Block Tuto
        TutoHideGameList.Hide()
        TutoHideFinalGrid.Hide()
        TutoHideRomInfo.Hide()
        TutoHideUSB.Hide()
        TutoHideSelectionIndic.Hide()
        TutoHideQuoiCopier.Hide()
        TutoHideOuCopier.Hide()
        TutoHideBoutonCopy.Hide()
    End Sub
    Public Shared Function GetFilesRecursive(ByVal initial As String) As List(Of String)
        ' This list stores the results.
        Dim result As New List(Of String)

        ' This stack stores the directories to
        ' .
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
    Private Sub ButtonGenererList_Click_1(sender As Object, e As EventArgs) Handles ButtonGenererList.Click

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

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "CocheImage"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "CocheVideo"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "CocheManuel"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "CocheOverlay"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "CocheSaves"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Double")
            .ColumnName = "Mo"
        End With
        table.Columns.Add(column)


        'Loop for every gamelists
        For Each i In ListGameLists.SelectedItems
            Dim nomconsole As String = i

            If CheckBoxARRM.Checked = True Then
                'on va verifier si ARRM ou non dans gamelist
                If System.IO.File.Exists(My.Settings.RecalboxFolder & "\roms\" & i & "\" & "gamelist_ARRM.xml") Then
                    gamelist = My.Settings.RecalboxFolder & "\roms\" & i & "\gamelist_ARRM.xml"
                Else
                    gamelist = My.Settings.RecalboxFolder & "\roms\" & i & "\gamelist.xml"
                End If
            Else
                gamelist = My.Settings.RecalboxFolder & "\roms\" & i & "\gamelist.xml"
            End If

            'On ajoute ensuite les consoles dans la listebox des console
            Dim consolederom As String = i
            consolederom = i

            listconsoleselected.Items.Add(consolederom)

            Dim gamelistXml As XElement
            Try
                gamelistXml = XElement.Load(gamelist)
            Catch ex As Exception
                GoTo consolesuivante
            End Try

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

                Dim rommo As Double = GetSizeSelectedRom(rompath, romconsole)
                Dim valeurcoche = Completioncheckboxligne(rompath, romconsole, romimage, romvideo, romanual)

                Dim cocheimage = valeurcoche.item1
                Dim cochevideo = valeurcoche.item2
                Dim cochemanual = valeurcoche.item3
                Dim cocheoverlay = valeurcoche.item4
                Dim cochesaves = valeurcoche.item5

                'on ajoute le tout dans une table
                table.Rows.Add(romconsole, romname, romId, rompath, romdesc, romimage, romvideo, romanual, romgenre, romnote, romdev, rompubl, romnbplayers, romdate, romCompteur, romRegion, cocheimage, cochevideo, cochemanual, cocheoverlay, cochesaves, rommo)
romsuivante:
            Next
consolesuivante:
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        FinalGrid.DataSource = table

        'Width for columns
        FinalGrid.Columns("Console").Width = 50
        FinalGrid.Columns("Titre").Width = 320

        FinalGrid.Columns("CocheImage").Width = 20
        FinalGrid.Columns("CocheVideo").Width = 20
        FinalGrid.Columns("CocheManuel").Width = 20
        FinalGrid.Columns("CocheOverlay").Width = 20
        FinalGrid.Columns("CocheSaves").Width = 20

        FinalGrid.Columns("Mo").Width = 60
        'Hiding les colonnes
        FinalGrid.Columns("GameId").Visible = False
        FinalGrid.Columns("CheminRom").Visible = False
        FinalGrid.Columns("Synopsis").Visible = False
        FinalGrid.Columns("CheminImage").Visible = False
        FinalGrid.Columns("CheminVideo").Visible = False
        FinalGrid.Columns("CheminManuel").Visible = False
        'Width for columns
        FinalGrid.Columns("Genre").Visible = False
        FinalGrid.Columns("Note").Visible = False
        FinalGrid.Columns("Developer").Visible = False
        FinalGrid.Columns("Publisher").Visible = False
        FinalGrid.Columns("NbPlayers").Visible = False
        FinalGrid.Columns("DateSortie").Visible = False
        FinalGrid.Columns("NbLancé").Visible = False
        FinalGrid.Columns("Region").Visible = False

        'add checkable columns at the end
        Dim colromselection As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromselection)
        colromselection.HeaderText = "Selection"
        colromselection.Name = "Selection"
        colromselection.Width = 45

        'Reajusting Interface and Showing Final Interface
        ListGameLists.Hide()
        GroupBoxSelectionRoms.Show()

        FinalGrid.Location = New Point(8, 28)
        FinalGrid.Size = New Size(600, 365)
        grp_RomInfos.Show()
        GroupBox1.Show()
        ButtonGenererList.Hide()
        txt_txtsearch.Show()
        ButtonRazClickk.Show()
        dv.Sort = "Console asc, Titre asc"

        'si c'est mode simple ou avancé
        If ChkAvance.Checked = True Then
            GroupFiltresAvances.Show()
        Else
            GroupFiltresAvances.Hide()
        End If

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
        ComboFiltreColonnes.Items.Add("Note")
        ComboFiltreColonnes.Items.Add("Developer")
        ComboFiltreColonnes.Items.Add("Publisher")
        ComboFiltreColonnes.Items.Add("NbPlayers")
        ComboFiltreColonnes.Items.Add("DateSortie")
        ComboFiltreColonnes.Items.Add("Nblancé")
        ComboFiltreColonnes.Items.Add("Region")

        'On compte le nombre total d'entrées
        txt_nbrom.Text = FinalGrid.Rows.Count - 1
        txtShownRoms.Text = txt_nbrom.Text

        'On lance la coloration des checkbox
        Call Colorerlescoches()

        'On appelle le stockage size
        txt_USBGo.Text = My.Settings.StockageSize

        'On affiche le bouton Tuto !
        ButtonTuto1.Show()

        'si c'est batocera, on redeplace la collection
        If InStr(My.Settings.DossierOverlay, "overlay") = 0 Then
            ButtonCollection.Location = New Point(549, 417)
            LabelCollection.Location = New Point(546, 470)
        End If
    End Sub
    Function GetSizeSelectedRom(cheminrom As String, console As String)
        'On check si le jeu existe
        If (Not System.IO.File.Exists(cheminrom)) Then
            Return (0)
        End If

        Dim sizefichier As Double
        Dim attr As FileAttributes = File.GetAttributes(cheminrom)

        If ((attr And FileAttribute.Directory) = FileAttribute.Directory) Then
            'si c'est un repertoire (daphne, dos ...etc) 

            Dim folder As New IO.DirectoryInfo(cheminrom & "\")
            For Each file As IO.FileInfo In folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
                sizefichier += file.Length
            Next file
            GoTo labelapresfolder
        Else
            'si c'est un fichier...
            Dim extensionrom As String = Path.GetExtension(cheminrom)

            'si c'est un m3u, il faut lire le fichier pour recuperer la vraie taille des cd's dedans
            If extensionrom = ".m3u" Then
                File.ReadAllLines(cheminrom)

                ' Open the m3u file to read from.
                Dim readText() As String = File.ReadAllLines(cheminrom)
                Dim s As String
                sizefichier = 0
                For Each s In readText
                    cheminrom = My.Settings.RecalboxFolder & "\roms\" & console & "\" & Replace(s, "/", "\")
                    Dim info As New FileInfo(cheminrom)
                    sizefichier += info.Length
                Next
            ElseIf extensionrom = ".cue" Then 'si c'est un cue, il faut lire le fichier pour recuperer la vraie taille des cd's dedans
                File.ReadAllLines(cheminrom)

                ' Open the cue file to read from.
                Dim readText() As String = File.ReadAllLines(cheminrom)
                Dim s As String
                sizefichier = 0
                For Each s In readText
                    Dim detectfile = InStr(s, Chr(34))
                    If detectfile >= 1 Then
                        'Dim isolerome As String = s.Substring(detectfile)
                        'Dim isolebinary As String = InStr(isolerome, Chr(34))
                        'Dim isolerom As String = isolerome.Substring(0, isolebinary - 1)

                        Dim iso As String = s.Substring(detectfile).Substring(0, InStr(s.Substring(detectfile), Chr(34)) - 1)
                        cheminrom = My.Settings.RecalboxFolder & "\roms\" & console & "\" & Replace(iso, "/", "\")
                        Dim info As New FileInfo(cheminrom)
                        sizefichier += info.Length
                    End If
                Next

            Else

                'sinon c'est un fichier normal 
                Dim info As New FileInfo(cheminrom)
                sizefichier = info.Length
            End If
        End If
labelapresfolder:
        'Conversion en Mo
        Dim tailleenmo As Double = sizefichier / 1048576
        Return Math.Round(tailleenmo, 2)
        sizefichier = 0
    End Function
    Function Completioncheckboxligne(cheminrom As String, console As String, cheminimage As String, cheminvideo As String, cheminmanuel As String)

        'test sur le chemin des screens, si la cellule est complétée alors on coche
        Dim cocheimage As Boolean
        If cheminimage = Nothing Then
            cocheimage = False
        Else
            cocheimage = True
        End If

        'test sur le chemin des videos
        Dim cochevideo As Boolean
        If cheminvideo = Nothing Then
            cochevideo = False
        Else
            cochevideo = True
        End If

        'test sur le chemin des manuels
        Dim cochemanuel As Boolean
        If cheminmanuel = Nothing Then
            cochemanuel = False
        Else
            cochemanuel = True
        End If

        'test sur le chemin des overlays
        Dim FileInfo As New FileInfo(cheminrom)
        Dim nomdelarom As String = FileInfo.Name
        Dim nomducfg As String = nomdelarom & ".cfg"
        Dim cheminoverlay As String

        If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
            cheminoverlay = Replace(cheminrom, "\roms\", "\overlays\")
        Else
            cheminoverlay = Replace(cheminrom, "\roms\", "\decorations\")
        End If

        Dim testcheminoverlay As String = Replace(cheminoverlay, nomdelarom, nomducfg)

        Dim cocheoverlay As Boolean
        If System.IO.File.Exists(testcheminoverlay) Then
            cocheoverlay = True
        Else
            cocheoverlay = False
        End If

        'test sur le chemin des saves
        Dim cheminsaves As String = Replace(cheminrom, "\roms\", "\saves\")
        Dim detectdossierentredeux As String = InStr(cheminrom, console)
        Dim enleveledossierentrop As String = cheminrom.Substring(detectdossierentredeux + Len(console))
        Dim romsansextension = FileNameWithoutExtension(nomdelarom)
        Dim dossierentrop = Replace(enleveledossierentrop, Path.GetFileName(cheminrom), "")

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
        Dim cochesaves As Boolean
        If consolesanssaves.Contains(console) Then
            cochesaves = False
            GoTo consolesanssaves
        End If

        'on verifie si il y'a des sauvegardes avec le nom du jeu en racine

        Dim chemindelasavee As String = Replace(cheminsaves, nomdelarom, "")
        'On check si le dossier de la save existe, au cas ou on le cree
        If (Not System.IO.Directory.Exists(chemindelasavee)) Then
            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(chemindelasavee))
        End If
        Dim endeuxfois As String = Replace(chemindelasavee, dossierentrop, "") & FileNameWithoutExtension(cheminrom)
        Dim savesCount As Integer = IO.Directory.GetFiles(Path.GetDirectoryName(endeuxfois), FileNameWithoutExtension(cheminrom) & ".*").Count





        If savesCount >= 1 Then
            cochesaves = True
        Else
            cochesaves = False
        End If
consolesanssaves:
        Return (cocheimage, cochevideo, cochemanuel, cocheoverlay, cochesaves)
    End Function
    Sub Colorerlescoches()
        For i = 0 To FinalGrid.RowCount - 1
            If FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheImage").Index).Value = True Then
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheImage").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheImage").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If

            If FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheVideo").Index).Value = True Then
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheVideo").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheVideo").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If

            If FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheManuel").Index).Value = True Then
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheManuel").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheManuel").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If

            If FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheOverlay").Index).Value = True Then
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If

            If FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheSaves").Index).Value = True Then
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheSaves").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                FinalGrid.Rows(i).Cells(FinalGrid.Columns("CocheSaves").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If

        Next

        'On met en ReadOnly les cases coches
        FinalGrid.Columns("CocheImage").ReadOnly = True
        FinalGrid.Columns("CocheVideo").ReadOnly = True
        FinalGrid.Columns("CocheManuel").ReadOnly = True
        FinalGrid.Columns("CocheOverlay").ReadOnly = True
        FinalGrid.Columns("CocheSaves").ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub FinalGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FinalGrid.CellMouseClick
        Dim totalline As Integer = FinalGrid.RowCount - 1

        If e.RowIndex = totalline Or e.RowIndex < 0 Then Exit Sub

        Call loadlesinfos(FinalGrid.CurrentCell.RowIndex)

    End Sub
    Sub loadlesinfos(rowindex As Integer)
        'Chargement des informations dans Rom Informations
        Dim row As DataGridViewRow = FinalGrid.Rows(rowindex)

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
            ButtonSonVid.Hide()
        Else
            vid_romvid.Show()
            vid_romvid.URL = row.Cells(FinalGrid.Columns("CheminVideo").Index).Value
            vid_romvid.settings.setMode("loop", True)
            vid_romvid.settings.volume = 80
            vid_romvid.settings.mute = True
            ButtonSonVid.Show()
            ButtonSonVid.BackgroundImage = My.Resources.iconsound
            vid_romvid.Ctlcontrols.play()
        End If

        'Conditionnelle sur les Boutons
        On Error Resume Next
        Dim checkboximg As String = row.Cells(FinalGrid.Columns("CocheImage").Index).Value
        Dim checkboxvideo As String = row.Cells(FinalGrid.Columns("CocheVideo").Index).Value
        Dim checkboxmanual As String = row.Cells(FinalGrid.Columns("CocheManuel").Index).Value
        Dim checkboxoverlay As String = row.Cells(FinalGrid.Columns("CocheOverlay").Index).Value
        Dim checkboxsave As String = row.Cells(FinalGrid.Columns("CocheSaves").Index).Value

        Dim imgscreen As New Bitmap(My.Resources.okscreen)
        Dim imgscreenno As New Bitmap(My.Resources.noscreen)
        Dim imgscreen2 As New Bitmap(imgscreen, romscreeno.Width, romscreeno.Height)
        Dim imgscreen2no As New Bitmap(imgscreenno, romscreeno.Width, romscreeno.Height)

        Dim imgvideo As New Bitmap(My.Resources.okvideo)
        Dim imgvideono As New Bitmap(My.Resources.novideo)
        Dim imgvideo2 As New Bitmap(imgvideo, romvideoo.Width, romvideoo.Height)
        Dim imgvideo2no As New Bitmap(imgvideono, romvideoo.Width, romvideoo.Height)

        Dim imgmanual As New Bitmap(My.Resources.okmanual)
        Dim imgmanualno As New Bitmap(My.Resources.nomanual)
        Dim imgmanual2 As New Bitmap(imgmanual, romvideoo.Width, romvideoo.Height)
        Dim imgmanual2no As New Bitmap(imgmanualno, romvideoo.Width, romvideoo.Height)

        Dim imgoverlay As New Bitmap(My.Resources.okoverlay)
        Dim imgoverlayno As New Bitmap(My.Resources.nooverlay)
        Dim imgoverlay2 As New Bitmap(imgoverlay, romoverlayo.Width, romoverlayo.Height)
        Dim imgoverlay2no As New Bitmap(imgoverlayno, romoverlayo.Width, romoverlayo.Height)

        Dim imgsaves As New Bitmap(My.Resources.okmem)
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
    Private Sub DataGridCellValueChanged(sender As DataGridView, e As DataGridViewCellEventArgs) Handles FinalGrid.CellValueChanged
        'check that row isn't -1, i.e. creating datagrid header
        If e.RowIndex = -1 Then Exit Sub

        'On recherche le numero de la colonne des Selections
        If e.ColumnIndex = FinalGrid.Columns("Selection").Index Then
            'Si on est ici c'est qu'on vient de cocher la case Selection
            Dim columnindex As Integer = FinalGrid.CurrentCell.ColumnIndex
            Dim rowIndex As Integer = FinalGrid.CurrentCell.RowIndex
            Dim pathrom As String = FinalGrid.Rows(rowIndex).Cells(FinalGrid.Columns("CheminRom").Index).Value

            'Verification de l'etat de la coche, si la Case dans selection est cochée, alors on ajoute dans la listbox MaSelection
            If FinalGrid.Rows(rowIndex).Cells(FinalGrid.Columns("Selection").Index).Value = True Then
                'Verif si c'est un doublon
                If listboxMaSelection.Items.Contains(FinalGrid.Rows(rowIndex).Cells(FinalGrid.Columns("CheminRom").Index).Value) Then
                    'si elle y est deja on ne fait rien
                Else
                    'sinon on l'ajoute
                    listboxMaSelection.Items.Add(pathrom)
                    FinalGrid.Rows(rowIndex).Cells(FinalGrid.Columns("Selection").Index).Value = False
                End If
            End If
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
        If listboxMaSelection.Items.Count = 0 Then
            txt_NbRomSelected.Text = 0
            txt_GoAPrevoir.Text = 0
            Exit Sub
        End If

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

        'on refresh l'espace restant


    End Sub

    Private Sub GroupBox1_VisibleChanged(sender As Object, e As EventArgs) Handles GroupBox1.VisibleChanged
        txt_CopyFolder.Text = My.Settings.CopyFolder
        txt_USBGo.Text = My.Settings.StockageSize
    End Sub

    Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopy.Click
        'verif du chemin
        If txt_CopyFolder.Text = Nothing Then
            MsgBox("Pas de Repertoire de Copie Défini" & Chr(10) & "ABANDON")
            Exit Sub
        End If

        'verif de la liste a copier
        If listboxMaSelection.Items.Count = 0 Then
            MsgBox("Pas de Roms à Copier" & Chr(10) & "ABANDON")
            Exit Sub
        End If

        'verif de l'espace disque
        If txt_GoAPrevoir.Text < 0 Then
            MsgBox("Trop d'espace est necessaire à la Copie" & Chr(10) & "ABANDON")
            Exit Sub
        End If

        'Verification que le chemin est vide
        Dim folder As New IO.DirectoryInfo(txt_CopyFolder.Text & "\")
        Dim sizedudossier = Nothing
        For Each file As IO.FileInfo In folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
            sizedudossier += file.Length
        Next file

        'Batocera ou Recalbox? 
        Dim typedistri As String
        If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
            typedistri = "\recalbox"
        Else
            typedistri = "\batocera"
        End If

        If sizedudossier >= 0 Then
            If MsgBox("Le Chemin de Copie : " & Chr(10) & txt_CopyFolder.Text & Chr(10) & "n'est pas vide" & Chr(10) & Chr(10) & "L'Assistant va creer un dossier : " & Chr(10) & txt_CopyFolder.Text & typedistri & Chr(10) & "Continuer ?", vbYesNo) = vbNo Then Exit Sub
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

        Dim optionsbox As String = temptxt1 & Chr(10) & temptxt2 & Chr(10) & temptxt3 & Chr(10) & temptxt4 & Chr(10) & temptxt5 & Chr(10) & temptxt6

        'Reposition listboxmaselection
        listboxMaSelection.Location = New Point(-2, 43)
        listboxMaSelection.Size = New Size(396, 433)

        If MsgBox("Vérifiez Votre Liste de Roms Ci Dessus" & Chr(10) & optionsbox & Chr(10) & Chr(10) & "Chemin de Copie :  " & Chr(10) & txt_CopyFolder.Text & "\recalbox", vbYesNo) = vbNo Then
            listboxMaSelection.Hide()
            Exit Sub
        End If

        'On défiltre par securité
        ButtonRazClickk.PerformClick()

        'On va boucler sur toutes les roms de la liste. 
        'COPIE DES ROMS
        Dim newrecalbox As String = My.Settings.CopyFolder & typedistri
        Directory.CreateDirectory(newrecalbox)

        For i = 0 To listboxMaSelection.Items.Count - 1
            Dim pathjeu As String = listboxMaSelection.Items(i)
            Dim replacejeu As String = Replace(pathjeu, My.Settings.RecalboxFolder, newrecalbox)
            Dim repertoirefinal As String = Path.GetDirectoryName(replacejeu)
            Dim legamelist As String = Path.GetDirectoryName(pathjeu) & "\gamelist.xml"
            Dim extensionrom As String = Path.GetExtension(pathjeu)

            'Dim consola As String = InStr(pathjeu, "\roms\")
            'Dim consoleu As String = pathjeu.Substring(consola + 5)
            'Dim prochainslash As String = InStr(consoleu, "\")
            'Dim consoledelarom As String = consoleu.Substring(0, prochainslash - 1)
            Dim consolederom As String = pathjeu.Substring(InStr(pathjeu, "\roms\") + 5).Substring(0, InStr(pathjeu.Substring(InStr(pathjeu, "\roms\") + 5), "\") - 1)
            Dim lenouvogamelist As String = newrecalbox & "\roms\" & consolederom & "\gamelist.xml"
            Dim attr As FileAttributes = File.GetAttributes(pathjeu)

            'On test si c'est un jeu en dossier ou non
            If ((attr And FileAttribute.Directory) = FileAttribute.Directory) Then
                'si c'est un repertoire (daphne, dos ...etc) 
                CopyDirectory(pathjeu, replacejeu)
                GoTo alagamelist
            End If


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
alagamelist:
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

                        Dim writer As New XmlTextWriter(lenouvogamelist.ToString, System.Text.Encoding.UTF8)
                        writer.WriteStartDocument(True)
                        writer.Formatting = Xml.Formatting.Indented
                        writer.Indentation = 2
                        writer.WriteStartElement("gameList")

                        CreateNode(xmlname _
                                     , xmlpath _
                                     , xmldesc _
                                     , xmlrating _
                                     , xmldeveloper _
                                     , xmlpublisher _
                                     , xmlgenre _
                                     , xmlplayers _
                                     , xmlreleasedate _
                                     , xmlimage _
                                     , xmlvideo _
                                     , xmlmanual _
                                     , xmlregion _
                                     , xmlplaycount _
                                     , writer, xmlromId)

                        writer.WriteEndElement()
                        writer.WriteEndDocument()
                        writer.Close()

                    End If
                Next
            End If

            'on check si la copie des image a été activée
            If checkimgs.Checked = True Then

                For a = 0 To FinalGrid.RowCount - 1 'Auquel cas on va boucler sur toute les lignes jusqu'a trouver la rom
                    Dim jeuencours As String = FinalGrid.Rows(a).Cells(FinalGrid.Columns("CheminRom").Index).Value
                    If jeuencours = pathjeu Then ' on cherche la ligne du jeu

                        Dim estcequeimage As String
                        estcequeimage = FinalGrid.Rows(a).Cells(FinalGrid.Columns("CocheImage").Index).Value
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
                            Dim cheminoverlaycfg1 As String

                            If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                                cheminoverlaycfg1 = Replace(FinalGrid.Rows(d).Cells(FinalGrid.Columns("CheminRom").Index).Value, "\roms\", "\overlays\") & ".cfg"
                            Else
                                cheminoverlaycfg1 = Replace(FinalGrid.Rows(d).Cells(FinalGrid.Columns("CheminRom").Index).Value, "\roms\", "\decorations\") & ".cfg"
                            End If


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
                                Dim detectinputoverlay As String

                                If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                                    detectinputoverlay = InStr(s, "/overlays/")
                                Else
                                    detectinputoverlay = InStr(s, "/decorations/")
                                End If

                                If detectinputoverlay > 0 Then
                                    'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                                    'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                                    'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)
                                    Dim chemincfgoverlaydanscfg As String

                                    If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                                        chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                                    Else
                                        chemincfgoverlaydanscfg = s.Substring(InStr(s, "/decorations/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/decorations/") + 9), ".cfg") + 3)
                                    End If

                                    If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                                        cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\overlays\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                                    Else
                                        cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\decorations\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                                    End If

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
                        estcequesaves = FinalGrid.Rows(e1).Cells(FinalGrid.Columns("CocheSaves").Index).Value ' on check si le jeu a un overlay sinon on zappe le traitement
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
            If MsgBox("Overlays : Que souhaitez vous copier ?" & Chr(10) & Chr(10) & "Oui = Jeux + Tous les Overlays Générique de tous les Systemes" & Chr(10) & Chr(10) & "Non = Jeux + Overlays Systèmes en cours", vbYesNo) = vbYes Then

                For overlaysys = 0 To ListGameLists.Items.Count - 1


                    Dim fulladresse As String = My.Settings.RecalboxFolder & "\roms\" & ListGameLists.Items(overlaysys)
                    Dim overlayadresse As String

                    If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                        overlayadresse = Replace(fulladresse, "\roms\", "\overlays\")
                    Else
                        overlayadresse = Replace(fulladresse, "\roms\", "\decorations\")
                    End If

                    Dim parentName As String = IO.Path.GetFileName(overlayadresse)

                    Dim fichier1cfg As String = overlayadresse & "\" & parentName & ".cfg"
                    Dim fichier2overlaycfg As String
                    Dim fichier3png As String

                    'Test si ca existe 
                    If Not File.Exists(fichier1cfg) Then GoTo lignesuiva

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

                        Dim detectinputoverlay As String
                        If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                            detectinputoverlay = InStr(s, "/overlays/")
                        Else
                            detectinputoverlay = InStr(s, "/decorations/")
                        End If

                        If detectinputoverlay > 0 Then
                            'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                            'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                            'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)

                            Dim chemincfgoverlaydanscfg As String
                            If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                                chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                            Else
                                chemincfgoverlaydanscfg = s.Substring(InStr(s, "/decorations/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/decorations/") + 9), ".cfg") + 3)
                            End If

                            If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                                cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\overlays\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                            Else
                                cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\decorations\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                            End If

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
lignesuiva:
                Next

            ElseIf vbNo Then

                For ligne = 0 To listconsoleselected.Items.Count - 1


                    Dim consolename As String = listconsoleselected.Items(ligne)
                    Dim fulladresse As String = My.Settings.RecalboxFolder & "\roms\" & consolename

                    Dim overlayadresse As String
                    If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                        overlayadresse = Replace(fulladresse, "\roms\", "\overlays\")
                    Else
                        overlayadresse = Replace(fulladresse, "\roms\", "\decorations\")
                    End If

                    Dim parentName As String = IO.Path.GetFileName(overlayadresse)


                    Dim fichier1cfg As String = overlayadresse & "\" & parentName & ".cfg"
                    Dim fichier2overlaycfg As String
                    Dim fichier3png As String

                    'test si ca existe
                    If Not File.Exists(fichier1cfg) Then GoTo lignesuivb

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
                        Dim detectinputoverlay As String

                        If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                            detectinputoverlay = InStr(s, "/overlays/")
                        Else
                            detectinputoverlay = InStr(s, "/decorations/")
                        End If

                        If detectinputoverlay > 0 Then
                            'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                            'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                            'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)
                            Dim chemincfgoverlaydanscfg As String

                            If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                                chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                            Else
                                chemincfgoverlaydanscfg = s.Substring(InStr(s, "/decorations/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/decorations/") + 9), ".cfg") + 3)
                            End If

                            If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                                cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\overlays\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                            Else
                                cheminpropreoverlay2 = My.Settings.RecalboxFolder & "\overlays\" & Replace(chemincfgoverlaydanscfg, "/", "\")
                            End If

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
lignesuivb:
            End If
        End If

        'on check si les BIOS a la fin 
        If checkbios.Checked = True Then
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(My.Settings.RecalboxFolder & "\bios", newrecalbox & "\bios", True)
        End If

        'calcul taille total du dossier
        Dim sizefichier As Long
        Dim foldero As New IO.DirectoryInfo(My.Settings.CopyFolder)
        For Each file As IO.FileInfo In foldero.GetFiles("*.*", IO.SearchOption.AllDirectories)
            sizefichier += file.Length
        Next file

        Dim calcultailletotal As Decimal = Math.Round(sizefichier / 1048576, 2)

        MsgBox("Copie Terminée !" & Chr(10) & "Taille Totale : " & calcultailletotal & " Mo" & Chr(10) & "Veuillez Deplacer le dossier 'recalbox' sur votre media")
        Process.Start("explorer", My.Settings.CopyFolder)
    End Sub
    Private Sub CreateNode(ByVal xmlname As String _
        , ByVal xmlpath As String _
        , ByVal xmldesc As String _
                           , ByVal xmlrating As String _
                           , ByVal xmldeveloper As String _
                           , ByVal xmlpublisher As String _
                           , ByVal xmlgenre As String _
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
    Private Sub ListboxMaSelection_DoubleClick(sender As Object, e As EventArgs) Handles listboxMaSelection.DoubleClick
        'on enleve de la liste et on met a jour la checkbox dans la selection
        Dim pathrom As String = listboxMaSelection.Items(listboxMaSelection.SelectedIndex)

        For a = 0 To FinalGrid.RowCount - 1 'Toutes les lignes
            If FinalGrid.Rows(a).Cells(FinalGrid.Columns("CheminRom").Index).Value = pathrom Then ' colonne des path
                listboxMaSelection.Items.Remove(pathrom)
                FinalGrid.Rows(a).Cells(FinalGrid.Columns("Selection").Index).Value = False
                Exit For
            End If
        Next

        'Update les chiffres
        Call UpdatelesChiffreRoms()
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

        'on relance la coloration des checkboxes
        Call Colorerlescoches()

        'On compte le nombre de lignes affichées
        Dim visibleRowsCount = FinalGrid.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1
        txtShownRoms.Text = visibleRowsCount
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim rowindex As Integer = FinalGrid.CurrentCell.RowIndex
        Dim columnindex As Integer = FinalGrid.Columns("Titre").Index

        Dim titre As String = FinalGrid.Rows(rowindex).Cells(columnindex).Value.ToString()

        If txt_romname.Right < 0 Then
            txt_romname.Left = Panel1.ClientSize.Width
        Else
            txt_romname.Left -= 10
        End If

    End Sub
    Private Sub ButtonRAZ_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Romscreeno_Click(sender As Object, e As EventArgs) Handles romscreeno.Click
        'si y'a rien de loadé
        If txt_romname.Text = Nothing Then Exit Sub

        'Si pas d'image sur le jeu en cours
        If IsDBNull(FinalGrid.SelectedCells(FinalGrid.Columns("CheminImage").Index).Value) Then
        Else
            System.Diagnostics.Process.Start(FinalGrid.SelectedCells(FinalGrid.Columns("CheminImage").Index).Value.ToString)
        End If
    End Sub
    Private Sub Romvideoo_Click(sender As Object, e As EventArgs) Handles romvideoo.Click
        'si y'a rien de loadé
        If txt_romname.Text = Nothing Then Exit Sub

        'Si pas d'image sur le jeu en cours
        If IsDBNull(FinalGrid.SelectedCells(FinalGrid.Columns("CheminVideo").Index).Value) Then
            Exit Sub
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

            Dim cheminoverlay As String
            If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                cheminoverlay = Replace(cheminrom, "\roms\", "\overlays\")
            Else
                cheminoverlay = Replace(cheminrom, "\roms\", "\decorations\")
            End If

            Dim testcheminoverlay As String = Replace(cheminoverlay, nomdelarom, nomducfg)

            Process.Start("explorer", Path.GetDirectoryName(testcheminoverlay).ToString)
        End If
    End Sub
    Private Sub Romsaveo_Click(sender As Object, e As EventArgs) Handles romsaveo.Click
        'si y'a rien de loadé
        If txt_romname.Text = Nothing Then Exit Sub

        'Si pas d'image sur le jeu en cours
        If FinalGrid.SelectedCells(FinalGrid.Columns("CocheSaves").Index).Value = False Then
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
            txt_morestant.Text = "ESPACE PLEIN"
        End If
    End Sub
    Private Sub Txt_USBGo_TextChanged(sender As Object, e As EventArgs) Handles txt_USBGo.TextChanged
        txt_morestant.Text = (Val(txt_USBGo.Text) * 1024) - Val(txt_GoAPrevoir.Text)
        My.Settings.StockageSize = txt_USBGo.Text
        My.Settings.Save()
    End Sub

    Private Sub Txt_txtsearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_txtsearch.MouseClick
        'Si la colonne c'est le filtre des Dates, afficher le popup
        If ComboFiltreColonnes.Text = "DateSortie" Then
            MsgBox("Vous allez filtrer sur une date" & Chr(10) & "Le Format des dates est 'AAAAMMJJ'" & Chr(10) & Chr(10) & "Je vous recommande de toujours saisir une année")
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

            If dgvr.Cells("CocheSaves").Value = True Then
                dgvr.Cells("CocheSaves").ToolTipText = "Saves OK pour cette Rom"
            Else
                dgvr.Cells("CocheSaves").ToolTipText = "Pas de Saves pour cette Rom"
            End If
        Next
    End Sub

    Private Sub ButtonGetBack_Click(sender As Object, e As EventArgs) Handles ButtonGetBack.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ButtonTuto1_Click_1(sender As Object, e As EventArgs) Handles ButtonTuto1.Click
        'Deroulement du Tuto
        'Replace les overlay des tutos
        TutoHideGameList.Size = New Point(213, 365)
        TutoHideGameList.Location = New Point(8, 28)

        TutoHideFinalGrid.Size = New Point(391, 364)
        TutoHideFinalGrid.Location = New Point(217, 28)

        TutoHideRomInfo.Size = New Point(395, 470)
        TutoHideRomInfo.Location = New Point(612, 28)

        TutoSelectionActuelle.Size = New Point(128, 104)
        TutoSelectionActuelle.Location = New Point(483, 399)

        TutoHideSimpleMode.Size = New Point(126, 91)
        TutoHideSimpleMode.Location = New Point(8, 509)

        TutoHideFiltresAvance.Size = New Point(474, 104)
        TutoHideFiltresAvance.Location = New Point(8, 399)

        TutoHideUSB.Size = New Point(171, 77)
        TutoHideUSB.Location = New Point(142, 523)

        TutoHideSelectionIndic.Size = New Point(177, 77)
        TutoHideSelectionIndic.Location = New Point(314, 523)

        TutoHideQuoiCopier.Size = New Point(205, 77)
        TutoHideQuoiCopier.Location = New Point(492, 523)

        TutoHideOuCopier.Size = New Point(230, 77)
        TutoHideOuCopier.Location = New Point(698, 523)

        TutoHideBoutonCopy.Size = New Point(76, 77)
        TutoHideBoutonCopy.Location = New Point(930, 523)

        'On reaffiche tout
        TutoHideGameList.Show()
        TutoHideFinalGrid.Show()
        TutoHideRomInfo.Show()
        TutoSelectionActuelle.Show()
        TutoHideSimpleMode.Show()
        TutoHideFiltresAvance.Show()
        TutoHideUSB.Show()
        TutoHideSelectionIndic.Show()
        TutoHideQuoiCopier.Show()
        TutoHideOuCopier.Show()
        TutoHideBoutonCopy.Show()

        TutoHideSimpleMode.Hide()
        CreateObject("WScript.Shell").popup("Avant toute chose : Reglez le mode simple ou avancé" & Chr(10) & Chr(10) & "Le mode avancé vous permet d'afficher des filtres supplémentaires", 2, "01/19 : Les Gamelists")

        TutoHideGameList.Hide()
        ListGameLists.Show()
        FinalGrid.Hide()
        CreateObject("WScript.Shell").Popup("Ci-Contre, vos Gamelists :" & Chr(10) & "Que vous avez selectionné à la Souris ou en laissant enfoncé le clic" & Chr(10) & "Ou avec CTRL Enfoncé + Clic" & Chr(10) & "les systèmes que vous avez importés dans le tableau", 2, "02/19 : Les Gamelists")

        ListGameLists.Hide()
        TutoHideFinalGrid.Hide()
        FinalGrid.Show()
        CreateObject("WScript.Shell").Popup("Une fois les Gamelists chargés, retrouvez l'intégralité de vos roms dans ce tableau", 2, "03/19 : Les Gamelists")
        CreateObject("WScript.Shell").Popup("Chaque ligne du tableau représente une Rom" & Chr(10) & "Les coches à sa droite representent les métadonnées", 2, "04/19 : Les Gamelists")
        CreateObject("WScript.Shell").Popup("Si la cellule est Verte : Info présente dans le Gamelist" & Chr(10) & "Si la cellule est Rouge : Info non présente" & Chr(10) & "Si la cellule est Noire : Non applicable à cette Console", 2, "05/19 : Les Gamelists")
        CreateObject("WScript.Shell").Popup("La dernière colonne est la SEULE colonne qui vous interesse" & Chr(10) & Chr(10) & "Elle permet de selectionner la Rom pour Copie", 2, "06/19 : Les Gamelists")

        TutoHideRomInfo.Hide()
        CreateObject("WScript.Shell").Popup("Lors d'un clic sur une Rom du tableau précédent" & Chr(10) & "Les informations ici sont affichées", 2, "07/19 : Rom Selectionnée")
        CreateObject("WScript.Shell").Popup("Remarquez les boutons du dessous" & Chr(10) & Chr(10) & "Qui vous permettront d'ouvrir chacun des médias représentés en coche dans le tableau", 2, "08/19 : Rom Selectionnée")

        TutoHideFiltresAvance.Hide()
        CreateObject("WScript.Shell").Popup("Si vous avez coché le mode avancé, voici les filtres qui vous permettre de n'afficher qu'une partie des élements chargés", 2, "09/19 : Filtres Avancés")
        CreateObject("WScript.Shell").Popup("N'oubliez pas de cocher les Roms que vous souhaitez copier via la coche en dernière colonne !", 2, "10/19 : Filtres Avancés")

        TutoSelectionActuelle.Hide()
        CreateObject("WScript.Shell").Popup("Vous pouvez à tout moment afficher votre selection via ce bouton.", 2, "11/19 : Selection et Collections")
        CreateObject("WScript.Shell").Popup("Sous Batocera, vous pouvez également utiliser les filtres vu précedemment pour réaliser une collection 'Jeux de Combats' ou 'TombRaider's' !", 2, "12/19 : Selection et Collections")

        TutoHideSelectionIndic.Hide()
        CreateObject("WScript.Shell").Popup("Après Selection, surveillez les indicateurs qui vous permettent d'avoir un oeil sur l'espace necessaire à la copie", 2, "13/19 : Indicateurs d'Espace Libre")

        TutoHideUSB.Hide()
        CreateObject("WScript.Shell").Popup("N'oubliez pas de Saisir ici l'espace de stockage de votre média cible pour la réalisation de votre collection", 2, "14/19 : Config du Stockage")

        TutoHideQuoiCopier.Hide()
        CreateObject("WScript.Shell").Popup("Selectionner les elements que vous souhaitez retrouver dans votre copie personnalisée", 2, "15/19 : Detail du Copieur")

        TutoHideOuCopier.Hide()
        CreateObject("WScript.Shell").Popup("Definissez ici votre repertoire de Sortie" & Chr(10) & Chr(10) & "Je vous conseille de mettre ici un repertoire vide 'REMADE'" & Chr(10) & "de préference sur le support de stockage contenant" & Chr(10) & "les médias pour optimiser le temps de copie", 2, "16/19 : Repertoire Final")
        TutoHideBoutonCopy.Hide()
        CreateObject("WScript.Shell").Popup("Quand votre selection est complète, et que votre copie finale est parametrée" & Chr(10) & Chr(10) & "C'est ici qu'on lance le tout !", 2, "17/19 : Demarrer la Copie")
        CreateObject("WScript.Shell").Popup("En esperant que ces popups vous aient été utile", 2, "18/19 : Tuto Utile ?")
        CreateObject("WScript.Shell").Popup("Bonne Construction =)", 2, "19/19 Merci !")

        'Et tout le Block Tuto
        TutoHideGameList.Hide()
        TutoHideFinalGrid.Hide()
        TutoHideRomInfo.Hide()
        TutoHideUSB.Hide()
        TutoHideSelectionIndic.Hide()
        TutoHideQuoiCopier.Hide()
        TutoHideOuCopier.Hide()
        TutoHideBoutonCopy.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonShowColonne.Click
        If ComboFiltreColonnes.Text Is Nothing Then Exit Sub
        If ComboFiltreColonnes.Text = "Console" Or ComboFiltreColonnes.Text = "Titre" Then Exit Sub
        FinalGrid.Columns(ComboFiltreColonnes.Text).Visible = True
    End Sub

    Private Sub ButtonHideColumn_Click(sender As Object, e As EventArgs) Handles ButtonHideColumn.Click
        If ComboFiltreColonnes.Text Is Nothing Then Exit Sub
        If ComboFiltreColonnes.Text = "Console" Or ComboFiltreColonnes.Text = "Titre" Then Exit Sub
        FinalGrid.Columns(ComboFiltreColonnes.Text).Visible = False
    End Sub

    Private Sub ButtonRazClickk_Click(sender As Object, e As EventArgs) Handles ButtonRazClickk.Click
        txt_txtsearch.Text = "forcingreset"
    End Sub

    Private Sub ButtonAfficherMaSelection_Click_1(sender As Object, e As EventArgs) Handles ButtonAfficherMaSelection.Click
        'On affiche la Listbox a la bonne place ou on là referme
        If listboxMaSelection.Visible = True Then
            listboxMaSelection.Hide()
            LabelSelection.Hide()
            txt_romname.Show()
        Else
            listboxMaSelection.Location = New Point(-2, 43)
            listboxMaSelection.Size = New Size(396, 433)
            txt_romname.Hide()
            listboxMaSelection.Show()
            LabelSelection.Show()
        End If
    End Sub

    Private Sub ButtonParcourirRecalCopy_Click_1(sender As Object, e As EventArgs) Handles ButtonParcourirRecalCopy.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txt_CopyFolder.Text = FolderBrowserDialog1.SelectedPath
            'On va remplacer la valeur par defaut "RecalboxFolder" et on la sauvegarde pour les prochaines fois
            My.Settings.CopyFolder = txt_CopyFolder.Text
            My.Settings.Save()
        End If
    End Sub

    Private Sub ButtonSonVid_Click(sender As Object, e As EventArgs) Handles ButtonSonVid.Click
        vid_romvid.settings.mute = Not vid_romvid.settings.mute

        If vid_romvid.settings.mute = True Then
            ButtonSonVid.BackgroundImage = My.Resources.iconsound
        Else
            ButtonSonVid.BackgroundImage = My.Resources.iconsound_off
        End If
    End Sub

    Private Sub ChkSimple_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSimple.CheckedChanged
        If ChkSimple.Checked = True Then
            ChkAvance.Checked = False

            My.Settings.SimpleMode = "simple"
            My.Settings.Save()
            GroupFiltresAvances.Hide()
        ElseIf ChkSimple.Checked = False Then
            ChkAvance.Checked = True

            My.Settings.SimpleMode = "avance"
            My.Settings.Save()
            GroupFiltresAvances.Show()
        End If
    End Sub

    Private Sub ChkAvance_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAvance.CheckedChanged
        If ChkAvance.Checked = True Then
            ChkSimple.Checked = False

            My.Settings.SimpleMode = "avance"
            My.Settings.Save()
            GroupFiltresAvances.Show()
        ElseIf ChkAvance.Checked = False Then
            ChkSimple.Checked = True

            My.Settings.SimpleMode = "simple"
            My.Settings.Save()
            GroupFiltresAvances.Hide()
        End If
    End Sub

    Private Sub FinalGrid_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FinalGrid.ColumnHeaderMouseClick
        'On colore les coches
        Call Colorerlescoches()

        'Recalculselection
        Call RecalculSelection()
    End Sub

    Sub RecalculSelection()
        'RAZ
        FinalGrid.Rows.Cast(Of DataGridViewRow).ToList.ForEach(Sub(r) r.Cells("Selection").Value = False)
    End Sub

    Public Sub CopyDirectory(ByVal sourcePath As String, ByVal destinationPath As String)
        Dim sourceDirectoryInfo As New System.IO.DirectoryInfo(sourcePath)

        ' If the destination folder don't exist then create it
        If Not System.IO.Directory.Exists(destinationPath) Then
            System.IO.Directory.CreateDirectory(destinationPath)
        End If

        Dim fileSystemInfo As System.IO.FileSystemInfo
        For Each fileSystemInfo In sourceDirectoryInfo.GetFileSystemInfos
            Dim destinationFileName As String =
                System.IO.Path.Combine(destinationPath, fileSystemInfo.Name)

            ' Now check whether its a file or a folder and take action accordingly
            If TypeOf fileSystemInfo Is System.IO.FileInfo Then
                System.IO.File.Copy(fileSystemInfo.FullName, destinationFileName, True)
            Else
                ' Recursively call the mothod to copy all the neste folders
                CopyDirectory(fileSystemInfo.FullName, destinationFileName)
            End If
        Next
    End Sub

    Private Sub ButtonCollection_Click(sender As Object, e As EventArgs) Handles ButtonCollection.Click
        GroupCollections.Visible = Not GroupCollections.Visible
        If GroupCollections.Visible = True Then
            GroupCollections.Location = New Point(350, 2)
            GroupCollections.Size = New Point(236, 396)
        Else
            GroupCollections.Location = New Point(141, 1)
            GroupCollections.Size = New Point(80, 19)
        End If
    End Sub
    Sub importdescollections(nomdelalist As ComboBox)
        'reset la combobox et grid
        nomdelalist.Items.Clear()
        If nomdelalist.Name = "ComboCollection" Then CollectionGrid.ClearSelection()
        If nomdelalist.Name = "CollectionEditor" Then CollectionGridDetaille.ClearSelection()

        'import les fichiers
        Dim di As New IO.DirectoryInfo(My.Settings.RecalboxFolder & "\system\configs\emulationstation\collections\")
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.cfg")
        Dim fi As IO.FileInfo
        For Each fi In aryFi
            nomdelalist.Items.Add(fi.Name)
        Next
    End Sub
    Private Sub GroupCollections_VisibleChanged(sender As Object, e As EventArgs) Handles GroupCollections.VisibleChanged
        Call importdescollections(ComboCollection)
        'focus sur le 1er
        If ComboCollection.SelectedValue = "" Then ComboCollection.SelectedIndex = 0
        CollectionGrid.RowsDefaultCellStyle.SelectionBackColor = Color.Red
        CollectionGrid.RowsDefaultCellStyle.SelectionForeColor = Color.White
        CollectionGrid.RowsDefaultCellStyle.ForeColor = Color.Black
    End Sub
    Private Sub SupCollection_Click(sender As Object, e As EventArgs) Handles SupCollection.Click
        If MsgBox("Etes vous sur de supprimer la collection : " & Chr(10) & ComboCollection.Text, vbYesNo) = vbNo Then Exit Sub
        'on delete
        Dim adressefinale = My.Settings.RecalboxFolder & "\system\configs\emulationstation\collections\" & ComboCollection.Text
        Kill(adressefinale)
        Call importdescollections(ComboCollection)
        ComboCollection.Text = ""
    End Sub
    Private Sub AjoutCollection_Click(sender As Object, e As EventArgs) Handles AjoutCollection.Click
        Dim nomdelanouvellecollec = InputBox("Quel Nom pour cette nouvelle collection ?")

        If nomdelanouvellecollec = Nothing Then
            MsgBox("Erreur, Reessayer")
        End If
        If ComboCollection.Items.Contains(nomdelanouvellecollec) Then
            MsgBox("Essayer un autre nom")
            Exit Sub
        End If

        'On cree le fichier
        File.Create(My.Settings.RecalboxFolder & "\system\configs\emulationstation\collections\custom-" & nomdelanouvellecollec & ".cfg").Dispose()
        Call importdescollections(ComboCollection)

        'Focus sur lui
        ComboCollection.SelectedItem = "custom-" & nomdelanouvellecollec & ".cfg"
    End Sub
    Private Sub CollectionGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles CollectionGrid.RowsAdded
        CollectionGrid.ClearSelection()
        CollectionGrid.Rows(e.RowIndex).Selected = True
    End Sub
    Private Sub ComboCollection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboCollection.SelectedIndexChanged
        'Securite RAZ
        CollectionGrid.DataSource = Nothing
        Call lirelacollection(ComboCollection.Text, CollectionGrid)
    End Sub
    Sub lirelacollection(filenamecollec As String, grido As DataGridView)
        'Creer le tableau
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
            .ColumnName = "FileName"
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
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "Presence"
        End With

        table.Columns.Add(column)

        'On lit le fichier cfg
        Dim adressecomplete = My.Settings.RecalboxFolder & "\system\configs\emulationstation\collections\" & filenamecollec
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(adressecomplete)
        Dim a As String
        Dim a2 As String

        Dim romconsole As String
        Dim romfilename As String
        Dim rompath As String
        Dim rompresence As Boolean

        Do
            a = reader.ReadLine
            If a = Nothing Then Exit Do
            a2 = Replace(Replace(a, "/", "\"), ".\", "\")
            rompath = My.Settings.RecalboxFolder & a2
            romfilename = Path.GetFileName(rompath)
            'Dim detectconsole = InStr(rompath, "roms\")
            'Dim donc = rompath.Substring(detectconsole + 4)
            'Dim reslash = InStr(donc, "\")
            'Dim finalconsole = donc.Substring(0, reslash - 1)
            romconsole = rompath.Substring(InStr(rompath, "roms\") + 4).Substring(0, InStr(rompath.Substring(InStr(rompath, "roms\") + 4), "\") - 1)

            If System.IO.File.Exists(rompath) Or System.IO.Directory.Exists(rompath) Then
                rompresence = True
            Else
                rompresence = False
            End If

            'on ajoute le tout dans la table
            table.Rows.Add(romconsole, romfilename, rompath, rompresence)

        Loop Until a Is Nothing
        reader.Close()

        'Sorting A-Z the console
        dv = table.DefaultView
        'dv.Sort = "Presence asc, Console asc, FileName asc"
        grido.DataSource = table

        'Width for columns

        grido.Columns("Console").Width = 70
        grido.Columns("FileName").Width = 95
        grido.Columns("CheminRom").Visible = False
        grido.Columns("Presence").Width = 30

        Call colorercollectionlignes(grido)
    End Sub
    Sub colorercollectionlignes(grido As DataGridView)
        For i = 0 To grido.Rows.Count - 1
            Dim presence = grido.Rows(i).Cells(grido.Columns("Presence").Index).Value

            If presence = True Then
                grido.Rows(i).Cells(grido.Columns("Presence").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                grido.Rows(i).Cells(grido.Columns("Presence").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If
        Next
    End Sub
    Private Sub ButtonRemoveFromCollection_Click(sender As Object, e As EventArgs) Handles ButtonRemoveFromCollection.Click
        For Each ligne In CollectionGrid.SelectedRows
            CollectionGrid.Rows.Remove(ligne)
        Next
    End Sub
    Private Sub ButtonAddCollection_Click(sender As Object, e As EventArgs) Handles ButtonAddCollection.Click
        Dim data As DataTable = CType((CollectionGrid.DataSource), DataTable)
        Dim dv As DataView
        For Each line In FinalGrid.SelectedRows
            Dim getindex = line.index
            Dim consolass = FinalGrid.Rows(getindex).Cells(FinalGrid.Columns("Console").Index).Value
            Dim pathrom = FinalGrid.Rows(getindex).Cells(FinalGrid.Columns("CheminRom").Index).Value
            'test sur le doublon
            For i = 0 To CollectionGrid.Rows.Count - 1
                Dim chemindejasaisi = CollectionGrid.Rows(i).Cells(CollectionGrid.Columns("CheminRom").Index).Value
                If chemindejasaisi = pathrom Then
                    MsgBox("Déjà dans la Collection")
                    CollectionGrid.ClearSelection()
                    CollectionGrid.Rows(i).Selected = True
                    Exit Sub
                End If
            Next

            Dim filename = Path.GetFileName(pathrom)
            Dim rompresence
            'test si le fichier existe
            If System.IO.File.Exists(pathrom) Then
                rompresence = True
            Else
                rompresence = False
            End If
            data.Rows.Add(consolass, filename, pathrom, rompresence)
        Next
        CollectionGrid.DataSource = data
    End Sub
    Private Sub SaveCollection_Click(sender As Object, e As EventArgs) Handles SaveCollection.Click
        Dim cheminfichier As String = My.Settings.RecalboxFolder & "\system\configs\emulationstation\collections\" & ComboCollection.Text
        Kill(cheminfichier)

        For i = 0 To CollectionGrid.Rows.Count - 1
            Dim cheminrom = Replace(CollectionGrid.Rows(i).Cells(CollectionGrid.Columns("CheminRom").Index).Value, "\", "/")
            Dim detectroms = InStr(cheminrom, "/roms")
            Dim cheminfinal = "./" & cheminrom.Substring(detectroms)

            System.IO.File.AppendAllText(cheminfichier, cheminfinal & Chr(10))
        Next
lignesuivante:

        'on doit maintenant remplacer la ligne dans le fichier 'system\configs\emulationstation\es_settings.cfg'
        Dim fulltxt As String = ""
        For fichier = 0 To ComboCollection.Items.Count - 1
            Dim nomcollec = Replace(Replace(ComboCollection.Items(fichier), "custom-", ""), ".cfg", "")
            fulltxt = fulltxt & nomcollec & ","
        Next
        Dim tailletxt As Integer = Len(fulltxt)
        Dim txtaremplacer As String = fulltxt.Substring(0, tailletxt - 1)

        'on va ouvrir le fichier 
        Dim adressesettings = My.Settings.RecalboxFolder & "\system\configs\emulationstation\es_settings.cfg"
        Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(adressesettings)
        Dim a As String

        Dim compteur As String
        Dim lines() As String = System.IO.File.ReadAllLines(adressesettings)

        Do
            compteur = compteur + 1
            a = reader.ReadLine
            If InStr(a, "CollectionSystemsCustom") > 1 Then
                lines(compteur - 1) = "	<string name=" & Chr(34) & "CollectionSystemsCustom" & Chr(34) & " value=" & Chr(34) & txtaremplacer & Chr(34) & " />"
                reader.Close()
                System.IO.File.WriteAllLines(adressesettings, lines)
                Exit Do
            End If
        Loop Until a Is Nothing
        MsgBox("Sauvegardé !")
    End Sub
    Private Sub CopyRoms_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub
    Private Sub FinalGrid_KeyDown(sender As Object, e As KeyEventArgs) Handles FinalGrid.KeyDown
        Dim actualrow As Integer = FinalGrid.CurrentRow.Index

        If e.KeyCode = Keys.Space Then
            Dim status = FinalGrid.Rows(actualrow).Cells(FinalGrid.Columns("Selection").Index).Value
            Dim newstatus As Boolean

            If status = False Or Nothing Then
                newstatus = True
            End If
            Dim pathrom As String = FinalGrid.Rows(actualrow).Cells(FinalGrid.Columns("CheminRom").Index).Value

            'Si déja dans la liste, on force l'ouverture de la selection
            If listboxMaSelection.Items.Contains(pathrom) Then
                MsgBox("Déja dans la Selection")
                listboxMaSelection.Hide()
                ButtonAfficherMaSelection.PerformClick()
            Else
                listboxMaSelection.Items.Add(pathrom)
                FinalGrid.Rows(actualrow).Cells(FinalGrid.Columns("Selection").Index).Value = False
            End If
        End If

    End Sub

    Private Sub FinalGrid_SelectionChanged(sender As Object, e As EventArgs) Handles FinalGrid.SelectionChanged
        Dim actualrow As Integer = FinalGrid.CurrentRow.Index
        Call loadlesinfos(actualrow)
    End Sub

    Private Sub ButtonCollectionAvance_Click(sender As Object, e As EventArgs) Handles ButtonCollectionAvance.Click
        GroupCollectEditor.Show()
        GroupCollectEditor.Location = New Point(483, 27)
        GroupCollectEditor.Size = New Point(523, 366)

        'on replique la combobox
        CollectionEditorList.Items.Clear()

        For i = 0 To ComboCollection.Items.Count - 1
            CollectionEditorList.Items.Add(ComboCollection.Items(i))
        Next

        'On focus sur la selection precedente
        If CollectionEditorList.SelectedValue = Nothing Then
            CollectionEditorList.Text = ComboCollection.SelectedItem.ToString
        End If

        'On hide le group selection et lui meme
        GroupCollections.Hide()
        ButtonCollection.Hide()
        LabelCollection.Hide()
        GroupBoxBoutonsMedias.Hide()
        GroupBoxSelectionRoms.Hide()
        CollectionEditorList.Focus()
        CellEnGrand.Show()
        ValidCell.Hide()
    End Sub
    Private Sub ButtonHideEditor_Click(sender As Object, e As EventArgs) Handles ButtonHideEditor.Click
        GroupCollections.Show()
        GroupCollectEditor.Hide()
        GroupCollectEditor.Location = New Point(122, 2)
        GroupCollectEditor.Size = New Point(59, 25)

        ButtonCollection.Show()
        LabelCollection.Show()
        GroupBoxBoutonsMedias.Show()
        GroupBoxSelectionRoms.Show()
        CellEnGrand.Hide()
    End Sub

    Private Sub CollectionEditorList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CollectionEditorList.SelectedIndexChanged
        'On force en noir les cellules
        CollectionGridDetaille.DefaultCellStyle.ForeColor = Color.Black
        CollectionGridDetaille.DefaultCellStyle.BackColor = Color.White

        'Reset par securite
        CollectionGridDetaille.ClearSelection()

        'On load les roms de la collection
        Call lirelacollection(CollectionEditorList.Text, CollectionGridDetaille)

        'On reprend le tableau et on le retravaille
        Call reprisedutableauetcollectionedetaille()
    End Sub
    Sub reprisedutableauetcollectionedetaille()
        Dim dt As DataTable = TryCast(CollectionGridDetaille.DataSource, DataTable)

        Dim dv As DataView
        Dim column As DataColumn

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "DateSortie"
        End With
        dt.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Titre"
        End With
        dt.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Synopsis"
        End With
        dt.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Genre"
        End With
        dt.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Note"
        End With
        dt.Columns.Add(column)


        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Developer"
        End With
        dt.Columns.Add(column)


        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Publisher"
        End With
        dt.Columns.Add(column)


        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "NbPlayers"
        End With
        dt.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Region"
        End With
        dt.Columns.Add(column)

        'Loop for every gamelists
        For i = 0 To CollectionGridDetaille.Rows.Count - 1
            Dim cheminrom = CollectionGridDetaille.Rows(i).Cells(CollectionGridDetaille.Columns("CheminRom").Index).Value
            Dim nomconsole As String = CollectionGridDetaille.Rows(i).Cells(CollectionGridDetaille.Columns("Console").Index).Value
            Dim gamelist As String

            gamelist = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\gamelist.xml"

            Dim gamelistXml As XElement
            Try
                gamelistXml = XElement.Load(gamelist)
            Catch ex As Exception
                GoTo romcollectionsuivante
            End Try

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
                Dim romnote As String
                Dim romdev As String
                Dim rompubl As String
                Dim romnbplayers As String
                Dim romdate As String
                Dim romCompteur As String
                Dim romRegion As String
                Dim romhidden As String = xEle.Element("hidden")

                'on check le path 
                Dim detectrompath As Integer = InStr(cheminrom, temprom)
                If detectrompath = 0 Then GoTo romsuivante

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
                dt.Rows(i)("DateSortie") = romdate
                dt.Rows(i)("Titre") = romname
                dt.Rows(i)("Synopsis") = romdesc
                dt.Rows(i)("Genre") = romgenre
                dt.Rows(i)("Note") = romnote
                dt.Rows(i)("Developer") = romdev
                dt.Rows(i)("Publisher") = rompubl
                dt.Rows(i)("NbPlayers") = romnbplayers
                dt.Rows(i)("Region") = romRegion

                Exit For
romsuivante:
            Next
romcollectionsuivante:
        Next

        'Width for columns
        CollectionGridDetaille.Columns("Console").Width = 50
        CollectionGridDetaille.Columns("Console").Frozen = True
        CollectionGridDetaille.Columns("FileName").Width = 110
        CollectionGridDetaille.Columns("FileName").Frozen = True
        CollectionGridDetaille.Columns("Titre").Width = 150
        CollectionGridDetaille.Columns("Presence").ReadOnly = True
        CollectionGridDetaille.Columns("CheminRom").Visible = False
        CollectionGridDetaille.Columns("Synopsis").Visible = True
        CollectionGridDetaille.Columns("Genre").Visible = True
        CollectionGridDetaille.Columns("Note").Visible = True
        CollectionGridDetaille.Columns("Note").Width = 40
        CollectionGridDetaille.Columns("Developer").Visible = True
        CollectionGridDetaille.Columns("Publisher").Visible = True
        CollectionGridDetaille.Columns("NbPlayers").Visible = True
        CollectionGridDetaille.Columns("NbPlayers").Width = 40
        CollectionGridDetaille.Columns("DateSortie").Visible = True
        CollectionGridDetaille.Columns("Region").Visible = False



        'Sorting A-Z the console

        dt.Columns("Titre").SetOrdinal(1)
        dt.Columns("DateSortie").SetOrdinal(2)
        dt.Columns("CheminRom").SetOrdinal(11)
        dt.Columns("Presence").SetOrdinal(10)
        CollectionGridDetaille.DataSource = dt
        dv = dt.DefaultView
        dv.Sort = "Presence asc, Console asc, CheminRom asc"

        'On lance la coloration des checkbox
        Call colorercollectionlignes(CollectionGridDetaille)
    End Sub
    Private Sub ConfirmEditInfoonCollection_Click(sender As Object, e As EventArgs) Handles ConfirmEditInfoonCollection.Click
        If MsgBox("Etes vous sur de vouloir modifier votre Gamelist" & Chr(10) & "par vos modifs en Rouge ?", vbYesNo) = vbNo Then
            Exit Sub
        End If
        Dim compteurjeux As Integer
        Dim fulltext As String

        'On fait la sauvegarde
        For i = 0 To CollectionGridDetaille.Rows.Count - 1
            For j = 0 To CollectionGridDetaille.Columns.Count - 1
                Dim couleurtext As Color = CollectionGridDetaille.Rows(i).Cells(j).Style.ForeColor
                If couleurtext = Color.Red Then
                    compteurjeux = compteurjeux + 1
                    Dim nomconsole As String = CollectionGridDetaille.Rows(i).Cells(CollectionGridDetaille.Columns("Console").Index).Value
                    Dim gamelist As String
                    Dim pathjeu As String = CollectionGridDetaille.Rows(i).Cells(CollectionGridDetaille.Columns("CheminRom").Index).Value
                    Dim nomcolonne As String = CollectionGridDetaille.Columns(j).Name

                    Select Case nomcolonne
                        Case "CheminRom"
                            nomcolonne = "<path>"
                        Case "Titre"
                            nomcolonne = "<name>"
                        Case "Synopsis"
                            nomcolonne = "<desc>"
                        Case "DateSortie"
                            nomcolonne = "<releasedate>"
                        Case = "Genre"
                            nomcolonne = "<genre>"
                        Case "Note"
                            nomcolonne = "<rating>"
                        Case "developer"
                            nomcolonne = "<developer>"
                        Case "publisher"
                            nomcolonne = "<publisher>"
                        Case "NbPlayers"
                            nomcolonne = "<players>"
                        Case "Region"
                            nomcolonne = "<region>"
                    End Select

                    gamelist = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\gamelist.xml"

                    'On ouvre le fichier gamelist et on va editer le texte
                    'Création d'un flux d'écriture
                    Dim compteurlignedufichiergamelist As Integer = 0
                    Dim readText() As String = File.ReadAllLines(gamelist)
                    Dim okgame As Integer = 0
                    Dim laligne As String

                    For Each s In readText
                        compteurlignedufichiergamelist = compteurlignedufichiergamelist + 1

                        'On lit notre fichier original
                        Dim nomdujeu = Path.GetFileName(pathjeu)
                        Dim nomformate = Replace(s, "amp;", "")
                        Dim detectpathjeu As Integer = InStr(nomformate, nomdujeu)
                        Dim detectcolonne As Integer = InStr(s, nomcolonne)

                        If detectpathjeu > 0 Then
                            okgame = 1
                        Else
                            If okgame = 0 Then GoTo lignesuivante
                        End If

                        If okgame > 0 Then
                            If detectcolonne = 0 Then
                                GoTo lignesuivante
                            Else
                                If detectcolonne > 0 And okgame = 1 Then
                                    Dim textavant = readText(compteurlignedufichiergamelist - 1)
                                    'Dim valeur = InStr(textavant, ">")
                                    'Dim textavant2 = textavant.Substring(valeur)
                                    'Dim valeur2 = InStr(textavant2, "<")
                                    'Dim textcomplet = textavant2.Substring(0, valeur2 - 1)
                                    Dim anciennevaleur = textavant.Substring(InStr(textavant, ">")).Substring(0, InStr(textavant.Substring(InStr(textavant, ">")), "<") - 1)
                                    Dim txtmodif = Replace(s, anciennevaleur, CollectionGridDetaille.Rows(i).Cells(j).Value)
                                    readText(compteurlignedufichiergamelist - 1) = txtmodif
                                    fulltext = fulltext + txtmodif & Chr(10)
                                    System.IO.File.WriteAllLines(gamelist, readText)
                                    Exit For
                                Else
                                    GoTo lignesuivante
                                End If
                            End If
                        End If
                        GoTo lignesuivante
lignesuivante:
                    Next
                End If
            Next
        Next
        If compteurjeux = 0 Then
            MsgBox("Aucun Changement detecté")
        Else
            MsgBox("Gamelist(s) sauvegardés" & Chr(10) & Chr(10) & fulltext)
        End If
    End Sub
    Private Sub CollectionGridDetaille_SelectionChanged(sender As Object, e As EventArgs) Handles CollectionGridDetaille.SelectionChanged
        CellEnGrand.Location = New Point(483, 415)
        CellEnGrand.Size = New Point(523, 88)

        Dim valeurcell As String
        If IsDBNull(CollectionGridDetaille.Rows(CollectionGridDetaille.CurrentCell.RowIndex).Cells(CollectionGridDetaille.CurrentCell.ColumnIndex).Value) = True Then
            valeurcell = Nothing
        Else
            valeurcell = CollectionGridDetaille.Rows(CollectionGridDetaille.CurrentCell.RowIndex).Cells(CollectionGridDetaille.CurrentCell.ColumnIndex).Value
        End If

        CellEnGrand.Text = valeurcell
    End Sub
    Private Sub CollectionGridDetaille_KeyDown(sender As Object, e As KeyEventArgs) Handles CollectionGridDetaille.KeyDown
        Dim rowo As Integer = CollectionGridDetaille.CurrentCell.RowIndex
        Dim colo As Integer = CollectionGridDetaille.CurrentCell.ColumnIndex

        'Test sur les valeurs
        If rowo < 0 Or rowo > CollectionGridDetaille.Rows.Count - 1 Then Exit Sub
        If colo < 0 Or colo > CollectionGridDetaille.Columns.Count - 1 Then Exit Sub
    End Sub
    Private Sub CellEnGrand_GotFocus(sender As Object, e As EventArgs) Handles CellEnGrand.GotFocus
        ValidCell.Show()
    End Sub
    Private Sub ValidCell_Click(sender As Object, e As EventArgs) Handles ValidCell.Click
        CellEnGrand.Location = New Point(234, 4)
        CellEnGrand.Size = New Point(19, 23)

        Dim valeurcell As String
        If IsDBNull(CollectionGridDetaille.Rows(CollectionGridDetaille.CurrentCell.RowIndex).Cells(CollectionGridDetaille.CurrentCell.ColumnIndex).Value) = True Then
            valeurcell = Nothing
        Else
            valeurcell = CollectionGridDetaille.Rows(CollectionGridDetaille.CurrentCell.RowIndex).Cells(CollectionGridDetaille.CurrentCell.ColumnIndex).Value
        End If

        'Test si c'est identique ou non
        If CellEnGrand.Text <> valeurcell Then
            CollectionGridDetaille.Rows(CollectionGridDetaille.CurrentCell.RowIndex).Cells(CollectionGridDetaille.CurrentCell.ColumnIndex).Value = CellEnGrand.Text
            CollectionGridDetaille.Rows(CollectionGridDetaille.CurrentCell.RowIndex).Cells(CollectionGridDetaille.CurrentCell.ColumnIndex).Style.ForeColor = Color.Red
        Else
            CollectionGridDetaille.Rows(CollectionGridDetaille.CurrentCell.RowIndex).Cells(CollectionGridDetaille.CurrentCell.ColumnIndex).Style.ForeColor = Color.Black
        End If

        CollectionGridDetaille.Focus()
        ValidCell.Hide()
    End Sub
End Class
