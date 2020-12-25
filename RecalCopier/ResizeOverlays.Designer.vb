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
        Me.buttonImport = New System.Windows.Forms.Button()
        Me.GameLists = New System.Windows.Forms.ListBox()
        Me.DataGridOverlays = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonGetBack1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HauteurOriginale = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LargeurOriginale = New System.Windows.Forms.TextBox()
        Me.FutureOverlay = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ActualOverlay = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TotalOverlay = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridOverlays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FutureOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualOverlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.DataGridOverlays.Size = New System.Drawing.Size(491, 284)
        Me.DataGridOverlays.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(217, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Liste de Toutes les Roms Gamelistées"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.HauteurOriginale)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LargeurOriginale)
        Me.GroupBox1.Location = New System.Drawing.Point(624, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 71)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametre Overlay :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "x"
        '
        'HauteurOriginale
        '
        Me.HauteurOriginale.Location = New System.Drawing.Point(67, 34)
        Me.HauteurOriginale.Name = "HauteurOriginale"
        Me.HauteurOriginale.ReadOnly = True
        Me.HauteurOriginale.Size = New System.Drawing.Size(47, 20)
        Me.HauteurOriginale.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Taille Overlay"
        '
        'LargeurOriginale
        '
        Me.LargeurOriginale.Location = New System.Drawing.Point(6, 34)
        Me.LargeurOriginale.Name = "LargeurOriginale"
        Me.LargeurOriginale.ReadOnly = True
        Me.LargeurOriginale.Size = New System.Drawing.Size(47, 20)
        Me.LargeurOriginale.TabIndex = 0
        '
        'FutureOverlay
        '
        Me.FutureOverlay.Location = New System.Drawing.Point(624, 359)
        Me.FutureOverlay.Name = "FutureOverlay"
        Me.FutureOverlay.Size = New System.Drawing.Size(362, 207)
        Me.FutureOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.FutureOverlay.TabIndex = 47
        Me.FutureOverlay.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(770, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Overlay Actuel"
        '
        'ActualOverlay
        '
        Me.ActualOverlay.BackColor = System.Drawing.Color.Black
        Me.ActualOverlay.Location = New System.Drawing.Point(624, 58)
        Me.ActualOverlay.Name = "ActualOverlay"
        Me.ActualOverlay.Size = New System.Drawing.Size(362, 207)
        Me.ActualOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ActualOverlay.TabIndex = 50
        Me.ActualOverlay.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(450, 359)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 207)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Parametre Overlay :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nouvelles Dimensions :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "x"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(87, 69)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(47, 20)
        Me.TextBox3.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Taille Overlay"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(26, 69)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(47, 20)
        Me.TextBox4.TabIndex = 0
        '
        'TotalOverlay
        '
        Me.TotalOverlay.Location = New System.Drawing.Point(546, 35)
        Me.TotalOverlay.Name = "TotalOverlay"
        Me.TotalOverlay.Size = New System.Drawing.Size(72, 20)
        Me.TotalOverlay.TabIndex = 51
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
        'ResizeOverlays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(998, 576)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TotalOverlay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ActualOverlay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FutureOverlay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonGetBack1)
        Me.Controls.Add(Me.buttonImport)
        Me.Controls.Add(Me.GameLists)
        Me.Controls.Add(Me.DataGridOverlays)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ResizeOverlays"
        Me.Text = "ResizeOverlays"
        CType(Me.DataGridOverlays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FutureOverlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualOverlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonImport As Button
    Friend WithEvents GameLists As ListBox
    Friend WithEvents DataGridOverlays As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonGetBack1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents HauteurOriginale As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LargeurOriginale As TextBox
    Friend WithEvents FutureOverlay As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ActualOverlay As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TotalOverlay As TextBox
    Friend WithEvents Label8 As Label
End Class
