Public Class PasswordHistoryForm
    Private PasswordHistory As List(Of String)

    Public Sub New(ByVal passwordHistory As List(Of String))
        InitializeComponent()
        Me.PasswordHistory = passwordHistory

        ' Populate the ListBox with history entries
        For Each password As String In passwordHistory
            ListBox1.Items.Add(password)
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim selectedPassword As String = ListBox1.SelectedItem.ToString()
            PasswordHistory.Remove(selectedPassword)
            ListBox1.Items.Remove(selectedPassword)
        Else
            MessageBox.Show("Please select a password to delete.")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveToFile_Click(sender As Object, e As EventArgs) Handles btnSaveToFile.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog.Title = "Save Password History"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            System.IO.File.WriteAllLines(filePath, PasswordHistory)
            MessageBox.Show("Password history saved to file successfully.")
        End If
    End Sub
End Class
