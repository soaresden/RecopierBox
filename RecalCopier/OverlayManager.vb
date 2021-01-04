Imports System.IO
Public Class OverlayManager

    Private Sub OverlayManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelChoice.Show()
        PanelChoice.Location = New Point(3, 39)
        PanelChoice.Size = New Point(971, 553)
        ImportBoth1.Hide()
        RichTextBox1.Hide()
    End Sub
    Private Sub ButtonShowOverlayManager_Click(sender As Object, e As EventArgs) Handles ButtonShowOverlayManager.Click
        PanelChoice.Hide()
        ImportBoth1.Show()
        RichTextBox1.Show()
        Call beginning()
    End Sub
    Sub beginning()
        GroupBox1.Hide()
        GroupBox2.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        ButtonSuppSave.Hide()

        Label7.Hide()
        ListToSupp.Hide()
        Label8.Hide()
        ListdesFichiersEnTrop.Hide()

        Call ImporterlesGamelists()
    End Sub
    Private Sub ButtonGetBack1_Click(sender As Object, e As EventArgs) Handles ButtonGetBack1.Click
        Form1.Show()
        Me.Close()
    End Sub
    Sub ImporterlesGamelists()
        'On Importe toutes les GameLists
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.DossierOverlay, FileIO.SearchOption.SearchTopLevelOnly)
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
            .ColumnName = "CheminOverlay"
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
                Dim romoverlays As String = Nothing
                Dim romhidden As String = xEle.Element("hidden")
                Dim romnomderom As String = Path.GetFileName(rompath)
                If romhidden = "true" Then GoTo Romsuivante 'si la rom est hidden, on l'affiche pas (Roms multicd)

                'on ajoute le tout dans une table
                table.Rows.Add(romconsole, romname, rompath, romnomderom, romoverlays)
Romsuivante:
            Next
ProchainGamelist:
        Next
        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridRoms.DataSource = table

        'On ajoute la checkbox pour les overlays
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn With {
    .HeaderText = "CocheOverlay",
    .Name = "CocheOverlay"
}
        DataGridRoms.Columns.Add(chk)

        'Width for columns
        DataGridRoms.RowHeadersWidth = 25
        DataGridRoms.Columns("Console").Width = 40
        DataGridRoms.Columns("Titre").Width = 205
        DataGridRoms.Columns("CheminRom").Width = 20
        DataGridRoms.Columns("NomdeRom").Width = 10
        DataGridRoms.Columns("CheminOverlay").Width = 50
        DataGridRoms.Columns("CocheOverlay").Width = 25

        'Hiding les colonnes
        DataGridRoms.Columns("CheminRom").Visible = False
        DataGridRoms.Columns("NomdeRom").Visible = False
        DataGridRoms.Columns("CheminOverlay").Visible = True

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, Titre asc"

        Dim compteuroverlay As Integer = 0
        'On remplit les Coches Overlays
        Call CompletiondesoverlaysRoms()

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
    Sub CompletiondesoverlaysRoms()
        Dim compteuroverlay As Integer = 0
        For ligne = 0 To DataGridRoms.RowCount - 2
            Dim rompath = DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CheminRom").Index).Value
            Dim romname = DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("NomdeRom").Index).Value
            Dim nomducfg As String = romname & ".cfg"
            Dim cheminoverlay As String


            cheminoverlay = Replace(rompath, "\roms\", "\overlays\")

            Dim testcheminoverlay As String = Replace(cheminoverlay, romname, nomducfg)

            DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CheminOverlay").Index).Value = testcheminoverlay

            If System.IO.File.Exists(testcheminoverlay) Then
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheOverlay").Index).Value = True
                compteuroverlay += 1
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheOverlay").Index).Value = False
                DataGridRoms.Rows(ligne).Cells(DataGridRoms.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If
        Next
        RomTotalOverlay.Text = compteuroverlay
    End Sub

    Private Sub ButtonImportOverlays_Click(sender As Object, e As EventArgs) Handles ButtonImportOverlays1.Click
        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If GameLists.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        'On clear par Securité
        DataGridOverlay.Columns.Clear()
        On Error Resume Next
        DataGridOverlay.Rows.Clear()
        On Error GoTo 0

        'on clear les listboxes au cas ou
        ListToSupp.Items.Clear()
        ListdesFichiersEnTrop.Items.Clear()

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

        Dim chemincfgoverlay As String = Nothing

        'Loop for every gamelists
        For Each i In GameLists.SelectedItems
            Dim nomconsole As String = i
            Dim nbdansdossier As Integer


            nbdansdossier = Directory.GetFiles(My.Settings.RecalboxFolder & "\overlays\" & nomconsole, "*.cfg").Count


                If nbdansdossier = 0 Then
                GoTo nextconsole
            End If

            Dim di As New IO.DirectoryInfo(My.Settings.DossierOverlay & nomconsole)
            Dim aryFi As IO.FileInfo() = di.GetFiles("*.cfg")
            Dim fi As IO.FileInfo
            Dim nomfichiercfg As String
            Dim cheminducfg As String
            Dim pathdelarom As String

            For Each fi In aryFi
                If fi.Name = nomconsole & "_overlay.cfg" Then GoTo fichiersuivant
                cheminducfg = fi.FullName
                nomfichiercfg = fi.Name

                pathdelarom = Replace(Replace(cheminducfg, "\overlays\", "\roms\"), ".cfg", "")


                    'On va rechercher le nom de la rom
                    Dim romname = Recherchenomdelarom(nomconsole, pathdelarom)

                'on ajoute au tableau
                table.Rows.Add(nomconsole, romname, nomfichiercfg, cheminducfg)

fichiersuivant:
            Next
nextconsole:
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridOverlay.DataSource = table

        'Width for columns
        DataGridOverlay.RowHeadersWidth = 25
        DataGridOverlay.Columns("Console").Width = 40
        DataGridOverlay.Columns("NomRomXML").Width = 130
        DataGridOverlay.Columns("NomFichierCFG").Width = 190
        DataGridOverlay.Columns("CheminCFG").Width = 45

        Dim compteuroverlay As Integer = 0

        'On ajoute la checkbox pour les overlays
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn With {
            .HeaderText = "CocheRom",
            .Name = "CocheRom"
        }
        DataGridOverlay.Columns.Add(chk)
        DataGridOverlay.Columns("CocheRom").Width = 25

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, NomRomXML asc"

        'On va vérifier si les cfg sont liés à une rom
        For row = 0 To DataGridOverlay.Rows.Count - 2
            Dim cheminencours = DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("CheminCFG").Index).Value
            Dim consolerom = DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("Console").Index).Value

            'on va colorer la colonne des coches
            If DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("NomRomXML").Index).Value = "#PASDANSXML#" Then
                DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("CocheRom").Index).Value = False
                DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("CocheRom").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
                'et du coup on va ajouter à la listbox des CFG
                Call FichiersCfgLies(cheminencours, consolerom)
            Else
                DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("CocheRom").Index).Value = True
                DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("CocheRom").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            End If
        Next

        'Si la liste est superieure à 1 alors on commence à ecrire tous les fichiers
        If ListToSupp.Items.Count > 0 Then
            Call Ecrireles3fichiers()
        Else
            ListToSupp.Items.Add("0 overlays en trop detecté dans votre dossier :)")
        End If

        'On met la derniere colonne coche en readonly
        DataGridOverlay.Columns("CocheRom").ReadOnly = True

        'On compte le nombre total d'entrées
        OverlayTotal.Text = DataGridOverlay.Rows.Count - 1
        OverlaySingle.Text = ListdesFichiersEnTrop.Items.Count
        'on affiche les outils
        TextBox2.Show()
        GroupBox2.Show()
        ButtonSuppSave.Show()
        Label7.Show()
        ListToSupp.Show()
        Label8.Show()
        ListdesFichiersEnTrop.Show()

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
        Dim genpathducfg As String


        genpathducfg = My.Settings.RecalboxFolder & "\overlays\" & consolerom & "\" & nomducfg



            ListToSupp.Items.Add(genpathducfg)
    End Sub

    Sub Ecrireles3fichiers()
        For i = 0 To ListToSupp.Items.Count - 1
            'Dim console As String = ListToSupp.Items(i)
            'Dim chercheroms As String = InStr(console, "overlays\",)
            'Dim finphrase As String = console.Substring((chercheroms + 8))
            'Dim detectedeuz As String = InStr(finphrase, "\")
            'Dim findugame As String = finphrase.Substring(0, detectedeuz - 1)

            Dim consolename As String = ListToSupp.Items(i).Substring((InStr(ListToSupp.Items(i), "overlays\",) + 8)).Substring(0, InStr(ListToSupp.Items(i).Substring((InStr(ListToSupp.Items(i), "overlays\",) + 8)), "\") - 1)
            Dim romnamecfg = Path.GetFileName(ListToSupp.Items(i))

            Call LectureDesCfgs(consolename, romnamecfg)
        Next
    End Sub

    Private Sub ButtonMenage_Click(sender As Object, e As EventArgs) Handles ButtonMenage1.Click
        If MsgBox("Etes vous sur de vouloir supprimer tous les fichiers dans la listbox rosée ci-dessus ?", vbYesNo) = vbNo Then Exit Sub

        For i = 0 To ListdesFichiersEnTrop.Items.Count - 1
            Dim pathdufichier As String = ListdesFichiersEnTrop.Items(i)
            System.IO.File.Delete(pathdufichier)
        Next
        MsgBox("Fichiers Supprimés avec Succès")
    End Sub

    Private Sub ImportBoth_Click(sender As Object, e As EventArgs) Handles ImportBoth1.Click
        buttonImportRoms1.PerformClick()
        ButtonImportOverlays1.PerformClick()
    End Sub
    Sub LectureDesCfgs(consolerom As String, nomducfg As String)
        Dim modifgamelistenrom As String = nomducfg

        Dim fichier1cfg As String = My.Settings.DossierOverlay & consolerom & "\" & modifgamelistenrom
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
        'On ajoute a la listbox
        ListdesFichiersEnTrop.Items.Add(fichier1cfg)

        For Each s In readText
            Dim detectinputoverlay As String

            detectinputoverlay = InStr(s, "/overlays/")


                If detectinputoverlay > 0 Then
                'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)

                Dim chemincfgoverlaydanscfg As String
                chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                cheminpropreoverlay2 = My.Settings.DossierOverlay & Replace(chemincfgoverlaydanscfg, "/", "\")
                justefichier2 = FileNameWithoutExtension(cheminpropreoverlay2) & ".cfg"
                Exit For
            End If
        Next

        'on lit le deuxieme fichier overlay cfg pour trouver le png
        If Not File.Exists(cheminpropreoverlay2) Then Exit Sub
        File.ReadAllLines(cheminpropreoverlay2)
        'On ajoute a la listbox
        ListdesFichiersEnTrop.Items.Add(cheminpropreoverlay2)

        Dim readText2() As String = File.ReadAllLines(cheminpropreoverlay2)
        Dim t As String

        For Each t In readText2
            Dim detectoverlayzero As String = InStr(t, "overlay0_overlay")
            If detectoverlayzero > 0 Then
                Dim chemindupng = t.Substring(detectoverlayzero + 19)
                Dim detectpng = InStr(chemindupng, "png")
                Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 2)
                Dim cheminpng = t.Substring(InStr(t, "overlay0_overlay") + 19).Substring(0, InStr(t.Substring(InStr(t, "overlay0_overlay") + 19), "png") + 2)
                fichier3png = Replace(cheminpropreoverlay2, justefichier2, cheminpng)
                Exit For
            End If
        Next
        'on ajoute a la listbox
        ListdesFichiersEnTrop.Items.Add(fichier3png)


    End Sub

    Private Sub DataGridRoms_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridRoms.SelectionChanged
        Dim actualrow As Integer = DataGridRoms.CurrentRow.Index
        If actualrow >= DataGridRoms.RowCount - 1 Then Exit Sub
        Dim nomdufichier As String = DataGridRoms.Rows(actualrow).Cells(2).Value
        NewName.Text = Path.GetFileName(nomdufichier) & ".cfg"
    End Sub

    Private Sub DataGridOverlay_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridOverlay.SelectionChanged
        Dim actualrow As Integer = DataGridOverlay.CurrentRow.Index
        If actualrow >= DataGridOverlay.RowCount - 1 Then Exit Sub
        Dim nomdufichier As String = DataGridOverlay.Rows(actualrow).Cells(2).Value
        ActualName.Text = Path.GetFileName(nomdufichier)
    End Sub

    Private Sub ListdesFichiersEnTrop_DoubleClick(sender As Object, e As EventArgs) Handles ListdesFichiersEnTrop.DoubleClick
        If ListdesFichiersEnTrop.SelectedItems.Count = 1 Then
            Process.Start(ListdesFichiersEnTrop.SelectedItem)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ListToSupp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListToSupp.SelectedIndexChanged

        'on va changer le actual name
        If ListToSupp.SelectedItems.Count = 0 Or ListToSupp.SelectedItem.ToString = "0 overlays en trop detecté dans votre dossier :)" Or ListToSupp.SelectedItem.ToString = Nothing Then
            Exit Sub
        ElseIf ListToSupp.SelectedItems.Count = 1 Then
            ActualName.Text = Path.GetFileName(ListToSupp.SelectedItem)
        End If

        Dim fichier1 As String = ListToSupp.SelectedItem
        Dim fichier2 As String = Nothing
        Dim fichier3 As String = Nothing

        Dim cheminpropreoverlay2 As String = Nothing
        Dim justefichier2 As String = Nothing
        Dim fichier3png As String = Nothing

        'Generate the 3 files
        Dim console As String = fichier1


        ' console = fichier1.Substring(InStr(fichier1, "\overlays\") + 9)
        '  Dim suite As String = InStr(console, "\")
        ' Dim donc As String = console.Substring(0, suite - 1)
        Dim consoleencourrs As String = fichier1.Substring(InStr(fichier1, "\overlays\") + 9).Substring(0, InStr(fichier1.Substring(InStr(fichier1, "\overlays\") + 9), "\") - 1)

        'on va lire le cfg pour trouver le cfg overlay
        File.ReadAllLines(fichier1)

        Dim readText() As String = File.ReadAllLines(fichier1)
        Dim s As String
        For Each s In readText
            Dim detectinputoverlay As String

            detectinputoverlay = InStr(s, "/overlays/")


                If detectinputoverlay > 0 Then
                'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)

                Dim chemincfgoverlaydanscfg As String

                chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                fichier2 = My.Settings.DossierOverlay & Replace(chemincfgoverlaydanscfg, "/", "\")
                Exit For
            End If
        Next

        'on lit le deuxieme fichier overlay cfg pour trouver le png
        If Not File.Exists(fichier2) Then GoTo skip
        File.ReadAllLines(fichier2)
        Dim readText2() As String = File.ReadAllLines(fichier2)
        Dim t As String

        For Each t In readText2
            Dim detectoverlayzero As String = InStr(t, "overlay0_overlay")
            If detectoverlayzero > 0 Then
                Dim chemindupng = t.Substring(detectoverlayzero + 19)
                Dim detectpng = InStr(chemindupng, "png")
                Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 2)
                Dim cheminpng = t.Substring(InStr(t, "overlay0_overlay") + 19).Substring(0, InStr(t.Substring(InStr(t, "overlay0_overlay") + 19), "png") + 2)
                fichier3 = Replace(fichier2, Path.GetFileName(fichier2), cheminpng)
                Exit For
            End If
        Next

skip:
        'on a les 3 fichiers, on cherche leur emplacement
        Dim fich1 As Integer = ListdesFichiersEnTrop.Items.IndexOf(fichier1)
        Dim fich2 As Integer = ListdesFichiersEnTrop.Items.IndexOf(fichier2)
        Dim fich3 As Integer = ListdesFichiersEnTrop.Items.IndexOf(fichier3)

        ListdesFichiersEnTrop.ClearSelected()
        ListdesFichiersEnTrop.SetSelected(fich1, True)
        ListdesFichiersEnTrop.SetSelected(fich2, True)
        ListdesFichiersEnTrop.SetSelected(fich3, True)
    End Sub

    Private Sub ButtonRenameSave_Click(sender As Object, e As EventArgs) Handles ButtonRenameSave.Click
        If NewName.Text = Nothing Or NewName.Text = ActualName.Text Then
            MsgBox("Aucun nom de fichier Saisi")
            Exit Sub
        End If

        'On detecte si y'a une extension.
        Dim newextension As String = Path.GetExtension(NewName.Text)

        'Si .blablablabla a moins de 8 caracteres, c'est que c'est une vraie extension (.scummvm ?). Donc ca veut dire que c'est une extension qui est saisie
        If newextension = ".cfg" Then
        Else
            NewName.Text = NewName.Text & ".cfg"
        End If

        'On prends l'extension attendue
        Dim finaladresse As String = Replace(ListToSupp.SelectedItem.ToString, ActualName.Text, NewName.Text)

        'Test si le fichier overlay déjà 
        If System.IO.File.Exists(finaladresse) Then
            MsgBox("Impossible de renommer ce fichier" & Chr(13) & "Un Overlay existe déjà avec ce nom")
            Exit Sub
        End If

        If MsgBox("Vous allez changer le nom de l'Overlay : " & Chr(13) & Chr(13) & ActualName.Text & Chr(13) & Chr(13) & "pour : " & Chr(13) & Chr(13) & NewName.Text & Chr(13) & Chr(13) & "Confirmer ?", vbYesNo) = vbNo Then Exit Sub

        'On va devoir renommer dans les fichiers texte puis déplacer le tout
        Dim fichieractuel As String = ListdesFichiersEnTrop.SelectedItem
        Dim fichierfinal1 As String = Replace(fichieractuel, ActualName.Text, NewName.Text)

        File.Move(fichieractuel, fichierfinal1)

        'on refresh le tout
        ActualName.Text = Path.GetFileName(fichierfinal1)
        NewName.Text = ActualName.Text

        ButtonImportOverlays1.PerformClick()

        'On enleve les doublons
        Supdoublon(ListdesFichiersEnTrop)
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

    Private Sub ButtonSuppSave_Click(sender As Object, e As EventArgs) Handles ButtonSuppSave.Click
        If MsgBox("Etes vous sur de supprimer les fichiers présents dans la liste en rouge ci dessous selectionnés ?" & Chr(13) & "Oui = Supprimer tous les fichiers CFG + _overlay + .png", vbYesNo) = vbNo Then Exit Sub

        templisttosupp.ClearSelected()

        For Each item In ListToSupp.SelectedItems
            templisttosupp.Items.Add(item)
        Next

        For i = 0 To templisttosupp.Items.Count - 1
            Dim fichiertosupp = templisttosupp.Items(i).ToString
            Dim realindex As Integer = ListToSupp.Items.IndexOf(templisttosupp.Items(i))
            ListToSupp.ClearSelected()
            ListToSupp.SetSelected(realindex, True)

            'Maintenant c'est selectionné on va les delete

            For Each j In ListToSupp.SelectedItems
                System.IO.File.Delete(j)
            Next

            'on remove les entrees
            For n As Integer = ListToSupp.SelectedItems.Count - 1 To 0 Step -1
                ListToSupp.Items.Remove(ListToSupp.SelectedItems(n))
            Next n

        Next

        'On enleve les doublons
        Supdoublon(ListToSupp)

    End Sub

    Private Sub ButtonResizeOverlays_Click(sender As Object, e As EventArgs) Handles ButtonResizeOverlays.Click
        ResizeOverlays.Show()
        Me.Close()
    End Sub

    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        OverlaysConverter.Show()
        Me.Close()
    End Sub
End Class