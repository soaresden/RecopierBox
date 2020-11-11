﻿Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Xml.Linq
Imports WMPLib
Imports System.Reflection
Imports System.Drawing.Imaging


Public Class CopyRoms
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
            Dim console As String = i
            Dim chercheroms As String = InStr(console, "roms\",)
            Dim finphrase As String = console.Substring((chercheroms + 4))
            Dim detectedeuz As String = InStr(finphrase, "\gamelist.xml")
            Dim findugame As String = finphrase.Substring(0, detectedeuz - 1)

            Dim nomconsole As String = i.Substring((InStr(i, "roms\",) + 4)).Substring(0, InStr(i.Substring((InStr(i, "roms\",) + 4)), "\gamelist.xml") - 1)

            gamelist = i

            Dim gamelistXml As XElement = XElement.Load(gamelist)

            'getting the list for the xml with nodes
            Dim query2 = From st In gamelistXml.Descendants("game") Select st

            For Each xEle As XElement In query2
                Dim romconsole As String = nomconsole
                Dim romname As String = xEle.Element("name")
                Dim rompath As String = Replace(My.Settings.RecalboxFolder & "\roms\" & nomconsole & Replace(xEle.Element("path"), "./", "\"), "/", "\")

                Dim romdesc As String
                Dim romimage As String
                Dim romvideo As String
                Dim romanual As String


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
            Next
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        FinalGrid.DataSource = table

        'Width for columns
        FinalGrid.Columns(0).Width = 60     'romconsole
        FinalGrid.Columns(1).Width = 200    'romname
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
        colromimage.Width = 30

        Dim colromvideo As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromvideo)
        colromvideo.HeaderText = "Video"
        colromvideo.Name = "Coche"
        colromvideo.Width = 30

        Dim colromanual As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromanual)
        colromanual.HeaderText = "Manual"
        colromanual.Name = "Coche"
        colromanual.Width = 30

        Dim colromoverlay As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromoverlay)
        colromoverlay.HeaderText = "Overlay"
        colromoverlay.Name = "Coche"
        colromoverlay.Width = 30

        Dim colromsaves As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromsaves)
        colromsaves.HeaderText = "Save"
        colromsaves.Name = "Coche"
        colromsaves.Width = 30

        Dim colromselection As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(colromselection)
        colromselection.HeaderText = "Selection"
        colromselection.Name = "Coche"
        colromselection.Width = 50

        'Ajout de la taille de la rom 
        Dim colromSize As New DataGridViewTextBoxColumn()
        FinalGrid.Columns.Add(colromSize)
        colromSize.HeaderText = "Mo"
        colromSize.Name = "Coche"
        colromSize.Width = 50

        'Reajusting Interface and Showing Final Interface
        ButtonImportXML.Hide()
        ListGameLists.Hide()
        lbl_gamelist.Hide()
        FinalGrid.Location = New Point(11, 28)
        FinalGrid.Size = New Size(596, 402)
        grp_RomInfos.Show()
        GroupBox1.Show()
        ButtonShowGames.Hide()
        txt_TotalRoms.Hide()

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

            If (attr And FileAttributes.Directory) = FileAttributes.Directory Then
                size = GetDirectorySize(chemindelarom)
            Else
                Dim info As New FileInfo(chemindelarom)
                size = info.Length
            End If
            'Conversion en Mo
            Dim nouvelletaille As Decimal = size / 1024
            Dim tailleenmo As Decimal = nouvelletaille / 1000

            oRow.Cells(13).Value = Math.Round(tailleenmo, 1)
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
            If oRow.Cells(4).Value IsNot Nothing Then
                oRow.Cells(7).Value = True
            Else
                oRow.Cells(7).Value = False
            End If

            'test sur le chemin des videos
            If oRow.Cells(5).Value IsNot Nothing Then
                oRow.Cells(8).Value = True
            Else
                oRow.Cells(8).Value = False
            End If

            'test sur le chemin des manuels
            If oRow.Cells(6).Value IsNot Nothing Then
                oRow.Cells(9).Value = True
            Else
                oRow.Cells(9).Value = False
            End If

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
    Private Sub CopyRoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hiding buttons and datagrids
        txt_TotalRoms.Hide()
        FinalGrid.Hide()
        ButtonShowGames.Hide()
        GroupBox1.Hide()
        lbl_bibliorecalbox.Hide()
        grp_RomInfos.Hide()

        'Launch Import Gamelist button
        ButtonImportXML.PerformClick()
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

    Public Function GetDirectorySize(path As String) As Long
        Dim files() As String = Directory.GetFiles(path, "*", SearchOption.AllDirectories)
        Dim size As Long = 0
        For Each file As String In files
            Dim info As New FileInfo(file)
            size += info.Length
        Next
        Return size
    End Function


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
                If FinalGrid.Rows(a).Cells(b).Value = True Then
                    count += 1
                    sommeSize += FinalGrid.Rows(a).Cells(b + 1).Value
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
            If e.ColumnIndex = 12 Then Call calculselection()
        End If
    End Sub
End Class
