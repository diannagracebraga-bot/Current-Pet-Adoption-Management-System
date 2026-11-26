Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormPetDetails

    Private currentPetName As String = ""

    Private Sub FormPetDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboHousing.SelectedIndex = 0
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtMsg.Clear()

        If isLoggedIn Then
            If Not String.IsNullOrEmpty(currentUser) Then
                txtName.Text = currentUser
            End If
            btnSubmit.Text = "🐾 Send Application"
        Else
            btnSubmit.Text = "🔒 Login to Adopt"
        End If

        loadPetDetails()
    End Sub

    Sub loadPetDetails()
        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM pets_tbl WHERE id = '" & selectedPetID & "'"
            adapter.SelectCommand = cmd
            Dim dt As New DataTable
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                Dim petStatus As String = row("status").ToString()
                currentPetName = row("name").ToString()
                Me.Text = "PawHaven - Adopt " & currentPetName
                lblPetName.Text = currentPetName
                lblSubtitle.Text = row("age").ToString() & " • " & row("gender").ToString() & " • " & row("size").ToString() & " • Located in " & row("owner_city").ToString()
                lblStatus.Text = petStatus

                If petStatus = "Approved" Then
                    btnSubmit.Enabled = True
                    btnSubmit.Text = "🐾 Send Application"
                    btnSubmit.BackColor = Color.FromArgb(31, 122, 40)
                ElseIf petStatus = "Pending Adoption" Then
                    btnSubmit.Enabled = False
                    btnSubmit.Text = "⏳ Pending Verification"
                    btnSubmit.BackColor = Color.Gray
                ElseIf petStatus = "Adopted" Then
                    btnSubmit.Enabled = False
                    btnSubmit.Text = "✅ Already Adopted"
                    btnSubmit.BackColor = Color.Gray
                Else
                    btnSubmit.Enabled = False
                    btnSubmit.Text = "Not Available"
                    btnSubmit.BackColor = Color.Gray
                End If

                Dim breed As String = row("breed").ToString()
                Dim species As String = row("species").ToString()
                txtStory.Text = currentPetName & " is a wonderful " & breed & " looking for a loving forever home. Very friendly and ready to meet you!"

                lblAge.Text = "Age: " & row("age").ToString()
                lblSex.Text = "Sex: " & row("gender").ToString()
                lblSize.Text = "Size: " & row("size").ToString()
                lblColor.Text = "Color: " & row("color").ToString()

                Dim vStatus As String = row("vaccinated").ToString()
                Dim vComplete As String = row("vaccine_complete").ToString()
                Dim vKind As String = row("vaccine_kind").ToString()
                Dim liveWith As String = row("live_with_pets").ToString()

                lblHealth.Text = "• Vaccinated: " & vStatus & " (" & vComplete & ")" & vbCrLf &
                                "• Kind: " & vKind & vbCrLf &
                                "• Good with other pets: " & liveWith

                Dim tempScore As Integer = 3
                Integer.TryParse(row("temperament").ToString(), tempScore)
                If tempScore < 1 Then tempScore = 1
                If tempScore > 5 Then tempScore = 5
                lblTemp.Text = "Temperament (Score " & tempScore & "/5)"
                pbTemp.Value = tempScore

                Dim clingScore As Integer = 3
                Integer.TryParse(row("clinginess").ToString(), clingScore)
                If clingScore < 1 Then clingScore = 1
                If clingScore > 5 Then clingScore = 5
                lblCling.Text = "Clinginess (Score " & clingScore & "/5)"
                pbCling.Value = clingScore

                picBanner.Image = GetPetPhoto(currentPetName, species, picBanner.Width, picBanner.Height)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading pet details from database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Function CreateBannerImage(name As String, species As String) As Image
        Dim bmp As New Bitmap(picBanner.Width, picBanner.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(Color.FromArgb(240, 246, 240))

            Dim emoji As String = "🐾"
            If species.ToLower().Contains("dog") Then emoji = "🐶"
            If species.ToLower().Contains("cat") Then emoji = "🐱"
            If species.ToLower().Contains("small") Or species.ToLower().Contains("rabbit") Then emoji = "🐰"

            Using fontEmoji As New Font("Segoe UI Emoji", 42, FontStyle.Regular)
                Using brush As New SolidBrush(Color.FromArgb(31, 122, 40))
                    g.DrawString(emoji, fontEmoji, brush, New PointF(CSng(bmp.Width / 2 - 35), 30))
                End Using
            End Using

            Using fontName As New Font("Segoe UI", 14, FontStyle.Bold)
                Using brush As New SolidBrush(Color.FromArgb(23, 92, 30))
                    Dim sf As New StringFormat()
                    sf.Alignment = StringAlignment.Center
                    g.DrawString(name & " (" & species & ")", fontName, brush, CSng(bmp.Width / 2), 115, sf)
                End Using
            End Using
        End Using
        Return bmp
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not isLoggedIn Then
            MessageBox.Show("Please log in first to submit an adoption application.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.Retry
            Me.Close()
            Return
        End If

        Dim fullName As String = txtName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim housing As String = cboHousing.Text.Trim()
        Dim msg As String = txtMsg.Text.Trim()

        If fullName = "" Then
            MessageBox.Show("Please enter your full name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        If phone = "" Then
            MessageBox.Show("Please enter your phone number.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        If email = "" Then
            MessageBox.Show("Please enter your email address.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return
        End If

        Dim dateNow As String = DateTime.Now.ToString("yyyy-MM-dd")

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO adoptions_tbl (pet_id, pet_name, applicant_name, phone, email, housing, message, status, date_submitted) VALUES (" &
                              "'" & selectedPetID & "', " &
                              "'" & currentPetName.Replace("'", "''") & "', " &
                              "'" & fullName.Replace("'", "''") & "', " &
                              "'" & phone.Replace("'", "''") & "', " &
                              "'" & email.Replace("'", "''") & "', " &
                              "'" & housing.Replace("'", "''") & "', " &
                              "'" & msg.Replace("'", "''") & "', " &
                              "'Pending', " &
                              "'" & dateNow & "')"
            cmd.ExecuteNonQuery()

            ' Mark pet as Pending Adoption so it is held for admin verification and hidden from Featured / Adopt Me
            cmd.CommandText = "UPDATE pets_tbl SET status = 'Pending Adoption' WHERE id = '" & selectedPetID & "'"
            cmd.ExecuteNonQuery()

            MessageBox.Show("Thank you, " & fullName & "! Your adoption application for " & currentPetName & " has been submitted and is pending admin verification.", "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error submitting application: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

End Class
