<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveManager
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
        Me.ButtonImportSaves1 = New System.Windows.Forms.Button()
        Me.buttonImportRoms1 = New System.Windows.Forms.Button()
        Me.ButtonGetBack1 = New System.Windows.Forms.Button()
        Me.ImportBoth1 = New System.Windows.Forms.Button()
        Me.DataGridSave = New System.Windows.Forms.DataGridView()
        Me.GameLists = New System.Windows.Forms.ListBox()
        Me.ButtonMenage1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RomTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SaveSingle = New System.Windows.Forms.TextBox()
        Me.SaveTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RomTotalSave = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridRoms = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListdesFichiersEnTrop = New System.Windows.Forms.ListBox()
        Me.ListSaves = New System.Windows.Forms.ListBox()
        Me.ButtonSuppSave = New System.Windows.Forms.Button()
        CType(Me.DataGridSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridRoms, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ButtonImportSaves1.Location = New System.Drawing.Point(758, 38)
        Me.ButtonImportSaves1.Name = "ButtonImportSaves1"
        Me.ButtonImportSaves1.Size = New System.Drawing.Size(116, 30)
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
        Me.buttonImportRoms1.Location = New System.Drawing.Point(385, 40)
        Me.buttonImportRoms1.Name = "buttonImportRoms1"
        Me.buttonImportRoms1.Size = New System.Drawing.Size(116, 30)
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
        Me.ButtonGetBack1.Location = New System.Drawing.Point(12, 12)
        Me.ButtonGetBack1.Name = "ButtonGetBack1"
        Me.ButtonGetBack1.Size = New System.Drawing.Size(116, 23)
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
        Me.ImportBoth1.Location = New System.Drawing.Point(507, 5)
        Me.ImportBoth1.Name = "ImportBoth1"
        Me.ImportBoth1.Size = New System.Drawing.Size(116, 30)
        Me.ImportBoth1.TabIndex = 55
        Me.ImportBoth1.Text = "Tout Importer"
        Me.ImportBoth1.UseVisualStyleBackColor = False
        '
        'DataGridSave
        '
        Me.DataGridSave.AllowUserToOrderColumns = True
        Me.DataGridSave.AllowUserToResizeRows = False
        Me.DataGridSave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSave.Location = New System.Drawing.Point(507, 76)
        Me.DataGridSave.Name = "DataGridSave"
        Me.DataGridSave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSave.Size = New System.Drawing.Size(367, 220)
        Me.DataGridSave.TabIndex = 50
        '
        'GameLists
        '
        Me.GameLists.FormattingEnabled = True
        Me.GameLists.Location = New System.Drawing.Point(12, 77)
        Me.GameLists.Name = "GameLists"
        Me.GameLists.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.GameLists.Size = New System.Drawing.Size(116, 355)
        Me.GameLists.TabIndex = 49
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
        Me.ButtonMenage1.Location = New System.Drawing.Point(245, 18)
        Me.ButtonMenage1.Name = "ButtonMenage1"
        Me.ButtonMenage1.Size = New System.Drawing.Size(116, 55)
        Me.ButtonMenage1.TabIndex = 42
        Me.ButtonMenage1.Text = "Supprimer les Saves Orphelines"
        Me.ButtonMenage1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total de Saves"
        '
        'RomTotal
        '
        Me.RomTotal.Location = New System.Drawing.Point(294, 18)
        Me.RomTotal.Name = "RomTotal"
        Me.RomTotal.Size = New System.Drawing.Size(67, 20)
        Me.RomTotal.TabIndex = 15
        Me.RomTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total de Saves Orphelines"
        '
        'SaveSingle
        '
        Me.SaveSingle.Location = New System.Drawing.Point(150, 54)
        Me.SaveSingle.Name = "SaveSingle"
        Me.SaveSingle.Size = New System.Drawing.Size(67, 20)
        Me.SaveSingle.TabIndex = 17
        Me.SaveSingle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SaveTotal
        '
        Me.SaveTotal.Location = New System.Drawing.Point(150, 22)
        Me.SaveTotal.Name = "SaveTotal"
        Me.SaveTotal.Size = New System.Drawing.Size(67, 20)
        Me.SaveTotal.TabIndex = 16
        Me.SaveTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total de Roms avec Saves"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total de Roms"
        '
        'RomTotalSave
        '
        Me.RomTotalSave.Location = New System.Drawing.Point(294, 54)
        Me.RomTotalSave.Name = "RomTotalSave"
        Me.RomTotalSave.Size = New System.Drawing.Size(67, 20)
        Me.RomTotalSave.TabIndex = 16
        Me.RomTotalSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.ButtonMenage1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.SaveSingle)
        Me.GroupBox2.Controls.Add(Me.SaveTotal)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(507, 434)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 89)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outils Overlays :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ButtonSuppSave)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RomTotalSave)
        Me.GroupBox1.Controls.Add(Me.RomTotal)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(134, 434)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 89)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outils Roms :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Bisque
        Me.TextBox2.Location = New System.Drawing.Point(507, 302)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(367, 62)
        Me.TextBox2.TabIndex = 46
        Me.TextBox2.Text = "La liste de toutes les Saves." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La coche à droite permets de savoir si une rom est" &
    " associée ou non." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si une save n'est pas associé, cela veut dire que cette Save " &
    "est orpheline."
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Lavender
        Me.TextBox1.Location = New System.Drawing.Point(134, 302)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(367, 62)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Text = "La liste de toutes vos roms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La coche à droite permet de savoir si une save est d" &
    "isponible ou non."
        '
        'DataGridRoms
        '
        Me.DataGridRoms.AllowUserToOrderColumns = True
        Me.DataGridRoms.AllowUserToResizeRows = False
        Me.DataGridRoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRoms.Location = New System.Drawing.Point(134, 76)
        Me.DataGridRoms.Name = "DataGridRoms"
        Me.DataGridRoms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRoms.Size = New System.Drawing.Size(367, 220)
        Me.DataGridRoms.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(510, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Liste de Toutes les Saves"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(137, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Liste de Toutes les Roms Gamelistées"
        '
        'ListdesFichiersEnTrop
        '
        Me.ListdesFichiersEnTrop.FormattingEnabled = True
        Me.ListdesFichiersEnTrop.Location = New System.Drawing.Point(507, 371)
        Me.ListdesFichiersEnTrop.Name = "ListdesFichiersEnTrop"
        Me.ListdesFichiersEnTrop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListdesFichiersEnTrop.Size = New System.Drawing.Size(367, 56)
        Me.ListdesFichiersEnTrop.TabIndex = 59
        '
        'ListSaves
        '
        Me.ListSaves.FormattingEnabled = True
        Me.ListSaves.Location = New System.Drawing.Point(134, 370)
        Me.ListSaves.Name = "ListSaves"
        Me.ListSaves.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListSaves.Size = New System.Drawing.Size(367, 56)
        Me.ListSaves.TabIndex = 60
        '
        'ButtonSuppSave
        '
        Me.ButtonSuppSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ButtonSuppSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonSuppSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonSuppSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonSuppSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonSuppSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSuppSave.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSuppSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSuppSave.Location = New System.Drawing.Point(6, 22)
        Me.ButtonSuppSave.Name = "ButtonSuppSave"
        Me.ButtonSuppSave.Size = New System.Drawing.Size(124, 30)
        Me.ButtonSuppSave.TabIndex = 61
        Me.ButtonSuppSave.Text = "Supprimer la Selection"
        Me.ButtonSuppSave.UseVisualStyleBackColor = False
        '
        'SaveManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 532)
        Me.Controls.Add(Me.ListSaves)
        Me.Controls.Add(Me.ListdesFichiersEnTrop)
        Me.Controls.Add(Me.ButtonImportSaves1)
        Me.Controls.Add(Me.buttonImportRoms1)
        Me.Controls.Add(Me.ButtonGetBack1)
        Me.Controls.Add(Me.ImportBoth1)
        Me.Controls.Add(Me.DataGridSave)
        Me.Controls.Add(Me.GameLists)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridRoms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SaveManager"
        Me.Text = "SaveManager"
        CType(Me.DataGridSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridRoms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonImportSaves1 As Button
    Friend WithEvents buttonImportRoms1 As Button
    Friend WithEvents ButtonGetBack1 As Button
    Friend WithEvents ImportBoth1 As Button
    Friend WithEvents DataGridSave As DataGridView
    Friend WithEvents GameLists As ListBox
    Friend WithEvents ButtonMenage1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents RomTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveSingle As TextBox
    Friend WithEvents SaveTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RomTotalSave As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridRoms As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListdesFichiersEnTrop As ListBox
    Friend WithEvents ListSaves As ListBox
    Friend WithEvents ButtonSuppSave As Button
End Class
