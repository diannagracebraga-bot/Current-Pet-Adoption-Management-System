Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub Form2_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            txtUser.Clear()
            txtPass.Clear()
            chkShowPass.Checked = False
            txtUser.Focus()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUser.Text.Trim()
        Dim password As String = txtPass.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE username = '" & username.Replace("'", "''") & "' AND password = '" & password.Replace("'", "''") & "'"
            adapter.SelectCommand = cmd
            Dim dt As New DataTable
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                currentUser = dt.Rows(0)("username").ToString()
                currentRole = dt.Rows(0)("role").ToString()
                isLoggedIn = True
                txtPass.Clear()

                If currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
                    MessageBox.Show("Welcome, " & currentUser & "!", "Admin Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Form6.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Welcome back, " & currentUser & "!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Form1.Show()
                    Me.Hide()
                End If
            Else
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
End Class