Imports System.IO
Public Class OverlayManager
    Private Sub OverlayManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        GroupBox2.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        Call ImporterlesGamelists()
    End Sub
    Private Sub ButtonGetBack_Click(sender As Object, e As EventArgs) Handles ButtonGetBack.Click
        Form1.Show()
        Me.Close()
    End Sub
    Sub ImporterlesGamelists()
        'On Importe toutes les GameLists
        For Each foundDirectory In Directory.GetDirectories(My.Settings.RecalboxFolder & "\roms", ".", SearchOption.TopDirectoryOnly)
            If File.Exists(foundDirectory & "\gamelist.xml") Then
                GameLists.Items.Add(foundDirectory & "\gamelist.xml")
            End If
        Next

        'Test sur les dossiers Overlays
        For j = 0 To GameLists.Items.Count - 2
            'Dim console As String = GameLists.Items(j)
            'Dim chercheroms As String = InStr(console, "roms\",)
            'Dim finphrase As String = console.Substring((chercheroms + 4))
            'Dim detectedeuz As String = InStr(finphrase, "\gamelist.xml")
            'Dim findugame As String = finphrase.Substring(0, detectedeuz - 1)
            Dim nomconsole As String = GameLists.Items(j).Substring((InStr(GameLists.Items(j), "roms\",) + 4)).Substring(0, InStr(GameLists.Items(j).Substring((InStr(GameLists.Items(j), "roms\",) + 4)), "\gamelist.xml") - 1)

            Dim dossieroverlay = My.Settings.RecalboxFolder & "\overlays\" & nomconsole
            If (Not System.IO.Directory.Exists(dossieroverlay)) Then
                GameLists.Items.RemoveAt(j)
            End If
        Next


    End Sub
    Private Sub ButtonImportRoms_Click(sender As Object, e As EventArgs) Handles buttonImportRoms.Click
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

            Dim gamelistXml As XElement = XElement.Load(gamelist)

            'getting the list for the xml with nodes
            Dim query2 = From st In gamelistXml.Descendants("game") Select st

            For Each xEle As XElement In query2
                Dim romconsole As String = nomconsole
                Dim romname As String = xEle.Element("name")
                Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
                Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & nomconsole & "\" & temprom
                Dim romoverlays As String = Nothing
                Dim romhidden As String = xEle.Element("hidden")
                Dim romnomderom As String = Path.GetFileName(rompath)
                If romhidden = "true" Then GoTo romsuivante 'si la rom est hidden, on l'affiche pas (Roms multicd)

                'on ajoute le tout dans une table
                table.Rows.Add(romconsole, romname, rompath, romnomderom, romoverlays)
romsuivante:
            Next
        Next


        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridRoms.DataSource = table

        'On ajoute la checkbox pour les overlays
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        chk.HeaderText = "CocheOverlay"
        chk.Name = "CocheOverlay"
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
        Call completiondesoverlaysRoms()

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
            Dim cheminoverlay As String = Replace(rompath, "\roms\", "\overlays\")
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

    Private Sub ButtonImportOverlays_Click(sender As Object, e As EventArgs) Handles ButtonImportOverlays.Click
        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If GameLists.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner des Gamelists")
            Exit Sub
        End If

        'On clear par Securité
        DataGridOverlay.Columns.Clear()
        On Error Resume Next
        DataGridOverlay.Rows.Clear()
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

        Dim chemincfgoverlay As String = Nothing

        'Loop for every gamelists
        For Each i In GameLists.SelectedItems
            'Dim console As String = i
            'Dim chercheroms As String = InStr(Console, "roms\",)
            'Dim finphrase As String = Console.Substring((chercheroms + 4))
            'Dim detectedeuz As String = InStr(finphrase, "\gamelist.xml")
            'Dim findugame As String = finphrase.Substring(0, detectedeuz - 1)
            Dim nomconsole As String = i.Substring((InStr(i, "roms\",) + 4)).Substring(0, InStr(i.Substring((InStr(i, "roms\",) + 4)), "\gamelist.xml") - 1)
            Dim nbdansdossier = Directory.GetFiles(My.Settings.RecalboxFolder & "\overlays\" & nomconsole, "*.cfg").Count

            If nbdansdossier = 0 Then
                MsgBox("Pas d'Overlays dans la console :" & nomconsole)
                Exit Sub
            End If

            Dim di As New IO.DirectoryInfo(My.Settings.RecalboxFolder & "\overlays\" & nomconsole)
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
        Next
        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridOverlay.DataSource = table

        'Width for columns
        DataGridOverlay.RowHeadersWidth = 25
        DataGridOverlay.Columns("Console").Width = 40
        DataGridOverlay.Columns("NomRomXML").Width = 100
        DataGridOverlay.Columns("NomFichierCFG").Width = 150
        DataGridOverlay.Columns("CheminCFG").Width = 25

        Dim compteuroverlay As Integer = 0

        'on clear la listbox au cas ou
        ListToSupp.Items.Clear()

        'On ajoute la checkbox pour les overlays
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        chk.HeaderText = "CocheRom"
        chk.Name = "CocheRom"
        DataGridOverlay.Columns.Add(chk)
        DataGridOverlay.Columns("CocheRom").Width = 25

        'Si la liste est superieure à 1 alors on commence à ecrire tous les fichiers
        If ListToSupp.Items.Count > 0 Then
            Call Ecrireles3fichiers()
        Else
            ListToSupp.Items.Add("Pas d'overlays en trop detecté dans votre dossier :)")
        End If

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

        'On met la derniere colonne coche en readonly
        DataGridRoms.Columns("CocheOverlay").ReadOnly = True
        DataGridOverlay.Columns("CocheRom").ReadOnly = True


        'On compte le nombre total d'entrées
        OverlayTotal.Text = DataGridOverlay.Rows.Count - 1
        OverlaySingle.Text = ListdesFichiersEnTrop.Items.Count
        'on affiche les outils
        TextBox2.Show()
        GroupBox2.Show()
    End Sub
    Function Recherchenomdelarom(console As String, pathdelarom As String)
        Dim lagamelist As String = My.Settings.RecalboxFolder & "\roms\" & console & "\gamelist.xml"
        Dim nomdelarom = Path.GetFileName(pathdelarom)
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
        Dim genpathducfg As String = My.Settings.RecalboxFolder & "\overlays\" & consolerom & "\" & nomducfg
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

    Private Sub ButtonMenage_Click(sender As Object, e As EventArgs) Handles ButtonMenage.Click
        If MsgBox("Etes vous sur de vouloir supprimer tous les fichiers dans la listbox rosée ci-contre ?", vbNo) = vbNo Then Exit Sub

        For i = 0 To ListdesFichiersEnTrop.Items.Count - 1
            Dim pathdufichier As String = ListdesFichiersEnTrop.Items(i)
            System.IO.File.Delete(pathdufichier)
        Next
        MsgBox("Fichiers Supprimés avec Succès")
    End Sub

    Private Sub ImportBoth_Click(sender As Object, e As EventArgs) Handles ImportBoth.Click
        buttonImportRoms.PerformClick()
        ButtonImportOverlays.PerformClick()
    End Sub
    Sub LectureDesCfgs(consolerom As String, nomducfg As String)
        Dim modifgamelistenrom As String = nomducfg

        Dim fichier1cfg As String = My.Settings.RecalboxFolder & "\overlays\" & consolerom & "\" & modifgamelistenrom
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
                Dim chemindupng = t.Substring(detectoverlayzero + 19)
                Dim detectpng = InStr(chemindupng, "png")
                Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 2)
                Dim cheminpng = t.Substring(InStr(t, "overlay0_overlay") + 19).Substring(0, InStr(t.Substring(InStr(t, "overlay0_overlay") + 19), "png") + 2)
                fichier3png = Replace(cheminpropreoverlay2, justefichier2, cheminpng)
                Exit For
            End If
        Next

        'On ajoute ces 3 paths a la listbox des A Supprimer
        ListdesFichiersEnTrop.Items.Add(fichier1cfg)
        ListdesFichiersEnTrop.Items.Add(cheminpropreoverlay2)
        ListdesFichiersEnTrop.Items.Add(fichier3png)
    End Sub
End Class