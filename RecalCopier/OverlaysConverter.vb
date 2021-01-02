Imports System.IO
Imports System.Text.RegularExpressions

Public Class OverlaysConverter
    Private Sub OverlaysConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Import des noms de plateformes   
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.RecalboxFolder & "\roms\", FileIO.SearchOption.SearchTopLevelOnly)
            GameLists.Items.Add(System.IO.Path.GetFileName(folder))
        Next

        ComboBox1.Items.Clear()
        If InStr(My.Settings.DossierOverlay, "decorations") > 1 Then
            For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.DossierOverlay, FileIO.SearchOption.SearchTopLevelOnly)
                ComboBox1.Items.Add(System.IO.Path.GetFileName(folder))
            Next
            ComboBox1.SelectedIndex = 0
        End If
        ButtonConvert.Hide()
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



            For Each fi In aryFi
                If fi.Name = nomconsole & "_overlay.cfg" Then GoTo fichiersuivant
                cheminducfg = fi.FullName
                nomfichiercfg = fi.Name

                pathdelarom = Replace(Replace(cheminducfg, "\overlays\", "\roms\"), ".cfg", "")
                Dim pathpourarrm As String = "*" & Path.GetFileName((pathdelarom))

                'On va rechercher le nom de la rom
                Dim results = Recherchenomdelarom(nomconsole, pathdelarom)
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

        'Si y'a eu des erreur faut avertir
        If yauerreur > 0 Then
            MsgBox("Des fichiers sont manquants" & Chr(13) & "Vérifiez leur dispo ou rescrappez les via le Bouton Requete ARRM" & Chr(13))
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

        'on colore les lignes
        Call colorer()
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
                Return ("#CONSOLE#", True)
            End If

            If rompath = pathdelarom Then
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
            Call completionBatocera()
        End If
        ButtonConvert.Show()
    End Sub
    Private Sub CheckBoxRecalbox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRecalbox.CheckedChanged
        If CheckBoxRecalbox.Checked = True Then
            CheckBoxRecalbox.Checked = True
            CheckBoxBatocera.Checked = False

            Dim nomdossier As String = InputBox("Veuillez Saisir un Nom Personnalisé pour le Dossier sous Batocera comme " & Chr(13) & Chr(13) & "CONVERTED", "Conversion RECALBOX --> BATOCERA", "CONVERTED")
            ComboBox1.Items.Add(nomdossier)
            If nomdossier <> Nothing Then
                Dim fullchemin = My.Settings.DossierOverlay & nomdossier
                If (Not System.IO.Directory.Exists(fullchemin)) Then
                    System.IO.Directory.CreateDirectory(fullchemin)
                End If
                ComboBox1.SelectedIndex = 0
            Else
                Exit Sub
            End If
        Else
            CheckBoxRecalbox.Checked = False
            CheckBoxBatocera.Checked = True
        End If
    End Sub
    Private Sub CheckBoxBatocera_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBatocera.CheckedChanged
        If CheckBoxBatocera.Checked = True Then
            CheckBoxRecalbox.Checked = False
            CheckBoxBatocera.Checked = True
        Else
            CheckBoxRecalbox.Checked = True
            CheckBoxBatocera.Checked = False

            Dim nomdossier As String = InputBox("Veuillez Saisir un Nom Personnalisé pour le Dossier sous Batocera comme " & Chr(13) & Chr(13) & "CONVERTED")
            ComboBox1.Items.Add(nomdossier)
            If nomdossier <> Nothing Then
                Dim fullchemin = My.Settings.DossierOverlay & nomdossier
                If (Not System.IO.Directory.Exists(fullchemin)) Then
                    System.IO.Directory.CreateDirectory(fullchemin)
                End If
                ComboBox1.SelectedIndex = 0
            End If
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

        'On va lire toutes les lignes
        For i = 0 To DataGridOverlays.Rows.Count - 1
            'on lit le fichier cfg
            Dim console = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("Console").Index).Value.ToString
            Dim nomducfg = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("NomFichierCFG").Index).Value.ToString

            Dim fichier1 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG").Index).Value
            Dim fichier2 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG2").Index).Value
            Dim fichier3 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminPNG").Index).Value


            If IsNumeric(fichier3) = True Then
                Process.Start(fichier1)
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
                Dim fullscreenx As Double
                Dim fullscreeny As Double
                Dim ligneopacity As String
                Dim lignetop As String
                Dim ligneleft As String
                Dim lignewidth As String
                Dim ligneheight As String

                If detectopacity > 0 Then
                    Dim opacity As Double = CDbl(Replace(Convertendecimal(s), ".", ","))
                    ligneopacity = " " & Chr(34) & "opacity" & Chr(34) & ":" & FormatNumber(opacity, 7) & ","
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
                    Dim top As Double = Integer.Parse(Regex.Replace(s, "[^\d]", ""))
                    lignetop = " " & Chr(34) & "top" & Chr(34) & ":" & top & ","
                End If

                If detectx > 0 Then
                    Dim left As Double = Integer.Parse(Regex.Replace(s, "[^\d]", ""))
                    ligneleft = " " & Chr(34) & "left" & Chr(34) & ":" & left & ","
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

                    Dim bottom As Double = fullscreeny - Top - 5
                    Dim lignebottom As String = " " & Chr(34) & "bottom" & Chr(34) & ":" & bottom & ","

                    Dim right As Double = fullscreenx - Top - 5
                    Dim ligneright As String = " " & Chr(34) & "right" & Chr(34) & ":" & right

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
        Process.Start(My.Settings.DossierOverlay & ComboBox1.Text)
    End Sub

    Function Convertendecimal(ligne As String)
        Dim regexx As String = "\d+?.\d+"
        Dim matches As MatchCollection = Regex.Matches(ligne, regexx)
        Dim resultats As String
        For Each m As Match In matches
            resultats = m.ToString
        Next
        Return resultats

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
        MsgBox("Requete dans le presse papiers" & Chr(13) & "Collez ca dans la barre de Requete d'ARRM et filtrez")
    End Sub

    Sub supplescfgs(num As Integer)
        For Each i In DataGridOverlays.SelectedRows
            Dim fichier1 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG").Index).Value
            Dim fichier2 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminCFG2").Index).Value
            Dim fichier3 As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminPNG").Index).Value

            If num = 123 Then
                Directory.Delete(fichier1)
                Directory.Delete(fichier2)
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
        Call supplescfgs(1)
    End Sub

    Private Sub Supp2_Click(sender As Object, e As EventArgs) Handles Supp2.Click
        Call supplescfgs(2)
    End Sub

    Private Sub Supp3_Click(sender As Object, e As EventArgs) Handles Supp3.Click
        Call supplescfgs(3)
    End Sub

    Private Sub Supp123_Click(sender As Object, e As EventArgs) Handles Supp123.Click
        Call supplescfgs(123)
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
End Class