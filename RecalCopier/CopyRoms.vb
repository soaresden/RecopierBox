Imports System.IO

Public Class CopyRoms

    Private Sub CopyRoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hiding buttons and datagrids
        txt_txtsearch.Hide()
        FinalGrid.Hide()
        ButtonShowGames.Hide()
        GroupBox1.Hide()
        lbl_bibliorecalbox.Hide()
        grp_RomInfos.Hide()
        vid_romvid.uiMode = "none"
        lbl_TxtSearch.Hide()
        txt_txtsearch.Hide()
        listboxMaSelection.Hide()
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
            .ColumnName = "romconsole"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "romname"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "rompath"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "romdesc"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "romimage"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "romvideo"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "rommanual"
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
                Dim rompath As String = Replace(My.Settings.RecalboxFolder & "\roms\" & nomconsole & Replace("\\" & Replace(xEle.Element("path"), "./", "\"), "/", "\"), "\\", "")
                Dim romhidden As String = xEle.Element("hidden")
                Dim romdesc As String
                Dim romimage As String
                Dim romvideo As String
                Dim romanual As String

                If romhidden IsNot Nothing Then GoTo romsuivante

                If xEle.Element("desc") Is Nothing Then
                    romdesc = Nothing
                Else
                    romdesc = xEle.Element("desc")
                End If

                If xEle.Element("image") Is Nothing Then
                    romimage = Nothing
                Else
                    romimage = Replace(My.Settings.RecalboxFolder & "\roms\" & nomconsole & Replace(xEle.Element("image"), "./", "\"), "/", "\")
                End If

                If xEle.Element("video") Is Nothing Then
                    romvideo = Nothing
                Else
                    romvideo = Replace(My.Settings.RecalboxFolder & "\roms\" & nomconsole & Replace(xEle.Element("video"), "./", "\"), "/", "\")
                End If

                If xEle.Element("manual") Is Nothing Then
                    romanual = Nothing
                Else
                    romanual = Replace(My.Settings.RecalboxFolder & "\roms\" & nomconsole & Replace(xEle.Element("manual"), "./", "\"), "/", "\")
                End If

                table.Rows.Add(romconsole, romname, rompath, romdesc, romimage, romvideo, romanual)
romsuivante:
            Next
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        FinalGrid.DataSource = table

        'Width for columns
        FinalGrid.Columns(0).Width = 40     'romconsole
        FinalGrid.Columns(1).Width = 180    'romname
        FinalGrid.Columns(2).Width = 1      'rompath
        FinalGrid.Columns(3).Width = 1      'romdesc
        FinalGrid.Columns(4).Width = 1      'romimage
        FinalGrid.Columns(5).Width = 1      'romvideo
        FinalGrid.Columns(6).Width = 1      'romanual

        '(0)romconsole
        '(1)romname
        '(2)rompath
        '(3)romdesc
        '(4)romimage
        '(5)romvideo
        '(6)romanual

        '(7)Screen ?
        '(8)Video ?
        '(9)Manuel ?
        '(10)Overlay ?
        '(11)Save ?
        '(12)Selection ?
        '(13)Size

        'add checkable columns at the end
        Dim colromimage As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromimage)
        colromimage.HeaderText = "Screen"
        colromimage.Name = "Coche"
        colromimage.Width = 25

        Dim colromvideo As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromvideo)
        colromvideo.HeaderText = "Video"
        colromvideo.Name = "Coche"
        colromvideo.Width = 25

        Dim colromanual As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromanual)
        colromanual.HeaderText = "Manual"
        colromanual.Name = "Coche"
        colromanual.Width = 25

        Dim colromoverlay As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromoverlay)
        colromoverlay.HeaderText = "Overlay"
        colromoverlay.Name = "Coche"
        colromoverlay.Width = 30

        Dim colromsaves As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromsaves)
        colromsaves.HeaderText = "Save"
        colromsaves.Name = "Coche"
        colromsaves.Width = 25

        Dim colromselection As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromselection)
        colromselection.HeaderText = "Selection"
        colromselection.Name = "Coche"
        colromselection.Width = 25

        'Ajout de la taille de la rom 
        Dim colromSize As New DataGridViewTextBoxColumn()
        FinalGrid.Columns.Add(colromSize)
        colromSize.HeaderText = "Mo"
        colromSize.Name = "Coche"
        colromSize.Width = 60

        'Reajusting Interface and Showing Final Interface
        ButtonImportXML.Hide()
        ListGameLists.Hide()
        lbl_gamelist.Hide()
        FinalGrid.Location = New Point(11, 28)
        FinalGrid.Size = New Size(592, 378)
        grp_RomInfos.Show()
        GroupBox1.Show()
        ButtonShowGames.Hide()
        txt_txtsearch.Show()
        lbl_TxtSearch.Show()

        dv.Sort = "romconsole asc, romname asc"

        'on va calculer la taille des roms
        Call Calcultaillerom()
        'On lance la completion des checkbox
        Call Completiondescheckbox()
    End Sub
    Sub Calcultaillerom()
        On Error Resume Next
        For Each oRow As DataGridViewRow In FinalGrid.Rows
            Dim chemindelarom = oRow.Cells(2).Value
            Dim size As Long

            Dim attr As FileAttributes = File.GetAttributes(chemindelarom)
            If ((attr And FileAttribute.Directory) = FileAttribute.Directory) Then
                'si c'est un repertoire (daphne, dos ...etc) 

                Dim folder As New IO.DirectoryInfo(chemindelarom & "\")
                For Each file As IO.FileInfo In folder.GetFiles("*.*", IO.SearchOption.AllDirectories)
                    size += file.Length
                Next file

                size = chemindelarom

            Else
                'si c'est un fichier...
                Dim extensionrom As String = Path.GetExtension(chemindelarom)

                'si c'est un m3u, il faut lire le fichier pour recuperer la vraie taille des cd's dedans
                If extensionrom = ".m3u" Then
                    Dim sw As StreamWriter
                    File.ReadAllLines(chemindelarom)

                    ' Open the m3u file to read from.
                    Dim readText() As String = File.ReadAllLines(chemindelarom)
                    Dim s As String
                    size = 0
                    For Each s In readText
                        chemindelarom = My.Settings.RecalboxFolder & "\roms\" & oRow.Cells(0).Value & "\" & Replace(s, "/", "\")
                        Dim info As New FileInfo(chemindelarom)
                        size += info.Length
                    Next
                ElseIf extensionrom = ".cue" Then 'si c'est un cue, il faut lire le fichier pour recuperer la vraie taille des cd's dedans
                    Dim sw As StreamWriter
                    File.ReadAllLines(chemindelarom)

                    ' Open the cue file to read from.
                    Dim readText() As String = File.ReadAllLines(chemindelarom)
                    Dim s As String
                    size = 0
                    For Each s In readText
                        Dim detectfile = InStr(s, Chr(34))
                        If detectfile >= 1 Then
                            'Dim isolerome As String = s.Substring(detectfile)
                            'Dim isolebinary As String = InStr(isolerome, Chr(34))
                            'Dim isolerom As String = isolerome.Substring(0, isolebinary - 1)

                            Dim iso As String = s.Substring(detectfile).Substring(0, InStr(s.Substring(detectfile), Chr(34)) - 1)

                            chemindelarom = My.Settings.RecalboxFolder & "\roms\" & oRow.Cells(0).Value & "\" & Replace(iso, "/", "\")

                            Dim info As New FileInfo(chemindelarom)
                            size += info.Length
                        End If
                    Next


                Else

                    'sinon c'est un fichier normal 
                    Dim info As New FileInfo(chemindelarom)
                    size = info.Length
                End If

            End If
            'Conversion en Mo
            Dim tailleenmo As Decimal = size / 1048576

            oRow.Cells(13).Value = Math.Round(tailleenmo, 2)
        Next
        On Error GoTo 0
    End Sub
    Sub Completiondescheckbox()
        '(0)romconsole
        '(1)romname
        '(2)rompath
        '(3)romdesc
        '(4)romimage
        '(5)romvideo
        '(6)romanual

        '(7)Screen ?
        '(8)Video ?
        '(9)Manuel ?
        '(10)Overlay ?
        '(11)Save ?
        '(12)Selection ?
        '(13)Size
        On Error Resume Next
        For Each oRow As DataGridViewRow In FinalGrid.Rows
            'test sur le chemin des screens, si la cellule est complétée alors on coche
            Dim lescreen As String = oRow.Cells(4).Value
            If lescreen Is Nothing Then
                oRow.Cells(7).Value = False
            Else
                oRow.Cells(7).Value = True
            End If

            'test sur le chemin des videos
            Dim lavideo As String = oRow.Cells(5).Value
            If lavideo Is Nothing Then
                oRow.Cells(8).Value = False
            Else
                oRow.Cells(8).Value = True
            End If

            'test sur le chemin des manuels
            Dim lemanuel As String = oRow.Cells(6).Value
            If lemanuel Is Nothing Then
                oRow.Cells(9).Value = False
            Else
                oRow.Cells(9).Value = True
            End If

            lescreen = Nothing
            lavideo = Nothing
            lemanuel = Nothing

            'test sur le chemin des overlays
            Dim cheminrom As String = oRow.Cells(2).Value
            Dim FileInfo As New FileInfo(cheminrom)
            Dim nomdelarom As String = FileInfo.Name
            Dim nomducfg As String = nomdelarom & ".cfg"

            Dim cheminoverlay As String = Replace(cheminrom, "\roms\", "\overlays\")
            Dim testcheminoverlay As String = Replace(cheminoverlay, nomdelarom, nomducfg)

            If System.IO.File.Exists(testcheminoverlay) Then
                oRow.Cells(10).Value = True
            Else
                oRow.Cells(10).Value = False
            End If

            'test sur le chemin des saves
            Dim cheminsaves As String = Replace(cheminrom, "\roms\", "\saves\")
            Dim romsansextension = FileNameWithoutExtension(nomdelarom)

            Dim savesCount As Integer = IO.Directory.GetFiles(Replace(cheminsaves, nomdelarom, ""), romsansextension & ".*").Length

            If savesCount >= 1 Then
                oRow.Cells(11).Value = True
            Else
                oRow.Cells(11).Value = False
            End If
        Next
        On Error GoTo 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttongetback.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub FinalGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FinalGrid.CellMouseClick
        Dim totalline As Integer = FinalGrid.RowCount - 1

        If e.RowIndex = totalline Then Exit Sub

        '(0)romconsole
        '(1)romname
        '(2)rompath
        '(3)romdesc
        '(4)romimage
        '(5)romvideo
        '(6)rommanual

        '(7)Screen ?
        '(8)Video ?
        '(9)Manuel ?
        '(10)Overlay ?
        '(11)Save ?
        '(12)Selection ?
        '(13) Size

        'Chargement des informations dans Rom Information
        Dim row As DataGridViewRow = FinalGrid.Rows(e.RowIndex)
        txt_romname.Text = row.Cells(1).Value.ToString
        txt_rompath.Text = row.Cells(2).Value.ToString
        If (String.IsNullOrEmpty(row.Cells(3).Value)) Then
            txt_romdesc.Text = ""
        Else
            txt_romdesc.Text = row.Cells(3).Value.ToString
        End If

        'calcul du vide pour ne pas afficher l'image / video
        Dim console As String = row.Cells(0).Value.ToString
        Dim cheminduvide = My.Settings.RecalboxFolder & "\roms\" & console

        If row.Cells(4).Value.ToString = Replace(cheminduvide & "\", "\\", "\") Then
            RomImage.Hide()
        Else
            RomImage.Show()
            RomImage.Image = Image.FromFile(row.Cells(4).Value.ToString)
        End If

        If row.Cells(5).Value.ToString = Replace(cheminduvide & "\", "\\", "\") Then
            vid_romvid.Hide()
        Else
            vid_romvid.Show()
            vid_romvid.URL = row.Cells(5).Value.ToString

            vid_romvid.uiMode = "none"
            vid_romvid.settings.setMode("loop", True)

            vid_romvid.settings.mute = True
            vid_romvid.Ctlcontrols.play()
        End If

        'Icones du Bas
        '(7)Screen ?
        '(8)Video ?
        '(9)Manuel ?
        '(10)Overlay ?
        '(11)Save ?
        '(12)Selection ?

        If row.Cells(7).Value = True Then
            romscreen.Image = My.Resources.Okscreen
        Else
            romscreen.Image = My.Resources.noscreen
        End If

        If row.Cells(8).Value = True Then
            romvideo.Image = My.Resources.OKvideo
        Else
            romvideo.Image = My.Resources.novideo
        End If

        If row.Cells(9).Value = True Then
            rommanual.Image = My.Resources.OKmanual
        Else
            rommanual.Image = My.Resources.nomanual
        End If

        If row.Cells(10).Value = True Then
            romoverlay.Image = My.Resources.OKoverlay
        Else
            romoverlay.Image = My.Resources.nooverlay
        End If

        If row.Cells(11).Value = True Then
            romsave.Image = My.Resources.OKMem
        Else
            romsave.Image = My.Resources.nomem
        End If
    End Sub
    Public Function AreSameImage(ByVal I1 As Image, ByVal I2 As Image) As Boolean
        Dim BM1 As Bitmap = I1
        Dim BM2 As Bitmap = I2
        For X = 0 To BM1.Width - 1
            For y = 0 To BM2.Height - 1
                If BM1.GetPixel(X, y) <> BM2.GetPixel(X, y) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
    Public Function FileNameWithoutExtension(ByVal FullPath _
        As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function
    Private Sub RomImage_DoubleClick(sender As Object, e As EventArgs) Handles RomImage.DoubleClick
        System.Diagnostics.Process.Start(FinalGrid.SelectedCells(4).Value.ToString)
    End Sub
    Private Sub Romscreen_DoubleClick(sender As Object, e As EventArgs) Handles romscreen.DoubleClick
        Dim OK As Image = My.Resources.Okscreen
        Dim NO As Image = My.Resources.noscreen

        If AreSameImage(romscreen.Image, OK) Then
            System.Diagnostics.Process.Start(FinalGrid.SelectedCells(4).Value.ToString)
        End If
    End Sub
    Private Sub Rommanual_DoubleClick(sender As Object, e As EventArgs) Handles rommanual.Click
        Dim OK As Image = My.Resources.OKmanual
        Dim NO As Image = My.Resources.nomanual

        If AreSameImage(rommanual.Image, OK) Then

            Process.Start(FinalGrid.SelectedCells(6).Value.ToString)
        End If
    End Sub
    Private Sub Romoverlay_DoubleClick(sender As Object, e As EventArgs) Handles romoverlay.Click
        Dim OK As Image = My.Resources.OKoverlay
        Dim NO As Image = My.Resources.nooverlay

        Dim cheminrom As String = FinalGrid.SelectedCells(2).Value.ToString
        Dim FileInfo As New FileInfo(cheminrom)
        Dim nomdelarom As String = FileInfo.Name
        Dim nomducfg As String = nomdelarom & ".cfg"

        Dim cheminoverlay As String = Replace(cheminrom, "\roms\", "\overlays\")
        Dim testcheminoverlay As String = Replace(cheminoverlay, nomdelarom, nomducfg)

        If AreSameImage(romoverlay.Image, OK) Then
            Process.Start("explorer", Path.GetDirectoryName(testcheminoverlay).ToString)
        End If
    End Sub
    Private Sub Romsave_Click(sender As Object, e As EventArgs) Handles romsave.Click
        Process.Start("explorer", Replace(romsave.ToString, "\roms\", "saves"))
    End Sub
    Sub Calculselection()
        'Refresh des valeurs
        Dim count As Integer = 0
        Dim sommeSize As Integer = 0

        For a = 0 To FinalGrid.RowCount - 1 'Toutes les lignes
            For b = 12 To 12             ' Colonne des checkbox 12
                'si c'est coché, on compte la somme et le nombre de coche
                Dim rompath As String = FinalGrid.Rows(a).Cells(2).Value

                If FinalGrid.Rows(a).Cells(b).Value = True Then
                    count += 1
                    sommeSize += FinalGrid.Rows(a).Cells(b + 1).Value

                    'pour la listbox de la selection
                    If listboxMaSelection.Items.Contains(rompath) Then
                    Else
                        listboxMaSelection.Items.Add(rompath)
                    End If

                ElseIf FinalGrid.Rows(a).Cells(b).Value = False Then
                    'on verifie que le jeu est dans la selection
                    Dim ligneindex As Integer = listboxMaSelection.Items.IndexOf(rompath)
                    If ligneindex <> -1 Then listboxMaSelection.Items.RemoveAt(ligneindex)
                End If
            Next
            FinalGrid.Rows(a).Cells(6).Value = count
        Next

        txt_NbRomSelected.Text = count
        txt_GoAPrevoir.Text = sommeSize
    End Sub

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
                                         e As DataGridViewCellEventArgs) _
                Handles FinalGrid.CellValueChanged
        'check that row isn't -1, i.e. creating datagrid header
        If e.RowIndex = -1 Then
            Exit Sub
        Else
            If e.ColumnIndex = 12 Then
                Dim columnindex As Integer = FinalGrid.CurrentCell.ColumnIndex
                Dim rowIndex As Integer = FinalGrid.CurrentCell.RowIndex

                Dim pathrom As String = FinalGrid.Rows(rowIndex).Cells(2).Value
                'si la case est cochée, alors on ajoute dans la listebox ma selection
                If FinalGrid.Rows(rowIndex).Cells(12).Value = True Then
                    listboxMaSelection.Items.Add(pathrom)

                Else 'sinon, on verifie si la ligne etait présente et si oui, on la supprime

                    On Error Resume Next
                    For i As Integer = 0 To listboxMaSelection.Items.Count - 1
                        Dim ligneencours As String = listboxMaSelection.Items(i).ToString
                        If ligneencours = pathrom Then
                            listboxMaSelection.Items.Remove(pathrom)
                        End If
                    Next
                    On Error GoTo 0
                End If

            End If
            'on refresh les indicateurs
            Dim valeurnbselect As Integer = listboxMaSelection.Items.Count
            txt_NbRomSelected.Text = valeurnbselect

            'On calcule la taille des roms cochée
            Dim sizecumulrom As Integer
            For a = 0 To listboxMaSelection.Items.Count - 1 'Toutes les lignes
                Dim romacchercher As String = listboxMaSelection.Items(a)
                For j = 0 To FinalGrid.RowCount - 1
                    If FinalGrid.Rows(j).Cells(2).Value = romacchercher Then
                        sizecumulrom += FinalGrid.Rows(j).Cells(13).Value

                    End If

                Next
                'On selectionne la ligne pour que le trigger change s'applique
                If listboxMaSelection.Visible = False Then 'si la listbox est invisible on l'affiche et on la rehide
                    listboxMaSelection.Show()
                    'on reboucle pour ne laisser selectionné que le dernier
                    For k = 0 To listboxMaSelection.Items.Count - 1
                        If a = k Then
                            listboxMaSelection.SetSelected(a, True)
                        Else
                            listboxMaSelection.SetSelected(a, False)
                        End If
                    Next
                    listboxMaSelection.Hide()

                Else 'on le fait directement
                    For k = 0 To listboxMaSelection.Items.Count - 1
                        If a = k Then
                            listboxMaSelection.SetSelected(a, True)
                        Else
                            listboxMaSelection.SetSelected(a, False)
                        End If
                    Next

                End If


            Next
            txt_GoAPrevoir.Text = sizecumulrom


        End If
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

    Private Sub Txt_txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txt_txtsearch.TextChanged
        'commande SQL pour filtrer
        TryCast(FinalGrid.DataSource, DataTable).DefaultView.RowFilter = String.Format("romname LIKE '%{0}%'", txt_txtsearch.Text)
                        'on relance le calcul des checkbox
                        Call Completiondescheckbox()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("A faire")
    End Sub

    Private Sub Buttonaffichermaselection_Click(sender As Object, e As EventArgs) Handles buttonaffichermaselection.Click
        If listboxMaSelection.Visible = True Then
            listboxMaSelection.Hide()
        Else
            listboxMaSelection.Show()
        End If
    End Sub


    Private Sub ListboxMaSelection_DoubleClick(sender As Object, e As EventArgs) Handles listboxMaSelection.DoubleClick
        'on enleve de la liste et on met a jour la checkbox dans la selection
        Dim pathrom As String = listboxMaSelection.Items(listboxMaSelection.SelectedIndex)

        For a = 0 To FinalGrid.RowCount - 1 'Toutes les lignes
            If FinalGrid.Rows(a).Cells(2).Value = pathrom Then ' colonne des path
                listboxMaSelection.Items.Remove(pathrom)
                FinalGrid.Rows(a).Cells(12).Value = False
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Txt_GoAPrevoir_TextChanged(sender As Object, e As EventArgs) Handles txt_GoAPrevoir.TextChanged
        txt_morestant.Text = (Val(txt_USBGo.Text) * 1024) - Val(txt_GoAPrevoir.Text)
    End Sub

    Private Sub ListboxMaSelection_SelectedValueChanged(sender As Object, e As EventArgs) Handles listboxMaSelection.SelectedValueChanged
        'Recocher les selections dans le datagrid
        For j = 0 To listboxMaSelection.Items.Count - 1 'toutes les lignes de la listbox

            Dim romselected As String = listboxMaSelection.Items(j)

            For a = 0 To FinalGrid.RowCount - 1 'Toutes les lignes du grid
                If FinalGrid.Rows(a).Cells(2).Value = romselected Then ' colonne des path
                    FinalGrid.Rows(a).Cells(12).Value = True
                    GoTo prochainj
                End If
            Next
prochainj:
        Next
    End Sub
End Class
