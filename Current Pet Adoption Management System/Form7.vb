Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormStateManager.LoadSavedState()
        Me.WindowState = FormStateManager.LastState
    End Sub


End Class