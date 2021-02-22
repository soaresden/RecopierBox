Imports System.IO

Public Class P2K
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
        DataGridViewExo.DataSource = table

        'Hiding les colonnes
        DataGridViewExo.Columns("DOS").Visible = False
        DataGridViewExo.Columns("Titre").Visible = True
        DataGridViewExo.Columns("Chemin").Visible = False
        DataGridViewExo.Columns("ID").Visible = False
        DataGridViewExo.Columns("Synopsis").Visible = False
        DataGridViewExo.Columns("Date").Visible = False
        DataGridViewExo.Columns("Dev").Visible = True
        DataGridViewExo.Columns("Publ").Visible = True
        DataGridViewExo.Columns("Genre").Visible = True
        DataGridViewExo.Columns("Manual").Visible = True
        DataGridViewExo.Columns("Image").Visible = True

        'Width for columns
        DataGridViewExo.Columns("Titre").Width = 110
        DataGridViewExo.Columns("Date").Width = 80
        DataGridViewExo.Columns("Dev").Width = 80
        DataGridViewExo.Columns("Publ").Width = 80
        DataGridViewExo.Columns("Genre").Width = 80
        DataGridViewExo.Columns("Manual").Width = 80
        DataGridViewExo.Columns("Image").Width = 70


    End Sub

    Private Sub NewAdresseExo_TextChanged(sender As Object, e As EventArgs) Handles NewAdresseExo.TextChanged
        FullNewadresseExo.Text = adresseExo.Text & "\" & NewAdresseExo.Text
    End Sub

    Private Sub DoExoConverter_Click(sender As Object, e As EventArgs) Handles DoExoConverter.Click
        If NewAdresseExo.Text = "" Then
            MsgBox("Saisir un nom de dossier svp")
            Exit Sub
        End If

        For i = 0 To DataGridViewExo.Rows.Count - 1
            On Error Resume Next
            Dim cheminimage As String = DataGridViewExo.Rows(i).Cells(DataGridViewExo.Columns("image").Index).Value
            Dim cheminmanual As String = DataGridViewExo.Rows(i).Cells(DataGridViewExo.Columns("manual").Index).Value
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
                DataGridViewExo.Rows(i).Cells(DataGridViewExo.Columns("image").Index).Value = finalfichier
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
                DataGridViewExo.Rows(i).Cells(DataGridViewExo.Columns("manual").Index).Value = finalfichier
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
End Class