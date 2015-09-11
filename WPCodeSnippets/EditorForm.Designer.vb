<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditorForm))
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CodeOrTextTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlaceHolderCbo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InsertSnippetBt = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SaveBt = New System.Windows.Forms.Button()
        Me.CancelBt = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(54, 19)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(258, 20)
        Me.NameTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.CodeOrTextTxt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NameTxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 257)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Snippet Details"
        '
        'CodeOrTextTxt
        '
        Me.CodeOrTextTxt.AcceptsReturn = True
        Me.CodeOrTextTxt.AcceptsTab = True
        Me.CodeOrTextTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodeOrTextTxt.HideSelection = False
        Me.CodeOrTextTxt.Location = New System.Drawing.Point(54, 48)
        Me.CodeOrTextTxt.Multiline = True
        Me.CodeOrTextTxt.Name = "CodeOrTextTxt"
        Me.CodeOrTextTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CodeOrTextTxt.Size = New System.Drawing.Size(387, 191)
        Me.CodeOrTextTxt.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Markup"
        '
        'PlaceHolderCbo
        '
        Me.PlaceHolderCbo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlaceHolderCbo.FormattingEnabled = True
        Me.PlaceHolderCbo.Items.AddRange(New Object() {"Ask for text", "Selected text"})
        Me.PlaceHolderCbo.Location = New System.Drawing.Point(140, 18)
        Me.PlaceHolderCbo.Name = "PlaceHolderCbo"
        Me.PlaceHolderCbo.Size = New System.Drawing.Size(144, 21)
        Me.PlaceHolderCbo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Insert Placeholder"
        '
        'InsertSnippetBt
        '
        Me.InsertSnippetBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InsertSnippetBt.Location = New System.Drawing.Point(301, 16)
        Me.InsertSnippetBt.Name = "InsertSnippetBt"
        Me.InsertSnippetBt.Size = New System.Drawing.Size(128, 23)
        Me.InsertSnippetBt.TabIndex = 5
        Me.InsertSnippetBt.Text = "Insert Placeholder"
        Me.InsertSnippetBt.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PlaceHolderCbo)
        Me.GroupBox2.Controls.Add(Me.InsertSnippetBt)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 54)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Placeholder"
        '
        'SaveBt
        '
        Me.SaveBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveBt.Location = New System.Drawing.Point(260, 348)
        Me.SaveBt.Name = "SaveBt"
        Me.SaveBt.Size = New System.Drawing.Size(96, 23)
        Me.SaveBt.TabIndex = 7
        Me.SaveBt.Text = "Save"
        Me.SaveBt.UseVisualStyleBackColor = True
        '
        'CancelBt
        '
        Me.CancelBt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBt.Location = New System.Drawing.Point(362, 348)
        Me.CancelBt.Name = "CancelBt"
        Me.CancelBt.Size = New System.Drawing.Size(96, 23)
        Me.CancelBt.TabIndex = 8
        Me.CancelBt.Text = "Cancel"
        Me.CancelBt.UseVisualStyleBackColor = True
        '
        'EditorForm
        '
        Me.AcceptButton = Me.SaveBt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBt
        Me.ClientSize = New System.Drawing.Size(468, 383)
        Me.Controls.Add(Me.CancelBt)
        Me.Controls.Add(Me.SaveBt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "EditorForm"
        Me.Text = "Create / Edit Snippet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameTxt As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents CodeOrTextTxt As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents PlaceHolderCbo As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents InsertSnippetBt As Windows.Forms.Button
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents SaveBt As Windows.Forms.Button
    Friend WithEvents CancelBt As Windows.Forms.Button
End Class
