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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OverlaySingle = New System.Windows.Forms.TextBox()
        Me.OverlayTotal = New System.Windows.Forms.TextBox()
        Me.ButtonMenage = New System.Windows.Forms.Button()
        Me.buttonImportRoms = New System.Windows.Forms.Button()
        Me.ButtonImportOverlays = New System.Windows.Forms.Button()
        Me.ButtonGetBack = New System.Windows.Forms.Button()
        Me.GameLists = New System.Windows.Forms.ListBox()
        Me.DataGridOverlay = New System.Windows.Forms.DataGridView()
        Me.ImportBoth = New System.Windows.Forms.Button()
        Me.ListToSupp = New System.Windows.Forms.ListBox()
        Me.ListdesFichiersEnTrop = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridRoms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(137, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Liste de Toutes les Roms Gamelistées"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(510, 50)
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
        Me.DataGridRoms.Location = New System.Drawing.Point(134, 71)
        Me.DataGridRoms.Name = "DataGridRoms"
        Me.DataGridRoms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRoms.Size = New System.Drawing.Size(367, 284)
        Me.DataGridRoms.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(134, 361)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(367, 62)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "La liste de toutes vos roms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La coche à droite permet de savoir si un overlay est" &
    " disponible ou non."
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox2.Location = New System.Drawing.Point(507, 195)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(367, 62)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "La liste de tous les Overlays." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "La coche à droite permets de savoir si une rom es" &
    "t associée ou non." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si un overlay n'est pas associé, cela veut dire que vous ave" &
    "z un overlay orphelin."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.RomTotalOverlay)
        Me.GroupBox1.Controls.Add(Me.RomTotal)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(134, 429)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 89)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outils Roms :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total de Roms avec Overlay"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total de Roms"
        '
        'RomTotalOverlay
        '
        Me.RomTotalOverlay.Location = New System.Drawing.Point(195, 54)
        Me.RomTotalOverlay.Name = "RomTotalOverlay"
        Me.RomTotalOverlay.Size = New System.Drawing.Size(67, 20)
        Me.RomTotalOverlay.TabIndex = 16
        Me.RomTotalOverlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RomTotal
        '
        Me.RomTotal.Location = New System.Drawing.Point(195, 18)
        Me.RomTotal.Name = "RomTotal"
        Me.RomTotal.Size = New System.Drawing.Size(67, 20)
        Me.RomTotal.TabIndex = 15
        Me.RomTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Teal
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.OverlaySingle)
        Me.GroupBox2.Controls.Add(Me.OverlayTotal)
        Me.GroupBox2.Controls.Add(Me.ButtonMenage)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(507, 429)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 89)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outils Overlays :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total d'Overlays"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total d'Overlay Orphelins"
        '
        'OverlaySingle
        '
        Me.OverlaySingle.Location = New System.Drawing.Point(150, 54)
        Me.OverlaySingle.Name = "OverlaySingle"
        Me.OverlaySingle.Size = New System.Drawing.Size(67, 20)
        Me.OverlaySingle.TabIndex = 17
        Me.OverlaySingle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OverlayTotal
        '
        Me.OverlayTotal.Location = New System.Drawing.Point(150, 22)
        Me.OverlayTotal.Name = "OverlayTotal"
        Me.OverlayTotal.Size = New System.Drawing.Size(67, 20)
        Me.OverlayTotal.TabIndex = 16
        Me.OverlayTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonMenage
        '
        Me.ButtonMenage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMenage.Location = New System.Drawing.Point(234, 22)
        Me.ButtonMenage.Name = "ButtonMenage"
        Me.ButtonMenage.Size = New System.Drawing.Size(127, 52)
        Me.ButtonMenage.TabIndex = 6
        Me.ButtonMenage.Text = "Supprimer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "les Overlays Orphelins"
        Me.ButtonMenage.UseVisualStyleBackColor = True
        '
        'buttonImportRoms
        '
        Me.buttonImportRoms.Location = New System.Drawing.Point(401, 42)
        Me.buttonImportRoms.Name = "buttonImportRoms"
        Me.buttonImportRoms.Size = New System.Drawing.Size(100, 23)
        Me.buttonImportRoms.TabIndex = 11
        Me.buttonImportRoms.Text = "Importer les Roms"
        Me.buttonImportRoms.UseVisualStyleBackColor = True
        '
        'ButtonImportOverlays
        '
        Me.ButtonImportOverlays.Location = New System.Drawing.Point(741, 43)
        Me.ButtonImportOverlays.Name = "ButtonImportOverlays"
        Me.ButtonImportOverlays.Size = New System.Drawing.Size(133, 23)
        Me.ButtonImportOverlays.TabIndex = 12
        Me.ButtonImportOverlays.Text = "Importer les Overlays"
        Me.ButtonImportOverlays.UseVisualStyleBackColor = True
        '
        'ButtonGetBack
        '
        Me.ButtonGetBack.Location = New System.Drawing.Point(12, 12)
        Me.ButtonGetBack.Name = "ButtonGetBack"
        Me.ButtonGetBack.Size = New System.Drawing.Size(116, 23)
        Me.ButtonGetBack.TabIndex = 13
        Me.ButtonGetBack.Text = "Retour Au Menu"
        Me.ButtonGetBack.UseVisualStyleBackColor = True
        '
        'GameLists
        '
        Me.GameLists.FormattingEnabled = True
        Me.GameLists.Location = New System.Drawing.Point(12, 72)
        Me.GameLists.Name = "GameLists"
        Me.GameLists.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.GameLists.Size = New System.Drawing.Size(116, 355)
        Me.GameLists.TabIndex = 14
        '
        'DataGridOverlay
        '
        Me.DataGridOverlay.AllowUserToOrderColumns = True
        Me.DataGridOverlay.AllowUserToResizeRows = False
        Me.DataGridOverlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOverlay.Location = New System.Drawing.Point(507, 71)
        Me.DataGridOverlay.Name = "DataGridOverlay"
        Me.DataGridOverlay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridOverlay.Size = New System.Drawing.Size(367, 118)
        Me.DataGridOverlay.TabIndex = 15
        '
        'ImportBoth
        '
        Me.ImportBoth.BackColor = System.Drawing.Color.FloralWhite
        Me.ImportBoth.Location = New System.Drawing.Point(418, 1)
        Me.ImportBoth.Name = "ImportBoth"
        Me.ImportBoth.Size = New System.Drawing.Size(157, 34)
        Me.ImportBoth.TabIndex = 16
        Me.ImportBoth.Text = "Importer Roms + Overlays"
        Me.ImportBoth.UseVisualStyleBackColor = False
        '
        'ListToSupp
        '
        Me.ListToSupp.BackColor = System.Drawing.Color.Silver
        Me.ListToSupp.FormattingEnabled = True
        Me.ListToSupp.Location = New System.Drawing.Point(507, 273)
        Me.ListToSupp.Name = "ListToSupp"
        Me.ListToSupp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListToSupp.Size = New System.Drawing.Size(367, 56)
        Me.ListToSupp.TabIndex = 17
        '
        'ListdesFichiersEnTrop
        '
        Me.ListdesFichiersEnTrop.BackColor = System.Drawing.Color.LightPink
        Me.ListdesFichiersEnTrop.FormattingEnabled = True
        Me.ListdesFichiersEnTrop.Location = New System.Drawing.Point(507, 351)
        Me.ListdesFichiersEnTrop.Name = "ListdesFichiersEnTrop"
        Me.ListdesFichiersEnTrop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListdesFichiersEnTrop.Size = New System.Drawing.Size(367, 69)
        Me.ListdesFichiersEnTrop.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(638, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Liste d'Overlays Principaux Sans Rom Associés :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(558, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(322, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Liste des fichiers cités ci-dessus et qui deviennent donc Orphelins :"
        '
        'OverlayManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(884, 521)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListdesFichiersEnTrop)
        Me.Controls.Add(Me.ListToSupp)
        Me.Controls.Add(Me.ImportBoth)
        Me.Controls.Add(Me.DataGridOverlay)
        Me.Controls.Add(Me.GameLists)
        Me.Controls.Add(Me.ButtonGetBack)
        Me.Controls.Add(Me.ButtonImportOverlays)
        Me.Controls.Add(Me.buttonImportRoms)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridRoms)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(900, 570)
        Me.MinimumSize = New System.Drawing.Size(826, 560)
        Me.Name = "OverlayManager"
        Me.Text = "OverlayManager"
        CType(Me.DataGridRoms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridOverlay, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButtonMenage As Button
    Friend WithEvents buttonImportRoms As Button
    Friend WithEvents ButtonImportOverlays As Button
    Friend WithEvents ButtonGetBack As Button
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
    Friend WithEvents ImportBoth As Button
    Friend WithEvents ListToSupp As ListBox
    Friend WithEvents ListdesFichiersEnTrop As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
