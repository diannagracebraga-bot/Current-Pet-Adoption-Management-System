Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form5

    Private isLoading As Boolean = True

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isLoading = True
        If Not isLoggedIn Then
            MessageBox.Show("Please log in first to view your pet records.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()
            isLoading = False
            Return
        End If
        loadMyPets()
        isLoading = False
    End Sub

    Private Sub Form5_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible AndAlso Not isLoading Then
            If Not isLoggedIn Then
                MessageBox.Show("Please log in first to view your pet records.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form2.Show()
                Me.Hide()
                Return
            End If
            loadMyPets()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Sub loadMyPets()
        flpAdoptions.Controls.Clear()
        Dim dt As New DataTable

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT id, name, species, breed, age, gender, size, vaccinated, owner_name, owner_city, status, date_added FROM pets_tbl ORDER BY id ASC"
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Error loading records from database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' Build horizontal row cards
        For Each row As DataRow In dt.Rows
            Dim card As Panel = CreateAdoptionRowCard(row)
            flpAdoptions.Controls.Add(card)
        Next
    End Sub

    Function CreateAdoptionRowCard(row As DataRow) As Panel
        Dim petId As String = row("id").ToString()
        Dim petName As String = row("name").ToString()
        Dim species As String = row("species").ToString()
        Dim breed As String = row("breed").ToString()
        Dim sizeText As String = row("size").ToString()
        Dim vaccinated As String = row("vaccinated").ToString().ToLower()
        Dim ownerName As String = row("owner_name").ToString()
        Dim ownerCity As String = row("owner_city").ToString()
        Dim statusText As String = row("status").ToString()
        Dim dateAdded As String = row("date_added").ToString()

        Dim card As New Panel()
        card.Size = New Size(760, 108)
        card.BackColor = Color.White
        card.BorderStyle = BorderStyle.FixedSingle
        card.Margin = New Padding(0, 0, 0, 14)

        ' Left thumbnail photo
        Dim picThumb As New PictureBox()
        picThumb.Size = New Size(82, 82)
        picThumb.Location = New Point(14, 12)
        picThumb.SizeMode = PictureBoxSizeMode.Normal
        picThumb.Image = GetPetPhoto(petName, species, 82, 82)

        ' Pet Title: Milo (Golden Retriever Mix)
        Dim lblNameBreed As New Label()
        lblNameBreed.Text = petName & " (" & breed & ")"
        lblNameBreed.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        lblNameBreed.ForeColor = Color.FromArgb(24, 24, 27)
        lblNameBreed.Location = New Point(112, 14)
        lblNameBreed.Size = New Size(380, 24)

        ' Registered by
        Dim lblOwner As New Label()
        lblOwner.Text = "Registered by: " & ownerName & " • " & ownerCity
        lblOwner.Font = New Font("Segoe UI", 8.5F)
        lblOwner.ForeColor = Color.FromArgb(113, 113, 122)
        lblOwner.Location = New Point(112, 40)
        lblOwner.Size = New Size(380, 18)

        ' 3 small gray pill labels
        Dim lblVacPill As New Label()
        lblVacPill.Text = "Vaccinated: " & vaccinated
        lblVacPill.Font = New Font("Segoe UI", 8.0F)
        lblVacPill.BackColor = Color.FromArgb(244, 244, 245)
        lblVacPill.ForeColor = Color.FromArgb(82, 82, 91)
        lblVacPill.AutoSize = True
        lblVacPill.Padding = New Padding(6, 3, 6, 3)
        lblVacPill.Location = New Point(112, 68)

        Dim lblSizePill As New Label()
        lblSizePill.Text = "Size: " & sizeText
        lblSizePill.Font = New Font("Segoe UI", 8.0F)
        lblSizePill.BackColor = Color.FromArgb(244, 244, 245)
        lblSizePill.ForeColor = Color.FromArgb(82, 82, 91)
        lblSizePill.AutoSize = True
        lblSizePill.Padding = New Padding(6, 3, 6, 3)
        lblSizePill.Location = New Point(218, 68)

        Dim lblDatePill As New Label()
        lblDatePill.Text = "Date: " & dateAdded
        lblDatePill.Font = New Font("Segoe UI", 8.0F)
        lblDatePill.BackColor = Color.FromArgb(244, 244, 245)
        lblDatePill.ForeColor = Color.FromArgb(82, 82, 91)
        lblDatePill.AutoSize = True
        lblDatePill.Padding = New Padding(6, 3, 6, 3)
        lblDatePill.Location = New Point(304, 68)

        ' Status Pill
        Dim lblStatus As New Label()
        lblStatus.Size = New Size(132, 28)
        lblStatus.Location = New Point(518, 39)
        lblStatus.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        lblStatus.TextAlign = ContentAlignment.MiddleCenter

        If statusText = "Approved" Then
            lblStatus.Text = "Approved & Listed"
            lblStatus.BackColor = Color.FromArgb(209, 250, 229)
            lblStatus.ForeColor = Color.FromArgb(6, 95, 70)
        ElseIf statusText = "Pending Adoption" Then
            lblStatus.Text = "Pending Adoption"
            lblStatus.BackColor = Color.FromArgb(219, 234, 254)
            lblStatus.ForeColor = Color.FromArgb(30, 64, 175)
        ElseIf statusText = "Adopted" Then
            lblStatus.Text = "Adopted"
            lblStatus.BackColor = Color.FromArgb(220, 252, 231)
            lblStatus.ForeColor = Color.FromArgb(21, 128, 61)
        ElseIf statusText = "Pending Review" Then
            lblStatus.Text = "Pending Review"
            lblStatus.BackColor = Color.FromArgb(254, 243, 199)
            lblStatus.ForeColor = Color.FromArgb(146, 64, 14)
        Else
            lblStatus.Text = statusText
            lblStatus.BackColor = Color.FromArgb(254, 226, 226)
            lblStatus.ForeColor = Color.FromArgb(153, 27, 27)
        End If

        ' Details Button (top right)
        Dim btnDetails As New Button()
        btnDetails.Text = "Details"
        btnDetails.Tag = petId
        btnDetails.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnDetails.BackColor = Color.FromArgb(249, 250, 251)
        btnDetails.ForeColor = Color.FromArgb(39, 39, 42)
        btnDetails.FlatStyle = FlatStyle.Flat
        btnDetails.FlatAppearance.BorderColor = Color.FromArgb(212, 212, 216)
        btnDetails.Size = New Size(76, 30)
        btnDetails.Location = New Point(666, 18)
        btnDetails.Cursor = Cursors.Hand
        AddHandler btnDetails.Click, AddressOf btnRowDetails_Click

        ' Cancel Button (bottom right)
        Dim btnCancel As New Button()
        btnCancel.Text = "Cancel"
        btnCancel.Tag = petId & "|" & petName
        btnCancel.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold)
        btnCancel.BackColor = Color.FromArgb(255, 241, 242)
        btnCancel.ForeColor = Color.FromArgb(190, 18, 60)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(254, 205, 211)
        btnCancel.Size = New Size(76, 30)
        btnCancel.Location = New Point(666, 56)
        btnCancel.Cursor = Cursors.Hand
        AddHandler btnCancel.Click, AddressOf btnRowCancel_Click

        card.Controls.Add(picThumb)
        card.Controls.Add(lblNameBreed)
        card.Controls.Add(lblOwner)
        card.Controls.Add(lblVacPill)
        card.Controls.Add(lblSizePill)
        card.Controls.Add(lblDatePill)
        card.Controls.Add(lblStatus)
        card.Controls.Add(btnDetails)
        card.Controls.Add(btnCancel)

        Return card
    End Function

    Private Sub btnRowDetails_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        selectedPetID = btn.Tag.ToString()
        FormPetDetails.ShowDialog()
        loadMyPets()
    End Sub

    Private Sub btnRowCancel_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim parts() As String = btn.Tag.ToString().Split("|"c)
        Dim petId As String = parts(0)
        Dim petName As String = If(parts.Length > 1, parts(1), "this pet")

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel and delete the listing for '" & petName & "' (ID #" & petId & ")?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                openCon()
                cmd.Connection = con
                cmd.CommandText = "DELETE FROM pets_tbl WHERE id = '" & petId & "'"
                cmd.ExecuteNonQuery()

                MessageBox.Show("Pet listing deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadMyPets()
            Catch ex As Exception
                MessageBox.Show("Error deleting pet: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

End Class
