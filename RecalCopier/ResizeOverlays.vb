Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing

Public Class ResizeOverlays
    Private Sub ButtonGetBack1_Click(sender As Object, e As EventArgs) Handles ButtonGetBack1.Click
        OverlayManager.Show()
        Me.Close()
    End Sub

    Private Sub ResizeOverlays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ImporterlesGamelists()
    End Sub
    Sub ImporterlesGamelists()
        'On Importe toutes les GameLists
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.DossierOverlay, FileIO.SearchOption.SearchTopLevelOnly)
            GameLists.Items.Add(System.IO.Path.GetFileName(folder))
        Next
    End Sub

    Private Sub buttonImport_Click(sender As Object, e As EventArgs) Handles buttonImport.Click
        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If GameLists.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner des Plateformes")
            Exit Sub
        End If

        'Hide les groupbox
        GroupBoxOriginalOverlay.Hide()
        ActualOverlay.Hide()
        GroupBoxNewOverlay.Hide()
        FutureOverlay.Hide()

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
            .ColumnName = "Titre"
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
            .ColumnName = "custom_viewport_x"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "custom_viewport_y"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "custom_viewport_width"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "custom_viewport_height"
        End With
        table.Columns.Add(column)

        For Each i In GameLists.SelectedItems
            Dim nomconsole As String = i
            Dim nbdansdossier As Integer

            If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                nbdansdossier = Directory.GetFiles(My.Settings.RecalboxFolder & "\overlays\" & nomconsole, "*.cfg").Count
            Else
                nbdansdossier = Directory.GetFiles(My.Settings.RecalboxFolder & "\decorations\" & nomconsole, "*.cfg").Count
            End If

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

                If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                    pathdelarom = Replace(Replace(cheminducfg, "\overlays\", "\roms\"), ".cfg", "")
                Else
                    pathdelarom = Replace(Replace(cheminducfg, "\decorations\", "\roms\"), ".cfg", "")
                End If

                'On va rechercher le nom de la rom
                Dim romname = Recherchenomdelarom(nomconsole, pathdelarom)

                'On recupere les valeurs dans les overlay custom
                Dim cvx As Integer = getcustomcfg(cheminducfg, nomconsole, "custom_viewport_x")
                Dim cvy As Integer = getcustomcfg(cheminducfg, nomconsole, "custom_viewport_y")
                Dim cvw As Integer = getcustomcfg(cheminducfg, nomconsole, "custom_viewport_width")
                Dim cvh As Integer = getcustomcfg(cheminducfg, nomconsole, "custom_viewport_height")

                'on ajoute au tableau
                table.Rows.Add(nomconsole, romname, nomfichiercfg, cheminducfg, cvx, cvy, cvw, cvh)

fichiersuivant:
            Next
nextconsole:
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        DataGridOverlays.DataSource = table

        'On ajoute la checkbox pour les overlays
        Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn With {
            .HeaderText = "CocheOverlay",
            .Name = "CocheOverlay"
        }
        DataGridOverlays.Columns.Add(chk)

        'Reajusting Interface and Showing Final Interface
        dv.Sort = "Console asc, Titre asc"

        'Width for columns
        DataGridOverlays.RowHeadersWidth = 25
        DataGridOverlays.Columns("Console").Width = 40
        DataGridOverlays.Columns("Titre").Width = 145
        DataGridOverlays.Columns("NomdeRom").Width = 10
        DataGridOverlays.Columns("CheminOverlay").Width = 50
        DataGridOverlays.Columns("CocheOverlay").Width = 25

        DataGridOverlays.Columns("custom_viewport_x").Width = 40
        DataGridOverlays.Columns("custom_viewport_y").Width = 40
        DataGridOverlays.Columns("custom_viewport_width").Width = 55
        DataGridOverlays.Columns("custom_viewport_height").Width = 55

        'Hiding les colonnes
        DataGridOverlays.Columns("NomdeRom").Visible = False
        DataGridOverlays.Columns("CheminOverlay").Visible = True

        'On met la derniere colonne coche en readonly
        DataGridOverlays.Columns("CocheOverlay").ReadOnly = True

        'On compte le nombre total d'entrées
        TotalOverlay.Text = DataGridOverlays.Rows.Count - 1

        'On remplit les Coches Overlays
        Call CompletiondesoverlaysRoms()

        'Show les groupbox et l'image
        GroupBoxOriginalOverlay.Show()
        ActualOverlay.Show()
        GroupBoxNewOverlay.Show()
        FutureOverlay.Show()

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

    Sub CompletiondesoverlaysRoms()
        For ligne = 0 To DataGridOverlays.RowCount - 2
            Dim testcheminoverlay As String = DataGridOverlays.Rows(ligne).Cells(DataGridOverlays.Columns("CheminOverlay").Index).Value

            DataGridOverlays.Rows(ligne).Cells(DataGridOverlays.Columns("CheminOverlay").Index).Value = testcheminoverlay

            If System.IO.File.Exists(testcheminoverlay) Then
                DataGridOverlays.Rows(ligne).Cells(DataGridOverlays.Columns("CocheOverlay").Index).Value = True
                DataGridOverlays.Rows(ligne).Cells(DataGridOverlays.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(162, 255, 162)
            Else
                DataGridOverlays.Rows(ligne).Cells(DataGridOverlays.Columns("CocheOverlay").Index).Value = False
                DataGridOverlays.Rows(ligne).Cells(DataGridOverlays.Columns("CocheOverlay").Index).Style.BackColor = Color.FromArgb(255, 139, 139)
            End If
        Next
    End Sub

    Function getcustomcfg(pathducfg As String, console As String, parametresouhaite As String)
        'on va lire le cfg pour trouver le cfg overlay
        File.ReadAllLines(pathducfg)
        Dim readText() As String = File.ReadAllLines(pathducfg)
        Dim s As String

        For Each s In readText
            Dim detectinputoverlay As String

            If InStr(s, parametresouhaite) > 0 Then
                Dim valeuregal As Integer = InStr(s, "=")
                Dim valeurvalue As String = s.Substring(valeuregal + 2)
                Dim vraievaleur As Integer = Integer.Parse(Regex.Replace(valeurvalue, "[^\d]", ""))

                Return vraievaleur
            End If
        Next
    End Function

    Function LectureDesCfgs(consolerom As String, nomducfg As String)
        Dim modifgamelistenrom As String = nomducfg

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
        File.ReadAllLines(fichier1cfg)

        Dim readText() As String = File.ReadAllLines(fichier1cfg)
        Dim s As String

        For Each s In readText
            Dim detectinputoverlay As String

            If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                detectinputoverlay = InStr(s, "/overlays/")
            Else
                detectinputoverlay = InStr(s, "/decorations/")
            End If

            If detectinputoverlay > 0 Then
                'Dim cheminducfgoverlay = s.Substring(detectinputoverlay + 9)
                'Dim detectdupointcfg = InStr(cheminducfgoverlay, ".cfg")
                'Dim cheminfinaloverlaycfg = cheminducfgoverlay.Substring(0, detectdupointcfg + 3)

                Dim chemincfgoverlaydanscfg As String

                If InStr(My.Settings.DossierOverlay, "overlays") > 0 Then
                    chemincfgoverlaydanscfg = s.Substring(InStr(s, "/overlays/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/overlays/") + 9), ".cfg") + 3)
                Else
                    chemincfgoverlaydanscfg = s.Substring(InStr(s, "/decorations/") + 9).Substring(0, InStr(s.Substring(InStr(s, "/decorations/") + 9), ".cfg") + 3)
                End If

                cheminpropreoverlay2 = My.Settings.DossierOverlay & Replace(chemincfgoverlaydanscfg, "/", "\")
                justefichier2 = FileNameWithoutExtension(cheminpropreoverlay2) & ".cfg"
                Exit For
            End If
        Next

        'on lit le deuxieme fichier overlay cfg pour trouver le png
        If Not File.Exists(cheminpropreoverlay2) Then Exit Function
        File.ReadAllLines(cheminpropreoverlay2)

        Dim readText2() As String = File.ReadAllLines(cheminpropreoverlay2)
        Dim t As String

        For Each t In readText2
            Dim detectoverlayzero As String = InStr(t, "overlay0_overlay")
            If detectoverlayzero > 0 Then
                Dim enlevelesguill = Replace(t, Chr(34), "")
                'Dim leegal = InStr(enlevelesguill, "=")
                'Dim chemindupng = enlevelesguill.Substring(leegal + 1)
                'Dim detectpng = InStr(chemindupng, "png")
                'Dim cheminfinalpng = chemindupng.Substring(0, detectpng + 2)

                Dim cheminpng = enlevelesguill.Substring(InStr(enlevelesguill, "=") + 1).Substring(0, InStr(enlevelesguill.Substring(InStr(enlevelesguill, "=") + 1), "png") + 2)
                fichier3png = Replace(cheminpropreoverlay2, justefichier2, cheminpng)
                Exit For
            End If
        Next
        'on ajoute a la listbox
        Return fichier3png
    End Function

    Public Function FileNameWithoutExtension(ByVal FullPath _
As String) As String
        Return System.IO.Path.GetFileNameWithoutExtension(FullPath)
    End Function

    Private Sub DataGridOverlays_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridOverlays.SelectionChanged
        Dim row As DataGridViewRow = DataGridOverlays.CurrentRow
        Dim totalline As Integer = DataGridOverlays.RowCount - 1

        If DataGridOverlays.SelectedRows.Count = 0 Then
            Exit Sub
        ElseIf DataGridOverlays.CurrentRow.Index >= totalline Then
            Exit Sub
        End If
        'Chargement de l'image

        Dim console As String = row.Cells(DataGridOverlays.Columns("Console").Index).Value
        Dim adressecfg As String = row.Cells(DataGridOverlays.Columns("CheminOverlay").Index).Value
        Dim png As String = LectureDesCfgs(console, adressecfg)

        ActualOverlay.Image = Image.FromFile(png)

        'Recuperer la taille du fichier
        LargeurOriginale.Text = Image.FromFile(png).Size.Width
        HauteurOriginale.Text = Image.FromFile(png).Size.Height

    End Sub
End Class