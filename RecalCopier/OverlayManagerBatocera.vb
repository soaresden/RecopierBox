Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions
Public Class OverlayManagerBatocera

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

        Label9.Hide()
        GameLists.Hide()
        ImportBoth1.Hide()
        buttonImportRoms1.Hide()
        ButtonImportOverlays1.Hide()

        Call Completercombo()
        Call ImporterlesGamelists()
    End Sub
    Private Sub ButtonGetBack1_Click(sender As Object, e As EventArgs) Handles ButtonGetBack1.Click
        Form1.Show()
        Me.Close()
    End Sub
    Sub ImporterlesGamelists()
        'On Importe toutes les GameLists
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.RecalboxFolder & "\roms\", FileIO.SearchOption.SearchTopLevelOnly)
            GameLists.Items.Add(System.IO.Path.GetFileName(folder))
        Next
    End Sub
    Private Sub ButtonImportRoms_Click(sender As Object, e As EventArgs) Handles buttonImportRoms1.Click
        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If ListGamesFolder.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner des Gamelists")
            Exit Sub
        End If

        'On clear par Securité
        DataGridRoms.Columns.Clear()
        On Error Resume Next
        DataGridRoms.Rows.Clear()
        On Error GoTo 0

        If ListGamesFolder.Items.Count = 0 Then Exit Sub

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

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminPNG"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "CocheOverlay"
        End With
        table.Columns.Add(column)

        Dim compteuroverlay As Integer = 0

        'Loop for every gamelists
        For Each i In ListGamesFolder.SelectedItems

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
                Dim tempinfo As String = Path.GetFileName(FileNameWithoutExtension(rompath) & ".info")
                Dim cocheoverlay As Boolean
                Dim cheminpng As String


                'on va chercher si un .info existe
                'on teste si il y'a des occurences
                Dim dossierrom As String = My.Settings.DossierOverlay & ComboBox1.Text & "\games\" & console
                Dim di As New IO.DirectoryInfo(dossierrom)

                Dim nboccurences As Integer = di.GetFiles(tempinfo).Count
                If nboccurences = 0 Then
                    cocheoverlay = False
                    romoverlays = "0"
                    cheminpng = "0"
                Else
                    cocheoverlay = True
                    compteuroverlay = compteuroverlay + 1
                    Dim aryFi As IO.FileInfo() = di.GetFiles("*.info")
                    Dim fi As IO.FileInfo

                    For Each fi In aryFi
                        romoverlays = fi.FullName
                        If Path.GetFileName(romoverlays) = tempinfo Then
                            cheminpng = Replace(romoverlays, ".info", ".png")
                            GoTo suivant
                        End If
                    Next
                End If
suivant:
                If romhidden = "true" Then GoTo Romsuivante 'si la rom est hidden, on l'affiche pas (Roms multicd)

                'Test si l'image existe
                If Not System.IO.File.Exists(cheminpng) Then
                    cheminpng = "0"
                End If

                'on ajoute le tout dans une table
                table.Rows.Add(romconsole, romname, rompath, romnomderom, romoverlays, cheminpng, cocheoverlay)
Romsuivante:
            Next
ProchainGamelist:
        Next
        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridRoms.DataSource = table

        'Width for columns
        DataGridRoms.RowHeadersWidth = 25
        DataGridRoms.Columns("Console").Width = 50
        DataGridRoms.Columns("Titre").Width = 150
        DataGridRoms.Columns("CheminRom").Width = 20
        DataGridRoms.Columns("NomdeRom").Width = 10
        DataGridRoms.Columns("CheminOverlay").Width = 45
        DataGridRoms.Columns("CheminPNG").Width = 45
        DataGridRoms.Columns("CocheOverlay").Width = 25

        'Hiding les colonnes
        DataGridRoms.Columns("CheminRom").Visible = False
        DataGridRoms.Columns("NomdeRom").Visible = False
        DataGridRoms.Columns("CheminOverlay").Visible = True

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, Titre asc"

        'On compte le nombre total d'entrées
        RomTotal.Text = DataGridRoms.Rows.Count - 1
        RomTotalOverlay.Text = compteuroverlay
        'On colore
        Call Colorerlescoches()

        'on affiche les outils
        TextBox1.Show()
        GroupBox1.Show()
    End Sub
    Sub Completercombo()
        'On Importe les dossiers bezel
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.DossierOverlay, FileIO.SearchOption.SearchTopLevelOnly)
            ComboBox1.Items.Add(System.IO.Path.GetFileName(folder))
        Next
        If ComboBox1.Items.Count = 0 Then
            Exit Sub
        Else
            ComboBox1.SelectedIndex = 0
        End If
    End Sub

    Public Function FileNameWithoutExtension(ByVal FullPath _
    As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function
    Function CompletiondesoverlaysRoms(console As String, nomfichierrom As String)
        Dim compteuroverlay As Integer = 0
        Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & console & "\" & nomfichierrom
        Dim nomducfg As String = FileNameWithoutExtension(nomfichierrom) & ".info"
        Dim cheminoverlay As String = Replace(rompath, "\roms\" & console & "\", "\decorations\" & ComboBox1.Text & "\games\" & console & "\")
        Dim testcheminoverlay As String = Replace(cheminoverlay, nomfichierrom, nomducfg)

        Dim cocheoverlay As Boolean
        If System.IO.File.Exists(testcheminoverlay) Then
            cocheoverlay = True
            compteuroverlay += 1
        Else
            cocheoverlay = False
        End If

        Return (cocheoverlay, testcheminoverlay, compteuroverlay)
    End Function
    Sub Colorerlescoches()
        If DataGridRoms.Rows.Count > 1 Then
            For i = 0 To DataGridRoms.RowCount - 1
                If DataGridRoms.Rows(i).Cells(DataGridRoms.Columns("CocheOverlay").Index).Value = True Then
                    DataGridRoms.Rows(i).Cells(DataGridRoms.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
                Else
                    DataGridRoms.Rows(i).Cells(DataGridRoms.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
                End If
            Next
            'On met en ReadOnly les cases coches
            DataGridRoms.Columns("CocheOverlay").ReadOnly = True
        End If

        If DataGridOverlay.Rows.Count > 1 Then
            For i = 0 To DataGridOverlay.RowCount - 1
                If DataGridOverlay.Rows(i).Cells(DataGridOverlay.Columns("CocheOverlay").Index).Value = True Then
                    DataGridOverlay.Rows(i).Cells(DataGridOverlay.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
                Else
                    DataGridOverlay.Rows(i).Cells(DataGridOverlay.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
                End If
            Next
            'On met en ReadOnly les cases coches
            DataGridOverlay.Columns("CocheOverlay").ReadOnly = True
        End If
    End Sub

    Private Sub ButtonImportOverlays_Click(sender As Object, e As EventArgs) Handles ButtonImportOverlays1.Click
        'On clear par Securité
        DataGridOverlay.Columns.Clear()
        On Error Resume Next
        DataGridOverlay.Rows.Clear()
        On Error GoTo 0

        If ListGamesFolder.SelectedItems.Count = 0 Then Exit Sub

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

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminPNG"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "CocheOverlay"
        End With
        table.Columns.Add(column)

        Dim compteuroverlays As Integer = 0
        'Loop for every gamelists selected
        For Each i In ListGamesFolder.SelectedItems
            'generating the console name
            Dim console As String = i
            gamelist = My.Settings.RecalboxFolder & "\roms\" & i & "\gamelist.xml"

            Dim dia As New IO.DirectoryInfo(My.Settings.DossierOverlay & ComboBox1.Text & "\games\" & console)
            Dim aryFia As IO.FileInfo() = dia.GetFiles("*.info")
            Dim fia As IO.FileInfo
            Dim pathdelaromo As String

            For Each fia In aryFia
                Dim cheminducfg As String = fia.FullName
                Dim nomfichiercfg As String = fia.Name
                Dim results = recherchedansgamelist(console, nomfichiercfg)
                Dim romname = results.item1
                Dim rompath = results.item2

                'On va mettre la presence a 0 si as de rom associée
                Dim presenceoverlays As Boolean
                If romname = "#PASDANSXML#" Then
                    presenceoverlays = False
                    compteuroverlays = compteuroverlays + 1
                Else
                    presenceoverlays = True
                End If

                'test presence png
                Dim png As String = Replace(cheminducfg, ".info", ".png")
                If System.IO.File.Exists(png) Then
                Else
                    png = "0"
                End If
                'on ajoute l'overlay
                table.Rows.Add(console, romname, rompath, nomfichiercfg, cheminducfg, png, presenceoverlays)
            Next

ProchainGamelist:
        Next

        'Ici on a fini l'intégralité des gamelists selectionné. On va importer maintenant le dossier des generiques Systems
        Dim di As New IO.DirectoryInfo(My.Settings.DossierOverlay & ComboBox1.Text & "\systems")
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.info")
        Dim fi As IO.FileInfo
        Dim pathdelarom As String

        For Each fi In aryFi
            Dim cheminducfg As String = fi.FullName
            Dim nomfichiercfg As String = fi.Name
            Dim nomconsole As String = FileNameWithoutExtension(nomfichiercfg)
            Dim romname As String = "##CONSOLE##"
            Dim rompath As String = "##PASDEROMPATH##"
            Dim romnomderom As String = "##CONSOLE##"
            Dim presenceoverlays As Boolean = True

            'test presence png
            Dim png As String = Replace(cheminducfg, ".info", ".png")
            If System.IO.File.Exists(png) Then
            Else
                png = "0"
            End If
            'on ajoute l'overlay
            table.Rows.Add(nomconsole, romname, rompath, romnomderom, cheminducfg, png, presenceoverlays)
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridOverlay.DataSource = table

        'Width for columns
        DataGridOverlay.RowHeadersWidth = 25
        DataGridOverlay.Columns("Console").Width = 60
        DataGridOverlay.Columns("Titre").Width = 80
        DataGridOverlay.Columns("CheminRom").Width = 20
        DataGridOverlay.Columns("NomdeRom").Width = 150
        DataGridOverlay.Columns("CheminOverlay").Width = 65
        DataGridOverlay.Columns("CheminPNG").Width = 65
        DataGridOverlay.Columns("CocheOverlay").Width = 25

        'Hiding les colonnes
        DataGridOverlay.Columns("CheminRom").Visible = False
        DataGridOverlay.Columns("NomdeRom").Visible = True

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, Titre asc"

        'On colore les coches
        Call Colorerlescoches()

        'On compte le nombre total d'entrées
        OverlayTotal.Text = DataGridOverlay.Rows.Count - 1
        OverlaySingle.Text = compteuroverlays

        'on affiche les outils
        GroupBox2.Show()
        TextBox2.Show()
        ButtonSuppSave.Show()

    End Sub
    Function recherchedansgamelist(console As String, nomdufichierinfo As String)
        Dim lagamelist As String = My.Settings.RecalboxFolder & "\roms\" & console & "\gamelist.xml"

        'Si il n'existe pas de gamelist, on va mettre les infos generique
        If Not System.IO.File.Exists(lagamelist) Then
            Return ("#NOGAMELIST#-" & nomdufichierinfo, "#NOGAMELIST#-" & nomdufichierinfo)
        End If

        Dim gamelistXml As XElement = XElement.Load(lagamelist)

        'on cherche le vrai nom de la rom
        Dim dia As New IO.DirectoryInfo(My.Settings.RecalboxFolder & "\roms\" & console & "\")

        'on teste si il y'a des occurences
        Dim nboccurences As Integer = dia.GetFiles(FileNameWithoutExtension(nomdufichierinfo) & ".*").Count
        If nboccurences = 0 Then
            Return ("#PASDANSXML#", "#PASDANSXML")
        End If

        Dim aryFia As IO.FileInfo() = dia.GetFiles(FileNameWithoutExtension(nomdufichierinfo) & ".*")
        Dim fia As IO.FileInfo

        Dim nomdufichier As String
        For Each fia In aryFia
            nomdufichier = Path.GetFileName(fia.FullName)
        Next


        'getting the list for the xml with nodes
        Dim query2 = From st In gamelistXml.Descendants("game") Select st

        For Each xEle As XElement In query2
            Dim romname As String = xEle.Element("name")
            Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
            Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & console & "\" & temprom


            'Si dans le rompath en cours il y'a un bout du nom du fichier alors on retourne les infos
            If InStr(rompath, nomdufichier) > 1 Then
                Return (romname, rompath)
                GoTo lignesuivante
            End If
lignesuivante:
        Next
        Return ("#PASDANSXML#", "#PASDANSXML#")
    End Function

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
    Private Sub ButtonMenage_Click(sender As Object, e As EventArgs) Handles ButtonMenage1.Click
        If MsgBox("Etes vous sur de vouloir supprimer tous les fichiers Orphelins (en rouge) du tableau ?", vbYesNo) = vbNo Then Exit Sub
        Dim compteur As Integer = 0

        'On delete les fichiers
        For i = 0 To DataGridOverlay.Rows.Count - 1
            If DataGridOverlay.Rows(i).Cells(DataGridOverlay.Columns("CocheOverlay").Index).Value = False Then
                Dim fichierinfo = DataGridOverlay.Rows(i).Cells(DataGridOverlay.Columns("CheminOverlay").Index).Value
                Dim fichierpng = DataGridOverlay.Rows(i).Cells(DataGridOverlay.Columns("CheminPNG").Index).Value

                On Error Resume Next
                System.IO.File.Delete(fichierinfo)
                System.IO.File.Delete(fichierpng)
                compteur += 1
                On Error GoTo 0
            End If
        Next
        MsgBox(compteur * 2 & " fichiers Supprimés avec Succès")

        ButtonImportOverlays1.PerformClick()
    End Sub

    Private Sub ImportBoth_Click(sender As Object, e As EventArgs) Handles ImportBoth1.Click
        buttonImportRoms1.PerformClick()
        ButtonImportOverlays1.PerformClick()
    End Sub
    Private Sub DataGridRoms_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridRoms.SelectionChanged
        Dim actualrow As Integer = DataGridRoms.CurrentRow.Index
        If actualrow >= DataGridRoms.RowCount - 1 Then Exit Sub
        Dim nomdufichier As String = DataGridRoms.Rows(actualrow).Cells(2).Value
        NewName.Text = Path.GetFileName(nomdufichier) & ".info"
    End Sub

    Private Sub DataGridOverlay_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridOverlay.SelectionChanged
        'on met le total selectionné dans la textbox
        nbselected.Text = DataGridOverlay.SelectedRows.Count

        Dim actualrow As Integer = DataGridOverlay.CurrentRow.Index
        If actualrow >= DataGridOverlay.RowCount - 1 Then Exit Sub
        Dim nomdufichier As String = DataGridOverlay.Rows(actualrow).Cells(DataGridOverlay.Columns("NomdeRom").Index).Value
        Dim pathinfo As String = DataGridOverlay.Rows(actualrow).Cells(DataGridOverlay.Columns("CheminOverlay").Index).Value
        'Si plus de Deux on affiche rien 
        If nbselected.Text > 1 Then
            ActualName.Text = Nothing
            actualpath.Text = Nothing
        Else
            ActualName.Text = Path.GetFileName(nomdufichier)
            actualpath.Text = pathinfo
            NewName.SelectAll()
            NewName.Focus()
        End If
    End Sub

    Private Sub ButtonRenameSave_Click(sender As Object, e As EventArgs) Handles ButtonRenameSave.Click
        If NewName.Text = Nothing Or NewName.Text = ActualName.Text Then
            MsgBox("Aucun nom de fichier Saisi")
            Exit Sub
        End If

        'On detecte si y'a une extension.
        Dim newextension As String = Path.GetExtension(NewName.Text)

        'Si .blablablabla a moins de 8 caracteres, c'est que c'est une vraie extension (.scummvm ?). Donc ca veut dire que c'est une extension qui est saisie
        If newextension = ".info" Then
        Else
            NewName.Text = NewName.Text & ".info"
        End If

        'On prends l'extension attendue
        Dim finaladresse As String = Replace(actualpath.Text, ActualName.Text, NewName.Text)

        'Test si le fichier overlay déjà 
        If System.IO.File.Exists(finaladresse) Then
            MsgBox("Impossible de renommer ce fichier" & Chr(10) & "Un Overlay existe déjà avec ce nom")
            Exit Sub
        End If

        If MsgBox("Vous allez changer le nom de l'Overlay : " & Chr(10) & Chr(10) & ActualName.Text & Chr(10) & Chr(10) & "pour : " & Chr(10) & Chr(10) & NewName.Text & Chr(10) & Chr(10) & "Confirmer ?", vbYesNo) = vbNo Then Exit Sub
        'On va devoir renommer dans les fichiers texte puis déplacer le tout
        Dim fichieractuel As String = actualpath.Text
        Dim fichierfinal1 As String = Replace(fichieractuel, ActualName.Text, NewName.Text)
        Dim fichieractuelpng As String = Replace(actualpath.Text, ".info", ".png")
        Dim fichierfinalpng As String = Replace(fichieractuelpng, Replace(ActualName.Text, ".info", ".png"), Replace(NewName.Text, ".info", ".png"))

        File.Move(fichieractuel, fichierfinal1)
        File.Move(fichieractuelpng, fichierfinalpng)

        'on refresh le tout
        ActualName.Text = Path.GetFileName(fichierfinal1)
        NewName.Text = ActualName.Text
        ImportBoth1.PerformClick()
    End Sub
    Function Convertendecimal(ligne As String)
        Dim resultats = Regex.Replace(ligne, "[^-?\d+\.]", "")
        Return resultats
    End Function
    Private Sub ButtonSuppSave_Click(sender As Object, e As EventArgs) Handles ButtonSuppSave.Click
        If MsgBox("Etes vous sur de supprimer les fichiers selectionnés dans le tableau ci dessus ?" & Chr(10) & "Oui = Supprimer tous les fichiers *.info + *.png", vbYesNo) = vbNo Then Exit Sub

        For Each item In DataGridOverlay.SelectedRows
            Dim ligneencours = Convertendecimal(item.ToString)
            Dim png = DataGridOverlay.Rows(ligneencours).Cells(DataGridOverlay.Columns("CheminPNG").Index).Value
            Dim info = DataGridOverlay.Rows(ligneencours).Cells(DataGridOverlay.Columns("CheminOverlay").Index).Value
            templisttosupp.Items.Add(png)
            templisttosupp.Items.Add(info)
        Next

        For i = 0 To templisttosupp.Items.Count - 1
            Dim fichiertosupp = templisttosupp.Items(i).ToString
            Dim realindex As Integer = templisttosupp.Items.IndexOf(templisttosupp.Items(i))
            System.IO.File.Delete(templisttosupp.Items(i))
        Next
        'on remove les entrees
        templisttosupp.Items.Clear()

        MsgBox("Fichiers Supprimés")

        ButtonImportOverlays1.PerformClick()
    End Sub
    Private Sub ButtonResizeOverlays_Click(sender As Object, e As EventArgs) Handles ButtonResizeOverlays.Click
        ResizeOverlaysBato.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        OverlaysConverter.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ListGamesFolder.Items.Clear()
        'On complete la listbox avec les dossiers de games
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.DossierOverlay & ComboBox1.Text & "\games\", FileIO.SearchOption.SearchTopLevelOnly)
            ListGamesFolder.Items.Add(System.IO.Path.GetFileName(folder))
        Next
    End Sub

    Private Sub ListGamesFolder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListGamesFolder.SelectedIndexChanged
        If ListGamesFolder.SelectedItems.Count = 0 Then
            ImportBoth1.Hide()
            buttonImportRoms1.Hide()
            ButtonImportOverlays1.Hide()
            Label9.Hide()
            GameLists.Hide()
        Else
            ImportBoth1.Show()
            buttonImportRoms1.Show()
            ButtonImportOverlays1.Show()
            Label9.Show()
            GameLists.Show()
        End If
    End Sub

    Private Sub DataGridOverlay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOverlay.CellContentClick
        Dim numcolonne = e.ColumnIndex
        Dim numligne = e.RowIndex

        If numcolonne < 2 Then Exit Sub

        Dim fichiercomplet = DataGridOverlay.Rows(numligne).Cells(numcolonne).Value

        If DataGridOverlay.Rows(numligne).Cells(numcolonne).Value = "0" Then
            Exit Sub
        Else
            If File.Exists(fichiercomplet) = True Then
                Process.Start(fichiercomplet)
            Else
                Exit Sub
            End If

        End If
    End Sub

    Private Sub DataGridRoms_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRoms.CellContentClick
        Dim numcolonne = e.ColumnIndex
        Dim numligne = e.RowIndex

        If numcolonne < 3 Then Exit Sub

        Dim fichiercomplet = DataGridRoms.Rows(numligne).Cells(numcolonne).Value

        If DataGridRoms.Rows(numligne).Cells(numcolonne).Value = "0" Then
            Exit Sub
        Else
            Process.Start(fichiercomplet)
        End If
    End Sub

    Private Sub DataGridOverlay_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOverlay.CellDoubleClick
        Dim numcolonne = e.ColumnIndex
        Dim numligne = e.RowIndex

        If numcolonne < 4 Then Exit Sub

        Dim fichiercomplet = DataGridOverlay.Rows(numligne).Cells(numcolonne).Value

        If DataGridOverlay.Rows(numligne).Cells(numcolonne).Value = "0" Then
            Exit Sub
        Else
            Process.Start(fichiercomplet)
        End If
    End Sub
    Private Sub OverlayManager_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Form1.Show()
    End Sub
End Class
