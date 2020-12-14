Imports System.IO
Public Class SaveManager
    Private Sub SaveManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        TextBox2.Hide()
        GroupRoms.Hide()
        GroupSaves.Hide()
        Call ImporterlesGamelists()
    End Sub
    Private Sub ButtonGetBack1_Click(sender As Object, e As EventArgs) Handles ButtonGetBack1.Click
        Form1.Show()
        Me.Close()
    End Sub
    Sub ImporterlesGamelists()
        'On Importe toutes les GameLists
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.RecalboxFolder & "\Saves\", FileIO.SearchOption.SearchTopLevelOnly)
            GameLists.Items.Add(System.IO.Path.GetFileName(folder))
        Next
    End Sub
    Private Sub ButtonImportRoms_Click(sender As Object, e As EventArgs) Handles buttonImportRoms1.Click
        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If GameLists.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner des Gamelists")
            Exit Sub
        End If

        'On clear par Securité
        DataGridRoms.Columns.Clear()
        On Error Resume Next
        DataGridRoms.Rows.Clear()
        On Error GoTo 0

        If GameLists.Items.Count = 0 Then Exit Sub

        Dim gamelist As String = GameLists.Items(0)
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
            .ColumnName = "NomdeRom"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminSave"
        End With
        table.Columns.Add(column)


        'Loop for every gamelists
        For Each i In GameLists.SelectedItems

            'generating the console name
            Dim console As String = i
            gamelist = My.Settings.RecalboxFolder & "\roms\" & i & "\gamelist.xml"

            'Si dans le dossier y'a pas de gamelist on va annuler l'ajout de roms parce que y'en a pas.
            If Not System.IO.File.Exists(gamelist) Then
                GoTo ProchainGamelist
            End If

            'On ajoute ensuite les consoles dans la listebox des console
            Dim consolederom As String = i
            Dim gamelistXml As XElement = XElement.Load(gamelist)

            'getting the list for the xml with nodes
            Dim query2 = From st In gamelistXml.Descendants("game") Select st

            For Each xEle As XElement In query2
                Dim romconsole As String = console
                Dim romname As String = xEle.Element("name")
                Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
                Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & console & "\" & temprom
                Dim romsaves As String = Nothing
                Dim romhidden As String = xEle.Element("hidden")
                Dim romnomderom As String = Path.GetFileName(rompath)
                If romhidden = "true" Then GoTo Romsuivante 'si la rom est hidden, on l'affiche pas (Roms multicd)

                'on ajoute le tout dans une table
                table.Rows.Add(romconsole, romname, rompath, romnomderom, romsaves)
Romsuivante:
            Next
ProchainGamelist:
        Next
        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridRoms.DataSource = table

        'On ajoute la checkbox pour les Saves
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn With {
            .HeaderText = "CocheSave",
            .Name = "CocheSave"
        }
        DataGridRoms.Columns.Add(chk)

        'Et le nombre de Saves
        DataGridRoms.Columns.Add("NbSaves", "NbSaves")

        'Width for columns
        DataGridRoms.RowHeadersWidth = 25
        DataGridRoms.Columns("Console").Width = 40
        DataGridRoms.Columns("Titre").Width = 185
        DataGridRoms.Columns("CheminRom").Width = 20
        DataGridRoms.Columns("NomdeRom").Width = 10
        DataGridRoms.Columns("CheminSave").Width = 40
        DataGridRoms.Columns("CocheSave").Width = 25
        DataGridRoms.Columns("NbSaves").Width = 30

        'Hiding les colonnes
        DataGridRoms.Columns("CheminRom").Visible = False
        DataGridRoms.Columns("NomdeRom").Visible = False
        DataGridRoms.Columns("CheminSave").Visible = True
        DataGridRoms.Columns("NbSaves").Visible = True

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, Titre asc"

        Dim compteurSave As Integer = 0

        'On remplit les Coches Saves
        Call CompletiondesSavesRoms()

        'On compte le nombre total d'entrées
        RomTotal.Text = DataGridRoms.Rows.Count - 1

        'on affiche les outils
        TextBox1.Show()
        GroupRoms.Show()
    End Sub

    Public Function FileNameWithoutExtension(ByVal FullPath _
    As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function
    Sub CompletiondesSavesRoms()
        Dim compteurSave As Integer = 0
        For ligne = 0 To DataGridRoms.RowCount - 2
            Dim rompath = DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CheminRom").Index).Value
            Dim dossierparent = Path.GetDirectoryName(rompath)
            Dim romname = DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("NomdeRom").Index).Value
            Dim console = DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("Console").Index).Value
            Dim romnamesansext = FileNameWithoutExtension(DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("NomdeRom").Index).Value)
            Dim nomducfg As String = romname & ".*"
            Dim cheminsave As String = Replace(rompath, "\roms\", "\saves\")
            Dim dossiersaveparent As String = Replace(dossierparent, "roms", "saves")
            Dim testcheminsave As String = Replace(cheminsave, romname, romnamesansext)
            Dim compteurfiles As Integer = 0
            Dim chemindufichier As String

            DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CheminSave").Index).Value = testcheminsave

            Dim dir As DirectoryInfo = New DirectoryInfo(dossiersaveparent)
            'on va enlever le dossier en trop si y'a
            Dim detectdossierentrop As String = InStr(dossierparent, console)

            Dim split As String() = rompath.Split("\")
            Dim dossierdelafin As String = split(split.Length - 2)

            If dossierdelafin <> console Then
                Dim remadedossier As String = dossierparent.Substring(detectdossierentrop + Len(console))
                Dim lenremadedossier As Integer = Len(remadedossier)
                dir = New DirectoryInfo(Replace(dossiersaveparent, dossierdelafin, ""))
            End If

            Dim files As FileInfo() = dir.GetFiles(romnamesansext & ".*")

            If files.Length > 0 Then
                For Each file As FileInfo In files
                    chemindufichier = dossiersaveparent & "\" & file.ToString
                    ListSaves.Items.Add(chemindufichier)
                    compteurfiles = compteurfiles + 1
                Next
            Else
            End If

            If compteurfiles > 0 Then
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheSave").Index).Value = True
                compteurSave += 1
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("NbSaves").Index).Value = compteurfiles
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheSave").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheSave").Index).Value = False
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("NbSaves").Index).Value = 0
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheSave").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If
        Next
        RomTotalSave.Text = compteurSave
    End Sub

    Private Sub ButtonImportSaves_Click(sender As Object, e As EventArgs) Handles ButtonImportSaves1.Click
        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If GameLists.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        'On clear par Securité
        DataGridSave.Columns.Clear()
        On Error Resume Next
        DataGridSave.Rows.Clear()
        On Error GoTo 0

        If GameLists.Items.Count = 0 Then Exit Sub

        Dim gamelist As String = GameLists.Items(0)
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
            .ColumnName = "NomRomXML"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "NomFichierSave"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminSave"
        End With
        table.Columns.Add(column)

        Dim chemincfgSave As String = Nothing

        'Loop for every gamelists
        For Each i In GameLists.SelectedItems
            Dim nomconsole As String = i
            Dim nbdansdossier = Directory.GetFiles(My.Settings.RecalboxFolder & "\saves\" & nomconsole, "*.*").Count

            If nbdansdossier = 0 Then
                MsgBox("Pas de Saves dans la console :" & nomconsole)
                Exit Sub
            End If

            Dim di As New IO.DirectoryInfo(My.Settings.RecalboxFolder & "\saves\" & nomconsole)
            Dim aryFi As IO.FileInfo() = di.GetFiles("*.*")
            Dim fi As IO.FileInfo
            Dim nomfichierdelasave As String
            Dim chemindelasave As String
            Dim pathdelasave As String

            For Each fi In aryFi
                chemindelasave = fi.FullName
                nomfichierdelasave = fi.Name
                pathdelasave = Replace(chemindelasave, "\saves\", "\roms\")

                'On va rechercher le nom de la save
                Dim romname = Recherchenomdelasave(nomconsole, pathdelasave)

                'on ajoute au tableau
                table.Rows.Add(nomconsole, romname, nomfichierdelasave, chemindelasave)

fichiersuivant:
            Next
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridSave.DataSource = table

        'Width for columns
        DataGridSave.RowHeadersWidth = 25
        DataGridSave.Columns("Console").Width = 40
        DataGridSave.Columns("NomRomXML").Width = 90
        DataGridSave.Columns("NomFichierSave").Width = 190
        DataGridSave.Columns("CheminSave").Width = 60

        Dim compteurSave As Integer = 0

        'On ajoute la checkbox pour les Saves
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn With {
            .HeaderText = "CocheRom",
            .Name = "CocheRom"
        }
        DataGridSave.Columns.Add(chk)
        DataGridSave.Columns("CocheRom").Width = 25

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, NomRomXML asc"

        'On supprime la liste au cas ou
        ListdesFichiersEnTrop.Items.Clear()

        'On va vérifier si les cfg sont liés à une rom
        For row = 0 To DataGridSave.Rows.Count - 2
            Dim cheminencours = DataGridSave.Rows(row).Cells(DataGridSave.Columns("CheminSave").Index).Value
            Dim consolerom = DataGridSave.Rows(row).Cells(DataGridSave.Columns("Console").Index).Value

            'on va colorer la colonne des coches
            If DataGridSave.Rows(row).Cells(DataGridSave.Columns("NomRomXML").Index).Value = "#ORPHELIN#" Then
                DataGridSave.Rows(row).Cells(DataGridSave.Columns("CocheRom").Index).Value = False
                DataGridSave.Rows(row).Cells(DataGridSave.Columns("CocheRom").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
                'et du coup on va ajouter à la listbox des CFG
                ListdesFichiersEnTrop.Items.Add(DataGridSave.Rows(row).Cells(DataGridSave.Columns("CheminSave").Index).Value)
            Else
                DataGridSave.Rows(row).Cells(DataGridSave.Columns("CocheRom").Index).Value = True
                DataGridSave.Rows(row).Cells(DataGridSave.Columns("CocheRom").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            End If
        Next

        'On met la derniere colonne coche en readonly
        DataGridSave.Columns("CocheRom").ReadOnly = True

        'On compte le nombre total d'entrées
        SaveTotal.Text = DataGridSave.Rows.Count - 1
        'on affiche les outils
        TextBox2.Show()
        GroupSaves.Show()
    End Sub
    Function Recherchenomdelasave(console As String, pathdelasave As String)
        Dim lagamelist As String = My.Settings.RecalboxFolder & "\roms\" & console & "\gamelist.xml"
        Dim nomdelasave = FileNameWithoutExtension((Path.GetFileName(pathdelasave)))

        'Si il n'existe pas de gamelist, on va mettre les infos generique
        If Not System.IO.File.Exists(lagamelist) Then
            Return "#NOGAMELIST#-" & console
        End If


        'On va essayer de trouver le nom de la rom avec le nom de la save
        Dim di As New IO.DirectoryInfo(My.Settings.RecalboxFolder & "\roms\" & console)
        Dim aryFi As IO.FileInfo() = di.GetFiles(nomdelasave & ".*")
        Dim fi As IO.FileInfo
        Dim nomfichierdelasave As String
        Dim chemindelasavetrouvee As String
        Dim romtrouvee As Integer = 0

        For Each fi In aryFi
            chemindelasavetrouvee = fi.FullName
            nomfichierdelasave = fi.Name

            Dim gamelistXml As XElement = XElement.Load(lagamelist)

            'getting the list for the xml with nodes
            Dim query2 = From st In gamelistXml.Descendants("game") Select st

            For Each xEle As XElement In query2
                Dim romname As String = xEle.Element("name")
                Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
                Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & console & "\" & temprom
                Dim nomdelarompath As String = Path.GetFileName(rompath)

                If nomdelarompath = nomfichierdelasave Then
                    Return romname
                End If
lignesuivante:
            Next
            Exit Function
        Next
        'Si il n' y a pas de rom trouvée on mets "Saves Orpheline"
        Return "#ORPHELIN#"
    End Function

    Private Sub ButtonMenage_Click(sender As Object, e As EventArgs)
        If MsgBox("Etes vous sur de vouloir supprimer tous les fichiers dans la listbox rosée ci-contre ?", vbYesNo) = vbNo Then Exit Sub

        For i = 0 To ListdesFichiersEnTrop.Items.Count - 1
            Dim pathdufichier As String = ListdesFichiersEnTrop.Items(i)
            System.IO.File.Delete(pathdufichier)
        Next
        MsgBox("Fichiers Supprimés avec Succès")
    End Sub

    Private Sub ImportBoth_Click(sender As Object, e As EventArgs) Handles ImportBoth1.Click
        'raz des lists
        ListSaves.Items.Clear()
        ListdesFichiersEnTrop.Items.Clear()

        buttonImportRoms1.PerformClick()
        ButtonImportSaves1.PerformClick()
    End Sub
    Sub LectureDesCfgs(consolerom As String, nomducfg As String)
        Dim modifgamelistenrom As String = nomducfg

        Dim fichier1cfg As String = My.Settings.RecalboxFolder & "\Saves\" & consolerom & "\" & modifgamelistenrom
        Dim fichier2Savecfg As String
        Dim fichier3png As String

        Dim cheminpropreSave2 As String
        Dim justefichier2 As String

        fichier3png = 0
        justefichier2 = 0
        fichier2Savecfg = 0
        cheminpropreSave2 = 0

        'on va lire le cfg pour trouver le cfg Save
        File.ReadAllLines(fichier1cfg)

        Dim readText() As String = File.ReadAllLines(fichier1cfg)
        Dim s As String
        'On ajoute a la listbox
        ListdesFichiersEnTrop.Items.Add(fichier1cfg)

        For Each s In readText
            Dim detectinputSave As String = InStr(s, "/Saves/")
            If detectinputSave > 0 Then
                'Dim cheminducfgSave = s.Substring(detectinputSave + 9)
                'Dim detectdupointcfg = InStr(cheminducfgSave, ".cfg")
                'Dim cheminfinalSavecfg = cheminducfgSave.Substring(0, detectdupointcfg + 3)
                Dim chemincfgSavedanscfg = s.Substring(InStr(s, "/Saves/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/Saves/") + 9), ".cfg") + 3)
                cheminpropreSave2 = My.Settings.RecalboxFolder & "\Saves\" & Replace(chemincfgSavedanscfg, "/", "\")
                justefichier2 = FileNameWithoutExtension(cheminpropreSave2) & ".cfg"
                Exit For
            End If
        Next

        'on lit le deuxieme fichier Save cfg pour trouver le png
        If Not File.Exists(cheminpropreSave2) Then Exit Sub
        File.ReadAllLines(cheminpropreSave2)
        'On ajoute a la listbox
        ListdesFichiersEnTrop.Items.Add(cheminpropreSave2)

        Dim readText2() As String = File.ReadAllLines(cheminpropreSave2)
        Dim t As String

        For Each t In readText2
            Dim detectSavezero As String = InStr(t, "Save0_Save")
            If detectSavezero > 0 Then
                Dim chemindupng = t.Substring(detectSavezero + 19)
                Dim detectpng = InStr(chemindupng, "png")
                Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 2)
                Dim cheminpng = t.Substring(InStr(t, "Save0_Save") + 19).Substring(0, InStr(t.Substring(InStr(t, "Save0_Save") + 19), "png") + 2)
                fichier3png = Replace(cheminpropreSave2, justefichier2, cheminpng)
                Exit For
            End If
        Next
        'on ajoute a la listbox
        ListdesFichiersEnTrop.Items.Add(fichier3png)
    End Sub

    Private Sub DataGridRoms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRoms.CellClick
        'check that row isn't -1, i.e. creating datagrid header
        If e.RowIndex = -1 Then Exit Sub

        'On copie le nom du fichier dans le fichier de renommage
        Dim nomdufichier As String = Path.GetFileName(DataGridRoms.Rows(e.RowIndex).Cells(DataGridRoms.Columns("CheminRom").Index).Value)
        NewName.Text = FileNameWithoutExtension(nomdufichier)

        'On recherche le numero de la colonne des Selections
        Dim valeursaves = DataGridRoms.Rows(e.RowIndex).Cells(DataGridRoms.Columns("NbSaves").Index).Value



        If valeursaves > 0 Then

            Dim nomdelaromgamelist As String = Path.GetFileName(DataGridRoms.Rows(e.RowIndex).Cells(DataGridRoms.Columns("CheminSave").Index).Value)
            'Si on est ici c'est qu'il y'a plusieurs saves à la rom. Donc on va selectionner les items dans la listbox
            Dim columnindex As Integer = DataGridRoms.CurrentCell.ColumnIndex
            Dim rowIndex As Integer = DataGridRoms.CurrentCell.RowIndex
            Dim pathrom As String = DataGridRoms.Rows(rowIndex).Cells(DataGridRoms.Columns("CheminRom").Index).Value
            Dim nomdelaromdanslistbox As String



            ListSaves.ClearSelected()

            'On va chercher le nom et selectionner
            For i = 0 To ListSaves.Items.Count - 1
                nomdelaromdanslistbox = FileNameWithoutExtension(ListSaves.Items(i).ToString)

                If nomdelaromdanslistbox = nomdelaromgamelist Then
                    ListSaves.SetSelected(i, True)
                End If
            Next

        End If
    End Sub

    Private Sub DataGridSave_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSave.CellContentClick
        'check that row isn't -1, i.e. creating datagrid header
        If e.RowIndex = -1 Then Exit Sub



        Dim nomdelasave As String = DataGridSave.Rows(e.RowIndex).Cells(DataGridSave.Columns("NomFichierSave").Index).Value
        ActualName.Text = nomdelasave
        PathActuel.Text = DataGridSave.Rows(e.RowIndex).Cells(DataGridSave.Columns("CheminSave").Index).Value

        'Si on est ici c'est qu'il y'a plusieurs saves à la rom. Donc on va selectionner les items dans la listbox
        Dim columnindex As Integer = DataGridSave.CurrentCell.ColumnIndex
        Dim rowIndex As Integer = DataGridSave.CurrentCell.RowIndex
        Dim pathrom As String = DataGridSave.Rows(rowIndex).Cells(DataGridSave.Columns("CheminSave").Index).Value
        Dim nomdelaromdanslistbox As String

            ListdesFichiersEnTrop.ClearSelected()

            'On va chercher le nom et selectionner
            For i = 0 To ListdesFichiersEnTrop.Items.Count - 1
            nomdelaromdanslistbox = Path.GetFileName(ListdesFichiersEnTrop.Items(i).ToString)

            If nomdelaromdanslistbox = nomdelasave Then
                ListdesFichiersEnTrop.SetSelected(i, True)
            End If
        Next

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
    Private Sub ButtonRomsDeleteSelected_Click(sender As Object, e As EventArgs) Handles ButtonRomsDeleteSelected.Click
        If ListSaves.SelectedItem = Nothing Then
            MsgBox("Aucune Selection")
            Exit Sub
        End If

        If MsgBox("Etes vous sur de supprimer definitivement les sauvegardes selectionnées ci contre ?", vbYesNo) = vbNo Then Exit Sub
        Dim compteur As Integer = 0

        'On delete les fichiers
        For Each i In ListSaves.SelectedItems
            System.IO.File.Delete(i)
            compteur = compteur + 1
        Next

        'on remove les entrees
        For n As Integer = ListSaves.SelectedItems.Count - 1 To 0 Step -1
            ListSaves.Items.Remove(ListSaves.SelectedItems(n))
        Next n

        'On Refresh
        buttonImportRoms1.PerformClick()

        'On enleve les doublons
        Supdoublon(ListSaves)

        'Recap
        MsgBox(compteur & " fichiers supprimés")
    End Sub

    Private Sub ButtonSuppSave_Click(sender As Object, e As EventArgs) Handles ButtonSuppSave.Click
        If ListdesFichiersEnTrop.SelectedItem = Nothing Then
            MsgBox("Aucune Selection")
            Exit Sub
        End If

        If MsgBox("Etes vous sur de supprimer definitivement les sauvegardes selectionnées ci contre ?", vbYesNo) = vbNo Then Exit Sub
        Dim compteur As Integer = 0

        'On delete les fichiers
        For Each i In ListdesFichiersEnTrop.SelectedItems
            System.IO.File.Delete(i)
            compteur = compteur + 1
        Next

        'on remove les entrees
        For n As Integer = ListdesFichiersEnTrop.SelectedItems.Count - 1 To 0 Step -1
            ListdesFichiersEnTrop.Items.Remove(ListdesFichiersEnTrop.SelectedItems(n))
        Next n

        'On Refresh
        ButtonImportSaves1.PerformClick()

        'On enleve les doublons
        Supdoublon(ListdesFichiersEnTrop)

        'Recap
        MsgBox(compteur & " fichiers supprimés")
    End Sub

    Private Sub ButtonMenageOrphelin_Click(sender As Object, e As EventArgs) Handles ButtonMenageOrphelin.Click
        If ListdesFichiersEnTrop.Items.Count = 0 Then
            MsgBox("Aucune Saves Orpheline Detectée")
            Exit Sub
        End If

        If MsgBox("Etes vous sur de supprimer DEFINITIVEMENT" & Chr(13) & "TOUTES les sauvegardes mentionnées comme Orphelines ?", vbYesNo) = vbNo Then Exit Sub

        For i = 0 To ListdesFichiersEnTrop.Items.Count - 1
            System.IO.File.Delete(ListdesFichiersEnTrop.Items(i))
        Next

        'On refresh
        ButtonImportSaves1.PerformClick()

        'On enleve les doublons
        Supdoublon(ListdesFichiersEnTrop)

        MsgBox("Fichiers Orphelins Supprimés")

    End Sub

    Private Sub ButtonRenameSave_Click(sender As Object, e As EventArgs) Handles ButtonRenameSave.Click
        If NewName.Text = Nothing Then
            MsgBox("Aucun nom de fichier Saisi")
            Exit Sub
        End If

        If ListdesFichiersEnTrop.SelectedItems.Count > 1 Then
            MsgBox("Impossible de Traiter plusieurs Fichiers simultanament")
            Exit Sub
        End If

        'On detecte si y'a une extension.
        Dim newextension As String = Path.GetExtension(NewName.Text)

        'Si .blablablabla a moins de 8 caracteres, c'est que c'est une vraie extension (.scummvm ?). Donc ca veut dire que c'est une extension qui est saisie
        If newextension = "" Then GoTo oncontinue

        If Len(newextension) < 8 Then
                MsgBox("Merci de retirer l'extension dans votre proposition")
                Exit Sub
            End If

oncontinue:

        'On prends l'extension attendue
        Dim extension As String = Path.GetExtension(ActualName.Text)
        Dim finaladresse As String = Replace(PathActuel.Text, ActualName.Text, (NewName.Text & extension))

        'on verifie que c'est un state
        If textstate.Visible = True Then
            If textstate.Text = 1 Then textstate.Text = ""
            finaladresse = Replace(finaladresse, extension, ".state" & textstate.Text)
        End If
        Dim newnamestate = Path.GetFileName(finaladresse)

        'Test si ca existe deja
        If System.IO.File.Exists(finaladresse) Then
            MsgBox("Impossible de renommer ce fichier" & Chr(13) & "Le nom Final de votre fichier existe déjà")
            Exit Sub
        End If

        If MsgBox("Vous allez changer le nom de la sauvegarde : " & Chr(13) & Chr(13) & ActualName.Text & Chr(13) & Chr(13) & "pour : " & Chr(13) & Chr(13) & newnamestate & Chr(13) & Chr(13) & "Confirmer ?", vbYesNo) = vbNo Then Exit Sub


        File.Move(PathActuel.Text, finaladresse)

        'on refresh le tout
        ActualName.Text = Nothing
        PathActuel.Text = Nothing
        ButtonImportSaves1.PerformClick()

        'On enleve les doublons
        Supdoublon(ListdesFichiersEnTrop)
    End Sub

    Private Sub ListdesFichiersEnTrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListdesFichiersEnTrop.SelectedIndexChanged
        ActualName.Text = Path.GetFileName(ListdesFichiersEnTrop.SelectedItem)
        PathActuel.Text = ListdesFichiersEnTrop.SelectedItem

        'detect if state
        Dim statenb As Integer = InStr(ActualName.Text, "state")
        If statenb > 0 Then
            textstate.Show()
            Label9.Show()
            Dim numero As String = ActualName.Text.Substring(statenb + 4)
            textstate.Text = numero
            If textstate.Text = "" Then textstate.Text = 1
        Else
            textstate.Hide()
            Label9.Hide()
            textstate.Text = Nothing
        End If
    End Sub



    Private Sub GameLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GameLists.SelectedIndexChanged
        If GameLists.Items.Count = 0 Then
            prevplatform.Hide()
            nextplatform.Hide()
            Exit Sub
        ElseIf GameLists.SelectedIndex = 0 Then
            prevplatform.Hide()
            nextplatform.Show()
        ElseIf GameLists.SelectedIndex = GameLists.Items.Count - 1 Then
            prevplatform.Show()
            nextplatform.Hide()
        End If
    End Sub
    Private Sub prevplatform_Click(sender As Object, e As EventArgs) Handles prevplatform.Click
        Dim num As Integer = GameLists.SelectedIndex
        GameLists.ClearSelected()
        GameLists.SelectedIndex = num - 1
        ImportBoth1.PerformClick()
    End Sub
    Private Sub nextplatform_Click(sender As Object, e As EventArgs) Handles nextplatform.Click
        Dim num As Integer = GameLists.SelectedIndex
        GameLists.ClearSelected()
        GameLists.SelectedIndex = num + 1
        ImportBoth1.PerformClick()
    End Sub
End Class