<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Quizz
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quizz))
        Me.Buttongetback = New System.Windows.Forms.Button()
        Me.GroupParamComplet = New System.Windows.Forms.GroupBox()
        Me.TxtTotalEntrees = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupParametres = New System.Windows.Forms.GroupBox()
        Me.GroupInfoRoms = New System.Windows.Forms.GroupBox()
        Me.TxtRating = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listhelpingboxPlayCount = New System.Windows.Forms.ListBox()
        Me.listhelpingboxAnnee = New System.Windows.Forms.ListBox()
        Me.listhelpingboxGenre = New System.Windows.Forms.ListBox()
        Me.listhelpingboxNote = New System.Windows.Forms.ListBox()
        Me.listhelpingboxPubl = New System.Windows.Forms.ListBox()
        Me.listhelpingboxPlayers = New System.Windows.Forms.ListBox()
        Me.listhelpingboxDev = New System.Windows.Forms.ListBox()
        Me.TxtSynopsis = New System.Windows.Forms.TextBox()
        Me.txtplayers = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPlayCount = New System.Windows.Forms.TextBox()
        Me.txtpub = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdev = New System.Windows.Forms.TextBox()
        Me.txtgenre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAnnee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupConfigPartie = New System.Windows.Forms.GroupBox()
        Me.ModeHardcore = New System.Windows.Forms.CheckBox()
        Me.ModeEasy = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ConsoleTitre = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TitreOnly = New System.Windows.Forms.RadioButton()
        Me.txtnbmanches = New System.Windows.Forms.TextBox()
        Me.ButtonValidConsole = New System.Windows.Forms.Button()
        Me.ButtonDoRandom = New System.Windows.Forms.Button()
        Me.ConsoleList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TempGrid = New System.Windows.Forms.DataGridView()
        Me.ListTitreDesJeux = New System.Windows.Forms.ListBox()
        Me.ListConsoleDesJeux = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PlayerNext = New System.Windows.Forms.Button()
        Me.PlayerPlay = New System.Windows.Forms.Button()
        Me.PlayerStop = New System.Windows.Forms.Button()
        Me.TitleBox = New System.Windows.Forms.PictureBox()
        Me.QuizzBox = New System.Windows.Forms.GroupBox()
        Me.ButtonShowVid = New System.Windows.Forms.Button()
        Me.PlayerPrev = New System.Windows.Forms.Button()
        Me.txtpositionend = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtpositionrandom = New System.Windows.Forms.TextBox()
        Me.RandomList = New System.Windows.Forms.ListBox()
        Me.PlayerAudio = New AxWMPLib.AxWindowsMediaPlayer()
        Me.HiddenButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtRules = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttempsaffichprop = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupParamComplet.SuspendLayout()
        Me.GroupParametres.SuspendLayout()
        Me.GroupInfoRoms.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupConfigPartie.SuspendLayout()
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuizzBox.SuspendLayout()
        CType(Me.PlayerAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HiddenButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Buttongetback
        '
        Me.Buttongetback.Location = New System.Drawing.Point(11, 11)
        Me.Buttongetback.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Buttongetback.Name = "Buttongetback"
        Me.Buttongetback.Size = New System.Drawing.Size(101, 23)
        Me.Buttongetback.TabIndex = 9
        Me.Buttongetback.Text = "Revenir au Menu"
        Me.Buttongetback.UseVisualStyleBackColor = True
        '
        'GroupParamComplet
        '
        Me.GroupParamComplet.BackColor = System.Drawing.Color.Maroon
        Me.GroupParamComplet.Controls.Add(Me.TxtTotalEntrees)
        Me.GroupParamComplet.Controls.Add(Me.Label10)
        Me.GroupParamComplet.Controls.Add(Me.GroupParametres)
        Me.GroupParamComplet.Controls.Add(Me.ButtonValidConsole)
        Me.GroupParamComplet.Controls.Add(Me.ButtonDoRandom)
        Me.GroupParamComplet.Controls.Add(Me.ConsoleList)
        Me.GroupParamComplet.Controls.Add(Me.Label1)
        Me.GroupParamComplet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupParamComplet.Location = New System.Drawing.Point(12, 39)
        Me.GroupParamComplet.Name = "GroupParamComplet"
        Me.GroupParamComplet.Size = New System.Drawing.Size(474, 550)
        Me.GroupParamComplet.TabIndex = 10
        Me.GroupParamComplet.TabStop = False
        Me.GroupParamComplet.Text = "Parametres :"
        '
        'TxtTotalEntrees
        '
        Me.TxtTotalEntrees.BackColor = System.Drawing.Color.Tomato
        Me.TxtTotalEntrees.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalEntrees.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtTotalEntrees.Location = New System.Drawing.Point(147, 514)
        Me.TxtTotalEntrees.Name = "TxtTotalEntrees"
        Me.TxtTotalEntrees.Size = New System.Drawing.Size(120, 31)
        Me.TxtTotalEntrees.TabIndex = 23
        Me.TxtTotalEntrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(147, 495)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Nombre de Jeux Filtrés :"
        '
        'GroupParametres
        '
        Me.GroupParametres.BackColor = System.Drawing.Color.Chocolate
        Me.GroupParametres.Controls.Add(Me.GroupInfoRoms)
        Me.GroupParametres.Controls.Add(Me.GroupConfigPartie)
        Me.GroupParametres.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupParametres.Location = New System.Drawing.Point(147, 16)
        Me.GroupParametres.Name = "GroupParametres"
        Me.GroupParametres.Size = New System.Drawing.Size(321, 464)
        Me.GroupParametres.TabIndex = 29
        Me.GroupParametres.TabStop = False
        Me.GroupParametres.Text = "Selection des Filtres :"
        '
        'GroupInfoRoms
        '
        Me.GroupInfoRoms.BackColor = System.Drawing.Color.MistyRose
        Me.GroupInfoRoms.Controls.Add(Me.TxtRating)
        Me.GroupInfoRoms.Controls.Add(Me.GroupBox1)
        Me.GroupInfoRoms.Controls.Add(Me.TxtSynopsis)
        Me.GroupInfoRoms.Controls.Add(Me.txtplayers)
        Me.GroupInfoRoms.Controls.Add(Me.Label9)
        Me.GroupInfoRoms.Controls.Add(Me.TxtPlayCount)
        Me.GroupInfoRoms.Controls.Add(Me.txtpub)
        Me.GroupInfoRoms.Controls.Add(Me.Label3)
        Me.GroupInfoRoms.Controls.Add(Me.txtdev)
        Me.GroupInfoRoms.Controls.Add(Me.txtgenre)
        Me.GroupInfoRoms.Controls.Add(Me.Label4)
        Me.GroupInfoRoms.Controls.Add(Me.Label2)
        Me.GroupInfoRoms.Controls.Add(Me.TxtAnnee)
        Me.GroupInfoRoms.Controls.Add(Me.Label7)
        Me.GroupInfoRoms.Controls.Add(Me.Label5)
        Me.GroupInfoRoms.Controls.Add(Me.Label8)
        Me.GroupInfoRoms.Controls.Add(Me.Label6)
        Me.GroupInfoRoms.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupInfoRoms.Location = New System.Drawing.Point(6, 19)
        Me.GroupInfoRoms.Name = "GroupInfoRoms"
        Me.GroupInfoRoms.Size = New System.Drawing.Size(309, 333)
        Me.GroupInfoRoms.TabIndex = 22
        Me.GroupInfoRoms.TabStop = False
        Me.GroupInfoRoms.Text = "Définir un/plusieurs Filtres sur Votre Selection :"
        '
        'TxtRating
        '
        Me.TxtRating.Location = New System.Drawing.Point(6, 307)
        Me.TxtRating.Name = "TxtRating"
        Me.TxtRating.Size = New System.Drawing.Size(121, 20)
        Me.TxtRating.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.listhelpingboxPlayCount)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxAnnee)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxGenre)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxNote)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxPubl)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxPlayers)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxDev)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(155, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 311)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catégories Trouvées :"
        '
        'listhelpingboxPlayCount
        '
        Me.listhelpingboxPlayCount.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxPlayCount.FormattingEnabled = True
        Me.listhelpingboxPlayCount.Location = New System.Drawing.Point(6, 198)
        Me.listhelpingboxPlayCount.Name = "listhelpingboxPlayCount"
        Me.listhelpingboxPlayCount.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxPlayCount.Sorted = True
        Me.listhelpingboxPlayCount.TabIndex = 34
        '
        'listhelpingboxAnnee
        '
        Me.listhelpingboxAnnee.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxAnnee.FormattingEnabled = True
        Me.listhelpingboxAnnee.Location = New System.Drawing.Point(6, 124)
        Me.listhelpingboxAnnee.Name = "listhelpingboxAnnee"
        Me.listhelpingboxAnnee.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxAnnee.Sorted = True
        Me.listhelpingboxAnnee.TabIndex = 33
        '
        'listhelpingboxGenre
        '
        Me.listhelpingboxGenre.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxGenre.FormattingEnabled = True
        Me.listhelpingboxGenre.Location = New System.Drawing.Point(6, 16)
        Me.listhelpingboxGenre.Name = "listhelpingboxGenre"
        Me.listhelpingboxGenre.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxGenre.Sorted = True
        Me.listhelpingboxGenre.TabIndex = 28
        '
        'listhelpingboxNote
        '
        Me.listhelpingboxNote.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxNote.FormattingEnabled = True
        Me.listhelpingboxNote.Location = New System.Drawing.Point(6, 275)
        Me.listhelpingboxNote.Name = "listhelpingboxNote"
        Me.listhelpingboxNote.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxNote.Sorted = True
        Me.listhelpingboxNote.TabIndex = 32
        '
        'listhelpingboxPubl
        '
        Me.listhelpingboxPubl.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxPubl.FormattingEnabled = True
        Me.listhelpingboxPubl.Location = New System.Drawing.Point(6, 88)
        Me.listhelpingboxPubl.Name = "listhelpingboxPubl"
        Me.listhelpingboxPubl.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxPubl.Sorted = True
        Me.listhelpingboxPubl.TabIndex = 29
        '
        'listhelpingboxPlayers
        '
        Me.listhelpingboxPlayers.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxPlayers.FormattingEnabled = True
        Me.listhelpingboxPlayers.Location = New System.Drawing.Point(6, 162)
        Me.listhelpingboxPlayers.Name = "listhelpingboxPlayers"
        Me.listhelpingboxPlayers.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxPlayers.Sorted = True
        Me.listhelpingboxPlayers.TabIndex = 31
        '
        'listhelpingboxDev
        '
        Me.listhelpingboxDev.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxDev.FormattingEnabled = True
        Me.listhelpingboxDev.Location = New System.Drawing.Point(6, 52)
        Me.listhelpingboxDev.Name = "listhelpingboxDev"
        Me.listhelpingboxDev.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxDev.Sorted = True
        Me.listhelpingboxDev.TabIndex = 30
        '
        'TxtSynopsis
        '
        Me.TxtSynopsis.Location = New System.Drawing.Point(6, 266)
        Me.TxtSynopsis.Name = "TxtSynopsis"
        Me.TxtSynopsis.Size = New System.Drawing.Size(121, 20)
        Me.TxtSynopsis.TabIndex = 22
        '
        'txtplayers
        '
        Me.txtplayers.Location = New System.Drawing.Point(6, 188)
        Me.txtplayers.Name = "txtplayers"
        Me.txtplayers.Size = New System.Drawing.Size(121, 20)
        Me.txtplayers.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nombre de Fois Joué :"
        '
        'TxtPlayCount
        '
        Me.TxtPlayCount.Location = New System.Drawing.Point(6, 227)
        Me.TxtPlayCount.Name = "TxtPlayCount"
        Me.TxtPlayCount.Size = New System.Drawing.Size(121, 20)
        Me.TxtPlayCount.TabIndex = 20
        '
        'txtpub
        '
        Me.txtpub.Location = New System.Drawing.Point(6, 110)
        Me.txtpub.Name = "txtpub"
        Me.txtpub.Size = New System.Drawing.Size(121, 20)
        Me.txtpub.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mot Clé dans Synopsis :"
        '
        'txtdev
        '
        Me.txtdev.Location = New System.Drawing.Point(6, 71)
        Me.txtdev.Name = "txtdev"
        Me.txtdev.Size = New System.Drawing.Size(121, 20)
        Me.txtdev.TabIndex = 23
        '
        'txtgenre
        '
        Me.txtgenre.Location = New System.Drawing.Point(6, 32)
        Me.txtgenre.Name = "txtgenre"
        Me.txtgenre.Size = New System.Drawing.Size(121, 20)
        Me.txtgenre.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Note :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Genre :"
        '
        'TxtAnnee
        '
        Me.TxtAnnee.Location = New System.Drawing.Point(6, 149)
        Me.TxtAnnee.Name = "TxtAnnee"
        Me.TxtAnnee.Size = New System.Drawing.Size(121, 20)
        Me.TxtAnnee.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nombre de Joueurs :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Developer :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Annee de Sortie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Publisher :"
        '
        'GroupConfigPartie
        '
        Me.GroupConfigPartie.BackColor = System.Drawing.Color.Black
        Me.GroupConfigPartie.Controls.Add(Me.Label16)
        Me.GroupConfigPartie.Controls.Add(Me.txttempsaffichprop)
        Me.GroupConfigPartie.Controls.Add(Me.ModeHardcore)
        Me.GroupConfigPartie.Controls.Add(Me.ModeEasy)
        Me.GroupConfigPartie.Controls.Add(Me.Label14)
        Me.GroupConfigPartie.Controls.Add(Me.Label13)
        Me.GroupConfigPartie.Controls.Add(Me.ConsoleTitre)
        Me.GroupConfigPartie.Controls.Add(Me.Label11)
        Me.GroupConfigPartie.Controls.Add(Me.TitreOnly)
        Me.GroupConfigPartie.Controls.Add(Me.txtnbmanches)
        Me.GroupConfigPartie.ForeColor = System.Drawing.Color.White
        Me.GroupConfigPartie.Location = New System.Drawing.Point(6, 358)
        Me.GroupConfigPartie.Name = "GroupConfigPartie"
        Me.GroupConfigPartie.Size = New System.Drawing.Size(309, 100)
        Me.GroupConfigPartie.TabIndex = 27
        Me.GroupConfigPartie.TabStop = False
        Me.GroupConfigPartie.Text = "Config Partie :"
        '
        'ModeHardcore
        '
        Me.ModeHardcore.AutoSize = True
        Me.ModeHardcore.Checked = True
        Me.ModeHardcore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ModeHardcore.ForeColor = System.Drawing.Color.Cornsilk
        Me.ModeHardcore.Location = New System.Drawing.Point(155, 77)
        Me.ModeHardcore.Name = "ModeHardcore"
        Me.ModeHardcore.Size = New System.Drawing.Size(152, 17)
        Me.ModeHardcore.TabIndex = 34
        Me.ModeHardcore.Text = "Mode Hardcore (Son Only)"
        Me.ModeHardcore.UseVisualStyleBackColor = True
        '
        'ModeEasy
        '
        Me.ModeEasy.AutoSize = True
        Me.ModeEasy.ForeColor = System.Drawing.Color.Cornsilk
        Me.ModeEasy.Location = New System.Drawing.Point(9, 77)
        Me.ModeEasy.Name = "ModeEasy"
        Me.ModeEasy.Size = New System.Drawing.Size(143, 17)
        Me.ModeEasy.TabIndex = 33
        Me.ModeEasy.Text = "Mode Easy (Avec Video)"
        Me.ModeEasy.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Location = New System.Drawing.Point(24, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Type de Jeu :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(24, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Difficulté :"
        '
        'ConsoleTitre
        '
        Me.ConsoleTitre.AutoSize = True
        Me.ConsoleTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ConsoleTitre.Location = New System.Drawing.Point(9, 41)
        Me.ConsoleTitre.Name = "ConsoleTitre"
        Me.ConsoleTitre.Size = New System.Drawing.Size(96, 17)
        Me.ConsoleTitre.TabIndex = 26
        Me.ConsoleTitre.TabStop = True
        Me.ConsoleTitre.Text = "Console + Titre"
        Me.ConsoleTitre.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Location = New System.Drawing.Point(134, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Saisir nb de Manches :"
        '
        'TitreOnly
        '
        Me.TitreOnly.AutoSize = True
        Me.TitreOnly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TitreOnly.Location = New System.Drawing.Point(9, 24)
        Me.TitreOnly.Name = "TitreOnly"
        Me.TitreOnly.Size = New System.Drawing.Size(97, 17)
        Me.TitreOnly.TabIndex = 25
        Me.TitreOnly.TabStop = True
        Me.TitreOnly.Text = "Deviner le Titre"
        Me.TitreOnly.UseVisualStyleBackColor = True
        '
        'txtnbmanches
        '
        Me.txtnbmanches.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtnbmanches.ForeColor = System.Drawing.SystemColors.Window
        Me.txtnbmanches.Location = New System.Drawing.Point(255, 8)
        Me.txtnbmanches.Name = "txtnbmanches"
        Me.txtnbmanches.Size = New System.Drawing.Size(48, 20)
        Me.txtnbmanches.TabIndex = 25
        Me.txtnbmanches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonValidConsole
        '
        Me.ButtonValidConsole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonValidConsole.Location = New System.Drawing.Point(6, 483)
        Me.ButtonValidConsole.Name = "ButtonValidConsole"
        Me.ButtonValidConsole.Size = New System.Drawing.Size(135, 38)
        Me.ButtonValidConsole.TabIndex = 28
        Me.ButtonValidConsole.Text = "Valider les Systèmes"
        Me.ButtonValidConsole.UseVisualStyleBackColor = True
        '
        'ButtonDoRandom
        '
        Me.ButtonDoRandom.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDoRandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonDoRandom.Image = CType(resources.GetObject("ButtonDoRandom.Image"), System.Drawing.Image)
        Me.ButtonDoRandom.Location = New System.Drawing.Point(274, 487)
        Me.ButtonDoRandom.Name = "ButtonDoRandom"
        Me.ButtonDoRandom.Size = New System.Drawing.Size(194, 46)
        Me.ButtonDoRandom.TabIndex = 24
        Me.ButtonDoRandom.UseVisualStyleBackColor = False
        '
        'ConsoleList
        '
        Me.ConsoleList.BackColor = System.Drawing.Color.PeachPuff
        Me.ConsoleList.ForeColor = System.Drawing.Color.SaddleBrown
        Me.ConsoleList.FormattingEnabled = True
        Me.ConsoleList.Location = New System.Drawing.Point(6, 35)
        Me.ConsoleList.Name = "ConsoleList"
        Me.ConsoleList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ConsoleList.Size = New System.Drawing.Size(135, 420)
        Me.ConsoleList.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selection des Consoles"
        '
        'TempGrid
        '
        Me.TempGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TempGrid.Location = New System.Drawing.Point(117, 3)
        Me.TempGrid.Name = "TempGrid"
        Me.TempGrid.RowHeadersWidth = 51
        Me.TempGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TempGrid.Size = New System.Drawing.Size(369, 30)
        Me.TempGrid.TabIndex = 11
        '
        'ListTitreDesJeux
        '
        Me.ListTitreDesJeux.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListTitreDesJeux.FormattingEnabled = True
        Me.ListTitreDesJeux.Location = New System.Drawing.Point(121, 299)
        Me.ListTitreDesJeux.Name = "ListTitreDesJeux"
        Me.ListTitreDesJeux.Size = New System.Drawing.Size(286, 186)
        Me.ListTitreDesJeux.TabIndex = 23
        '
        'ListConsoleDesJeux
        '
        Me.ListConsoleDesJeux.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListConsoleDesJeux.FormattingEnabled = True
        Me.ListConsoleDesJeux.Location = New System.Drawing.Point(8, 300)
        Me.ListConsoleDesJeux.Name = "ListConsoleDesJeux"
        Me.ListConsoleDesJeux.Size = New System.Drawing.Size(107, 186)
        Me.ListConsoleDesJeux.TabIndex = 24
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 271)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(401, 23)
        Me.ProgressBar1.TabIndex = 27
        '
        'PlayerNext
        '
        Me.PlayerNext.BackColor = System.Drawing.Color.RoyalBlue
        Me.PlayerNext.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerNext.Location = New System.Drawing.Point(355, 224)
        Me.PlayerNext.Name = "PlayerNext"
        Me.PlayerNext.Size = New System.Drawing.Size(49, 41)
        Me.PlayerNext.TabIndex = 28
        Me.PlayerNext.Text = ">>"
        Me.PlayerNext.UseVisualStyleBackColor = False
        '
        'PlayerPlay
        '
        Me.PlayerPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlayerPlay.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPlay.Location = New System.Drawing.Point(152, 224)
        Me.PlayerPlay.Name = "PlayerPlay"
        Me.PlayerPlay.Size = New System.Drawing.Size(49, 41)
        Me.PlayerPlay.TabIndex = 33
        Me.PlayerPlay.Text = "|>"
        Me.PlayerPlay.UseVisualStyleBackColor = False
        '
        'PlayerStop
        '
        Me.PlayerStop.BackColor = System.Drawing.Color.GhostWhite
        Me.PlayerStop.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerStop.Location = New System.Drawing.Point(250, 224)
        Me.PlayerStop.Name = "PlayerStop"
        Me.PlayerStop.Size = New System.Drawing.Size(73, 41)
        Me.PlayerStop.TabIndex = 34
        Me.PlayerStop.Text = "[STOP]"
        Me.PlayerStop.UseVisualStyleBackColor = False
        '
        'TitleBox
        '
        Me.TitleBox.BackColor = System.Drawing.Color.White
        Me.TitleBox.Image = CType(resources.GetObject("TitleBox.Image"), System.Drawing.Image)
        Me.TitleBox.Location = New System.Drawing.Point(492, 3)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(212, 89)
        Me.TitleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TitleBox.TabIndex = 35
        Me.TitleBox.TabStop = False
        '
        'QuizzBox
        '
        Me.QuizzBox.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.QuizzBox.Controls.Add(Me.Label15)
        Me.QuizzBox.Controls.Add(Me.ButtonShowVid)
        Me.QuizzBox.Controls.Add(Me.PlayerPrev)
        Me.QuizzBox.Controls.Add(Me.txtpositionend)
        Me.QuizzBox.Controls.Add(Me.ListTitreDesJeux)
        Me.QuizzBox.Controls.Add(Me.ListConsoleDesJeux)
        Me.QuizzBox.Controls.Add(Me.ProgressBar1)
        Me.QuizzBox.Controls.Add(Me.PlayerStop)
        Me.QuizzBox.Controls.Add(Me.Label12)
        Me.QuizzBox.Controls.Add(Me.PlayerPlay)
        Me.QuizzBox.Controls.Add(Me.PlayerNext)
        Me.QuizzBox.Controls.Add(Me.txtpositionrandom)
        Me.QuizzBox.Controls.Add(Me.RandomList)
        Me.QuizzBox.Controls.Add(Me.PlayerAudio)
        Me.QuizzBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QuizzBox.Location = New System.Drawing.Point(492, 98)
        Me.QuizzBox.Name = "QuizzBox"
        Me.QuizzBox.Size = New System.Drawing.Size(413, 491)
        Me.QuizzBox.TabIndex = 36
        Me.QuizzBox.TabStop = False
        Me.QuizzBox.Text = "Menu QuizzBox :"
        '
        'ButtonShowVid
        '
        Me.ButtonShowVid.Location = New System.Drawing.Point(8, 222)
        Me.ButtonShowVid.Name = "ButtonShowVid"
        Me.ButtonShowVid.Size = New System.Drawing.Size(54, 43)
        Me.ButtonShowVid.TabIndex = 39
        Me.ButtonShowVid.UseVisualStyleBackColor = True
        '
        'PlayerPrev
        '
        Me.PlayerPrev.BackColor = System.Drawing.Color.RoyalBlue
        Me.PlayerPrev.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerPrev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPrev.Location = New System.Drawing.Point(68, 224)
        Me.PlayerPrev.Name = "PlayerPrev"
        Me.PlayerPrev.Size = New System.Drawing.Size(49, 41)
        Me.PlayerPrev.TabIndex = 38
        Me.PlayerPrev.Text = "<<"
        Me.PlayerPrev.UseVisualStyleBackColor = False
        '
        'txtpositionend
        '
        Me.txtpositionend.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpositionend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtpositionend.Location = New System.Drawing.Point(302, 13)
        Me.txtpositionend.Name = "txtpositionend"
        Me.txtpositionend.ReadOnly = True
        Me.txtpositionend.Size = New System.Drawing.Size(79, 31)
        Me.txtpositionend.TabIndex = 37
        Me.txtpositionend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(276, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "sur"
        '
        'txtpositionrandom
        '
        Me.txtpositionrandom.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpositionrandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtpositionrandom.Location = New System.Drawing.Point(190, 13)
        Me.txtpositionrandom.Name = "txtpositionrandom"
        Me.txtpositionrandom.ReadOnly = True
        Me.txtpositionrandom.Size = New System.Drawing.Size(79, 31)
        Me.txtpositionrandom.TabIndex = 35
        Me.txtpositionrandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomList
        '
        Me.RandomList.BackColor = System.Drawing.Color.Thistle
        Me.RandomList.Enabled = False
        Me.RandomList.FormattingEnabled = True
        Me.RandomList.Location = New System.Drawing.Point(6, 17)
        Me.RandomList.Name = "RandomList"
        Me.RandomList.Size = New System.Drawing.Size(56, 199)
        Me.RandomList.TabIndex = 34
        '
        'PlayerAudio
        '
        Me.PlayerAudio.Enabled = True
        Me.PlayerAudio.Location = New System.Drawing.Point(68, 47)
        Me.PlayerAudio.Name = "PlayerAudio"
        Me.PlayerAudio.OcxState = CType(resources.GetObject("PlayerAudio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PlayerAudio.Size = New System.Drawing.Size(336, 176)
        Me.PlayerAudio.TabIndex = 33
        '
        'HiddenButton
        '
        Me.HiddenButton.Location = New System.Drawing.Point(683, 59)
        Me.HiddenButton.Name = "HiddenButton"
        Me.HiddenButton.Size = New System.Drawing.Size(5, 5)
        Me.HiddenButton.TabIndex = 39
        Me.HiddenButton.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'txtRules
        '
        Me.txtRules.BackColor = System.Drawing.Color.BlueViolet
        Me.txtRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRules.ForeColor = System.Drawing.SystemColors.Window
        Me.txtRules.Location = New System.Drawing.Point(710, 3)
        Me.txtRules.Multiline = True
        Me.txtRules.Name = "txtRules"
        Me.txtRules.ReadOnly = True
        Me.txtRules.Size = New System.Drawing.Size(195, 89)
        Me.txtRules.TabIndex = 40
        Me.txtRules.Text = "Vous allez entendre/voir une video." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*1ère moitié : Concentrez-vous, Souvenez-vou" &
    "s et Reflechissez !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*2ème moitié : Des propositions apparaissent, Validez vot" &
    "re choix !"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(143, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Titre n°"
        '
        'txttempsaffichprop
        '
        Me.txttempsaffichprop.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txttempsaffichprop.ForeColor = System.Drawing.SystemColors.Window
        Me.txttempsaffichprop.Location = New System.Drawing.Point(255, 28)
        Me.txttempsaffichprop.Name = "txttempsaffichprop"
        Me.txttempsaffichprop.Size = New System.Drawing.Size(48, 20)
        Me.txttempsaffichprop.TabIndex = 35
        Me.txttempsaffichprop.Text = "15"
        Me.txttempsaffichprop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label16.Location = New System.Drawing.Point(119, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(130, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Temps avant Proposition :"
        '
        'Quizz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(908, 588)
        Me.Controls.Add(Me.HiddenButton)
        Me.Controls.Add(Me.QuizzBox)
        Me.Controls.Add(Me.TitleBox)
        Me.Controls.Add(Me.TempGrid)
        Me.Controls.Add(Me.GroupParamComplet)
        Me.Controls.Add(Me.Buttongetback)
        Me.Controls.Add(Me.txtRules)
        Me.MaximumSize = New System.Drawing.Size(924, 627)
        Me.MinimumSize = New System.Drawing.Size(924, 627)
        Me.Name = "Quizz"
        Me.Text = "Quizz"
        Me.GroupParamComplet.ResumeLayout(False)
        Me.GroupParamComplet.PerformLayout()
        Me.GroupParametres.ResumeLayout(False)
        Me.GroupInfoRoms.ResumeLayout(False)
        Me.GroupInfoRoms.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupConfigPartie.ResumeLayout(False)
        Me.GroupConfigPartie.PerformLayout()
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuizzBox.ResumeLayout(False)
        Me.QuizzBox.PerformLayout()
        CType(Me.PlayerAudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HiddenButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Buttongetback As Button
    Friend WithEvents GroupParamComplet As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ConsoleList As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupConfigPartie As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtnbmanches As TextBox
    Friend WithEvents ButtonDoRandom As Button
    Friend WithEvents TxtSynopsis As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPlayCount As TextBox
    Friend WithEvents GroupInfoRoms As GroupBox
    Friend WithEvents TxtAnnee As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TempGrid As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonValidConsole As Button
    Friend WithEvents GroupParametres As GroupBox
    Friend WithEvents TxtTotalEntrees As TextBox
    Friend WithEvents ConsoleTitre As RadioButton
    Friend WithEvents TitreOnly As RadioButton
    Friend WithEvents ListTitreDesJeux As ListBox
    Friend WithEvents ListConsoleDesJeux As ListBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents listhelpingboxGenre As ListBox
    Friend WithEvents listhelpingboxPubl As ListBox
    Friend WithEvents listhelpingboxNote As ListBox
    Friend WithEvents listhelpingboxPlayers As ListBox
    Friend WithEvents listhelpingboxDev As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtplayers As TextBox
    Friend WithEvents txtpub As TextBox
    Friend WithEvents txtdev As TextBox
    Friend WithEvents txtgenre As TextBox
    Friend WithEvents PlayerNext As Button
    Friend WithEvents PlayerPlay As Button
    Friend WithEvents PlayerStop As Button
    Friend WithEvents TitleBox As PictureBox
    Friend WithEvents QuizzBox As GroupBox
    Friend WithEvents PlayerPrev As Button
    Friend WithEvents txtpositionend As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtpositionrandom As TextBox
    Friend WithEvents RandomList As ListBox
    Friend WithEvents PlayerAudio As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents HiddenButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TxtRating As TextBox
    Friend WithEvents ButtonShowVid As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ModeHardcore As CheckBox
    Friend WithEvents ModeEasy As CheckBox
    Friend WithEvents txtRules As TextBox
    Friend WithEvents listhelpingboxAnnee As ListBox
    Friend WithEvents listhelpingboxPlayCount As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txttempsaffichprop As TextBox
    Friend WithEvents Label15 As Label
End Class
