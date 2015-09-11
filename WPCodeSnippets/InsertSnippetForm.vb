Public Class InsertSnippetForm

    Private _Snippet As Snippet

    Private Sub CancelBt_Click(sender As Object, e As EventArgs) Handles CancelBt.Click
        Me.Close()
    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(sSnippetName As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _Snippet = PluginMainForm._lsSnippets.Find(Function(x) x.SnippetName = sSnippetName)

    End Sub
End Class