Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Form2
    Sub ClearAll_Login()

        TextBox1.Clear()
        TextBox2.Clear()
        CheckBox1.Checked = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Save current window state
        FormStateManager.SwitchForm(Me, Form1)
        ClearAll_Login()



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Show Password
        If TextBox2.PasswordChar = "*" Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Sign up - Create Account Interface
        FormStateManager.SwitchForm(Me, Form3)
        ClearAll_Login()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Login Button

        'Check if account avail on database 
        openCon()
        Dim checkuser As New MySqlCommand("SELECT * FROM users WHERE username = @currentUser AND password = @userPass", con)
        checkuser.Parameters.AddWithValue("@currentUser", TextBox1.Text)
        checkuser.Parameters.AddWithValue("@userPass", TextBox2.Text)

        Dim user As Integer = CInt(checkuser.ExecuteScalar())
        con.Close()

        If user > 0 Then
            Session.LoggedInUser = TextBox1.Text
            Session.IsLoggedIn = True
            'updating user log in status

            openCon()
            cmd.Connection = con
            cmd.Parameters.Clear()

            cmd.CommandText = "UPDATE users SET login_status = @loginstatus WHERE username = @user"
            cmd.Parameters.AddWithValue("@loginstatus", True)
            cmd.Parameters.AddWithValue("@user", TextBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Sucessfully Logged in")
            con.Close()

            ClearAll_Login()

            Form1.UpdateButton()
            FormStateManager.SwitchForm(Me, Form1)

        ElseIf Trim(TextBox1.Text) = "" And Trim(TextBox2.Text) = "" Then
            MessageBox.Show("Please enter your username and password")
            Return
        ElseIf Trim(TextBox1.Text) = "" Then
            MessageBox.Show("Please enter your username")
            Return
        ElseIf Trim(TextBox2.Text) = "" Then
            MessageBox.Show("Please enter your password")
            Return
        Else
            MessageBox.Show("Invalid user or password")
            ClearAll_Login()
            Return
        End If

    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'window state
         FormStateManager.LoadSavedState()
        Me.WindowState = FormStateManager.LastState

    End Sub


End Class