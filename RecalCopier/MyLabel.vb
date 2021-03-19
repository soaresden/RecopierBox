Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.IO
Imports System.Reflection

Public Class MyLabel
    Inherits System.Windows.Forms.Label
    Private Shared FontCollection As PrivateFontCollection
    Private FontFamily As FontFamily

    Public Sub New()
        _privateFontName = "Equinox Com"
        _privateFontSize = 14.25
        UpdateFont()
    End Sub

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
        End Set
    End Property
    Private _privateFontName As String

    <DefaultValue("Equinox Com")>
    Public Property PrivateFontName() As String
        Get
            Return _privateFontName
        End Get
        Set(ByVal value As String)
            _privateFontName = value
            UpdateFont()
        End Set
    End Property

    Private _privateFontSize As Single
    <DefaultValue(14.25!)>
    Public Property PrivateFontSize() As Single
        Get
            Return _privateFontSize
        End Get
        Set(ByVal value As Single)
            _privateFontSize = value
            UpdateFont()
        End Set
    End Property

    Sub UpdateFont()
        If FontCollection Is Nothing Then
            FontCollection = New PrivateFontCollection()
            AddPrivateFont("font-EquinoxRg.ttf", My.Resources.font_EquinoxRg)
            AddPrivateFont("font-vagRounded-BT-Normal.ttf", My.Resources.font_vagRounded_BT_Normal)
        End If

        If _privateFontSize = 0 Or String.IsNullOrEmpty(_privateFontName) Then
            Return
        End If

        Me.FontFamily = New FontFamily(_privateFontName, FontCollection)
        Me.Font = New Font(Me.FontFamily, _privateFontSize)
    End Sub
    Private Shared Sub AddPrivateFont(fontFileName As String, bytes As Byte())
        Dim fontPath As String = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fontFileName)
        If Not File.Exists(fontPath) Then
            File.WriteAllBytes(fontPath, bytes)
        End If
        FontCollection.AddFontFile(fontPath)
    End Sub
End Class
