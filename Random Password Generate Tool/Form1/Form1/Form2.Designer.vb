<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtPassword = New TextBox()
        btnCheckPassword = New Button()
        lblPasswordStrength = New Label()
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        PasswordTestToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(121, 70)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(225, 27)
        txtPassword.TabIndex = 0
        ' 
        ' btnCheckPassword
        ' 
        btnCheckPassword.Location = New Point(370, 68)
        btnCheckPassword.Name = "btnCheckPassword"
        btnCheckPassword.Size = New Size(94, 29)
        btnCheckPassword.TabIndex = 1
        btnCheckPassword.Text = "Check"
        btnCheckPassword.UseVisualStyleBackColor = True
        ' 
        ' lblPasswordStrength
        ' 
        lblPasswordStrength.AutoSize = True
        lblPasswordStrength.Location = New Point(121, 124)
        lblPasswordStrength.Name = "lblPasswordStrength"
        lblPasswordStrength.Size = New Size(0, 20)
        lblPasswordStrength.TabIndex = 2
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem, PasswordTestToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(75, 24)
        ToolStripMenuItem1.Text = "Options"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(135, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' PasswordTestToolStripMenuItem
        ' 
        PasswordTestToolStripMenuItem.Name = "PasswordTestToolStripMenuItem"
        PasswordTestToolStripMenuItem.Size = New Size(135, 26)
        PasswordTestToolStripMenuItem.Text = "Return"
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
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSalmon
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(lblPasswordStrength)
        Controls.Add(btnCheckPassword)
        Controls.Add(txtPassword)
        Name = "Form2"
        Text = "Form2"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCheckPassword As Button
    Friend WithEvents lblPasswordStrength As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasswordTestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
