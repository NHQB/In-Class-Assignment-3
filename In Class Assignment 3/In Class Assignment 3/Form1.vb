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

    ''' <summary>
    '''  Handles clicking right no button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNoRight_Click(sender As Object, e As EventArgs) Handles btnNoRight.MouseEnter
        btnNoRight.Visible = False
        btnNoLeft.Visible = True
    End Sub

    ''' <summary>
    '''  Handles clicking left no button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnNoLeft_Click(sender As Object, e As EventArgs) Handles btnNoLeft.MouseEnter
        btnNoLeft.Visible = False
        btnNoRight.Visible = True
    End Sub

    Private Sub btnNoRight_Click_1(sender As Object, e As EventArgs) Handles btnNoRight.Click
        MsgBox("You chose the wrong one, Click ok to choose again")
    End Sub

    Private Sub btnNoLeft_Click_1(sender As Object, e As EventArgs) Handles btnNoLeft.Click
        MsgBox("You chose the wrong one, Click ok to choose again")
    End Sub
End Class
