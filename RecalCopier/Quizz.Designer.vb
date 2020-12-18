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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonDoRandom1 = New System.Windows.Forms.Button()
        Me.CheckAvecFiltres = New System.Windows.Forms.CheckBox()
        Me.GroupConfigPartie = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txttempsaffichprop = New System.Windows.Forms.TextBox()
        Me.ModeHardcore = New System.Windows.Forms.CheckBox()
        Me.ModeEasy = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ConsoleTitre = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TitreOnly = New System.Windows.Forms.RadioButton()
        Me.txtnbmanches = New System.Windows.Forms.TextBox()
        Me.CheckSansFiltres = New System.Windows.Forms.CheckBox()
        Me.ButtonValidConsole1 = New System.Windows.Forms.Button()
        Me.TxtTotalEntrees = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ConsoleList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupSansFiltres = New System.Windows.Forms.GroupBox()
        Me.ButtonInfo = New System.Windows.Forms.Button()
        Me.TxtExplicationFiltres = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtRules = New System.Windows.Forms.TextBox()
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
        Me.listrandobox = New System.Windows.Forms.ListBox()
        Me.TempGrid = New System.Windows.Forms.DataGridView()
        Me.TitleBox = New System.Windows.Forms.PictureBox()
        Me.QuizzBoxRep = New System.Windows.Forms.GroupBox()
        Me.ListTitreDesJeux = New System.Windows.Forms.ListBox()
        Me.ListConsoleDesJeux = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtpositionend = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtpositionrandom = New System.Windows.Forms.TextBox()
        Me.RandomList = New System.Windows.Forms.ListBox()
        Me.PlayerAudio = New AxWMPLib.AxWindowsMediaPlayer()
        Me.HiddenButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonGetBack1 = New System.Windows.Forms.Button()
        Me.PlayerNext = New System.Windows.Forms.Button()
        Me.PlayerPlay = New System.Windows.Forms.Button()
        Me.PlayerStop = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PlayerPrev = New System.Windows.Forms.Button()
        Me.TimeBox = New System.Windows.Forms.TextBox()
        Me.PanelVideo = New System.Windows.Forms.Panel()
        Me.Cheat = New System.Windows.Forms.CheckBox()
        Me.ToolTipNbJeux = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupParamComplet.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupConfigPartie.SuspendLayout()
        Me.GroupSansFiltres.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFiltres.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QuizzBoxRep.SuspendLayout()
        CType(Me.PlayerAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HiddenButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVideo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupParamComplet
        '
        Me.GroupParamComplet.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.GroupParamComplet.Controls.Add(Me.PictureBox2)
        Me.GroupParamComplet.Controls.Add(Me.ButtonDoRandom1)
        Me.GroupParamComplet.Controls.Add(Me.CheckAvecFiltres)
        Me.GroupParamComplet.Controls.Add(Me.GroupConfigPartie)
        Me.GroupParamComplet.Controls.Add(Me.CheckSansFiltres)
        Me.GroupParamComplet.Controls.Add(Me.ButtonValidConsole1)
        Me.GroupParamComplet.Controls.Add(Me.TxtTotalEntrees)
        Me.GroupParamComplet.Controls.Add(Me.Label10)
        Me.GroupParamComplet.Controls.Add(Me.ConsoleList)
        Me.GroupParamComplet.Controls.Add(Me.Label1)
        Me.GroupParamComplet.Controls.Add(Me.GroupSansFiltres)
        Me.GroupParamComplet.Controls.Add(Me.GroupFiltres)
        Me.GroupParamComplet.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupParamComplet.Location = New System.Drawing.Point(16, 48)
        Me.GroupParamComplet.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupParamComplet.Name = "GroupParamComplet"
        Me.GroupParamComplet.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupParamComplet.Size = New System.Drawing.Size(632, 677)
        Me.GroupParamComplet.TabIndex = 10
        Me.GroupParamComplet.TabStop = False
        Me.GroupParamComplet.Text = "Parametres :"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(172, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'ButtonDoRandom1
        '
        Me.ButtonDoRandom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ButtonDoRandom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonDoRandom1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonDoRandom1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonDoRandom1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ButtonDoRandom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDoRandom1.Font = New System.Drawing.Font("Equinox Com", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDoRandom1.ForeColor = System.Drawing.Color.White
        Me.ButtonDoRandom1.Location = New System.Drawing.Point(380, 43)
        Me.ButtonDoRandom1.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDoRandom1.Name = "ButtonDoRandom1"
        Me.ButtonDoRandom1.Size = New System.Drawing.Size(244, 55)
        Me.ButtonDoRandom1.TabIndex = 45
        Me.ButtonDoRandom1.Text = "Générer Nouveau Jeu"
        Me.ButtonDoRandom1.UseVisualStyleBackColor = False
        '
        'CheckAvecFiltres
        '
        Me.CheckAvecFiltres.AutoSize = True
        Me.CheckAvecFiltres.Location = New System.Drawing.Point(444, 15)
        Me.CheckAvecFiltres.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckAvecFiltres.Name = "CheckAvecFiltres"
        Me.CheckAvecFiltres.Size = New System.Drawing.Size(103, 21)
        Me.CheckAvecFiltres.TabIndex = 44
        Me.CheckAvecFiltres.Text = "Avec Filtres"
        Me.CheckAvecFiltres.UseVisualStyleBackColor = True
        '
        'GroupConfigPartie
        '
        Me.GroupConfigPartie.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(200, Byte), Integer))
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
        Me.GroupConfigPartie.Location = New System.Drawing.Point(196, 106)
        Me.GroupConfigPartie.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupConfigPartie.Name = "GroupConfigPartie"
        Me.GroupConfigPartie.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupConfigPartie.Size = New System.Drawing.Size(428, 126)
        Me.GroupConfigPartie.TabIndex = 27
        Me.GroupConfigPartie.TabStop = False
        Me.GroupConfigPartie.Text = "Config Partie :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Aqua
        Me.Label16.Location = New System.Drawing.Point(191, 38)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 17)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "_ sec avant Proposition :"
        '
        'txttempsaffichprop
        '
        Me.txttempsaffichprop.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txttempsaffichprop.ForeColor = System.Drawing.SystemColors.Window
        Me.txttempsaffichprop.Location = New System.Drawing.Point(356, 34)
        Me.txttempsaffichprop.Margin = New System.Windows.Forms.Padding(4)
        Me.txttempsaffichprop.Name = "txttempsaffichprop"
        Me.txttempsaffichprop.Size = New System.Drawing.Size(63, 22)
        Me.txttempsaffichprop.TabIndex = 35
        Me.txttempsaffichprop.Text = "15"
        Me.txttempsaffichprop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ModeHardcore
        '
        Me.ModeHardcore.AutoSize = True
        Me.ModeHardcore.Checked = True
        Me.ModeHardcore.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ModeHardcore.ForeColor = System.Drawing.Color.White
        Me.ModeHardcore.Location = New System.Drawing.Point(223, 95)
        Me.ModeHardcore.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeHardcore.Name = "ModeHardcore"
        Me.ModeHardcore.Size = New System.Drawing.Size(200, 21)
        Me.ModeHardcore.TabIndex = 34
        Me.ModeHardcore.Text = "Mode Hardcore (Son Only)"
        Me.ModeHardcore.UseVisualStyleBackColor = True
        '
        'ModeEasy
        '
        Me.ModeEasy.AutoSize = True
        Me.ModeEasy.ForeColor = System.Drawing.Color.White
        Me.ModeEasy.Location = New System.Drawing.Point(12, 95)
        Me.ModeEasy.Margin = New System.Windows.Forms.Padding(4)
        Me.ModeEasy.Name = "ModeEasy"
        Me.ModeEasy.Size = New System.Drawing.Size(185, 21)
        Me.ModeEasy.TabIndex = 33
        Me.ModeEasy.Text = "Mode Easy (Avec Video)"
        Me.ModeEasy.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Lime
        Me.Label14.Location = New System.Drawing.Point(32, 14)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 17)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Type de Jeu :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(32, 75)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 17)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Difficulté :"
        '
        'ConsoleTitre
        '
        Me.ConsoleTitre.AutoSize = True
        Me.ConsoleTitre.ForeColor = System.Drawing.Color.White
        Me.ConsoleTitre.Location = New System.Drawing.Point(12, 50)
        Me.ConsoleTitre.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsoleTitre.Name = "ConsoleTitre"
        Me.ConsoleTitre.Size = New System.Drawing.Size(125, 21)
        Me.ConsoleTitre.TabIndex = 26
        Me.ConsoleTitre.TabStop = True
        Me.ConsoleTitre.Text = "Console + Titre"
        Me.ConsoleTitre.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Aqua
        Me.Label11.Location = New System.Drawing.Point(215, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Générer _ manches :"
        '
        'TitreOnly
        '
        Me.TitreOnly.AutoSize = True
        Me.TitreOnly.ForeColor = System.Drawing.Color.White
        Me.TitreOnly.Location = New System.Drawing.Point(12, 30)
        Me.TitreOnly.Margin = New System.Windows.Forms.Padding(4)
        Me.TitreOnly.Name = "TitreOnly"
        Me.TitreOnly.Size = New System.Drawing.Size(126, 21)
        Me.TitreOnly.TabIndex = 25
        Me.TitreOnly.TabStop = True
        Me.TitreOnly.Text = "Deviner le Titre"
        Me.TitreOnly.UseVisualStyleBackColor = True
        '
        'txtnbmanches
        '
        Me.txtnbmanches.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txtnbmanches.ForeColor = System.Drawing.SystemColors.Window
        Me.txtnbmanches.Location = New System.Drawing.Point(356, 10)
        Me.txtnbmanches.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnbmanches.Name = "txtnbmanches"
        Me.txtnbmanches.Size = New System.Drawing.Size(63, 22)
        Me.txtnbmanches.TabIndex = 25
        Me.txtnbmanches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckSansFiltres
        '
        Me.CheckSansFiltres.AutoSize = True
        Me.CheckSansFiltres.Location = New System.Drawing.Point(288, 15)
        Me.CheckSansFiltres.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckSansFiltres.Name = "CheckSansFiltres"
        Me.CheckSansFiltres.Size = New System.Drawing.Size(104, 21)
        Me.CheckSansFiltres.TabIndex = 43
        Me.CheckSansFiltres.Text = "Sans Filtres"
        Me.CheckSansFiltres.UseVisualStyleBackColor = True
        '
        'ButtonValidConsole1
        '
        Me.ButtonValidConsole1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ButtonValidConsole1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonValidConsole1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonValidConsole1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonValidConsole1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ButtonValidConsole1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonValidConsole1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonValidConsole1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonValidConsole1.Location = New System.Drawing.Point(8, 603)
        Me.ButtonValidConsole1.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonValidConsole1.Name = "ButtonValidConsole1"
        Me.ButtonValidConsole1.Size = New System.Drawing.Size(180, 68)
        Me.ButtonValidConsole1.TabIndex = 42
        Me.ButtonValidConsole1.Text = "Valider la Selection"
        Me.ButtonValidConsole1.UseVisualStyleBackColor = False
        '
        'TxtTotalEntrees
        '
        Me.TxtTotalEntrees.BackColor = System.Drawing.Color.DarkViolet
        Me.TxtTotalEntrees.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalEntrees.ForeColor = System.Drawing.Color.Yellow
        Me.TxtTotalEntrees.Location = New System.Drawing.Point(196, 60)
        Me.TxtTotalEntrees.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalEntrees.Name = "TxtTotalEntrees"
        Me.TxtTotalEntrees.ReadOnly = True
        Me.TxtTotalEntrees.Size = New System.Drawing.Size(159, 37)
        Me.TxtTotalEntrees.TabIndex = 23
        Me.TxtTotalEntrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(199, 39)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "__ Jeux dans la liste filtrée" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ConsoleList
        '
        Me.ConsoleList.BackColor = System.Drawing.Color.White
        Me.ConsoleList.ForeColor = System.Drawing.Color.Crimson
        Me.ConsoleList.FormattingEnabled = True
        Me.ConsoleList.ItemHeight = 16
        Me.ConsoleList.Location = New System.Drawing.Point(8, 155)
        Me.ConsoleList.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsoleList.Name = "ConsoleList"
        Me.ConsoleList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ConsoleList.Size = New System.Drawing.Size(179, 436)
        Me.ConsoleList.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selection des Consoles :"
        '
        'GroupSansFiltres
        '
        Me.GroupSansFiltres.BackColor = System.Drawing.Color.MistyRose
        Me.GroupSansFiltres.Controls.Add(Me.ButtonInfo)
        Me.GroupSansFiltres.Controls.Add(Me.TxtExplicationFiltres)
        Me.GroupSansFiltres.Controls.Add(Me.PictureBox1)
        Me.GroupSansFiltres.Controls.Add(Me.txtRules)
        Me.GroupSansFiltres.Location = New System.Drawing.Point(196, 249)
        Me.GroupSansFiltres.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupSansFiltres.Name = "GroupSansFiltres"
        Me.GroupSansFiltres.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupSansFiltres.Size = New System.Drawing.Size(427, 422)
        Me.GroupSansFiltres.TabIndex = 46
        Me.GroupSansFiltres.TabStop = False
        Me.GroupSansFiltres.Text = "Mode Sans Filtres : Instructions"
        '
        'ButtonInfo
        '
        Me.ButtonInfo.BackColor = System.Drawing.Color.BlueViolet
        Me.ButtonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite
        Me.ButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInfo.Font = New System.Drawing.Font("Equinox Com", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInfo.ForeColor = System.Drawing.Color.White
        Me.ButtonInfo.Image = CType(resources.GetObject("ButtonInfo.Image"), System.Drawing.Image)
        Me.ButtonInfo.Location = New System.Drawing.Point(364, 8)
        Me.ButtonInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonInfo.Name = "ButtonInfo"
        Me.ButtonInfo.Size = New System.Drawing.Size(56, 55)
        Me.ButtonInfo.TabIndex = 47
        Me.ButtonInfo.UseVisualStyleBackColor = False
        '
        'TxtExplicationFiltres
        '
        Me.TxtExplicationFiltres.Location = New System.Drawing.Point(6, 63)
        Me.TxtExplicationFiltres.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtExplicationFiltres.Multiline = True
        Me.TxtExplicationFiltres.Name = "TxtExplicationFiltres"
        Me.TxtExplicationFiltres.ReadOnly = True
        Me.TxtExplicationFiltres.Size = New System.Drawing.Size(413, 215)
        Me.TxtExplicationFiltres.TabIndex = 0
        Me.TxtExplicationFiltres.Text = resources.GetString("TxtExplicationFiltres.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(243, 268)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txtRules
        '
        Me.txtRules.BackColor = System.Drawing.Color.White
        Me.txtRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRules.ForeColor = System.Drawing.Color.Blue
        Me.txtRules.Location = New System.Drawing.Point(8, 281)
        Me.txtRules.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRules.Multiline = True
        Me.txtRules.Name = "txtRules"
        Me.txtRules.ReadOnly = True
        Me.txtRules.Size = New System.Drawing.Size(225, 131)
        Me.txtRules.TabIndex = 40
        Me.txtRules.Text = "*1ère Phase :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Concentrez-vous," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Souvenez-vous et Reflechissez !" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*2ème Phase :" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Des propositions apparaissent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Validez votre choix !"
        '
        'GroupFiltres
        '
        Me.GroupFiltres.BackColor = System.Drawing.Color.MistyRose
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
        Me.GroupFiltres.Location = New System.Drawing.Point(196, 249)
        Me.GroupFiltres.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupFiltres.Name = "GroupFiltres"
        Me.GroupFiltres.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupFiltres.Size = New System.Drawing.Size(428, 422)
        Me.GroupFiltres.TabIndex = 29
        Me.GroupFiltres.TabStop = False
        Me.GroupFiltres.Text = "Saisir des Filtres et appuyez sur Entree"
        '
        'TxtRating
        '
        Me.TxtRating.Location = New System.Drawing.Point(8, 379)
        Me.TxtRating.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRating.Name = "TxtRating"
        Me.TxtRating.Size = New System.Drawing.Size(193, 22)
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
        Me.GroupBox1.Location = New System.Drawing.Point(223, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(197, 383)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catégories Trouvées :"
        '
        'listhelpingboxPlayCount
        '
        Me.listhelpingboxPlayCount.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxPlayCount.FormattingEnabled = True
        Me.listhelpingboxPlayCount.ItemHeight = 16
        Me.listhelpingboxPlayCount.Location = New System.Drawing.Point(8, 244)
        Me.listhelpingboxPlayCount.Margin = New System.Windows.Forms.Padding(4)
        Me.listhelpingboxPlayCount.Name = "listhelpingboxPlayCount"
        Me.listhelpingboxPlayCount.Size = New System.Drawing.Size(180, 36)
        Me.listhelpingboxPlayCount.Sorted = True
        Me.listhelpingboxPlayCount.TabIndex = 34
        '
        'listhelpingboxAnnee
        '
        Me.listhelpingboxAnnee.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxAnnee.FormattingEnabled = True
        Me.listhelpingboxAnnee.ItemHeight = 16
        Me.listhelpingboxAnnee.Location = New System.Drawing.Point(8, 153)
        Me.listhelpingboxAnnee.Margin = New System.Windows.Forms.Padding(4)
        Me.listhelpingboxAnnee.Name = "listhelpingboxAnnee"
        Me.listhelpingboxAnnee.Size = New System.Drawing.Size(180, 36)
        Me.listhelpingboxAnnee.Sorted = True
        Me.listhelpingboxAnnee.TabIndex = 33
        '
        'listhelpingboxGenre
        '
        Me.listhelpingboxGenre.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxGenre.FormattingEnabled = True
        Me.listhelpingboxGenre.ItemHeight = 16
        Me.listhelpingboxGenre.Location = New System.Drawing.Point(8, 20)
        Me.listhelpingboxGenre.Margin = New System.Windows.Forms.Padding(4)
        Me.listhelpingboxGenre.Name = "listhelpingboxGenre"
        Me.listhelpingboxGenre.Size = New System.Drawing.Size(180, 36)
        Me.listhelpingboxGenre.Sorted = True
        Me.listhelpingboxGenre.TabIndex = 28
        '
        'listhelpingboxNote
        '
        Me.listhelpingboxNote.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxNote.FormattingEnabled = True
        Me.listhelpingboxNote.ItemHeight = 16
        Me.listhelpingboxNote.Location = New System.Drawing.Point(8, 338)
        Me.listhelpingboxNote.Margin = New System.Windows.Forms.Padding(4)
        Me.listhelpingboxNote.Name = "listhelpingboxNote"
        Me.listhelpingboxNote.Size = New System.Drawing.Size(180, 36)
        Me.listhelpingboxNote.Sorted = True
        Me.listhelpingboxNote.TabIndex = 32
        '
        'listhelpingboxPubl
        '
        Me.listhelpingboxPubl.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxPubl.FormattingEnabled = True
        Me.listhelpingboxPubl.ItemHeight = 16
        Me.listhelpingboxPubl.Location = New System.Drawing.Point(8, 108)
        Me.listhelpingboxPubl.Margin = New System.Windows.Forms.Padding(4)
        Me.listhelpingboxPubl.Name = "listhelpingboxPubl"
        Me.listhelpingboxPubl.Size = New System.Drawing.Size(180, 36)
        Me.listhelpingboxPubl.Sorted = True
        Me.listhelpingboxPubl.TabIndex = 29
        '
        'listhelpingboxPlayers
        '
        Me.listhelpingboxPlayers.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxPlayers.FormattingEnabled = True
        Me.listhelpingboxPlayers.ItemHeight = 16
        Me.listhelpingboxPlayers.Location = New System.Drawing.Point(8, 199)
        Me.listhelpingboxPlayers.Margin = New System.Windows.Forms.Padding(4)
        Me.listhelpingboxPlayers.Name = "listhelpingboxPlayers"
        Me.listhelpingboxPlayers.Size = New System.Drawing.Size(180, 36)
        Me.listhelpingboxPlayers.Sorted = True
        Me.listhelpingboxPlayers.TabIndex = 31
        '
        'listhelpingboxDev
        '
        Me.listhelpingboxDev.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.listhelpingboxDev.FormattingEnabled = True
        Me.listhelpingboxDev.ItemHeight = 16
        Me.listhelpingboxDev.Location = New System.Drawing.Point(8, 64)
        Me.listhelpingboxDev.Margin = New System.Windows.Forms.Padding(4)
        Me.listhelpingboxDev.Name = "listhelpingboxDev"
        Me.listhelpingboxDev.Size = New System.Drawing.Size(180, 36)
        Me.listhelpingboxDev.Sorted = True
        Me.listhelpingboxDev.TabIndex = 30
        '
        'TxtSynopsis
        '
        Me.TxtSynopsis.Location = New System.Drawing.Point(8, 329)
        Me.TxtSynopsis.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSynopsis.Name = "TxtSynopsis"
        Me.TxtSynopsis.Size = New System.Drawing.Size(193, 22)
        Me.TxtSynopsis.TabIndex = 38
        '
        'txtplayers
        '
        Me.txtplayers.Location = New System.Drawing.Point(8, 233)
        Me.txtplayers.Margin = New System.Windows.Forms.Padding(4)
        Me.txtplayers.Name = "txtplayers"
        Me.txtplayers.Size = New System.Drawing.Size(193, 22)
        Me.txtplayers.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label9.Location = New System.Drawing.Point(8, 261)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 17)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Nombre de Fois Joué :"
        '
        'TxtPlayCount
        '
        Me.TxtPlayCount.Location = New System.Drawing.Point(8, 281)
        Me.TxtPlayCount.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPlayCount.Name = "TxtPlayCount"
        Me.TxtPlayCount.Size = New System.Drawing.Size(193, 22)
        Me.TxtPlayCount.TabIndex = 36
        '
        'txtpub
        '
        Me.txtpub.Location = New System.Drawing.Point(8, 137)
        Me.txtpub.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpub.Name = "txtpub"
        Me.txtpub.Size = New System.Drawing.Size(193, 22)
        Me.txtpub.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(8, 309)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Mot Clé dans Synopsis :"
        '
        'txtdev
        '
        Me.txtdev.Location = New System.Drawing.Point(8, 89)
        Me.txtdev.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdev.Name = "txtdev"
        Me.txtdev.Size = New System.Drawing.Size(193, 22)
        Me.txtdev.TabIndex = 40
        '
        'txtgenre
        '
        Me.txtgenre.Location = New System.Drawing.Point(8, 41)
        Me.txtgenre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgenre.Name = "txtgenre"
        Me.txtgenre.Size = New System.Drawing.Size(193, 22)
        Me.txtgenre.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(8, 359)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Note :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(8, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Genre :"
        '
        'TxtAnnee
        '
        Me.TxtAnnee.Location = New System.Drawing.Point(8, 185)
        Me.TxtAnnee.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAnnee.Name = "TxtAnnee"
        Me.TxtAnnee.Size = New System.Drawing.Size(193, 22)
        Me.TxtAnnee.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(4, 213)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 17)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Nombre de Joueurs :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(8, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Developer :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label8.Location = New System.Drawing.Point(8, 165)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Annee de Sortie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label6.Location = New System.Drawing.Point(8, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Publisher :"
        '
        'listrandobox
        '
        Me.listrandobox.BackColor = System.Drawing.SystemColors.Info
        Me.listrandobox.FormattingEnabled = True
        Me.listrandobox.ItemHeight = 16
        Me.listrandobox.Location = New System.Drawing.Point(19, 7)
        Me.listrandobox.Margin = New System.Windows.Forms.Padding(4)
        Me.listrandobox.Name = "listrandobox"
        Me.listrandobox.Size = New System.Drawing.Size(115, 36)
        Me.listrandobox.TabIndex = 41
        Me.listrandobox.Visible = False
        '
        'TempGrid
        '
        Me.TempGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TempGrid.Location = New System.Drawing.Point(156, 4)
        Me.TempGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.TempGrid.Name = "TempGrid"
        Me.TempGrid.RowHeadersWidth = 51
        Me.TempGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TempGrid.Size = New System.Drawing.Size(492, 37)
        Me.TempGrid.TabIndex = 11
        '
        'TitleBox
        '
        Me.TitleBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.TitleBox.Image = CType(resources.GetObject("TitleBox.Image"), System.Drawing.Image)
        Me.TitleBox.Location = New System.Drawing.Point(8, -12)
        Me.TitleBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(555, 468)
        Me.TitleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TitleBox.TabIndex = 35
        Me.TitleBox.TabStop = False
        '
        'QuizzBoxRep
        '
        Me.QuizzBoxRep.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.QuizzBoxRep.Controls.Add(Me.ListTitreDesJeux)
        Me.QuizzBoxRep.Controls.Add(Me.ListConsoleDesJeux)
        Me.QuizzBoxRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QuizzBoxRep.Location = New System.Drawing.Point(656, 462)
        Me.QuizzBoxRep.Margin = New System.Windows.Forms.Padding(4)
        Me.QuizzBoxRep.Name = "QuizzBoxRep"
        Me.QuizzBoxRep.Padding = New System.Windows.Forms.Padding(4)
        Me.QuizzBoxRep.Size = New System.Drawing.Size(555, 263)
        Me.QuizzBoxRep.TabIndex = 36
        Me.QuizzBoxRep.TabStop = False
        Me.QuizzBoxRep.Text = "Propositions et Reponses :"
        '
        'ListTitreDesJeux
        '
        Me.ListTitreDesJeux.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListTitreDesJeux.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListTitreDesJeux.FormattingEnabled = True
        Me.ListTitreDesJeux.ItemHeight = 17
        Me.ListTitreDesJeux.Location = New System.Drawing.Point(159, 20)
        Me.ListTitreDesJeux.Margin = New System.Windows.Forms.Padding(4)
        Me.ListTitreDesJeux.Name = "ListTitreDesJeux"
        Me.ListTitreDesJeux.Size = New System.Drawing.Size(380, 225)
        Me.ListTitreDesJeux.TabIndex = 23
        '
        'ListConsoleDesJeux
        '
        Me.ListConsoleDesJeux.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListConsoleDesJeux.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListConsoleDesJeux.FormattingEnabled = True
        Me.ListConsoleDesJeux.ItemHeight = 17
        Me.ListConsoleDesJeux.Location = New System.Drawing.Point(8, 21)
        Me.ListConsoleDesJeux.Margin = New System.Windows.Forms.Padding(4)
        Me.ListConsoleDesJeux.Name = "ListConsoleDesJeux"
        Me.ListConsoleDesJeux.Size = New System.Drawing.Size(141, 225)
        Me.ListConsoleDesJeux.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(257, 18)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 29)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Titre n°"
        '
        'txtpositionend
        '
        Me.txtpositionend.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtpositionend.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpositionend.ForeColor = System.Drawing.Color.White
        Me.txtpositionend.Location = New System.Drawing.Point(373, 49)
        Me.txtpositionend.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpositionend.Name = "txtpositionend"
        Me.txtpositionend.ReadOnly = True
        Me.txtpositionend.Size = New System.Drawing.Size(95, 37)
        Me.txtpositionend.TabIndex = 37
        Me.txtpositionend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(404, 17)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 29)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "sur"
        '
        'txtpositionrandom
        '
        Me.txtpositionrandom.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtpositionrandom.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpositionrandom.ForeColor = System.Drawing.Color.White
        Me.txtpositionrandom.Location = New System.Drawing.Point(249, 49)
        Me.txtpositionrandom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpositionrandom.Name = "txtpositionrandom"
        Me.txtpositionrandom.ReadOnly = True
        Me.txtpositionrandom.Size = New System.Drawing.Size(95, 37)
        Me.txtpositionrandom.TabIndex = 35
        Me.txtpositionrandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomList
        '
        Me.RandomList.BackColor = System.Drawing.Color.DimGray
        Me.RandomList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.RandomList.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.RandomList.FormattingEnabled = True
        Me.RandomList.Location = New System.Drawing.Point(19, 94)
        Me.RandomList.Margin = New System.Windows.Forms.Padding(4)
        Me.RandomList.Name = "RandomList"
        Me.RandomList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RandomList.Size = New System.Drawing.Size(115, 251)
        Me.RandomList.TabIndex = 34
        '
        'PlayerAudio
        '
        Me.PlayerAudio.Enabled = True
        Me.PlayerAudio.Location = New System.Drawing.Point(107, 76)
        Me.PlayerAudio.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerAudio.Name = "PlayerAudio"
        Me.PlayerAudio.OcxState = CType(resources.GetObject("PlayerAudio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PlayerAudio.Size = New System.Drawing.Size(312, 206)
        Me.PlayerAudio.TabIndex = 33
        '
        'HiddenButton
        '
        Me.HiddenButton.Location = New System.Drawing.Point(263, 73)
        Me.HiddenButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HiddenButton.Name = "HiddenButton"
        Me.HiddenButton.Size = New System.Drawing.Size(7, 6)
        Me.HiddenButton.TabIndex = 39
        Me.HiddenButton.TabStop = False
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
        Me.ButtonGetBack1.Location = New System.Drawing.Point(16, 12)
        Me.ButtonGetBack1.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonGetBack1.Name = "ButtonGetBack1"
        Me.ButtonGetBack1.Size = New System.Drawing.Size(125, 28)
        Me.ButtonGetBack1.TabIndex = 41
        Me.ButtonGetBack1.Text = "Retour Au Menu"
        Me.ButtonGetBack1.UseVisualStyleBackColor = False
        '
        'PlayerNext
        '
        Me.PlayerNext.BackColor = System.Drawing.Color.Transparent
        Me.PlayerNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.PlayerNext.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerNext.Image = CType(resources.GetObject("PlayerNext.Image"), System.Drawing.Image)
        Me.PlayerNext.Location = New System.Drawing.Point(492, 351)
        Me.PlayerNext.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerNext.Name = "PlayerNext"
        Me.PlayerNext.Size = New System.Drawing.Size(67, 62)
        Me.PlayerNext.TabIndex = 28
        Me.PlayerNext.UseVisualStyleBackColor = False
        '
        'PlayerPlay
        '
        Me.PlayerPlay.BackColor = System.Drawing.Color.Transparent
        Me.PlayerPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlayerPlay.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPlay.Image = CType(resources.GetObject("PlayerPlay.Image"), System.Drawing.Image)
        Me.PlayerPlay.Location = New System.Drawing.Point(263, 351)
        Me.PlayerPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerPlay.Name = "PlayerPlay"
        Me.PlayerPlay.Size = New System.Drawing.Size(67, 62)
        Me.PlayerPlay.TabIndex = 33
        Me.PlayerPlay.UseVisualStyleBackColor = False
        '
        'PlayerStop
        '
        Me.PlayerStop.BackColor = System.Drawing.Color.GhostWhite
        Me.PlayerStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.PlayerStop.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerStop.Image = CType(resources.GetObject("PlayerStop.Image"), System.Drawing.Image)
        Me.PlayerStop.Location = New System.Drawing.Point(379, 351)
        Me.PlayerStop.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerStop.Name = "PlayerStop"
        Me.PlayerStop.Size = New System.Drawing.Size(67, 62)
        Me.PlayerStop.TabIndex = 34
        Me.PlayerStop.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(19, 417)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(532, 28)
        Me.ProgressBar1.TabIndex = 27
        '
        'PlayerPrev
        '
        Me.PlayerPrev.BackColor = System.Drawing.Color.Transparent
        Me.PlayerPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.PlayerPrev.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerPrev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPrev.Image = CType(resources.GetObject("PlayerPrev.Image"), System.Drawing.Image)
        Me.PlayerPrev.Location = New System.Drawing.Point(143, 351)
        Me.PlayerPrev.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerPrev.Name = "PlayerPrev"
        Me.PlayerPrev.Size = New System.Drawing.Size(67, 62)
        Me.PlayerPrev.TabIndex = 38
        Me.PlayerPrev.UseVisualStyleBackColor = False
        '
        'TimeBox
        '
        Me.TimeBox.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.TimeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeBox.ForeColor = System.Drawing.SystemColors.Window
        Me.TimeBox.Location = New System.Drawing.Point(19, 358)
        Me.TimeBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.ReadOnly = True
        Me.TimeBox.Size = New System.Drawing.Size(115, 54)
        Me.TimeBox.TabIndex = 40
        Me.TimeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelVideo
        '
        Me.PanelVideo.Controls.Add(Me.Cheat)
        Me.PanelVideo.Controls.Add(Me.listrandobox)
        Me.PanelVideo.Controls.Add(Me.TimeBox)
        Me.PanelVideo.Controls.Add(Me.RandomList)
        Me.PanelVideo.Controls.Add(Me.ProgressBar1)
        Me.PanelVideo.Controls.Add(Me.txtpositionrandom)
        Me.PanelVideo.Controls.Add(Me.Label12)
        Me.PanelVideo.Controls.Add(Me.PlayerPrev)
        Me.PanelVideo.Controls.Add(Me.txtpositionend)
        Me.PanelVideo.Controls.Add(Me.Label15)
        Me.PanelVideo.Controls.Add(Me.PlayerAudio)
        Me.PanelVideo.Controls.Add(Me.HiddenButton)
        Me.PanelVideo.Controls.Add(Me.PlayerNext)
        Me.PanelVideo.Controls.Add(Me.PlayerPlay)
        Me.PanelVideo.Controls.Add(Me.PlayerStop)
        Me.PanelVideo.Controls.Add(Me.TitleBox)
        Me.PanelVideo.Location = New System.Drawing.Point(648, 2)
        Me.PanelVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelVideo.Name = "PanelVideo"
        Me.PanelVideo.Size = New System.Drawing.Size(563, 455)
        Me.PanelVideo.TabIndex = 42
        '
        'Cheat
        '
        Me.Cheat.AutoSize = True
        Me.Cheat.Location = New System.Drawing.Point(351, 62)
        Me.Cheat.Margin = New System.Windows.Forms.Padding(4)
        Me.Cheat.Name = "Cheat"
        Me.Cheat.Size = New System.Drawing.Size(18, 17)
        Me.Cheat.TabIndex = 42
        Me.Cheat.UseVisualStyleBackColor = True
        '
        'Quizz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1208, 714)
        Me.Controls.Add(Me.ButtonGetBack1)
        Me.Controls.Add(Me.TempGrid)
        Me.Controls.Add(Me.GroupParamComplet)
        Me.Controls.Add(Me.QuizzBoxRep)
        Me.Controls.Add(Me.PanelVideo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1226, 761)
        Me.MinimumSize = New System.Drawing.Size(1226, 761)
        Me.Name = "Quizz"
        Me.Text = "Quizz"
        Me.GroupParamComplet.ResumeLayout(False)
        Me.GroupParamComplet.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupConfigPartie.ResumeLayout(False)
        Me.GroupConfigPartie.PerformLayout()
        Me.GroupSansFiltres.ResumeLayout(False)
        Me.GroupSansFiltres.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFiltres.ResumeLayout(False)
        Me.GroupFiltres.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QuizzBoxRep.ResumeLayout(False)
        CType(Me.PlayerAudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HiddenButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVideo.ResumeLayout(False)
        Me.PanelVideo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupParamComplet As GroupBox
    Friend WithEvents ConsoleList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupConfigPartie As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtnbmanches As TextBox
    Friend WithEvents TempGrid As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupFiltres As GroupBox
    Friend WithEvents TxtTotalEntrees As TextBox
    Friend WithEvents ConsoleTitre As RadioButton
    Friend WithEvents TitreOnly As RadioButton
    Friend WithEvents TitleBox As PictureBox
    Friend WithEvents QuizzBoxRep As GroupBox
    Friend WithEvents txtpositionend As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtpositionrandom As TextBox
    Friend WithEvents RandomList As ListBox
    Friend WithEvents PlayerAudio As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents HiddenButton As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ModeHardcore As CheckBox
    Friend WithEvents ModeEasy As CheckBox
    Friend WithEvents txtRules As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txttempsaffichprop As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents listrandobox As ListBox
    Friend WithEvents ButtonGetBack1 As Button
    Friend WithEvents ButtonValidConsole1 As Button
    Friend WithEvents CheckAvecFiltres As CheckBox
    Friend WithEvents CheckSansFiltres As CheckBox
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
    Friend WithEvents GroupSansFiltres As GroupBox
    Friend WithEvents TxtExplicationFiltres As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ListTitreDesJeux As ListBox
    Friend WithEvents ListConsoleDesJeux As ListBox
    Friend WithEvents PlayerNext As Button
    Friend WithEvents PlayerPlay As Button
    Friend WithEvents PlayerStop As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PlayerPrev As Button
    Friend WithEvents TimeBox As TextBox
    Friend WithEvents PanelVideo As Panel
    Friend WithEvents Cheat As CheckBox
    Friend WithEvents ToolTipNbJeux As ToolTip
    Friend WithEvents ButtonInfo As Button
End Class
