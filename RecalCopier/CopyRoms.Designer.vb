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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopyRoms))
        Me.ButtonImportXML = New System.Windows.Forms.Button()
        Me.ListGameLists = New System.Windows.Forms.ListBox()
        Me.lbl_gamelist = New System.Windows.Forms.Label()
        Me.ButtonShowGames = New System.Windows.Forms.Button()
        Me.FinalGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ButtonParcourirRecalCopy = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_CopyFolder = New System.Windows.Forms.TextBox()
        Me.ButtonCopy = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkbios = New System.Windows.Forms.CheckBox()
        Me.checksaves = New System.Windows.Forms.CheckBox()
        Me.checkimgs = New System.Windows.Forms.CheckBox()
        Me.checkoverlays = New System.Windows.Forms.CheckBox()
        Me.checkvideos = New System.Windows.Forms.CheckBox()
        Me.checkmanuals = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.buttonaffichermaselection = New System.Windows.Forms.Button()
        Me.txt_morestant = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_GoAPrevoir = New System.Windows.Forms.Label()
        Me.txt_GoAPrevoir = New System.Windows.Forms.TextBox()
        Me.lbl_romSelected = New System.Windows.Forms.Label()
        Me.txt_NbRomSelected = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_USBGo = New System.Windows.Forms.TextBox()
        Me.Buttongetback = New System.Windows.Forms.Button()
        Me.lbl_bibliorecalbox = New System.Windows.Forms.Label()
        Me.grp_RomInfos = New System.Windows.Forms.GroupBox()
        Me.romsaveo = New System.Windows.Forms.Button()
        Me.romoverlayo = New System.Windows.Forms.Button()
        Me.rommanualo = New System.Windows.Forms.Button()
        Me.romvideoo = New System.Windows.Forms.Button()
        Me.romscreeno = New System.Windows.Forms.Button()
        Me.listboxMaSelection = New System.Windows.Forms.ListBox()
        Me.txt_romdesc = New System.Windows.Forms.RichTextBox()
        Me.txt_rompath = New System.Windows.Forms.TextBox()
        Me.txt_romname = New System.Windows.Forms.TextBox()
        Me.vid_romvid = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RomImage = New System.Windows.Forms.PictureBox()
        Me.txt_txtsearch = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbl_TxtSearch = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.buttonRAZ = New System.Windows.Forms.Button()
        Me.GroupFiltresAvances = New System.Windows.Forms.GroupBox()
        CType(Me.FinalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_RomInfos.SuspendLayout()
        CType(Me.vid_romvid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RomImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonImportXML
        '
        Me.ButtonImportXML.Location = New System.Drawing.Point(15, 7)
        Me.ButtonImportXML.Name = "ButtonImportXML"
        Me.ButtonImportXML.Size = New System.Drawing.Size(206, 30)
        Me.ButtonImportXML.TabIndex = 1
        Me.ButtonImportXML.Text = "Importer les Gamelist.xml"
        Me.ButtonImportXML.UseVisualStyleBackColor = True
        '
        'ListGameLists
        '
        Me.ListGameLists.FormattingEnabled = True
        Me.ListGameLists.Location = New System.Drawing.Point(15, 63)
        Me.ListGameLists.Name = "ListGameLists"
        Me.ListGameLists.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListGameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListGameLists.Size = New System.Drawing.Size(206, 329)
        Me.ListGameLists.TabIndex = 2
        '
        'lbl_gamelist
        '
        Me.lbl_gamelist.AutoSize = True
        Me.lbl_gamelist.Font = New System.Drawing.Font("VAG Rounded", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gamelist.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_gamelist.Location = New System.Drawing.Point(59, 42)
        Me.lbl_gamelist.Name = "lbl_gamelist"
        Me.lbl_gamelist.Size = New System.Drawing.Size(118, 18)
        Me.lbl_gamelist.TabIndex = 3
        Me.lbl_gamelist.Text = "Vos GameLists :"
        '
        'ButtonShowGames
        '
        Me.ButtonShowGames.Location = New System.Drawing.Point(15, 398)
        Me.ButtonShowGames.Name = "ButtonShowGames"
        Me.ButtonShowGames.Size = New System.Drawing.Size(206, 32)
        Me.ButtonShowGames.TabIndex = 4
        Me.ButtonShowGames.Text = "Construire les Systemes Selectionnés"
        Me.ButtonShowGames.UseVisualStyleBackColor = True
        '
        'FinalGrid
        '
        Me.FinalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinalGrid.Location = New System.Drawing.Point(226, 28)
        Me.FinalGrid.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FinalGrid.MultiSelect = False
        Me.FinalGrid.Name = "FinalGrid"
        Me.FinalGrid.RowHeadersWidth = 51
        Me.FinalGrid.RowTemplate.Height = 24
        Me.FinalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FinalGrid.Size = New System.Drawing.Size(382, 402)
        Me.FinalGrid.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.ButtonCopy)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(15, 436)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(990, 92)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actions"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.ButtonParcourirRecalCopy)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txt_CopyFolder)
        Me.GroupBox5.Location = New System.Drawing.Point(699, 17)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(223, 65)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Copie"
        '
        'ButtonParcourirRecalCopy
        '
        Me.ButtonParcourirRecalCopy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonParcourirRecalCopy.Location = New System.Drawing.Point(2, 38)
        Me.ButtonParcourirRecalCopy.Name = "ButtonParcourirRecalCopy"
        Me.ButtonParcourirRecalCopy.Size = New System.Drawing.Size(61, 23)
        Me.ButtonParcourirRecalCopy.TabIndex = 6
        Me.ButtonParcourirRecalCopy.Text = "Parcourir"
        Me.ButtonParcourirRecalCopy.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(64, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 39)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Lettre du Support USB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ou " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dossier où ""recalbox"" sera créé" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_CopyFolder
        '
        Me.txt_CopyFolder.Location = New System.Drawing.Point(2, 16)
        Me.txt_CopyFolder.Name = "txt_CopyFolder"
        Me.txt_CopyFolder.Size = New System.Drawing.Size(61, 20)
        Me.txt_CopyFolder.TabIndex = 0
        Me.txt_CopyFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.Location = New System.Drawing.Point(921, 15)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(69, 72)
        Me.ButtonCopy.TabIndex = 14
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.checkbios)
        Me.GroupBox2.Controls.Add(Me.checksaves)
        Me.GroupBox2.Controls.Add(Me.checkimgs)
        Me.GroupBox2.Controls.Add(Me.checkoverlays)
        Me.GroupBox2.Controls.Add(Me.checkvideos)
        Me.GroupBox2.Controls.Add(Me.checkmanuals)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(121, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 65)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quoi Copier ?"
        '
        'checkbios
        '
        Me.checkbios.AutoSize = True
        Me.checkbios.Checked = True
        Me.checkbios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkbios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkbios.Location = New System.Drawing.Point(6, 19)
        Me.checkbios.Name = "checkbios"
        Me.checkbios.Size = New System.Drawing.Size(46, 17)
        Me.checkbios.TabIndex = 9
        Me.checkbios.Text = "Bios"
        Me.checkbios.UseVisualStyleBackColor = True
        '
        'checksaves
        '
        Me.checksaves.AutoSize = True
        Me.checksaves.Checked = True
        Me.checksaves.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checksaves.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checksaves.Location = New System.Drawing.Point(135, 38)
        Me.checksaves.Name = "checksaves"
        Me.checksaves.Size = New System.Drawing.Size(56, 17)
        Me.checksaves.TabIndex = 8
        Me.checksaves.Text = "Saves"
        Me.checksaves.UseVisualStyleBackColor = True
        '
        'checkimgs
        '
        Me.checkimgs.AutoSize = True
        Me.checkimgs.Checked = True
        Me.checkimgs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkimgs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkimgs.Location = New System.Drawing.Point(70, 19)
        Me.checkimgs.Name = "checkimgs"
        Me.checkimgs.Size = New System.Drawing.Size(60, 17)
        Me.checkimgs.TabIndex = 4
        Me.checkimgs.Text = "Images"
        Me.checkimgs.UseVisualStyleBackColor = True
        '
        'checkoverlays
        '
        Me.checkoverlays.AutoSize = True
        Me.checkoverlays.Checked = True
        Me.checkoverlays.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkoverlays.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkoverlays.Location = New System.Drawing.Point(70, 38)
        Me.checkoverlays.Name = "checkoverlays"
        Me.checkoverlays.Size = New System.Drawing.Size(67, 17)
        Me.checkoverlays.TabIndex = 7
        Me.checkoverlays.Text = "Overlays"
        Me.checkoverlays.UseVisualStyleBackColor = True
        '
        'checkvideos
        '
        Me.checkvideos.AutoSize = True
        Me.checkvideos.Checked = True
        Me.checkvideos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkvideos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkvideos.Location = New System.Drawing.Point(135, 19)
        Me.checkvideos.Name = "checkvideos"
        Me.checkvideos.Size = New System.Drawing.Size(58, 17)
        Me.checkvideos.TabIndex = 5
        Me.checkvideos.Text = "Videos"
        Me.checkvideos.UseVisualStyleBackColor = True
        '
        'checkmanuals
        '
        Me.checkmanuals.AutoSize = True
        Me.checkmanuals.Checked = True
        Me.checkmanuals.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkmanuals.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.checkmanuals.Location = New System.Drawing.Point(6, 38)
        Me.checkmanuals.Name = "checkmanuals"
        Me.checkmanuals.Size = New System.Drawing.Size(66, 17)
        Me.checkmanuals.TabIndex = 6
        Me.checkmanuals.Text = "Manuels"
        Me.checkmanuals.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox4.Controls.Add(Me.buttonaffichermaselection)
        Me.GroupBox4.Controls.Add(Me.txt_morestant)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lbl_GoAPrevoir)
        Me.GroupBox4.Controls.Add(Me.txt_GoAPrevoir)
        Me.GroupBox4.Controls.Add(Me.lbl_romSelected)
        Me.GroupBox4.Controls.Add(Me.txt_NbRomSelected)
        Me.GroupBox4.Location = New System.Drawing.Point(316, 17)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(380, 65)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ma Selection"
        '
        'buttonaffichermaselection
        '
        Me.buttonaffichermaselection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.buttonaffichermaselection.Location = New System.Drawing.Point(219, 10)
        Me.buttonaffichermaselection.Name = "buttonaffichermaselection"
        Me.buttonaffichermaselection.Size = New System.Drawing.Size(159, 23)
        Me.buttonaffichermaselection.TabIndex = 6
        Me.buttonaffichermaselection.Text = "Afficher/Cacher ma Selection"
        Me.buttonaffichermaselection.UseVisualStyleBackColor = True
        '
        'txt_morestant
        '
        Me.txt_morestant.Location = New System.Drawing.Point(153, 42)
        Me.txt_morestant.Name = "txt_morestant"
        Me.txt_morestant.Size = New System.Drawing.Size(79, 20)
        Me.txt_morestant.TabIndex = 5
        Me.txt_morestant.Text = "0"
        Me.txt_morestant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(235, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mo Théorique Restants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Sans Images/Videos etc...)"
        '
        'lbl_GoAPrevoir
        '
        Me.lbl_GoAPrevoir.AutoSize = True
        Me.lbl_GoAPrevoir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_GoAPrevoir.Location = New System.Drawing.Point(83, 45)
        Me.lbl_GoAPrevoir.Name = "lbl_GoAPrevoir"
        Me.lbl_GoAPrevoir.Size = New System.Drawing.Size(64, 13)
        Me.lbl_GoAPrevoir.TabIndex = 3
        Me.lbl_GoAPrevoir.Text = "Mo à Copier"
        '
        'txt_GoAPrevoir
        '
        Me.txt_GoAPrevoir.Location = New System.Drawing.Point(5, 42)
        Me.txt_GoAPrevoir.Name = "txt_GoAPrevoir"
        Me.txt_GoAPrevoir.Size = New System.Drawing.Size(72, 20)
        Me.txt_GoAPrevoir.TabIndex = 2
        Me.txt_GoAPrevoir.Text = "0"
        Me.txt_GoAPrevoir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_romSelected
        '
        Me.lbl_romSelected.AutoSize = True
        Me.lbl_romSelected.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_romSelected.Location = New System.Drawing.Point(83, 20)
        Me.lbl_romSelected.Name = "lbl_romSelected"
        Me.lbl_romSelected.Size = New System.Drawing.Size(102, 13)
        Me.lbl_romSelected.TabIndex = 1
        Me.lbl_romSelected.Text = "Roms selectionnées"
        '
        'txt_NbRomSelected
        '
        Me.txt_NbRomSelected.Location = New System.Drawing.Point(5, 16)
        Me.txt_NbRomSelected.Name = "txt_NbRomSelected"
        Me.txt_NbRomSelected.Size = New System.Drawing.Size(72, 20)
        Me.txt_NbRomSelected.TabIndex = 0
        Me.txt_NbRomSelected.Text = "0"
        Me.txt_NbRomSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_USBGo)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(4, 17)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(112, 65)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ma Carte SD/USB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(76, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Go"
        '
        'txt_USBGo
        '
        Me.txt_USBGo.Location = New System.Drawing.Point(18, 24)
        Me.txt_USBGo.Name = "txt_USBGo"
        Me.txt_USBGo.Size = New System.Drawing.Size(52, 20)
        Me.txt_USBGo.TabIndex = 0
        Me.txt_USBGo.Text = "16"
        Me.txt_USBGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Buttongetback
        '
        Me.Buttongetback.Location = New System.Drawing.Point(15, 532)
        Me.Buttongetback.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Buttongetback.Name = "Buttongetback"
        Me.Buttongetback.Size = New System.Drawing.Size(101, 31)
        Me.Buttongetback.TabIndex = 8
        Me.Buttongetback.Text = "Revenir au Menu"
        Me.Buttongetback.UseVisualStyleBackColor = True
        '
        'lbl_bibliorecalbox
        '
        Me.lbl_bibliorecalbox.AutoSize = True
        Me.lbl_bibliorecalbox.Font = New System.Drawing.Font("VAG Rounded", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bibliorecalbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_bibliorecalbox.Location = New System.Drawing.Point(328, 7)
        Me.lbl_bibliorecalbox.Name = "lbl_bibliorecalbox"
        Me.lbl_bibliorecalbox.Size = New System.Drawing.Size(201, 18)
        Me.lbl_bibliorecalbox.TabIndex = 9
        Me.lbl_bibliorecalbox.Text = "Bibliothèque Selectionnée :"
        '
        'grp_RomInfos
        '
        Me.grp_RomInfos.BackColor = System.Drawing.Color.SkyBlue
        Me.grp_RomInfos.Controls.Add(Me.romsaveo)
        Me.grp_RomInfos.Controls.Add(Me.romoverlayo)
        Me.grp_RomInfos.Controls.Add(Me.rommanualo)
        Me.grp_RomInfos.Controls.Add(Me.romvideoo)
        Me.grp_RomInfos.Controls.Add(Me.romscreeno)
        Me.grp_RomInfos.Controls.Add(Me.listboxMaSelection)
        Me.grp_RomInfos.Controls.Add(Me.txt_romdesc)
        Me.grp_RomInfos.Controls.Add(Me.txt_rompath)
        Me.grp_RomInfos.Controls.Add(Me.txt_romname)
        Me.grp_RomInfos.Controls.Add(Me.vid_romvid)
        Me.grp_RomInfos.Controls.Add(Me.Label2)
        Me.grp_RomInfos.Controls.Add(Me.Label1)
        Me.grp_RomInfos.Controls.Add(Me.RomImage)
        Me.grp_RomInfos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grp_RomInfos.Location = New System.Drawing.Point(612, 28)
        Me.grp_RomInfos.Name = "grp_RomInfos"
        Me.grp_RomInfos.Size = New System.Drawing.Size(393, 402)
        Me.grp_RomInfos.TabIndex = 10
        Me.grp_RomInfos.TabStop = False
        Me.grp_RomInfos.Text = "Rom Infos"
        '
        'romsaveo
        '
        Me.romsaveo.Location = New System.Drawing.Point(329, 344)
        Me.romsaveo.Name = "romsaveo"
        Me.romsaveo.Size = New System.Drawing.Size(57, 55)
        Me.romsaveo.TabIndex = 20
        Me.romsaveo.UseVisualStyleBackColor = True
        '
        'romoverlayo
        '
        Me.romoverlayo.Location = New System.Drawing.Point(242, 344)
        Me.romoverlayo.Name = "romoverlayo"
        Me.romoverlayo.Size = New System.Drawing.Size(57, 55)
        Me.romoverlayo.TabIndex = 19
        Me.romoverlayo.UseVisualStyleBackColor = True
        '
        'rommanualo
        '
        Me.rommanualo.Location = New System.Drawing.Point(163, 344)
        Me.rommanualo.Name = "rommanualo"
        Me.rommanualo.Size = New System.Drawing.Size(57, 55)
        Me.rommanualo.TabIndex = 18
        Me.rommanualo.UseVisualStyleBackColor = True
        '
        'romvideoo
        '
        Me.romvideoo.Location = New System.Drawing.Point(82, 344)
        Me.romvideoo.Name = "romvideoo"
        Me.romvideoo.Size = New System.Drawing.Size(57, 55)
        Me.romvideoo.TabIndex = 17
        Me.romvideoo.UseVisualStyleBackColor = True
        '
        'romscreeno
        '
        Me.romscreeno.Location = New System.Drawing.Point(9, 344)
        Me.romscreeno.Name = "romscreeno"
        Me.romscreeno.Size = New System.Drawing.Size(57, 55)
        Me.romscreeno.TabIndex = 16
        Me.romscreeno.UseVisualStyleBackColor = True
        '
        'listboxMaSelection
        '
        Me.listboxMaSelection.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.listboxMaSelection.ForeColor = System.Drawing.SystemColors.InfoText
        Me.listboxMaSelection.FormattingEnabled = True
        Me.listboxMaSelection.Location = New System.Drawing.Point(242, 58)
        Me.listboxMaSelection.Name = "listboxMaSelection"
        Me.listboxMaSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.listboxMaSelection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listboxMaSelection.Size = New System.Drawing.Size(146, 17)
        Me.listboxMaSelection.TabIndex = 12
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
        Me.vid_romvid.Location = New System.Drawing.Point(6, 186)
        Me.vid_romvid.Name = "vid_romvid"
        Me.vid_romvid.OcxState = CType(resources.GetObject("vid_romvid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vid_romvid.Size = New System.Drawing.Size(227, 139)
        Me.vid_romvid.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(124, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Autres Fichiers de la Rom :"
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
        'txt_txtsearch
        '
        Me.txt_txtsearch.Location = New System.Drawing.Point(203, 407)
        Me.txt_txtsearch.Name = "txt_txtsearch"
        Me.txt_txtsearch.Size = New System.Drawing.Size(177, 20)
        Me.txt_txtsearch.TabIndex = 4
        '
        'lbl_TxtSearch
        '
        Me.lbl_TxtSearch.AutoSize = True
        Me.lbl_TxtSearch.Font = New System.Drawing.Font("VAG Rounded", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TxtSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_TxtSearch.Location = New System.Drawing.Point(16, 412)
        Me.lbl_TxtSearch.Name = "lbl_TxtSearch"
        Me.lbl_TxtSearch.Size = New System.Drawing.Size(183, 15)
        Me.lbl_TxtSearch.TabIndex = 11
        Me.lbl_TxtSearch.Text = "Recherche Romname et Entrée :"
        '
        'Timer1
        '
        '
        'buttonRAZ
        '
        Me.buttonRAZ.Location = New System.Drawing.Point(386, 405)
        Me.buttonRAZ.Name = "buttonRAZ"
        Me.buttonRAZ.Size = New System.Drawing.Size(111, 23)
        Me.buttonRAZ.TabIndex = 12
        Me.buttonRAZ.Text = "RAZ Recherche"
        Me.buttonRAZ.UseVisualStyleBackColor = True
        '
        'GroupFiltresAvances
        '
        Me.GroupFiltresAvances.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.GroupFiltresAvances.Location = New System.Drawing.Point(129, 532)
        Me.GroupFiltresAvances.Name = "GroupFiltresAvances"
        Me.GroupFiltresAvances.Size = New System.Drawing.Size(582, 48)
        Me.GroupFiltresAvances.TabIndex = 13
        Me.GroupFiltresAvances.TabStop = False
        Me.GroupFiltresAvances.Text = "Filtres Avance"
        '
        'CopyRoms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 580)
        Me.Controls.Add(Me.GroupFiltresAvances)
        Me.Controls.Add(Me.buttonRAZ)
        Me.Controls.Add(Me.lbl_TxtSearch)
        Me.Controls.Add(Me.txt_txtsearch)
        Me.Controls.Add(Me.grp_RomInfos)
        Me.Controls.Add(Me.lbl_bibliorecalbox)
        Me.Controls.Add(Me.Buttongetback)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonShowGames)
        Me.Controls.Add(Me.lbl_gamelist)
        Me.Controls.Add(Me.ListGameLists)
        Me.Controls.Add(Me.ButtonImportXML)
        Me.Controls.Add(Me.FinalGrid)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(1034, 619)
        Me.MinimumSize = New System.Drawing.Size(1034, 619)
        Me.Name = "CopyRoms"
        Me.Text = "CopyRoms"
        CType(Me.FinalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_RomInfos.ResumeLayout(False)
        Me.grp_RomInfos.PerformLayout()
        CType(Me.vid_romvid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RomImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonImportXML As Button
    Friend WithEvents ListGameLists As ListBox
    Friend WithEvents lbl_gamelist As Label
    Friend WithEvents ButtonShowGames As Button
    Friend WithEvents FinalGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Buttongetback As Button
    Friend WithEvents lbl_bibliorecalbox As Label
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents vid_romvid As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents txt_rompath As TextBox
    Friend WithEvents txt_romname As TextBox
    Friend WithEvents txt_romdesc As RichTextBox
    Friend WithEvents txt_txtsearch As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ButtonParcourirRecalCopy As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_CopyFolder As TextBox
    Friend WithEvents ButtonCopy As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents checkbios As CheckBox
    Friend WithEvents checksaves As CheckBox
    Friend WithEvents checkimgs As CheckBox
    Friend WithEvents checkoverlays As CheckBox
    Friend WithEvents checkvideos As CheckBox
    Friend WithEvents checkmanuals As CheckBox
    Friend WithEvents txt_morestant As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lbl_TxtSearch As Label
    Friend WithEvents listboxMaSelection As ListBox
    Friend WithEvents buttonaffichermaselection As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents buttonRAZ As Button
    Friend WithEvents romscreeno As Button
    Friend WithEvents romsaveo As Button
    Friend WithEvents romoverlayo As Button
    Friend WithEvents rommanualo As Button
    Friend WithEvents romvideoo As Button
    Friend WithEvents GroupFiltresAvances As GroupBox
End Class
