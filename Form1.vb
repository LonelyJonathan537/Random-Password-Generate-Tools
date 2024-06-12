Public Class Form1
    Dim UsableChars() As String
    Dim RandomClass As New Random()
    Dim Charslist As String = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,^,&,*,(,),[,],?,`,~"
    Dim FinalPassword As String = ""
    Dim Number As Integer = 0

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GeneratePassword()
    End Sub

    Private Sub btnAutoGenerate_Click(sender As Object, e As EventArgs) Handles btnAutoGenerate.Click
        GeneratePassword(30) ' Set a maximum length of 30 characters for auto-generation
    End Sub

    Private Sub GeneratePassword(Optional ByVal maxLength As Integer = 0)
        UsableChars = Split(Charslist, ",")
        FinalPassword = ""
        Number = 0

        Dim passwordLength As Integer
        If maxLength > 0 Then
            passwordLength = RandomClass.Next(1, maxLength + 1) ' Set a random length up to maxLength
        Else
            passwordLength = CInt(txtLength.Text) ' Use the specified length if auto-generation not limited
        End If

        For i As Integer = 1 To passwordLength
            Number = RandomClass.Next(0, UsableChars.Length)
            FinalPassword &= UsableChars(Number)
        Next

        txtPassword.Text = FinalPassword
    End Sub

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
End Class
