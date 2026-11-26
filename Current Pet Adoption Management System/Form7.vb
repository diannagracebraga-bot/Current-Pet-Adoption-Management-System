Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form7

    Private selectedSpecies As String = "All"
    Private placeholderText As String = "Search by pet name, breed, or city..."
    Private isLoading As Boolean = True

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLoading = True
        cboAge.SelectedIndex = 0
        cboSize.SelectedIndex = 0
        cboGender.SelectedIndex = 0
        txtSearch.Text = placeholderText
        txtSearch.ForeColor = Color.Gray
        isLoading = False

        UpdateSpeciesButtons()
        loadAvailablePets()
    End Sub

    Private Sub Form7_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible AndAlso Not isLoading Then
            loadAvailablePets()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    ' Placeholder behavior for search textbox
    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = placeholderText Then
            txtSearch.Text = ""
            txtSearch.ForeColor = Color.FromArgb(24, 24, 27)
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If txtSearch.Text.Trim() = "" Then
            txtSearch.Text = placeholderText
            txtSearch.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If Not isLoading Then
            loadAvailablePets()
        End If
    End Sub

    ' Species Toggle Buttons
    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        selectedSpecies = "All"
        UpdateSpeciesButtons()
        loadAvailablePets()
    End Sub

    Private Sub btnDog_Click(sender As Object, e As EventArgs) Handles btnDog.Click
        selectedSpecies = "Dog"
        UpdateSpeciesButtons()
        loadAvailablePets()
    End Sub

    Private Sub btnCat_Click(sender As Object, e As EventArgs) Handles btnCat.Click
        selectedSpecies = "Cat"
        UpdateSpeciesButtons()
        loadAvailablePets()
    End Sub

    Private Sub btnSmall_Click(sender As Object, e As EventArgs) Handles btnSmall.Click
        selectedSpecies = "Small Pet"
        UpdateSpeciesButtons()
        loadAvailablePets()
    End Sub

    Sub UpdateSpeciesButtons()
        Dim buttons() As Button = {btnAll, btnDog, btnCat, btnSmall}
        Dim values() As String = {"All", "Dog", "Cat", "Small Pet"}

        For i As Integer = 0 To buttons.Length - 1
            If selectedSpecies = values(i) Then
                buttons(i).BackColor = Color.FromArgb(31, 122, 40)
                buttons(i).ForeColor = Color.White
                buttons(i).FlatAppearance.BorderSize = 0
            Else
                buttons(i).BackColor = Color.White
                buttons(i).ForeColor = Color.FromArgb(39, 39, 42)
                buttons(i).FlatAppearance.BorderSize = 1
                buttons(i).FlatAppearance.BorderColor = Color.FromArgb(212, 212, 216)
            End If
        Next
    End Sub

    Private Sub Filters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAge.SelectedIndexChanged, cboSize.SelectedIndexChanged, cboGender.SelectedIndexChanged
        If Not isLoading Then
            loadAvailablePets()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        isLoading = True
        txtSearch.Text = placeholderText
        txtSearch.ForeColor = Color.Gray
        selectedSpecies = "All"
        cboAge.SelectedIndex = 0
        cboSize.SelectedIndex = 0
        cboGender.SelectedIndex = 0
        isLoading = False

        UpdateSpeciesButtons()
        loadAvailablePets()
    End Sub

    Sub loadAvailablePets()
        flpPets.Controls.Clear()
        Dim dt As New DataTable

        Try
            openCon()
            cmd.Connection = con
            Dim sql As String = "SELECT id, name, species, breed, age, gender, size, vaccinated, temperament, clinginess, owner_city, status FROM pets_tbl WHERE status = 'Approved'"

            If selectedSpecies <> "All" Then
                sql &= " AND species = '" & selectedSpecies & "'"
            End If

            If cboSize.SelectedIndex > 0 Then
                sql &= " AND size = '" & cboSize.Text & "'"
            End If

            If cboGender.SelectedIndex > 0 Then
                sql &= " AND gender = '" & cboGender.Text & "'"
            End If

            Dim keyword As String = txtSearch.Text.Trim()
            If keyword <> "" AndAlso keyword <> placeholderText Then
                sql &= " AND (name LIKE '%" & keyword.Replace("'", "''") & "%' OR breed LIKE '%" & keyword.Replace("'", "''") & "%' OR owner_city LIKE '%" & keyword.Replace("'", "''") & "%')"
            End If

            sql &= " ORDER BY id ASC"
            cmd.CommandText = sql
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error loading pets from database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' Filter by Age Group in code and build cards
        Dim visibleCount As Integer = 0
        For Each row As DataRow In dt.Rows
            If cboAge.SelectedIndex > 0 Then
                Dim rowAgeGroup As String = GetAgeGroup(row("age").ToString())
                If rowAgeGroup <> cboAge.Text Then Continue For
            End If

            Dim card As Panel = CreateAdoptCard(row)
            flpPets.Controls.Add(card)
            visibleCount += 1
        Next

        lblCount.Text = "Showing " & visibleCount & " pet" & If(visibleCount = 1, "", "s")
    End Sub

    Function CreateAdoptCard(row As DataRow) As Panel
        Dim petId As String = row("id").ToString()
        Dim petName As String = row("name").ToString()
        Dim species As String = row("species").ToString()
        Dim breed As String = row("breed").ToString()
        Dim age As String = row("age").ToString()
        Dim gender As String = row("gender").ToString()
        Dim ownerCity As String = row("owner_city").ToString()
        Dim vaccinated As String = row("vaccinated").ToString()

        Dim tempScore As Integer = 3
        Dim clingScore As Integer = 3
        Integer.TryParse(row("temperament").ToString(), tempScore)
        Integer.TryParse(row("clinginess").ToString(), clingScore)

        Dim card As New Panel()
        card.Size = New Size(226, 342)
        card.BackColor = Color.White
        card.BorderStyle = BorderStyle.FixedSingle
        card.Margin = New Padding(0, 0, 14, 14)

        ' Top photo
        Dim picPet As New PictureBox()
        picPet.Size = New Size(224, 145)
        picPet.Location = New Point(0, 0)
        picPet.SizeMode = PictureBoxSizeMode.Normal
        picPet.Image = GetPetPhoto(petName, species, 224, 145)

        ' Available badge (top-left)
        Dim lblAvailBadge As New Label()
        lblAvailBadge.Text = "• Available"
        lblAvailBadge.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblAvailBadge.BackColor = Color.FromArgb(31, 122, 40)
        lblAvailBadge.ForeColor = Color.White
        lblAvailBadge.Size = New Size(68, 20)
        lblAvailBadge.Location = New Point(8, 8)
        lblAvailBadge.TextAlign = ContentAlignment.MiddleCenter
        picPet.Controls.Add(lblAvailBadge)

        ' Species badge (top-right)
        Dim lblSpeciesBadge As New Label()
        lblSpeciesBadge.Text = species
        lblSpeciesBadge.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblSpeciesBadge.BackColor = Color.White
        lblSpeciesBadge.ForeColor = Color.FromArgb(39, 39, 42)
        lblSpeciesBadge.Size = New Size(56, 20)
        lblSpeciesBadge.Location = New Point(160, 8)
        lblSpeciesBadge.TextAlign = ContentAlignment.MiddleCenter
        picPet.Controls.Add(lblSpeciesBadge)

        ' Pet Name
        Dim lblName As New Label()
        lblName.Text = petName
        lblName.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(24, 24, 27)
        lblName.Location = New Point(10, 154)
        lblName.Size = New Size(135, 22)

        ' Age pill on right
        Dim lblAgePill As New Label()
        lblAgePill.Text = age
        lblAgePill.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblAgePill.BackColor = Color.FromArgb(236, 253, 245)
        lblAgePill.ForeColor = Color.FromArgb(4, 120, 87)
        lblAgePill.Size = New Size(64, 20)
        lblAgePill.Location = New Point(150, 155)
        lblAgePill.TextAlign = ContentAlignment.MiddleCenter

        ' Breed & Gender
        Dim lblBreedSex As New Label()
        lblBreedSex.Text = breed & " • " & gender
        lblBreedSex.Font = New Font("Segoe UI", 8.0F)
        lblBreedSex.ForeColor = Color.FromArgb(113, 113, 122)
        lblBreedSex.Location = New Point(10, 180)
        lblBreedSex.Size = New Size(204, 18)

        ' City / Location
        Dim lblCity As New Label()
        lblCity.Text = "📍 " & ownerCity
        lblCity.Font = New Font("Segoe UI", 8.0F)
        lblCity.ForeColor = Color.FromArgb(21, 128, 61)
        lblCity.Location = New Point(10, 202)
        lblCity.Size = New Size(204, 18)

        ' Tags FlowLayoutPanel (up to 3 trait tags)
        Dim flpTags As New FlowLayoutPanel()
        flpTags.Location = New Point(10, 228)
        flpTags.Size = New Size(204, 48)
        flpTags.BackColor = Color.White

        Dim tags As List(Of String) = GetPetTags(petName, vaccinated, tempScore, clingScore)
        For Each t As String In tags
            Dim lblTag As New Label()
            lblTag.Text = t
            lblTag.Font = New Font("Segoe UI", 7.25F)
            lblTag.BackColor = Color.FromArgb(244, 244, 245)
            lblTag.ForeColor = Color.FromArgb(82, 82, 91)
            lblTag.AutoSize = True
            lblTag.Padding = New Padding(4, 2, 4, 2)
            lblTag.Margin = New Padding(0, 0, 4, 4)
            flpTags.Controls.Add(lblTag)
        Next

        ' View Profile button (guests can view pet details without logging in)
        Dim btnProfile As New Button()
        btnProfile.Text = "View Profile"
        btnProfile.Tag = petId
        btnProfile.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnProfile.BackColor = Color.FromArgb(249, 250, 251)
        btnProfile.ForeColor = Color.FromArgb(39, 39, 42)
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 216)
        btnProfile.Size = New Size(96, 32)
        btnProfile.Location = New Point(10, 296)
        btnProfile.Cursor = Cursors.Hand
        AddHandler btnProfile.Click, AddressOf CardViewProfile_Click

        ' Adopt Me button (requires login)
        Dim btnAdoptPet As New Button()
        btnAdoptPet.Text = "🐾 Adopt Me"
        btnAdoptPet.Tag = petId
        btnAdoptPet.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        btnAdoptPet.BackColor = Color.FromArgb(31, 122, 40)
        btnAdoptPet.ForeColor = Color.White
        btnAdoptPet.FlatStyle = FlatStyle.Flat
        btnAdoptPet.FlatAppearance.BorderSize = 0
        btnAdoptPet.Size = New Size(100, 32)
        btnAdoptPet.Location = New Point(114, 296)
        btnAdoptPet.Cursor = Cursors.Hand
        AddHandler btnAdoptPet.Click, AddressOf CardAdoptButton_Click

        card.Controls.Add(picPet)
        card.Controls.Add(lblName)
        card.Controls.Add(lblAgePill)
        card.Controls.Add(lblBreedSex)
        card.Controls.Add(lblCity)
        card.Controls.Add(flpTags)
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
        loadAvailablePets()
    End Sub

    Private Sub CardAdoptButton_Click(sender As Object, e As EventArgs)
        If Not isLoggedIn Then
            MessageBox.Show("Please log in first to adopt a pet.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()
            Return
        End If

        Dim btn As Button = CType(sender, Button)
        selectedPetID = btn.Tag.ToString()
        FormPetDetails.ShowDialog()
        loadAvailablePets()
    End Sub

End Class
