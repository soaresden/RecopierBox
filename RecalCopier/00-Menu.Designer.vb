<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonBrowseRecalboxFolder = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.TxtRecalfolderPath = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Disclaimer = New System.Windows.Forms.GroupBox()
        Me.TxtDisclaimer = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VersionNetFramework = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WhyGameList = New System.Windows.Forms.GroupBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.txtWhyGamelist = New System.Windows.Forms.TextBox()
        Me.PanelGauche = New System.Windows.Forms.Panel()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.ButtonOverlay = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonQuizz = New System.Windows.Forms.Button()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelHaut = New System.Windows.Forms.Panel()
        Me.PanelDroite = New System.Windows.Forms.Panel()
        Me.groupBox2.SuspendLayout()
        Me.Disclaimer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WhyGameList.SuspendLayout()
        Me.PanelGauche.SuspendLayout()
        Me.PanelHaut.SuspendLayout()
        Me.PanelDroite.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.BackColor = System.Drawing.Color.DimGray
        Me.groupBox2.Controls.Add(Me.ButtonBrowseRecalboxFolder)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.TxtRecalfolderPath)
        Me.groupBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.groupBox2.Location = New System.Drawing.Point(0, 98)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Size = New System.Drawing.Size(245, 91)
        Me.groupBox2.TabIndex = 12
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Configuration du Dossier :"
        '
        'ButtonBrowseRecalboxFolder
        '
        Me.ButtonBrowseRecalboxFolder.Font = New System.Drawing.Font("VAG Rounded", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrowseRecalboxFolder.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ButtonBrowseRecalboxFolder.Location = New System.Drawing.Point(177, 67)
        Me.ButtonBrowseRecalboxFolder.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonBrowseRecalboxFolder.Name = "ButtonBrowseRecalboxFolder"
        Me.ButtonBrowseRecalboxFolder.Size = New System.Drawing.Size(61, 19)
        Me.ButtonBrowseRecalboxFolder.TabIndex = 2
        Me.ButtonBrowseRecalboxFolder.Text = "Parcourir"
        Me.ButtonBrowseRecalboxFolder.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(3, 15)
        Me.label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(241, 45)
        Me.label4.TabIndex = 1
        Me.label4.Text = "Selectionner votre Dossier Mère" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recalbox/Batocera" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(celui qui contient roms/over" &
    "lays/saves..etc)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtRecalfolderPath
        '
        Me.TxtRecalfolderPath.Location = New System.Drawing.Point(4, 67)
        Me.TxtRecalfolderPath.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtRecalfolderPath.Name = "TxtRecalfolderPath"
        Me.TxtRecalfolderPath.Size = New System.Drawing.Size(144, 20)
        Me.TxtRecalfolderPath.TabIndex = 0
        Me.TxtRecalfolderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.label2.Font = New System.Drawing.Font("Equinox Com", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(162, 39)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(405, 18)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Votre Builder de Pack Personnalisé pour votre FrontEnd Recalbox/Batocera"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.label1.Font = New System.Drawing.Font("VAGRounded BT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.label1.Location = New System.Drawing.Point(122, -1)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(473, 40)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Bienvenue dans RecopierBox"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.label3.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Yellow
        Me.label3.Location = New System.Drawing.Point(146, 67)
        Me.label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(92, 14)
        Me.label3.TabIndex = 14
        Me.label3.Text = "v4 by Soaresden"
        '
        'Disclaimer
        '
        Me.Disclaimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Disclaimer.Controls.Add(Me.TxtDisclaimer)
        Me.Disclaimer.Controls.Add(Me.Button1)
        Me.Disclaimer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Disclaimer.Location = New System.Drawing.Point(254, 67)
        Me.Disclaimer.Name = "Disclaimer"
        Me.Disclaimer.Size = New System.Drawing.Size(695, 468)
        Me.Disclaimer.TabIndex = 16
        Me.Disclaimer.TabStop = False
        Me.Disclaimer.Text = "Pourquoi cet Outil ?"
        '
        'TxtDisclaimer
        '
        Me.TxtDisclaimer.BackColor = System.Drawing.Color.White
        Me.TxtDisclaimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisclaimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDisclaimer.Location = New System.Drawing.Point(6, 47)
        Me.TxtDisclaimer.Name = "TxtDisclaimer"
        Me.TxtDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDisclaimer.Size = New System.Drawing.Size(683, 235)
        Me.TxtDisclaimer.TabIndex = 18
        Me.TxtDisclaimer.Text = resources.GetString("TxtDisclaimer.Text")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(146, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(438, 83)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "J'accepte que cet Outil n'effectue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "QUE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "des opérations sur des GameList déja scr" &
    "appés"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.RichTextBox1.Location = New System.Drawing.Point(4, 367)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(216, 16)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = "https://github.com/soaresden/RecopierBox"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RecalCopier.My.Resources.Resources.iconlog
        Me.PictureBox1.Location = New System.Drawing.Point(11, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'VersionNetFramework
        '
        Me.VersionNetFramework.AutoSize = True
        Me.VersionNetFramework.Font = New System.Drawing.Font("Equinox Com", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionNetFramework.ForeColor = System.Drawing.Color.Lime
        Me.VersionNetFramework.Location = New System.Drawing.Point(2, 346)
        Me.VersionNetFramework.Name = "VersionNetFramework"
        Me.VersionNetFramework.Size = New System.Drawing.Size(134, 18)
        Me.VersionNetFramework.TabIndex = 21
        Me.VersionNetFramework.Text = ".net Framework version"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(70, 257)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'WhyGameList
        '
        Me.WhyGameList.BackColor = System.Drawing.Color.SteelBlue
        Me.WhyGameList.Controls.Add(Me.RichTextBox2)
        Me.WhyGameList.Controls.Add(Me.txtWhyGamelist)
        Me.WhyGameList.Controls.Add(Me.PictureBox3)
        Me.WhyGameList.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WhyGameList.Location = New System.Drawing.Point(3, 3)
        Me.WhyGameList.Name = "WhyGameList"
        Me.WhyGameList.Size = New System.Drawing.Size(216, 340)
        Me.WhyGameList.TabIndex = 23
        Me.WhyGameList.TabStop = False
        Me.WhyGameList.Text = "Verifiez vos GameList !"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 304)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(210, 30)
        Me.RichTextBox2.TabIndex = 24
        Me.RichTextBox2.Text = "http://jujuvincebros.fr/telechargements2/file/10-arrm-another-recalbox-roms-manag" &
    "er"
        '
        'txtWhyGamelist
        '
        Me.txtWhyGamelist.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtWhyGamelist.Location = New System.Drawing.Point(7, 19)
        Me.txtWhyGamelist.Multiline = True
        Me.txtWhyGamelist.Name = "txtWhyGamelist"
        Me.txtWhyGamelist.ReadOnly = True
        Me.txtWhyGamelist.Size = New System.Drawing.Size(203, 215)
        Me.txtWhyGamelist.TabIndex = 0
        Me.txtWhyGamelist.Text = resources.GetString("txtWhyGamelist.Text")
        '
        'PanelGauche
        '
        Me.PanelGauche.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.PanelGauche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGauche.Controls.Add(Me.label3)
        Me.PanelGauche.Controls.Add(Me.Quitter)
        Me.PanelGauche.Controls.Add(Me.ButtonOverlay)
        Me.PanelGauche.Controls.Add(Me.ButtonSave)
        Me.PanelGauche.Controls.Add(Me.ButtonQuizz)
        Me.PanelGauche.Controls.Add(Me.ButtonCopy)
        Me.PanelGauche.Controls.Add(Me.Label5)
        Me.PanelGauche.Controls.Add(Me.groupBox2)
        Me.PanelGauche.Controls.Add(Me.PictureBox1)
        Me.PanelGauche.Location = New System.Drawing.Point(1, -1)
        Me.PanelGauche.Name = "PanelGauche"
        Me.PanelGauche.Size = New System.Drawing.Size(247, 542)
        Me.PanelGauche.TabIndex = 24
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Quitter.Cursor = System.Windows.Forms.Cursors.Default
        Me.Quitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Quitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Quitter.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Quitter.Location = New System.Drawing.Point(1, 487)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(244, 49)
        Me.Quitter.TabIndex = 24
        Me.Quitter.Text = "QUITTER"
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'ButtonOverlay
        '
        Me.ButtonOverlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ButtonOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonOverlay.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonOverlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonOverlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ButtonOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOverlay.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOverlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonOverlay.Image = CType(resources.GetObject("ButtonOverlay.Image"), System.Drawing.Image)
        Me.ButtonOverlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonOverlay.Location = New System.Drawing.Point(0, 289)
        Me.ButtonOverlay.Name = "ButtonOverlay"
        Me.ButtonOverlay.Size = New System.Drawing.Size(244, 60)
        Me.ButtonOverlay.TabIndex = 23
        Me.ButtonOverlay.Text = "GERER LES OVERLAYS"
        Me.ButtonOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonOverlay.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSave.Image = CType(resources.GetObject("ButtonSave.Image"), System.Drawing.Image)
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(-1, 355)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(244, 60)
        Me.ButtonSave.TabIndex = 22
        Me.ButtonSave.Text = "ORGANISER LES SAVES"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonQuizz
        '
        Me.ButtonQuizz.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonQuizz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonQuizz.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonQuizz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonQuizz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonQuizz.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuizz.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonQuizz.Image = CType(resources.GetObject("ButtonQuizz.Image"), System.Drawing.Image)
        Me.ButtonQuizz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonQuizz.Location = New System.Drawing.Point(1, 421)
        Me.ButtonQuizz.Name = "ButtonQuizz"
        Me.ButtonQuizz.Size = New System.Drawing.Size(244, 60)
        Me.ButtonQuizz.TabIndex = 21
        Me.ButtonQuizz.Text = "JOUER AU BLIND TEST♪"
        Me.ButtonQuizz.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonQuizz.UseVisualStyleBackColor = False
        '
        'ButtonCopy
        '
        Me.ButtonCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCopy.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCopy.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCopy.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCopy.Location = New System.Drawing.Point(0, 223)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(244, 60)
        Me.ButtonCopy.TabIndex = 20
        Me.ButtonCopy.Text = "CREER UN DOSSIER PERSO"
        Me.ButtonCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCopy.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("VAGRounded BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(85, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 30)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "RecopierBox"
        '
        'PanelHaut
        '
        Me.PanelHaut.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.PanelHaut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelHaut.Controls.Add(Me.label1)
        Me.PanelHaut.Controls.Add(Me.label2)
        Me.PanelHaut.Location = New System.Drawing.Point(254, -1)
        Me.PanelHaut.Name = "PanelHaut"
        Me.PanelHaut.Size = New System.Drawing.Size(696, 62)
        Me.PanelHaut.TabIndex = 25
        '
        'PanelDroite
        '
        Me.PanelDroite.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.PanelDroite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDroite.Controls.Add(Me.RichTextBox1)
        Me.PanelDroite.Controls.Add(Me.WhyGameList)
        Me.PanelDroite.Controls.Add(Me.VersionNetFramework)
        Me.PanelDroite.Location = New System.Drawing.Point(729, 150)
        Me.PanelDroite.Name = "PanelDroite"
        Me.PanelDroite.Size = New System.Drawing.Size(225, 391)
        Me.PanelDroite.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 536)
        Me.Controls.Add(Me.Disclaimer)
        Me.Controls.Add(Me.PanelDroite)
        Me.Controls.Add(Me.PanelHaut)
        Me.Controls.Add(Me.PanelGauche)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(966, 575)
        Me.MinimumSize = New System.Drawing.Size(966, 575)
        Me.Name = "Form1"
        Me.Text = "Menu RecopierBox"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.Disclaimer.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WhyGameList.ResumeLayout(False)
        Me.WhyGameList.PerformLayout()
        Me.PanelGauche.ResumeLayout(False)
        Me.PanelGauche.PerformLayout()
        Me.PanelHaut.ResumeLayout(False)
        Me.PanelHaut.PerformLayout()
        Me.PanelDroite.ResumeLayout(False)
        Me.PanelDroite.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents ButtonBrowseRecalboxFolder As Button
    Private WithEvents label4 As Label
    Private WithEvents TxtRecalfolderPath As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Disclaimer As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TxtDisclaimer As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VersionNetFramework As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents WhyGameList As GroupBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents txtWhyGamelist As TextBox
    Friend WithEvents PanelGauche As Panel
    Friend WithEvents Quitter As Button
    Friend WithEvents ButtonOverlay As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonQuizz As Button
    Friend WithEvents ButtonCopy As Button
    Private WithEvents Label5 As Label
    Friend WithEvents PanelHaut As Panel
    Friend WithEvents PanelDroite As Panel
End Class
