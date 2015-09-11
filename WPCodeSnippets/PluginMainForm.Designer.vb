<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PluginMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PluginMainForm))
        Me.SelectionListBox = New System.Windows.Forms.ListBox()
        Me.CreateNewBt = New System.Windows.Forms.Button()
        Me.EditBt = New System.Windows.Forms.Button()
        Me.CloseBt = New System.Windows.Forms.Button()
        Me.InsertBt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SelectionListBox
        '
        Me.SelectionListBox.FormattingEnabled = True
        Me.SelectionListBox.Location = New System.Drawing.Point(12, 46)
        Me.SelectionListBox.Name = "SelectionListBox"
        Me.SelectionListBox.Size = New System.Drawing.Size(234, 264)
        Me.SelectionListBox.TabIndex = 0
        '
        'CreateNewBt
        '
        Me.CreateNewBt.Location = New System.Drawing.Point(12, 12)
        Me.CreateNewBt.Name = "CreateNewBt"
        Me.CreateNewBt.Size = New System.Drawing.Size(108, 23)
        Me.CreateNewBt.TabIndex = 3
        Me.CreateNewBt.Text = "Create New..."
        Me.CreateNewBt.UseVisualStyleBackColor = True
        '
        'EditBt
        '
        Me.EditBt.Location = New System.Drawing.Point(138, 12)
        Me.EditBt.Name = "EditBt"
        Me.EditBt.Size = New System.Drawing.Size(108, 23)
        Me.EditBt.TabIndex = 4
        Me.EditBt.Text = "Edit..."
        Me.EditBt.UseVisualStyleBackColor = True
        '
        'CloseBt
        '
        Me.CloseBt.Location = New System.Drawing.Point(138, 322)
        Me.CloseBt.Name = "CloseBt"
        Me.CloseBt.Size = New System.Drawing.Size(108, 23)
        Me.CloseBt.TabIndex = 5
        Me.CloseBt.Text = "Close"
        Me.CloseBt.UseVisualStyleBackColor = True
        '
        'InsertBt
        '
        Me.InsertBt.Location = New System.Drawing.Point(12, 322)
        Me.InsertBt.Name = "InsertBt"
        Me.InsertBt.Size = New System.Drawing.Size(108, 23)
        Me.InsertBt.TabIndex = 6
        Me.InsertBt.Text = "Insert Snippet"
        Me.InsertBt.UseVisualStyleBackColor = True
        '
        'PluginMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 359)
        Me.Controls.Add(Me.InsertBt)
        Me.Controls.Add(Me.CloseBt)
        Me.Controls.Add(Me.EditBt)
        Me.Controls.Add(Me.CreateNewBt)
        Me.Controls.Add(Me.SelectionListBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PluginMainForm"
        Me.Text = "WLW Snippets"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SelectionListBox As Windows.Forms.ListBox
    Friend WithEvents CreateNewBt As Windows.Forms.Button
    Friend WithEvents EditBt As Windows.Forms.Button
    Friend WithEvents CloseBt As Windows.Forms.Button
    Friend WithEvents InsertBt As Windows.Forms.Button
End Class
