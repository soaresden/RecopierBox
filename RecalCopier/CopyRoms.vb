Imports System.Xml
Imports System.Data
Imports System.IO
Imports System.Net


Public Class CopyRoms
    Private Sub ButtonImportXML_click(sender As Object, e As EventArgs) Handles ButtonImportXML.Click

        Dim list As List(Of String) = GetFilesRecursive(My.Settings.RecalboxFolder & "\roms")

        ' Loop through and display each path.
        For Each path In list
            Console.WriteLine(path)
            ListBox1.Items.Add(path)
        Next

        MsgBox(list.Count & " Plateformes ajoutées")

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.Items.Count = 0 Then Exit Sub

        Dim gamelist As String = ListBox1.Items(0)
        Dim dt As New DataTable()
        dt.Columns.Add("console", GetType(String))
        dt.Columns.Add("name", GetType(String))
        dt.Columns.Add("path", GetType(String))
        dt.Columns.Add("desc", GetType(String))
        dt.Columns.Add("image", GetType(String))
        dt.Columns.Add("video", GetType(String))


        For i = 0 To ListBox1.Items.Count - 1

            'Dim nomconsole As String = ListBox1.Items(i)
            'Dim chercheroms As String = InStr(nomconsole, "roms\",)
            'Dim finphrase As String = nomconsole.Substring((chercheroms + 4))
            'Dim detectedeuz As String = InStr(finphrase, "\gamelist.xml")
            'Dim findugame As String = finphrase.Substring(0, detectedeuz - 1)

            Dim consolename As String = ListBox1.Items(i).Substring((InStr(ListBox1.Items(i), "roms\",) + 4)).Substring(0, InStr(ListBox1.Items(i).Substring((InStr(ListBox1.Items(i), "roms\",) + 4)), "\gamelist.xml") - 1)

            gamelist = ListBox1.Items(i)

            Dim xmldoc As New XmlDocument()
            xmldoc.Load(gamelist)

            Dim nodeList As XmlNodeList = xmldoc.SelectNodes("//gameList/game")

            For Each node As XmlNode In nodeList

                Dim dtrow As DataRow = dt.NewRow()
                Dim romname As String = node("name").InnerText
                Dim rompath As String = node("path").InnerText
                Dim romdesc As String
                Dim romimage As String
                Dim romvideo As String

                Dim YOURTEMPVARIABLE As XmlNodeList = xmldoc.GetElementsByTagName("desc")
                If YOURTEMPVARIABLE.Count > 0 Then
                    romdesc = YOURTEMPVARIABLE(0).InnerXml
                Else
                    romdesc = ""
                End If

                Dim YOURTEMPVARIABLE1 As XmlNodeList = xmldoc.GetElementsByTagName("image")
                If YOURTEMPVARIABLE1.Count > 0 Then
                    romimage = YOURTEMPVARIABLE1(0).InnerXml
                Else
                    romimage = ""
                End If

                Dim YOURTEMPVARIABLE2 As XmlNodeList = xmldoc.GetElementsByTagName("video")
                If YOURTEMPVARIABLE2.Count > 0 Then
                    romvideo = YOURTEMPVARIABLE2(0).InnerXml
                Else
                    romvideo = ""
                End If

                dtrow("console") = consolename
                dtrow("name") = romname
                dtrow("path") = rompath
                dtrow("desc") = romdesc
                dtrow("image") = romimage
                dtrow("video") = romvideo
                dt.Rows.Add(dtrow)

                romname = ""
                rompath = ""
                romdesc = ""
                romimage = ""
                romvideo = ""

            Next
            DataGridView1.DataSource = dt

        Next

    End Sub

End Class