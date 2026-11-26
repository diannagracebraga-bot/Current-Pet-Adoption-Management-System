Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class Form4

    Private selectedImagePath As String = ""

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not isLoggedIn Then
            MessageBox.Show("Please log in first to add a pet for adoption.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()
            Return
        End If
        If Not String.IsNullOrEmpty(currentUser) Then
            txtOwner.Text = currentUser
        End If
    End Sub

    Private Sub Form4_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            If Not isLoggedIn Then
                MessageBox.Show("Please log in first to add a pet for adoption.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form2.Show()
                Me.Hide()
                Return
            End If
            If Not String.IsNullOrEmpty(currentUser) Then
                txtOwner.Text = currentUser
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        ofd.Title = "Select Pet Photo"
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                selectedImagePath = ofd.FileName
                picPet.Image = Image.FromFile(ofd.FileName)
            Catch ex As Exception
                MessageBox.Show("Failed to load image: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim pName As String = txtName.Text.Trim()
        Dim pSpecies As String = cboSpecies.Text.Trim()
        Dim pBreed As String = txtBreed.Text.Trim()
        Dim pAge As String = txtAge.Text.Trim()
        Dim pSize As String = cboSize.Text.Trim()
        Dim pColor As String = txtColor.Text.Trim()

        Dim oName As String = txtOwner.Text.Trim()
        Dim oPhone As String = txtPhone.Text.Trim()
        Dim oCity As String = txtCity.Text.Trim()
        Dim oEmail As String = txtEmail.Text.Trim()

        If pName = "" Or pSpecies = "" Or pAge = "" Then
            MessageBox.Show("Please enter the pet's name, species, and age.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        If oName = "" Or oPhone = "" Then
            MessageBox.Show("Please enter the owner's name and contact number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtOwner.Focus()
            Return
        End If

        Dim pGender As String = "Male"
        If rbFemale.Checked Then
            pGender = "Female"
        End If

        Dim pLivePets As String = "Yes"
        If rbPetsNo.Checked Then
            pLivePets = "No"
        End If

        Dim pVaccinated As String = "Yes"
        If rbVacNo.Checked Then
            pVaccinated = "No"
        End If

        Dim pVacComplete As String = cboVacStatus.Text.Trim()
        Dim pVacKind As String = txtVacKind.Text.Trim()

        Dim pTemp As Integer = 3
        If rbTemp1.Checked Then
            pTemp = 1
        ElseIf rbTemp2.Checked Then
            pTemp = 2
        ElseIf rbTemp3.Checked Then
            pTemp = 3
        ElseIf rbTemp4.Checked Then
            pTemp = 4
        ElseIf rbTemp5.Checked Then
            pTemp = 5
        End If

        Dim pCling As Integer = 3
        If rbCling1.Checked Then
            pCling = 1
        ElseIf rbCling2.Checked Then
            pCling = 2
        ElseIf rbCling3.Checked Then
            pCling = 3
        ElseIf rbCling4.Checked Then
            pCling = 4
        ElseIf rbCling5.Checked Then
            pCling = 5
        End If

        Dim dateAdded As String = DateTime.Now.ToString("yyyy-MM-dd")

        Try
            openCon()
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO pets_tbl (name, species, breed, age, gender, size, color, live_with_pets, vaccinated, vaccine_kind, vaccine_complete, temperament, clinginess, owner_name, owner_phone, owner_city, owner_email, status, date_added) VALUES (" &
                              "'" & pName.Replace("'", "''") & "', " &
                              "'" & pSpecies.Replace("'", "''") & "', " &
                              "'" & pBreed.Replace("'", "''") & "', " &
                              "'" & pAge.Replace("'", "''") & "', " &
                              "'" & pGender & "', " &
                              "'" & pSize & "', " &
                              "'" & pColor.Replace("'", "''") & "', " &
                              "'" & pLivePets & "', " &
                              "'" & pVaccinated & "', " &
                              "'" & pVacKind.Replace("'", "''") & "', " &
                              "'" & pVacComplete & "', " &
                              pTemp & ", " &
                              pCling & ", " &
                              "'" & oName.Replace("'", "''") & "', " &
                              "'" & oPhone.Replace("'", "''") & "', " &
                              "'" & oCity.Replace("'", "''") & "', " &
                              "'" & oEmail.Replace("'", "''") & "', " &
                              "'Pending Review', " &
                              "'" & dateAdded & "')"
            cmd.ExecuteNonQuery()

            ' Save uploaded photo if selected
            If selectedImagePath <> "" AndAlso File.Exists(selectedImagePath) Then
                Dim imgFolder As String = Path.Combine(Application.StartupPath, "images")
                If Not Directory.Exists(imgFolder) Then
                    Directory.CreateDirectory(imgFolder)
                End If
                Dim destPath As String = Path.Combine(imgFolder, pName.ToLower().Trim() & ".jpg")
                File.Copy(selectedImagePath, destPath, True)
            End If

            MessageBox.Show("Pet listing submitted successfully! Your submission is now in 'Pending Review' status.", "Listing Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form5.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error saving pet to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

End Class
