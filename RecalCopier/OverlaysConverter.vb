Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions

Public Class OverlaysConverter
    Private Sub OverlaysConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonConvert.Hide()
        Supp1.Hide()
        Supp2.Hide()
        Supp3.Hide()
        Supp123.Hide()
        GameLists.Hide()
        ButtonImportAll.Hide()
        DataGridOverlays.Hide()
        Label1.Hide()
        ListErreurs.Hide()
        RqtARRM.Hide()

        ComboBox1.Enabled = False

        'On dresse la liste des consoles
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.DossierOverlay, FileIO.SearchOption.SearchTopLevelOnly)
            GameLists.Items.Add(System.IO.Path.GetFileName(folder))
        Next
    End Sub
    Sub CompletionRecalbox()
        'On clear par Securité
        DataGridOverlays.Columns.Clear()
        On Error Resume Next
        DataGridOverlays.Rows.Clear()
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

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminCFG2"
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
            .ColumnName = "CocheCFG"
        End With
        table.Columns.Add(column)

        Dim chemincfgoverlay As String = Nothing
        Dim yauerreur As Integer = 0
        'Loop for every gamelists
        For Each i In GameLists.SelectedItems
            Dim nomconsole As String = i
            Dim nbdansdossier As Integer

            Dim chemindudossier = My.Settings.DossierOverlay & nomconsole
            If (Not System.IO.Directory.Exists(chemindudossier)) Then
                GoTo nextconsole
            End If

            nbdansdossier = Directory.GetFiles(My.Settings.RecalboxFolder & "\overlays\" & nomconsole, "*.cfg").Count

            Dim di As New IO.DirectoryInfo(My.Settings.DossierOverlay & nomconsole)
            Dim aryFi As IO.FileInfo() = di.GetFiles("*.cfg")
            Dim fi As IO.FileInfo
            Dim nomfichiercfg As String
            Dim cheminducfg As String
            Dim pathdelarom As String


            On Error Resume Next
            For Each fi In aryFi
                If fi.Name = nomconsole & "_overlay.cfg" Then GoTo fichiersuivant
                cheminducfg = fi.FullName
                nomfichiercfg = fi.Name

                Dim generegamelist As String

                If nomfichiercfg = nomconsole & ".cfg" Then
                    pathdelarom = Path.GetFileName(cheminducfg)
                    Dim aenlever = "\" & nomfichiercfg
                    generegamelist = Replace(Replace(cheminducfg, "\overlays\", "\roms\"), aenlever, "\gamelist.xml")
                Else
                    pathdelarom = Replace(Replace(cheminducfg, "\overlays\", "\roms\"), ".cfg", "")
                    generegamelist = Replace(Replace(Replace(cheminducfg, "\overlays\", "\roms\"), ".cfg", ""), Path.GetFileName(Replace(Replace(cheminducfg, "\overlays\", "\roms\"), ".cfg", "")), "") & "gamelist.xml"
                End If

                Dim pathpourarrm As String = "*" & Path.GetFileName((pathdelarom))

                'On va rechercher le nom de la rom
                Dim results = Recherchenomdelarom(generegamelist, nomconsole, pathdelarom)
                Dim romname = results.item1
                Dim etatoverlay = results.item2

                Dim results2 = LectureDesCfgs(nomconsole, nomfichiercfg)
                Dim overlay2 = results2.item2
                Dim fichierpng = results2.item3

                'Test si le fichier cfg 2 existe et les fichier png
                If overlay2 = "0" Then
                    yauerreur = yauerreur + 1
                    ListErreurs.Items.Add(pathpourarrm)
                    GoTo ajout
                End If

                If fichierpng = "0" Then
                    yauerreur = yauerreur + 1
                    ListErreurs.Items.Add(pathpourarrm)
                End If
ajout:
                'on ajoute au tableau
                table.Rows.Add(nomconsole, romname, nomfichiercfg, cheminducfg, overlay2, fichierpng, etatoverlay)

fichiersuivant:
            Next
nextconsole:
        Next
        On Error GoTo 0
        'Si y'a eu des erreur faut avertir
        If yauerreur > 0 Then
            MsgBox("Des fichiers sont manquants" & Chr(10) & "Vérifiez leur dispo ou rescrappez les via le Bouton Requete ARRM" & Chr(10))
            RqtARRM.Show()
        Else
            RqtARRM.Hide()
        End If

        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridOverlays.DataSource = table

        'Width for columns
        DataGridOverlays.RowHeadersWidth = 25
        DataGridOverlays.Columns("Console").Width = 40
        DataGridOverlays.Columns("NomRomXML").Width = 110
        DataGridOverlays.Columns("NomFichierCFG").Width = 110
        DataGridOverlays.Columns("CheminCFG").Width = 120
        DataGridOverlays.Columns("CheminCFG2").Width = 120
        DataGridOverlays.Columns("CheminPNG").Width = 120
        DataGridOverlays.Columns("CocheCFG").Visible = False

        Dim compteuroverlay As Integer = 0

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, CheminCFG2 asc"

        'on affiche les boutons
        Supp1.Show()
        Supp2.Show()
        Supp3.Show()

        'on colore les lignes
        Call Colorer()
    End Sub
    Function Recherchenomdelarom(chemingamelist As String, console As String, nomdufichiercfg As String)
        Dim lagamelist As String = chemingamelist
        Dim nomdelarom = Path.GetFileName(nomdufichiercfg)

        'Si il n'existe pas de gamelist, on va mettre les infos generique
        If Not System.IO.File.Exists(lagamelist) Then
            Return "#NOGAMELIST#-" & nomdelarom
        End If

        Dim gamelistXml As XElement = XElement.Load(lagamelist)

        'getting the list for the xml with nodes
        Dim query2 = From st In gamelistXml.Descendants("game") Select st
        Dim genpathdelarom As String
        genpathdelarom = Path.GetDirectoryName(chemingamelist) & "\" & Path.GetFileName(nomdufichiercfg)

        For Each xEle As XElement In query2
            Dim romname As String = xEle.Element("name")
            Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
            Dim rompath As String = Replace(xEle.Element("path"), "./", "")

            If console & ".cfg" = nomdelarom Then
                Return ("#CONSOLE#", True)
            End If

            If rompath = Path.GetFileName(nomdufichiercfg) Then
                Return (romname, True)
                GoTo lignesuivante
            End If
lignesuivante:
        Next

        Return ("#PASDANSXML#", True)
    End Function
    Public Function FileNameWithoutExtension(ByVal FullPath _
    As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonImportAll.Click
        ListErreurs.Items.Clear()

        If CheckBoxRecalbox.Checked = True Then
            Call CompletionRecalbox()
        Else
            Call Completionbatocera()
        End If

        DataGridOverlays.Show()
        ButtonConvert.Show()
        Supp1.Show()
        Supp3.Show()
        Supp123.Show()
        Label1.Show()
        ListErreurs.Show()
        RqtARRM.Show()
    End Sub
    Sub Importfichierbato()
        'On importe le nom des dossiers et on met en editable la combobox
        If InStr(My.Settings.DossierOverlay, "decorations") > 1 Then
            For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.DossierOverlay, FileIO.SearchOption.SearchTopLevelOnly)
                ComboBox1.Items.Add(System.IO.Path.GetFileName(folder))
            Next
            ComboBox1.Enabled = True
        End If
    End Sub
    Private Sub CheckBoxRecalbox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRecalbox.CheckedChanged
        If CheckBoxRecalbox.Checked = True Then
            CheckBoxRecalbox.Checked = True
            CheckBoxBatocera.Checked = False
            GameLists.Show()
        End If
    End Sub
    Private Sub CheckBoxBatocera_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBatocera.CheckedChanged
        If CheckBoxBatocera.Checked = True Then
            CheckBoxRecalbox.Checked = False
            CheckBoxBatocera.Checked = True
            Call Importfichierbato()
            MsgBox("Selectionnez le dossier Batocera Source pour la Conversion")
            ComboBox1.Focus()
            'On hide les boutons supp du 2eme fichier
            Supp2.Hide()
        End If
    End Sub
    Private Sub ButtonGetBack1_Click(sender As Object, e As EventArgs) Handles ButtonGetBack1.Click
        If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
            OverlayManager.Show()
        Else
            OverlayManagerBatocera.Show()
        End If

        Me.Close()
    End Sub
    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        If DataGridOverlays.Rows.Count = 0 Then
            MsgBox("Merci d'Importer vos configs d'abord")
            Exit Sub
        End If

        'On verifie qu'un dossier Batocera est bien selectionné
        If ComboBox1.Text = Nothing Then
            If CheckBoxBatocera.Checked = True Then
                MsgBox("Aucun Dossier Final Selectionné" & Chr(10) & Chr(10) & "Abandon")
                Exit Sub
            End If
        End If

        Dim nomdossierquestion As String
        'Si c'est Recalbox, On va creer le dossier final juste avant de convertir
        If CheckBoxRecalbox.Checked = True Then
            nomdossierquestion = InputBox("Veuillez Saisir un Nom Personnalisé pour le Dossier sous Batocera comme " & Chr(10) & Chr(10) & "CONVERTED", "Conversion RECALBOX --> BATOCERA", "CONVERTED")
            ComboBox1.Items.Add(nomdossierquestion)
            ComboBox1.SelectedItem = nomdossierquestion

            'Si on annule, on quitte tout
            If nomdossierquestion = Nothing Then
                MsgBox("Abandon")
                Exit Sub
            Else
                Dim fullchemin = My.Settings.DossierOverlay & ComboBox1.Text
                If (Not System.IO.Directory.Exists(fullchemin)) Then
                    System.IO.Directory.CreateDirectory(fullchemin)
                End If
            End If

        Else 'si c'est Batocera, on va devoir creer un dossier pour Recalbox
            nomdossierquestion = InputBox("Veuillez Saisir un Nom Personnalisé pour le Dossier pour Recalbox " & Chr(10) & Chr(10) & "RECALBOXCONVERTED", "Conversion BATOCERA --> RECALBOX", "RECALBOXCONVERTED")

            'Si on annule, on quitte tout
            If nomdossierquestion = Nothing Then
                MsgBox("Abandon")
                Exit Sub
            Else
                Dim fullchemin = My.Settings.DossierOverlay & nomdossierquestion
                If (Not System.IO.Directory.Exists(fullchemin)) Then
                    System.IO.Directory.CreateDirectory(fullchemin)
                End If
            End If

        End If

        If CheckBoxRecalbox.Checked = True Then
            'On va lire toutes les lignes
            For i = 0 To DataGridOverlays.Rows.Count - 1
                'on lit le fichier cfg
                Dim console = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("Console").Index).Value.ToString
                Dim nomducfg = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("NomFichierCFG").Index).Value.ToString

                Dim fichier1 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG").Index).Value
                Dim fichier2 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG2").Index).Value
                Dim fichier3 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminPNG").Index).Value


                If IsNumeric(fichier3) = True Then
                    GoTo fichiersuivant
                End If

                'des le depart on va copier les fichiers PNG au bon endroit grace au fichier 3
                'Si c'est overlay console ou jeu
                Dim cheminfinalducfg As String

                If GameLists.Items.Contains(FileNameWithoutExtension(fichier1.ToString)) Then
                    'c'est un overlay console donc on cree le dossier systems
                    If (Not System.IO.Directory.Exists(My.Settings.DossierOverlay & ComboBox1.Text & "\systems\")) Then
                        Directory.CreateDirectory(My.Settings.DossierOverlay & ComboBox1.Text & "\systems\")
                    End If
                    cheminfinalducfg = My.Settings.DossierOverlay & ComboBox1.Text & "\systems\" & FileNameWithoutExtension(fichier1) & ".info"
                    File.Copy(fichier3, My.Settings.DossierOverlay & ComboBox1.Text & "\systems\" & Path.GetFileName(fichier3), True)
                Else
                    'c'est un jeu donc on va le mettre dans son dossierr games puis console
                    If (Not System.IO.Directory.Exists(My.Settings.DossierOverlay & ComboBox1.Text & "\games\" & console)) Then
                        Directory.CreateDirectory(My.Settings.DossierOverlay & ComboBox1.Text & "\games\" & console)
                    End If
                    cheminfinalducfg = My.Settings.DossierOverlay & ComboBox1.Text & "\games\" & console & "\" & FileNameWithoutExtension(FileNameWithoutExtension(fichier1)) & ".info"
                    File.Copy(fichier3, My.Settings.DossierOverlay & ComboBox1.Text & "\games\" & console & "\" & Path.GetFileName(fichier3), True)
                End If

                'on ouvre le fichier 1 pour recuperer les infos
                File.ReadAllLines(fichier1)

                Dim readText() As String = File.ReadAllLines(fichier1)
                Dim s As String
                Dim lineCount = File.ReadAllLines(fichier1).Length

                'Création d'un flux d'écriture
                Dim compteurlignedufichiercfg As Integer = 0

                Dim sw As New StreamWriter(cheminfinalducfg)
                sw.WriteLine("{")

                For Each s In readText
                    compteurlignedufichiercfg = compteurlignedufichiercfg + 1
                    'On lit notre fichier original
                    Dim detectopacity As String = InStr(s, "input_overlay_opacity")
                    Dim detectfullscreenx As String = InStr(s, "video_fullscreen_x")
                    Dim detectfullscreeny As String = InStr(s, "video_fullscreen_y")
                    Dim detectx As String = InStr(s, "custom_viewport_x")
                    Dim detecty As String = InStr(s, "custom_viewport_y")
                    Dim detectw As String = InStr(s, "custom_viewport_width")
                    Dim detecth As String = InStr(s, "custom_viewport_height")
                    Dim imagey As Double
                    Dim imagex As Double
                    Dim topo As Double
                    Dim lefto As Double

                    Dim fullscreenx As Double
                    Dim fullscreeny As Double
                    Dim ligneopacity As String
                    Dim lignetop As String
                    Dim ligneleft As String
                    Dim lignewidth As String
                    Dim ligneheight As String

                    If detectopacity > 0 Then
                        Dim opacity As Double = CDbl(Replace(Convertendecimal(s), ".", ","))
                        ligneopacity = " " & Chr(34) & "opacity" & Chr(34) & ":" & Replace(FormatNumber(opacity, 7), ",", ".") & ","
                    End If

                    Dim lignemsgx As String = " " & Chr(34) & "messagex" & Chr(34) & ":" & "0.220000,"
                    Dim lignemsgy As String = " " & Chr(34) & "messagey" & Chr(34) & ":" & "0.120000,"

                    If detectfullscreenx > 0 Then
                        fullscreenx = Integer.Parse(Regex.Replace(s, "[^\d]", ""))
                        lignewidth = " " & Chr(34) & "width" & Chr(34) & ":" & fullscreenx & ","
                    End If

                    If detectfullscreeny > 0 Then
                        fullscreeny = Integer.Parse(Regex.Replace(s, "[^\d]", ""))
                        ligneheight = " " & Chr(34) & "height" & Chr(34) & ":" & fullscreeny & ","
                    End If

                    If detecty > 0 Then
                        topo = Integer.Parse(Regex.Replace(s, "[^\d]", ""))
                        lignetop = " " & Chr(34) & "top" & Chr(34) & ":" & topo & ","
                    End If

                    If detectx > 0 Then
                        lefto = Integer.Parse(Regex.Replace(s, "[^\d]", ""))
                        ligneleft = " " & Chr(34) & "left" & Chr(34) & ":" & lefto & ","
                    End If

                    If detecth > 0 Then
                        imagey = Integer.Parse(Regex.Replace(s, "[^\d]", ""))
                    End If

                    If detectw > 0 Then
                        imagex = Integer.Parse(Regex.Replace(s, "[^\d]", ""))
                    End If


                    If compteurlignedufichiercfg = lineCount Then
                        sw.WriteLine(ligneopacity)
                        sw.WriteLine(lignemsgx)
                        sw.WriteLine(lignemsgy)

                        If lignewidth = Nothing Then
                            'Recuperer la taille du fichier
                            fullscreenx = Image.FromFile(fichier3).Size.Width
                            lignewidth = " " & Chr(34) & "width" & Chr(34) & ":" & fullscreenx & ","
                        End If

                        If ligneheight = Nothing Then
                            'Recuperer la taille du fichier
                            fullscreeny = Image.FromFile(fichier3).Size.Height
                            ligneheight = " " & Chr(34) & "height" & Chr(34) & ":" & fullscreeny & ","
                        End If

                        Dim bottomo As Double = fullscreeny - imagey - topo
                        Dim lignebottom As String = " " & Chr(34) & "bottom" & Chr(34) & ":" & bottomo & ","

                        Dim righto As Double = fullscreenx - imagex - lefto
                        Dim ligneright As String = " " & Chr(34) & "right" & Chr(34) & ":" & righto

                        sw.WriteLine(lignewidth)
                        sw.WriteLine(ligneheight)
                        sw.WriteLine(lignetop)
                        sw.WriteLine(ligneleft)
                        sw.WriteLine(lignebottom)
                        sw.WriteLine(ligneright)

                        sw.WriteLine("}")
                    End If
                Next

                'On ferme le fichier
                sw.Close()
fichiersuivant:
            Next
            MsgBox("Copiez/Deplacer votre dossier '" & ComboBox1.Text & "' dans le repertoire '/decorations' de Batocera")
            Process.Start(My.Settings.DossierOverlay & ComboBox1.Text)
        Else 'Si c'est Batocera 
            'On va lire toutes les lignes
            For i = 0 To DataGridOverlays.Rows.Count - 1
                'on lit le fichier cfg
                Dim console = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("Console").Index).Value.ToString
                Dim nomducfg = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("NomFichierCFG").Index).Value.ToString

                Dim fichier1 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG").Index).Value
                Dim fichier3 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminPNG").Index).Value


                If IsNumeric(fichier3) = True Then
                    GoTo fichiersuivantbato
                End If

                'des le depart on va copier les fichiers PNG au bon endroit grace au fichier 3
                'Si c'est overlay console ou jeu
                Dim cheminfinalducfg As String
                'Recuperer la taille du fichier
                Dim largimg = Image.FromFile(fichier3).Size.Width
                Dim hautimg = Image.FromFile(fichier3).Size.Height

                If FileNameWithoutExtension(fichier1.ToString) = console Then
                    'c'est un overlay console donc on cree le dossier systems
                    If (Not System.IO.Directory.Exists(My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console)) Then
                        Directory.CreateDirectory(My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console)
                    End If
                    cheminfinalducfg = My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console & "\" & FileNameWithoutExtension(FileNameWithoutExtension(fichier1)) & ".cfg"
                    File.Copy(fichier3, My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console & "\" & Path.GetFileName(fichier3), True)
                Else
                    'c'est un jeu donc on va le mettre dans son dossierr games puis console
                    If (Not System.IO.Directory.Exists(My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console)) Then
                        Directory.CreateDirectory(My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console)
                    End If
                    cheminfinalducfg = My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console & "\" & FileNameWithoutExtension(FileNameWithoutExtension(fichier1)) & ".cfg"
                    File.Copy(fichier3, My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console & "\" & Path.GetFileName(fichier3), True)
                End If

                'on ouvre le fichier 1 pour recuperer les infos
                File.ReadAllLines(fichier1)

                Dim readText() As String = File.ReadAllLines(fichier1)
                Dim s As String
                Dim lineCount = File.ReadAllLines(fichier1).Length

                'Création d'un flux d'écriture
                Dim compteurlignedufichiercfg As Integer = 0

                Dim sw As New StreamWriter(cheminfinalducfg)
                sw.WriteLine("# generated by RecopierBox by Soaresden")
                sw.WriteLine("input_overlay = " & Chr(34) & "/recalbox/share/overlays/" & console & "/" & largimg & "x" & hautimg & "/" & FileNameWithoutExtension(fichier1) & "_overlay.cfg" & Chr(34))
                sw.WriteLine("# aspect ratio")
                sw.WriteLine("aspect_ratio_index = " & Chr(34) & "23" & Chr(34))
                sw.WriteLine("video_force_aspect = " & Chr(34) & "true" & Chr(34))
                sw.WriteLine("video_force_aspect = " & Chr(34) & "true" & Chr(34))
                sw.WriteLine("video_scale_integer = " & Chr(34) & "false" & Chr(34))
                sw.WriteLine("video_smooth = " & Chr(34) & "false" & Chr(34))
                sw.WriteLine("video_font_size = " & Chr(34) & "28.000000" & Chr(34))
                sw.WriteLine("video_message_color = " & Chr(34) & "ffff00" & Chr(34))
                sw.WriteLine("# common overlay parameters")
                sw.WriteLine("input_overlay_hide_in_menu = " & Chr(34) & "true" & Chr(34))
                sw.WriteLine("input_overlay_enable = " & Chr(34) & "true" & Chr(34))
                sw.WriteLine("input_overlay_scale = " & Chr(34) & "1.000000" & Chr(34))


                For Each s In readText
                    compteurlignedufichiercfg = compteurlignedufichiercfg + 1
                    'On lit notre fichier original
                    Dim detectopacity As Integer = InStr(s, "opacity")
                    Dim detectmsgx As Integer = InStr(s, "messagex")
                    Dim detectmsgy As Integer = InStr(s, "messagey")
                    Dim detectw As Integer = InStr(s, "width")
                    Dim detecth As Integer = InStr(s, "height")
                    Dim detecttop As Integer = InStr(s, "top")
                    Dim detectleft As Integer = InStr(s, "left")
                    Dim detectbottom As Integer = InStr(s, "bottom")
                    Dim detectright As Integer = InStr(s, "right")

                    Dim ligneopacity As String
                    Dim lignefullscreenx As String
                    Dim lignefullscreeny As String
                    Dim lignetop As String
                    Dim ligneleft As String
                    Dim lignewidth As String
                    Dim ligneheight As String
                    Dim fullscreenx As Integer
                    Dim fullscreeny As Integer


                    If detectmsgx > 0 Then GoTo lignesuivante
                    If detectmsgy > 0 Then GoTo lignesuivante

                    If detectopacity > 0 Then
                        Dim opacity = Convertendecimal(s)
                        ligneopacity = "input_overlay_opacity = " & Chr(34) & opacity & Chr(34)
                        sw.WriteLine(ligneopacity)
                    End If

                    If detectw > 0 Then
                        fullscreenx = Convertendecimal(s)
                        lignefullscreenx = "video_fullscreen_x = " & Chr(34) & fullscreenx & Chr(34)
                        sw.WriteLine(lignefullscreenx)
                    End If

                    If detecth > 0 Then
                        fullscreeny = Convertendecimal(s)
                        lignefullscreeny = "video_fullscreen_y = " & Chr(34) & fullscreeny & Chr(34)
                        sw.WriteLine(lignefullscreeny)
                    End If

                    If detecttop > 0 Then
                        Dim top = Convertendecimal(s)
                        lignetop = "custom_viewport_y = " & Chr(34) & top & Chr(34)
                        sw.WriteLine(lignetop)
                    End If

                    If detectleft > 0 Then
                        Dim left = Convertendecimal(s)
                        ligneleft = "custom_viewport_x = " & Chr(34) & left & Chr(34)
                        sw.WriteLine(ligneleft)
                    End If

                    If detectbottom > 0 Then
                        Dim bottomo = fullscreeny - Top - Convertendecimal(s) 'bottom
                        ligneheight = "custom_viewport_height = " & Chr(34) & bottomo & Chr(34)
                        sw.WriteLine(ligneheight)
                    End If

                    If detectright > 0 Then
                        Dim righto = fullscreenx - Left - Convertendecimal(s) 'right
                        lignewidth = "custom_viewport_width = " & Chr(34) & righto & Chr(34)
                        sw.WriteLine(lignewidth)
                    End If

lignesuivante:
                Next

                'On ferme le fichier
                sw.Close()


                'Si c'est un overlay console, ce sera dans le dossier principal, sinon dans le dossier resolution
                'On va creer le fichier _overlay
                Dim dossierducfgoverlay2 As String
                If InStr(cheminfinalducfg, console & ".cfg") > 1 Then
                    dossierducfgoverlay2 = My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console & "\"
                Else
                    dossierducfgoverlay2 = My.Settings.DossierOverlay & nomdossierquestion & "\overlays\" & console & "\" & largimg & "x" & hautimg & "\"
                End If

                'Verifie si le dossier de la resolution existe
                If (Not System.IO.Directory.Exists(dossierducfgoverlay2)) Then
                    Directory.CreateDirectory(dossierducfgoverlay2)
                End If

                Dim cheminoverlaycfg2 As String = dossierducfgoverlay2 & FileNameWithoutExtension(fichier1) & "_overlay.cfg"

                'Nouveau fichier _overlay.cfg
                Dim sw2 As New StreamWriter(cheminoverlaycfg2)
                sw2.WriteLine("# generated by RecopierBox by Soaresden")
                sw2.WriteLine("overlay0_overlay = " & Chr(34) & Path.GetFileName(fichier3) & Chr(34))
                sw2.WriteLine("overlays = 1")
                sw2.WriteLine("overlay0_full_screen = True")
                sw2.WriteLine("overlay0_descs = 0")

                'On ferme le fichier
                sw2.Close()

fichiersuivantbato:
            Next

            MsgBox("Copiez/Deplacer le contenu de votre dossier '" & Chr(10) & Chr(10) & nomdossierquestion & Chr(10) & "dans le repertoire '/overlays' de votre Recalbox")
            Process.Start(My.Settings.DossierOverlay & nomdossierquestion)
        End If
    End Sub
    Function Convertendecimal(ligne As String)
        Dim resultats = Regex.Replace(ligne, "[^-?\d+\.]", "")
        Return resultats
    End Function
    Function Lecturedescfgsbato(lagamelist As String, consolerom As String, nomducfg As String)
        If consolerom = Nothing Then Exit Function

        Dim modifgamelistenrom As String = nomducfg
        Dim aenlever As String = "roms"
        Dim fichier1cfg As String = nomducfg
        Dim fichier2overlaycfg As String
        Dim fichier3png As String

        Dim cheminpropreoverlay2 As String
        Dim justefichier2 As String

        fichier3png = 0
        justefichier2 = 0
        fichier2overlaycfg = 0
        cheminpropreoverlay2 = 0

        'on va lire le cfg pour trouver le cfg overlay
        File.ReadAllLines(nomducfg)

        Dim readText() As String = File.ReadAllLines(fichier1cfg)
        Dim s As String

        For Each s In readText
            Dim detectinputoverlay As String

            detectinputoverlay = InStr(s, "/overlays/")

            If detectinputoverlay > 0 Then
                Dim sansguillemets = Replace(s, Chr(34), "")
                'Dim cheminducfgoverlay = sansguillemets.Substring(detectinputoverlay + 8)
                'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)

                Dim chemincfgoverlaydanscfg As String
                chemincfgoverlaydanscfg = Replace(s, Chr(34), "").Substring(detectinputoverlay + 8).Substring(0, InStr(Replace(s, Chr(34), "").Substring(detectinputoverlay + 8), ".cfg") + 3)
                cheminpropreoverlay2 = Replace(My.Settings.DossierOverlay.Substring(0, Len(My.Settings.DossierOverlay)) & Replace(chemincfgoverlaydanscfg, "/", "\"), "\\", "\")
                justefichier2 = FileNameWithoutExtension(cheminpropreoverlay2) & ".cfg"
                Exit For
            End If
        Next

        'on lit le deuxieme fichier overlay cfg pour trouver le png
        If Not File.Exists(cheminpropreoverlay2) Then
            cheminpropreoverlay2 = "0"
            GoTo findugame
        End If
        File.ReadAllLines(cheminpropreoverlay2)

        Dim readText2() As String = File.ReadAllLines(cheminpropreoverlay2)
        Dim t As String

        For Each t In readText2
            Dim detectegal As String = InStr(t, "overlay =")
            If detectegal > 0 Then
                t = Replace(t, Chr(34), "")
                'Dim chemindupng = t.Substring(detectegal + 9)
                'Dim detectpng = InStr(chemindupng, "png")
                'Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 3)
                Dim cheminpng = t.Substring(detectegal + 9).Substring(0, InStr(t.Substring(detectegal + 10), "png") + 3)


                fichier3png = Replace(cheminpropreoverlay2, justefichier2, cheminpng)
            End If
        Next

findugame:
        Return (fichier1cfg, cheminpropreoverlay2, fichier3png)
    End Function
    Function LectureDesCfgs(consolerom As String, nomducfg As String)
        If consolerom = Nothing Then Exit Function

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

        For Each s In readText
            Dim detectinputoverlay As String

            detectinputoverlay = InStr(s, "/overlays/")

            If detectinputoverlay > 0 Then
                Dim sansguillemets = Replace(s, Chr(34), "")
                'Dim cheminducfgoverlay = sansguillemets.Substring(detectinputoverlay + 8)
                'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)

                Dim chemincfgoverlaydanscfg As String
                chemincfgoverlaydanscfg = Replace(s, Chr(34), "").Substring(detectinputoverlay + 8).Substring(0, InStr(Replace(s, Chr(34), "").Substring(detectinputoverlay + 8), ".cfg") + 3)
                cheminpropreoverlay2 = Replace(My.Settings.DossierOverlay.Substring(0, Len(My.Settings.DossierOverlay)) & Replace(chemincfgoverlaydanscfg, "/", "\"), "\\", "\")
                justefichier2 = FileNameWithoutExtension(cheminpropreoverlay2) & ".cfg"
                Exit For
            End If
        Next

        'on lit le deuxieme fichier overlay cfg pour trouver le png
        If Not File.Exists(cheminpropreoverlay2) Then
            cheminpropreoverlay2 = "0"
            GoTo findugame
        End If
        File.ReadAllLines(cheminpropreoverlay2)

        Dim readText2() As String = File.ReadAllLines(cheminpropreoverlay2)
        Dim t As String

        For Each t In readText2
            Dim detectegal As String = InStr(t, "overlay =")
            If detectegal > 0 Then
                t = Replace(t, Chr(34), "")
                'Dim chemindupng = t.Substring(detectegal + 9)
                'Dim detectpng = InStr(chemindupng, "png")
                'Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 3)
                Dim cheminpng = t.Substring(detectegal + 9).Substring(0, InStr(t.Substring(detectegal + 10), "png") + 3)


                fichier3png = Replace(cheminpropreoverlay2, justefichier2, cheminpng)
            End If
        Next

findugame:
        Return (fichier1cfg, cheminpropreoverlay2, fichier3png)
    End Function

    Sub Completionbatocera()
        'On clear par Securité
        DataGridOverlays.Columns.Clear()
        On Error Resume Next
        DataGridOverlays.Rows.Clear()
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

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "CheminPNG"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.Boolean")
            .ColumnName = "CocheCFG"
        End With
        table.Columns.Add(column)

        Dim chemincfgoverlay As String = Nothing
        Dim yauerreur As Integer = 0

        Dim di As New IO.DirectoryInfo(My.Settings.DossierOverlay & ComboBox1.Text)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.info", SearchOption.AllDirectories)
        Dim fi As IO.FileInfo

        Dim nomfichiercfg As String
        Dim cheminducfg As String
        Dim pathdelarom As String

        For Each fi In aryFi
            Dim fichiercomplet As String = fi.FullName

            'extraction de la console
            Dim nomconsole As String = Path.GetFileName(Path.GetDirectoryName(fi.FullName))
            Dim diroms As New IO.DirectoryInfo(My.Settings.RecalboxFolder & "\roms\" & nomconsole)

            nomfichiercfg = fi.Name
            Dim aremplacer As String = "decorations\" & ComboBox1.Text & "\"
            pathdelarom = Replace(Replace(Replace(fichiercomplet, aremplacer, ""), "games", "roms"), nomfichiercfg, FileNameWithoutExtension(nomfichiercfg) & ".")

            Dim romname
            Dim etatoverlay

            'Si le .info est la console
            If InStr(pathdelarom, "systems\") > 1 Then
                romname = ""
                etatoverlay = True
                romname = "##CONSOLE##"
                nomconsole = Path.GetFileName(FileNameWithoutExtension(pathdelarom))
                GoTo saisie
            End If

            'Test si le dossier Roms\Console existe 
            If (Not System.IO.Directory.Exists(Path.GetDirectoryName(pathdelarom))) Then
                romname = ""
                etatoverlay = True
                romname = "##PAS DE DOSSIER CONSOLE DANS ROMS##"
                GoTo saisie
            End If

            Dim vraieromfilecompte As Integer = diroms.GetFiles(FileNameWithoutExtension(nomfichiercfg) & ".*", SearchOption.AllDirectories).Count
            If vraieromfilecompte = 0 Then
                MsgBox("Pas de Roms trouvée à :" & Chr(10) & Chr(10) & nomfichiercfg & Chr(10) & "Verifiez vos Overlays. Abandon")
                Exit Sub
            End If
            Dim vraieromfile As IO.FileInfo() = diroms.GetFiles(FileNameWithoutExtension(nomfichiercfg) & ".*", SearchOption.AllDirectories)
            Dim realromfile As String = vraieromfile(0).ToString
            Dim generegamelist As String = Path.GetDirectoryName(pathdelarom) & "\gamelist.xml"


            'On va rechercher le nom de la rom

            If realromfile <> Nothing Then
                Dim results = Recherchenomdelarom(generegamelist, nomconsole, realromfile)
                romname = results.item1
                etatoverlay = results.item2
            Else
                romname = pathdelarom
                etatoverlay = True
            End If

saisie:
            'On prends le nom du fichier png
            Dim fichierpng As String = Replace(fichiercomplet, ".info", ".png")
            'test son existence
            If Not File.Exists(fichierpng) Then
                yauerreur = yauerreur + 1
                fichierpng = "0"
                ListErreurs.Items.Add(fichierpng)
            End If

            'on ajoute au tableau
            table.Rows.Add(nomconsole, romname, nomfichiercfg, fichiercomplet, fichierpng, etatoverlay)

fichiersuivant:
        Next

        'Si y'a eu des erreur faut avertir
        If yauerreur > 0 Then
            MsgBox("Des fichiers sont manquants" & Chr(10) & "Vérifiez leur dispo ou rescrappez les via le Bouton Requete ARRM" & Chr(10))
            RqtARRM.Show()
        Else
            RqtARRM.Hide()
        End If

        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridOverlays.DataSource = table

        'Width for columns
        DataGridOverlays.RowHeadersWidth = 25
        DataGridOverlays.Columns("Console").Width = 70
        DataGridOverlays.Columns("NomRomXML").Width = 240
        DataGridOverlays.Columns("NomFichierCFG").Width = 150
        DataGridOverlays.Columns("CheminCFG").Width = 90
        DataGridOverlays.Columns("CheminPNG").Width = 90
        DataGridOverlays.Columns("CocheCFG").Visible = False

        Dim compteuroverlay As Integer = 0

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, CheminCFG asc"

        'on affiche les boutons
        Supp1.Show()
        Supp2.Hide()
        Supp3.Show()

        'on colore les lignes
        Call Colorerbato()
    End Sub
    Sub Colorer()
        For i = 0 To DataGridOverlays.Rows.Count - 1
            Dim fichier1 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG").Index).Value
            Dim fichier2 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG2").Index).Value
            Dim fichier3 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminPNG").Index).Value

            If fichier1 = "0" Then
                DataGridOverlays.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 139, 139)
            ElseIf fichier2 = "0" Then
                DataGridOverlays.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 139, 139)
            ElseIf fichier3 = "0" Then
                DataGridOverlays.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 139, 139)
            Else
                DataGridOverlays.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(162, 255, 162)
            End If
        Next
    End Sub
    Sub Colorerbato()
        For i = 0 To DataGridOverlays.Rows.Count - 1
            Dim fichier1 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG").Index).Value
            Dim fichier3 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminPNG").Index).Value

            If fichier1 = "0" Then
                DataGridOverlays.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 139, 139)
            ElseIf fichier3 = "0" Then
                DataGridOverlays.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(255, 139, 139)
            Else
                DataGridOverlays.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(162, 255, 162)
            End If
        Next
    End Sub
    Function Extractconsole(cheminfichierinfo As String)
        For i = 0 To GameLists.Items.Count - 1
            Dim consolegamelist = GameLists.Items(i)
            Dim detecteconsole = InStr(cheminfichierinfo, consolegamelist)
            If detecteconsole > 1 Then
                'ca veut dire qu'on a detecté une console
                'Dim consoledetect As String = cheminfichierinfo.Substring(detecteconsole - 1)
                'Dim detectleslash As Integer = InStr(consoledetect, "\")
                'Dim laconsole As String = consoledetect.Substring(0, detectleslash - 1)
                Dim laconsoledetectee As String = cheminfichierinfo.Substring(detecteconsole - 1).Substring(0, InStr(cheminfichierinfo.Substring(detecteconsole - 1), "\") - 1)
                Return laconsoledetectee
                Exit Function
            End If
        Next
        Return "pasconsole"
    End Function
    Private Sub RqtARRM_Click(sender As Object, e As EventArgs) Handles RqtARRM.Click
        If ListErreurs.Items.Count = 0 Then Exit Sub
        Dim rqt As String = Nothing
        Dim dernier = ListErreurs.SelectedItems.Item(ListErreurs.SelectedItems.Count - 1)

        For Each j In ListErreurs.SelectedItems

            'A cause du caractere ', on va le tronquer sinon ca casse la requete
            If InStr(j, "'") > 0 Then
                j = j.ToString.Substring(0, InStr(j, "'") - 1) & "*"
            End If

            'Si y'a qu'un seul selectionné 
            If ListErreurs.SelectedItems.Count = 1 Then
                rqt = rqt + "fichier_rom like '" & j & "'"
                Clipboard.SetText(rqt)
                GoTo Fin
            End If

            'SI y'en a plusieurs de selectionné
            If ListErreurs.Items.Count > 1 Then
                rqt = rqt + "fichier_rom like '" & j & "'"

                'si c'est le dernier selectionné, on va le mettre dans le presse papiers
                If j <> dernier Then
                    rqt = rqt + " or "
                Else
                    Clipboard.SetText(rqt)
                    GoTo Fin
                End If
            End If
        Next
Fin:
        MsgBox("Requete dans le presse papiers" & Chr(10) & "Collez ca dans la barre de Requete d'ARRM et filtrez")
    End Sub
    Sub Supplescfgs(num As Integer)
        For Each i In DataGridOverlays.SelectedRows
            Dim fichier1 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG").Index).Value
            Dim fichier2 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG2").Index).Value
            Dim fichier3 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminPNG").Index).Value

            If num = 123 Then
                Directory.Delete(fichier1)
                If Supp2.Visible Then
                    Directory.Delete(fichier2)
                End If
                Directory.Delete(fichier3)
            ElseIf num = 1 Then
                Directory.Delete(fichier1)
            ElseIf num = 2 Then
                Directory.Delete(fichier2)
            ElseIf num = 3 Then
                Directory.Delete(fichier3)
            End If
        Next
    End Sub
    Private Sub Supp1_Click(sender As Object, e As EventArgs) Handles Supp1.Click
        Call Supplescfgs(1)
    End Sub
    Private Sub Supp2_Click(sender As Object, e As EventArgs) Handles Supp2.Click
        Call Supplescfgs(2)
    End Sub
    Private Sub Supp3_Click(sender As Object, e As EventArgs) Handles Supp3.Click
        Call Supplescfgs(3)
    End Sub
    Private Sub Supp123_Click(sender As Object, e As EventArgs) Handles Supp123.Click
        Call Supplescfgs(123)
    End Sub
    Private Sub DataGridOverlays_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOverlays.CellContentDoubleClick
        Dim numcolonne = e.ColumnIndex
        Dim numligne = e.RowIndex

        If numcolonne < 3 Then Exit Sub
        Dim fichiercomplet = DataGridOverlays.Rows(numligne).Cells(numcolonne).Value

        If DataGridOverlays.Rows(numligne).Cells(numcolonne).Value = "0" Then
            Exit Sub
        Else
            Process.Start(fichiercomplet)
        End If
    End Sub
    Private Sub GameLists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GameLists.SelectedIndexChanged
        If GameLists.SelectedItems.Count > 0 Then
            ButtonImportAll.Show()
        Else
            ButtonImportAll.Hide()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If CheckBoxBatocera.Checked = True Then MsgBox("Import en Cours ...")
        ButtonImportAll.Show()
        ButtonImportAll.PerformClick()
        ButtonImportAll.Hide()
    End Sub
    Private Sub DataGridOverlays_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOverlays.CellContentClick
        Call Colorerbato()
    End Sub
    Private Sub DataGridOverlays_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridOverlays.ColumnHeaderMouseClick
        Call Colorerbato()
    End Sub

    Private Sub OverlaysConverter_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
    End Sub
End Class