<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CopyRoms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyRoms))
        Me.ButtonImportXML = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbl_gamelist = New System.Windows.Forms.Label()
        Me.ButtonShowGames = New System.Windows.Forms.Button()
        Me.TempGrid = New System.Windows.Forms.DataGridView()
        Me.FinalGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbl_GoAPrevoir = New System.Windows.Forms.Label()
        Me.txt_GoAPrevoir = New System.Windows.Forms.TextBox()
        Me.lbl_romSelected = New System.Windows.Forms.Label()
        Me.txt_NbRomSelected = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_USBGo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.combo_console = New System.Windows.Forms.ComboBox()
        Me.txt_console = New System.Windows.Forms.Button()
        Me.Buttongetback = New System.Windows.Forms.Button()
        Me.lbl_bibliorecalbox = New System.Windows.Forms.Label()
        Me.grp_RomInfos = New System.Windows.Forms.GroupBox()
        Me.txt_romdesc = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_rompath = New System.Windows.Forms.TextBox()
        Me.txt_romname = New System.Windows.Forms.TextBox()
        Me.vid_romvid = New AxWMPLib.AxWindowsMediaPlayer()
        Me.romscreen = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.romsave = New System.Windows.Forms.PictureBox()
        Me.romoverlay = New System.Windows.Forms.PictureBox()
        Me.rommanual = New System.Windows.Forms.PictureBox()
        Me.romvideo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RomImage = New System.Windows.Forms.PictureBox()
        Me.txt_TotalRoms = New System.Windows.Forms.TextBox()
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_RomInfos.SuspendLayout()
        CType(Me.vid_romvid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.romscreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.romsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.romoverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rommanual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.romvideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RomImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonImportXML
        '
        Me.ButtonImportXML.Location = New System.Drawing.Point(54, 7)
        Me.ButtonImportXML.Name = "ButtonImportXML"
        Me.ButtonImportXML.Size = New System.Drawing.Size(132, 30)
        Me.ButtonImportXML.TabIndex = 1
        Me.ButtonImportXML.Text = "Importer les Gamelist.xml"
        Me.ButtonImportXML.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(206, 329)
        Me.ListBox1.TabIndex = 2
        '
        'lbl_gamelist
        '
        Me.lbl_gamelist.AutoSize = True
        Me.lbl_gamelist.Font = New System.Drawing.Font("VAG Rounded", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gamelist.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_gamelist.Location = New System.Drawing.Point(51, 44)
        Me.lbl_gamelist.Name = "lbl_gamelist"
        Me.lbl_gamelist.Size = New System.Drawing.Size(135, 15)
        Me.lbl_gamelist.TabIndex = 3
        Me.lbl_gamelist.Text = "Chemin des GameLists"
        '
        'ButtonShowGames
        '
        Me.ButtonShowGames.Location = New System.Drawing.Point(48, 398)
        Me.ButtonShowGames.Name = "ButtonShowGames"
        Me.ButtonShowGames.Size = New System.Drawing.Size(146, 32)
        Me.ButtonShowGames.TabIndex = 4
        Me.ButtonShowGames.Text = "Construire la Bibliothèque"
        Me.ButtonShowGames.UseVisualStyleBackColor = True
        '
        'TempGrid
        '
        Me.TempGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TempGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TempGrid.Location = New System.Drawing.Point(225, 28)
        Me.TempGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.TempGrid.Name = "TempGrid"
        Me.TempGrid.RowHeadersWidth = 51
        Me.TempGrid.RowTemplate.Height = 24
        Me.TempGrid.Size = New System.Drawing.Size(382, 30)
        Me.TempGrid.TabIndex = 5
        '
        'FinalGrid
        '
        Me.FinalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinalGrid.Location = New System.Drawing.Point(226, 63)
        Me.FinalGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.FinalGrid.MultiSelect = False
        Me.FinalGrid.Name = "FinalGrid"
        Me.FinalGrid.RowHeadersWidth = 51
        Me.FinalGrid.RowTemplate.Height = 24
        Me.FinalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FinalGrid.Size = New System.Drawing.Size(382, 367)
        Me.FinalGrid.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(15, 436)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(990, 92)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outils"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.lbl_GoAPrevoir)
        Me.GroupBox4.Controls.Add(Me.txt_GoAPrevoir)
        Me.GroupBox4.Controls.Add(Me.lbl_romSelected)
        Me.GroupBox4.Controls.Add(Me.txt_NbRomSelected)
        Me.GroupBox4.Location = New System.Drawing.Point(301, 14)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(514, 65)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selection"
        '
        'lbl_GoAPrevoir
        '
        Me.lbl_GoAPrevoir.AutoSize = True
        Me.lbl_GoAPrevoir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_GoAPrevoir.Location = New System.Drawing.Point(409, 36)
        Me.lbl_GoAPrevoir.Name = "lbl_GoAPrevoir"
        Me.lbl_GoAPrevoir.Size = New System.Drawing.Size(66, 13)
        Me.lbl_GoAPrevoir.TabIndex = 3
        Me.lbl_GoAPrevoir.Text = "Go à Prévoir"
        '
        'txt_GoAPrevoir
        '
        Me.txt_GoAPrevoir.Location = New System.Drawing.Point(342, 33)
        Me.txt_GoAPrevoir.Name = "txt_GoAPrevoir"
        Me.txt_GoAPrevoir.Size = New System.Drawing.Size(61, 20)
        Me.txt_GoAPrevoir.TabIndex = 2
        Me.txt_GoAPrevoir.Text = "0"
        Me.txt_GoAPrevoir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_romSelected
        '
        Me.lbl_romSelected.AutoSize = True
        Me.lbl_romSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_romSelected.Location = New System.Drawing.Point(409, 8)
        Me.lbl_romSelected.Name = "lbl_romSelected"
        Me.lbl_romSelected.Size = New System.Drawing.Size(104, 13)
        Me.lbl_romSelected.TabIndex = 1
        Me.lbl_romSelected.Text = "Roms Selectionnées"
        '
        'txt_NbRomSelected
        '
        Me.txt_NbRomSelected.Location = New System.Drawing.Point(342, 3)
        Me.txt_NbRomSelected.Name = "txt_NbRomSelected"
        Me.txt_NbRomSelected.Size = New System.Drawing.Size(61, 20)
        Me.txt_NbRomSelected.TabIndex = 0
        Me.txt_NbRomSelected.Text = "0"
        Me.txt_NbRomSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_USBGo)
        Me.GroupBox3.Location = New System.Drawing.Point(155, 17)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(109, 65)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ma Carte SD/USB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(33, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Taille (Go)"
        '
        'txt_USBGo
        '
        Me.txt_USBGo.Location = New System.Drawing.Point(36, 18)
        Me.txt_USBGo.Name = "txt_USBGo"
        Me.txt_USBGo.Size = New System.Drawing.Size(52, 20)
        Me.txt_USBGo.TabIndex = 0
        Me.txt_USBGo.Text = "16"
        Me.txt_USBGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.combo_console)
        Me.GroupBox2.Controls.Add(Me.txt_console)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 17)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(127, 65)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtres Bibliotheque"
        '
        'combo_console
        '
        Me.combo_console.FormattingEnabled = True
        Me.combo_console.Location = New System.Drawing.Point(4, 17)
        Me.combo_console.Margin = New System.Windows.Forms.Padding(2)
        Me.combo_console.Name = "combo_console"
        Me.combo_console.Size = New System.Drawing.Size(110, 21)
        Me.combo_console.TabIndex = 1
        '
        'txt_console
        '
        Me.txt_console.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_console.Location = New System.Drawing.Point(4, 41)
        Me.txt_console.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_console.Name = "txt_console"
        Me.txt_console.Size = New System.Drawing.Size(110, 19)
        Me.txt_console.TabIndex = 0
        Me.txt_console.Text = "Filtrer par Console"
        Me.txt_console.UseVisualStyleBackColor = True
        '
        'Buttongetback
        '
        Me.Buttongetback.Location = New System.Drawing.Point(15, 532)
        Me.Buttongetback.Margin = New System.Windows.Forms.Padding(2)
        Me.Buttongetback.Name = "Buttongetback"
        Me.Buttongetback.Size = New System.Drawing.Size(101, 31)
        Me.Buttongetback.TabIndex = 8
        Me.Buttongetback.Text = "Revenir au Menu"
        Me.Buttongetback.UseVisualStyleBackColor = True
        '
        'lbl_bibliorecalbox
        '
        Me.lbl_bibliorecalbox.AutoSize = True
        Me.lbl_bibliorecalbox.Font = New System.Drawing.Font("VAG Rounded", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bibliorecalbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_bibliorecalbox.Location = New System.Drawing.Point(349, 7)
        Me.lbl_bibliorecalbox.Name = "lbl_bibliorecalbox"
        Me.lbl_bibliorecalbox.Size = New System.Drawing.Size(130, 15)
        Me.lbl_bibliorecalbox.TabIndex = 9
        Me.lbl_bibliorecalbox.Text = "Bibliotheque Recalbox"
        '
        'grp_RomInfos
        '
        Me.grp_RomInfos.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grp_RomInfos.Controls.Add(Me.txt_romdesc)
        Me.grp_RomInfos.Controls.Add(Me.Label4)
        Me.grp_RomInfos.Controls.Add(Me.txt_rompath)
        Me.grp_RomInfos.Controls.Add(Me.txt_romname)
        Me.grp_RomInfos.Controls.Add(Me.vid_romvid)
        Me.grp_RomInfos.Controls.Add(Me.romscreen)
        Me.grp_RomInfos.Controls.Add(Me.Label2)
        Me.grp_RomInfos.Controls.Add(Me.romsave)
        Me.grp_RomInfos.Controls.Add(Me.romoverlay)
        Me.grp_RomInfos.Controls.Add(Me.rommanual)
        Me.grp_RomInfos.Controls.Add(Me.romvideo)
        Me.grp_RomInfos.Controls.Add(Me.Label1)
        Me.grp_RomInfos.Controls.Add(Me.RomImage)
        Me.grp_RomInfos.Location = New System.Drawing.Point(612, 28)
        Me.grp_RomInfos.Name = "grp_RomInfos"
        Me.grp_RomInfos.Size = New System.Drawing.Size(393, 402)
        Me.grp_RomInfos.TabIndex = 10
        Me.grp_RomInfos.TabStop = False
        Me.grp_RomInfos.Text = "Rom Infos"
        '
        'txt_romdesc
        '
        Me.txt_romdesc.Location = New System.Drawing.Point(242, 75)
        Me.txt_romdesc.Name = "txt_romdesc"
        Me.txt_romdesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_romdesc.Size = New System.Drawing.Size(145, 250)
        Me.txt_romdesc.TabIndex = 15
        Me.txt_romdesc.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(35, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "2x Clic pour Ouvrir le Screen"
        '
        'txt_rompath
        '
        Me.txt_rompath.BackColor = System.Drawing.SystemColors.Info
        Me.txt_rompath.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rompath.Location = New System.Drawing.Point(5, 40)
        Me.txt_rompath.Name = "txt_rompath"
        Me.txt_rompath.Size = New System.Drawing.Size(382, 15)
        Me.txt_rompath.TabIndex = 14
        '
        'txt_romname
        '
        Me.txt_romname.Font = New System.Drawing.Font("VAG Rounded", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_romname.Location = New System.Drawing.Point(5, 11)
        Me.txt_romname.Name = "txt_romname"
        Me.txt_romname.Size = New System.Drawing.Size(382, 29)
        Me.txt_romname.TabIndex = 13
        Me.txt_romname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vid_romvid
        '
        Me.vid_romvid.Enabled = True
        Me.vid_romvid.Location = New System.Drawing.Point(6, 200)
        Me.vid_romvid.Name = "vid_romvid"
        Me.vid_romvid.OcxState = CType(resources.GetObject("vid_romvid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vid_romvid.Size = New System.Drawing.Size(227, 125)
        Me.vid_romvid.TabIndex = 12
        '
        'romscreen
        '
        Me.romscreen.Image = CType(resources.GetObject("romscreen.Image"), System.Drawing.Image)
        Me.romscreen.Location = New System.Drawing.Point(7, 344)
        Me.romscreen.Name = "romscreen"
        Me.romscreen.Size = New System.Drawing.Size(48, 52)
        Me.romscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.romscreen.TabIndex = 10
        Me.romscreen.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Autres Fichiers de la Rom :"
        '
        'romsave
        '
        Me.romsave.Image = CType(resources.GetObject("romsave.Image"), System.Drawing.Image)
        Me.romsave.Location = New System.Drawing.Point(330, 344)
        Me.romsave.Name = "romsave"
        Me.romsave.Size = New System.Drawing.Size(48, 52)
        Me.romsave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.romsave.TabIndex = 7
        Me.romsave.TabStop = False
        '
        'romoverlay
        '
        Me.romoverlay.Image = CType(resources.GetObject("romoverlay.Image"), System.Drawing.Image)
        Me.romoverlay.Location = New System.Drawing.Point(239, 344)
        Me.romoverlay.Name = "romoverlay"
        Me.romoverlay.Size = New System.Drawing.Size(48, 52)
        Me.romoverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.romoverlay.TabIndex = 6
        Me.romoverlay.TabStop = False
        '
        'rommanual
        '
        Me.rommanual.Image = CType(resources.GetObject("rommanual.Image"), System.Drawing.Image)
        Me.rommanual.Location = New System.Drawing.Point(157, 344)
        Me.rommanual.Name = "rommanual"
        Me.rommanual.Size = New System.Drawing.Size(48, 52)
        Me.rommanual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rommanual.TabIndex = 5
        Me.rommanual.TabStop = False
        '
        'romvideo
        '
        Me.romvideo.Image = CType(resources.GetObject("romvideo.Image"), System.Drawing.Image)
        Me.romvideo.Location = New System.Drawing.Point(79, 344)
        Me.romvideo.Name = "romvideo"
        Me.romvideo.Size = New System.Drawing.Size(48, 52)
        Me.romvideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.romvideo.TabIndex = 4
        Me.romvideo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Synopsis :"
        '
        'RomImage
        '
        Me.RomImage.Image = CType(resources.GetObject("RomImage.Image"), System.Drawing.Image)
        Me.RomImage.InitialImage = Nothing
        Me.RomImage.Location = New System.Drawing.Point(6, 58)
        Me.RomImage.Name = "RomImage"
        Me.RomImage.Size = New System.Drawing.Size(227, 122)
        Me.RomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RomImage.TabIndex = 0
        Me.RomImage.TabStop = False
        '
        'txt_TotalRoms
        '
        Me.txt_TotalRoms.Location = New System.Drawing.Point(507, 3)
        Me.txt_TotalRoms.Name = "txt_TotalRoms"
        Me.txt_TotalRoms.Size = New System.Drawing.Size(100, 20)
        Me.txt_TotalRoms.TabIndex = 4
        '
        'CopyRoms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1017, 574)
        Me.Controls.Add(Me.txt_TotalRoms)
        Me.Controls.Add(Me.grp_RomInfos)
        Me.Controls.Add(Me.lbl_bibliorecalbox)
        Me.Controls.Add(Me.Buttongetback)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TempGrid)
        Me.Controls.Add(Me.ButtonShowGames)
        Me.Controls.Add(Me.lbl_gamelist)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonImportXML)
        Me.Controls.Add(Me.FinalGrid)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CopyRoms"
        Me.Text = "CopyRoms"
        CType(Me.TempGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_RomInfos.ResumeLayout(False)
        Me.grp_RomInfos.PerformLayout()
        CType(Me.vid_romvid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.romscreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.romsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.romoverlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rommanual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.romvideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonImportXML As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lbl_gamelist As Label
    Friend WithEvents ButtonShowGames As Button
    Friend WithEvents TempGrid As DataGridView
    Friend WithEvents FinalGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Buttongetback As Button
    Friend WithEvents lbl_bibliorecalbox As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents combo_console As ComboBox
    Friend WithEvents txt_console As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_GoAPrevoir As Label
    Friend WithEvents txt_GoAPrevoir As TextBox
    Friend WithEvents lbl_romSelected As Label
    Friend WithEvents txt_NbRomSelected As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_USBGo As TextBox
    Friend WithEvents grp_RomInfos As GroupBox
    Friend WithEvents RomImage As PictureBox
    Friend WithEvents romscreen As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents romsave As PictureBox
    Friend WithEvents romoverlay As PictureBox
    Friend WithEvents rommanual As PictureBox
    Friend WithEvents romvideo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents vid_romvid As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents txt_rompath As TextBox
    Friend WithEvents txt_romname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_romdesc As RichTextBox
    Friend WithEvents txt_TotalRoms As TextBox
End Class
