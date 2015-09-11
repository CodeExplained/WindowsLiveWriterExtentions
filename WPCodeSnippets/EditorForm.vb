Public Class EditorForm

    Private _Snippet As Snippet
    Private _NewSnippet As Boolean = False

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(sSnippetName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If sSnippetName = "New" Then
            _Snippet = New Snippet
            _NewSnippet = True
        Else
            _Snippet = PluginMainForm._lsSnippets.Find(Function(x) x.SnippetName = sSnippetName)
            _NewSnippet = False

            Me.NameTxt.Text = _Snippet.SnippetName
            Me.CodeOrTextTxt.Text = _Snippet.CodeOrText
            Me.PlaceHolderCbo.Text = _Snippet.PlaceHolderType


        End If

    End Sub
End Class