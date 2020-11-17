<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Quitter = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonBrowseRecalboxFolder = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.TxtRecalfolderPath = New System.Windows.Forms.TextBox()
        Me.MenuBoutons = New System.Windows.Forms.GroupBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.ButtonOverlay = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Disclaimer = New System.Windows.Forms.GroupBox()
        Me.TxtDisclaimer = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.VersionNetFramework = New System.Windows.Forms.Label()
        Me.ButtonQuizz = New System.Windows.Forms.Button()
        Me.groupBox2.SuspendLayout()
        Me.MenuBoutons.SuspendLayout()
        Me.Disclaimer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Quitter
        '
        Me.Quitter.Font = New System.Drawing.Font("VAGRounded BT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitter.Location = New System.Drawing.Point(576, 598)
        Me.Quitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(159, 53)
        Me.Quitter.TabIndex = 13
        Me.Quitter.Text = "QUITTER"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.DimGray
        Me.groupBox2.Controls.Add(Me.ButtonBrowseRecalboxFolder)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.TxtRecalfolderPath)
        Me.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.groupBox2.Location = New System.Drawing.Point(909, 480)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.groupBox2.Size = New System.Drawing.Size(344, 112)
        Me.groupBox2.TabIndex = 12
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Configuration Initiale"
        '
        'ButtonBrowseRecalboxFolder
        '
        Me.ButtonBrowseRecalboxFolder.Font = New System.Drawing.Font("VAG Rounded", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrowseRecalboxFolder.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ButtonBrowseRecalboxFolder.Location = New System.Drawing.Point(243, 68)
        Me.ButtonBrowseRecalboxFolder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonBrowseRecalboxFolder.Name = "ButtonBrowseRecalboxFolder"
        Me.ButtonBrowseRecalboxFolder.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBrowseRecalboxFolder.TabIndex = 2
        Me.ButtonBrowseRecalboxFolder.Text = "Parcourir"
        Me.ButtonBrowseRecalboxFolder.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(25, 32)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(299, 17)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Saisir/Selectionner le Dossier Mère Recalbox"
        '
        'TxtRecalfolderPath
        '
        Me.TxtRecalfolderPath.Location = New System.Drawing.Point(28, 68)
        Me.TxtRecalfolderPath.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtRecalfolderPath.Name = "TxtRecalfolderPath"
        Me.TxtRecalfolderPath.Size = New System.Drawing.Size(191, 22)
        Me.TxtRecalfolderPath.TabIndex = 0
        '
        'MenuBoutons
        '
        Me.MenuBoutons.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.MenuBoutons.Controls.Add(Me.ButtonSave)
        Me.MenuBoutons.Controls.Add(Me.ButtonCopy)
        Me.MenuBoutons.Controls.Add(Me.ButtonOverlay)
        Me.MenuBoutons.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.MenuBoutons.Location = New System.Drawing.Point(15, 82)
        Me.MenuBoutons.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuBoutons.Name = "MenuBoutons"
        Me.MenuBoutons.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MenuBoutons.Size = New System.Drawing.Size(349, 570)
        Me.MenuBoutons.TabIndex = 11
        Me.MenuBoutons.TabStop = False
        Me.MenuBoutons.Text = "Faites votre Selection :"
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.Location = New System.Drawing.Point(11, 389)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(325, 175)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "GERER " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vos Saves"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCopy.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.Location = New System.Drawing.Point(11, 22)
        Me.ButtonCopy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(325, 178)
        Me.ButtonCopy.TabIndex = 3
        Me.ButtonCopy.Text = "PREPARER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Un Dossier Perso"
        Me.ButtonCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'ButtonOverlay
        '
        Me.ButtonOverlay.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOverlay.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonOverlay.Image = CType(resources.GetObject("ButtonOverlay.Image"), System.Drawing.Image)
        Me.ButtonOverlay.Location = New System.Drawing.Point(11, 206)
        Me.ButtonOverlay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonOverlay.Name = "ButtonOverlay"
        Me.ButtonOverlay.Size = New System.Drawing.Size(325, 178)
        Me.ButtonOverlay.TabIndex = 1
        Me.ButtonOverlay.Text = "GERER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vos Overlays Consoles et Jeux"
        Me.ButtonOverlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonOverlay.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("VAGRounded BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.Info
        Me.label2.Location = New System.Drawing.Point(217, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(454, 21)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Votre Builder de Pack Personnalisé pour votre RecalBox"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("VAGRounded BT", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.label1.Location = New System.Drawing.Point(211, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(623, 53)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Bienvenue dans RecopierBox"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Aqua
        Me.label3.Location = New System.Drawing.Point(1125, 634)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(122, 17)
        Me.label3.TabIndex = 14
        Me.label3.Text = "v1.3 by Soaresden"
        '
        'Disclaimer
        '
        Me.Disclaimer.Controls.Add(Me.TxtDisclaimer)
        Me.Disclaimer.Controls.Add(Me.Button1)
        Me.Disclaimer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Disclaimer.Location = New System.Drawing.Point(15, 82)
        Me.Disclaimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Disclaimer.Name = "Disclaimer"
        Me.Disclaimer.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Disclaimer.Size = New System.Drawing.Size(1239, 510)
        Me.Disclaimer.TabIndex = 16
        Me.Disclaimer.TabStop = False
        Me.Disclaimer.Text = "Pourquoi cet Outil ?"
        '
        'TxtDisclaimer
        '
        Me.TxtDisclaimer.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDisclaimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisclaimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDisclaimer.Location = New System.Drawing.Point(7, 137)
        Me.TxtDisclaimer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDisclaimer.Name = "TxtDisclaimer"
        Me.TxtDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDisclaimer.Size = New System.Drawing.Size(1221, 221)
        Me.TxtDisclaimer.TabIndex = 18
        Me.TxtDisclaimer.Text = resources.GetString("TxtDisclaimer.Text")
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(40, 377)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1156, 70)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "J'accepte que cet Outil n'effectue QUE des opérations sur des GameList déja scrap" &
    "pés"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.RichTextBox1.Location = New System.Drawing.Point(965, 599)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(288, 33)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = "https://github.com/soaresden/RecopierBox"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RecalCopier.My.Resources.Resources.iconlog
        Me.PictureBox1.Location = New System.Drawing.Point(15, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RecalCopier.My.Resources.Resources.iconlog
        Me.PictureBox2.Location = New System.Drawing.Point(15, 5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(196, 166)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'VersionNetFramework
        '
        Me.VersionNetFramework.AutoSize = True
        Me.VersionNetFramework.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionNetFramework.ForeColor = System.Drawing.Color.Yellow
        Me.VersionNetFramework.Location = New System.Drawing.Point(992, 5)
        Me.VersionNetFramework.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VersionNetFramework.Name = "VersionNetFramework"
        Me.VersionNetFramework.Size = New System.Drawing.Size(207, 24)
        Me.VersionNetFramework.TabIndex = 21
        Me.VersionNetFramework.Text = ".net Framework version"
        '
        'ButtonQuizz
        '
        Me.ButtonQuizz.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuizz.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonQuizz.Image = CType(resources.GetObject("ButtonQuizz.Image"), System.Drawing.Image)
        Me.ButtonQuizz.Location = New System.Drawing.Point(748, 288)
        Me.ButtonQuizz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonQuizz.Name = "ButtonQuizz"
        Me.ButtonQuizz.Size = New System.Drawing.Size(104, 105)
        Me.ButtonQuizz.TabIndex = 5
        Me.ButtonQuizz.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonQuizz.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 652)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Disclaimer)
        Me.Controls.Add(Me.ButtonQuizz)
        Me.Controls.Add(Me.VersionNetFramework)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.MenuBoutons)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1282, 699)
        Me.MinimumSize = New System.Drawing.Size(1282, 699)
        Me.Name = "Form1"
        Me.Text = "Menu RecopierBox"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.MenuBoutons.ResumeLayout(False)
        Me.Disclaimer.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Quitter As Button
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents ButtonBrowseRecalboxFolder As Button
    Private WithEvents label4 As Label
    Private WithEvents TxtRecalfolderPath As TextBox
    Private WithEvents MenuBoutons As GroupBox
    Private WithEvents ButtonSave As Button
    Private WithEvents ButtonCopy As Button
    Private WithEvents ButtonOverlay As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Disclaimer As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TxtDisclaimer As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents VersionNetFramework As Label
    Private WithEvents ButtonQuizz As Button
End Class
