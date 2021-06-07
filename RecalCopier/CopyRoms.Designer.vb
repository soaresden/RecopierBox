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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.grp_RomInfos = New System.Windows.Forms.GroupBox()
        Me.listboxMaSelection = New System.Windows.Forms.ListBox()
        Me.ButtonSonVid = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelSelection = New System.Windows.Forms.Label()
        Me.txt_romname = New System.Windows.Forms.Label()
        Me.GroupBoxBoutonsMedias = New System.Windows.Forms.GroupBox()
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupMode = New System.Windows.Forms.GroupBox()
        Me.ChkAvance = New System.Windows.Forms.CheckBox()
        Me.ChkSimple = New System.Windows.Forms.CheckBox()
        Me.GroupBoxSelectionRoms = New System.Windows.Forms.GroupBox()
        Me.ButtonAfficherMaSelection = New System.Windows.Forms.Button()
        Me.LabelCollection = New System.Windows.Forms.Label()
        Me.GroupCollections = New System.Windows.Forms.GroupBox()
        Me.ButtonCollectionAvance = New System.Windows.Forms.Button()
        Me.ButtonAddCollection = New System.Windows.Forms.Button()
        Me.ButtonRemoveFromCollection = New System.Windows.Forms.Button()
        Me.AjoutCollection = New System.Windows.Forms.Button()
        Me.SaveCollection = New System.Windows.Forms.Button()
        Me.SupCollection = New System.Windows.Forms.Button()
        Me.CollectionGrid = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboCollection = New System.Windows.Forms.ComboBox()
        Me.ButtonCollection = New System.Windows.Forms.Button()
        Me.TutoSelectionActuelle = New System.Windows.Forms.PictureBox()
        Me.TutoHideFiltresAvance = New System.Windows.Forms.PictureBox()
        Me.TutoHideBoutonCopy = New System.Windows.Forms.PictureBox()
        Me.TutoHideOuCopier = New System.Windows.Forms.PictureBox()
        Me.TutoHideSimpleMode = New System.Windows.Forms.PictureBox()
        Me.TutoHideQuoiCopier = New System.Windows.Forms.PictureBox()
        Me.TutoHideSelectionIndic = New System.Windows.Forms.PictureBox()
        Me.TutoHideUSB = New System.Windows.Forms.PictureBox()
        Me.TutoHideGameList = New System.Windows.Forms.PictureBox()
        Me.TutoHideRomInfo = New System.Windows.Forms.PictureBox()
        Me.TutoHideFinalGrid = New System.Windows.Forms.PictureBox()
        Me.GroupCollectEditor = New System.Windows.Forms.GroupBox()
        Me.ValidCell = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ButtonHideEditor = New System.Windows.Forms.Button()
        Me.CollectionGridDetaille = New System.Windows.Forms.DataGridView()
        Me.ConfirmEditInfoonCollection = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CollectionEditorList = New System.Windows.Forms.ComboBox()
        Me.CellEnGrand = New System.Windows.Forms.RichTextBox()
        Me.ExportExcel = New System.Windows.Forms.Button()
        Me.ImportToRecopierBox = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.checkroms = New System.Windows.Forms.CheckBox()
        CType(Me.FinalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_RomInfos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxBoutonsMedias.SuspendLayout()
        CType(Me.RomImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vid_romvid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupFiltresAvances.SuspendLayout()
        Me.GroupMode.SuspendLayout()
        Me.GroupBoxSelectionRoms.SuspendLayout()
        Me.GroupCollections.SuspendLayout()
        CType(Me.CollectionGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoSelectionActuelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideFiltresAvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideBoutonCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideOuCopier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideSimpleMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideQuoiCopier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideSelectionIndic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideUSB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideGameList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideRomInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoHideFinalGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCollectEditor.SuspendLayout()
        CType(Me.CollectionGridDetaille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListGameLists
        '
        Me.ListGameLists.FormattingEnabled = True
        Me.ListGameLists.ItemHeight = 16
        Me.ListGameLists.Location = New System.Drawing.Point(20, 62)
        Me.ListGameLists.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListGameLists.Name = "ListGameLists"
        Me.ListGameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListGameLists.Size = New System.Drawing.Size(273, 372)
        Me.ListGameLists.TabIndex = 2
        '
        'FinalGrid
        '
        Me.FinalGrid.AllowUserToAddRows = False
        Me.FinalGrid.AllowUserToDeleteRows = False
        Me.FinalGrid.AllowUserToOrderColumns = True
        Me.FinalGrid.AllowUserToResizeRows = False
        Me.FinalGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.FinalGrid.ColumnHeadersHeight = 29
        Me.FinalGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FinalGrid.Location = New System.Drawing.Point(301, 34)
        Me.FinalGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FinalGrid.MultiSelect = False
        Me.FinalGrid.Name = "FinalGrid"
        Me.FinalGrid.ReadOnly = True
        Me.FinalGrid.RowHeadersVisible = False
        Me.FinalGrid.RowHeadersWidth = 51
        Me.FinalGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.FinalGrid.RowTemplate.Height = 24
        Me.FinalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FinalGrid.Size = New System.Drawing.Size(509, 449)
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
        Me.GroupBox1.Location = New System.Drawing.Point(183, 625)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1157, 113)
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
        Me.GroupBox5.Location = New System.Drawing.Point(748, 20)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(297, 86)
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
        Me.ButtonParcourirRecalCopy.Location = New System.Drawing.Point(209, 50)
        Me.ButtonParcourirRecalCopy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonParcourirRecalCopy.Name = "ButtonParcourirRecalCopy"
        Me.ButtonParcourirRecalCopy.Size = New System.Drawing.Size(81, 31)
        Me.ButtonParcourirRecalCopy.TabIndex = 40
        Me.ButtonParcourirRecalCopy.Text = "Parcourir"
        Me.ButtonParcourirRecalCopy.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(7, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Dossier où le dossier final sera créé :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_CopyFolder
        '
        Me.txt_CopyFolder.Location = New System.Drawing.Point(7, 53)
        Me.txt_CopyFolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_CopyFolder.Name = "txt_CopyFolder"
        Me.txt_CopyFolder.Size = New System.Drawing.Size(193, 22)
        Me.txt_CopyFolder.TabIndex = 0
        Me.txt_CopyFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCopy
        '
        Me.ButtonCopy.Image = CType(resources.GetObject("ButtonCopy.Image"), System.Drawing.Image)
        Me.ButtonCopy.Location = New System.Drawing.Point(1057, 18)
        Me.ButtonCopy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCopy.Name = "ButtonCopy"
        Me.ButtonCopy.Size = New System.Drawing.Size(92, 89)
        Me.ButtonCopy.TabIndex = 14
        Me.ButtonCopy.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.checkroms)
        Me.GroupBox2.Controls.Add(Me.checkbios)
        Me.GroupBox2.Controls.Add(Me.checksaves)
        Me.GroupBox2.Controls.Add(Me.checkimgs)
        Me.GroupBox2.Controls.Add(Me.checkoverlays)
        Me.GroupBox2.Controls.Add(Me.checkvideos)
        Me.GroupBox2.Controls.Add(Me.checkmanuals)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(480, 21)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(253, 86)
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
        Me.checkbios.Location = New System.Drawing.Point(167, 59)
        Me.checkbios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkbios.Name = "checkbios"
        Me.checkbios.Size = New System.Drawing.Size(57, 21)
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
        Me.checksaves.Location = New System.Drawing.Point(92, 59)
        Me.checksaves.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checksaves.Name = "checksaves"
        Me.checksaves.Size = New System.Drawing.Size(69, 21)
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
        Me.checkimgs.Location = New System.Drawing.Point(5, 37)
        Me.checkimgs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkimgs.Name = "checkimgs"
        Me.checkimgs.Size = New System.Drawing.Size(75, 21)
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
        Me.checkoverlays.Location = New System.Drawing.Point(168, 37)
        Me.checkoverlays.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkoverlays.Name = "checkoverlays"
        Me.checkoverlays.Size = New System.Drawing.Size(86, 21)
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
        Me.checkvideos.Location = New System.Drawing.Point(92, 38)
        Me.checkvideos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkvideos.Name = "checkvideos"
        Me.checkvideos.Size = New System.Drawing.Size(73, 21)
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
        Me.checkmanuals.Location = New System.Drawing.Point(5, 59)
        Me.checkmanuals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkmanuals.Name = "checkmanuals"
        Me.checkmanuals.Size = New System.Drawing.Size(83, 21)
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
        Me.GroupBox4.Location = New System.Drawing.Point(236, 21)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(231, 86)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ma Selection"
        '
        'lbl_GoAPrevoir
        '
        Me.lbl_GoAPrevoir.AutoSize = True
        Me.lbl_GoAPrevoir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_GoAPrevoir.Location = New System.Drawing.Point(85, 57)
        Me.lbl_GoAPrevoir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_GoAPrevoir.Name = "lbl_GoAPrevoir"
        Me.lbl_GoAPrevoir.Size = New System.Drawing.Size(84, 17)
        Me.lbl_GoAPrevoir.TabIndex = 3
        Me.lbl_GoAPrevoir.Text = "Mo à Copier"
        '
        'txt_GoAPrevoir
        '
        Me.txt_GoAPrevoir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GoAPrevoir.Location = New System.Drawing.Point(7, 52)
        Me.txt_GoAPrevoir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_GoAPrevoir.Name = "txt_GoAPrevoir"
        Me.txt_GoAPrevoir.ReadOnly = True
        Me.txt_GoAPrevoir.Size = New System.Drawing.Size(76, 26)
        Me.txt_GoAPrevoir.TabIndex = 2
        Me.txt_GoAPrevoir.Text = "0"
        Me.txt_GoAPrevoir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_romSelected
        '
        Me.lbl_romSelected.AutoSize = True
        Me.lbl_romSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_romSelected.Location = New System.Drawing.Point(85, 23)
        Me.lbl_romSelected.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_romSelected.Name = "lbl_romSelected"
        Me.lbl_romSelected.Size = New System.Drawing.Size(137, 17)
        Me.lbl_romSelected.TabIndex = 1
        Me.lbl_romSelected.Text = "Roms Selectionnées"
        '
        'txt_NbRomSelected
        '
        Me.txt_NbRomSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NbRomSelected.Location = New System.Drawing.Point(7, 20)
        Me.txt_NbRomSelected.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_NbRomSelected.Name = "txt_NbRomSelected"
        Me.txt_NbRomSelected.ReadOnly = True
        Me.txt_NbRomSelected.Size = New System.Drawing.Size(76, 26)
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
        Me.GroupBox3.Location = New System.Drawing.Point(15, 21)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(211, 86)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Taille USB :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(115, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mo Restants" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_morestant
        '
        Me.txt_morestant.Location = New System.Drawing.Point(20, 55)
        Me.txt_morestant.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_morestant.Name = "txt_morestant"
        Me.txt_morestant.ReadOnly = True
        Me.txt_morestant.Size = New System.Drawing.Size(85, 22)
        Me.txt_morestant.TabIndex = 5
        Me.txt_morestant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(115, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Go"
        '
        'txt_USBGo
        '
        Me.txt_USBGo.Location = New System.Drawing.Point(20, 20)
        Me.txt_USBGo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_USBGo.Name = "txt_USBGo"
        Me.txt_USBGo.Size = New System.Drawing.Size(85, 22)
        Me.txt_USBGo.TabIndex = 0
        Me.txt_USBGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grp_RomInfos
        '
        Me.grp_RomInfos.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.grp_RomInfos.Controls.Add(Me.listboxMaSelection)
        Me.grp_RomInfos.Controls.Add(Me.ButtonSonVid)
        Me.grp_RomInfos.Controls.Add(Me.Panel1)
        Me.grp_RomInfos.Controls.Add(Me.GroupBoxBoutonsMedias)
        Me.grp_RomInfos.Controls.Add(Me.RomImage)
        Me.grp_RomInfos.Controls.Add(Me.txt_romdesc)
        Me.grp_RomInfos.Controls.Add(Me.txt_rompath)
        Me.grp_RomInfos.Controls.Add(Me.vid_romvid)
        Me.grp_RomInfos.Controls.Add(Me.Label1)
        Me.grp_RomInfos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grp_RomInfos.Location = New System.Drawing.Point(816, 34)
        Me.grp_RomInfos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_RomInfos.Name = "grp_RomInfos"
        Me.grp_RomInfos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grp_RomInfos.Size = New System.Drawing.Size(524, 585)
        Me.grp_RomInfos.TabIndex = 10
        Me.grp_RomInfos.TabStop = False
        Me.grp_RomInfos.Text = "Rom Infos"
        '
        'listboxMaSelection
        '
        Me.listboxMaSelection.BackColor = System.Drawing.Color.Navy
        Me.listboxMaSelection.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.listboxMaSelection.FormattingEnabled = True
        Me.listboxMaSelection.ItemHeight = 16
        Me.listboxMaSelection.Location = New System.Drawing.Point(245, 68)
        Me.listboxMaSelection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listboxMaSelection.Name = "listboxMaSelection"
        Me.listboxMaSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.listboxMaSelection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.listboxMaSelection.Size = New System.Drawing.Size(269, 20)
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
        Me.ButtonSonVid.Location = New System.Drawing.Point(88, 239)
        Me.ButtonSonVid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSonVid.Name = "ButtonSonVid"
        Me.ButtonSonVid.Size = New System.Drawing.Size(69, 60)
        Me.ButtonSonVid.TabIndex = 40
        Me.ButtonSonVid.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelSelection)
        Me.Panel1.Controls.Add(Me.txt_romname)
        Me.Panel1.Location = New System.Drawing.Point(7, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 32)
        Me.Panel1.TabIndex = 23
        '
        'LabelSelection
        '
        Me.LabelSelection.AutoSize = True
        Me.LabelSelection.Font = New System.Drawing.Font("VAG Rounded", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSelection.ForeColor = System.Drawing.Color.Yellow
        Me.LabelSelection.Location = New System.Drawing.Point(63, 5)
        Me.LabelSelection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSelection.Name = "LabelSelection"
        Me.LabelSelection.Size = New System.Drawing.Size(382, 22)
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
        Me.txt_romname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_romname.Name = "txt_romname"
        Me.txt_romname.Size = New System.Drawing.Size(371, 33)
        Me.txt_romname.TabIndex = 22
        Me.txt_romname.Text = "Veuillez cliquer sur une Rom"
        '
        'GroupBoxBoutonsMedias
        '
        Me.GroupBoxBoutonsMedias.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.romsaveo)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.romoverlayo)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.rommanualo)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.romvideoo)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.romscreeno)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.Label14)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.Label13)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.Label12)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.Label11)
        Me.GroupBoxBoutonsMedias.Controls.Add(Me.Label2)
        Me.GroupBoxBoutonsMedias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBoxBoutonsMedias.Location = New System.Drawing.Point(8, 476)
        Me.GroupBoxBoutonsMedias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxBoutonsMedias.Name = "GroupBoxBoutonsMedias"
        Me.GroupBoxBoutonsMedias.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxBoutonsMedias.Size = New System.Drawing.Size(508, 101)
        Me.GroupBoxBoutonsMedias.TabIndex = 21
        Me.GroupBoxBoutonsMedias.TabStop = False
        Me.GroupBoxBoutonsMedias.Text = "Fichiers Liés à la Rom :"
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
        Me.romsaveo.Location = New System.Drawing.Point(421, 16)
        Me.romsaveo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.romsaveo.Name = "romsaveo"
        Me.romsaveo.Size = New System.Drawing.Size(67, 60)
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
        Me.romoverlayo.Location = New System.Drawing.Point(324, 16)
        Me.romoverlayo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.romoverlayo.Name = "romoverlayo"
        Me.romoverlayo.Size = New System.Drawing.Size(67, 60)
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
        Me.rommanualo.Location = New System.Drawing.Point(213, 16)
        Me.rommanualo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rommanualo.Name = "rommanualo"
        Me.rommanualo.Size = New System.Drawing.Size(67, 60)
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
        Me.romvideoo.Location = New System.Drawing.Point(115, 16)
        Me.romvideoo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.romvideoo.Name = "romvideoo"
        Me.romvideoo.Size = New System.Drawing.Size(67, 60)
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
        Me.romscreeno.Location = New System.Drawing.Point(17, 17)
        Me.romscreeno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.romscreeno.Name = "romscreeno"
        Me.romscreeno.Size = New System.Drawing.Size(67, 60)
        Me.romscreeno.TabIndex = 41
        Me.romscreeno.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(433, 79)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 17)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Save"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(332, 79)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Overlay"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(219, 79)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Manuel"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(127, 80)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Video"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ScreenShot"
        '
        'RomImage
        '
        Me.RomImage.Image = CType(resources.GetObject("RomImage.Image"), System.Drawing.Image)
        Me.RomImage.InitialImage = Nothing
        Me.RomImage.Location = New System.Drawing.Point(7, 68)
        Me.RomImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RomImage.Name = "RomImage"
        Me.RomImage.Size = New System.Drawing.Size(231, 162)
        Me.RomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RomImage.TabIndex = 0
        Me.RomImage.TabStop = False
        '
        'txt_romdesc
        '
        Me.txt_romdesc.Location = New System.Drawing.Point(245, 91)
        Me.txt_romdesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_romdesc.Name = "txt_romdesc"
        Me.txt_romdesc.ReadOnly = True
        Me.txt_romdesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_romdesc.Size = New System.Drawing.Size(269, 377)
        Me.txt_romdesc.TabIndex = 15
        Me.txt_romdesc.Text = ""
        '
        'txt_rompath
        '
        Me.txt_rompath.BackColor = System.Drawing.SystemColors.Info
        Me.txt_rompath.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rompath.Location = New System.Drawing.Point(7, 50)
        Me.txt_rompath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_rompath.Name = "txt_rompath"
        Me.txt_rompath.ReadOnly = True
        Me.txt_rompath.Size = New System.Drawing.Size(508, 17)
        Me.txt_rompath.TabIndex = 14
        '
        'vid_romvid
        '
        Me.vid_romvid.Enabled = True
        Me.vid_romvid.Location = New System.Drawing.Point(5, 249)
        Me.vid_romvid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.vid_romvid.Name = "vid_romvid"
        Me.vid_romvid.OcxState = CType(resources.GetObject("vid_romvid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vid_romvid.Size = New System.Drawing.Size(173, 132)
        Me.vid_romvid.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(348, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Synopsis :"
        '
        'txt_txtsearch
        '
        Me.txt_txtsearch.Location = New System.Drawing.Point(325, 37)
        Me.txt_txtsearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_txtsearch.Name = "txt_txtsearch"
        Me.txt_txtsearch.Size = New System.Drawing.Size(151, 22)
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
        Me.GroupFiltresAvances.Location = New System.Drawing.Point(11, 490)
        Me.GroupFiltresAvances.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupFiltresAvances.Name = "GroupFiltresAvances"
        Me.GroupFiltresAvances.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupFiltresAvances.Size = New System.Drawing.Size(632, 129)
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
        Me.ButtonRazClickk.Location = New System.Drawing.Point(327, 70)
        Me.ButtonRazClickk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRazClickk.Name = "ButtonRazClickk"
        Me.ButtonRazClickk.Size = New System.Drawing.Size(151, 52)
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
        Me.ButtonHideColumn.Location = New System.Drawing.Point(239, 70)
        Me.ButtonHideColumn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonHideColumn.Name = "ButtonHideColumn"
        Me.ButtonHideColumn.Size = New System.Drawing.Size(79, 52)
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
        Me.ButtonShowColonne.Location = New System.Drawing.Point(152, 70)
        Me.ButtonShowColonne.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonShowColonne.Name = "ButtonShowColonne"
        Me.ButtonShowColonne.Size = New System.Drawing.Size(79, 52)
        Me.ButtonShowColonne.TabIndex = 36
        Me.ButtonShowColonne.Text = "Afficher"
        Me.ButtonShowColonne.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(149, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Filtres :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(7, 18)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Ma Selection :"
        '
        'listconsoleselected
        '
        Me.listconsoleselected.FormattingEnabled = True
        Me.listconsoleselected.ItemHeight = 16
        Me.listconsoleselected.Location = New System.Drawing.Point(9, 37)
        Me.listconsoleselected.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.listconsoleselected.Name = "listconsoleselected"
        Me.listconsoleselected.Size = New System.Drawing.Size(124, 84)
        Me.listconsoleselected.TabIndex = 19
        '
        'txtShownRoms
        '
        Me.txtShownRoms.BackColor = System.Drawing.Color.Honeydew
        Me.txtShownRoms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShownRoms.Location = New System.Drawing.Point(517, 42)
        Me.txtShownRoms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtShownRoms.Name = "txtShownRoms"
        Me.txtShownRoms.ReadOnly = True
        Me.txtShownRoms.Size = New System.Drawing.Size(61, 22)
        Me.txtShownRoms.TabIndex = 19
        Me.txtShownRoms.Text = "0"
        Me.txtShownRoms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(493, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Nb Roms Total :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(487, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nb Roms Affichées :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_nbrom
        '
        Me.txt_nbrom.BackColor = System.Drawing.Color.ForestGreen
        Me.txt_nbrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nbrom.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_nbrom.Location = New System.Drawing.Point(517, 95)
        Me.txt_nbrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nbrom.Name = "txt_nbrom"
        Me.txt_nbrom.ReadOnly = True
        Me.txt_nbrom.Size = New System.Drawing.Size(61, 26)
        Me.txt_nbrom.TabIndex = 16
        Me.txt_nbrom.Text = "0"
        Me.txt_nbrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(323, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Valeur du Filtre :"
        '
        'ComboFiltreColonnes
        '
        Me.ComboFiltreColonnes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFiltreColonnes.FormattingEnabled = True
        Me.ComboFiltreColonnes.Location = New System.Drawing.Point(152, 37)
        Me.ComboFiltreColonnes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboFiltreColonnes.Name = "ComboFiltreColonnes"
        Me.ComboFiltreColonnes.Size = New System.Drawing.Size(164, 24)
        Me.ComboFiltreColonnes.TabIndex = 0
        '
        'CheckBoxARRM
        '
        Me.CheckBoxARRM.AutoSize = True
        Me.CheckBoxARRM.Checked = True
        Me.CheckBoxARRM.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxARRM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBoxARRM.Location = New System.Drawing.Point(31, 37)
        Me.CheckBoxARRM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxARRM.Name = "CheckBoxARRM"
        Me.CheckBoxARRM.Size = New System.Drawing.Size(263, 21)
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
        Me.ButtonGetBack.Location = New System.Drawing.Point(20, 2)
        Me.ButtonGetBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGetBack.Name = "ButtonGetBack"
        Me.ButtonGetBack.Size = New System.Drawing.Size(125, 28)
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
        Me.ButtonTuto1.Location = New System.Drawing.Point(1216, 2)
        Me.ButtonTuto1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonTuto1.Name = "ButtonTuto1"
        Me.ButtonTuto1.Size = New System.Drawing.Size(125, 28)
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
        Me.ButtonGenererList.Location = New System.Drawing.Point(20, 447)
        Me.ButtonGenererList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGenererList.Name = "ButtonGenererList"
        Me.ButtonGenererList.Size = New System.Drawing.Size(275, 37)
        Me.ButtonGenererList.TabIndex = 37
        Me.ButtonGenererList.Text = "Valider les Systèmes Selectionnés"
        Me.ButtonGenererList.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(11, 90)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 34)
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
        Me.GroupMode.Location = New System.Drawing.Point(11, 628)
        Me.GroupMode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupMode.Name = "GroupMode"
        Me.GroupMode.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupMode.Size = New System.Drawing.Size(165, 110)
        Me.GroupMode.TabIndex = 41
        Me.GroupMode.TabStop = False
        Me.GroupMode.Text = "Simple/Expert Mode"
        '
        'ChkAvance
        '
        Me.ChkAvance.AutoSize = True
        Me.ChkAvance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ChkAvance.Location = New System.Drawing.Point(27, 73)
        Me.ChkAvance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAvance.Name = "ChkAvance"
        Me.ChkAvance.Size = New System.Drawing.Size(116, 21)
        Me.ChkAvance.TabIndex = 1
        Me.ChkAvance.Text = "Mode Avancé"
        Me.ChkAvance.UseVisualStyleBackColor = True
        '
        'ChkSimple
        '
        Me.ChkSimple.AutoSize = True
        Me.ChkSimple.ForeColor = System.Drawing.Color.Black
        Me.ChkSimple.Location = New System.Drawing.Point(27, 38)
        Me.ChkSimple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkSimple.Name = "ChkSimple"
        Me.ChkSimple.Size = New System.Drawing.Size(111, 21)
        Me.ChkSimple.TabIndex = 0
        Me.ChkSimple.Text = "Mode Simple"
        Me.ChkSimple.UseVisualStyleBackColor = True
        '
        'GroupBoxSelectionRoms
        '
        Me.GroupBoxSelectionRoms.Controls.Add(Me.ButtonAfficherMaSelection)
        Me.GroupBoxSelectionRoms.Controls.Add(Me.Label15)
        Me.GroupBoxSelectionRoms.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBoxSelectionRoms.Location = New System.Drawing.Point(644, 490)
        Me.GroupBoxSelectionRoms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxSelectionRoms.Name = "GroupBoxSelectionRoms"
        Me.GroupBoxSelectionRoms.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxSelectionRoms.Size = New System.Drawing.Size(171, 129)
        Me.GroupBoxSelectionRoms.TabIndex = 42
        Me.GroupBoxSelectionRoms.TabStop = False
        Me.GroupBoxSelectionRoms.Text = "Selection : Afficher ..."
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
        Me.ButtonAfficherMaSelection.Location = New System.Drawing.Point(11, 23)
        Me.ButtonAfficherMaSelection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonAfficherMaSelection.Name = "ButtonAfficherMaSelection"
        Me.ButtonAfficherMaSelection.Size = New System.Drawing.Size(67, 60)
        Me.ButtonAfficherMaSelection.TabIndex = 39
        Me.ButtonAfficherMaSelection.UseVisualStyleBackColor = False
        '
        'LabelCollection
        '
        Me.LabelCollection.AutoSize = True
        Me.LabelCollection.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelCollection.Location = New System.Drawing.Point(728, 578)
        Me.LabelCollection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCollection.Name = "LabelCollection"
        Me.LabelCollection.Size = New System.Drawing.Size(76, 34)
        Me.LabelCollection.TabIndex = 42
        Me.LabelCollection.Text = "Gestion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Collections"
        Me.LabelCollection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupCollections
        '
        Me.GroupCollections.BackColor = System.Drawing.Color.DarkGreen
        Me.GroupCollections.Controls.Add(Me.ButtonCollectionAvance)
        Me.GroupCollections.Controls.Add(Me.ButtonAddCollection)
        Me.GroupCollections.Controls.Add(Me.ButtonRemoveFromCollection)
        Me.GroupCollections.Controls.Add(Me.AjoutCollection)
        Me.GroupCollections.Controls.Add(Me.SaveCollection)
        Me.GroupCollections.Controls.Add(Me.SupCollection)
        Me.GroupCollections.Controls.Add(Me.CollectionGrid)
        Me.GroupCollections.Controls.Add(Me.Label18)
        Me.GroupCollections.Controls.Add(Me.ComboCollection)
        Me.GroupCollections.ForeColor = System.Drawing.Color.White
        Me.GroupCollections.Location = New System.Drawing.Point(147, 5)
        Me.GroupCollections.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupCollections.Name = "GroupCollections"
        Me.GroupCollections.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupCollections.Size = New System.Drawing.Size(76, 26)
        Me.GroupCollections.TabIndex = 48
        Me.GroupCollections.TabStop = False
        Me.GroupCollections.Text = "Gestionnaire de Collections"
        '
        'ButtonCollectionAvance
        '
        Me.ButtonCollectionAvance.BackColor = System.Drawing.Color.DarkMagenta
        Me.ButtonCollectionAvance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCollectionAvance.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonCollectionAvance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonCollectionAvance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.ButtonCollectionAvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCollectionAvance.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCollectionAvance.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonCollectionAvance.Location = New System.Drawing.Point(163, 103)
        Me.ButtonCollectionAvance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCollectionAvance.Name = "ButtonCollectionAvance"
        Me.ButtonCollectionAvance.Size = New System.Drawing.Size(140, 39)
        Me.ButtonCollectionAvance.TabIndex = 44
        Me.ButtonCollectionAvance.Text = "Editer les Infos"
        Me.ButtonCollectionAvance.UseVisualStyleBackColor = False
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
        Me.ButtonAddCollection.Location = New System.Drawing.Point(231, 434)
        Me.ButtonAddCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonAddCollection.Name = "ButtonAddCollection"
        Me.ButtonAddCollection.Size = New System.Drawing.Size(72, 42)
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
        Me.ButtonRemoveFromCollection.Location = New System.Drawing.Point(12, 434)
        Me.ButtonRemoveFromCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRemoveFromCollection.Name = "ButtonRemoveFromCollection"
        Me.ButtonRemoveFromCollection.Size = New System.Drawing.Size(72, 42)
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
        Me.AjoutCollection.Location = New System.Drawing.Point(201, 22)
        Me.AjoutCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AjoutCollection.Name = "AjoutCollection"
        Me.AjoutCollection.Size = New System.Drawing.Size(101, 33)
        Me.AjoutCollection.TabIndex = 41
        Me.AjoutCollection.Text = "New Collec."
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
        Me.SaveCollection.Location = New System.Drawing.Point(107, 434)
        Me.SaveCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SaveCollection.Name = "SaveCollection"
        Me.SaveCollection.Size = New System.Drawing.Size(103, 42)
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
        Me.SupCollection.Location = New System.Drawing.Point(12, 63)
        Me.SupCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SupCollection.Name = "SupCollection"
        Me.SupCollection.Size = New System.Drawing.Size(291, 28)
        Me.SupCollection.TabIndex = 39
        Me.SupCollection.Text = "Supprimer la collection ci dessus"
        Me.SupCollection.UseVisualStyleBackColor = False
        '
        'CollectionGrid
        '
        Me.CollectionGrid.AllowUserToAddRows = False
        Me.CollectionGrid.AllowUserToResizeRows = False
        Me.CollectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CollectionGrid.Location = New System.Drawing.Point(12, 144)
        Me.CollectionGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CollectionGrid.Name = "CollectionGrid"
        Me.CollectionGrid.ReadOnly = True
        Me.CollectionGrid.RowHeadersVisible = False
        Me.CollectionGrid.RowHeadersWidth = 51
        Me.CollectionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CollectionGrid.Size = New System.Drawing.Size(291, 286)
        Me.CollectionGrid.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 127)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(156, 17)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Roms de la Collection : "
        '
        'ComboCollection
        '
        Me.ComboCollection.FormattingEnabled = True
        Me.ComboCollection.Location = New System.Drawing.Point(12, 31)
        Me.ComboCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboCollection.Name = "ComboCollection"
        Me.ComboCollection.Size = New System.Drawing.Size(175, 24)
        Me.ComboCollection.TabIndex = 1
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
        Me.ButtonCollection.Location = New System.Drawing.Point(732, 513)
        Me.ButtonCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonCollection.Name = "ButtonCollection"
        Me.ButtonCollection.Size = New System.Drawing.Size(67, 60)
        Me.ButtonCollection.TabIndex = 41
        Me.ButtonCollection.UseVisualStyleBackColor = False
        '
        'TutoSelectionActuelle
        '
        Me.TutoSelectionActuelle.Location = New System.Drawing.Point(597, 2)
        Me.TutoSelectionActuelle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoSelectionActuelle.Name = "TutoSelectionActuelle"
        Me.TutoSelectionActuelle.Size = New System.Drawing.Size(32, 26)
        Me.TutoSelectionActuelle.TabIndex = 47
        Me.TutoSelectionActuelle.TabStop = False
        '
        'TutoHideFiltresAvance
        '
        Me.TutoHideFiltresAvance.Location = New System.Drawing.Point(637, 2)
        Me.TutoHideFiltresAvance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideFiltresAvance.Name = "TutoHideFiltresAvance"
        Me.TutoHideFiltresAvance.Size = New System.Drawing.Size(67, 28)
        Me.TutoHideFiltresAvance.TabIndex = 45
        Me.TutoHideFiltresAvance.TabStop = False
        '
        'TutoHideBoutonCopy
        '
        Me.TutoHideBoutonCopy.Location = New System.Drawing.Point(1119, 5)
        Me.TutoHideBoutonCopy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideBoutonCopy.Name = "TutoHideBoutonCopy"
        Me.TutoHideBoutonCopy.Size = New System.Drawing.Size(43, 28)
        Me.TutoHideBoutonCopy.TabIndex = 30
        Me.TutoHideBoutonCopy.TabStop = False
        '
        'TutoHideOuCopier
        '
        Me.TutoHideOuCopier.Location = New System.Drawing.Point(967, 5)
        Me.TutoHideOuCopier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideOuCopier.Name = "TutoHideOuCopier"
        Me.TutoHideOuCopier.Size = New System.Drawing.Size(116, 28)
        Me.TutoHideOuCopier.TabIndex = 26
        Me.TutoHideOuCopier.TabStop = False
        '
        'TutoHideSimpleMode
        '
        Me.TutoHideSimpleMode.Location = New System.Drawing.Point(712, 2)
        Me.TutoHideSimpleMode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideSimpleMode.Name = "TutoHideSimpleMode"
        Me.TutoHideSimpleMode.Size = New System.Drawing.Size(56, 28)
        Me.TutoHideSimpleMode.TabIndex = 43
        Me.TutoHideSimpleMode.TabStop = False
        '
        'TutoHideQuoiCopier
        '
        Me.TutoHideQuoiCopier.Location = New System.Drawing.Point(876, 5)
        Me.TutoHideQuoiCopier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideQuoiCopier.Name = "TutoHideQuoiCopier"
        Me.TutoHideQuoiCopier.Size = New System.Drawing.Size(83, 28)
        Me.TutoHideQuoiCopier.TabIndex = 27
        Me.TutoHideQuoiCopier.TabStop = False
        '
        'TutoHideSelectionIndic
        '
        Me.TutoHideSelectionIndic.Location = New System.Drawing.Point(823, 5)
        Me.TutoHideSelectionIndic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideSelectionIndic.Name = "TutoHideSelectionIndic"
        Me.TutoHideSelectionIndic.Size = New System.Drawing.Size(45, 28)
        Me.TutoHideSelectionIndic.TabIndex = 28
        Me.TutoHideSelectionIndic.TabStop = False
        '
        'TutoHideUSB
        '
        Me.TutoHideUSB.Location = New System.Drawing.Point(777, 5)
        Me.TutoHideUSB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideUSB.Name = "TutoHideUSB"
        Me.TutoHideUSB.Size = New System.Drawing.Size(37, 28)
        Me.TutoHideUSB.TabIndex = 23
        Me.TutoHideUSB.TabStop = False
        '
        'TutoHideGameList
        '
        Me.TutoHideGameList.Location = New System.Drawing.Point(345, 2)
        Me.TutoHideGameList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideGameList.Name = "TutoHideGameList"
        Me.TutoHideGameList.Size = New System.Drawing.Size(99, 26)
        Me.TutoHideGameList.TabIndex = 24
        Me.TutoHideGameList.TabStop = False
        '
        'TutoHideRomInfo
        '
        Me.TutoHideRomInfo.Location = New System.Drawing.Point(545, 2)
        Me.TutoHideRomInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideRomInfo.Name = "TutoHideRomInfo"
        Me.TutoHideRomInfo.Size = New System.Drawing.Size(44, 26)
        Me.TutoHideRomInfo.TabIndex = 22
        Me.TutoHideRomInfo.TabStop = False
        '
        'TutoHideFinalGrid
        '
        Me.TutoHideFinalGrid.Location = New System.Drawing.Point(452, 2)
        Me.TutoHideFinalGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TutoHideFinalGrid.Name = "TutoHideFinalGrid"
        Me.TutoHideFinalGrid.Size = New System.Drawing.Size(85, 26)
        Me.TutoHideFinalGrid.TabIndex = 20
        Me.TutoHideFinalGrid.TabStop = False
        '
        'GroupCollectEditor
        '
        Me.GroupCollectEditor.BackColor = System.Drawing.Color.DarkMagenta
        Me.GroupCollectEditor.Controls.Add(Me.ValidCell)
        Me.GroupCollectEditor.Controls.Add(Me.Label19)
        Me.GroupCollectEditor.Controls.Add(Me.ButtonHideEditor)
        Me.GroupCollectEditor.Controls.Add(Me.CollectionGridDetaille)
        Me.GroupCollectEditor.Controls.Add(Me.ConfirmEditInfoonCollection)
        Me.GroupCollectEditor.Controls.Add(Me.Label17)
        Me.GroupCollectEditor.Controls.Add(Me.CollectionEditorList)
        Me.GroupCollectEditor.ForeColor = System.Drawing.Color.White
        Me.GroupCollectEditor.Location = New System.Drawing.Point(231, 2)
        Me.GroupCollectEditor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupCollectEditor.Name = "GroupCollectEditor"
        Me.GroupCollectEditor.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupCollectEditor.Size = New System.Drawing.Size(64, 28)
        Me.GroupCollectEditor.TabIndex = 50
        Me.GroupCollectEditor.TabStop = False
        Me.GroupCollectEditor.Text = "Editeur d'Infos des Collections Avancé"
        '
        'ValidCell
        '
        Me.ValidCell.BackColor = System.Drawing.Color.Orchid
        Me.ValidCell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ValidCell.Cursor = System.Windows.Forms.Cursors.Default
        Me.ValidCell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ValidCell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
        Me.ValidCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ValidCell.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValidCell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ValidCell.Location = New System.Drawing.Point(165, 406)
        Me.ValidCell.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ValidCell.Name = "ValidCell"
        Me.ValidCell.Size = New System.Drawing.Size(176, 38)
        Me.ValidCell.TabIndex = 52
        Me.ValidCell.Text = "Valider la Cellule"
        Me.ValidCell.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(195, 36)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(415, 51)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Vous Pouvez DEPLACER, REDUIRE les Colonnes à votre Guise." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FLECHES" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "= Deplacement" &
    " Cellule" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLIC S/ CELLULE" & Global.Microsoft.VisualBasic.ChrW(9) & "= Valider"
        '
        'ButtonHideEditor
        '
        Me.ButtonHideEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonHideEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonHideEditor.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonHideEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonHideEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonHideEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHideEditor.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHideEditor.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonHideEditor.Location = New System.Drawing.Point(8, 406)
        Me.ButtonHideEditor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonHideEditor.Name = "ButtonHideEditor"
        Me.ButtonHideEditor.Size = New System.Drawing.Size(125, 38)
        Me.ButtonHideEditor.TabIndex = 50
        Me.ButtonHideEditor.Text = "Cacher l'Editeur"
        Me.ButtonHideEditor.UseVisualStyleBackColor = False
        '
        'CollectionGridDetaille
        '
        Me.CollectionGridDetaille.AllowUserToAddRows = False
        Me.CollectionGridDetaille.AllowUserToDeleteRows = False
        Me.CollectionGridDetaille.AllowUserToOrderColumns = True
        Me.CollectionGridDetaille.AllowUserToResizeRows = False
        Me.CollectionGridDetaille.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.CollectionGridDetaille.ColumnHeadersHeight = 29
        Me.CollectionGridDetaille.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CollectionGridDetaille.DefaultCellStyle = DataGridViewCellStyle1
        Me.CollectionGridDetaille.Location = New System.Drawing.Point(7, 86)
        Me.CollectionGridDetaille.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CollectionGridDetaille.MultiSelect = False
        Me.CollectionGridDetaille.Name = "CollectionGridDetaille"
        Me.CollectionGridDetaille.ReadOnly = True
        Me.CollectionGridDetaille.RowHeadersVisible = False
        Me.CollectionGridDetaille.RowHeadersWidth = 51
        Me.CollectionGridDetaille.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CollectionGridDetaille.RowTemplate.Height = 24
        Me.CollectionGridDetaille.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.CollectionGridDetaille.Size = New System.Drawing.Size(681, 314)
        Me.CollectionGridDetaille.TabIndex = 50
        '
        'ConfirmEditInfoonCollection
        '
        Me.ConfirmEditInfoonCollection.BackColor = System.Drawing.Color.Gold
        Me.ConfirmEditInfoonCollection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ConfirmEditInfoonCollection.Cursor = System.Windows.Forms.Cursors.Default
        Me.ConfirmEditInfoonCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ConfirmEditInfoonCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.ConfirmEditInfoonCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmEditInfoonCollection.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmEditInfoonCollection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ConfirmEditInfoonCollection.Location = New System.Drawing.Point(368, 406)
        Me.ConfirmEditInfoonCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ConfirmEditInfoonCollection.Name = "ConfirmEditInfoonCollection"
        Me.ConfirmEditInfoonCollection.Size = New System.Drawing.Size(320, 38)
        Me.ConfirmEditInfoonCollection.TabIndex = 40
        Me.ConfirmEditInfoonCollection.Text = "Sauvegarder les Changements dans les GameLists"
        Me.ConfirmEditInfoonCollection.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 68)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 17)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Roms de la Collection : "
        '
        'CollectionEditorList
        '
        Me.CollectionEditorList.FormattingEnabled = True
        Me.CollectionEditorList.Location = New System.Drawing.Point(7, 23)
        Me.CollectionEditorList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CollectionEditorList.Name = "CollectionEditorList"
        Me.CollectionEditorList.Size = New System.Drawing.Size(157, 24)
        Me.CollectionEditorList.TabIndex = 1
        '
        'CellEnGrand
        '
        Me.CellEnGrand.BackColor = System.Drawing.Color.LavenderBlush
        Me.CellEnGrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CellEnGrand.Location = New System.Drawing.Point(296, 2)
        Me.CellEnGrand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CellEnGrand.Name = "CellEnGrand"
        Me.CellEnGrand.Size = New System.Drawing.Size(15, 26)
        Me.CellEnGrand.TabIndex = 52
        Me.CellEnGrand.Text = ""
        '
        'ExportExcel
        '
        Me.ExportExcel.BackColor = System.Drawing.Color.DarkOrange
        Me.ExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExportExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.ExportExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ExportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExportExcel.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExportExcel.Image = CType(resources.GetObject("ExportExcel.Image"), System.Drawing.Image)
        Me.ExportExcel.Location = New System.Drawing.Point(301, 1)
        Me.ExportExcel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ExportExcel.Name = "ExportExcel"
        Me.ExportExcel.Size = New System.Drawing.Size(143, 30)
        Me.ExportExcel.TabIndex = 53
        Me.ExportExcel.Text = "Exporter vers Excel"
        Me.ExportExcel.UseVisualStyleBackColor = False
        '
        'ImportToRecopierBox
        '
        Me.ImportToRecopierBox.BackColor = System.Drawing.Color.DarkOrange
        Me.ImportToRecopierBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ImportToRecopierBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImportToRecopierBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ImportToRecopierBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ImportToRecopierBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ImportToRecopierBox.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportToRecopierBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ImportToRecopierBox.Image = CType(resources.GetObject("ImportToRecopierBox.Image"), System.Drawing.Image)
        Me.ImportToRecopierBox.Location = New System.Drawing.Point(623, 1)
        Me.ImportToRecopierBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImportToRecopierBox.Name = "ImportToRecopierBox"
        Me.ImportToRecopierBox.Size = New System.Drawing.Size(188, 30)
        Me.ImportToRecopierBox.TabIndex = 54
        Me.ImportToRecopierBox.Text = "Importer vers RecopierBox"
        Me.ImportToRecopierBox.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'checkroms
        '
        Me.checkroms.AutoSize = True
        Me.checkroms.Checked = True
        Me.checkroms.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkroms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.checkroms.Location = New System.Drawing.Point(92, 13)
        Me.checkroms.Margin = New System.Windows.Forms.Padding(4)
        Me.checkroms.Name = "checkroms"
        Me.checkroms.Size = New System.Drawing.Size(66, 21)
        Me.checkroms.TabIndex = 10
        Me.checkroms.Text = "Roms"
        Me.checkroms.UseVisualStyleBackColor = True
        '
        'CopyRoms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1355, 742)
        Me.Controls.Add(Me.ImportToRecopierBox)
        Me.Controls.Add(Me.ExportExcel)
        Me.Controls.Add(Me.CellEnGrand)
        Me.Controls.Add(Me.GroupCollectEditor)
        Me.Controls.Add(Me.LabelCollection)
        Me.Controls.Add(Me.GroupCollections)
        Me.Controls.Add(Me.ButtonCollection)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1373, 789)
        Me.MinimumSize = New System.Drawing.Size(1373, 789)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBoxBoutonsMedias.ResumeLayout(False)
        Me.GroupBoxBoutonsMedias.PerformLayout()
        CType(Me.RomImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vid_romvid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupFiltresAvances.ResumeLayout(False)
        Me.GroupFiltresAvances.PerformLayout()
        Me.GroupMode.ResumeLayout(False)
        Me.GroupMode.PerformLayout()
        Me.GroupBoxSelectionRoms.ResumeLayout(False)
        Me.GroupBoxSelectionRoms.PerformLayout()
        Me.GroupCollections.ResumeLayout(False)
        Me.GroupCollections.PerformLayout()
        CType(Me.CollectionGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoSelectionActuelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideFiltresAvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideBoutonCopy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideOuCopier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideSimpleMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideQuoiCopier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideSelectionIndic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideUSB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideGameList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideRomInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoHideFinalGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCollectEditor.ResumeLayout(False)
        Me.GroupCollectEditor.PerformLayout()
        CType(Me.CollectionGridDetaille, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBoxBoutonsMedias As GroupBox
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
    Friend WithEvents LabelCollection As Label
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
    Friend WithEvents ButtonCollectionAvance As Button
    Friend WithEvents GroupCollectEditor As GroupBox
    Friend WithEvents ButtonHideEditor As Button
    Friend WithEvents ConfirmEditInfoonCollection As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents CollectionEditorList As ComboBox
    Friend WithEvents CollectionGridDetaille As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents CellEnGrand As RichTextBox
    Friend WithEvents ValidCell As Button
    Friend WithEvents ExportExcel As Button
    Friend WithEvents ImportToRecopierBox As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents checkroms As CheckBox
End Class
