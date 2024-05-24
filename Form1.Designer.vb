<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnGenerate = New Button()
        Label1 = New Label()
        txtLength = New TextBox()
        txtPassword = New TextBox()
        btnAutoGenerate = New Button()
        SuspendLayout()
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = SystemColors.AppWorkspace
        btnGenerate.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGenerate.Location = New Point(294, 28)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(126, 42)
        btnGenerate.TabIndex = 0
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 28)
        Label1.TabIndex = 1
        Label1.Text = "Length"
        ' 
        ' txtLength
        ' 
        txtLength.Location = New Point(122, 36)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(157, 27)
        txtLength.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(36, 106)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(633, 161)
        txtPassword.TabIndex = 3
        ' 
        ' btnAutoGenerate
        ' 
        btnAutoGenerate.BackColor = SystemColors.AppWorkspace
        btnAutoGenerate.Font = New Font("Corbel", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAutoGenerate.Location = New Point(441, 28)
        btnAutoGenerate.Name = "btnAutoGenerate"
        btnAutoGenerate.Size = New Size(218, 42)
        btnAutoGenerate.TabIndex = 4
        btnAutoGenerate.Text = "Auto Generate Password"
        btnAutoGenerate.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(703, 294)
        Controls.Add(btnAutoGenerate)
        Controls.Add(txtPassword)
        Controls.Add(txtLength)
        Controls.Add(Label1)
        Controls.Add(btnGenerate)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Random Password Generator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnAutoGenerate As Button
End Class
