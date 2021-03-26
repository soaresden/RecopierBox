Imports Microsoft.Win32
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Security.Cryptography
Imports System.Net.Http
Imports System.Drawing.Text
Imports System.Reflection

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load a l'ouverture le chemin initial
        TxtRecalfolderPath.Text = My.Settings.RecalboxFolder
        PanelGauche.Hide()
        PanelDroite.Hide()
        PanelSettings.Hide()
        NetFourDotFiveAndHigher()

        If My.Settings.Disclaimer = "ok" Then
            Disclaimer.Hide()
            PanelGauche.Show()
            PanelDroite.Hide()
            PanelSettings.Hide()
        End If

        'On check si le Folder enregistré existe, sinon on le fout à zéro
        If (Not System.IO.Directory.Exists(TxtRecalfolderPath.Text)) Then
            TxtRecalfolderPath.Text = ""
        End If

        'On met les tooltip
        ToolTipCopy.SetToolTip(ButtonCopy, "Générez votre dossier Custom !")
        ToolTipOverlays.SetToolTip(ButtonOverlay, "Gérez votre collection d'overlays")
        ToolTipSaves.SetToolTip(ButtonSave, "Maitrisez/renommer vos sauvegardes orphelines")
        ToolTipBlindTest.SetToolTip(ButtonQuizz, "Essayez de reconnaitre par video/son vos jeux favoris !")
        ToolTipPaypal.SetToolTip(Paypal, "N'Hesitez pas à soutenir le projet par ce bouton :) !")
        ToolTipP2k.SetToolTip(ButtonP2k, "Convertissez vos Roms ExoDos depuis Exodos Convert et Convertissez vos P2K-Info !")

        'Et on indique si y'a besoin d'écrire
        If TxtRecalfolderPath Is Nothing Then
            MsgBox("Merci de Choisir votre Dossier Mère d'abord !")
            PanelSettings.Show()
            Exit Sub
        End If

        'On call le test des dossier
        Call DetectTypeDossier(TxtRecalfolderPath.Text)

        'On affiche l'update si besoin
        Call Checkupdate()
    End Sub
    Private Sub NetFourDotFiveAndHigher()
        Const strSubKey As String = "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full"
        Dim netKey As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(strSubKey)

        If netKey IsNot Nothing And netKey.GetValue("Release") IsNot Nothing Then
            VersionNetFramework.Text = "Votre .NET Framework : " & StrHigher(Integer.Parse(netKey.GetValue("Release")))
        Else
            VersionNetFramework.Text = "Votre .NET Framework : " & StrHigher(Integer.Parse(netKey.GetValue("Release")))
            MsgBox("Votre .NET Framework : " & StrHigher(Integer.Parse(netKey.GetValue("Release"))) & Chr(10) & "Vous vous exposez à des bugs !" & Chr(10) & "Merci d'installer le Framework minimum de 4.7.2 et Réouvrir le Logiciel")
            System.Diagnostics.Process.Start(String.Format("https://dotnet.microsoft.com/download/dotnet-framework"))
        End If
    End Sub
    Private Function StrHigher(ByVal intRelease As Integer) As String
        If intRelease >= 461808 Then Return "4.8"
        If intRelease >= 461808 Then Return "4.7.1"
        If intRelease >= 461308 Then Return "4.7"
        If intRelease >= 394802 Then Return "4.6.2"
        If intRelease >= 394254 Then Return "4.6.1"
        If intRelease >= 393295 Then Return "4.6"
        If intRelease >= 379893 Then Return "4.5.2"
        If intRelease >= 378675 Then Return "4.5.2"
        If intRelease >= 378389 Then Return "4.5"

        Return ".Net Framework Non Installé"
    End Function
    Sub DetectTypeDossier(CheminDossierRecalbox As String)
        If (System.IO.Directory.Exists(CheminDossierRecalbox & "\overlays")) Then
            TypeRecalbox.Checked = True
            TypeBatocera.Checked = False
            My.Settings.DossierOverlay = CheminDossierRecalbox & "\overlays\"
            My.Settings.Save()
        Else
            TypeRecalbox.Checked = False
            TypeBatocera.Checked = True
            My.Settings.DossierOverlay = CheminDossierRecalbox & "\decorations\"
            My.Settings.Save()
        End If
    End Sub
    Private Sub ButtonBrowseRecalboxFolder_Click(sender As Object, e As EventArgs) Handles ButtonBrowseRecalboxFolder.Click
        'Au clic, on ouvre la selection du repertoire
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            'Check si un dossier Roms est present dedans
            Dim tailledossier = Len(FolderBrowserDialog1.SelectedPath.ToString)
            Dim derniercar = FolderBrowserDialog1.SelectedPath.ToString.Substring(tailledossier - 1, 1)
            Dim cheminsaisi As String

            'si c'st un dossier direct on enleve le "\"
            If derniercar = "\" Then
                cheminsaisi = FolderBrowserDialog1.SelectedPath.ToString.Substring(0, tailledossier - 1)
            Else
                cheminsaisi = FolderBrowserDialog1.SelectedPath.ToString.Substring(0, tailledossier)
            End If


            If (Not System.IO.Directory.Exists(cheminsaisi & "\Roms")) Then
                MsgBox("Le Chemin saisi ne possede pas de dossier 'Roms'" & Chr(10) & "Selectionner votre dossier Mère")
                TxtRecalfolderPath.Text = Nothing
            Else
                MsgBox("Chemin OK !")

                TxtRecalfolderPath.Text = cheminsaisi
                'On va remplacer la valeur par defaut "RecalboxFolder" et on la sauvegarde pour les prochaines fois
                My.Settings.RecalboxFolder = TxtRecalfolderPath.Text
                My.Settings.Save()
                'On call le test des dossier
                Call DetectTypeDossier(TxtRecalfolderPath.Text)
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Merci de votre compréhension")
        Disclaimer.Hide()
        PanelGauche.Show()
        PanelDroite.Hide()
        My.Settings.Disclaimer = "ok"
        My.Settings.Save()
    End Sub
    Private Sub TxtRecalfolderPath_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRecalfolderPath.KeyDown
        'Ajout d'un \ de securite si besoin
        If e.KeyCode = Keys.Enter Then

            If TxtRecalfolderPath.Text.Substring(Len(TxtRecalfolderPath.Text) - 1, 1) = "\" Then
                TxtRecalfolderPath.Text = TxtRecalfolderPath.Text.Substring(0, Len(TxtRecalfolderPath.Text) - 1)
            End If

            If (Not System.IO.Directory.Exists(TxtRecalfolderPath.Text & "\Roms")) Then
                MsgBox("Le Chemin saisi ne possede pas de dossier 'Roms'" & Chr(10) & "Selectionner votre dossier Mère")
                TxtRecalfolderPath.Text = Nothing
            Else
                MsgBox("Chemin OK !")

                My.Settings.RecalboxFolder = TxtRecalfolderPath.Text
                My.Settings.Save()
                Call DetectTypeDossier(TxtRecalfolderPath.Text)
            End If
        End If
    End Sub
    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.Click
        System.Diagnostics.Process.Start(String.Format("https://github.com/soaresden/RecopierBox"))
    End Sub
    Private Sub RichTextBox2_Click(sender As Object, e As EventArgs) Handles RichTextBox2.Click
        System.Diagnostics.Process.Start(String.Format("http://jujuvincebros.fr/telechargements2/file/10-arrm-another-recalbox-roms-manager"))
    End Sub
    Private Sub ButtonCopy_Click_1(sender As Object, e As EventArgs) Handles ButtonCopy.Click
        If My.Settings.RecalboxFolder Is Nothing Then
            MsgBox("Pas de Chemin !")
            ButtonSetDossier.PerformClick()
        End If
        'Au clic, on ouvre le formulaire associé et on ferme le menu
        CopyRoms.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonQuizz_Click_1(sender As Object, e As EventArgs) Handles ButtonQuizz.Click
        If My.Settings.RecalboxFolder Is Nothing Then
            MsgBox("Pas de Chemin !")
            ButtonSetDossier.PerformClick()
        End If

        If TxtRecalfolderPath Is Nothing Then
            MsgBox("Merci de Choisir votre Dossier Recalbox d'abord !")
            Exit Sub
        End If
        'Au clic, on ouvre le formulaire associé et on ferme le menu
        Quizz.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonSave_Click_1(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If My.Settings.RecalboxFolder Is Nothing Then
            MsgBox("Pas de Chemin !")
            ButtonSetDossier.PerformClick()
        End If
        'Au clic, on ouvre le formulaire associé et on ferme le menu
        SaveManager.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonOverlay_Click_1(sender As Object, e As EventArgs) Handles ButtonOverlay.Click
        If My.Settings.RecalboxFolder Is Nothing Then
            MsgBox("Pas de Chemin !")
            ButtonSetDossier.PerformClick()
        End If
        'Au clic, on ouvre le formulaire associé et on ferme le menu
        If TypeRecalbox.Checked = True Then
            OverlayManager.Show()
            Me.Hide()
        Else
            OverlayManagerBatocera.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub ButtonP2k_Click(sender As Object, e As EventArgs) Handles ButtonP2k.Click
        If My.Settings.RecalboxFolder Is Nothing Then
            MsgBox("Pas de Chemin !")
            ButtonSetDossier.PerformClick()
        End If
        'Au clic, on ouvre le formulaire associé et on ferme le menu
        P2K.Show()
        Me.Hide()
    End Sub
    Private Sub Paypal_Click(sender As Object, e As EventArgs) Handles Paypal.Click
        System.Diagnostics.Process.Start(String.Format("https://paypal.me/SoaresDenis?locale.x=fr_FR"))
    End Sub
    Private Sub ButtonHideArrm_Click(sender As Object, e As EventArgs) Handles ButtonHideArrm.Click
        PanelDroite.Visible = Not PanelDroite.Visible
    End Sub
    Private Sub ButtonSetDossier_Click(sender As Object, e As EventArgs) Handles ButtonSetDossier.Click
        PanelSettings.Visible = Not PanelSettings.Visible
    End Sub
    Sub Checkupdate()
        'check online
        Dim versiononline As Double
        Dim versionnow As Double = Replace(Replace(version.Text, "v", ""), ".", ",")


        'Github API
        Dim Client As HttpClient = New HttpClient()
        Client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "windows")
        Try
            Dim res = Client.GetAsync("https://api.github.com/repos/soaresden/RecopierBox/releases/latest").Result.Content.ReadAsStringAsync().Result
            versiononline = Replace(res.Substring(InStr(res, "tag_name") + 10).Substring(1, InStr(res.Substring(InStr(res, "tag_name") + 10), ",") - 3), ".", ",")

            If versiononline > versionnow Then
                Try
                    MsgBox("Update en cours de Telechargement")
                    DoUpdate()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Catch ex As exception
            GoTo skipupdate
        End Try

        'Dim getversion = InStr(res, "tag_name")
        'Dim getversion2 = res.Substring(getversion + 10)
        'Dim slash = InStr(getversion2, ",")
        'Dim final = getversion2.Substring(1, slash - 3)


skipupdate:
    End Sub
    Private Sub DoUpdate()
        Try
            'Declare application path
            Dim appPath As String = Application.StartupPath
            'Declare download directory path
            Dim downloadDir As String = Application.StartupPath & "\Updates"
            'Declare update files path
            Dim updateFiles As String = downloadDir & "\release.zip"
            'Create download directory
            Directory.CreateDirectory(downloadDir)
            'Download updates file in .zip file
            'My.Computer.Network.DownloadFile("https://github.com/soaresden/RecopierBox/releases/latest/download/release.zip", updateFiles, "", "")
            Dim remoteUri As String = "https://github.com/soaresden/RecopierBox/releases/latest/download/release.zip"
            Dim fileName As String = "release.zip"
            Dim password As String = "windows"
            Dim username As String = "windows"
            Using client As New WebClient()
                client.Credentials = New NetworkCredential(username, password)
                client.DownloadFile(remoteUri, updateFiles)
            End Using

            'Get windows default zip creator/extrator 
            Dim shObj As Object = Activator.CreateInstance(Type.GetTypeFromProgID("Shell.Application"))
            'Declare the folder where the items will be extracted.
            Dim output As Object = shObj.NameSpace((appPath))
            'Declare the input zip file.
            Dim input As Object = shObj.NameSpace((updateFiles))
            'msgbox
            MsgBox("Update téléchargée dans le dossier 'Updates'" & Chr(10) & "Vous devrez dezipper et remplacer par vous même :)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReShowDisclaimer_Click(sender As Object, e As EventArgs) Handles ReShowDisclaimer.Click
        Disclaimer.Visible = Not Disclaimer.Visible
    End Sub

End Class
