<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        PictureBox1 = New PictureBox()
        btnOK = New Button()
        lblAbout = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(22, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(243, 219)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(596, 397)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(138, 29)
        btnOK.TabIndex = 2
        btnOK.Text = "Close"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' lblAbout
        ' 
        lblAbout.AutoSize = True
        lblAbout.Location = New Point(340, 64)
        lblAbout.Name = "lblAbout"
        lblAbout.Size = New Size(53, 20)
        lblAbout.TabIndex = 3
        lblAbout.Text = "Label1"
        ' 
        ' AboutForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(800, 450)
        Controls.Add(lblAbout)
        Controls.Add(btnOK)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "AboutForm"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnOK As Button
    Friend WithEvents lblAbout As Label
End Class
