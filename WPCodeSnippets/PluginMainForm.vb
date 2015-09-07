Public Class PluginMainForm

    Public _lsSnippets As List(Of Snippet)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _lsSnippets = New List(Of Snippet)

    End Sub

    Private Sub CloseBt_Click(sender As Object, e As EventArgs) Handles CloseBt.Click
        Me.Close()
    End Sub

    Private Sub CreateNewBt_Click(sender As Object, e As EventArgs) Handles CreateNewBt.Click
        Dim f As New EditorForm("New")
        f.ShowDialog()
        f = Nothing
    End Sub

    Private Sub EditBt_Click(sender As Object, e As EventArgs) Handles EditBt.Click
        Dim f As New EditorForm(SelectionListBox.SelectedValue.ToString)
        f.ShowDialog()
        f = Nothing
    End Sub
End Class