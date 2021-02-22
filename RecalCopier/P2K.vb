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
            If (Not System.IO.Directory.Exists(cheminsaisi & "\downloaded_images") And Not System.IO.File.Exists(cheminsaisi & "\gamelist.xml") Then
                MsgBox("Le Chemin saisi ne possede pas de dossier 'downloaded_images' et/ou de gamelist.xml" & Chr(13) & "Selectionner votre dossier généré par Exodos Converter")
                adresseExo.Text = Nothing
            Else
                adresseExo.Text = FolderBrowserDialog2.SelectedPath
                Call validlecheminexo
            End If
        End If
    End Sub

    Sub validlecheminexo()
        'import de l'adresse

        Dim gamelistXml As XElement = XElement.Load(adresseExo.Text)

        'On cree le table
        Dim table As New DataTable()
        Dim dv As DataView
        Dim column As DataColumn

        column = New DataColumn()

        column = New DataColumn()
        With column
            .DataType = Type.GetType("System.String")
            .ColumnName = "Titre"
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
            .ColumnName = "Date"
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
            .ColumnName = "Genre"
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
            .ColumnName = "Image"
        End With
        table.Columns.Add(column)


        'getting the list for the xml with nodes
        Dim query2 = From st In gamelistXml.Descendants("game") Select st

        For Each xEle As XElement In query2
            Dim romconsole As String = "dos"
            Dim romname As String = xEle.Element("name")
            Dim romId As String
            Dim temprom As String = Replace(Replace(Replace(xEle.Element("path"), "/", "\"), "./", ""), ".\", "")
            Dim rompath As String = My.Settings.RecalboxFolder & "\roms\" & romconsole & "\" & temprom
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
                romimage = adresseExo.Text & "\roms\" & romconsole & "\" & Replace(Replace(Replace(xEle.Element("image"), "/", "\"), "./", ""), ".\", "")
            End If

            If xEle.Element("manual") Is Nothing Then
                romanual = Nothing
            Else
                romanual = adresseExo.Text & "\roms\" & romconsole & "\" & Replace(Replace(Replace(xEle.Element("manual"), "/", "\"), "./", ""), ".\", "")
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

        'Width for columns
        DataGridViewExo.Columns("Titre").Width = 50
        DataGridViewExo.Columns("Desc").Width = 50
        DataGridViewExo.Columns("Date").Width = 50
        DataGridViewExo.Columns("Dev").Width = 50
        DataGridViewExo.Columns("Publ").Width = 50
        DataGridViewExo.Columns("Genre").Width = 50
        DataGridViewExo.Columns("Manual").Width = 50
        DataGridViewExo.Columns("Image").Width = 50

        'Hiding les colonnes
        DataGridViewExo.Columns("Titre").Visible = True
        DataGridViewExo.Columns("Desc").Visible = True
        DataGridViewExo.Columns("Date").Visible = True
        DataGridViewExo.Columns("Dev").Visible = True
        DataGridViewExo.Columns("Publ").Visible = True
        DataGridViewExo.Columns("Genre").Visible = True
        DataGridViewExo.Columns("Manual").Visible = True
        DataGridViewExo.Columns("Image").Visible = True

        FinalGrid.Columns("GameId").Visible = False
        FinalGrid.Columns("CheminRom").Visible = False
        FinalGrid.Columns("Synopsis").Visible = False
        FinalGrid.Columns("CheminImage").Visible = False
        FinalGrid.Columns("CheminVideo").Visible = False
        FinalGrid.Columns("CheminManuel").Visible = False
        'Width for columns
        FinalGrid.Columns("Genre").Visible = False
        FinalGrid.Columns("Note").Visible = False
        FinalGrid.Columns("Developer").Visible = False
        FinalGrid.Columns("Publisher").Visible = False
        FinalGrid.Columns("NbPlayers").Visible = False
        FinalGrid.Columns("DateSortie").Visible = False
        FinalGrid.Columns("NbLancé").Visible = False
        FinalGrid.Columns("Region").Visible = False

    End Sub


End Class