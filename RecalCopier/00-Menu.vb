Imports Microsoft.Win32
Imports System

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load a l'ouverture le chemin initial
        TxtRecalfolderPath.Text = My.Settings.RecalboxFolder
        MenuBoutons.Hide()
        NetFourDotFiveAndHigher()
    End Sub
    Private Sub NetFourDotFiveAndHigher()

        Const strSubKey As String = "SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full"
        Dim netKey As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(strSubKey)

        If netKey IsNot Nothing And netKey.GetValue("Release") IsNot Nothing Then
            MsgBox(".NET Framework Version: " + StrHigher(Integer.Parse(netKey.GetValue("Release"))))
        Else
            MsgBox("Votre .NET Framework est inférieur à Version 4.5" & Chr(13) & "Vous vous exposez à des bugs !" & Chr(13) & "Merci d'installer le Framework et RéOuvrir le Logiciel")
            System.Diagnostics.Process.Start(String.Format("https://dotnet.microsoft.com/download/dotnet-framework"))
        End If

    End Sub

    Private Function StrHigher(ByVal intRelease As Integer) As String

        If intRelease >= 461808 Then Return "4.7.2 or later"

        If intRelease >= 461308 Then Return "4.7.1"

        If intRelease >= 460798 Then Return "4.7"

        If intRelease >= 394802 Then Return "4.6.2"

        If intRelease >= 394254 Then Return "4.6.1"

        If intRelease >= 393295 Then Return "4.6"

        If intRelease >= 379893 Then Return "4.5.2"

        If intRelease >= 378675 Then Return "4.5.1"

        If intRelease >= 378389 Then Return "4.5"

        Return "No 4.5 or later version detected"

    End Function
    Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopy.Click
        If TxtRecalfolderPath Is Nothing Then
            MsgBox("Merci de Choisir votre Dossier Recalbox d'abord !")
            Exit Sub
        End If
        'Au clic, on ouvre le formulaire associé et on ferme le menu
        CopyRoms.Show()
        Me.Hide()
    End Sub
    Private Sub ButtonOverlay_Click(sender As Object, e As EventArgs) Handles ButtonOverlay.Click
        'Au clic, on ouvre le formulaire associé et on ferme le menu
        MsgBox("En Travail")
    End Sub
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'Au clic, on ouvre le formulaire associé et on ferme le menu
        MsgBox("En Travail")
    End Sub
    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        'Au clic, on ferme le programme
        Me.Close()
    End Sub
    Private Sub ButtonBrowseRecalboxFolder_Click(sender As Object, e As EventArgs) Handles ButtonBrowseRecalboxFolder.Click
        'Au clic, on ouvre la selection du repertoire
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TxtRecalfolderPath.Text = FolderBrowserDialog1.SelectedPath
            'On va remplacer la valeur par defaut "RecalboxFolder" et on la sauvegarde pour les prochaines fois
            My.Settings.RecalboxFolder = TxtRecalfolderPath.Text
            My.Settings.Save()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Merci de votre compréhension")
        Disclaimer.Hide()
        PictureBox2.Hide()
        MenuBoutons.Show()
    End Sub
    Private Sub TxtRecalfolderPath_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRecalfolderPath.KeyDown
        'Ajout d'un \ de securite si besoin
        If e.KeyCode = Keys.Enter Then
            If TxtRecalfolderPath.Text.Substring(Len(TxtRecalfolderPath.Text) - 1, 1) <> "\" Then
                TxtRecalfolderPath.Text = TxtRecalfolderPath.Text + "\"
            End If
        End If
    End Sub
    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.Click
        System.Diagnostics.Process.Start(String.Format("https://github.com/soaresden/RecopierBox"))
    End Sub
End Class
