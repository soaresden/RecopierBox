Imports System.IO
Public Class OverlayManager
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

    End Sub

    Private Sub OverlayManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ImporterlesGamelists()
    End Sub
    Public Function FileNameWithoutExtension(ByVal FullPath _
    As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function
    Sub completiondesoverlaysRoms()
        Dim compteuroverlay As Integer = 0
        For ligne = 0 To DataGridRoms.RowCount - 1
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
End Class