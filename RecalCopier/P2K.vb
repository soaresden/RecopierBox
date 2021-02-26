Imports System.IO

Public Class P2K
    Private Sub P2K_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hide le cote P2k
        Label7.Hide()
        NewP2kFolder.Hide()
        TxtSourisBato.Hide()
        RichTextBox4.Hide()
        Fulladressep2k.Hide()
        LabelP1.Hide()
        LabelP2.Hide()
        LabelP3.Hide()
        LabelP4.Hide()
        RichTextBox0.Hide()
        RichTextBox1.Hide()
        RichTextBox2.Hide()
        RichTextBox3.Hide()
        LabelFT.Hide()
        FinalRichText.Hide()
        WriteFile.Hide()
        ValidConvP2k.Hide()
        ValidDossierDos.Hide()

        'Hide cote Exodos
        Label5.Hide()
        NewAdresseExo.Hide()
        FullNewadresseExo.Hide()
        DoExoConverter.Hide()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start(String.Format("https://github.com/Voljega/ExoDOSConverter/releases/"))
    End Sub
    Private Sub ParcourirExo_Click(sender As Object, e As EventArgs) Handles ParcourirExo.Click
        'Au clic, on ouvre la selection du repertoire
        If FolderBrowserDialog2.ShowDialog() = DialogResult.OK Then
            'Check si un dossier Roms est present dedans
            Dim cheminsaisi As String = FolderBrowserDialog2.SelectedPath
            If (Not System.IO.Directory.Exists(cheminsaisi & "\downloaded_images") And Not System.IO.File.Exists(cheminsaisi & "\gamelist.xml")) Then
                MsgBox("Le Chemin saisi ne possede pas de dossier 'downloaded_images' et/ou de gamelist.xml" & Chr(13) & "Selectionner votre dossier généré par Exodos Converter")
                adresseExo.Text = Nothing
            Else
                adresseExo.Text = FolderBrowserDialog2.SelectedPath
                Call validlecheminexo()
                NewAdresseExo.Focus()
                Label5.Show()
                NewAdresseExo.Show()
                FullNewadresseExo.Show()
            End If
        End If
    End Sub
    Sub validlecheminexo()
        'import de l'adresse
        Dim gamelistXml As XElement = XElement.Load(adresseExo.Text & "\gamelist.xml")

        'On cree le table
        Dim table As New DataTable()
        Dim dv As DataView
        Dim column As DataColumn

        column = New DataColumn()

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "DOS"
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
            .ColumnName = "ID"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Chemin"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Synopsis"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Image"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Manual"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Genre"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Dev"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Publ"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Date"
        End With
        table.Columns.Add(column)



        'getting the list for the xml with nodes
        Dim query2 = From st In gamelistXml.Descendants("game") Select st

        For Each xEle As XElement In query2
            Dim romconsole As String = "dos"
            Dim romname As String = xEle.Element("name")
            Dim romId As String
            Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
            Dim rompath As String = My.Settings.RecalboxFolder & "\" & temprom
            Dim romgenre As String
            Dim romdesc As String
            Dim romimage As String
            Dim romanual As String
            Dim romdev As String
            Dim rompubl As String
            Dim romdate As String

            'Conditionnelles sur tous les champs

            If xEle.Element("desc") Is Nothing Then
                romdesc = Nothing
            Else
                romdesc = xEle.Element("desc")
            End If

            Dim ExistGameId As Boolean = xEle.Attributes("id").Any

            If ExistGameId = True Then
                romId = xEle.Attribute("id").Value
            Else
                romId = Nothing
            End If

            If xEle.Element("image") Is Nothing Then
                romimage = Nothing
            Else
                romimage = adresseExo.Text & "\" & Replace(Replace(Replace(xEle.Element("image"), "/", "\"), "./", ""), ".\", "")
            End If

            If xEle.Element("manual") = "" Then
                romanual = Nothing
            Else
                romanual = adresseExo.Text & "\" & Replace(Replace(Replace(xEle.Element("manual"), "/", "\"), "./", ""), ".\", "")
            End If

            If xEle.Element("genre") Is Nothing Then
                romgenre = Nothing
            Else
                romgenre = xEle.Element("genre")
            End If

            If xEle.Element("developer") Is Nothing Then
                romdev = Nothing
            Else
                romdev = xEle.Element("developer")
            End If

            If xEle.Element("publisher") Is Nothing Then
                rompubl = Nothing
            Else
                rompubl = xEle.Element("publisher")
            End If

            If xEle.Element("releasedate") Is Nothing Then
                romdate = Nothing
            Else
                romdate = xEle.Element("releasedate")
            End If

            'on ajoute le tout dans une table
            table.Rows.Add(romconsole, romname, romId, rompath, romdesc, romimage, romanual, romgenre, romdev, rompubl, romdate)
romsuivante:
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        ExodosSheet.DataSource = table

        'Hiding les colonnes
        ExodosSheet.Columns("DOS").Visible = False
        ExodosSheet.Columns("Titre").Visible = True
        ExodosSheet.Columns("Chemin").Visible = False
        ExodosSheet.Columns("ID").Visible = False
        ExodosSheet.Columns("Synopsis").Visible = False
        ExodosSheet.Columns("Date").Visible = False
        ExodosSheet.Columns("Dev").Visible = True
        ExodosSheet.Columns("Publ").Visible = True
        ExodosSheet.Columns("Genre").Visible = True
        ExodosSheet.Columns("Manual").Visible = True
        ExodosSheet.Columns("Image").Visible = True

        'Width for columns
        ExodosSheet.Columns("Titre").Width = 110
        ExodosSheet.Columns("Date").Width = 80
        ExodosSheet.Columns("Dev").Width = 80
        ExodosSheet.Columns("Publ").Width = 80
        ExodosSheet.Columns("Genre").Width = 80
        ExodosSheet.Columns("Manual").Width = 80
        ExodosSheet.Columns("Image").Width = 70


    End Sub

    Private Sub NewAdresseExo_TextChanged(sender As Object, e As EventArgs) Handles NewAdresseExo.TextChanged
        FullNewadresseExo.Text = adresseExo.Text & "\" & NewAdresseExo.Text
        DoExoConverter.Show()
        FullNewadresseExo.Show()
    End Sub

    Private Sub DoExoConverter_Click(sender As Object, e As EventArgs) Handles DoExoConverter.Click
        If NewAdresseExo.Text = "" Then
            MsgBox("Saisir un nom de dossier svp")
            Exit Sub
        End If

        For i = 0 To ExodosSheet.Rows.Count - 1
            On Error Resume Next
            Dim cheminimage As String = ExodosSheet.Rows(i).Cells(ExodosSheet.Columns("image").Index).Value
            Dim cheminmanual As String = ExodosSheet.Rows(i).Cells(ExodosSheet.Columns("manual").Index).Value
            On Error GoTo 0

            'On va copier coller et creer les dossiers

            If cheminimage <> "" Then
                'on va creer et copier le dossier
                If Not System.IO.Directory.Exists(FullNewadresseExo.Text & "\media\images\") Then
                    MkDir(FullNewadresseExo.Text & "\media\images\")
                End If
                Dim nomdufichier As String = Path.GetFileName(cheminimage)
                Dim finalfichier As String = FullNewadresseExo.Text & "\media\images\" & nomdufichier
                'on copie le fichier
                FileCopy(cheminimage, finalfichier)
                'et on mets le vrai chemin
                ExodosSheet.Rows(i).Cells(ExodosSheet.Columns("image").Index).Value = finalfichier
            End If

            If cheminmanual <> "" Then
                'on va creer et copier le dossier
                If Not System.IO.Directory.Exists(FullNewadresseExo.Text & "\media\manuals\") Then
                    MkDir(FullNewadresseExo.Text & "\media\manuals\")
                End If
                Dim nomdufichier As String = Path.GetFileName(cheminmanual)
                Dim finalfichier As String = FullNewadresseExo.Text & "\media\manuals\" & nomdufichier
                'on copie le fichier
                FileCopy(cheminimage, finalfichier)
                'et on mets le vrai chemin
                ExodosSheet.Rows(i).Cells(ExodosSheet.Columns("manual").Index).Value = finalfichier
            End If

        Next

        'On va copier le gamelist
        FileCopy(adresseExo.Text & "\gamelist.xml", FullNewadresseExo.Text & "\gamelist.xml")

        'On va le modifier
        Dim filePath = FullNewadresseExo.Text & "\gamelist.xml"
        'Create a temp file to write out the new file contents to.
        Dim tempFilePath = Path.GetTempFileName()

        Using reader As New IO.StreamReader(filePath),
            writer As New IO.StreamWriter(tempFilePath)
            Do Until reader.EndOfStream
                Dim line = reader.ReadLine()
                If InStr(line, ".jpg") > 0 Then
                    line = Replace(line, "./downloaded_images", "./media/images")
                End If
                If InStr(line, ".png") > 0 Then
                    line = Replace(line, "./downloaded_images", "./media/images")
                End If
                If InStr(line, ".pdf") > 0 Then
                    line = Replace(line, "./downloaded_images", "./media/manuals")
                End If

                writer.WriteLine(line)
            Loop
        End Using

        'Overwrite the original file with the contents of the temp file and remove the temp file.
        My.Computer.FileSystem.MoveFile(tempFilePath, filePath, True)

        'On ouvre le dossier pour dire que c'est fini
        MsgBox("Conversion en dossier 'Media' terminé")
        Process.Start(FullNewadresseExo.Text & "\media")
        MsgBox("Ecraser le contenu du dossier qui s'ouvre dans votre dossier roms\dos\")
        Process.Start(My.Settings.RecalboxFolder & "\roms\dos\")
    End Sub
    Private Sub BatotoRB_CheckedChanged(sender As Object, e As EventArgs) Handles BatotoRB.CheckedChanged
        ValidDossierDos.Show()
        RbToBato.Checked = Not BatotoRB.Checked
    End Sub

    Private Sub RbToBato_CheckedChanged(sender As Object, e As EventArgs) Handles RbToBato.CheckedChanged
        ValidDossierDos.Show()
        BatotoRB.Checked = Not RbToBato.Checked
    End Sub

    Private Sub ImporterDossierDos(sender As Object, e As EventArgs) Handles ValidDossierDos.Click
        'Au clic, on ouvre la selection du repertoire
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            'Check si un dossier Roms est present dedans
            Dim cheminsaisi As String = FolderBrowserDialog1.SelectedPath
            Dim di As New IO.DirectoryInfo(cheminsaisi)

            Dim aryFiP2K As IO.FileInfo() = di.GetFiles("*.p2k.cfg", SearchOption.AllDirectories)
            Dim aryFiKEYS As IO.FileInfo() = di.GetFiles("*.keys", SearchOption.AllDirectories)

            If (aryFiP2K.Count = 0 Or aryFiKEYS.Count > 1) Or (aryFiP2K.Count > 1 Or aryFiKEYS.Count > 0) Then
                adressepad.Text = FolderBrowserDialog1.SelectedPath
                NewAdresseExo.Focus()
            Else
                MsgBox("Le Chemin saisi ne possede pas de fichiers .p2k.cfg ou .keys" & Chr(13))
                adressepad.Text = Nothing
                Exit Sub
            End If
        End If

        'on check si c'est batocera ou Recalbox
        Dim extension As String

        If RbToBato.Checked = True Then
            RbToBato.Visible = True
            BatotoRB.Visible = False
            extension = "p2k.cfg"
        ElseIf BatotoRB.Checked = True Then
            RbToBato.Visible = False
            BatoToRb.Visible = True
            extension = ".keys"
        End If

        Call ImportdesP2k(extension)

        'on reshow tout
        Label7.Show()
        NewP2kFolder.Show()

        If RbToBato.Checked = True Then
            TxtSourisBato.Show()
            RichTextBox4.Show()
        Else
            TxtSourisBato.Hide()
            RichTextBox4.Hide()
        End If

        NewP2kFolder.Focus()
    End Sub

    Sub ImportdesP2k(extension As String)
        Dim table As New DataTable()
        Dim dv As DataView
        Dim column As DataColumn

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "FichierP2k"
        End With
        table.Columns.Add(column)

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Cheminp2k"
        End With
        table.Columns.Add(column)

        Dim di As New IO.DirectoryInfo(adressepad.Text)
        Dim aryFi As IO.FileInfo()
        If RbToBato.Checked = True Then
            aryfi = di.GetFiles("*." & extension, SearchOption.AllDirectories)
        Else
            aryFi = di.GetFiles("padto" & extension, SearchOption.AllDirectories)
        End If

        Dim fi As IO.FileInfo
        Dim nomfichierdelasave As String
        Dim chemindelasave As String

        For Each fi In aryFi
            chemindelasave = fi.FullName
            If RbToBato.Checked = True Then
                nomfichierdelasave = fi.Name
            Else
                nomfichierdelasave = fi.Directory.Name
            End If
            'on ajoute au tableau
            table.Rows.Add(nomfichierdelasave, chemindelasave)

fichiersuivant:
        Next

        'Sorting A-Z the console
        dv = table.DefaultView
        ListingP2k.DataSource = table

        'Width for columns
        ListingP2k.RowHeadersWidth = 25
        ListingP2k.Columns("FichierP2k").Width = 150
        ListingP2k.Columns("Cheminp2k").Width = 80
        NewP2kFolder.Focus()
    End Sub
    Private Sub NewP2kFolder_TextChanged(sender As Object, e As EventArgs) Handles NewP2kFolder.TextChanged
        Fulladressep2k.Show()
        LabelP1.Show()
        LabelP2.Show()
        LabelP3.Show()
        LabelP4.Show()
        RichTextBox0.Show()
        RichTextBox1.Show()
        RichTextBox2.Show()
        RichTextBox3.Show()
        LabelFT.Show()
        FinalRichText.Show()
        Fulladressep2k.Text = adressepad.Text & "\" & NewP2kFolder.Text
    End Sub

    Private Sub ListingP2k_SelectionChanged(sender As Object, e As EventArgs) Handles ListingP2k.SelectionChanged
        RichTextBox0.Clear()
        RichTextBox1.Clear()
        RichTextBox2.Clear()
        RichTextBox3.Clear()

        On Error Resume Next

        'on ouvre le fichier
        Dim chemindufichier As String = ListingP2k.SelectedRows(0).Cells(ListingP2k.Columns("Cheminp2k").Index).Value
        If chemindufichier = Nothing Then Exit Sub
        'on va lire le fichier en question
        File.ReadAllLines(chemindufichier)

        Dim readText() As String = File.ReadAllLines(chemindufichier)
        Dim s As String


        For Each s In readText
            If RbToBato.Checked = True Then
                If s = "" Then
                    GoTo lignesuivante
                ElseIf s.Substring(0, 1) = "#" Then
                    GoTo lignesuivante
                ElseIf s.Substring(0, 1) = " " Then
                    GoTo lignesuivante
                Else

                    Dim resultats = p2kread(s)


                    'on va mettre ces infos dans le bon textbox
                    Dim playernb = resultats.item1
                    Dim inputpad = resultats.item2
                    Dim realkey = resultats.item3

                    'Generer le texte
                    Dim newtext As String = genererlatouche(LCase(inputpad), UCase(realkey))
                    'on repointe vers le bon 
                    Select Case playernb
                        Case 0
                            RichTextBox0.Text = RichTextBox0.Text & newtext
                        Case 1
                            RichTextBox1.Text = RichTextBox1.Text & newtext
                        Case 2
                            RichTextBox2.Text = RichTextBox2.Text & newtext
                        Case 3
                            RichTextBox3.Text = RichTextBox3.Text & newtext
                    End Select
                End If

            Else
                Dim detectaccolade As Integer = InStr(s, "{")
                Dim detectactionplayer As Integer = InStr(s, "actions_player")
                Dim detecttrigger As Integer = InStr(s, "trigger")
                Dim detecttype As Integer = InStr(s, "type")
                Dim detectarget As Integer = InStr(s, "target")
                Dim detectfincrochet As Integer = InStr(s, "]")
                Dim detectfinaccolade As Integer = InStr(s, "}")

                Dim numplayer As Integer
                Dim trigger As String
                Dim typebutton As String
                Dim targetbutton As String

                If detectaccolade >= 1 Then
                    GoTo lignesuivante
                ElseIf InStr(s, "actions_player") >= 1 Then
                    'on va recuperer le numero du player 
                    numplayer = s.Substring(detectactionplayer + 13, 1)
                    GoTo lignesuivante
                ElseIf detecttrigger >= 1 Then
                    'dim temptrigger = s.Substring(detecttrigger + Len("trigger") + 3)
                    'Dim detectapostrophe As Integer = InStr(trigger, Chr(34))
                    'Dim buttontrigger As String = trigger.Substring(0, detectapostrophe - 1)
                    trigger = s.Substring(detecttrigger + Len("trigger") + 3).Substring(0, InStr(s.Substring(detecttrigger + Len("trigger") + 3), Chr(34)) - 1)
                    GoTo lignesuivante
                ElseIf detecttype >= 1 Then
                    If InStr(s, "mouse") > 1 Then
                        trigger = Nothing
                        GoTo lignesuivante
                    End If
                ElseIf detectarget > 1 Then 'on est sur la derniere ligne donc on peut generer
                    targetbutton = s.Substring(detectarget + Len("target") + 3).Substring(0, InStr(s.Substring(detectarget + Len("target") + 3), Chr(34)) - 1)
                    'on genere la ligne
                    Dim touchesfinales As String = genererlignep2k(numplayer, trigger, targetbutton)

                    'detection du joueur et on mets le texte
                    Select Case numplayer
                        Case 1
                            RichTextBox0.Text = RichTextBox0.Text & touchesfinales & Chr(13)
                        Case 2
                            RichTextBox1.Text = RichTextBox1.Text & touchesfinales & Chr(13)
                        Case 3
                            RichTextBox2.Text = RichTextBox2.Text & touchesfinales & Chr(13)
                        Case 4
                            RichTextBox3.Text = RichTextBox3.Text & touchesfinales & Chr(13)
                    End Select

                    'on remet les variable à 0 puisque on va tout refaire
                    trigger = Nothing
                    typebutton = Nothing
                    targetbutton = Nothing
                    GoTo lignesuivante
                ElseIf detectfincrochet >= 1 Then 'on est a la fin du joueur donc on met numplayer a rien du tout et le reste aussi
                    numplayer = Nothing
                    trigger = Nothing
                    typebutton = Nothing
                    targetbutton = Nothing
                End If
            End If
lignesuivante:
        Next

        If RbToBato.Checked = True Then
            'on enleve les sauts et les virgules de la fin
            RichTextBox0.Text = RichTextBox0.Text.Substring(0, Len(RichTextBox0.Text) - 2)
            RichTextBox1.Text = RichTextBox1.Text.Substring(0, Len(RichTextBox1.Text) - 2)
            RichTextBox2.Text = RichTextBox2.Text.Substring(0, Len(RichTextBox2.Text) - 2)
            RichTextBox3.Text = RichTextBox3.Text.Substring(0, Len(RichTextBox3.Text) - 2)
            On Error GoTo 0
        End If

        WriteFile.Show()
        ValidConvP2k.Show()
    End Sub
    Function p2kread(linetoread As String)
        'read first number
        Dim playernb As Integer = linetoread.Substring(0, 1)

        'read inputpad
        Dim detectegal As Integer = InStr(linetoread, "=")
        Dim inputpad As String = linetoread.Substring(2, detectegal - 4)

        'read realkey
        Dim detectpointvirgule As Integer = InStr(linetoread, ";;")
        Dim realkey As String
        If detectpointvirgule > 1 Then
            realkey = linetoread.Substring(detectegal + 1, detectpointvirgule - (detectegal + 3))
        Else
            If detectegal + 1 > Len(linetoread) Then
                realkey = Nothing
            Else
                realkey = linetoread.Substring(detectegal + 1)
            End If
        End If

        Return (playernb, inputpad, realkey)
    End Function
    Function genererlatouche(inputpad, realkey)
        If inputpad <> "j" Then
            inputpad = Replace(inputpad, "j", "joystick")
        End If
        If inputpad = "l1" Then
            inputpad = Replace(inputpad, "l1", "pageup")
        End If
        If inputpad = "r1" Then
            inputpad = Replace(inputpad, "r1", "pagedown")
        End If

        If realkey = "s01" Then
            realkey = Replace(realkey, "s01", "grave")
        End If
        If realkey = "s02" Then
            realkey = Replace(realkey, "s02", "minus")
        End If
        If realkey = "s03" Then
            realkey = Replace(realkey, "s03", "equal")
        End If
        If realkey = "s04" Then
            realkey = Replace(realkey, "s04", "leftbrace")
        End If
        If realkey = "s05" Then
            realkey = Replace(realkey, "s05", "rightbrace")
        End If
        If realkey = "s06" Then
            realkey = Replace(realkey, "s06", "semicolon")
        End If
        If realkey = "s07" Then
            realkey = Replace(realkey, "s07", "apostrophe")
        End If
        If realkey = "s08" Then
            realkey = Replace(realkey, "s08", "backslash")
        End If
        If realkey = "s09" Then
            realkey = Replace(realkey, "s09", "comma")
        End If
        If realkey = "s10" Then
            realkey = Replace(realkey, "s10", "dot")
        End If

        Dim texte As String = vbTab & vbTab & "{" & Chr(13) &
            vbTab & vbTab & vbTab & Chr(34) & "trigger" & Chr(34) & ": " & Chr(34) & inputpad & Chr(34) & "," & Chr(13) &
            vbTab & vbTab & vbTab & Chr(34) & "type" & Chr(34) & ": " & Chr(34) & "key" & Chr(34) & "," & Chr(13) &
            vbTab & vbTab & vbTab & Chr(34) & "target" & Chr(34) & ": " & Chr(34) & "KEY_" & UCase(realkey) & Chr(34) & Chr(13) &
            vbTab & vbTab & "}," & Chr(13)
        Return texte
    End Function
    Function genererlignep2k(numplayer As Integer, inputpad As String, realkey As String)
        'on transforme l'input au cas ou
        If inputpad <> "j" Then
            inputpad = Replace(inputpad, "joystick", "j")
        End If
        If inputpad = "pageup" Then
            inputpad = Replace(inputpad, "pageup", "l1")
        End If
        If inputpad = "pagedown" Then
            inputpad = Replace(inputpad, "pagedown", "r1")
        End If

        'on transforme la realkey
        realkey = Replace(realkey, "KEY_", "")
        'et on met en minuscule 
        realkey = LCase(realkey)

        If realkey = "grave" Then
            realkey = Replace(realkey, "grave", "s01")
        End If
        If realkey = "minus" Then
            realkey = Replace(realkey, "minus", "s02")
        End If
        If realkey = "equal" Then
            realkey = Replace(realkey, "equal", "s03")
        End If
        If realkey = "leftbrace" Then
            realkey = Replace(realkey, "leftbrace", "s04")
        End If
        If realkey = "rightbrace" Then
            realkey = Replace(realkey, "rightbrace", "s05")
        End If
        If realkey = "semicolon" Then
            realkey = Replace(realkey, "semicolon", "s06")
        End If
        If realkey = "apostrophe" Then
            realkey = Replace(realkey, "apostrophe", "s07")
        End If
        If realkey = "backslash" Then
            realkey = Replace(realkey, "backslash", "s08")
        End If
        If realkey = "comma" Then
            realkey = Replace(realkey, "comma", "s09")
        End If
        If realkey = "dot" Then
            realkey = Replace(realkey, "dot", "s10")
        End If

        Dim ligneentiere As String = numplayer - 1 & ":" & inputpad & " = " & realkey
        Return ligneentiere
    End Function
    Sub savelefichier()

        Dim chemindufichiercomplet As String = ListingP2k.SelectedRows(0).Cells(ListingP2k.Columns("Cheminp2k").Index).Value
        'Dim extension As String = Path.GetFileName(chemindufichiercomplet)
        'Dim premierpoint As Integer = InStr(extension, ".")
        'Dim extensionfichier As String = extension.Substring(premierpoint - 1)

        Dim extensionfichier As String = Path.GetFileName(chemindufichiercomplet).Substring(InStr(Path.GetFileName(chemindufichiercomplet), ".") - 1)
        Dim cheminfinal As String

        If extensionfichier = ".pc.p2k.cfg" Then
            cheminfinal = Replace(chemindufichiercomplet, ".p2k.cfg", "") & "\padto.keys"
        ElseIf extensionfichier = ".p2k.cfg" Then
            cheminfinal = Replace(chemindufichiercomplet, extensionfichier, "padto.keys")
        ElseIf instr(chemindufichiercomplet, ".pc") > 1 And extensionfichier = ".keys" Then
            Dim dossierparent As String = Path.GetDirectoryName(chemindufichiercomplet)
            Dim dossierfinalenreg As String = Path.GetDirectoryName(dossierparent)
            Dim nomdufichierfinal As String = Path.GetFileName(dossierparent) & ".p2k.cfg"
            cheminfinal = dossierfinalenreg & "\" & nomdufichierfinal
        ElseIf extensionfichier = ".keys" Then
            cheminfinal = Replace(chemindufichiercomplet, "padto.keys", ".p2k.cfg")
        Else
            cheminfinal = Replace(chemindufichiercomplet, extensionfichier, ".p2k.cfg")
        End If

        Dim dossierfinal As String = Replace(cheminfinal, adressepad.Text, Fulladressep2k.Text)

        If (Not System.IO.Directory.Exists(Path.GetDirectoryName(dossierfinal))) Then
            MkDir(Path.GetDirectoryName(dossierfinal))
        End If
        System.IO.File.WriteAllText(dossierfinal, FinalRichText.Text)
    End Sub
    Private Sub ValidConvP2k_Click(sender As Object, e As EventArgs) Handles ValidConvP2k.Click
        If NewP2kFolder.Text = "" Then
            MsgBox("Saisir un nom de dossier svp")
            NewP2kFolder.Focus()
            Exit Sub
        End If

        For i = 0 To ListingP2k.Rows.Count - 1
            ListingP2k.ClearSelection()
            ListingP2k.Rows(i).Selected = True
            If RbToBato.Checked = True Then Call genererfichier()
            Call savelefichier()
        Next
        Process.Start(Fulladressep2k.Text)
        MsgBox("Conversion Terminée" & Chr(13) & "Copiez ces dossiers dans votre repertoire")
    End Sub
    Private Sub WriteFile_Click(sender As Object, e As EventArgs) Handles WriteFile.Click
        If NewP2kFolder.Text = "" Then
            MsgBox("Saisir un nom de dossier svp")
            NewP2kFolder.Focus()
            Exit Sub
        End If
        If RbToBato.Checked = True Then
            Call genererfichier()
        End If
        Call savelefichier()
        MsgBox("Conversion Terminée")
    End Sub
    Private Sub ButtonGetBack_Click(sender As Object, e As EventArgs) Handles ButtonGetBack.Click
        Form1.Show()
        Me.Close()
    End Sub
    Sub genererfichier()
        FinalRichText.Clear()

        'On commence a ecrire la forme du fichier
        FinalRichText.Text = "{" & Chr(13)

        'On mets le player 1
        FinalRichText.Text = FinalRichText.Text &
             vbTab & Chr(34) & "actions_player1" & Chr(34) & ": [" & Chr(13) &
        RichTextBox0.Text & Chr(13) & vbTab & "]"

        'On teste le player 2
        If RichTextBox1.Text <> "" Then
            FinalRichText.Text = FinalRichText.Text & "," & Chr(13) &
            vbTab & Chr(34) & "actions_player2" & Chr(34) & ": [" & Chr(13) &
            RichTextBox1.Text & Chr(13) & vbTab & "]"
        End If

        If RichTextBox2.Text <> "" Then
            FinalRichText.Text = FinalRichText.Text & "," & Chr(13) &
            vbTab & Chr(34) & "actions_player3" & Chr(34) & ": [" & Chr(13) &
            RichTextBox2.Text & Chr(13) & vbTab & "]"
        End If

        If RichTextBox3.Text <> "" Then
            FinalRichText.Text = FinalRichText.Text & "," & Chr(13) &
            vbTab & Chr(34) & "actions_player3" & Chr(34) & ": [" & Chr(13) &
            RichTextBox3.Text & Chr(13) & vbTab & "]"
        End If

        Dim tailletexte As Integer = Len(FinalRichText.Text)

        FinalRichText.Text = FinalRichText.Text.Substring(0, tailletexte) & Chr(13) & "}"
    End Sub
    Private Sub RichTextBox0_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox0.GotFocus
        RichTextBox0.Location = New Point(6, 348)
        RichTextBox0.Size = New Point(419, 128)
        RichTextBox0.Show()
        RichTextBox1.Hide()
        RichTextBox2.Hide()
        RichTextBox3.Hide()
        FinalRichText.Hide()
        LabelP1.Show()
        LabelP2.Hide()
        LabelP3.Hide()
        LabelP4.Hide()
    End Sub
    Private Sub RichTextBox0_LostFocus(sender As Object, e As EventArgs) Handles RichTextBox0.LostFocus
        RichTextBox0.Location = New Point(6, 348)
        RichTextBox0.Size = New Point(71, 36)
        RichTextBox0.Show()
        RichTextBox1.Show()
        RichTextBox2.Show()
        RichTextBox3.Show()
        FinalRichText.Show()
        LabelP1.Show()
        LabelP2.Show()
        LabelP3.Show()
        LabelP4.Show()
    End Sub
    Private Sub RichTextBox1_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox1.GotFocus
        RichTextBox1.Location = New Point(6, 348)
        RichTextBox1.Size = New Point(419, 128)
        RichTextBox0.Hide()
        RichTextBox1.Show()
        RichTextBox2.Hide()
        RichTextBox3.Hide()
        FinalRichText.Hide()
        LabelP1.Hide()
        LabelP2.Show()
        LabelP3.Hide()
        LabelP4.Hide()
    End Sub
    Private Sub RichTextBox1_LostFocus(sender As Object, e As EventArgs) Handles RichTextBox1.LostFocus
        RichTextBox1.Location = New Point(6, 403)
        RichTextBox1.Size = New Point(71, 36)
        RichTextBox0.Show()
        RichTextBox1.Show()
        RichTextBox2.Show()
        RichTextBox3.Show()
        FinalRichText.Show()
        LabelP1.Show()
        LabelP2.Show()
        LabelP3.Show()
        LabelP4.Show()
    End Sub
    Private Sub RichTextBox2_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox2.GotFocus
        RichTextBox2.Location = New Point(6, 348)
        RichTextBox2.Size = New Point(419, 128)
        RichTextBox0.Hide()
        RichTextBox1.Hide()
        RichTextBox2.Show()
        RichTextBox3.Hide()
        FinalRichText.Hide()
        LabelP1.Hide()
        LabelP2.Hide()
        LabelP3.Show()
        LabelP4.Hide()
    End Sub
    Private Sub RichTextBox2_LostFocus(sender As Object, e As EventArgs) Handles RichTextBox2.LostFocus
        RichTextBox2.Location = New Point(82, 348)
        RichTextBox2.Size = New Point(71, 36)
        RichTextBox0.Show()
        RichTextBox1.Show()
        RichTextBox2.Show()
        RichTextBox3.Show()
        FinalRichText.Show()
        LabelP1.Show()
        LabelP2.Show()
        LabelP3.Show()
        LabelP4.Show()
    End Sub
    Private Sub RichTextBox3_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox3.GotFocus
        RichTextBox3.Location = New Point(6, 348)
        RichTextBox3.Size = New Point(419, 128)
        RichTextBox0.Hide()
        RichTextBox1.Hide()
        RichTextBox2.Hide()
        RichTextBox3.Show()
        FinalRichText.Hide()
        LabelP1.Hide()
        LabelP2.Hide()
        LabelP3.Hide()
        LabelP4.Show()
    End Sub
    Private Sub RichTextBox3_LostFocus(sender As Object, e As EventArgs) Handles RichTextBox3.LostFocus
        RichTextBox3.Location = New Point(82, 403)
        RichTextBox3.Size = New Point(71, 36)
        RichTextBox0.Show()
        RichTextBox1.Show()
        RichTextBox2.Show()
        RichTextBox3.Show()
        FinalRichText.Show()
        LabelP1.Show()
        LabelP2.Show()
        LabelP3.Show()
        LabelP4.Show()
    End Sub
    Private Sub FinalRichText_GotFocus(sender As Object, e As EventArgs) Handles FinalRichText.GotFocus
        FinalRichText.Location = New Point(6, 348)
        FinalRichText.Size = New Point(419, 128)
        RichTextBox0.Hide()
        RichTextBox1.Hide()
        RichTextBox2.Hide()
        RichTextBox3.Hide()
        FinalRichText.Show()
        LabelP1.Hide()
        LabelP2.Hide()
        LabelP3.Hide()
        LabelP4.Hide()
    End Sub
    Private Sub FinalRichText_LostFocus(sender As Object, e As EventArgs) Handles FinalRichText.LostFocus
        FinalRichText.Location = New Point(264, 348)
        FinalRichText.Size = New Point(161, 89)
        RichTextBox0.Show()
        RichTextBox1.Show()
        RichTextBox2.Show()
        RichTextBox3.Show()
        FinalRichText.Show()
        LabelP1.Show()
        LabelP2.Show()
        LabelP3.Show()
        LabelP4.Show()
    End Sub

    Private Sub RichTextBox4_GotFocus(sender As Object, e As EventArgs) Handles RichTextBox4.GotFocus
        RichTextBox4.SelectAll()
        Clipboard.SetText(RichTextBox4.Text)
    End Sub

    Private Sub RichTextBox0_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox0.TextChanged
        FinalRichText.Text = RichTextBox0.Text & RichTextBox1.Text & RichTextBox2.Text & RichTextBox3.Text
    End Sub
End Class