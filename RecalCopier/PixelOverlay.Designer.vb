<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PixelOverlay
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
        Me.CacaGif = New System.Windows.Forms.PictureBox()
        CType(Me.CacaGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CacaGif
        '
        Me.CacaGif.Image = Global.RecalCopier.My.Resources.Resources.pixelempty
        Me.CacaGif.Location = New System.Drawing.Point(0, 0)
        Me.CacaGif.Name = "CacaGif"
        Me.CacaGif.Size = New System.Drawing.Size(320, 192)
        Me.CacaGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CacaGif.TabIndex = 0
        Me.CacaGif.TabStop = False
        '
        'PixelOverlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(318, 191)
        Me.Controls.Add(Me.CacaGif)
        Me.Name = "PixelOverlay"
        Me.Text = "PixelOverlay"
        CType(Me.CacaGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CacaGif As PictureBox
End Class
