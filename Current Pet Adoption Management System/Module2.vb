Module Session
    Public LoggedInUser As String = ""
    Public IsLoggedIn As Boolean = False
End Module

Module FormStateManager

    Public LastState As FormWindowState = FormWindowState.Normal

    Public Sub LoadSavedState()
        Dim saved As String = My.Settings.WindowState
        If String.IsNullOrEmpty(saved) Then saved = "Normal"

        Select Case saved
            Case "Maximized"
                LastState = FormWindowState.Maximized
            Case "Minimized"
                LastState = FormWindowState.Minimized
            Case Else
                LastState = FormWindowState.Normal
        End Select
    End Sub

    Public Sub SwitchForm(currentForm As Form, nextForm As Form)
        ' Remember where the outgoing form was
        If currentForm.WindowState <> FormWindowState.Minimized Then
            LastState = currentForm.WindowState
        End If

        ' only meaningful if LoadSavedState ran at startup
        My.Settings.WindowState = LastState.ToString()
        My.Settings.Save()

        ' Show first, then apply state
        nextForm.Show()
        If LastState <> FormWindowState.Minimized Then
            nextForm.WindowState = LastState
        End If

        currentForm.Hide()
    End Sub

End Module
