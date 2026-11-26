Imports System.Drawing
Imports System.Windows.Forms
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient

Public Class Form1

    Private isLoading As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLoading = True
        UpdateUI()
        loadFeaturedPets()
        isLoading = False
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible AndAlso Not isLoading Then
            UpdateUI()
            loadFeaturedPets()
        End If
    End Sub

    Sub UpdateUI()
        If IsLoggedIn Then
            btnLogout.Text = "Log out"
        Else
            btnLogout.Text = "Login"
        End If

        ' Show Admin Mode button only when logged in as Admin
        If IsLoggedIn AndAlso currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            btnAdmin.Visible = True
        Else
            btnAdmin.Visible = False
        End If
    End Sub

    Sub loadFeaturedPets()
        flpFeatured.Controls.Clear()
        Dim featTable As New DataTable

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT id, name, species, breed, age, gender, size, owner_city, status FROM pets_tbl WHERE status = 'Approved' ORDER BY id ASC LIMIT 3"
            adapter.SelectCommand = cmd
            adapter.Fill(featTable)
        Catch ex As Exception
            MessageBox.Show("Cannot connect to MySQL database 'gentripets_db'. Please start MySQL in XAMPP and make sure the tables exist." & vbCrLf & vbCrLf & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' Build 3 featured pet cards
        For Each row As DataRow In featTable.Rows
            Dim card As Panel = CreateFeaturedCard(row)
            flpFeatured.Controls.Add(card)
        Next
    End Sub

    Function CreateFeaturedCard(row As DataRow) As Panel
        Dim petId As String = row("id").ToString()
        Dim petName As String = row("name").ToString()
        Dim species As String = row("species").ToString()
        Dim breed As String = row("breed").ToString()
        Dim age As String = row("age").ToString()

        Dim card As New Panel()
        card.Size = New Size(298, 320)
        card.BackColor = Color.White
        card.Margin = New Padding(0, 0, 18, 12)
        card.BorderStyle = BorderStyle.FixedSingle

        ' Top photo
        Dim picPet As New PictureBox()
        picPet.Size = New Size(296, 152)
        picPet.Location = New Point(0, 0)
        picPet.SizeMode = PictureBoxSizeMode.Normal
        picPet.Image = GetPetPhoto(petName, species, 296, 152)

        ' Featured badge (top-left on photo)
        Dim lblBadge As New Label()
        lblBadge.Text = "Featured"
        lblBadge.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblBadge.BackColor = Color.FromArgb(31, 122, 40)
        lblBadge.ForeColor = Color.White
        lblBadge.Size = New Size(64, 22)
        lblBadge.Location = New Point(10, 10)
        lblBadge.TextAlign = ContentAlignment.MiddleCenter
        picPet.Controls.Add(lblBadge)

        ' Species badge (top-right on photo)
        Dim lblSpecies As New Label()
        lblSpecies.Text = species
        lblSpecies.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        lblSpecies.BackColor = Color.White
        lblSpecies.ForeColor = Color.FromArgb(39, 39, 42)
        lblSpecies.Size = New Size(56, 22)
        lblSpecies.Location = New Point(230, 10)
        lblSpecies.TextAlign = ContentAlignment.MiddleCenter
        picPet.Controls.Add(lblSpecies)

        ' Pet Name
        Dim lblName As New Label()
        lblName.Text = petName
        lblName.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(24, 24, 27)
        lblName.Location = New Point(12, 162)
        lblName.Size = New Size(190, 24)

        ' Age on right
        Dim lblAge As New Label()
        lblAge.Text = age
        lblAge.Font = New Font("Segoe UI", 8.5F)
        lblAge.ForeColor = Color.FromArgb(113, 113, 122)
        lblAge.Location = New Point(205, 165)
        lblAge.Size = New Size(78, 18)
        lblAge.TextAlign = ContentAlignment.MiddleRight

        ' Breed
        Dim lblBreed As New Label()
        lblBreed.Text = breed
        lblBreed.Font = New Font("Segoe UI", 8.5F)
        lblBreed.ForeColor = Color.FromArgb(113, 113, 122)
        lblBreed.Location = New Point(12, 186)
        lblBreed.Size = New Size(272, 18)

        ' Short description
        Dim lblDesc As New Label()
        lblDesc.Text = GetPetDescription(petName, breed, species)
        lblDesc.Font = New Font("Segoe UI", 8.25F)
        lblDesc.ForeColor = Color.FromArgb(82, 82, 91)
        lblDesc.Location = New Point(12, 210)
        lblDesc.Size = New Size(272, 42)

        ' View Profile button (guests can view pet details without logging in)
        Dim btnProfile As New Button()
        btnProfile.Text = "View Profile"
        btnProfile.Tag = petId
        btnProfile.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnProfile.BackColor = Color.FromArgb(249, 250, 251)
        btnProfile.ForeColor = Color.FromArgb(39, 39, 42)
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 216)
        btnProfile.Size = New Size(130, 32)
        btnProfile.Location = New Point(12, 272)
        btnProfile.Cursor = Cursors.Hand
        AddHandler btnProfile.Click, AddressOf CardViewProfile_Click

        ' Adopt Me button (requires login)
        Dim btnAdoptPet As New Button()
        btnAdoptPet.Text = "Adopt Me"
        btnAdoptPet.Tag = petId
        btnAdoptPet.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnAdoptPet.BackColor = Color.FromArgb(31, 122, 40)
        btnAdoptPet.ForeColor = Color.White
        btnAdoptPet.FlatStyle = FlatStyle.Flat
        btnAdoptPet.FlatAppearance.BorderSize = 0
        btnAdoptPet.Size = New Size(130, 32)
        btnAdoptPet.Location = New Point(152, 272)
        btnAdoptPet.Cursor = Cursors.Hand
        AddHandler btnAdoptPet.Click, AddressOf CardAdoptButton_Click

        card.Controls.Add(picPet)
        card.Controls.Add(lblName)
        card.Controls.Add(lblAge)
        card.Controls.Add(lblBreed)
        card.Controls.Add(lblDesc)
        card.Controls.Add(btnProfile)
        card.Controls.Add(btnAdoptPet)

        Return card
    End Function

    Private Sub CardViewProfile_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        selectedPetID = btn.Tag.ToString()
        If FormPetDetails.ShowDialog() = DialogResult.Retry Then
            Form2.Show()
            Me.Hide()
            Return
        End If
        loadFeaturedPets()
    End Sub

    Private Sub CardAdoptButton_Click(sender As Object, e As EventArgs)
        If Not IsLoggedIn Then
            MessageBox.Show("Please log in first to adopt a pet.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()
            Return
        End If

        Dim btn As Button = CType(sender, Button)
        selectedPetID = btn.Tag.ToString()
        FormPetDetails.ShowDialog()
        loadFeaturedPets()
    End Sub

    ' =========================================================================
    ' NAVIGATION (SEPARATE FORMS)
    ' =========================================================================
    Private Sub btnLogo_Click(sender As Object, e As EventArgs) Handles btnLogo.Click, btnHome.Click
        loadFeaturedPets()
    End Sub

    Private Sub btnAdopt_Click(sender As Object, e As EventArgs) Handles btnAdopt.Click, btnBrowse.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub lnkViewAll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkViewAll.LinkClicked
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click, btnPost.Click
        If Not IsLoggedIn Then
            MessageBox.Show("Please log in first to add a pet for adoption.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()
            Return
        End If
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click, btnHistory.Click
        If Not IsLoggedIn Then
            MessageBox.Show("Please log in first to view your pet records.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()
            Return
        End If
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        If IsLoggedIn AndAlso currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then
            Form6.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please log in with an Admin account to enter the Admin Panel.", "Admin Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If IsLoggedIn Then
            Dim result As DialogResult = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                IsLoggedIn = False
                currentUser = ""
                currentRole = ""
                UpdateUI()
                Form2.Show()
                Me.Hide()
            End If
        Else
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
