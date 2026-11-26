Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form6

    Private isLoading As Boolean = True
    Private activeTab As String = "Listings"

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLoading = True
        UpdateAuthButton()
        UpdateTabButtons()
        loadAdminPets()
        isLoading = False
    End Sub

    Private Sub Form6_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible AndAlso Not isLoading Then
            UpdateAuthButton()
            UpdateTabButtons()
            loadAdminPets()
        End If
    End Sub

    Private Sub flpQueue_SizeChanged(sender As Object, e As EventArgs) Handles flpQueue.SizeChanged
        Dim targetWidth As Integer = Math.Max(890, flpQueue.ClientSize.Width - 20)
        For Each ctrl As Control In flpQueue.Controls
            ctrl.Width = targetWidth
        Next
    End Sub

    Sub UpdateAuthButton()
        If isLoggedIn Then
            btnLogout.Text = "Log out"
        Else
            btnLogout.Text = "Login"
        End If
    End Sub

    Sub UpdateTabButtons()
        If activeTab = "Listings" Then
            btnTabListings.BackColor = Color.White
            btnTabListings.ForeColor = Color.FromArgb(24, 24, 27)
            btnTabAdoptions.BackColor = Color.FromArgb(39, 39, 42)
            btnTabAdoptions.ForeColor = Color.FromArgb(212, 212, 216)

            lblColBreed.Text = "BREED / SPECIES"
            lblColOwner.Text = "OWNER CONTACT"
            lblColDate.Text = "DATE SUBMITTED"
        Else
            btnTabAdoptions.BackColor = Color.White
            btnTabAdoptions.ForeColor = Color.FromArgb(24, 24, 27)
            btnTabListings.BackColor = Color.FromArgb(39, 39, 42)
            btnTabListings.ForeColor = Color.FromArgb(212, 212, 216)

            lblColBreed.Text = "APPLICANT & HOUSING"
            lblColOwner.Text = "CONTACT INFO"
            lblColDate.Text = "DATE APPLIED"
        End If
    End Sub

    Private Sub btnTabListings_Click(sender As Object, e As EventArgs) Handles btnTabListings.Click
        activeTab = "Listings"
        UpdateTabButtons()
        loadAdminPets()
    End Sub

    Private Sub btnTabAdoptions_Click(sender As Object, e As EventArgs) Handles btnTabAdoptions.Click
        activeTab = "Adoptions"
        UpdateTabButtons()
        loadAdminPets()
    End Sub

    ' =========================================================================
    ' NAVIGATION (SEPARATE FORMS)
    ' =========================================================================
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click, btnHome.Click, btnExit.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdopt_Click(sender As Object, e As EventArgs) Handles btnAdopt.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If isLoggedIn Then
            Dim result As DialogResult = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                isLoggedIn = False
                currentUser = ""
                Form2.Show()
                Me.Hide()
            End If
        Else
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    ' =========================================================================
    ' LOAD KPIs & REVIEW QUEUE ROWS
    ' =========================================================================
    Sub loadAdminPets()
        flpQueue.Controls.Clear()
        Dim dt As New DataTable
        Dim adoptedCount As Integer = 0
        Dim availableCount As Integer = 0
        Dim pendingListingsCount As Integer = 0
        Dim pendingAdoptionsCount As Integer = 0

        Try
            openCon()
            cmd.Connection = con

            If activeTab = "Listings" Then
                cmd.CommandText = "SELECT id, name, species, breed, owner_name, owner_phone, date_added, status FROM pets_tbl ORDER BY id ASC"
            Else
                cmd.CommandText = "SELECT a.id, a.pet_id, a.pet_name, IFNULL(p.species, 'Pet') AS species, a.applicant_name, a.housing, a.phone, a.email, a.message, a.status, a.date_submitted " &
                                  "FROM adoptions_tbl a LEFT JOIN pets_tbl p ON a.pet_id = p.id ORDER BY a.id DESC"
            End If
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            cmd.CommandText = "SELECT COUNT(*) FROM pets_tbl WHERE status = 'Adopted'"
            adoptedCount = Convert.ToInt32(cmd.ExecuteScalar())

            cmd.CommandText = "SELECT COUNT(*) FROM pets_tbl WHERE status = 'Approved'"
            availableCount = Convert.ToInt32(cmd.ExecuteScalar())

            cmd.CommandText = "SELECT COUNT(*) FROM pets_tbl WHERE status = 'Pending Review'"
            pendingListingsCount = Convert.ToInt32(cmd.ExecuteScalar())

            cmd.CommandText = "SELECT COUNT(*) FROM adoptions_tbl WHERE status = 'Pending'"
            pendingAdoptionsCount = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error loading admin data from database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        lblAdopted.Text = adoptedCount.ToString()
        lblAvailable.Text = availableCount.ToString()
        lblPending.Text = (pendingListingsCount + pendingAdoptionsCount).ToString()

        btnTabListings.Text = "📋 Pet Listings (" & pendingListingsCount & ")"
        btnTabAdoptions.Text = "🐾 Adoption Requests (" & pendingAdoptionsCount & ")"

        For Each row As DataRow In dt.Rows
            Dim rowCard As Panel
            If activeTab = "Listings" Then
                rowCard = CreateQueueRow(row)
            Else
                rowCard = CreateAdoptionRequestRow(row)
            End If
            flpQueue.Controls.Add(rowCard)
        Next
    End Sub

    Function CreateQueueRow(row As DataRow) As Panel
        Dim petId As String = row("id").ToString()
        Dim petName As String = row("name").ToString()
        Dim species As String = row("species").ToString()
        Dim breed As String = row("breed").ToString()
        Dim ownerName As String = row("owner_name").ToString()
        Dim ownerPhone As String = row("owner_phone").ToString()
        Dim dateAdded As String = row("date_added").ToString()
        Dim statusText As String = row("status").ToString()

        Dim rowWidth As Integer = Math.Max(890, flpQueue.ClientSize.Width - 20)
        Dim pnlRow As New Panel()
        pnlRow.Size = New Size(rowWidth, 62)
        pnlRow.BackColor = Color.White
        pnlRow.Margin = New Padding(0)

        Dim pnlDivider As New Panel()
        pnlDivider.Dock = DockStyle.Bottom
        pnlDivider.Height = 1
        pnlDivider.BackColor = Color.FromArgb(244, 244, 245)

        ' 1. Pet Thumbnail + Name
        Dim picThumb As New PictureBox()
        picThumb.Size = New Size(40, 40)
        picThumb.Location = New Point(16, 11)
        picThumb.SizeMode = PictureBoxSizeMode.Normal
        picThumb.Image = GetPetPhoto(petName, species, 40, 40)

        Dim lblPetName As New Label()
        lblPetName.Text = petName
        lblPetName.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblPetName.ForeColor = Color.FromArgb(24, 24, 27)
        lblPetName.Location = New Point(66, 20)
        lblPetName.Size = New Size(140, 22)

        ' 2. Breed / Species
        Dim lblSpecies As New Label()
        lblSpecies.Text = species
        lblSpecies.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblSpecies.ForeColor = Color.FromArgb(39, 39, 42)
        lblSpecies.Location = New Point(215, 13)
        lblSpecies.Size = New Size(160, 18)

        Dim lblBreed As New Label()
        lblBreed.Text = breed
        lblBreed.Font = New Font("Segoe UI", 8.0F)
        lblBreed.ForeColor = Color.FromArgb(113, 113, 122)
        lblBreed.Location = New Point(215, 31)
        lblBreed.Size = New Size(160, 18)

        ' 3. Owner Contact
        Dim lblOwner As New Label()
        lblOwner.Text = ownerName
        lblOwner.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblOwner.ForeColor = Color.FromArgb(39, 39, 42)
        lblOwner.Location = New Point(385, 13)
        lblOwner.Size = New Size(160, 18)

        Dim lblPhone As New Label()
        lblPhone.Text = ownerPhone
        lblPhone.Font = New Font("Segoe UI", 8.0F)
        lblPhone.ForeColor = Color.FromArgb(113, 113, 122)
        lblPhone.Location = New Point(385, 31)
        lblPhone.Size = New Size(160, 18)

        ' 4. Date Submitted
        Dim lblDate As New Label()
        lblDate.Text = dateAdded
        lblDate.Font = New Font("Segoe UI", 8.5F)
        lblDate.ForeColor = Color.FromArgb(113, 113, 122)
        lblDate.Location = New Point(555, 21)
        lblDate.Size = New Size(115, 18)

        ' 5. Status Badge
        Dim lblRowStatus As New Label()
        lblRowStatus.Font = New Font("Segoe UI", 7.75F, FontStyle.Bold)
        lblRowStatus.Size = New Size(102, 24)
        lblRowStatus.Location = New Point(668, 19)
        lblRowStatus.TextAlign = ContentAlignment.MiddleCenter

        If statusText = "Approved" Then
            lblRowStatus.Text = "Approved"
            lblRowStatus.BackColor = Color.FromArgb(209, 250, 229)
            lblRowStatus.ForeColor = Color.FromArgb(6, 95, 70)
        ElseIf statusText = "Pending Adoption" Then
            lblRowStatus.Text = "Pending Adoption"
            lblRowStatus.BackColor = Color.FromArgb(219, 234, 254)
            lblRowStatus.ForeColor = Color.FromArgb(30, 64, 175)
        ElseIf statusText = "Adopted" Then
            lblRowStatus.Text = "Adopted"
            lblRowStatus.BackColor = Color.FromArgb(220, 252, 231)
            lblRowStatus.ForeColor = Color.FromArgb(21, 128, 61)
        ElseIf statusText = "Rejected" Then
            lblRowStatus.Text = "Rejected"
            lblRowStatus.BackColor = Color.FromArgb(254, 226, 226)
            lblRowStatus.ForeColor = Color.FromArgb(153, 27, 27)
        Else
            lblRowStatus.Text = "Pending"
            lblRowStatus.BackColor = Color.FromArgb(254, 243, 199)
            lblRowStatus.ForeColor = Color.FromArgb(146, 64, 14)
        End If

        ' 6. Actions
        Dim btnEye As New Button()
        btnEye.Text = "👁"
        btnEye.Tag = petId
        btnEye.Font = New Font("Segoe UI Emoji", 9.0F)
        btnEye.BackColor = Color.White
        btnEye.ForeColor = Color.FromArgb(82, 82, 91)
        btnEye.FlatStyle = FlatStyle.Flat
        btnEye.FlatAppearance.BorderSize = 0
        btnEye.Size = New Size(30, 26)
        btnEye.Location = New Point(rowWidth - 42, 18)
        btnEye.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEye.Cursor = Cursors.Hand
        AddHandler btnEye.Click, AddressOf btnRowView_Click

        If statusText = "Pending Review" Then
            Dim btnApproveRow As New Button()
            btnApproveRow.Text = "Approve"
            btnApproveRow.Tag = petId
            btnApproveRow.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
            btnApproveRow.BackColor = Color.FromArgb(22, 163, 74)
            btnApproveRow.ForeColor = Color.White
            btnApproveRow.FlatStyle = FlatStyle.Flat
            btnApproveRow.FlatAppearance.BorderSize = 0
            btnApproveRow.Size = New Size(64, 26)
            btnApproveRow.Location = New Point(rowWidth - 172, 18)
            btnApproveRow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnApproveRow.Cursor = Cursors.Hand
            AddHandler btnApproveRow.Click, AddressOf btnRowApprove_Click

            Dim btnRejectRow As New Button()
            btnRejectRow.Text = "Reject"
            btnRejectRow.Tag = petId
            btnRejectRow.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
            btnRejectRow.BackColor = Color.FromArgb(225, 29, 72)
            btnRejectRow.ForeColor = Color.White
            btnRejectRow.FlatStyle = FlatStyle.Flat
            btnRejectRow.FlatAppearance.BorderSize = 0
            btnRejectRow.Size = New Size(56, 26)
            btnRejectRow.Location = New Point(rowWidth - 104, 18)
            btnRejectRow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnRejectRow.Cursor = Cursors.Hand
            AddHandler btnRejectRow.Click, AddressOf btnRowReject_Click

            pnlRow.Controls.Add(btnApproveRow)
            pnlRow.Controls.Add(btnRejectRow)
        Else
            Dim btnResetRow As New Button()
            btnResetRow.Text = "Reset"
            btnResetRow.Tag = petId
            btnResetRow.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
            btnResetRow.BackColor = Color.FromArgb(244, 244, 245)
            btnResetRow.ForeColor = Color.FromArgb(63, 63, 70)
            btnResetRow.FlatStyle = FlatStyle.Flat
            btnResetRow.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 216)
            btnResetRow.Size = New Size(56, 26)
            btnResetRow.Location = New Point(rowWidth - 104, 18)
            btnResetRow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnResetRow.Cursor = Cursors.Hand
            AddHandler btnResetRow.Click, AddressOf btnRowReset_Click
            pnlRow.Controls.Add(btnResetRow)
        End If

        pnlRow.Controls.Add(picThumb)
        pnlRow.Controls.Add(lblPetName)
        pnlRow.Controls.Add(lblSpecies)
        pnlRow.Controls.Add(lblBreed)
        pnlRow.Controls.Add(lblOwner)
        pnlRow.Controls.Add(lblPhone)
        pnlRow.Controls.Add(lblDate)
        pnlRow.Controls.Add(lblRowStatus)
        pnlRow.Controls.Add(btnEye)
        pnlRow.Controls.Add(pnlDivider)

        Return pnlRow
    End Function

    Function CreateAdoptionRequestRow(row As DataRow) As Panel
        Dim appId As String = row("id").ToString()
        Dim petId As String = row("pet_id").ToString()
        Dim petName As String = row("pet_name").ToString()
        Dim species As String = row("species").ToString()
        Dim applicant As String = row("applicant_name").ToString()
        Dim housing As String = row("housing").ToString()
        Dim phone As String = row("phone").ToString()
        Dim email As String = row("email").ToString()
        Dim msg As String = row("message").ToString()
        Dim dateApplied As String = row("date_submitted").ToString()
        Dim statusText As String = row("status").ToString()

        Dim rowWidth As Integer = Math.Max(890, flpQueue.ClientSize.Width - 20)
        Dim pnlRow As New Panel()
        pnlRow.Size = New Size(rowWidth, 62)
        pnlRow.BackColor = Color.White
        pnlRow.Margin = New Padding(0)

        Dim pnlDivider As New Panel()
        pnlDivider.Dock = DockStyle.Bottom
        pnlDivider.Height = 1
        pnlDivider.BackColor = Color.FromArgb(244, 244, 245)

        ' 1. Pet Thumbnail + Name
        Dim picThumb As New PictureBox()
        picThumb.Size = New Size(40, 40)
        picThumb.Location = New Point(16, 11)
        picThumb.SizeMode = PictureBoxSizeMode.Normal
        picThumb.Image = GetPetPhoto(petName, species, 40, 40)

        Dim lblPetName As New Label()
        lblPetName.Text = petName
        lblPetName.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblPetName.ForeColor = Color.FromArgb(24, 24, 27)
        lblPetName.Location = New Point(66, 20)
        lblPetName.Size = New Size(140, 22)

        ' 2. Applicant & Housing
        Dim lblApplicant As New Label()
        lblApplicant.Text = applicant
        lblApplicant.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblApplicant.ForeColor = Color.FromArgb(39, 39, 42)
        lblApplicant.Location = New Point(215, 13)
        lblApplicant.Size = New Size(160, 18)

        Dim lblHousing As New Label()
        lblHousing.Text = housing
        lblHousing.Font = New Font("Segoe UI", 8.0F)
        lblHousing.ForeColor = Color.FromArgb(113, 113, 122)
        lblHousing.Location = New Point(215, 31)
        lblHousing.Size = New Size(160, 18)

        ' 3. Contact Info
        Dim lblPhone As New Label()
        lblPhone.Text = phone
        lblPhone.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblPhone.ForeColor = Color.FromArgb(39, 39, 42)
        lblPhone.Location = New Point(385, 13)
        lblPhone.Size = New Size(160, 18)

        Dim lblEmail As New Label()
        lblEmail.Text = email
        lblEmail.Font = New Font("Segoe UI", 8.0F)
        lblEmail.ForeColor = Color.FromArgb(113, 113, 122)
        lblEmail.Location = New Point(385, 31)
        lblEmail.Size = New Size(160, 18)

        ' 4. Date Applied
        Dim lblDate As New Label()
        lblDate.Text = dateApplied
        lblDate.Font = New Font("Segoe UI", 8.5F)
        lblDate.ForeColor = Color.FromArgb(113, 113, 122)
        lblDate.Location = New Point(555, 21)
        lblDate.Size = New Size(115, 18)

        ' 5. Status Badge
        Dim lblRowStatus As New Label()
        lblRowStatus.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblRowStatus.Size = New Size(86, 24)
        lblRowStatus.Location = New Point(682, 19)
        lblRowStatus.TextAlign = ContentAlignment.MiddleCenter

        If statusText = "Approved" Then
            lblRowStatus.Text = "Approved"
            lblRowStatus.BackColor = Color.FromArgb(209, 250, 229)
            lblRowStatus.ForeColor = Color.FromArgb(6, 95, 70)
        ElseIf statusText = "Rejected" Then
            lblRowStatus.Text = "Rejected"
            lblRowStatus.BackColor = Color.FromArgb(254, 226, 226)
            lblRowStatus.ForeColor = Color.FromArgb(153, 27, 27)
        Else
            lblRowStatus.Text = "Pending"
            lblRowStatus.BackColor = Color.FromArgb(254, 243, 199)
            lblRowStatus.ForeColor = Color.FromArgb(146, 64, 14)
        End If

        ' 6. Actions (View Message + Approve/Reject or Reset)
        Dim infoPayload As String = "Pet: " & petName & vbCrLf &
                                    "Applicant: " & applicant & vbCrLf &
                                    "Phone: " & phone & vbCrLf &
                                    "Email: " & email & vbCrLf &
                                    "Housing: " & housing & vbCrLf &
                                    "Date Applied: " & dateApplied & vbCrLf &
                                    "Status: " & statusText & vbCrLf & vbCrLf &
                                    "Message:" & vbCrLf & If(String.IsNullOrWhiteSpace(msg), "(No message provided)", msg)

        Dim btnEye As New Button()
        btnEye.Text = "👁"
        btnEye.Tag = infoPayload
        btnEye.Font = New Font("Segoe UI Emoji", 9.0F)
        btnEye.BackColor = Color.White
        btnEye.ForeColor = Color.FromArgb(82, 82, 91)
        btnEye.FlatStyle = FlatStyle.Flat
        btnEye.FlatAppearance.BorderSize = 0
        btnEye.Size = New Size(30, 26)
        btnEye.Location = New Point(rowWidth - 42, 18)
        btnEye.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEye.Cursor = Cursors.Hand
        AddHandler btnEye.Click, AddressOf btnAdoptionView_Click

        Dim idPair As String = appId & "|" & petId
        If statusText = "Approved" OrElse statusText = "Rejected" Then
            Dim btnResetRow As New Button()
            btnResetRow.Text = "Reset"
            btnResetRow.Tag = idPair
            btnResetRow.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
            btnResetRow.BackColor = Color.FromArgb(244, 244, 245)
            btnResetRow.ForeColor = Color.FromArgb(63, 63, 70)
            btnResetRow.FlatStyle = FlatStyle.Flat
            btnResetRow.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 216)
            btnResetRow.Size = New Size(56, 26)
            btnResetRow.Location = New Point(rowWidth - 104, 18)
            btnResetRow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnResetRow.Cursor = Cursors.Hand
            AddHandler btnResetRow.Click, AddressOf btnAdoptionReset_Click
            pnlRow.Controls.Add(btnResetRow)
        Else
            Dim btnApproveRow As New Button()
            btnApproveRow.Text = "Approve"
            btnApproveRow.Tag = idPair
            btnApproveRow.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
            btnApproveRow.BackColor = Color.FromArgb(22, 163, 74)
            btnApproveRow.ForeColor = Color.White
            btnApproveRow.FlatStyle = FlatStyle.Flat
            btnApproveRow.FlatAppearance.BorderSize = 0
            btnApproveRow.Size = New Size(64, 26)
            btnApproveRow.Location = New Point(rowWidth - 172, 18)
            btnApproveRow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnApproveRow.Cursor = Cursors.Hand
            AddHandler btnApproveRow.Click, AddressOf btnAdoptionApprove_Click

            Dim btnRejectRow As New Button()
            btnRejectRow.Text = "Reject"
            btnRejectRow.Tag = idPair
            btnRejectRow.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
            btnRejectRow.BackColor = Color.FromArgb(225, 29, 72)
            btnRejectRow.ForeColor = Color.White
            btnRejectRow.FlatStyle = FlatStyle.Flat
            btnRejectRow.FlatAppearance.BorderSize = 0
            btnRejectRow.Size = New Size(56, 26)
            btnRejectRow.Location = New Point(rowWidth - 104, 18)
            btnRejectRow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
            btnRejectRow.Cursor = Cursors.Hand
            AddHandler btnRejectRow.Click, AddressOf btnAdoptionReject_Click

            pnlRow.Controls.Add(btnApproveRow)
            pnlRow.Controls.Add(btnRejectRow)
        End If

        pnlRow.Controls.Add(picThumb)
        pnlRow.Controls.Add(lblPetName)
        pnlRow.Controls.Add(lblApplicant)
        pnlRow.Controls.Add(lblHousing)
        pnlRow.Controls.Add(lblPhone)
        pnlRow.Controls.Add(lblEmail)
        pnlRow.Controls.Add(lblDate)
        pnlRow.Controls.Add(lblRowStatus)
        pnlRow.Controls.Add(btnEye)
        pnlRow.Controls.Add(pnlDivider)

        Return pnlRow
    End Function

    ' =========================================================================
    ' PET LISTING ACTIONS
    ' =========================================================================
    Private Sub btnRowApprove_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        UpdatePetStatus(btn.Tag.ToString(), "Approved")
    End Sub

    Private Sub btnRowReject_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        UpdatePetStatus(btn.Tag.ToString(), "Rejected")
    End Sub

    Private Sub btnRowReset_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        UpdatePetStatus(btn.Tag.ToString(), "Pending Review")
    End Sub

    Private Sub btnRowView_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        selectedPetID = btn.Tag.ToString()
        FormPetDetails.ShowDialog()
        loadAdminPets()
    End Sub

    Sub UpdatePetStatus(petId As String, newStatus As String)
        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "UPDATE pets_tbl SET status = '" & newStatus & "' WHERE id = '" & petId & "'"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error updating pet status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        loadAdminPets()
    End Sub

    ' =========================================================================
    ' ADOPTION REQUEST VERIFICATION ACTIONS
    ' =========================================================================
    Private Sub btnAdoptionApprove_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim parts() As String = btn.Tag.ToString().Split("|"c)
        Dim appId As String = parts(0)
        Dim petId As String = parts(1)

        Try
            openCon()
            cmd.Connection = con

            ' 1. Approve this adoption request
            cmd.CommandText = "UPDATE adoptions_tbl SET status = 'Approved' WHERE id = '" & appId & "'"
            cmd.ExecuteNonQuery()

            ' 2. Mark the pet as Adopted so it will no longer appear in Featured or Adopt Me
            cmd.CommandText = "UPDATE pets_tbl SET status = 'Adopted' WHERE id = '" & petId & "'"
            cmd.ExecuteNonQuery()

            ' 3. Reject any other competing pending requests for the same pet
            cmd.CommandText = "UPDATE adoptions_tbl SET status = 'Rejected' WHERE pet_id = '" & petId & "' AND id <> '" & appId & "' AND status = 'Pending'"
            cmd.ExecuteNonQuery()

            MessageBox.Show("Adoption request approved! The pet is now marked as Adopted and removed from Featured / Adopt Me.", "Adoption Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error approving adoption: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        loadAdminPets()
    End Sub

    Private Sub btnAdoptionReject_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim parts() As String = btn.Tag.ToString().Split("|"c)
        Dim appId As String = parts(0)
        Dim petId As String = parts(1)

        Try
            openCon()
            cmd.Connection = con

            ' 1. Reject this adoption request
            cmd.CommandText = "UPDATE adoptions_tbl SET status = 'Rejected' WHERE id = '" & appId & "'"
            cmd.ExecuteNonQuery()

            ' 2. Return the pet back to Approved (available) so others can adopt it
            cmd.CommandText = "UPDATE pets_tbl SET status = 'Approved' WHERE id = '" & petId & "' AND status = 'Pending Adoption'"
            cmd.ExecuteNonQuery()

            MessageBox.Show("Adoption request rejected. The pet is now available again in Adopt Me.", "Adoption Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error rejecting adoption: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        loadAdminPets()
    End Sub

    Private Sub btnAdoptionReset_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim parts() As String = btn.Tag.ToString().Split("|"c)
        Dim appId As String = parts(0)
        Dim petId As String = parts(1)

        Try
            openCon()
            cmd.Connection = con

            cmd.CommandText = "UPDATE adoptions_tbl SET status = 'Pending' WHERE id = '" & appId & "'"
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE pets_tbl SET status = 'Pending Adoption' WHERE id = '" & petId & "'"
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error resetting adoption: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        loadAdminPets()
    End Sub

    Private Sub btnAdoptionView_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        MessageBox.Show(btn.Tag.ToString(), "Adoption Application Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
