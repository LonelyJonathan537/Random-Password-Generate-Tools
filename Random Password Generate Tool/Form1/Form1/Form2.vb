Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the font size and style
        lblPasswordStrength.Font = New Font(lblPasswordStrength.Font.FontFamily, 10, FontStyle.Bold)

        ' Set the label size
        lblPasswordStrength.AutoSize = False
        lblPasswordStrength.Size = New Size(300, 50)
        lblPasswordStrength.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Function CheckPasswordStrength(password As String) As String
        Dim score As Integer = 0

        If password.Length >= 8 Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "\d") Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[!@#$%^&*(),.?""':{}|<>]") Then score += 1

        Select Case score
            Case 5
                Return "Very Strong"
            Case 4
                Return "Strong"
            Case 3
                Return "Moderate"
            Case 2
                Return "Weak"
            Case Else
                Return "Very Weak"
        End Select
    End Function

    Private Sub btnCheckPassword_Click(sender As Object, e As EventArgs) Handles btnCheckPassword.Click
        Dim strength As String = CheckPasswordStrength(txtPassword.Text)
        lblPasswordStrength.Text = "Password Strength: " & strength

        Select Case strength
            Case "Very Weak"
                lblPasswordStrength.ForeColor = Color.Red
            Case "Weak"
                lblPasswordStrength.ForeColor = Color.OrangeRed
            Case "Moderate"
                lblPasswordStrength.ForeColor = Color.Yellow
            Case "Strong"
                lblPasswordStrength.ForeColor = Color.Green
            Case "Very Strong"
                lblPasswordStrength.ForeColor = Color.DarkGreen
        End Select
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim aboutForm As New AboutForm()
        ' Optionally load and set an image on the AboutForm
        ' Example: aboutForm.PictureBox.Image = My.Resources.YourImageName
        aboutForm.ShowDialog()
    End Sub

    Private Sub PasswordTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordTestToolStripMenuItem.Click
        ' Return to the main form (Form1) without opening a new instance
        Me.Close()
    End Sub
End Class
