<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtPassword = New TextBox()
        txtLength = New TextBox()
        lblStrength = New Label()
        btnAutoGenerate = New Button()
        btnSave = New Button()
        btnCheckStrength = New Button()
        btnCopyToClipboard = New Button()
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        PasswordHistoryToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(71, 182)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(586, 172)
        txtPassword.TabIndex = 0
        ' 
        ' txtLength
        ' 
        txtLength.Location = New Point(188, 64)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(125, 27)
        txtLength.TabIndex = 1
        ' 
        ' lblStrength
        ' 
        lblStrength.AutoSize = True
        lblStrength.Location = New Point(223, 141)
        lblStrength.Name = "lblStrength"
        lblStrength.Size = New Size(0, 20)
        lblStrength.TabIndex = 2
        ' 
        ' btnAutoGenerate
        ' 
        btnAutoGenerate.Location = New Point(553, 137)
        btnAutoGenerate.Name = "btnAutoGenerate"
        btnAutoGenerate.Size = New Size(94, 29)
        btnAutoGenerate.TabIndex = 3
        btnAutoGenerate.Text = "Generate"
        btnAutoGenerate.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(563, 369)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCheckStrength
        ' 
        btnCheckStrength.Location = New Point(71, 137)
        btnCheckStrength.Name = "btnCheckStrength"
        btnCheckStrength.Size = New Size(133, 29)
        btnCheckStrength.TabIndex = 5
        btnCheckStrength.Text = "Check Strength"
        btnCheckStrength.UseVisualStyleBackColor = True
        ' 
        ' btnCopyToClipboard
        ' 
        btnCopyToClipboard.Location = New Point(71, 97)
        btnCopyToClipboard.Name = "btnCopyToClipboard"
        btnCopyToClipboard.Size = New Size(163, 29)
        btnCopyToClipboard.TabIndex = 6
        btnCopyToClipboard.Text = "Copy to Clipboard"
        btnCopyToClipboard.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(71, 62)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 7
        Button1.Text = "Set Length"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 8
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem, PasswordHistoryToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(75, 24)
        ToolStripMenuItem1.Text = "Options"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(204, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' PasswordHistoryToolStripMenuItem
        ' 
        PasswordHistoryToolStripMenuItem.Name = "PasswordHistoryToolStripMenuItem"
        PasswordHistoryToolStripMenuItem.Size = New Size(204, 26)
        PasswordHistoryToolStripMenuItem.Text = "Password History"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(64, 24)
        ToolStripMenuItem2.Text = "About"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btnCopyToClipboard)
        Controls.Add(btnCheckStrength)
        Controls.Add(btnSave)
        Controls.Add(btnAutoGenerate)
        Controls.Add(lblStrength)
        Controls.Add(txtLength)
        Controls.Add(txtPassword)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblStrength As Label
    Friend WithEvents btnAutoGenerate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCheckStrength As Button
    Friend WithEvents btnCopyToClipboard As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasswordHistoryToolStripMenuItem As ToolStripMenuItem

End Class
