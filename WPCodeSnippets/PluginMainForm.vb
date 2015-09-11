Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO

Public Class PluginMainForm

    Private Const _DataSaveFolder As String = "\WLWSnippetManagerPlugin"

    Private mlsSnippets As List(Of Snippet)

    Public Property _lsSnippets As List(Of Snippet)
        Get
            Return mlsSnippets
        End Get
        Set(value As List(Of Snippet))
            mlsSnippets = value
        End Set
    End Property
    Private ReadOnly Property _SaveDirectory As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & _DataSaveFolder
        End Get
    End Property
    Private ReadOnly Property _FilePathName As String
        Get
            Return _SaveDirectory & "\Snippets.xml"
        End Get
    End Property

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ReadSnippetsFromDisk()


    End Sub

    Private Sub CloseBt_Click(sender As Object, e As EventArgs) Handles CloseBt.Click

        '_lsSnippets.Add(New Snippet With {.SnippetName = "Test", .CodeOrText = "CODE HOLDER", .PlaceHolderType = "XYX"})
        '_lsSnippets.Add(New Snippet With {.SnippetName = "TestASD", .CodeOrText = "CODE HOLDERASD", .PlaceHolderType = "XYXaSD"})


        Me.Close()
    End Sub

    Private Sub CreateNewBt_Click(sender As Object, e As EventArgs) Handles CreateNewBt.Click
        Dim f As New EditorForm("New")
        f.ShowDialog()
        f = Nothing
    End Sub

    Private Sub EditBt_Click(sender As Object, e As EventArgs) Handles EditBt.Click

        EditSnippet()

    End Sub
    Private Sub EditSnippet()
        Dim f As EditorForm

        Try
            f = New EditorForm(SelectionListBox.SelectedItem.ToString)
            f.ShowDialog()

        Catch ex As Exception

        Finally
            f = Nothing
        End Try
    End Sub
    Private Sub PluginMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ReadSnippetsFromDisk()
        If My.Computer.FileSystem.DirectoryExists(_SaveDirectory) = False Then
            My.Computer.FileSystem.CreateDirectory(_SaveDirectory)
        End If

        _lsSnippets = New List(Of Snippet)

        If My.Computer.FileSystem.FileExists(_FilePathName) Then
            Dim x As XmlSerializer

            Try
                x = New XmlSerializer(_lsSnippets.GetType)

                Using fs As FileStream = New FileStream(_FilePathName, FileMode.Open)
                    Dim rdr As XmlReader = XmlReader.Create(fs)

                    _lsSnippets = CType(x.Deserialize(rdr), List(Of Snippet))

                End Using

            Catch ex As Exception

            Finally
                x = Nothing

            End Try



        End If

        For Each oSnippet In _lsSnippets
            SelectionListBox.Items.Add(oSnippet.SnippetName)
        Next



    End Sub
    Private Sub WriteSnippetsToDisk()
        Dim x As XmlSerializer

        Try

            Using objStreamWriter As New StreamWriter(_FilePathName)

                x = New XmlSerializer(_lsSnippets.GetType)
                x.Serialize(objStreamWriter, _lsSnippets)
                objStreamWriter.Close()

            End Using
        Catch ex As Exception

        Finally
            x = Nothing

        End Try
    End Sub

    Private Sub PluginMainForm_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        WriteSnippetsToDisk()
    End Sub

    Private Sub SelectionListBox_DoubleClick(sender As Object, e As EventArgs) Handles SelectionListBox.DoubleClick
        InsertSnippet()
    End Sub
    Sub InsertSnippet()
        If String.IsNullOrEmpty(SelectionListBox.SelectedItem) Then

            Windows.Forms.MessageBox.Show("Please select snippet to insert", "Select snippet...")
            Exit Sub

        End If

        Dim sMarkup As String = _lsSnippets.Find(Function(x) x.SnippetName = SelectionListBox.SelectedItem).CodeOrText

        If sMarkup.Contains("++Ask for text++") Then
            Dim f As InsertSnippetForm

            Try
                f = New InsertSnippetForm(SelectionListBox.SelectedItem.ToString)
                f.ShowDialog()

            Catch ex As Exception

            Finally
                f = Nothing
            End Try

        Else
            InsertIntoPost(sMarkup)
        End If




        Me.Close()

    End Sub

    Private Sub InsertBt_Click(sender As Object, e As EventArgs) Handles InsertBt.Click
        InsertSnippet()
    End Sub
    Public Sub InsertIntoPost(sMarkupToInsert As String)

    End Sub
End Class