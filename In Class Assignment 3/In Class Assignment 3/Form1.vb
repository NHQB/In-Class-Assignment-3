Option Strict On
Public Class Form1
    ''' <summary>
    ''' Handles clicking yes button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        MsgBox("Yes, you ARE awesome! Great job, and thank you.")
        Application.Exit()
    End Sub
End Class
