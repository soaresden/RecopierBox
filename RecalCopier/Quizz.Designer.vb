<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quizz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quizz))
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.Buttongetback = New System.Windows.Forms.Button()
        Me.GroupParamComplet = New System.Windows.Forms.GroupBox()
        Me.TxtTotalEntrees = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupParametres = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listhelpingboxGenre = New System.Windows.Forms.ListBox()
        Me.listhelpingboxNote = New System.Windows.Forms.ListBox()
        Me.listhelpingboxPubl = New System.Windows.Forms.ListBox()
        Me.listhelpingboxPlayers = New System.Windows.Forms.ListBox()
        Me.listhelpingboxDev = New System.Windows.Forms.ListBox()
        Me.GroupInfoRoms = New System.Windows.Forms.GroupBox()
        Me.txtplayers = New System.Windows.Forms.TextBox()
        Me.txtpub = New System.Windows.Forms.TextBox()
        Me.txtdev = New System.Windows.Forms.TextBox()
        Me.txtgenre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAnnee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ConsoleTitre = New System.Windows.Forms.RadioButton()
        Me.GroupUserInfo = New System.Windows.Forms.GroupBox()
        Me.TxtSynopsis = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtPlayCount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboRating = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TitreOnly = New System.Windows.Forms.RadioButton()
        Me.ButtonValidFilters = New System.Windows.Forms.Button()
        Me.GroupConfigPartie = New System.Windows.Forms.GroupBox()
        Me.RandomList = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnbmanches = New System.Windows.Forms.TextBox()
        Me.ButtonValidConsole = New System.Windows.Forms.Button()
        Me.ConsoleList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TempGrid = New System.Windows.Forms.DataGridView()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ListTitreDesJeux = New System.Windows.Forms.ListBox()
        Me.ListConsoleDesJeux = New System.Windows.Forms.ListBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupParamComplet.SuspendLayout()
        Me.GroupParametres.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupInfoRoms.SuspendLayout()
        Me.GroupUserInfo.SuspendLayout()
        Me.GroupConfigPartie.SuspendLayout()
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Font = New System.Drawing.Font("VAGRounded BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPlay.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.ButtonPlay.Image = CType(resources.GetObject("ButtonPlay.Image"), System.Drawing.Image)
        Me.ButtonPlay.Location = New System.Drawing.Point(355, 465)
        Me.ButtonPlay.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(74, 76)
        Me.ButtonPlay.TabIndex = 6
        Me.ButtonPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'Buttongetback
        '
        Me.Buttongetback.Location = New System.Drawing.Point(11, 11)
        Me.Buttongetback.Margin = New System.Windows.Forms.Padding(2)
        Me.Buttongetback.Name = "Buttongetback"
        Me.Buttongetback.Size = New System.Drawing.Size(101, 23)
        Me.Buttongetback.TabIndex = 9
        Me.Buttongetback.Text = "Revenir au Menu"
        Me.Buttongetback.UseVisualStyleBackColor = True
        '
        'GroupParamComplet
        '
        Me.GroupParamComplet.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.GroupParamComplet.Controls.Add(Me.TxtTotalEntrees)
        Me.GroupParamComplet.Controls.Add(Me.Label10)
        Me.GroupParamComplet.Controls.Add(Me.GroupParametres)
        Me.GroupParamComplet.Controls.Add(Me.ButtonValidConsole)
        Me.GroupParamComplet.Controls.Add(Me.ButtonPlay)
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
        Me.TxtTotalEntrees.BackColor = System.Drawing.Color.Purple
        Me.TxtTotalEntrees.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalEntrees.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtTotalEntrees.Location = New System.Drawing.Point(162, 484)
        Me.TxtTotalEntrees.Name = "TxtTotalEntrees"
        Me.TxtTotalEntrees.Size = New System.Drawing.Size(94, 31)
        Me.TxtTotalEntrees.TabIndex = 23
        Me.TxtTotalEntrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(181, 464)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Total Roms"
        '
        'GroupParametres
        '
        Me.GroupParametres.BackColor = System.Drawing.Color.MediumPurple
        Me.GroupParametres.Controls.Add(Me.GroupBox1)
        Me.GroupParametres.Controls.Add(Me.GroupInfoRoms)
        Me.GroupParametres.Controls.Add(Me.ConsoleTitre)
        Me.GroupParametres.Controls.Add(Me.GroupUserInfo)
        Me.GroupParametres.Controls.Add(Me.TitreOnly)
        Me.GroupParametres.Controls.Add(Me.ButtonValidFilters)
        Me.GroupParametres.Controls.Add(Me.GroupConfigPartie)
        Me.GroupParametres.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupParametres.Location = New System.Drawing.Point(147, 16)
        Me.GroupParametres.Name = "GroupParametres"
        Me.GroupParametres.Size = New System.Drawing.Size(315, 445)
        Me.GroupParametres.TabIndex = 29
        Me.GroupParametres.TabStop = False
        Me.GroupParametres.Text = "Selection des Filtres :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Plum
        Me.GroupBox1.Controls.Add(Me.listhelpingboxGenre)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxNote)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxPubl)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxPlayers)
        Me.GroupBox1.Controls.Add(Me.listhelpingboxDev)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 220)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catégories Trouvées :"
        '
        'listhelpingboxGenre
        '
        Me.listhelpingboxGenre.FormattingEnabled = True
        Me.listhelpingboxGenre.Location = New System.Drawing.Point(6, 16)
        Me.listhelpingboxGenre.Name = "listhelpingboxGenre"
        Me.listhelpingboxGenre.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxGenre.TabIndex = 28
        '
        'listhelpingboxNote
        '
        Me.listhelpingboxNote.FormattingEnabled = True
        Me.listhelpingboxNote.Location = New System.Drawing.Point(6, 166)
        Me.listhelpingboxNote.Name = "listhelpingboxNote"
        Me.listhelpingboxNote.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxNote.TabIndex = 32
        '
        'listhelpingboxPubl
        '
        Me.listhelpingboxPubl.FormattingEnabled = True
        Me.listhelpingboxPubl.Location = New System.Drawing.Point(6, 94)
        Me.listhelpingboxPubl.Name = "listhelpingboxPubl"
        Me.listhelpingboxPubl.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxPubl.TabIndex = 29
        '
        'listhelpingboxPlayers
        '
        Me.listhelpingboxPlayers.FormattingEnabled = True
        Me.listhelpingboxPlayers.Location = New System.Drawing.Point(6, 130)
        Me.listhelpingboxPlayers.Name = "listhelpingboxPlayers"
        Me.listhelpingboxPlayers.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxPlayers.TabIndex = 31
        '
        'listhelpingboxDev
        '
        Me.listhelpingboxDev.FormattingEnabled = True
        Me.listhelpingboxDev.Location = New System.Drawing.Point(6, 58)
        Me.listhelpingboxDev.Name = "listhelpingboxDev"
        Me.listhelpingboxDev.Size = New System.Drawing.Size(136, 30)
        Me.listhelpingboxDev.TabIndex = 30
        '
        'GroupInfoRoms
        '
        Me.GroupInfoRoms.BackColor = System.Drawing.Color.Plum
        Me.GroupInfoRoms.Controls.Add(Me.txtplayers)
        Me.GroupInfoRoms.Controls.Add(Me.txtpub)
        Me.GroupInfoRoms.Controls.Add(Me.txtdev)
        Me.GroupInfoRoms.Controls.Add(Me.txtgenre)
        Me.GroupInfoRoms.Controls.Add(Me.Label2)
        Me.GroupInfoRoms.Controls.Add(Me.TxtAnnee)
        Me.GroupInfoRoms.Controls.Add(Me.Label7)
        Me.GroupInfoRoms.Controls.Add(Me.Label5)
        Me.GroupInfoRoms.Controls.Add(Me.Label8)
        Me.GroupInfoRoms.Controls.Add(Me.Label6)
        Me.GroupInfoRoms.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupInfoRoms.Location = New System.Drawing.Point(172, 19)
        Me.GroupInfoRoms.Name = "GroupInfoRoms"
        Me.GroupInfoRoms.Size = New System.Drawing.Size(137, 220)
        Me.GroupInfoRoms.TabIndex = 22
        Me.GroupInfoRoms.TabStop = False
        Me.GroupInfoRoms.Text = "Infos Roms"
        '
        'txtplayers
        '
        Me.txtplayers.Location = New System.Drawing.Point(6, 188)
        Me.txtplayers.Name = "txtplayers"
        Me.txtplayers.Size = New System.Drawing.Size(121, 20)
        Me.txtplayers.TabIndex = 25
        '
        'txtpub
        '
        Me.txtpub.Location = New System.Drawing.Point(6, 110)
        Me.txtpub.Name = "txtpub"
        Me.txtpub.Size = New System.Drawing.Size(121, 20)
        Me.txtpub.TabIndex = 24
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Genre"
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
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nb Players"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Developer"
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
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Publisher"
        '
        'ConsoleTitre
        '
        Me.ConsoleTitre.AutoSize = True
        Me.ConsoleTitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ConsoleTitre.Location = New System.Drawing.Point(6, 422)
        Me.ConsoleTitre.Name = "ConsoleTitre"
        Me.ConsoleTitre.Size = New System.Drawing.Size(105, 17)
        Me.ConsoleTitre.TabIndex = 26
        Me.ConsoleTitre.TabStop = True
        Me.ConsoleTitre.Text = "Console + Titre ?"
        Me.ConsoleTitre.UseVisualStyleBackColor = True
        '
        'GroupUserInfo
        '
        Me.GroupUserInfo.BackColor = System.Drawing.Color.Plum
        Me.GroupUserInfo.Controls.Add(Me.TxtSynopsis)
        Me.GroupUserInfo.Controls.Add(Me.Label9)
        Me.GroupUserInfo.Controls.Add(Me.TxtPlayCount)
        Me.GroupUserInfo.Controls.Add(Me.Label3)
        Me.GroupUserInfo.Controls.Add(Me.ComboRating)
        Me.GroupUserInfo.Controls.Add(Me.Label4)
        Me.GroupUserInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupUserInfo.Location = New System.Drawing.Point(6, 258)
        Me.GroupUserInfo.Name = "GroupUserInfo"
        Me.GroupUserInfo.Size = New System.Drawing.Size(148, 144)
        Me.GroupUserInfo.TabIndex = 23
        Me.GroupUserInfo.TabStop = False
        Me.GroupUserInfo.Text = "Infos User"
        '
        'TxtSynopsis
        '
        Me.TxtSynopsis.Location = New System.Drawing.Point(6, 74)
        Me.TxtSynopsis.Name = "TxtSynopsis"
        Me.TxtSynopsis.Size = New System.Drawing.Size(121, 20)
        Me.TxtSynopsis.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Play Count"
        '
        'TxtPlayCount
        '
        Me.TxtPlayCount.Location = New System.Drawing.Point(6, 35)
        Me.TxtPlayCount.Name = "TxtPlayCount"
        Me.TxtPlayCount.Size = New System.Drawing.Size(121, 20)
        Me.TxtPlayCount.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mot Clé dans Synopsis"
        '
        'ComboRating
        '
        Me.ComboRating.FormattingEnabled = True
        Me.ComboRating.Location = New System.Drawing.Point(6, 114)
        Me.ComboRating.Name = "ComboRating"
        Me.ComboRating.Size = New System.Drawing.Size(121, 21)
        Me.ComboRating.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Note"
        '
        'TitreOnly
        '
        Me.TitreOnly.AutoSize = True
        Me.TitreOnly.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TitreOnly.Location = New System.Drawing.Point(6, 408)
        Me.TitreOnly.Name = "TitreOnly"
        Me.TitreOnly.Size = New System.Drawing.Size(79, 17)
        Me.TitreOnly.TabIndex = 25
        Me.TitreOnly.TabStop = True
        Me.TitreOnly.Text = "Titre Only ?"
        Me.TitreOnly.UseVisualStyleBackColor = True
        '
        'ButtonValidFilters
        '
        Me.ButtonValidFilters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonValidFilters.Location = New System.Drawing.Point(172, 408)
        Me.ButtonValidFilters.Name = "ButtonValidFilters"
        Me.ButtonValidFilters.Size = New System.Drawing.Size(137, 23)
        Me.ButtonValidFilters.TabIndex = 24
        Me.ButtonValidFilters.Text = "Calculer le Random"
        Me.ButtonValidFilters.UseVisualStyleBackColor = True
        '
        'GroupConfigPartie
        '
        Me.GroupConfigPartie.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GroupConfigPartie.Controls.Add(Me.RandomList)
        Me.GroupConfigPartie.Controls.Add(Me.Label11)
        Me.GroupConfigPartie.Controls.Add(Me.txtnbmanches)
        Me.GroupConfigPartie.Location = New System.Drawing.Point(172, 258)
        Me.GroupConfigPartie.Name = "GroupConfigPartie"
        Me.GroupConfigPartie.Size = New System.Drawing.Size(137, 144)
        Me.GroupConfigPartie.TabIndex = 27
        Me.GroupConfigPartie.TabStop = False
        Me.GroupConfigPartie.Text = "Config Partie :"
        '
        'RandomList
        '
        Me.RandomList.FormattingEnabled = True
        Me.RandomList.Location = New System.Drawing.Point(6, 58)
        Me.RandomList.Name = "RandomList"
        Me.RandomList.Size = New System.Drawing.Size(121, 82)
        Me.RandomList.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Combien de Manches ?"
        '
        'txtnbmanches
        '
        Me.txtnbmanches.Location = New System.Drawing.Point(36, 32)
        Me.txtnbmanches.Name = "txtnbmanches"
        Me.txtnbmanches.Size = New System.Drawing.Size(61, 20)
        Me.txtnbmanches.TabIndex = 25
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
        'ConsoleList
        '
        Me.ConsoleList.FormattingEnabled = True
        Me.ConsoleList.Location = New System.Drawing.Point(6, 35)
        Me.ConsoleList.Name = "ConsoleList"
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
        Me.TempGrid.Location = New System.Drawing.Point(492, 4)
        Me.TempGrid.Name = "TempGrid"
        Me.TempGrid.Size = New System.Drawing.Size(414, 75)
        Me.TempGrid.TabIndex = 11
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(525, 85)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(350, 209)
        Me.AxWindowsMediaPlayer1.TabIndex = 22
        '
        'ListTitreDesJeux
        '
        Me.ListTitreDesJeux.FormattingEnabled = True
        Me.ListTitreDesJeux.Location = New System.Drawing.Point(611, 394)
        Me.ListTitreDesJeux.Name = "ListTitreDesJeux"
        Me.ListTitreDesJeux.Size = New System.Drawing.Size(295, 186)
        Me.ListTitreDesJeux.TabIndex = 23
        '
        'ListConsoleDesJeux
        '
        Me.ListConsoleDesJeux.FormattingEnabled = True
        Me.ListConsoleDesJeux.Location = New System.Drawing.Point(492, 393)
        Me.ListConsoleDesJeux.Name = "ListConsoleDesJeux"
        Me.ListConsoleDesJeux.Size = New System.Drawing.Size(113, 186)
        Me.ListConsoleDesJeux.TabIndex = 24
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(492, 300)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(413, 23)
        Me.ProgressBar1.TabIndex = 27
        '
        'Quizz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(908, 591)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ListConsoleDesJeux)
        Me.Controls.Add(Me.ListTitreDesJeux)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.TempGrid)
        Me.Controls.Add(Me.GroupParamComplet)
        Me.Controls.Add(Me.Buttongetback)
        Me.Name = "Quizz"
        Me.Text = "Quizz"
        Me.GroupParamComplet.ResumeLayout(False)
        Me.GroupParamComplet.PerformLayout()
        Me.GroupParametres.ResumeLayout(False)
        Me.GroupParametres.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupInfoRoms.ResumeLayout(False)
        Me.GroupInfoRoms.PerformLayout()
        Me.GroupUserInfo.ResumeLayout(False)
        Me.GroupUserInfo.PerformLayout()
        Me.GroupConfigPartie.ResumeLayout(False)
        Me.GroupConfigPartie.PerformLayout()
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ButtonPlay As Button
    Friend WithEvents Buttongetback As Button
    Friend WithEvents GroupParamComplet As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboRating As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ConsoleList As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupConfigPartie As GroupBox
    Friend WithEvents RandomList As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtnbmanches As TextBox
    Friend WithEvents ButtonValidFilters As Button
    Friend WithEvents GroupUserInfo As GroupBox
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
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
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
End Class
