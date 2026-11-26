Imports MySql.Data.MySqlClient

Public Class Form3

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPass.PasswordChar = ""
            txtConfirm.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
            txtConfirm.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUser.Text.Trim()
        Dim pass As String = txtPass.Text.Trim()
        Dim confirm As String = txtConfirm.Text.Trim()

        If username = "" Or pass = "" Or confirm = "" Then
            MessageBox.Show("Please fill out all fields.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If pass <> confirm Then
            MessageBox.Show("Passwords do not match!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT COUNT(*) FROM users WHERE username = '" & username.Replace("'", "''") & "'"
            Dim userCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If userCount > 0 Then
                MessageBox.Show("Username already taken. Please choose another.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            cmd.CommandText = "INSERT INTO users (username, password, role) VALUES ('" & username.Replace("'", "''") & "', '" & pass.Replace("'", "''") & "', 'User')"
            cmd.ExecuteNonQuery()

            currentUser = username
            currentRole = "User"
            isLoggedIn = True
            MessageBox.Show("Account successfully created! Welcome to PawHaven.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class
