Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.ComponentModel
Public Class ResizeOverlaysBato
    Private Sub ResizeOverlaysBato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide des elements
        GroupBoxOriginalOverlay.Hide()
        ActualOverlay.Hide()
        PicXrandr.Hide()

        Call ImporterlesGamelists()
    End Sub

    Private Sub ButtonGetBack1_Click(sender As Object, e As EventArgs) Handles ButtonGetBack1.Click
        OverlayManager.Show()
        Me.Close()
    End Sub

    Sub ImporterlesGamelists()
        'On Importe toutes les GameLists
        For Each folder As String In My.Computer.FileSystem.GetDirectories(My.Settings.DossierOverlay, FileIO.SearchOption.SearchTopLevelOnly)
            GameLists.Items.Add(System.IO.Path.GetFileName(folder))
        Next
    End Sub

    Private Sub BouttonImport_Click(sender As Object, e As EventArgs) Handles buttonImport.Click
        'Conditionnelle pour ne rien lancer si aucun selectionnés
        If GameLists.SelectedItems.Count = 0 Then
            MsgBox("Merci de Selectionner des Plateformes")
            Exit Sub
        End If

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
            .ColumnName = "top"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "left"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "bottom"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "right"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "PngX"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "PngY"
        End With
        table.Columns.Add(column)

        For Each i In GameLists.SelectedItems
            Dim dossieroverlay As String = i
            Dim nomconsole As String
            Dim nbdansdossier As Integer

            Dim di As New IO.DirectoryInfo(My.Settings.DossierOverlay & dossieroverlay)
            Dim aryFi As IO.FileInfo() = di.GetFiles("*.info", SearchOption.AllDirectories)
            Dim fi As IO.FileInfo
            Dim nomfichiercfg As String
            Dim cheminducfg As String
            Dim pathdelarom As String
            Dim detectgames As Boolean
            Dim detectsystem As Boolean

            For Each fi In aryFi


                cheminducfg = fi.FullName
                nomfichiercfg = fi.Name

                'test games ou system
                If InStr(cheminducfg, "games\") > 1 Then
                    detectgames = True
                    detectsystem = False
                    nomconsole = Replace(cheminducfg, My.Settings.DossierOverlay & dossieroverlay & "\games\", "").Substring(0, InStr(Replace(cheminducfg, My.Settings.DossierOverlay & dossieroverlay & "\games\", ""), "\") - 1)
                Else
                    detectgames = False
                    detectsystem = True
                    nomconsole = Path.GetFileNameWithoutExtension(fi.Name)
                End If



                'On va rechercher le nom de la rom
                Dim romname = Recherchenomdelarom(nomconsole, nomfichiercfg)

                'On recupere les valeurs dans les overlay custom
                Dim cvtop As Integer = Getcustomcfg(cheminducfg, "top")
                Dim cvleft As Integer = Getcustomcfg(cheminducfg, "left")
                Dim cvbottom As Integer = Getcustomcfg(cheminducfg, "bottom")
                Dim cvright As Integer = Getcustomcfg(cheminducfg, "right")

                Dim png As System.Drawing.Image = System.Drawing.Image.FromFile(Replace(cheminducfg, ".info", ".png"))
                Dim pngx As Integer = png.Width
                Dim pngy As Integer = png.Height
                png.Dispose()

                'on ajoute au tableau
                table.Rows.Add(nomconsole, romname, nomfichiercfg, cheminducfg, cvtop, cvleft, cvbottom, cvright, pngx, pngy)

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
        DataGridOverlays.Columns("Titre").Width = 130
        DataGridOverlays.Columns("NomdeRom").Width = 10
        DataGridOverlays.Columns("CheminOverlay").Width = 30
        DataGridOverlays.Columns("CocheOverlay").Width = 25

        DataGridOverlays.Columns("top").Width = 35
        DataGridOverlays.Columns("left").Width = 35
        DataGridOverlays.Columns("bottom").Width = 35
        DataGridOverlays.Columns("right").Width = 35
        DataGridOverlays.Columns("PngX").Width = 40
        DataGridOverlays.Columns("PngY").Width = 40

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

    End Sub
    Function Recherchenomdelarom(console As String, pathdelarom As String)
        Dim lagamelist As String = My.Settings.RecalboxFolder & "\roms\" & console & "\gamelist.xml"
        Dim nomdelarom = pathdelarom

        'Si il n'existe pas de gamelist, on va mettre les infos generique
        If Not System.IO.File.Exists(lagamelist) Then
            Return "#NOGAMELIST#-" & nomdelarom
        End If

        Dim gamelistXml As XElement = XElement.Load(lagamelist)

        'getting the list for the xml with nodes
        Dim query2 = From st In gamelistXml.Descendants("game") Select st
        Dim genpathdelarom As String
        genpathdelarom = My.Settings.RecalboxFolder & "\roms\" & console & "\" & nomdelarom

        'test de l'overlay = console
        If console = Path.GetFileNameWithoutExtension(nomdelarom) Then
            Return "#CONSOLE#"
        End If

        For Each xEle As XElement In query2
            Dim romname As String = xEle.Element("name")
            Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
            Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & console & "\" & temprom



            If Path.GetFileNameWithoutExtension(Path.GetFileName(rompath)) = Path.GetFileNameWithoutExtension(pathdelarom) Then
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

    Function Getcustomcfg(pathducfg As String, parametresouhaite As String)
        'on va lire le cfg pour trouver le cfg overlay
        File.ReadAllLines(pathducfg)
        Dim readText() As String = File.ReadAllLines(pathducfg)
        Dim s As String

        For Each s In readText

            If InStr(s, parametresouhaite) > 0 Then
                Dim valeuregal As Integer = InStr(s, "=")
                Dim valeurvalue As String = s.Substring(valeuregal + 2)
                Dim vraievaleur As Integer = Integer.Parse(Regex.Replace(valeurvalue, "[^\d]", ""))

                Return vraievaleur
            End If
        Next
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
        Dim png As String = Replace(row.Cells(DataGridOverlays.Columns("CheminOverlay").Index).Value, ".info", ".png")
        On Error Resume Next

        ActualOverlay.Image = Image.FromFile(png)
        'Recuperer la taille du fichier
        LargeurOriginale.Text = row.Cells(DataGridOverlays.Columns("PngX").Index).Value
        HauteurOriginale.Text = row.Cells(DataGridOverlays.Columns("PngY").Index).Value

        On Error GoTo 0
    End Sub
    Private Sub ChkOriginalReplace_CheckedChanged(sender As Object, e As EventArgs) Handles chkOriginalReplace.CheckedChanged
        If chkOriginalReplace.Checked = True Then
            chkOriginalReplace.Checked = True
            chkcopysomewhere.Checked = False
        Else
            chkOriginalReplace.Checked = False
            chkcopysomewhere.Checked = True
        End If
    End Sub
    Private Sub Chkcopysomewhere_CheckedChanged(sender As Object, e As EventArgs) Handles chkcopysomewhere.CheckedChanged
        If chkcopysomewhere.Checked = True Then
            chkOriginalReplace.Checked = False
            chkcopysomewhere.Checked = True
        Else
            chkOriginalReplace.Checked = True
            chkcopysomewhere.Checked = False
        End If
    End Sub
    Private Sub ButtonGoResize_Click(sender As Object, e As EventArgs) Handles ButtonGoResize.Click
        If MsgBox("Etes vous sur de vouloir redimensionner l'intégralité du tableau ?", vbYesNo) = vbNo Then Exit Sub
        Dim typedecopie As String

        If chkOriginalReplace.Checked = True Then
            typedecopie = "Replacement"
        Else
            typedecopie = "Nouveau"
        End If

        'On va boucler pour le tableau entier
        For i = 0 To DataGridOverlays.Rows.Count - 2
            'Lecture des values originales
            Dim console As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("Console").Index).Value
            Dim adressecfg As String = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("CheminOverlay").Index).Value
            Dim cvtop As Integer = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("top").Index).Value
            Dim cvleft As Integer = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("left").Index).Value
            Dim cvbottom As Integer = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("bottom").Index).Value
            Dim cvright As Integer = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("right").Index).Value
            Dim pngwidth As Integer = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("PngX").Index).Value
            Dim pngheight As Integer = DataGridOverlays.Rows(i).Cells(DataGridOverlays.Columns("PngY").Index).Value
            Dim systemorgames As Integer = InStr(adressecfg, "games\")


            'Si on est en mode Nouveau, il faut copier le fichier au prealable
            If typedecopie = "Nouveau" Then
                Dim dossierdefin As String
                'on va creer le chemin final selon system or games
                If systemorgames > 1 Then
                    dossierdefin = "\games\"
                Else
                    dossierdefin = "\systems\"
                End If

                Dim nouveauchemincfg As String = My.Settings.DossierOverlay & "aCUSTOM RESOLUTION - " & NouveauX.Text & "x" & NouveauY.Text & dossierdefin
                If (Not System.IO.Directory.Exists(nouveauchemincfg)) Then
                    System.IO.Directory.CreateDirectory(nouveauchemincfg)
                End If

                Dim cheminfinal = nouveauchemincfg & Path.GetFileName((adressecfg))
                System.IO.File.Copy(adressecfg, cheminfinal, True)

                'on oublie pas de copier le png dans le nouveau repertoire
                Dim adressepng = Replace(adressecfg, ".info", ".png")
                Dim cheminfinalpng = Replace(cheminfinal, ".info", ".png")
                System.IO.File.Copy(adressepng, cheminfinalpng, True)
                adressecfg = cheminfinal

            End If


            'On fait du ligne a ligne pour trouver la bonnne ligne et on remplace
            Dim lines() As String = IO.File.ReadAllLines(adressecfg)
                For j As Integer = 0 To lines.Length - 1
                If lines(j).Contains("width") Then
                    Dim ligneoriginaleX = Integer.Parse(Regex.Replace(lines(j), "[^\d]", ""))
                    Dim nouvelleligneX = " " & Chr(34) & "width" & Chr(34) & ":" & NouveauX.Text & ","
                    lines(j) = nouvelleligneX
                End If
                If lines(j).Contains("height") Then
                    Dim ligneoriginaleYX = Integer.Parse(Regex.Replace(lines(j), "[^\d]", ""))
                    Dim nouvelleligneY = " " & Chr(34) & "height" & Chr(34) & ":" & NouveauY.Text & ","
                    lines(j) = nouvelleligneY
                End If
            Next

                IO.File.WriteAllLines(adressecfg, lines) 'assuming you want to write the file

            'On va maintenant remplacer les valeurs par les nouvelles calculées
            Dim ratiodux As Double = LargeurOriginale.Text / NouveauX.Text
            Dim ratioduy As Double = HauteurOriginale.Text / NouveauY.Text

            Dim newvalx1 As Integer = Math.Round(cvleft / ratiodux, 0)
            Dim newvalx2 As Integer = Math.Round(cvright / ratiodux, 0)
            Dim newvaly1 As Integer = Math.Round(cvtop / ratioduy, 0)
            Dim newvaly2 As Integer = Math.Round(cvbottom / ratioduy, 0)

            Dim lines2() As String = IO.File.ReadAllLines(adressecfg)
            Dim derniereligne = lines2.Length - 2

            For j As Integer = 0 To lines2.Length - 1
                If lines2(j).Contains("left") Then
                    Dim ligneoriginaleX1 = Integer.Parse(Regex.Replace(lines2(j).ToString, "[^\d]", ""))
                    Dim nouvelleligneX1 = " " & Chr(34) & "left" & Chr(34) & ":" & newvalx1 & ","
                    lines2(j) = nouvelleligneX1
                End If
                If lines2(j).Contains("right") Then
                    Dim ligneoriginaleX2 = Integer.Parse(Regex.Replace(lines2(j).ToString, "[^\d]", ""))
                    Dim nouvelleligneX2 = " " & Chr(34) & "right" & Chr(34) & ":" & newvaly2 & ","
                    lines2(j) = nouvelleligneX2
                End If
                If lines2(j).Contains("top") Then
                    Dim ligneoriginaleY1 = Integer.Parse(Regex.Replace(lines2(j).ToString, "[^\d]", ""))
                    Dim nouvelleligneY1 = " " & Chr(34) & "top" & Chr(34) & ":" & newvaly1 & ","
                    lines2(j) = nouvelleligneY1
                End If
                If lines2(j).Contains("bottom") Then
                    Dim ligneoriginaleY2 = Integer.Parse(Regex.Replace(lines2(j).ToString, "[^\d]", ""))
                    Dim nouvelleligneY2 = " " & Chr(34) & "bottom" & Chr(34) & ":" & newvaly2 & ","
                    lines2(j) = nouvelleligneY2
                End If

                'verifier que la derniere ligne n'est pas une virgule

                If lines2(derniereligne).Contains(",") Then
                    Dim derniereligneoriginale = lines2(derniereligne)
                    Dim dernierelignesansvirgule = Replace(derniereligneoriginale, ",", "")
                    lines2(derniereligne) = dernierelignesansvirgule
                End If
            Next

            IO.File.WriteAllLines(adressecfg, lines2)

            'Fichier suivant
        Next i

        MsgBox("Redimensionnement des Fichiers CFG Terminé")
        If typedecopie = "Nouveau" Then
            MsgBox("Votre Dossier s'appelle : " & Chr(10) & Chr(10) & "aCUSTOM RESOLUTION - " & NouveauX.Text & "x" & NouveauY.Text)
        End If
        Dim dossieraouvrir As String = My.Settings.DossierOverlay
        Process.Start(dossieraouvrir)
    End Sub

    Private Sub ButtonKnowResolution_Click(sender As Object, e As EventArgs) Handles ButtonKnowResolution.Click
        If PicXrandr.Visible = True Then
            PicXrandr.Hide()
            Exit Sub
        End If

        If PicXrandr.Visible = False Then
            PicXrandr.Show()
            MsgBox("Ouvrir Putty en SSH (Putty)" & Chr(10) & "Apres avoir mis le mot de passe de votre distribution, ecrire" & Chr(10) & "xrandr" & Chr(10) & "on vous indique la resolution (en rose)")
        End If

    End Sub

    Private Sub ResizeOverlays_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Show()
        Me.Show()
    End Sub
End Class