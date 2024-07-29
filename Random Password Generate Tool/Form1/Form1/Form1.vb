Public Class Form1
    Dim UsableChars() As String
    Dim RandomClass As New Random()
    Dim Charslist As String = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,^,&,*,(,),[,],?,`,~"
    Dim FinalPassword As String = ""
    Dim Number As Integer = 0
    Dim PasswordHistory As New List(Of String)()

    Private Sub btnAutoGenerate_Click(sender As Object, e As EventArgs) Handles btnAutoGenerate.Click
        Dim length As Integer
        If Integer.TryParse(txtLength.Text, length) AndAlso length > 0 Then
            GeneratePassword(length)
        Else
            MessageBox.Show("Please enter a valid positive number for password length.")
        End If
    End Sub

    'Function generate password with length
    Private Sub GeneratePassword(ByVal length As Integer)
        UsableChars = Split(Charslist, ",")
        FinalPassword = ""
        Number = 0

        For i As Integer = 1 To length
            Number = RandomClass.Next(0, UsableChars.Length)
            FinalPassword &= UsableChars(Number)
        Next

        txtPassword.Text = FinalPassword

        ' Add generated password to history
        PasswordHistory.Add(FinalPassword)
    End Sub

    'Function to Save Password in txt Format
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SavePasswordToFile()
    End Sub

    Private Sub SavePasswordToFile()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Password"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            System.IO.File.WriteAllText(filePath, txtPassword.Text)
        End If
    End Sub

    'Function To Check Password Strength
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


    'Function to handle click button for check strength
    Private Sub btnCheckStrength_Click(sender As Object, e As EventArgs) Handles btnCheckStrength.Click
        Dim strength As String = CheckPasswordStrength(txtPassword.Text)
        lblStrength.Text = "Password Strength: " & strength
    End Sub

    'Function to copy clipboard
    Private Sub btnCopyToClipboard_Click(sender As Object, e As EventArgs) Handles btnCopyToClipboard.Click
        If txtPassword.Text <> "" Then
            Clipboard.SetText(txtPassword.Text)
            MessageBox.Show("Password copied to clipboard")
        Else
            MessageBox.Show("Generate a password first")
        End If
    End Sub

    'Function for MenuStrip
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
        ' Show the password strength test form (Form2)
        Dim passwordTestForm As New Form2()
        passwordTestForm.ShowDialog()
    End Sub

    Private Sub PasswordHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordHistoryToolStripMenuItem.Click
        ' Show password history dialog or form
        Dim historyForm As New PasswordHistoryForm(PasswordHistory)
        historyForm.ShowDialog()
    End Sub
End Class
