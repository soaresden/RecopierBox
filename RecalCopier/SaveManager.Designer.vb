﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaveManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveManager))
        Me.ButtonImportSaves1 = New System.Windows.Forms.Button()
        Me.buttonImportRoms1 = New System.Windows.Forms.Button()
        Me.ButtonGetBack1 = New System.Windows.Forms.Button()
        Me.ImportBoth1 = New System.Windows.Forms.Button()
        Me.DataGridSave = New System.Windows.Forms.DataGridView()
        Me.GameLists = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RomTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveSingle = New System.Windows.Forms.TextBox()
        Me.SaveTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RomTotalSave = New System.Windows.Forms.TextBox()
        Me.RenameSelection = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textstate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ActualName = New System.Windows.Forms.TextBox()
        Me.ButtonRenameSave = New System.Windows.Forms.Button()
        Me.NewName = New System.Windows.Forms.TextBox()
        Me.PathActuel = New System.Windows.Forms.TextBox()
        Me.ButtonSuppSave = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridRoms = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListdesFichiersEnTrop = New System.Windows.Forms.ListBox()
        Me.ListSaves = New System.Windows.Forms.ListBox()
        Me.ButtonMenageOrphelin = New System.Windows.Forms.Button()
        Me.ButtonRomsDeleteSelected = New System.Windows.Forms.Button()
        Me.GroupRoms = New System.Windows.Forms.GroupBox()
        Me.GroupSaves = New System.Windows.Forms.GroupBox()
        Me.ButtonRenommer = New System.Windows.Forms.Button()
        Me.prevplatform = New System.Windows.Forms.Button()
        Me.nextplatform = New System.Windows.Forms.Button()
        Me.BatoPict = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RenameSelection.SuspendLayout()
        CType(Me.DataGridRoms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupRoms.SuspendLayout()
        Me.GroupSaves.SuspendLayout()
        CType(Me.BatoPict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonImportSaves1
        '
        Me.ButtonImportSaves1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ButtonImportSaves1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonImportSaves1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonImportSaves1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonImportSaves1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ButtonImportSaves1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImportSaves1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportSaves1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonImportSaves1.Location = New System.Drawing.Point(1125, 34)
        Me.ButtonImportSaves1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonImportSaves1.Name = "ButtonImportSaves1"
        Me.ButtonImportSaves1.Size = New System.Drawing.Size(155, 37)
        Me.ButtonImportSaves1.TabIndex = 58
        Me.ButtonImportSaves1.Text = "Importer les Saves"
        Me.ButtonImportSaves1.UseVisualStyleBackColor = False
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
        Me.buttonImportRoms1.Location = New System.Drawing.Point(505, 34)
        Me.buttonImportRoms1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonImportRoms1.Name = "buttonImportRoms1"
        Me.buttonImportRoms1.Size = New System.Drawing.Size(155, 37)
        Me.buttonImportRoms1.TabIndex = 57
        Me.buttonImportRoms1.Text = "Importer les Roms"
        Me.buttonImportRoms1.UseVisualStyleBackColor = False
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
        Me.ButtonGetBack1.Location = New System.Drawing.Point(16, 15)
        Me.ButtonGetBack1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGetBack1.Name = "ButtonGetBack1"
        Me.ButtonGetBack1.Size = New System.Drawing.Size(155, 28)
        Me.ButtonGetBack1.TabIndex = 56
        Me.ButtonGetBack1.Text = "Retour Au Menu"
        Me.ButtonGetBack1.UseVisualStyleBackColor = False
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
        Me.ImportBoth1.Location = New System.Drawing.Point(179, 6)
        Me.ImportBoth1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImportBoth1.Name = "ImportBoth1"
        Me.ImportBoth1.Size = New System.Drawing.Size(155, 37)
        Me.ImportBoth1.TabIndex = 55
        Me.ImportBoth1.Text = "Tout Importer"
        Me.ImportBoth1.UseVisualStyleBackColor = False
        '
        'DataGridSave
        '
        Me.DataGridSave.AllowUserToOrderColumns = True
        Me.DataGridSave.AllowUserToResizeRows = False
        Me.DataGridSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSave.Location = New System.Drawing.Point(676, 172)
        Me.DataGridSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridSave.Name = "DataGridSave"
        Me.DataGridSave.RowHeadersWidth = 51
        Me.DataGridSave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSave.Size = New System.Drawing.Size(604, 268)
        Me.DataGridSave.TabIndex = 50
        '
        'GameLists
        '
        Me.GameLists.FormattingEnabled = True
        Me.GameLists.ItemHeight = 16
        Me.GameLists.Location = New System.Drawing.Point(16, 95)
        Me.GameLists.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GameLists.Name = "GameLists"
        Me.GameLists.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.GameLists.Size = New System.Drawing.Size(153, 564)
        Me.GameLists.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(1113, 448)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total de Saves :"
        '
        'RomTotal
        '
        Me.RomTotal.Location = New System.Drawing.Point(605, 444)
        Me.RomTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RomTotal.Name = "RomTotal"
        Me.RomTotal.ReadOnly = True
        Me.RomTotal.Size = New System.Drawing.Size(52, 22)
        Me.RomTotal.TabIndex = 15
        Me.RomTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(1043, 474)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total de Saves Orphelines :"
        '
        'SaveSingle
        '
        Me.SaveSingle.Location = New System.Drawing.Point(1227, 473)
        Me.SaveSingle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveSingle.Name = "SaveSingle"
        Me.SaveSingle.ReadOnly = True
        Me.SaveSingle.Size = New System.Drawing.Size(52, 22)
        Me.SaveSingle.TabIndex = 17
        Me.SaveSingle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SaveTotal
        '
        Me.SaveTotal.Location = New System.Drawing.Point(1227, 444)
        Me.SaveTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveTotal.Name = "SaveTotal"
        Me.SaveTotal.ReadOnly = True
        Me.SaveTotal.Size = New System.Drawing.Size(52, 22)
        Me.SaveTotal.TabIndex = 16
        Me.SaveTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(464, 478)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total AVEC Saves :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(488, 448)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total de Roms :"
        '
        'RomTotalSave
        '
        Me.RomTotalSave.Location = New System.Drawing.Point(605, 474)
        Me.RomTotalSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RomTotalSave.Name = "RomTotalSave"
        Me.RomTotalSave.ReadOnly = True
        Me.RomTotalSave.Size = New System.Drawing.Size(52, 22)
        Me.RomTotalSave.TabIndex = 16
        Me.RomTotalSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RenameSelection
        '
        Me.RenameSelection.BackColor = System.Drawing.Color.Sienna
        Me.RenameSelection.Controls.Add(Me.Label9)
        Me.RenameSelection.Controls.Add(Me.textstate)
        Me.RenameSelection.Controls.Add(Me.Label8)
        Me.RenameSelection.Controls.Add(Me.Label7)
        Me.RenameSelection.Controls.Add(Me.ActualName)
        Me.RenameSelection.Controls.Add(Me.ButtonRenameSave)
        Me.RenameSelection.Controls.Add(Me.NewName)
        Me.RenameSelection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RenameSelection.Location = New System.Drawing.Point(591, 497)
        Me.RenameSelection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RenameSelection.Name = "RenameSelection"
        Me.RenameSelection.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RenameSelection.Size = New System.Drawing.Size(77, 65)
        Me.RenameSelection.TabIndex = 48
        Me.RenameSelection.TabStop = False
        Me.RenameSelection.Text = "OUTIL RENOMMER VOS SAVES :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(361, 177)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "n° State :"
        '
        'textstate
        '
        Me.textstate.Location = New System.Drawing.Point(437, 175)
        Me.textstate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textstate.Name = "textstate"
        Me.textstate.Size = New System.Drawing.Size(41, 22)
        Me.textstate.TabIndex = 62
        Me.textstate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 97)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(394, 34)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Nouveau Nom du fichier Save " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Cliquer sur une ligne du Tableau ci dessus pour Pr" &
    "éRemplir)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 17)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(331, 34)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Nom du Fichier Save Actuel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Cliquer sur la liste Rose à Droite pour Préremplir) " &
    ":"
        '
        'ActualName
        '
        Me.ActualName.Location = New System.Drawing.Point(8, 62)
        Me.ActualName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ActualName.Name = "ActualName"
        Me.ActualName.ReadOnly = True
        Me.ActualName.Size = New System.Drawing.Size(471, 22)
        Me.ActualName.TabIndex = 63
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
        Me.ButtonRenameSave.Location = New System.Drawing.Point(187, 172)
        Me.ButtonRenameSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRenameSave.Name = "ButtonRenameSave"
        Me.ButtonRenameSave.Size = New System.Drawing.Size(133, 34)
        Me.ButtonRenameSave.TabIndex = 43
        Me.ButtonRenameSave.Text = "Renommer la save"
        Me.ButtonRenameSave.UseVisualStyleBackColor = False
        '
        'NewName
        '
        Me.NewName.Location = New System.Drawing.Point(8, 133)
        Me.NewName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NewName.Name = "NewName"
        Me.NewName.Size = New System.Drawing.Size(471, 22)
        Me.NewName.TabIndex = 62
        '
        'PathActuel
        '
        Me.PathActuel.Location = New System.Drawing.Point(13, 75)
        Me.PathActuel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PathActuel.Name = "PathActuel"
        Me.PathActuel.ReadOnly = True
        Me.PathActuel.Size = New System.Drawing.Size(132, 22)
        Me.PathActuel.TabIndex = 66
        Me.PathActuel.Visible = False
        '
        'ButtonSuppSave
        '
        Me.ButtonSuppSave.BackColor = System.Drawing.Color.Red
        Me.ButtonSuppSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSuppSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonSuppSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonSuppSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.ButtonSuppSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSuppSave.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuppSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSuppSave.Location = New System.Drawing.Point(381, 97)
        Me.ButtonSuppSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSuppSave.Name = "ButtonSuppSave"
        Me.ButtonSuppSave.Size = New System.Drawing.Size(215, 63)
        Me.ButtonSuppSave.TabIndex = 61
        Me.ButtonSuppSave.Text = "Supprimer le(s) " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Saves Selectionnées ci-contre"
        Me.ButtonSuppSave.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Bisque
        Me.TextBox2.Location = New System.Drawing.Point(676, 79)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(603, 69)
        Me.TextBox2.TabIndex = 46
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lavender
        Me.TextBox1.Location = New System.Drawing.Point(179, 79)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(479, 69)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = "La liste de toutes vos roms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La coche à droite permet de savoir si une save est d" &
    "isponible ou non." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selectionner une ligne copie automatiquement le nom du fichie" &
    "r dans le presse-papiers."
        '
        'DataGridRoms
        '
        Me.DataGridRoms.AllowUserToOrderColumns = True
        Me.DataGridRoms.AllowUserToResizeRows = False
        Me.DataGridRoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRoms.Location = New System.Drawing.Point(179, 172)
        Me.DataGridRoms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridRoms.Name = "DataGridRoms"
        Me.DataGridRoms.RowHeadersWidth = 51
        Me.DataGridRoms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRoms.Size = New System.Drawing.Size(480, 268)
        Me.DataGridRoms.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Equinox Com", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(799, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 22)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Liste COMPLETE de Toutes les Saves dans le Dossier :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Equinox Com", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(280, 153)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 22)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Liste de Toutes les Roms Gamelistées :"
        '
        'ListdesFichiersEnTrop
        '
        Me.ListdesFichiersEnTrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ListdesFichiersEnTrop.FormattingEnabled = True
        Me.ListdesFichiersEnTrop.ItemHeight = 16
        Me.ListdesFichiersEnTrop.Location = New System.Drawing.Point(8, 22)
        Me.ListdesFichiersEnTrop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListdesFichiersEnTrop.Name = "ListdesFichiersEnTrop"
        Me.ListdesFichiersEnTrop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListdesFichiersEnTrop.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListdesFichiersEnTrop.Size = New System.Drawing.Size(364, 132)
        Me.ListdesFichiersEnTrop.TabIndex = 59
        '
        'ListSaves
        '
        Me.ListSaves.BackColor = System.Drawing.Color.LightCyan
        Me.ListSaves.FormattingEnabled = True
        Me.ListSaves.ItemHeight = 16
        Me.ListSaves.Location = New System.Drawing.Point(8, 23)
        Me.ListSaves.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListSaves.Name = "ListSaves"
        Me.ListSaves.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListSaves.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListSaves.Size = New System.Drawing.Size(263, 116)
        Me.ListSaves.TabIndex = 60
        '
        'ButtonMenageOrphelin
        '
        Me.ButtonMenageOrphelin.BackColor = System.Drawing.Color.Crimson
        Me.ButtonMenageOrphelin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonMenageOrphelin.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonMenageOrphelin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonMenageOrphelin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink
        Me.ButtonMenageOrphelin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenageOrphelin.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenageOrphelin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMenageOrphelin.Location = New System.Drawing.Point(381, 23)
        Me.ButtonMenageOrphelin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonMenageOrphelin.Name = "ButtonMenageOrphelin"
        Me.ButtonMenageOrphelin.Size = New System.Drawing.Size(215, 57)
        Me.ButtonMenageOrphelin.TabIndex = 42
        Me.ButtonMenageOrphelin.Text = "Supprimer TOUTES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "les Saves Orphelines"
        Me.ButtonMenageOrphelin.UseVisualStyleBackColor = False
        '
        'ButtonRomsDeleteSelected
        '
        Me.ButtonRomsDeleteSelected.BackColor = System.Drawing.Color.Red
        Me.ButtonRomsDeleteSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRomsDeleteSelected.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonRomsDeleteSelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonRomsDeleteSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.ButtonRomsDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRomsDeleteSelected.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRomsDeleteSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRomsDeleteSelected.Location = New System.Drawing.Point(219, 447)
        Me.ButtonRomsDeleteSelected.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRomsDeleteSelected.Name = "ButtonRomsDeleteSelected"
        Me.ButtonRomsDeleteSelected.Size = New System.Drawing.Size(193, 54)
        Me.ButtonRomsDeleteSelected.TabIndex = 62
        Me.ButtonRomsDeleteSelected.Text = "Supprimer le(s) Saves" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selectionné(es) ci-dessous"
        Me.ButtonRomsDeleteSelected.UseVisualStyleBackColor = False
        '
        'GroupRoms
        '
        Me.GroupRoms.BackColor = System.Drawing.Color.DarkBlue
        Me.GroupRoms.Controls.Add(Me.ListSaves)
        Me.GroupRoms.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupRoms.Location = New System.Drawing.Point(179, 508)
        Me.GroupRoms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupRoms.Name = "GroupRoms"
        Me.GroupRoms.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupRoms.Size = New System.Drawing.Size(280, 151)
        Me.GroupRoms.TabIndex = 63
        Me.GroupRoms.TabStop = False
        Me.GroupRoms.Text = "Fichiers liés à la Rom Select. ci-dessus :"
        '
        'GroupSaves
        '
        Me.GroupSaves.BackColor = System.Drawing.Color.Salmon
        Me.GroupSaves.Controls.Add(Me.ButtonMenageOrphelin)
        Me.GroupSaves.Controls.Add(Me.PathActuel)
        Me.GroupSaves.Controls.Add(Me.ListdesFichiersEnTrop)
        Me.GroupSaves.Controls.Add(Me.ButtonSuppSave)
        Me.GroupSaves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupSaves.Location = New System.Drawing.Point(676, 500)
        Me.GroupSaves.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupSaves.Name = "GroupSaves"
        Me.GroupSaves.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupSaves.Size = New System.Drawing.Size(604, 162)
        Me.GroupSaves.TabIndex = 64
        Me.GroupSaves.TabStop = False
        Me.GroupSaves.Text = "Dans la Liste ci dessus, voici les fichiers 'Orphelins' qui n'ont pas de Rom asso" &
    "ciée"
        '
        'ButtonRenommer
        '
        Me.ButtonRenommer.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonRenommer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRenommer.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonRenommer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonRenommer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tan
        Me.ButtonRenommer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRenommer.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRenommer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRenommer.Location = New System.Drawing.Point(676, 444)
        Me.ButtonRenommer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRenommer.Name = "ButtonRenommer"
        Me.ButtonRenommer.Size = New System.Drawing.Size(215, 50)
        Me.ButtonRenommer.TabIndex = 67
        Me.ButtonRenommer.Text = "Ouvrir l'Outil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'Renommer vos Saves'"
        Me.ButtonRenommer.UseVisualStyleBackColor = False
        '
        'prevplatform
        '
        Me.prevplatform.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.prevplatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.prevplatform.Cursor = System.Windows.Forms.Cursors.Default
        Me.prevplatform.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.prevplatform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.prevplatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prevplatform.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevplatform.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prevplatform.Location = New System.Drawing.Point(16, 62)
        Me.prevplatform.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.prevplatform.Name = "prevplatform"
        Me.prevplatform.Size = New System.Drawing.Size(75, 28)
        Me.prevplatform.TabIndex = 66
        Me.prevplatform.Text = "<<"
        Me.prevplatform.UseVisualStyleBackColor = False
        '
        'nextplatform
        '
        Me.nextplatform.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.nextplatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.nextplatform.Cursor = System.Windows.Forms.Cursors.Default
        Me.nextplatform.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.nextplatform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.nextplatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextplatform.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextplatform.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nextplatform.Location = New System.Drawing.Point(96, 62)
        Me.nextplatform.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nextplatform.Name = "nextplatform"
        Me.nextplatform.Size = New System.Drawing.Size(75, 28)
        Me.nextplatform.TabIndex = 67
        Me.nextplatform.Text = ">>"
        Me.nextplatform.UseVisualStyleBackColor = False
        '
        'BatoPict
        '
        Me.BatoPict.Location = New System.Drawing.Point(467, 517)
        Me.BatoPict.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BatoPict.Name = "BatoPict"
        Me.BatoPict.Size = New System.Drawing.Size(192, 139)
        Me.BatoPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BatoPict.TabIndex = 69
        Me.BatoPict.TabStop = False
        '
        'SaveManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1291, 661)
        Me.Controls.Add(Me.RenameSelection)
        Me.Controls.Add(Me.ButtonRenommer)
        Me.Controls.Add(Me.BatoPict)
        Me.Controls.Add(Me.ButtonRomsDeleteSelected)
        Me.Controls.Add(Me.nextplatform)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prevplatform)
        Me.Controls.Add(Me.GroupSaves)
        Me.Controls.Add(Me.GroupRoms)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SaveSingle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SaveTotal)
        Me.Controls.Add(Me.RomTotalSave)
        Me.Controls.Add(Me.ButtonImportSaves1)
        Me.Controls.Add(Me.buttonImportRoms1)
        Me.Controls.Add(Me.RomTotal)
        Me.Controls.Add(Me.ButtonGetBack1)
        Me.Controls.Add(Me.ImportBoth1)
        Me.Controls.Add(Me.DataGridSave)
        Me.Controls.Add(Me.GameLists)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridRoms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(1309, 708)
        Me.MinimumSize = New System.Drawing.Size(1309, 708)
        Me.Name = "SaveManager"
        Me.Text = "SaveManager"
        CType(Me.DataGridSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RenameSelection.ResumeLayout(False)
        Me.RenameSelection.PerformLayout()
        CType(Me.DataGridRoms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupRoms.ResumeLayout(False)
        Me.GroupSaves.ResumeLayout(False)
        Me.GroupSaves.PerformLayout()
        CType(Me.BatoPict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonImportSaves1 As Button
    Friend WithEvents buttonImportRoms1 As Button
    Friend WithEvents ButtonGetBack1 As Button
    Friend WithEvents ImportBoth1 As Button
    Friend WithEvents DataGridSave As DataGridView
    Friend WithEvents GameLists As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RomTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveSingle As TextBox
    Friend WithEvents SaveTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RomTotalSave As TextBox
    Friend WithEvents RenameSelection As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridRoms As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListdesFichiersEnTrop As ListBox
    Friend WithEvents ListSaves As ListBox
    Friend WithEvents ButtonSuppSave As Button
    Friend WithEvents NewName As TextBox
    Friend WithEvents ButtonRenameSave As Button
    Friend WithEvents ButtonMenageOrphelin As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ActualName As TextBox
    Friend WithEvents ButtonRomsDeleteSelected As Button
    Friend WithEvents GroupRoms As GroupBox
    Friend WithEvents GroupSaves As GroupBox
    Friend WithEvents PathActuel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textstate As TextBox
    Friend WithEvents prevplatform As Button
    Friend WithEvents nextplatform As Button
    Friend WithEvents BatoPict As PictureBox
    Friend WithEvents ButtonRenommer As Button
End Class
