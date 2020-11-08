Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load a l'ouverture le chemin initial
        TxtRecalfolderPath.Text = My.Settings.RecalboxFolder
        MenuBoutons.Hide()

    End Sub
    Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopy.Click
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
        MenuBoutons.Show()
    End Sub
End Class
