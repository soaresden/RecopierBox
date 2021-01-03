<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverlaysConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverlaysConverter))
        Me.CheckBoxRecalbox = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBatocera = New System.Windows.Forms.CheckBox()
        Me.ButtonGetBack1 = New System.Windows.Forms.Button()
        Me.GameLists = New System.Windows.Forms.ListBox()
        Me.DataGridOverlays = New System.Windows.Forms.DataGridView()
        Me.ButtonImportAll = New System.Windows.Forms.Button()
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextCombobox = New System.Windows.Forms.Label()
        Me.ListErreurs = New System.Windows.Forms.ListBox()
        Me.RqtARRM = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Supp1 = New System.Windows.Forms.Button()
        Me.Supp2 = New System.Windows.Forms.Button()
        Me.Supp3 = New System.Windows.Forms.Button()
        Me.Supp123 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridOverlays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxRecalbox
        '
        Me.CheckBoxRecalbox.AutoSize = True
        Me.CheckBoxRecalbox.Location = New System.Drawing.Point(8, 54)
        Me.CheckBoxRecalbox.Name = "CheckBoxRecalbox"
        Me.CheckBoxRecalbox.Size = New System.Drawing.Size(220, 17)
        Me.CheckBoxRecalbox.TabIndex = 1
        Me.CheckBoxRecalbox.Text = "Overlays Recalbox --> Overlays Batocera"
        Me.CheckBoxRecalbox.UseVisualStyleBackColor = True
        '
        'CheckBoxBatocera
        '
        Me.CheckBoxBatocera.AutoSize = True
        Me.CheckBoxBatocera.Location = New System.Drawing.Point(8, 76)
        Me.CheckBoxBatocera.Name = "CheckBoxBatocera"
        Me.CheckBoxBatocera.Size = New System.Drawing.Size(220, 17)
        Me.CheckBoxBatocera.TabIndex = 2
        Me.CheckBoxBatocera.Text = "Overlays Batocera --> Overlays Recalbox"
        Me.CheckBoxBatocera.UseVisualStyleBackColor = True
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
        Me.ButtonGetBack1.Location = New System.Drawing.Point(8, 6)
        Me.ButtonGetBack1.Name = "ButtonGetBack1"
        Me.ButtonGetBack1.Size = New System.Drawing.Size(116, 23)
        Me.ButtonGetBack1.TabIndex = 40
        Me.ButtonGetBack1.Text = "Retour aux Overlays"
        Me.ButtonGetBack1.UseVisualStyleBackColor = False
        '
        'GameLists
        '
        Me.GameLists.FormattingEnabled = True
        Me.GameLists.Location = New System.Drawing.Point(8, 99)
        Me.GameLists.Name = "GameLists"
        Me.GameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.GameLists.Size = New System.Drawing.Size(121, 303)
        Me.GameLists.TabIndex = 41
        '
        'DataGridOverlays
        '
        Me.DataGridOverlays.AllowUserToAddRows = False
        Me.DataGridOverlays.AllowUserToDeleteRows = False
        Me.DataGridOverlays.AllowUserToResizeRows = False
        Me.DataGridOverlays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOverlays.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridOverlays.Location = New System.Drawing.Point(135, 158)
        Me.DataGridOverlays.MultiSelect = False
        Me.DataGridOverlays.Name = "DataGridOverlays"
        Me.DataGridOverlays.ReadOnly = True
        Me.DataGridOverlays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridOverlays.Size = New System.Drawing.Size(667, 244)
        Me.DataGridOverlays.TabIndex = 42
        '
        'ButtonImportAll
        '
        Me.ButtonImportAll.BackColor = System.Drawing.Color.Green
        Me.ButtonImportAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonImportAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonImportAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonImportAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonImportAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonImportAll.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImportAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonImportAll.Location = New System.Drawing.Point(8, 414)
        Me.ButtonImportAll.Name = "ButtonImportAll"
        Me.ButtonImportAll.Size = New System.Drawing.Size(121, 47)
        Me.ButtonImportAll.TabIndex = 43
        Me.ButtonImportAll.Text = "Importer les fichiers Configs selectionnés"
        Me.ButtonImportAll.UseVisualStyleBackColor = False
        '
        'ButtonConvert
        '
        Me.ButtonConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonConvert.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonConvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConvert.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonConvert.Location = New System.Drawing.Point(808, 42)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(120, 39)
        Me.ButtonConvert.TabIndex = 44
        Me.ButtonConvert.Text = "Lancer la Conversion"
        Me.ButtonConvert.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(808, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 45
        '
        'TextCombobox
        '
        Me.TextCombobox.AutoSize = True
        Me.TextCombobox.Location = New System.Drawing.Point(805, -1)
        Me.TextCombobox.Name = "TextCombobox"
        Me.TextCombobox.Size = New System.Drawing.Size(128, 13)
        Me.TextCombobox.TabIndex = 46
        Me.TextCombobox.Text = "Nom du Dossier Batocera"
        '
        'ListErreurs
        '
        Me.ListErreurs.FormattingEnabled = True
        Me.ListErreurs.Location = New System.Drawing.Point(808, 121)
        Me.ListErreurs.Name = "ListErreurs"
        Me.ListErreurs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListErreurs.Size = New System.Drawing.Size(120, 290)
        Me.ListErreurs.TabIndex = 47
        '
        'RqtARRM
        '
        Me.RqtARRM.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.RqtARRM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RqtARRM.Cursor = System.Windows.Forms.Cursors.Default
        Me.RqtARRM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.RqtARRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.RqtARRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RqtARRM.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RqtARRM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RqtARRM.Location = New System.Drawing.Point(808, 413)
        Me.RqtARRM.Name = "RqtARRM"
        Me.RqtARRM.Size = New System.Drawing.Size(120, 48)
        Me.RqtARRM.TabIndex = 48
        Me.RqtARRM.Text = "Copier la Requete pour ARRM"
        Me.RqtARRM.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TextBox1.Location = New System.Drawing.Point(357, 6)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(445, 136)
        Me.TextBox1.TabIndex = 49
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Supp1
        '
        Me.Supp1.BackColor = System.Drawing.Color.Coral
        Me.Supp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Supp1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Supp1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Supp1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Supp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Supp1.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supp1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Supp1.Location = New System.Drawing.Point(167, 414)
        Me.Supp1.Name = "Supp1"
        Me.Supp1.Size = New System.Drawing.Size(121, 47)
        Me.Supp1.TabIndex = 50
        Me.Supp1.Text = "Supprimer le fichier 1"
        Me.Supp1.UseVisualStyleBackColor = False
        '
        'Supp2
        '
        Me.Supp2.BackColor = System.Drawing.Color.Coral
        Me.Supp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Supp2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Supp2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Supp2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Supp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Supp2.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supp2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Supp2.Location = New System.Drawing.Point(310, 414)
        Me.Supp2.Name = "Supp2"
        Me.Supp2.Size = New System.Drawing.Size(121, 47)
        Me.Supp2.TabIndex = 51
        Me.Supp2.Text = "Supprimer le fichier 2"
        Me.Supp2.UseVisualStyleBackColor = False
        '
        'Supp3
        '
        Me.Supp3.BackColor = System.Drawing.Color.Coral
        Me.Supp3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Supp3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Supp3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Supp3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Supp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Supp3.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supp3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Supp3.Location = New System.Drawing.Point(450, 414)
        Me.Supp3.Name = "Supp3"
        Me.Supp3.Size = New System.Drawing.Size(121, 47)
        Me.Supp3.TabIndex = 52
        Me.Supp3.Text = "Supprimer le fichier 3"
        Me.Supp3.UseVisualStyleBackColor = False
        '
        'Supp123
        '
        Me.Supp123.BackColor = System.Drawing.Color.Firebrick
        Me.Supp123.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Supp123.Cursor = System.Windows.Forms.Cursors.Default
        Me.Supp123.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Supp123.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Supp123.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Supp123.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supp123.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Supp123.Location = New System.Drawing.Point(627, 413)
        Me.Supp123.Name = "Supp123"
        Me.Supp123.Size = New System.Drawing.Size(140, 47)
        Me.Supp123.TabIndex = 53
        Me.Supp123.Text = "Supprimer Tout"
        Me.Supp123.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(824, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 26)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Liste Fichiers " & Global.Microsoft.VisualBasic.ChrW(13) & "avec Manquants :"
        '
        'OverlaysConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(929, 467)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Supp123)
        Me.Controls.Add(Me.Supp3)
        Me.Controls.Add(Me.Supp2)
        Me.Controls.Add(Me.Supp1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RqtARRM)
        Me.Controls.Add(Me.ListErreurs)
        Me.Controls.Add(Me.TextCombobox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonConvert)
        Me.Controls.Add(Me.ButtonImportAll)
        Me.Controls.Add(Me.DataGridOverlays)
        Me.Controls.Add(Me.GameLists)
        Me.Controls.Add(Me.ButtonGetBack1)
        Me.Controls.Add(Me.CheckBoxBatocera)
        Me.Controls.Add(Me.CheckBoxRecalbox)
        Me.MaximumSize = New System.Drawing.Size(945, 506)
        Me.MinimumSize = New System.Drawing.Size(945, 506)
        Me.Name = "OverlaysConverter"
        Me.Text = "OverlaysConverter"
        CType(Me.DataGridOverlays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBoxRecalbox As CheckBox
    Friend WithEvents CheckBoxBatocera As CheckBox
    Friend WithEvents ButtonGetBack1 As Button
    Friend WithEvents GameLists As ListBox
    Friend WithEvents DataGridOverlays As DataGridView
    Friend WithEvents ButtonImportAll As Button
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextCombobox As Label
    Friend WithEvents ListErreurs As ListBox
    Friend WithEvents RqtARRM As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Supp1 As Button
    Friend WithEvents Supp2 As Button
    Friend WithEvents Supp3 As Button
    Friend WithEvents Supp123 As Button
    Friend WithEvents Label1 As Label
End Class
