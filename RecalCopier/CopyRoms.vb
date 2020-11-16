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
        txt_txtsearch.Hide()
        listboxMaSelection.Hide()
        buttonRAZ.Hide()
        GroupFiltresAvances.Hide()
        minipic1.Hide()
        minipic2.Hide()
        minipic3.Hide()
        minipic4.Hide()
        minipic5.Hide()

        'Launch Import Gamelist button
        ButtonImportXML.PerformClick()
    End Sub
    Private Sub ButtonImportXML_click(sender As Object, e As EventArgs) Handles ButtonImportXML.Click
        For Each foundDirectory In Directory.GetDirectories(My.Settings.RecalboxFolder & "\roms", ".", SearchOption.TopDirectoryOnly)

            If File.Exists(foundDirectory & "\gamelist.xml") Then
                ListGameLists.Items.Add(foundDirectory & "\gamelist.xml")
            End If
        Next

        'showing gridview2
        ButtonImportXML.Hide()
        FinalGrid.Show()
        ButtonShowGames.Show()

        'Mettre les console dans la listebox console
        For ligne = 0 To ListGameLists.Items.Count - 1
            Dim consolederom As String
            consolederom = pathjeu.Substring(InStr(pathjeu, "\roms\") + 5).Substring(0, InStr(pathjeu.Substring(InStr(pathjeu, "\roms\") + 5), "\") - 1)

            listconsoleselected.Items.Add(consolederom)
        Next

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
            Dim nomconsole As String = i.Substring((InStr(i, "roms\",) + 4)).Substring(0, InStr(i.Substring((InStr(i, "roms\",) + 4)), "\gamelist.xml") - 1)

            gamelist = i

            Dim gamelistXml As XElement = XElement.Load(gamelist)

            'getting the list for the xml with nodes
            Dim query2 = From st In gamelistXml.Descendants("game") Select st

            For Each xEle As XElement In query2
                Dim romconsole As String = nomconsole
                Dim romname As String = xEle.Element("name")
                Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
                Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & temprom
                Dim romhidden As String = xEle.Element("hidden")
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

                'Conditionnelles sur tous les champs
                If romhidden = "true" Then GoTo romsuivante 'si la rom est hidden, on l'affiche pas (Roms multicd)


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
                table.Rows.Add(romconsole, romname, rompath, romdesc, romimage, romvideo, romanual, romgenre, romadult, romnote, romdev, rompubl, romnbplayers, romdate, romCompteur, romRegion)
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
        lbl_gamelist.Hide()
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

                Dim sizefichier As Long
                Dim attr As FileAttributes = File.GetAttributes(chemindelarom)

                If ((attr And FileAttribute.Directory) = FileAttribute.Directory) Then
                    'si c'est un repertoire (daphne, dos ...etc) 

                    Dim folder As New IO.DirectoryInfo(chemindelarom & "\")
                    For Each file As IO.FileInfo In folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
                        sizefichier += file.Length
                    Next file

                    sizefichier = chemindelarom

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
                'Conversion en Mo
                Dim tailleenmo As Decimal = sizefichier / 1048576
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
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheImage").Index).Value = True
            End If
            'test sur le chemin des videos
            If IsDBNull(FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CheminVideo").Index).Value) Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheVideo").Index).Value = False
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheVideo").Index).Value = True
            End If
            'test sur le chemin des manuels
            If IsDBNull(FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CheminManuel").Index).Value) Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheManuel").Index).Value = False
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheManuel").Index).Value = True
            End If

            'test sur le chemin des overlays

            Dim FileInfo As New FileInfo(cheminrom)
            Dim nomdelarom As String = FileInfo.Name
            Dim nomducfg As String = nomdelarom & ".cfg"

            Dim cheminoverlay As String = Replace(cheminrom, "\roms\", "\overlays\")
            Dim testcheminoverlay As String = Replace(cheminoverlay, nomdelarom, nomducfg)

            If System.IO.File.Exists(testcheminoverlay) Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheOverlay").Index).Value = True
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheOverlay").Index).Value = False
            End If

            'test sur le chemin des saves
            Dim cheminsaves As String = Replace(cheminrom, "\roms\", "\saves\")
            Dim romsansextension = FileNameWithoutExtension(nomdelarom)

            Dim savesCount As Integer = IO.Directory.GetFiles(Replace(cheminsaves, nomdelarom, ""), romsansextension & ".*").Length

            If savesCount >= 1 Then
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheSave").Index).Value = True
            Else
                FinalGrid.Rows(orow).Cells(FinalGrid.Columns("CocheSave").Index).Value = False
            End If
        Next

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

        If IsDBNull(row.Cells(FinalGrid.Columns("CheminImage").Index).Value) Then
            cellulevideo = Nothing
        Else
            cellulevideo = row.Cells(FinalGrid.Columns("CocheImage").Index).Value
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

            vid_romvid.uiMode = "none"
            vid_romvid.settings.setMode("loop", True)

            vid_romvid.settings.mute = True
            vid_romvid.Ctlcontrols.play()
        End If

        'Conditionnelle sur les Boutons
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

        If checkboximg = True Then
            romscreeno.Image = imgscreen2
        Else
            romscreeno.Image = imgscreen2no
        End If

        If checkboxvideo = True Then
            romvideoo.Image = imgvideo2
        Else
            romvideoo.Image = imgvideo2no
        End If

        If checkboxmanual = True Then
            rommanualo.Image = imgmanual2
        Else
            rommanualo.Image = imgmanual2no
        End If

        If checkboxoverlay = True Then
            romoverlayo.Image = imgoverlay2
        Else
            romoverlayo.Image = imgoverlay2no
        End If

        If checkboxsave = True Then
            romsaveo.Image = imgsaves2
        Else
            romsaveo.Image = imgsaves2no
        End If
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

        'On recherche le numero de la colonne des Titres
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
                    Call selectiondudernier(a)
                    listboxMaSelection.Hide() 'et On la rehide
                Else
                    Call selectiondudernier(a)
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
        Dim sizecumulrom As Integer

        For a = 0 To listboxMaSelection.Items.Count - 1 'Toutes les lignes
            Dim romacchercher As String = listboxMaSelection.Items(a)
            For j = 0 To FinalGrid.RowCount - 1
                If FinalGrid.Rows(j).Cells(FinalGrid.Columns("CheminRom").Index).Value = romacchercher Then
                    sizecumulrom += FinalGrid.Rows(j).Cells(FinalGrid.Columns("Mo").Index).Value
                End If
            Next
            txt_GoAPrevoir.Text = sizecumulrom ' et on l'affiche dans le txtbox
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
            temptxt5 = "Les Overlays seront Copiées"
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
        listboxMaSelection.Location = New Point(6, 0)
        listboxMaSelection.Size = New Size(387, 329)

        If MsgBox("Vérifiez Votre Liste de Roms Ci Dessus" & Chr(13) & optionsbox & Chr(13) & Chr(13) & "Chemin de Copie :" & Chr(13) & txt_CopyFolder.Text, vbYesNo) = vbNo Then
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

            'a optimiser pour ecrire le gamelist en temps réel ...
            'en attendant on copie le gamelist
            System.IO.File.Copy(legamelist, lenouvogamelist, True)

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
                        estcequesaves = FinalGrid.Rows(e1).Cells(FinalGrid.Columns("CheminSave").Index).Value ' on check si le jeu a un overlay sinon on zappe le traitement
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
            If MsgBox("Vous aviez coché les Overlays, voules vous les overlays systemes également ?" & Chr(13) & "Oui = Tous les Systemes" & Chr(13) & "Annuler = Consoles Selectionnées" & Chr(13) & "Non = Aucun", vbYesNoCancel) = vbYes Then
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
                    Dim fulladresse As String = Path.GetDirectoryName(listconsoleselected.Items(overlaysys))
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
        Dim folder As New IO.DirectoryInfo(My.Settings.CopyFolder)
        For Each file As IO.FileInfo In folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
            sizefichier += file.Length
        Next file

        Dim calcultailletotal As Decimal = Math.Round(sizefichier / 1048576, 2)

        MsgBox("Copie Terminée !" & Chr(13) & "Taille Totale : " & calcultailletotal & " Mo" & Chr(13) & "Veuillez Deplacer le dossier recalbox sur votre media")
        Process.Start("explorer", My.Settings.CopyFolder)
    End Sub
    Private Sub Buttonaffichermaselection_Click(sender As Object, e As EventArgs) Handles buttonaffichermaselection.Click
        'On affiche la Listbox a la bonne place ou on là referme
        If listboxMaSelection.Visible = True Then
            listboxMaSelection.Hide()
        Else
            listboxMaSelection.Location = New Point(6, 0)
            listboxMaSelection.Size = New Size(387, 329)
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

#Enable Warning BC42105 ' La fonction ne retourne pas de valeur sur tous les chemins du code
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
    Private Sub Txt_GoAPrevoir_TextChanged(sender As Object, e As EventArgs) Handles txt_GoAPrevoir.TextChanged
        txt_morestant.Text = (Val(txt_USBGo.Text) * 1024) - Val(txt_GoAPrevoir.Text)
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
End Class
