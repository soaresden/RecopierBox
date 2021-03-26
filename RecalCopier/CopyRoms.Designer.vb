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
        Me.ListGameLists = New System.Windows.Forms.ListBox()
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
        Me.lbl_GoAPrevoir = New System.Windows.Forms.Label()
        Me.txt_GoAPrevoir = New System.Windows.Forms.TextBox()
        Me.lbl_romSelected = New System.Windows.Forms.Label()
        Me.txt_NbRomSelected = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_morestant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_USBGo = New System.Windows.Forms.TextBox()
        Me.TutoHideBoutonCopy = New System.Windows.Forms.PictureBox()
        Me.TutoHideOuCopier = New System.Windows.Forms.PictureBox()
        Me.TutoHideQuoiCopier = New System.Windows.Forms.PictureBox()
        Me.TutoHideSelectionIndic = New System.Windows.Forms.PictureBox()
        Me.TutoHideUSB = New System.Windows.Forms.PictureBox()
        Me.ButtonAfficherMaSelection = New System.Windows.Forms.Button()
        Me.grp_RomInfos = New System.Windows.Forms.GroupBox()
        Me.listboxMaSelection = New System.Windows.Forms.ListBox()
        Me.ButtonSonVid = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelSelection = New System.Windows.Forms.Label()
        Me.txt_romname = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.romsaveo = New System.Windows.Forms.Button()
        Me.romoverlayo = New System.Windows.Forms.Button()
        Me.rommanualo = New System.Windows.Forms.Button()
        Me.romvideoo = New System.Windows.Forms.Button()
        Me.romscreeno = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RomImage = New System.Windows.Forms.PictureBox()
        Me.txt_romdesc = New System.Windows.Forms.RichTextBox()
        Me.txt_rompath = New System.Windows.Forms.TextBox()
        Me.vid_romvid = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_txtsearch = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupFiltresAvances = New System.Windows.Forms.GroupBox()
        Me.ButtonRazClickk = New System.Windows.Forms.Button()
        Me.ButtonHideColumn = New System.Windows.Forms.Button()
        Me.ButtonShowColonne = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.listconsoleselected = New System.Windows.Forms.ListBox()
        Me.txtShownRoms = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nbrom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboFiltreColonnes = New System.Windows.Forms.ComboBox()
        Me.CheckBoxARRM = New System.Windows.Forms.CheckBox()
        Me.ButtonGetBack = New System.Windows.Forms.Button()
        Me.ButtonTuto1 = New System.Windows.Forms.Button()
        Me.ButtonGenererList = New System.Windows.Forms.Button()
        Me.TutoHideGameList = New System.Windows.Forms.PictureBox()
        Me.TutoHideRomInfo = New System.Windows.Forms.PictureBox()
        Me.TutoHideFinalGrid = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupMode = New System.Windows.Forms.GroupBox()
        Me.ChkAvance = New System.Windows.Forms.CheckBox()
        Me.ChkSimple = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSelectionRoms = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ButtonCollection = New System.Windows.Forms.Button()
        Me.TutoHideSimpleMode = New System.Windows.Forms.PictureBox()
        Me.TutoHideFiltresAvance = New System.Windows.Forms.PictureBox()
        Me.TutoSelectionActuelle = New System.Windows.Forms.PictureBox()
        Me.GroupCollections = New System.Windows.Forms.GroupBox()
        Me.ButtonAddCollection = New System.Windows.Forms.Button()
        Me.ButtonRemoveFromCollection = New System.Windows.Forms.Button()
        Me.AjoutCollection = New System.Windows.Forms.Button()
        Me.SaveCollection = New System.Windows.Forms.Button()
        Me.SupCollection = New System.Windows.Forms.Button()
        Me.CollectionGrid = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboCollection = New System.Windows.Forms.ComboBox()
        CType(Me.FinalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TutoHideBoutonCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideOuCopier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideQuoiCopier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideSelectionIndic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideUSB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_RomInfos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.RomImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vid_romvid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFiltresAvances.SuspendLayout()
        CType(Me.TutoHideGameList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideRomInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideFinalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupMode.SuspendLayout()
        Me.GroupBoxSelectionRoms.SuspendLayout()
        CType(Me.TutoHideSimpleMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideFiltresAvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoSelectionActuelle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCollections.SuspendLayout()
        CType(Me.CollectionGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListGameLists
        '
        Me.ListGameLists.FormattingEnabled = True
        Me.ListGameLists.Location = New System.Drawing.Point(15, 50)
        Me.ListGameLists.Name = "ListGameLists"
        Me.ListGameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListGameLists.Size = New System.Drawing.Size(206, 303)
        Me.ListGameLists.TabIndex = 2
        '
        'FinalGrid
        '
        Me.FinalGrid.AllowUserToAddRows = False
        Me.FinalGrid.AllowUserToDeleteRows = False
        Me.FinalGrid.AllowUserToOrderColumns = True
        Me.FinalGrid.AllowUserToResizeRows = False
        Me.FinalGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.FinalGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FinalGrid.Location = New System.Drawing.Point(226, 28)
        Me.FinalGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.FinalGrid.MultiSelect = False
        Me.FinalGrid.Name = "FinalGrid"
        Me.FinalGrid.ReadOnly = True
        Me.FinalGrid.RowHeadersVisible = False
        Me.FinalGrid.RowHeadersWidth = 51
        Me.FinalGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.FinalGrid.RowTemplate.Height = 24
        Me.FinalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FinalGrid.Size = New System.Drawing.Size(382, 365)
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
        Me.GroupBox1.Location = New System.Drawing.Point(137, 508)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(868, 92)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opérations :"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.ButtonParcourirRecalCopy)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txt_CopyFolder)
        Me.GroupBox5.Location = New System.Drawing.Point(561, 16)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(223, 70)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Repertoire Final de Copie :"
        '
        'ButtonParcourirRecalCopy
        '
        Me.ButtonParcourirRecalCopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.ButtonParcourirRecalCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonParcourirRecalCopy.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonParcourirRecalCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonParcourirRecalCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ButtonParcourirRecalCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonParcourirRecalCopy.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParcourirRecalCopy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonParcourirRecalCopy.Location = New System.Drawing.Point(157, 41)
        Me.ButtonParcourirRecalCopy.Name = "ButtonParcourirRecalCopy"
        Me.ButtonParcourirRecalCopy.Size = New System.Drawing.Size(61, 25)
        Me.ButtonParcourirRecalCopy.TabIndex = 40
        Me.ButtonParcourirRecalCopy.Text = "Parcourir"
        Me.ButtonParcourirRecalCopy.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(5, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Dossier où le dossier final sera créé :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_CopyFolder
        '
        Me.txt_CopyFolder.Location = New System.Drawing.Point(5, 43)
        Me.txt_CopyFolder.Name = "txt_CopyFolder"
        Me.txt_CopyFolder.Size = New System.Drawing.Size(146, 20)
        Me.txt_CopyFolder.TabIndex = 0
        Me.txt_CopyFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.Location = New System.Drawing.Point(793, 15)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(69, 72)
        Me.ButtonCopy.TabIndex = 14
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.checkbios)
        Me.GroupBox2.Controls.Add(Me.checksaves)
        Me.GroupBox2.Controls.Add(Me.checkimgs)
        Me.GroupBox2.Controls.Add(Me.checkoverlays)
        Me.GroupBox2.Controls.Add(Me.checkvideos)
        Me.GroupBox2.Controls.Add(Me.checkmanuals)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(360, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 70)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quoi Copier ?"
        '
        'checkbios
        '
        Me.checkbios.AutoSize = True
        Me.checkbios.Checked = True
        Me.checkbios.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkbios.ForeColor = System.Drawing.Color.Maroon
        Me.checkbios.Location = New System.Drawing.Point(66, 50)
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
        Me.checksaves.ForeColor = System.Drawing.Color.Blue
        Me.checksaves.Location = New System.Drawing.Point(102, 33)
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
        Me.checkimgs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.checkimgs.Location = New System.Drawing.Point(4, 16)
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
        Me.checkoverlays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.checkoverlays.Location = New System.Drawing.Point(122, 16)
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
        Me.checkvideos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.checkvideos.Location = New System.Drawing.Point(66, 16)
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
        Me.checkmanuals.ForeColor = System.Drawing.Color.Blue
        Me.checkmanuals.Location = New System.Drawing.Point(37, 33)
        Me.checkmanuals.Name = "checkmanuals"
        Me.checkmanuals.Size = New System.Drawing.Size(66, 17)
        Me.checkmanuals.TabIndex = 6
        Me.checkmanuals.Text = "Manuels"
        Me.checkmanuals.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.lbl_GoAPrevoir)
        Me.GroupBox4.Controls.Add(Me.txt_GoAPrevoir)
        Me.GroupBox4.Controls.Add(Me.lbl_romSelected)
        Me.GroupBox4.Controls.Add(Me.txt_NbRomSelected)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(177, 17)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(173, 70)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ma Selection"
        '
        'lbl_GoAPrevoir
        '
        Me.lbl_GoAPrevoir.AutoSize = True
        Me.lbl_GoAPrevoir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_GoAPrevoir.Location = New System.Drawing.Point(64, 46)
        Me.lbl_GoAPrevoir.Name = "lbl_GoAPrevoir"
        Me.lbl_GoAPrevoir.Size = New System.Drawing.Size(64, 13)
        Me.lbl_GoAPrevoir.TabIndex = 3
        Me.lbl_GoAPrevoir.Text = "Mo à Copier"
        '
        'txt_GoAPrevoir
        '
        Me.txt_GoAPrevoir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GoAPrevoir.Location = New System.Drawing.Point(5, 42)
        Me.txt_GoAPrevoir.Name = "txt_GoAPrevoir"
        Me.txt_GoAPrevoir.ReadOnly = True
        Me.txt_GoAPrevoir.Size = New System.Drawing.Size(58, 22)
        Me.txt_GoAPrevoir.TabIndex = 2
        Me.txt_GoAPrevoir.Text = "0"
        Me.txt_GoAPrevoir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_romSelected
        '
        Me.lbl_romSelected.AutoSize = True
        Me.lbl_romSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_romSelected.Location = New System.Drawing.Point(64, 19)
        Me.lbl_romSelected.Name = "lbl_romSelected"
        Me.lbl_romSelected.Size = New System.Drawing.Size(104, 13)
        Me.lbl_romSelected.TabIndex = 1
        Me.lbl_romSelected.Text = "Roms Selectionnées"
        '
        'txt_NbRomSelected
        '
        Me.txt_NbRomSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NbRomSelected.Location = New System.Drawing.Point(5, 16)
        Me.txt_NbRomSelected.Name = "txt_NbRomSelected"
        Me.txt_NbRomSelected.ReadOnly = True
        Me.txt_NbRomSelected.Size = New System.Drawing.Size(58, 22)
        Me.txt_NbRomSelected.TabIndex = 0
        Me.txt_NbRomSelected.Text = "0"
        Me.txt_NbRomSelected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_morestant)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_USBGo)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(11, 17)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(158, 70)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Taille USB :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(86, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mo Restants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_morestant
        '
        Me.txt_morestant.Location = New System.Drawing.Point(15, 45)
        Me.txt_morestant.Name = "txt_morestant"
        Me.txt_morestant.ReadOnly = True
        Me.txt_morestant.Size = New System.Drawing.Size(65, 20)
        Me.txt_morestant.TabIndex = 5
        Me.txt_morestant.Text = "10240"
        Me.txt_morestant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(86, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Go"
        '
        'txt_USBGo
        '
        Me.txt_USBGo.Location = New System.Drawing.Point(15, 16)
        Me.txt_USBGo.Name = "txt_USBGo"
        Me.txt_USBGo.Size = New System.Drawing.Size(65, 20)
        Me.txt_USBGo.TabIndex = 0
        Me.txt_USBGo.Text = "128"
        Me.txt_USBGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TutoHideBoutonCopy
        '
        Me.TutoHideBoutonCopy.Location = New System.Drawing.Point(839, 4)
        Me.TutoHideBoutonCopy.Name = "TutoHideBoutonCopy"
        Me.TutoHideBoutonCopy.Size = New System.Drawing.Size(32, 23)
        Me.TutoHideBoutonCopy.TabIndex = 30
        Me.TutoHideBoutonCopy.TabStop = False
        '
        'TutoHideOuCopier
        '
        Me.TutoHideOuCopier.Location = New System.Drawing.Point(725, 4)
        Me.TutoHideOuCopier.Name = "TutoHideOuCopier"
        Me.TutoHideOuCopier.Size = New System.Drawing.Size(87, 23)
        Me.TutoHideOuCopier.TabIndex = 26
        Me.TutoHideOuCopier.TabStop = False
        '
        'TutoHideQuoiCopier
        '
        Me.TutoHideQuoiCopier.Location = New System.Drawing.Point(657, 4)
        Me.TutoHideQuoiCopier.Name = "TutoHideQuoiCopier"
        Me.TutoHideQuoiCopier.Size = New System.Drawing.Size(62, 23)
        Me.TutoHideQuoiCopier.TabIndex = 27
        Me.TutoHideQuoiCopier.TabStop = False
        '
        'TutoHideSelectionIndic
        '
        Me.TutoHideSelectionIndic.Location = New System.Drawing.Point(617, 4)
        Me.TutoHideSelectionIndic.Name = "TutoHideSelectionIndic"
        Me.TutoHideSelectionIndic.Size = New System.Drawing.Size(34, 23)
        Me.TutoHideSelectionIndic.TabIndex = 28
        Me.TutoHideSelectionIndic.TabStop = False
        '
        'TutoHideUSB
        '
        Me.TutoHideUSB.Location = New System.Drawing.Point(583, 4)
        Me.TutoHideUSB.Name = "TutoHideUSB"
        Me.TutoHideUSB.Size = New System.Drawing.Size(28, 23)
        Me.TutoHideUSB.TabIndex = 23
        Me.TutoHideUSB.TabStop = False
        '
        'ButtonAfficherMaSelection
        '
        Me.ButtonAfficherMaSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ButtonAfficherMaSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonAfficherMaSelection.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonAfficherMaSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonAfficherMaSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonAfficherMaSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAfficherMaSelection.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAfficherMaSelection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAfficherMaSelection.Image = CType(resources.GetObject("ButtonAfficherMaSelection.Image"), System.Drawing.Image)
        Me.ButtonAfficherMaSelection.Location = New System.Drawing.Point(8, 19)
        Me.ButtonAfficherMaSelection.Name = "ButtonAfficherMaSelection"
        Me.ButtonAfficherMaSelection.Size = New System.Drawing.Size(50, 49)
        Me.ButtonAfficherMaSelection.TabIndex = 39
        Me.ButtonAfficherMaSelection.UseVisualStyleBackColor = False
        '
        'grp_RomInfos
        '
        Me.grp_RomInfos.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.grp_RomInfos.Controls.Add(Me.listboxMaSelection)
        Me.grp_RomInfos.Controls.Add(Me.ButtonSonVid)
        Me.grp_RomInfos.Controls.Add(Me.Panel1)
        Me.grp_RomInfos.Controls.Add(Me.GroupBox6)
        Me.grp_RomInfos.Controls.Add(Me.RomImage)
        Me.grp_RomInfos.Controls.Add(Me.txt_romdesc)
        Me.grp_RomInfos.Controls.Add(Me.txt_rompath)
        Me.grp_RomInfos.Controls.Add(Me.vid_romvid)
        Me.grp_RomInfos.Controls.Add(Me.Label1)
        Me.grp_RomInfos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_RomInfos.Location = New System.Drawing.Point(612, 28)
        Me.grp_RomInfos.Name = "grp_RomInfos"
        Me.grp_RomInfos.Size = New System.Drawing.Size(393, 475)
        Me.grp_RomInfos.TabIndex = 10
        Me.grp_RomInfos.TabStop = False
        Me.grp_RomInfos.Text = "Rom Infos"
        '
        'listboxMaSelection
        '
        Me.listboxMaSelection.BackColor = System.Drawing.Color.Navy
        Me.listboxMaSelection.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.listboxMaSelection.FormattingEnabled = True
        Me.listboxMaSelection.Location = New System.Drawing.Point(184, 55)
        Me.listboxMaSelection.Name = "listboxMaSelection"
        Me.listboxMaSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.listboxMaSelection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listboxMaSelection.Size = New System.Drawing.Size(203, 17)
        Me.listboxMaSelection.TabIndex = 12
        '
        'ButtonSonVid
        '
        Me.ButtonSonVid.BackColor = System.Drawing.Color.White
        Me.ButtonSonVid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSonVid.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonSonVid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonSonVid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.ButtonSonVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSonVid.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSonVid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSonVid.Location = New System.Drawing.Point(66, 194)
        Me.ButtonSonVid.Name = "ButtonSonVid"
        Me.ButtonSonVid.Size = New System.Drawing.Size(52, 49)
        Me.ButtonSonVid.TabIndex = 40
        Me.ButtonSonVid.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelSelection)
        Me.Panel1.Controls.Add(Me.txt_romname)
        Me.Panel1.Location = New System.Drawing.Point(5, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 26)
        Me.Panel1.TabIndex = 23
        '
        'LabelSelection
        '
        Me.LabelSelection.AutoSize = True
        Me.LabelSelection.Font = New System.Drawing.Font("VAG Rounded", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelection.ForeColor = System.Drawing.Color.Yellow
        Me.LabelSelection.Location = New System.Drawing.Point(47, 4)
        Me.LabelSelection.Name = "LabelSelection"
        Me.LabelSelection.Size = New System.Drawing.Size(300, 17)
        Me.LabelSelection.TabIndex = 48
        Me.LabelSelection.Text = "Ma Selection à Copier : (2x clic p/ supprimer)"
        Me.LabelSelection.Visible = False
        '
        'txt_romname
        '
        Me.txt_romname.AutoSize = True
        Me.txt_romname.Font = New System.Drawing.Font("VAGRounded BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_romname.ForeColor = System.Drawing.Color.White
        Me.txt_romname.Location = New System.Drawing.Point(1, 0)
        Me.txt_romname.Name = "txt_romname"
        Me.txt_romname.Size = New System.Drawing.Size(290, 26)
        Me.txt_romname.TabIndex = 22
        Me.txt_romname.Text = "Veuillez cliquer sur une Rom"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.romsaveo)
        Me.GroupBox6.Controls.Add(Me.romoverlayo)
        Me.GroupBox6.Controls.Add(Me.rommanualo)
        Me.GroupBox6.Controls.Add(Me.romvideoo)
        Me.GroupBox6.Controls.Add(Me.romscreeno)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Location = New System.Drawing.Point(6, 387)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(381, 82)
        Me.GroupBox6.TabIndex = 21
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Fichiers Liés à la Rom :"
        '
        'romsaveo
        '
        Me.romsaveo.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.romsaveo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.romsaveo.Cursor = System.Windows.Forms.Cursors.Default
        Me.romsaveo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.romsaveo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.romsaveo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.romsaveo.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.romsaveo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.romsaveo.Location = New System.Drawing.Point(316, 13)
        Me.romsaveo.Name = "romsaveo"
        Me.romsaveo.Size = New System.Drawing.Size(50, 49)
        Me.romsaveo.TabIndex = 45
        Me.romsaveo.UseVisualStyleBackColor = False
        '
        'romoverlayo
        '
        Me.romoverlayo.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.romoverlayo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.romoverlayo.Cursor = System.Windows.Forms.Cursors.Default
        Me.romoverlayo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.romoverlayo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.romoverlayo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.romoverlayo.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.romoverlayo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.romoverlayo.Location = New System.Drawing.Point(243, 13)
        Me.romoverlayo.Name = "romoverlayo"
        Me.romoverlayo.Size = New System.Drawing.Size(50, 49)
        Me.romoverlayo.TabIndex = 44
        Me.romoverlayo.UseVisualStyleBackColor = False
        '
        'rommanualo
        '
        Me.rommanualo.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.rommanualo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rommanualo.Cursor = System.Windows.Forms.Cursors.Default
        Me.rommanualo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.rommanualo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.rommanualo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rommanualo.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rommanualo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rommanualo.Location = New System.Drawing.Point(160, 13)
        Me.rommanualo.Name = "rommanualo"
        Me.rommanualo.Size = New System.Drawing.Size(50, 49)
        Me.rommanualo.TabIndex = 43
        Me.rommanualo.UseVisualStyleBackColor = False
        '
        'romvideoo
        '
        Me.romvideoo.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.romvideoo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.romvideoo.Cursor = System.Windows.Forms.Cursors.Default
        Me.romvideoo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.romvideoo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.romvideoo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.romvideoo.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.romvideoo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.romvideoo.Location = New System.Drawing.Point(86, 13)
        Me.romvideoo.Name = "romvideoo"
        Me.romvideoo.Size = New System.Drawing.Size(50, 49)
        Me.romvideoo.TabIndex = 42
        Me.romvideoo.UseVisualStyleBackColor = False
        '
        'romscreeno
        '
        Me.romscreeno.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.romscreeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.romscreeno.Cursor = System.Windows.Forms.Cursors.Default
        Me.romscreeno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.romscreeno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.romscreeno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.romscreeno.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.romscreeno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.romscreeno.Location = New System.Drawing.Point(13, 14)
        Me.romscreeno.Name = "romscreeno"
        Me.romscreeno.Size = New System.Drawing.Size(50, 49)
        Me.romscreeno.TabIndex = 41
        Me.romscreeno.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(325, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Save"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(249, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Overlay"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(164, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Manuel"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(95, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Video"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ScreenShot"
        '
        'RomImage
        '
        Me.RomImage.Image = CType(resources.GetObject("RomImage.Image"), System.Drawing.Image)
        Me.RomImage.InitialImage = Nothing
        Me.RomImage.Location = New System.Drawing.Point(5, 55)
        Me.RomImage.Name = "RomImage"
        Me.RomImage.Size = New System.Drawing.Size(173, 132)
        Me.RomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RomImage.TabIndex = 0
        Me.RomImage.TabStop = False
        '
        'txt_romdesc
        '
        Me.txt_romdesc.Location = New System.Drawing.Point(184, 74)
        Me.txt_romdesc.Name = "txt_romdesc"
        Me.txt_romdesc.ReadOnly = True
        Me.txt_romdesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_romdesc.Size = New System.Drawing.Size(203, 307)
        Me.txt_romdesc.TabIndex = 15
        Me.txt_romdesc.Text = ""
        '
        'txt_rompath
        '
        Me.txt_rompath.BackColor = System.Drawing.SystemColors.Info
        Me.txt_rompath.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rompath.Location = New System.Drawing.Point(5, 41)
        Me.txt_rompath.Name = "txt_rompath"
        Me.txt_rompath.ReadOnly = True
        Me.txt_rompath.Size = New System.Drawing.Size(382, 15)
        Me.txt_rompath.TabIndex = 14
        '
        'vid_romvid
        '
        Me.vid_romvid.Enabled = True
        Me.vid_romvid.Location = New System.Drawing.Point(5, 249)
        Me.vid_romvid.Name = "vid_romvid"
        Me.vid_romvid.OcxState = CType(resources.GetObject("vid_romvid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vid_romvid.Size = New System.Drawing.Size(173, 132)
        Me.vid_romvid.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Synopsis :"
        '
        'txt_txtsearch
        '
        Me.txt_txtsearch.Location = New System.Drawing.Point(244, 30)
        Me.txt_txtsearch.Name = "txt_txtsearch"
        Me.txt_txtsearch.Size = New System.Drawing.Size(114, 20)
        Me.txt_txtsearch.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 75
        '
        'GroupFiltresAvances
        '
        Me.GroupFiltresAvances.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GroupFiltresAvances.Controls.Add(Me.ButtonRazClickk)
        Me.GroupFiltresAvances.Controls.Add(Me.ButtonHideColumn)
        Me.GroupFiltresAvances.Controls.Add(Me.ButtonShowColonne)
        Me.GroupFiltresAvances.Controls.Add(Me.Label10)
        Me.GroupFiltresAvances.Controls.Add(Me.Label9)
        Me.GroupFiltresAvances.Controls.Add(Me.listconsoleselected)
        Me.GroupFiltresAvances.Controls.Add(Me.txtShownRoms)
        Me.GroupFiltresAvances.Controls.Add(Me.Label7)
        Me.GroupFiltresAvances.Controls.Add(Me.Label6)
        Me.GroupFiltresAvances.Controls.Add(Me.txt_nbrom)
        Me.GroupFiltresAvances.Controls.Add(Me.Label4)
        Me.GroupFiltresAvances.Controls.Add(Me.ComboFiltreColonnes)
        Me.GroupFiltresAvances.Controls.Add(Me.txt_txtsearch)
        Me.GroupFiltresAvances.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupFiltresAvances.Location = New System.Drawing.Point(8, 398)
        Me.GroupFiltresAvances.Name = "GroupFiltresAvances"
        Me.GroupFiltresAvances.Size = New System.Drawing.Size(474, 105)
        Me.GroupFiltresAvances.TabIndex = 13
        Me.GroupFiltresAvances.TabStop = False
        Me.GroupFiltresAvances.Text = "Filtres Avancés :"
        '
        'ButtonRazClickk
        '
        Me.ButtonRazClickk.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonRazClickk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRazClickk.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonRazClickk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonRazClickk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonRazClickk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRazClickk.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRazClickk.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRazClickk.Location = New System.Drawing.Point(245, 57)
        Me.ButtonRazClickk.Name = "ButtonRazClickk"
        Me.ButtonRazClickk.Size = New System.Drawing.Size(113, 42)
        Me.ButtonRazClickk.TabIndex = 38
        Me.ButtonRazClickk.Text = "RAZ Recherche"
        Me.ButtonRazClickk.UseVisualStyleBackColor = False
        '
        'ButtonHideColumn
        '
        Me.ButtonHideColumn.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonHideColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHideColumn.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonHideColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonHideColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonHideColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHideColumn.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHideColumn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonHideColumn.Location = New System.Drawing.Point(179, 57)
        Me.ButtonHideColumn.Name = "ButtonHideColumn"
        Me.ButtonHideColumn.Size = New System.Drawing.Size(59, 42)
        Me.ButtonHideColumn.TabIndex = 37
        Me.ButtonHideColumn.Text = "Cacher"
        Me.ButtonHideColumn.UseVisualStyleBackColor = False
        '
        'ButtonShowColonne
        '
        Me.ButtonShowColonne.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonShowColonne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonShowColonne.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonShowColonne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonShowColonne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonShowColonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowColonne.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonShowColonne.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonShowColonne.Location = New System.Drawing.Point(114, 57)
        Me.ButtonShowColonne.Name = "ButtonShowColonne"
        Me.ButtonShowColonne.Size = New System.Drawing.Size(59, 42)
        Me.ButtonShowColonne.TabIndex = 36
        Me.ButtonShowColonne.Text = "Afficher"
        Me.ButtonShowColonne.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(112, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Filtres :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(5, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ma Selection :"
        '
        'listconsoleselected
        '
        Me.listconsoleselected.FormattingEnabled = True
        Me.listconsoleselected.Location = New System.Drawing.Point(7, 30)
        Me.listconsoleselected.Name = "listconsoleselected"
        Me.listconsoleselected.Size = New System.Drawing.Size(94, 69)
        Me.listconsoleselected.TabIndex = 19
        '
        'txtShownRoms
        '
        Me.txtShownRoms.BackColor = System.Drawing.Color.Honeydew
        Me.txtShownRoms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShownRoms.Location = New System.Drawing.Point(388, 34)
        Me.txtShownRoms.Name = "txtShownRoms"
        Me.txtShownRoms.ReadOnly = True
        Me.txtShownRoms.Size = New System.Drawing.Size(47, 20)
        Me.txtShownRoms.TabIndex = 19
        Me.txtShownRoms.Text = "0"
        Me.txtShownRoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(370, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nb Roms Total :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(365, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nb Roms Affichées :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_nbrom
        '
        Me.txt_nbrom.BackColor = System.Drawing.Color.ForestGreen
        Me.txt_nbrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nbrom.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_nbrom.Location = New System.Drawing.Point(388, 77)
        Me.txt_nbrom.Name = "txt_nbrom"
        Me.txt_nbrom.ReadOnly = True
        Me.txt_nbrom.Size = New System.Drawing.Size(47, 22)
        Me.txt_nbrom.TabIndex = 16
        Me.txt_nbrom.Text = "0"
        Me.txt_nbrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(242, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Valeur du Filtre :"
        '
        'ComboFiltreColonnes
        '
        Me.ComboFiltreColonnes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFiltreColonnes.FormattingEnabled = True
        Me.ComboFiltreColonnes.Location = New System.Drawing.Point(114, 30)
        Me.ComboFiltreColonnes.Name = "ComboFiltreColonnes"
        Me.ComboFiltreColonnes.Size = New System.Drawing.Size(124, 21)
        Me.ComboFiltreColonnes.TabIndex = 0
        '
        'CheckBoxARRM
        '
        Me.CheckBoxARRM.AutoSize = True
        Me.CheckBoxARRM.Checked = True
        Me.CheckBoxARRM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxARRM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBoxARRM.Location = New System.Drawing.Point(23, 30)
        Me.CheckBoxARRM.Name = "CheckBoxARRM"
        Me.CheckBoxARRM.Size = New System.Drawing.Size(198, 17)
        Me.CheckBoxARRM.TabIndex = 32
        Me.CheckBoxARRM.Text = "Utiliser les gamelist ARRM en priorité"
        Me.CheckBoxARRM.UseVisualStyleBackColor = True
        '
        'ButtonGetBack
        '
        Me.ButtonGetBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonGetBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonGetBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonGetBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonGetBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonGetBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGetBack.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGetBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGetBack.Location = New System.Drawing.Point(15, 2)
        Me.ButtonGetBack.Name = "ButtonGetBack"
        Me.ButtonGetBack.Size = New System.Drawing.Size(94, 23)
        Me.ButtonGetBack.TabIndex = 33
        Me.ButtonGetBack.Text = "Retour Au Menu"
        Me.ButtonGetBack.UseVisualStyleBackColor = False
        '
        'ButtonTuto1
        '
        Me.ButtonTuto1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ButtonTuto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonTuto1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonTuto1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonTuto1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ButtonTuto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTuto1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTuto1.ForeColor = System.Drawing.Color.White
        Me.ButtonTuto1.Location = New System.Drawing.Point(912, 2)
        Me.ButtonTuto1.Name = "ButtonTuto1"
        Me.ButtonTuto1.Size = New System.Drawing.Size(94, 23)
        Me.ButtonTuto1.TabIndex = 35
        Me.ButtonTuto1.Text = "Help/Tutoriel"
        Me.ButtonTuto1.UseVisualStyleBackColor = False
        '
        'ButtonGenererList
        '
        Me.ButtonGenererList.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ButtonGenererList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonGenererList.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonGenererList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonGenererList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonGenererList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGenererList.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenererList.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGenererList.Location = New System.Drawing.Point(15, 363)
        Me.ButtonGenererList.Name = "ButtonGenererList"
        Me.ButtonGenererList.Size = New System.Drawing.Size(206, 30)
        Me.ButtonGenererList.TabIndex = 37
        Me.ButtonGenererList.Text = "Valider les Systèmes Selectionnés"
        Me.ButtonGenererList.UseVisualStyleBackColor = False
        '
        'TutoHideGameList
        '
        Me.TutoHideGameList.Location = New System.Drawing.Point(259, 2)
        Me.TutoHideGameList.Name = "TutoHideGameList"
        Me.TutoHideGameList.Size = New System.Drawing.Size(74, 21)
        Me.TutoHideGameList.TabIndex = 24
        Me.TutoHideGameList.TabStop = False
        '
        'TutoHideRomInfo
        '
        Me.TutoHideRomInfo.Location = New System.Drawing.Point(409, 2)
        Me.TutoHideRomInfo.Name = "TutoHideRomInfo"
        Me.TutoHideRomInfo.Size = New System.Drawing.Size(33, 21)
        Me.TutoHideRomInfo.TabIndex = 22
        Me.TutoHideRomInfo.TabStop = False
        '
        'TutoHideFinalGrid
        '
        Me.TutoHideFinalGrid.Location = New System.Drawing.Point(339, 2)
        Me.TutoHideFinalGrid.Name = "TutoHideFinalGrid"
        Me.TutoHideFinalGrid.Size = New System.Drawing.Size(64, 21)
        Me.TutoHideFinalGrid.TabIndex = 20
        Me.TutoHideFinalGrid.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(8, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 26)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Votre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Selection"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupMode
        '
        Me.GroupMode.BackColor = System.Drawing.Color.Silver
        Me.GroupMode.Controls.Add(Me.ChkAvance)
        Me.GroupMode.Controls.Add(Me.ChkSimple)
        Me.GroupMode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupMode.Location = New System.Drawing.Point(8, 510)
        Me.GroupMode.Name = "GroupMode"
        Me.GroupMode.Size = New System.Drawing.Size(124, 89)
        Me.GroupMode.TabIndex = 41
        Me.GroupMode.TabStop = False
        Me.GroupMode.Text = "Simple/Expert Mode"
        '
        'ChkAvance
        '
        Me.ChkAvance.AutoSize = True
        Me.ChkAvance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ChkAvance.Location = New System.Drawing.Point(20, 59)
        Me.ChkAvance.Name = "ChkAvance"
        Me.ChkAvance.Size = New System.Drawing.Size(93, 17)
        Me.ChkAvance.TabIndex = 1
        Me.ChkAvance.Text = "Mode Avancé"
        Me.ChkAvance.UseVisualStyleBackColor = True
        '
        'ChkSimple
        '
        Me.ChkSimple.AutoSize = True
        Me.ChkSimple.ForeColor = System.Drawing.Color.Black
        Me.ChkSimple.Location = New System.Drawing.Point(20, 31)
        Me.ChkSimple.Name = "ChkSimple"
        Me.ChkSimple.Size = New System.Drawing.Size(87, 17)
        Me.ChkSimple.TabIndex = 0
        Me.ChkSimple.Text = "Mode Simple"
        Me.ChkSimple.UseVisualStyleBackColor = True
        '
        'GroupBoxSelectionRoms
        '
        Me.GroupBoxSelectionRoms.Controls.Add(Me.Label16)
        Me.GroupBoxSelectionRoms.Controls.Add(Me.ButtonCollection)
        Me.GroupBoxSelectionRoms.Controls.Add(Me.ButtonAfficherMaSelection)
        Me.GroupBoxSelectionRoms.Controls.Add(Me.Label15)
        Me.GroupBoxSelectionRoms.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBoxSelectionRoms.Location = New System.Drawing.Point(483, 398)
        Me.GroupBoxSelectionRoms.Name = "GroupBoxSelectionRoms"
        Me.GroupBoxSelectionRoms.Size = New System.Drawing.Size(128, 105)
        Me.GroupBoxSelectionRoms.TabIndex = 42
        Me.GroupBoxSelectionRoms.TabStop = False
        Me.GroupBoxSelectionRoms.Text = "Selection : Afficher ..."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(68, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 26)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Gestion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Collections"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonCollection
        '
        Me.ButtonCollection.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.ButtonCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCollection.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.ButtonCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCollection.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCollection.Image = CType(resources.GetObject("ButtonCollection.Image"), System.Drawing.Image)
        Me.ButtonCollection.Location = New System.Drawing.Point(72, 19)
        Me.ButtonCollection.Name = "ButtonCollection"
        Me.ButtonCollection.Size = New System.Drawing.Size(50, 49)
        Me.ButtonCollection.TabIndex = 41
        Me.ButtonCollection.UseVisualStyleBackColor = False
        '
        'TutoHideSimpleMode
        '
        Me.TutoHideSimpleMode.Location = New System.Drawing.Point(534, 2)
        Me.TutoHideSimpleMode.Name = "TutoHideSimpleMode"
        Me.TutoHideSimpleMode.Size = New System.Drawing.Size(42, 23)
        Me.TutoHideSimpleMode.TabIndex = 43
        Me.TutoHideSimpleMode.TabStop = False
        '
        'TutoHideFiltresAvance
        '
        Me.TutoHideFiltresAvance.Location = New System.Drawing.Point(478, 2)
        Me.TutoHideFiltresAvance.Name = "TutoHideFiltresAvance"
        Me.TutoHideFiltresAvance.Size = New System.Drawing.Size(50, 23)
        Me.TutoHideFiltresAvance.TabIndex = 45
        Me.TutoHideFiltresAvance.TabStop = False
        '
        'TutoSelectionActuelle
        '
        Me.TutoSelectionActuelle.Location = New System.Drawing.Point(448, 2)
        Me.TutoSelectionActuelle.Name = "TutoSelectionActuelle"
        Me.TutoSelectionActuelle.Size = New System.Drawing.Size(24, 21)
        Me.TutoSelectionActuelle.TabIndex = 47
        Me.TutoSelectionActuelle.TabStop = False
        '
        'GroupCollections
        '
        Me.GroupCollections.BackColor = System.Drawing.Color.DarkGreen
        Me.GroupCollections.Controls.Add(Me.ButtonAddCollection)
        Me.GroupCollections.Controls.Add(Me.ButtonRemoveFromCollection)
        Me.GroupCollections.Controls.Add(Me.AjoutCollection)
        Me.GroupCollections.Controls.Add(Me.SaveCollection)
        Me.GroupCollections.Controls.Add(Me.SupCollection)
        Me.GroupCollections.Controls.Add(Me.CollectionGrid)
        Me.GroupCollections.Controls.Add(Me.Label18)
        Me.GroupCollections.Controls.Add(Me.ComboCollection)
        Me.GroupCollections.ForeColor = System.Drawing.Color.White
        Me.GroupCollections.Location = New System.Drawing.Point(187, 2)
        Me.GroupCollections.Name = "GroupCollections"
        Me.GroupCollections.Size = New System.Drawing.Size(59, 21)
        Me.GroupCollections.TabIndex = 48
        Me.GroupCollections.TabStop = False
        Me.GroupCollections.Text = "Gestionnaire de Collections"
        '
        'ButtonAddCollection
        '
        Me.ButtonAddCollection.BackColor = System.Drawing.Color.MidnightBlue
        Me.ButtonAddCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonAddCollection.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonAddCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonAddCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonAddCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddCollection.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAddCollection.Location = New System.Drawing.Point(173, 353)
        Me.ButtonAddCollection.Name = "ButtonAddCollection"
        Me.ButtonAddCollection.Size = New System.Drawing.Size(54, 34)
        Me.ButtonAddCollection.TabIndex = 43
        Me.ButtonAddCollection.Text = "Ajouter"
        Me.ButtonAddCollection.UseVisualStyleBackColor = False
        '
        'ButtonRemoveFromCollection
        '
        Me.ButtonRemoveFromCollection.BackColor = System.Drawing.Color.Red
        Me.ButtonRemoveFromCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRemoveFromCollection.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonRemoveFromCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonRemoveFromCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.ButtonRemoveFromCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRemoveFromCollection.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemoveFromCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRemoveFromCollection.Location = New System.Drawing.Point(9, 353)
        Me.ButtonRemoveFromCollection.Name = "ButtonRemoveFromCollection"
        Me.ButtonRemoveFromCollection.Size = New System.Drawing.Size(54, 34)
        Me.ButtonRemoveFromCollection.TabIndex = 42
        Me.ButtonRemoveFromCollection.Text = "Retirer"
        Me.ButtonRemoveFromCollection.UseVisualStyleBackColor = False
        '
        'AjoutCollection
        '
        Me.AjoutCollection.BackColor = System.Drawing.Color.MediumVioletRed
        Me.AjoutCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.AjoutCollection.Cursor = System.Windows.Forms.Cursors.Default
        Me.AjoutCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.AjoutCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.AjoutCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AjoutCollection.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjoutCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AjoutCollection.Location = New System.Drawing.Point(151, 8)
        Me.AjoutCollection.Name = "AjoutCollection"
        Me.AjoutCollection.Size = New System.Drawing.Size(76, 46)
        Me.AjoutCollection.TabIndex = 41
        Me.AjoutCollection.Text = "Creer une" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Collection"
        Me.AjoutCollection.UseVisualStyleBackColor = False
        '
        'SaveCollection
        '
        Me.SaveCollection.BackColor = System.Drawing.Color.Gold
        Me.SaveCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SaveCollection.Cursor = System.Windows.Forms.Cursors.Default
        Me.SaveCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.SaveCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.SaveCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveCollection.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveCollection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SaveCollection.Location = New System.Drawing.Point(80, 353)
        Me.SaveCollection.Name = "SaveCollection"
        Me.SaveCollection.Size = New System.Drawing.Size(77, 34)
        Me.SaveCollection.TabIndex = 40
        Me.SaveCollection.Text = "Sauvegarder"
        Me.SaveCollection.UseVisualStyleBackColor = False
        '
        'SupCollection
        '
        Me.SupCollection.BackColor = System.Drawing.Color.MediumVioletRed
        Me.SupCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SupCollection.Cursor = System.Windows.Forms.Cursors.Default
        Me.SupCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.SupCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.SupCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupCollection.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SupCollection.Location = New System.Drawing.Point(9, 59)
        Me.SupCollection.Name = "SupCollection"
        Me.SupCollection.Size = New System.Drawing.Size(218, 31)
        Me.SupCollection.TabIndex = 39
        Me.SupCollection.Text = "Supprimer la collection ci dessus"
        Me.SupCollection.UseVisualStyleBackColor = False
        '
        'CollectionGrid
        '
        Me.CollectionGrid.AllowUserToAddRows = False
        Me.CollectionGrid.AllowUserToResizeRows = False
        Me.CollectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CollectionGrid.Location = New System.Drawing.Point(9, 117)
        Me.CollectionGrid.Name = "CollectionGrid"
        Me.CollectionGrid.ReadOnly = True
        Me.CollectionGrid.RowHeadersVisible = False
        Me.CollectionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CollectionGrid.Size = New System.Drawing.Size(218, 232)
        Me.CollectionGrid.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Roms de la Collection : "
        '
        'ComboCollection
        '
        Me.ComboCollection.FormattingEnabled = True
        Me.ComboCollection.Location = New System.Drawing.Point(9, 25)
        Me.ComboCollection.Name = "ComboCollection"
        Me.ComboCollection.Size = New System.Drawing.Size(132, 21)
        Me.ComboCollection.TabIndex = 1
        '
        'CopyRoms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1018, 611)
        Me.Controls.Add(Me.GroupCollections)
        Me.Controls.Add(Me.TutoSelectionActuelle)
        Me.Controls.Add(Me.TutoHideFiltresAvance)
        Me.Controls.Add(Me.TutoHideBoutonCopy)
        Me.Controls.Add(Me.TutoHideOuCopier)
        Me.Controls.Add(Me.TutoHideSimpleMode)
        Me.Controls.Add(Me.TutoHideQuoiCopier)
        Me.Controls.Add(Me.TutoHideSelectionIndic)
        Me.Controls.Add(Me.TutoHideUSB)
        Me.Controls.Add(Me.TutoHideGameList)
        Me.Controls.Add(Me.TutoHideRomInfo)
        Me.Controls.Add(Me.TutoHideFinalGrid)
        Me.Controls.Add(Me.GroupBoxSelectionRoms)
        Me.Controls.Add(Me.GroupMode)
        Me.Controls.Add(Me.ButtonGenererList)
        Me.Controls.Add(Me.ButtonTuto1)
        Me.Controls.Add(Me.ButtonGetBack)
        Me.Controls.Add(Me.CheckBoxARRM)
        Me.Controls.Add(Me.GroupFiltresAvances)
        Me.Controls.Add(Me.grp_RomInfos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListGameLists)
        Me.Controls.Add(Me.FinalGrid)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1034, 650)
        Me.MinimumSize = New System.Drawing.Size(1034, 650)
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
        CType(Me.TutoHideBoutonCopy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideOuCopier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideQuoiCopier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideSelectionIndic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideUSB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_RomInfos.ResumeLayout(False)
        Me.grp_RomInfos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.RomImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vid_romvid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFiltresAvances.ResumeLayout(False)
        Me.GroupFiltresAvances.PerformLayout()
        CType(Me.TutoHideGameList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideRomInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideFinalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupMode.ResumeLayout(False)
        Me.GroupMode.PerformLayout()
        Me.GroupBoxSelectionRoms.ResumeLayout(False)
        Me.GroupBoxSelectionRoms.PerformLayout()
        CType(Me.TutoHideSimpleMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideFiltresAvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoSelectionActuelle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCollections.ResumeLayout(False)
        Me.GroupCollections.PerformLayout()
        CType(Me.CollectionGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListGameLists As ListBox
    Friend WithEvents FinalGrid As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents vid_romvid As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents txt_rompath As TextBox
    Friend WithEvents txt_romdesc As RichTextBox
    Friend WithEvents txt_txtsearch As TextBox
    Friend WithEvents GroupBox5 As GroupBox
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
    Friend WithEvents listboxMaSelection As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupFiltresAvances As GroupBox
    Friend WithEvents ComboFiltreColonnes As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtShownRoms As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nbrom As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents listconsoleselected As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TutoHideFinalGrid As PictureBox
    Friend WithEvents TutoHideRomInfo As PictureBox
    Friend WithEvents TutoHideUSB As PictureBox
    Friend WithEvents TutoHideGameList As PictureBox
    Friend WithEvents TutoHideOuCopier As PictureBox
    Friend WithEvents TutoHideQuoiCopier As PictureBox
    Friend WithEvents TutoHideSelectionIndic As PictureBox
    Friend WithEvents TutoHideBoutonCopy As PictureBox
    Friend WithEvents CheckBoxARRM As CheckBox
    Friend WithEvents txt_romname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonGetBack As Button
    Friend WithEvents ButtonTuto1 As Button
    Friend WithEvents ButtonRazClickk As Button
    Friend WithEvents ButtonHideColumn As Button
    Friend WithEvents ButtonShowColonne As Button
    Friend WithEvents ButtonAfficherMaSelection As Button
    Friend WithEvents ButtonParcourirRecalCopy As Button
    Friend WithEvents ButtonSonVid As Button
    Friend WithEvents ButtonGenererList As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupMode As GroupBox
    Friend WithEvents ChkAvance As CheckBox
    Friend WithEvents ChkSimple As CheckBox
    Friend WithEvents GroupBoxSelectionRoms As GroupBox
    Friend WithEvents romsaveo As Button
    Friend WithEvents romoverlayo As Button
    Friend WithEvents rommanualo As Button
    Friend WithEvents romvideoo As Button
    Friend WithEvents romscreeno As Button
    Friend WithEvents TutoHideSimpleMode As PictureBox
    Friend WithEvents TutoHideFiltresAvance As PictureBox
    Friend WithEvents TutoSelectionActuelle As PictureBox
    Friend WithEvents LabelSelection As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ButtonCollection As Button
    Friend WithEvents GroupCollections As GroupBox
    Friend WithEvents AjoutCollection As Button
    Friend WithEvents SaveCollection As Button
    Friend WithEvents SupCollection As Button
    Friend WithEvents CollectionGrid As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents ComboCollection As ComboBox
    Friend WithEvents ButtonRemoveFromCollection As Button
    Friend WithEvents ButtonAddCollection As Button
End Class
