# Cronin-6.2-18-Sum-numbers-Do-loop
1 to 100 = ?

Public Class frmSum

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim sum, num As Double
        Do While num < 101
            sum = sum + num
            num += 1
        Loop
        txtOutput.Text = sum
    End Sub
End Class
