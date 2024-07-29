Public Class AboutForm

    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display the about information in the label
        lblAbout.Text = "About This Application" & vbCrLf &
                        vbCrLf &
                        "This application is a random password generator" & vbCrLf & "built using Visual Basic .NET." & vbCrLf & "It provides a simple yet effective way to generate strong passwords" & vbCrLf & "for various purposes," & vbCrLf & "ensuring security and complexity." & vbCrLf & vbCrLf & vbCrLf & "Have Fun using this software."
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

End Class
