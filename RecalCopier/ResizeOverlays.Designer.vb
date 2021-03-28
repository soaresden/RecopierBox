<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResizeOverlays
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResizeOverlays))
        Me.buttonImport = New System.Windows.Forms.Button()
        Me.GameLists = New System.Windows.Forms.ListBox()
        Me.DataGridOverlays = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonGetBack1 = New System.Windows.Forms.Button()
        Me.GroupBoxOriginalOverlay = New System.Windows.Forms.GroupBox()
        Me.ButtonKnowResolution = New System.Windows.Forms.Button()
        Me.ButtonGoResize = New System.Windows.Forms.Button()
        Me.chkcopysomewhere = New System.Windows.Forms.CheckBox()
        Me.chkOriginalReplace = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HauteurOriginale = New System.Windows.Forms.TextBox()
        Me.NouveauY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LargeurOriginale = New System.Windows.Forms.TextBox()
        Me.NouveauX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ActualOverlay = New System.Windows.Forms.PictureBox()
        Me.TotalOverlay = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PicXrandr = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridOverlays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxOriginalOverlay.SuspendLayout()
        CType(Me.ActualOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicXrandr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonImport
        '
        Me.buttonImport.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.buttonImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.buttonImport.Cursor = System.Windows.Forms.Cursors.Default
        Me.buttonImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.buttonImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonImport.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonImport.Location = New System.Drawing.Point(5, 536)
        Me.buttonImport.Name = "buttonImport"
        Me.buttonImport.Size = New System.Drawing.Size(116, 30)
        Me.buttonImport.TabIndex = 44
        Me.buttonImport.Text = "Importer les Overlays"
        Me.buttonImport.UseVisualStyleBackColor = False
        '
        'GameLists
        '
        Me.GameLists.FormattingEnabled = True
        Me.GameLists.Location = New System.Drawing.Point(5, 58)
        Me.GameLists.Name = "GameLists"
        Me.GameLists.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GameLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.GameLists.Size = New System.Drawing.Size(116, 472)
        Me.GameLists.TabIndex = 43
        '
        'DataGridOverlays
        '
        Me.DataGridOverlays.AllowUserToOrderColumns = True
        Me.DataGridOverlays.AllowUserToResizeRows = False
        Me.DataGridOverlays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOverlays.Location = New System.Drawing.Point(127, 58)
        Me.DataGridOverlays.Name = "DataGridOverlays"
        Me.DataGridOverlays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridOverlays.Size = New System.Drawing.Size(491, 497)
        Me.DataGridOverlays.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(127, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Liste de Tous les Fichiers Overlays :"
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
        Me.ButtonGetBack1.Location = New System.Drawing.Point(5, 3)
        Me.ButtonGetBack1.Name = "ButtonGetBack1"
        Me.ButtonGetBack1.Size = New System.Drawing.Size(116, 23)
        Me.ButtonGetBack1.TabIndex = 45
        Me.ButtonGetBack1.Text = "Retour Aux Overlays"
        Me.ButtonGetBack1.UseVisualStyleBackColor = False
        '
        'GroupBoxOriginalOverlay
        '
        Me.GroupBoxOriginalOverlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.ButtonKnowResolution)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.ButtonGoResize)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.chkcopysomewhere)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.chkOriginalReplace)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.Label7)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.Label4)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.Label5)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.HauteurOriginale)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.NouveauY)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.Label3)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.LargeurOriginale)
        Me.GroupBoxOriginalOverlay.Controls.Add(Me.NouveauX)
        Me.GroupBoxOriginalOverlay.Location = New System.Drawing.Point(624, 351)
        Me.GroupBoxOriginalOverlay.Name = "GroupBoxOriginalOverlay"
        Me.GroupBoxOriginalOverlay.Size = New System.Drawing.Size(362, 204)
        Me.GroupBoxOriginalOverlay.TabIndex = 46
        Me.GroupBoxOriginalOverlay.TabStop = False
        Me.GroupBoxOriginalOverlay.Text = "Parametre Overlay :"
        '
        'ButtonKnowResolution
        '
        Me.ButtonKnowResolution.BackColor = System.Drawing.Color.Gray
        Me.ButtonKnowResolution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonKnowResolution.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonKnowResolution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonKnowResolution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonKnowResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonKnowResolution.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKnowResolution.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonKnowResolution.Location = New System.Drawing.Point(185, 59)
        Me.ButtonKnowResolution.Name = "ButtonKnowResolution"
        Me.ButtonKnowResolution.Size = New System.Drawing.Size(171, 30)
        Me.ButtonKnowResolution.TabIndex = 4
        Me.ButtonKnowResolution.Text = "Connaitre sa Resolution sous PC ?"
        Me.ButtonKnowResolution.UseVisualStyleBackColor = False
        '
        'ButtonGoResize
        '
        Me.ButtonGoResize.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ButtonGoResize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonGoResize.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonGoResize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ButtonGoResize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ButtonGoResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGoResize.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGoResize.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGoResize.Location = New System.Drawing.Point(122, 175)
        Me.ButtonGoResize.Name = "ButtonGoResize"
        Me.ButtonGoResize.Size = New System.Drawing.Size(116, 23)
        Me.ButtonGoResize.TabIndex = 7
        Me.ButtonGoResize.Text = "Redimensionner"
        Me.ButtonGoResize.UseVisualStyleBackColor = False
        '
        'chkcopysomewhere
        '
        Me.chkcopysomewhere.AutoSize = True
        Me.chkcopysomewhere.Checked = True
        Me.chkcopysomewhere.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkcopysomewhere.Location = New System.Drawing.Point(6, 132)
        Me.chkcopysomewhere.Name = "chkcopysomewhere"
        Me.chkcopysomewhere.Size = New System.Drawing.Size(310, 30)
        Me.chkcopysomewhere.TabIndex = 6
        Me.chkcopysomewhere.Text = "Copier les fichiers redimensionnés vers un autre Repertoire ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """overlays\aCustom""" &
    ""
        Me.chkcopysomewhere.UseVisualStyleBackColor = True
        '
        'chkOriginalReplace
        '
        Me.chkOriginalReplace.AutoSize = True
        Me.chkOriginalReplace.Location = New System.Drawing.Point(6, 109)
        Me.chkOriginalReplace.Name = "chkOriginalReplace"
        Me.chkOriginalReplace.Size = New System.Drawing.Size(183, 17)
        Me.chkOriginalReplace.TabIndex = 5
        Me.chkOriginalReplace.Text = "Remplacer les fichiers originaux ?"
        Me.chkOriginalReplace.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Resolution Finale Souhaitée :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "x"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "x"
        '
        'HauteurOriginale
        '
        Me.HauteurOriginale.Location = New System.Drawing.Point(99, 34)
        Me.HauteurOriginale.Name = "HauteurOriginale"
        Me.HauteurOriginale.ReadOnly = True
        Me.HauteurOriginale.Size = New System.Drawing.Size(47, 20)
        Me.HauteurOriginale.TabIndex = 1
        Me.HauteurOriginale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NouveauY
        '
        Me.NouveauY.Location = New System.Drawing.Point(297, 33)
        Me.NouveauY.Name = "NouveauY"
        Me.NouveauY.Size = New System.Drawing.Size(47, 20)
        Me.NouveauY.TabIndex = 3
        Me.NouveauY.Text = "720"
        Me.NouveauY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Taille Originale des Overlays"
        '
        'LargeurOriginale
        '
        Me.LargeurOriginale.Location = New System.Drawing.Point(9, 33)
        Me.LargeurOriginale.Name = "LargeurOriginale"
        Me.LargeurOriginale.ReadOnly = True
        Me.LargeurOriginale.Size = New System.Drawing.Size(47, 20)
        Me.LargeurOriginale.TabIndex = 0
        Me.LargeurOriginale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NouveauX
        '
        Me.NouveauX.Location = New System.Drawing.Point(202, 33)
        Me.NouveauX.Name = "NouveauX"
        Me.NouveauX.Size = New System.Drawing.Size(47, 20)
        Me.NouveauX.TabIndex = 2
        Me.NouveauX.Text = "1280"
        Me.NouveauX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(770, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Overlay Actuel :"
        '
        'ActualOverlay
        '
        Me.ActualOverlay.BackColor = System.Drawing.Color.Black
        Me.ActualOverlay.Location = New System.Drawing.Point(624, 58)
        Me.ActualOverlay.Name = "ActualOverlay"
        Me.ActualOverlay.Size = New System.Drawing.Size(362, 284)
        Me.ActualOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ActualOverlay.TabIndex = 50
        Me.ActualOverlay.TabStop = False
        '
        'TotalOverlay
        '
        Me.TotalOverlay.Location = New System.Drawing.Point(546, 35)
        Me.TotalOverlay.Name = "TotalOverlay"
        Me.TotalOverlay.ReadOnly = True
        Me.TotalOverlay.Size = New System.Drawing.Size(72, 20)
        Me.TotalOverlay.TabIndex = 51
        Me.TotalOverlay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(543, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Total Overlays"
        '
        'PicXrandr
        '
        Me.PicXrandr.BackColor = System.Drawing.Color.Black
        Me.PicXrandr.Image = CType(resources.GetObject("PicXrandr.Image"), System.Drawing.Image)
        Me.PicXrandr.Location = New System.Drawing.Point(127, 58)
        Me.PicXrandr.Name = "PicXrandr"
        Me.PicXrandr.Size = New System.Drawing.Size(859, 308)
        Me.PicXrandr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicXrandr.TabIndex = 53
        Me.PicXrandr.TabStop = False
        '
        'ResizeOverlays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 576)
        Me.Controls.Add(Me.PicXrandr)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TotalOverlay)
        Me.Controls.Add(Me.ActualOverlay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxOriginalOverlay)
        Me.Controls.Add(Me.ButtonGetBack1)
        Me.Controls.Add(Me.buttonImport)
        Me.Controls.Add(Me.GameLists)
        Me.Controls.Add(Me.DataGridOverlays)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(1014, 615)
        Me.MinimumSize = New System.Drawing.Size(1014, 615)
        Me.Name = "ResizeOverlays"
        Me.Text = "ResizeOverlays"
        CType(Me.DataGridOverlays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxOriginalOverlay.ResumeLayout(False)
        Me.GroupBoxOriginalOverlay.PerformLayout()
        CType(Me.ActualOverlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicXrandr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonImport As Button
    Friend WithEvents GameLists As ListBox
    Friend WithEvents DataGridOverlays As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonGetBack1 As Button
    Friend WithEvents GroupBoxOriginalOverlay As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents HauteurOriginale As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LargeurOriginale As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ActualOverlay As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NouveauY As TextBox
    Friend WithEvents NouveauX As TextBox
    Friend WithEvents TotalOverlay As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonGoResize As Button
    Friend WithEvents chkcopysomewhere As CheckBox
    Friend WithEvents chkOriginalReplace As CheckBox
    Friend WithEvents ButtonKnowResolution As Button
    Friend WithEvents PicXrandr As PictureBox
End Class
