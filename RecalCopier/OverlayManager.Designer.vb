<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OverlayManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverlayManager))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridRoms = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RomTotalOverlay = New System.Windows.Forms.TextBox()
        Me.RomTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RenameSelection = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ActualName = New System.Windows.Forms.TextBox()
        Me.NewName = New System.Windows.Forms.TextBox()
        Me.ButtonRenameSave = New System.Windows.Forms.Button()
        Me.ButtonMenage1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OverlaySingle = New System.Windows.Forms.TextBox()
        Me.OverlayTotal = New System.Windows.Forms.TextBox()
        Me.ButtonSuppSave = New System.Windows.Forms.Button()
        Me.GameLists = New System.Windows.Forms.ListBox()
        Me.DataGridOverlay = New System.Windows.Forms.DataGridView()
        Me.ListToSupp = New System.Windows.Forms.ListBox()
        Me.ListdesFichiersEnTrop = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ImportBoth1 = New System.Windows.Forms.Button()
        Me.ButtonGetBack1 = New System.Windows.Forms.Button()
        Me.buttonImportRoms1 = New System.Windows.Forms.Button()
        Me.ButtonImportOverlays1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.templisttosupp = New System.Windows.Forms.ListBox()
        Me.ButtonResizeOverlays = New System.Windows.Forms.Button()
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.PanelChoice = New System.Windows.Forms.Panel()
        Me.ButtonShowOverlayManager = New System.Windows.Forms.Button()
        CType(Me.DataGridRoms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.RenameSelection.SuspendLayout()
        CType(Me.DataGridOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(318, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Liste de Toutes les Roms Gamelistées"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(510, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Liste de Tous les Overlays"
        '
        'DataGridRoms
        '
        Me.DataGridRoms.AllowUserToOrderColumns = True
        Me.DataGridRoms.AllowUserToResizeRows = False
        Me.DataGridRoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRoms.Location = New System.Drawing.Point(134, 102)
        Me.DataGridRoms.Name = "DataGridRoms"
        Me.DataGridRoms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRoms.Size = New System.Drawing.Size(367, 284)
        Me.DataGridRoms.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lavender
        Me.TextBox1.Location = New System.Drawing.Point(134, 392)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(367, 62)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "La liste de toutes vos roms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La coche à droite permet de savoir si un overlay est" &
    " disponible ou non."
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Bisque
        Me.TextBox2.Location = New System.Drawing.Point(507, 226)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(476, 62)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "La liste de tous les Overlays." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La coche à droite permets de savoir si une rom es" &
    "t associée ou non." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si un overlay n'est pas associé, cela veut dire que vous ave" &
    "z un overlay orphelin."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RomTotalOverlay)
        Me.GroupBox1.Controls.Add(Me.RomTotal)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(134, 460)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 129)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outils :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total de Roms avec Overlay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total de Roms"
        '
        'RomTotalOverlay
        '
        Me.RomTotalOverlay.Location = New System.Drawing.Point(149, 78)
        Me.RomTotalOverlay.Name = "RomTotalOverlay"
        Me.RomTotalOverlay.Size = New System.Drawing.Size(67, 20)
        Me.RomTotalOverlay.TabIndex = 16
        Me.RomTotalOverlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RomTotal
        '
        Me.RomTotal.Location = New System.Drawing.Point(149, 39)
        Me.RomTotal.Name = "RomTotal"
        Me.RomTotal.Size = New System.Drawing.Size(67, 20)
        Me.RomTotal.TabIndex = 15
        Me.RomTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.RenameSelection)
        Me.GroupBox2.Controls.Add(Me.ButtonMenage1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.OverlaySingle)
        Me.GroupBox2.Controls.Add(Me.OverlayTotal)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(368, 460)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(615, 129)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outils Overlays :"
        '
        'RenameSelection
        '
        Me.RenameSelection.BackColor = System.Drawing.Color.Sienna
        Me.RenameSelection.Controls.Add(Me.Label10)
        Me.RenameSelection.Controls.Add(Me.Label11)
        Me.RenameSelection.Controls.Add(Me.ActualName)
        Me.RenameSelection.Controls.Add(Me.NewName)
        Me.RenameSelection.Controls.Add(Me.ButtonRenameSave)
        Me.RenameSelection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RenameSelection.Location = New System.Drawing.Point(6, 19)
        Me.RenameSelection.Name = "RenameSelection"
        Me.RenameSelection.Size = New System.Drawing.Size(396, 104)
        Me.RenameSelection.TabIndex = 62
        Me.RenameSelection.TabStop = False
        Me.RenameSelection.Text = "Renommer le fichier CFG principal : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Nouveau Nom :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "NomOverlay Actuel :"
        '
        'ActualName
        '
        Me.ActualName.Location = New System.Drawing.Point(112, 15)
        Me.ActualName.Name = "ActualName"
        Me.ActualName.ReadOnly = True
        Me.ActualName.Size = New System.Drawing.Size(278, 20)
        Me.ActualName.TabIndex = 63
        Me.ActualName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NewName
        '
        Me.NewName.Location = New System.Drawing.Point(112, 41)
        Me.NewName.Name = "NewName"
        Me.NewName.Size = New System.Drawing.Size(278, 20)
        Me.NewName.TabIndex = 62
        Me.NewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonRenameSave
        '
        Me.ButtonRenameSave.BackColor = System.Drawing.Color.Sienna
        Me.ButtonRenameSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRenameSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonRenameSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonRenameSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff
        Me.ButtonRenameSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRenameSave.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRenameSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRenameSave.Location = New System.Drawing.Point(112, 62)
        Me.ButtonRenameSave.Name = "ButtonRenameSave"
        Me.ButtonRenameSave.Size = New System.Drawing.Size(278, 36)
        Me.ButtonRenameSave.TabIndex = 43
        Me.ButtonRenameSave.Text = "Renommer l'overlay avec le Nom ci-dessus"
        Me.ButtonRenameSave.UseVisualStyleBackColor = False
        '
        'ButtonMenage1
        '
        Me.ButtonMenage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ButtonMenage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonMenage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonMenage1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonMenage1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ButtonMenage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenage1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenage1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMenage1.Location = New System.Drawing.Point(471, 66)
        Me.ButtonMenage1.Name = "ButtonMenage1"
        Me.ButtonMenage1.Size = New System.Drawing.Size(138, 40)
        Me.ButtonMenage1.TabIndex = 42
        Me.ButtonMenage1.Text = "Supprimer les" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Overlays Orphelins"
        Me.ButtonMenage1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total d'Overlays"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(408, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total d'Overlay Orphelins"
        '
        'OverlaySingle
        '
        Me.OverlaySingle.Location = New System.Drawing.Point(539, 37)
        Me.OverlaySingle.Name = "OverlaySingle"
        Me.OverlaySingle.Size = New System.Drawing.Size(67, 20)
        Me.OverlaySingle.TabIndex = 17
        Me.OverlaySingle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OverlayTotal
        '
        Me.OverlayTotal.Location = New System.Drawing.Point(539, 14)
        Me.OverlayTotal.Name = "OverlayTotal"
        Me.OverlayTotal.Size = New System.Drawing.Size(67, 20)
        Me.OverlayTotal.TabIndex = 16
        Me.OverlayTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonSuppSave
        '
        Me.ButtonSuppSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ButtonSuppSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSuppSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonSuppSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonSuppSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonSuppSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSuppSave.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuppSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSuppSave.Location = New System.Drawing.Point(507, 412)
        Me.ButtonSuppSave.Name = "ButtonSuppSave"
        Me.ButtonSuppSave.Size = New System.Drawing.Size(245, 42)
        Me.ButtonSuppSave.TabIndex = 63
        Me.ButtonSuppSave.Text = "Supprimer en Cascade" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La selection ci-dessus"
        Me.ButtonSuppSave.UseVisualStyleBackColor = False
        '
        'GameLists
        '
        Me.GameLists.FormattingEnabled = True
        Me.GameLists.Location = New System.Drawing.Point(12, 102)
        Me.GameLists.Name = "GameLists"
        Me.GameLists.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.GameLists.Size = New System.Drawing.Size(116, 472)
        Me.GameLists.TabIndex = 14
        '
        'DataGridOverlay
        '
        Me.DataGridOverlay.AllowUserToOrderColumns = True
        Me.DataGridOverlay.AllowUserToResizeRows = False
        Me.DataGridOverlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOverlay.Location = New System.Drawing.Point(507, 102)
        Me.DataGridOverlay.Name = "DataGridOverlay"
        Me.DataGridOverlay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridOverlay.Size = New System.Drawing.Size(476, 118)
        Me.DataGridOverlay.TabIndex = 15
        '
        'ListToSupp
        '
        Me.ListToSupp.BackColor = System.Drawing.Color.MistyRose
        Me.ListToSupp.FormattingEnabled = True
        Me.ListToSupp.Location = New System.Drawing.Point(507, 307)
        Me.ListToSupp.Name = "ListToSupp"
        Me.ListToSupp.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListToSupp.Size = New System.Drawing.Size(245, 95)
        Me.ListToSupp.TabIndex = 17
        '
        'ListdesFichiersEnTrop
        '
        Me.ListdesFichiersEnTrop.BackColor = System.Drawing.Color.LightPink
        Me.ListdesFichiersEnTrop.FormattingEnabled = True
        Me.ListdesFichiersEnTrop.Location = New System.Drawing.Point(758, 307)
        Me.ListdesFichiersEnTrop.Name = "ListdesFichiersEnTrop"
        Me.ListdesFichiersEnTrop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListdesFichiersEnTrop.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListdesFichiersEnTrop.Size = New System.Drawing.Size(225, 147)
        Me.ListdesFichiersEnTrop.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(507, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Fichiers CFG sans roms associés :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(758, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Liste des fichiers cité dans la liste ci dessus :"
        '
        'ImportBoth1
        '
        Me.ImportBoth1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ImportBoth1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ImportBoth1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImportBoth1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ImportBoth1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ImportBoth1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImportBoth1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportBoth1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ImportBoth1.Location = New System.Drawing.Point(134, 7)
        Me.ImportBoth1.Name = "ImportBoth1"
        Me.ImportBoth1.Size = New System.Drawing.Size(116, 23)
        Me.ImportBoth1.TabIndex = 38
        Me.ImportBoth1.Text = "Tout Importer"
        Me.ImportBoth1.UseVisualStyleBackColor = False
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
        Me.ButtonGetBack1.Location = New System.Drawing.Point(12, 7)
        Me.ButtonGetBack1.Name = "ButtonGetBack1"
        Me.ButtonGetBack1.Size = New System.Drawing.Size(116, 23)
        Me.ButtonGetBack1.TabIndex = 39
        Me.ButtonGetBack1.Text = "Retour Au Menu"
        Me.ButtonGetBack1.UseVisualStyleBackColor = False
        '
        'buttonImportRoms1
        '
        Me.buttonImportRoms1.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.buttonImportRoms1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonImportRoms1.Cursor = System.Windows.Forms.Cursors.Default
        Me.buttonImportRoms1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.buttonImportRoms1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.buttonImportRoms1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonImportRoms1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonImportRoms1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonImportRoms1.Location = New System.Drawing.Point(385, 53)
        Me.buttonImportRoms1.Name = "buttonImportRoms1"
        Me.buttonImportRoms1.Size = New System.Drawing.Size(116, 30)
        Me.buttonImportRoms1.TabIndex = 40
        Me.buttonImportRoms1.Text = "Importer les Roms"
        Me.buttonImportRoms1.UseVisualStyleBackColor = False
        '
        'ButtonImportOverlays1
        '
        Me.ButtonImportOverlays1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ButtonImportOverlays1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonImportOverlays1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonImportOverlays1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonImportOverlays1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ButtonImportOverlays1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImportOverlays1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportOverlays1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonImportOverlays1.Location = New System.Drawing.Point(867, 66)
        Me.ButtonImportOverlays1.Name = "ButtonImportOverlays1"
        Me.ButtonImportOverlays1.Size = New System.Drawing.Size(116, 30)
        Me.ButtonImportOverlays1.TabIndex = 41
        Me.ButtonImportOverlays1.Text = "Importer les Overlays"
        Me.ButtonImportOverlays1.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RichTextBox1.Location = New System.Drawing.Point(507, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(476, 60)
        Me.RichTextBox1.TabIndex = 43
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'templisttosupp
        '
        Me.templisttosupp.FormattingEnabled = True
        Me.templisttosupp.Location = New System.Drawing.Point(880, 226)
        Me.templisttosupp.Name = "templisttosupp"
        Me.templisttosupp.Size = New System.Drawing.Size(103, 56)
        Me.templisttosupp.TabIndex = 44
        Me.templisttosupp.Visible = False
        '
        'ButtonResizeOverlays
        '
        Me.ButtonResizeOverlays.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ButtonResizeOverlays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonResizeOverlays.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonResizeOverlays.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonResizeOverlays.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ButtonResizeOverlays.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonResizeOverlays.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResizeOverlays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonResizeOverlays.Location = New System.Drawing.Point(315, 314)
        Me.ButtonResizeOverlays.Name = "ButtonResizeOverlays"
        Me.ButtonResizeOverlays.Size = New System.Drawing.Size(347, 161)
        Me.ButtonResizeOverlays.TabIndex = 64
        Me.ButtonResizeOverlays.Text = "Overlay Resizer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permet de Redimensionner vos overlays actuel en une résolution" &
    " autre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ex: 1920x1080 --> 1024x600"
        Me.ButtonResizeOverlays.UseVisualStyleBackColor = False
        '
        'ButtonConvert
        '
        Me.ButtonConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonConvert.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConvert.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConvert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonConvert.Location = New System.Drawing.Point(621, 149)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(344, 121)
        Me.ButtonConvert.TabIndex = 65
        Me.ButtonConvert.Text = "Overlay Converter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permet de convertir vos overlays au format Recalbox" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(*.cfg " &
    "+ *_overlay.cfg +*.png)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en overlay au format Batocera et vice versa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(*.info + " &
    "*.png)"
        Me.ButtonConvert.UseVisualStyleBackColor = False
        '
        'PanelChoice
        '
        Me.PanelChoice.Controls.Add(Me.ButtonConvert)
        Me.PanelChoice.Controls.Add(Me.ButtonShowOverlayManager)
        Me.PanelChoice.Controls.Add(Me.ButtonResizeOverlays)
        Me.PanelChoice.Location = New System.Drawing.Point(269, 7)
        Me.PanelChoice.Name = "PanelChoice"
        Me.PanelChoice.Size = New System.Drawing.Size(232, 23)
        Me.PanelChoice.TabIndex = 90
        '
        'ButtonShowOverlayManager
        '
        Me.ButtonShowOverlayManager.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonShowOverlayManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonShowOverlayManager.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonShowOverlayManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonShowOverlayManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonShowOverlayManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowOverlayManager.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShowOverlayManager.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonShowOverlayManager.Location = New System.Drawing.Point(30, 151)
        Me.ButtonShowOverlayManager.Name = "ButtonShowOverlayManager"
        Me.ButtonShowOverlayManager.Size = New System.Drawing.Size(344, 119)
        Me.ButtonShowOverlayManager.TabIndex = 90
        Me.ButtonShowOverlayManager.Text = "Overlay Manager" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permet de Gérer vos overlays actuels en affichant :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- dans " &
    "votre gamelist, les roms avec et sans overlays" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- dans votre dossier overlays, l" &
    "es roms qui n'ont pas de roms associé."
        Me.ButtonShowOverlayManager.UseVisualStyleBackColor = False
        '
        'OverlayManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(984, 591)
        Me.Controls.Add(Me.PanelChoice)
        Me.Controls.Add(Me.templisttosupp)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ButtonSuppSave)
        Me.Controls.Add(Me.ButtonImportOverlays1)
        Me.Controls.Add(Me.buttonImportRoms1)
        Me.Controls.Add(Me.ButtonGetBack1)
        Me.Controls.Add(Me.ImportBoth1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListdesFichiersEnTrop)
        Me.Controls.Add(Me.ListToSupp)
        Me.Controls.Add(Me.DataGridOverlay)
        Me.Controls.Add(Me.GameLists)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridRoms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1000, 630)
        Me.MinimumSize = New System.Drawing.Size(1000, 630)
        Me.Name = "OverlayManager"
        Me.Text = "OverlayManager"
        CType(Me.DataGridRoms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.RenameSelection.ResumeLayout(False)
        Me.RenameSelection.PerformLayout()
        CType(Me.DataGridOverlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChoice.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridRoms As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GameLists As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RomTotalOverlay As TextBox
    Friend WithEvents RomTotal As TextBox
    Friend WithEvents DataGridOverlay As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OverlaySingle As TextBox
    Friend WithEvents OverlayTotal As TextBox
    Friend WithEvents ListToSupp As ListBox
    Friend WithEvents ListdesFichiersEnTrop As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ImportBoth1 As Button
    Friend WithEvents ButtonGetBack1 As Button
    Friend WithEvents buttonImportRoms1 As Button
    Friend WithEvents ButtonImportOverlays1 As Button
    Friend WithEvents ButtonMenage1 As Button
    Friend WithEvents RenameSelection As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ActualName As TextBox
    Friend WithEvents NewName As TextBox
    Friend WithEvents ButtonRenameSave As Button
    Friend WithEvents ButtonSuppSave As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents templisttosupp As ListBox
    Friend WithEvents ButtonResizeOverlays As Button
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents PanelChoice As Panel
    Friend WithEvents ButtonShowOverlayManager As Button
End Class
