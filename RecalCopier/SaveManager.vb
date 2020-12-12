Imports System.IO
Public Class SaveManager
    Private Sub SaveManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        GroupBox2.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
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

        'Width for columns
        DataGridRoms.RowHeadersWidth = 25
        DataGridRoms.Columns("Console").Width = 40
        DataGridRoms.Columns("Titre").Width = 205
        DataGridRoms.Columns("CheminRom").Width = 20
        DataGridRoms.Columns("NomdeRom").Width = 10
        DataGridRoms.Columns("CheminSave").Width = 50
        DataGridRoms.Columns("CocheSave").Width = 25

        'Hiding les colonnes
        DataGridRoms.Columns("CheminRom").Visible = False
        DataGridRoms.Columns("NomdeRom").Visible = False
        DataGridRoms.Columns("CheminSave").Visible = True

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, Titre asc"

        Dim compteurSave As Integer = 0
        'On remplit les Coches Saves
        Call CompletiondesSavesRoms()

        'On compte le nombre total d'entrées
        RomTotal.Text = DataGridRoms.Rows.Count - 1

        'on affiche les outils
        TextBox1.Show()
        GroupBox1.Show()
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
            Dim romnamesansext = FileNameWithoutExtension(DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("NomdeRom").Index).Value)
            Dim nomducfg As String = romname & ".*"
            Dim cheminsave As String = Replace(rompath, "\roms\", "\Saves\")
            Dim dossiersaveparent As String = Replace(dossierparent, "roms", "saves")
            Dim testcheminsave As String = Replace(cheminsave, romname, romnamesansext)
            Dim compteurfiles As Integer = 0
            Dim chemindufichier As String

            DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CheminSave").Index).Value = testcheminsave

            Dim dir As DirectoryInfo = New DirectoryInfo(dossiersaveparent)
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
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheSave").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheSave").Index).Value = False
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
            .ColumnName = "NomFichierCFG"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminCFG"
        End With
        table.Columns.Add(column)

        Dim chemincfgSave As String = Nothing

        'Loop for every gamelists
        For Each i In GameLists.SelectedItems
            Dim nomconsole As String = i
            Dim nbdansdossier = Directory.GetFiles(My.Settings.RecalboxFolder & "\Saves\" & nomconsole, "*.cfg").Count

            If nbdansdossier = 0 Then
                MsgBox("Pas d'Saves dans la console :" & nomconsole)
                Exit Sub
            End If

            Dim di As New IO.DirectoryInfo(My.Settings.RecalboxFolder & "\Saves\" & nomconsole)
            Dim aryFi As IO.FileInfo() = di.GetFiles("*.cfg")
            Dim fi As IO.FileInfo
            Dim nomfichiercfg As String
            Dim cheminducfg As String
            Dim pathdelarom As String

            For Each fi In aryFi
                If fi.Name = nomconsole & "_Save.cfg" Then GoTo fichiersuivant
                cheminducfg = fi.FullName
                nomfichiercfg = fi.Name
                pathdelarom = Replace(Replace(cheminducfg, "\Saves\", "\roms\"), ".cfg", "")

                'On va rechercher le nom de la rom
                Dim romname = Recherchenomdelarom(nomconsole, pathdelarom)

                'on ajoute au tableau
                table.Rows.Add(nomconsole, romname, nomfichiercfg, cheminducfg)

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
        DataGridSave.Columns("NomFichierCFG").Width = 140
        DataGridSave.Columns("CheminCFG").Width = 25

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

        'On va vérifier si les cfg sont liés à une rom
        For row = 0 To DataGridSave.Rows.Count - 2
            Dim cheminencours = DataGridSave.Rows(row).Cells(DataGridSave.Columns("CheminCFG").Index).Value
            Dim consolerom = DataGridSave.Rows(row).Cells(DataGridSave.Columns("Console").Index).Value

            'on va colorer la colonne des coches
            If DataGridSave.Rows(row).Cells(DataGridSave.Columns("NomRomXML").Index).Value = "#PASDANSXML#" Then
                DataGridSave.Rows(row).Cells(DataGridSave.Columns("CocheRom").Index).Value = False
                DataGridSave.Rows(row).Cells(DataGridSave.Columns("CocheRom").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
                'et du coup on va ajouter à la listbox des CFG
                Call FichiersCfgLies(cheminencours, consolerom)
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
        GroupBox2.Show()
    End Sub
    Function Recherchenomdelarom(console As String, pathdelarom As String)
        Dim lagamelist As String = My.Settings.RecalboxFolder & "\roms\" & console & "\gamelist.xml"
        Dim nomdelarom = Path.GetFileName(pathdelarom)


        'Si il n'existe pas de gamelist, on va mettre les infos generique
        If Not System.IO.File.Exists(lagamelist) Then
            Return "#NOGAMELIST#-" & nomdelarom
        End If

        Dim gamelistXml As XElement = XElement.Load(lagamelist)

        'getting the list for the xml with nodes
        Dim query2 = From st In gamelistXml.Descendants("game") Select st
        Dim genpathdelarom As String
        genpathdelarom = My.Settings.RecalboxFolder & "\roms\" & console & "\" & nomdelarom

        For Each xEle As XElement In query2
            Dim romname As String = xEle.Element("name")
            Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
            Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & console & "\" & temprom

            If console = nomdelarom Then
                Return "#CONSOLE#"
            End If

            If rompath = pathdelarom Then
                Return romname
                GoTo lignesuivante
            End If
lignesuivante:
        Next
        Return "#PASDANSXML#"
    End Function
    Sub FichiersCfgLies(cheminencours As String, consolerom As String)
        Dim cheminducfg As String = cheminencours
        Dim nomducfg As String = Path.GetFileName(cheminducfg)
        Dim gamelistassocie As String = My.Settings.RecalboxFolder & "\roms\" & consolerom & "\gamelist.xml"
        Dim genpathdelarom As String

        'Verification du cfg console
        If nomducfg = consolerom & ".cfg" Then
            Exit Sub
        End If

        genpathdelarom = My.Settings.RecalboxFolder & "\roms\" & consolerom & "\" & nomducfg
        'si on est arrivé ici, c'est que y'a pas de roms avec ce path donc on l'ajoute
        Dim genpathducfg As String = My.Settings.RecalboxFolder & "\Saves\" & consolerom & "\" & nomducfg
    End Sub

    Private Sub ButtonMenage_Click(sender As Object, e As EventArgs) Handles ButtonMenage1.Click
        If MsgBox("Etes vous sur de vouloir supprimer tous les fichiers dans la listbox rosée ci-contre ?", vbYesNo) = vbNo Then Exit Sub

        For i = 0 To ListdesFichiersEnTrop.Items.Count - 1
            Dim pathdufichier As String = ListdesFichiersEnTrop.Items(i)
            System.IO.File.Delete(pathdufichier)
        Next
        MsgBox("Fichiers Supprimés avec Succès")
    End Sub

    Private Sub ImportBoth_Click(sender As Object, e As EventArgs) Handles ImportBoth1.Click
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
End Class