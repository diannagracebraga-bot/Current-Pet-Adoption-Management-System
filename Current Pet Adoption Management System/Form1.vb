Public Class Form1
    Public isLoggedIn As Boolean = False

    Public Sub UpdateButton() ' pub sub to refresh
        'Show login/logout button
        If Session.IsLoggedIn = False Then
            Button4.Visible = True ' login button
            Button5.Visible = False ' logout button
        ElseIf Session.IsLoggedIn = True Then
            Button4.Visible = False ' login button
            Button5.Visible = True ' logout button
        End If
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' form code
        'Update buttons/window state
        FormStateManager.LoadSavedState()
        Me.WindowState = FormStateManager.LastState
        UpdateButton()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Save current window state
        FormStateManager.SwitchForm(Me, Form2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Set adoption button
        FormStateManager.SwitchForm(Me, Form4)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'log out
        Dim result As DialogResult = MessageBox.Show(
        "Do you wish to logout?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )
        If result = DialogResult.Yes Then

            Session.IsLoggedIn = False
            UpdateButton()

            'update to database the login status
            openCon()
            cmd.Connection = con
            cmd.Parameters.Clear()
            cmd.CommandText = "UPDATE users SET login_status = @loginstatus WHERE username = @user"
            cmd.Parameters.AddWithValue("@loginstatus", False)
            cmd.Parameters.AddWithValue("@user", Session.LoggedInUser)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Sucessfully Logged out")
            con.Close()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'about button - mission vision , goals, and contact

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'adopt me button
        '--place here tutorial on how they can use the web to adopt 
        'a pet, and the procoesses and FAQs of GentriPets Adopt
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

    End Sub
End Class

