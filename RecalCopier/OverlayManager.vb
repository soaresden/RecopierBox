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
        DataGridRoms.Columns("Console").Width = 40
        DataGridRoms.Columns("Titre").Width = 190
        DataGridRoms.Columns("CheminRom").Width = 10
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
            .ColumnName = "TitreRom Overlay"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "NomRom"
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

            Dim di As New IO.DirectoryInfo(My.Settings.RecalboxFolder & "\overlays\" & nomconsole)
            Dim aryFi As IO.FileInfo() = di.GetFiles("*.cfg")
            Dim fi As IO.FileInfo
            Dim nomducfg As String
            Dim romnomderom As String
            Dim cheminducfg As String


            For Each fi In aryFi
                If fi.Name = nomconsole & "_overlay.cfg" Then GoTo fichiersuivant
                cheminducfg = fi.FullName
                table.Rows.Add(nomconsole, Nothing, Nothing, cheminducfg)
fichiersuivant:
            Next
        Next
        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridOverlay.DataSource = table

        'On ajoute la checkbox pour les overlays
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn
        chk.HeaderText = "CocheRom"
        chk.Name = "CocheRom"
        DataGridOverlay.Columns.Add(chk)

        'Width for columns
        DataGridOverlay.Columns("Console").Width = 40
        DataGridOverlay.Columns("TitreRom Overlay").Width = 170
        DataGridOverlay.Columns("NomRom").Width = 10
        DataGridOverlay.Columns("CheminCFG").Width = 70
        DataGridOverlay.Columns("CocheRom").Width = 25

        DataGridOverlay.Columns("NomRom").Visible = False

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, TitreRom Overlay asc"

        Dim compteuroverlay As Integer = 0

        'on clear la listbox au cas ou
        ListToSupp.Items.Clear()

        'On va vérifier si les cfg sont liés à une rom
        For row = 0 To DataGridOverlay.Rows.Count - 2
            Dim cheminencours = DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("CheminCFG").Index).Value
            Dim consolerom = DataGridOverlay.Rows(row).Cells(DataGridOverlay.Columns("Console").Index).Value

            'et du coup on va ajouter à la listbox des CFG
            Call FichiersCfgLies(cheminencours, consolerom)

        Next

        'Si la liste est superieure à 1 alors on commence à ecrire tous les fichiers
        If ListToSupp.Items.Count > 0 Then Call Ecrireles3fichiers()


        'On alimente les cellules du Titre
        For lignass = 0 To DataGridOverlay.Rows.Count - 2
            Dim consoleencours = DataGridOverlay.Rows(lignass).Cells(DataGridOverlay.Columns("Console").Index).Value
            Dim gamelistgen As String = My.Settings.RecalboxFolder & "\roms\" & consoleencours & "\gamelist.xml"
            Dim gamelistXml As XElement = XElement.Load(gamelistgen)


            Dim valeurcell As String = DataGridOverlay.Rows(lignass).Cells(DataGridOverlay.Columns("CheminCFG").Index).Value
            Dim nomdufichiersanscfg As String = Replace(Path.GetFileName(valeurcell), ".cfg", "")

            If nomdufichiersanscfg = consoleencours Then
                DataGridOverlay.Rows(lignass).Cells(DataGridOverlay.Columns("TitreRom Overlay").Index).Value = "OVERLAY CONSOLE"
                GoTo lignesuivante
            End If

            Dim queryy = From st In gamelistXml.Descendants("game") Select st
            Dim cheminromcomplet As String = Replace(Replace(valeurcell, ".cfg", ""), "\overlays\", "\roms\")



            For Each xEle As XElement In queryy
                Dim romname As String = xEle.Element("name")
                Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
                Dim rompatho As String = My.Settings.RecalboxFolder & "\roms\" & consoleencours & "\" & temprom

                If rompatho = cheminromcomplet Then
                    DataGridOverlay.Rows(lignass).Cells(DataGridOverlay.Columns("TitreRom Overlay").Index).Value = romname
                    DataGridOverlay.Rows(lignass).Cells(DataGridOverlay.Columns("CocheRom").Index).Value = True
                    DataGridOverlay.Rows(lignass).Cells(DataGridOverlay.Columns("CocheRom").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
                    Exit For
                End If
            Next
lignesuivante:
        Next


        'On compte le nombre total d'entrées
        OverlayTotal.Text = DataGridOverlay.Rows.Count - 1
        OverlaySingle.Text = ListdesFichiersEnTrop.Items.Count
        'on affiche les outils
        TextBox2.Show()
        GroupBox2.Show()
    End Sub
    Sub FichiersCfgLies(cheminencours As String, consolerom As String)
        Dim cheminducfg As String = cheminencours
        Dim nomducfg As String = Path.GetFileName(cheminducfg)
        Dim gamelistassocie As String = My.Settings.RecalboxFolder & "\roms\" & consolerom & "\gamelist.xml"
        Dim gamelistXml As XElement = XElement.Load(gamelistassocie)

        'Verification du cfg console
        If nomducfg = consolerom & ".cfg" Then
            Exit Sub
        End If

        Dim nomdelarom = Replace(nomducfg, ".cfg", "")
        'getting the list for the xml with nodes
        Dim query2 = From st In gamelistXml.Descendants("game") Select st
        Dim genpathdelarom As String

        For Each xEle As XElement In query2
            Dim romname As String = xEle.Element("name")
            Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
            Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & consolerom & "\" & temprom

            genpathdelarom = My.Settings.RecalboxFolder & "\roms\" & consolerom & "\" & nomdelarom

            If rompath = genpathdelarom Then
                Exit Sub
            End If
        Next

        genpathdelarom = My.Settings.RecalboxFolder & "\roms\" & consolerom & "\" & nomdelarom
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

    Private Sub DataGridRoms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRoms.CellClick
        If e.ColumnIndex = DataGridRoms.Columns("CocheOverlay").Index Then
            DataGridRoms.Rows(e.RowIndex).Cells(DataGridOverlay.Columns("CocheOverlay").Index).ReadOnly = True
        End If
    End Sub
    Private Sub DataGridOverlay_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOverlay.CellClick
        If e.ColumnIndex = DataGridOverlay.Columns("CocheRom").Index Then
            DataGridRoms.Rows(e.RowIndex).Cells(DataGridOverlay.Columns("CocheRom").Index).ReadOnly = True
        End If
    End Sub
End Class