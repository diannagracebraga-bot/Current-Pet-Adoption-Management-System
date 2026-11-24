Imports System.Security.Cryptography.X509Certificates 'this stuffs suddenly showed up automatically as I edit the code
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient


Public Class Form3 'SIGNUP page
    Sub ClearAll_Signup() 'reuse clear code for less clutter
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

        CheckBox1.Checked = False
        CheckBox2.Checked = False

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Back to login Button/optional if just want to re-add bcuz of link
        Me.Hide()
        Form2.Show()
        ClearAll_Signup()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'Create Password - show pass
        If TextBox3.PasswordChar = "*" Then
            TextBox3.PasswordChar = ""
        Else
            TextBox3.PasswordChar = "*"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Re-enter Password - show pass
        If TextBox1.PasswordChar = "*" Then
            TextBox1.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Submit button Part
        Dim usernameTXT As String = TextBox4.Text.Trim()
        Dim create_pass As String = TextBox3.Text.Trim()
        Dim re_enter_pass As String = TextBox1.Text.Trim()

        'Check duplicate accounts on database first
        openCon()
        Dim checkdup As New MySqlCommand("SELECT * FROM users WHERE username = @newUser", con)
        checkdup.Parameters.AddWithValue("@newUser", usernameTXT.Trim())

        Dim dup As Integer = CInt(checkdup.ExecuteScalar())
        con.Close()

        If dup > 0 Then
            MessageBox.Show("That username is taken, please choose another")
            ClearAll_Signup()
            Return
        End If

        'username field and matching password check if empty too

        If usernameTXT = "" And create_pass = "" And re_enter_pass = "" Then
            MessageBox.Show("Please input all necessary fields.")
            Return
            '----
        ElseIf usernameTXT = "" And create_pass = "" Then
            MessageBox.Show("Please enter your username and create password.")
            Return
        ElseIf usernameTXT = "" And re_enter_pass = "" Then
            MessageBox.Show("Please enter your username and re-enter your password.")
            Return
            '-----
        ElseIf create_pass = "" And re_enter_pass = "" Then
            MessageBox.Show("Please create your password and re-enter it.")
            Return
        ElseIf create_pass = "" And usernameTXT = "" Then
            MessageBox.Show("Please enter your username and create your password.")
            Return
            '---
        ElseIf usernameTXT = "" Then
            MessageBox.Show("Please enter your username.")
            Return
        ElseIf create_pass = "" Then
            MessageBox.Show("Please create your password.")
            Return
        ElseIf re_enter_pass = "" Then
            MessageBox.Show("Please re-enter your password.")
            Return
            '---
        ElseIf create_pass <> re_enter_pass Then
            MessageBox.Show("Passwords do not match, please check again.")
            Return
        End If

        'connecting to database
        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO users (username, password)
                                    VALUES (@user, @pass );"
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@user", usernameTXT)
            cmd.Parameters.AddWithValue("@pass", create_pass)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Sucessfully Created an Account")
            con.Close()

            Dim loginform As New Form2() 'goal of this code is to autofill the login form after signup new acc
            loginform.TextBox1.Text = TextBox4.Text
            loginform.TextBox2.Text = TextBox3.Text

            Me.Hide()
            loginform.Show() 'new login form, if form5() it shows the old one where its unfilled

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

        ClearAll_Signup()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'back to login link
        FormStateManager.SwitchForm(Me, Form2)
        ClearAll_Signup()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'window state
        FormStateManager.LoadSavedState()
        Me.WindowState = FormStateManager.LastState
    End Sub

End Class