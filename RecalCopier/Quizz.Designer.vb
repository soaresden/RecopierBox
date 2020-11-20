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
        Me.ComboRating = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.ButtonDoRandom = New System.Windows.Forms.Button()
        Me.GroupConfigPartie = New System.Windows.Forms.GroupBox()
        Me.ConsoleTitre = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TitreOnly = New System.Windows.Forms.RadioButton()
        Me.txtnbmanches = New System.Windows.Forms.TextBox()
        Me.ButtonValidConsole = New System.Windows.Forms.Button()
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
        Me.Buttongetback.Location = New System.Drawing.Point(15, 14)
        Me.Buttongetback.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Buttongetback.Name = "Buttongetback"
        Me.Buttongetback.Size = New System.Drawing.Size(135, 28)
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
        Me.GroupParamComplet.Controls.Add(Me.ConsoleList)
        Me.GroupParamComplet.Controls.Add(Me.Label1)
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
        'TxtTotalEntrees
        '
        Me.TxtTotalEntrees.BackColor = System.Drawing.Color.Tomato
        Me.TxtTotalEntrees.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalEntrees.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtTotalEntrees.Location = New System.Drawing.Point(343, 626)
        Me.TxtTotalEntrees.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalEntrees.Name = "TxtTotalEntrees"
        Me.TxtTotalEntrees.Size = New System.Drawing.Size(155, 37)
        Me.TxtTotalEntrees.TabIndex = 23
        Me.TxtTotalEntrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(301, 607)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(251, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Roms Trouvées aux Critères ci-dessus"
        '
        'GroupParametres
        '
        Me.GroupParametres.BackColor = System.Drawing.Color.Chocolate
        Me.GroupParametres.Controls.Add(Me.GroupInfoRoms)
        Me.GroupParametres.Controls.Add(Me.ButtonDoRandom)
        Me.GroupParametres.Controls.Add(Me.GroupConfigPartie)
        Me.GroupParametres.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupParametres.Location = New System.Drawing.Point(196, 20)
        Me.GroupParametres.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupParametres.Name = "GroupParametres"
        Me.GroupParametres.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupParametres.Size = New System.Drawing.Size(428, 571)
        Me.GroupParametres.TabIndex = 29
        Me.GroupParametres.TabStop = False
        Me.GroupParametres.Text = "Selection des Filtres :"
        '
        'GroupInfoRoms
        '
        Me.GroupInfoRoms.BackColor = System.Drawing.Color.MistyRose
        Me.GroupInfoRoms.Controls.Add(Me.ComboRating)
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
        Me.GroupInfoRoms.Location = New System.Drawing.Point(8, 23)
        Me.GroupInfoRoms.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupInfoRoms.Name = "GroupInfoRoms"
        Me.GroupInfoRoms.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupInfoRoms.Size = New System.Drawing.Size(412, 410)
        Me.GroupInfoRoms.TabIndex = 22
        Me.GroupInfoRoms.TabStop = False
        Me.GroupInfoRoms.Text = "Définir un/plusieurs Filtres sur Votre Selection :"
        '
        'ComboRating
        '
        Me.ComboRating.Location = New System.Drawing.Point(8, 378)
        Me.ComboRating.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboRating.Name = "ComboRating"
        Me.ComboRating.Size = New System.Drawing.Size(160, 22)
        Me.ComboRating.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.listhelpingboxGenre)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxNote)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxPubl)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxPlayers)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxDev)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(207, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(197, 383)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catégories Trouvées :"
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
        Me.listhelpingboxNote.Location = New System.Drawing.Point(8, 308)
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
        Me.listhelpingboxPubl.Location = New System.Drawing.Point(8, 144)
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
        Me.listhelpingboxPlayers.Location = New System.Drawing.Point(8, 219)
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
        Me.listhelpingboxDev.Location = New System.Drawing.Point(8, 75)
        Me.listhelpingboxDev.Margin = New System.Windows.Forms.Padding(4)
        Me.listhelpingboxDev.Name = "listhelpingboxDev"
        Me.listhelpingboxDev.Size = New System.Drawing.Size(180, 36)
        Me.listhelpingboxDev.Sorted = True
        Me.listhelpingboxDev.TabIndex = 30
        '
        'TxtSynopsis
        '
        Me.TxtSynopsis.Location = New System.Drawing.Point(8, 327)
        Me.TxtSynopsis.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSynopsis.Name = "TxtSynopsis"
        Me.TxtSynopsis.Size = New System.Drawing.Size(160, 22)
        Me.TxtSynopsis.TabIndex = 22
        '
        'txtplayers
        '
        Me.txtplayers.Location = New System.Drawing.Point(8, 231)
        Me.txtplayers.Margin = New System.Windows.Forms.Padding(4)
        Me.txtplayers.Name = "txtplayers"
        Me.txtplayers.Size = New System.Drawing.Size(160, 22)
        Me.txtplayers.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 260)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nombre de Fois Joué :"
        '
        'TxtPlayCount
        '
        Me.TxtPlayCount.Location = New System.Drawing.Point(8, 279)
        Me.TxtPlayCount.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPlayCount.Name = "TxtPlayCount"
        Me.TxtPlayCount.Size = New System.Drawing.Size(160, 22)
        Me.TxtPlayCount.TabIndex = 20
        '
        'txtpub
        '
        Me.txtpub.Location = New System.Drawing.Point(8, 135)
        Me.txtpub.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpub.Name = "txtpub"
        Me.txtpub.Size = New System.Drawing.Size(160, 22)
        Me.txtpub.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 308)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mot Clé dans Synopsis :"
        '
        'txtdev
        '
        Me.txtdev.Location = New System.Drawing.Point(8, 87)
        Me.txtdev.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdev.Name = "txtdev"
        Me.txtdev.Size = New System.Drawing.Size(160, 22)
        Me.txtdev.TabIndex = 23
        '
        'txtgenre
        '
        Me.txtgenre.Location = New System.Drawing.Point(8, 39)
        Me.txtgenre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgenre.Name = "txtgenre"
        Me.txtgenre.Size = New System.Drawing.Size(160, 22)
        Me.txtgenre.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 358)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Note :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Genre :"
        '
        'TxtAnnee
        '
        Me.TxtAnnee.Location = New System.Drawing.Point(8, 183)
        Me.TxtAnnee.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAnnee.Name = "TxtAnnee"
        Me.TxtAnnee.Size = New System.Drawing.Size(160, 22)
        Me.TxtAnnee.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 212)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nombre de Joueurs :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Developer :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 164)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Annee de Sortie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 116)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Publisher :"
        '
        'ButtonDoRandom
        '
        Me.ButtonDoRandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonDoRandom.Location = New System.Drawing.Point(125, 519)
        Me.ButtonDoRandom.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDoRandom.Name = "ButtonDoRandom"
        Me.ButtonDoRandom.Size = New System.Drawing.Size(156, 44)
        Me.ButtonDoRandom.TabIndex = 24
        Me.ButtonDoRandom.Text = "Génerer Le Jeu"
        Me.ButtonDoRandom.UseVisualStyleBackColor = True
        '
        'GroupConfigPartie
        '
        Me.GroupConfigPartie.BackColor = System.Drawing.Color.OldLace
        Me.GroupConfigPartie.Controls.Add(Me.ConsoleTitre)
        Me.GroupConfigPartie.Controls.Add(Me.Label11)
        Me.GroupConfigPartie.Controls.Add(Me.TitreOnly)
        Me.GroupConfigPartie.Controls.Add(Me.txtnbmanches)
        Me.GroupConfigPartie.Location = New System.Drawing.Point(8, 441)
        Me.GroupConfigPartie.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupConfigPartie.Name = "GroupConfigPartie"
        Me.GroupConfigPartie.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupConfigPartie.Size = New System.Drawing.Size(412, 71)
        Me.GroupConfigPartie.TabIndex = 27
        Me.GroupConfigPartie.TabStop = False
        Me.GroupConfigPartie.Text = "Config Partie :"
        '
        'ConsoleTitre
        '
        Me.ConsoleTitre.AutoSize = True
        Me.ConsoleTitre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ConsoleTitre.Location = New System.Drawing.Point(256, 43)
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
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(11, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(156, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Combien de Manches ?"
        '
        'TitreOnly
        '
        Me.TitreOnly.AutoSize = True
        Me.TitreOnly.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TitreOnly.Location = New System.Drawing.Point(256, 20)
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
        Me.txtnbmanches.Location = New System.Drawing.Point(12, 39)
        Me.txtnbmanches.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnbmanches.Name = "txtnbmanches"
        Me.txtnbmanches.Size = New System.Drawing.Size(145, 22)
        Me.txtnbmanches.TabIndex = 25
        Me.txtnbmanches.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonValidConsole
        '
        Me.ButtonValidConsole.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonValidConsole.Location = New System.Drawing.Point(8, 594)
        Me.ButtonValidConsole.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonValidConsole.Name = "ButtonValidConsole"
        Me.ButtonValidConsole.Size = New System.Drawing.Size(180, 47)
        Me.ButtonValidConsole.TabIndex = 28
        Me.ButtonValidConsole.Text = "Valider les Systèmes"
        Me.ButtonValidConsole.UseVisualStyleBackColor = True
        '
        'ConsoleList
        '
        Me.ConsoleList.BackColor = System.Drawing.Color.PeachPuff
        Me.ConsoleList.ForeColor = System.Drawing.Color.SaddleBrown
        Me.ConsoleList.FormattingEnabled = True
        Me.ConsoleList.ItemHeight = 16
        Me.ConsoleList.Location = New System.Drawing.Point(8, 43)
        Me.ConsoleList.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsoleList.Name = "ConsoleList"
        Me.ConsoleList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ConsoleList.Size = New System.Drawing.Size(179, 516)
        Me.ConsoleList.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selection des Consoles"
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
        'ListTitreDesJeux
        '
        Me.ListTitreDesJeux.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListTitreDesJeux.FormattingEnabled = True
        Me.ListTitreDesJeux.ItemHeight = 16
        Me.ListTitreDesJeux.Location = New System.Drawing.Point(161, 368)
        Me.ListTitreDesJeux.Margin = New System.Windows.Forms.Padding(4)
        Me.ListTitreDesJeux.Name = "ListTitreDesJeux"
        Me.ListTitreDesJeux.Size = New System.Drawing.Size(380, 228)
        Me.ListTitreDesJeux.TabIndex = 23
        '
        'ListConsoleDesJeux
        '
        Me.ListConsoleDesJeux.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ListConsoleDesJeux.FormattingEnabled = True
        Me.ListConsoleDesJeux.ItemHeight = 16
        Me.ListConsoleDesJeux.Location = New System.Drawing.Point(11, 369)
        Me.ListConsoleDesJeux.Margin = New System.Windows.Forms.Padding(4)
        Me.ListConsoleDesJeux.Name = "ListConsoleDesJeux"
        Me.ListConsoleDesJeux.Size = New System.Drawing.Size(141, 228)
        Me.ListConsoleDesJeux.TabIndex = 24
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 334)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(535, 28)
        Me.ProgressBar1.TabIndex = 27
        '
        'PlayerNext
        '
        Me.PlayerNext.BackColor = System.Drawing.Color.RoyalBlue
        Me.PlayerNext.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerNext.Location = New System.Drawing.Point(473, 276)
        Me.PlayerNext.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerNext.Name = "PlayerNext"
        Me.PlayerNext.Size = New System.Drawing.Size(65, 50)
        Me.PlayerNext.TabIndex = 28
        Me.PlayerNext.Text = ">>"
        Me.PlayerNext.UseVisualStyleBackColor = False
        '
        'PlayerPlay
        '
        Me.PlayerPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlayerPlay.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerPlay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPlay.Location = New System.Drawing.Point(203, 276)
        Me.PlayerPlay.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerPlay.Name = "PlayerPlay"
        Me.PlayerPlay.Size = New System.Drawing.Size(65, 50)
        Me.PlayerPlay.TabIndex = 33
        Me.PlayerPlay.Text = "|>"
        Me.PlayerPlay.UseVisualStyleBackColor = False
        '
        'PlayerStop
        '
        Me.PlayerStop.BackColor = System.Drawing.Color.GhostWhite
        Me.PlayerStop.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerStop.Location = New System.Drawing.Point(333, 276)
        Me.PlayerStop.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerStop.Name = "PlayerStop"
        Me.PlayerStop.Size = New System.Drawing.Size(97, 50)
        Me.PlayerStop.TabIndex = 34
        Me.PlayerStop.Text = "[STOP]"
        Me.PlayerStop.UseVisualStyleBackColor = False
        '
        'TitleBox
        '
        Me.TitleBox.BackColor = System.Drawing.Color.White
        Me.TitleBox.Image = CType(resources.GetObject("TitleBox.Image"), System.Drawing.Image)
        Me.TitleBox.Location = New System.Drawing.Point(656, 4)
        Me.TitleBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(551, 110)
        Me.TitleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TitleBox.TabIndex = 35
        Me.TitleBox.TabStop = False
        '
        'QuizzBox
        '
        Me.QuizzBox.BackColor = System.Drawing.Color.DarkSlateBlue
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
        Me.QuizzBox.Location = New System.Drawing.Point(656, 121)
        Me.QuizzBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuizzBox.Name = "QuizzBox"
        Me.QuizzBox.Padding = New System.Windows.Forms.Padding(4)
        Me.QuizzBox.Size = New System.Drawing.Size(551, 604)
        Me.QuizzBox.TabIndex = 36
        Me.QuizzBox.TabStop = False
        Me.QuizzBox.Text = "QuizzBox"
        '
        'ButtonShowVid
        '
        Me.ButtonShowVid.Image = Global.RecalCopier.My.Resources.Resources.OKvideo
        Me.ButtonShowVid.Location = New System.Drawing.Point(11, 273)
        Me.ButtonShowVid.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonShowVid.Name = "ButtonShowVid"
        Me.ButtonShowVid.Size = New System.Drawing.Size(72, 53)
        Me.ButtonShowVid.TabIndex = 39
        Me.ButtonShowVid.UseVisualStyleBackColor = True
        '
        'PlayerPrev
        '
        Me.PlayerPrev.BackColor = System.Drawing.Color.RoyalBlue
        Me.PlayerPrev.Font = New System.Drawing.Font("VAG Rundschrift D", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerPrev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerPrev.Location = New System.Drawing.Point(91, 276)
        Me.PlayerPrev.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerPrev.Name = "PlayerPrev"
        Me.PlayerPrev.Size = New System.Drawing.Size(65, 50)
        Me.PlayerPrev.TabIndex = 38
        Me.PlayerPrev.Text = "<<"
        Me.PlayerPrev.UseVisualStyleBackColor = False
        '
        'txtpositionend
        '
        Me.txtpositionend.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpositionend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtpositionend.Location = New System.Drawing.Point(327, 16)
        Me.txtpositionend.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpositionend.Name = "txtpositionend"
        Me.txtpositionend.ReadOnly = True
        Me.txtpositionend.Size = New System.Drawing.Size(104, 37)
        Me.txtpositionend.TabIndex = 37
        Me.txtpositionend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(292, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 17)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "sur"
        '
        'txtpositionrandom
        '
        Me.txtpositionrandom.Font = New System.Drawing.Font("VAGRounded BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpositionrandom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtpositionrandom.Location = New System.Drawing.Point(177, 16)
        Me.txtpositionrandom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpositionrandom.Name = "txtpositionrandom"
        Me.txtpositionrandom.ReadOnly = True
        Me.txtpositionrandom.Size = New System.Drawing.Size(104, 37)
        Me.txtpositionrandom.TabIndex = 35
        Me.txtpositionrandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RandomList
        '
        Me.RandomList.BackColor = System.Drawing.Color.Thistle
        Me.RandomList.Enabled = False
        Me.RandomList.FormattingEnabled = True
        Me.RandomList.ItemHeight = 16
        Me.RandomList.Location = New System.Drawing.Point(8, 21)
        Me.RandomList.Margin = New System.Windows.Forms.Padding(4)
        Me.RandomList.Name = "RandomList"
        Me.RandomList.Size = New System.Drawing.Size(73, 244)
        Me.RandomList.TabIndex = 34
        '
        'PlayerAudio
        '
        Me.PlayerAudio.Enabled = True
        Me.PlayerAudio.Location = New System.Drawing.Point(68, 47)
        Me.PlayerAudio.Margin = New System.Windows.Forms.Padding(4)
        Me.PlayerAudio.Name = "PlayerAudio"
        Me.PlayerAudio.OcxState = CType(resources.GetObject("PlayerAudio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PlayerAudio.Size = New System.Drawing.Size(336, 176)
        Me.PlayerAudio.TabIndex = 33
        '
        'HiddenButton
        '
        Me.HiddenButton.Location = New System.Drawing.Point(1075, 75)
        Me.HiddenButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HiddenButton.Name = "HiddenButton"
        Me.HiddenButton.Size = New System.Drawing.Size(13, 12)
        Me.HiddenButton.TabIndex = 39
        Me.HiddenButton.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Quizz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1208, 718)
        Me.Controls.Add(Me.HiddenButton)
        Me.Controls.Add(Me.QuizzBox)
        Me.Controls.Add(Me.TitleBox)
        Me.Controls.Add(Me.TempGrid)
        Me.Controls.Add(Me.GroupParamComplet)
        Me.Controls.Add(Me.Buttongetback)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1226, 765)
        Me.MinimumSize = New System.Drawing.Size(1226, 765)
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
    Friend WithEvents ComboRating As TextBox
    Friend WithEvents ButtonShowVid As Button
End Class
