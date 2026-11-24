Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStateManager.LoadSavedState()
        Me.WindowState = FormStateManager.LastState
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        set_adoption.Show()
    End Sub
End Class