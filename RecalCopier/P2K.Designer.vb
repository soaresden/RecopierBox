<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P2K
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P2K))
        Me.ButtonGetBack = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Title1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BatoToRb = New System.Windows.Forms.Label()
        Me.RbtoBato = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ParcourirPad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adressepad = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewExo = New System.Windows.Forms.DataGridView()
        Me.FullNewadresseExo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NewAdresseExo = New System.Windows.Forms.TextBox()
        Me.DoExoConverter = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ParcourirExo = New System.Windows.Forms.Button()
        Me.adresseExo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewExo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ButtonGetBack.Location = New System.Drawing.Point(12, 12)
        Me.ButtonGetBack.Name = "ButtonGetBack"
        Me.ButtonGetBack.Size = New System.Drawing.Size(94, 23)
        Me.ButtonGetBack.TabIndex = 34
        Me.ButtonGetBack.Text = "Retour Au Menu"
        Me.ButtonGetBack.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.Title1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.BatoToRb)
        Me.Panel1.Controls.Add(Me.RbtoBato)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.ParcourirPad)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.adressepad)
        Me.Panel1.Location = New System.Drawing.Point(112, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 546)
        Me.Panel1.TabIndex = 37
        '
        'Title1
        '
        Me.Title1.BackColor = System.Drawing.Color.SeaGreen
        Me.Title1.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.ForeColor = System.Drawing.SystemColors.Window
        Me.Title1.Location = New System.Drawing.Point(107, 3)
        Me.Title1.Multiline = True
        Me.Title1.Name = "Title1"
        Me.Title1.ReadOnly = True
        Me.Title1.Size = New System.Drawing.Size(218, 72)
        Me.Title1.TabIndex = 49
        Me.Title1.Text = "CONVERTIR DES " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FICHIERS PAD2KEYBOARD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P2K.CFG & .KEYS"
        Me.Title1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(3, 473)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(312, 20)
        Me.TextBox4.TabIndex = 47
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 453)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Saisir un nom de Dossier de Sortie"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(209, 450)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(105, 20)
        Me.TextBox3.TabIndex = 45
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(92, 511)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 32)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Confirmer la conversion"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BatoToRb
        '
        Me.BatoToRb.AutoSize = True
        Me.BatoToRb.Location = New System.Drawing.Point(5, 253)
        Me.BatoToRb.Name = "BatoToRb"
        Me.BatoToRb.Size = New System.Drawing.Size(231, 13)
        Me.BatoToRb.TabIndex = 43
        Me.BatoToRb.Text = "Dossier Batocera (.keys) --> Recalbox's p2k.cfg"
        '
        'RbtoBato
        '
        Me.RbtoBato.AutoSize = True
        Me.RbtoBato.Location = New System.Drawing.Point(5, 240)
        Me.RbtoBato.Name = "RbtoBato"
        Me.RbtoBato.Size = New System.Drawing.Size(231, 13)
        Me.RbtoBato.TabIndex = 42
        Me.RbtoBato.Text = "Dossier Recalbox (p2k.cfg) --> Batocera's .keys"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(3, 286)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(322, 160)
        Me.ListBox1.TabIndex = 41
        '
        'ParcourirPad
        '
        Me.ParcourirPad.BackColor = System.Drawing.Color.SeaGreen
        Me.ParcourirPad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ParcourirPad.Cursor = System.Windows.Forms.Cursors.Default
        Me.ParcourirPad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ParcourirPad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ParcourirPad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParcourirPad.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParcourirPad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ParcourirPad.Location = New System.Drawing.Point(246, 214)
        Me.ParcourirPad.Name = "ParcourirPad"
        Me.ParcourirPad.Size = New System.Drawing.Size(69, 23)
        Me.ParcourirPad.TabIndex = 39
        Me.ParcourirPad.Text = "Parcourir"
        Me.ParcourirPad.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 39)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Réaliser des conversions de fichiers :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- .p2k.cfg (Recalbox)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- .keys (Batocera)" &
    ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 26)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Saisir le chemin roms/console souhaitée" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ps: tous les sous dossiers seront pris e" &
    "n compte"
        '
        'adressepad
        '
        Me.adressepad.Location = New System.Drawing.Point(3, 217)
        Me.adressepad.Name = "adressepad"
        Me.adressepad.Size = New System.Drawing.Size(237, 20)
        Me.adressepad.TabIndex = 37
        Me.adressepad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.Controls.Add(Me.DataGridViewExo)
        Me.Panel2.Controls.Add(Me.FullNewadresseExo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.NewAdresseExo)
        Me.Panel2.Controls.Add(Me.DoExoConverter)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.ParcourirExo)
        Me.Panel2.Controls.Add(Me.adresseExo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(446, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 546)
        Me.Panel2.TabIndex = 38
        '
        'DataGridViewExo
        '
        Me.DataGridViewExo.AllowUserToAddRows = False
        Me.DataGridViewExo.AllowUserToDeleteRows = False
        Me.DataGridViewExo.AllowUserToResizeRows = False
        Me.DataGridViewExo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewExo.Location = New System.Drawing.Point(6, 244)
        Me.DataGridViewExo.MultiSelect = False
        Me.DataGridViewExo.Name = "DataGridViewExo"
        Me.DataGridViewExo.RowHeadersVisible = False
        Me.DataGridViewExo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewExo.Size = New System.Drawing.Size(523, 202)
        Me.DataGridViewExo.TabIndex = 59
        '
        'FullNewadresseExo
        '
        Me.FullNewadresseExo.Location = New System.Drawing.Point(7, 476)
        Me.FullNewadresseExo.Name = "FullNewadresseExo"
        Me.FullNewadresseExo.ReadOnly = True
        Me.FullNewadresseExo.Size = New System.Drawing.Size(522, 20)
        Me.FullNewadresseExo.TabIndex = 58
        Me.FullNewadresseExo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Saisir un nom de Dossier de Sortie"
        '
        'NewAdresseExo
        '
        Me.NewAdresseExo.Location = New System.Drawing.Point(241, 450)
        Me.NewAdresseExo.Name = "NewAdresseExo"
        Me.NewAdresseExo.Size = New System.Drawing.Size(128, 20)
        Me.NewAdresseExo.TabIndex = 56
        Me.NewAdresseExo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DoExoConverter
        '
        Me.DoExoConverter.BackColor = System.Drawing.Color.IndianRed
        Me.DoExoConverter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DoExoConverter.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoExoConverter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.DoExoConverter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DoExoConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DoExoConverter.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoExoConverter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DoExoConverter.Location = New System.Drawing.Point(215, 511)
        Me.DoExoConverter.Name = "DoExoConverter"
        Me.DoExoConverter.Size = New System.Drawing.Size(154, 32)
        Me.DoExoConverter.TabIndex = 51
        Me.DoExoConverter.Text = "Valider le nouveau format"
        Me.DoExoConverter.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.IndianRed
        Me.TextBox5.Font = New System.Drawing.Font("Equinox Com", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox5.Location = New System.Drawing.Point(107, 3)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(422, 72)
        Me.TextBox5.TabIndex = 50
        Me.TextBox5.Text = "CONVERTIR DES " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EXODOS CONVERTER'S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AU FORMAT MEDIA"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ParcourirExo
        '
        Me.ParcourirExo.BackColor = System.Drawing.Color.IndianRed
        Me.ParcourirExo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ParcourirExo.Cursor = System.Windows.Forms.Cursors.Default
        Me.ParcourirExo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.ParcourirExo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ParcourirExo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParcourirExo.Font = New System.Drawing.Font("Equinox Com", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParcourirExo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ParcourirExo.Location = New System.Drawing.Point(455, 213)
        Me.ParcourirExo.Name = "ParcourirExo"
        Me.ParcourirExo.Size = New System.Drawing.Size(69, 23)
        Me.ParcourirExo.TabIndex = 41
        Me.ParcourirExo.Text = "Parcourir"
        Me.ParcourirExo.UseVisualStyleBackColor = False
        '
        'adresseExo
        '
        Me.adresseExo.Location = New System.Drawing.Point(12, 216)
        Me.adresseExo.Name = "adresseExo"
        Me.adresseExo.Size = New System.Drawing.Size(437, 20)
        Me.adresseExo.TabIndex = 42
        Me.adresseExo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Saisir le chemin de votre repertoire de sortie de votre converter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 52)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Convertir des gamelists générées par le converter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(downloaded_images)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "au format" &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(media/screenshot ...)"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(173, 78)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(276, 13)
        Me.LinkLabel1.TabIndex = 36
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://github.com/Voljega/ExoDOSConverter/releases/"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'P2K
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(990, 563)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ButtonGetBack)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "P2K"
        Me.Text = "P2K"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridViewExo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonGetBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents adressepad As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Title1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents BatoToRb As Label
    Friend WithEvents RbtoBato As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ParcourirPad As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FullNewadresseExo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NewAdresseExo As TextBox
    Friend WithEvents DoExoConverter As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ParcourirExo As Button
    Friend WithEvents adresseExo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents DataGridViewExo As DataGridView
End Class
