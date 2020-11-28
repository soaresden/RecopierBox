<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverlayManager
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridRoms = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RAvecOverlay = New System.Windows.Forms.CheckBox()
        Me.RSansOverlay = New System.Windows.Forms.CheckBox()
        Me.RAZRoms = New System.Windows.Forms.Button()
        Me.RAZOverlays = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ButtonMenage = New System.Windows.Forms.Button()
        Me.buttonImportRoms = New System.Windows.Forms.Button()
        Me.ButtonImportOverlays = New System.Windows.Forms.Button()
        Me.ButtonGetBack = New System.Windows.Forms.Button()
        Me.GameLists = New System.Windows.Forms.ListBox()
        Me.RomTotal = New System.Windows.Forms.TextBox()
        Me.RomTotalOverlay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridOverlay = New System.Windows.Forms.DataGridView()
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
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Liste de tous les Overlays"
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
        Me.TextBox2.Location = New System.Drawing.Point(507, 361)
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
        Me.GroupBox1.Controls.Add(Me.RAZRoms)
        Me.GroupBox1.Controls.Add(Me.RomTotal)
        Me.GroupBox1.Controls.Add(Me.RSansOverlay)
        Me.GroupBox1.Controls.Add(Me.RAvecOverlay)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(134, 429)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 89)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outils Roms :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Teal
        Me.GroupBox2.Controls.Add(Me.ButtonMenage)
        Me.GroupBox2.Controls.Add(Me.RAZOverlays)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(507, 429)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 89)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Outils Overlays :"
        '
        'RAvecOverlay
        '
        Me.RAvecOverlay.AutoSize = True
        Me.RAvecOverlay.Checked = True
        Me.RAvecOverlay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RAvecOverlay.Location = New System.Drawing.Point(6, 13)
        Me.RAvecOverlay.Name = "RAvecOverlay"
        Me.RAvecOverlay.Size = New System.Drawing.Size(179, 17)
        Me.RAvecOverlay.TabIndex = 0
        Me.RAvecOverlay.Text = "Afficher les Roms avec Overlays"
        Me.RAvecOverlay.UseVisualStyleBackColor = True
        '
        'RSansOverlay
        '
        Me.RSansOverlay.AutoSize = True
        Me.RSansOverlay.Location = New System.Drawing.Point(6, 28)
        Me.RSansOverlay.Name = "RSansOverlay"
        Me.RSansOverlay.Size = New System.Drawing.Size(177, 17)
        Me.RSansOverlay.TabIndex = 1
        Me.RSansOverlay.Text = "Afficher les Roms sans Overlays"
        Me.RSansOverlay.UseVisualStyleBackColor = True
        '
        'RAZRoms
        '
        Me.RAZRoms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RAZRoms.Location = New System.Drawing.Point(65, 44)
        Me.RAZRoms.Name = "RAZRoms"
        Me.RAZRoms.Size = New System.Drawing.Size(68, 23)
        Me.RAZRoms.TabIndex = 2
        Me.RAZRoms.Text = "RAZ"
        Me.RAZRoms.UseVisualStyleBackColor = True
        '
        'RAZOverlays
        '
        Me.RAZOverlays.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RAZOverlays.Location = New System.Drawing.Point(65, 44)
        Me.RAZOverlays.Name = "RAZOverlays"
        Me.RAZOverlays.Size = New System.Drawing.Size(68, 23)
        Me.RAZOverlays.TabIndex = 5
        Me.RAZOverlays.Text = "RAZ"
        Me.RAZOverlays.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(169, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Afficher les Overlays Orphelins"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(6, 13)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(195, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Afficher les Overlays liés à une Rom"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ButtonMenage
        '
        Me.ButtonMenage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonMenage.Location = New System.Drawing.Point(237, 19)
        Me.ButtonMenage.Name = "ButtonMenage"
        Me.ButtonMenage.Size = New System.Drawing.Size(127, 38)
        Me.ButtonMenage.TabIndex = 6
        Me.ButtonMenage.Text = "Supprimer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "les Overlays en Trop"
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
        Me.ButtonGetBack.Location = New System.Drawing.Point(12, 11)
        Me.ButtonGetBack.Name = "ButtonGetBack"
        Me.ButtonGetBack.Size = New System.Drawing.Size(104, 23)
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
        'RomTotal
        '
        Me.RomTotal.Location = New System.Drawing.Point(254, 62)
        Me.RomTotal.Name = "RomTotal"
        Me.RomTotal.Size = New System.Drawing.Size(67, 20)
        Me.RomTotal.TabIndex = 15
        '
        'RomTotalOverlay
        '
        Me.RomTotalOverlay.Location = New System.Drawing.Point(254, 25)
        Me.RomTotalOverlay.Name = "RomTotalOverlay"
        Me.RomTotalOverlay.Size = New System.Drawing.Size(67, 20)
        Me.RomTotalOverlay.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total de Roms"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Total de Roms avec Overlay"
        '
        'DataGridOverlay
        '
        Me.DataGridOverlay.AllowUserToOrderColumns = True
        Me.DataGridOverlay.AllowUserToResizeRows = False
        Me.DataGridOverlay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOverlay.Location = New System.Drawing.Point(507, 71)
        Me.DataGridOverlay.Name = "DataGridOverlay"
        Me.DataGridOverlay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridOverlay.Size = New System.Drawing.Size(367, 284)
        Me.DataGridOverlay.TabIndex = 15
        '
        'OverlayManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(884, 521)
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
    Friend WithEvents RAZRoms As Button
    Friend WithEvents RSansOverlay As CheckBox
    Friend WithEvents RAvecOverlay As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonMenage As Button
    Friend WithEvents RAZOverlays As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents buttonImportRoms As Button
    Friend WithEvents ButtonImportOverlays As Button
    Friend WithEvents ButtonGetBack As Button
    Friend WithEvents GameLists As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RomTotalOverlay As TextBox
    Friend WithEvents RomTotal As TextBox
    Friend WithEvents DataGridOverlay As DataGridView
End Class
