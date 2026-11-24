Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStateManager.LoadSavedState()
        Me.WindowState = FormStateManager.LastState
    End Sub

End Class