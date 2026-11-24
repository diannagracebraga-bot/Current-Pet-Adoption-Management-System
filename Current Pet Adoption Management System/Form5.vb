Public Class Form5
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'go back to set adoptions page
        FormStateManager.SwitchForm(Me, Form4)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'window state
        FormStateManager.LoadSavedState()
        Me.WindowState = FormStateManager.LastState
    End Sub


End Class