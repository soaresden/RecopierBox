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
        Me.GroupParamComplet = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ButtonInfo = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonDoRandom1 = New System.Windows.Forms.Button()
        Me.GroupConfigPartie = New System.Windows.Forms.GroupBox()
        Me.PasTitreNiConsole = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txttempsaffichprop = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ConsoleTitre = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TitreOnly = New System.Windows.Forms.RadioButton()
        Me.txtnbmanches = New System.Windows.Forms.TextBox()
        Me.ButtonValidConsole1 = New System.Windows.Forms.Button()
        Me.TxtTotalEntrees = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ConsoleList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupFiltres = New System.Windows.Forms.GroupBox()
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
        Me.ListTitreDesJeux = New System.Windows.Forms.ListBox()
        Me.ListConsoleDesJeux = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonGetBack1 = New System.Windows.Forms.Button()
        Me.ToolTipNbJeux = New System.Windows.Forms.ToolTip(Me.components)
        Me.TitleBox = New System.Windows.Forms.GroupBox()
        Me.PlayerAudio = New AxWMPLib.AxWindowsMediaPlayer()
        Me.listrandobox = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TimeBox = New System.Windows.Forms.TextBox()
        Me.PlayerNext = New System.Windows.Forms.Button()
        Me.RandomList = New System.Windows.Forms.ListBox()
        Me.txtpositionend = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PlayerPrev = New System.Windows.Forms.Button()
        Me.PlayerStop = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PlayerPlay = New System.Windows.Forms.Button()
        Me.txtpositionrandom = New System.Windows.Forms.TextBox()
        Me.GroupDifficulty = New System.Windows.Forms.GroupBox()
        Me.ValidQuizz = New System.Windows.Forms.Button()
        Me.PlayerOnce = New System.Windows.Forms.CheckBox()
        Me.PlayerRepeat = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SonSans = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.VidPixel = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.VidNormal = New System.Windows.Forms.CheckBox()
        Me.SonAvec = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Historique = New System.Windows.Forms.ListBox()
        Me.TempGrid = New System.Windows.Forms.DataGridView()
        Me.VidSans = New System.Windows.Forms.CheckBox()
        Me.ExportTxt = New System.Windows.Forms.Button()
        Me.GroupParamComplet.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupConfigPartie.SuspendLayout()
        Me.GroupFiltres.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TitleBox.SuspendLayout()
        CType(Me.PlayerAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupDifficulty.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupParamComplet
        '
        Me.GroupParamComplet.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GroupParamComplet.Controls.Add(Me.Label20)
        Me.GroupParamComplet.Controls.Add(Me.ButtonInfo)
        Me.GroupParamComplet.Controls.Add(Me.PictureBox2)
        Me.GroupParamComplet.Controls.Add(Me.ButtonDoRandom1)
        Me.GroupParamComplet.Controls.Add(Me.GroupConfigPartie)
        Me.GroupParamComplet.Controls.Add(Me.ButtonValidConsole1)
        Me.GroupParamComplet.Controls.Add(Me.TxtTotalEntrees)
        Me.GroupParamComplet.Controls.Add(Me.Label10)
        Me.GroupParamComplet.Controls.Add(Me.ConsoleList)
        Me.GroupParamComplet.Controls.Add(Me.Label1)
        Me.GroupParamComplet.Controls.Add(Me.GroupFiltres)
        Me.GroupParamComplet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupParamComplet.Location = New System.Drawing.Point(12, 39)
        Me.GroupParamComplet.Name = "GroupParamComplet"
        Me.GroupParamComplet.Size = New System.Drawing.Size(474, 559)
        Me.GroupParamComplet.TabIndex = 10
        Me.GroupParamComplet.TabStop = False
        Me.GroupParamComplet.Text = "Parametres :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(171, 98)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 13)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Cacher/Afficher les Filtres"
        '
        'ButtonInfo
        '
        Me.ButtonInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ButtonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInfo.Font = New System.Drawing.Font("Equinox Com", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInfo.ForeColor = System.Drawing.Color.White
        Me.ButtonInfo.Image = CType(resources.GetObject("ButtonInfo.Image"), System.Drawing.Image)
        Me.ButtonInfo.Location = New System.Drawing.Point(210, 111)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(42, 39)
        Me.ButtonInfo.TabIndex = 47
        Me.ButtonInfo.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(129, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'ButtonDoRandom1
        '
        Me.ButtonDoRandom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ButtonDoRandom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonDoRandom1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonDoRandom1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonDoRandom1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ButtonDoRandom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDoRandom1.Font = New System.Drawing.Font("Equinox Com", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDoRandom1.ForeColor = System.Drawing.Color.White
        Me.ButtonDoRandom1.Location = New System.Drawing.Point(220, 506)
        Me.ButtonDoRandom1.Name = "ButtonDoRandom1"
        Me.ButtonDoRandom1.Size = New System.Drawing.Size(183, 45)
        Me.ButtonDoRandom1.TabIndex = 45
        Me.ButtonDoRandom1.Text = "Générer Nouveau Jeu"
        Me.ButtonDoRandom1.UseVisualStyleBackColor = False
        '
        'GroupConfigPartie
        '
        Me.GroupConfigPartie.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.GroupConfigPartie.Controls.Add(Me.PasTitreNiConsole)
        Me.GroupConfigPartie.Controls.Add(Me.Label17)
        Me.GroupConfigPartie.Controls.Add(Me.Label16)
        Me.GroupConfigPartie.Controls.Add(Me.txttempsaffichprop)
        Me.GroupConfigPartie.Controls.Add(Me.Label14)
        Me.GroupConfigPartie.Controls.Add(Me.ConsoleTitre)
        Me.GroupConfigPartie.Controls.Add(Me.Label11)
        Me.GroupConfigPartie.Controls.Add(Me.TitreOnly)
        Me.GroupConfigPartie.Controls.Add(Me.txtnbmanches)
        Me.GroupConfigPartie.ForeColor = System.Drawing.Color.White
        Me.GroupConfigPartie.Location = New System.Drawing.Point(147, 9)
        Me.GroupConfigPartie.Name = "GroupConfigPartie"
        Me.GroupConfigPartie.Size = New System.Drawing.Size(321, 88)
        Me.GroupConfigPartie.TabIndex = 27
        Me.GroupConfigPartie.TabStop = False
        Me.GroupConfigPartie.Text = "Config Partie :"
        '
        'PasTitreNiConsole
        '
        Me.PasTitreNiConsole.AutoSize = True
        Me.PasTitreNiConsole.ForeColor = System.Drawing.Color.White
        Me.PasTitreNiConsole.Location = New System.Drawing.Point(9, 65)
        Me.PasTitreNiConsole.Name = "PasTitreNiConsole"
        Me.PasTitreNiConsole.Size = New System.Drawing.Size(118, 17)
        Me.PasTitreNiConsole.TabIndex = 38
        Me.PasTitreNiConsole.Text = "Pas de Propositions"
        Me.PasTitreNiConsole.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(249, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 16)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Options :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(152, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "_ sec avant Proposition"
        '
        'txttempsaffichprop
        '
        Me.txttempsaffichprop.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txttempsaffichprop.ForeColor = System.Drawing.SystemColors.Window
        Me.txttempsaffichprop.Location = New System.Drawing.Point(270, 61)
        Me.txttempsaffichprop.Name = "txttempsaffichprop"
        Me.txttempsaffichprop.Size = New System.Drawing.Size(48, 20)
        Me.txttempsaffichprop.TabIndex = 35
        Me.txttempsaffichprop.Text = "15"
        Me.txttempsaffichprop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 16)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Type de Jeu :"
        '
        'ConsoleTitre
        '
        Me.ConsoleTitre.AutoSize = True
        Me.ConsoleTitre.ForeColor = System.Drawing.Color.White
        Me.ConsoleTitre.Location = New System.Drawing.Point(9, 50)
        Me.ConsoleTitre.Name = "ConsoleTitre"
        Me.ConsoleTitre.Size = New System.Drawing.Size(96, 17)
        Me.ConsoleTitre.TabIndex = 26
        Me.ConsoleTitre.Text = "Console + Titre"
        Me.ConsoleTitre.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(170, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Générer _ manches"
        '
        'TitreOnly
        '
        Me.TitreOnly.AutoSize = True
        Me.TitreOnly.ForeColor = System.Drawing.Color.White
        Me.TitreOnly.Location = New System.Drawing.Point(9, 35)
        Me.TitreOnly.Name = "TitreOnly"
        Me.TitreOnly.Size = New System.Drawing.Size(97, 17)
        Me.TitreOnly.TabIndex = 25
        Me.TitreOnly.Text = "Deviner le Titre"
        Me.TitreOnly.UseVisualStyleBackColor = True
        '
        'txtnbmanches
        '
        Me.txtnbmanches.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtnbmanches.ForeColor = System.Drawing.SystemColors.Window
        Me.txtnbmanches.Location = New System.Drawing.Point(270, 35)
        Me.txtnbmanches.Name = "txtnbmanches"
        Me.txtnbmanches.Size = New System.Drawing.Size(48, 20)
        Me.txtnbmanches.TabIndex = 25
        Me.txtnbmanches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonValidConsole1
        '
        Me.ButtonValidConsole1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ButtonValidConsole1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonValidConsole1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonValidConsole1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonValidConsole1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ButtonValidConsole1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonValidConsole1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonValidConsole1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonValidConsole1.Location = New System.Drawing.Point(6, 506)
        Me.ButtonValidConsole1.Name = "ButtonValidConsole1"
        Me.ButtonValidConsole1.Size = New System.Drawing.Size(135, 44)
        Me.ButtonValidConsole1.TabIndex = 42
        Me.ButtonValidConsole1.Text = "Valider la Selection"
        Me.ButtonValidConsole1.UseVisualStyleBackColor = False
        '
        'TxtTotalEntrees
        '
        Me.TxtTotalEntrees.BackColor = System.Drawing.Color.Plum
        Me.TxtTotalEntrees.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalEntrees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TxtTotalEntrees.Location = New System.Drawing.Point(348, 114)
        Me.TxtTotalEntrees.Name = "TxtTotalEntrees"
        Me.TxtTotalEntrees.ReadOnly = True
        Me.TxtTotalEntrees.Size = New System.Drawing.Size(120, 31)
        Me.TxtTotalEntrees.TabIndex = 23
        Me.TxtTotalEntrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(338, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "__ Jeux dans la liste filtrée" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ConsoleList
        '
        Me.ConsoleList.BackColor = System.Drawing.Color.White
        Me.ConsoleList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ConsoleList.FormattingEnabled = True
        Me.ConsoleList.Location = New System.Drawing.Point(6, 126)
        Me.ConsoleList.Name = "ConsoleList"
        Me.ConsoleList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ConsoleList.Size = New System.Drawing.Size(135, 368)
        Me.ConsoleList.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selection des Consoles :"
        '
        'GroupFiltres
        '
        Me.GroupFiltres.BackColor = System.Drawing.Color.Thistle
        Me.GroupFiltres.Controls.Add(Me.TxtRating)
        Me.GroupFiltres.Controls.Add(Me.GroupBox1)
        Me.GroupFiltres.Controls.Add(Me.TxtSynopsis)
        Me.GroupFiltres.Controls.Add(Me.txtplayers)
        Me.GroupFiltres.Controls.Add(Me.Label9)
        Me.GroupFiltres.Controls.Add(Me.TxtPlayCount)
        Me.GroupFiltres.Controls.Add(Me.txtpub)
        Me.GroupFiltres.Controls.Add(Me.Label3)
        Me.GroupFiltres.Controls.Add(Me.txtdev)
        Me.GroupFiltres.Controls.Add(Me.txtgenre)
        Me.GroupFiltres.Controls.Add(Me.Label4)
        Me.GroupFiltres.Controls.Add(Me.Label2)
        Me.GroupFiltres.Controls.Add(Me.TxtAnnee)
        Me.GroupFiltres.Controls.Add(Me.Label7)
        Me.GroupFiltres.Controls.Add(Me.Label5)
        Me.GroupFiltres.Controls.Add(Me.Label8)
        Me.GroupFiltres.Controls.Add(Me.Label6)
        Me.GroupFiltres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupFiltres.Location = New System.Drawing.Point(147, 155)
        Me.GroupFiltres.Name = "GroupFiltres"
        Me.GroupFiltres.Size = New System.Drawing.Size(321, 337)
        Me.GroupFiltres.TabIndex = 29
        Me.GroupFiltres.TabStop = False
        Me.GroupFiltres.Text = "Saisir des Filtres et validez par Entree :"
        '
        'TxtRating
        '
        Me.TxtRating.Location = New System.Drawing.Point(6, 308)
        Me.TxtRating.Name = "TxtRating"
        Me.TxtRating.Size = New System.Drawing.Size(146, 20)
        Me.TxtRating.TabIndex = 44
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
        Me.GroupBox1.Location = New System.Drawing.Point(167, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 311)
        Me.GroupBox1.TabIndex = 43
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
        Me.TxtSynopsis.Location = New System.Drawing.Point(6, 267)
        Me.TxtSynopsis.Name = "TxtSynopsis"
        Me.TxtSynopsis.Size = New System.Drawing.Size(146, 20)
        Me.TxtSynopsis.TabIndex = 38
        '
        'txtplayers
        '
        Me.txtplayers.Location = New System.Drawing.Point(6, 189)
        Me.txtplayers.Name = "txtplayers"
        Me.txtplayers.Size = New System.Drawing.Size(146, 20)
        Me.txtplayers.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label9.Location = New System.Drawing.Point(6, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Nombre de Fois Joué :"
        '
        'TxtPlayCount
        '
        Me.TxtPlayCount.Location = New System.Drawing.Point(6, 228)
        Me.TxtPlayCount.Name = "TxtPlayCount"
        Me.TxtPlayCount.Size = New System.Drawing.Size(146, 20)
        Me.TxtPlayCount.TabIndex = 36
        '
        'txtpub
        '
        Me.txtpub.Location = New System.Drawing.Point(6, 111)
        Me.txtpub.Name = "txtpub"
        Me.txtpub.Size = New System.Drawing.Size(146, 20)
        Me.txtpub.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label3.Location = New System.Drawing.Point(6, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Mot Clé dans Synopsis :"
        '
        'txtdev
        '
        Me.txtdev.Location = New System.Drawing.Point(6, 72)
        Me.txtdev.Name = "txtdev"
        Me.txtdev.Size = New System.Drawing.Size(146, 20)
        Me.txtdev.TabIndex = 40
        '
        'txtgenre
        '
        Me.txtgenre.Location = New System.Drawing.Point(6, 33)
        Me.txtgenre.Name = "txtgenre"
        Me.txtgenre.Size = New System.Drawing.Size(146, 20)
        Me.txtgenre.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label4.Location = New System.Drawing.Point(6, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Note :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Genre :"
        '
        'TxtAnnee
        '
        Me.TxtAnnee.Location = New System.Drawing.Point(6, 150)
        Me.TxtAnnee.Name = "TxtAnnee"
        Me.TxtAnnee.Size = New System.Drawing.Size(146, 20)
        Me.TxtAnnee.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label7.Location = New System.Drawing.Point(6, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Nombre de Joueurs :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label5.Location = New System.Drawing.Point(6, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Developer :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label8.Location = New System.Drawing.Point(6, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Annee de Sortie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label6.Location = New System.Drawing.Point(6, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Publisher :"
        '
        'ListTitreDesJeux
        '
        Me.ListTitreDesJeux.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListTitreDesJeux.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTitreDesJeux.FormattingEnabled = True
        Me.ListTitreDesJeux.Location = New System.Drawing.Point(116, 2)
        Me.ListTitreDesJeux.Name = "ListTitreDesJeux"
        Me.ListTitreDesJeux.Size = New System.Drawing.Size(286, 173)
        Me.ListTitreDesJeux.TabIndex = 23
        '
        'ListConsoleDesJeux
        '
        Me.ListConsoleDesJeux.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListConsoleDesJeux.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListConsoleDesJeux.FormattingEnabled = True
        Me.ListConsoleDesJeux.Location = New System.Drawing.Point(3, 3)
        Me.ListConsoleDesJeux.Name = "ListConsoleDesJeux"
        Me.ListConsoleDesJeux.Size = New System.Drawing.Size(107, 173)
        Me.ListConsoleDesJeux.TabIndex = 24
        '
        'Timer1
        '
        '
        'ButtonGetBack1
        '
        Me.ButtonGetBack1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonGetBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonGetBack1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonGetBack1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonGetBack1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonGetBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGetBack1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGetBack1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGetBack1.Location = New System.Drawing.Point(12, 10)
        Me.ButtonGetBack1.Name = "ButtonGetBack1"
        Me.ButtonGetBack1.Size = New System.Drawing.Size(94, 23)
        Me.ButtonGetBack1.TabIndex = 41
        Me.ButtonGetBack1.Text = "Retour Au Menu"
        Me.ButtonGetBack1.UseVisualStyleBackColor = False
        '
        'TitleBox
        '
        Me.TitleBox.BackColor = System.Drawing.Color.MidnightBlue
        Me.TitleBox.Controls.Add(Me.PlayerAudio)
        Me.TitleBox.Controls.Add(Me.listrandobox)
        Me.TitleBox.Controls.Add(Me.Label15)
        Me.TitleBox.Controls.Add(Me.TimeBox)
        Me.TitleBox.Controls.Add(Me.PlayerNext)
        Me.TitleBox.Controls.Add(Me.RandomList)
        Me.TitleBox.Controls.Add(Me.txtpositionend)
        Me.TitleBox.Controls.Add(Me.ProgressBar1)
        Me.TitleBox.Controls.Add(Me.PlayerPrev)
        Me.TitleBox.Controls.Add(Me.PlayerStop)
        Me.TitleBox.Controls.Add(Me.Label12)
        Me.TitleBox.Controls.Add(Me.PlayerPlay)
        Me.TitleBox.Controls.Add(Me.txtpositionrandom)
        Me.TitleBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TitleBox.Location = New System.Drawing.Point(489, 100)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(416, 295)
        Me.TitleBox.TabIndex = 50
        Me.TitleBox.TabStop = False
        Me.TitleBox.Text = "VideoPlayerBox"
        '
        'PlayerAudio
        '
        Me.PlayerAudio.Enabled = True
        Me.PlayerAudio.Location = New System.Drawing.Point(111, 68)
        Me.PlayerAudio.Name = "PlayerAudio"
        Me.PlayerAudio.OcxState = CType(resources.GetObject("PlayerAudio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PlayerAudio.Size = New System.Drawing.Size(300, 181)
        Me.PlayerAudio.TabIndex = 33
        '
        'listrandobox
        '
        Me.listrandobox.BackColor = System.Drawing.SystemColors.Info
        Me.listrandobox.FormattingEnabled = True
        Me.listrandobox.Location = New System.Drawing.Point(7, 147)
        Me.listrandobox.Name = "listrandobox"
        Me.listrandobox.Size = New System.Drawing.Size(98, 30)
        Me.listrandobox.TabIndex = 41
        Me.listrandobox.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(190, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 22)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Titre n°"
        '
        'TimeBox
        '
        Me.TimeBox.BackColor = System.Drawing.Color.RoyalBlue
        Me.TimeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBox.ForeColor = System.Drawing.SystemColors.Window
        Me.TimeBox.Location = New System.Drawing.Point(7, 245)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.ReadOnly = True
        Me.TimeBox.Size = New System.Drawing.Size(99, 45)
        Me.TimeBox.TabIndex = 40
        Me.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlayerNext
        '
        Me.PlayerNext.BackColor = System.Drawing.Color.Transparent
        Me.PlayerNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.PlayerNext.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerNext.Image = CType(resources.GetObject("PlayerNext.Image"), System.Drawing.Image)
        Me.PlayerNext.Location = New System.Drawing.Point(57, 24)
        Me.PlayerNext.Name = "PlayerNext"
        Me.PlayerNext.Size = New System.Drawing.Size(50, 50)
        Me.PlayerNext.TabIndex = 28
        Me.PlayerNext.UseVisualStyleBackColor = False
        '
        'RandomList
        '
        Me.RandomList.BackColor = System.Drawing.Color.DimGray
        Me.RandomList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RandomList.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.RandomList.FormattingEnabled = True
        Me.RandomList.Location = New System.Drawing.Point(6, 77)
        Me.RandomList.Name = "RandomList"
        Me.RandomList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RandomList.Size = New System.Drawing.Size(99, 108)
        Me.RandomList.TabIndex = 34
        '
        'txtpositionend
        '
        Me.txtpositionend.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtpositionend.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpositionend.ForeColor = System.Drawing.Color.White
        Me.txtpositionend.Location = New System.Drawing.Point(277, 33)
        Me.txtpositionend.Name = "txtpositionend"
        Me.txtpositionend.ReadOnly = True
        Me.txtpositionend.Size = New System.Drawing.Size(72, 31)
        Me.txtpositionend.TabIndex = 37
        Me.txtpositionend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(111, 258)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(300, 27)
        Me.ProgressBar1.TabIndex = 27
        '
        'PlayerPrev
        '
        Me.PlayerPrev.BackColor = System.Drawing.Color.Transparent
        Me.PlayerPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.PlayerPrev.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerPrev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPrev.Image = CType(resources.GetObject("PlayerPrev.Image"), System.Drawing.Image)
        Me.PlayerPrev.Location = New System.Drawing.Point(6, 24)
        Me.PlayerPrev.Name = "PlayerPrev"
        Me.PlayerPrev.Size = New System.Drawing.Size(50, 50)
        Me.PlayerPrev.TabIndex = 38
        Me.PlayerPrev.UseVisualStyleBackColor = False
        '
        'PlayerStop
        '
        Me.PlayerStop.BackColor = System.Drawing.Color.GhostWhite
        Me.PlayerStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.PlayerStop.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerStop.Image = CType(resources.GetObject("PlayerStop.Image"), System.Drawing.Image)
        Me.PlayerStop.Location = New System.Drawing.Point(57, 191)
        Me.PlayerStop.Name = "PlayerStop"
        Me.PlayerStop.Size = New System.Drawing.Size(50, 50)
        Me.PlayerStop.TabIndex = 34
        Me.PlayerStop.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(297, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 22)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "sur"
        '
        'PlayerPlay
        '
        Me.PlayerPlay.BackColor = System.Drawing.Color.Transparent
        Me.PlayerPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlayerPlay.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPlay.Image = CType(resources.GetObject("PlayerPlay.Image"), System.Drawing.Image)
        Me.PlayerPlay.Location = New System.Drawing.Point(7, 191)
        Me.PlayerPlay.Name = "PlayerPlay"
        Me.PlayerPlay.Size = New System.Drawing.Size(50, 50)
        Me.PlayerPlay.TabIndex = 33
        Me.PlayerPlay.UseVisualStyleBackColor = False
        '
        'txtpositionrandom
        '
        Me.txtpositionrandom.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtpositionrandom.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpositionrandom.ForeColor = System.Drawing.Color.White
        Me.txtpositionrandom.Location = New System.Drawing.Point(184, 33)
        Me.txtpositionrandom.Name = "txtpositionrandom"
        Me.txtpositionrandom.ReadOnly = True
        Me.txtpositionrandom.Size = New System.Drawing.Size(72, 31)
        Me.txtpositionrandom.TabIndex = 35
        Me.txtpositionrandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupDifficulty
        '
        Me.GroupDifficulty.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.GroupDifficulty.Controls.Add(Me.VidSans)
        Me.GroupDifficulty.Controls.Add(Me.ValidQuizz)
        Me.GroupDifficulty.Controls.Add(Me.PlayerOnce)
        Me.GroupDifficulty.Controls.Add(Me.PlayerRepeat)
        Me.GroupDifficulty.Controls.Add(Me.Label19)
        Me.GroupDifficulty.Controls.Add(Me.SonSans)
        Me.GroupDifficulty.Controls.Add(Me.Label18)
        Me.GroupDifficulty.Controls.Add(Me.VidPixel)
        Me.GroupDifficulty.Controls.Add(Me.Label13)
        Me.GroupDifficulty.Controls.Add(Me.VidNormal)
        Me.GroupDifficulty.Controls.Add(Me.SonAvec)
        Me.GroupDifficulty.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupDifficulty.Location = New System.Drawing.Point(489, 3)
        Me.GroupDifficulty.Name = "GroupDifficulty"
        Me.GroupDifficulty.Size = New System.Drawing.Size(416, 91)
        Me.GroupDifficulty.TabIndex = 49
        Me.GroupDifficulty.TabStop = False
        Me.GroupDifficulty.Text = "Mode/Difficulté du Quiz"
        '
        'ValidQuizz
        '
        Me.ValidQuizz.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ValidQuizz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ValidQuizz.Cursor = System.Windows.Forms.Cursors.Default
        Me.ValidQuizz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ValidQuizz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet
        Me.ValidQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ValidQuizz.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidQuizz.ForeColor = System.Drawing.Color.White
        Me.ValidQuizz.Location = New System.Drawing.Point(330, 36)
        Me.ValidQuizz.Name = "ValidQuizz"
        Me.ValidQuizz.Size = New System.Drawing.Size(45, 32)
        Me.ValidQuizz.TabIndex = 49
        Me.ValidQuizz.Text = "OK"
        Me.ValidQuizz.UseVisualStyleBackColor = False
        '
        'PlayerOnce
        '
        Me.PlayerOnce.AutoSize = True
        Me.PlayerOnce.Checked = True
        Me.PlayerOnce.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PlayerOnce.ForeColor = System.Drawing.Color.White
        Me.PlayerOnce.Location = New System.Drawing.Point(168, 30)
        Me.PlayerOnce.Name = "PlayerOnce"
        Me.PlayerOnce.Size = New System.Drawing.Size(98, 17)
        Me.PlayerOnce.TabIndex = 43
        Me.PlayerOnce.Text = "Une Seule Fois"
        Me.PlayerOnce.UseVisualStyleBackColor = True
        '
        'PlayerRepeat
        '
        Me.PlayerRepeat.AutoSize = True
        Me.PlayerRepeat.ForeColor = System.Drawing.Color.White
        Me.PlayerRepeat.Location = New System.Drawing.Point(168, 64)
        Me.PlayerRepeat.Name = "PlayerRepeat"
        Me.PlayerRepeat.Size = New System.Drawing.Size(98, 17)
        Me.PlayerRepeat.TabIndex = 42
        Me.PlayerRepeat.Text = "Repeat à la Fin"
        Me.PlayerRepeat.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Aqua
        Me.Label19.Location = New System.Drawing.Point(166, 11)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Option du Player :"
        '
        'SonSans
        '
        Me.SonSans.AutoSize = True
        Me.SonSans.ForeColor = System.Drawing.Color.White
        Me.SonSans.Location = New System.Drawing.Point(86, 64)
        Me.SonSans.Name = "SonSans"
        Me.SonSans.Size = New System.Drawing.Size(72, 17)
        Me.SonSans.TabIndex = 40
        Me.SonSans.Text = "Sans Son"
        Me.SonSans.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Aqua
        Me.Label18.Location = New System.Drawing.Point(83, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Option Audio :"
        '
        'VidPixel
        '
        Me.VidPixel.AutoSize = True
        Me.VidPixel.ForeColor = System.Drawing.Color.White
        Me.VidPixel.Location = New System.Drawing.Point(9, 64)
        Me.VidPixel.Name = "VidPixel"
        Me.VidPixel.Size = New System.Drawing.Size(48, 17)
        Me.VidPixel.TabIndex = 38
        Me.VidPixel.Text = "Pixel"
        Me.VidPixel.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Aqua
        Me.Label13.Location = New System.Drawing.Point(6, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Option Video :"
        '
        'VidNormal
        '
        Me.VidNormal.AutoSize = True
        Me.VidNormal.Checked = True
        Me.VidNormal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VidNormal.ForeColor = System.Drawing.Color.White
        Me.VidNormal.Location = New System.Drawing.Point(9, 30)
        Me.VidNormal.Name = "VidNormal"
        Me.VidNormal.Size = New System.Drawing.Size(65, 17)
        Me.VidNormal.TabIndex = 33
        Me.VidNormal.Text = "Normale"
        Me.VidNormal.UseVisualStyleBackColor = True
        '
        'SonAvec
        '
        Me.SonAvec.AutoSize = True
        Me.SonAvec.Checked = True
        Me.SonAvec.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SonAvec.ForeColor = System.Drawing.Color.White
        Me.SonAvec.Location = New System.Drawing.Point(86, 30)
        Me.SonAvec.Name = "SonAvec"
        Me.SonAvec.Size = New System.Drawing.Size(73, 17)
        Me.SonAvec.TabIndex = 34
        Me.SonAvec.Text = "Avec Son"
        Me.SonAvec.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(489, 397)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(416, 201)
        Me.TabControl1.TabIndex = 51
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Cornsilk
        Me.TabPage1.Controls.Add(Me.ListTitreDesJeux)
        Me.TabPage1.Controls.Add(Me.ListConsoleDesJeux)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(408, 175)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Propositions"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Cornsilk
        Me.TabPage2.Controls.Add(Me.ExportTxt)
        Me.TabPage2.Controls.Add(Me.Historique)
        Me.TabPage2.Controls.Add(Me.TempGrid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(408, 175)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historique"
        '
        'Historique
        '
        Me.Historique.Enabled = False
        Me.Historique.FormattingEnabled = True
        Me.Historique.Location = New System.Drawing.Point(159, 9)
        Me.Historique.Name = "Historique"
        Me.Historique.Size = New System.Drawing.Size(246, 121)
        Me.Historique.TabIndex = 12
        '
        'TempGrid
        '
        Me.TempGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TempGrid.Location = New System.Drawing.Point(6, 9)
        Me.TempGrid.Name = "TempGrid"
        Me.TempGrid.RowHeadersWidth = 51
        Me.TempGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TempGrid.Size = New System.Drawing.Size(147, 151)
        Me.TempGrid.TabIndex = 11
        '
        'VidSans
        '
        Me.VidSans.AutoSize = True
        Me.VidSans.ForeColor = System.Drawing.Color.White
        Me.VidSans.Location = New System.Drawing.Point(9, 48)
        Me.VidSans.Name = "VidSans"
        Me.VidSans.Size = New System.Drawing.Size(80, 17)
        Me.VidSans.TabIndex = 50
        Me.VidSans.Text = "Sans Video"
        Me.VidSans.UseVisualStyleBackColor = True
        '
        'ExportTxt
        '
        Me.ExportTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ExportTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExportTxt.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExportTxt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ExportTxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ExportTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportTxt.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportTxt.ForeColor = System.Drawing.Color.White
        Me.ExportTxt.Location = New System.Drawing.Point(200, 136)
        Me.ExportTxt.Name = "ExportTxt"
        Me.ExportTxt.Size = New System.Drawing.Size(157, 28)
        Me.ExportTxt.TabIndex = 46
        Me.ExportTxt.Text = "Exporter l'historique en .txt"
        Me.ExportTxt.UseVisualStyleBackColor = False
        '
        'Quizz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(908, 601)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupDifficulty)
        Me.Controls.Add(Me.TitleBox)
        Me.Controls.Add(Me.ButtonGetBack1)
        Me.Controls.Add(Me.GroupParamComplet)
        Me.MaximumSize = New System.Drawing.Size(924, 640)
        Me.MinimumSize = New System.Drawing.Size(924, 640)
        Me.Name = "Quizz"
        Me.Text = "Quizz"
        Me.GroupParamComplet.ResumeLayout(False)
        Me.GroupParamComplet.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupConfigPartie.ResumeLayout(False)
        Me.GroupConfigPartie.PerformLayout()
        Me.GroupFiltres.ResumeLayout(False)
        Me.GroupFiltres.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TitleBox.ResumeLayout(False)
        Me.TitleBox.PerformLayout()
        CType(Me.PlayerAudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupDifficulty.ResumeLayout(False)
        Me.GroupDifficulty.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupParamComplet As GroupBox
    Friend WithEvents ConsoleList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupConfigPartie As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtnbmanches As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupFiltres As GroupBox
    Friend WithEvents TxtTotalEntrees As TextBox
    Friend WithEvents ConsoleTitre As RadioButton
    Friend WithEvents TitreOnly As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txttempsaffichprop As TextBox
    Friend WithEvents ButtonGetBack1 As Button
    Friend WithEvents ButtonValidConsole1 As Button
    Friend WithEvents ButtonDoRandom1 As Button
    Friend WithEvents TxtRating As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listhelpingboxPlayCount As ListBox
    Friend WithEvents listhelpingboxAnnee As ListBox
    Friend WithEvents listhelpingboxGenre As ListBox
    Friend WithEvents listhelpingboxNote As ListBox
    Friend WithEvents listhelpingboxPubl As ListBox
    Friend WithEvents listhelpingboxPlayers As ListBox
    Friend WithEvents listhelpingboxDev As ListBox
    Friend WithEvents TxtSynopsis As TextBox
    Friend WithEvents txtplayers As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtPlayCount As TextBox
    Friend WithEvents txtpub As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdev As TextBox
    Friend WithEvents txtgenre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAnnee As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ListTitreDesJeux As ListBox
    Friend WithEvents ListConsoleDesJeux As ListBox
    Friend WithEvents ToolTipNbJeux As ToolTip
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ButtonInfo As Button
    Friend WithEvents PasTitreNiConsole As RadioButton
    Friend WithEvents TitleBox As GroupBox
    Friend WithEvents PlayerAudio As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents listrandobox As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TimeBox As TextBox
    Friend WithEvents PlayerNext As Button
    Friend WithEvents RandomList As ListBox
    Friend WithEvents txtpositionend As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PlayerPrev As Button
    Friend WithEvents PlayerStop As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PlayerPlay As Button
    Friend WithEvents txtpositionrandom As TextBox
    Friend WithEvents GroupDifficulty As GroupBox
    Friend WithEvents PlayerOnce As CheckBox
    Friend WithEvents PlayerRepeat As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents SonSans As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents VidPixel As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents VidNormal As CheckBox
    Friend WithEvents SonAvec As CheckBox
    Friend WithEvents ValidQuizz As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Historique As ListBox
    Friend WithEvents TempGrid As DataGridView
    Friend WithEvents VidSans As CheckBox
    Friend WithEvents ExportTxt As Button
End Class
