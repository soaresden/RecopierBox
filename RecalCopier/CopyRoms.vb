Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Xml.Linq
Imports WMPLib
Imports System.Reflection
Public Class CopyRoms
    Private Playlist As WMPLib.IWMPPlaylist
    Private Sub ButtonImportXML_click(sender As Object, e As EventArgs) Handles ButtonImportXML.Click

        Dim list As List(Of String) = GetFilesRecursive(My.Settings.RecalboxFolder & "\roms")

        ' Loop through and display each path.
        For Each path In list
            ListBox1.Items.Add(path)
        Next

        MsgBox(list.Count & " Plateformes ajoutées")

        'showing gridview2
        TempGrid.Hide()
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
        'Showing stuff
        TempGrid.Show()
        FinalGrid.Show()

        If ListBox1.Items.Count = 0 Then Exit Sub
        Dim gamelist As String = ListBox1.Items(0)

        'Cloning Columns to Datagrid 2
        Dim x As Integer

        For x = 0 To TempGrid.Columns.Count - 1
            FinalGrid.Columns.Add(TempGrid.Columns(x).Clone())
        Next

        'Loop for every gamelists
        For i = 0 To ListBox1.Items.Count - 1

            gamelist = ListBox1.Items(i)

            'generating the console name
            Dim console As String = ListBox1.Items(i)
            Dim chercheroms As String = InStr(console, "roms\",)
            Dim finphrase As String = console.Substring((chercheroms + 4))
            Dim detectedeuz As String = InStr(finphrase, "\gamelist.xml")
            Dim findugame As String = finphrase.Substring(0, detectedeuz - 1)
            Dim nomconsole As String = ListBox1.Items(i).Substring((InStr(ListBox1.Items(i), "roms\",) + 4)).Substring(0, InStr(ListBox1.Items(i).Substring((InStr(ListBox1.Items(i), "roms\",) + 4)), "\gamelist.xml") - 1)

            Dim gamelistXml As XElement = XElement.Load(gamelist)

            'getting the list for the xml with nodes
            Dim query = From st In gamelistXml.Descendants("game")
                        Select New With {
                  .romconsole = nomconsole,
                  .romname = st.<name>.Value,
                  .rompath = Replace(My.Settings.RecalboxFolder & "\roms\" & nomconsole & Replace(st.<path>.Value, "./", "\"), "/", "\"),
                  .romdesc = st.<desc>.Value,
                  .romimage = Replace(My.Settings.RecalboxFolder & "\roms\" & nomconsole & Replace(st.<image>.Value, "./", "\"), "/", "\"),
                  .romvideo = Replace(My.Settings.RecalboxFolder & "\roms\" & nomconsole & Replace(st.<video>.Value, "./", "\"), "/", "\")}

            'getting the whole informations to the gridview1
            TempGrid.DataSource = query.ToList()

            'conditionnal for the first time
            If FinalGrid.Columns.Count = 0 Then
                For Each dgvc As DataGridViewColumn In TempGrid.Columns
                    FinalGrid.Columns.Add(TryCast(dgvc.Clone(), DataGridViewColumn))
                Next
            End If

            'Cloning the datagridview1 for the 2nd one
            Dim row As New DataGridViewRow()

            For j As Integer = 0 To TempGrid.Rows.Count - 1
                row = DirectCast(TempGrid.Rows(j).Clone(), DataGridViewRow)
                Dim intColIndex As Integer = 0
                For Each cell As DataGridViewCell In TempGrid.Rows(j).Cells
                    row.Cells(intColIndex).Value = cell.Value
                    intColIndex += 1
                Next
                FinalGrid.Rows.Add(row)
            Next
        Next
        'hiding the first grid
        TempGrid.Hide()
        'Sorting A-Z the console
        FinalGrid.Sort(FinalGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        'Width for columns
        FinalGrid.Columns(0).Width = 30
        FinalGrid.Columns(1).Width = 200
        FinalGrid.Columns(2).Width = 1
        FinalGrid.Columns(3).Width = 1
        FinalGrid.Columns(4).Width = 1
        FinalGrid.Columns(5).Width = 40

        'add checkable column at the end
        Dim chk As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(chk)
        chk.HeaderText = "Selection"
        chk.Name = "Coche"
        chk.Width = 10

        Dim overlay As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(overlay)
        overlay.HeaderText = "Overlay ?"
        overlay.Name = "Coche"
        overlay.Width = 10

        Dim saves As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(saves)
        saves.HeaderText = "Saves ?"
        saves.Name = "Coche"
        saves.Width = 10

        Dim image As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(image)
        image.HeaderText = "Saves ?"
        image.Name = "Coche"
        image.Width = 10

        Dim video As New DataGridViewCheckBoxColumn()
        FinalGrid.Columns.Add(video)
        video.HeaderText = "Saves ?"
        video.Name = "Coche"
        video.Width = 10


        'Reajusting Interface and Showing Final Interface
        ButtonImportXML.Hide()
        ListBox1.Hide()
        lbl_gamelist.Hide()
        FinalGrid.Location = New Point(11, 28)
        FinalGrid.Size = New Size(596, 402)
        grp_RomInfos.Show()
        GroupBox1.Show()
        ButtonShowGames.Hide()
        MsgBox("Bibliotheque Chargée")
    End Sub

    Private Sub CopyRoms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hiding buttons and datagrids
        TempGrid.Hide()
        FinalGrid.Hide()
        ButtonShowGames.Hide()
        GroupBox1.Hide()
        lbl_bibliorecalbox.Hide()
        grp_RomInfos.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttongetback.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub FinalGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FinalGrid.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = FinalGrid.Rows(e.RowIndex)
            txt_romname.Text = row.Cells(1).Value.ToString
            txt_rompath.Text = row.Cells(2).Value.ToString
            txt_romdesc.Text = row.Cells(3).Value.ToString

            'calcul du vide pour ne pas afficher
            Dim console As String = row.Cells(0).Value.ToString
            Dim cheminduvide = My.Settings.RecalboxFolder & "\roms\" & console

            If row.Cells(4).Value.ToString = cheminduvide Then
                RomImage.Hide()
            Else
                RomImage.Show()
                RomImage.Image = Image.FromFile(row.Cells(4).Value.ToString)
            End If

            If row.Cells(5).Value.ToString = cheminduvide Then
                vid_romvid.Hide()
            Else
                vid_romvid.Show()
                vid_romvid.URL = row.Cells(5).Value.ToString

                vid_romvid.uiMode = "none"
                vid_romvid.settings.setMode("loop", True)

                vid_romvid.settings.mute = True
                vid_romvid.Ctlcontrols.play()
            End If
        End If
    End Sub

    Private Sub RomImage_DoubleClick(sender As Object, e As EventArgs) Handles RomImage.DoubleClick
        System.Diagnostics.Process.Start(FinalGrid.SelectedCells(4).Value.ToString)
    End Sub

End Class