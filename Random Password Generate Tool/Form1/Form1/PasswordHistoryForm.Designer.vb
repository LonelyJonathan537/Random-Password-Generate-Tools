<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PasswordHistoryForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required designer variable.
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordHistoryForm))
        ListBox1 = New ListBox()
        btnDelete = New Button()
        btnClose = New Button()
        btnSaveToFile = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(11, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(267, 244)
        ListBox1.TabIndex = 0
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(11, 262)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(89, 30)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(188, 262)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(89, 30)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnSaveToFile
        ' 
        btnSaveToFile.Location = New Point(100, 262)
        btnSaveToFile.Name = "btnSaveToFile"
        btnSaveToFile.Size = New Size(89, 30)
        btnSaveToFile.TabIndex = 3
        btnSaveToFile.Text = "Save"
        btnSaveToFile.UseVisualStyleBackColor = True
        ' 
        ' PasswordHistoryForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(288, 307)
        Controls.Add(btnSaveToFile)
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PasswordHistoryForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "Password History"
        ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSaveToFile As Button

End Class
